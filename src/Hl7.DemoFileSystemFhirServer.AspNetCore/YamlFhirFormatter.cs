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
using Microsoft.Extensions.Primitives;
using System.Text.Json;

namespace Hl7.Fhir.WebApi
{
    public static class YamlContentType
    {
        public static string[] LooseYamlFormats = { "yaml", "text/yam", "application/x-yaml" };

        public const string YAML_CONTENT_HEADER = "application/fhir+yaml";  // An informal FHIR mime type (still to be registered).
        public static readonly string[] YAML_CONTENT_HEADERS = new string[]
            { YAML_CONTENT_HEADER,
                "text/yaml",
                "application/x-yaml" };

        public const string FORMAT_PARAM_YAML = "yaml";

        public static StringSegment GetMediaTypeHeaderValue(Type type)
        {
            MediaTypeHeaderValue header = new MediaTypeHeaderValue(YAML_CONTENT_HEADER);
            header.Charset = Encoding.UTF8.WebName;
            StringSegment hv = new StringSegment(header.ToString());
            return hv;
        }
    }


    public class YamlFhirInputFormatter : FhirMediaTypeInputFormatter
    {
        public YamlFhirInputFormatter() : base()
        {
            foreach (var mediaType in YamlContentType.YAML_CONTENT_HEADERS)
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

            try
            {
                // parse the YAML
                var r = new StreamReader(request.Body);
                string yamlContent = await r.ReadToEndAsync();
                var deserializer = new YamlDotNet.Serialization.DeserializerBuilder().Build();
                var r2 = new StringReader(yamlContent);
                var yamlObject = deserializer.Deserialize(r2);

                // convert to JSON
                var serializer = new YamlDotNet.Serialization.SerializerBuilder()
                                        .JsonCompatible()
                                        .Build();
                var resource = new FhirJsonParser(_settings).Parse<Resource>(serializer.Serialize(yamlObject));
                return InputFormatterResult.Success(resource);
            }
            catch (FormatException exception)
            {
                throw HandleBodyParsingFormatException(exception);
            }
        }
    }

    public class YamlFhirOutputFormatter : FhirMediaTypeOutputFormatter
    {
        public YamlFhirOutputFormatter() : base()
        {
            foreach (var mediaType in YamlContentType.YAML_CONTENT_HEADERS)
                SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }

        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            context.ContentType = YamlContentType.GetMediaTypeHeaderValue(context.ObjectType);
            // note that the base is called last, as this may overwrite the ContentType where the resource is of type Binary
            base.WriteResponseHeaders(context);
#if NET6_0_OR_GREATER
            if (context.Object is Resource r)
            {
                string id = r.Id ?? Guid.NewGuid().ToFhirId();
                if (id.StartsWith("urn:uuid:"))
                    id = id.Substring(9);
                context.HttpContext.Response.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = $"\"fhir.{r.TypeName}.{id}.yaml\"" }.ToString();
            }
#endif
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
                        jps.SummaryFilter = SerializationFilter.ForElements(r.Annotation<FilterOutputToElements>().Value);
                    }
                    JsonSerializerOptions _serializerOptions = new JsonSerializerOptions().ForFhir(serializerSettings: jps);
                    _serializerOptions.WriteIndented = true; // make it pretty
                    var ms = new MemoryStream();
                    await System.Text.Json.JsonSerializer.SerializeAsync(ms, context.Object, _serializerOptions, context.HttpContext.RequestAborted);
                    ms.Position = 0;

                    using (var sr = new StreamReader(ms))
                    {
                        var ds = new YamlDotNet.Serialization.Deserializer();
                        var yamlObject = ds.Deserialize(sr);
                        var serializer = new YamlDotNet.Serialization.SerializerBuilder()
                                                .Build();
                        var ms2 = new MemoryStream();
                        var sr2 = new StreamWriter(ms2);
                        serializer.Serialize(sr2, yamlObject);
                        sr2.Flush();
                        ms2.Position = 0;
                        await ms2.CopyToAsync(context.HttpContext.Response.Body);
                    }
                }
            }
        }
    }
}
