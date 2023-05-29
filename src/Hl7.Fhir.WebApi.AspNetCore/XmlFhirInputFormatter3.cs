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
using System.ComponentModel.DataAnnotations;
using Hl7.Fhir.Language.Debugging;

namespace Hl7.Fhir.WebApi
{
    public class XmlFhirInputFormatter3 : FhirMediaTypeInputFormatter
    {
        public XmlFhirInputFormatter3() : base()
        {
            foreach (var mediaType in ContentType.XML_CONTENT_HEADERS)
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

            // TODO: Brian: Would like to know what the issue is here? Will this be resolved by the Async update to the core?
            using (MemoryStream ms = new MemoryStream())
            {
                await request.Body.CopyToAsync(ms);
                ms.Seek(0, SeekOrigin.Begin);

                using (var reader = SerializationUtil.XmlReaderFromStream(ms))
                {
                    try
                    {
                        var settings = new FhirXmlPocoDeserializerSettings()
                        {
                            AnnotateResourceParseExceptions = true,
                            ValidateOnFailedParse = true,
                            // Validator = null, // Since we can handle multiple issues, let this through
                        };
                        var ds = new FhirXmlPocoDeserializer(settings);
                        Resource resource = ds.DeserializeResource(reader);
                        return InputFormatterResult.Success(resource);
                    }
                    catch (DeserializationFailedException exception)
                    {
                        throw HandleBodyParsingFormatException(exception);
                    }
                }
            }
        }
    }
}
