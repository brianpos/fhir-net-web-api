using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net.Http;

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
            var q1 = new Questionnaire { Id = "q1-ai", Url = "http://example.org/canonical-active-integer", Version = "10.1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-ai", Url = "http://example.org/canonical-active-integer", Version = "2.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-ai", Url = "http://example.org/canonical-active-integer", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));
            clientFhir.Update(q1);
            clientFhir.Update(q2);
            clientFhir.Update(q3);

            var p = new Parameters();
            p.Parameter.Add(new Parameters.ParameterComponent() { Name = "url", Value = new FhirString(q1.Url) });
            var result = clientFhir.TypeOperation<Questionnaire>("current-canonical", p);
            BasicFacade.DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a capability statement returned");
            Assert.IsInstanceOfType(result, typeof(Questionnaire));
            Assert.AreEqual("q1-ai", result.Id);
        }

        [TestMethod]
        public void CurrentCanonicalOperationByStatus()
        {
            var app = new UnitTestFhirServerApplication();
            HttpClient client = app.CreateClient();
            var clientFhir = new FhirClient(app.Server.BaseAddress, client);

            // create some test data
            var q1 = new Questionnaire { Id = "q1-si", Url = "http://example.org/canonical-status-integer", Version = "10.1", Status = PublicationStatus.Retired };
            var q2 = new Questionnaire { Id = "q2-si", Url = "http://example.org/canonical-status-integer", Version = "2.2", Status = PublicationStatus.Draft };
            var q3 = new Questionnaire { Id = "q3-si", Url = "http://example.org/canonical-status-integer", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));
            clientFhir.Update(q1);
            clientFhir.Update(q2);
            clientFhir.Update(q3);

            var p = new Parameters();
            p.Parameter.Add(new Parameters.ParameterComponent() { Name = "url", Value = new FhirString(q1.Url) });
            var result = clientFhir.TypeOperation<Questionnaire>("current-canonical", p);
            BasicFacade.DebugDumpOutputXml(result);
            Assert.IsInstanceOfType(result, typeof(Questionnaire));
            Assert.AreEqual("q3-si", result.Id);

            p.Parameter.Add(new Parameters.ParameterComponent() { Name = "status", Value = new FhirString("draft") });
            result = clientFhir.TypeOperation<Questionnaire>("current-canonical", p);
            BasicFacade.DebugDumpOutputXml(result);
            Assert.IsInstanceOfType(result, typeof(Questionnaire));
            Assert.AreEqual("q2-si", result.Id);
        }

        [TestMethod]
        public void ValidateCanonicalVersion()
        {
            var app = new UnitTestFhirServerApplication();
            HttpClient client = app.CreateClient();
            var clientFhir = new FhirClient(app.Server.BaseAddress, client);

            // create some test data
            var q1 = new Questionnaire { Id = "q1-ai", Url = "http://example.org/canonical-active-integer", Version = "10.1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-ai", Url = "http://example.org/canonical-active-integer", Version = "2.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-ai", Url = "http://example.org/canonical-active-integer", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));
            clientFhir.Update(q1);
            clientFhir.Update(q2);
            clientFhir.Update(q3);

            // Attempt to create another duplicate version 10.1
            try
            {
                var q4 = new Questionnaire { Id = "q4-ai", Url = "http://example.org/canonical-active-integer", Version = "10.1", Status = PublicationStatus.Active };
                clientFhir.Update(q4);
                Assert.Fail("Version 10.1 should be recorded as a duplicate");
                clientFhir.Delete(q4);
            }
            catch (FhirOperationException ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, ex.Status);
                var iss = ex.Outcome.Issue.First();
                Assert.AreEqual(OperationOutcome.IssueType.Duplicate, iss.Code);
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, iss.Severity);
            }
        }

        [TestMethod]
        public void ValidateInvalidCanonicalVersion()
        {
            var app = new UnitTestFhirServerApplication();
            HttpClient client = app.CreateClient();
            var clientFhir = new FhirClient(app.Server.BaseAddress, client);

            // create some test data
            var q3 = new Questionnaire { Id = "q3-ai", Url = "http://example.org/canonical-active-integer", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));
            clientFhir.Update(q3);

            try
            {
                // Attempt to create an invalid canonical (other resource has version algorithm)
                var q4 = new Questionnaire { Id = "q4-ai-inv-i1", Url = "http://example.org/canonical-active-integer", Version = "abc", Status = PublicationStatus.Active };
                clientFhir.Update(q4);
                Assert.Fail("Version format not reported as invalid");
                clientFhir.Delete(q4);
            }
            catch (FhirOperationException ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, ex.Status);
                var iss = ex.Outcome.Issue.First();
                Assert.AreEqual(OperationOutcome.IssueType.Value, iss.Code);
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, iss.Severity);
            }

            try
            {
                // Attempt to create an invalid canonical (this resource has version algorithm)
                var q4 = new Questionnaire { Id = "q4-inv-i2", Url = "http://example.org/canonical-inv-integer2", Version = "abc", Status = PublicationStatus.Active };
                q4.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));
                clientFhir.Update(q4);
                Assert.Fail("Version format not reported as invalid");
                clientFhir.Delete(q4);
            }
            catch (FhirOperationException ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, ex.Status);
                var iss = ex.Outcome.Issue.First();
                Assert.AreEqual(OperationOutcome.IssueType.Value, iss.Code);
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, iss.Severity);
            }

            try
            {
                // Attempt to create an invalid canonical (this resource has version algorithm)
                var q4 = new Questionnaire { Id = "q4-inv-s1", Url = "http://example.org/canonical-inv-semver", Version = "abc", Status = PublicationStatus.Active };
                q4.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "semver"));
                clientFhir.Update(q4);
                Assert.Fail("Version format not reported as invalid");
                clientFhir.Delete(q4);
            }
            catch (FhirOperationException ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, ex.Status);
                var iss = ex.Outcome.Issue.First();
                Assert.AreEqual(OperationOutcome.IssueType.Value, iss.Code);
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, iss.Severity);
            }

            try
            {
                // Attempt to create an invalid canonical (this resource has version algorithm)
                var q4 = new Questionnaire { Id = "q4-inv-d1", Url = "http://example.org/canonical-inv-date", Version = "abc", Status = PublicationStatus.Active };
                q4.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "date"));
                clientFhir.Update(q4);
                Assert.Fail("Version format not reported as invalid");
                clientFhir.Delete(q4);
            }
            catch (FhirOperationException ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, ex.Status);
                var iss = ex.Outcome.Issue.First();
                Assert.AreEqual(OperationOutcome.IssueType.Value, iss.Code);
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, iss.Severity);
            }
        }

        [TestMethod]
        public void ValidateCanonicalVersionAlgorithm()
        {
            var app = new UnitTestFhirServerApplication();
            HttpClient client = app.CreateClient();
            var clientFhir = new FhirClient(app.Server.BaseAddress, client);

            // create some test data
            var q3 = new Questionnaire { Id = "q3-ai", Url = "http://example.org/canonical-active-integer", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));
            clientFhir.Update(q3);

            // Attempt to create another with a conflicting algorithm
            try
            {
                var q5 = new Questionnaire { Id = "q5-ai", Url = "http://example.org/canonical-active-integer", Version = "10.1", Status = PublicationStatus.Active };
                q5.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "semver"));
                clientFhir.Update(q5);
                Assert.Fail("Should report conflicting versioning algorithm");
            }
            catch (FhirOperationException ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, ex.Status);
                var iss = ex.Outcome.Issue.First();
                Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, iss.Code);
                Assert.AreEqual(OperationOutcome.IssueSeverity.Error, iss.Severity);
            }
        }

        [TestMethod]
        public void NumericCanonicalVersions()
        {
            var q1 = new Questionnaire { Id = "q1-ai", Url = "http://example.org/canonical-active-integer", Version = "10.1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-ai", Url = "http://example.org/canonical-active-integer", Version = "2.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-ai", Url = "http://example.org/canonical-active-integer", Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "integer"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3 });
            Assert.AreEqual(q1.Version, result.Version);

            result = CurrentCanonical.Current(new[] { q3, q2, q1 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public void SemverCanonicalVersions()
        {
            var q1 = new Questionnaire { Id = "q1-semver", Url = "http://example.org/canonical-semver", Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-semver", Url = "http://example.org/canonical-semver", Version = "11.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-semver", Url = "http://example.org/canonical-semver", Version = "1.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Id = "q4-semver", Url = "http://example.org/canonical-semver", Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Id = "q5-semver", Url = "http://example.org/canonical-semver", Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "semver"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q2.Version, result.Version);
        }

        [TestMethod]
        public void SemverCanonicalVersionsWithPreReleases()
        {
            var q1 = new Questionnaire { Id = "q1-semver-pre", Url = "http://example.org/canonical-semver-pre-release", Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-semver-pre", Url = "http://example.org/canonical-semver-pre-release", Version = "1.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-semver-pre", Url = "http://example.org/canonical-semver-pre-release", Version = "1.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Id = "q4-semver-pre", Url = "http://example.org/canonical-semver-pre-release", Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Id = "q5-semver-pre", Url = "http://example.org/canonical-semver-pre-release", Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "semver"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q5.Version, result.Version);
        }

        [TestMethod]
        public void FhirpathCanonicalVersions()
        {
            var q1 = new Questionnaire { Id = "q1-fhirpath", Url = "http://example.org/canonical-fhirpath", Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-fhirpath", Url = "http://example.org/canonical-fhirpath", Version = "11.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-fhirpath", Url = "http://example.org/canonical-fhirpath", Version = "1.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Id = "q4-fhirpath", Url = "http://example.org/canonical-fhirpath", Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Id = "q5-fhirpath", Url = "http://example.org/canonical-fhirpath", Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm("iif(%version1 > %version2, -1, iif(%version1 < %version2, 1, 0))"); // as version is a string, this comes out as an alpha sort

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public void AlphaCanonicalVersions()
        {
            var q1 = new Questionnaire { Id = "q1-alpha", Url = "http://example.org/canonical-alpha", Version = "2.0.1-alpha2", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-alpha", Url = "http://example.org/canonical-alpha", Version = "1.0.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-alpha", Url = "http://example.org/canonical-alpha", Version = "12.0.3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Id = "q4-alpha", Url = "http://example.org/canonical-alpha", Version = "2.0.1-alpha1", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Id = "q5-alpha", Url = "http://example.org/canonical-alpha", Version = "2.0.1", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "alpha"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public void NaturalCanonicalVersions()
        {
            var q1 = new Questionnaire { Id = "q1-nat", Url = "http://example.org/canonical-natural", Version = "general1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q2-nat", Url = "http://example.org/canonical-natural", Version = "general2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Id = "q3-nat", Url = "http://example.org/canonical-natural", Version = "general3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Id = "q4-nat", Url = "http://example.org/canonical-natural", Version = "general1000", Status = PublicationStatus.Active };
            var q5 = new Questionnaire { Id = "q5-nat", Url = "http://example.org/canonical-natural", Version = "general200", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "natural"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3, q4, q5 });
            Assert.AreEqual(q4.Version, result.Version);
        }


        [TestMethod]
        public void SortCanonicalVersions()
        {
            var q1 = new Questionnaire { Id = "q1-nat-b", Url = "http://example.org/canonical-natural-sort", Version = "general1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Id = "q1-nat-b", Url = "http://example.org/canonical-natural-sort", Version = "general2", Status = PublicationStatus.Retired };
            var q3 = new Questionnaire { Id = "q1-nat-b", Url = "http://example.org/canonical-natural-sort", Version = "general3", Status = PublicationStatus.Active };
            var q4 = new Questionnaire { Id = "q1-nat-b", Url = "http://example.org/canonical-natural-sort", Version = "general1000", Status = PublicationStatus.Draft };
            var q5 = new Questionnaire { Id = "q1-nat-b", Url = "http://example.org/canonical-natural-sort", Version = "general200", Status = PublicationStatus.Retired };
            var q6 = new Questionnaire { Id = "q1-nat-b", Url = "http://example.org/canonical-natural-sort", Version = "general200" };
            q3.versionAlgorithm(new Coding("http://hl7.org/fhir/version-algorithm", "natural"));

            IOrderedEnumerable<IVersionableConformanceResource> result = CurrentCanonical.Ordered(new[] { q1, q2, q3, q4, q5, q6 });
            foreach (var item in result)
                System.Diagnostics.Trace.WriteLine($"{item.Status?.ToString() ?? "(null)"}, {item.Version}");
            Assert.AreEqual(q3.Version, result.First().Version);
        }
    }
}
