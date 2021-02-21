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
		private void Parse(CommunicationRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "replaces":
							var newItem_replaces = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_replaces, reader, outcome, locationPath + ".replaces["+result.Replaces.Count+"]"); // 110
							result.Replaces.Add(newItem_replaces);
							break;
						case "groupIdentifier":
							result.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.GroupIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".groupIdentifier"); // 120
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>, reader, outcome, locationPath + ".status"); // 130
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 140
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 150
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 160
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 170
							break;
						case "medium":
							var newItem_medium = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_medium, reader, outcome, locationPath + ".medium["+result.Medium.Count+"]"); // 180
							result.Medium.Add(newItem_medium);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 190
							break;
						case "about":
							var newItem_about = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_about, reader, outcome, locationPath + ".about["+result.About.Count+"]"); // 200
							result.About.Add(newItem_about);
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 210
							break;
						case "payload":
							var newItem_payload = new Hl7.Fhir.Model.CommunicationRequest.PayloadComponent();
							Parse(newItem_payload, reader, outcome, locationPath + ".payload["+result.Payload.Count+"]"); // 220
							result.Payload.Add(newItem_payload);
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 230
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							Parse(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 230
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 240
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 250
							break;
						case "recipient":
							var newItem_recipient = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_recipient, reader, outcome, locationPath + ".recipient["+result.Recipient.Count+"]"); // 260
							result.Recipient.Add(newItem_recipient);
							break;
						case "sender":
							result.Sender = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Sender as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".sender"); // 270
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 280
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 290
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 300
							result.Note.Add(newItem_note);
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

		private async System.Threading.Tasks.Task ParseAsync(CommunicationRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "replaces":
							var newItem_replaces = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_replaces, reader, outcome, locationPath + ".replaces["+result.Replaces.Count+"]"); // 110
							result.Replaces.Add(newItem_replaces);
							break;
						case "groupIdentifier":
							result.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.GroupIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".groupIdentifier"); // 120
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>, reader, outcome, locationPath + ".status"); // 130
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 140
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 150
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 160
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 170
							break;
						case "medium":
							var newItem_medium = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_medium, reader, outcome, locationPath + ".medium["+result.Medium.Count+"]"); // 180
							result.Medium.Add(newItem_medium);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 190
							break;
						case "about":
							var newItem_about = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_about, reader, outcome, locationPath + ".about["+result.About.Count+"]"); // 200
							result.About.Add(newItem_about);
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 210
							break;
						case "payload":
							var newItem_payload = new Hl7.Fhir.Model.CommunicationRequest.PayloadComponent();
							await ParseAsync(newItem_payload, reader, outcome, locationPath + ".payload["+result.Payload.Count+"]"); // 220
							result.Payload.Add(newItem_payload);
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 230
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 230
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 240
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 250
							break;
						case "recipient":
							var newItem_recipient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_recipient, reader, outcome, locationPath + ".recipient["+result.Recipient.Count+"]"); // 260
							result.Recipient.Add(newItem_recipient);
							break;
						case "sender":
							result.Sender = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Sender as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".sender"); // 270
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 280
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 290
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 300
							result.Note.Add(newItem_note);
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
