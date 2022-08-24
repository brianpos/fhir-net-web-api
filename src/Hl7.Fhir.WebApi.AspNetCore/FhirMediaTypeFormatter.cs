/*
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Text;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Builder;
using System.Net;
using System.Text.RegularExpressions;
using System.Linq;
using Hl7.Fhir.Serialization;

namespace Hl7.Fhir.WebApi
{
    public abstract class FhirMediaTypeInputFormatter : TextInputFormatter
    {
        public FhirMediaTypeInputFormatter() : base()
        {
            this.SupportedEncodings.Clear();
            this.SupportedEncodings.Add(UTF8EncodingWithoutBOM); // Encoding.UTF8);
        }

        /// <summary>
        /// This is set by the actual formatter (xml or json)
        /// </summary>
        protected Resource entry = null;

        protected override bool CanReadType(Type type)
        {
            if (typeof(Resource).IsAssignableFrom(type))
                return true;
            return false;
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
                oo.Issue[0].Location = matches.Select(m => m.Groups["loc"].Value);
                foreach (Match m in matches)
                {
                    oo.Issue[0].Details.Text = oo.Issue[0].Details.Text.Replace(m.Value, "");
                }
            }
            return new FhirServerException(HttpStatusCode.BadRequest, oo, "Body parsing failed: " + exception.Message);
        }

        protected static Exception HandleBodyParsingFormatException(DeserializationFailedException exception)
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
                oo.Issue[0].Location = matches.Select(m => m.Groups["loc"].Value);
                foreach (Match m in matches)
                {
                    oo.Issue[0].Details.Text = oo.Issue[0].Details.Text.Replace(m.Value, "");
                }
            }
            return new FhirServerException(HttpStatusCode.BadRequest, oo, "Body parsing failed: " + exception.Message);
        }
    }

    public abstract class FhirMediaTypeOutputFormatter : TextOutputFormatter
    {
        public FhirMediaTypeOutputFormatter() : base()
        {
            this.SupportedEncodings.Clear();
            this.SupportedEncodings.Add(Encoding.UTF8);
        }

        protected override bool CanWriteType(Type type)
        {
            // Do we need to call the base implementation?
            // base.CanWriteType(type);
            if (type == typeof(OperationOutcome))
                return true;
            if (typeof(Resource).IsAssignableFrom(type))
                return true;
            // The null case here is to support the deleted FhirObjectResult
            if (type == null)
                return true;
            return false;
        }

        const string x_correlation_id = "X-Correlation-Id";
        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            base.WriteResponseHeaders(context);
            if (context.Object is Hl7.Fhir.Model.Resource resource)
            {
                // output the Last-Modified header using the RFC1123 format
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings?view=netframework-4.7
                if (resource.Meta != null && resource.Meta.LastUpdated.HasValue)
                    context.HttpContext.Response.Headers.Add(HeaderNames.LastModified, resource.Meta.LastUpdated.Value.UtcDateTime.ToString("r"));
                else
                    context.HttpContext.Response.Headers.Add(HeaderNames.LastModified, DateTimeOffset.UtcNow.ToString("r"));
                if (resource.Meta != null && !String.IsNullOrEmpty(resource.Meta.VersionId))
                    context.HttpContext.Response.Headers.Add(HeaderNames.ETag, $"W/\"{resource.Meta.VersionId}\"");
                if (!string.IsNullOrEmpty(resource.Id))
                    context.HttpContext.Response.Headers.Add(HeaderNames.Location, resource.ResourceIdentity(resource.ResourceBase).OriginalString);

                if (resource is Binary && context.HttpContext.Request.Headers[HeaderNames.Accept] == FhirMediaType.BinaryResource)
                {
                    context.HttpContext.Response.Headers[HeaderNames.ContentType] = ((Binary)resource).ContentType;
                    context.ContentType = new Microsoft.Extensions.Primitives.StringSegment(((Binary)resource).ContentType);
                }
            }

            if (context.HttpContext.Items.ContainsKey("fhir-inputs"))
            {
                ModelBaseInputs inputs = context.HttpContext.Items["fhir-inputs"] as ModelBaseInputs;
                if (inputs != null)
                {
                    foreach (var header in inputs.ResponseHeaders)
                    {
                        context.HttpContext.Response.Headers.Add(header.Key, new Microsoft.Extensions.Primitives.StringValues(header.Value.ToArray()));
                    }
                }
            }

            // echo any X-Correlation-Id Headers if encountered
            if (context.HttpContext.Request.Headers.ContainsKey(x_correlation_id))
            {
                if (!context.HttpContext.Response.Headers.ContainsKey(x_correlation_id))
                    context.HttpContext.Response.Headers.Add(x_correlation_id, context.HttpContext.Request.Headers[x_correlation_id]);
                if (context.HttpContext.Request.Headers[x_correlation_id] != context.HttpContext.Response.Headers[x_correlation_id])
                    System.Diagnostics.Trace.WriteLine($"Hl7.Fhir.WebApi.FhirMediaTypeOutputFormatter: X-Correlation-Id headers didn't match request vs response");
            }
        }
    }
}