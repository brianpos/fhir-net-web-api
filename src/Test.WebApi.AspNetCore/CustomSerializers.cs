using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
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
using Task = System.Threading.Tasks.Task;

namespace Test.WebApi.AspNetCore
{
    [TestClass]
    public class CustomSerializers
    {
        public static int sampleSize = 10000;

        [TestMethod]
        public void XmlLoadIntrospection()
        {
            var p = new Patient();
            var temp = new FhirXmlSerializer().SerializeToString(p);
        }

        [TestMethod]
        public void XmlSerializerCustomForChoiceTypes()
        {
            Patient p = GenerateSamplePatient();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                NewLineHandling = NewLineHandling.Entitize,
                Indent = true,
                NamespaceHandling = NamespaceHandling.OmitDuplicates
            };
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            CancellationToken ct = new CancellationToken();
            StringBuilder sb = new StringBuilder();
            using (XmlWriter xw = XmlWriter.Create(sb, settings))
            {
                // xs.Serialize(xw, p);
                Hl7.Fhir.CustomSerializer.FhirCustomXmlWriter.Write(p, xw, ct);
            }
            System.Diagnostics.Trace.WriteLine(sb);
            System.Diagnostics.Trace.WriteLine("test complete");
        }


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
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            CancellationToken ct = new CancellationToken();
            for (int n = 0; n < sampleSize; n++)
            {
                StringBuilder sb = new StringBuilder();
                using (XmlWriter xw = XmlWriter.Create(sb, settings))
                {
                    // xs.Serialize(xw, p);
                    Hl7.Fhir.CustomSerializer.FhirCustomXmlWriter.Write(p, xw, ct);
                }
                if (n == 0)
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
                string result = fs.SerializeToString(p);
                if (n == 0)
                    System.Diagnostics.Trace.WriteLine(result);
            }
            System.Diagnostics.Trace.WriteLine("test complete");
        }

        [TestMethod]
        public void XmlParserCustomWithDeserialize()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatient.xml"));
            writer.Flush();

            Patient p = null;
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                p = xs.Deserialize(stream) as Patient;
            }
            UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
        }

        [TestMethod]
        public void XmlParserCustom2()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatient.xml"));
            writer.Flush();

            Patient p = null;
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            var settings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreProcessingInstructions = true,
                IgnoreWhitespace = true,
                DtdProcessing = DtdProcessing.Prohibit,
                NameTable = new NameTable()
            };
            var xrc = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                var xr = XmlReader.Create(stream, settings);
                var outcome = new OperationOutcome();
                p = xrc.Parse(xr, outcome) as Patient;
                // p = xs.Deserialize(xr) as Patient;
                if (n == 0)
                {
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(outcome);
                }
            }
        }
        [TestMethod]
        public void XmlParserCustom2WithErrors()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatientWithErrors.xml"));
            writer.Flush();

            Patient p = null;
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            var settings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreProcessingInstructions = true,
                IgnoreWhitespace = true,
                DtdProcessing = DtdProcessing.Prohibit,
                NameTable = new NameTable()
            };
            var xrc = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                var xr = XmlReader.Create(stream, settings);
                var outcome = new OperationOutcome();
                p = xrc.Parse(xr, outcome) as Patient;
                // p = xs.Deserialize(xr) as Patient;
                if (n == 0)
                {
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(outcome);
                }
            }
        }

        [TestMethod]
        public async Task XmlParserCustom2Async()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatient.xml"));
            writer.Flush();

            Patient p = null;
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            var settings = new XmlReaderSettings
            {
                Async = true,
                IgnoreComments = true,
                IgnoreProcessingInstructions = true,
                IgnoreWhitespace = true,
                DtdProcessing = DtdProcessing.Prohibit,
                NameTable = new NameTable()
            };
            var xrc = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                var xr = XmlReader.Create(stream, settings);
                var outcome = new OperationOutcome();
                p = await xrc.ParseAsync(xr, outcome) as Patient;
                // p = xs.Deserialize(xr) as Patient;
                if (n == 0)
                {
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(outcome);
                }
            }
        }
        [TestMethod]
        public async Task XmlParserCustom2AsyncWithErrors()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatientWithErrors.xml"));
            writer.Flush();

            Patient p = null;
            XmlSerializer xs = new Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer2();
            var settings = new XmlReaderSettings
            {
                Async = true,
                IgnoreComments = true,
                IgnoreProcessingInstructions = true,
                IgnoreWhitespace = true,
                DtdProcessing = DtdProcessing.Prohibit,
                NameTable = new NameTable()
            };
            var xrc = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

            for (int n = 0; n < sampleSize; n++)
            {
                stream.Position = 0;
                var xr = XmlReader.Create(stream, settings);
                var outcome = new OperationOutcome();
                p = await xrc.ParseAsync(xr, outcome) as Patient;
                // p = xs.Deserialize(xr) as Patient;
                if (n == 0)
                {
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
                    UnitTestWebApi.BasicFacade.DebugDumpOutputXml(outcome);
                }
            }
        }

        [TestMethod]
        public void XmlParserStandard()
        {
            var fs = new Hl7.Fhir.Serialization.FhirXmlParser(new ParserSettings() { AcceptUnknownMembers = true, AllowUnrecognizedEnums = true, PermissiveParsing = true });
            // var fs = new Hl7.Fhir.Serialization.FhirXmlParser();
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
        [TestMethod]
        public void XmlParserStandardWithErrors()
        {
            var settings = new ParserSettings()
            {
                AcceptUnknownMembers = true,
                AllowUnrecognizedEnums = true,
                PermissiveParsing = true,
                ExceptionHandler = (source, args) => {
                    // don't throw it!
                    System.Diagnostics.Trace.WriteLine(args.Message);
                }
            };
            var fs = new Hl7.Fhir.Serialization.FhirXmlParser(settings);
            // var fs = new Hl7.Fhir.Serialization.FhirXmlParser();
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            // writer.WriteLine("<Patient xmlns=\"http://hl7.org.fhir\"><id value=\"pat1\"/></Patient>"); // System.IO.File.ReadAllText(""));
            writer.WriteLine(System.IO.File.ReadAllText("TestPatientWithErrors.xml"));
            writer.Flush();

            try
            {
                Patient p = null;
                for (int n = 0; n < sampleSize; n++)
                {
                    stream.Position = 0;
                    p = fs.Parse<Patient>(SerializationUtil.XmlReaderFromStream(stream));
                }
                UnitTestWebApi.BasicFacade.DebugDumpOutputXml(p);
            }
            catch (System.FormatException ex)
            {
                Assert.AreEqual("Type checking the data: Literal 'chicken' cannot be parsed as a decimal. (at Patient.extension[2].valueDecimal[0])", ex.Message);
            }
        }

        Coding ParseCoding(XmlReader reader, Stack<string> contextLocation)
        {
            // This is called when the current node is on the <valueCoding> node of the reader
            // when it returns, the node will be on the </valueCoding> or <valueCoding/> node
            // unless some error occurs, in which case, could be anywhere
            // The context will be
            Coding result = new Coding();
            if (reader.MoveToFirstAttribute())
            {
                do
                {
                    switch (reader.Name)
                    {
                        case "id":
                            result.ElementId = reader.Value;
                            break;
                        default:
                            // WTF we doing here, this is an error at this location
                            // IXmlLineInfo info = reader as IXmlLineInfo;
                            break;
                    }
                } while (reader.MoveToNextAttribute());
                reader.MoveToElement();
            }

            // there are not other nodes present
            if (reader.IsEmptyElement || reader.NodeType == XmlNodeType.EndElement)
                return result;

            // Now locate any other child nodes (till we encounter our end node)
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.EndElement)
                    return result;
                if (reader.IsStartElement())
                {
                    if (contextLocation.Count > 0)
                        contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
                    else
                        contextLocation.Push(reader.Name);
                }
                switch (reader.Name)
                {
                    case "extension":
                        var newItem_extension = new Hl7.Fhir.Model.Extension();
                        System.Diagnostics.Trace.WriteLine("===> extension: " + reader.ReadOuterXml());
                        result.Extension.Add(newItem_extension);
                        break;
                    case "system":
                        System.Diagnostics.Trace.WriteLine("===> system: " + reader.ReadOuterXml());
                        // result.SystemElement = ParseString(reader, contextLocation);
                        break;
                    case "version":
                        result.VersionElement = ParseString(reader, contextLocation);
                        break;
                    case "code":
                        System.Diagnostics.Trace.WriteLine("===> code: " + reader.ReadOuterXml());
                        // result.CodeElement = ParseString(reader, contextLocation);
                        break;
                    case "display":
                        result.DisplayElement = ParseString(reader, contextLocation);
                        break;
                    default:
                        // Property not found
                        // System.Diagnostics.Trace.WriteLine($"Unexpected token found {child.Name}");
                        System.Diagnostics.Trace.WriteLine($"===> ??? {reader.Name}: " + reader.ReadOuterXml());
                        break;
                }
                if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                    contextLocation.Pop();
            }
            return result;
        }

        FhirString ParseString(XmlReader reader, Stack<string> contextLocation)
        {
            FhirString result = new FhirString();

            if (reader.HasAttributes)
            {
                for (int attrIndex = 0; attrIndex < reader.AttributeCount; attrIndex++)
                {
                    reader.MoveToAttribute(attrIndex);
                    switch (reader.Name)
                    {
                        case "value":
                            result.Value = reader.Value;
                            break;
                        case "id":
                            result.ElementId = reader.Value;
                            break;
                    }
                }
                reader.MoveToElement();
            }

            System.Diagnostics.Trace.WriteLine($"===> {reader.Name}: " + reader.ReadOuterXml());
            return result;
            // Now locate any other child nodes (till we encounter our end node)
            while (!reader.IsEmptyElement && reader.Read() && reader.NodeType != XmlNodeType.EndElement)
            {
                if (reader.IsStartElement())
                {
                    if (contextLocation.Count > 0)
                        contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
                    else
                        contextLocation.Push(reader.Name);
                }
                switch (reader.Name)
                {
                    case "extension":
                        var newItem_extension = new Hl7.Fhir.Model.Extension();
                        Console.WriteLine(reader.ReadOuterXml());
                        result.Extension.Add(newItem_extension);
                        break;

                    default:
                        // Property not found
                        // System.Diagnostics.Trace.WriteLine($"Unexpected token found {child.Name}");
                        Console.WriteLine(reader.ReadOuterXml());
                        break;
                }
                if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                    contextLocation.Pop();
            }
            return result;
        }

        public void ParseElement(XmlReader reader, Stack<string> contextLocation)
        {
            // skip ignored elements
            while (reader.NodeType == XmlNodeType.Comment
                || reader.NodeType == XmlNodeType.XmlDeclaration
                || reader.NodeType == XmlNodeType.Whitespace
                || reader.NodeType == XmlNodeType.SignificantWhitespace
                || reader.NodeType == XmlNodeType.CDATA
                || reader.NodeType == XmlNodeType.Notation
                || reader.NodeType == XmlNodeType.ProcessingInstruction)
                reader.Read();

            if (reader.EOF)
                return;

            if (reader.IsStartElement())
            {
                if (contextLocation.Count > 0)
                    contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
                else
                    contextLocation.Push(reader.Name);
            }
            System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

            if (reader.HasAttributes)
            {
                for (int attrIndex = 0; attrIndex < reader.AttributeCount; attrIndex++)
                {
                    reader.MoveToAttribute(attrIndex);
                    System.Diagnostics.Trace.WriteLine($"    {reader.Name} = {reader.Value}");
                }
                reader.MoveToElement();
            }
            if (reader.IsEmptyElement)
            {
                contextLocation.Pop();
                // reader.Read();
                return;
            }
            // otherwise proceed to read all the other nodes
            while (reader.Read())
            {
                if (reader.NamespaceURI == "http://www.w3.org/1999/xhtml")
                {
                    System.Diagnostics.Trace.WriteLine(">>> " + reader.ReadOuterXml());
                    break;
                }
                else if (reader.IsStartElement())
                {
                    ParseElement(reader, contextLocation);
                }
                else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                {
                    break;
                }
            }
            contextLocation.Pop();
        }

        [TestMethod]
        public void XmlTestParserQuality2()
        {
            var patient = GenerateSamplePatient();
            string patientXML = new FhirXmlSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(patient);
            XmlReader reader = SerializationUtil.XmlReaderFromXmlText(patientXML);
            Stack<string> path = new Stack<string>();
            while (reader.Read())
            {
                ParseElement(reader, path);
            }
            UnitTestWebApi.BasicFacade.DebugDumpOutputXml(patient);
        }

        [TestMethod]
        public void XmlTestParserQuality()
        {
            var patient = GenerateSamplePatient();
            string patientXML = new FhirXmlSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(patient);
            XmlReader reader = SerializationUtil.XmlReaderFromXmlText(patientXML);
            string indent = "";
            Stack<string> path = new Stack<string>();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (path.Count > 0)
                        path.Push(path.Peek() + "." + reader.Name);
                    else
                        path.Push(reader.Name);
                }
                if (reader.NodeType == XmlNodeType.EndElement)
                    indent = indent.Substring(2);
                string namespaceUri = reader.NamespaceURI;
                if (namespaceUri == "http://hl7.org/fhir")
                    namespaceUri = "fhir";
                // Console.WriteLine($"{indent}{namespaceUri}::{reader.Name}");
                System.Diagnostics.Trace.WriteLine(path.Peek());
                if (namespaceUri == "http://www.w3.org/1999/xhtml")
                    System.Diagnostics.Trace.WriteLine(reader.ReadOuterXml());
                if (path.Peek() == "Patient.text.extension.valueCoding")
                {
                    var coding = ParseCoding(reader, path);
                }
                if (reader.HasAttributes)
                {
                    for (int attrIndex = 0; attrIndex < reader.AttributeCount; attrIndex++)
                    {
                        reader.MoveToAttribute(attrIndex);
                        System.Diagnostics.Trace.WriteLine($"{indent}{reader.Name} = {reader.Value}");
                    }
                    reader.MoveToElement();
                }
                if (reader.IsStartElement() && !reader.IsEmptyElement)
                {
                    indent += "  ";
                }
                if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                    path.Pop();
            }
            UnitTestWebApi.BasicFacade.DebugDumpOutputXml(patient);
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
            p.Deceased = new FhirBoolean(false);
            p.ManagingOrganization = new ResourceReference()
            {
                Reference = "#43",
                Display = "Brian's porgs"
            };

            p.SetExtension("http://example.org/ext2", new Coding("http://example.org/cs/231", "C123", "Display val"));
            p.Text = new Narrative()
            {
                Status = Narrative.NarrativeStatus.Generated,
                Div = "<div xmlns=\"http://www.w3.org/1999/xhtml\">\r\nsome content<table><td>stuff</td><td></td><td/></table></div>"
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

            if (ClassMapping.TryCreate(type, out var cm, Hl7.Fhir.Specification.FhirRelease.R4))
            {
                System.Diagnostics.Trace.WriteLine($">> {type.FullName} ({type.Name})");
                foreach (var pm in cm.PropertyMappings)
                {
                    if (ModelInfo.GetFhirTypeNameForType(pm.ImplementingType) != null)
                        ScanTypes(pm.ImplementingType, generatedTypes);
                }
            }
        }

        public void GenerateSerializer(Type type)
        {
            ClassMapping.TryCreate(type, out var cm, Hl7.Fhir.Specification.FhirRelease.R4B);
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
