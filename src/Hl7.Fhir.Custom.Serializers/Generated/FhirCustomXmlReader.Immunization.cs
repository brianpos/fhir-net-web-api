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
		private void Parse(Immunization result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason", cancellationToken); // 110
							break;
						case "vaccineCode":
							result.VaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.VaccineCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".vaccineCode", cancellationToken); // 120
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 140
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence", cancellationToken); // 150
							break;
						case "occurrenceString":
							result.Occurrence = new Hl7.Fhir.Model.FhirString();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".occurrence", cancellationToken); // 150
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.RecordedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recorded", cancellationToken); // 160
							break;
						case "primarySource":
							result.PrimarySourceElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.PrimarySourceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".primarySource", cancellationToken); // 170
							break;
						case "reportOrigin":
							result.ReportOrigin = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ReportOrigin as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".reportOrigin", cancellationToken); // 180
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 190
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".manufacturer", cancellationToken); // 200
							break;
						case "lotNumber":
							result.LotNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LotNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".lotNumber", cancellationToken); // 210
							break;
						case "expirationDate":
							result.ExpirationDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.ExpirationDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".expirationDate", cancellationToken); // 220
							break;
						case "site":
							result.Site = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Site as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".site", cancellationToken); // 230
							break;
						case "route":
							result.Route = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Route as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".route", cancellationToken); // 240
							break;
						case "doseQuantity":
							result.DoseQuantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.DoseQuantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".doseQuantity", cancellationToken); // 250
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.Immunization.PerformerComponent();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 260
							result.Performer.Add(newItem_performer);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 270
							result.Note.Add(newItem_note);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 280
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 290
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "isSubpotent":
							result.IsSubpotentElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsSubpotentElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isSubpotent", cancellationToken); // 300
							break;
						case "subpotentReason":
							var newItem_subpotentReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subpotentReason, reader, outcome, locationPath + ".subpotentReason["+result.SubpotentReason.Count+"]", cancellationToken); // 310
							result.SubpotentReason.Add(newItem_subpotentReason);
							break;
						case "education":
							var newItem_education = new Hl7.Fhir.Model.Immunization.EducationComponent();
							Parse(newItem_education, reader, outcome, locationPath + ".education["+result.Education.Count+"]", cancellationToken); // 320
							result.Education.Add(newItem_education);
							break;
						case "programEligibility":
							var newItem_programEligibility = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_programEligibility, reader, outcome, locationPath + ".programEligibility["+result.ProgramEligibility.Count+"]", cancellationToken); // 330
							result.ProgramEligibility.Add(newItem_programEligibility);
							break;
						case "fundingSource":
							result.FundingSource = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FundingSource as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundingSource", cancellationToken); // 340
							break;
						case "reaction":
							var newItem_reaction = new Hl7.Fhir.Model.Immunization.ReactionComponent();
							Parse(newItem_reaction, reader, outcome, locationPath + ".reaction["+result.Reaction.Count+"]", cancellationToken); // 350
							result.Reaction.Add(newItem_reaction);
							break;
						case "protocolApplied":
							var newItem_protocolApplied = new Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent();
							Parse(newItem_protocolApplied, reader, outcome, locationPath + ".protocolApplied["+result.ProtocolApplied.Count+"]", cancellationToken); // 360
							result.ProtocolApplied.Add(newItem_protocolApplied);
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

		private async System.Threading.Tasks.Task ParseAsync(Immunization result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason", cancellationToken); // 110
							break;
						case "vaccineCode":
							result.VaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.VaccineCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".vaccineCode", cancellationToken); // 120
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 140
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence", cancellationToken); // 150
							break;
						case "occurrenceString":
							result.Occurrence = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".occurrence", cancellationToken); // 150
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.RecordedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recorded", cancellationToken); // 160
							break;
						case "primarySource":
							result.PrimarySourceElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.PrimarySourceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".primarySource", cancellationToken); // 170
							break;
						case "reportOrigin":
							result.ReportOrigin = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ReportOrigin as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".reportOrigin", cancellationToken); // 180
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 190
							break;
						case "manufacturer":
							result.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Manufacturer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".manufacturer", cancellationToken); // 200
							break;
						case "lotNumber":
							result.LotNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LotNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".lotNumber", cancellationToken); // 210
							break;
						case "expirationDate":
							result.ExpirationDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.ExpirationDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".expirationDate", cancellationToken); // 220
							break;
						case "site":
							result.Site = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Site as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".site", cancellationToken); // 230
							break;
						case "route":
							result.Route = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Route as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".route", cancellationToken); // 240
							break;
						case "doseQuantity":
							result.DoseQuantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.DoseQuantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".doseQuantity", cancellationToken); // 250
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.Immunization.PerformerComponent();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 260
							result.Performer.Add(newItem_performer);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 270
							result.Note.Add(newItem_note);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 280
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 290
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "isSubpotent":
							result.IsSubpotentElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsSubpotentElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isSubpotent", cancellationToken); // 300
							break;
						case "subpotentReason":
							var newItem_subpotentReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subpotentReason, reader, outcome, locationPath + ".subpotentReason["+result.SubpotentReason.Count+"]", cancellationToken); // 310
							result.SubpotentReason.Add(newItem_subpotentReason);
							break;
						case "education":
							var newItem_education = new Hl7.Fhir.Model.Immunization.EducationComponent();
							await ParseAsync(newItem_education, reader, outcome, locationPath + ".education["+result.Education.Count+"]", cancellationToken); // 320
							result.Education.Add(newItem_education);
							break;
						case "programEligibility":
							var newItem_programEligibility = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_programEligibility, reader, outcome, locationPath + ".programEligibility["+result.ProgramEligibility.Count+"]", cancellationToken); // 330
							result.ProgramEligibility.Add(newItem_programEligibility);
							break;
						case "fundingSource":
							result.FundingSource = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FundingSource as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundingSource", cancellationToken); // 340
							break;
						case "reaction":
							var newItem_reaction = new Hl7.Fhir.Model.Immunization.ReactionComponent();
							await ParseAsync(newItem_reaction, reader, outcome, locationPath + ".reaction["+result.Reaction.Count+"]", cancellationToken); // 350
							result.Reaction.Add(newItem_reaction);
							break;
						case "protocolApplied":
							var newItem_protocolApplied = new Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent();
							await ParseAsync(newItem_protocolApplied, reader, outcome, locationPath + ".protocolApplied["+result.ProtocolApplied.Count+"]", cancellationToken); // 360
							result.ProtocolApplied.Add(newItem_protocolApplied);
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
