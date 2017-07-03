using Hl7.Fhir.WebApi;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hl7.Fhir.NetCoreApi.STU3
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
