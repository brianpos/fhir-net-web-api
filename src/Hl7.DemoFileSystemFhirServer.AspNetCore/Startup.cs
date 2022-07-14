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
using Hl7.Fhir.WebApi;
using Hl7.Fhir.DemoFileSystemFhirServer;
using System;
using Microsoft.Extensions.Logging;
using Hl7.Fhir.Introspection;
using System.Reflection;
using Microsoft.Extensions.Hosting;

namespace Hl7.DemoFileSystemFhirServer
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            // Workaround for the R4B Citation resource
            if (!Hl7.Fhir.Model.ModelInfo.FhirTypeToCsType.ContainsKey("Citation"))
            {
                Hl7.Fhir.Model.ModelInfo.FhirTypeToCsType.Add("Citation", typeof(Hl7.Fhir.Model.Citation));
                Hl7.Fhir.Model.ModelInfo.FhirCsTypeToString.Add(typeof(Hl7.Fhir.Model.Citation), "Citation");
            }

            _env = env;
        }
        private IWebHostEnvironment _env;

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
               .SetBasePath(_env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddEnvironmentVariables();
            Configuration = configBuilder.Build();
            var settings = Configuration.GetOption<ServerSettings>("ServerSettings");

            services.AddTransient<FhirSmartAppLaunchConfiguration>(options =>
            {
                var result = new FhirSmartAppLaunchConfiguration();
                var authBaseAddress = "https://localhost:5001/connect/";
                result.authorization_endpoint = $"{authBaseAddress}authorize";
                result.token_endpoint = $"{authBaseAddress}token";

                result.introspection_endpoint = $"{authBaseAddress}introspect";
                result.revocation_endpoint = $"{authBaseAddress}revocation";
                result.token_endpoint_auth_methods_supported = new string[] { "client_secret_basic", "client_secret_post" };
                result.scopes_supported = new string[] { "openid", "profile", "launch", "patient/*.*", "user/*.*", "offline_access" };
                result.response_types_supported = new string[] { "code", "code id_token", "id_token", "refresh_token" };
                result.capabilities = new string[] { "launch-ehr", "launch-standalone", "client-public", "client-confidential-symmetric" };
                result.code_challenge_methods_supported = new[] { "S256" };
                return result;
            });

            services.AddLogging(logging => {
                logging.AddConsole(config => {
                   //  config.LogToStandardErrorThreshold = LogLevel.Trace;
                });
            });

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

            DirectorySystemService<System.IServiceProvider>.Directory = settings.ServerBaseDirectory;
            if (!System.IO.Directory.Exists(DirectorySystemService<System.IServiceProvider>.Directory))
                System.IO.Directory.CreateDirectory(DirectorySystemService<System.IServiceProvider>.Directory);

            var reverseProxyAddresses = new System.Collections.Generic.Dictionary<string, System.Uri>();
            reverseProxyAddresses.Add("https://demo.org", new System.Uri("https://demo.org/testme"));
            reverseProxyAddresses.Add("https://demo2.org", new System.Uri("https://demo.org/testme"));

            // services.AddSingleton<IFhirSystemServiceR4<IServiceProvider>>(systemService);
            services.AddSingleton<IFhirSystemServiceR4<IServiceProvider>>((s) => {
                var systemService = new DirectorySystemService<System.IServiceProvider>();
                systemService.InitializeIndexes();
                return systemService;
            });

            services.UseFhirServerController(/*systemService,*/ options =>
            {
                // An example HTML formatter that puts the raw XML on the output
                options.OutputFormatters.Add(new Fhir.WebApi.SimpleHtmlFhirOutputFormatter());
            }, reverseProxyAddresses);

            // register the Static Content
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

            // Strip out all of the markdown search parameter descriptions from memory as they do nothing for us
            foreach (var sp in Hl7.Fhir.Model.ModelInfo.SearchParameters)
            {
                sp.Description = null;
            }
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

            app.UseCors();
            app.UseAuthentication();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapFhirSmartAppLaunchController();
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapFallbackToFile(System.IO.Path.Combine(env.WebRootPath, "content"));
            });
        }
    }
}
