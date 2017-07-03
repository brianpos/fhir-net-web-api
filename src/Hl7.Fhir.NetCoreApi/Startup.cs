using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Hl7.Fhir.WebApi;
using System.Buffers;
using Microsoft.Extensions.ObjectPool;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using Hl7.Fhir.NetCoreApi.STU3;
using Hl7.DemoFileSystemFhirServer;

namespace Hl7.Fhir.NetCoreApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            _systemService = new DirectorySystemService();
            DirectorySystemService.Directory = @"c:\temp\demoserver";
            if (!System.IO.Directory.Exists(DirectorySystemService.Directory))
                System.IO.Directory.CreateDirectory(DirectorySystemService.Directory);
        }

        internal static IFhirSystemServiceSTU3 _systemService;

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc(options =>
            {
                // remove the default formatters
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.JsonInputFormatter>();
                // Note there is a default implementation of the json patch in here, need to know how to hook into that
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.JsonPatchInputFormatter>();

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
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            app.UseResponseBuffering();
        }
    }
}
