using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.Specification.Source
{
    public class SqliteConformanceResourceResolver : IConformanceSource, IAsyncResourceResolver
    {
        public SqliteConformanceResourceResolver(SpecificationContext context)
        {
            _context = context;
            _serializer = new FhirXmlSerializer(new SerializerSettings() { Pretty = true });
            _parser = new FhirXmlParser();
        }
        SpecificationContext _context;
        FhirXmlSerializer _serializer;
        FhirXmlParser _parser;

        public async Task<OperationOutcome> MigrateFrom(ZipSource source, Action<OperationOutcome.IssueComponent, string, Resource> progressReporter = null, CancellationToken ct = new CancellationToken())
        {
            var outcome = new OperationOutcome();
            int totalResources = 0;
            int savedResources = 0;
            var uris = source.ListResourceUris().ToList();
            foreach (var itemUri in uris)
            {
                try
                {
                    var resource = source.ResolveByCanonicalUri(itemUri);
                    if (resource != null)
                    {
                        totalResources++;
                        var includeResult = await IncludeCanonicalResource(resource, progressReporter, ct);
                        if (includeResult.Success)
                            savedResources++;
                        outcome.Issue.AddRange(includeResult.Issue);
                    }
                    else
                    {
                        resource = source.ResolveByUri(itemUri);
                        if (resource != null)
                        {
                            totalResources++;
                            var includeResult = await IncludeCanonicalResource(resource, progressReporter, ct);
                            if (includeResult.Success)
                                savedResources++;
                            outcome.Issue.AddRange(includeResult.Issue);
                        }
                        else
                        {
                            System.Diagnostics.Trace.WriteLine($"cannot resolve {itemUri}");
                        }
                    }
                }
                catch(Hl7.Fhir.Support.ResolvingConflictException ex)
                {
                    System.Diagnostics.Trace.WriteLine($"Exceptioin resolving {itemUri} : {ex.Message}");
                }
            }
            try
            {
                await _context.SaveChangesAsync(ct);
                var issue = new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Code = OperationOutcome.IssueType.Informational,
                    Details = new CodeableConcept() { Text = $"Migration complete - {savedResources}/{totalResources}" }
                };
                outcome.Issue.Add(issue);
                progressReporter?.Invoke(issue, null, null);
            }
            catch (Exception ex)
            {
                var issue = new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Error,
                    Code = OperationOutcome.IssueType.Exception,
                    Details = new CodeableConcept() { Text = $"Updating database failed: {ex.Message}" },
                    Diagnostics = ex.InnerException?.Message
                };
                outcome.Issue.Add(issue);
                progressReporter?.Invoke(issue, null, null);
            }
            return outcome;
        }

        public async Task<OperationOutcome> IncludeCanonicalResource(Resource resource, Action<OperationOutcome.IssueComponent, string, Resource> progressReporter = null, CancellationToken ct = new CancellationToken())
        {
            var outcome = new OperationOutcome();
            if (resource is IConformanceResource icr)
            {
                string version = null;
                if (resource is IVersionableConformanceResource ivr)
                {
                    version = ivr.Version;
                }
                var query = _context.ConformanceResource.Where(entity => entity.CanonicalUrl == icr.Url).AsQueryable();
                if (!string.IsNullOrEmpty(version))
                    query = query.Where(entity => entity.Version == version);
                if (!await query.AnyAsync(ct))
                {
                    if (resource is StructureDefinition sd)
                    {
                        // patch some known bad definitions as they are being loaded
                        if (sd.Url == "http://hl7.org/fhir/StructureDefinition/Questionnaire")
                        {
                            var els = sd.Snapshot.Element.SelectMany(el => el.Constraint.Where(c => c.Key == "que-10" || c.Key == "que-7"))
                                .Union(sd.Differential.Element.SelectMany(el => el.Constraint.Where(c => c.Key == "que-10" || c.Key == "que-7")));
                            foreach (var item in els)
                            {
                                // Correct the que-10  invariant
                                if (item.Expression == "(type in ('boolean' | 'decimal' | 'integer' | 'string' | 'text' | 'url')) or maxLength.empty()")
                                    item.Expression = "(type in ('boolean' | 'decimal' | 'integer' | 'string' | 'text' | 'url' | 'open-choice')) or maxLength.empty()";

                                // Correct the que-7 invariant
                                if (item.Expression == "operator = 'exists' implies (answer is Boolean)")
                                    item.Expression = "operator = 'exists' implies (answer is boolean)";
                            }
                        }
                    }
                    var entity = new ConformanceResourceEntity()
                    {
                        ResourceType = resource.TypeName,
                        ResourceId = resource.Id,
                        CanonicalUrl = icr.Url,
                        Version = version,
                        Current = true,
                        ResourceXML = _serializer.SerializeToString(resource)
                    };

                    if (resource is ConceptMap cm)
                    {
                        if (cm.Source is FhirUri fvs)
                            entity.SourceCanonicalUrl = fvs.Value;
                        if (cm.Source is Canonical cvs)
                            entity.SourceCanonicalUrl = cvs.Value;
                        if (cm.Target is FhirUri fvt)
                            entity.TargetCanonicalUrl = fvt.Value;
                        if (cm.Target is Canonical cvt)
                            entity.TargetCanonicalUrl = cvt.Value;
                    }

                    _context.ConformanceResource.Add(entity);
                    await _context.SaveChangesAsync(ct);

                    var issue = new OperationOutcome.IssueComponent()
                    {
                        Severity = OperationOutcome.IssueSeverity.Information,
                        Code = OperationOutcome.IssueType.Informational,
                        Details = new CodeableConcept() { Text = $"Resource Added {icr.Url}|{version}" }
                    };
                    outcome.Issue.Add(issue);
                    progressReporter?.Invoke(issue, icr.Url, resource);
                }
                else
                {
                    var issue = new OperationOutcome.IssueComponent()
                    {
                        Severity = OperationOutcome.IssueSeverity.Information,
                        Code = OperationOutcome.IssueType.Informational,
                        Details = new CodeableConcept() { Text = $"Resource skipped {icr.Url}|{version} - already included" }
                    };
                    outcome.Issue.Add(issue);
                    progressReporter?.Invoke(issue, icr.Url, null);
                }
            }
            else
            {
                // Resource was not a versionable canonical resource
                var issue = new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Code = OperationOutcome.IssueType.Informational,
                    Details = new CodeableConcept() { Text = $"Resource skipped {resource.TypeName}/{resource.Id} - not a conformance resource" }
                };
                outcome.Issue.Add(issue);
                progressReporter?.Invoke(issue, null, null);
            }
            return outcome;
        }

        public CodeSystem FindCodeSystemByValueSet(string valueSetUri)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConceptMap> FindConceptMaps(string sourceUri = null, string targetUri = null)
        {
            throw new NotImplementedException();
        }

        public NamingSystem FindNamingSystem(string uniqueId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ListResourceUris(ResourceType? filter = null)
        {
            var query = _context.ConformanceResource.Where(entity => entity.Current).AsQueryable();
            if (filter.HasValue)
            {
                string filterValue = filter.GetLiteral();
                query = query.Where(entity => entity.ResourceType == filterValue);
            }
            return query.Select(entity => entity.CanonicalUrl).ToList();
        }

        public Resource ResolveByCanonicalUri(string uri)
        {
            string canonical = uri;
            string version = null;
            int index = canonical.IndexOf("|");
            if (index != -1)
            {
                version = canonical.Substring(index+1);
                canonical = canonical.Substring(0, index);
            }

            var query = _context.ConformanceResource.Where(entity => entity.CanonicalUrl == canonical).AsQueryable();
            ConformanceResourceEntity entityResource;
            if (!string.IsNullOrEmpty(version))
            {
                entityResource = query.FirstOrDefault(entity => entity.Version == version);
                if (entityResource != null)
                    return _parser.Parse<Resource>(entityResource.ResourceXML);
            }

            // try grabbing the current one then
            entityResource = query.FirstOrDefault(entity => entity.Current);
            if (entityResource != null)
                return _parser.Parse<Resource>(entityResource.ResourceXML);

            return null;
        }

        public Resource ResolveByUri(string uri)
        {
            return ResolveByCanonicalUri(uri);
        }

        public async Task<Resource> ResolveByUriAsync(string uri)
        {
            string canonical = uri;
            string version = null;
            int index = canonical.IndexOf("|");
            if (index != -1)
            {
                version = canonical.Substring(index + 1);
                canonical = canonical.Substring(0, index);
            }

            var query = _context.ConformanceResource.Where(entity => entity.CanonicalUrl == canonical).AsQueryable();
            ConformanceResourceEntity entityResource;
            if (!string.IsNullOrEmpty(version))
            {
                entityResource = await query.FirstOrDefaultAsync(entity => entity.Version == version);
                if (entityResource != null)
                    return _parser.Parse<Resource>(entityResource.ResourceXML);
            }

            // try grabbing the current one then
            entityResource = await query.FirstOrDefaultAsync(entity => entity.Current);
            if (entityResource != null)
                return _parser.Parse<Resource>(entityResource.ResourceXML);

            return null;
        }

        public Task<Resource> ResolveByCanonicalUriAsync(string uri)
        {
            return ResolveByUriAsync(uri);
        }
    }
}
