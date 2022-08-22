using Hl7.DemoFileSystemFhirServer;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Rest.Legacy;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Specification.Terminology;
using Hl7.Fhir.Validation;
using Hl7.Fhir.WebApi;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using Task = System.Threading.Tasks.Task;

namespace UnitTestWebApi
{
    [TestClass]
    public class CanonicalVersionTests
    {
        [TestMethod]
        public async Task NumericCanonicalVersions()
        {
            var q1 = new Questionnaire { Version = "10.1", Status = PublicationStatus.Active };
            var q2 = new Questionnaire { Version = "2.2", Status = PublicationStatus.Active };
            var q3 = new Questionnaire { Version = "0.3", Status = PublicationStatus.Active };
            q3.versionAlgorithm(new Coding(null, "integer"));

            var result = CurrentCanonical.Current(new[] { q1, q2, q3 });
            Assert.AreEqual(q1.Version, result.Version);

            result = CurrentCanonical.Current(new[] { q3, q2, q1 });
            Assert.AreEqual(q1.Version, result.Version);
        }

        [TestMethod]
        public async Task SemverCanonicalVersions()
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
        public async Task SemverCanonicalVersionsWithPreReleases()
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
        public async Task FhirpathCanonicalVersions()
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
        public async Task AlphaCanonicalVersions()
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
        public async Task NaturalCanonicalVersions()
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
    }
}
