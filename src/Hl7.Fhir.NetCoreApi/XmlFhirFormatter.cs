/* 
 * Copyright (c) 2017+ brianpos, Furore and contributors
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
using Microsoft.AspNetCore.Http.Internal;
using System.Reflection;

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

            var request = context.HttpContext.Request;

            // TODO: Brian: Would like to know what the issue is here? Will this be resolved by the Async update to the core?
            if (!request.Body.CanSeek)
            {
                // To avoid blocking on the stream, we asynchronously read everything 
                // into a buffer, and then seek back to the beginning.
                request.EnableRewind();
                Debug.Assert(request.Body.CanSeek);

                // no timeout configuration on this? or does that happen at another layer?
                await request.Body.DrainAsync(CancellationToken.None);
                request.Body.Seek(0L, SeekOrigin.Begin);
            }

            using (var xmlReader = SerializationUtil.XmlReaderFromStream(request.Body))
            {
                try
                {
                    var resource = new FhirXmlParser().Parse<Resource>(xmlReader);
                    return InputFormatterResult.Success(resource);
                }
                catch (FormatException exc)
                {
                    throw new FhirServerException(HttpStatusCode.BadRequest, "Body parsing failed: " + exc.Message);
                }
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

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                OmitXmlDeclaration = true,
                Async = true,
                CloseOutput = true,
                Indent = true,
                NewLineHandling = NewLineHandling.Entitize,
                IndentChars = "  "
            };
            using (XmlWriter writer = XmlWriter.Create(context.HttpContext.Response.Body, settings))
            {
                SummaryType st = SummaryType.False;
                if (context.ObjectType == typeof(OperationOutcome))
                {
                    // We will only honor the summary type during serialization of the outcome
                    // if the resource wasn't a stored OpOutcome we are returning
                    OperationOutcome resource = (OperationOutcome)context.Object;
                    if (string.IsNullOrEmpty(resource.Id) && resource.HasAnnotation<SummaryType>())
                        st = resource.Annotation<SummaryType>();
                    FhirSerializer.SerializeResource(resource, writer, st);
                }
                else if (typeof(Resource).IsAssignableFrom(context.ObjectType))
                {
                    if (context.Object != null)
                    {
                        Resource r = context.Object as Resource;
                        if (r.HasAnnotation<SummaryType>())
                            st = r.Annotation<SummaryType>();
                        FhirSerializer.SerializeResource(r, writer, st);
                    }
                }
                return writer.FlushAsync();
            }
        }
    }
}
