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
		public void Parse(Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent result, XmlReader reader, OperationOutcome outcome)
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
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "material":
							result.Material = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Material as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "cap":
							result.Cap = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Cap as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "capacity":
							result.Capacity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Capacity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 80
							break;
						case "minimumVolumeQuantity":
							result.MinimumVolume = new Hl7.Fhir.Model.Quantity();
							Parse(result.MinimumVolume as Hl7.Fhir.Model.Quantity, reader, outcome); // 90
							break;
						case "minimumVolumeString":
							result.MinimumVolume = new Hl7.Fhir.Model.FhirString();
							Parse(result.MinimumVolume as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "additive":
							var newItem_additive = new Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent();
							Parse(newItem_additive, reader, outcome); // 100
							result.Additive.Add(newItem_additive);
							break;
						case "preparation":
							result.PreparationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PreparationElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent result, XmlReader reader, OperationOutcome outcome)
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
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "material":
							result.Material = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Material as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "cap":
							result.Cap = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Cap as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "capacity":
							result.Capacity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Capacity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 80
							break;
						case "minimumVolumeQuantity":
							result.MinimumVolume = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.MinimumVolume as Hl7.Fhir.Model.Quantity, reader, outcome); // 90
							break;
						case "minimumVolumeString":
							result.MinimumVolume = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MinimumVolume as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "additive":
							var newItem_additive = new Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent();
							await ParseAsync(newItem_additive, reader, outcome); // 100
							result.Additive.Add(newItem_additive);
							break;
						case "preparation":
							result.PreparationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PreparationElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
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
