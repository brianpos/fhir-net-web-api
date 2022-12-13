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
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Language.Debugging;
using System.Net;
using Hl7.Fhir.Specification.Source;

namespace Hl7.Fhir.DemoFileSystemFhirServer
{
    public class DirectoryResourceService<TSP> : Hl7.Fhir.WebApi.IFhirResourceServiceR4<TSP>
        where TSP : class
    {
        public ModelBaseInputs<TSP> RequestDetails { get; private set; }

        public string ResourceName { get; private set; }
        public string ResourceDirectory { get; private set; }
        public SearchIndexer Indexer { get; set; }

        public IResourceResolver Source { get; private set; }
        public IAsyncResourceResolver AsyncSource { get; private set; }

        public DirectoryResourceService(ModelBaseInputs<TSP> requestDetails, string resourceName, string directory, IResourceResolver source, IAsyncResourceResolver asyncSource)
        {
            this.RequestDetails = requestDetails;
            this.ResourceDirectory = directory;
            this.ResourceName = resourceName;
            this.Source = source;
            this.AsyncSource = asyncSource;
        }

        public DirectoryResourceService(ModelBaseInputs<TSP> requestDetails, string resourceName, string directory, IResourceResolver Source, IAsyncResourceResolver AsyncSource, SearchIndexer indexer)
        {
            this.RequestDetails = requestDetails;
            this.ResourceDirectory = directory;
            this.ResourceName = resourceName;
            this.Source = Source;
            this.AsyncSource = AsyncSource;
            this.Indexer = indexer;
        }


        protected static Serialization.FhirXmlSerializer _serializer = new Serialization.FhirXmlSerializer(new Serialization.SerializerSettings() { Pretty = true });
        protected static Serialization.FhirXmlParser _parser = new Serialization.FhirXmlParser();

        virtual public async Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince)
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
                        versionNumber = verFile + 1;
                }
            }
            resource.Meta.VersionId = versionNumber.ToString();
            string path = Path.Combine(ResourceDirectory, $"{resource.TypeName}.{resource.Id}.{resource.Meta.VersionId}.xml");

            // Validate the resource before we actually store it!
            var validationMode = ResourceValidationMode.create;
            if (versionNumber != 1)
                validationMode = ResourceValidationMode.update;
            var validationOutcome = await ValidateResource(resource, validationMode, null);
            if (!validationOutcome.Success)
            {
                var message = $"Validation failed: {validationOutcome.Errors} errors, {validationOutcome.Warnings}";
                if (validationOutcome.Fatals > 0)
                    message += $" ({validationOutcome.Fatals} fatals)";

                // Temporarily remove the warnings/information messages
                validationOutcome.Issue.RemoveAll(i => i.Severity == OperationOutcome.IssueSeverity.Warning);
                validationOutcome.Issue.RemoveAll(i => i.Severity == OperationOutcome.IssueSeverity.Information);

                throw new FhirServerException(System.Net.HttpStatusCode.BadRequest, validationOutcome, $"Validation failed: {validationOutcome.Errors} errors, {validationOutcome.Warnings} ({validationOutcome.Fatals} fatals)");
            }

            var settings = new Serialization.SerializerSettings() { Pretty = true };
            File.WriteAllText(
                path,
                _serializer.SerializeToString(resource));
            path = Path.Combine(ResourceDirectory, $"{resource.TypeName}.{resource.Id}..xml"); // the current version of the resource
            File.WriteAllText(
                path,
                _serializer.SerializeToString(resource));
            if (validationMode == ResourceValidationMode.create)
                resource.SetAnnotation<CreateOrUpate>(CreateOrUpate.Create);
            else
                resource.SetAnnotation<CreateOrUpate>(CreateOrUpate.Update);
            // and update the search index
            Indexer.ScanResource(resource, Path.Combine(ResourceDirectory, $"{resource.TypeName}.{resource.Id}..xml"));
            return resource;
        }

        public enum ResourceValidationMode { create, update, delete, profile };
        virtual public Task<OperationOutcome> ValidateResource(Resource resource, ResourceValidationMode mode, string[] profiles)
        {
            var compiler = new Hl7.FhirPath.FhirPathCompiler();
            var settings = new Hl7.Fhir.Validation.ValidationSettings()
            {
                ResourceResolver = Source,
                TerminologyService = new Hl7.Fhir.Specification.Terminology.LocalTerminologyService(AsyncSource, new Specification.Terminology.ValueSetExpanderSettings() { MaxExpansionSize = 1500 }),
                FhirPathCompiler = compiler
            };
            //settings.ConstraintsToIgnore = settings.ConstraintsToIgnore.Union(new []{
            //    "ref-1", // causes issues with
            //    // "ctm-1", // should permit prac roles too
            //    // "sdf-0" // name properties should be usable as identifiers in code (no spaces etc)

            //} ).Distinct().ToArray();
            var validator = new Hl7.Fhir.Validation.Validator(settings);
            var outcome = validator.Validate(resource.ToTypedElement(), profiles);

            // strip out any profile missing
            outcome.Issue.RemoveAll((i) => i.Details.Coding.Any(c => c.Code == "4000") && i.Details.Text.Contains("Unable to resolve reference to profile"));

            // Version 1.9.0 of the core libs incorrectly report the errors in location, not expression, so move them over
            foreach (var issue in outcome.Issue)
            {
                if (!issue.ExpressionElement.Any())
                {
                    issue.ExpressionElement = issue.LocationElement;
                    issue.LocationElement = null;
                }
            }

            // TODO: If the resource has the subsetted meta tag, then reject the create/update

            return Task<OperationOutcome>.FromResult(outcome);
        }

        virtual public Task<string> Delete(string id, string ifMatch)
        {
            string path = Path.Combine(ResourceDirectory, $"{this.ResourceName}.{id}..xml");
            if (File.Exists(path))
                File.Delete(path);
            return System.Threading.Tasks.Task.FromResult<string>(null);
        }

        virtual public Task<Resource> Get(string resourceId, string VersionId, SummaryType summary)
        {
            RequestDetails.SetResponseHeaderValue("test", "wild-turkey-get");

            string path = Path.Combine(ResourceDirectory, $"{this.ResourceName}.{resourceId}.{VersionId}.xml");
            if (File.Exists(path))
                return System.Threading.Tasks.Task.FromResult(_parser.Parse<Resource>(File.ReadAllText(path)));
            throw new FhirServerException(System.Net.HttpStatusCode.Gone, "It might have been deleted!");
        }

        virtual public Task<CapabilityStatement.ResourceComponent> GetRestResourceComponent()
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

        virtual public Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var files = Directory.EnumerateFiles(ResourceDirectory, $"{ResourceName}.{ResourceId}.?*.xml");
            foreach (var filename in files)
            {
                if (filename.EndsWith("..xml"))
                    continue;
                var resource = _parser.Parse<Resource>(File.ReadAllText(filename));
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

        virtual public async Task<Resource> PerformOperation(string operation, Parameters operationParameters, SummaryType summary)
        {
            switch (operation.ToLower())
            {
                case "validate":
                    return await PerformOperation_Validate(operationParameters, summary);
            }
            if (operation == "count-em")
            {
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"{ResourceName} resource instances: {Directory.EnumerateFiles(ResourceDirectory, $"{ResourceName}.*.xml").Count()}")
                });
                return result;
            }
            if (operation == "preferred-id")
            {
                // Test operation that isn't really anything just for a specific unit test
                NamingSystem ns = new NamingSystem() { Id = operationParameters.GetString("id") };
                return ns;
            }

            throw new NotImplementedException();
        }

        virtual public async Task<Resource> PerformOperation(string id, string operation, Parameters operationParameters, SummaryType summary)
        {
            switch (operation.ToLower())
            {
                case "validate":
                    if (operationParameters.Parameter.Any(p => p.Name.ToLower() == "resource"))
                    {
                        var outcome = new OperationOutcome();
                        outcome.Issue.Add(new OperationOutcome.IssueComponent()
                        {
                            Code = OperationOutcome.IssueType.Incomplete,
                            Severity = OperationOutcome.IssueSeverity.Error,
                            Details = new CodeableConcept(null, null, "When calling the resource instance validate operation the 'resource' parameters must not be provided")
                        });
                        outcome.SetAnnotation<HttpStatusCode>(HttpStatusCode.BadRequest);
                        return outcome;
                    }
                    var resource = await Get(id, null, SummaryType.False);
                    operationParameters.Add("resource", resource);
                    return await PerformOperation_Validate(operationParameters, summary);
            }
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
                return outcome;
            }
            throw new NotImplementedException();
        }

        protected async Task<Resource> PerformOperation_Validate(Parameters operationParameters, SummaryType summary)
        {
            var outcome = new OperationOutcome();
            ResourceValidationMode? mode = ResourceValidationMode.create;
            Resource resource = operationParameters["resource"]?.Resource;
            List<string> profiles = new List<string>();

            var modeParams = operationParameters.Parameter.Where(p => p.Name?.ToLower() == "mode");
            if (modeParams.Count() > 1)
            {
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, "Multiple 'mode' parameters provided, using the first one")
                });
            }
            if (modeParams.Any())
            {
                string modeStr = null;
                var value = modeParams.First().Value;
                if (value is Code code) modeStr = code.Value;
                else if (value is FhirString str) modeStr = str.Value;
                else
                {
                    outcome.Issue.Add(new OperationOutcome.IssueComponent()
                    {
                        Code = OperationOutcome.IssueType.Structure,
                        Severity = OperationOutcome.IssueSeverity.Error,
                        Details = new CodeableConcept(null, null, "Multiple 'mode' parameters provided, using the first one")
                    });
                }
                if (!string.IsNullOrEmpty(modeStr))
                {
                    mode = EnumUtility.ParseLiteral<ResourceValidationMode>(modeStr, true);
                    if (!mode.HasValue)
                    {
                        outcome.Issue.Add(new OperationOutcome.IssueComponent()
                        {
                            Code = OperationOutcome.IssueType.CodeInvalid,
                            Severity = OperationOutcome.IssueSeverity.Error,
                            Details = new CodeableConcept(null, null, $"Invalid 'mode' parameter value '{modeStr}'")
                        });
                    }
                }
            }

            var resourceParams = operationParameters.Parameter.Where(p => p.Name == "resource");
            if (resourceParams.Count() > 1)
            {
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Incomplete,
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Details = new CodeableConcept(null, null, "Multiple 'resource' parameters provided")
                });
            }
            if (resourceParams.Count() != 1 && mode != ResourceValidationMode.delete)
            {
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Incomplete,
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Details = new CodeableConcept(null, null, "Missing the 'resource' parameter")
                });
            }

            var profileParams = operationParameters.Parameter.Where(p => p.Name?.ToLower() == "profile");
            if (profileParams.Any())
            {
                foreach (var value in profileParams.Select(p => p.Value))
                {
                    if (value is FhirUri code)
                        profiles.Add(code.Value);
                    else if (value is FhirString str)
                        profiles.Add(str.Value);
                }
            }

            if (resource != null && resource.TypeName != this.ResourceName)
            {
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Incomplete,
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Details = new CodeableConcept(null, null, $"Cannot validate a '{resource.TypeName}' resource on the '{this.ResourceName}' endpoint")
                });
            }

            if (!outcome.Success)
            {
                outcome.SetAnnotation<HttpStatusCode>(HttpStatusCode.BadRequest);
                return outcome;
            }

            var result = await ValidateResource(resource, mode.Value, profiles.ToArray());
            outcome.Issue.AddRange(result.Issue);
            if (outcome.Success)
            {
                // resource validated fine, add an information message to report it
                string summaryMessage = $"Validation of '{resource.TypeName}/{resource.Id}' for {mode.GetLiteral()} was successful";
                if (outcome.Warnings > 0)
                    summaryMessage += $" (with {outcome.Warnings} warnings)";
                outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, summaryMessage)
                });
            }
            return outcome;
        }

        virtual public Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary, string sortby)
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
                        var resourceEntry = _parser.Parse<Resource>(xr);
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

        virtual public Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var files = Directory.EnumerateFiles(ResourceDirectory, $"{ResourceName}.*.*.xml");
            foreach (var filename in files)
            {
                if (filename.EndsWith("..xml")) // this is the current version file, the version number file will have the real data
                    continue;
                var resource = _parser.Parse<Resource>(File.ReadAllText(filename));
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
