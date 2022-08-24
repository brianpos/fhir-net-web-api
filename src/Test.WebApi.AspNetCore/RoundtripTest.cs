/*
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Firely.Fhir.Packages;
using Hl7.DemoFileSystemFhirServer;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest.Legacy;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Hl7.Fhir.WebApi;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SharpCompress.Readers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using Task = System.Threading.Tasks.Task;

namespace UnitTestWebApi
{
    [TestClass]
    public class RoundtripTest
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
        #endregion

        [TestMethod, TestCategory("Round Trip")]
        public async Task UploadAllExamples()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            clientFhir.PreferredFormat = Hl7.Fhir.Rest.ResourceFormat.Json;

            var examplesTarball = @"C:\temp\demoserver-4.2.1\examples.tgz";
            Stream sourceStream;
            if (!System.IO.File.Exists(examplesTarball))
            {
                Debug.WriteLine($"Downloading to {examplesTarball}");

                PackageClient pc = PackageClient.Create();
                var examplesPkg = await pc.GetPackage(new PackageReference("hl7.fhir.r4.examples", null));
                string contents = Encoding.UTF8.GetString(examplesPkg);
                var pl = JsonConvert.DeserializeObject<PackageListing>(contents);

                // var pr = new Firely.Fhir.Packages.PackageReference("hl7.fhir.r4.examples", "4.0.1");
                // examplesPkg = await pc.GetPackage(pr);
                HttpClient client = new HttpClient();
                examplesPkg = await client.GetByteArrayAsync("http://hl7.org/fhir/R4B/hl7.fhir.r4b.examples.tgz");
                System.IO.File.WriteAllBytes(examplesTarball, examplesPkg);
                sourceStream = new MemoryStream(examplesPkg);
            }
            else
            {
                Debug.WriteLine($"Reading {examplesTarball}");
                sourceStream = System.IO.File.OpenRead(examplesTarball);
            }


            Stream gzipStream = new System.IO.Compression.GZipStream(sourceStream, System.IO.Compression.CompressionMode.Decompress);
            MemoryStream ms = new MemoryStream();
            using (gzipStream)
            {
                // Unzip the tar file
                await gzipStream.CopyToAsync(ms);
                ms.Seek(0, SeekOrigin.Begin);
            }

            var reader = ReaderFactory.Open(ms);
            var packageItemCount = 0;
            while (reader.MoveToNextEntry())
            {
                packageItemCount++;
            }
            ms.Seek(0, SeekOrigin.Begin);
            reader = ReaderFactory.Open(ms);
            string currentPosition;

            var files = packageItemCount;
            long successes = 0;
            long failures = 0;
            var sw = Stopwatch.StartNew();

            var nt = new NameTable();
            var xmlParserClassic = new FhirXmlParser();
            var xmlParserCustom = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();
            var xmlSerializer = new FhirXmlSerializer(new SerializerSettings() { Pretty = true });

            var filesWithValidationErrorKnownInSimplifierPackage = new string[] {
                "package/.index.json",
                "package/package.json",

                "package/Observation-decimal.json",
                "package/ActivityDefinition-heart-valve-replacement.json",
                "package/Questionnaire-zika-virus-exposure-assessment.json",
                "package/CompartmentDefinition-patient.json",
                "package/MedicinalProductUndesirableEffect-example.json",
                "package/CareTeam-example.json",
                "package/Encounter-home.json",
                "package/ExampleScenario-example.json",
                "package/SearchParameter-valueset-extensions-ValueSet-keyword.json",
                "package/MedicinalProductIngredient-example.json",
                "package/MedicinalProductInteraction-example.json",
                "package/CapabilityStatement-base.json",
                "package/ig-r4.json",
                "package/OperationDefinition-MedicinalProduct-everything.json",
                "package/CompartmentDefinition-device.json",
                "package/Bundle-v2-valuesets.json",
                "package/PlanDefinition-options-example.json",
                "package/ImplementationGuide-fhir.json",
                "package/CompartmentDefinition-practitioner.json",
                "package/Bundle-resources.json",
                "package/MedicinalProductIndication-example.json",
                "package/CodeSystem-v2-0550.json",
                "package/EventDefinition-example.json",
                "package/MedicinalProductManufactured-example.json",
                "package/SubstanceSpecification-example.json",
                "package/MedicinalProductContraindication-example.json",
                "package/RequestGroup-example.json",
                "package/MedicinalProductAuthorization-example.json",
                "package/MedicinalProductPharmaceutical-example.json",
                "package/CompartmentDefinition-relatedPerson.json",
                "package/MedicinalProductPackaged-example.json",
                "package/CompartmentDefinition-encounter.json",
                "package/MedicinalProduct-example.json",
                "package/RiskEvidenceSynthesis-example.json",
                "package/Evidence-example.json",
                "package/PlanDefinition-protocol-example.json",
                "package/ActivityDefinition-blood-tubes-supply.json",
                "package/EffectEvidenceSynthesis-example.json",
                "package/Questionnaire-qs1.json",

                "package/Bundle-dataelements.json",

                "package/Bundle-searchParams.json",
                "package/SearchParameter-ImplementationGuide-resource.json",
                "package/SearchParameter-Library-derived-from.json",
                "package/SearchParameter-EffectEvidenceSynthesis-context.json",
                "package/SearchParameter-Linkage-source.json",
                "package/SearchParameter-MedicinalProductPackaged-identifier.json",
                "package/SearchParameter-EffectEvidenceSynthesis-context-quantity.json",
                "package/SearchParameter-EffectEvidenceSynthesis-jurisdiction.json",
                "package/SearchParameter-ClinicalImpression-supporting-info.json",
                "package/SearchParameter-valueset-extensions-ValueSet-end.json",
                "package/SearchParameter-AuditEvent-entity.json",
                "package/SearchParameter-Provenance-target.json",
                "package/SearchParameter-EvidenceVariable-depends-on.json",
                "package/SearchParameter-Task-focus.json",
                "package/SearchParameter-Evidence-derived-from.json",
                "package/SearchParameter-ImmunizationRecommendation-information.json",
                "package/SearchParameter-RiskEvidenceSynthesis-context.json",
                "package/SearchParameter-EffectEvidenceSynthesis-description.json",
                "package/SearchParameter-Measure-derived-from.json",
                "package/SearchParameter-DocumentManifest-item.json",
                "package/SearchParameter-MedicinalProductAuthorization-subject.json",
                "package/SearchParameter-Evidence-predecessor.json",
                "package/SearchParameter-MedicinalProductAuthorization-country.json",
                "package/SearchParameter-Consent-data.json",
                "package/SearchParameter-codesystem-extensions-CodeSystem-effective.json",
                "package/SearchParameter-MedicinalProductUndesirableEffect-subject.json",
                "package/SearchParameter-RiskEvidenceSynthesis-context-type.json",
                "package/SearchParameter-Communication-based-on.json",
                "package/SearchParameter-MedicinalProductPackaged-subject.json",
                "package/SearchParameter-MeasureReport-evaluated-resource.json",
                "package/SearchParameter-Composition-entry.json",
                "package/SearchParameter-EffectEvidenceSynthesis-context-type-quantity.json",
                "package/SearchParameter-Condition-evidence-detail.json",
                "package/SearchParameter-MedicinalProduct-name.json",
                "package/SearchParameter-codesystem-extensions-CodeSystem-author.json",
                "package/SearchParameter-PlanDefinition-composed-of.json",
                "package/SearchParameter-MedicinalProductAuthorization-holder.json",
                "package/SearchParameter-codesystem-extensions-CodeSystem-keyword.json",
                "package/SearchParameter-Evidence-successor.json",
                "package/SearchParameter-CommunicationRequest-based-on.json",
                "package/SearchParameter-DocumentManifest-related-ref.json",
                "package/SearchParameter-EffectEvidenceSynthesis-status.json",
                "package/SearchParameter-PlanDefinition-successor.json",
                "package/SearchParameter-EvidenceVariable-composed-of.json",
                "package/SearchParameter-RiskEvidenceSynthesis-title.json",
                "package/SearchParameter-RiskEvidenceSynthesis-url.json",
                "package/SearchParameter-ResearchDefinition-successor.json",
                "package/SearchParameter-EventDefinition-predecessor.json",
                "package/SearchParameter-EffectEvidenceSynthesis-context-type.json",
                "package/SearchParameter-PlanDefinition-derived-from.json",
                "package/SearchParameter-EventDefinition-derived-from.json",
                "package/SearchParameter-MedicinalProductAuthorization-identifier.json",
                "package/SearchParameter-Library-successor.json",
                "package/SearchParameter-ResearchElementDefinition-composed-of.json",
                "package/SearchParameter-EvidenceVariable-successor.json",
                "package/SearchParameter-MedicinalProductAuthorization-status.json",
                "package/SearchParameter-EffectEvidenceSynthesis-context-type-value.json",
                "package/SearchParameter-Communication-part-of.json",
                "package/SearchParameter-valueset-extensions-ValueSet-workflow.json",
                "package/SearchParameter-RiskEvidenceSynthesis-context-type-value.json",
                "package/SearchParameter-Appointment-supporting-info.json",
                "package/SearchParameter-Evidence-composed-of.json",
                "package/SearchParameter-EventDefinition-successor.json",
                "package/SearchParameter-ResearchDefinition-depends-on.json",
                "package/SearchParameter-Measure-composed-of.json",
                "package/SearchParameter-Evidence-depends-on.json",
                "package/SearchParameter-MedicinalProduct-identifier.json",
                "package/SearchParameter-Measure-successor.json",
                "package/SearchParameter-EffectEvidenceSynthesis-name.json",
                "package/SearchParameter-MedicinalProductInteraction-subject.json",
                "package/SearchParameter-List-item.json",
                "package/SearchParameter-ResearchElementDefinition-derived-from.json",
                "package/SearchParameter-codesystem-extensions-CodeSystem-workflow.json",
                "package/SearchParameter-EffectEvidenceSynthesis-url.json",
                "package/SearchParameter-RiskEvidenceSynthesis-version.json",
                "package/SearchParameter-RiskEvidenceSynthesis-context-quantity.json",
                "package/SearchParameter-valueset-extensions-ValueSet-author.json",
                "package/SearchParameter-Task-based-on.json",
                "package/SearchParameter-MedicinalProductPharmaceutical-target-species.json",
                "package/SearchParameter-Measure-depends-on.json",
                "package/SearchParameter-ActivityDefinition-depends-on.json",
                "package/SearchParameter-MessageHeader-focus.json",
                "package/SearchParameter-codesystem-extensions-CodeSystem-end.json",
                "package/SearchParameter-MedicinalProduct-name-language.json",
                "package/SearchParameter-PlanDefinition-depends-on.json",
                "package/SearchParameter-Contract-subject.json",
                "package/SearchParameter-RiskEvidenceSynthesis-date.json",
                "package/SearchParameter-questionnaireresponse-extensions-QuestionnaireResponse-item-subject.json",
                "package/SearchParameter-RiskEvidenceSynthesis-name.json",
                "package/SearchParameter-RiskEvidenceSynthesis-description.json",
                "package/SearchParameter-EvidenceVariable-derived-from.json",
                "package/SearchParameter-ActivityDefinition-predecessor.json",
                "package/SearchParameter-Linkage-item.json",
                "package/SearchParameter-ActivityDefinition-successor.json",
                "package/SearchParameter-Task-subject.json",
                "package/SearchParameter-DeviceRequest-prior-request.json",
                "package/SearchParameter-DeviceRequest-based-on.json",
                "package/SearchParameter-SubstanceSpecification-code.json",
                "package/SearchParameter-DetectedIssue-implicated.json",
                "package/SearchParameter-EffectEvidenceSynthesis-publisher.json",
                "package/SearchParameter-ResearchDefinition-composed-of.json",
                "package/SearchParameter-Measure-predecessor.json",
                "package/SearchParameter-Library-predecessor.json",
                "package/SearchParameter-MedicinalProductPharmaceutical-route.json",
                "package/SearchParameter-MedicinalProductIndication-subject.json",
                "package/SearchParameter-RiskEvidenceSynthesis-status.json",
                "package/SearchParameter-Observation-focus.json",
                "package/SearchParameter-ResearchElementDefinition-predecessor.json",
                "package/SearchParameter-ActivityDefinition-composed-of.json",
                "package/SearchParameter-VerificationResult-target.json",
                "package/SearchParameter-Provenance-entity.json",
                "package/SearchParameter-RiskEvidenceSynthesis-effective.json",
                "package/SearchParameter-Basic-subject.json",
                "package/SearchParameter-EventDefinition-composed-of.json",
                "package/SearchParameter-ResearchElementDefinition-depends-on.json",
                "package/SearchParameter-Composition-subject.json",
                "package/SearchParameter-EventDefinition-depends-on.json",
                "package/SearchParameter-ActivityDefinition-derived-from.json",
                "package/SearchParameter-RiskEvidenceSynthesis-identifier.json",
                "package/SearchParameter-Library-composed-of.json",
                "package/SearchParameter-QuestionnaireResponse-subject.json",
                "package/SearchParameter-Library-depends-on.json",
                "package/SearchParameter-PlanDefinition-predecessor.json",
                "package/SearchParameter-MedicinalProductPharmaceutical-identifier.json",
                "package/SearchParameter-ResearchDefinition-predecessor.json",
                "package/SearchParameter-EffectEvidenceSynthesis-version.json",
                "package/SearchParameter-RiskEvidenceSynthesis-publisher.json",
                "package/SearchParameter-ResearchElementDefinition-successor.json",
                "package/SearchParameter-PaymentNotice-response.json",
                "package/SearchParameter-valueset-extensions-ValueSet-effective.json",
                "package/SearchParameter-RiskEvidenceSynthesis-jurisdiction.json",
                "package/SearchParameter-EvidenceVariable-predecessor.json",
                "package/SearchParameter-RiskEvidenceSynthesis-context-type-quantity.json",
                "package/SearchParameter-DocumentReference-related.json",
                "package/SearchParameter-EffectEvidenceSynthesis-identifier.json",
                "package/SearchParameter-PaymentNotice-request.json",
                "package/SearchParameter-EffectEvidenceSynthesis-title.json",
                "package/SearchParameter-EffectEvidenceSynthesis-date.json",
                "package/SearchParameter-EffectEvidenceSynthesis-effective.json",
                "package/SearchParameter-ResearchDefinition-derived-from.json",
                "package/SearchParameter-MedicinalProductContraindication-subject.json",
            };

            var filesWithValidationError = new string[] {
                "package/.index.json",
                "package/package.json",

                "package/Observation-decimal.json",
                "package/Questionnaire-qs1.json",
                "package/CareTeam-example.json",
                "package/Encounter-home.json",
                "package/ExampleScenario-example.json",

                "package/Bundle-valuesets.json",
                "package/Bundle-conceptmaps.json",
                "package/Bundle-types.json",
                "package/Bundle-dataelements.json",
                "package/Bundle-extensions.json",
                "package/Bundle-resources.json",
                "package/Bundle-profiles-others.json",

                "package/MedicinalProductDefinition-drug-and-device.json",
                "package/MedicinalProductDefinition-drug-combo-product.json",
                "package/MedicinalProductDefinition-product-with-contained-package-and-ingredient.json",
                "package/ConceptMap-cm-administrative-gender-v2.json",
                "package/CodeSystem-therapy-relationship-type.json",
                "package/MedicinalProductDefinition-equilidem-with-ing-and-auth.json",
                "package/ImplementationGuide-example.json",
                "package/CodeSystem-catalogType.json",
                "package/SearchParameter-questionnaireresponse-extensions-QuestionnaireResponse-item-subject.json",
                "package/ConceptMap-cm-contact-point-use-v2.json",
                "package/MedicinalProductDefinition-Acetamin-500-20-generic.json",
                "package/ConceptMap-cm-name-use-v2.json",
                "package/MedicinalProductDefinition-drug-and-device-complete.json",
            };

            // disable validation during parsing (not its job)
            var ds = new FhirJsonPocoDeserializerSettings { Validator = null };
            JsonSerializerOptions options = new JsonSerializerOptions().ForFhir(deserializerSettings: ds);
            var jsparser = new FhirJsonParser(new ParserSettings() { AcceptUnknownMembers = true, AllowUnrecognizedEnums = true, PermissiveParsing = true });

            var errs = new System.Collections.Generic.List<String>();
            var errFiles = new System.Collections.Generic.List<String>();

            while (reader.MoveToNextEntry())
            {
                currentPosition = reader.Entry.Key;
                if (!reader.Entry.IsDirectory)
                {
                    var exampleName = reader.Entry.Key;
                    // Debug.WriteLine($"Uploading {exampleName}");
                    var stream = reader.OpenEntryStream();
                    using (stream)
                    {
                        if (filesWithValidationError.Contains(exampleName))
                            continue;

                        Resource resource;
                        if (exampleName.EndsWith(".xml"))
                        {
                            try
                            {
                                // Debug.WriteLine($"Uploading {exampleName} [xml]");
                                using (var xr = SerializationUtil.XmlReaderFromStream(stream))
                                {
                                    resource = xmlParserClassic.Parse<Resource>(xr);
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Trace.WriteLine($"ERROR: ({exampleName}) {ex.Message}");
                                System.Threading.Interlocked.Increment(ref failures);
                                if (!errs.Contains(ex.Message))
                                    errs.Add(ex.Message);
                                errFiles.Add(exampleName);
                                continue;
                            }
                        }
                        else
                        {
                            try
                            {

                                // return;
                                // Debug.WriteLine($"Uploading {exampleName} [json]");
                                using (var jr = SerializationUtil.JsonReaderFromStream(stream))
                                {
                                    resource = jsparser.Parse<Resource>(jr);
                                }

                                // The new JSON Parser
                                // resource = System.Text.Json.JsonSerializer.Deserialize<Resource>(stream, options);
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Trace.WriteLine($"ERROR: ({exampleName}) {ex.Message}");
                                System.Threading.Interlocked.Increment(ref failures);
                                if (!errs.Contains(ex.Message))
                                    errs.Add(ex.Message);
                                errFiles.Add(exampleName);
                                continue;
                            }
                        }
                        if (resource.Meta == null)
                            resource.Meta = new Meta();
                        resource.Meta.Source = exampleName;
                        try
                        {
                            if (resource is CapabilityStatement cs)
                            {
                                if (cs.FhirVersion == FHIRVersion.N4_3_0Cibuild)
                                    cs.FhirVersion = FHIRVersion.N4_3_0;
                            }

                            if (resource is CodeSystem csy)
                            {
                                if (string.IsNullOrEmpty(csy.Publisher))
                                    csy.Publisher = "unknown";
                                if (csy.Description == null)
                                    csy.Description = new Markdown("unknown");
                            }

                            if (resource is ValueSet vs)
                            {
                                if (string.IsNullOrEmpty(vs.Publisher))
                                    vs.Publisher = "unknown";
                                if (!vs.Status.HasValue)
                                    vs.Status = PublicationStatus.Unknown;
                            }


                            if (resource is SearchParameter sp)
                            {
                                if (!sp.Base.Any())
                                {
                                    // Quietly skip them
                                    // System.Diagnostics.Trace.WriteLine($"ERROR: ({exampleName}) Search parameter with no base");
                                    // System.Threading.Interlocked.Increment(ref failures);
                                    // DebugDumpOutputXml(resource);
                                    // errFiles.Add(exampleName);
                                    continue;
                                }
                            }

                            if (resource is StructureDefinition)
                            {
                                // skip these
                            }
                            else
                            {
                                Resource result;
                                if (!string.IsNullOrEmpty(resource.Id))
                                    result = clientFhir.Update(resource);
                                else
                                    result = clientFhir.Create(resource);
                            }
                            System.Threading.Interlocked.Increment(ref successes);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Trace.WriteLine($"ERROR: ({exampleName}) {ex.Message}");
                            System.Threading.Interlocked.Increment(ref failures);
                            // DebugDumpOutputXml(resource);
                            errFiles.Add(exampleName);
                        }
                    }
                }
            }

            sw.Stop();
            Debug.WriteLine("Done!");
            Debug.WriteLine("-----------------------------------");
            Debug.WriteLine(String.Join("\r\n", errs));
            Debug.WriteLine("-----------------------------------");
            Debug.WriteLine(String.Join("\r\n", errFiles));
            Debug.WriteLine("-----------------------------------");
            Debug.WriteLine($"Success: {successes}");
            Debug.WriteLine($"Failures: {failures}");
            Debug.WriteLine($"Duration: {sw.Elapsed.ToString()}");
            Debug.WriteLine($"rps: {(successes + failures) / sw.Elapsed.TotalSeconds}");

            Assert.AreEqual(0, failures); // Most of these are due to the rng-2 error in the core fhirpath implementation (which is being reviewed for compliance to the standard)
        }

        [TestMethod, TestCategory("Round Trip")]
        public void CompareAllExamples()
        {
            LegacyFhirClient clientFhir = new LegacyFhirClient(_baseAddress, false);
            string examplesZipPath = @"TestData\examples.zip";
            var inputPath = ZipFile.OpenRead(examplesZipPath);

            var files = inputPath.Entries;
            long successes = 0;
            long failures = 0;
            var sw = Stopwatch.StartNew();

            var nt = new NameTable();
            var xmlParserClassic = new FhirXmlParser();
            var xmlParserCustom = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();
            var xmlSerializer = new FhirXmlSerializer(new SerializerSettings() { Pretty = true });

            System.Threading.Tasks.Parallel.ForEach(files,
                new System.Threading.Tasks.ParallelOptions() { MaxDegreeOfParallelism = 1 },
                file =>
                {
                    var exampleName = file.Name;
                    Resource resourceOld;
                    Resource resourceNew;
                    var localZip = ZipFile.OpenRead(examplesZipPath);
                    var stream = localZip.GetEntry(file.Name).Open();
                    using (stream)
                    {
                        // skip the dataelements file
                        if (exampleName.EndsWith("dataelements.xml"))
                            return;
                        // skip the valuesets file
                        if (exampleName.EndsWith("valuesets.xml"))
                            return;
                        if (exampleName.EndsWith("v2-tables.xml"))
                            return;

                        // skip other known invalid files
                        if (exampleName.Contains("observation-decimal(decimal)"))
                            return;

                        //if (exampleName.EndsWith(""))
                        //    return;

                        MemoryStream ms = new MemoryStream();
                        if (exampleName.EndsWith(".xml"))
                        {
                            stream.CopyTo(ms);
                            ms.Position = 0;
                            // Debug.WriteLine($"Uploading {exampleName} [xml]");
                            using (var xr = SerializationUtil.XmlReaderFromStream(ms))
                            {
                                resourceOld = xmlParserClassic.Parse<Resource>(xr);
                            }
                            //ms.Position = 0;
                            //using (var xrc = XmlReader.Create(ms, Hl7.Fhir.CustomSerializer.FhirCustomXmlReader.Settings))
                            //{
                            //    var outcome = new OperationOutcome();
                            //    resourceNew = xmlParserCustom.Parse(xrc, outcome) as Resource;
                            //    if (!outcome.Success)
                            //        DebugDumpOutputXml(outcome);
                            //}
                            ms.Position = 0;
                        }
                        else
                        {
                            return;
                            // Debug.WriteLine($"Uploading {exampleName} [json]");
                            // var jr = SerializationUtil.JsonReaderFromStream(stream);
                            // resource = new FhirJsonParser().Parse<Resource>(jr);
                        }
                        try
                        {
                            if (false)
                            {
                                if (resourceNew is StructureDefinition)
                                {
                                    // skip these
                                }
                                else
                                {
                                    Resource result;
                                    var resource = resourceNew;
                                    if (!string.IsNullOrEmpty(resource.Id))
                                        result = clientFhir.Update(resource);
                                    else
                                        result = clientFhir.Create(resource);
                                }
                                System.Threading.Interlocked.Increment(ref successes);

                            }

                            // trim out the Text
                            //if (resourceOld is DomainResource ro)
                            //    ro.Text = null;
                            //if (resourceNew is DomainResource rn)
                            //    rn.Text = null;

                            // Now verify that the resource was correct
                            //if (resourceNew.IsExactly(resourceOld))
                            //    System.Threading.Interlocked.Increment(ref successes);
                            //else
                            //{
                            //    if (xmlSerializer.SerializeToString(resourceNew) != xmlSerializer.SerializeToString(resourceOld))
                            //    {
                            //        System.Diagnostics.Trace.WriteLine($"MATCH: ({exampleName}) diff doesnt match");
                            //        System.Threading.Interlocked.Increment(ref failures);
                            //        System.IO.File.WriteAllBytes($"c:\\temp\\diffs\\{exampleName}.raw", ms.ToArray());
                            //        System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}", xmlSerializer.SerializeToString(resourceNew));
                            //        System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}.old", xmlSerializer.SerializeToString(resourceOld));
                            //    }
                            //    else
                            //    {
                            //        System.Diagnostics.Trace.WriteLine($"\r\nWarn: ({exampleName}) IsExactly doesnt match");
                            //        System.IO.File.WriteAllBytes($"c:\\temp\\diffs\\{exampleName}.raw", ms.ToArray());
                            //        System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}", xmlSerializer.SerializeToString(resourceNew));
                            //        System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}.old", xmlSerializer.SerializeToString(resourceOld));
                            //        CompareResources(resourceOld, resourceNew);
                            //    }
                            //}
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Trace.WriteLine($"ERROR: ({exampleName}) {ex.Message}");
                            System.Threading.Interlocked.Increment(ref failures);
                        }
                    }
                });

            sw.Stop();
            Debug.WriteLine("Done!");
            Debug.WriteLine("-----------------------------------");
            Debug.WriteLine($"Success: {successes}");
            Debug.WriteLine($"Failures: {failures}");
            Debug.WriteLine($"Duration: {sw.Elapsed.ToString()}");
            Debug.WriteLine($"rps: {(successes + failures) / sw.Elapsed.TotalSeconds}");

            Assert.AreEqual(0, failures); // Most of these are due to the rng-2 error in the core fhirpath implementation (which is being reviewed for compliance to the standard)
        }

        private void CompareResources(Base resourceOld, Base resourceNew, string path = null)
        {
            ClassMapping cm;
            ClassMapping.TryGetMappingForType(resourceNew.GetType(), Hl7.Fhir.Specification.FhirRelease.R4, out cm);
            foreach (var pm in cm.PropertyMappings)
            {
                if (!pm.IsCollection)
                {
                    var ov = pm.GetValue(resourceOld) as Base;
                    var nv = pm.GetValue(resourceNew) as Base;
                    if (ov != null && nv != null && !ov.IsExactly(nv))
                    {
                        System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {ov.IsExactly(nv)} {pm.ImplementingType.Name}");
                        CompareResources(ov, nv, $"{path}.{pm.Name}");
                    }
                    else
                    {
                        if ((ov == null) != (nv == null))
                            System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {ov} {nv}");
                        if (ov == null && nv == null)
                        {
                            var ov1 = pm.GetValue(resourceOld);
                            var nv1 = pm.GetValue(resourceNew);
                            if (ov1 != null || nv1 != null)
                            {
                                if ((ov1 == null) != (nv1 == null))
                                    System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {ov} {nv}");
                            }
                        }
                    }
                }
                else
                {
                    var ov = pm.GetValue(resourceOld) as System.Collections.IList;
                    var nv = pm.GetValue(resourceNew) as System.Collections.IList;
                    if (ov != null && nv != null)
                    {
                        if (ov.Count != nv.Count)
                            System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {ov.Count} != {nv.Count}");
                        else
                        {
                            for (int n = 0; n < ov.Count; n++)
                            {
                                var oi = ov[n] as Base;
                                var ni = nv[n] as Base;
                                if (!oi.IsExactly(ni))
                                {
                                    System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {oi.IsExactly(ni)}");
                                    CompareResources(oi, ni, $"{path}.{pm.Name}[{n}]");
                                }
                            }
                        }
                    }
                    else
                        if ((ov == null) != (nv == null))
                        System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {ov} {nv}");
                }
            }
            resourceOld.IsExactly(resourceNew);
        }
    }
}
