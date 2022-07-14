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
    public class FhirCustomXmlSerializationWriter : XmlSerializationWriter
    {
        public void Write(Base o)
        {
            if (o is Base b)
            {
                FhirCustomXmlWriter.WriteBase(o, this.Writer, "root", new CancellationToken());
            }
            this.Writer.Flush();
        }

        protected override void InitCallbacks()
        {
        }
    }


    public partial class FhirCustomXmlWriter
    {
        public static XmlWriterSettings Settings = new XmlWriterSettings
        {
            Encoding = new UTF8Encoding(false),
            OmitXmlDeclaration = true,
            Async = true,
            CloseOutput = true,
            Indent = true,
            NewLineHandling = NewLineHandling.Entitize,
            IndentChars = "  "
        };

        public static void Write<T>(IEnumerable<T> items, XmlWriter writer, string propName, CancellationToken cancellationToken)
            where T : Base
        {
            foreach (T item in items)
            {
                // Check if the serialization is canceled before continuing
                // through the collection
                if (cancellationToken.IsCancellationRequested)
                    return;
                //if (propName == "contained" && item is Resource)
                //    writer.WriteStartElement(propName, XmlNs.FHIR);
                WriteBase(item, writer, propName, cancellationToken);
                //if (propName == "contained" && item is Resource)
                //    writer.WriteEndElement();
            }
        }

        public static void Write<T>(IEnumerable<Code<T>> items, XmlWriter writer, string propName, CancellationToken cancellationToken)
            where T : struct, System.Enum
        {
            foreach (Code<T> item in items)
            {
                // Check if the serialization is canceled before continuing
                // through the collection
                if (cancellationToken.IsCancellationRequested)
                    return;
                Write(item, writer, propName, cancellationToken);
            }
        }

        public static void Write(string rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (!string.IsNullOrEmpty(rawValue))
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, rawValue);
                // writer.WriteEndElement();
            }
        }
        public static void Write(int? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Write(decimal? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Write(bool? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Write(DateTimeOffset? rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue.HasValue)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, PrimitiveTypeConverter.ConvertTo<string>(rawValue));
                // writer.WriteEndElement();
            }
        }
        public static void Write<T>(Code<T> rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
             where T : struct, Enum
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
        public static void Write(byte[] rawValue, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            if (rawValue?.Length > 0)
            {
                // writer.WriteStartElement(propertyName, XmlNs.FHIR);
                writer.WriteAttributeString(propertyName, System.Convert.ToBase64String(rawValue));
                // writer.WriteEndElement();
            }
        }
    }
}
