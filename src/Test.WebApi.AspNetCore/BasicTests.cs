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
    public class BasicFacade
    {
        #region << Test prepare and cleanup >>
        private IDisposable _fhirServerController;
        public string _baseAddress;

        [TestInitialize]
        public void PrepareTests()
        {
            Type myType = typeof(FhirR4Controller);

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

            var host = WebHost.CreateDefaultBuilder(null)
                .UseUrls(_baseAddress.TrimEnd('/'))
                .UseContentRoot(Path.GetDirectoryName(this.GetType().Assembly.Location))
                .UseWebRoot(Path.GetDirectoryName(this.GetType().Assembly.Location) + @"\wwwroot")
                .UseEnvironment("Development")
                .UseStartup<Startup>()
                .Build();
            _fhirServerController = host;
            host.RunAsync();
            host.WaitForShutdownAsync();
            System.Diagnostics.Trace.WriteLine($"Listening at {_baseAddress}");
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
        public void GetStaticContent()
        {
            HttpClient c = new HttpClient();
            var result = c.GetAsync(_baseAddress + "content/icon_page.gif").Result;

            System.Diagnostics.Trace.WriteLine(result.ToString());

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Should be status ok");
            // This test occasionally fails when the build doesn't copy over the static files from the referenced Facade project
            Assert.AreEqual("image/gif", result.Content.Headers.ContentType.MediaType, "Should be status ok");
        }

        [TestMethod]
        public async Task GetCapabilityStatement()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);

            var result = clientFhir.CapabilityStatement();
            string xml = new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(result);
            System.Diagnostics.Trace.WriteLine(xml);

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
        public void CreatePatient()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = new DateTime(1970, 3, 1).ToFhirDate(); // yes there are extensions to convert to FHIR format
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");

            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequestCorrlationTest;
            clientFhir.OnAfterResponse += ClientFhir_OnAfterResponseCorrlationTest;
            clientFhir.OnAfterResponse += (object sender, AfterResponseEventArgs args) =>
            {
                string location = args.RawResponse.GetResponseHeader("Location");
                if (!string.IsNullOrEmpty(location))
                {
                    System.Diagnostics.Trace.WriteLine($">> (Status: {args.RawResponse.StatusCode}) {args.RawResponse.Method}: {location}");
                    Assert.IsTrue(!location.StartsWith("https://demo.org/testme/"), "proxy redirect detected");
                }
                Assert.AreEqual("wild-turkey-create", args.RawResponse.GetResponseHeader("test"), "Custom Response header missing");
            };

            var result = clientFhir.Create<Patient>(p);

            Assert.IsNotNull(result.Id, "Newly created patient should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created patient should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created patient should have the creation date populated");
            Assert.IsTrue(result.Active.Value, "The patient was created as an active patient");
        }

        [TestMethod]
        public async Task CreatePatientWithInvalidDate()
        {
            Patient p = new Patient();
            p.Name = new System.Collections.Generic.List<HumanName>();
            p.Name.Add(new HumanName().WithGiven("Grahame").AndFamily("Grieve"));
            p.BirthDate = "01-03-1970";
            p.GenderElement = new Code<AdministrativeGender>() { ObjectValue = "m" };
            p.Active = true;
            p.ManagingOrganization = new ResourceReference("Organization/1", "Demo Org");

            var clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.Settings.ParserSettings.AllowUnrecognizedEnums = true;

            //clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequestCorrlationTest;
            //clientFhir.OnAfterResponse += ClientFhir_OnAfterResponseCorrlationTest;
            clientFhir.OnAfterResponse += (object sender, AfterResponseEventArgs args) =>
            {
                string location = args.RawResponse.GetResponseHeader("Location");
                if (!string.IsNullOrEmpty(location))
                {
                    System.Diagnostics.Trace.WriteLine($">> (Status: {args.RawResponse.StatusCode}) {args.RawResponse.Method}: {location}");
                    Assert.IsTrue(!location.StartsWith("https://demo.org/testme/"), "proxy redirect detected");
                }
                // Assert.AreEqual("wild-turkey-create", args.RawResponse.GetResponseHeader("test"), "Custom Response header missing");
            };

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
                Assert.IsTrue(ex.Message.Contains("Type checking the data: Literal '01-03-1970' cannot be parsed as a date."));
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
                Assert.IsTrue(ex.Message.Contains("Type checking the data: Literal '01-03-1970' cannot be parsed as a date."));
            }
        }

        private void ClientFhir_OnBeforeRequestCorrlationTest(object sender, BeforeRequestEventArgs e)
        {
            e.RawRequest.Headers.Add("X-Correlation-Id", "TestMe");
        }

        private void ClientFhir_OnAfterResponseCorrlationTest(object sender, AfterResponseEventArgs e)
        {
            Assert.AreEqual("TestMe", e.RawResponse.Headers.Get("X-Correlation-Id"));
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

            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.Settings.PreferredFormat = ResourceFormat.Json;
            var result = clientFhir.Update<Patient>(p);

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

            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.Settings.PreferredFormat = ResourceFormat.Json;
            var result = clientFhir.Update<Patient>(p);

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

            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            var result = clientFhir.Create<Patient>(p);

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
            }
        }

        [TestMethod]
        public async Task ConvertPatientResourceFormat()
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

