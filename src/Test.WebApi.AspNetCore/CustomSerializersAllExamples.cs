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
    public class CustomSerializersTest
    {
        #region << Test prepare and cleanup >>
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
        public void XmlParseAllExamplesCustom2()
        {
            string examplesZipPath = @"TestData\examples.zip";
            var inputPath = ZipFile.OpenRead(examplesZipPath);

            var files = inputPath.Entries;
            long successes = 0;
            long failures = 0;
            var sw = Stopwatch.StartNew();

            var xrc = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

            System.Threading.Tasks.Parallel.ForEach(files,
                new System.Threading.Tasks.ParallelOptions() { MaxDegreeOfParallelism = 100 },
                file =>
                {
                    var exampleName = file.Name;
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

                        if (exampleName.EndsWith(".xml"))
                        {
                            // Debug.WriteLine($"Uploading {exampleName} [xml]");
                            using (var xr = XmlReader.Create(stream, Hl7.Fhir.CustomSerializer.FhirCustomXmlReader.Settings))
                            {
                                var outcome = new OperationOutcome();
                                resourceNew = xrc.Parse(xr, outcome) as Patient;
                                if (outcome.Success)
                                    System.Threading.Interlocked.Increment(ref successes);
                                else
                                    System.Threading.Interlocked.Increment(ref failures);
                            }
                        }
                        else
                        {
                            return;
                            // Debug.WriteLine($"Uploading {exampleName} [json]");
                            // var jr = SerializationUtil.JsonReaderFromStream(stream);
                            // resource = new FhirJsonParser().Parse<Resource>(jr);
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
            Debug.WriteLine($"Memory: {GC.GetTotalMemory(true) / 1000:n0}");

            Assert.AreEqual(0, failures); // Most of these are due to the rng-2 error in the core fhirpath implementation (which is being reviewed for compliance to the standard)
        }

#if NETCOREAPP3_1 || NET5_0_OR_GREATER
        [TestMethod, TestCategory("Round Trip")]
        public async System.Threading.Tasks.Task XmlParseAllExamplesCustom2Async()
        {
            string examplesZipPath = @"TestData\examples.zip";
            var inputPath = ZipFile.OpenRead(examplesZipPath);

            var files = inputPath.Entries;
            long successes = 0;
            long failures = 0;
            var sw = Stopwatch.StartNew();

            var xmlParserCustom = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

            List<System.Threading.Tasks.Task> listOfTasks = new List<System.Threading.Tasks.Task>();
            foreach (ZipArchiveEntry file in files)
            {
                listOfTasks.Add(ExtractFileAsync(examplesZipPath, xmlParserCustom, file));
            }
            await System.Threading.Tasks.Task.WhenAll(listOfTasks).ConfigureAwait(false);
            foreach (System.Threading.Tasks.Task<bool> item in listOfTasks)
            {
                if (item.Result)
                    System.Threading.Interlocked.Increment(ref successes);
            }

            sw.Stop();
            Debug.WriteLine("Done!");
            Debug.WriteLine("-----------------------------------");
            Debug.WriteLine($"Success: {successes}");
            Debug.WriteLine($"Failures: {failures}");
            Debug.WriteLine($"Duration: {sw.Elapsed.ToString()}");
            Debug.WriteLine($"rps: {(successes + failures) / sw.Elapsed.TotalSeconds}");
            Debug.WriteLine($"Memory: {GC.GetTotalMemory(true)/1000:n0}");

            Assert.AreEqual(0, failures); // Most of these are due to the rng-2 error in the core fhirpath implementation (which is being reviewed for compliance to the standard)
        }

        private static async System.Threading.Tasks.Task<bool> ExtractFileAsync(string examplesZipPath, Hl7.Fhir.CustomSerializer.FhirCustomXmlReader xmlParserCustom, ZipArchiveEntry file)
        {
            var exampleName = file.Name;
            Resource resourceNew;
            var localZip = ZipFile.OpenRead(examplesZipPath);
            var stream = localZip.GetEntry(file.Name).Open();
            using (stream)
            {
                // skip the dataelements file
                if (exampleName.EndsWith("dataelements.xml"))
                    return false;
                // skip the valuesets file
                if (exampleName.EndsWith("valuesets.xml"))
                    return false;
                if (exampleName.EndsWith("v2-tables.xml"))
                    return false;

                // skip other known invalid files
                if (exampleName.Contains("observation-decimal(decimal)"))
                    return false;

                //if (exampleName.EndsWith(""))
                //    return;

                if (exampleName.EndsWith(".xml"))
                {
                    // Debug.WriteLine($"Uploading {exampleName} [xml]");
                    using (var xr = XmlReader.Create(stream, Hl7.Fhir.CustomSerializer.FhirCustomXmlReader.Settings))
                    {
                        var outcome = new OperationOutcome();
                        resourceNew = await xmlParserCustom.ParseAsync(xr, outcome) as Resource;
                    }
                }
                else
                {
                    return false;
                    // Debug.WriteLine($"Uploading {exampleName} [json]");
                    // var jr = SerializationUtil.JsonReaderFromStream(stream);
                    // resource = new FhirJsonParser().Parse<Resource>(jr);
                }
            }
            return true;
        }
#endif

        [TestMethod, TestCategory("Round Trip")]
        public void XmlParseAllExamplesStandard()
        {
            string examplesZipPath = @"TestData\examples.zip";
            var inputPath = ZipFile.OpenRead(examplesZipPath);

            var files = inputPath.Entries;
            long successes = 0;
            long failures = 0;
            var sw = Stopwatch.StartNew();

            var xmlParserClassic = new FhirXmlParser();

            System.Threading.Tasks.Parallel.ForEach(files,
                new System.Threading.Tasks.ParallelOptions() { MaxDegreeOfParallelism = 100 },
                file =>
                {
                    var exampleName = file.Name;
                    Resource resourceOld;
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

                        if (exampleName.EndsWith(".xml"))
                        {
                            // Debug.WriteLine($"Uploading {exampleName} [xml]");
                            using (var xr = SerializationUtil.XmlReaderFromStream(stream))
                                resourceOld = xmlParserClassic.Parse<Resource>(xr);
                        }
                        else
                        {
                            return;
                            // Debug.WriteLine($"Uploading {exampleName} [json]");
                            // var jr = SerializationUtil.JsonReaderFromStream(stream);
                            // resource = new FhirJsonParser().Parse<Resource>(jr);
                        }
                        System.Threading.Interlocked.Increment(ref successes);
                    }
                });

            sw.Stop();
            Debug.WriteLine("Done!");
            Debug.WriteLine("-----------------------------------");
            Debug.WriteLine($"Success: {successes}");
            Debug.WriteLine($"Failures: {failures}");
            Debug.WriteLine($"Duration: {sw.Elapsed.ToString()}");
            Debug.WriteLine($"rps: {(successes + failures) / sw.Elapsed.TotalSeconds}");
            Debug.WriteLine($"Memory: {GC.GetTotalMemory(true) / 1000:n0}");

            Assert.AreEqual(0, failures); // Most of these are due to the rng-2 error in the core fhirpath implementation (which is being reviewed for compliance to the standard)
        }
    }
}
