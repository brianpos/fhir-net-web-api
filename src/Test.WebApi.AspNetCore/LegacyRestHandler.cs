using System;
using System.Net.Http;
using System.Threading;

namespace UnitTestWebApi
{
    public class LegacyRestHandler : DelegatingHandler
    {
        public LegacyRestHandler()
        {
        }

        public LegacyRestHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        public EventHandler<HttpResponseMessage> OnAfterResponse;
        public EventHandler<HttpRequestMessage> OnBeforeRequest;

#if NET5_0_OR_GREATER
        protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (OnBeforeRequest != null)
                OnBeforeRequest(this, request);
            var response = base.Send(request, cancellationToken);
            if (OnAfterResponse != null)
                OnAfterResponse(this, response);
            return response;
        }
#endif

        protected override async System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (OnBeforeRequest != null)
                OnBeforeRequest(this, request);
            var response = await base.SendAsync(request, cancellationToken);
            if (OnAfterResponse != null)
                OnAfterResponse(this, response);
            return response;
        }
    }
}
