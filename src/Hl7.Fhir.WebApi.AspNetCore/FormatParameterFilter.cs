/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.WebApi;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;

namespace Hl7.Fhir.NetCoreApi.R4
{
    public class FhirFormatParameterFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            // Look for the _format parameter on the query
            var query = context.HttpContext.Request.Query;
            if (query?.ContainsKey("_format") == true)
            {
                if (String.Compare(query["_format"], "xml", true) == 0)
                    context.HttpContext.Request.Headers[HeaderNames.Accept] = new string[] { FhirMediaType.XmlResource };
                if (String.Compare(query["_format"], "json", true) == 0)
                    context.HttpContext.Request.Headers[HeaderNames.Accept] = new string[] { FhirMediaType.JsonResource };
            }
        }
    }
}
