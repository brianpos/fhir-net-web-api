using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace Microsoft.Health.Fhir.Facade.SqlServer
{
    internal class RawResourceSerializer
    {
        static internal Resource Deserialize(byte[] data)
        {
            using (var stream = new MemoryStream(data))
            {
                using (var gzipStream = new GZipStream(stream, CompressionMode.Decompress))
                {
                    using (var rdr = Hl7.Fhir.Utility.SerializationUtil.JsonReaderFromStream(gzipStream))
                    {
                        return new Hl7.Fhir.Serialization.FhirJsonParser().Parse<Resource>(rdr);
                    }
                }
            }
        }
    }
}
