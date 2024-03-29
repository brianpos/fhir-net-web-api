﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Sockets;
using System.Net;
using Hl7.Fhir.WebApi;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System.Net.Http;
using System.Linq;

namespace UnitTestWebApi
{
    [TestClass]
    public class SimpleCRUD
    {
        #region << Test prepare and cleanup >>
        private IDisposable _fhirServerController;
        public string _baseAddress;

        [TestInitialize]
        public void PrepareTests()
        {
            // Ensure that we grab an available IP port on the local workstation
            // http://stackoverflow.com/questions/9895129/how-do-i-find-an-available-port-before-bind-the-socket-with-the-endpoint
            string port = "9000";

            using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                sock.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0)); // Pass 0 here, it means to go looking for a free port
                port = ((IPEndPoint)sock.LocalEndPoint).Port.ToString();
                sock.Close();
            }

            // Now use that randomly located port to start up a local FHIR server
            _baseAddress = "http://localhost:" + port + "/";
            _fhirServerController = Microsoft.Owin.Hosting.WebApp.Start<Hl7.DemoFileSystemFhirServer.Startup>(_baseAddress);
        }

        [TestCleanup]
        public void CleanupTests()
        {
            if (_fhirServerController != null)
                _fhirServerController.Dispose();
        }
        public static void DebugDumpOutputXml(Base fragment)
        {
            if (fragment == null)
                Console.WriteLine("(null)");
            else
            {
                var doc = System.Xml.Linq.XDocument.Parse(new FhirXmlSerializer().SerializeToString(fragment));
                Console.WriteLine(doc.ToString(System.Xml.Linq.SaveOptions.None));
            }
        }
        public static void DebugDumpOutputJson(Base fragment)
        {
            if (fragment == null)
                Console.WriteLine("(null)");
            else
            {
                Console.WriteLine(new FhirJsonSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(fragment));
            }
        }
        #endregion

        [TestMethod]
        public void CreatePatient()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");

            var handler = new LegacyRestHandler(new HttpClientHandler());
            var httpclient = new HttpClient(handler);
            FhirClient clientFhir = new FhirClient(_baseAddress, httpclient);
            clientFhir.Settings.VerifyFhirVersion = false;
            handler.OnBeforeRequest += ClientFhir_OnBeforeRequestCorrlationTest;
            handler.OnAfterResponse += ClientFhir_OnAfterResponseCorrlationTest;
            handler.OnAfterResponse += (sender, args) =>
            {
                string location = null;
                if (args.Headers.TryGetValues("Location", out var locations))
                {
                    location = locations.FirstOrDefault();
                }
                if (!string.IsNullOrEmpty(location))
                {
                    System.Diagnostics.Trace.WriteLine($">> (Status: {args.StatusCode}) {args.RequestMessage.Method}: {location}");
                    Assert.IsTrue(!location.StartsWith("https://demo.org/testme/v2/"), "proxy redirect detected");
                }
#if DEBUG
                Assert.AreEqual("wild-turkey-create", args.Headers.GetValues("test").FirstOrDefault(), "Custom Response header missing");
#endif
            };

            var result = clientFhir.Create<Patient>(p);
            DebugDumpOutputXml(result);

            Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
        }

        [TestMethod]
        public void CreatePatientWithInvalidDate()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = "01-03-1970";
            p.GenderElement = new Code<AdministrativeGender>() { ObjectValue = "m" };
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");

            var handler = new LegacyRestHandler(new HttpClientHandler());
            var httpclient = new HttpClient(handler);
            FhirClient clientFhir = new FhirClient(_baseAddress, httpclient);
            clientFhir.Settings.VerifyFhirVersion = false;
            handler.OnBeforeRequest += ClientFhir_OnBeforeRequestCorrlationTest;
            handler.OnAfterResponse += ClientFhir_OnAfterResponseCorrlationTest;
            handler.OnAfterResponse += (sender, args) =>
            {
                string location = null;
                if (args.Headers.TryGetValues("Location", out var locations))
                {
                    location = locations.FirstOrDefault();
                }
                if (!string.IsNullOrEmpty(location))
                {
                    System.Diagnostics.Trace.WriteLine($">> (Status: {args.StatusCode}) {args.RequestMessage.Method}: {args.RequestMessage.RequestUri} //=> {location}");
                    Assert.IsTrue(!location.StartsWith("https://demo.org/testme/v2/"), "proxy redirect detected");
                }
                // Assert.AreEqual("wild-turkey-create", args.RawResponse.GetResponseHeader("test"), "Custom Response header missing");
            };

            // with the default XML
            try
            {
                var result = clientFhir.Create<Patient>(p);

                Assert.Fail("Version1.9 of the fhir client fails parsing - even if I disagree with it");
                Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
                Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
            }
            catch (FhirOperationException ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
                DebugDumpOutputXml(ex.Outcome);
                Assert.AreEqual(HttpStatusCode.BadRequest, ex.Status, "Expected a bad request due to parsing the date");
                Assert.IsTrue(ex.Message.Contains("Literal '01-03-1970' cannot be parsed as a date"));
            }

            // and try again with JSON
            try
            {
                clientFhir.Settings.PreferredFormat = ResourceFormat.Json;
                var result = clientFhir.Create<Patient>(p);

                Assert.Fail("Version1.9 of the fhir client fails parsing - even if I disagree with it");
                Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
                Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
            }
            catch (FhirOperationException ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
                DebugDumpOutputXml(ex.Outcome);
                Assert.AreEqual(HttpStatusCode.BadRequest, ex.Status, "Expected a bad request due to parsing the date");
                Assert.IsTrue(ex.Message.Contains("Literal '01-03-1970' cannot be parsed as a date"));
            }
        }

        [TestMethod]
        public void ReadPatient()
        {
            Patient p = new Patient();
            p.Id = "pat1"; // if you support this format for the IDs (client allocated ID)
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/2", "Other Org");

            FhirClient clientFhir = new FhirClient(_baseAddress);
            clientFhir.Settings.VerifyFhirVersion = false;
            var result = clientFhir.Update<Patient>(p);
            DebugDumpOutputXml(result);

            Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");

            // read the record to check that it can be loaded
            result = clientFhir.Read<Patient>("Patient/pat1");
            Assert.AreEqual(p.Id, result.Id, "Newly created patient should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");

            try
            {
                var p4 = clientFhir.Read<Patient>("Patient/missing-client-id");
                Assert.Fail("Should have received an exception running this");
            }
            catch (Hl7.Fhir.Rest.FhirOperationException ex)
            {
                // This was the expected outcome
                System.Diagnostics.Trace.WriteLine(ex.Message);
                DebugDumpOutputXml(ex.Outcome);
            }
        }

        [TestMethod]
        public void UpdatePatient()
        {
            Patient p = new Patient();
            p.Id = "pat1"; // if you support this format for the IDs (client allocated ID)
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/2", "Other Org");

            FhirClient clientFhir = new FhirClient(_baseAddress);
            clientFhir.Settings.VerifyFhirVersion = false;
            var result = clientFhir.Update<Patient>(p);
            DebugDumpOutputXml(result);

            Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
        }

        [TestMethod]
        public void DeletePatient()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");

            FhirClient clientFhir = new FhirClient(_baseAddress);
            clientFhir.Settings.VerifyFhirVersion = false;
            var result = clientFhir.Create<Patient>(p);
            DebugDumpOutputXml(result);

            Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");

            // Now delete the patient we just created
            clientFhir.Delete(result);

            try
            {
                var p4 = clientFhir.Read<Patient>($"Patient/{result.Id}");
                Assert.Fail("Should have received an exception running this");
            }
            catch (Hl7.Fhir.Rest.FhirOperationException ex)
            {
                Assert.AreEqual(HttpStatusCode.Gone, ex.Status, "Expected the patient to have been deleted");
                // This was the expected outcome
                System.Diagnostics.Trace.WriteLine(ex.Message);
                DebugDumpOutputXml(ex.Outcome);
            }
        }
        [TestMethod]
        public async System.Threading.Tasks.Task CreatePatientWithInvalidDateAsync()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = "01-03-1970";
            p.GenderElement = new Code<AdministrativeGender>() { ObjectValue = "m" };
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");

            var handler = new LegacyRestHandler(new HttpClientHandler());
            var httpclient = new HttpClient(handler);
            FhirClient clientFhir = new FhirClient(_baseAddress, httpclient);
            clientFhir.Settings.VerifyFhirVersion = false;
            handler.OnBeforeRequest += ClientFhir_OnBeforeRequestCorrlationTest;
            handler.OnAfterResponse += ClientFhir_OnAfterResponseCorrlationTest;

            // with the default XML
            try
            {
                // clientFhir.ParserSettings.AllowUnrecognizedEnums = true;
                var result = await clientFhir.CreateAsync<Patient>(p);

                Assert.Fail("Version1.9 of the fhir client fails parsing - even if I disagree with it");
                Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
                Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
            }
            catch (FhirOperationException ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
                DebugDumpOutputXml(ex.Outcome);
                Assert.AreEqual(HttpStatusCode.BadRequest, ex.Status, "Expected a bad request due to parsing the date");
                Assert.IsTrue(ex.Message.Contains(" '01-03-1970' "));
            }

            // and try again with JSON
            try
            {
                clientFhir.Settings.PreferredFormat = ResourceFormat.Json;
                var result = await clientFhir.CreateAsync<Patient>(p);

                Assert.Fail("Version1.9 of the fhir client fails parsing - even if I disagree with it");
                Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
                Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
            }
            catch (FhirOperationException ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
                DebugDumpOutputXml(ex.Outcome);
                Assert.AreEqual(HttpStatusCode.BadRequest, ex.Status, "Expected a bad request due to parsing the date");
                Assert.IsTrue(ex.Message.Contains(" '01-03-1970' "));
            }
        }

        [TestMethod]
        public async System.Threading.Tasks.Task ConvertPatientResourceFormat()
        {
            Patient p = new Patient();
            p.Id = "pat1"; // if you support this format for the IDs (client allocated ID)
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/2", "Other Org");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json+fhir"));

            string xml = new FhirXmlSerializer().SerializeToString(p);
            HttpContent rawPostContent = new StringContent(xml, System.Text.Encoding.UTF8, "application/xml+fhir");
            var rawResult = await client.PostAsync($"{_baseAddress}$convert", rawPostContent);
            string textResult = await rawResult.Content.ReadAsStringAsync();
            var result = new FhirJsonParser().Parse<Patient>(textResult);
            System.Diagnostics.Trace.WriteLine($"{result.ResourceIdentity()}");

            Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
            Assert.IsTrue(p.IsExactly(result), "resources should be the same");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetCapabilityStatement()
        {
            FhirClient clientFhir = new FhirClient(_baseAddress);
            clientFhir.Settings.VerifyFhirVersion = false;
            var result = clientFhir.CapabilityStatement();
            DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a capability statement returned");
            Assert.IsNotNull(result.FhirVersion, "Should at least report the version of fhir active");

            HttpClient client = new HttpClient();
            var rawResult = await client.GetAsync($"{_baseAddress}");
            var cs = new FhirXmlParser().Parse<CapabilityStatement>(Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(await rawResult.Content.ReadAsStreamAsync()));
            System.Diagnostics.Trace.WriteLine($"{cs.Url}");
            Assert.AreEqual(_baseAddress + "metadata", cs.Url);

            rawResult = await client.GetAsync($"{_baseAddress}metadata");
            cs = new FhirXmlParser().Parse<CapabilityStatement>(Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(await rawResult.Content.ReadAsStreamAsync()));
            System.Diagnostics.Trace.WriteLine($"{cs.Url}");
            Assert.AreEqual(_baseAddress + "metadata", cs.Url);

            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Options, $"{_baseAddress}");
            rawResult = await client.SendAsync(msg);
            cs = new FhirXmlParser().Parse<CapabilityStatement>(Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(await rawResult.Content.ReadAsStreamAsync()));
            System.Diagnostics.Trace.WriteLine($"{cs.Url}");
            Assert.AreEqual(_baseAddress + "metadata", cs.Url);
        }

        [TestMethod]
        public void WholeSystemHistory()
        {
            FhirClient clientFhir = new FhirClient(_baseAddress);
            clientFhir.Settings.VerifyFhirVersion = false;

            // Create a Patient
            Patient p = new Patient();
            p.Id = "pat1"; // if you support this format for the IDs (client allocated ID)
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/2", "Other Org");
            clientFhir.Update(p);

            // Create an Organization
            Organization org = new Organization();
            org.Id = "2";
            org.Name = "Other Org";
            clientFhir.Update(org);

            // Load the whole history
            var result = clientFhir.WholeSystemHistory();

            Console.WriteLine($"Total All Resources: {result.Total}");
            foreach (var item in result.Entry)
            {
                Console.WriteLine($"{item.FullUrl}");
            }

            Assert.IsNotNull(result.Total, "There should be a total count");
            Assert.IsNotNull(result.Meta, "History Bundle should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "History Bundle should have the creation date populated");
            Assert.IsTrue(result.Total.Value > 0, "Should be at least 1 item in the history");
            Assert.AreEqual(result.Total.Value, result.Entry.Count, "Should be matching total and entry counts");

            // Load the Organization type history
            var resultOrgs = clientFhir.TypeHistory<Organization>();
            DebugDumpOutputXml(resultOrgs);

            Console.WriteLine($"Total Org Resources: {resultOrgs.Total}");
            foreach (var item in resultOrgs.Entry)
            {
                Console.WriteLine($"{item.FullUrl}");
            }

            Assert.IsNotNull(resultOrgs.Total, "There should be a total count");
            Assert.IsNotNull(resultOrgs.Meta, "History Bundle should have an Meta created");
            Assert.IsNotNull(resultOrgs.Meta.LastUpdated, "History Bundle should have the creation date populated");
            Assert.IsTrue(resultOrgs.Total.Value > 0, "Should be at least 1 item in the history");
            Assert.AreEqual(resultOrgs.Total.Value, resultOrgs.Entry.Count, "Should be matching total and entry counts");
            Assert.IsTrue(resultOrgs.Total.Value < result.Total.Value, "Should be less orgs than the whole system entry count");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task AlternateHostOperations()
        {
            var handler = new LegacyRestHandler(new HttpClientHandler());
            var httpclient = new HttpClient(handler);
            FhirClient clientFhir = new FhirClient(_baseAddress, httpclient);
            clientFhir.Settings.VerifyFhirVersion = false;
            handler.OnBeforeRequest += ClientFhir_OnBeforeRequest_AlternateHost;
            handler.OnAfterResponse += (sender, args) =>
            {
                string location = null;
                if (args.Headers.TryGetValues("Location", out var locations))
                {
                    location = locations.FirstOrDefault();
                }
                if (!string.IsNullOrEmpty(location))
                {
                    System.Diagnostics.Trace.WriteLine($">> (Status: {args.StatusCode}) {args.RequestMessage.Method}: {args.RequestMessage.RequestUri}   // => {location}");
                    Assert.IsTrue(location.StartsWith("https://demo.org/testme/v2/"), "proxy redirect not detected");
                }
            };

            // Capqbility statement
            var cs = await clientFhir.CapabilityStatementAsync();
            Assert.AreEqual("https://demo.org/testme/v2/metadata", cs.Url, "Should matching capability statement");
            Assert.AreEqual("https://demo.org/testme/v2", cs.Implementation.Url, "Should matching capability statement");

            // Create a Patient
            Patient p = new Patient();
            p.Id = "pat1"; // if you support this format for the IDs (client allocated ID)
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/2", "Other Org");
            clientFhir.Update(p);

            // Create an Organization
            Organization org = new Organization();
            org.Id = "2";
            org.Name = "Other Org";
            clientFhir.Update(org);

            // Load the whole history
            var result = clientFhir.WholeSystemHistory();

            Console.WriteLine($"Total All Resources: {result.Total}");
            foreach (var item in result.Entry)
            {
                Console.WriteLine($"{item.FullUrl}");
            }

            Assert.IsNotNull(result.Total, "There should be a total count");
            Assert.IsNotNull(result.Meta, "History Bundle should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "History Bundle should have the creation date populated");
            Assert.IsTrue(result.Total.Value > 0, "Should be at least 1 item in the history");
            Assert.AreEqual(result.Total.Value, result.Entry.Count, "Should be matching total and entry counts");

            // Load the Organization type history
            var resultOrgs = clientFhir.TypeHistory<Organization>();
            DebugDumpOutputXml(resultOrgs);

            Console.WriteLine($"Total Org Resources: {resultOrgs.Total}");
            foreach (var item in resultOrgs.Entry)
            {
                Console.WriteLine($"{item.FullUrl}");
            }

            Assert.IsNotNull(resultOrgs.Total, "There should be a total count");
            Assert.IsNotNull(resultOrgs.Meta, "History Bundle should have an Meta created");
            Assert.IsNotNull(resultOrgs.Meta.LastUpdated, "History Bundle should have the creation date populated");
            Assert.IsTrue(resultOrgs.Total.Value > 0, "Should be at least 1 item in the history");
            Assert.AreEqual(resultOrgs.Total.Value, resultOrgs.Entry.Count, "Should be matching total and entry counts");
            Assert.IsTrue(resultOrgs.Total.Value < result.Total.Value, "Should be less orgs than the whole system entry count");

            // Test create
            org.Id = null;
            org = clientFhir.Create(org);

            // Test Delete
            clientFhir.Delete(org);

            // Test Search
            var searchOrg = clientFhir.Search<Organization>(new[] { "name=Other" });
            DebugDumpOutputXml(searchOrg);
            // Assert.IsTrue(searchOrg.SelfLink.OriginalString.StartsWith("https://demo.org/testme/v2"));
            foreach (var entry in searchOrg.Entry)
            {
                Assert.IsTrue(entry.FullUrl.StartsWith("urn:uuid:") || entry.FullUrl.StartsWith("https://demo.org/testme/v2/"), $"Search Entry fullurl: {entry.FullUrl}");
            }

            // Custom operation
            var resultOp = clientFhir.WholeSystemOperation("count-em", null, true) as OperationOutcome;
            DebugDumpOutputXml(resultOp);
            Assert.IsNotNull(resultOp, "Should be a capability statement returned");
            Assert.AreEqual(2, resultOp.Issue.Count, "Should contain the issue that has the count of the number of resources in there");
            Console.WriteLine($"{resultOp.Issue[0].Details.Text}");
        }

        [TestMethod]
        public void PerformCustomOperationCountResourceTypeInstances()
        {
            FhirClient clientFhir = new FhirClient(_baseAddress);
            clientFhir.Settings.VerifyFhirVersion = false;
            var result = clientFhir.TypeOperation<Patient>("count-em", null, true) as OperationOutcome;
            DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a capability statement returned");
            Assert.AreEqual(1, result.Issue.Count, "Should contain the issue that has the count of the number of resources in there");
            Console.WriteLine($"{result.Issue[0].Details.Text}");
        }

        [TestMethod]
        public void PerformCustomOperationCountAllResourceInstances()
        {
            var handler = new LegacyRestHandler(new HttpClientHandler());
            FhirClient clientFhir = new FhirClient(_baseAddress, null, handler);
            clientFhir.Settings.VerifyFhirVersion = false;
            handler.OnBeforeRequest += ClientFhir_OnBeforeRequest;
            var result = clientFhir.WholeSystemOperation("count-em", null, true) as OperationOutcome;
            DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a capability statement returned");
            Assert.AreEqual(2, result.Issue.Count, "Should contain the issue that has the count of the number of resources in there");
            Console.WriteLine($"{result.Issue[0].Details.Text}");
            Assert.IsTrue(result.Issue[1].Details.Text.Contains("x-test: Cleaner"), "Missing the custom header added to the request");
        }

        [TestMethod]
        public void PerformCustomOperationWithIdParameter()
        {
            var handler = new LegacyRestHandler(new HttpClientHandler());
            FhirClient clientFhir = new FhirClient(_baseAddress, null, handler);
            clientFhir.Settings.VerifyFhirVersion = false;
            handler.OnBeforeRequest += ClientFhir_OnBeforeRequest;
            string exampleQuery = $"{_baseAddress}NamingSystem/$preferred-id?id=45&type=uri";
            var result = clientFhir.Get(exampleQuery) as NamingSystem;
            DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a NamingSystem returned");
            Assert.AreEqual("45", result.Id);
        }

        private void ClientFhir_OnBeforeRequest(object sender, HttpRequestMessage eRawRequest)
        {
            System.Diagnostics.Trace.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{eRawRequest.Method}: {eRawRequest.RequestUri}");
            eRawRequest.Headers.Add("x-test", "Cleaner");
        }
        private void ClientFhir_OnBeforeRequestCorrlationTest(object sender, HttpRequestMessage eRawRequest)
        {
            eRawRequest.Headers.Add("X-Correlation-Id", "TestMe");
        }

        private void ClientFhir_OnAfterResponseCorrlationTest(object sender, HttpResponseMessage eRawResponse)
        {
            Assert.AreEqual("TestMe", eRawResponse.Headers.GetValues("X-Correlation-Id").FirstOrDefault());
        }

        private void ClientFhir_OnBeforeRequest_AlternateHost(object sender, HttpRequestMessage eRawRequest)
        {
            eRawRequest.Headers.Add("X-Forwarded-Proto", "https");
            eRawRequest.Headers.Add("X-Forwarded-Host", "demo.org");
            eRawRequest.Headers.Add("X-Forwarded-Port", "443");
            eRawRequest.Headers.Add("X-Forwarded-Prefix", "testme/v2");
        }
    }
}
