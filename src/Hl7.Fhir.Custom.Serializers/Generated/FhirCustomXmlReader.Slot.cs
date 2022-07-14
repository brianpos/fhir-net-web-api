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
		private void Parse(Slot result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "serviceCategory":
							var newItem_serviceCategory = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_serviceCategory, reader, outcome, locationPath + ".serviceCategory["+result.ServiceCategory.Count+"]", cancellationToken); // 100
							result.ServiceCategory.Add(newItem_serviceCategory);
							break;
						case "serviceType":
							var newItem_serviceType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_serviceType, reader, outcome, locationPath + ".serviceType["+result.ServiceType.Count+"]", cancellationToken); // 110
							result.ServiceType.Add(newItem_serviceType);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]", cancellationToken); // 120
							result.Specialty.Add(newItem_specialty);
							break;
						case "appointmentType":
							result.AppointmentType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AppointmentType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".appointmentType", cancellationToken); // 130
							break;
						case "schedule":
							result.Schedule = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Schedule as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".schedule", cancellationToken); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Slot.SlotStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Slot.SlotStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 150
							break;
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Instant();
							Parse(result.StartElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".start", cancellationToken); // 160
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Instant();
							Parse(result.EndElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".end", cancellationToken); // 170
							break;
						case "overbooked":
							result.OverbookedElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.OverbookedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".overbooked", cancellationToken); // 180
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment", cancellationToken); // 190
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

		private async System.Threading.Tasks.Task ParseAsync(Slot result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "serviceCategory":
							var newItem_serviceCategory = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_serviceCategory, reader, outcome, locationPath + ".serviceCategory["+result.ServiceCategory.Count+"]", cancellationToken); // 100
							result.ServiceCategory.Add(newItem_serviceCategory);
							break;
						case "serviceType":
							var newItem_serviceType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_serviceType, reader, outcome, locationPath + ".serviceType["+result.ServiceType.Count+"]", cancellationToken); // 110
							result.ServiceType.Add(newItem_serviceType);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]", cancellationToken); // 120
							result.Specialty.Add(newItem_specialty);
							break;
						case "appointmentType":
							result.AppointmentType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AppointmentType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".appointmentType", cancellationToken); // 130
							break;
						case "schedule":
							result.Schedule = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Schedule as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".schedule", cancellationToken); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Slot.SlotStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Slot.SlotStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 150
							break;
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.StartElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".start", cancellationToken); // 160
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.EndElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".end", cancellationToken); // 170
							break;
						case "overbooked":
							result.OverbookedElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.OverbookedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".overbooked", cancellationToken); // 180
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment", cancellationToken); // 190
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
