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
		private void Parse(MedicationDispense result, XmlReader reader, OperationOutcome outcome)
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
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome); // 100
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>, reader, outcome); // 110
							break;
						case "statusReasonCodeableConcept":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "statusReasonReference":
							result.StatusReason = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.StatusReason as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 120
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "medicationCodeableConcept":
							result.Medication = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Medication as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "medicationReference":
							result.Medication = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Medication as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 160
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInformation, reader, outcome); // 170
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.MedicationDispense.PerformerComponent();
							Parse(newItem_performer, reader, outcome); // 180
							result.Performer.Add(newItem_performer);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "authorizingPrescription":
							var newItem_authorizingPrescription = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_authorizingPrescription, reader, outcome); // 200
							result.AuthorizingPrescription.Add(newItem_authorizingPrescription);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 210
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 220
							break;
						case "daysSupply":
							result.DaysSupply = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.DaysSupply as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 230
							break;
						case "whenPrepared":
							result.WhenPreparedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.WhenPreparedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 240
							break;
						case "whenHandedOver":
							result.WhenHandedOverElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.WhenHandedOverElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 250
							break;
						case "destination":
							result.Destination = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Destination as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "receiver":
							var newItem_receiver = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_receiver, reader, outcome); // 270
							result.Receiver.Add(newItem_receiver);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 280
							result.Note.Add(newItem_note);
							break;
						case "dosageInstruction":
							var newItem_dosageInstruction = new Hl7.Fhir.Model.Dosage();
							Parse(newItem_dosageInstruction, reader, outcome); // 290
							result.DosageInstruction.Add(newItem_dosageInstruction);
							break;
						case "substitution":
							result.Substitution = new Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent();
							Parse(result.Substitution as Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent, reader, outcome); // 300
							break;
						case "detectedIssue":
							var newItem_detectedIssue = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_detectedIssue, reader, outcome); // 310
							result.DetectedIssue.Add(newItem_detectedIssue);
							break;
						case "eventHistory":
							var newItem_eventHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_eventHistory, reader, outcome); // 320
							result.EventHistory.Add(newItem_eventHistory);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicationDispense result, XmlReader reader, OperationOutcome outcome)
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
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome); // 100
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes>, reader, outcome); // 110
							break;
						case "statusReasonCodeableConcept":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "statusReasonReference":
							result.StatusReason = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 120
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "medicationCodeableConcept":
							result.Medication = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Medication as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "medicationReference":
							result.Medication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Medication as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 160
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInformation, reader, outcome); // 170
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.MedicationDispense.PerformerComponent();
							await ParseAsync(newItem_performer, reader, outcome); // 180
							result.Performer.Add(newItem_performer);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "authorizingPrescription":
							var newItem_authorizingPrescription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_authorizingPrescription, reader, outcome); // 200
							result.AuthorizingPrescription.Add(newItem_authorizingPrescription);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 210
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 220
							break;
						case "daysSupply":
							result.DaysSupply = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.DaysSupply as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 230
							break;
						case "whenPrepared":
							result.WhenPreparedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.WhenPreparedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 240
							break;
						case "whenHandedOver":
							result.WhenHandedOverElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.WhenHandedOverElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 250
							break;
						case "destination":
							result.Destination = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Destination as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "receiver":
							var newItem_receiver = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_receiver, reader, outcome); // 270
							result.Receiver.Add(newItem_receiver);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 280
							result.Note.Add(newItem_note);
							break;
						case "dosageInstruction":
							var newItem_dosageInstruction = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(newItem_dosageInstruction, reader, outcome); // 290
							result.DosageInstruction.Add(newItem_dosageInstruction);
							break;
						case "substitution":
							result.Substitution = new Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent();
							await ParseAsync(result.Substitution as Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent, reader, outcome); // 300
							break;
						case "detectedIssue":
							var newItem_detectedIssue = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_detectedIssue, reader, outcome); // 310
							result.DetectedIssue.Add(newItem_detectedIssue);
							break;
						case "eventHistory":
							var newItem_eventHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_eventHistory, reader, outcome); // 320
							result.EventHistory.Add(newItem_eventHistory);
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
