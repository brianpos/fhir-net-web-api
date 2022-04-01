using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System.Linq;
using Hl7.Fhir.Utility;
using System.Threading.Tasks;
using Hl7.Fhir.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Threading;
using Task = System.Threading.Tasks.Task;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Microsoft.Health.Fhir.Facade.SqlServer
{
    public class ClosureMaintainer
    {
        public ClosureMaintainer(string terminologyServer)
        {
            TerminologyServer = terminologyServer ?? "https://r4.ontoserver.csiro.au/fhir"; // default the CSIRO test server (for now)
            cache = new MemoryCache(new MemoryCacheOptions()
            {
                CompactionPercentage = 0.10,
                ExpirationScanFrequency = new TimeSpan(0, 30, 0), // scan the cache every half hour
                SizeLimit = 500 // permit 500 closure tables (claims they are all the same size)
            });
        }

        MemoryCache cache;
        public DemoEntityModels.TerminologyDbContext DbContext;
        string TerminologyServer { get; set; }
        public CancellationToken CancellationToken { get; set; }

        /// <summary>
        /// Create the database file/dbContext
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public async Task InitializeAsync(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<DemoEntityModels.TerminologyDbContext>().UseSqlServer(connectionString);
            DbContext = new DemoEntityModels.TerminologyDbContext(builder.Options);
            await DbContext.Database.EnsureCreatedAsync(CancellationToken);
        }

        /// <summary>
        /// Create and Initiailize the initial Closure Table
        /// </summary>
        /// <param name="name"></param>
        /// <param name="codeSystem"></param>
        /// <returns></returns>
        public async Task<DemoEntityModels.ClosureTable> InitializeClosureTable(string name, string codeSystem)
        {
            DemoEntityModels.ClosureTable ctable = await DbContext.ClosureTable.FirstOrDefaultAsync(ct => ct.Name == name);
            if (ctable == null)
            {
                // Call the closure operation on the Ontoserver database
                FhirClient terminologyServer = new FhirClient(TerminologyServer);

                // Initialize the closure table
                var parameters = new Parameters();
                parameters.Add("name", new FhirString(name));
                var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);

                ctable = new DemoEntityModels.ClosureTable()
                {
                    Name = name,
                    CodeSystem = codeSystem,
                    CodeSystemHash = codeSystem.GetHashCode(),
                };
                if (closureResult is ConceptMap cm)
                {
                    ctable.SyncVersion = cm.Version;
                }

                await DbContext.ClosureTable.AddAsync(ctable, CancellationToken);
                await DbContext.SaveChangesAsync(CancellationToken);
            }
            return ctable;
        }

        public async Task DeleteClosureTable(string name)
        {
            // Call the closure operation on the Ontoserver database to truncate the closure table
            FhirClient terminologyServer = new FhirClient(TerminologyServer);

            // Initialize the closure table
            var parameters = new Parameters();
            parameters.Add("name", new FhirString(name));
            var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);

            // and remove the local table/data
            var ctable = DbContext.ClosureTable.FirstOrDefault(ct => ct.Name == name);
            if (ctable != null)
            {
                await DbContext.Database.ExecuteSqlInterpolatedAsync($"delete from closure_relationship where ClosureId = {ctable.Id}", CancellationToken);
                await DbContext.Database.ExecuteSqlInterpolatedAsync($"delete from closure_concept where ClosureId = {ctable.Id}", CancellationToken);
                await DbContext.Database.ExecuteSqlInterpolatedAsync($"delete from closure where Name = {name}", CancellationToken);
            }
            cache.Remove(name);
        }

        public async Task<ConceptMap> FhirServerUsesConcept(string namePrefix, Coding coding)
        {
            var ctable = await cache.GetOrCreateAsync<DemoEntityModels.ClosureTable>(coding.System, async (cacheEntry) =>
            {
                var ct = await InitializeClosureTable(namePrefix, coding.System);
                cacheEntry.SetValue(ct);
                cacheEntry.SetSize(1);
                return ct;
            });
            // check if the concept exists
            if (!DbContext.ClosureConcepts.Any(cv => cv.ClosureId == ctable.Id && cv.Code == coding.Code))
            {
                // Add in this concept first
                DbContext.ClosureConcepts.Add(new DemoEntityModels.ClosureConcept() { ClosureId = ctable.Id, Code = coding.Code, Display = coding.Display, ActualDataValue = true });

                // needs to be added into the closure
                // Call the closure operation on the Ontoserver database
                FhirClient terminologyServer = new FhirClient(TerminologyServer);

                try
                {
                    // update the closure table
                    var parameters = new Parameters();
                    parameters.Add("name", new FhirString(namePrefix));
                    parameters.Add("concept", new Coding(coding.System, coding.Code));
                    var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
                    if (closureResult is ConceptMap cm)
                    {
                        // Update the closure table version
                        ctable.SyncVersion = cm.Version;

                        // add the returned concepts into the closure table values
                        foreach (var element in cm.Group.SelectMany(g => g.Element))
                        {
                            foreach (var target in element.Target)
                            {
                                if (target.Equivalence != ConceptMapEquivalence.Unmatched)
                                {
                                    var relationship = new DemoEntityModels.ClosureRelationship()
                                    {
                                        ClosureId = ctable.Id,
                                        ChildCode = element.Code,
                                        ParentCode = target.Code,
                                        ConceptJson = element.ToJson()
                                    };
                                    DbContext.ClosureRelationships.Add(relationship);
                                    Console.WriteLine(element.ToJson());
                                }
                            }
                        }
                        await DbContext.SaveChangesAsync(CancellationToken);

                        return cm;
                    }
                }
                catch (FhirOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    // DebugDumpOutputXml(ex.Outcome);
                }
            }
            return null;
        }

        public async Task<ConceptMap> CheckRelationshipsForSearchConcept(string namePrefix, Coding coding)
        {
            var ctable = await cache.GetOrCreateAsync<DemoEntityModels.ClosureTable>(coding.System, async (cacheEntry) =>
            {
                var ct = await InitializeClosureTable(namePrefix, coding.System);
                cacheEntry.SetValue(ct);
                cacheEntry.SetSize(1);
                return ct;
            });

            // check if the concept exists
            if (!DbContext.ClosureConcepts.Any(cv => cv.ClosureId == ctable.Id && cv.Code == coding.Code))
            {
                // The Search concepts don't exist in the raw FHIR Data, so don't add these in specifically
                DbContext.ClosureConcepts.Add(new DemoEntityModels.ClosureConcept() { ClosureId = ctable.Id, Code = coding.Code, Display = coding.Display, ActualDataValue = false });

                // needs to be added into the closure
                // Call the closure operation on the Ontoserver database
                FhirClient terminologyServer = new FhirClient(TerminologyServer);

                try
                {
                    // update the closure table
                    var parameters = new Parameters();
                    parameters.Add("name", new FhirString(namePrefix));
                    parameters.Add("concept", new Coding(coding.System, coding.Code));
                    var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
                    if (closureResult is ConceptMap cm)
                    {
                        // Update the closure table version
                        ctable.SyncVersion = cm.Version;

                        // add the returned concepts into the closure table values
                        foreach (var element in cm.Group.SelectMany(g => g.Element))
                        {
                            foreach (var target in element.Target)
                            {
                                if (target.Equivalence != ConceptMapEquivalence.Unmatched)
                                {
                                    var relationship = new DemoEntityModels.ClosureRelationship()
                                    {
                                        ClosureId = ctable.Id,
                                        ChildCode = element.Code,
                                        ParentCode = target.Code,
                                        ConceptJson = element.ToJson()
                                    };
                                    DbContext.ClosureRelationships.Add(relationship);
                                    Console.WriteLine(element.ToJson());
                                }
                            }
                        }
                        await DbContext.SaveChangesAsync(CancellationToken);
                        return cm;
                    }
                }
                catch (FhirOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    // DebugDumpOutputXml(ex.Outcome);
                }
            }
            return null;
        }

        /// <summary>
        /// All codings are expected to have the same system value
        /// </summary>
        /// <param name="namePrefix"></param>
        /// <param name="codings"></param>
        public async Task FhirServerUsesConcepts(string namePrefix, IEnumerable<Coding> codings)
        {
            var ctable = await cache.GetOrCreateAsync<Hl7.Fhir.DemoSqliteFhirServer.DemoEntityModels.ClosureTable>(codings.First().System, async (cacheEntry) =>
            {
                var ct = await InitializeClosureTable(namePrefix, codings.First().System);
                cacheEntry.SetValue(ct);
                cacheEntry.SetSize(1);
                return ct;
            });

            FhirClient terminologyServer = new FhirClient(TerminologyServer);
            var parameters = new Parameters();
            parameters.Add("name", new FhirString(namePrefix));

            foreach (var coding in codings)
            {
                // Find codes not already in the database
                if (!DbContext.ClosureConcepts.Any(cv => cv.ClosureId == ctable.Id && cv.Code == coding.Code))
                {
                    // The Search concepts don't exist in the raw FHIR Data, so don't add these in specifically
                    DbContext.ClosureConcepts.Add(new Hl7.Fhir.DemoSqliteFhirServer.DemoEntityModels.ClosureConcept() { ClosureId = ctable.Id, Code = coding.Code, Display = coding.Display, ActualDataValue = false });
                    parameters.Add("concept", new Coding(coding.System, coding.Code));
                }
            }

            if (parameters.Parameter.Count == 1)
                return;

            // needs to be added into the closure
            // Call the closure operation on the Ontoserver database
            try
            {
                // update the closure table
                var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
                if (closureResult is ConceptMap cm)
                {
                    // Update the closure table version
                    ctable.SyncVersion = cm.Version;

                    // add the returned concepts into the closure table values
                    foreach (var element in cm.Group.SelectMany(g => g.Element))
                    {
                        foreach (var target in element.Target)
                        {
                            if (target.Equivalence != ConceptMapEquivalence.Unmatched)
                            {
                                var relationship = new Hl7.Fhir.DemoSqliteFhirServer.DemoEntityModels.ClosureRelationship()
                                {
                                    ClosureId = ctable.Id,
                                    ChildCode = element.Code,
                                    ParentCode = target.Code,
                                    ConceptJson = element.ToJson()
                                };
                                DbContext.ClosureRelationships.Add(relationship);
                                Console.WriteLine(element.ToJson());
                            }
                        }
                    }
                    await DbContext.SaveChangesAsync(CancellationToken);
                }
            }
            catch (FhirOperationException ex)
            {
                Console.WriteLine(ex.Message);
                // DebugDumpOutputXml(ex.Outcome);
            }
        }

        /// <summary>
        /// This is required when someone
        /// </summary>
        /// <returns></returns>
        public Task ReInitializeClosureTable(string name)
        {
            //var ctable = await cache.GetOrCreateAsync<DemoEntityModels.ClosureTable>(coding.System, async (cacheEntry) =>
            //{
            //    var ct = await InitializeClosureTable(namePrefix, coding.System);
            //    cacheEntry.SetValue(ct);
            //    cacheEntry.SetSize(1);
            //    return ct;
            //});
            //IEnumerable<Coding> allData = await DbContext.
            return Task.CompletedTask;
        }
    }
}
