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
		public void Parse(Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "baseFormulaType":
							result.BaseFormulaType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BaseFormulaType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".baseFormulaType"); // 40
							break;
						case "baseFormulaProductName":
							result.BaseFormulaProductNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.BaseFormulaProductNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".baseFormulaProductName"); // 50
							break;
						case "additiveType":
							result.AdditiveType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AdditiveType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".additiveType"); // 60
							break;
						case "additiveProductName":
							result.AdditiveProductNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AdditiveProductNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".additiveProductName"); // 70
							break;
						case "caloricDensity":
							result.CaloricDensity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.CaloricDensity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".caloricDensity"); // 80
							break;
						case "routeofAdministration":
							result.RouteofAdministration = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.RouteofAdministration as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".routeofAdministration"); // 90
							break;
						case "administration":
							var newItem_administration = new Hl7.Fhir.Model.NutritionOrder.AdministrationComponent();
							Parse(newItem_administration, reader, outcome, locationPath + ".administration["+result.Administration.Count+"]"); // 100
							result.Administration.Add(newItem_administration);
							break;
						case "maxVolumeToDeliver":
							result.MaxVolumeToDeliver = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.MaxVolumeToDeliver as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".maxVolumeToDeliver"); // 110
							break;
						case "administrationInstruction":
							result.AdministrationInstructionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AdministrationInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".administrationInstruction"); // 120
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "baseFormulaType":
							result.BaseFormulaType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BaseFormulaType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".baseFormulaType"); // 40
							break;
						case "baseFormulaProductName":
							result.BaseFormulaProductNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.BaseFormulaProductNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".baseFormulaProductName"); // 50
							break;
						case "additiveType":
							result.AdditiveType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AdditiveType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".additiveType"); // 60
							break;
						case "additiveProductName":
							result.AdditiveProductNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AdditiveProductNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".additiveProductName"); // 70
							break;
						case "caloricDensity":
							result.CaloricDensity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.CaloricDensity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".caloricDensity"); // 80
							break;
						case "routeofAdministration":
							result.RouteofAdministration = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.RouteofAdministration as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".routeofAdministration"); // 90
							break;
						case "administration":
							var newItem_administration = new Hl7.Fhir.Model.NutritionOrder.AdministrationComponent();
							await ParseAsync(newItem_administration, reader, outcome, locationPath + ".administration["+result.Administration.Count+"]"); // 100
							result.Administration.Add(newItem_administration);
							break;
						case "maxVolumeToDeliver":
							result.MaxVolumeToDeliver = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.MaxVolumeToDeliver as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".maxVolumeToDeliver"); // 110
							break;
						case "administrationInstruction":
							result.AdministrationInstructionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AdministrationInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".administrationInstruction"); // 120
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
