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
		private void Parse(MedicinalProduct result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.Coding();
							Parse(result.Domain as Hl7.Fhir.Model.Coding, reader, outcome); // 110
							break;
						case "combinedPharmaceuticalDoseForm":
							result.CombinedPharmaceuticalDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CombinedPharmaceuticalDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "legalStatusOfSupply":
							result.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.LegalStatusOfSupply as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "additionalMonitoringIndicator":
							result.AdditionalMonitoringIndicator = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AdditionalMonitoringIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "specialMeasures":
							var newItem_specialMeasures = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_specialMeasures, reader, outcome); // 150
							result.SpecialMeasuresElement.Add(newItem_specialMeasures);
							break;
						case "paediatricUseIndicator":
							result.PaediatricUseIndicator = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PaediatricUseIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "productClassification":
							var newItem_productClassification = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_productClassification, reader, outcome); // 170
							result.ProductClassification.Add(newItem_productClassification);
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							Parse(newItem_marketingStatus, reader, outcome); // 180
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "pharmaceuticalProduct":
							var newItem_pharmaceuticalProduct = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_pharmaceuticalProduct, reader, outcome); // 190
							result.PharmaceuticalProduct.Add(newItem_pharmaceuticalProduct);
							break;
						case "packagedMedicinalProduct":
							var newItem_packagedMedicinalProduct = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_packagedMedicinalProduct, reader, outcome); // 200
							result.PackagedMedicinalProduct.Add(newItem_packagedMedicinalProduct);
							break;
						case "attachedDocument":
							var newItem_attachedDocument = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_attachedDocument, reader, outcome); // 210
							result.AttachedDocument.Add(newItem_attachedDocument);
							break;
						case "masterFile":
							var newItem_masterFile = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_masterFile, reader, outcome); // 220
							result.MasterFile.Add(newItem_masterFile);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_contact, reader, outcome); // 230
							result.Contact.Add(newItem_contact);
							break;
						case "clinicalTrial":
							var newItem_clinicalTrial = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_clinicalTrial, reader, outcome); // 240
							result.ClinicalTrial.Add(newItem_clinicalTrial);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.MedicinalProduct.NameComponent();
							Parse(newItem_name, reader, outcome); // 250
							result.Name.Add(newItem_name);
							break;
						case "crossReference":
							var newItem_crossReference = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_crossReference, reader, outcome); // 260
							result.CrossReference.Add(newItem_crossReference);
							break;
						case "manufacturingBusinessOperation":
							var newItem_manufacturingBusinessOperation = new Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent();
							Parse(newItem_manufacturingBusinessOperation, reader, outcome); // 270
							result.ManufacturingBusinessOperation.Add(newItem_manufacturingBusinessOperation);
							break;
						case "specialDesignation":
							var newItem_specialDesignation = new Hl7.Fhir.Model.MedicinalProduct.SpecialDesignationComponent();
							Parse(newItem_specialDesignation, reader, outcome); // 280
							result.SpecialDesignation.Add(newItem_specialDesignation);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProduct result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Domain as Hl7.Fhir.Model.Coding, reader, outcome); // 110
							break;
						case "combinedPharmaceuticalDoseForm":
							result.CombinedPharmaceuticalDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CombinedPharmaceuticalDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "legalStatusOfSupply":
							result.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.LegalStatusOfSupply as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "additionalMonitoringIndicator":
							result.AdditionalMonitoringIndicator = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AdditionalMonitoringIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "specialMeasures":
							var newItem_specialMeasures = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_specialMeasures, reader, outcome); // 150
							result.SpecialMeasuresElement.Add(newItem_specialMeasures);
							break;
						case "paediatricUseIndicator":
							result.PaediatricUseIndicator = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PaediatricUseIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "productClassification":
							var newItem_productClassification = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_productClassification, reader, outcome); // 170
							result.ProductClassification.Add(newItem_productClassification);
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							await ParseAsync(newItem_marketingStatus, reader, outcome); // 180
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "pharmaceuticalProduct":
							var newItem_pharmaceuticalProduct = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_pharmaceuticalProduct, reader, outcome); // 190
							result.PharmaceuticalProduct.Add(newItem_pharmaceuticalProduct);
							break;
						case "packagedMedicinalProduct":
							var newItem_packagedMedicinalProduct = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_packagedMedicinalProduct, reader, outcome); // 200
							result.PackagedMedicinalProduct.Add(newItem_packagedMedicinalProduct);
							break;
						case "attachedDocument":
							var newItem_attachedDocument = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_attachedDocument, reader, outcome); // 210
							result.AttachedDocument.Add(newItem_attachedDocument);
							break;
						case "masterFile":
							var newItem_masterFile = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_masterFile, reader, outcome); // 220
							result.MasterFile.Add(newItem_masterFile);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_contact, reader, outcome); // 230
							result.Contact.Add(newItem_contact);
							break;
						case "clinicalTrial":
							var newItem_clinicalTrial = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_clinicalTrial, reader, outcome); // 240
							result.ClinicalTrial.Add(newItem_clinicalTrial);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.MedicinalProduct.NameComponent();
							await ParseAsync(newItem_name, reader, outcome); // 250
							result.Name.Add(newItem_name);
							break;
						case "crossReference":
							var newItem_crossReference = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_crossReference, reader, outcome); // 260
							result.CrossReference.Add(newItem_crossReference);
							break;
						case "manufacturingBusinessOperation":
							var newItem_manufacturingBusinessOperation = new Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent();
							await ParseAsync(newItem_manufacturingBusinessOperation, reader, outcome); // 270
							result.ManufacturingBusinessOperation.Add(newItem_manufacturingBusinessOperation);
							break;
						case "specialDesignation":
							var newItem_specialDesignation = new Hl7.Fhir.Model.MedicinalProduct.SpecialDesignationComponent();
							await ParseAsync(newItem_specialDesignation, reader, outcome); // 280
							result.SpecialDesignation.Add(newItem_specialDesignation);
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
