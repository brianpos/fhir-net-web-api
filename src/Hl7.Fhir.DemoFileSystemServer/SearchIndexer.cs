using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.Language.Debugging;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.FhirPath;
using Hl7.FhirPath.Sprache;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// A DEMONSTRATION Search Indexer - not for production usage - only a sample in memory process for testing purposes
    /// </summary>
    public class SearchIndexer
    {
        // index by resource#search-parameter-name
        // then inner index by search value
        // resulting in the filename of the resource
        public ConcurrentDictionary<string, ConcurrentDictionary<string, List<string>>> MemoryIndex = new ConcurrentDictionary<string, ConcurrentDictionary<string, List<string>>>();
        public DateTimeOffset? LastScanTime;

        public void Initialize(string directory)
        {
            Hl7.Fhir.FhirPath.ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();
            var files = System.IO.Directory.EnumerateFiles(directory, "*.*.*.xml");

            string cacheFile = Path.Combine(directory, ".search-index-cache.json");
            if (File.Exists(cacheFile))
            {
                var indexerCached = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchIndexer>(File.ReadAllText(cacheFile));
                bool cacheValid = true;
                foreach (var filename in files.AsParallel())
                {
                    if (File.GetLastWriteTime(filename) > indexerCached.LastScanTime.Value)
                    {
                        cacheValid = false;
                        break;
                    }
                }
                if (cacheValid)
                {
                    // Just use the cache
                    this.MemoryIndex = indexerCached.MemoryIndex;
                    this.LastScanTime = indexerCached.LastScanTime;
                    return;
                }
            }
            // nothing was in the cache, so just scan the directory
            ScanDirectory(directory);
        }

        public void ScanDirectory(string directory)
        {
            MemoryIndex.Clear();
            LastScanTime = DateTimeOffset.Now;
            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = System.IO.Directory.EnumerateFiles(directory, "*.*.*.xml");
            foreach (var filename in files.AsParallel())
            {
                if (!filename.EndsWith("..xml")) // skip over the version history items
                    continue;
                ScanResource(parser, filename);
            }
            WriteCache(directory);
        }

        public void DeleteSearchCache(string directory)
        {
            string cacheFile = Path.Combine(directory, ".search-index-cache.json");
            if (File.Exists(cacheFile))
                File.Delete(cacheFile);
        }

        public void WriteCache(string directory)
        {
            string cacheFile = Path.Combine(directory, ".search-index-cache.json");
            string temp = Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(cacheFile, temp);
        }

        public IEnumerable<string> Search(string resourceType, string parameter, string value)
        {
            var searchparameters = ModelInfo.SearchParameters.Where(r => r.Resource == resourceType && r.Name == parameter && !String.IsNullOrEmpty(r.Expression));
            foreach (var index in searchparameters)
            {
                // prepare the search data cache
                string key = resourceType + "#" + index.Name;
                if (!MemoryIndex.ContainsKey(key))
                    return null;
                var searchIndex = MemoryIndex[key];
                List<string> items = new List<string>();
                if (index.Type == SearchParamType.String)
                {
                    foreach (var val in searchIndex.Keys)
                    {
                        if (val.StartsWith(value, StringComparison.CurrentCultureIgnoreCase))
                        {
                            items.AddRange(searchIndex[val]);
                        }
                    }
                    return items;
                }
                else
                {
                    if (searchIndex.ContainsKey(value))
                        return searchIndex[value];
                }
                return new string[] { };
            }
            return null;
        }

        public void ScanResource(Serialization.FhirXmlParser parser, string filename)
        {
            var resource = parser.Parse<Resource>(System.IO.File.ReadAllText(filename));
            ScanResource(resource, filename);
        }

        public void ScanResource(Resource resource, string filename)
        {
            // Extract the search properties
            var searchparameters = ModelInfo.SearchParameters.Where(r => r.Resource == resource.ResourceType.ToString() && !String.IsNullOrEmpty(r.Expression));
            foreach (var index in searchparameters.AsParallel())
            {
                // prepare the search data cache
                string key = resource.ResourceType.ToString() + "#" + index.Name;
                if (!MemoryIndex.ContainsKey(key))
                {
                    MemoryIndex.TryAdd(key, new ConcurrentDictionary<string, List<string>>());
                }
                var searchIndex = MemoryIndex[key];

                // Extract the values from the example
                ExtractSearchDataFromResource(searchIndex, resource, index, filename);
            }

        }

        private void ExtractSearchDataFromResource(ConcurrentDictionary<string, List<string>> searchIndex, Resource resource, ModelInfo.SearchParamDefinition index, string filename)
        {
            var resourceModel = new ScopedNode(resource.ToTypedElement());

            IEnumerable<ITypedElement> results;
            try
            {
                results = resourceModel.Select(index.Expression, new FhirEvaluationContext(resourceModel) { ElementResolver = mockResolver });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine($"Failed processing search expression {index.Name}: {index.Expression}");
                return;
            }
            if (results.Count() > 0)
            {
                foreach (var t2 in results)
                {
                    if (t2 != null)
                    {
                        var fhirval = t2.Annotation<IFhirValueProvider>();
                        if (fhirval?.FhirValue != null)
                        {
                            // Validate the type of data returned against the type of search parameter
                            //Debug.Write(index.Resource + "." + index.Name + ": ");
                            //Debug.WriteLine(fhirval?.FhirValue.ToString());// + "\r\n";

                            foreach (var val in ConvertTypeForSearch(fhirval?.FhirValue).Where(v => !string.IsNullOrEmpty(v)))
                            {
                                if (searchIndex.ContainsKey(val))
                                {
                                    if (!searchIndex[val].Contains(filename))
                                        searchIndex[val].Add(filename);
                                }
                                else
                                    searchIndex.AddOrUpdate(val, new List<string>() { filename }, (x, y) =>
                                    {
                                        if (!y.Contains(filename))
                                            y.Add(filename); 
                                        return y;
                                    });
                            }
                        }
                        //else if (t2.Value is Hl7.FhirPath.ConstantValue)
                        //{
                        //    //    Debug.Write(index.Resource + "." + index.Name + ": ");
                        //    //    Debug.WriteLine((t2.Value as Hl7.FhirPath.ConstantValue).Value);
                        //    exampleSearchValues[key]++;
                        //}
                        else if (t2.Value is bool || t2.Value is string)
                        {
                            //    Debug.Write(index.Resource + "." + index.Name + ": ");
                            //    Debug.WriteLine((bool)t2.Value);
                            if (searchIndex.ContainsKey(t2.Value.ToString()))
                            {
                                if (!searchIndex[t2.Value.ToString()].Contains(filename))
                                    searchIndex[t2.Value.ToString()].Add(filename);
                            }
                            else
                            {
                                if (!searchIndex.TryAdd(t2.Value.ToString(), new List<string>() { filename }))
                                {
                                    if (searchIndex.ContainsKey(t2.Value.ToString()))
                                        if (!searchIndex[t2.Value.ToString()].Contains(filename))
                                            searchIndex[t2.Value.ToString()].Add(filename);
                                }
                            }
                        }
                        else
                        {
                            Debug.Write(index.Resource + "." + index.Name + ": ");
                            Debug.WriteLine(t2.Value);
                        }
                    }
                }
            }
        }

        private static IEnumerable<string> ConvertTypeForSearch(Base value)
        {
            if (value is ResourceReference resref)
            {
                if (!string.IsNullOrEmpty(resref.Reference) && !resref.Reference.StartsWith("#"))
                {
                    yield return resref.Reference;
                    if (resref.Reference.Contains("/"))
                        yield return resref.Reference.Substring(resref.Reference.IndexOf("/") + 1);
                }
                yield break;
            }
            if (value is Identifier identifer)
            {
                if (!string.IsNullOrEmpty(identifer.System) && !string.IsNullOrEmpty(identifer.Value))
                {
                    yield return identifer.System + "|" + identifer.Value;
                    yield return identifer.Value;
                }
                yield break;
            }
            if (value is CodeableConcept cc)
            {
                foreach (var ccoding in cc.Coding)
                {
                    if (!string.IsNullOrEmpty(ccoding.System) && !string.IsNullOrEmpty(ccoding.Code))
                    {
                        yield return ccoding.System + "|" + ccoding.Code;
                        yield return ccoding.Code;
                    }
                }
                yield break;
            }
            if (value is Coding coding)
            {
                if (!string.IsNullOrEmpty(coding.System) && !string.IsNullOrEmpty(coding.Code))
                {
                    yield return coding.System + "|" + coding.Code;
                    yield return coding.Code;
                }
                yield break;
            }
            if (value is Period)
                yield break;
            if (value is Model.Range)
                yield break;
            yield return value.ToString();
        }

        private static ITypedElement mockResolver(string url)
        {
            ResourceIdentity ri = new ResourceIdentity(url);
            if (!string.IsNullOrEmpty(ri.ResourceType))
            {
                var fac = new Hl7.Fhir.Serialization.DefaultModelFactory();
                var type = ModelInfo.GetTypeForFhirType(ri.ResourceType);
                DomainResource res = fac.Create(type) as DomainResource;
                res.Id = ri.Id;
                return res.ToTypedElement();
            }
            return null;
        }

        public List<string> SearchUsingIndex(string resourceType, string indexName, string searchValue)
        {
            // retrieve the resource index
            string key = $"{resourceType}#{indexName}";
            if (MemoryIndex.ContainsKey(key))
            {
                var indexData = MemoryIndex[key];
                if (indexData.ContainsKey(searchValue))
                    return indexData[searchValue];
            }
            return null;
        }
    }
}
