using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task = System.Threading.Tasks.Task;

namespace UnitTestWebApi
{
    [TestClass]
    public class HtmlOutputTests
    {
        [TestMethod]
        public void XmlOutputTests()
        {
            Patient p = TestPatient();

            var ct = new System.Threading.CancellationToken();
            var result = p.ToHtmlXml(ct, "http://example.org/", SummaryType.False);
            System.Diagnostics.Trace.WriteLine(result);
        }

        private static Patient TestPatient()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Gri&eves"));
            p.Name.Add(new HumanName().WithGiven("Brian").AndFamily("Postlethwaite"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");
            return p;
        }

        [TestMethod]
        public void JsonOutputTests()
        {
            Patient p = TestPatient();

            var ct = new System.Threading.CancellationToken();
            var result = p.ToHtmlJson(ct, "http://example.org/", SummaryType.False);
            System.Diagnostics.Trace.WriteLine(result);
        }
    }
}
