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
		private void Parse(CatalogEntry result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 100
							break;
						case "orderable":
							result.OrderableElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.OrderableElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".orderable"); // 110
							break;
						case "referencedItem":
							result.ReferencedItem = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ReferencedItem as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".referencedItem"); // 120
							break;
						case "additionalIdentifier":
							var newItem_additionalIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_additionalIdentifier, reader, outcome, locationPath + ".additionalIdentifier["+result.AdditionalIdentifier.Count+"]"); // 130
							result.AdditionalIdentifier.Add(newItem_additionalIdentifier);
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]"); // 140
							result.Classification.Add(newItem_classification);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "validityPeriod":
							result.ValidityPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.ValidityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".validityPeriod"); // 160
							break;
						case "validTo":
							result.ValidToElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ValidToElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".validTo"); // 170
							break;
						case "lastUpdated":
							result.LastUpdatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.LastUpdatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".lastUpdated"); // 180
							break;
						case "additionalCharacteristic":
							var newItem_additionalCharacteristic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_additionalCharacteristic, reader, outcome, locationPath + ".additionalCharacteristic["+result.AdditionalCharacteristic.Count+"]"); // 190
							result.AdditionalCharacteristic.Add(newItem_additionalCharacteristic);
							break;
						case "additionalClassification":
							var newItem_additionalClassification = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_additionalClassification, reader, outcome, locationPath + ".additionalClassification["+result.AdditionalClassification.Count+"]"); // 200
							result.AdditionalClassification.Add(newItem_additionalClassification);
							break;
						case "relatedEntry":
							var newItem_relatedEntry = new Hl7.Fhir.Model.CatalogEntry.RelatedEntryComponent();
							Parse(newItem_relatedEntry, reader, outcome, locationPath + ".relatedEntry["+result.RelatedEntry.Count+"]"); // 210
							result.RelatedEntry.Add(newItem_relatedEntry);
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

		private async System.Threading.Tasks.Task ParseAsync(CatalogEntry result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 100
							break;
						case "orderable":
							result.OrderableElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.OrderableElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".orderable"); // 110
							break;
						case "referencedItem":
							result.ReferencedItem = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ReferencedItem as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".referencedItem"); // 120
							break;
						case "additionalIdentifier":
							var newItem_additionalIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_additionalIdentifier, reader, outcome, locationPath + ".additionalIdentifier["+result.AdditionalIdentifier.Count+"]"); // 130
							result.AdditionalIdentifier.Add(newItem_additionalIdentifier);
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]"); // 140
							result.Classification.Add(newItem_classification);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "validityPeriod":
							result.ValidityPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.ValidityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".validityPeriod"); // 160
							break;
						case "validTo":
							result.ValidToElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ValidToElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".validTo"); // 170
							break;
						case "lastUpdated":
							result.LastUpdatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.LastUpdatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".lastUpdated"); // 180
							break;
						case "additionalCharacteristic":
							var newItem_additionalCharacteristic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_additionalCharacteristic, reader, outcome, locationPath + ".additionalCharacteristic["+result.AdditionalCharacteristic.Count+"]"); // 190
							result.AdditionalCharacteristic.Add(newItem_additionalCharacteristic);
							break;
						case "additionalClassification":
							var newItem_additionalClassification = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_additionalClassification, reader, outcome, locationPath + ".additionalClassification["+result.AdditionalClassification.Count+"]"); // 200
							result.AdditionalClassification.Add(newItem_additionalClassification);
							break;
						case "relatedEntry":
							var newItem_relatedEntry = new Hl7.Fhir.Model.CatalogEntry.RelatedEntryComponent();
							await ParseAsync(newItem_relatedEntry, reader, outcome, locationPath + ".relatedEntry["+result.RelatedEntry.Count+"]"); // 210
							result.RelatedEntry.Add(newItem_relatedEntry);
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
