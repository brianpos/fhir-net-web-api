/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using System.Threading.Tasks;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Text;
using System.Threading;
using Hl7.Fhir.Serialization;
using System.Xml;
using Hl7.Fhir.Utility;
using System.Collections.Generic;

namespace Hl7.Fhir.CustomSerializer
{
    public partial class CustomFhirXmlSerializer : XmlSerializer
    {
        public static void Serialize<T>(IEnumerable<T> items, XmlWriter writer, string propName, CancellationToken cancellationToken)
            where T : Base
        {
            foreach (T item in items)
            {
                // Check if the serialization is canceled before continuing 
                // through the collection
                if (cancellationToken.IsCancellationRequested)
                    return;
                if (propName == "contained" && item is Resource)
                    writer.WriteStartElement(propName, XmlNs.FHIR);
                    SerializeBase(item, writer, propName, cancellationToken);
                if (propName == "contained" && item is Resource)
                    writer.WriteEndElement();
            }
        }

        public static void Serialize(string rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (!string.IsNullOrEmpty(rawValue))
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, rawValue);
                // writer.WriteEndElement();
            }
        }
        public static void Serialize(int? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Serialize(decimal? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Serialize(bool? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Serialize(DateTimeOffset? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Serialize<T>(Code<T> rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
             where T : struct
        {
            if (cancellationToken.IsCancellationRequested) return;
            var value = rawValue?.ObjectValue as string;
            if (!string.IsNullOrEmpty(value))
            {
                writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString("value", value);
                writer.WriteEndElement();
            }
        }
        public static void Serialize(byte[] rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue?.Length > 0)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, System.Convert.ToBase64String(rawValue));
                // writer.WriteEndElement();
            }
        }

        protected override object Deserialize(XmlSerializationReader reader)
        {
            var fr = reader as Hl7.Fhir.CustomSerializer.FhirXmlSerializationReader;
            return fr.Parse();
        }

        protected override XmlSerializationReader CreateReader()
        {
            return new Hl7.Fhir.CustomSerializer.FhirXmlSerializationReader();
        }
    }
}

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// Serializers, Cancellation will be checked at the start of each type, and each iteration in a collection
    /// (This makes breaking processing a 100k collection practical)
    /// </summary>
    public class CustomFhirXmlSerializer : XmlSerializer
    {
        protected override void Serialize(object o, XmlSerializationWriter writer)
        {
            StringBuilder sb = new StringBuilder();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                NewLineHandling = NewLineHandling.Entitize,
                Indent = true
            };

            using (XmlWriter xw = XmlWriter.Create(sb, settings))
            {
                if (o is Base b)
                {
                    Hl7.Fhir.CustomSerializer.CustomFhirXmlSerializer.SerializeBase(b, xw, "root", new CancellationToken());
                }
                xw.Flush();
            }
        }

        public async Task<string> SerializeAsync(Stream content, CancellationToken cancellationToken)
        {
            StringBuilder sb = new StringBuilder();
            await System.Threading.Tasks.Task.Run(() =>
            {
                // StreamWriter sw = new StreamWriter()
            });
            return sb.ToString();
        }

        //public static void Serialize(HumanName name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)
        //{
        //    if (cancellationToken.IsCancellationRequested) return;
        //    writer.WriteStartElement(propertyName, XmlNs.FHIR);
        //    Serialize(name.extension, "extension");
        //    Serialize(name.use, "use");
        //    Serialize(name.text, "text");
        //    Serialize(name.family, "family");
        //    Serialize(name.given, "given");
        //    Serialize(name.prefix, "prefix");
        //    Serialize(name.suffix, "suffix");
        //    Serialize(name.period, "period");
        //    writer.WriteEndElement();
        //}

        //public static void Serialize(Extension name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)
        //{
        //    if (cancellationToken.IsCancellationRequested) return;
        //    writer.WriteStartElement(propertyName, XmlNs.FHIR);
        //    Serialize(name.extension, "extension");
        //    Serialize(name.value, "value");
        //    writer.WriteEndElement();
        //}

        //public static void Serialize(Element name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)
        //{
        //    if (cancellationToken.IsCancellationRequested) return;
        //    writer.WriteStartElement(propertyName, XmlNs.FHIR);
        //    Serialize(name.extension, "extension");
        //    writer.WriteEndElement();
        //}

        //public static void Serialize(FhirString name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)
        //{
        //    if (cancellationToken.IsCancellationRequested) return;
        //    writer.WriteStartElement(propertyName, XmlNs.FHIR);
        //    Serialize(name.Extension, "extension");
        //    writer.WriteEndElement();
        //}

        //public static void Serialize(Period name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)
        //{
        //    if (cancellationToken.IsCancellationRequested) return;
        //    writer.WriteStartElement(propertyName, XmlNs.FHIR);
        //    Serialize(name.Extension, "extension");
        //    Serialize(name.Start, "start");
        //    Serialize(name.End, "end");
        //    writer.WriteEndElement();
        //}

        //public static void Serialize(FhirDateTime name, string propertyName, XmlWriter writer, CancellationToken cancellationToken)
        //{
        //    if (cancellationToken.IsCancellationRequested) return;
        //    writer.WriteStartElement(propertyName, XmlNs.FHIR);
        //    Serialize(name.Extension, "extension");
        //    writer.WriteEndElement();
        //}
    }
}