#if NETCOREAPP3_0_OR_GREATER
        [TestMethod]
        public void TestSqliteResolverWithValidation()
        {
            var builder = new DbContextOptionsBuilder<SpecificationContext>().UseSqlite(@"Data Source=c:\temp\Sqlite-specification.db");
            var dbContext = new SpecificationContext(builder.Options);
            dbContext.Database.EnsureCreated();
            var targetResolver = new SqliteConformanceResourceResolver(dbContext);
            var localTerminologyService = new LocalTerminologyService(targetResolver, new ValueSetExpanderSettings() { ValueSetSource = targetResolver });
            var validator = new Validator(new ValidationSettings() { ResourceResolver = targetResolver, TerminologyService = localTerminologyService });

            var server = new LegacyFhirClient("http://sqlonfhir-r4.azurewebsites.net/fhir", false);
            var q = server.Read<Questionnaire>("Questionnaire/enable-when-tests");
            var outcome = validator.Validate(q);
            DebugDumpOutputXml(outcome);

            q = server.Read<Questionnaire>("Questionnaire/mbs715");
            outcome = validator.Validate(q);
            DebugDumpOutputXml(outcome);

            q = server.Read<Questionnaire>("Questionnaire/pre-pop-test2");
            outcome = validator.Validate(q);
            DebugDumpOutputXml(outcome);
        }

        [TestMethod]
        public void ExportSpecificationZipToSqlite()
        {
            var source = Hl7.Fhir.Specification.Source.ZipSource.CreateValidationSource();
            Dictionary<string, Resource> canonicalsRequired = new Dictionary<string, Resource>();
    
            var builder = new DbContextOptionsBuilder<SpecificationContext>().UseSqlite(@"Data Source=c:\temp\Sqlite-specification.db");
            var dbContext = new SpecificationContext(builder.Options);
            dbContext.Database.EnsureCreated();
            var targetResolver = new SqliteConformanceResourceResolver(dbContext);
            var sourceSDC = new ZipSource(@"E:\git\brianpos\QForms\Test.WebApi.AspNetCore\TestData\sdc-ig.zip");
            var outcome = targetResolver.MigrateFrom(sourceSDC, (issue, canonical, resource) =>
            {
                System.Diagnostics.Trace.WriteLine($"{issue.Severity}/{issue.Code}: {issue.Details?.Text}");
                if (resource != null)
                    ScanResource(source, canonical, canonicalsRequired, resource);
            }).GetAwaiter().GetResult();

            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/Questionnaire", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/ValueSet", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/CodeSystem", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/StructureDefinition", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/Patient", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/Practitioner", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/PractitionerRole", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/Organization", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/Observation", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/Bundle", canonicalsRequired);

            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/entryFormat", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/maxDecimalPlaces", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/maxSize", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/maxValue", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/mimeType", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/minLength", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/minValue", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/ordinalValue", canonicalsRequired);

            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-choiceOrientation", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-displayCategory", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-fhirType", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-hidden", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-itemControl", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-maxOccurs", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-minOccurs", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-optionExclusive", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-optionPrefix", canonicalsRequired);

            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-unit", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/questionnaire-optionUnit", canonicalsRequired);

            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/regex", canonicalsRequired);
            ScanCanonical(source, "http://hl7.org/fhir/StructureDefinition/variable", canonicalsRequired);

            var clientFhir = new LegacyFhirClient(_baseAddress, false);
            var serializer = new Hl7.Fhir.Serialization.FhirXmlSerializer(new SerializerSettings() { Pretty = true });
            foreach (var item in canonicalsRequired.Keys)
            {
                System.Diagnostics.Trace.WriteLine(item);
                var resource = canonicalsRequired[item] as DomainResource;
                resource.Extension.Clear();
                resource.Text = null;
                if (resource is IConformanceResource cr)
                {
                    cr.Contact.Clear();
                    cr.Description = null;
                    cr.Purpose = null;
                    cr.Publisher = null;
                }
                if (resource is StructureDefinition sd)
                {
                    sd.Mapping.Clear();
                    foreach (var element in sd.Differential.Element)
                    {
                        CleanElement(element);
                    }
                    foreach (var element in sd.Snapshot.Element)
                    {
                        CleanElement(element);
                    }
                }
                targetResolver.IncludeCanonicalResource(resource);
                // var result = clientFhir.Update(resource);
                System.IO.File.WriteAllBytes($"c:\\temp\\{resource.TypeName}-{resource.Id}.xml", serializer.SerializeToBytes(resource));
            }
        }
