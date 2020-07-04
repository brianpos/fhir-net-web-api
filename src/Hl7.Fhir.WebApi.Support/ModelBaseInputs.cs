/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.WebApi
{
    public class SystemModelBaseInputs<TSP> : ModelBaseInputs<TSP>
    {
        /// <summary>
        /// Constructor to create the Model inputs and set all the properties
        /// (Done as constructor with private setters so that when a new property 
        /// is added we don't miss places that need to populate it)
        /// </summary>
        /// <param name="baseUri">The Base URI is the actual FHIR URL used for this request, will end with /fhir/</param>
        /// <param name="serviceProvider"></param>
        public SystemModelBaseInputs(
            Uri baseUri,
            TSP serviceProvider)
            : base(GetSystemPrincipal(), null, null, null, baseUri, null, null, serviceProvider)
        {
        }
    }

    public class ModelBaseInputs<TSP> : ModelBaseInputs
    {
        /// <summary>
        /// Constructor to create the Model inputs and set all the properties
        /// (Done as constructor with private setters so that when a new property 
        /// is added we don't miss places that need to populate it)
        /// </summary>
        /// <param name="user"></param>
        /// <param name="clientCertificate"></param>
        /// <param name="httpMethod"></param>
        /// <param name="requestUri"></param>
        /// <param name="baseUri">The Base URI is the actual FHIR url used for this request, will end with /fhir/</param>
        /// <param name="x_api_key"></param>
        /// <param name="headers"></param>
        /// <param name="serviceProvider"></param>
        public ModelBaseInputs(
            IPrincipal user,
            X509Certificate2 clientCertificate,
            string httpMethod,
            Uri requestUri,
            Uri baseUri,
            string x_api_key,
            IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers,
            TSP serviceProvider)
            : base (user, clientCertificate,httpMethod, requestUri, baseUri, x_api_key, headers)
        {
            this.ServiceProvider = serviceProvider;
        }
        /// <summary>
        /// Access to the Dependency Injector
        /// </summary>
        public TSP ServiceProvider { get; private set; }

    }

    public class ModelBaseInputs
    {
        /// <summary>
        /// Constructor to create the Model inputs and set all the properties
        /// (Done as constructor with private setters so that when a new property 
        /// is added we don't miss places that need to populate it)
        /// </summary>
        /// <param name="user"></param>
        /// <param name="clientCertificate"></param>
        /// <param name="httpMethod"></param>
        /// <param name="requestUri"></param>
        /// <param name="baseUri">The Base URI is the actual FHIR url used for this request, will end with /fhir/</param>
        /// <param name="x_api_key"></param>
        /// <param name="headers"></param>
        internal ModelBaseInputs(
            IPrincipal user,
            X509Certificate2 clientCertificate,
            string httpMethod,
            Uri requestUri,
            Uri baseUri,
            string x_api_key,
            IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers)
        {
            this.User = user;
            this.ClientCertificate = clientCertificate;
            this.HttpMethod = httpMethod;
            this.RequestUri = requestUri;
            this.BaseUri = baseUri;
            this.X_Api_Key = x_api_key;
            this.Headers = headers;
        }

        /// <summary>
        /// The authenticated user name from the HttpContext
        /// </summary>
        public IPrincipal User { get; private set; }

        /// <summary>
        /// The certificate used to connect with the API
        /// </summary>
        public X509Certificate2 ClientCertificate { get; private set; }

        /// <summary>
        /// The CorrelationId of the request
        /// </summary>
        public string X_CorelationId { get; set; }

        /// <summary>
        /// The Http method e.g. GET
        /// </summary>
        public string HttpMethod { get; private set; }

        /// <summary>
        /// The request URI
        /// </summary>
        public Uri RequestUri { get; private set; }

        /// <summary>
        /// The request URI
        /// </summary>
        public Uri BaseUri { get; private set; }

        // Header properties that we care about
        // ETag
        // RequestedFormat (propagated from accept of format parameter)
        // Id-Modified-Since
        // If-None-Match
        // If-None-Exist
        // If-Match
        // Prefer (return=minimal or return=representation)

        /// <summary>
        /// The x-api-key from the headers of the request
        /// </summary>
        public string X_Api_Key { get; private set; }

        public IEnumerable<KeyValuePair<string, IEnumerable<string>>> Headers { get; private set; }

        public Dictionary<string, List<string>> ResponseHeaders { get; private set; } = new Dictionary<string, List<string>>(StringComparer.CurrentCultureIgnoreCase);

        /// <summary>
        /// Appends a new value to the specific key (ensuring no duplicates are created)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddResponseHeaderValue(string key, string value)
        {
            List<string> headervalues;
            if (ResponseHeaders.ContainsKey(key))
            {
                headervalues = ResponseHeaders[key];
            }
            else
            {
                headervalues = new List<string>();
                ResponseHeaders.Add(key, headervalues);
            }
            if (!headervalues.Contains(value))
                headervalues.Add(value);
        }

        /// <summary>
        /// Sets the value of a specific header key - resetting an existing value if was set
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetResponseHeaderValue(string key, string value)
        {
            List<string> headervalues;
            if (ResponseHeaders.ContainsKey(key))
            {
                headervalues = ResponseHeaders[key];
            }
            else
            {
                headervalues = new List<string>();
                ResponseHeaders.Add(key, headervalues);
            }
            headervalues.Clear();
            headervalues.Add(value);
        }

        private static IPrincipal _systemPrincipal;
        /// <summary>
        /// The System Principal is used when creating records on behalf of the server
        /// </summary>
        /// <returns></returns>
        public static IPrincipal GetSystemPrincipal()
        {
            if (_systemPrincipal == null)
            {
                _systemPrincipal = new GenericPrincipal(new GenericIdentity("System"), null);
            }
            return _systemPrincipal;
        }
    }
}