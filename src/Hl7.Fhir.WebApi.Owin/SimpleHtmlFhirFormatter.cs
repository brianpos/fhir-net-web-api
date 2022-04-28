/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System;
using System.IO;
using Hl7.Fhir.Model;
using System.Text;
using Hl7.Fhir.Utility;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Hl7.Fhir.Rest;

namespace Hl7.Fhir.WebApi
{
    public class SimpleHtmlFhirOutputFormatter : FhirMediaTypeFormatter
    {
        public SimpleHtmlFhirOutputFormatter() : base()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }

        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = new MediaTypeHeaderValue("text/html");
        }

        public override async System.Threading.Tasks.Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            sb.AppendLine("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" integrity=\"sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u\" crossorigin=\"anonymous\">");
            sb.AppendLine("<!-- Optional theme -->");
            sb.AppendLine("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css\" integrity=\"sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp\" crossorigin=\"anonymous\">");
            sb.AppendLine("<!-- Latest compiled and minified JavaScript -->");
            sb.AppendLine("<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\" integrity=\"sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa\" crossorigin=\"anonymous\"></script>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            // sb.AppendLine($"<div>{context.HttpContext.Request.Method}: {context.HttpContext.Request.RequestUri()}<div>");
            // sb.AppendLine($"<div>Status: {context.HttpContext.Response.StatusCode}<div>");
            if (value is Resource resource)
            {
                if (resource == null)
                    sb.AppendLine("<div>(null)</div>");
                else
                {
                    var ct = new System.Threading.CancellationToken();
                    SummaryType st = SummaryType.False;
                    if (resource.HasAnnotation<SummaryType>())
                        st = resource.Annotation<SummaryType>();
                    var partialResource = new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(resource, st);
                    var r2 = new Hl7.Fhir.Serialization.FhirXmlParser().Parse<Resource>(partialResource);
                    var resourceAsXml = r2.ToHtmlXml(ct, resource.ResourceBase?.OriginalString ?? "", st);
                    sb.AppendLine(resourceAsXml);
                    var resourceAsJson = r2.ToHtmlJson(ct, resource.ResourceBase?.OriginalString ?? "", st);
                    sb.AppendLine(resourceAsJson);
                }
            }

            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            StreamWriter writer = new StreamWriter(writeStream, System.Text.Encoding.UTF8);
            await writer.WriteAsync(sb.ToString()).ConfigureAwait(false);
            await writer.FlushAsync().ConfigureAwait(false);
        }
    }
}
