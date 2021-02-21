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
		private void Parse(Appointment result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "cancelationReason":
							result.CancelationReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CancelationReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".cancelationReason"); // 110
							break;
						case "serviceCategory":
							var newItem_serviceCategory = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_serviceCategory, reader, outcome, locationPath + ".serviceCategory["+result.ServiceCategory.Count+"]"); // 120
							result.ServiceCategory.Add(newItem_serviceCategory);
							break;
						case "serviceType":
							var newItem_serviceType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_serviceType, reader, outcome, locationPath + ".serviceType["+result.ServiceType.Count+"]"); // 130
							result.ServiceType.Add(newItem_serviceType);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]"); // 140
							result.Specialty.Add(newItem_specialty);
							break;
						case "appointmentType":
							result.AppointmentType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AppointmentType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".appointmentType"); // 150
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 160
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 170
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.PriorityElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".priority"); // 180
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 190
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInformation, reader, outcome, locationPath + ".supportingInformation["+result.SupportingInformation.Count+"]"); // 200
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Instant();
							Parse(result.StartElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".start"); // 210
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Instant();
							Parse(result.EndElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".end"); // 220
							break;
						case "minutesDuration":
							result.MinutesDurationElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.MinutesDurationElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".minutesDuration"); // 230
							break;
						case "slot":
							var newItem_slot = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_slot, reader, outcome, locationPath + ".slot["+result.Slot.Count+"]"); // 240
							result.Slot.Add(newItem_slot);
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 250
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment"); // 260
							break;
						case "patientInstruction":
							result.PatientInstructionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PatientInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".patientInstruction"); // 270
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 280
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.Appointment.ParticipantComponent();
							Parse(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]"); // 290
							result.Participant.Add(newItem_participant);
							break;
						case "requestedPeriod":
							var newItem_requestedPeriod = new Hl7.Fhir.Model.Period();
							Parse(newItem_requestedPeriod, reader, outcome, locationPath + ".requestedPeriod["+result.RequestedPeriod.Count+"]"); // 300
							result.RequestedPeriod.Add(newItem_requestedPeriod);
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

		private async System.Threading.Tasks.Task ParseAsync(Appointment result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "cancelationReason":
							result.CancelationReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CancelationReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".cancelationReason"); // 110
							break;
						case "serviceCategory":
							var newItem_serviceCategory = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_serviceCategory, reader, outcome, locationPath + ".serviceCategory["+result.ServiceCategory.Count+"]"); // 120
							result.ServiceCategory.Add(newItem_serviceCategory);
							break;
						case "serviceType":
							var newItem_serviceType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_serviceType, reader, outcome, locationPath + ".serviceType["+result.ServiceType.Count+"]"); // 130
							result.ServiceType.Add(newItem_serviceType);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]"); // 140
							result.Specialty.Add(newItem_specialty);
							break;
						case "appointmentType":
							result.AppointmentType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AppointmentType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".appointmentType"); // 150
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 160
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 170
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".priority"); // 180
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 190
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInformation, reader, outcome, locationPath + ".supportingInformation["+result.SupportingInformation.Count+"]"); // 200
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.StartElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".start"); // 210
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.EndElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".end"); // 220
							break;
						case "minutesDuration":
							result.MinutesDurationElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.MinutesDurationElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".minutesDuration"); // 230
							break;
						case "slot":
							var newItem_slot = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_slot, reader, outcome, locationPath + ".slot["+result.Slot.Count+"]"); // 240
							result.Slot.Add(newItem_slot);
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 250
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment"); // 260
							break;
						case "patientInstruction":
							result.PatientInstructionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PatientInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".patientInstruction"); // 270
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 280
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.Appointment.ParticipantComponent();
							await ParseAsync(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]"); // 290
							result.Participant.Add(newItem_participant);
							break;
						case "requestedPeriod":
							var newItem_requestedPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(newItem_requestedPeriod, reader, outcome, locationPath + ".requestedPeriod["+result.RequestedPeriod.Count+"]"); // 300
							result.RequestedPeriod.Add(newItem_requestedPeriod);
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
