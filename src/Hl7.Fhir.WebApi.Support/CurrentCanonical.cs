using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.Model;
using Hl7.FhirPath;
using Hl7.FhirPath.Expressions;
using NaturalSort.Extension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Fhir.WebApi
{
    public static class CurrentCanonical
    {
        public static IVersionableConformanceResource Current(IEnumerable<IVersionableConformanceResource> vcrs)
        {
            var comparer = new CurrentCanonicalComparer(vcrs);
            return Ordered(vcrs).FirstOrDefault();
        }

        public static IOrderedEnumerable<IVersionableConformanceResource> Ordered(IEnumerable<IVersionableConformanceResource> vcrs)
        {
            var comparer = new CurrentCanonicalComparer(vcrs);
            return vcrs.OrderBy(StatusPrecedence)
                .ThenByDescending((f) => f, comparer)
                .ThenBy(LastModifiedOrder)
                .ThenBy(ResourceIdOrder);
        }

        public static Func<IVersionableConformanceResource, int> StatusPrecedence = (f) =>
        {
            switch (f.Status)
            {
                case PublicationStatus.Active: return 1;
                case PublicationStatus.Draft: return 2;
                case PublicationStatus.Retired: return 3;
                case PublicationStatus.Unknown: return 4;
                default: return 5;
            }
        };

        public static Func<IVersionableConformanceResource, DateTimeOffset?> LastModifiedOrder = (vcr) =>
        {
            var resource = vcr as DomainResource;
            return resource?.Meta?.LastUpdated;
        };

        public static Func<IVersionableConformanceResource, string> ResourceIdOrder = (vcr) =>
        {
            var resource = vcr as DomainResource;
            return resource.Id;
        };
    }

    public static class CurrentCanonicalExtensions
    {
        public const string ext_versionAlgorithm = "http://hl7.org/fhir/StructureDefinition/versionAlgorithm";
        public static Coding versionAlgorithCoded(this IVersionableConformanceResource vcr)
        {
            var resource = vcr as DomainResource;
            var result = resource?.GetExtensionValue<Coding>(ext_versionAlgorithm);
            return result;
        }
        public static string versionAlgorithFhirPathExpression(this IVersionableConformanceResource vcr)
        {
            var resource = vcr as DomainResource;
            var result = resource?.GetStringExtension(ext_versionAlgorithm);
            return result;
        }
        public static void versionAlgorithm(this IVersionableConformanceResource vcr, string fhirpathExpression)
        {
            var resource = vcr as DomainResource;
            resource?.RemoveExtension(ext_versionAlgorithm);
            resource?.SetStringExtension(ext_versionAlgorithm, fhirpathExpression);
        }
        public static void versionAlgorithm(this IVersionableConformanceResource vcr, Coding algorithm)
        {
            var resource = vcr as DomainResource;
            resource?.RemoveExtension(ext_versionAlgorithm);
            resource?.SetExtension(ext_versionAlgorithm, algorithm);
        }
    }

    public class CurrentCanonicalComparer : IComparer<IVersionableConformanceResource>
    {
        public CurrentCanonicalComparer(IEnumerable<IVersionableConformanceResource> vcrs)
        {
            _algorithm = Algorithm.alpha;
            var fhirpath = vcrs.FirstOrDefault(vcr => !string.IsNullOrEmpty(vcr.versionAlgorithFhirPathExpression())).versionAlgorithFhirPathExpression();
            if (!string.IsNullOrEmpty(fhirpath))
            {
                _algorithm = Algorithm.fhirpath;
                _fhirpathExpression = fhirpath;
                _st = new SymbolTable(FhirPathCompiler.DefaultSymbolTable);
                Hl7.FhirPath.FhirPathCompiler compiler = new Hl7.FhirPath.FhirPathCompiler(_st);
                _fhirpathCompiledExpression = compiler.Compile(_fhirpathExpression);
                System.Diagnostics.Trace.WriteLine("Sorting by Fhirpath expression");
            }
            else
            {
                var coding = vcrs.FirstOrDefault(vcr => vcr.versionAlgorithCoded() != null).versionAlgorithCoded();
                if (coding != null)
                {
                    switch (coding.Code)
                    {
                        case "semver": _algorithm = Algorithm.semver; break;
                        case "integer": _algorithm = Algorithm.integer; break;
                        case "alpha": _algorithm = Algorithm.alpha; break;
                        case "date": _algorithm = Algorithm.date; break;
                        case "natural": _algorithm = Algorithm.natural; break;
                    }
                }
                System.Diagnostics.Trace.WriteLine($"Sorting by {_algorithm}");
            }

            // if no engine is found, try to deduce what versioning mechanism was intended

        }

        private enum Algorithm
        {
            semver,
            integer,
            alpha,
            date,
            natural,
            fhirpath
        };
        private Algorithm _algorithm;
        private string _fhirpathExpression;
        CompiledExpression _fhirpathCompiledExpression;
        SymbolTable _st;
        private NaturalSortComparer _nsComparer = new NaturalSortComparer(StringComparison.OrdinalIgnoreCase);

        public int Compare(IVersionableConformanceResource x, IVersionableConformanceResource y)
        {
            switch (_algorithm)
            {
                case Algorithm.alpha: return String.Compare(x.Version, y.Version);
                case Algorithm.date: return String.Compare(x.Version, y.Version);
                case Algorithm.integer:
                    {
                        if (decimal.TryParse(x.Version, out decimal xD) && decimal.TryParse(y.Version, out decimal yD))
                            return xD.CompareTo(yD);
                        System.Diagnostics.Trace.WriteLine($"Unable to compare {x.Version} to {y.Version}");
                        return 0;
                    }
                case Algorithm.semver:
                    {
                        var xS = Semver.SemVersion.Parse(x.Version, Semver.SemVersionStyles.Any);
                        var yS = Semver.SemVersion.Parse(y.Version, Semver.SemVersionStyles.Any);
                        return xS.CompareSortOrderTo(yS);
                        //var xS = Hl7.Fhir.Utility.SemVersion.Parse(x.Version);
                        //var yS = Utility.SemVersion.Parse(y.Version);
                        //return Utility.SemVersion.Compare(xS, yS);
                    }
                case Algorithm.natural:
                    return _nsComparer.Compare(x.Version, y.Version);
                case Algorithm.fhirpath:
                    {
                        var dv = ElementNode.ForPrimitive(true);
						var ec = new FhirEvaluationContext(dv);
						ec.Environment.Add("version1", ElementNode.CreateList(ElementNode.ForPrimitive(x.Version)));
						ec.Environment.Add("version2", ElementNode.CreateList(ElementNode.ForPrimitive(y.Version)));

                        var value = _fhirpathCompiledExpression(dv, ec).FirstOrDefault().Value;
                        if (value is Integer i)
                            return i.Value ?? 0;
                        break;
                    }
            }
            return String.Compare(x.Version, y.Version);
        }
    }
}
