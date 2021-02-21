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
		public void Parse(Hl7.Fhir.Model.Immunization.EducationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "documentType":
							result.DocumentTypeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DocumentTypeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentType"); // 40
							break;
						case "reference":
							result.ReferenceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ReferenceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".reference"); // 50
							break;
						case "publicationDate":
							result.PublicationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.PublicationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".publicationDate"); // 60
							break;
						case "presentationDate":
							result.PresentationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.PresentationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".presentationDate"); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Immunization.EducationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "documentType":
							result.DocumentTypeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DocumentTypeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentType"); // 40
							break;
						case "reference":
							result.ReferenceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ReferenceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".reference"); // 50
							break;
						case "publicationDate":
							result.PublicationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.PublicationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".publicationDate"); // 60
							break;
						case "presentationDate":
							result.PresentationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.PresentationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".presentationDate"); // 70
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
