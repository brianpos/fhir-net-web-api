/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System;
using System.IO;
using System.Net;
using Microsoft.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Text;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using System.Diagnostics;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.CustomSerializer;
#if NETCOREAPP2_2
using Microsoft.AspNetCore.Http.Internal;
#endif

namespace Hl7.Fhir.WebApi
{
    public class XmlFhirInputFormatter : FhirMediaTypeInputFormatter
    {
        public XmlFhirInputFormatter() : base()
        {
            foreach (var mediaType in ContentType.XML_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            if (encoding.EncodingName != Encoding.UTF8.EncodingName)
                throw new FhirServerException(HttpStatusCode.BadRequest, "FHIR supports UTF-8 encoding exclusively, not " + encoding.WebName);

            // stream out the content
            var xmlParserCustom = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();
            using (var xr = XmlReader.Create(context.HttpContext.Request.Body, FhirCustomXmlReader.Settings))
            {
                var outcome = new OperationOutcome();
                Resource resource = await xmlParserCustom.ParseAsync(xr, outcome, null, context.HttpContext.RequestAborted) as Resource;
                if (!outcome.Success)
                    throw new FhirServerException(HttpStatusCode.BadRequest, outcome);
                return InputFormatterResult.Success(resource);
            }
        }
    }

    public class XmlFhirOutputFormatter : FhirMediaTypeOutputFormatter
    {
        public XmlFhirOutputFormatter() : base()
        {
            foreach (var mediaType in ContentType.XML_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }

        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            context.ContentType = FhirMediaType.GetMediaTypeHeaderValue(context.ObjectType, ResourceFormat.Xml);
            // note that the base is called last, as this may overwrite the ContentType where the resource is of type Binary
            base.WriteResponseHeaders(context);
            //   headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = "fhir.resource.json" };
        }

        public override System.Threading.Tasks.Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (selectedEncoding == null)
                throw new ArgumentNullException(nameof(selectedEncoding));

            if (context.ObjectType != null)
            {
                MemoryStream stream = new MemoryStream();
                using (XmlWriter writer = XmlWriter.Create(stream, FhirCustomXmlWriter.Settings))
                {
                    SummaryType st = SummaryType.False;
                    if (context.ObjectType == typeof(OperationOutcome))
                    {
                        // We will only honor the summary type during serialization of the outcome
                        // if the resource wasn't a stored OpOutcome we are returning
                        OperationOutcome resource = (OperationOutcome)context.Object;
                        if (string.IsNullOrEmpty(resource.Id) && resource.HasAnnotation<SummaryType>())
                            st = resource.Annotation<SummaryType>();
                        if (st == SummaryType.False)
                            FhirCustomXmlWriter.WriteBase(resource, writer, "root", context.HttpContext.RequestAborted);
                        else
                            new FhirXmlSerializer().Serialize(resource, writer, st);
                    }
                    else if (typeof(Resource).IsAssignableFrom(context.ObjectType))
                    {
                        if (context.Object != null)
                        {
                            Resource r = context.Object as Resource;
                            if (r.HasAnnotation<SummaryType>())
                                st = r.Annotation<SummaryType>();
                            if (st == SummaryType.False)
                                FhirCustomXmlWriter.WriteBase(r, writer, "root", context.HttpContext.RequestAborted);
                            else
                                new FhirXmlSerializer().Serialize(r, writer, st);
                        }
                    }
                    writer.Flush();
                    stream.Position = 0;
                    // Write out the content to the output stream
                    return stream.CopyToAsync(context.HttpContext.Response.Body, context.HttpContext.RequestAborted);
                }
            }
            return System.Threading.Tasks.Task.CompletedTask;
        }
    }
}
