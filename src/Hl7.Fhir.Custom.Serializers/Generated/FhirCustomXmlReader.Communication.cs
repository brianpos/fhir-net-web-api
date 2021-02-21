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
		private void Parse(Communication result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]"); // 130
							result.PartOf.Add(newItem_partOf);
							break;
						case "inResponseTo":
							var newItem_inResponseTo = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_inResponseTo, reader, outcome, locationPath + ".inResponseTo["+result.InResponseTo.Count+"]"); // 140
							result.InResponseTo.Add(newItem_inResponseTo);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 160
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 170
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 180
							break;
						case "medium":
							var newItem_medium = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_medium, reader, outcome, locationPath + ".medium["+result.Medium.Count+"]"); // 190
							result.Medium.Add(newItem_medium);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 200
							break;
						case "topic":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".topic"); // 210
							break;
						case "about":
							var newItem_about = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_about, reader, outcome, locationPath + ".about["+result.About.Count+"]"); // 220
							result.About.Add(newItem_about);
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 230
							break;
						case "sent":
							result.SentElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.SentElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".sent"); // 240
							break;
						case "received":
							result.ReceivedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ReceivedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".received"); // 250
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
						case "payload":
							var newItem_payload = new Hl7.Fhir.Model.Communication.PayloadComponent();
							Parse(newItem_payload, reader, outcome, locationPath + ".payload["+result.Payload.Count+"]"); // 300
							result.Payload.Add(newItem_payload);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 310
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

		private async System.Threading.Tasks.Task ParseAsync(Communication result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]"); // 130
							result.PartOf.Add(newItem_partOf);
							break;
						case "inResponseTo":
							var newItem_inResponseTo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_inResponseTo, reader, outcome, locationPath + ".inResponseTo["+result.InResponseTo.Count+"]"); // 140
							result.InResponseTo.Add(newItem_inResponseTo);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 160
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 170
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 180
							break;
						case "medium":
							var newItem_medium = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_medium, reader, outcome, locationPath + ".medium["+result.Medium.Count+"]"); // 190
							result.Medium.Add(newItem_medium);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 200
							break;
						case "topic":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".topic"); // 210
							break;
						case "about":
							var newItem_about = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_about, reader, outcome, locationPath + ".about["+result.About.Count+"]"); // 220
							result.About.Add(newItem_about);
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 230
							break;
						case "sent":
							result.SentElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.SentElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".sent"); // 240
							break;
						case "received":
							result.ReceivedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ReceivedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".received"); // 250
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
						case "payload":
							var newItem_payload = new Hl7.Fhir.Model.Communication.PayloadComponent();
							await ParseAsync(newItem_payload, reader, outcome, locationPath + ".payload["+result.Payload.Count+"]"); // 300
							result.Payload.Add(newItem_payload);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 310
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
