using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.Rest
{
    public class FhirHttpClient : IDisposable, IFhirHttpClient
    {
        System.Net.Http.HttpClient _httpClient;
        Hl7.Fhir.Serialization.FhirXmlParser _xmlParser = new Hl7.Fhir.Serialization.FhirXmlParser();
        Hl7.Fhir.Serialization.FhirXmlSerializer _xmlSerializer = new Hl7.Fhir.Serialization.FhirXmlSerializer();
        private string _baseAddress;

        public FhirHttpClient(string baseAddress, params DelegatingHandler[] handlers)
        {
            _httpClient = HttpClientFactory.Create(handlers);
            _baseAddress = baseAddress.TrimEnd('/');
        }

        public FhirHttpClient(string baseAddress, HttpMessageHandler innerHandler, params DelegatingHandler[] handlers)
        {
            _httpClient = HttpClientFactory.Create(innerHandler, handlers);
            _baseAddress = baseAddress.TrimEnd('/');
        }

        /// <summary>
        /// This is extracted from the regular FhirClient (v1.9.0) Requester.cs
        /// </summary>
        /// <param name="operationName"></param>
        /// <param name="status"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        private static Exception buildFhirOperationException(string operationName, System.Net.HttpStatusCode status, Resource body)
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
            throw buildFhirOperationException("Create", response.StatusCode, outcome);
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
                throw buildFhirOperationException("Delete", response.StatusCode, outcome);
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
                    if (_httpClient != null)
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
            throw buildFhirOperationException("Read", response.StatusCode, outcome);
        }

        public async Task<Bundle> SearchAsync<TResource>(string[] searchParameters)
            where TResource : Resource
        {
            UriParamList spd = new UriParamList(searchParameters.Select(criteria => criteria.SplitLeft('=')));
            string requestUrl = $"{_baseAddress}/{Hl7.Fhir.Model.ModelInfo.GetFhirTypeNameForType(typeof(TResource))}?{spd.ToQueryString()}";
            var response = await _httpClient.GetAsync(requestUrl).ConfigureAwait(false);
            var stream = await response.Content.ReadAsStreamAsync();
            var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream);
            if (response.IsSuccessStatusCode)
            {
                // serialize the result
                return _xmlParser.Parse<Bundle>(xr);
            }
            var outcome = _xmlParser.Parse<OperationOutcome>(xr);
            throw buildFhirOperationException("Search", response.StatusCode, outcome);
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
            throw buildFhirOperationException("Update", response.StatusCode, outcome);
        }
    }
}