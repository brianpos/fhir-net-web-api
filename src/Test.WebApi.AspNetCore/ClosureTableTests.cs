using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System.Linq;
using Task = System.Threading.Tasks.Task;

namespace UnitTestWebApi
{
    [TestClass]
    public class ClosureTableTests
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

#if NETCOREAPP3_0_OR_GREATER
        [TestMethod]
        public async Task QuickTestCreatingOntoServerClosureTable()
        {
            // Call the closure operation on the Ontoserver database
            FhirClient terminologyServer = new FhirClient("https://r4.ontoserver.csiro.au/fhir");

            // Initialize the closure table
            var parameters = new Parameters();
            parameters.Add("name", new FhirString("brian_test"));
            DebugDumpOutputXml(parameters);
            var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
            DebugDumpOutputXml(closureResult);

            // And the concept into the registry
            parameters.Add("name", new FhirString("brian_test"));
            parameters.Add("concept", new Coding("http://loinc.org", "LP415675-0"));
            parameters.Add("concept", new Coding("http://loinc.org", "LP416421-8"));
            parameters.Add("concept", new Coding("http://loinc.org", "29463-7"));
            parameters.Add("concept", new Coding("http://loinc.org", "3141-9"));
            // parameters.Add("version", new FhirString("nominated_version"));
            DebugDumpOutputXml(parameters);
            closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
            DebugDumpOutputXml(closureResult);
        }

        [TestMethod, Ignore]
        public async Task QuickClosureTableTests()
        {
            var cm = new Hl7.Fhir.DemoSqliteFhirServer.ClosureMaintainer("https://r4.ontoserver.csiro.au/fhir");
            await cm.InitializeAsync(@"c:\temp\Sqlite-closure.db");
            await cm.DeleteClosureTable("brian_test");

            // Prepare a closure table with some data as the fhir data DB is built up (this should occur as the data is saved into the FHIR Server)
            await cm.InitializeClosureTable("brian_test", "http://loinc.org");
            await cm.FhirServerUsesConcept("brian_test", new Coding("http://loinc.org", "29463-7"));
            await cm.FhirServerUsesConcept("brian_test", new Coding("http://loinc.org", "3141-9"));
            await cm.FhirServerUsesConcept("brian_test", new Coding("http://loinc.org", "8339-4"));

            // Now we're going to simulate preparing some data for some specific searches... (with nodes that aren't in the dataset)
            Console.WriteLine("");
            await cm.CheckRelationshipsForSearchConcept("brian_test", new Coding("http://loinc.org", "LP415675-0"));
            foreach (var cr in cm.DbContext.ClosureRelationships.ToList()) Console.WriteLine($"{cr.ParentCode} - {cr.ChildCode}");

            Console.WriteLine("");
            await cm.CheckRelationshipsForSearchConcept("brian_test", new Coding("http://loinc.org", "LP416421-8"));
            foreach (var cr in cm.DbContext.ClosureRelationships.ToList()) Console.WriteLine($"{cr.ParentCode} - {cr.ChildCode}");

            Console.WriteLine("");
            await cm.CheckRelationshipsForSearchConcept("brian_test", new Coding("http://loinc.org", "LP65139-5"));
            foreach (var cr in cm.DbContext.ClosureRelationships.ToList()) Console.WriteLine($"{cr.ParentCode} - {cr.ChildCode}");

            Console.WriteLine("");
            await cm.CheckRelationshipsForSearchConcept("brian_test", new Coding("http://loinc.org", "LP65139-5"));
            foreach (var cr in cm.DbContext.ClosureRelationships.ToList()) Console.WriteLine($"{cr.ParentCode} - {cr.ChildCode}");
        }
#endif
    }
}
