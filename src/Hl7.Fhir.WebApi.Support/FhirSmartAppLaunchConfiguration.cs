using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.WebApi
{
    public class FhirSmartAppLaunchConfiguration
    {
        public string authorization_endpoint { get; set; }
        public string token_endpoint { get; set; }
        public IEnumerable<string> token_endpoint_auth_methods_supported { get; set; }
        public string registration_endpoint { get; set; }
        public IEnumerable<string> scopes_supported { get; set; }
        public IEnumerable<string> response_types_supported { get; set; }
        public string management_endpoint { get; set; }
        public string introspection_endpoint { get; set; }
        public string revocation_endpoint { get; set; }
        public IEnumerable<string> capabilities { get; set; }
    }
}
