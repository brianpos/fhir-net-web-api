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
		private void Parse(Condition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "clinicalStatus":
							result.ClinicalStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ClinicalStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".clinicalStatus", cancellationToken); // 100
							break;
						case "verificationStatus":
							result.VerificationStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.VerificationStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".verificationStatus", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "severity":
							result.Severity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Severity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".severity", cancellationToken); // 130
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 140
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]", cancellationToken); // 150
							result.BodySite.Add(newItem_bodySite);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 160
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 170
							break;
						case "onsetDateTime":
							result.Onset = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Onset as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetAge":
							result.Onset = new Hl7.Fhir.Model.Age();
							Parse(result.Onset as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetPeriod":
							result.Onset = new Hl7.Fhir.Model.Period();
							Parse(result.Onset as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetRange":
							result.Onset = new Hl7.Fhir.Model.Range();
							Parse(result.Onset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetString":
							result.Onset = new Hl7.Fhir.Model.FhirString();
							Parse(result.Onset as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "abatementDateTime":
							result.Abatement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Abatement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementAge":
							result.Abatement = new Hl7.Fhir.Model.Age();
							Parse(result.Abatement as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementPeriod":
							result.Abatement = new Hl7.Fhir.Model.Period();
							Parse(result.Abatement as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementRange":
							result.Abatement = new Hl7.Fhir.Model.Range();
							Parse(result.Abatement as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementString":
							result.Abatement = new Hl7.Fhir.Model.FhirString();
							Parse(result.Abatement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "recordedDate":
							result.RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.RecordedDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recordedDate", cancellationToken); // 200
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder", cancellationToken); // 210
							break;
						case "asserter":
							result.Asserter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Asserter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".asserter", cancellationToken); // 220
							break;
						case "stage":
							var newItem_stage = new Hl7.Fhir.Model.Condition.StageComponent();
							Parse(newItem_stage, reader, outcome, locationPath + ".stage["+result.Stage.Count+"]", cancellationToken); // 230
							result.Stage.Add(newItem_stage);
							break;
						case "evidence":
							var newItem_evidence = new Hl7.Fhir.Model.Condition.EvidenceComponent();
							Parse(newItem_evidence, reader, outcome, locationPath + ".evidence["+result.Evidence.Count+"]", cancellationToken); // 240
							result.Evidence.Add(newItem_evidence);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 250
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

		private async System.Threading.Tasks.Task ParseAsync(Condition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "clinicalStatus":
							result.ClinicalStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ClinicalStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".clinicalStatus", cancellationToken); // 100
							break;
						case "verificationStatus":
							result.VerificationStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.VerificationStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".verificationStatus", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "severity":
							result.Severity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Severity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".severity", cancellationToken); // 130
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 140
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]", cancellationToken); // 150
							result.BodySite.Add(newItem_bodySite);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 160
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 170
							break;
						case "onsetDateTime":
							result.Onset = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetAge":
							result.Onset = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetPeriod":
							result.Onset = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetRange":
							result.Onset = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "onsetString":
							result.Onset = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".onset", cancellationToken); // 180
							break;
						case "abatementDateTime":
							result.Abatement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Abatement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementAge":
							result.Abatement = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Abatement as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementPeriod":
							result.Abatement = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Abatement as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementRange":
							result.Abatement = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Abatement as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "abatementString":
							result.Abatement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Abatement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".abatement", cancellationToken); // 190
							break;
						case "recordedDate":
							result.RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.RecordedDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recordedDate", cancellationToken); // 200
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder", cancellationToken); // 210
							break;
						case "asserter":
							result.Asserter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Asserter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".asserter", cancellationToken); // 220
							break;
						case "stage":
							var newItem_stage = new Hl7.Fhir.Model.Condition.StageComponent();
							await ParseAsync(newItem_stage, reader, outcome, locationPath + ".stage["+result.Stage.Count+"]", cancellationToken); // 230
							result.Stage.Add(newItem_stage);
							break;
						case "evidence":
							var newItem_evidence = new Hl7.Fhir.Model.Condition.EvidenceComponent();
							await ParseAsync(newItem_evidence, reader, outcome, locationPath + ".evidence["+result.Evidence.Count+"]", cancellationToken); // 240
							result.Evidence.Add(newItem_evidence);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 250
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
