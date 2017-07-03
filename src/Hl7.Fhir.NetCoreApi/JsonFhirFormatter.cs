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
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text;
using System.Reflection;
using Microsoft.AspNetCore.Http.Internal;
using System.Diagnostics;
using Microsoft.AspNetCore.WebUtilities;
using System.Threading;
using System.Buffers;
using Microsoft.AspNetCore.Mvc.Formatters.Json.Internal;

namespace Hl7.Fhir.WebApi
{
    public class JsonFhirInputFormatter : FhirMediaTypeInputFormatter
    {
        public JsonFhirInputFormatter() : base()
        {
            foreach (var mediaType in ContentType.JSON_CONTENT_HEADERS)
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

            using (var streamReader = context.ReaderFactory(request.Body, encoding))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                // need to configure these properties as is done in 
                // HL7.Fhir.SerializationUtil.JsonReaderFromJsonText()
                jsonReader.DateParseHandling = DateParseHandling.None;
                jsonReader.FloatParseHandling = FloatParseHandling.Decimal;

                try
                {
                    var resource = new FhirJsonParser().Parse<Resource>(jsonReader);
                    return InputFormatterResult.Success(resource);
                }
                catch (FormatException exception)
                {
                    throw new FhirServerException(HttpStatusCode.BadRequest, "Body parsing failed: " + exception.Message);
                }
            }
        }
    }
    public class JsonFhirOutputFormatter : FhirMediaTypeOutputFormatter
    {
        public JsonFhirOutputFormatter(ArrayPool<char> charPool) : base()
        {
            if (charPool == null)
                throw new ArgumentNullException(nameof(charPool));

            _charPool = new JsonArrayPool<char>(charPool);

            foreach (var mediaType in ContentType.JSON_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }

        private readonly IArrayPool<char> _charPool;

        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            context.ContentType = FhirMediaType.GetMediaTypeHeaderValue(context.ObjectType, ResourceFormat.Json);
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

            using (StreamWriter writer = new StreamWriter(context.HttpContext.Response.Body))
            {
                JsonTextWriter jsonwriter = (JsonTextWriter)SerializationUtil.CreateJsonTextWriter(writer); // This will use the BetterJsonWriter which handles precision correctly
                using (jsonwriter)
                {
                    jsonwriter.ArrayPool = _charPool;
                    jsonwriter.Formatting = Formatting.Indented; // lets make it pretty

                    SummaryType st = SummaryType.False;
                    if (context.ObjectType == typeof(OperationOutcome))
                    {
                        // We will only honor the summary type during serialization of the outcome
                        // if the resource wasn't a stored OpOutcome we are returning
                        OperationOutcome resource = (OperationOutcome)context.Object;
                        if (string.IsNullOrEmpty(resource.Id) && resource.HasAnnotation<SummaryType>())
                            st = resource.Annotation<SummaryType>();
                        FhirSerializer.SerializeResource(resource, jsonwriter, st);
                    }
                    else if (typeof(Resource).IsAssignableFrom(context.ObjectType))
                    {
                        if (context.Object != null)
                        {
                            Resource r = context.Object as Resource;
                            if (r.HasAnnotation<SummaryType>())
                                st = r.Annotation<SummaryType>();
                            FhirSerializer.SerializeResource(r, jsonwriter, st);
                        }
                    }
                    return writer.FlushAsync();
                }
            }
        }
    }
}
