using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Fhir.NetCoreApi;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using System.IO;
#if NETCOREAPP3_0 || NETCOREAPP3_1
using Microsoft.Extensions.Hosting;
#endif

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

            DirectorySystemService.Directory = @"c:\temp\demoserver";
            if (!System.IO.Directory.Exists(DirectorySystemService.Directory))
                System.IO.Directory.CreateDirectory(DirectorySystemService.Directory);

            var systemService = new DirectorySystemService();

            services.UseFhirServerController(systemService, options => { /* options.OutputFormatters.Add(new TelstraHealth.FhirHtmlFormatter.FhirHtmlOutputFormatter()); */ });
            // services.AddScoped<TelstraHealth.FhirHtmlFormatter.RazorViewToStringRenderer>();

            // register the Static Content
#if NETCOREAPP2_2
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.FileProviders.Clear();
                options.FileProviders.Add(new PhysicalFileProvider(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            });
#endif
#if NETCOREAPP3_0 || NETCOREAPP3_1
            services.AddRazorPages(options =>
            {
                options.RootDirectory = "/wwwroot";
            });
#endif

            // Tell the Net stack to only use TLS
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // This should not be in any production system, it
            // essentially permits dud certs being used
            // unchecked.
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender2, cert2, chain, sslPolicyErrors) => true;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
#if NETCOREAPP2_2
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
#endif
#if NETCOREAPP3_0 || NETCOREAPP3_1
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
#endif
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

#if NETCOREAPP2_2
            app.UseMvc();
#endif
#if NETCOREAPP3_0 || NETCOREAPP3_1
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapFallbackToFile(System.IO.Path.Combine(env.WebRootPath, "content"));
            });
#endif
        }
    }
}
