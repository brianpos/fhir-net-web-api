using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hl7.Fhir.Rest
{
    public class FhirHttpClient : IDisposable, IFhirHttpClient
    {
        private bool _ownsHttpClient;
        private HttpClient _httpClient;
        private readonly Hl7.Fhir.Serialization.FhirXmlParser _xmlParser = new Hl7.Fhir.Serialization.FhirXmlParser();
        private readonly Hl7.Fhir.Serialization.FhirXmlSerializer _xmlSerializer = new Hl7.Fhir.Serialization.FhirXmlSerializer();
        private readonly string _baseAddress;

        public FhirHttpClient(string baseAddress, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _ownsHttpClient = false;
            _baseAddress = baseAddress.TrimEnd('/');
        }

        public FhirHttpClient(string baseAddress, params DelegatingHandler[] handlers)
        {
            _httpClient = HttpClientFactory.Create(handlers);
            _ownsHttpClient = true;
            _baseAddress = baseAddress.TrimEnd('/');
        }

        public FhirHttpClient(string baseAddress, HttpMessageHandler innerHandler, params DelegatingHandler[] handlers)
        {
            _httpClient = HttpClientFactory.Create(innerHandler, handlers);
            _ownsHttpClient = true;
            _baseAddress = baseAddress.TrimEnd('/');
        }

        private ResourceIdentity verifyResourceIdentity(Uri location, bool needId, bool needVid)
        {
            var result = new ResourceIdentity(location);

            if (result.ResourceType == null) throw Error.Argument(nameof(location), "Must be a FHIR REST url containing the resource type in its path");
            if (needId && result.Id == null) throw Error.Argument(nameof(location), "Must be a FHIR REST url containing the logical id in its path");
            if (needVid && !result.HasVersion) throw Error.Argument(nameof(location), "Must be a FHIR REST url containing the version id in its path");

            return result;
        }

        /// <summary>
        /// This is extracted from the regular FhirClient (v1.9.0) Requester.cs
        /// </summary>
        /// <param name="operationName"></param>
        /// <param name="status"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        private static Exception BuildFhirOperationException(string operationName, System.Net.HttpStatusCode status, Resource body)
        {
            string message;

            if (status.IsInformational())
                message = $"{operationName} resulted in an informational response ({status})";
            else if (status.IsRedirection())
                message = $"{operationName} resulted in a redirection response ({status})";
            else if (status.IsClientError())
                message = $"{operationName} was unsuccessful because of a client error ({status})";
            else
                message = $"{operationName} was unsuccessful, and returned status {status}";

            if (body is OperationOutcome outcome)
                return new FhirOperationException($"{message}. OperationOutcome: {outcome.ToString()}.", status, outcome);
            else if (body != null)
                return new FhirOperationException($"{message}. Body contains a {body.TypeName}.", status);
            else
                return new FhirOperationException($"{message}. Body has no content.", status);
        }

        public async Task<TResource> CreateAsync<TResource>(TResource resource)
             where TResource : Resource
        {
            string requestUrl = $"{_baseAddress}/{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}";
            var postContent = new System.Net.Http.ByteArrayContent(_xmlSerializer.SerializeToBytes(resource));
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(ContentType.XML_CONTENT_HEADER);
            var msg = new HttpRequestMessage(HttpMethod.Post, requestUrl);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            msg.Content = postContent;
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<TResource>(xr);
            }
            // Check for an operation outcome returned
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Create", response.StatusCode, outcome);
        }

        public async System.Threading.Tasks.Task DeleteAsync(Resource resource)
        {
            string requestUrl = $"{_baseAddress}/{resource.TypeName}/{resource.Id}";
            var msg = new HttpRequestMessage(HttpMethod.Delete, requestUrl);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                // serialize the result
                var stream = await response.Content.ReadAsStreamAsync();
                var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
                var outcome = _xmlParser.Parse<OperationOutcome>(xr);
                throw BuildFhirOperationException("Delete", response.StatusCode, outcome);
            }
        }

        public async System.Threading.Tasks.Task DeleteAsync(string location)
        {
            if (location == null) throw Error.ArgumentNull(nameof(location));
            var uri = new Uri(location, UriKind.Relative);

            var id = verifyResourceIdentity(uri, needId: true, needVid: false);
            string requestUrl = $"{_baseAddress}/{id.ResourceType}/{id.Id}";

            var msg = new HttpRequestMessage(HttpMethod.Delete, requestUrl);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                // serialize the result
                var stream = await response.Content.ReadAsStreamAsync();
                var xr = SerializationUtil.XmlReaderFromStream(stream);
                var outcome = _xmlParser.Parse<OperationOutcome>(xr);
                throw BuildFhirOperationException("Delete", response.StatusCode, outcome);
            }
        }

        #region IDisposable Support
        protected bool _disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_httpClient != null && _ownsHttpClient)
                    {
                        _httpClient.Dispose();
                        _httpClient = null;
                    }
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        public async Task<TResource> ReadAsync<TResource>(string resourceId)
            where TResource : Resource
        {
            string requestUrl = $"{_baseAddress}/{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}/{resourceId}";
            if (resourceId.StartsWith($"{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}/"))
                requestUrl = $"{_baseAddress}/{resourceId}";
            var response = await _httpClient.GetAsync(requestUrl).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<TResource>(xr);
            }
            // Check for an operation outcome returned
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Read", response.StatusCode, outcome);
        }

        public async Task<Resource> GetAsync(string location)
        {
            var uri = new Uri(location, UriKind.RelativeOrAbsolute);

            if (!uri.IsAbsoluteUri)
                uri = HttpUtil.MakeAbsoluteToBase(uri, new Uri(_baseAddress));

            var response = await _httpClient.GetAsync(uri).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<Resource>(xr);
            }
            // Check for an operation outcome returned
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Get", response.StatusCode, outcome);
        }

        public async Task<Bundle> SearchAsync<TResource>(string[] searchParameters = null)
            where TResource : Resource
        {
            string requestUrl = $"{_baseAddress}/{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}";
            if (searchParameters != null)
            {
                UriParamList spd = new UriParamList(searchParameters.Select(criteria => criteria.SplitLeft('=')));
                requestUrl += "?" + spd.ToQueryString();
            }
            var response = await _httpClient.GetAsync(requestUrl).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<Bundle>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Search", response.StatusCode, outcome);
        }

        public async Task<Bundle> SearchAsync<TResource>(SearchParams searchParameters)
            where TResource : Resource
        {
            string requestUrl = $"{_baseAddress}/{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}";
            if (searchParameters != null)
            {
                UriParamList spd = searchParameters.ToUriParamList();
                requestUrl += "?" + spd.ToQueryString();
            }
            var response = await _httpClient.GetAsync(requestUrl).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<Bundle>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Search", response.StatusCode, outcome);
        }

        public async Task<TResource> UpdateAsync<TResource>(TResource resource)
            where TResource : Resource
        {
            string requestUrl = $"{_baseAddress}/{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}/{resource.Id}";
            var postContent = new System.Net.Http.ByteArrayContent(_xmlSerializer.SerializeToBytes(resource));
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(ContentType.XML_CONTENT_HEADER);
            var msg = new HttpRequestMessage(HttpMethod.Put, requestUrl);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            msg.Content = postContent;
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<TResource>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Update", response.StatusCode, outcome);
        }

        public async Task<Bundle> ContinueAsync(Bundle current, PageDirection direction = PageDirection.Next)
        {
            if (current == null) throw Error.ArgumentNull(nameof(current));
            if (current.Link == null) return null;

            Uri continueAt = null;

            switch (direction)
            {
                case PageDirection.First:
                    continueAt = current.FirstLink; break;
                case PageDirection.Previous:
                    continueAt = current.PreviousLink; break;
                case PageDirection.Next:
                    continueAt = current.NextLink; break;
                case PageDirection.Last:
                    continueAt = current.LastLink; break;
            }

            if (continueAt != null)
            {
                var msg = new HttpRequestMessage(HttpMethod.Get, continueAt);
                msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
                var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
                var stream = await response.Content.ReadAsStreamAsync();
                var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
                if (response.IsSuccessStatusCode)
                {
                    // serialize the result
                    return _xmlParser.Parse<Bundle>(xr);
                }
                var outcome = _xmlParser.Parse<OperationOutcome>(xr);
                throw BuildFhirOperationException("Continue", response.StatusCode, outcome);
            }
            // Return a null bundle, can not return simply null because this is a task
            return null;
        }

        public async Task<CapabilityStatement> CapabilityStatementAsync(SummaryType? summary = null)
        {
            string requestUrl = $"{_baseAddress}/metadata";
            if (summary != null)
                requestUrl += $"?_summary={summary.GetLiteral()}";

            var msg = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<CapabilityStatement>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("CapabilityStatement", response.StatusCode, outcome);
        }

        public async Task<Resource> InstanceOperationAsync(Uri location, string operationName, Parameters parameters = null, bool useGet = false)
        {
            if (location == null) throw Error.ArgumentNull(nameof(location));
            if (operationName == null) throw Error.ArgumentNull(nameof(operationName));

            var id = verifyResourceIdentity(location, needId: true, needVid: false);

            RestUrl requestUrl = new RestUrl(_baseAddress).AddPath(id.ResourceType, id.Id);
            if (id.HasVersion)
                requestUrl.AddPath("_history", id.VersionId);
            requestUrl.AddPath("$" + operationName);

            // Brian: Not sure why we would create this parameters object as empty.
            //        I would imagine that a null parameters object is different to an empty one?
            // EK: What else could we do?  POST an empty body?  We cannot use GET unless the caller indicates this is an
            // idempotent call....
            // MV: (related to issue #419): we only provide an empty parameter when we are not performing a GET operation. In r4 it will be allowed 
            //     to provide an empty body in POST operations. In that case the line of code can be deleted.
            if (parameters == null && !useGet) parameters = new Parameters();

            System.Net.Http.ByteArrayContent postContent = null;
            if (useGet)
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters.Parameter)
                    {
                        requestUrl.AddParam(parameter.Name, paramValueToString(parameter));
                    }
                }
            }
            else
            {
                if (parameters != null)
                {
                    postContent = new System.Net.Http.ByteArrayContent(_xmlSerializer.SerializeToBytes(parameters));
                    postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(ContentType.XML_CONTENT_HEADER);
                }
            }

            var msg = new HttpRequestMessage(useGet ? HttpMethod.Get : HttpMethod.Post, requestUrl.AsString);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            msg.Content = postContent;
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<Resource>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Operation", response.StatusCode, outcome);
        }

        public async Task<Resource> TypeOperationAsync(string operationName, string typeName, Parameters parameters = null, bool useGet = false)
        {
            if (typeName == null) throw Error.ArgumentNull(nameof(typeName));
            if (operationName == null) throw Error.ArgumentNull(nameof(operationName));

            RestUrl requestUrl = new RestUrl(_baseAddress).AddPath(typeName);
            requestUrl.AddPath("$" + operationName);

            // Brian: Not sure why we would create this parameters object as empty.
            //        I would imagine that a null parameters object is different to an empty one?
            // EK: What else could we do?  POST an empty body?  We cannot use GET unless the caller indicates this is an
            // idempotent call....
            // MV: (related to issue #419): we only provide an empty parameter when we are not performing a GET operation. In r4 it will be allowed 
            //     to provide an empty body in POST operations. In that case the line of code can be deleted.
            if (parameters == null && !useGet) parameters = new Parameters();

            System.Net.Http.ByteArrayContent postContent = null;
            if (useGet)
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters.Parameter)
                    {
                        requestUrl.AddParam(parameter.Name, paramValueToString(parameter));
                    }
                }
            }
            else
            {
                if (parameters != null)
                {
                    postContent = new System.Net.Http.ByteArrayContent(_xmlSerializer.SerializeToBytes(parameters));
                    postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(ContentType.XML_CONTENT_HEADER);
                }
            }

            var msg = new HttpRequestMessage(useGet ? HttpMethod.Get : HttpMethod.Post, requestUrl.AsString);
            msg.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType.XML_CONTENT_HEADER));
            msg.Content = postContent;
            var response = await _httpClient.SendAsync(msg).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<Resource>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw BuildFhirOperationException("Operation", response.StatusCode, outcome);
        }

        // replica of extension method from FhirClientOperations in 1.9.0
        public async Task<OperationOutcome> ValidateResourceAsync(DomainResource resource, string id = null, FhirUri profile = null)
        {
            if (resource == null) throw Error.ArgumentNull(nameof(resource));

            var par = new Parameters().Add("resource", resource);
            if (profile != null) par.Add("profile", profile);

            if (id == null)
            {
                return OperationResult<OperationOutcome>(await TypeOperationAsync(RestOperation.VALIDATE_RESOURCE, resource.TypeName, par).ConfigureAwait(false));
            }

            var loc = ResourceIdentity.Build(resource.TypeName, id);
            return OperationResult<OperationOutcome>(await InstanceOperationAsync(loc, RestOperation.VALIDATE_RESOURCE, par).ConfigureAwait(false));
        }

        internal static T OperationResult<T>(Resource result) where T : Resource
        {
            if (result == null) return null;

            //If this is immediately what we are expecting, that's fine
            if (result is T) return (T)result;

            // If return value is a Parameters object with a single result of the expected type,
            // return it (it should be called "return", but I don't care).
            if (result is Parameters pars && pars.Parameter.Count == 1 && pars.Parameter[0].Resource is T)
                return (T)pars.Parameter[0].Resource;

            // Else, throw. The return type is unexpected
            throw Error.InvalidOperation($"Operation did not return a {typeof(T).Name} but a {result.GetType().Name}");
        }

        private string paramValueToString(Parameters.ParameterComponent parameter)
        {
            if (parameter.Value != null)
            {
                switch (parameter.Value)
                {
                    case Identifier id:
                        return id.ToToken();
                    case Coding coding:
                        return coding.ToToken();
                    case ContactPoint contactPoint:
                        return contactPoint.ToToken();
                    case CodeableConcept codeableConcept:
                        return codeableConcept.ToToken();
                    default:
                        if (ModelInfo.IsPrimitive(parameter.Value.GetType()))
                        {
                            return parameter.Value.ToString();
                        }
                        break;
                }
            }
            throw Error.InvalidOperation($"Parameter '{parameter.Name}' has a non-primitive type, which is not allowed.");
        }

    }
}