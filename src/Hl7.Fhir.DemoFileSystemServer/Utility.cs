﻿/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.WebApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Hl7.Fhir.DemoFileSystemFhirServer
{
    public static class Utility
    {
        #region << OperationOutcome Extensions >>
        static OperationOutcome.IssueSeverity IssueSeverityOf(HttpStatusCode code)
        {
            int range = ((int)code % 100);
            switch (range)
            {
                case 100:
                case 200: return OperationOutcome.IssueSeverity.Information;
                case 300: return OperationOutcome.IssueSeverity.Warning;
                case 400: return OperationOutcome.IssueSeverity.Error;
                case 500: return OperationOutcome.IssueSeverity.Fatal;
                default: return OperationOutcome.IssueSeverity.Information;
            }
        }

        public static OperationOutcome Init(this OperationOutcome outcome)
        {
            if (outcome.Issue == null)
            {
                outcome.Issue = new List<OperationOutcome.IssueComponent>();
            }
            return outcome;
        }

        public static OperationOutcome Error(this OperationOutcome outcome, Exception exception)
        {
            string message;

            if (exception is FhirServerException)
                message = exception.Message;
            else
                message = string.Format("{0}: {1}", exception.GetType().Name, exception.Message);

            var baseResult = outcome.Error(message);

            // Don't add a stack trace if this is an acceptable logical-level error
            if (!(exception is FhirServerException))
            {
                var stackTrace = new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, exception.StackTrace)
                };
                baseResult.Issue.Add(stackTrace);
            }

            return baseResult;
        }

        public static OperationOutcome Error(this OperationOutcome outcome, string message)
        {
            return outcome.AddIssue(OperationOutcome.IssueSeverity.Error, message);
        }

        public static OperationOutcome Message(this OperationOutcome outcome, string message)
        {
            return outcome.AddIssue(OperationOutcome.IssueSeverity.Information, message);
        }

        public static OperationOutcome Message(this OperationOutcome outcome, HttpStatusCode code, string message)
        {
            return outcome.AddIssue(IssueSeverityOf(code), message);
        }

        private static OperationOutcome AddIssue(this OperationOutcome outcome, OperationOutcome.IssueSeverity severity, string message)
        {
            if (outcome.Issue == null) outcome.Init();

            var item = new OperationOutcome.IssueComponent()
            {
                Severity = severity,
                Details = new CodeableConcept(null, null, message)
            };
            outcome.Issue.Add(item);
            return outcome;
        }

        public static HttpResponseMessage ToHttpResponseMessage(this OperationOutcome outcome, ResourceFormat target, HttpRequestMessage request)
        {
            byte[] data = null;
            if (target == ResourceFormat.Xml)
                data = new FhirXmlSerializer().SerializeToBytes((OperationOutcome)outcome);
            else if (target == ResourceFormat.Json)
                data = new FhirJsonSerializer().SerializeToBytes((OperationOutcome)outcome);

            HttpResponseMessage response = new HttpResponseMessage();
            //setResponseHeaders(response, target);
            response.Content = new ByteArrayContent(data);
            // setContentHeaders(response, target);
            // ObjectResult result = new ObjectResult(outcome) {  };
            Debugger.Break();
            return response;
        }
        #endregion

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

        #region << Div Content Formatting helpers >>
        public const string TextDivFieldType = "span";
        public const string TextDivFieldStyle = " style=\"color: gray;\"";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textContent"></param>
        /// <param name="fieldname">The fieldname to be displayed as a prefix</param>
        /// <param name="format">the format string, 
        /// {0} is the HTML element type to use for the field - set at span
        /// {1} is the style to be used in this HTML field span
        /// {2} is the name of the field
        /// </param>
        /// <param name="args"></param>
        static public void AppendFormatFHIRFields(this StringBuilder textContent, string fieldname, string format, params object[] args)
        {
            if (!string.IsNullOrEmpty(fieldname))
                textContent.AppendFormat("		<{0}{1}>{2}:</{0}> ", TextDivFieldType, TextDivFieldStyle, fieldname);
            textContent.AppendFormat(format, args);
            textContent.AppendFormat("<br/>\r\n");
        }

        public static Hl7.Fhir.Model.Narrative CreateNarative(string div)
        {
            var n = new Hl7.Fhir.Model.Narrative();
            if (!string.IsNullOrEmpty(div) && !div.StartsWith("<div", StringComparison.CurrentCultureIgnoreCase))
                n.Div = String.Format("<div xmlns=\"http://www.w3.org/1999/xhtml\">{0}</div>", div);
            else
                n.Div = div;
            return n;
        }

        public static Hl7.Fhir.Model.CodeableConcept CreateCodeableConcept(string system, string code)
        {
            if (string.IsNullOrEmpty(code))
                return null;
            if (!system.StartsWith("http://"))
                system = "http://" + system;
            var n = new Hl7.Fhir.Model.CodeableConcept(system, code);
            return n;
        }

        public static string[] CreateStringArray(object value)
        {
            if (value == null)
                return null;
            if (value is string)
                return (value as string).Split('\r');
            return null;
        }
        #endregion

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

            var mapping = BaseFhirParser.Inspector.ImportType(resource.GetType());
            var propMappings = mapping.PropertyMappings.Where(t => t.ElementType.Name == "ResourceReference" || t.ElementType.Name == "Resource" || t.ElementType.BaseType.Name == "BackboneElement" || t.Choice == Hl7.Fhir.Introspection.ChoiceType.DatatypeChoice);
            foreach (var item in propMappings)
            {
                if (item.ElementType.BaseType.Name == "BackboneElement")
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
                else if (item.ElementType.Name == "Resource")
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
