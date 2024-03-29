﻿/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.Validation;

namespace Hl7.Fhir.WebApi
{
	public static class WebApiConfig
	{
        internal static IFhirSystemServiceR4<IDependencyScope> _systemService;
        internal static Dictionary<string, Uri> _supportedForwardedForSystems;

        public static void Register(HttpConfiguration config, IFhirSystemServiceR4<IDependencyScope> systemService, Dictionary<string, Uri> supportedForwardedForSystems = null)
		{
            _systemService = systemService;
            _supportedForwardedForSystems = supportedForwardedForSystems;

            config.MessageHandlers.Add(new InterceptBodyHandler());
            config.MessageHandlers.Add(new MediaTypeHandler());

            config.Filters.Add(new FhirExceptionFilter());

            config.MapHttpAttributeRoutes();

            // remove existing formatters
            config.Formatters.Clear();

            // Hook custom formatters            
            config.Formatters.Add(new XmlFhirFormatter());
            config.Formatters.Add(new JsonFhirFormatter());
            config.Formatters.Add(new BinaryFhirFormatter());

            // Add these formatters in case our own throw exceptions, at least you
            // get a decent error message from the default formatters then.
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.Add(new XmlMediaTypeFormatter());

            // EK: Remove the default BodyModel Validator. We don't need it,
            // and it makes the Validation framework throw a null reference exception
            // when the body empty. This only surfaces when calling a DELETE with no body,
            // while the action method has a parameter for the body.
            config.Services.Replace(typeof(IBodyModelValidator), null);
        }
	}
}
