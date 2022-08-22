// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.WebApi;
using Microsoft.Azure.Functions.Worker.Http;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Xml;

namespace Hl7.DemoFhirAzureFunctionApp
{
    public static class HelperStaticFunctions
    {
        static public Hl7.Fhir.Rest.ResourceFormat GetOutputFormat(this HttpRequestData req)
        {
            // Check the _format query parameter
            if (req.FunctionContext.BindingContext.BindingData.ContainsKey("_format"))
            {
                string format = req.FunctionContext.BindingContext.BindingData["_format"] as string;
                if (FhirMediaType.LooseXmlFormats.Contains(format))
                    return Hl7.Fhir.Rest.ResourceFormat.Xml;
                if (FhirMediaType.LooseJsonFormats.Contains(format))
                    return Hl7.Fhir.Rest.ResourceFormat.Json;
            }

            // check for any accept headers included
            foreach (string mimeType in req.Headers.GetValues("Accept"))
            {
                if (FhirMediaType.LooseXmlFormats.Contains(mimeType))
                    return Hl7.Fhir.Rest.ResourceFormat.Xml;
                if (FhirMediaType.LooseJsonFormats.Contains(mimeType))
                    return Hl7.Fhir.Rest.ResourceFormat.Json;
                if (ContentType.XML_CONTENT_HEADERS.Contains(mimeType))
                    return Hl7.Fhir.Rest.ResourceFormat.Xml;
                if (ContentType.JSON_CONTENT_HEADERS.Contains(mimeType))
                    return Hl7.Fhir.Rest.ResourceFormat.Json;
            }

            return Hl7.Fhir.Rest.ResourceFormat.Json;
        }

        static JsonSerializerOptions _serializerOptions = new JsonSerializerOptions() { WriteIndented = true }.ForFhir(serializerSettings: new FhirJsonPocoSerializerSettings());
        static XmlWriterSettings _xmlWriterSettings = new XmlWriterSettings
        {
            Encoding = new UTF8Encoding(false),
            OmitXmlDeclaration = true,
            Async = true,
            CloseOutput = false,
            Indent = true,
            NewLineHandling = NewLineHandling.Entitize,
            IndentChars = "  "
        };

        static public HttpResponseData FormatFhirDataOutput(this HttpRequestData req, HttpStatusCode code, Resource resource)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            // Perform the content negotiation
            var outputFormat = req.GetOutputFormat();

            MemoryStream stream = new MemoryStream();
            if (outputFormat == Hl7.Fhir.Rest.ResourceFormat.Json)
            {
                response.Headers.Add("Content-Type", FhirMediaType.GetMediaTypeHeaderValue(resource?.GetType(), Hl7.Fhir.Rest.ResourceFormat.Json).Value);
                System.Text.Json.JsonSerializer.Serialize(stream, resource, _serializerOptions);
            }
            if (outputFormat == Hl7.Fhir.Rest.ResourceFormat.Xml)
            {
                response.Headers.Add("Content-Type", FhirMediaType.GetMediaTypeHeaderValue(resource?.GetType(), Hl7.Fhir.Rest.ResourceFormat.Xml).Value);
                using (XmlWriter writer = XmlWriter.Create(stream, _xmlWriterSettings))
                {
                    new FhirXmlSerializer().Serialize(resource, writer);
                    writer.Flush();
                }
            }
            stream.Position = 0;
            response.Body = stream;

            return response;
        }
    }
}
