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
		private void Parse(MedicationRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationrequestStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationrequestStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 110
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationRequestIntent>();
							Parse(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationRequestIntent>, reader, outcome, locationPath + ".intent"); // 120
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 130
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 140
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 150
							break;
						case "reportedBoolean":
							result.Reported = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Reported as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".reported"); // 160
							break;
						case "reportedReference":
							result.Reported = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Reported as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".reported"); // 160
							break;
						case "medicationCodeableConcept":
							result.Medication = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Medication as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".medication"); // 170
							break;
						case "medicationReference":
							result.Medication = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Medication as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".medication"); // 170
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 180
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 190
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInformation, reader, outcome, locationPath + ".supportingInformation["+result.SupportingInformation.Count+"]"); // 200
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 210
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 220
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer"); // 230
							break;
						case "performerType":
							result.PerformerType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PerformerType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".performerType"); // 240
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 250
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 260
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 270
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 280
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 290
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 300
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "groupIdentifier":
							result.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.GroupIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".groupIdentifier"); // 310
							break;
						case "courseOfTherapyType":
							result.CourseOfTherapyType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CourseOfTherapyType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".courseOfTherapyType"); // 320
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 330
							result.Insurance.Add(newItem_insurance);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 340
							result.Note.Add(newItem_note);
							break;
						case "dosageInstruction":
							var newItem_dosageInstruction = new Hl7.Fhir.Model.Dosage();
							Parse(newItem_dosageInstruction, reader, outcome, locationPath + ".dosageInstruction["+result.DosageInstruction.Count+"]"); // 350
							result.DosageInstruction.Add(newItem_dosageInstruction);
							break;
						case "dispenseRequest":
							result.DispenseRequest = new Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent();
							Parse(result.DispenseRequest as Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent, reader, outcome, locationPath + ".dispenseRequest"); // 360
							break;
						case "substitution":
							result.Substitution = new Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent();
							Parse(result.Substitution as Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent, reader, outcome, locationPath + ".substitution"); // 370
							break;
						case "priorPrescription":
							result.PriorPrescription = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.PriorPrescription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".priorPrescription"); // 380
							break;
						case "detectedIssue":
							var newItem_detectedIssue = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_detectedIssue, reader, outcome, locationPath + ".detectedIssue["+result.DetectedIssue.Count+"]"); // 390
							result.DetectedIssue.Add(newItem_detectedIssue);
							break;
						case "eventHistory":
							var newItem_eventHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_eventHistory, reader, outcome, locationPath + ".eventHistory["+result.EventHistory.Count+"]"); // 400
							result.EventHistory.Add(newItem_eventHistory);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicationRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationrequestStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationrequestStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 110
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationRequestIntent>();
							await ParseAsync(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationRequestIntent>, reader, outcome, locationPath + ".intent"); // 120
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 130
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 140
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 150
							break;
						case "reportedBoolean":
							result.Reported = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Reported as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".reported"); // 160
							break;
						case "reportedReference":
							result.Reported = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Reported as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".reported"); // 160
							break;
						case "medicationCodeableConcept":
							result.Medication = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Medication as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".medication"); // 170
							break;
						case "medicationReference":
							result.Medication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Medication as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".medication"); // 170
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 180
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 190
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInformation, reader, outcome, locationPath + ".supportingInformation["+result.SupportingInformation.Count+"]"); // 200
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 210
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 220
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer"); // 230
							break;
						case "performerType":
							result.PerformerType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PerformerType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".performerType"); // 240
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 250
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 260
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 270
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 280
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 290
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 300
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "groupIdentifier":
							result.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.GroupIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".groupIdentifier"); // 310
							break;
						case "courseOfTherapyType":
							result.CourseOfTherapyType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CourseOfTherapyType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".courseOfTherapyType"); // 320
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 330
							result.Insurance.Add(newItem_insurance);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 340
							result.Note.Add(newItem_note);
							break;
						case "dosageInstruction":
							var newItem_dosageInstruction = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(newItem_dosageInstruction, reader, outcome, locationPath + ".dosageInstruction["+result.DosageInstruction.Count+"]"); // 350
							result.DosageInstruction.Add(newItem_dosageInstruction);
							break;
						case "dispenseRequest":
							result.DispenseRequest = new Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent();
							await ParseAsync(result.DispenseRequest as Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent, reader, outcome, locationPath + ".dispenseRequest"); // 360
							break;
						case "substitution":
							result.Substitution = new Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent();
							await ParseAsync(result.Substitution as Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent, reader, outcome, locationPath + ".substitution"); // 370
							break;
						case "priorPrescription":
							result.PriorPrescription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.PriorPrescription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".priorPrescription"); // 380
							break;
						case "detectedIssue":
							var newItem_detectedIssue = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_detectedIssue, reader, outcome, locationPath + ".detectedIssue["+result.DetectedIssue.Count+"]"); // 390
							result.DetectedIssue.Add(newItem_detectedIssue);
							break;
						case "eventHistory":
							var newItem_eventHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_eventHistory, reader, outcome, locationPath + ".eventHistory["+result.EventHistory.Count+"]"); // 400
							result.EventHistory.Add(newItem_eventHistory);
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
