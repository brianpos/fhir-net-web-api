﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker.Middleware;
using Microsoft.Extensions.Logging;

namespace Hl7.DemoFhirAzureFunctionApp
{
    /// <summary>
    /// This middleware catches any exceptions during function invocations and
    /// returns a response with 500 status code for http invocations.
    /// </summary>
    internal sealed class ExceptionHandlingMiddleware : IFunctionsWorkerMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing invocation");

                var httpReqData = await context.GetHttpRequestDataAsync();

                if (httpReqData != null)
                {
                    // Create an instance of HttpResponseData with 500 status code.
                    var newHttpResponse = httpReqData.CreateResponse(HttpStatusCode.InternalServerError);
                    // You need to explicitly pass the status code in WriteAsJsonAsync method.
                    // https://github.com/Azure/azure-functions-dotnet-worker/issues/776
                    await newHttpResponse.WriteAsJsonAsync(new { FooStatus = "Invocation failed!" }, newHttpResponse.StatusCode);

                    // Update invocation result.
                    context.GetInvocationResult().Value = newHttpResponse;
                }
            }
        }
    }
}