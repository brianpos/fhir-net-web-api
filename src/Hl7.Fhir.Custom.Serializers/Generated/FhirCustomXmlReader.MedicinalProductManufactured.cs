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
		private void Parse(MedicinalProductManufactured result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "manufacturedDoseForm":
							result.ManufacturedDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ManufacturedDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "unitOfPresentation":
							result.UnitOfPresentation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.UnitOfPresentation as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 110
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome); // 120
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_ingredient, reader, outcome); // 130
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							Parse(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome); // 140
							break;
						case "otherCharacteristics":
							var newItem_otherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_otherCharacteristics, reader, outcome); // 150
							result.OtherCharacteristics.Add(newItem_otherCharacteristics);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProductManufactured result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "manufacturedDoseForm":
							result.ManufacturedDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ManufacturedDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "unitOfPresentation":
							result.UnitOfPresentation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.UnitOfPresentation as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 110
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome); // 120
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_ingredient, reader, outcome); // 130
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							await ParseAsync(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome); // 140
							break;
						case "otherCharacteristics":
							var newItem_otherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_otherCharacteristics, reader, outcome); // 150
							result.OtherCharacteristics.Add(newItem_otherCharacteristics);
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
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
