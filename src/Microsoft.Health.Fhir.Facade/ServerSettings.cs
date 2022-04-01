using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hl7.DemoFileSystemFhirServer
{
    public class ServerSettings
    {
        public string[] AllowedOrigins { get; set; }
        public string ServerBaseDirectory { get; set; }
    }

    public static class ConfigurationExtension
    {
        public static TOptions GetOption<TOptions>(this IConfiguration configuration, string settingKey)
            where TOptions : class, new()
        {
            var azureOptions = new TOptions();
            // KNP dont ask me why but u need to manually import Microsoft.Extensions.Configuration.Binder to see the extension
            // it's not in the extensions lib above
            // https://andrewlock.net/how-to-use-the-ioptions-pattern-for-configuration-in-asp-net-core-rc2/
            configuration.Bind(settingKey, azureOptions);
            return azureOptions;
        }
    }
}
