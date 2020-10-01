using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hl7.Fhir.WebApi
{
    public class BackgroundProcessInputScope
    {
        public ModelBaseInputs<IServiceProvider> RequestDetails { get; internal set;}
        public IServiceScope Scope { get; internal set; }
    }

    public static class InputScopeExtensions
    {
        /// <summary>
        /// The Scope returned must be disposed by the caller of this routine
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static BackgroundProcessInputScope NewScope(this ModelBaseInputs<IServiceProvider> request)
        {
            var newScope = request.ServiceProvider.CreateScope();
            return new BackgroundProcessInputScope 
            {
                RequestDetails = new ModelBaseInputs<IServiceProvider>(
                    request.User, request.ClientCertificate,
                    request.HttpMethod, request.RequestUri, request.BaseUri,
                    request.X_Api_Key, request.Headers, request.ServiceProvider)
                {
                    X_CorelationId = request.X_CorelationId
                }, 
                Scope = newScope
            };
        }
    }
}
