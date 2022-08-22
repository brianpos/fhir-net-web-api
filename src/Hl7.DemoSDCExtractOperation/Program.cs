// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Configuration;
using Hl7.Fhir.Rest;

namespace Hl7.DemoFhirAzureFunctionApp
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults((IFunctionsWorkerApplicationBuilder builder) =>
                {
                    var config = new ConfigurationBuilder()
                        .AddEnvironmentVariables()
                        .Build();
                    builder.Services.AddTransient<FhirClient>((services) => { return new FhirClient(config["baseURL"]); });

                    // Register our custom middlewares with the worker
                    builder.UseMiddleware<ExceptionHandlingMiddleware>();

                    builder.UseWhen<StampHttpHeaderMiddleware>((context) =>
                    {
                        // We want to use this middleware only for http trigger invocations.
                        return context.FunctionDefinition.InputBindings.Values
                                      .First(a => a.Type.EndsWith("Trigger")).Type == "httpTrigger";
                    });
                },
                (WorkerOptions options) => {
                    // Register a converter that will handle converting a Resource derived class as a model binding from the http request body
                    // It will work out if the content is XML or JSON and convert that on the way in too.
                    options.InputConverters.Register<FhirInputConverter>();
                })
                .Build();
            host.Run();
        }
    }
}