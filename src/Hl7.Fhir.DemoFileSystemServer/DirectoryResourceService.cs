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

namespace Hl7.Fhir.DemoFileSystemFhirServer
{
    public class DirectoryResourceService<TSP> : Hl7.Fhir.WebApi.IFhirResourceServiceR4<TSP>
        where TSP : class
    {
        public ModelBaseInputs<TSP> RequestDetails { get; set; }

        public string ResourceName { get; set; }
        public string ResourceDirectory { get; set; }
        public SearchIndexer Indexer { get; set; }


        public Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince)
        {
            RequestDetails.SetResponseHeaderValue("test", "wild-turkey-create");

            if (String.IsNullOrEmpty(resource.Id))
                resource.Id = Guid.NewGuid().ToFhirId();
            if (resource.Meta == null)
                resource.Meta = new Meta();
            resource.Meta.LastUpdated = DateTime.Now;

            // Get the latest version number
            int versionNumber = 1; // default will be 1
            foreach (var file in Directory.EnumerateFiles(ResourceDirectory, $"{resource.TypeName}.{resource.Id}.*.xml"))
            {
                string versionSection = file.Substring(0, file.LastIndexOf('.'));
                versionSection = versionSection.Substring(versionSection.LastIndexOf('.') + 1);
                int verFile;
                if (int.TryParse(versionSection, out verFile))
                {
                    if (verFile >= versionNumber)
                        versionNumber = verFile+1;
                }
            }
            resource.Meta.VersionId = versionNumber.ToString();
            string path = Path.Combine(ResourceDirectory, $"{resource.TypeName}.{resource.Id}.{resource.Meta.VersionId}.xml");
            File.WriteAllText(
                path,
                new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(resource));
            path = Path.Combine(ResourceDirectory, $"{resource.TypeName}.{resource.Id}..xml"); // the current version of the resource
            File.WriteAllText(
                path,
                new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(resource));
            resource.SetAnnotation<CreateOrUpate>(CreateOrUpate.Create);
            // and update the search index
            Indexer.ScanResource(resource, Path.Combine(ResourceDirectory, $"{resource.TypeName}.{resource.Id}..xml"));
            return System.Threading.Tasks.Task.FromResult(resource);
        }

        public Task<string> Delete(string id, string ifMatch)
        {
            string path = Path.Combine(ResourceDirectory, $"{this.ResourceName}.{id}..xml");
            if (File.Exists(path))
                File.Delete(path);
            return System.Threading.Tasks.Task.FromResult<string>(null);
        }

        public Task<Resource> Get(string resourceId, string VersionId, SummaryType summary)
        {
            RequestDetails.SetResponseHeaderValue("test", "wild-turkey-get");

            string path = Path.Combine(ResourceDirectory, $"{this.ResourceName}.{resourceId}.{VersionId}.xml");
            if (File.Exists(path))
                return System.Threading.Tasks.Task.FromResult(new Fhir.Serialization.FhirXmlParser().Parse<Resource>(File.ReadAllText(path)));
            throw new FhirServerException(System.Net.HttpStatusCode.Gone, "It might have been deleted!");
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
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Vread },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.HistoryInstance },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.HistoryType },
            };

            return System.Threading.Tasks.Task.FromResult(rt);
        }

        public Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = Directory.EnumerateFiles(ResourceDirectory, $"{ResourceName}.{ResourceId}.?*.xml");
            foreach (var filename in files)
            {
                if (filename.EndsWith("..xml"))
                    continue;
                var resource = parser.Parse<Resource>(File.ReadAllText(filename));
                result.AddResourceEntry(resource,
                    ResourceIdentity.Build(RequestDetails.BaseUri,
                        resource.TypeName,
                        resource.Id,
                        resource.Meta.VersionId).OriginalString);
            }
            result.Total = result.Entry.Count;
            result.Entry.Sort((x, y) => { return y.Resource.Meta.VersionId.CompareTo(x.Resource.Meta.VersionId); });

            // also need to set the page links

            return System.Threading.Tasks.Task.FromResult(result);
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

        public Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary, string sortby)
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
            string filter = $"{ResourceName}.*..xml";
            IEnumerable<string> filenames = null;
            var idparam = parameters.Where(kp => kp.Key == "_id");
            List<string> usedParameters = new List<string>();
            if (idparam.Any())
            {
                // Even though this is a trashy demo app, don't permit walking the file system
                filter = $"{ResourceName}.{idparam.First().Value.Replace("/", "")}.*.xml";
                filenames = Directory.EnumerateFiles(ResourceDirectory, filter);
                usedParameters.Add("_id");
            }
            foreach (var p in parameters)
            {
                var r = Indexer.Search(ResourceName, p.Key, p.Value);
                if (r != null)
                {
                    if (filenames == null)
                        filenames = r;
                    else
                        filenames = filenames.Intersect(r);
                    usedParameters.Add(p.Key);
                }
            }
            if (filenames == null)
                filenames = Directory.EnumerateFiles(ResourceDirectory, filter);
            foreach (var filename in filenames)
            {
                if (!filename.EndsWith("..xml")) // skip over the version history items
                    continue;
                if (File.Exists(filename))
                {
                    using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
                        var resourceEntry = parser.Parse<Resource>(xr);
                        if (entries.ContainsKey(resourceEntry.Id))
                        {
                            if (String.Compare(entries[resourceEntry.Id].Meta.VersionId, resourceEntry.Meta.VersionId) < 0)
                                entries[resource.Id] = resourceEntry;
                        }
                        else
                            entries.Add(resourceEntry.Id, resourceEntry);
                    }
                }
                else
                {
                    System.Diagnostics.Trace.WriteLine($"Search data out of date for file likely deleted file: {filename}");
                }
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

            // Add in the navigation links
            resource.SelfLink = RequestDetails.RequestUri;

            return System.Threading.Tasks.Task.FromResult(resource);
        }

        public Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = Directory.EnumerateFiles(ResourceDirectory, $"{ResourceName}.*.*.xml");
            foreach (var filename in files)
            {
                if (filename.EndsWith("..xml")) // this is the current version file, the version number file will have the real data
                    continue;
                var resource = parser.Parse<Resource>(File.ReadAllText(filename));
                result.AddResourceEntry(resource,
                    ResourceIdentity.Build(RequestDetails.BaseUri,
                        resource.TypeName,
                        resource.Id,
                        resource.Meta.VersionId).OriginalString);
            }
            result.Total = result.Entry.Count;
            result.Entry.Sort((x, y) => { return y.Resource.Meta.LastUpdated.Value.CompareTo(x.Resource.Meta.LastUpdated.Value); });

            // also need to set the page links

            return System.Threading.Tasks.Task.FromResult(result);
        }
    }
}
