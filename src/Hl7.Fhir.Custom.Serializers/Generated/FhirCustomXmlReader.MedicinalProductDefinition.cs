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
		private void Parse(MedicinalProductDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Domain as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".domain", cancellationToken); // 110
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 120
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".statusDate", cancellationToken); // 140
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 150
							break;
						case "combinedPharmaceuticalDoseForm":
							result.CombinedPharmaceuticalDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CombinedPharmaceuticalDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".combinedPharmaceuticalDoseForm", cancellationToken); // 160
							break;
						case "route":
							var newItem_route = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_route, reader, outcome, locationPath + ".route["+result.Route.Count+"]", cancellationToken); // 170
							result.Route.Add(newItem_route);
							break;
						case "indication":
							result.Indication = new Hl7.Fhir.Model.Markdown();
							Parse(result.Indication as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".indication", cancellationToken); // 180
							break;
						case "legalStatusOfSupply":
							result.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.LegalStatusOfSupply as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalStatusOfSupply", cancellationToken); // 190
							break;
						case "additionalMonitoringIndicator":
							result.AdditionalMonitoringIndicator = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AdditionalMonitoringIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".additionalMonitoringIndicator", cancellationToken); // 200
							break;
						case "specialMeasures":
							var newItem_specialMeasures = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialMeasures, reader, outcome, locationPath + ".specialMeasures["+result.SpecialMeasures.Count+"]", cancellationToken); // 210
							result.SpecialMeasures.Add(newItem_specialMeasures);
							break;
						case "pediatricUseIndicator":
							result.PediatricUseIndicator = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PediatricUseIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".pediatricUseIndicator", cancellationToken); // 220
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]", cancellationToken); // 230
							result.Classification.Add(newItem_classification);
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							Parse(newItem_marketingStatus, reader, outcome, locationPath + ".marketingStatus["+result.MarketingStatus.Count+"]", cancellationToken); // 240
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "packagedMedicinalProduct":
							var newItem_packagedMedicinalProduct = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_packagedMedicinalProduct, reader, outcome, locationPath + ".packagedMedicinalProduct["+result.PackagedMedicinalProduct.Count+"]", cancellationToken); // 250
							result.PackagedMedicinalProduct.Add(newItem_packagedMedicinalProduct);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 260
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "impurity":
							var newItem_impurity = new Hl7.Fhir.Model.CodeableReference();
							Parse(newItem_impurity, reader, outcome, locationPath + ".impurity["+result.Impurity.Count+"]", cancellationToken); // 270
							result.Impurity.Add(newItem_impurity);
							break;
						case "attachedDocument":
							var newItem_attachedDocument = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_attachedDocument, reader, outcome, locationPath + ".attachedDocument["+result.AttachedDocument.Count+"]", cancellationToken); // 280
							result.AttachedDocument.Add(newItem_attachedDocument);
							break;
						case "masterFile":
							var newItem_masterFile = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_masterFile, reader, outcome, locationPath + ".masterFile["+result.MasterFile.Count+"]", cancellationToken); // 290
							result.MasterFile.Add(newItem_masterFile);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.MedicinalProductDefinition.ContactComponent();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 300
							result.Contact.Add(newItem_contact);
							break;
						case "clinicalTrial":
							var newItem_clinicalTrial = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_clinicalTrial, reader, outcome, locationPath + ".clinicalTrial["+result.ClinicalTrial.Count+"]", cancellationToken); // 310
							result.ClinicalTrial.Add(newItem_clinicalTrial);
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							Parse(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 320
							result.Code.Add(newItem_code);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.MedicinalProductDefinition.NameComponent();
							Parse(newItem_name, reader, outcome, locationPath + ".name["+result.Name.Count+"]", cancellationToken); // 330
							result.Name.Add(newItem_name);
							break;
						case "crossReference":
							var newItem_crossReference = new Hl7.Fhir.Model.MedicinalProductDefinition.CrossReferenceComponent();
							Parse(newItem_crossReference, reader, outcome, locationPath + ".crossReference["+result.CrossReference.Count+"]", cancellationToken); // 340
							result.CrossReference.Add(newItem_crossReference);
							break;
						case "operation":
							var newItem_operation = new Hl7.Fhir.Model.MedicinalProductDefinition.OperationComponent();
							Parse(newItem_operation, reader, outcome, locationPath + ".operation["+result.Operation.Count+"]", cancellationToken); // 350
							result.Operation.Add(newItem_operation);
							break;
						case "characteristic":
							var newItem_characteristic = new Hl7.Fhir.Model.MedicinalProductDefinition.CharacteristicComponent();
							Parse(newItem_characteristic, reader, outcome, locationPath + ".characteristic["+result.Characteristic.Count+"]", cancellationToken); // 360
							result.Characteristic.Add(newItem_characteristic);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProductDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Domain as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".domain", cancellationToken); // 110
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 120
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".statusDate", cancellationToken); // 140
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 150
							break;
						case "combinedPharmaceuticalDoseForm":
							result.CombinedPharmaceuticalDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CombinedPharmaceuticalDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".combinedPharmaceuticalDoseForm", cancellationToken); // 160
							break;
						case "route":
							var newItem_route = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_route, reader, outcome, locationPath + ".route["+result.Route.Count+"]", cancellationToken); // 170
							result.Route.Add(newItem_route);
							break;
						case "indication":
							result.Indication = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Indication as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".indication", cancellationToken); // 180
							break;
						case "legalStatusOfSupply":
							result.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.LegalStatusOfSupply as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalStatusOfSupply", cancellationToken); // 190
							break;
						case "additionalMonitoringIndicator":
							result.AdditionalMonitoringIndicator = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AdditionalMonitoringIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".additionalMonitoringIndicator", cancellationToken); // 200
							break;
						case "specialMeasures":
							var newItem_specialMeasures = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialMeasures, reader, outcome, locationPath + ".specialMeasures["+result.SpecialMeasures.Count+"]", cancellationToken); // 210
							result.SpecialMeasures.Add(newItem_specialMeasures);
							break;
						case "pediatricUseIndicator":
							result.PediatricUseIndicator = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PediatricUseIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".pediatricUseIndicator", cancellationToken); // 220
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]", cancellationToken); // 230
							result.Classification.Add(newItem_classification);
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							await ParseAsync(newItem_marketingStatus, reader, outcome, locationPath + ".marketingStatus["+result.MarketingStatus.Count+"]", cancellationToken); // 240
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "packagedMedicinalProduct":
							var newItem_packagedMedicinalProduct = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_packagedMedicinalProduct, reader, outcome, locationPath + ".packagedMedicinalProduct["+result.PackagedMedicinalProduct.Count+"]", cancellationToken); // 250
							result.PackagedMedicinalProduct.Add(newItem_packagedMedicinalProduct);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 260
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "impurity":
							var newItem_impurity = new Hl7.Fhir.Model.CodeableReference();
							await ParseAsync(newItem_impurity, reader, outcome, locationPath + ".impurity["+result.Impurity.Count+"]", cancellationToken); // 270
							result.Impurity.Add(newItem_impurity);
							break;
						case "attachedDocument":
							var newItem_attachedDocument = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_attachedDocument, reader, outcome, locationPath + ".attachedDocument["+result.AttachedDocument.Count+"]", cancellationToken); // 280
							result.AttachedDocument.Add(newItem_attachedDocument);
							break;
						case "masterFile":
							var newItem_masterFile = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_masterFile, reader, outcome, locationPath + ".masterFile["+result.MasterFile.Count+"]", cancellationToken); // 290
							result.MasterFile.Add(newItem_masterFile);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.MedicinalProductDefinition.ContactComponent();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 300
							result.Contact.Add(newItem_contact);
							break;
						case "clinicalTrial":
							var newItem_clinicalTrial = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_clinicalTrial, reader, outcome, locationPath + ".clinicalTrial["+result.ClinicalTrial.Count+"]", cancellationToken); // 310
							result.ClinicalTrial.Add(newItem_clinicalTrial);
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 320
							result.Code.Add(newItem_code);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.MedicinalProductDefinition.NameComponent();
							await ParseAsync(newItem_name, reader, outcome, locationPath + ".name["+result.Name.Count+"]", cancellationToken); // 330
							result.Name.Add(newItem_name);
							break;
						case "crossReference":
							var newItem_crossReference = new Hl7.Fhir.Model.MedicinalProductDefinition.CrossReferenceComponent();
							await ParseAsync(newItem_crossReference, reader, outcome, locationPath + ".crossReference["+result.CrossReference.Count+"]", cancellationToken); // 340
							result.CrossReference.Add(newItem_crossReference);
							break;
						case "operation":
							var newItem_operation = new Hl7.Fhir.Model.MedicinalProductDefinition.OperationComponent();
							await ParseAsync(newItem_operation, reader, outcome, locationPath + ".operation["+result.Operation.Count+"]", cancellationToken); // 350
							result.Operation.Add(newItem_operation);
							break;
						case "characteristic":
							var newItem_characteristic = new Hl7.Fhir.Model.MedicinalProductDefinition.CharacteristicComponent();
							await ParseAsync(newItem_characteristic, reader, outcome, locationPath + ".characteristic["+result.Characteristic.Count+"]", cancellationToken); // 360
							result.Characteristic.Add(newItem_characteristic);
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
