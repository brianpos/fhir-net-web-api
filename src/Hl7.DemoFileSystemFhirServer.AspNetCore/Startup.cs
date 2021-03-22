using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Fhir.NetCoreApi;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Configuration;
#if NETCOREAPP3_0 || NETCOREAPP3_1
using Microsoft.Extensions.Hosting;
#endif

namespace Hl7.DemoFileSystemFhirServer
{
    public class Startup
    {
#if NETCOREAPP3_0 || NETCOREAPP3_1
        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }
        private IWebHostEnvironment _env;
#else
        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }
        private IHostingEnvironment _env;
        
#endif

        public IConfiguration Configuration { get; set; }

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

            // Load the configuration settings
            var configBuilder = new ConfigurationBuilder()
#if NETCOREAPP3_0 || NETCOREAPP3_1
               .SetBasePath(_env.ContentRootPath)
#else
               .SetBasePath(_env.ContentRootPath)
#endif
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddEnvironmentVariables();
            Configuration = configBuilder.Build();
            var settings = Configuration.GetOption<ServerSettings>("ServerSettings");

            // CORS Support
            services.AddCors(o => o.AddDefaultPolicy(builder =>
            {
                // Better to use with Origins to only permit locations that we really trust
                // builder.AllowAnyOrigin();
                builder.WithOrigins(settings.AllowedOrigins);
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowCredentials();
                builder.WithExposedHeaders(new[] { "Content-Location", "Location", "Etag" });
            }));

            DirectorySystemService.Directory = settings.ServerBaseDirectory;
            if (!System.IO.Directory.Exists(DirectorySystemService.Directory))
                System.IO.Directory.CreateDirectory(DirectorySystemService.Directory);

            var systemService = new DirectorySystemService();
            var reverseProxyAddresses = new System.Collections.Generic.Dictionary<string, System.Uri>();
            reverseProxyAddresses.Add("https://demo.org", new System.Uri("https://demo.org/testme"));
            reverseProxyAddresses.Add("https://demo2.org", new System.Uri("https://demo.org/testme"));

            services.UseFhirServerController(systemService, options => 
            {
                // An example HTML formatter that puts the raw XML on the output
                options.OutputFormatters.Add(new Fhir.WebApi.SimpleHtmlFhirOutputFormatter());
            }, reverseProxyAddresses);

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

            // Strip out all of the markdown search parameter descriptions from memory as they do nothing for us
            foreach (var sp in Hl7.Fhir.Model.ModelInfo.SearchParameters)
            {
                sp.Description = null;
            }
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

            app.UseCors();
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
