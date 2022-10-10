using Hl7.Fhir.Model;

namespace Hl7.Fhir.StructuredDataCapture
{
    public class CanonicalUrl
    {
        public CanonicalUrl(string canonicalWithOptionalVersion)
        {
            int index = canonicalWithOptionalVersion.IndexOf("|", System.StringComparison.CurrentCultureIgnoreCase);
            if (index != -1)
            {
                Url = new FhirUri(canonicalWithOptionalVersion.Substring(0, index));
                Version = new FhirString(canonicalWithOptionalVersion.Substring(index + 1));
            }
            else
            {
                Url = new FhirUri(canonicalWithOptionalVersion);
            }
        }

        public FhirUri Url { get; set; }
        public FhirString Version { get; set; }

        public string Value
        {
            get
            {
                if (!string.IsNullOrEmpty(Version?.Value))
                    return $"{Url.Value}|{Version?.Value}";
                return Url.Value;
            }
        }
    }
}
