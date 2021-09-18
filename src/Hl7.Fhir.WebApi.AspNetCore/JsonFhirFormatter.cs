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
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text;
using System.Diagnostics;
using Microsoft.AspNetCore.WebUtilities;
using System.Threading;
using System.Buffers;

#if NETCOREAPP2_2
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc.Formatters.Json.Internal;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
#endif

namespace Hl7.Fhir.WebApi
{
    public class JsonFhirInputFormatter : FhirMediaTypeInputFormatter
    {
        public JsonFhirInputFormatter() : base()
        {
            foreach (var mediaType in ContentType.JSON_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }
        static ParserSettings _settings = new ParserSettings() { AllowUnrecognizedEnums = true, PermissiveParsing = true };

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            if (encoding.EncodingName != Encoding.UTF8.EncodingName)
                throw new FhirServerException(HttpStatusCode.BadRequest, "FHIR supports UTF-8 encoding exclusively, not " + encoding.WebName);

            var request = context.HttpContext.Request;

            using (MemoryStream ms = new MemoryStream())
            {
                await request.Body.CopyToAsync(ms);
                ms.Seek(0, SeekOrigin.Begin);

                using (var streamReader = context.ReaderFactory(ms, encoding))
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    // need to configure these properties as is done in 
                    // HL7.Fhir.SerializationUtil.JsonReaderFromJsonText()
                    jsonReader.DateParseHandling = DateParseHandling.None;
                    jsonReader.FloatParseHandling = FloatParseHandling.Decimal;

                    try
                    {
                        var resource = new FhirJsonParser(_settings).Parse<Resource>(jsonReader);
                        return InputFormatterResult.Success(resource);
                    }
                    catch (FormatException exception)
                    {
                        throw HandleBodyParsingFormatException(exception);
                    }
                }
            }
        }
    }

#if !NETCOREAPP2_2
    class ArrayPool : IArrayPool<char>
    {
        internal ArrayPool(ArrayPool<char> pool)
        {
            _pool = pool;
        }
        ArrayPool<char> _pool;

        public char[] Rent(int minimumLength)
        {
            return _pool.Rent(minimumLength);
        }

        public void Return(char[] array)
        {
            _pool.Return(array);
        }
    }
#endif

    public class JsonFhirOutputFormatter : FhirMediaTypeOutputFormatter
    {
        public JsonFhirOutputFormatter(ArrayPool<char> charPool) : base()
        {
            if (charPool == null)
                throw new ArgumentNullException(nameof(charPool));

#if NETCOREAPP2_2
            _charPool = new JsonArrayPool<char>(charPool);
#else
            _charPool = new ArrayPool(charPool);
#endif

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

        public override async System.Threading.Tasks.Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (selectedEncoding == null)
                throw new ArgumentNullException(nameof(selectedEncoding));

            if (context.ObjectType != null)
            {
                // The content is serialized into a memory stream not direct onto the http stream
                // as the FHIR serializer does not support async writing, however the http body
                // doesn't support sync writing
                MemoryStream stream = new MemoryStream();
                using (StreamWriter writer = new StreamWriter(stream))
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
                            new FhirJsonSerializer().Serialize(resource, jsonwriter, st);
                        }
                        else if (typeof(Resource).IsAssignableFrom(context.ObjectType))
                        {
                            if (context.Object != null)
                            {
                                Resource r = context.Object as Resource;
                                if (r.HasAnnotation<SummaryType>())
                                    st = r.Annotation<SummaryType>();
                                new FhirJsonSerializer().Serialize(r, jsonwriter, st);
                            }
                        }
                        jsonwriter.Flush();
                        stream.Position = 0;

                        // Write out the content to the output stream
                        await stream.CopyToAsync(context.HttpContext.Response.Body, context.HttpContext.RequestAborted);
                    }
                }
            }
        }
    }
}
