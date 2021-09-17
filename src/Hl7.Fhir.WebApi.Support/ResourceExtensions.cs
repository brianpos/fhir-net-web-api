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
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Fhir.WebApi
{
    public static class ResourceExtensions
    {
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
        #endregion

        public static Uri AppendToQuery(this Uri me, string query)
        {
            if (string.IsNullOrEmpty(me.Query))
                return new Uri(me.OriginalString + "?" + query.TrimStart('?').TrimEnd('&'));
            return new Uri(me.OriginalString + "&" + query.TrimEnd('&'));
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
