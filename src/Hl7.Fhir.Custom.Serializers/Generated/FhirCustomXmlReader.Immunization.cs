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
		private void Parse(Immunization result, XmlReader reader, OperationOutcome outcome)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>, reader, outcome); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "vaccineCode":
							result.VaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.VaccineCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "occurrenceString":
							result.Occurrence = new Hl7.Fhir.Model.FhirString();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.RecordedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "primarySource":
							result.PrimarySourceElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.PrimarySourceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 170
							break;
						case "reportOrigin":
							result.ReportOrigin = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ReportOrigin as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 180
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 200
							break;
						case "lotNumber":
							result.LotNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LotNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "expirationDate":
							result.ExpirationDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.ExpirationDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 220
							break;
						case "site":
							result.Site = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Site as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 230
							break;
						case "route":
							result.Route = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Route as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 240
							break;
						case "doseQuantity":
							result.DoseQuantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.DoseQuantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 250
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.Immunization.PerformerComponent();
							Parse(newItem_performer, reader, outcome); // 260
							result.Performer.Add(newItem_performer);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 270
							result.Note.Add(newItem_note);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome); // 280
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome); // 290
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "isSubpotent":
							result.IsSubpotentElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsSubpotentElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 300
							break;
						case "subpotentReason":
							var newItem_subpotentReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subpotentReason, reader, outcome); // 310
							result.SubpotentReason.Add(newItem_subpotentReason);
							break;
						case "education":
							var newItem_education = new Hl7.Fhir.Model.Immunization.EducationComponent();
							Parse(newItem_education, reader, outcome); // 320
							result.Education.Add(newItem_education);
							break;
						case "programEligibility":
							var newItem_programEligibility = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_programEligibility, reader, outcome); // 330
							result.ProgramEligibility.Add(newItem_programEligibility);
							break;
						case "fundingSource":
							result.FundingSource = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FundingSource as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 340
							break;
						case "reaction":
							var newItem_reaction = new Hl7.Fhir.Model.Immunization.ReactionComponent();
							Parse(newItem_reaction, reader, outcome); // 350
							result.Reaction.Add(newItem_reaction);
							break;
						case "protocolApplied":
							var newItem_protocolApplied = new Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent();
							Parse(newItem_protocolApplied, reader, outcome); // 360
							result.ProtocolApplied.Add(newItem_protocolApplied);
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

		private async System.Threading.Tasks.Task ParseAsync(Immunization result, XmlReader reader, OperationOutcome outcome)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>, reader, outcome); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "vaccineCode":
							result.VaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.VaccineCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "occurrenceString":
							result.Occurrence = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.RecordedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "primarySource":
							result.PrimarySourceElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.PrimarySourceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 170
							break;
						case "reportOrigin":
							result.ReportOrigin = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ReportOrigin as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 180
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 200
							break;
						case "lotNumber":
							result.LotNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LotNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "expirationDate":
							result.ExpirationDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.ExpirationDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 220
							break;
						case "site":
							result.Site = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Site as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 230
							break;
						case "route":
							result.Route = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Route as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 240
							break;
						case "doseQuantity":
							result.DoseQuantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.DoseQuantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 250
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.Immunization.PerformerComponent();
							await ParseAsync(newItem_performer, reader, outcome); // 260
							result.Performer.Add(newItem_performer);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 270
							result.Note.Add(newItem_note);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome); // 280
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome); // 290
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "isSubpotent":
							result.IsSubpotentElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsSubpotentElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 300
							break;
						case "subpotentReason":
							var newItem_subpotentReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subpotentReason, reader, outcome); // 310
							result.SubpotentReason.Add(newItem_subpotentReason);
							break;
						case "education":
							var newItem_education = new Hl7.Fhir.Model.Immunization.EducationComponent();
							await ParseAsync(newItem_education, reader, outcome); // 320
							result.Education.Add(newItem_education);
							break;
						case "programEligibility":
							var newItem_programEligibility = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_programEligibility, reader, outcome); // 330
							result.ProgramEligibility.Add(newItem_programEligibility);
							break;
						case "fundingSource":
							result.FundingSource = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FundingSource as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 340
							break;
						case "reaction":
							var newItem_reaction = new Hl7.Fhir.Model.Immunization.ReactionComponent();
							await ParseAsync(newItem_reaction, reader, outcome); // 350
							result.Reaction.Add(newItem_reaction);
							break;
						case "protocolApplied":
							var newItem_protocolApplied = new Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent();
							await ParseAsync(newItem_protocolApplied, reader, outcome); // 360
							result.ProtocolApplied.Add(newItem_protocolApplied);
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
