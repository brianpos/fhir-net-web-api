using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml;
using Task = System.Threading.Tasks.Task;

namespace UnitTestWebApi
{
    [TestClass]
    public class CanonicalVersionTests
    {
        [TestMethod]
        public void CurrentCanonicalOperation()
        {
            var app = new UnitTestFhirServerApplication();
            HttpClient client = app.CreateClient();
            var clientFhir = new FhirClient(app.Server.BaseAddress, client);

            // create some test data
            var q1 = new Questionnaire { Id = "q1", Url = "http://example.org/canonical", Version = "10.1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2", Url = "http://example.org/canonical", Version = "2.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3", Url = "http://example.org/canonical", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "integer"));
            clientFhir.Update(q1);
            clientFhir.Update(q2);
            clientFhir.Update(q3);

            var p = new Parameters();
            p.Parameter.Add(new Parameters.ParameterComponent() { Name = "url", Value = new FhirString(q1.Url) });
            var result = clientFhir.TypeOperation<Questionnaire>("current-canonical", p);
            BasicFacade.DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a capability statement returned");
            Assert.IsInstanceOfType(result, typeof(Questionnaire));
            Assert.AreEqual("q1", result.Id);
        }

        [TestMethod]
        public void CurrentCanonicalOperationByStatus()
        {
            var app = new UnitTestFhirServerApplication();
            HttpClient client = app.CreateClient();
            var clientFhir = new FhirClient(app.Server.BaseAddress, client);

            // create some test data
            var q1 = new Questionnaire { Id = "q1", Url = "http://example.org/canonical", Version = "10.1", Status = PublicationStatus.Retired };
            var q2 = new Questionnaire { Id = "q2", Url = "http://example.org/canonical", Version = "2.2", Status = PublicationStatus.Draft };
            var q3 = new Questionnaire { Id = "q3", Url = "http://example.org/canonical", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "integer"));
            clientFhir.Update(q1);
            clientFhir.Update(q2);
            clientFhir.Update(q3);

            var p = new Parameters();
            p.Parameter.Add(new Parameters.ParameterComponent() { Name = "url", Value = new FhirString(q1.Url) });
            var result = clientFhir.TypeOperation<Questionnaire>("current-canonical", p);
            BasicFacade.DebugDumpOutputXml(result);
            Assert.IsInstanceOfType(result, typeof(Questionnaire));
            Assert.AreEqual("q3", result.Id);

            p.Parameter.Add(new Parameters.ParameterComponent() { Name = "status", Value = new FhirString("draft") });
            result = clientFhir.TypeOperation<Questionnaire>("current-canonical", p);
            BasicFacade.DebugDumpOutputXml(result);
            Assert.IsInstanceOfType(result, typeof(Questionnaire));
            Assert.AreEqual("q2", result.Id);
        }

        [TestMethod]
        public void NumericCanonicalVersions()
        {
            var q1 = new Questionnaire { Url = "http://example.org/canonical", Version = "10.1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Url = "http://example.org/canonical", Version = "2.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Url = "http://example.org/canonical", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "integer"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3 });
            Assert.AreEqual(q1.Version, result.Version);

            result = CurrentCanonical.Current(new[] { q3, q2, q1 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public void SemverCanonicalVersions()
        {
            var q1 = new Questionnaire { Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "11.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Version = "1.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "semver"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q2.Version, result.Version);
        }

        [TestMethod]
        public void SemverCanonicalVersionsWithPreReleases()
        {
            var q1 = new Questionnaire { Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "1.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Version = "1.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "semver"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q5.Version, result.Version);
        }

        [TestMethod]
        public void FhirpathCanonicalVersions()
        {
            var q1 = new Questionnaire { Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "11.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Version = "1.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm("iif(%version1 > %version2, -1, iif(%version1 < %version2, 1, 0))"); // as version is a string, this comes out as an alpha sort

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public void AlphaCanonicalVersions()
        {
            var q1 = new Questionnaire { Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "1.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Version = "12.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "alpha"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public void NaturalCanonicalVersions()
        {
            var q1 = new Questionnaire { Version = "general1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "general2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Version = "general3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Version = "general1000", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Version = "general200", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "natural"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q4.Version, result.Version);
        }


        [TestMethod]
        public void SortCanonicalVersions()
        {
            var q1 = new Questionnaire { Version = "general1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "general2", Status = PublicationStatus.Retired };
            var q3 = new Questionnaire { Version = "general3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Version = "general1000", Status = PublicationStatus.Draft };
            var q5 = new Questionnaire { Version = "general200", Status = PublicationStatus.Retired };
            var q6 = new Questionnaire { Version = "general200" };
            q3.versionAlgorithm(new Coding(null, "natural"));

            IOrderedEnumerable<IVersionableConformanceResource> result = CurrentCanonical.Ordered(new[] { q1, q2, q3, q4, q5, q6 });
            foreach (var item in result)
                System.Diagnostics.Trace.WriteLine($"{item.Status?.ToString() ?? "(null)"}, {item.Version}");
            Assert.AreEqual(q3.Version, result.First().Version);
        }
    }
}
