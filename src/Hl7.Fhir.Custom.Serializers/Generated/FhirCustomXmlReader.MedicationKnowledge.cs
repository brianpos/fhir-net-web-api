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
		private void Parse(MedicationKnowledge result, XmlReader reader, OperationOutcome outcome)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>, reader, outcome); // 100
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "doseForm":
							result.DoseForm = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Amount as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 130
							break;
						case "synonym":
							var newItem_synonym = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_synonym, reader, outcome); // 140
							result.SynonymElement.Add(newItem_synonym);
							break;
						case "relatedMedicationKnowledge":
							var newItem_relatedMedicationKnowledge = new Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent();
							Parse(newItem_relatedMedicationKnowledge, reader, outcome); // 150
							result.RelatedMedicationKnowledge.Add(newItem_relatedMedicationKnowledge);
							break;
						case "associatedMedication":
							var newItem_associatedMedication = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_associatedMedication, reader, outcome); // 160
							result.AssociatedMedication.Add(newItem_associatedMedication);
							break;
						case "productType":
							var newItem_productType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_productType, reader, outcome); // 170
							result.ProductType.Add(newItem_productType);
							break;
						case "monograph":
							var newItem_monograph = new Hl7.Fhir.Model.MedicationKnowledge.MonographComponent();
							Parse(newItem_monograph, reader, outcome); // 180
							result.Monograph.Add(newItem_monograph);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent();
							Parse(newItem_ingredient, reader, outcome); // 190
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "preparationInstruction":
							result.PreparationInstruction = new Hl7.Fhir.Model.Markdown();
							Parse(result.PreparationInstruction as Hl7.Fhir.Model.Markdown, reader, outcome); // 200
							break;
						case "intendedRoute":
							var newItem_intendedRoute = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_intendedRoute, reader, outcome); // 210
							result.IntendedRoute.Add(newItem_intendedRoute);
							break;
						case "cost":
							var newItem_cost = new Hl7.Fhir.Model.MedicationKnowledge.CostComponent();
							Parse(newItem_cost, reader, outcome); // 220
							result.Cost.Add(newItem_cost);
							break;
						case "monitoringProgram":
							var newItem_monitoringProgram = new Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent();
							Parse(newItem_monitoringProgram, reader, outcome); // 230
							result.MonitoringProgram.Add(newItem_monitoringProgram);
							break;
						case "administrationGuidelines":
							var newItem_administrationGuidelines = new Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent();
							Parse(newItem_administrationGuidelines, reader, outcome); // 240
							result.AdministrationGuidelines.Add(newItem_administrationGuidelines);
							break;
						case "medicineClassification":
							var newItem_medicineClassification = new Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent();
							Parse(newItem_medicineClassification, reader, outcome); // 250
							result.MedicineClassification.Add(newItem_medicineClassification);
							break;
						case "packaging":
							result.Packaging = new Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent();
							Parse(result.Packaging as Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent, reader, outcome); // 260
							break;
						case "drugCharacteristic":
							var newItem_drugCharacteristic = new Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent();
							Parse(newItem_drugCharacteristic, reader, outcome); // 270
							result.DrugCharacteristic.Add(newItem_drugCharacteristic);
							break;
						case "contraindication":
							var newItem_contraindication = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_contraindication, reader, outcome); // 280
							result.Contraindication.Add(newItem_contraindication);
							break;
						case "regulatory":
							var newItem_regulatory = new Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent();
							Parse(newItem_regulatory, reader, outcome); // 290
							result.Regulatory.Add(newItem_regulatory);
							break;
						case "kinetics":
							var newItem_kinetics = new Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent();
							Parse(newItem_kinetics, reader, outcome); // 300
							result.Kinetics.Add(newItem_kinetics);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicationKnowledge result, XmlReader reader, OperationOutcome outcome)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>, reader, outcome); // 100
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "doseForm":
							result.DoseForm = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 130
							break;
						case "synonym":
							var newItem_synonym = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_synonym, reader, outcome); // 140
							result.SynonymElement.Add(newItem_synonym);
							break;
						case "relatedMedicationKnowledge":
							var newItem_relatedMedicationKnowledge = new Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent();
							await ParseAsync(newItem_relatedMedicationKnowledge, reader, outcome); // 150
							result.RelatedMedicationKnowledge.Add(newItem_relatedMedicationKnowledge);
							break;
						case "associatedMedication":
							var newItem_associatedMedication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_associatedMedication, reader, outcome); // 160
							result.AssociatedMedication.Add(newItem_associatedMedication);
							break;
						case "productType":
							var newItem_productType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_productType, reader, outcome); // 170
							result.ProductType.Add(newItem_productType);
							break;
						case "monograph":
							var newItem_monograph = new Hl7.Fhir.Model.MedicationKnowledge.MonographComponent();
							await ParseAsync(newItem_monograph, reader, outcome); // 180
							result.Monograph.Add(newItem_monograph);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent();
							await ParseAsync(newItem_ingredient, reader, outcome); // 190
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "preparationInstruction":
							result.PreparationInstruction = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.PreparationInstruction as Hl7.Fhir.Model.Markdown, reader, outcome); // 200
							break;
						case "intendedRoute":
							var newItem_intendedRoute = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_intendedRoute, reader, outcome); // 210
							result.IntendedRoute.Add(newItem_intendedRoute);
							break;
						case "cost":
							var newItem_cost = new Hl7.Fhir.Model.MedicationKnowledge.CostComponent();
							await ParseAsync(newItem_cost, reader, outcome); // 220
							result.Cost.Add(newItem_cost);
							break;
						case "monitoringProgram":
							var newItem_monitoringProgram = new Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent();
							await ParseAsync(newItem_monitoringProgram, reader, outcome); // 230
							result.MonitoringProgram.Add(newItem_monitoringProgram);
							break;
						case "administrationGuidelines":
							var newItem_administrationGuidelines = new Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent();
							await ParseAsync(newItem_administrationGuidelines, reader, outcome); // 240
							result.AdministrationGuidelines.Add(newItem_administrationGuidelines);
							break;
						case "medicineClassification":
							var newItem_medicineClassification = new Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent();
							await ParseAsync(newItem_medicineClassification, reader, outcome); // 250
							result.MedicineClassification.Add(newItem_medicineClassification);
							break;
						case "packaging":
							result.Packaging = new Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent();
							await ParseAsync(result.Packaging as Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent, reader, outcome); // 260
							break;
						case "drugCharacteristic":
							var newItem_drugCharacteristic = new Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent();
							await ParseAsync(newItem_drugCharacteristic, reader, outcome); // 270
							result.DrugCharacteristic.Add(newItem_drugCharacteristic);
							break;
						case "contraindication":
							var newItem_contraindication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_contraindication, reader, outcome); // 280
							result.Contraindication.Add(newItem_contraindication);
							break;
						case "regulatory":
							var newItem_regulatory = new Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent();
							await ParseAsync(newItem_regulatory, reader, outcome); // 290
							result.Regulatory.Add(newItem_regulatory);
							break;
						case "kinetics":
							var newItem_kinetics = new Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent();
							await ParseAsync(newItem_kinetics, reader, outcome); // 300
							result.Kinetics.Add(newItem_kinetics);
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
