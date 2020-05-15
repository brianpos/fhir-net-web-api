/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Hl7.Fhir.WebApi
{
    public static class HttpRequestExtensions
    {
        public static bool Exists(this HttpHeaders headers, string key)
        {
            IEnumerable<string> values;
            if (headers.TryGetValues(key, out values))
            {
                return values.Count() > 0;
            }
            else return false;

        }
        public static void Replace(this HttpHeaders headers, string header, string value)
        {
            //if (headers.Exists(header)) 
            headers.Remove(header);
            headers.Add(header, value);
        }
        public static string Value(this HttpHeaders headers, string key)
        {
            IEnumerable<string> values;
            if (headers.TryGetValues(key, out values))
            {
                return values.FirstOrDefault();
            }
            else return null;
        }
        public static void ReplaceHeader(this HttpRequest request, string header, string value)
        {
            request.Headers[header] = value;
        }

        public static string Header(this HttpRequest request, string key)
        {
            StringValues values;
            if (request.Headers.TryGetValue(key, out values))
            {
                return values.FirstOrDefault();
            }
            else return null;
        }
        
        public static Uri RequestUri(this HttpRequest request)
        {
            return new Uri(request.GetDisplayUrl());
        }

        public static string GetParameter(this HttpRequest request, string key)
        {
            foreach (var param in request.Query)
            {
                if (param.Key == key) return param.Value;
            }
            return null;
        }

        /// <summary>
        /// Retrieve all the parameters from the Request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="excludeParameters">Do not include any parameters from the provided collection</param>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, string>> TupledParameters(this HttpRequest request, string[] excludeParameters = null)
        {
            var list = new List<KeyValuePair<string, string>>();

            foreach (var pair in request.Query)
            {
                if (excludeParameters == null || !excludeParameters.Contains(pair.Key))
                    list.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));
            }
            return list;
        }

        public static IEnumerable<KeyValuePair<string, string>> TupledParameters(this IQueryCollection query, string[] excludeParameters = null)
        {
            var list = new List<KeyValuePair<string, string>>();

            if (query?.Keys != null)
            {
                foreach (string key in query.Keys)
                {
                    if (excludeParameters == null || !excludeParameters.Contains(key))
                        list.Add(new KeyValuePair<string, string>(key, query[key]));
                }
            }
            return list;
        }
    }
}