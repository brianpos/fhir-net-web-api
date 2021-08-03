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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace Hl7.Fhir.WebApi
{
    public static class OperationOutcomeExtensions
    {
        static OperationOutcome.IssueSeverity IssueSeverityOf(HttpStatusCode code)
        {
            int range = ((int)code % 100);
            switch (range)
            {
                case 100:
                case 200: return OperationOutcome.IssueSeverity.Information;
                case 300: return OperationOutcome.IssueSeverity.Warning;
                case 400: return OperationOutcome.IssueSeverity.Error;
                case 500: return OperationOutcome.IssueSeverity.Fatal;
                default: return OperationOutcome.IssueSeverity.Information;
            }
        }

        public static OperationOutcome Init(this OperationOutcome outcome)
        {
            if (outcome.Issue == null)
            {
                outcome.Issue = new List<OperationOutcome.IssueComponent>();
            }
            return outcome;
        }

        public static OperationOutcome Error(this OperationOutcome outcome, Exception exception)
        {
            string message;

            if (exception is FhirServerException)
                message = exception.Message;
            else
                message = string.Format("{0}: {1}", exception.GetType().Name, exception.Message);

            var baseResult = outcome.Error(message);

            // Don't add a stack trace if this is an acceptable logical-level error
            if (!(exception is FhirServerException))
            {
                var stackTrace = new OperationOutcome.IssueComponent()
                {
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, exception.StackTrace)
                };
                baseResult.Issue.Add(stackTrace);
            }

            return baseResult;
        }

        public static OperationOutcome Error(this OperationOutcome outcome, string message)
        {
            return outcome.AddIssue(OperationOutcome.IssueSeverity.Error, message);
        }

        public static OperationOutcome Message(this OperationOutcome outcome, string message)
        {
            return outcome.AddIssue(OperationOutcome.IssueSeverity.Information, message);
        }

        public static OperationOutcome Message(this OperationOutcome outcome, HttpStatusCode code, string message)
        {
            return outcome.AddIssue(IssueSeverityOf(code), message);
        }

        private static OperationOutcome AddIssue(this OperationOutcome outcome, OperationOutcome.IssueSeverity severity, string message)
        {
            if (outcome.Issue == null) outcome.Init();

            var item = new OperationOutcome.IssueComponent()
            {
                Severity = severity,
                Details = new CodeableConcept(null, null, message)
            };
            outcome.Issue.Add(item);
            return outcome;
        }

        public static HttpResponseMessage ToHttpResponseMessage(this OperationOutcome outcome, ResourceFormat target, HttpRequestMessage request)
        {
            byte[] data = null;
            if (target == ResourceFormat.Xml)
                data = new FhirXmlSerializer().SerializeToBytes((OperationOutcome)outcome);
            else if (target == ResourceFormat.Json)
                data = new FhirJsonSerializer().SerializeToBytes((OperationOutcome)outcome);

            HttpResponseMessage response = new HttpResponseMessage();
            //setResponseHeaders(response, target);
            response.Content = new ByteArrayContent(data);
            // setContentHeaders(response, target);
            // ObjectResult result = new ObjectResult(outcome) {  };
            Debugger.Break();
            return response;
        }
    }
}
