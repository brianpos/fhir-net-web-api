using Firely.Fhir.Validation;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Specification.Terminology;
using Hl7.Fhir.Validation;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.DemoSqliteFhirServer.Specification
{
    public class NpmPackageSource
    {
        public NpmPackageSource()
        {
            _source = new CachedResolver(
                new MultiResolver(
                    ZipSource.CreateValidationSource(),
                    new DirectorySource(@"c:\temp\OtherProfiles")
                    ));
            _validator = new Validator(_source, new LocalTerminologyService(_source));
        }

        private CachedResolver _source;
        private Validator _validator;
        private Hl7.Fhir.Serialization.FhirJsonParser _json = new Hl7.Fhir.Serialization.FhirJsonParser();
        private Hl7.Fhir.Serialization.FhirXmlParser _xml = new Hl7.Fhir.Serialization.FhirXmlParser();

        Dictionary<string, ResourceLocation> CanonicalPostitions = new Dictionary<string, ResourceLocation>();

        class ResourceLocation
        {
            public string PackageFileName { get; set; }
            public string ResourceEntryName { get; set; }
        }

        class PacakgeIndexFormat
        {
            public string PackageFileName { get; set; }
            public DateTime PackageModifiedTimestamp { get; set; }
            public IEnumerable<KeyValuePair<string, string>> CanonicalUrlMappings { get; set; }
        }

        public async Task SaveIndex(string npmPackageFile, string indexFile)
        {
            var pkgIndex = new PacakgeIndexFormat()
            {
                PackageFileName = npmPackageFile,
                PackageModifiedTimestamp = new System.IO.FileInfo(npmPackageFile).LastWriteTime,
                CanonicalUrlMappings = CanonicalPostitions.Where(cp => cp.Value.PackageFileName == npmPackageFile).Select(cp => new KeyValuePair<string, string>(cp.Key, cp.Value.ResourceEntryName))
            };
            using (var indexStream = System.IO.File.OpenWrite(indexFile))
            {
                using (var tw = new StreamWriter(indexStream))
                using (var jw = new Newtonsoft.Json.JsonTextWriter(tw))
                {
                    var s = Newtonsoft.Json.JsonSerializer.Create();
                    s.Formatting = Newtonsoft.Json.Formatting.Indented;
                    s.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                    s.Serialize(jw, pkgIndex);
                    await jw.FlushAsync();
                }
            }
        }

        public async Task LoadIndex(string npmPackageFile, string indexFile)
        {
            if (!File.Exists(npmPackageFile)) return;
            if (!File.Exists(indexFile))
            {
                await IndexPackage(npmPackageFile);
                return;
            }
            var indexContent = File.ReadAllText(indexFile);
            var jr = new Newtonsoft.Json.JsonTextReader(new StringReader(indexContent));
            var s = Newtonsoft.Json.JsonSerializer.Create();
            var pkgIndex = s.Deserialize<PacakgeIndexFormat>(jr);

            // Check if this index is current, or if it needs to be rebuilt.
            if (npmPackageFile != pkgIndex.PackageFileName || pkgIndex.PackageModifiedTimestamp < new System.IO.FileInfo(npmPackageFile).LastWriteTime)
            {
                await IndexPackage(npmPackageFile);
                return;
            }
            CanonicalPostitions = CanonicalPostitions.Union(
                                    pkgIndex.CanonicalUrlMappings.Select(pi => new KeyValuePair<string, ResourceLocation>(pi.Key, new ResourceLocation() { PackageFileName = npmPackageFile, ResourceEntryName = pi.Value })))
                                .ToDictionary(x => x.Key, y => y.Value);
        }

        public async Task IndexPackage(string npmPackageFile)
        {
            using (var packageStream = System.IO.File.OpenRead(npmPackageFile))
            {
                await IndexPackage(npmPackageFile, packageStream);
            }
        }

        string currentPosition;
        private async Task IndexPackage(string npmPackageFile, System.IO.Stream packageStream)
        {
            // Spool the package all into memory, uncompressing as it goes
            Stream gzipStream = new System.IO.Compression.GZipStream(packageStream, System.IO.Compression.CompressionMode.Decompress);
            MemoryStream ms = new MemoryStream();
            using (gzipStream)
            {
                // Unzip the tar file
                await gzipStream.CopyToAsync(ms);
                ms.Seek(0, SeekOrigin.Begin);
            }

            // Check that the first line in the indexStream
            //var srIndex = new StreamReader(indexStream);
            //var indexedPackageFileName = srIndex.ReadLineAsync();
            var skipFiles = new[] {
                "package/ig-r4.json",
                "package/.index.json",
                "other/spec.internals",
                "other/validation-summary.json",
                "other/validation-oo.json",
                // some weirdness that is in US-CORE? - Nope, the weirdness is above (*everything should be in the package folder)
                "package/other/.index.json",
                "package/other/spec.internals",
                "package/other/validation-summary.json",
                "package/other/validation-oo.json",
                "package/openapi/.index.json",
                "package/xml/.index.json"
            };

            // https://stackoverflow.com/questions/8863875/decompress-tar-files-using-c-sharp
            var reader = ReaderFactory.Open(ms);
            var packageItemCount = 0;
            while (reader.MoveToNextEntry())
            {
                packageItemCount++;
            }
            ms.Seek(0, SeekOrigin.Begin);
            reader = ReaderFactory.Open(ms);
            while (reader.MoveToNextEntry())
            {
                currentPosition = reader.Entry.Key;
                if (!reader.Entry.IsDirectory)
                {
                    if (reader.Entry.Key.EndsWith(".sch"))
                        continue;
                    if (skipFiles.Contains(reader.Entry.Key))
                        continue;
                    if (reader.Entry.Key.EndsWith(".openapi.json"))
                        continue;
                    // skip any examples
                    if (reader.Entry.Key.StartsWith("example"))
                        continue;
                    // skip any openapi files
                    if (reader.Entry.Key.StartsWith("openapi/"))
                        continue;
                    // more USCore weirdness
                    if (reader.Entry.Key.StartsWith("package/example"))
                        continue;

                    // Skip some resource types that we just don't need to worry about in the package resolver
                    // and thus don't want to index these files wasting memory
                    if (reader.Entry.Key.StartsWith("package/SearchParameter"))
                        continue;
                    if (reader.Entry.Key.StartsWith("package/ImplementationGuide"))
                        continue;
                    if (reader.Entry.Key.StartsWith("package/CapabilityStatement"))
                        continue;
                    if (reader.Entry.Key.StartsWith("package/OperationDefinition"))
                        continue;


                    string itemName = reader.Entry.Key;
                    var entry = reader.OpenEntryStream();
                    using (entry)
                    {
                        if (reader.Entry.Key == "package/package.json")
                        {
                            var sr = new StreamReader(entry);
                            string packageJson = await sr.ReadToEndAsync();
                            System.Diagnostics.Trace.WriteLine(packageJson);
                            continue;
                        }
                        System.Diagnostics.Trace.WriteLine($"Indexing: {reader.Entry.Key}");
                        try
                        {
                            var resource = await ValidateResource(itemName, entry);
                            if (resource is IConformanceResource icr && icr.Url != "http://snomed.info/sct")
                            {
                                if (!CanonicalPostitions.ContainsKey(icr.Url))
                                    CanonicalPostitions.Add(icr.Url, new ResourceLocation() { PackageFileName = npmPackageFile, ResourceEntryName = itemName });
                                else
                                    System.Diagnostics.Trace.WriteLine($"Canonical {icr.Url} already indexed");
                            }
                            if (resource is IVersionableConformanceResource ivr && ivr.Url != "http://snomed.info/sct")
                            {
                                // Also include the versioned resource reference, as sometimes that is required.
                                if (!CanonicalPostitions.ContainsKey($"{ivr.Url}|{ivr.Version}"))
                                    CanonicalPostitions.Add($"{ivr.Url}|{ivr.Version}", new ResourceLocation() { PackageFileName = npmPackageFile, ResourceEntryName = itemName });
                                else
                                    System.Diagnostics.Trace.WriteLine($"Canonical {ivr.Url}|{ivr.Version} already indexed");
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Trace.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        public async Task<Resource> ValidateResource(string itemName, Stream resourceStream)
        {
            Resource resource = null;
            if (itemName.EndsWith(".xml"))
            {
                using (var reader = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(resourceStream))
                {
                    resource = _xml.Parse<Resource>(reader);
                }
            }
            else if (itemName.EndsWith(".json"))
            {
                using (var reader = Hl7.Fhir.Utility.SerializationUtil.JsonReaderFromStream(resourceStream))
                {
                    resource = _json.Parse<Resource>(reader);
                }

            }
            if (resource != null)
            {
                var outcome = _validator.Validate(resource);
                // Ignore the undefined extension that we know we is safe to ignore
                // outcome.Issue.RemoveAll(d => d.Details.Text == "Unable to resolve reference to profile 'http://hl7.org/fhir/StructureDefinition/elementdefinition-type-must-support'");
                // Put it into another directory resolver
                System.Diagnostics.Trace.WriteLine(outcome);
                if (!outcome.Success)
                    System.Diagnostics.Trace.WriteLine(new Hl7.Fhir.Serialization.FhirXmlSerializer().SerializeToString(outcome));
            }
            return resource;
        }

        public Resource ResolveCanonical(string canonicalUrl)
        {
            if (!CanonicalPostitions.ContainsKey(canonicalUrl)) return null;
            var item = CanonicalPostitions[canonicalUrl];
            var itemName = item.ResourceEntryName;

            using (var packageStream = System.IO.File.OpenRead(item.PackageFileName))
            {
                // Spool the package all into memory, uncompressing as it goes
                Stream gzipStream = new System.IO.Compression.GZipStream(packageStream, System.IO.Compression.CompressionMode.Decompress);
                var reader = ReaderFactory.Open(gzipStream);
                while (reader.MoveToNextEntry())
                {
                    if (itemName != reader.Entry.Key) continue;

                    var entry = reader.OpenEntryStream();
                    using (entry)
                    {
                        System.Diagnostics.Trace.WriteLine($"Reading: {reader.Entry.Key}");
                        try
                        {
                            if (itemName.EndsWith(".xml"))
                            {
                                using (var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(entry))
                                {
                                    var resource = _xml.Parse<Resource>(xr);
                                    return resource;
                                }
                            }
                            else if (itemName.EndsWith(".json"))
                            {
                                using (var jr = Hl7.Fhir.Utility.SerializationUtil.JsonReaderFromStream(entry))
                                {
                                    var resource = _json.Parse<Resource>(jr);
                                    return resource;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Trace.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return null;
        }
    }
}
