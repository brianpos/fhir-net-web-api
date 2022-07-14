using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using System.Linq;
using Hl7.Fhir.Utility;
using System.Net;
using System.Runtime.CompilerServices;
using Hl7.Fhir.DemoSqliteFhirServer.DemoEntityModels;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Hl7.Fhir.DemoSqliteFhirServer.DemoSearchIndexer;

namespace Hl7.Fhir.DemoSqliteFhirServer
{
    /// <summary>
    /// This is an implementation of the FHIR Service that sources all its files in the file system
    /// </summary>
    public class SqliteSystemService<TSP> : Hl7.Fhir.WebApi.IFhirSystemServiceR4<TSP>
        where TSP : class
    {
        public SqliteSystemService()
        {
        }

        /// <summary>
        /// The File system directory that will be scanned for the storage of FHIR resources
        /// </summary>
        public static string Directory { get; set; }
        private DemoSearchIndexer _indexer;
        public int DefaultPageSize { get; set; } = 40;

        private FhirDbContext GetFhirDbContext(TSP services)
        {
            if (services is System.IServiceProvider sp)
            {
                return sp.GetService<FhirDbContext>();
            }
            //if (services is System.Web.Http.Dependencies.IDependencyScope)
            //{

            //}
            return null;
        }

        public async System.Threading.Tasks.Task<CapabilityStatement> GetConformance(ModelBaseInputs<TSP> request, SummaryType summary)
        {
            Hl7.Fhir.Model.CapabilityStatement con = new Hl7.Fhir.Model.CapabilityStatement();
            con.Url = request.BaseUri + "metadata";
            con.Description = new Markdown("Demonstration Directory based FHIR server");
            con.DateElement = new Hl7.Fhir.Model.FhirDateTime("2017-04-30");
            con.Version = "1.0.0.0";
            con.Name = "demoCapStmt";
            con.Experimental = true;
            con.Status = PublicationStatus.Active;
            con.FhirVersion = FHIRVersion.N4_0_1;
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

            foreach (var resName in ModelInfo.SupportedResources)
            {
                var c = await GetResourceService(request, resName).GetRestResourceComponent();
                if (c != null)
                    con.Rest[0].Resource.Add(c);
            }

            return con;
        }

        public IFhirResourceServiceR4<TSP> GetResourceService(ModelBaseInputs<TSP> request, string resourceName)
        {
            FhirDbContext db = GetFhirDbContext(request.ServiceProvider);
            if (_indexer == null)
            {
                _indexer = new DemoSearchIndexer();
                _indexer.Initialize(db);
            }
            return new SqliteResourceService<TSP>() { RequestDetails = request, ResourceName = resourceName, ResourceDirectory = Directory, Indexer = _indexer, db = db };
        }

        public async System.Threading.Tasks.Task<Resource> PerformOperation(ModelBaseInputs<TSP> request, string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "convert")
            {
                Resource resource = operationParameters.GetResource("input");
                if (resource != null)
                    return resource;
                OperationOutcome outcome = new OperationOutcome();
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Code = OperationOutcome.IssueType.Value,
                    Details = new CodeableConcept() { Text = "Missing resource to convert" }
                });
                return outcome as Resource;
            }
            if (operation == "count-em")
            {
                var result = new OperationOutcome();
                FhirDbContext db = GetFhirDbContext(request.ServiceProvider);
                long items = db.Resource_Header.Count(); // yes not async, the other non async call - only used in unit tests
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"All resource type instances: {items}")
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
                return result;
            }
            if (operation == "search-cache-rescan")
            {
                FhirDbContext db = GetFhirDbContext(request.ServiceProvider);
                await db.Database.EnsureDeletedAsync();
                await db.Database.EnsureCreatedAsync();

                await _indexer.ScanDirectory(request.CancellationToken, db, Directory);
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"Search Cache re-scanned")
                });
                return result;
            }
            if (operation == "search-cache-delete")
            {
                FhirDbContext db = GetFhirDbContext(request.ServiceProvider);
                _indexer.DeleteSearchCache(db);
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"Search Cache deleted")
                });
                return result;
            }

            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task<Bundle> ProcessBatch(ModelBaseInputs<TSP> request, Bundle batch)
        {
            BatchOperationProcessing<TSP> batchProcessor = new BatchOperationProcessing<TSP>();
            batchProcessor.DefaultPageSize = DefaultPageSize;
            batchProcessor.GetResourceService = GetResourceService;
            return await batchProcessor.ProcessBatch(request, batch);
        }

        public System.Threading.Tasks.Task<Bundle> Search(ModelBaseInputs<TSP> request, IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task<Bundle> SystemHistory(ModelBaseInputs<TSP> request, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta();
            result.Meta.LastUpdated = DateTime.Now;
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            FhirDbContext db = GetFhirDbContext(request.ServiceProvider);
            var resources = await _indexer.SystemHistory(request.CancellationToken, db, since, Till, Count);

            foreach (SearchResourceResult item in resources)
            {
                result.Entry.Add(new Bundle.EntryComponent()
                {
                    Resource = item.Resource,
                    FullUrl = item.Resource != null ? ResourceIdentity.Build(request.BaseUri, item.Resource.TypeName, item.Resource.Id, item.Resource.Meta.VersionId).OriginalString : null,
                    Request = item.Request
                });
            }
            result.Total = result.Entry.Count;

            // also need to set the page links

            return result;
        }
    }
}
