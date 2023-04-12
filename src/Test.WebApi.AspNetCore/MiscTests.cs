using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Support;
using Hl7.Fhir.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net.Http;

namespace UnitTestWebApi
{
    [TestClass]
    public class MiscTests
    {
        [DataTestMethod]
        [DataRow("2020", "2020-01-01T00:00:00+00:00")]
        [DataRow("2020-02", "2020-02-01T00:00:00+00:00")]
        [DataRow("2020-02-02", "2020-02-02T00:00:00+00:00")]
        [DataRow("2020-02-02T22:45:30+10:00", "2020-02-02T22:45:30+10:00")]
        [DataRow("2020-02-02T22:45:30-05:00", "2020-02-02T22:45:30-05:00")]
        [DataRow("2020-02-02T22:45:30Z", "2020-02-02T22:45:30+00:00")]
        public void ToDateTimeOffsetChecks(string value, string expected)
        {
            // This commented out line is to help demonstrate how the existing Firely routine messes things up
            // var actual = new FhirDateTime(value).ToDateTimeOffset(DateTimeOffset.Now.Offset);

            // This is the routine that we've implemented for the facade to retain timezone offset values in data
            // (When comparing for date usage, don't want the actual date portion of the data to be different)
            var actual = new FhirDateTime(value).ToDateTimeOffsetForFacade();
            Assert.AreEqual(expected, actual.ToFhirDateTime());
        }
    }
}
