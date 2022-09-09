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

namespace Hl7.Fhir.WebApi
{
    public class YamlFormatParameterFilter : IResultFilter
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
                if (YamlContentType.LooseYamlFormats.Contains(_format))
                    context.HttpContext.Request.Headers[HeaderNames.Accept] = new string[] { YamlContentType.YAML_CONTENT_HEADER };
            }
        }
    }
}
