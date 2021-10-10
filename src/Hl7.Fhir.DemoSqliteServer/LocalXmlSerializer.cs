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

namespace Hl7.Fhir.DemoSqliteFhirServer
{
    public interface ILocalXmlSerializer
    {
        Resource Parse<T>(string contentXML, CancellationToken cancellationToken = new CancellationToken()) where T : Resource;
        Resource Parse<T>(XmlReader contentXML, CancellationToken cancellationToken = new CancellationToken()) where T : Resource;
        string SerializeToString(Resource resource, CancellationToken cancellationToken = new CancellationToken());
        byte[] SerializeToBytes(Resource resource, CancellationToken cancellationToken = new CancellationToken());
    }

    public class LocalXmlSerializer : ILocalXmlSerializer
    {
        FhirXmlParser _parser = new FhirXmlParser();
        FhirXmlSerializer _serializer = new FhirXmlSerializer(new SerializerSettings() { Pretty = true });

        public Resource Parse<T>(string contentXML, CancellationToken cancellationToken = new CancellationToken())
            where T: Resource
        {
            return _parser.Parse<T>(contentXML);
        }

        public Resource Parse<T>(XmlReader contentXML, CancellationToken cancellationToken = new CancellationToken())
            where T : Resource
        {
            return _parser.Parse<T>(contentXML);
        }

        public string SerializeToString(Resource resource, CancellationToken cancellationToken = new CancellationToken())
        {
            return _serializer.SerializeToString(resource);
        }

        public byte[] SerializeToBytes(Resource resource, CancellationToken cancellationToken = new CancellationToken())
        {
            return _serializer.SerializeToBytes(resource);
        }
    }
}
