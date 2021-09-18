using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.Language.Debugging;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Support;
using Hl7.Fhir.WebApi.DemoEntityModels;
using Hl7.FhirPath;
using Hl7.FhirPath.Sprache;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// A DEMONSTRATION Search Indexer - not for production usage - only a sample in memory process for testing purposes
    /// </summary>
    public class DemoSearchIndexer
    {
        public class GetResourceResult
        {
            internal GetResourceResult(Resource resource)
            {
                Resource = resource;
            }
            public static GetResourceResult Deleted = new GetResourceResult(null) { IsDeleted = true };
            public Resource Resource { get; }
            public bool IsDeleted { get; private set; }
        }

        public void Initialize(FhirDbContext db)
        {
            Hl7.Fhir.FhirPath.ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();
            db.Database.EnsureCreated();
        }

        public async Task ScanDirectory(FhirDbContext db, string directory)
        {
            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = System.IO.Directory.EnumerateFiles(directory, "*.*.*.xml");
            foreach (var filename in files.AsParallel())
            {
                if (!filename.EndsWith("..xml")) // skip over the version history items
                    continue;
                await ScanResource(db, parser, filename);
            }
        }

        public void DeleteSearchCache(FhirDbContext db)
        {
            db.Database.EnsureDeleted();
        }

        public async Task<IEnumerable<long>> Search(FhirDbContext db, string resourceType, string parameter, string value)
        {
            IEnumerable<long> internal_ids = new long[] { };
            var searchparameters = ModelInfo.SearchParameters.Where(r => r.Resource == resourceType && r.Name == parameter && !String.IsNullOrEmpty(r.Expression));
            foreach (var index in searchparameters)
            {
                // prepare the search data cache
                string key = $"{index.Resource}.{index.Name}";
                List<string> items = new List<string>();
                if (index.Type == SearchParamType.String)
                {
                    var results = await db.SearchIndexString.Where(i => i.Path == key && i.Value.StartsWith(value)).ToListAsync();
                    internal_ids = internal_ids.Union(results.Select(r => r.internal_id));
                    return internal_ids;
                }
                else
                {
                    var results = await db.SearchIndexString.Where(i => i.Path == key && i.Value == value).ToListAsync();
                    internal_ids = internal_ids.Union(results.Select(r => r.internal_id));
                    return internal_ids;
                }
            }
            return null;
        }

        public async Task<GetResourceResult> Get(FhirDbContext db, string ResourceType, string Id, string version = null)
        {
            if (version == null)
            {
                var record = await db.Resource_Header.FirstOrDefaultAsync(r => r.resource_id == Id && r.ResourceType == ResourceType).ConfigureAwait(false);
                if (record == null)
                    return null;
                if (record.deleted)
                {
                    return GetResourceResult.Deleted;
                }
                return new GetResourceResult(new Serialization.FhirXmlParser().Parse<Resource>(record.contentXML));
            }
            if (int.TryParse(version, out var versionNo))
            {
                var record = await db.Resource_History.FirstOrDefaultAsync(r => r.resource_id == Id && r.ResourceType == ResourceType && r.version_id == versionNo).ConfigureAwait(false);
                if (record == null)
                    return null;
                if (record.deleted)
                {
                    return GetResourceResult.Deleted;
                }
                using (var stream = new MemoryStream(record.contentXML))
                {
                    using (var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream))
                    {
                        return new GetResourceResult(new Serialization.FhirXmlParser().Parse<Resource>(xr));
                    }
                }
            }
            return null;
        }

        internal async Task<IEnumerable<Resource>> InstanceHistory(FhirDbContext db, string resourceName, string resourceId, DateTimeOffset? since, DateTimeOffset? till, int? count)
        {
            List<Resource> result = new List<Resource>();
            var parser = new Fhir.Serialization.FhirXmlParser();
            var query = db.Resource_History.Where(r => r.ResourceType == resourceName && r.resource_id == resourceId).AsQueryable();
            if (since.HasValue)
                query = query.Where(r => r.last_updated >= since.Value);
            if (till.HasValue)
                query = query.Where(r => r.last_updated <= till.Value);
            if (count.HasValue)
                query = query.Take(count.Value);
            var queryResults = await query.ToListAsync();
            foreach (var item in queryResults)
            {
                using (var stream = new MemoryStream(item.contentXML))
                {
                    using (var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream))
                    {
                        result.Add(parser.Parse<Resource>(xr));
                    }
                }
            }
            return result;
        }

        internal async Task<IEnumerable<Resource>> TypeHistory(FhirDbContext db, string resourceName, DateTimeOffset? since, DateTimeOffset? till, int? count)
        {
            List<Resource> result = new List<Resource>();
            var parser = new Fhir.Serialization.FhirXmlParser();
            var query = db.Resource_History.Where(r => r.ResourceType == resourceName).AsQueryable();
            if (since.HasValue)
                query = query.Where(r => r.last_updated >= since.Value);
            if (till.HasValue)
                query = query.Where(r => r.last_updated <= till.Value);
            if (count.HasValue)
                query = query.Take(count.Value);
            var queryResults = await query.ToListAsync();
            foreach (var item in queryResults)
            {
                using (var stream = new MemoryStream(item.contentXML))
                {
                    using (var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream))
                    {
                        result.Add(parser.Parse<Resource>(xr));
                    }
                }
            }
            return result;
        }

        internal async Task<IEnumerable<Resource>> SystemHistory(FhirDbContext db, DateTimeOffset? since, DateTimeOffset? till, int? count)
        {
            List<Resource> result = new List<Resource>();
            var parser = new Fhir.Serialization.FhirXmlParser();
            var query = db.Resource_History.AsQueryable();
            if (since.HasValue)
                query = query.Where(r => r.last_updated >= since.Value);
            if (till.HasValue)
                query = query.Where(r => r.last_updated <= till.Value);
            if (count.HasValue)
                query = query.Take(count.Value);
            query = query.OrderByDescending(o => o.last_updated);
            var queryResults = await query.ToListAsync();
            foreach (var item in queryResults)
            {
                using (var stream = new MemoryStream(item.contentXML))
                {
                    using (var xr = Hl7.Fhir.Utility.SerializationUtil.XmlReaderFromStream(stream))
                    {
                        result.Add(parser.Parse<Resource>(xr));
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Delete the resource and return the version number of the deletion instance
        /// or -1 when the resource did not exist
        /// </summary>
        /// <param name="db"></param>
        /// <param name="Id"></param>
        /// <param name="ResourceType"></param>
        /// <returns></returns>
        public async Task<int> DeleteResource(FhirDbContext db, string ResourceType, string Id)
        {
            await db.Database.BeginTransactionAsync();
            var record = await db.Resource_Header.FirstOrDefaultAsync(r => r.resource_id == Id && r.ResourceType == ResourceType).ConfigureAwait(false);
            if (record == null)
                return -1;
            record.last_updated = DateTimeOffset.Now;
            record.deleted = true;
            record.current_version_id++;

            await db.Resource_History.AddAsync(new resource_history()
            {
                ResourceType = ResourceType,
                resource_id = Id,
                deleted = true,
                last_updated = DateTimeOffset.Now,
                internal_id = record.internal_id,
                version_id = record.current_version_id
            });
            var existingValues = await db.SearchIndexString.Where(v => v.internal_id == record.internal_id).ToListAsync();
            db.SearchIndexString.RemoveRange(existingValues);
            await db.SaveChangesAsync();
            db.Database.CommitTransaction(); // interesting that there is no async form of this call
            return record.current_version_id;
        }

        /// <summary>
        /// Scan over the provided file from the file system and store it into the FHIR Database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="parser"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        private async Task ScanResource(FhirDbContext db, Serialization.FhirXmlParser parser, string filename)
        {
            var resource = parser.Parse<Resource>(System.IO.File.ReadAllText(filename));
            await StoreResource(db, resource);
        }

        public async Task StoreResource(FhirDbContext db, Resource resource)
        {
            bool updatingResource = true;
            if (String.IsNullOrEmpty(resource.Id))
            {
                resource.Id = Guid.NewGuid().ToFhirId();
                updatingResource = false;
            }
            if (resource.Meta == null)
                resource.Meta = new Meta();
            Resource oldValue = null;
            DateTimeOffset modificationTime = DateTimeOffset.Now;
            var record = await db.Resource_Header.FirstOrDefaultAsync(r => r.resource_id == resource.Id && r.ResourceType == resource.TypeName).ConfigureAwait(false);
            if (record != null)
            {
                if (!record.deleted)
                {
                    // do some sanity checking on this content to see if it is different
                    oldValue = new Hl7.Fhir.Serialization.FhirXmlParser().Parse<Resource>(record.contentXML);
                    // if they are the same, don't commit anything
                    if (CompareContentForSave(oldValue, resource))
                    {
                        if (resource is DomainResource dr)
                        {
                            dr.Text = (oldValue as DomainResource).Text;
                        }
                        resource.Meta = oldValue.Meta;
                        return;
                    }
                }
                // increment the version number and set the modified timestamp
                record.current_version_id++;
                resource.Meta.VersionId = record.current_version_id.ToString();
                record.last_updated = modificationTime;
                resource.Meta.LastUpdated = modificationTime;
                if (record.deleted)
                    record.deleted = false;
            }
            else
            {
                // set the version number and set the modified timestamp
                resource.Meta.VersionId = "1";
                resource.Meta.LastUpdated = modificationTime;
            }

            var xml = new Serialization.FhirXmlSerializer(new Serialization.SerializerSettings { Pretty = true }).SerializeToString(resource);
            var xmlBytes = new Serialization.FhirXmlSerializer(new Serialization.SerializerSettings { Pretty = true }).SerializeToBytes(resource);
            if (record == null)
            {
                var result = await db.Resource_Header.AddAsync(new resource_header()
                {
                    ResourceType = resource.TypeName,
                    resource_id = resource.Id,
                    deleted = false,
                    last_updated = modificationTime,
                    current_version_id = 1,
                    contentXML = xml
                });
                await db.SaveChangesAsync();
                record = result.Entity;
            }
            else
            {
                record.contentXML = xml;
            }
            int versionId = record.current_version_id;
            if (!await db.Resource_History.AnyAsync(hist => hist.resource_id == resource.Id && hist.ResourceType == resource.TypeName && hist.version_id == versionId))
            {
                await db.Resource_History.AddAsync(new resource_history()
                {
                    ResourceType = resource.TypeName,
                    resource_id = resource.Id,
                    deleted = false,
                    last_updated = modificationTime,
                    internal_id = record.internal_id,
                    UsedPutHttpMethod = updatingResource,
                    version_id = record.current_version_id,
                    contentXML = xmlBytes
                });
            }

            // Extract the search properties
            var searchparameters = ModelInfo.SearchParameters.Where(r => r.Resource == resource.TypeName && !String.IsNullOrEmpty(r.Expression));
            foreach (var index in searchparameters.AsParallel())
            {
                // Extract the values from the example
                await ExtractSearchDataFromResource(db, resource, index, record.internal_id);
            }
            await db.SaveChangesAsync();
        }

        private async Task ExtractSearchDataFromResource(FhirDbContext db, Resource resource, ModelInfo.SearchParamDefinition index, long internal_id)
        {
            var resourceModel = new ScopedNode(resource.ToTypedElement());

            IEnumerable<ITypedElement> results;
            try
            {
                results = resourceModel.Select(index.Expression, new FhirEvaluationContext(resourceModel) { ElementResolver = mockResolver });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine($"Failed processing search expression {index.Name}: {index.Expression}, {ex.Message}");
                return;
            }
            if (results.Count() > 0)
            {
                foreach (var t2 in results)
                {
                    if (t2 != null)
                    {
                        string key = $"{index.Resource}.{index.Name}";
                        var fhirval = t2.Annotation<IFhirValueProvider>();
                        if (fhirval?.FhirValue != null)
                        {
                            // Validate the type of data returned against the type of search parameter
                            //Debug.Write(index.Resource + "." + index.Name + ": ");
                            //Debug.WriteLine(fhirval?.FhirValue.ToString());// + "\r\n";
                            var existingValues = await db.SearchIndexString.Where(v => v.internal_id == internal_id && v.Path == key).ToListAsync();
                            foreach (var val in ConvertTypeForSearch(fhirval?.FhirValue).Where(v => !string.IsNullOrEmpty(v)))
                            {
                                await UpdateIndexTable(db, index, internal_id, existingValues, val);
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
                            var existingValues = await db.SearchIndexString.Where(v => v.internal_id == internal_id && v.Path == key).ToListAsync();
                            var val = t2.Value.ToString();
                            await UpdateIndexTable(db, index, internal_id, existingValues, val);
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

        private static async Task UpdateIndexTable(FhirDbContext db, ModelInfo.SearchParamDefinition index, long internal_id, List<IndexString> existingValues, string val)
        {
            if (existingValues.RemoveAll(ev => ev.Value == val) == 0)
            {
                // it wasn't there, so we need to add it
                await db.SearchIndexString.AddAsync(new IndexString()
                {
                    internal_id = internal_id,
                    Path = $"{index.Resource}.{index.Name}",
                    Value = val
                });
            }
            db.SearchIndexString.RemoveRange(existingValues);
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

        public bool CompareContentForSave(Base resourceOld, Base resourceNew)
        {
            if (resourceOld == null && resourceNew == null)
                return true;

            var cm = Hl7.Fhir.Serialization.BaseFhirParser.Inspector.FindClassMappingByType(resourceOld.GetType()) ?? Hl7.Fhir.Serialization.BaseFhirParser.Inspector.FindClassMappingByType(resourceNew.GetType());
            foreach (var pm in cm.PropertyMappings)
            {
                // skip the narrative
                if (pm.ElementType == typeof(Narrative))
                    continue;
                // skip the version and last updated props
                if (cm.NativeType == typeof(Meta) && (pm.Name == "lastUpdated" || pm.Name == "versionId"))
                    continue;

                if (!pm.IsCollection)
                {
                    var ovRaw = pm.GetValue(resourceOld);
                    var nvRaw = pm.GetValue(resourceNew);
                    if (ovRaw == null && nvRaw == null)
                        continue;
                    if ((ovRaw == null) != (nvRaw == null)) // one of them is null (but not both)
                        return false;

                    var ov = ovRaw as Base;
                    var nv = nvRaw as Base;
                    if (ov != null && nv != null)
                    {
                        if (ov is Primitive p)
                        {
                            if (!ov.IsExactly(nv))
                                return false;
                        }
                        else
                        {
                            if (!CompareContentForSave(ov, nv))
                                return false;
                        }
                    }
                    else
                    {
                        // this is a raw property, need to manually compare
                        if (!ovRaw.Equals(nvRaw))
                            return false;
                    }
                }
                else
                {
                    var ov = pm.GetValue(resourceOld) as System.Collections.IList;
                    var nv = pm.GetValue(resourceNew) as System.Collections.IList;
                    if (ov != null && nv != null)
                    {
                        if (ov.Count != nv.Count)
                            return false;
                        else
                        {
                            for (int n = 0; n < ov.Count; n++)
                            {
                                var oi = ov[n] as Base;
                                var ni = nv[n] as Base;
                                if (!CompareContentForSave(oi, ni))
                                    return false;
                            }
                        }
                    }
                    else
                    {
                        if (ov != null || nv != null)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
