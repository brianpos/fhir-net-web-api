/* 
 * Copyright (c) 2017+ brianpos, Furore and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Microsoft.Net.Http.Headers;

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

        // Don't want to spool through the stream here, just pass the stream onto the next level so that it can spool 
        // rather than be complete in a single string to then process
        //protected string ReadBodyFromStream(Stream readStream, HttpContent content)
        //{
        //    var charset = content.Headers.ContentType.CharSet ?? Encoding.UTF8.WebName; // this was headername in WebApi
        //    var encoding = Encoding.GetEncoding(charset);

        //    if (encoding != Encoding.UTF8)
        //        throw new FhirServerException(HttpStatusCode.BadRequest, "FHIR supports UTF-8 encoding exclusively, not " + encoding.WebName);

        //    StreamReader sr = new StreamReader(readStream, Encoding.UTF8, true);
        //    return sr.ReadToEnd();
        //}
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
            return false;
        }

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

                if (resource is Binary)
                {
                    context.HttpContext.Response.Headers.Add(HeaderNames.ContentType, ((Binary)resource).ContentType);
                    context.ContentType = new Microsoft.Extensions.Primitives.StringSegment(((Binary)resource).ContentType);
                }
            }
        }
    }
}