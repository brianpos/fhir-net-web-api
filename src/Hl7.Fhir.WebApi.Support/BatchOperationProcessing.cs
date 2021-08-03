using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.WebApi
{
    public class BatchOperationProcessing<TSP>
        where TSP: class
    {
        public Func<ModelBaseInputs<TSP>, string, IFhirResourceServiceR4<TSP>> GetResourceService { get; set; }
        public int DefaultPageSize { get; set; } = 40;

        public async System.Threading.Tasks.Task<Bundle> ProcessBatch(ModelBaseInputs<TSP> request, Bundle batch)
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

                // Request-less bundle handling
                foreach (var entry in batch.Entry.Where(e => e.Request == null))
                {
                    await ProcessBatchEntry(request, outcome, mappedResourceIds, entry);
                }

            }
            outcome.Total = outcome.Entry.Count;
            return outcome;
        }

        private async System.Threading.Tasks.Task ProcessBatchEntry(ModelBaseInputs<TSP> request, Bundle outcome, Dictionary<string, string> mappedResourceIds, Bundle.EntryComponent entry)
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
                        ResourceIdentity ri = new ResourceIdentity(url);
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
                            var ids = entry.Resource.AllReferences();
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
                        catch (FhirOperationException ex)
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
                        catch (FhirOperationException ex)
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
                            try
                            {
                                var parameters = System.Web.HttpUtility.ParseQueryString(new Uri(request.BaseUri + entry.Request.Url).Query).TupledParameters(false);
                                int pagesize;
                                string pageSizeString = parameters.Where(k => k.Key == "_count").FirstOrDefault().Value;
                                if (string.IsNullOrEmpty(pageSizeString) || !int.TryParse(pageSizeString, out pagesize))
                                    pagesize = DefaultPageSize;
                                Bundle result = await model.Search(parameters, pagesize, SummaryType.False);
                                // result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
                                itemResult.Resource = result;
                                itemResult.Response.Status = ((int)HttpStatusCode.OK).ToString();
                            }
                            catch (FhirOperationException ex)
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
    }
}
