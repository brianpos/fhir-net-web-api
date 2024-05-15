// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.StructuredDataCapture;
using Hl7.Fhir.WebApi;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Hl7.DemoFhirAzureFunctionApp
{
    public class StructuredDataCaptureFunctions
    {
        [Function("extract-post")]
        public static async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "$extract")] HttpRequestData req,
            FunctionContext context,
            // [InputConverter(typeof(FhirInputConverter))]
            Parameters resource)
        {
            var logger = context.GetLogger<StructuredDataCaptureFunctions>();
            FhirClient client = context.InstanceServices.GetService<FhirClient>();

            var qr = resource.GetResource("questionnaire-response") as QuestionnaireResponse;

            if (qr != null)
            {
                var q = await ResolveQuestionnaire(client, qr);

                var extractor = new Hl7.Fhir.StructuredDataCapture.QuestionnaireResponseExtract();
                var extractResults = await extractor.PerformExtractOperation(qr, q);
                return req.FormatFhirDataOutput(HttpStatusCode.OK, extractResults);
            }

            return req.FormatFhirDataOutput(HttpStatusCode.OK, qr);
        }

        [Function("extract-by-id")]
        public static async Task<HttpResponseData> ExtractForQuestionnaireResponseId([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "{id}/$extract")] HttpRequestData req,
            FunctionContext context,
            string id)
        {
            var logger = context.GetLogger<StructuredDataCaptureFunctions>();
            FhirClient client = context.InstanceServices.GetService<FhirClient>();

            // Retrieve the QuestionnaireResponse
            var qr = await GetQR(client, id);

            if (qr != null)
            {
                var q = await ResolveQuestionnaire(client, qr);

                var extractor = new Hl7.Fhir.StructuredDataCapture.QuestionnaireResponseExtract();
                var extractResults = await extractor.PerformExtractOperation(qr, q);
                return req.FormatFhirDataOutput(HttpStatusCode.OK, extractResults);
            }

            return req.FormatFhirDataOutput(HttpStatusCode.OK, qr);
        }

        static async Task<QuestionnaireResponse> GetQR(FhirClient client, string id)
        {
            return await client.ReadAsync<QuestionnaireResponse>($"QuestionnaireResponse/{id}");
        }

        static async Task<Questionnaire> ResolveQuestionnaire(FhirClient client, QuestionnaireResponse qr)
        {
            // contained questionnaire
            if (qr.Questionnaire.StartsWith("#"))
            {
                return qr.Contained.Find(c => "#"+c.Id == qr.Questionnaire) as Questionnaire;
            }

            // go resolve it from a server!
            CanonicalUrl canonical = new CanonicalUrl(qr.Questionnaire); // use the CanonicalUrl to parse out the version if its in there
            string query = $"url={canonical.Url.Value}";
            if (canonical.Version != null)
                query += $"&version={canonical.Version.Value}";
            var b = await client.SearchAsync<Questionnaire>(new string[]{ query });

            // According to the canonical URL resolving version rules!
            var qVers = b.Entry.Where(e => (e.Resource as Questionnaire)?.Url == canonical.Url.Value).Select(e => e.Resource).Cast<IVersionableConformanceResource>();
            return CurrentCanonical.Current(qVers) as Questionnaire;

            // or this could also call the $current-canonical which is defined for R5
        }
    }
}
