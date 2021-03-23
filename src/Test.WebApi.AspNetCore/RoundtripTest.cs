/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Hl7.Fhir.Support;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.IO.Compression;
using Hl7.Fhir.Utility;
using Hl7.Fhir.WebApi;
using System.Net.Sockets;
using System.Net;
using Microsoft.AspNetCore;
using Hl7.DemoFileSystemFhirServer;
using Microsoft.AspNetCore.Hosting;

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
        public void UploadAllExamples()
        {
            Hl7.Fhir.Rest.FhirClient clientFhir = new Hl7.Fhir.Rest.FhirClient(_baseAddress, false);
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
                new System.Threading.Tasks.ParallelOptions() { MaxDegreeOfParallelism = 12 },
                file =>
            {
                var exampleName = file.Name;
                Resource resource;
                var localZip = ZipFile.OpenRead(examplesZipPath);
                var stream = localZip.GetEntry(file.Name).Open();
                using (stream)
                {
                    // skip the dataelements file
                    if (exampleName.EndsWith("dataelements.xml"))
                        return;
                    // skip the valuesets file
                    // if (exampleName.EndsWith("valuesets.xml"))
                    //    return;

                    // if (exampleName.EndsWith("v2-tables.xml"))
                    //    return;

                    // skip other known invalid files
                    if (exampleName.Contains("observation-decimal(decimal)"))
                        return;

                    //if (exampleName.EndsWith(""))
                    //    return;

                    // MemoryStream ms = new MemoryStream();
                    if (exampleName.EndsWith(".xml"))
                    {
                        // stream.CopyTo(ms);
                        // ms.Position = 0;
                        // Debug.WriteLine($"Uploading {exampleName} [xml]");
                        //using (var xr = SerializationUtil.XmlReaderFromStream(ms))
                        //{
                        //    resource = xmlParserClassic.Parse<Resource>(xr);
                        //}
                        //ms.Position = 0;
                        using (var xrc = XmlReader.Create(stream, Hl7.Fhir.CustomSerializer.FhirCustomXmlReader.Settings))
                        {
                            var outcome = new OperationOutcome();
                            resource = xmlParserCustom.Parse(xrc, outcome) as Resource;
                            if (!outcome.Success)
                                DebugDumpOutputXml(outcome);
                        }
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

        [TestMethod, TestCategory("Round Trip")]
        public void CompareAllExamples()
        {
            Hl7.Fhir.Rest.FhirClient clientFhir = new Hl7.Fhir.Rest.FhirClient(_baseAddress, false);
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
                            ms.Position = 0;
                            using (var xrc = XmlReader.Create(ms, Hl7.Fhir.CustomSerializer.FhirCustomXmlReader.Settings))
                            {
                                var outcome = new OperationOutcome();
                                resourceNew = xmlParserCustom.Parse(xrc, outcome) as Resource;
                                if (!outcome.Success)
                                    DebugDumpOutputXml(outcome);
                            }
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
                            if (resourceNew.IsExactly(resourceOld))
                                System.Threading.Interlocked.Increment(ref successes);
                            else
                            {
                                if (xmlSerializer.SerializeToString(resourceNew) != xmlSerializer.SerializeToString(resourceOld))
                                {
                                    System.Diagnostics.Trace.WriteLine($"MATCH: ({exampleName}) diff doesnt match");
                                    System.Threading.Interlocked.Increment(ref failures);
                                    System.IO.File.WriteAllBytes($"c:\\temp\\diffs\\{exampleName}.raw", ms.ToArray());
                                    System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}", xmlSerializer.SerializeToString(resourceNew));
                                    System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}.old", xmlSerializer.SerializeToString(resourceOld));
                                }
                                else
                                {
                                    System.Diagnostics.Trace.WriteLine($"\r\nWarn: ({exampleName}) IsExactly doesnt match");
                                    System.IO.File.WriteAllBytes($"c:\\temp\\diffs\\{exampleName}.raw", ms.ToArray());
                                    System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}", xmlSerializer.SerializeToString(resourceNew));
                                    System.IO.File.WriteAllText($"c:\\temp\\diffs\\{exampleName}.old", xmlSerializer.SerializeToString(resourceOld));
                                    CompareResources(resourceOld, resourceNew);
                                }
                            }
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
            var cm = Hl7.Fhir.Serialization.BaseFhirParser.Inspector.FindClassMappingByType(resourceNew.GetType());
            foreach (var pm in cm.PropertyMappings)
            {
                if (!pm.IsCollection)
                {
                    var ov = pm.GetValue(resourceOld) as Base;
                    var nv = pm.GetValue(resourceNew) as Base;
                    if (ov != null && nv != null && !ov.IsExactly(nv))
                    {
                        System.Diagnostics.Trace.WriteLine($"{path}.{pm.Name}: {ov.IsExactly(nv)} {pm.ElementType.Name}");
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
