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
		private void Parse(MedicationKnowledge result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".manufacturer", cancellationToken); // 110
							break;
						case "doseForm":
							result.DoseForm = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".doseForm", cancellationToken); // 120
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Amount as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".amount", cancellationToken); // 130
							break;
						case "synonym":
							var newItem_synonym = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_synonym, reader, outcome, locationPath + ".synonym["+result.SynonymElement.Count+"]", cancellationToken); // 140
							result.SynonymElement.Add(newItem_synonym);
							break;
						case "relatedMedicationKnowledge":
							var newItem_relatedMedicationKnowledge = new Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent();
							Parse(newItem_relatedMedicationKnowledge, reader, outcome, locationPath + ".relatedMedicationKnowledge["+result.RelatedMedicationKnowledge.Count+"]", cancellationToken); // 150
							result.RelatedMedicationKnowledge.Add(newItem_relatedMedicationKnowledge);
							break;
						case "associatedMedication":
							var newItem_associatedMedication = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_associatedMedication, reader, outcome, locationPath + ".associatedMedication["+result.AssociatedMedication.Count+"]", cancellationToken); // 160
							result.AssociatedMedication.Add(newItem_associatedMedication);
							break;
						case "productType":
							var newItem_productType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_productType, reader, outcome, locationPath + ".productType["+result.ProductType.Count+"]", cancellationToken); // 170
							result.ProductType.Add(newItem_productType);
							break;
						case "monograph":
							var newItem_monograph = new Hl7.Fhir.Model.MedicationKnowledge.MonographComponent();
							Parse(newItem_monograph, reader, outcome, locationPath + ".monograph["+result.Monograph.Count+"]", cancellationToken); // 180
							result.Monograph.Add(newItem_monograph);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent();
							Parse(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 190
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "preparationInstruction":
							result.PreparationInstruction = new Hl7.Fhir.Model.Markdown();
							Parse(result.PreparationInstruction as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".preparationInstruction", cancellationToken); // 200
							break;
						case "intendedRoute":
							var newItem_intendedRoute = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_intendedRoute, reader, outcome, locationPath + ".intendedRoute["+result.IntendedRoute.Count+"]", cancellationToken); // 210
							result.IntendedRoute.Add(newItem_intendedRoute);
							break;
						case "cost":
							var newItem_cost = new Hl7.Fhir.Model.MedicationKnowledge.CostComponent();
							Parse(newItem_cost, reader, outcome, locationPath + ".cost["+result.Cost.Count+"]", cancellationToken); // 220
							result.Cost.Add(newItem_cost);
							break;
						case "monitoringProgram":
							var newItem_monitoringProgram = new Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent();
							Parse(newItem_monitoringProgram, reader, outcome, locationPath + ".monitoringProgram["+result.MonitoringProgram.Count+"]", cancellationToken); // 230
							result.MonitoringProgram.Add(newItem_monitoringProgram);
							break;
						case "administrationGuidelines":
							var newItem_administrationGuidelines = new Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent();
							Parse(newItem_administrationGuidelines, reader, outcome, locationPath + ".administrationGuidelines["+result.AdministrationGuidelines.Count+"]", cancellationToken); // 240
							result.AdministrationGuidelines.Add(newItem_administrationGuidelines);
							break;
						case "medicineClassification":
							var newItem_medicineClassification = new Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent();
							Parse(newItem_medicineClassification, reader, outcome, locationPath + ".medicineClassification["+result.MedicineClassification.Count+"]", cancellationToken); // 250
							result.MedicineClassification.Add(newItem_medicineClassification);
							break;
						case "packaging":
							result.Packaging = new Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent();
							Parse(result.Packaging as Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent, reader, outcome, locationPath + ".packaging", cancellationToken); // 260
							break;
						case "drugCharacteristic":
							var newItem_drugCharacteristic = new Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent();
							Parse(newItem_drugCharacteristic, reader, outcome, locationPath + ".drugCharacteristic["+result.DrugCharacteristic.Count+"]", cancellationToken); // 270
							result.DrugCharacteristic.Add(newItem_drugCharacteristic);
							break;
						case "contraindication":
							var newItem_contraindication = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_contraindication, reader, outcome, locationPath + ".contraindication["+result.Contraindication.Count+"]", cancellationToken); // 280
							result.Contraindication.Add(newItem_contraindication);
							break;
						case "regulatory":
							var newItem_regulatory = new Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent();
							Parse(newItem_regulatory, reader, outcome, locationPath + ".regulatory["+result.Regulatory.Count+"]", cancellationToken); // 290
							result.Regulatory.Add(newItem_regulatory);
							break;
						case "kinetics":
							var newItem_kinetics = new Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent();
							Parse(newItem_kinetics, reader, outcome, locationPath + ".kinetics["+result.Kinetics.Count+"]", cancellationToken); // 300
							result.Kinetics.Add(newItem_kinetics);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicationKnowledge result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".manufacturer", cancellationToken); // 110
							break;
						case "doseForm":
							result.DoseForm = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".doseForm", cancellationToken); // 120
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".amount", cancellationToken); // 130
							break;
						case "synonym":
							var newItem_synonym = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_synonym, reader, outcome, locationPath + ".synonym["+result.SynonymElement.Count+"]", cancellationToken); // 140
							result.SynonymElement.Add(newItem_synonym);
							break;
						case "relatedMedicationKnowledge":
							var newItem_relatedMedicationKnowledge = new Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent();
							await ParseAsync(newItem_relatedMedicationKnowledge, reader, outcome, locationPath + ".relatedMedicationKnowledge["+result.RelatedMedicationKnowledge.Count+"]", cancellationToken); // 150
							result.RelatedMedicationKnowledge.Add(newItem_relatedMedicationKnowledge);
							break;
						case "associatedMedication":
							var newItem_associatedMedication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_associatedMedication, reader, outcome, locationPath + ".associatedMedication["+result.AssociatedMedication.Count+"]", cancellationToken); // 160
							result.AssociatedMedication.Add(newItem_associatedMedication);
							break;
						case "productType":
							var newItem_productType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_productType, reader, outcome, locationPath + ".productType["+result.ProductType.Count+"]", cancellationToken); // 170
							result.ProductType.Add(newItem_productType);
							break;
						case "monograph":
							var newItem_monograph = new Hl7.Fhir.Model.MedicationKnowledge.MonographComponent();
							await ParseAsync(newItem_monograph, reader, outcome, locationPath + ".monograph["+result.Monograph.Count+"]", cancellationToken); // 180
							result.Monograph.Add(newItem_monograph);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent();
							await ParseAsync(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 190
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "preparationInstruction":
							result.PreparationInstruction = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.PreparationInstruction as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".preparationInstruction", cancellationToken); // 200
							break;
						case "intendedRoute":
							var newItem_intendedRoute = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_intendedRoute, reader, outcome, locationPath + ".intendedRoute["+result.IntendedRoute.Count+"]", cancellationToken); // 210
							result.IntendedRoute.Add(newItem_intendedRoute);
							break;
						case "cost":
							var newItem_cost = new Hl7.Fhir.Model.MedicationKnowledge.CostComponent();
							await ParseAsync(newItem_cost, reader, outcome, locationPath + ".cost["+result.Cost.Count+"]", cancellationToken); // 220
							result.Cost.Add(newItem_cost);
							break;
						case "monitoringProgram":
							var newItem_monitoringProgram = new Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent();
							await ParseAsync(newItem_monitoringProgram, reader, outcome, locationPath + ".monitoringProgram["+result.MonitoringProgram.Count+"]", cancellationToken); // 230
							result.MonitoringProgram.Add(newItem_monitoringProgram);
							break;
						case "administrationGuidelines":
							var newItem_administrationGuidelines = new Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent();
							await ParseAsync(newItem_administrationGuidelines, reader, outcome, locationPath + ".administrationGuidelines["+result.AdministrationGuidelines.Count+"]", cancellationToken); // 240
							result.AdministrationGuidelines.Add(newItem_administrationGuidelines);
							break;
						case "medicineClassification":
							var newItem_medicineClassification = new Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent();
							await ParseAsync(newItem_medicineClassification, reader, outcome, locationPath + ".medicineClassification["+result.MedicineClassification.Count+"]", cancellationToken); // 250
							result.MedicineClassification.Add(newItem_medicineClassification);
							break;
						case "packaging":
							result.Packaging = new Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent();
							await ParseAsync(result.Packaging as Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent, reader, outcome, locationPath + ".packaging", cancellationToken); // 260
							break;
						case "drugCharacteristic":
							var newItem_drugCharacteristic = new Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent();
							await ParseAsync(newItem_drugCharacteristic, reader, outcome, locationPath + ".drugCharacteristic["+result.DrugCharacteristic.Count+"]", cancellationToken); // 270
							result.DrugCharacteristic.Add(newItem_drugCharacteristic);
							break;
						case "contraindication":
							var newItem_contraindication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_contraindication, reader, outcome, locationPath + ".contraindication["+result.Contraindication.Count+"]", cancellationToken); // 280
							result.Contraindication.Add(newItem_contraindication);
							break;
						case "regulatory":
							var newItem_regulatory = new Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent();
							await ParseAsync(newItem_regulatory, reader, outcome, locationPath + ".regulatory["+result.Regulatory.Count+"]", cancellationToken); // 290
							result.Regulatory.Add(newItem_regulatory);
							break;
						case "kinetics":
							var newItem_kinetics = new Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent();
							await ParseAsync(newItem_kinetics, reader, outcome, locationPath + ".kinetics["+result.Kinetics.Count+"]", cancellationToken); // 300
							result.Kinetics.Add(newItem_kinetics);
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
