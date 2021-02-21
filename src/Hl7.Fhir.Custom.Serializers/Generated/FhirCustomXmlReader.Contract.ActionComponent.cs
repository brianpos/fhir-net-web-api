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
		public void Parse(Hl7.Fhir.Model.Contract.ActionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 50
							break;
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.Contract.ActionSubjectComponent();
							Parse(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]"); // 60
							result.Subject.Add(newItem_subject);
							break;
						case "intent":
							result.Intent = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Intent as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".intent"); // 70
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]"); // 80
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status"); // 90
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".context"); // 100
							break;
						case "contextLinkId":
							var newItem_contextLinkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_contextLinkId, reader, outcome, locationPath + ".contextLinkId["+result.ContextLinkIdElement.Count+"]"); // 110
							result.ContextLinkIdElement.Add(newItem_contextLinkId);
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 120
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							Parse(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 120
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							Parse(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".occurrence"); // 120
							break;
						case "requester":
							var newItem_requester = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_requester, reader, outcome, locationPath + ".requester["+result.Requester.Count+"]"); // 130
							result.Requester.Add(newItem_requester);
							break;
						case "requesterLinkId":
							var newItem_requesterLinkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_requesterLinkId, reader, outcome, locationPath + ".requesterLinkId["+result.RequesterLinkIdElement.Count+"]"); // 140
							result.RequesterLinkIdElement.Add(newItem_requesterLinkId);
							break;
						case "performerType":
							var newItem_performerType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_performerType, reader, outcome, locationPath + ".performerType["+result.PerformerType.Count+"]"); // 150
							result.PerformerType.Add(newItem_performerType);
							break;
						case "performerRole":
							result.PerformerRole = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PerformerRole as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".performerRole"); // 160
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer"); // 170
							break;
						case "performerLinkId":
							var newItem_performerLinkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_performerLinkId, reader, outcome, locationPath + ".performerLinkId["+result.PerformerLinkIdElement.Count+"]"); // 180
							result.PerformerLinkIdElement.Add(newItem_performerLinkId);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 190
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 200
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_reason, reader, outcome, locationPath + ".reason["+result.ReasonElement.Count+"]"); // 210
							result.ReasonElement.Add(newItem_reason);
							break;
						case "reasonLinkId":
							var newItem_reasonLinkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_reasonLinkId, reader, outcome, locationPath + ".reasonLinkId["+result.ReasonLinkIdElement.Count+"]"); // 220
							result.ReasonLinkIdElement.Add(newItem_reasonLinkId);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 230
							result.Note.Add(newItem_note);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							Parse(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]"); // 240
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.ActionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 50
							break;
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.Contract.ActionSubjectComponent();
							await ParseAsync(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]"); // 60
							result.Subject.Add(newItem_subject);
							break;
						case "intent":
							result.Intent = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Intent as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".intent"); // 70
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]"); // 80
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status"); // 90
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".context"); // 100
							break;
						case "contextLinkId":
							var newItem_contextLinkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_contextLinkId, reader, outcome, locationPath + ".contextLinkId["+result.ContextLinkIdElement.Count+"]"); // 110
							result.ContextLinkIdElement.Add(newItem_contextLinkId);
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 120
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 120
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".occurrence"); // 120
							break;
						case "requester":
							var newItem_requester = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_requester, reader, outcome, locationPath + ".requester["+result.Requester.Count+"]"); // 130
							result.Requester.Add(newItem_requester);
							break;
						case "requesterLinkId":
							var newItem_requesterLinkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_requesterLinkId, reader, outcome, locationPath + ".requesterLinkId["+result.RequesterLinkIdElement.Count+"]"); // 140
							result.RequesterLinkIdElement.Add(newItem_requesterLinkId);
							break;
						case "performerType":
							var newItem_performerType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_performerType, reader, outcome, locationPath + ".performerType["+result.PerformerType.Count+"]"); // 150
							result.PerformerType.Add(newItem_performerType);
							break;
						case "performerRole":
							result.PerformerRole = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PerformerRole as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".performerRole"); // 160
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer"); // 170
							break;
						case "performerLinkId":
							var newItem_performerLinkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_performerLinkId, reader, outcome, locationPath + ".performerLinkId["+result.PerformerLinkIdElement.Count+"]"); // 180
							result.PerformerLinkIdElement.Add(newItem_performerLinkId);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 190
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 200
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_reason, reader, outcome, locationPath + ".reason["+result.ReasonElement.Count+"]"); // 210
							result.ReasonElement.Add(newItem_reason);
							break;
						case "reasonLinkId":
							var newItem_reasonLinkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_reasonLinkId, reader, outcome, locationPath + ".reasonLinkId["+result.ReasonLinkIdElement.Count+"]"); // 220
							result.ReasonLinkIdElement.Add(newItem_reasonLinkId);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 230
							result.Note.Add(newItem_note);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]"); // 240
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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
