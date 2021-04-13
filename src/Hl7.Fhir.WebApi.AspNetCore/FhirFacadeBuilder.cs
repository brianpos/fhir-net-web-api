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
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Hl7.Fhir.NetCoreApi
{
    public static class FhirFacadeBuilder
    {
        internal static IFhirSystemServiceR4<IServiceProvider> _systemService;
        internal static Dictionary<string, Uri> _supportedForwardedForSystems;

        /// <summary>
        /// Add the facade for the FHIR server using the provided System service model
        /// </summary>
        /// <param name="services"></param>
        /// <param name="systemService"></param>
        /// <param name="setupAction">This action is called once the options are all prepared, incase the caller wants to extend any further, such as registering other output formatters (e.g. HTML)</param>
        /// <param name="supportedForwardedForSystems">A dictionary of server addresses forwarded from and what to (the value could include a virtual folder that should be assumed if the provided forwarded for address is detected)</param>
        public static void UseFhirServerController(this IServiceCollection services, IFhirSystemServiceR4<IServiceProvider> systemService, Action<MvcOptions> setupAction, Dictionary<string, Uri> supportedForwardedForSystems = null)
        {
            NetCoreApi.FhirFacadeBuilder._systemService = systemService;
            _supportedForwardedForSystems = supportedForwardedForSystems;
#if NETCOREAPP2_2
            services.AddMvc(options =>
            {
                // remove the default formatters
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.JsonInputFormatter>();
                // Note there is a default implementation of the json patch in here, need to know how to hook into that
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.JsonPatchInputFormatter>();
#else
            services.AddControllers(options =>
            {
                // remove the default formatters
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>();
                // Note there is a default implementation of the json patch in here, need to know how to hook into that
                // options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.JsonPatchInputFormatter>();
#endif

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

                // And our exception handler that processes FhirServerExceptions into appropriate results
                options.Filters.Add(new FhirExceptionFilter());

                // permit the HTML to be generated for the browser
                options.RespectBrowserAcceptHeader = true;

                // give caller opportunity to modify the mvc options
                setupAction(options);
#if NETCOREAPP2_2
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
#else
            }).AddApplicationPart(typeof(FhirR4Controller).Assembly);
#endif
        }


        //
        // Summary:
        //     Adds endpoints for controller actions to the Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
        //     without specifying any routes.
        //
        // Parameters:
        //   endpoints:
        //     The Microsoft.AspNetCore.Routing.IEndpointRouteBuilder.
        //
        // Returns:
        //     An Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder for
        //     endpoints associated with controller actions.
#if !NETCOREAPP2_2
        public static void MapFhirSmartAppLaunchController(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet(".well-known/smart-configuration", async context =>
            {
                var config = context.RequestServices.GetService<FhirSmartAppLaunchConfiguration>();
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 200;
                var jsonSettings = new Newtonsoft.Json.JsonSerializerSettings() { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore };
                await context.Response.WriteAsync(Newtonsoft.Json.JsonConvert.SerializeObject(config, settings: jsonSettings));
            });
        }
#endif
    }
}
