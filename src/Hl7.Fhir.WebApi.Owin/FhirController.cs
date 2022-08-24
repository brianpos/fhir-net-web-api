/*
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using Hl7.FhirPath.Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// This class basically implements
    /// http://hl7.org/fhir/r4/http.html
    /// </summary>
    [RoutePrefix("")]
    public partial class FhirR4Controller : ApiController
    {
        internal ModelBaseInputs<IDependencyScope> GetInputs(string baseUrl)
        {
            return GetInputs(Request, User, new Uri(baseUrl));
        }

        internal static ModelBaseInputs<IDependencyScope> GetInputs(HttpRequestMessage Request, System.Security.Principal.IPrincipal User, Uri baseUrl)
        {
            // If the headers indicate that this was through a proxy, update the baseurl to come from that location
            if (Request.Headers.Contains("Forwarded"))
            {
                // TODO: https://tools.ietf.org/html/rfc7239
                //var forwarded = Request.Headers["Forwarded"].FirstOrDefault(s => !string.IsNullOrEmpty(s) && !s.StartsWith("_"));
                //var
                //string virtualPath = Request.PathBase.Value?.TrimEnd('/');
                //string proxyUrl = baseUrl.OriginalString;
                //if (NetCoreApi.FhirFacadeBuilder._supportedForwardedForSystems.ContainsKey(proxyUrl))
                //    baseUrl = NetCoreApi.FhirFacadeBuilder._supportedForwardedForSystems[proxyUrl];
                //else
                //    baseUrl = new Uri(proxyUrl);
            }
            if (Request.Headers.Contains("X-Forwarded-Proto") && Request.Headers.Contains("X-Forwarded-Host") && Request.Headers.Contains("X-Forwarded-Port"))
            {
                // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-Host
                // X-Forwarded-For=30.10.0.2;X-Forwarded-Proto=https;X-Forwarded-Host=fhirtest.emerging.com.au;X-Forwarded-Port=443;
                string proto = Request.Headers.GetValues("X-Forwarded-Proto").FirstOrDefault();
                string host = Request.Headers.GetValues("X-Forwarded-Host").FirstOrDefault();
                string port = Request.Headers.GetValues("X-Forwarded-Port").FirstOrDefault();
                string prefix = Request.Headers.GetValues("X-Forwarded-Prefix").FirstOrDefault();
                if (port == "443")
                    port = null;
                else
                    port = ":" + port;
                string proxyUrl = $"{proto}://{host}{port}/";
                if (!string.IsNullOrEmpty(prefix?.Trim('/')))
                    proxyUrl += $"{prefix.Trim('/')}/";

                if (WebApiConfig._supportedForwardedForSystems?.ContainsKey(proxyUrl) == true)
                    baseUrl = WebApiConfig._supportedForwardedForSystems[proxyUrl];
                else
                    baseUrl = new Uri(proxyUrl);
            }

            var cert = Request.GetClientCertificate();
            var inputs = new ModelBaseInputs<IDependencyScope>(
                User,
                cert,
                Request.Method.Method,
                Request.RequestUri,
                baseUrl,
                Request.Header("x-api-key"),
                Request.Headers,
                Request.GetDependencyScope());

            if (Request.Headers.Contains("X-Correlation-Id"))
            {
                inputs.X_CorelationId = Request.Headers.GetValues("X-Correlation-Id").FirstOrDefault();
            }
            else
            {
                inputs.X_CorelationId = Guid.NewGuid().ToFhirId();
            }
            Request.Properties.Add("fhir-inputs", inputs);
            inputs.CancellationToken = Request.GetOwinContext().Request.CallCancelled;
            return inputs;
        }

        // Query Parameter names that are processed by the various HTTP actions
        readonly string[] SearchQueryParameterNames = { "_summary", "_sort", "_count", "_format" };
        readonly string[] OperationQueryParameterNames = { "_summary", "_format" };

        internal static IFhirSystemServiceR4<IDependencyScope> GetSystemModel(ModelBaseInputs<IDependencyScope> inputs)
        {
            return WebApiConfig._systemService;
        }

        internal static IFhirResourceServiceR4<IDependencyScope> GetResourceModel(string ResourceName, ModelBaseInputs<IDependencyScope> inputs)
        {
            try
            {
                var model = WebApiConfig._systemService.GetResourceService(inputs, ResourceName);

                if (model != null)
                    return model;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
            }
            throw new FhirServerException(HttpStatusCode.NotFound, "Resource [" + ResourceName + "] is not supported on this server");
        }

        public static Hl7.Fhir.Rest.SummaryType GetSummaryParameter(HttpRequestMessage request)
        {
            string s = request.GetParameter(FhirParameter.SUMMARY);
            if (s == null)
                return Hl7.Fhir.Rest.SummaryType.False;

            switch (s.ToLower())
            {
                case "true": return Hl7.Fhir.Rest.SummaryType.True;
                case "false": return Hl7.Fhir.Rest.SummaryType.False;
                case "text": return Hl7.Fhir.Rest.SummaryType.Text;
                case "data": return Hl7.Fhir.Rest.SummaryType.Data;
                case "count": return Hl7.Fhir.Rest.SummaryType.Count;
                default: return Hl7.Fhir.Rest.SummaryType.False;
            }
        }

        /// <summary>
        /// http://hl7-fhir.github.io/http.html#transaction
        /// </summary>
        [HttpPost, Route("")]
        public HttpResponseMessage ProcessBatch([FromBody] Bundle batch)
        {
            var buri = this.CalculateBaseURI("metadata");
            var inputs = GetInputs(buri);

            try
            {
                Bundle outcome = GetSystemModel(inputs).ProcessBatch(inputs, batch).Result;
                outcome.ResourceBase = inputs.BaseUri;
                Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
                outcome.SetAnnotation<SummaryType>(summary);
                return Request.ResourceResponse(outcome, HttpStatusCode.OK);
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, "Batch/Transactions are not supported on this server");
            }
        }

        // GET fhir/values
        [HttpOptions, Route("")]
        [HttpGet, Route("metadata")]
        [AllowAnonymous]
        public Hl7.Fhir.Model.CapabilityStatement GetConformance()
        {
            var buri = this.CalculateBaseURI("metadata");
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            var inputs = GetInputs(buri);
            var con = GetSystemModel(inputs).GetConformance(inputs, summary).Result;
            con.ResourceBase = inputs.BaseUri;
            con.SetAnnotation<SummaryType>(summary);
            return con;
        }

        [HttpGet, Route("{ResourceName}/{id}")]
        public HttpResponseMessage Get(string ResourceName, string id)
        {
            return Get(ResourceName, id, null);
        }

        // GET fhir/patient/5/_history/4
        //[HttpGet, Route("{type}/{id}/_history/{vid}")]
        [HttpGet, Route("{ResourceName}/{id}/_history/{vid}")]
        public HttpResponseMessage Get(string ResourceName, string id, string vid)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            if (!Id.IsValidValue(id))
            {
                throw new FhirServerException(HttpStatusCode.BadRequest, "ID [" + id + "] is not a valid FHIR Resource ID");
            }

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            try
            {
                Resource resource = model.Get(id, vid, summary).Result;
                if (resource != null)
                {
                    resource.ResourceBase = inputs.BaseUri;

                    if (resource is DomainResource)
                    {
                        DomainResource dr = resource as DomainResource;
                        switch (summary)
                        {
                            case Hl7.Fhir.Rest.SummaryType.False:
                                break;
                            case Hl7.Fhir.Rest.SummaryType.True:
                                // summary doesn't have the text in it.
                                dr.Text = null;
                                // there are no contained references in the summary form
                                dr.Contained = null;

                                // Add in the Meta Tag that indicates that this resource is only a partial
                                resource.Meta.Tag = new List<Coding>
                            {
                                new Coding("http://terminology.hl7.org/CodeSystem/v3-ObservationValue", "SUBSETTED")
                            };
                                break;
                            case Hl7.Fhir.Rest.SummaryType.Text:
                                // what do we need to filter here
                                break;
                            case Hl7.Fhir.Rest.SummaryType.Data:
                                // summary doesn't have the text in it.
                                dr.Text = null;
                                // Add in the Meta Tag that indicates that this resource is only a partial
                                resource.Meta.Tag = new List<Coding>
                            {
                                new Coding("http://terminology.hl7.org/CodeSystem/v3-ObservationValue", "SUBSETTED")
                            };
                                break;
                        }
                    }

                    if (ResourceName == "Binary")
                    {
                        // We need to reset the accepts type so that the correct formatter is used on the way out.
                        string formatParam = this.ControllerContext.Request.GetParameter("_format");
                        if (string.IsNullOrEmpty(formatParam))
                        {
                            this.ControllerContext.Request.Headers.Accept.Clear();
                            this.ControllerContext.Request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue((resource as Binary).ContentType));
                        }
                    }

                    var msg = Request.ResourceResponse(resource, HttpStatusCode.OK);
                    msg.Headers.Location = resource.ResourceIdentity().WithBase(resource.ResourceBase);
                    msg.Headers.Add("ETag", String.Format("\"{0}\"", resource.Meta.VersionId));

                    if (ResourceName == "Binary")
                    {
                        // We need to reset the accepts type so that the correct formatter is used on the way out.
                        string formatParam = this.ControllerContext.Request.GetParameter("_format");
                        if (string.IsNullOrEmpty(formatParam))
                        {
                            msg.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                            {
                                FileName = String.Format("fhir_binary_{0}_{1}.{2}",
                                  resource.Id,
                                  resource.Meta != null ? resource.Meta.VersionId : "0",
                                  GetFileExtensionForMimeType((resource as Binary).ContentType))
                            };
                        }
                    }

                    return msg;
                }

                // this request is a "you wanted what?"
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Get {ResourceName} is not supported on this server");
            }
        }

        [HttpGet, Route("{ResourceName}/{id}/${operation}")]
        public HttpResponseMessage PerformOperation(string ResourceName, string id, string operation)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            Parameters operationParameters = new Parameters();
            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);
            try
            {
                var resource = model.PerformOperation(id, operation, operationParameters, summary).Result;
                return PrepareOperationOutputMessage(inputs.BaseUri, $"/{ResourceName}/{id}/${operation}", resource);
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support operation [${operation}] on this server");
            }
        }

        private static Parameters ConvertOperationParameters(string operation, Resource inputResource)
        {
            Parameters operationParameters;
            if (inputResource is Parameters p)
                operationParameters = p;
            else
            {
                operationParameters = new Parameters();
                if (operation == "convert")
                    operationParameters.Parameter.Add(new Parameters.ParameterComponent() { Name = "input", Resource = inputResource });
                else
                    operationParameters.Parameter.Add(new Parameters.ParameterComponent() { Name = "resource", Resource = inputResource });
            }

            return operationParameters;
        }

        [HttpPost, Route("{ResourceName}/{id}/${operation}")]
        public HttpResponseMessage PerformOperation(string ResourceName, string id, string operation, [FromBody] Resource inputResource)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);
            Parameters operationParameters = ConvertOperationParameters(operation, inputResource);

            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);
            try
            {
                var resource = model.PerformOperation(id, operation, operationParameters, summary).Result;
                return PrepareOperationOutputMessage(inputs.BaseUri, $"/{ResourceName}/{id}/${operation}", resource);
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support operation [${operation}] on this server");
            }
        }

        [HttpGet, Route("{ResourceName}/${operation}")]
        public HttpResponseMessage PerformOperation(string ResourceName, string operation)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            Parameters operationParameters = new Parameters();
            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);
            try
            {
                var resource = model.PerformOperation(operation, operationParameters, summary).Result;
                return PrepareOperationOutputMessage(inputs.BaseUri, $"/{ResourceName}/${operation}", resource);
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support operation [${operation}] on this server");
            }
        }

        [HttpPost, Route("{ResourceName}/${operation}")]
        public HttpResponseMessage PerformOperation(string ResourceName, string operation, [FromBody] Resource inputResource)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);
            Parameters operationParameters = ConvertOperationParameters(operation, inputResource);

            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);
            try
            {
                var resource = model.PerformOperation(operation, operationParameters, summary).Result;
                return PrepareOperationOutputMessage(inputs.BaseUri, $"/{ResourceName}/${operation}", resource);
            }
            catch (NotImplementedException)
            {
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support operation [${operation}] on this server");
            }
        }

        private HttpResponseMessage PrepareOperationOutputMessage(Uri baseUri, string ResourceAndOperationName, Resource resource)
        {
            if (resource != null)
            {
                resource.ResourceBase = baseUri;

                if (resource is Binary)
                {
                    // We need to reset the accepts type so that the correct formatter is used on the way out.
                    string formatParam = this.ControllerContext.Request.GetParameter("_format");
                    if (string.IsNullOrEmpty(formatParam))
                    {
                        this.ControllerContext.Request.Headers.Accept.Clear();
                        this.ControllerContext.Request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue((resource as Binary).ContentType));
                    }
                }

                var msg = Request.ResourceResponse(resource, HttpStatusCode.OK);
                if (!string.IsNullOrEmpty(resource.Id))
                    msg.Headers.Location = resource.ResourceIdentity().WithBase(resource.ResourceBase);
                else
                {
                    msg.Headers.Location = new Uri(resource.ResourceBase + ResourceAndOperationName + Request.RequestUri.Query);
                }
                if (resource.Meta != null && !string.IsNullOrEmpty(resource.Meta.VersionId))
                    msg.Headers.Add("ETag", String.Format("\"{0}\"", resource.Meta.VersionId));

                if (resource is Binary)
                {
                    // We need to reset the accepts type so that the correct formatter is used on the way out.
                    string formatParam = this.ControllerContext.Request.GetParameter("_format");
                    if (string.IsNullOrEmpty(formatParam))
                    {
                        msg.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                        {
                            FileName = String.Format("fhir_binary_{0}_{1}.{2}",
                              resource.Id,
                              resource.Meta != null ? resource.Meta.VersionId : "0",
                              GetFileExtensionForMimeType((resource as Binary).ContentType))
                        };
                    }
                }

                return msg;
            }

            // this request is a "you wanted what?"
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPost, HttpGet, Route("${operation}")]
        public HttpResponseMessage PerformOperation(string operation, [FromBody] Resource inputResource)
        {
            var buri = this.CalculateBaseURI("${operation}");
            var inputs = GetInputs(buri);
            Parameters operationParameters = ConvertOperationParameters(operation, inputResource);

            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));

            try
            {
                Resource resource = GetSystemModel(inputs).PerformOperation(inputs, operation, operationParameters, summary).Result;
                return PrepareOperationOutputMessage(inputs.BaseUri, $"/${operation}", resource);
            }
            catch (NotImplementedException)
            {
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"System operation [${operation}] is not supported on this server");
            }
        }

        private void ExtractParametersFromUrl(ref Parameters operationParameters, IEnumerable<KeyValuePair<string, string>> enumerable)
        {
            if (operationParameters == null)
                operationParameters = new Parameters();
            foreach (var item in Request.TupledParameters())
            {
                operationParameters.Add(item.Key, new FhirString(item.Value));
            }
        }

        private string GetFileExtensionForMimeType(string mimetype)
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + mimetype, false);
            if (regKey != null && regKey.GetValue("Extension") != null)
                return regKey.GetValue("Extension").ToString();
            return null;
        }

        [HttpGet, Route("{ResourceName}/_search")]
        public Bundle SearchWithOperator(string ResourceName)
        {
            return Search(ResourceName);
        }

        // GET fhir/patient/
        // GET fhir/patient/search?
        //[HttpGet, Route("{type}")]
        //[HttpGet, Route("{type}/_search")]
        [HttpGet, Route("{ResourceName}")]
        public Bundle Search(string ResourceName)
        {
            System.Diagnostics.Trace.WriteLine("GET: " + this.ControllerContext.Request.RequestUri.OriginalString);

            var parameters = Request.TupledParameters(SearchQueryParameterNames);
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            string sortby = Request.GetParameter(FhirParameter.SORT);
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                Bundle result = model.Search(parameters, pagesize, summary, sortby).Result;
                result.ResourceBase = inputs.BaseUri;

                this.ControllerContext.Request.SaveEntry(result);
                result.SetAnnotation<SummaryType>(summary);
                return result;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support searching on this server");
            }
        }

        // Need the POST form of search going to "{ResourceName}/_search"
        [HttpPost, Route("{ResourceName}/_search")]
        public Bundle SearchByPost(string ResourceName)
        {
            System.Diagnostics.Trace.WriteLine("GET: " + this.ControllerContext.Request.RequestUri.OriginalString);

            var parameters = Request.TupledParameters(SearchQueryParameterNames).ToList();

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            // Also grab the application/x-www-form-urlencoded content body
            if (Request.Content.IsFormData())
            {
                // This is Bad, talk to Andrew again to find out the library to assist with this.
                var requestData = Request.Content.ReadAsFormDataAsync().Result;
                foreach (var item in requestData.AllKeys)
                {
                    parameters.Add(new KeyValuePair<string, string>(item, requestData[item]));
                }
            }

            Hl7.Fhir.Rest.SummaryType summary = parameters.GetSummaryParameter() ?? SummaryType.False;
            string pageSizeString = parameters.Where(k => k.Key == FhirParameter.COUNT).FirstOrDefault().Value;
            string sortby = parameters.Where(k => k.Key == FhirParameter.SORT).FirstOrDefault().Value;
            if (string.IsNullOrEmpty(pageSizeString) || !int.TryParse(pageSizeString, out int pagesize))
                pagesize = Const.DEFAULT_PAGE_SIZE;

            try
            {
                Bundle result = model.Search(parameters, pagesize, summary, sortby).Result;
                result.ResourceBase = inputs.BaseUri;

                this.ControllerContext.Request.SaveEntry(result);
                result.SetAnnotation<SummaryType>(summary);
                return result;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support searching on this server");
            }
        }

        // GET fhir/patient/_history
        [HttpGet, Route("{ResourceName}/_history")]
        public Bundle ResourceHistory(string ResourceName)
        {
            System.Diagnostics.Trace.WriteLine("GET: " + this.ControllerContext.Request.RequestUri.OriginalString);

            DateTimeOffset? since = Request.GetDateParameter("_since");
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                // TODO: Locate the till parameter in the history
                Bundle result = model.TypeHistory(since, null, pagesize, summary).Result;
                result.ResourceBase = inputs.BaseUri;

                this.ControllerContext.Request.SaveEntry(result);
                return result;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support type level history on this server");
            }
        }

        // GET fhir/patient/5/_history
        //[HttpGet, Route("{type}/{id}/_history/{vid}")]
        [HttpGet, Route("{ResourceName}/{id}/_history")]
        public Bundle InstanceHistory(string ResourceName, string id)
        {
            System.Diagnostics.Trace.WriteLine("GET: " + this.ControllerContext.Request.RequestUri.OriginalString);

            DateTimeOffset? since = Request.GetDateParameter("_since");
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                Bundle result = model.InstanceHistory(id, since, null, pagesize, summary).Result;
                result.ResourceBase = inputs.BaseUri;
                if (result.Total == 0)
                {
                    try
                    {
                        // Check to see if the item itself exists
                        if (model.Get(id, null, Hl7.Fhir.Rest.SummaryType.True) == null)
                        {
                            // this resource does not exist to have a history
                            throw new FhirServerException(HttpStatusCode.NotFound, "The resource was not found");
                        }
                    }
                    catch (FhirServerException ex)
                    {
                        if (ex.StatusCode != HttpStatusCode.Gone)
                            throw ex;
                    }
                }

                this.ControllerContext.Request.SaveEntry(result);
                return result;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support instance level history on this server");
            }
        }

        [HttpGet, Route("_history")]
        public Bundle WholeSystemHistory()
        {
            System.Diagnostics.Trace.WriteLine("GET: " + this.ControllerContext.Request.RequestUri.OriginalString);
            var buri = this.CalculateBaseURI("_history");

            DateTimeOffset? since = Request.GetDateParameter("_since");
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            var inputs = GetInputs(buri);
            var model = GetSystemModel(inputs);

            try
            {
                Bundle result = model.SystemHistory(inputs, since, null, pagesize, summary).Result;
                result.ResourceBase = inputs.BaseUri;

                this.ControllerContext.Request.SaveEntry(result);
                return result;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"System level history not supported on this server");
            }
        }


        // POST fhir/values
        /// <summary>
        ///
        /// </summary>
        /// <param name="ResourceName">The FHIR Resource name e.g. `Patient`</param>
        /// <param name="bodyResource"></param>
        /// <returns></returns>
        /// <remarks>
        /// No need to test for null body, as the filters will throw the issue before it gets here
        /// Unit tests ensure this is the case
        /// </remarks>
        [HttpPost, Route("{ResourceName}", Order = 0)]
        public async System.Threading.Tasks.Task<HttpResponseMessage> Post(string ResourceName, [FromBody] Resource bodyResource)
        {
            System.Diagnostics.Trace.WriteLine("POST: " + this.ControllerContext.Request.RequestUri.OriginalString);
            var buri = this.CalculateBaseURI("{ResourceName}");


            if (bodyResource == null)
            {
                var oo = new OperationOutcome()
                {
                    Text = Utility.CreateNarative("Validation Error"),
                    //    Contained = new List<Resource> { bodyResource } // Can't attach a null resource!
                };
                oo.Issue = new List<OperationOutcome.IssueComponent>
                {
                    new OperationOutcome.IssueComponent()
                    {
                        Details = new CodeableConcept(null, null, "Missing " + ResourceName + " resource POST"),
                        Severity = OperationOutcome.IssueSeverity.Fatal
                    }
                };
                // return oo;
                return Request.CreateResponse(HttpStatusCode.BadRequest, oo);
            }

            if (!String.IsNullOrEmpty(bodyResource.Id))
            {
                var oo = new OperationOutcome()
                {
                    Text = Utility.CreateNarative("Validation Error"),
                    Contained = new List<Resource> { bodyResource }
                };
                oo.Issue = new List<OperationOutcome.IssueComponent>
                {
                    new OperationOutcome.IssueComponent()
                    {
                        Details = new CodeableConcept(null, null, "ID must be empty for POST"),
                        Severity = OperationOutcome.IssueSeverity.Fatal
                    }
                };
                // return oo;
                return Request.CreateResponse(HttpStatusCode.BadRequest, oo);
            }

            var inputs = GetInputs(buri);
            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                var result = await model.Create(bodyResource, null, null, null).ConfigureAwait(false);
                this.ControllerContext.Request.SaveEntry(bodyResource);
                result.ResourceBase = inputs.BaseUri;
                var actualResource = result;

                ResourceIdentity ri = null;
                if (result is Bundle)
                {
                    ri = result.ResourceIdentity(result.ResourceBase);
                }
                else if (!(result is OperationOutcome) && !string.IsNullOrEmpty(result.Id))
                {
                    ri = result.ResourceIdentity(result.ResourceBase);
                }

                // Check the prefer header
                if (Request.Headers.Contains("Prefer"))
                {
                    string preferHeader = Request.Headers.GetValues("Prefer").FirstOrDefault();
                    if (preferHeader != null && preferHeader.ToLower() == "return=operationoutcome")
                    {
                        if (!(result is OperationOutcome))
                        {
                            OperationOutcome so = new OperationOutcome()
                            {
                                Text = Utility.CreateNarative("Resource update")
                            };
                            so.Text.Status = Narrative.NarrativeStatus.Generated;
                            so.Issue = new List<OperationOutcome.IssueComponent>
                        {
                            new OperationOutcome.IssueComponent()
                            {
                                Severity = OperationOutcome.IssueSeverity.Information,
                                Code = OperationOutcome.IssueType.Informational,
                                Details = new CodeableConcept(null, null, "Update was completed")
                            }
                        };
                            result = so;
                        }
                    }
                }

                HttpResponseMessage returnMessage;
                if (bodyResource.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                    returnMessage = Request.CreateResponse(HttpStatusCode.Created, result);
                else
                    returnMessage = Request.CreateResponse(HttpStatusCode.OK, result);

                // Put in the "Location" header
                if (ri != null)
                {
                    returnMessage.Headers.Add("Location", ri.OriginalString);
                    Request.Properties.Add(Const.ResourceIdentityKey, ri.MakeRelative().OriginalString);
                }
                if (actualResource.Meta != null && !string.IsNullOrEmpty(actualResource.Meta.VersionId))
                {
                    returnMessage.Headers.Add("ETag", String.Format("W/\"{0}\"", actualResource.Meta.VersionId));
                }
                if (actualResource.Meta != null && actualResource.Meta.LastUpdated.HasValue)
                {
                    returnMessage.Content.Headers.LastModified = actualResource.Meta.LastUpdated.Value;
                    // returnMessage.Headers.Add("Last-Modified", actualResource.Meta.LastUpdated.Value.ToString("r"));
                }

                // Check the prefer header
                if (Request.Headers.Contains("Prefer"))
                {
                    string preferHeader = Request.Headers.GetValues("Prefer").FirstOrDefault();
                    if (preferHeader != null && preferHeader.ToLower() == "return=minimal")
                    {
                        returnMessage.Content = null;
                    }
                }

                return returnMessage;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support create on this server");
            }
        }

        /// <summary>
        /// Support for Conditional Updates
        /// eg. PUT fhir/Patient?identifier=http://temp|43&amp;birthDate=1973-10
        /// </summary>
        /// <param name="ResourceName"></param>
        /// <param name="bodyResource"></param>
        /// <returns></returns>
        [HttpPut, Route("{ResourceName}")]
        public HttpResponseMessage Put(string ResourceName, [FromBody] Resource bodyResource)
        {
            System.Diagnostics.Trace.WriteLine("PUT: " + this.ControllerContext.Request.RequestUri.OriginalString);
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            if (String.IsNullOrEmpty(this.ControllerContext.Request.RequestUri.Query))
            {
                throw new FhirServerException(HttpStatusCode.BadRequest, "Conditional updates not supported without query parameters");
            }

            if (!String.IsNullOrEmpty(bodyResource.Id))
            {
                // This is a conditional update, so clear the Id on the record
                // so that it doesn't accidentally get processed
                bodyResource.Id = null;
            }

            OperationOutcome so = new OperationOutcome();
            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot PUT a AuditEvent, you must POST them");
            }

            // so.Success();
            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                string ifMatch = null;
                var conditionalSearchParams = this.ControllerContext.Request.RequestUri.ParseQueryString().TupledParameters();
                if (conditionalSearchParams.Count() > 0)
                {
                    ifMatch = this.ControllerContext.Request.RequestUri.Query;
                }

                var result = model.Create(bodyResource, ifMatch, null, null).Result;
                // if (bodyResource is Binary)
                this.ControllerContext.Request.SaveEntry(bodyResource);
                result.ResourceBase = inputs.BaseUri;
                var actualResource = result;

                // Check the prefer header
                if (Request.Headers.Contains("Prefer"))
                {
                    string preferHeader = Request.Headers.GetValues("Prefer").FirstOrDefault();
                    if (preferHeader != null && preferHeader.ToLower() == "return=operationoutcome")
                    {
                        if (!(result is OperationOutcome))
                        {
                            so = new OperationOutcome()
                            {
                                Text = Utility.CreateNarative("Resource update")
                            };
                            so.Text.Status = Narrative.NarrativeStatus.Generated;
                            so.Issue = new List<OperationOutcome.IssueComponent>
                        {
                            new OperationOutcome.IssueComponent()
                            {
                                Severity = OperationOutcome.IssueSeverity.Information,
                                Code = OperationOutcome.IssueType.Informational,
                                Details = new CodeableConcept(null, null, "Update was completed")
                            }
                        };
                            result = so;
                        }
                    }
                }

                HttpResponseMessage returnMessage;
                if (bodyResource.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                    returnMessage = Request.CreateResponse(HttpStatusCode.Created, result);
                else
                    returnMessage = Request.CreateResponse(HttpStatusCode.OK, result);

                // Put in the "Location" header
                if (actualResource is Bundle)
                {
                    returnMessage.Headers.Add("Location", result.ResourceIdentity(actualResource.ResourceBase).OriginalString);
                    Request.Properties.Add(Const.ResourceIdentityKey, actualResource.ResourceIdentity().MakeRelative().OriginalString);
                }
                else if (!(actualResource is OperationOutcome) && !string.IsNullOrEmpty(actualResource.Id))
                {
                    returnMessage.Headers.Add("Location", actualResource.ResourceIdentity(actualResource.ResourceBase).OriginalString);
                    Request.Properties.Add(Const.ResourceIdentityKey, actualResource.ResourceIdentity().MakeRelative().OriginalString);
                }
                if (actualResource.Meta != null && !string.IsNullOrEmpty(actualResource.Meta.VersionId))
                {
                    returnMessage.Headers.Add("ETag", String.Format("W/\"{0}\"", actualResource.Meta.VersionId));
                }
                if (actualResource.Meta != null && actualResource.Meta.LastUpdated.HasValue)
                {
                    returnMessage.Content.Headers.LastModified = actualResource.Meta.LastUpdated.Value;
                    // returnMessage.Headers.Add("Last-Modified", actualResource.Meta.LastUpdated.Value.ToString("r"));
                }

                // Check the prefer header
                if (Request.Headers.Contains("Prefer"))
                {
                    string preferHeader = Request.Headers.GetValues("Prefer").FirstOrDefault();
                    if (preferHeader != null && preferHeader.ToLower() == "return=minimal")
                    {
                        returnMessage.Content = null;
                    }
                }

                return returnMessage;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support update on this server");
            }
        }

        // PUT fhir/Patient/5
        [HttpPut, Route("{ResourceName}/{id}")]
        public HttpResponseMessage Put(string ResourceName, string id, [FromBody] Resource bodyResource)
        {
            System.Diagnostics.Trace.WriteLine("PUT: " + this.ControllerContext.Request.RequestUri.OriginalString);
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            if (!Id.IsValidValue(id))
            {
                throw new FhirServerException(HttpStatusCode.BadRequest, "ID [" + id + "] is not a valid FHIR Resource ID");
            }

            bodyResource.Id = id;
            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot PUT a AuditEvent, you must POST them");
            }

            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                var result = model.Create(bodyResource, null, null, null).Result;
                this.ControllerContext.Request.SaveEntry(bodyResource);
                result.ResourceBase = inputs.BaseUri;
                var actualResource = result;

                ResourceIdentity ri = null;
                if (result is Bundle)
                {
                    ri = result.ResourceIdentity(result.ResourceBase);
                }
                else if (!(result is OperationOutcome) && !string.IsNullOrEmpty(result.Id))
                {
                    ri = result.ResourceIdentity(result.ResourceBase);
                }

                // Check the prefer header
                if (Request.Headers.Contains("Prefer"))
                {
                    string preferHeader = Request.Headers.GetValues("Prefer").FirstOrDefault();
                    if (preferHeader != null && preferHeader.ToLower() == "return=operationoutcome")
                    {
                        if (!(result is OperationOutcome))
                        {
                            OperationOutcome so = new OperationOutcome()
                            {
                                Text = Utility.CreateNarative("Resource update")
                            };
                            so.Text.Status = Narrative.NarrativeStatus.Generated;
                            so.Issue = new List<OperationOutcome.IssueComponent>
                        {
                            new OperationOutcome.IssueComponent()
                            {
                                Severity = OperationOutcome.IssueSeverity.Information,
                                Code = OperationOutcome.IssueType.Informational,
                                Details = new CodeableConcept(null, null, "Update was completed")
                            }
                        };
                            result = so;
                        }
                    }
                }

                HttpResponseMessage returnMessage;
                if (bodyResource.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                    returnMessage = Request.CreateResponse(HttpStatusCode.Created, result);
                else
                    returnMessage = Request.CreateResponse(HttpStatusCode.OK, result);

                // Put in the "Location" header
                if (ri != null)
                {
                    returnMessage.Headers.Add("Location", ri.OriginalString);
                    Request.Properties.Add(Const.ResourceIdentityKey, ri.MakeRelative().OriginalString);
                }
                if (actualResource.Meta != null && !string.IsNullOrEmpty(actualResource.Meta.VersionId))
                {
                    returnMessage.Headers.Add("ETag", String.Format("W/\"{0}\"", actualResource.Meta.VersionId));
                }
                if (actualResource.Meta != null && actualResource.Meta.LastUpdated.HasValue)
                {
                    // returnMessage.Headers.CacheControl.
                    returnMessage.Content.Headers.LastModified = actualResource.Meta.LastUpdated.Value;
                }

                // Check the prefer header
                if (Request.Headers.Contains("Prefer"))
                {
                    string preferHeader = Request.Headers.GetValues("Prefer").FirstOrDefault();
                    if (preferHeader != null && preferHeader.ToLower() == "return=minimal")
                    {
                        returnMessage.Content = null;
                    }
                }

                return returnMessage;
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support update on this server");
            }
        }

        // DELETE fhir/values/5
        [HttpDelete, Route("{ResourceName}/{id}")]
        public HttpResponseMessage Delete(string ResourceName, string id)
        {
            System.Diagnostics.Trace.WriteLine("DELETE: " + this.ControllerContext.Request.RequestUri.OriginalString);
            var buri = this.CalculateBaseURI("{ResourceName}");


            var inputs = GetInputs(buri);

            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot DELETE a AuditEvent");
            }
            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                string deletedIdentity = model.Delete(id, null).Result;
                Request.Properties.Add(Const.ResourceIdentityKey, deletedIdentity);

                var msg = Request.CreateResponse(HttpStatusCode.NoContent);
                if (!string.IsNullOrEmpty(deletedIdentity))
                {
                    ResourceIdentity ri = new ResourceIdentity(deletedIdentity);
                    msg.Headers.Add("ETag", String.Format("W/\"{0}\"", ri.VersionId));
                }
                return msg;
                // for an OperationOutcome return would need to return accepted
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support delete on this server");
            }
        }

        // DELETE fhir/Patient?identifier=http://example.org/demo|34
        [HttpDelete, Route("{ResourceName}")]
        public HttpResponseMessage Delete(string ResourceName)
        {
            System.Diagnostics.Trace.WriteLine("DELETE: " + this.ControllerContext.Request.RequestUri.OriginalString);
            var buri = this.CalculateBaseURI("{ResourceName}");

            var inputs = GetInputs(buri);

            if (Request.TupledParameters().Count() == 0)
            {
                var oo = new OperationOutcome()
                {
                    Text = Utility.CreateNarative("Precondition Error")
                };
                oo.Issue = new List<OperationOutcome.IssueComponent>
                {
                    new OperationOutcome.IssueComponent()
                    {
                        Details = new CodeableConcept(null, null, "Conditionally deleting a " + ResourceName + " requires parameters"),
                        Severity = OperationOutcome.IssueSeverity.Fatal
                    }
                };
                // return oo;
                return Request.CreateResponse(HttpStatusCode.BadRequest, oo);
            }

            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot DELETE a AuditEvent");
            }
            IFhirResourceServiceR4<IDependencyScope> model = GetResourceModel(ResourceName, inputs);

            try
            {
                string ifMatch = Request.RequestUri.Query;
                if (ifMatch.StartsWith("?"))
                    ifMatch = ifMatch.Substring(1);
                string deletedIdentity = model.Delete(null, ifMatch).Result;
                Request.Properties.Add(Const.ResourceIdentityKey, deletedIdentity);

                var msg = Request.CreateResponse(HttpStatusCode.NoContent);
                if (!string.IsNullOrEmpty(deletedIdentity))
                {
                    ResourceIdentity ri = new ResourceIdentity(deletedIdentity);
                    msg.Headers.Add("ETag", String.Format("W/\"{0}\"", ri.VersionId));
                }
                return msg;
                // for an OperationOutcome return would need to return accepted
            }
            catch (NotImplementedException)
            {
                // This type of exception is perfectly fine and expected, don't want the exception being otherwise caught
                throw new FhirServerException(HttpStatusCode.NotImplemented, $"Resource [{ResourceName}] does not support conditional delete on this server");
            }
        }
    }
}
