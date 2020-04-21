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
using System.Linq;

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
                string _format = query["_format"];
                _format = _format.ToLower();
                if (FhirMediaType.LooseXmlFormats.Contains(_format))
                    context.HttpContext.Request.Headers[HeaderNames.Accept] = new string[] { FhirMediaType.XmlResource };
                if (FhirMediaType.LooseJsonFormats.Contains(_format))
                    context.HttpContext.Request.Headers[HeaderNames.Accept] = new string[] { FhirMediaType.JsonResource };
            }
            // Also check for binary content
            if (context.Result is FhirObjectResult fr && fr.Result is Model.Binary &&
                !(context.HttpContext.Request.Headers[HeaderNames.Accept] == FhirMediaType.XmlResource
                || context.HttpContext.Request.Headers[HeaderNames.Accept] == FhirMediaType.JsonResource))
            {
                foreach(var accept in context.HttpContext.Request.Headers[HeaderNames.Accept].Select(i => MediaTypeHeaderValue.Parse(i)))
                {
                    if (FhirMediaType.StrictFormats.Contains(accept.MediaType.Value)) 
                        return;
                    else if (FhirMediaType.LooseXmlFormats.Contains(accept.MediaType.Value)) 
                        return;
                    else if (FhirMediaType.LooseJsonFormats.Contains(accept.MediaType.Value)) 
                        return;
                }
                context.HttpContext.Request.Headers[HeaderNames.Accept] = new string[] { FhirMediaType.BinaryResource };
            }
        }
    }
}
