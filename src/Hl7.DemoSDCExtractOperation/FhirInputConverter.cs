/*
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Converters;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hl7.DemoFhirAzureFunctionApp
{
    public class FhirInputConverter : IInputConverter
    {
        static JsonSerializerOptions _deserializerOptions = new JsonSerializerOptions().ForFhir(deserializerSettings: new FhirJsonPocoDeserializerSettings { Validator = null });
        static ParserSettings _settings = new ParserSettings() { AllowUnrecognizedEnums = true, PermissiveParsing = true };

        public async ValueTask<ConversionResult> ConvertAsync(ConverterContext context)
        {
            if (typeof(Resource).IsAssignableFrom(context.TargetType))
            {
                var data = await context.FunctionContext.GetHttpRequestDataAsync();
                if (data.Method != "POST")
                    return ConversionResult.Unhandled();
                using (MemoryStream ms = new MemoryStream())
                {
                    await data.Body.CopyToAsync(ms);
                    ms.Seek(0, SeekOrigin.Begin);

                    if (ContentType.JSON_CONTENT_HEADERS.Contains(data.Headers.GetValues("Content-Type").FirstOrDefault()))
                    {
                        try
                        {
                            var resource = await System.Text.Json.JsonSerializer.DeserializeAsync<Resource>(ms, _deserializerOptions);
                            if (resource != null && !resource.GetType().IsAssignableFrom(context.TargetType))
                            {
                                return ConversionResult.Failed(new ArgumentException("Incorrect type passed in body"));
                            }
                            return ConversionResult.Success(resource);
                        }
                        catch (FormatException exception)
                        {
                            return ConversionResult.Failed(exception);
                        }
                    }

                    if (ContentType.XML_CONTENT_HEADERS.Contains(data.Headers.GetValues("Content-Type").FirstOrDefault()))
                    {
                        using (var reader = SerializationUtil.XmlReaderFromStream(ms))
                        {
                            try
                            {
                                Resource resource = new FhirXmlParser(_settings).Parse<Resource>(reader);
                                if (resource != null && !resource.GetType().IsAssignableFrom(context.TargetType))
                                {
                                    return ConversionResult.Failed(new ArgumentException("Incorrect type passed in body"));
                                }
                                return ConversionResult.Success(resource);
                            }
                            catch (FormatException exception)
                            {
                                return ConversionResult.Failed(exception);
                            }
                        }
                    }
                }
            }
            return ConversionResult.Unhandled();
        }
    }
}
