using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Fhir.NetCoreApi;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace Hl7.DemoFileSystemFhirServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options =>
            options.Level = System.IO.Compression.CompressionLevel.Fastest);
            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                            {
                               "application/fhir+xml",
                               "application/fhir+json"
                            });
                options.Providers.Add<GzipCompressionProvider>();
            });

            AzureBlobStorageSystemService.Directory = @"c:\temp\demoserver";
            if (!System.IO.Directory.Exists(AzureBlobStorageSystemService.Directory))
                System.IO.Directory.CreateDirectory(AzureBlobStorageSystemService.Directory);

            var systemService = new AzureBlobStorageSystemService();

            services.UseFhirServerController(systemService, options => { /* options.OutputFormatters.Add(new TelstraHealth.FhirHtmlFormatter.FhirHtmlOutputFormatter()); */ });
            // services.AddScoped<TelstraHealth.FhirHtmlFormatter.RazorViewToStringRenderer>();

            // register the Static Content
            //services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.FileProviders.Clear();
            //    options.FileProviders.Add(new PhysicalFileProvider(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            //});
            services.AddRazorPages(options =>
            {
                options.RootDirectory = "/wwwroot";
            });

            // Tell the Net stack to only use TLS
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // This should not be in any production system, it
            // essentially permits dud certs being used
            // unchecked.
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender2, cert2, chain, sslPolicyErrors) => true;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseResponseCompression();
            // app.UseResponseBuffering();
            app.UseStaticFiles(new StaticFileOptions(new Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions()
            {
                FileProvider = new PhysicalFileProvider(System.IO.Path.Combine(env.WebRootPath, "content")),
                RequestPath = "/content"
            }));

            app.UseAuthentication();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapFallbackToFile(System.IO.Path.Combine(env.WebRootPath, "content"));
            });
        }
    }
}
