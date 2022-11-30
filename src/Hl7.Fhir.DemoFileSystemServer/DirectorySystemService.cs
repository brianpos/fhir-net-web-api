using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Utility;
using Hl7.Fhir.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hl7.Fhir.DemoFileSystemFhirServer
{
    /// <summary>
    /// This is an implementation of the FHIR Service that sources all its files in the file system
    /// </summary>
    public class DirectorySystemService<TSP> : Hl7.Fhir.WebApi.IFhirSystemServiceR4<TSP>
        where TSP : class
    {
        public DirectorySystemService()
        {
            var _dirSource = new DirectorySource(Directory, new DirectorySourceSettings() { ExcludeSummariesForUnknownArtifacts = true, MultiThreaded = true, Mask = "*..xml" });
            var cacheResolver = new CachedResolver(
                new MultiResolver(
                    _dirSource,
                    ZipSource.CreateValidationSource()
                    ));
            _source = cacheResolver;
        }

        /// <summary>
        /// The File system directory that will be scanned for the storage of FHIR resources
        /// </summary>
        public static string Directory { get; set; }
        private SearchIndexer _indexer;
        public int DefaultPageSize { get; set; } = 40;

        private CachedResolver _source;

        public IResourceResolver Source { get { return _source; } }

        public IAsyncResourceResolver AsyncSource { get { return _source; } }

        public void InitializeIndexes()
        {
            _indexer = new SearchIndexer();
            _indexer.Initialize(Directory);
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
            con.FhirVersion = FHIRVersion.N4_3_0;
            // con.AcceptUnknown = CapabilityStatement.UnknownContentCode.Extensions;
            con.Format = new string[] { "xml", "json" };
            con.Kind = CapabilityStatementKind.Instance;
            con.Meta = new Meta();
            con.Meta.LastUpdatedElement = Instant.Now();

            con.Implementation = new CapabilityStatement.ImplementationComponent();
            con.Implementation.Url = request.BaseUri.OriginalString.Trim('/');

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
            if (!Hl7.Fhir.Model.ModelInfo.IsCoreModelType(resourceName))
                throw new NotImplementedException();

            return new DirectoryResourceService<TSP>(request, resourceName, Directory, _source, _source, _indexer);
        }

        public System.Threading.Tasks.Task<Resource> PerformOperation(ModelBaseInputs<TSP> request, string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "convert")
            {
                Resource resource = operationParameters.GetResource("input");
                if (resource != null)
                    return Task<Resource>.FromResult(resource);
                OperationOutcome outcome = new OperationOutcome();
                return Task<Resource>.FromResult(outcome as Resource);
            }
            if (operation == "count-em")
            {
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"All resource type instances: {System.IO.Directory.EnumerateFiles(Directory, $"*.xml").Count()}")
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
            if (operation == "search-cache-write")
            {
                _indexer.WriteCache(Directory);
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"Search Cache updated")
                });
                return System.Threading.Tasks.Task.FromResult<Resource>(result);
            }
            if (operation == "search-cache-rescan")
            {
                _indexer.ScanDirectory(Directory);
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"Search Cache re-scanned")
                });
                return System.Threading.Tasks.Task.FromResult<Resource>(result);
            }
            if (operation == "search-cache-delete")
            {
                _indexer.DeleteSearchCache(Directory);
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"Search Cache deleted")
                });
                return System.Threading.Tasks.Task.FromResult<Resource>(result);
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

        public System.Threading.Tasks.Task<Bundle> SystemHistory(ModelBaseInputs<TSP> request, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta();
            result.Meta.LastUpdated = DateTime.Now;
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = System.IO.Directory.EnumerateFiles(Directory, "*.*.*.xml");
            foreach (var filename in files)
            {
                if (filename.EndsWith("..xml")) // this is the current version file, the version number file will have the real data
                    continue;
                var resource = parser.Parse<Resource>(System.IO.File.ReadAllText(filename));
                result.AddResourceEntry(resource,
                    ResourceIdentity.Build(request.BaseUri,
                        resource.TypeName,
                        resource.Id,
                        resource.Meta.VersionId).OriginalString);
            }
            result.Total = result.Entry.Count;

            // also need to set the page links

            return System.Threading.Tasks.Task.FromResult(result);
        }
    }
}
