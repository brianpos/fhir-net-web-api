// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Middleware;
using Task = System.Threading.Tasks.Task;

namespace Hl7.DemoFhirAzureFunctionApp
{
    /// <summary>
    /// Middleware to stamp a response header on the result of http trigger invocation.
    /// </summary>
    internal sealed class StampHttpHeaderMiddleware : IFunctionsWorkerMiddleware
    {
        public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
        {
            var requestData = await context.GetHttpRequestDataAsync();

            string correlationId;
            if (requestData!.Headers.TryGetValues("x-correlationId", out var values))
            {
                correlationId = values.First();
            }
            else
            {
                correlationId = Guid.NewGuid().ToString();
            }

            await next(context);

            context.GetHttpResponseData()?.Headers.Add("x-correlationId", correlationId);
        }
    }
}