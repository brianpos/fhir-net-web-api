/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Hl7.Fhir.NetCoreApi.R4;
using Hl7.FhirPath.Sprache;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// This class basically implements
    /// http://hl7.org/fhir/r4/http.html
    /// </summary>
    [Route("")]
    public partial class FhirR4Controller : Controller
    {
        internal ModelBaseInputs<IServiceProvider> GetInputs(string baseUrl)
        {
            return GetInputs(Request, User, new Uri(baseUrl));
        }

        readonly string[] SearchQueryParameterNames = { "_summary", "_sort", "_count", "_format" };
        readonly string[] OperationQueryParameterNames = { "_summary", "_format" };

        internal static ModelBaseInputs<IServiceProvider> GetInputs(HttpRequest Request, System.Security.Principal.IPrincipal User, Uri baseUrl)
        {
            // If the headers indicate that this was through a proxy, update the baseurl to come from that location
            if (NetCoreApi.FhirFacadeBuilder._supportedForwardedForSystems?.Count > 0)
            {
                if (Request.Headers.ContainsKey("Forwarded"))
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
                if (Request.Headers.ContainsKey("X-Forwarded-Proto") && Request.Headers.ContainsKey("X-Forwarded-Host") && Request.Headers.ContainsKey("X-Forwarded-Port"))
                {
                    // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-Host
                    // X-Forwarded-For=30.10.0.2;X-Forwarded-Proto=https;X-Forwarded-Host=fhirtest.emerging.com.au;X-Forwarded-Port=443;
                    string proto = Request.Headers["X-Forwarded-Proto"];
                    string host = Request.Headers["X-Forwarded-Host"];
                    string port = Request.Headers["X-Forwarded-Port"];
                    if (port == "443")
                        port = null;
                    else
                        port = ":" + port;
                    string proxyUrl = $"{proto}://{host}{port}";
                    if (NetCoreApi.FhirFacadeBuilder._supportedForwardedForSystems.ContainsKey(proxyUrl))
                        baseUrl = NetCoreApi.FhirFacadeBuilder._supportedForwardedForSystems[proxyUrl];
                    else
                        baseUrl = new Uri(proxyUrl);
                }
            }

            var cert = Request.HttpContext.Connection.ClientCertificate;
            var inputs = new ModelBaseInputs<IServiceProvider>(
                User,
                cert,
                Request.Method,
                new Uri(Request.GetDisplayUrl()), //RequestUri,
                baseUrl,
                Request.Header("x-api-key"),
                Request.Headers.Select(h => new KeyValuePair<string, IEnumerable<string>>(h.Key, h.Value)),
                Request.HttpContext.RequestServices);
            if (Request.Headers.ContainsKey("X-Correlation-Id"))
            {
                inputs.X_CorelationId = Request.Header("X-Correlation-Id");
            }
            else
            {
                inputs.X_CorelationId = Guid.NewGuid().ToFhirId();
            }
            Request.HttpContext.Items.Add("fhir-inputs", inputs);
            inputs.CancellationToken = Request.HttpContext.RequestAborted;
            return inputs;
        }

        internal static IFhirSystemServiceR4<IServiceProvider> GetSystemModel(ModelBaseInputs<IServiceProvider> inputs)
        {
            return NetCoreApi.FhirFacadeBuilder._systemService;
        }

        internal static IFhirResourceServiceR4<IServiceProvider> GetResourceModel(string ResourceName, ModelBaseInputs<IServiceProvider> inputs)
        {
            var model = NetCoreApi.FhirFacadeBuilder._systemService.GetResourceService(inputs, ResourceName);

            if (model != null)
                return model;

            throw new FhirServerException(HttpStatusCode.NotFound, "Resource [" + ResourceName + "] is not supported on this server");
        }

        public static Hl7.Fhir.Rest.SummaryType GetSummaryParameter(HttpRequest request)
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
        public async Task<IActionResult> ProcessBatch([FromBody]Bundle batch)
        {
            var buri = this.CalculateBaseURI("metadata");
            var inputs = GetInputs(buri);

            Bundle outcome = await GetSystemModel(inputs).ProcessBatch(inputs, batch);
            outcome.ResourceBase = inputs.BaseUri;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            PrepareResourceForOutputWithSummary(inputs, summary, outcome);
            var resultCode = HttpStatusCode.OK;
            if (outcome.HasAnnotation<HttpStatusCode>())
                resultCode = outcome.Annotation<HttpStatusCode>();
            return new FhirObjectResult(resultCode, outcome);
        }

        // GET fhir/values
        [HttpOptions, Route("")]
        [HttpGet, Route("metadata")]
        [AllowAnonymous]
        public async Task<Hl7.Fhir.Model.CapabilityStatement> GetConformance()
        {
            var buri = this.CalculateBaseURI("metadata");
            var inputs = GetInputs(buri);

            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            var con = await GetSystemModel(inputs).GetConformance(inputs, summary);
            con.ResourceBase = inputs.BaseUri;
            PrepareResourceForOutputWithSummary(inputs, summary, con);
            return con;
        }

        [HttpGet, Route(@"{ResourceName:regex(^((?!(C|c)ontent)(?!(S|S)cripts)[[A-Za-z]])+$)}/{id:regex(^(?!$.+)([[A-Za-z0-9\.-]])+$)}")]
        public Task<IActionResult> Get(string ResourceName, string id)
        {
            return Get(ResourceName, id, null);
        }

        // GET fhir/patient/5/_history/4
        //[HttpGet, Route("{type}/{id}/_history/{vid}")]
        [HttpGet, Route(@"{ResourceName:regex(^((?!(C|c)ontent)(?!(S|S)cripts)[[A-Za-z]])+$)}/{id:regex(^(?!$.+)([[A-Za-z0-9\.-]])+$)}/_history/{vid}")]
        public async Task<IActionResult> Get(string ResourceName, string id, string vid)
        {
            var buri = this.CalculateBaseURI("{ResourceName");
            var inputs = GetInputs(buri);

            if (!Id.IsValidValue(id))
            {
                throw new FhirServerException(HttpStatusCode.BadRequest, "ID [" + id + "] is not a valid FHIR Resource ID");
            }

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            Resource resource = await model.Get(id, vid, summary);
            PrepareResourceForOutputWithSummary(inputs, summary, resource);
            if (resource != null)
            {
                if (resource.HasAnnotation<HttpStatusCode>())
                    return new FhirObjectResult(resource.Annotation<HttpStatusCode>(), resource);
                return new FhirObjectResult(HttpStatusCode.OK, resource);
            }

            // this request is a "you wanted what?"
            return new NotFoundResult();
        }

        private static void PrepareResourceForOutputWithSummary(ModelBaseInputs<IServiceProvider> inputs, SummaryType summary, Resource resource)
        {
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
                resource.SetAnnotation(summary);
            }
        }

        [HttpGet, Route("{ResourceName}/{id}/${operation}")]
        public async Task<IActionResult> PerformOperationResourceInstance(string ResourceName, string id, string operation)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            Parameters operationParameters = new Parameters();
            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);
            var resource = await model.PerformOperation(id, operation, operationParameters, summary);
            PrepareResourceForOutputWithSummary(inputs, summary, resource);
            return PrepareOperationOutputMessage(inputs.BaseUri, resource);
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
        public async Task<IActionResult> PerformOperationResourceInstance(string ResourceName, string id, string operation, [FromBody] Resource inputResource)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);
            Parameters operationParameters = ConvertOperationParameters(operation, inputResource);

            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);
            var resource = await model.PerformOperation(id, operation, operationParameters, summary);
                PrepareResourceForOutputWithSummary(inputs, summary, resource);
            return PrepareOperationOutputMessage(inputs.BaseUri, resource);
        }

        [HttpGet, Route("{ResourceName}/${operation}")]
        public async Task<IActionResult> PerformOperationResourceType(string ResourceName, string operation)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            Parameters operationParameters = new Parameters();
            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);
            var resource = await model.PerformOperation(operation, operationParameters, summary);
                PrepareResourceForOutputWithSummary(inputs, summary, resource);
            return PrepareOperationOutputMessage(inputs.BaseUri, resource);
        }

        [HttpPost, Route("{ResourceName}/${operation}")]
        public async Task<IActionResult> PerformOperationResourceType(string ResourceName, string operation, [FromBody] Resource inputResource)
        {
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);
            Parameters operationParameters = ConvertOperationParameters(operation, inputResource);

            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);
            var resource = await model.PerformOperation(operation, operationParameters, summary);
                PrepareResourceForOutputWithSummary(inputs, summary, resource);
            return PrepareOperationOutputMessage(inputs.BaseUri, resource);
        }

        private IActionResult PrepareOperationOutputMessage(Uri baseUri, Resource resource)
        {
            if (resource != null)
            {
                resource.ResourceBase = baseUri;
                HttpStatusCode resultCode = HttpStatusCode.OK;
                if (resource.HasAnnotation<HttpStatusCode>())
                    resultCode = resource.Annotation<HttpStatusCode>();
                return new FhirObjectResult(resultCode, resource);
            }

            // this request is a "you wanted what?"
            return new NotFoundResult();
        }

        [HttpGet, Route("${operation}")]
        public async Task<IActionResult> PerformOperationSystem(string operation)
        {
            var buri = this.CalculateBaseURI("${operation}");
            var inputs = GetInputs(buri);
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            Parameters operationParameters = new Parameters();
            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));

            Resource resource = await GetSystemModel(inputs).PerformOperation(inputs, operation, operationParameters, summary);
                PrepareResourceForOutputWithSummary(inputs, summary, resource);
            return PrepareOperationOutputMessage(inputs.BaseUri, resource);
        }

        [HttpPost, Route("${operation}")]
        public async Task<IActionResult> PerformOperationSystem(string operation, [FromBody] Resource inputResource)
        {
            var buri = this.CalculateBaseURI("${operation}");
            var inputs = GetInputs(buri);
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            Parameters operationParameters = ConvertOperationParameters(operation, inputResource);

            ExtractParametersFromUrl(ref operationParameters, Request.TupledParameters(OperationQueryParameterNames));

            Resource resource = await GetSystemModel(inputs).PerformOperation(inputs, operation, operationParameters, summary);
                PrepareResourceForOutputWithSummary(inputs, summary, resource);
            return PrepareOperationOutputMessage(inputs.BaseUri, resource);
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
        public Task<Bundle> SearchWithOperator(string ResourceName)
        {
            return Search(ResourceName);
        }

        // GET fhir/patient/
        // GET fhir/patient/search?
        //[HttpGet, Route("{type}")]
        //[HttpGet, Route("{type}/_search")]
        [HttpGet, Route("{ResourceName:regex(^[[A-Za-z]]+$)}")]
        public async Task<Bundle> Search(string ResourceName)
        {
            System.Diagnostics.Debug.WriteLine("GET: " + this.Request.GetDisplayUrl());

            var parameters = Request.TupledParameters(SearchQueryParameterNames);
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            string sortby = Request.GetParameter(FhirParameter.SORT);
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;

            var buri = this.CalculateBaseURI("{ResourceName");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            Bundle result = await model.Search(parameters, pagesize, summary);
            result.ResourceBase = inputs.BaseUri;

            PrepareResourceForOutputWithSummary(inputs, summary, result);
            return result;
        }

        // Need the POST form of search going to "{ResourceName}/_search"
        [HttpPost, Route("{ResourceName}/_search")]
        public async Task<Bundle> SearchByPost(string ResourceName)
        {
            System.Diagnostics.Debug.WriteLine("GET: " + this.Request.GetDisplayUrl());

            var parameters = Request.TupledParameters(SearchQueryParameterNames).ToList();
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);
            string sortby = Request.GetParameter(FhirParameter.SORT);
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            // Also grab the application/x-www-form-urlencoded content body
            if (Request.HasFormContentType)
            {
                var requestData = Request.Form;
                foreach (var item in requestData)
                {
                    parameters.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }
            }

            Bundle result = await model.Search(parameters, pagesize, summary);
            result.ResourceBase = inputs.BaseUri;

            PrepareResourceForOutputWithSummary(inputs, summary, result);
            return result;
        }

        // GET fhir/patient/_history
        [HttpGet, Route("{ResourceName}/_history")]
        public async Task<Bundle> ResourceHistory(string ResourceName)
        {
            System.Diagnostics.Debug.WriteLine("GET: " + this.Request.GetDisplayUrl());

            DateTimeOffset? since = Request.GetDateParameter("_since");
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            Bundle result = await model.TypeHistory(since, null, pagesize, summary);
            result.ResourceBase = inputs.BaseUri;

            PrepareResourceForOutputWithSummary(inputs, summary, result);
            return result;
        }

        // GET fhir/patient/5/_history
        //[HttpGet, Route("{type}/{id}/_history/{vid}")]
        [HttpGet, Route("{ResourceName}/{id}/_history")]
        public async Task<Bundle> InstanceHistory(string ResourceName, string id)
        {
            System.Diagnostics.Debug.WriteLine("GET: " + this.Request.GetDisplayUrl());

            DateTimeOffset? since = Request.GetDateParameter("_since");
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            Bundle result = await model.InstanceHistory(id, since, null, pagesize, summary);
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

            // this.Request.SaveEntry(result);
            PrepareResourceForOutputWithSummary(inputs, summary, result);
            return result;
        }

        [HttpGet, Route("_history")]
        public async Task<Bundle> WholeSystemHistory()
        {
            System.Diagnostics.Debug.WriteLine("GET: " + this.Request.GetDisplayUrl());
            var buri = this.CalculateBaseURI("_history");
            var inputs = GetInputs(buri);

            DateTimeOffset? since = Request.GetDateParameter("_since");
            int pagesize = Request.GetIntParameter(FhirParameter.COUNT) ?? Const.DEFAULT_PAGE_SIZE;
            Hl7.Fhir.Rest.SummaryType summary = GetSummaryParameter(Request);

            var model = GetSystemModel(inputs);

            Bundle result = await model.SystemHistory(inputs, since, null, pagesize, summary);
            result.ResourceBase = inputs.BaseUri;

            PrepareResourceForOutputWithSummary(inputs, summary, result);
            return result;
        }


        // POST fhir/values
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ResourceName"></param>
        /// <param name="bodyResource"></param>
        /// <returns></returns>
        /// <remarks>
        /// No need to test for null body, as the filters will throw the issue before it gets here
        /// Unit tests ensure this is the case
        /// </remarks>
        [HttpPost, Route("{ResourceName}", Order = 0)]
        public async Task<IActionResult> Post(string ResourceName, [FromBody] Resource bodyResource)
        {
            System.Diagnostics.Debug.WriteLine("POST: " + this.Request.GetDisplayUrl());
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

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
            return new BadRequestObjectResult(oo) { StatusCode = (int)HttpStatusCode.BadRequest };
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
                return new BadRequestObjectResult(oo) { StatusCode = (int)HttpStatusCode.BadRequest };
            }

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            var result = await model.Create(bodyResource, null, null, null);
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
            if (Request.Headers.ContainsKey("Prefer"))
            {
                string preferHeader = Request.Header("Prefer");
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

            FhirObjectResult returnMessage;
            if (actualResource.HasAnnotation<CreateOrUpate>())
            {
                if (actualResource.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                    returnMessage = new FhirObjectResult(HttpStatusCode.Created, result, actualResource);
                else
                    returnMessage = new FhirObjectResult(HttpStatusCode.OK, result, actualResource);
            }
            else
            {
                // The model didn't set the annotation, so we will just assume created is the appropriate call
                System.Diagnostics.Trace.WriteLine("The Model did not test the Annotation<CreateOrUpdate() on the returned resource");
                returnMessage = new FhirObjectResult(HttpStatusCode.Created, result, actualResource);
            }

            // Check the prefer header
            if (Request.Headers.ContainsKey("Prefer"))
            {
                string preferHeader = Request.Header("Prefer");
                if (preferHeader != null && preferHeader.ToLower() == "return=minimal")
                {
                    returnMessage.Value = null;
                }
            }

            if (bodyResource.HasAnnotation<HttpStatusCode>())
                returnMessage.StatusCode = (int)bodyResource.Annotation<HttpStatusCode>();
            if (actualResource.HasAnnotation<HttpStatusCode>())
                returnMessage.StatusCode = (int)actualResource.Annotation<HttpStatusCode>();

            return returnMessage;
        }

        /// <summary>
        /// Support for Conditional Updates
        /// eg. PUT fhir/Patient?identifier=http://temp|43&amp;birthDate=1973-10
        /// </summary>
        /// <param name="ResourceName"></param>
        /// <param name="bodyResource"></param>
        /// <returns></returns>
        [HttpPut, Route("{ResourceName}")]
        public async Task<IActionResult> Put(string ResourceName, [FromBody]Resource bodyResource)
        {
            System.Diagnostics.Debug.WriteLine("PUT: " + this.Request.GetDisplayUrl());
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            if (String.IsNullOrEmpty(this.Request.RequestUri().Query))
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
            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            string ifMatch = null;
            var conditionalSearchParams = this.Request.TupledParameters();
            if (conditionalSearchParams.Count() > 0)
            {
                ifMatch = this.Request.RequestUri().Query;
            }

            var result = await model.Create(bodyResource, ifMatch, null, null);
            result.ResourceBase = inputs.BaseUri;
            var actualResource = result;

            // Check the prefer header
            if (Request.Headers.ContainsKey("Prefer"))
            {
                string preferHeader = Request.Header("Prefer");
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

            FhirObjectResult returnMessage;
            if (actualResource.HasAnnotation<CreateOrUpate>())
            {
                if (actualResource.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                    returnMessage = new FhirObjectResult(HttpStatusCode.Created, result, actualResource);
                else
                    returnMessage = new FhirObjectResult(HttpStatusCode.OK, result, actualResource);
            }
            else
            {
                // The model didn't decide, so we'll just indicate that it was ok.
                System.Diagnostics.Trace.WriteLine("The Model did not test the Annotation<CreateOrUpdate() on the returned resource");
                returnMessage = new FhirObjectResult(HttpStatusCode.OK, result, actualResource);
            }

            // Check the prefer header
            if (Request.Headers.ContainsKey("Prefer"))
            {
                string preferHeader = Request.Header("Prefer");
                if (preferHeader != null && preferHeader.ToLower() == "return=minimal")
                {
                    returnMessage.Value = null;
                }
            }

            if (bodyResource.HasAnnotation<HttpStatusCode>())
                returnMessage.StatusCode = (int)bodyResource.Annotation<HttpStatusCode>();
            if (actualResource.HasAnnotation<HttpStatusCode>())
                returnMessage.StatusCode = (int)actualResource.Annotation<HttpStatusCode>();

            return returnMessage;
        }


        // PUT fhir/Patient/5
        [HttpPut, Route("{ResourceName}/{id}")]
        public async Task<IActionResult> Put(string ResourceName, string id, [FromBody]Resource bodyResource)
        {
            System.Diagnostics.Debug.WriteLine("PUT: " + this.Request.GetDisplayUrl());

            if (!Id.IsValidValue(id))
            {
                throw new FhirServerException(HttpStatusCode.BadRequest, "ID [" + id + "] is not a valid FHIR Resource ID");
            }

            var inputs = GetInputs(this.CalculateBaseURI("{ResourceName}"));

            bodyResource.Id = id;
            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot PUT a AuditEvent, you must POST them");
            }

            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            var result = await model.Create(bodyResource, null, null, null);
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
            if (Request.Headers.ContainsKey("Prefer"))
            {
                string preferHeader = Request.Header("Prefer");
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

            FhirObjectResult returnMessage;
            if (actualResource.HasAnnotation<CreateOrUpate>())
            {
                if (actualResource.Annotation<CreateOrUpate>() == CreateOrUpate.Create)
                    returnMessage = new FhirObjectResult(HttpStatusCode.Created, result, actualResource);
                else
                    returnMessage = new FhirObjectResult(HttpStatusCode.OK, result, actualResource);
            }
            else
            {
                // The model didn't decide, so we'll just indicate that it was ok.
                System.Diagnostics.Trace.WriteLine("The Model did not test the Annotation<CreateOrUpdate() on the returned resource");
                returnMessage = new FhirObjectResult(HttpStatusCode.OK, result, actualResource);
            }

            // Check the prefer header
            if (Request.Headers.ContainsKey("Prefer"))
            {
                string preferHeader = Request.Header("Prefer");
                if (preferHeader != null && preferHeader.ToLower() == "return=minimal")
                {
                    returnMessage.Value = null;
                }
            }

            if (bodyResource.HasAnnotation<HttpStatusCode>())
                returnMessage.StatusCode = (int)bodyResource.Annotation<HttpStatusCode>();
            if (actualResource.HasAnnotation<HttpStatusCode>())
                returnMessage.StatusCode = (int)actualResource.Annotation<HttpStatusCode>();

            return returnMessage;
        }

        // DELETE fhir/values/5
        [HttpDelete, Route("{ResourceName}/{id}")]
        public async Task<IActionResult> Delete(string ResourceName, string id)
        {
            System.Diagnostics.Debug.WriteLine("DELETE: " + this.Request.GetDisplayUrl());
            var buri = this.CalculateBaseURI("{ResourceName}");
            var inputs = GetInputs(buri);

            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot DELETE a AuditEvent");
            }
            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            string deletedIdentity = await model.Delete(id, null);
            // Request.Properties.Add(Const.ResourceIdentityKey, deletedIdentity);

            if (!string.IsNullOrEmpty(deletedIdentity))
            {
                ResourceIdentity ri = new ResourceIdentity(deletedIdentity);
                return FhirObjectResult.FhirDeletedResult(ri.VersionId);
            }
            return FhirObjectResult.FhirDeletedResult();
            // for an OperationOutcome return would need to return accepted
        }

        // DELETE fhir/Patient?identifier=http://example.org/demo|34
        [HttpDelete, Route("{ResourceName}")]
        public async Task<IActionResult> Delete(string ResourceName)
        {
            System.Diagnostics.Debug.WriteLine("DELETE: " + this.Request.GetDisplayUrl());
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
                return new FhirObjectResult(HttpStatusCode.BadRequest, oo);
            }

            if (ResourceName == "AuditEvent")
            {
                // depends on the AuditEvent, if was created by the server, then it will get an unauthorized exception report
                // otherwise externally reported events can be updated!
                //throw new FhirServerException(HttpStatusCode.MethodNotAllowed, "Cannot DELETE a AuditEvent");
            }
            IFhirResourceServiceR4<IServiceProvider> model = GetResourceModel(ResourceName, inputs);

            string ifMatch = Request.RequestUri().Query;
            if (ifMatch.StartsWith("?"))
                ifMatch = ifMatch.Substring(1);
            string deletedIdentity = await model.Delete(null, ifMatch);
            // Request.Properties.Add(Const.ResourceIdentityKey, deletedIdentity);

            if (!string.IsNullOrEmpty(deletedIdentity))
            {
                ResourceIdentity ri = new ResourceIdentity(deletedIdentity);
                return FhirObjectResult.FhirDeletedResult(ri.VersionId);
            }
            return FhirObjectResult.FhirDeletedResult();
            // for an OperationOutcome return would need to return accepted
        }
    }
}
