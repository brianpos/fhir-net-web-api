using Hl7.DemoFileSystemFhirServer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;

namespace UnitTestWebApi
{
    internal class UnitTestFhirServerApplication : WebApplicationFactory<Startup>
    {
        private readonly string _environment;

        public UnitTestFhirServerApplication(string environment = "Development")
        {
            _environment = environment;
            Server.BaseAddress = new Uri("https://localhost/");
        }

        protected override IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(x => x.UseStartup<Startup>()
                    .UseTestServer());
        }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseEnvironment(_environment);
            return base.CreateHost(builder);
        }
    }
}
