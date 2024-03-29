﻿/* 
 * Copyright (c) 2014, Furore (info@furore.com), HealthConnex and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.github.com/furore-fhir/spark/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using System.Web.Http;
using Microsoft.Owin.Logging;

namespace Hl7.Fhir.WebApi
{
    public class FhirExceptionFilter : ExceptionFilterAttribute
    {
        public FhirExceptionFilter(ILogger logger = null)
        {
            _logger = logger;
        }

        /// <summary>
        /// Dependency injected logger
        /// </summary>
        private ILogger _logger { get; set; }

        OperationOutcome CreateOutcome(string message)
        {
            return new OperationOutcome().Error(message);
        }

        public OperationOutcome CreateOutcome(Exception exception)
        {
            OperationOutcome outcome = new OperationOutcome().Init();
            Exception e = exception;
            do
            {
                outcome.Error(e);
                e = e.InnerException;
            }
            while (e != null);

            return outcome;
        }
        const string x_correlation_id = "X-Correlation-Id";

        public override void OnException(HttpActionExecutedContext context)
        {
            HttpResponseMessage errorResponse;

            if (context.Exception is FhirServerException fex)
            {
                var outcome = fex.Outcome == null ? CreateOutcome(fex) : fex.Outcome;
                errorResponse = context.Request.CreateResponse(fex.StatusCode, outcome);
                _logger?.WriteError(outcome.ToString(), fex);
            }
            else if (context.Exception is HttpResponseException)
            {
                var he = (HttpResponseException)context.Exception;
                errorResponse = context.Request.CreateResponse(he.Response.StatusCode, CreateOutcome(he.Response.ToString()));
                _logger?.WriteCritical("Unhandled exception in the Server", context.Exception);
            }
            else
            {
                errorResponse = context.Request.CreateResponse(HttpStatusCode.InternalServerError, CreateOutcome(context.Exception));
                _logger?.WriteCritical("Unhandled exception in the Server", context.Exception);
            }

            // echo any X-Correlation-Id Headers if encountered
            if (context.Request.Headers.Contains(x_correlation_id))
            {
                if (!errorResponse.Headers.Contains(x_correlation_id))
                    errorResponse.Headers.Add(x_correlation_id, context.Request.Headers.GetValues(x_correlation_id));
#if DEBUG
                if (context.Request.Headers.GetValues(x_correlation_id).ToString() != errorResponse.Headers.GetValues(x_correlation_id).ToString())
                    System.Diagnostics.Trace.WriteLine($"Hl7.Fhir.WebApi.FhirMediaTypeOutputFormatter: X-Correlation-Id headers didn't match request vs response");
#endif
            }

            throw new HttpResponseException(errorResponse);
        }
    }
}
