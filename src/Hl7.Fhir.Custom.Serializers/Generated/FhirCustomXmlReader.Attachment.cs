// -----------------------------------------------------------------------------
// GENERATED CODE - DO NOT EDIT
// -----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Hl7.Fhir.CustomSerializer
{
    public partial class FhirCustomXmlReader
    {
		public void Parse(Hl7.Fhir.Model.Attachment result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "contentType":
							result.ContentTypeElement = new Hl7.Fhir.Model.Code();
							Parse(result.ContentTypeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".contentType", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "data":
							result.DataElement = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.DataElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".data", cancellationToken); // 50
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".url", cancellationToken); // 60
							break;
						case "size":
							result.SizeElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.SizeElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".size", cancellationToken); // 70
							break;
						case "hash":
							result.HashElement = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.HashElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".hash", cancellationToken); // 80
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 90
							break;
						case "creation":
							result.CreationElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreationElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".creation", cancellationToken); // 100
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Attachment result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "contentType":
							result.ContentTypeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.ContentTypeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".contentType", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "data":
							result.DataElement = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.DataElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".data", cancellationToken); // 50
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".url", cancellationToken); // 60
							break;
						case "size":
							result.SizeElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.SizeElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".size", cancellationToken); // 70
							break;
						case "hash":
							result.HashElement = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.HashElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".hash", cancellationToken); // 80
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 90
							break;
						case "creation":
							result.CreationElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreationElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".creation", cancellationToken); // 100
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}
	}
}
