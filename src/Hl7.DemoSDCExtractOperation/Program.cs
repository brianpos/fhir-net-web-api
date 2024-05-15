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
			var config = new ConfigurationBuilder()
				.AddEnvironmentVariables()
				.Build();

			var builder =
			new HostBuilder()
				.ConfigureFunctionsWebApplication((context, builder2) =>
				{
					builder2.Services.AddTransient<FhirClient>((services) => { return new FhirClient(config["BaseURL"]); });
					// Register our custom middlewares with the worker
					builder2.UseMiddleware<ExceptionHandlingMiddleware>();

					builder2.UseWhen<StampHttpHeaderMiddleware>((context) =>
					{
						// We want to use this middleware only for http trigger invocations.
						return context.FunctionDefinition.InputBindings.Values
									  .First(a => a.Type.EndsWith("Trigger")).Type == "httpTrigger";
					});
				});
			var host = builder.Build();
			host.Run();
		}
	}
}
