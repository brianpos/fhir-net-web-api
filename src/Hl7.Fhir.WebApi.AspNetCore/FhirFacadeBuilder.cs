/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Microsoft.Extensions.DependencyInjection;
using Hl7.Fhir.WebApi;
using System.Buffers;
using Microsoft.AspNetCore.Mvc;
using System;
using Hl7.Fhir.NetCoreApi.R4;

namespace Hl7.Fhir.NetCoreApi
{
    public static class FhirFacadeBuilder
    {
        internal static IFhirSystemServiceR4<IServiceProvider> _systemService;

        /// <summary>
        /// Add the facade for the FHIR server using the provided System service model
        /// </summary>
        /// <param name="services"></param>
        /// <param name="systemService"></param>
        /// <param name="setupAction">This action is called once the options are all prepared, incase the caller wants to extend any futher, such as registering other output formatters (e.g. HTML)</param>
        public static void UseFhirServerController(this IServiceCollection services, IFhirSystemServiceR4<IServiceProvider> systemService, Action<MvcOptions> setupAction)
        {
            NetCoreApi.FhirFacadeBuilder._systemService = systemService;
            services.AddControllers(options =>
            {
                // remove the default formatters
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>();
                // Note there is a default implementation of the json patch in here, need to know how to hook into that
                // options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.JsonPatchInputFormatter>();

                options.InputFormatters.Add(new XmlFhirInputFormatter());
                options.InputFormatters.Add(new JsonFhirInputFormatter());
                options.InputFormatters.Add(new BinaryFhirInputFormatter());

                options.OutputFormatters.Clear();
                options.OutputFormatters.Add(new XmlFhirOutputFormatter());
                options.OutputFormatters.Add(new JsonFhirOutputFormatter(ArrayPool<char>.Shared));
                options.OutputFormatters.Add(new BinaryFhirOutputFormatter());

                // and include our custom content negotiator filter to handle the _format parameter
                // (from the FHIR spec:  http://hl7.org/fhir/http.html#mime-type )
                // https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters
                options.Filters.Add(new FhirFormatParameterFilter());

                // permit the HTML to be generated for the browser
                options.RespectBrowserAcceptHeader = true;

                // give caller opportunity to modify the mvc options
                setupAction(options);
            });
        }
    }
}
