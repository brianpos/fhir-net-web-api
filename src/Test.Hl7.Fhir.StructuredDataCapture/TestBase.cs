using System.Diagnostics;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Hl7.Fhir.StructuredDataCapture.Test
{
    public class TestBase
    {
        public static void DebugDumpXml(Base item)
        {
            if (item == null)
                Trace.WriteLine("(null)");
            else
            {
                Trace.WriteLine(new FhirXmlSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(item));
            }
        }
    }
}
