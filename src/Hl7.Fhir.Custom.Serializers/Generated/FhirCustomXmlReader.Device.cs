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
		private void Parse(Device result, XmlReader reader, OperationOutcome outcome)
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
						case "definition":
							result.Definition = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Definition as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 100
							break;
						case "udiCarrier":
							var newItem_udiCarrier = new Hl7.Fhir.Model.Device.UdiCarrierComponent();
							Parse(newItem_udiCarrier, reader, outcome); // 110
							result.UdiCarrier.Add(newItem_udiCarrier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Device.FHIRDeviceStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Device.FHIRDeviceStatus>, reader, outcome); // 120
							break;
						case "statusReason":
							var newItem_statusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_statusReason, reader, outcome); // 130
							result.StatusReason.Add(newItem_statusReason);
							break;
						case "distinctIdentifier":
							result.DistinctIdentifierElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DistinctIdentifierElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
							break;
						case "manufacturer":
							result.ManufacturerElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ManufacturerElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "manufactureDate":
							result.ManufactureDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ManufactureDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "expirationDate":
							result.ExpirationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ExpirationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "lotNumber":
							result.LotNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LotNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 180
							break;
						case "serialNumber":
							result.SerialNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SerialNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 190
							break;
						case "deviceName":
							var newItem_deviceName = new Hl7.Fhir.Model.Device.DeviceNameComponent();
							Parse(newItem_deviceName, reader, outcome); // 200
							result.DeviceName.Add(newItem_deviceName);
							break;
						case "modelNumber":
							result.ModelNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ModelNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "partNumber":
							result.PartNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PartNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 220
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 230
							break;
						case "specialization":
							var newItem_specialization = new Hl7.Fhir.Model.Device.SpecializationComponent();
							Parse(newItem_specialization, reader, outcome); // 240
							result.Specialization.Add(newItem_specialization);
							break;
						case "version":
							var newItem_version = new Hl7.Fhir.Model.Device.VersionComponent();
							Parse(newItem_version, reader, outcome); // 250
							result.Version.Add(newItem_version);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.Device.PropertyComponent();
							Parse(newItem_property, reader, outcome); // 260
							result.Property.Add(newItem_property);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "owner":
							result.Owner = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Owner as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 280
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_contact, reader, outcome); // 290
							result.Contact.Add(newItem_contact);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 310
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 320
							result.Note.Add(newItem_note);
							break;
						case "safety":
							var newItem_safety = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_safety, reader, outcome); // 330
							result.Safety.Add(newItem_safety);
							break;
						case "parent":
							result.Parent = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Parent as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 340
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

		private async System.Threading.Tasks.Task ParseAsync(Device result, XmlReader reader, OperationOutcome outcome)
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
						case "definition":
							result.Definition = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 100
							break;
						case "udiCarrier":
							var newItem_udiCarrier = new Hl7.Fhir.Model.Device.UdiCarrierComponent();
							await ParseAsync(newItem_udiCarrier, reader, outcome); // 110
							result.UdiCarrier.Add(newItem_udiCarrier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Device.FHIRDeviceStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Device.FHIRDeviceStatus>, reader, outcome); // 120
							break;
						case "statusReason":
							var newItem_statusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_statusReason, reader, outcome); // 130
							result.StatusReason.Add(newItem_statusReason);
							break;
						case "distinctIdentifier":
							result.DistinctIdentifierElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DistinctIdentifierElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
							break;
						case "manufacturer":
							result.ManufacturerElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ManufacturerElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "manufactureDate":
							result.ManufactureDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ManufactureDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "expirationDate":
							result.ExpirationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ExpirationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "lotNumber":
							result.LotNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LotNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 180
							break;
						case "serialNumber":
							result.SerialNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SerialNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 190
							break;
						case "deviceName":
							var newItem_deviceName = new Hl7.Fhir.Model.Device.DeviceNameComponent();
							await ParseAsync(newItem_deviceName, reader, outcome); // 200
							result.DeviceName.Add(newItem_deviceName);
							break;
						case "modelNumber":
							result.ModelNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ModelNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "partNumber":
							result.PartNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PartNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 220
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 230
							break;
						case "specialization":
							var newItem_specialization = new Hl7.Fhir.Model.Device.SpecializationComponent();
							await ParseAsync(newItem_specialization, reader, outcome); // 240
							result.Specialization.Add(newItem_specialization);
							break;
						case "version":
							var newItem_version = new Hl7.Fhir.Model.Device.VersionComponent();
							await ParseAsync(newItem_version, reader, outcome); // 250
							result.Version.Add(newItem_version);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.Device.PropertyComponent();
							await ParseAsync(newItem_property, reader, outcome); // 260
							result.Property.Add(newItem_property);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "owner":
							result.Owner = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Owner as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 280
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_contact, reader, outcome); // 290
							result.Contact.Add(newItem_contact);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 310
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 320
							result.Note.Add(newItem_note);
							break;
						case "safety":
							var newItem_safety = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_safety, reader, outcome); // 330
							result.Safety.Add(newItem_safety);
							break;
						case "parent":
							result.Parent = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Parent as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 340
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
