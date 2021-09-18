/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Hl7.Fhir.WebApi
{
    public static class Utility
    {
        #region << OperationOutcome Extensions >>
        private static void setContentHeaders(HttpResponseMessage response, ResourceFormat format)
        {
            response.Content.Headers.ContentType = FhirMediaType.GetMediaTypeHeaderValue(typeof(Resource), format);
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
            setContentHeaders(response, target);

            return response;
        }
        #endregion

        #region << WebApi Controller Extensions >>
        public static string CalculateBaseURI(this System.Web.Http.ApiController me, string resourceName)
        {
            Uri ri = me.ControllerContext.Request.RequestUri;
            if (resourceName == "metadata" || resourceName == "${operation}")
            {
                return String.Format("{0}://{1}{2}{3}{4}",
                    ri.Scheme,
                    ri.Host,
                    ri.IsDefaultPort ? "" : ":" + ri.Port.ToString(),
                    me.ControllerContext.RequestContext.VirtualPathRoot.TrimEnd('/') + '/',
                    me.ControllerContext.RouteData.Route.RouteTemplate.Replace("metadata", "").Replace("${operation}", ""));
            }
            if (me.ControllerContext.RouteData.Route.RouteTemplate.Contains("{ResourceName}"))
                resourceName = "{ResourceName}";
            string baseUri = String.Format("{0}://{1}{2}{3}{4}",
                ri.Scheme,
                ri.Host,
                ri.IsDefaultPort ? "" : ":" + ri.Port.ToString(),
                me.ControllerContext.RequestContext.VirtualPathRoot.TrimEnd('/')+'/',
                me.ControllerContext.RouteData.Route.RouteTemplate.Substring(0, me.ControllerContext.RouteData.Route.RouteTemplate.LastIndexOf(resourceName)));
            return baseUri;
        }

        #endregion

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

        #region << Static Utility functions for extracting common fhir types >>
        public static DateTime? ToDateTime(this FhirDateTime me)
        {
            if (me == null)
                return null;
            DateTime result;
            if (DateTime.TryParse(me.Value, out result))
                return result;
            if (!string.IsNullOrEmpty(me.Value))
            {
                // the date didn't parse, one of the common mistakes
                // with dates is not to include the - symbols
                // so lets put them in and proceed
                if (me.Value.Length == 8 && !me.Value.Contains("-"))
                {
                    string newValue = me.Value.Insert(4, "-").Insert(7, "-");
                    System.Diagnostics.Trace.WriteLine(String.Format("Invalid Date [{0}] was encountered, processing it as though it was [{1}]", me.Value, newValue));
                    if (DateTime.TryParse(newValue, out result))
                        return result;
                }
            }
            return null;
        }

        public static DateTime? ToDateTime(this Date me)
        {
            if (me == null)
                return null;
            DateTime result;
            if (DateTime.TryParse(me.Value, out result))
                return result;
            if (!string.IsNullOrEmpty(me.Value))
            {
                // the date didn't parse, one of the common mistakes
                // with dates is not to include the - symbols
                // so lets put them in and proceed
                if (me.Value.Length == 8 && !me.Value.Contains("-"))
                {
                    string newValue = me.Value.Insert(4, "-").Insert(7, "-");
                    System.Diagnostics.Trace.WriteLine(String.Format("Invalid Date [{0}] was encountered, processing it as though it was [{1}]", me.Value, newValue));
                    if (DateTime.TryParse(newValue, out result))
                        return result;
                }
            }
            return null;
        }

        public static string ToFhirId(this System.Guid me)
        {
            return me.ToString("n");
        }

        public static string ToFhirId(this System.Guid? me)
        {
            if (me.HasValue)
                return me.Value.ToString("n");
            return null;
        }

        public static string ToFhirDate(this System.DateTime me)
        {
            return me.ToString("yyyy-MM-dd");
        }

        public static string ToFhirDate(this System.DateTime? me)
        {
            if (me.HasValue)
                return me.Value.ToString("yyyy-MM-dd");
            return null;
        }

        public static string ToFhirDateTime(this System.DateTime me)
        {
            return me.ToString("yyyy-MM-ddTHH:mm:ss.sss");
        }

        public static string ToFhirDateTime(this System.DateTime? me)
        {
            if (me.HasValue)
                return me.Value.ToString("yyyy-MM-ddTHH:mm:ss.sss");
            return null;
        }
        #endregion

    }
}
