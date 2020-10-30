/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Hl7.Fhir.WebApi
{
    public abstract class FhirMediaTypeFormatter : MediaTypeFormatter
    {
        public FhirMediaTypeFormatter() : base()
        {
            this.SupportedEncodings.Clear();
            this.SupportedEncodings.Add(Encoding.UTF8);
        }

        protected Resource entry = null;
        internal ModelBaseInputs _inputs = null;

        private void setEntryHeaders(HttpContentHeaders headers)
        {
            if (_inputs != null) // this happens if there is a parsing exception on the body
            {
                foreach (var header in _inputs.ResponseHeaders)
                {
                    headers.Add(header.Key, header.Value);
                }
                if (!string.IsNullOrEmpty(_inputs.X_CorelationId))
                {
                    if (headers.Contains("X-Correlation-Id"))
                        headers.Remove("X-Correlation-Id");
                    headers.Add("X-Correlation-Id", _inputs.X_CorelationId);
                }
            }
            if (entry != null)
            {
                if (entry.Meta != null && entry.Meta.LastUpdated.HasValue)
                    headers.LastModified = entry.Meta.LastUpdated.Value.UtcDateTime;
                else
                    headers.LastModified = DateTimeOffset.UtcNow;
                if (!string.IsNullOrEmpty(entry.Id))
                    headers.ContentLocation = new Uri(entry.ResourceIdentity(entry.ResourceBase).OriginalString);

                if (entry is Binary)
                {
                    headers.ContentType = new MediaTypeHeaderValue( ((Binary)entry).ContentType);
                }
            }
        }

        public override bool CanReadType(Type type)
        {
            if (typeof(Resource).IsAssignableFrom(type))
                return true;
            return false;
        }

        public override bool CanWriteType(Type type)
        {
            if (typeof(Resource).IsAssignableFrom(type) || type == typeof(OperationOutcome))
                return true;
            return false;
        }

        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            setEntryHeaders(headers);
        }

        public override MediaTypeFormatter GetPerRequestFormatterInstance(Type type, HttpRequestMessage request, MediaTypeHeaderValue mediaType)
        {
            this.entry = request.GetEntry();
            if (request.Properties.ContainsKey("fhir-inputs"))
                _inputs = request.Properties["fhir-inputs"] as ModelBaseInputs;
            return base.GetPerRequestFormatterInstance(type, request, mediaType);
        }

        protected string ReadBodyFromStream(Stream readStream, HttpContent content)
        {
            var charset = content.Headers.ContentType.CharSet ?? Encoding.UTF8.HeaderName;
            var encoding = Encoding.GetEncoding(charset);

            if (encoding != Encoding.UTF8)
                throw new FhirServerException(HttpStatusCode.BadRequest, "FHIR supports UTF-8 encoding exclusively, not " + encoding.WebName);

            StreamReader sr = new StreamReader(readStream, Encoding.UTF8, true);
            return sr.ReadToEnd();
        }

        static readonly Regex _matchExceptionLocation = new Regex(@"\(at (?<loc>[a-zA-Z\.\[\]0-9]+)\)$");
        protected static Exception HandleBodyParsingFormatException(FormatException exception)
        {
            OperationOutcome oo = new OperationOutcome();
            oo.Issue.Add(new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Fatal,
                Code = OperationOutcome.IssueType.Exception,
                Details = new CodeableConcept() { Text = exception.Message }
            });
            MatchCollection matches = _matchExceptionLocation.Matches(exception.Message);
            if (matches.Count > 0)
            {
                List<string> locs = new List<string>();
                foreach (Match m in matches)
                {
                    locs.Add(m.Groups["loc"].Value);
                    oo.Issue[0].Details.Text = oo.Issue[0].Details.Text.Replace(m.Value, "");
                }
                oo.Issue[0].Location = locs;
            }
            return new FhirServerException(HttpStatusCode.BadRequest, oo, "Body parsing failed: " + exception.Message);
        }
    }
}