using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using Hl7.Fhir.Utility;
using System.Threading.Tasks;
using System.Linq;
using Hl7.Fhir.Support;
using System.IO;
using Hl7.Fhir.WebApi.DemoEntityModels;
using static Hl7.Fhir.WebApi.DemoSearchIndexer;

namespace Hl7.Fhir.DemoFileSystemFhirServer
{
    public class SqliteResourceService<TSP> : Hl7.Fhir.WebApi.IFhirResourceServiceR4<TSP>
        where TSP : class
    {
        public ModelBaseInputs<TSP> RequestDetails { get; set; }

        public string ResourceName { get; set; }
        public string ResourceDirectory { get; set; }
        public DemoSearchIndexer Indexer { get; set; }
        internal FhirDbContext db { get; set; }

        public async Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince)
        {
            RequestDetails.SetResponseHeaderValue("test", "wild-turkey-create");

            // and update the search index
            await Indexer.StoreResource(db, resource);
            resource.SetAnnotation<CreateOrUpate>(CreateOrUpate.Create);
            return resource;
        }

        public async Task<string> Delete(string id, string ifMatch)
        {
            int version = await Indexer.DeleteResource(db, ResourceName, id);
            if (version == -1)
            {
                throw new FhirServerException(System.Net.HttpStatusCode.NotFound, "Resource ID not found");
            }
            return $"{ResourceName}/{id}/_history/{version}";
        }

        public async Task<Resource> Get(string resourceId, string VersionId, SummaryType summary)
        {
            RequestDetails.SetResponseHeaderValue("test", "wild-turkey-get");

            var result = await Indexer.Get(db, ResourceName, resourceId, VersionId);
            if (result == null)
                throw new FhirServerException(System.Net.HttpStatusCode.NotFound, "Resource ID/Version not found");
            if (result.IsDeleted)
                throw new FhirServerException(System.Net.HttpStatusCode.Gone, $"{ResourceName}/{resourceId} has been deleted");
            return result.Resource;
        }

