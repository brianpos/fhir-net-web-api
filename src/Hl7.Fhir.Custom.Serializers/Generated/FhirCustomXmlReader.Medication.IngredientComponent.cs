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
		public void Parse(Hl7.Fhir.Model.Medication.IngredientComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
			{
				// contextLocation.Pop();
				return;
			}

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
						case "itemCodeableConcept":
							result.Item = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Item as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".item"); // 40
							break;
						case "itemReference":
							result.Item = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Item as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".item"); // 40
							break;
						case "isActive":
							result.IsActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isActive"); // 50
							break;
						case "strength":
							result.Strength = new Hl7.Fhir.Model.Ratio();
							Parse(result.Strength as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".strength"); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Medication.IngredientComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
			{
				// contextLocation.Pop();
				return;
			}

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
						case "itemCodeableConcept":
							result.Item = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Item as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".item"); // 40
							break;
						case "itemReference":
							result.Item = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Item as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".item"); // 40
							break;
						case "isActive":
							result.IsActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isActive"); // 50
							break;
						case "strength":
							result.Strength = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Strength as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".strength"); // 60
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
