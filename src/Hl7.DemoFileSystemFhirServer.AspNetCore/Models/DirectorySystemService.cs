using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using System.Linq;
using System.Net;
using Hl7.Fhir.Utility;

namespace Hl7.DemoFileSystemFhirServer
{
    /// <summary>
    /// This is an implementation of the FHIR Service that sources all its files in the file system
    /// </summary>
    public class DirectorySystemService : Hl7.Fhir.WebApi.IFhirSystemServiceR4<IServiceProvider>
    {
        public DirectorySystemService()
        {
            InitializeIndexes();
        }

        /// <summary>
        /// The File system directory that will be scanned for the storage of FHIR resources
        /// </summary>
        public static string Directory { get; set; }

        public void InitializeIndexes()
        {
        }

        public System.Threading.Tasks.Task<CapabilityStatement> GetConformance(ModelBaseInputs<IServiceProvider> request, SummaryType summary)
        {
            Hl7.Fhir.Model.CapabilityStatement con = new Hl7.Fhir.Model.CapabilityStatement();
            con.Url = request.BaseUri + "metadata";
            con.Description = new Markdown("Demonstration Directory based FHIR server (aspnetcore)");
            con.DateElement = new Hl7.Fhir.Model.FhirDateTime("2017-04-30");
            con.Version = "1.0.0.0";
            con.Name = "demoCapStmt";
            con.Experimental = true;
            con.Status = PublicationStatus.Active;
            con.FhirVersion = FHIRVersion.N4_0_0;
            // con.AcceptUnknown = CapabilityStatement.UnknownContentCode.Extensions;
            con.Format = new string[] { "xml", "json" };
            con.Kind = CapabilityStatementKind.Instance;
            con.Meta = new Meta();
            con.Meta.LastUpdatedElement = Instant.Now();

            con.Rest = new List<Hl7.Fhir.Model.CapabilityStatement.RestComponent>
            {
                new Hl7.Fhir.Model.CapabilityStatement.RestComponent()
                {
                    Operation = new List<Hl7.Fhir.Model.CapabilityStatement.OperationComponent>()
                }
            };
            con.Rest[0].Mode = CapabilityStatement.RestfulCapabilityMode.Server;
            con.Rest[0].Resource = new List<Hl7.Fhir.Model.CapabilityStatement.ResourceComponent>();

            //foreach (var model in ModelFactory.GetAllModels(GetInputs(buri)))
            //{
            //    con.Rest[0].Resource.Add(model.GetRestResourceComponent());
            //}

            return System.Threading.Tasks.Task.FromResult(con);
        }

        public IFhirResourceServiceR4<IServiceProvider> GetResourceService(ModelBaseInputs<IServiceProvider> request, string resourceName)
        {
            return new DirectoryResourceService() { RequestDetails = request, ResourceName = resourceName };
        }

