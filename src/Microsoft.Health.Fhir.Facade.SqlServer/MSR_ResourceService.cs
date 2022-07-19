using Hl7.Fhir.ElementModel.Types;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Support;
using Hl7.Fhir.Utility;
using Hl7.Fhir.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Health.Fhir.Facade.SqlServer.EntityModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Resource = Hl7.Fhir.Model.Resource;
using LinqKit;

namespace Microsoft.Health.Fhir.Facade.SqlServer
{
    public class MSR_ResourceService<TSP> : Hl7.Fhir.WebApi.IFhirResourceServiceR5<TSP>
        where TSP : class
    {
        public ModelBaseInputs<TSP> RequestDetails { get; set; }

        public string ResourceName { get; set; }

        internal FHIR_R4Context dbMS { get; set; }
        internal int ResourceTypeId { get; set; }
        internal Dictionary<string, short> SearchParamIdCache { get; set; } // this really should be cached

        public Task<CapabilityStatement.ResourceComponent> GetRestResourceComponent()
        {
            var rt = new Hl7.Fhir.Model.CapabilityStatement.ResourceComponent();
            rt.TypeElement = new Code<Hl7.Fhir.Model.ResourceType>() { ObjectValue = ResourceName };
            rt.ReadHistory = true;
            rt.UpdateCreate = true;
            rt.Versioning = CapabilityStatement.ResourceVersionPolicy.Versioned;
            rt.ConditionalCreate = false;
            rt.ConditionalUpdate = false;
            rt.ConditionalDelete = CapabilityStatement.ConditionalDeleteStatus.NotSupported;

            rt.Interaction = new List<CapabilityStatement.ResourceInteractionComponent>()
            {
                // new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Create },
                new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.Read },
                // new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.Update },
                // new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.Delete },
                new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.SearchType },
                new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.Vread },
                new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.HistoryInstance },
                new CapabilityStatement.ResourceInteractionComponent() { Code = TypeRestfulInteraction.HistoryType },
            };

            return System.Threading.Tasks.Task.FromResult(rt);
        }

        public async Task<Resource> Get(string resourceId, string VersionId, SummaryType summary)
        {
            EF.ResourceTable resourceRow;
            if (!string.IsNullOrEmpty(VersionId) && int.TryParse(VersionId, out int version)) // versioned request or not
                resourceRow = await dbMS.Resource.FirstOrDefaultAsync(r => r.ResourceTypeId == this.ResourceTypeId && r.ResourceId == resourceId && r.Version == version, RequestDetails.CancellationToken);
            else
                resourceRow = await dbMS.Resource.FirstOrDefaultAsync(r => r.ResourceTypeId == this.ResourceTypeId && r.ResourceId == resourceId && r.IsHistory == false, RequestDetails.CancellationToken);

            if (resourceRow == null)
                throw new FhirServerException(System.Net.HttpStatusCode.NotFound, "Resource ID/Version not found");
            if (resourceRow.IsDeleted)
                throw new FhirServerException(System.Net.HttpStatusCode.Gone, $"{ResourceName}/{resourceId} has been deleted");
            return RawResourceSerializer.Deserialize(resourceRow.RawResource);
        }

        public async Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary, string orderby)
        {
            // This is a demo search implementation - really just doing _id and token based search for the external terminology demo
            Bundle result = new Bundle();
            if (result.Meta == null)
                result.Meta = new Meta();
            result.Meta.LastUpdated = System.DateTime.Now;
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToFhirId()).OriginalString;
            result.Type = Bundle.BundleType.Searchset;
            result.ResourceBase = RequestDetails.BaseUri;

            var table = dbMS.Resource.Where(r => r.ResourceTypeId == this.ResourceTypeId && r.IsHistory == false);

            var idparam = parameters.Where(kp => kp.Key == "_id");
            List<string> usedParameters = new List<string>();
            if (idparam.Any())
            {
                // Even though this is a trashy demo app, don't permit walking the file system
                usedParameters.Add("_id");
            }

            foreach (var p in parameters)
            {
                var values = p.Value.Split(',');

                // Yeah this code should really use a search parameter parser like the ones..
                // https://github.com/FirelyTeam/spark/blob/r4/master/src/Spark.Engine/Search/Model/Modifier.cs
                // or https://github.com/brianpos/fhir-server/blob/main/src/Microsoft.Health.Fhir.Core/Features/Search/Expressions/Parsers/SearchParameterExpressionParser.cs
                string modifier = null;
                string searchParameterName = p.Key.Trim();
                if (searchParameterName.Contains(":"))
                {
                    // there is a search modifier, so need to identify and strip it off.
                    modifier = searchParameterName.Substring(searchParameterName.IndexOf(":") + 1);
                    searchParameterName = searchParameterName.Substring(0, searchParameterName.IndexOf(":"));
                }

                if (searchParameterName == "_id")
                {
                    continue;
                }

                if (!SearchParamIdCache.ContainsKey(searchParameterName))
                {
                    // Not a search parameter that is valid for this resource type (we don't index it)
                    continue;
                }
                int spId = SearchParamIdCache[searchParameterName];

                // this is the Query that we're going to support with this POC
                // code:below=http://loinc.org|LP415675-0,http://loinc.org|LP416421-8
                if (modifier == "below")
                {
                    System.Linq.Expressions.Expression<Func<EF.ResourceTable, bool>> predicate = null;
                    foreach (string value in values.Distinct())
                    {
                        // this one needs to check against the specific table
                        var coding = value.Split("|");
                        if (coding.Length == 2)
                        {
                            System.Diagnostics.Trace.WriteLine($"Searching below {value}");

                            var cm = new ClosureMaintainer("https://r4.ontoserver.csiro.au/fhir");
                            cm.CancellationToken = RequestDetails.CancellationToken;
                            await cm.InitializeAsync("Data Source=.;Initial Catalog=FHIR_R4;Integrated Security=True;Application Name=FHIR_Server;MultipleActiveResultSets=true;");
                            await cm.CheckRelationshipsForSearchConcept("brian_test", new Coding(coding[0], coding[1]));

                            int? systemId = dbMS.System.FirstOrDefault(s => s.Value == coding[0])?.SystemId;
                            long? closureId = dbMS.ClosureTable.FirstOrDefault(s => s.Name == $"brian_test")?.Id; // name should be the property name instead (combined with a system prefix)

                            if (systemId.HasValue && closureId.HasValue)
                            {
                                // reach into the Closure Table
                                System.Linq.Expressions.Expression<Func<EF.ResourceTable, bool>> iterationPredicate = (sop) => dbMS.TokenSearchParam
                                                            .Join(dbMS.ClosureRelationships, tsp => tsp.Code, cr => cr.ChildCode, (tsp, cr) => new { tsp, cr })
                                                            .Any(v => v.cr.ClosureId == closureId && v.tsp.SystemId == systemId.Value && v.tsp.ResourceSurrogateId == sop.ResourceSurrogateId
                                                                        && v.cr.ParentCode == coding[1] && v.tsp.SearchParamId == spId);
                                if (predicate == null)
                                    predicate = iterationPredicate;
                                else
                                    predicate = predicate.Or(iterationPredicate);
                            }

                        }
                    }
                    if (predicate != null) table = table.Where(predicate);
                    usedParameters.Add(p.Key);
                }
                else
                {
                    System.Linq.Expressions.Expression<Func<EF.ResourceTable, bool>> predicate = null;
                    foreach (string value in values)
                    {
                        // this one needs to check against the specific table
                        var coding = value.Split("|");
                        if (coding.Length == 2)
                        {
                            int? systemId = dbMS.System.FirstOrDefault(s => s.Value == coding[0])?.SystemId;

                            if (predicate == null && systemId.HasValue)
                                predicate = (sop) => dbMS.TokenSearchParam.Any(tsp => tsp.ResourceTypeId == this.ResourceTypeId && tsp.SearchParamId == spId && tsp.ResourceSurrogateId == sop.ResourceSurrogateId
                                                                                        && tsp.Code == coding[1] && tsp.SystemId == systemId);
                            //else
                            //    predicate = predicate.Or(sop => dbMS.TokenSearchParam.Any(tsp => tsp.ResourceTypeId == this.ResourceTypeId && tsp.SearchParamId == spId && tsp.ResourceSurrogateId == sop.ResourceSurrogateId));

                        }
                    }
                    if (predicate != null) table = table.Where(predicate);
                    usedParameters.Add(p.Key);

                }

            }

            // trim down to just the pagesize requested
            table = table.Take(Count ?? 20); // Default Table Size if none requested

            // Retrieve the actual data
            var selectedData = await table.ToListAsync(RequestDetails.CancellationToken);
            foreach (var row in selectedData)
            {
                var rv = RawResourceSerializer.Deserialize(row.RawResource);
                rv.Meta.VersionId = row.Version.ToString(); // why is not the version in the raw data...
                result.AddResourceEntry(rv,
                    new Uri(ResourceIdentity.Build(RequestDetails.BaseUri, ResourceName, rv.Id).OriginalString).OriginalString).Search = new Bundle.SearchComponent()
                    {
                        Mode = Bundle.SearchEntryMode.Match
                    };
            }

            if (parameters.Count(p => p.Key != "_id" && !usedParameters.Contains(p.Key)) > 0)
            {
                var outcome = new OperationOutcome();
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Warning,
                    Code = OperationOutcome.IssueType.NotSupported,
                    Details = new CodeableConcept() { Text = $"Unsupported search parameters used: {System.String.Join("&", parameters.Where(p => p.Key != "_id" && !usedParameters.Contains(p.Key)).Select(k => k.Key + "=" + k.Value))}" }
                });
                result.AddResourceEntry(outcome,
                    new Uri("urn:uuid:" + Guid.NewGuid().ToFhirId()).OriginalString).Search = new Bundle.SearchComponent()
                    {
                        Mode = Bundle.SearchEntryMode.Outcome
                    };
            }

            result.Total = result.Entry.Count;

            return result;
        }

        public async Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = System.DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var table = dbMS.Resource.Where(r => r.ResourceTypeId == this.ResourceTypeId && r.ResourceId == ResourceId)
                .OrderBy(r => r.ResourceTypeId)
                .ThenBy(r => r.ResourceId)
                .ThenByDescending(r => r.Version)
                .Take(Count ?? 20); // Default Table Size if none requested
            foreach (var row in await table.ToArrayAsync(RequestDetails.CancellationToken))
            {
                Resource resource = null;
                if (!row.IsDeleted)
                {
                    resource = RawResourceSerializer.Deserialize(row.RawResource);
                    resource.Meta.VersionId = row.Version.ToString(); // why is not the version in the raw data...
                }
                var ri = ResourceIdentity.Build(RequestDetails.BaseUri, ResourceName, row.ResourceId, row.Version.ToString());
                result.Entry.Add(new Bundle.EntryComponent()
                {
                    Resource = resource,
                    FullUrl = ri.OriginalString,
                    Request = new Bundle.RequestComponent()
                    {
                        Method = row.IsDeleted ? Bundle.HTTPVerb.DELETE : Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Bundle.HTTPVerb>(row.RequestMethod),
                        Url = $"{ResourceName}/{row.ResourceId}/_history/{row.Version}"
                    },
                });
            }

            // also need to set the page links

            return result;
        }


        public async Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = System.DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var table = dbMS.Resource.Where(r => r.ResourceTypeId == this.ResourceTypeId).Take(Count ?? 20); // Default Table Size if none requested
            foreach (var row in await table.ToArrayAsync(RequestDetails.CancellationToken))
            {
                Resource resource = null;
                if (!row.IsDeleted)
                {
                    resource = RawResourceSerializer.Deserialize(row.RawResource);
                    resource.Meta.VersionId = row.Version.ToString(); // why is not the version in the raw data...
                }
                var ri = ResourceIdentity.Build(RequestDetails.BaseUri, ResourceName, row.ResourceId, row.Version.ToString());
                result.Entry.Add(new Bundle.EntryComponent()
                {
                    Resource = resource,
                    FullUrl = ri.OriginalString,
                    Request = new Bundle.RequestComponent()
                    {
                        Method = row.IsDeleted ? Bundle.HTTPVerb.DELETE : Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Bundle.HTTPVerb>(row.RequestMethod),
                        Url = $"{ResourceName}/{row.ResourceId}/_history/{row.Version}"
                    },
                });
            }

            // also need to set the page links

            return result;
        }

        public async Task<Resource> PerformOperation(string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "update-closure")
            {
                var cm = new ClosureMaintainer("https://r4.ontoserver.csiro.au/fhir");
                cm.CancellationToken = RequestDetails.CancellationToken;
                await cm.InitializeAsync("Data Source=.;Initial Catalog=FHIR_R4;Integrated Security=True;Application Name=FHIR_Server;MultipleActiveResultSets=true;");

                var name = operationParameters.GetString("name") ?? "brian_test";
                var system = operationParameters.GetString("system");
                var code = operationParameters.GetString("code");
                ConceptMap resultConceptMap = null;
                if (!string.IsNullOrEmpty(system) && !string.IsNullOrEmpty(code))
                    resultConceptMap = await cm.FhirServerUsesConcept(name, new Coding(system, code));

                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept() { Text = "Closure Table updated" }
                });
                if (resultConceptMap != null)
                    result.Contained.Add(resultConceptMap);
                return result;
            }

            if (operation == "reset-closure")
            {
                var cm = new ClosureMaintainer("https://r4.ontoserver.csiro.au/fhir");
                cm.CancellationToken = RequestDetails.CancellationToken;
                await cm.InitializeAsync("Data Source=.;Initial Catalog=FHIR_R4;Integrated Security=True;Application Name=FHIR_Server;MultipleActiveResultSets=true;");
                var name = operationParameters.GetString("name") ?? "brian_test";
                await cm.DeleteClosureTable(name);

                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept() { Text = "Closure Table reset" }
                });
                return result;

            }

            throw new NotImplementedException();
        }

        #region << This demo proxy does not support these things >>
        public Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(string id, string ifMatch)
        {
            throw new NotImplementedException();
        }
        public Task<Resource> PerformOperation(string id, string operation, Parameters operationParameters, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
