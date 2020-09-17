using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Hl7.FhirPath.Sprache;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Test.WebApi.AspNetCore
{
    [TestClass]
    public class CustomSerializers
    {
        public static int sampleSize = 10000;

        [TestMethod]
        public void XmlSerializerCustom()
        {
            Patient p = GenerateSamplePatient();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                NewLineHandling = NewLineHandling.Entitize,
                Indent = true,
                NamespaceHandling = NamespaceHandling.OmitDuplicates
            };

            for (int n = 0; n < sampleSize; n++)
            {
                StringBuilder sb = new StringBuilder();
                using (XmlWriter xw = XmlWriter.Create(sb, settings))
                {
                    var ct = new CancellationToken();
                    Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer.SerializeBase(p, xw, "root", ct);
                    xw.Flush();
                }
                System.Diagnostics.Trace.WriteLine(sb);
            }
            System.Diagnostics.Trace.WriteLine("test complete");
        }

        [TestMethod]
        public void XmlSerializerStandard()
        {
            var fs = new Hl7.Fhir.Serialization.FhirXmlSerializer(new Hl7.Fhir.Serialization.SerializerSettings() { Pretty = true });
            Patient p = GenerateSamplePatient();
            for (int n = 0; n < sampleSize; n++)
            {
                System.Diagnostics.Trace.WriteLine(fs.SerializeToString(p));
            }
            System.Diagnostics.Trace.WriteLine("test complete");
        }

        [TestMethod]
        public void XmlParserCustom()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatient.xml"));
            writer.Flush();

            Patient p = null;
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer();
            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                p = xs.Deserialize(stream) as Patient;
            }
            UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
        }
        [TestMethod]
        public void XmlParserStandard()
        {
            var fs = new Hl7.Fhir.Serialization.FhirXmlParser();
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatient.xml"));
            writer.Flush();

            Patient p = null;
            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                p = fs.Parse<Patient>(SerializationUtil.XmlReaderFromStream(stream));
            }
            UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
        }

        private static Patient GenerateSamplePatient()
        {
            Patient p = new Patient()
            {
                Id = "5",
                Active = true,
                BirthDate = "1973-01-17"
            };
            p.ActiveElement.SetExtension("http://example.org/test", new FhirString("testvalue"));
            p.ActiveElement.ElementId = "1";
            p.Name.Add(new HumanName().WithGiven("Brian").AndFamily("Pos"));
            p.Name[0].Given = new[] { "Brian", "Richard" };
            p.Name[0].AddExtension("http://example.org/3rd", new Coding("system", "43"));
            p.ManagingOrganization = new ResourceReference()
            {
                Reference = "#43",
                Display = "Brian's porgs"
            };

            p.SetExtension("http://example.org/ext2", new Coding("http://example.org/cs/231", "C123", "Display val"));
            p.Text = new Narrative()
            {
                Status = Narrative.NarrativeStatus.Generated,
                Div = "<div xmlns=\"http://www.w3.org/1999/xhtml\">some content</div>"
            };

            // Add in lots of phone numbers
            for (int n = 0; n < 2; n++)
            {
                p.Telecom.Add(new ContactPoint() { System = ContactPoint.ContactPointSystem.Phone, Value = $"{n}" });
            }

            var o = new Organization()
            {
                Id = "43",
                Name = "Brian's porgs"
            };
            o.Telecom.Add(new ContactPoint()
            {
                System = ContactPoint.ContactPointSystem.Phone,
                Value = "0121 222342"
            });
            p.Contained.Add(o);
            return p;
        }

        public void ScanTypes(Type type, Dictionary<string, Type> generatedTypes)
        {
            if (generatedTypes.ContainsKey(type.FullName))
                return;
            generatedTypes.Add(type.FullName, type);

            var cm = ClassMapping.Create(type);
            System.Diagnostics.Trace.WriteLine($">> {type.FullName} ({type.Name})");
            foreach (var pm in cm.PropertyMappings)
            {
                if (ModelInfo.GetFhirTypeNameForType(pm.ElementType) != null)
                    ScanTypes(pm.ElementType, generatedTypes);
            }
        }

        public void GenerateSerializer(Type type)
        {
            var cm = ClassMapping.Create(type);
            System.Diagnostics.Trace.WriteLine($"public static void Serialize({type.Name} name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)");
            System.Diagnostics.Trace.WriteLine("{");
            System.Diagnostics.Trace.WriteLine("\tif (cancellationToken.IsCancellationRequested) return;");
            System.Diagnostics.Trace.WriteLine($"\twriter.WriteStartElement(propertyName, XmlNs.FHIR);");
            foreach (var pm in cm.PropertyMappings)
            {
                if (pm.IsPrimitive)
                {
                    // if (pm.SerializationHint == Hl7.Fhir.Specification.XmlRepresentation.XmlAttr)
                }
                else
                {
                    // check for the property type
                    System.Diagnostics.Trace.WriteLine($"\tSerialize(name.{pm.Name}, \"{pm.Name}\");");
                }
            }
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.Instance))
            {
                if (prop.GetCustomAttribute(typeof(NotMappedAttribute)) != null)
                    continue;
                FhirElementAttribute fea = prop.GetCustomAttribute(typeof(FhirElementAttribute)) as FhirElementAttribute;
                System.Diagnostics.Trace.WriteLine($"\tSerialize2(name.{prop.Name}, \"{fea.Name}\"); // {fea.Order}");
                // prop.PropertyType
            }

            System.Diagnostics.Trace.WriteLine($"\twriter.WriteEndElement();");
            System.Diagnostics.Trace.WriteLine("}");
            System.Diagnostics.Trace.WriteLine("");

            // --------------------------------------------------------------

        }
    }
}
