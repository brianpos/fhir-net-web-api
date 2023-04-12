using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// FHIR SMART App Launch Metadata Class definition based on FHIR Specification (nearing publication as final v2 version)
    /// <a href="http://build.fhir.org/ig/HL7/smart-app-launch/conformance.html#metadata">http://build.fhir.org/ig/HL7/smart-app-launch/conformance.html#metadata</a>
    /// https://hl7.org/fhir/smart-app-launch/conformance.html
    /// </summary>
    public class FhirSmartAppLaunchConfiguration
    {
        /// <summary>
        /// CONDITIONAL, String conveying this system’s OpenID Connect Issuer URL. Required if the server’s capabilities include `sso-openid-connect`; otherwise, omitted
        /// </summary>
        public string issuer { get; set; }

        /// <summary>
        /// REQUIRED, URL to the OAuth2 authorization endpoint
        /// </summary>
        public string authorization_endpoint { get; set; }

        /// <summary>
        /// REQUIRED, URL to the OAuth2 token endpoint
        /// </summary>
        public string token_endpoint { get; set; }

        /// <summary>
        /// OPTIONAL, array of client authentication methods supported by the token endpoint. The options are <b>"client_secret_post"</b> and <b>"client_secret_basic"</b>
        /// </summary>
        /// <remarks>
        /// Note that the specification which has a conflicting definition, <b>"token_endpoint_auth_methods"</b>,
        /// however this has been clarified to this value as per the OIDC specification (http://jira.hl7.org/browse/FHIR-27831)
        /// (This should be resolved before the v2 spec is published)
        /// </remarks>
        public IEnumerable<string> token_endpoint_auth_methods_supported { get; set; }

        /// <summary>
        /// OPTIONAL, if available, URL to the OAuth2 dynamic registration endpoint for this FHIR server
        /// </summary>
        public string registration_endpoint { get; set; }

        /// <summary>
        /// RECOMMENDED, array of scopes a client may request. See <a href="http://docs.smarthealthit.org/authorization/scopes-and-launch-context/#quick-start">scopes and launch</a> context.
        /// The server SHALL support all scopes listed here;
        /// additional scopes MAY be supported (so clients should not consider this an exhaustive list)
        /// </summary>
        public IEnumerable<string> scopes_supported { get; set; }

        /// <summary>
        /// RECOMMENDED, array of OAuth2 response_type values that are supported
        /// </summary>
        public IEnumerable<string> response_types_supported { get; set; }

        /// <summary>
        /// RECOMMENDED, URL where an end-user can view which applications currently have access to data and can make adjustments to these access rights
        /// </summary>
        public string management_endpoint { get; set; }

        /// <summary>
        /// RECOMMENDED, URL to a server’s introspection endpoint that can be used to validate a token
        /// </summary>
        public string introspection_endpoint { get; set; }

        /// <summary>
        /// RECOMMENDED, URL to a server’s revoke endpoint that can be used to revoke a token
        /// </summary>
        public string revocation_endpoint { get; set; }

        /// <summary>
        /// Array of PKCE code challenge methods supported.
        /// The <b>"S256"</b> method SHALL be included in this list, and the "plain" method SHALL NOT be included in this list.
        /// </summary>
        public IEnumerable<string> code_challenge_methods_supported { get; set; }

        /// <summary>
        /// REQUIRED, array of strings representing SMART capabilities (e.g., "single-sign-on" or "launch-standalone") that the server supports
        /// (as listed <a href="http://build.fhir.org/ig/HL7/smart-app-launch/conformance.html#capability-sets">here</a>)
        /// </summary>
        public IEnumerable<string> capabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        public IEnumerable<string> grant_types_supported { get; set; }
    }
}