        public System.Threading.Tasks.Task<Resource> PerformOperation(ModelBaseInputs<IServiceProvider> request, string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "count-em")
            {
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"All resource type instances: {System.IO.Directory.EnumerateFiles(DirectorySystemService.Directory, $"*.xml").Count()}")
                });
                if (request.Headers.Any())
                {
                    string headers = String.Join("\r\n", request.Headers.Select(h => $"{h.Key}: {String.Join(",", h.Value)}"));
                    result.Issue.Add(new OperationOutcome.IssueComponent()
                    {
                        Code = OperationOutcome.IssueType.Informational,
                        Severity = OperationOutcome.IssueSeverity.Information,
                        Details = new CodeableConcept(null, null, headers)
                    });
                }
                return System.Threading.Tasks.Task.FromResult<Resource>(result);
            }

            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task<Bundle> ProcessBatch(ModelBaseInputs<IServiceProvider> request, Bundle batch)
        {
            Bundle outcome = new Bundle();
            outcome.Type = Bundle.BundleType.TransactionResponse;
            outcome.Entry = new List<Bundle.EntryComponent>();
            outcome.ResourceBase = request.BaseUri;
            if (batch.Entry != null)
            {
                // mapping from batch identities to local resource identities (in our DB)
                Dictionary<string, string> mappedResourceIds = new Dictionary<string, string>();

                // http://hl7.org/fhir/http.html#transaction
                // Perform the validation of the batch first

                // DELETE
                foreach (var entry in batch.Entry.Where(e => e.Request != null && e.Request.Method == Bundle.HTTPVerb.DELETE))
                {
                    await ProcessBatchEntry(request, outcome, mappedResourceIds, entry);
                }
                // POST
                foreach (var entry in batch.Entry.Where(e => e.Request != null && e.Request.Method == Bundle.HTTPVerb.POST))
                {
                    await ProcessBatchEntry(request, outcome, mappedResourceIds, entry);
                }
                // PUT
                foreach (var entry in batch.Entry.Where(e => e.Request != null && e.Request.Method == Bundle.HTTPVerb.PUT))
                {
                    await ProcessBatchEntry(request, outcome, mappedResourceIds, entry);
                }
                // GET
                foreach (var entry in batch.Entry.Where(e => e.Request != null && e.Request.Method == Bundle.HTTPVerb.GET))
                {
                    await ProcessBatchEntry(request, outcome, mappedResourceIds, entry);
                }

                // Requestless bundle handling
                foreach (var entry in batch.Entry.Where(e => e.Request == null))
                {
                    await ProcessBatchEntry(request, outcome, mappedResourceIds, entry);
                }

            }
            outcome.Total = outcome.Entry.Count;
            return outcome;
        }

        private async System.Threading.Tasks.Task ProcessBatchEntry(ModelBaseInputs<IServiceProvider> request, Bundle outcome, Dictionary<string, string> mappedResourceIds, Bundle.EntryComponent entry)
        {
            if (entry.Request == null)
            {
                entry.Request = new Bundle.RequestComponent();
                if (!string.IsNullOrEmpty(entry.Resource.Id))
                {
                    entry.Request.Method = Bundle.HTTPVerb.PUT;
                    entry.Request.Url = entry.Resource.ResourceType + "/" + entry.Resource.Id;
                }
                else
                    entry.Request.Method = Bundle.HTTPVerb.POST;
            }
            if (entry.Request != null)
            {
                Bundle.EntryComponent itemResult = new Bundle.EntryComponent();
                itemResult.FullUrl = entry.FullUrl;
                itemResult.Request = entry.Request;
                outcome.Entry.Add(itemResult);
                string resourceType = null;
                if (entry.Resource != null)
                {
                    resourceType = entry.Resource.ResourceType.ToString();
                }
                else if (!string.IsNullOrEmpty(entry.Request.Url))
                {
                    string url = entry.Request.Url;
                    if (url.Contains("?"))
                    {
                        resourceType = url.Substring(0, url.IndexOf("?"));
                        if (resourceType.Contains("/"))
                            resourceType = resourceType.Substring(resourceType.IndexOf("/") + 1);
                        FHIRAllTypes rt;
                        if (!Enum.TryParse<FHIRAllTypes>(resourceType, out rt))
                            resourceType = null;
                    }
                    else
                    {
                        Hl7.Fhir.Rest.ResourceIdentity ri = new Hl7.Fhir.Rest.ResourceIdentity(url);
                        resourceType = ri.ResourceType;
                    }
                }
                if (string.IsNullOrEmpty(resourceType))
                {
                    itemResult.Response = new Bundle.ResponseComponent();
                    itemResult.Response.Status = HttpStatusCode.BadRequest.ToString();
                    OperationOutcome outcomeItem = new OperationOutcome();
                    outcomeItem.Issue.Add(new OperationOutcome.IssueComponent()
                    {
                        Severity = OperationOutcome.IssueSeverity.Error,
                        Details = new CodeableConcept(null, null, "Resource Type [" + resourceType + "] was not found")
                    });
                    itemResult.Resource = outcomeItem;
                    return;
                }
                System.Diagnostics.Trace.WriteLine(String.Format("Transaction ({1}) url: {0}", entry.Request.Url, resourceType));
                var model = GetResourceService(request, resourceType);
                if (model != null)
                {
                    if (entry.Request.Method == Bundle.HTTPVerb.PUT || entry.Request.Method == Bundle.HTTPVerb.POST)
                    {
                        itemResult.Response = new Bundle.ResponseComponent();
                        // itemResult.TransactionResponse.TypeName = entry.Transaction.TypeName;
                        try
                        {
                            string oldId = resourceType + "/" + entry.Resource.Id;
                            if (entry.Request.Method == Bundle.HTTPVerb.POST)
                                entry.Resource.Id = null;

                            // Replace any of the internal reference IDs with ones
                            // that have been remapped
                            var ids = AllReferences(entry.Resource);
                            foreach (var resRef in ids.Where(rr => !String.IsNullOrEmpty(rr.Reference)))
                            {
                                // TODO: If this is an identifier reference, then we must resolve the reference

                                // Otherwise these are just normal references
                                if (!string.IsNullOrEmpty(resRef.Reference))
                                {
                                    ResourceIdentity riEntity = new ResourceIdentity(resRef.Reference);
                                    if (mappedResourceIds.ContainsKey(resRef.Reference))
                                    {
                                        resRef.Reference = mappedResourceIds[resRef.Reference];
                                    }
                                }
                            }

                            // Store the changes
                            Resource r = await model.Create(entry.Resource, entry.Request?.IfMatch, entry.Request?.IfNoneExist, entry.Request?.IfModifiedSince);
                            if (!string.IsNullOrEmpty(oldId) && oldId != resourceType + "/" && !mappedResourceIds.ContainsKey(oldId))
                                mappedResourceIds.Add(oldId, resourceType + "/" + r.Id);

                            itemResult.Resource = r;
                            if (r.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                                itemResult.Response.Status = ((int)HttpStatusCode.Created).ToString();
                            else
                                itemResult.Response.Status = ((int)HttpStatusCode.OK).ToString();

                            // Also include the Location and ETag values here
                            itemResult.Response.Location = r.ResourceIdentity().OriginalString;
                            itemResult.Response.Etag = String.Format("W/\"{0}\"", r.Meta.VersionId);
                        }
                        catch (FhirServerException ex)
                        {
                            itemResult.Response.Status = ((int)ex.StatusCode).ToString();
                            itemResult.Resource = ex.Outcome;
                        }
                        catch (Hl7.Fhir.Rest.FhirOperationException ex)
                        {
                            itemResult.Response.Status = ((int)ex.Status).ToString();
                            itemResult.Resource = ex.Outcome;
                        }
                    }
                    else if (entry.Request.Method == Bundle.HTTPVerb.DELETE)
                    {
                        itemResult.Response = new Bundle.ResponseComponent();
                        try
                        {
                            ResourceIdentity ri = new ResourceIdentity(entry.Request.Url);
                            if (mappedResourceIds.ContainsKey(resourceType + "/" + ri.Id))
                            {
                                // This is an error transaction
                            }
                            string deletedIdentity = await model.Delete(ri.Id, entry.Request.IfMatch);

                            itemResult.Response.Status = ((int)HttpStatusCode.NoContent).ToString();

                            // Also include the Location and ETag values here
                            if (!string.IsNullOrEmpty(deletedIdentity))
                            {
                                ResourceIdentity riDelete = new ResourceIdentity(deletedIdentity);
                                itemResult.Response.Etag = String.Format("W/\"{0}\"", riDelete.VersionId);
                            }
                        }
                        catch (Hl7.Fhir.Rest.FhirOperationException ex)
                        {
                            itemResult.Response.Status = ex.Status.ToString();
                            itemResult.Resource = ex.Outcome;
                        }
                        catch (FhirServerException ex)
                        {
                            itemResult.Response.Status = ((int)ex.StatusCode).ToString();
                            itemResult.Resource = ex.Outcome;
                        }
                    }
                    else
                    {
                        // implement the GET searching
                        itemResult.Response = new Bundle.ResponseComponent();
                        var query = new Uri(entry.Request.Url, UriKind.RelativeOrAbsolute);
                        if (query.IsAbsoluteUri)
                        {
                            itemResult.Response.Status = HttpStatusCode.MethodNotAllowed.ToString(); // "Not Supported: " + entry.Transaction.Url;
                        }
                        else if (entry.Request.Url.StartsWith($"{resourceType}?"))
                        {
                            var parameters = System.Web.HttpUtility.ParseQueryString(entry.Request.Url).TupledParameters(false);
                            int pagesize;
                            string pageSizeString = parameters.Where(k => k.Key == FhirParameter.COUNT).FirstOrDefault().Value;
                            if (string.IsNullOrEmpty(pageSizeString) || !int.TryParse(pageSizeString, out pagesize))
                                pagesize = Const.DEFAULT_PAGE_SIZE;
                            itemResult.Resource = await model.Search(parameters, pagesize, SummaryType.False);
                            itemResult.Response.Status = ((int)HttpStatusCode.OK).ToString();
                        }
                        else
                        {
                            // this is a regular get, so check it for resource Identity
                            ResourceIdentity ri = new ResourceIdentity(query);
                            itemResult.Resource = await model.Get(ri.Id, ri.VersionId, SummaryType.False);

                            itemResult.Response.Status = ((int)HttpStatusCode.OK).ToString();

                            // Also include the Location and ETag values here
                            itemResult.Response.Location = itemResult.Resource.ResourceIdentity().OriginalString;
                            itemResult.Response.Etag = String.Format("W/\"{0}\"", itemResult.Resource.Meta.VersionId);
                        }
                    }
                }
            }
        }


        public System.Threading.Tasks.Task<Bundle> Search(ModelBaseInputs<IServiceProvider> request, IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<Bundle> SystemHistory(ModelBaseInputs<IServiceProvider> request, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta();
            result.Meta.LastUpdated = DateTime.Now;
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = System.IO.Directory.EnumerateFiles(DirectorySystemService.Directory);
            foreach (var filename in files)
            {
                var resource = parser.Parse<Resource>(System.IO.File.ReadAllText(filename));
                result.AddResourceEntry(resource, 
                    ResourceIdentity.Build(request.BaseUri, 
                        resource.ResourceType.ToString(), 
                        resource.Id, 
                        resource.Meta.VersionId).OriginalString);
            }
            result.Total = result.Entry.Count;

            // also need to set the page links

            return System.Threading.Tasks.Task.FromResult(result);
        }
        public static List<ResourceReference> AllReferences(Base resource)
        {
            List<ResourceReference> results = new List<ResourceReference>();
            if (resource == null)
                return results;

            var mapping = Fhir.Serialization.BaseFhirParser.Inspector.ImportType(resource.GetType());
            foreach (var item in mapping.PropertyMappings.Where(t => t.ElementType.Name == "ResourceReference" || t.ElementType.BaseType.Name == "BackboneElement"))
            {
                if (item.ElementType.BaseType.Name == "BackboneElement")
                {
                    if (item.IsCollection)
                    {
                        System.Collections.IEnumerable col = item.GetValue(resource) as System.Collections.IEnumerable;
                        foreach (var e in col)
                        {
                            BackboneElement be = e as BackboneElement;
                            results.AddRange(AllReferences(be));
                        }
                    }
                    else
                    {
                        BackboneElement be = item.GetValue(resource) as BackboneElement;
                        results.AddRange(AllReferences(be));
                    }
                }
                else
                {
                    ResourceReference rr = item.GetValue(resource) as ResourceReference;
                    if (rr != null)
                        results.Add(rr);
                }
            }
            return results;
        }
    }
}
