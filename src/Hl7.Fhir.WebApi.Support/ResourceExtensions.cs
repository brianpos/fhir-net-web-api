/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Hl7.Fhir.WebApi
{
    public static class ResourceExtensions
    {
        public const string SubsettedSystem = "http://terminology.hl7.org/CodeSystem/v3-ObservationValue";

        #region << Parameter Extractions Extensions >>
        public static string GetString(this Parameters me, string name)
        {
            var value = me.Parameter.Where(s => s.Name == name).FirstOrDefault();
            if (value == null)
                return null;
            if (value.Value as FhirString != null)
                return ((FhirString)value.Value).Value;
            if (value.Value as FhirUri != null)
                return ((FhirUri)value.Value).Value;
            return null;
        }

        public static Resource GetResource(this Parameters me, string name)
        {
            var value = me.Parameter.Where(s => s.Name == name).FirstOrDefault();
            if (value == null)
                return null;
            return value.Resource;
        }

        public static Hl7.Fhir.Rest.SummaryType? GetSummaryParameter(this IEnumerable<KeyValuePair<string, string>> parameters)
        {
            string s = parameters.Where(k => k.Key == "_summary").FirstOrDefault().Value;
            if (s == null)
                return Hl7.Fhir.Rest.SummaryType.False;

            switch (s.ToLower())
            {
                case "true": return Hl7.Fhir.Rest.SummaryType.True;
                case "false": return Hl7.Fhir.Rest.SummaryType.False;
                case "text": return Hl7.Fhir.Rest.SummaryType.Text;
                case "data": return Hl7.Fhir.Rest.SummaryType.Data;
                case "count": return Hl7.Fhir.Rest.SummaryType.Count;
            }
            return null;
        }
        #endregion

        public static Uri AppendToQuery(this Uri me, string query)
        {
            if (string.IsNullOrEmpty(me.Query))
                return new Uri(me.OriginalString + "?" + query.TrimStart('?').TrimEnd('&'));
            return new Uri(me.OriginalString + "&" + query.TrimEnd('&'));
        }

        /// <summary>
        /// Convert the FhirDateTime to a DateTimeOffset, but without forcing the timezone offset to some arbitrary zone
        /// instead retaining the offset included in the value
        /// (this routine will set to UTC if the content does not contain a zone itself)
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static DateTimeOffset? ToDateTimeOffsetForFacade(this Hl7.Fhir.Model.FhirDateTime me)
        {
            // TODO: Complain bitterly that this is lossy and very brittle outside GMT/UTC zones
            // This loses the data that is in the value
            // return me.ToDateTimeOffset(DateTimeOffset.Now.Offset);
            // This is an extract of the code that eventually gets hit by the above call, except without forcing the data
            // to any pre-defined timezone, allow it to remain in it's native zone representation.
            // (not UTC or some server defined value)

            // May not be just a time spec (without a date). Look for values like Thh:mm or hh:mm
            if (me.Value.IndexOf(":") == 2 || me.Value.IndexOf(":") == 3)
                return null;
                // throw Error.Format("A date(time) cannot contain just a time");

            if (!me.Value.Contains("T") && me.Value.Length <= 10)
            {
                // MV: when there is no time-part, consider this then as a UTC datetime by adding Zulu = UTC(+0)
                return XmlConvert.ToDateTimeOffset(me.Value + "Z");
            }
            return XmlConvert.ToDateTimeOffset(me.Value);
        }

        #region << Resource Extension Methods >>
        public static List<String> ReservedSearchParams = new List<string>() { "_id", "_language", "_lastUpdated", "_profile", "_security", "_tag", "_has" };

        public static IEnumerable<KeyValuePair<string, string>> TupledParameters(this System.Collections.Specialized.NameValueCollection query, bool filterReservedParameters)
        {
            var list = new List<KeyValuePair<string, string>>();

            if (query.HasKeys())
            {
                foreach (string key in query.Keys)
                {
                    if (!filterReservedParameters || !key.StartsWith("_") || ReservedSearchParams.Contains(key))
                        list.Add(new KeyValuePair<string, string>(key, query[key]));
                }
            }
            return list;
        }

        public static List<ResourceReference> AllReferences(this Base resource)
        {
            List<ResourceReference> results = new List<ResourceReference>();
            if (resource == null)
                return results;

            if (resource is IExtendable extendable)
            {
                foreach (var i in extendable.Extension)
                {
                    if (i.Value is ResourceReference resRef)
                        results.Add(resRef);
                }
            }
            if (resource is IModifierExtendable modExtendable)
            {
                foreach (var i in modExtendable.ModifierExtension)
                {
                    if (i.Value is ResourceReference resRef)
                        results.Add(resRef);
                }
            }

            ClassMapping mapping;
            ClassMapping.TryGetMappingForType(resource.GetType(), Specification.FhirRelease.R4, out mapping);
            var propMappings = mapping.PropertyMappings.Where(t => t.ImplementingType.Name == "ResourceReference" || t.ImplementingType.Name == "Resource" || t.ImplementingType.BaseType.Name == "BackboneElement" || t.Choice == Hl7.Fhir.Introspection.ChoiceType.DatatypeChoice);
            foreach (var item in propMappings)
            {
                if (item.ImplementingType.BaseType.Name == "BackboneElement")
                {
                    if (item.IsCollection)
                    {
                        System.Collections.IEnumerable col = item.GetValue(resource) as System.Collections.IEnumerable;
                        foreach (var e in col)
                        {
                            BackboneElement be = e as BackboneElement;
                            results.AddRange(be.AllReferences());
                        }
                    }
                    else
                    {
                        BackboneElement be = item.GetValue(resource) as BackboneElement;
                        results.AddRange(be.AllReferences());
                    }
                }
                else if (item.ImplementingType.Name == "Resource")
                {
                    if (item.IsCollection)
                    {
                        System.Collections.IEnumerable col = item.GetValue(resource) as System.Collections.IEnumerable;
                        foreach (var e in col)
                        {
                            Resource r = e as Resource;
                            results.AddRange(r.AllReferences());
                        }
                    }
                    else
                    {
                        Resource r = item.GetValue(resource) as Resource;
                        results.AddRange(r.AllReferences());
                    }
                }
                else
                {
                    if (item.IsCollection)
                    {
                        System.Collections.IEnumerable col = item.GetValue(resource) as System.Collections.IEnumerable;
                        foreach (var e in col)
                        {
                            ResourceReference rr = e as ResourceReference;
                            if (rr != null)
                                results.Add(rr);
                        }
                    }
                    else
                    {
                        ResourceReference rr = item.GetValue(resource) as ResourceReference;
                        if (rr != null)
                            results.Add(rr);
                    }
                }
            }
            return results;
        }
        #endregion
    }
}
