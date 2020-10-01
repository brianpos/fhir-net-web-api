using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Sockets;
using System.Net;
using Owin;
using System.Web.Http;
using Hl7.Fhir.WebApi;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System.Net.Http;
using Hl7.Fhir.Introspection;
using System.Runtime.Serialization;
using Hl7.Fhir.Validation;
using System.Collections.Generic;
using Hl7.Fhir.Specification.Source;

namespace UnitTestWebApi
{
    [TestClass]
    public class ValidationFixes
    {
        [TestMethod]
        public void ResourceReferenceInfiniteLoop()
        {
            var r = new Patient()
            {
                Id = "blah",
                Active = true,
                ManagingOrganization = new ResourceReference("#", "self of no!")
            };
            r.Active = true;
            r.Contained.Add(new List() { Id = "", Mode = ListMode.Snapshot, Status = List.ListStatus.Current });
            var source = new CachedResolver(
                        // Use the specification zip that is local (from the NuGet package)
                        // ZipSource.CreateValidationSource()
                        new ZipSource(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "specification.zip"))
                    );
            var settings = new ValidationSettings()
            {
                ResourceResolver = source,
                GenerateSnapshot = true,
                ResolveExternalReferences = false,
                Trace = false
            };

            var validator = new Hl7.Fhir.Validation.Validator(settings);
            OperationOutcome oo = validator.Validate(r);
            SimpleCRUD.DebugDumpOutputXml(oo);
        }
    }
}
