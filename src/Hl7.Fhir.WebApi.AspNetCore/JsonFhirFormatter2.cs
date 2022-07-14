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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System.Text.Json;
using Hl7.Fhir.Language.Debugging;

namespace Hl7.Fhir.WebApi
{
    public class JsonFhirInputFormatter2 : FhirMediaTypeInputFormatter
    {
        public JsonFhirInputFormatter2() : base()
        {
            foreach (var mediaType in ContentType.JSON_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }
        static JsonSerializerOptions _deserializerOptions = new JsonSerializerOptions().ForFhir(deserializerSettings: new FhirJsonPocoDeserializerSettings { Validator = null });

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            if (encoding.EncodingName != Encoding.UTF8.EncodingName)
                throw new FhirServerException(HttpStatusCode.BadRequest, "FHIR supports UTF-8 encoding exclusively, not " + encoding.WebName);

            var request = context.HttpContext.Request;

            try
            {
                var resource = await System.Text.Json.JsonSerializer.DeserializeAsync<Resource>(request.Body, _deserializerOptions, context.HttpContext.RequestAborted);
                return InputFormatterResult.Success(resource);
            }
            catch (FormatException exception)
            {
                throw HandleBodyParsingFormatException(exception);
            }
        }
    }

    public class JsonFhirOutputFormatter2 : FhirMediaTypeOutputFormatter
    {
        public JsonFhirOutputFormatter2() : base()
        {
            foreach (var mediaType in ContentType.JSON_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }

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
                if (typeof(Resource).IsAssignableFrom(context.ObjectType) && context.Object != null)
                {
                    var jps = new FhirJsonPocoSerializerSettings();
                    Resource r = context.Object as Resource;
                    if (r.HasAnnotation<SummaryType>() && !(r is OperationOutcome && string.IsNullOrEmpty(r.Id)))
                    {
                        var st = r.Annotation<SummaryType>();
                        switch (st)
                        {
                            case SummaryType.True:
                                jps.SummaryFilter = SerializationFilter.ForSummary();
                                break;
                            case SummaryType.Text:
                                jps.SummaryFilter = SerializationFilter.ForText();
                                break;
                            case SummaryType.Data:
                                jps.SummaryFilter = SerializationFilter.ForData();
                                break;
                            case SummaryType.Count:
                                // ??? What to do with this?
                                break;
                            case SummaryType.False:
                                break;
                        }
                    }
                    if (r.HasAnnotation<FilterOutputToElements>())
                    {
                        jps.SummaryFilter = SerializationFilter.ForElements(r.Annotation<FilterOutputToElements>().ToString().Split(","));
                    }
                    JsonSerializerOptions _serializerOptions = new JsonSerializerOptions().ForFhir(serializerSettings: jps);
                    _serializerOptions.WriteIndented = true; // make it pretty
                    await System.Text.Json.JsonSerializer.SerializeAsync(context.HttpContext.Response.Body, context.Object, _serializerOptions, context.HttpContext.RequestAborted);
                }
            }
        }
    }
}
