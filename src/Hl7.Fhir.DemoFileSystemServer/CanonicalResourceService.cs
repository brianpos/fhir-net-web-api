using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Support;
using Hl7.Fhir.Utility;
using Hl7.Fhir.WebApi;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Hl7.Fhir.DemoFileSystemFhirServer
{
    public class CanonicalResourceService<TSP> : DirectoryResourceService<TSP>
        where TSP : class
    {
        public CanonicalResourceService(ModelBaseInputs<TSP> requestDetails, string resourceName, string directory, IResourceResolver source, IAsyncResourceResolver asyncSource)
            : base(requestDetails, resourceName, directory, source, asyncSource)
        {
        }

        public CanonicalResourceService(ModelBaseInputs<TSP> requestDetails, string resourceName, string directory, IResourceResolver source, IAsyncResourceResolver asyncSource, SearchIndexer indexer)
            : base(requestDetails, resourceName, directory, source, asyncSource, indexer)
        {
        }

        override async public Task<OperationOutcome> ValidateResource(Resource resource, ResourceValidationMode mode, string[] profiles)
        {
            var outcome = await base.ValidateResource(resource, mode, profiles);

            if (outcome.Success && resource is IVersionableConformanceResource icr)
            {
                // This validation was successful, check that the canonical URL/Version/algorithm doesn't
                // create some invalid state for the server to be in

                // consistency with other instances
                var kvps = new List<KeyValuePair<string, string>>();
                kvps.Add(new KeyValuePair<string, string>("url", icr.Url));
                var bundle = await Search(kvps, null, SummaryType.True, null);

                var ivrs = bundle.Entry
                    .Select(e => e.Resource as IVersionableConformanceResource)
                    .Where(e => e != null && (e as Resource).Id != resource.Id)
                    .ToList(); // exclude itself (for updates)

                // Verify that this version doesn't already exist too.
                if (ivrs.Any(v => v.Version == icr.Version)) // this also needs to permit copies for alternate FHIR versions too
                {
                    outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                    {
                        Code = OperationOutcome.IssueType.Duplicate,
                        Severity = OperationOutcome.IssueSeverity.Error,
                        Details = new CodeableConcept(null, null, $"Version {icr.Version} of {icr.Url} already exists")
                    });
                }

                // Verify version algorithm isn't defined differently
                bool conflictingAlgorithm = false;
                var existingFhirpathAlg = ivrs.Where(e => e.versionAlgorithFhirPathExpression() != null).Select(e => e.versionAlgorithFhirPathExpression());
                var existingVerAlg = ivrs.Where(e => e.versionAlgorithCoded() != null).Select(e => e.versionAlgorithCoded().Code);
                if (icr.versionAlgorithFhirPathExpression() != null
                    && (existingVerAlg.Any() || existingFhirpathAlg.Any(e => e != icr.versionAlgorithFhirPathExpression())))
                    conflictingAlgorithm = true;

                if (icr.versionAlgorithCoded() != null
                    && (existingFhirpathAlg.Any() || existingVerAlg.Any(e => e != icr.versionAlgorithCoded().Code)))
                    conflictingAlgorithm = true;

                if (conflictingAlgorithm == true)
                {
                    outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                    {
                        Code = OperationOutcome.IssueType.BusinessRule,
                        Severity = OperationOutcome.IssueSeverity.Error,
                        Details = new CodeableConcept(null, null, $"Ambiguous version algorithms would result: {string.Join(",", existingVerAlg.Union(existingFhirpathAlg))} is the existing algorithm")
                    });
                }

                // Is the canonical version number of valid against the algorithm selected.
                var alg = existingVerAlg.FirstOrDefault() ?? icr.versionAlgorithCoded()?.Code;
                if (!string.IsNullOrEmpty(icr.Version))
                {
                    switch (alg)
                    {
                        case "alpha":
                            // No special validation rules
                            break;
                        case "semver":
                            if (!SemanticVersioning.Version.TryParse(icr.Version, true, out var ver))
                            {
                                outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                                {
                                    Code = OperationOutcome.IssueType.Value,
                                    Severity = OperationOutcome.IssueSeverity.Error,
                                    Details = new CodeableConcept(null, null, $"Version {icr.Version} is not a semver value")
                                });
                            }
                            break;
                        case "integer":
                            if (!decimal.TryParse(icr.Version, out decimal iValue))
                            {
                                outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                                {
                                    Code = OperationOutcome.IssueType.Value,
                                    Severity = OperationOutcome.IssueSeverity.Error,
                                    Details = new CodeableConcept(null, null, $"Version {icr.Version} is not a integer value")
                                });
                            }
                            break;
                        case "date":
                            if (!FhirDateTime.IsValidValue(icr.Version))
                            {
                                outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                                {
                                    Code = OperationOutcome.IssueType.Value,
                                    Severity = OperationOutcome.IssueSeverity.Error,
                                    Details = new CodeableConcept(null, null, $"Version {icr.Version} is not a date value")
                                });
                            }
                            break;
                        case "natural":
                            // No special validation rules
                            break;
                    }
                }
            }

            return outcome;
        }

        override public async Task<Resource> PerformOperation(string operation, Parameters operationParameters, SummaryType summary)
        {
            switch (operation.ToLower())
            {
                case "current-canonical":
                    return await PerformOperation_CurrentCanonical(operationParameters, summary);
            }

            return await base.PerformOperation(operation, operationParameters, summary);
        }

        private async Task<Resource> PerformOperation_CurrentCanonical(Parameters operationParameters, SummaryType summary)
        {
            var outcome = new OperationOutcome();
            string url = null;
            var statuses = new List<string>();

            // read the URL parameter
            var urlParams = operationParameters.Parameter.Where(p => p.Name?.ToLower() == "url");
            if (urlParams.Any())
            {
                if (urlParams.Count() > 1)
                {
                    outcome.Issue.Add(new OperationOutcome.IssueComponent()
                    {
                        Code = OperationOutcome.IssueType.Informational,
                        Severity = OperationOutcome.IssueSeverity.Information,
                        Details = new CodeableConcept(null, null, "Multiple 'url' parameters provided, using the first one")
                    });
                }
                var val = urlParams.FirstOrDefault().Value;
                if (val == null)
                {
                    outcome.Issue.Add(new OperationOutcome.IssueComponent()
                    {
                        Code = OperationOutcome.IssueType.Required,
                        Severity = OperationOutcome.IssueSeverity.Error,
                        Details = new CodeableConcept(null, null, "Parameter 'url' value is missing")
                    });
                }
                else
                {
                    if (!(val is FhirString || val is FhirUri))
                    {
                        outcome.Issue.Add(new OperationOutcome.IssueComponent()
                        {
                            Code = OperationOutcome.IssueType.Informational,
                            Severity = OperationOutcome.IssueSeverity.Information,
                            Details = new CodeableConcept(null, null, $"'url' parameters provided as {val.TypeName}, uri is defined in the specification")
                        });
                    }
                    if (val is PrimitiveType p)
                        url = p.ToString();
                }
            }
            if (!urlParams.Any())
            {
                outcome.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Required,
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Details = new CodeableConcept(null, null, "Required parmeter 'url' missing")
                });
            }

            // read the status parameter(s)
            var statusParams = operationParameters.Parameter.Where(p => p.Name?.ToLower() == "status");
            if (statusParams.Any())
            {
                foreach (var value in statusParams.Select(p => p.Value))
                {
                    string psv = value.ToString();
                    if (value is FhirUri code)
                        psv = code.Value;
                    else if (value is FhirString str)
                        psv = str.Value;
                    if (!string.IsNullOrEmpty(psv))
                    {
                        statuses.AddRange(psv.Split(','));
                    }
                }
                // validate status value is in enumeration
                foreach (var psv in statuses)
                {
                    PublicationStatus? ps = EnumUtility.ParseLiteral<PublicationStatus>(psv);
                    if (!ps.HasValue)
                    {
                        outcome.Issue.Add(new OperationOutcome.IssueComponent()
                        {
                            Code = OperationOutcome.IssueType.Invalid,
                            Severity = OperationOutcome.IssueSeverity.Error,
                            Details = new CodeableConcept(null, null, $"Invalid 'status' parameter value [{psv}]")
                        });
                    }
                }
            }

            // return the error if one was detected
            if (!outcome.Success)
            {
                outcome.SetAnnotation<HttpStatusCode>(HttpStatusCode.BadRequest);
                return outcome;
            }

            // Search for the resources using this canonical URL
            var kvps = new List<KeyValuePair<string, string>>();
            kvps.Add(new KeyValuePair<string, string>("url", url));
            if (statuses.Any())
                kvps.Add(new KeyValuePair<string, string>("status", string.Join(",", statuses)));
            var bundle = await Search(kvps, null, summary, null);
            if (!bundle.Entry.Any())
            {
                outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
                {
                    Code = OperationOutcome.IssueType.NotFound,
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Details = new CodeableConcept(null, null, $"Canonical URL '{url}' was not found")
                });
                outcome.SetAnnotation(HttpStatusCode.NotFound);
                return outcome;
            }

            // use the Canonical helper function to locate the current one
            var ivrs = bundle.Entry.Select(e => e.Resource as IVersionableConformanceResource).Where(e => e != null);
            var result = CurrentCanonical.Current(ivrs);
            if (result != null)
            {
                return result as Resource;
            }

            // Could not evaluate the current version
            outcome.Issue.Insert(0, new OperationOutcome.IssueComponent
            {
                Code = OperationOutcome.IssueType.Processing,
                Severity = OperationOutcome.IssueSeverity.Error,
                Details = new CodeableConcept(null, null, $"Canonical URL '{url}' could not be calculated between versions {string.Join(",", ivrs.Select(i => i.Version))}")
            });
            outcome.SetAnnotation(HttpStatusCode.Ambiguous);
            return outcome;
        }
    }
}