#endif
        private static void CleanElement(ElementDefinition element)
        {
            element.Mapping.Clear();
            element.Definition = null;
            element.Comment = null;
            element.Alias = null;
            element.Requirements = null;
        }

        private static void ScanCanonical(IResourceResolver source, string canonicalUri, Dictionary<string, Resource> canonicalsRequired)
        {
            if (string.IsNullOrEmpty(canonicalUri))
                return;
            if (canonicalsRequired.ContainsKey(canonicalUri))
                return;
            if (canonicalUri.Contains("|"))
                canonicalUri = canonicalUri.Substring(0, canonicalUri.IndexOf("|"));
            var requiredResource = source.ResolveByCanonicalUri(canonicalUri);
            if (requiredResource == null)
                requiredResource = source.ResolveByUri(canonicalUri);
            ScanResource(source, canonicalUri, canonicalsRequired, requiredResource);
        }

        private static void ScanResource(IResourceResolver source, string canonicalUri, Dictionary<string, Resource> canonicalsRequired, Resource requiredResource)
        {
            if (requiredResource == null)
            {
                System.Diagnostics.Trace.WriteLine($"Failed to resolve {canonicalUri}");
                return;
            }
            if (requiredResource is StructureDefinition sd)
            {
                canonicalsRequired.Add(canonicalUri, requiredResource);
                ScanCanonical(source, sd.BaseDefinition, canonicalsRequired);
                foreach (var element in sd.Differential.Element)
                {
                    foreach (var type in element.Type)
                    {
                        string typeUri = type.Code;
                        if (!typeUri.Contains("/"))
                            typeUri = "http://hl7.org/fhir/StructureDefinition/" + typeUri;
                        ScanCanonical(source, typeUri, canonicalsRequired);
                    }
                    // need the type URL and valueset bindings
                    ScanCanonical(source, element.Binding?.ValueSet, canonicalsRequired);
                }
            }
            if (requiredResource is ValueSet vs)
            {
                if (!canonicalsRequired.ContainsKey(canonicalUri))
                    canonicalsRequired.Add(canonicalUri, requiredResource);
                foreach (var include in vs.Compose.Include)
                {
                    ScanCanonical(source, include.System, canonicalsRequired);
                }
            }
            if (requiredResource is CodeSystem cs)
            {
                canonicalsRequired.Add(canonicalUri, requiredResource);
            }
        }

        private void ClientFhir_OnBeforeRequest1(object sender, BeforeRequestEventArgs e)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WholeSystemHistory()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);

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
        public void AlternateHostOperations()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequest_AlternateHost;
            clientFhir.OnAfterResponse += (object sender, AfterResponseEventArgs args) =>
            {
                string location = args.RawResponse.GetResponseHeader("Location");
                if (!string.IsNullOrEmpty(location))
                {
                    System.Diagnostics.Trace.WriteLine($">> (Status: {args.RawResponse.StatusCode}) {args.RawResponse.Method}: {location}");
                    Assert.IsTrue(location.StartsWith("https://demo.org/testme/"), "proxy redirect not detected");
                }
            };

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
            // Assert.IsTrue(searchOrg.SelfLink.OriginalString.StartsWith("https://demo.org/testme/"));
            foreach (var entry in searchOrg.Entry)
            {
                Assert.IsTrue(entry.FullUrl.StartsWith("urn:uuid:") || entry.FullUrl.StartsWith("https://demo.org/testme/"), $"Search Entry fullurl: {entry.FullUrl}");
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
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            var result = clientFhir.TypeOperation<Patient>("count-em", null, true) as OperationOutcome;
            Assert.IsNotNull(result, "Should be a capability statement returned");
            string xml = new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(result);
            System.Diagnostics.Trace.WriteLine(xml);
            Assert.AreEqual(1, result.Issue.Count, "Should contain the issue that has the count of the number of resources in there");
            Console.WriteLine($"{result.Issue[0].Details.Text}");
        }

        [TestMethod]
        public void PerformCustomOperationCountAllResourceInstances()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequest;
            var result = clientFhir.WholeSystemOperation("count-em", null, true) as OperationOutcome;
            Assert.IsNotNull(result, "Should be a capability statement returned");
            string xml = new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(result);
            System.Diagnostics.Trace.WriteLine(xml);
            Assert.AreEqual(2, result.Issue.Count, "Should contain the issue that has the count of the number of resources in there");
            Console.WriteLine($"{result.Issue[0].Details.Text}");
            Assert.IsTrue(result.Issue[1].Details.Text.Contains("x-test: Cleaner"), "Missing the custom header added to the request");
        }

        [TestMethod]
        public void PerformCustomOperationWithIdParameter()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequest;
            string exampleQuery = $"{_baseAddress}NamingSystem/$preferred-id?id=45&type=uri";
            var result = clientFhir.Get(exampleQuery) as NamingSystem;
            DebugDumpOutputXml(result);
            Assert.IsNotNull(result, "Should be a NamingSystem returned");
            Assert.AreEqual("45", result.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task ReadBinary()
        {
            var b = new Binary();
            b.Id = "bin1"; // if you support this format for the IDs (client allocated ID)
            b.SecurityContext = new ResourceReference("Organization/2", "Other Org");
            b.ContentType = "image/gif";
            b.Data = System.IO.File.ReadAllBytes(@"TestData/icon_choice.gif");
            int dataLen = b.Data.Length;
            Console.WriteLine("Updating this resource content:");
            DebugDumpOutputXml(b);

            // Do a custom write of the Binary resource as the FHIR client forces it into a stream, rather than
            // just pushing the byte-stream, and ignoring the security context
            // PUT ContentType: XML, Accept: Binary 
            HttpClient rawWriter = new HttpClient();
            rawWriter.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("image/gif"));
            HttpContent content = new System.Net.Http.StringContent(new FhirXmlSerializer().SerializeToString(b), System.Text.Encoding.UTF8, "application/fhir+xml");
            var resRaw = await rawWriter.PutAsync($"{_baseAddress}Binary/bin1", content);
            Console.WriteLine("Raw Result:");
            Console.WriteLine(System.Convert.ToBase64String(await resRaw.Content.ReadAsByteArrayAsync()));
            Assert.AreEqual(HttpStatusCode.Created, resRaw.StatusCode);
            Assert.AreEqual("image/gif", resRaw.Content.Headers.ContentType.MediaType);
            Assert.AreEqual("Organization/2", resRaw.Headers.Value("X-Security-Context"));

            // PUT ContentType: XML, Accept: XML
            rawWriter.DefaultRequestHeaders.Accept.Clear();
            rawWriter.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/fhir+xml"));
            resRaw = await rawWriter.PutAsync($"{_baseAddress}Binary/bin1", content);
            var result = new FhirXmlParser().Parse<Binary>(await resRaw.Content.ReadAsStringAsync());
            Console.WriteLine("Xml Result:");
            DebugDumpOutputXml(result);
            Assert.AreEqual(HttpStatusCode.Created, resRaw.StatusCode);
            Assert.AreEqual("application/fhir+xml", resRaw.Content.Headers.ContentType.MediaType);

            Assert.IsNotNull(result.Id, "Newly created binary should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created binary should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created binary should have the creation date populated");
            Assert.AreEqual(dataLen, result.Data.Length, "Binary length should be the same");

            // Now Create it using the Binary input formatter
            rawWriter.DefaultRequestHeaders.Accept.Clear();
            rawWriter.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/fhir+xml"));
            HttpContent binaryContent = new System.Net.Http.ByteArrayContent(b.Data);
            binaryContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/gif");
            binaryContent.Headers.Add("X-Security-Context", "Organization/3");
            resRaw = await rawWriter.PutAsync($"{_baseAddress}Binary/bin1", binaryContent);
            result = new FhirXmlParser().Parse<Binary>(await resRaw.Content.ReadAsStringAsync());
            Console.WriteLine("Xml Result:");
            DebugDumpOutputXml(result);
            Assert.AreEqual(HttpStatusCode.Created, resRaw.StatusCode);
            Assert.AreEqual("application/fhir+xml", resRaw.Content.Headers.ContentType.MediaType);

            Assert.IsNotNull(result.Id, "Newly created binary should have an ID");
            Assert.IsNotNull(result.Meta, "Newly created binary should have an Meta created");
            Assert.IsNotNull(result.Meta.LastUpdated, "Newly created binary should have the creation date populated");
            Assert.AreEqual(dataLen, result.Data.Length, "Binary length should be the same");

            try
            {
                LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
                clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequest;
                clientFhir.Settings.Timeout = 50000;
                // This method uses the BINARY stream approach (which has issues - no security context passed through)
                clientFhir.OnBeforeRequest += ClientFhir_OnBeforeRequest_SecurityContectHeader;
                result = clientFhir.Update(b);
                clientFhir.OnBeforeRequest -= ClientFhir_OnBeforeRequest_SecurityContectHeader;
                DebugDumpOutputXml(result);

                Assert.IsNotNull(result.Id, "Newly created binary should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created binary should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created binary should have the creation date populated");
                Assert.AreEqual(dataLen, result.Data.Length, "Binary length should be the same");
                Assert.AreEqual("Organization/4", result.SecurityContext?.Reference);

                // read the record to check that it can be loaded with the regular FHIR client
                clientFhir.Settings.PreferredFormat = ResourceFormat.Xml;
                result = clientFhir.Read<Binary>("Binary/bin1");
                Assert.AreEqual(b.Id, result.Id, "Newly created binary should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created binary should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created binary should have the creation date populated");
                Assert.AreEqual(dataLen, result.Data.Length, "Binary length should be the same");

                // And also check with json
                clientFhir.Settings.PreferredFormat = ResourceFormat.Json;
                result = clientFhir.Read<Binary>("Binary/bin1");
                Assert.AreEqual(b.Id, result.Id, "Newly created binary should have an ID");
                Assert.IsNotNull(result.Meta, "Newly created binary should have an Meta created");
                Assert.IsNotNull(result.Meta.LastUpdated, "Newly created binary should have the creation date populated");
                Assert.AreEqual(dataLen, result.Data.Length, "Binary length should be the same");
                clientFhir.Settings.PreferredFormat = ResourceFormat.Xml;

                try
                {
                    var b4 = clientFhir.Read<Binary>("Binary/missing-client-id");
                    Assert.Fail("Should have received an exception running this");
                }
                catch (Hl7.Fhir.Rest.FhirOperationException ex)
                {
                    // This was the expected outcome
                    System.Diagnostics.Trace.WriteLine(ex.Message);
                    DebugDumpOutputXml(ex.Outcome);
                }

                // read the file as a binary gif (using it's content type)
                HttpClient rawClient = new HttpClient();
                rawClient.DefaultRequestHeaders.Accept.Clear();
                rawClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("image/gif"));
                resRaw = await rawClient.GetAsync($"{_baseAddress}Binary/bin1");
                Assert.AreEqual("image/gif", resRaw.Content.Headers.ContentType.MediaType);
                Console.WriteLine(System.Convert.ToBase64String(await resRaw.Content.ReadAsByteArrayAsync()));

                // read the file using another type that it isn't
            }
            catch (FhirOperationException ex)
            {
                DebugDumpOutputXml(ex.Outcome);
                throw;
            }

        }

        private void ClientFhir_OnBeforeRequest(object sender, BeforeRequestEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("---------------------------------------------------");
            System.Diagnostics.Trace.WriteLine($"{e.RawRequest.Method}: {e.RawRequest.RequestUri}");
            e.RawRequest.Headers.Add("x-test", "Cleaner");
        }
        private void ClientFhir_OnBeforeRequest_SecurityContectHeader(object sender, BeforeRequestEventArgs e)
        {
            e.RawRequest.Headers.Add("X-Security-Context", "Organization/4");
        }
        private void ClientFhir_OnBeforeRequest_AlternateHost(object sender, BeforeRequestEventArgs e)
        {
            e.RawRequest.Headers.Add("X-Forwarded-Proto", "https");
            e.RawRequest.Headers.Add("X-Forwarded-Host", "demo.org");
            e.RawRequest.Headers.Add("X-Forwarded-Port", "443");
        }

    }
}
