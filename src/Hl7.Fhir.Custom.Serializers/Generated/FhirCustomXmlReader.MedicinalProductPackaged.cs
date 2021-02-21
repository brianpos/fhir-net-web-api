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
		private void Parse(MedicinalProductPackaged result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]"); // 100
							result.Subject.Add(newItem_subject);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 110
							break;
						case "legalStatusOfSupply":
							result.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.LegalStatusOfSupply as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalStatusOfSupply"); // 120
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							Parse(newItem_marketingStatus, reader, outcome, locationPath + ".marketingStatus["+result.MarketingStatus.Count+"]"); // 130
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "marketingAuthorization":
							result.MarketingAuthorization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.MarketingAuthorization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".marketingAuthorization"); // 140
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]"); // 150
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "batchIdentifier":
							var newItem_batchIdentifier = new Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent();
							Parse(newItem_batchIdentifier, reader, outcome, locationPath + ".batchIdentifier["+result.BatchIdentifier.Count+"]"); // 160
							result.BatchIdentifier.Add(newItem_batchIdentifier);
							break;
						case "packageItem":
							var newItem_packageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
							Parse(newItem_packageItem, reader, outcome, locationPath + ".packageItem["+result.PackageItem.Count+"]"); // 170
							result.PackageItem.Add(newItem_packageItem);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProductPackaged result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]"); // 100
							result.Subject.Add(newItem_subject);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 110
							break;
						case "legalStatusOfSupply":
							result.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.LegalStatusOfSupply as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalStatusOfSupply"); // 120
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							await ParseAsync(newItem_marketingStatus, reader, outcome, locationPath + ".marketingStatus["+result.MarketingStatus.Count+"]"); // 130
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "marketingAuthorization":
							result.MarketingAuthorization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.MarketingAuthorization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".marketingAuthorization"); // 140
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]"); // 150
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "batchIdentifier":
							var newItem_batchIdentifier = new Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent();
							await ParseAsync(newItem_batchIdentifier, reader, outcome, locationPath + ".batchIdentifier["+result.BatchIdentifier.Count+"]"); // 160
							result.BatchIdentifier.Add(newItem_batchIdentifier);
							break;
						case "packageItem":
							var newItem_packageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
							await ParseAsync(newItem_packageItem, reader, outcome, locationPath + ".packageItem["+result.PackageItem.Count+"]"); // 170
							result.PackageItem.Add(newItem_packageItem);
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
