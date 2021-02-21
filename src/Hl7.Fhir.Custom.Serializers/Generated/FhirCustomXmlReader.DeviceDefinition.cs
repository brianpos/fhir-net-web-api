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
		private void Parse(DeviceDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "udiDeviceIdentifier":
							var newItem_udiDeviceIdentifier = new Hl7.Fhir.Model.DeviceDefinition.UdiDeviceIdentifierComponent();
							Parse(newItem_udiDeviceIdentifier, reader, outcome); // 100
							result.UdiDeviceIdentifier.Add(newItem_udiDeviceIdentifier);
							break;
						case "manufacturerString":
							result.Manufacturer = new Hl7.Fhir.Model.FhirString();
							Parse(result.Manufacturer as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "manufacturerReference":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "deviceName":
							var newItem_deviceName = new Hl7.Fhir.Model.DeviceDefinition.DeviceNameComponent();
							Parse(newItem_deviceName, reader, outcome); // 120
							result.DeviceName.Add(newItem_deviceName);
							break;
						case "modelNumber":
							result.ModelNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ModelNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "specialization":
							var newItem_specialization = new Hl7.Fhir.Model.DeviceDefinition.SpecializationComponent();
							Parse(newItem_specialization, reader, outcome); // 150
							result.Specialization.Add(newItem_specialization);
							break;
						case "version":
							var newItem_version = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_version, reader, outcome); // 160
							result.VersionElement.Add(newItem_version);
							break;
						case "safety":
							var newItem_safety = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_safety, reader, outcome); // 170
							result.Safety.Add(newItem_safety);
							break;
						case "shelfLifeStorage":
							var newItem_shelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
							Parse(newItem_shelfLifeStorage, reader, outcome); // 180
							result.ShelfLifeStorage.Add(newItem_shelfLifeStorage);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							Parse(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome); // 190
							break;
						case "languageCode":
							var newItem_languageCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_languageCode, reader, outcome); // 200
							result.LanguageCode.Add(newItem_languageCode);
							break;
						case "capability":
							var newItem_capability = new Hl7.Fhir.Model.DeviceDefinition.CapabilityComponent();
							Parse(newItem_capability, reader, outcome); // 210
							result.Capability.Add(newItem_capability);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.DeviceDefinition.PropertyComponent();
							Parse(newItem_property, reader, outcome); // 220
							result.Property.Add(newItem_property);
							break;
						case "owner":
							result.Owner = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Owner as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 230
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_contact, reader, outcome); // 240
							result.Contact.Add(newItem_contact);
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 250
							break;
						case "onlineInformation":
							result.OnlineInformationElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.OnlineInformationElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 260
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 270
							result.Note.Add(newItem_note);
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 280
							break;
						case "parentDevice":
							result.ParentDevice = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ParentDevice as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 290
							break;
						case "material":
							var newItem_material = new Hl7.Fhir.Model.DeviceDefinition.MaterialComponent();
							Parse(newItem_material, reader, outcome); // 300
							result.Material.Add(newItem_material);
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

		private async System.Threading.Tasks.Task ParseAsync(DeviceDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "udiDeviceIdentifier":
							var newItem_udiDeviceIdentifier = new Hl7.Fhir.Model.DeviceDefinition.UdiDeviceIdentifierComponent();
							await ParseAsync(newItem_udiDeviceIdentifier, reader, outcome); // 100
							result.UdiDeviceIdentifier.Add(newItem_udiDeviceIdentifier);
							break;
						case "manufacturerString":
							result.Manufacturer = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Manufacturer as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "manufacturerReference":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "deviceName":
							var newItem_deviceName = new Hl7.Fhir.Model.DeviceDefinition.DeviceNameComponent();
							await ParseAsync(newItem_deviceName, reader, outcome); // 120
							result.DeviceName.Add(newItem_deviceName);
							break;
						case "modelNumber":
							result.ModelNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ModelNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "specialization":
							var newItem_specialization = new Hl7.Fhir.Model.DeviceDefinition.SpecializationComponent();
							await ParseAsync(newItem_specialization, reader, outcome); // 150
							result.Specialization.Add(newItem_specialization);
							break;
						case "version":
							var newItem_version = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_version, reader, outcome); // 160
							result.VersionElement.Add(newItem_version);
							break;
						case "safety":
							var newItem_safety = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_safety, reader, outcome); // 170
							result.Safety.Add(newItem_safety);
							break;
						case "shelfLifeStorage":
							var newItem_shelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
							await ParseAsync(newItem_shelfLifeStorage, reader, outcome); // 180
							result.ShelfLifeStorage.Add(newItem_shelfLifeStorage);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							await ParseAsync(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome); // 190
							break;
						case "languageCode":
							var newItem_languageCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_languageCode, reader, outcome); // 200
							result.LanguageCode.Add(newItem_languageCode);
							break;
						case "capability":
							var newItem_capability = new Hl7.Fhir.Model.DeviceDefinition.CapabilityComponent();
							await ParseAsync(newItem_capability, reader, outcome); // 210
							result.Capability.Add(newItem_capability);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.DeviceDefinition.PropertyComponent();
							await ParseAsync(newItem_property, reader, outcome); // 220
							result.Property.Add(newItem_property);
							break;
						case "owner":
							result.Owner = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Owner as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 230
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_contact, reader, outcome); // 240
							result.Contact.Add(newItem_contact);
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 250
							break;
						case "onlineInformation":
							result.OnlineInformationElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.OnlineInformationElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 260
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 270
							result.Note.Add(newItem_note);
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 280
							break;
						case "parentDevice":
							result.ParentDevice = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ParentDevice as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 290
							break;
						case "material":
							var newItem_material = new Hl7.Fhir.Model.DeviceDefinition.MaterialComponent();
							await ParseAsync(newItem_material, reader, outcome); // 300
							result.Material.Add(newItem_material);
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
