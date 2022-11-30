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
            _algorithm = algorithm.alpha;
            var fhirpath = vcrs.FirstOrDefault(vcr => !string.IsNullOrEmpty(vcr.versionAlgorithFhirPathExpression())).versionAlgorithFhirPathExpression();
            if (!string.IsNullOrEmpty(fhirpath))
            {
                _algorithm = algorithm.fhirpath;
                _fhirpathExpression = fhirpath;
                _st = new SymbolTable(FhirPathCompiler.DefaultSymbolTable);
                _st.AddVar("version1", "");
                _st.AddVar("version2", "");
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
                        case "semver": _algorithm = algorithm.semver; break;
                        case "integer": _algorithm = algorithm.integer; break;
                        case "alpha": _algorithm = algorithm.alpha; break;
                        case "date": _algorithm = algorithm.date; break;
                        case "natural": _algorithm = algorithm.natural; break;
                    }
                }
                System.Diagnostics.Trace.WriteLine($"Sorting by {_algorithm}");
            }

            // if no engine is found, try to deduce what versioning mechanism was intended

        }

        private enum algorithm
        {
            semver,
            integer,
            alpha,
            date,
            natural,
            fhirpath
        };
        private algorithm _algorithm;
        private string _fhirpathExpression;
        CompiledExpression _fhirpathCompiledExpression;
        SymbolTable _st;
        private NaturalSortComparer _nsComparer = new NaturalSortComparer(StringComparison.OrdinalIgnoreCase);

        public int Compare(IVersionableConformanceResource x, IVersionableConformanceResource y)
        {
            switch (_algorithm)
            {
                case algorithm.alpha: return String.Compare(x.Version, y.Version);
                case algorithm.date: return String.Compare(x.Version, y.Version);
                case algorithm.integer:
                    {
                        if (decimal.TryParse(x.Version, out decimal xD) && decimal.TryParse(y.Version, out decimal yD))
                            return xD.CompareTo(yD);
                        System.Diagnostics.Trace.WriteLine($"Unable to compare {x.Version} to {y.Version}");
                        return 0;
                    }
                case algorithm.semver:
                    {
                        var xS = Hl7.Fhir.Utility.SemVersion.Parse(x.Version);
                        var yS = Utility.SemVersion.Parse(y.Version);
                        return Utility.SemVersion.Compare(xS, yS);
                    }
                case algorithm.natural:
                    return _nsComparer.Compare(x.Version, y.Version);
                case algorithm.fhirpath:
                    {
                        _st.AddVar("version1", x.Version);
                        _st.AddVar("version2", y.Version);
                        var value = _fhirpathCompiledExpression(null, new EvaluationContext()).FirstOrDefault().Value;
                        if (value is Integer i)
                            return i.Value ?? 0;
                        break;
                    }
            }
            return String.Compare(x.Version, y.Version);
        }
    }
}
