using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;
using Hl7.Fhir.CustomSerializer;

namespace Hl7.DemoFileSystemFhirServer
{
    public class CustomXmlSerializer : Hl7.Fhir.DemoSqliteFhirServer.ILocalXmlSerializer
    {
        XmlReaderSettings _settingsParser = new XmlReaderSettings
        {
            IgnoreComments = true,
            IgnoreProcessingInstructions = true,
            IgnoreWhitespace = true,
            DtdProcessing = DtdProcessing.Prohibit,
            NameTable = new NameTable()
        };
        XmlWriterSettings _settingsSerializer = new XmlWriterSettings
        {
            OmitXmlDeclaration = true,
            NewLineHandling = NewLineHandling.Entitize,
            Indent = true,
            NamespaceHandling = NamespaceHandling.OmitDuplicates
        };
        Hl7.Fhir.CustomSerializer.FhirCustomXmlReader _parser = new Hl7.Fhir.CustomSerializer.FhirCustomXmlReader();

        public Resource Parse<T>(string contentXML, CancellationToken cancellationToken = new CancellationToken())
            where T : Resource
        {
            StringReader sr = new StringReader(contentXML);
            var xr = XmlReader.Create(sr, _settingsParser);
            var outcome = new OperationOutcome();
            return _parser.Parse(xr, outcome, null, cancellationToken);
        }

        public Resource Parse<T>(XmlReader contentXML, CancellationToken cancellationToken = new CancellationToken())
            where T : Resource
        {
            var xr = XmlReader.Create(contentXML, _settingsParser);
            var outcome = new OperationOutcome();
            return _parser.Parse(xr, outcome, null, cancellationToken);
        }

        public string SerializeToString(Resource resource, CancellationToken cancellationToken = new CancellationToken())
        {
            StringBuilder sb = new StringBuilder();
            using (XmlWriter xw = XmlWriter.Create(sb, _settingsSerializer))
            {
                FhirCustomXmlWriter.WriteResource(resource, xw, cancellationToken);
            }
            return sb.ToString();
        }

        public byte[] SerializeToBytes(Resource resource, CancellationToken cancellationToken = new CancellationToken())
        {
            MemoryStream ms = new MemoryStream();
            using (XmlWriter xw = XmlWriter.Create(ms, _settingsSerializer))
            {
                FhirCustomXmlWriter.WriteResource(resource, xw, cancellationToken);
            }
            return ms.ToArray();
        }
    }
}