        public Task<CapabilityStatement.ResourceComponent> GetRestResourceComponent()
        {
            var rt = new Hl7.Fhir.Model.CapabilityStatement.ResourceComponent();
            rt.TypeElement = new Code<ResourceType>() { ObjectValue = ResourceName };
            rt.ReadHistory = true;
            rt.UpdateCreate = true;
            rt.Versioning = CapabilityStatement.ResourceVersionPolicy.Versioned;
            rt.ConditionalCreate = false;
            rt.ConditionalUpdate = false;
            rt.ConditionalDelete = CapabilityStatement.ConditionalDeleteStatus.NotSupported;

            rt.Interaction = new List<CapabilityStatement.ResourceInteractionComponent>()
            {
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Create },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Read },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Update },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Delete },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.SearchType },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Vread },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.HistoryInstance },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.HistoryType },
            };

            return System.Threading.Tasks.Task.FromResult(rt);
        }

        public async Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var resources = await Indexer.InstanceHistory(db, ResourceName, ResourceId, since, Till, Count);

            foreach (SearchResourceResult item in resources)
            {
                result.Entry.Add(new Bundle.EntryComponent()
                {
                    Resource = item.Resource,
                    FullUrl = ResourceIdentity.Build(RequestDetails.BaseUri, item.Resource.TypeName, item.Resource.Id, item.Resource.Meta.VersionId).OriginalString,
                    Request = item.Request
                });
            }
            result.Total = result.Entry.Count;

            // also need to set the page links

            return result;
        }

        public Task<Resource> PerformOperation(string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "count-em")
            {
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"{ResourceName} resource instances: {Directory.EnumerateFiles(ResourceDirectory, $"{ResourceName}.*.xml").Count()}")
                });
                return System.Threading.Tasks.Task.FromResult<Resource>(result);
            }
            if (operation == "preferred-id")
            {
                // Test operation that isn't really anything just for a specific unit test
                NamingSystem ns = new NamingSystem() { Id = operationParameters.GetString("id") };
                return System.Threading.Tasks.Task.FromResult<Resource>(ns);
            }

            throw new NotImplementedException();
        }

        public Task<Resource> PerformOperation(string id, string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "send-activation-code")
            {
                // Test operation that isn't really anything just for a specific unit test
                OperationOutcome outcome = new OperationOutcome() { Id = operationParameters?.GetString("id") };
                outcome.Issue.Add(new OperationOutcome.IssueComponent
                {
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Code = OperationOutcome.IssueType.Informational,
                    Details = new CodeableConcept() { Text = $"Send an activation code to {ResourceName}/{id}" }
                });
                return System.Threading.Tasks.Task.FromResult<Resource>(outcome);
            }
            throw new NotImplementedException();
        }

        public async Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary)
        {
            // This is a Brute force search implementation - just scan all the files
            Bundle resource = new Bundle();
            if (resource.Meta == null)
                resource.Meta = new Meta();
            resource.Meta.LastUpdated = DateTime.Now;
            resource.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToFhirId()).OriginalString;
            resource.Type = Bundle.BundleType.Searchset;
            resource.ResourceBase = RequestDetails.BaseUri;

            Dictionary<string, Resource> entries = new Dictionary<string, Resource>();
            var parser = new Hl7.Fhir.Serialization.FhirXmlParser();
            IEnumerable<long> filenames = null;
            var idparam = parameters.Where(kp => kp.Key == "_id");
            List<string> usedParameters = new List<string>();
            if (idparam.Any())
            {
                // Even though this is a trashy demo app, don't permit walking the file system
                usedParameters.Add("_id");
            }
            foreach (var p in parameters)
            {
                var r = await Indexer.Search(db, ResourceName, p.Key, p.Value);
                if (r != null)
                {
                    if (filenames == null)
                        filenames = r;
                    else
                        filenames = filenames.Intersect(r);
                    usedParameters.Add(p.Key);
                }
            }
            var searchResources = db.Resource_Header.AsQueryable();
            if (filenames?.Any() == true)
                searchResources = searchResources.Where(r => filenames.Contains(r.internal_id));
            else
                searchResources = searchResources.Where(r => r.ResourceType == ResourceName);

            foreach (var resourceItem in searchResources)
            {
                var resourceEntry = parser.Parse<Resource>(resourceItem.contentXML);
                entries.Add(resourceEntry.Id, resourceEntry);
            }
            foreach (var item in entries.Values)
            {
                resource.AddResourceEntry(item,
                    ResourceIdentity.Build(RequestDetails.BaseUri,
                        item.TypeName,
                        item.Id,
                        item.Meta?.VersionId).OriginalString).Search = new Bundle.SearchComponent()
                        {
                            Mode = Bundle.SearchEntryMode.Match
                        };
            }
            resource.Total = resource.Entry.Count(e => e.Search.Mode == Bundle.SearchEntryMode.Match);
            if (Count.HasValue)
                resource.Entry = resource.Entry.Take(Count.Value).ToList();
            if (parameters.Count(p => p.Key != "_id" && !usedParameters.Contains(p.Key)) > 0)
            {
                var outcome = new OperationOutcome();
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Warning,
                    Code = OperationOutcome.IssueType.NotSupported,
                    Details = new CodeableConcept() { Text = $"Unsupported search parameters used: {String.Join("&", parameters.Where(p => p.Key != "_id" && !usedParameters.Contains(p.Key)).Select(k => k.Key + "=" + k.Value))}" }
                });
                resource.AddResourceEntry(outcome,
                    new Uri("urn:uuid:" + Guid.NewGuid().ToFhirId()).OriginalString).Search = new Bundle.SearchComponent()
                    {
                        Mode = Bundle.SearchEntryMode.Outcome
                    };
            }

            return resource;
        }

        public async Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var resources = await Indexer.TypeHistory(db, ResourceName, since, Till, Count);

            foreach (SearchResourceResult item in resources)
            {
                result.Entry.Add(new Bundle.EntryComponent()
                {
                    Resource = item.Resource,
                    FullUrl = ResourceIdentity.Build(RequestDetails.BaseUri, item.Resource.TypeName, item.Resource.Id, item.Resource.Meta.VersionId).OriginalString,
                    Request = item.Request
                });
            }
            result.Total = result.Entry.Count;

            // also need to set the page links

            return result;
        }
    }
}
