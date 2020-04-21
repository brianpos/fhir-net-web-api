/* 
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

namespace Hl7.Fhir.WebApi
{
    public class FhirExceptionFilter : ExceptionFilterAttribute
    {
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

        public override void OnException(HttpActionExecutedContext context)
        {
            HttpResponseMessage errorResponse;

            if (context.Exception is FhirServerException)
            {
                var exception = (FhirServerException)context.Exception;
                var outcome = exception.Outcome == null ? CreateOutcome(exception) : exception.Outcome;
                errorResponse = context.Request.CreateResponse(exception.StatusCode, outcome);
            }
            else if (context.Exception is HttpResponseException)
            {
                var he = (HttpResponseException)context.Exception;
                errorResponse = context.Request.CreateResponse(he.Response.StatusCode, CreateOutcome(he.Response.ToString()));
            }
            else
                errorResponse = context.Request.CreateResponse(HttpStatusCode.InternalServerError, CreateOutcome(context.Exception));

            throw new HttpResponseException(errorResponse);
        }
    }
}
