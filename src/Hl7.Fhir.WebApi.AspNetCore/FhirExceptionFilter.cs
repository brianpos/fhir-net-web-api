/* 
 * Copyright (c) 2014, Furore (info@furore.com), HealthConnex and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.github.com/furore-fhir/spark/master/LICENSE
 */

using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;
using System.Net.Http;

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

        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is FhirServerException)
            {
                var exception = (FhirServerException)context.Exception;
                var outcome = exception.Outcome == null ? CreateOutcome(exception) : exception.Outcome;
                context.Result = new ObjectResult(outcome) { StatusCode = (int)exception.StatusCode };
                context.ExceptionHandled = true;
                return;
            }
            base.OnException(context);
        }
    }
}
