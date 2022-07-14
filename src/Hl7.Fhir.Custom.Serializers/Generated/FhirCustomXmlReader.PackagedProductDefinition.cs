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
		private void Parse(PackagedProductDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 110
							break;
						case "packageFor":
							var newItem_packageFor = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_packageFor, reader, outcome, locationPath + ".packageFor["+result.PackageFor.Count+"]", cancellationToken); // 120
							result.PackageFor.Add(newItem_packageFor);
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".statusDate", cancellationToken); // 140
							break;
						case "containedItemQuantity":
							var newItem_containedItemQuantity = new Hl7.Fhir.Model.Quantity();
							Parse(newItem_containedItemQuantity, reader, outcome, locationPath + ".containedItemQuantity["+result.ContainedItemQuantity.Count+"]", cancellationToken); // 150
							result.ContainedItemQuantity.Add(newItem_containedItemQuantity);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 160
							break;
						case "legalStatusOfSupply":
							var newItem_legalStatusOfSupply = new Hl7.Fhir.Model.PackagedProductDefinition.LegalStatusOfSupplyComponent();
							Parse(newItem_legalStatusOfSupply, reader, outcome, locationPath + ".legalStatusOfSupply["+result.LegalStatusOfSupply.Count+"]", cancellationToken); // 170
							result.LegalStatusOfSupply.Add(newItem_legalStatusOfSupply);
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							Parse(newItem_marketingStatus, reader, outcome, locationPath + ".marketingStatus["+result.MarketingStatus.Count+"]", cancellationToken); // 180
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "characteristic":
							var newItem_characteristic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_characteristic, reader, outcome, locationPath + ".characteristic["+result.Characteristic.Count+"]", cancellationToken); // 190
							result.Characteristic.Add(newItem_characteristic);
							break;
						case "copackagedIndicator":
							result.CopackagedIndicatorElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.CopackagedIndicatorElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".copackagedIndicator", cancellationToken); // 200
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 210
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "package":
							result.Package = new Hl7.Fhir.Model.PackagedProductDefinition.PackageComponent();
							Parse(result.Package as Hl7.Fhir.Model.PackagedProductDefinition.PackageComponent, reader, outcome, locationPath + ".package", cancellationToken); // 220
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

		private async System.Threading.Tasks.Task ParseAsync(PackagedProductDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 110
							break;
						case "packageFor":
							var newItem_packageFor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_packageFor, reader, outcome, locationPath + ".packageFor["+result.PackageFor.Count+"]", cancellationToken); // 120
							result.PackageFor.Add(newItem_packageFor);
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".statusDate", cancellationToken); // 140
							break;
						case "containedItemQuantity":
							var newItem_containedItemQuantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(newItem_containedItemQuantity, reader, outcome, locationPath + ".containedItemQuantity["+result.ContainedItemQuantity.Count+"]", cancellationToken); // 150
							result.ContainedItemQuantity.Add(newItem_containedItemQuantity);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 160
							break;
						case "legalStatusOfSupply":
							var newItem_legalStatusOfSupply = new Hl7.Fhir.Model.PackagedProductDefinition.LegalStatusOfSupplyComponent();
							await ParseAsync(newItem_legalStatusOfSupply, reader, outcome, locationPath + ".legalStatusOfSupply["+result.LegalStatusOfSupply.Count+"]", cancellationToken); // 170
							result.LegalStatusOfSupply.Add(newItem_legalStatusOfSupply);
							break;
						case "marketingStatus":
							var newItem_marketingStatus = new Hl7.Fhir.Model.MarketingStatus();
							await ParseAsync(newItem_marketingStatus, reader, outcome, locationPath + ".marketingStatus["+result.MarketingStatus.Count+"]", cancellationToken); // 180
							result.MarketingStatus.Add(newItem_marketingStatus);
							break;
						case "characteristic":
							var newItem_characteristic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_characteristic, reader, outcome, locationPath + ".characteristic["+result.Characteristic.Count+"]", cancellationToken); // 190
							result.Characteristic.Add(newItem_characteristic);
							break;
						case "copackagedIndicator":
							result.CopackagedIndicatorElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.CopackagedIndicatorElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".copackagedIndicator", cancellationToken); // 200
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 210
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "package":
							result.Package = new Hl7.Fhir.Model.PackagedProductDefinition.PackageComponent();
							await ParseAsync(result.Package as Hl7.Fhir.Model.PackagedProductDefinition.PackageComponent, reader, outcome, locationPath + ".package", cancellationToken); // 220
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
