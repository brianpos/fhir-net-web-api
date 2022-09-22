using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Owin;
using System.Web.Http;
using Hl7.Fhir.WebApi;
using Microsoft.AspNet.WebApi.Extensions.Compression.Server.Owin;
using System.Net.Http.Extensions.Compression.Core.Compressors;
using Hl7.Fhir.DemoFileSystemFhirServer;
using Microsoft.Owin.Logging;

namespace Hl7.DemoFileSystemFhirServer
{
    public class Startup
    {
        // This test stuff was based off the code found here:
        // http://www.asp.net/web-api/overview/hosting-aspnet-web-api/use-owin-to-self-host-web-api
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            DirectorySystemService<System.Web.Http.Dependencies.IDependencyScope>.Directory = @"c:\temp\demoserver-4.3.0";
            if (!System.IO.Directory.Exists(DirectorySystemService<System.Web.Http.Dependencies.IDependencyScope>.Directory))
                System.IO.Directory.CreateDirectory(DirectorySystemService<System.Web.Http.Dependencies.IDependencyScope>.Directory);

            // Configure Web API for self-host.
            HttpConfiguration config = new HttpConfiguration();
            var reverseProxyAddresses = new System.Collections.Generic.Dictionary<string, System.Uri>();
            // reverseProxyAddresses.Add("https://demo.org", new System.Uri("https://demo.org/testme"));
            // reverseProxyAddresses.Add("https://demo2.org", new System.Uri("https://demo.org/testme"));

            var systemService = new DirectorySystemService<System.Web.Http.Dependencies.IDependencyScope>();
            systemService.InitializeIndexes();
            WebApiConfig.Register(config, systemService, reverseProxyAddresses); // this is from the actual WebAPI Project
            config.Formatters.Add(new SimpleHtmlFhirOutputFormatter());

            // https://github.com/azzlack/Microsoft.AspNet.WebApi.MessageHandlers.Compression
            config.MessageHandlers.Insert(0, new OwinServerCompressionHandler(4096, new GZipCompressor(), new DeflateCompressor()));

            // register the logger
            appBuilder.CreateLogger<Startup>();

            appBuilder.UseWebApi(config);
        }
    }
}
