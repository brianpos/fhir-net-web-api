﻿/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.WebApi
{
    public class JsonFhirFormatter : FhirMediaTypeFormatter
    {
        public JsonFhirFormatter() : base()
        {
            foreach (var mediaType in ContentType.JSON_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }
        static ParserSettings _settings = new ParserSettings() { AllowUnrecognizedEnums = true, PermissiveParsing = true };

        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = FhirMediaType.GetMediaTypeHeaderValue(type, ResourceFormat.Json);
         //   headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = "fhir.resource.json" };
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            if (!typeof(Resource).IsAssignableFrom(type))
                throw new FhirServerException(HttpStatusCode.BadRequest, "Cannot read unsupported type {0} from body", type.Name);

            try
            {
                var body = base.ReadBodyFromStream(readStream, content);

                var resource = new FhirJsonParser(_settings).Parse<Resource>(body);
                // TODO: Do we need to update the Meta object with context information?
                // entry.Tags = content.Headers.GetFhirTags();
                return System.Threading.Tasks.Task.FromResult<object>(resource);
            }
            catch (FormatException exception)
            {
                throw HandleBodyParsingFormatException(exception);
            }
        }

        public override System.Threading.Tasks.Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            StreamWriter writer = new StreamWriter(writeStream);
            JsonWriter jsonwriter = SerializationUtil.CreateJsonTextWriter(writer); // This will use the BetterJsonWriter which handles precision correctly
            if (type == typeof(OperationOutcome))
            {
                Resource resource = (Resource)value;
                new FhirJsonSerializer().Serialize(resource, jsonwriter);
            }
            else if (typeof(Resource).IsAssignableFrom(type))
            {
                if (value != null)
                {
                    Resource r = value as Resource;
                    SummaryType st = SummaryType.False;
                    if (r.HasAnnotation<SummaryType>())
                        st = r.Annotation<SummaryType>();
                    new FhirJsonSerializer().Serialize(r, jsonwriter, st);
                }
            }
            writer.Flush();
            return System.Threading.Tasks.Task.CompletedTask;
        }
    }
}
