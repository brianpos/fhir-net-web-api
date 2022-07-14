/*
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Text;

namespace Hl7.Fhir.WebApi
{
    public class SimpleHtmlFhirOutputFormatter : FhirMediaTypeOutputFormatter
    {
        public SimpleHtmlFhirOutputFormatter() : base()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }

        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            context.ContentType = new Microsoft.Extensions.Primitives.StringSegment("text/html");
            context.HttpContext.Response.GetTypedHeaders().CacheControl = new CacheControlHeaderValue() { NoCache = true };
            base.WriteResponseHeaders(context);
        }

        public override async System.Threading.Tasks.Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (selectedEncoding == null)
                throw new ArgumentNullException(nameof(selectedEncoding));


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            sb.AppendLine("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" integrity=\"sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u\" crossorigin=\"anonymous\">");
            sb.AppendLine("<!-- Optional theme -->");
            sb.AppendLine("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css\" integrity=\"sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp\" crossorigin=\"anonymous\">");
            sb.AppendLine("<!-- Latest compiled and minified JavaScript -->");
            // sb.AppendLine("<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\" integrity=\"sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa\" crossorigin=\"anonymous\"></script>");
            sb.AppendLine("<style>");
            sb.AppendLine(".fhir_resource { white-space: pre-wrap; padding: 0px 12px 12px 12px; border: 1pt solid lightgrey; overflow-wrap: break-word; } .fhir_resource > br, .fhir_resource span > br { display: none; } .fhir_resource .canonical, .fhir_resource .reference { font-weight: bold; color: blue;} .fhir_resource span { white-space: pre-wrap; } .fhir_resource span.contained { color: darkgrey; }");
            sb.AppendLine("</style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body class=\"container\">");
            sb.AppendLine($"<div class=\"code\">{context.HttpContext.Request.Method}: {context.HttpContext.Request.RequestUri()}<div>");
            sb.AppendLine($"<div>Status: {context.HttpContext.Response.StatusCode}<div>");
            if (context.Object is Resource resource)
            {
                var ri = new ResourceIdentity(context.HttpContext.Request.RequestUri().GetLeftPart(UriPartial.Path)).OriginalString;
                var resRi = resource.ResourceIdentity();
                if (resRi?.OriginalString == ri || resRi?.WithoutVersion().OriginalString == ri)
                {
                    // This is an actual resource coming back
                    sb.AppendLine($"<a class=\"btn btn-primary\" href=\"{resRi.WithoutVersion().OriginalString}\">current</a> ");
                    sb.AppendLine($"<a class=\"btn bg-secondary\" href=\"{resRi.WithoutVersion().OriginalString}/_history\">versions</a> ");
                    if (!string.IsNullOrEmpty(resRi.VersionId))
                        sb.AppendLine($"<a class=\"btn bg-secondary\" href=\"{resRi.OriginalString}\">v{resRi.VersionId}</a> ");
                    if (resource is DomainResource domainResource && !string.IsNullOrEmpty(domainResource.Text?.Div))
                    {
                        sb.AppendLine("<hr/>");
                        sb.AppendLine(domainResource.Text.Div);
                    }
                }
                if (resource == null)
                    sb.AppendLine("<div>(null)</div>");
                else
                {
                    SummaryType st = SummaryType.False;
                    if (resource.HasAnnotation<SummaryType>() && (!(resource is OperationOutcome) || (resource as OperationOutcome).Id == null))
                        st = resource.Annotation<SummaryType>();
                    var ct = new System.Threading.CancellationToken();
                    var resourceAsXml = resource.ToHtmlXml(ct, resource.ResourceBase?.OriginalString ?? "", st);
                    sb.AppendLine(resourceAsXml);
                    //var resourceAsJson = resource.ToHtmlJson(ct, resource.ResourceBase?.OriginalString ?? "", st);
                    //sb.AppendLine(resourceAsJson);
                }
            }

            sb.AppendLine("<br/>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            StreamWriter writer = new StreamWriter(context.HttpContext.Response.Body, System.Text.Encoding.UTF8);
            await writer.WriteAsync(sb.ToString());
            await writer.FlushAsync();
        }
    }
}
