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
		private void Parse(AllergyIntolerance result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "clinicalStatus":
							result.ClinicalStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ClinicalStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".clinicalStatus"); // 100
							break;
						case "verificationStatus":
							result.VerificationStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.VerificationStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".verificationStatus"); // 110
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType>, reader, outcome, locationPath + ".type"); // 120
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.CategoryElement.Count+"]"); // 130
							result.CategoryElement.Add(newItem_category);
							break;
						case "criticality":
							result.CriticalityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality>();
							Parse(result.CriticalityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality>, reader, outcome, locationPath + ".criticality"); // 140
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 150
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 160
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 170
							break;
						case "onsetDateTime":
							result.Onset = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Onset as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetAge":
							result.Onset = new Hl7.Fhir.Model.Age();
							Parse(result.Onset as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetPeriod":
							result.Onset = new Hl7.Fhir.Model.Period();
							Parse(result.Onset as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetRange":
							result.Onset = new Hl7.Fhir.Model.Range();
							Parse(result.Onset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetString":
							result.Onset = new Hl7.Fhir.Model.FhirString();
							Parse(result.Onset as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "recordedDate":
							result.RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.RecordedDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recordedDate"); // 190
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 200
							break;
						case "asserter":
							result.Asserter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Asserter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".asserter"); // 210
							break;
						case "lastOccurrence":
							result.LastOccurrenceElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.LastOccurrenceElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".lastOccurrence"); // 220
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 230
							result.Note.Add(newItem_note);
							break;
						case "reaction":
							var newItem_reaction = new Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent();
							Parse(newItem_reaction, reader, outcome, locationPath + ".reaction["+result.Reaction.Count+"]"); // 240
							result.Reaction.Add(newItem_reaction);
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

		private async System.Threading.Tasks.Task ParseAsync(AllergyIntolerance result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "clinicalStatus":
							result.ClinicalStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ClinicalStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".clinicalStatus"); // 100
							break;
						case "verificationStatus":
							result.VerificationStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.VerificationStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".verificationStatus"); // 110
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType>, reader, outcome, locationPath + ".type"); // 120
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.CategoryElement.Count+"]"); // 130
							result.CategoryElement.Add(newItem_category);
							break;
						case "criticality":
							result.CriticalityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality>();
							await ParseAsync(result.CriticalityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality>, reader, outcome, locationPath + ".criticality"); // 140
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 150
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 160
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 170
							break;
						case "onsetDateTime":
							result.Onset = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetAge":
							result.Onset = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetPeriod":
							result.Onset = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetRange":
							result.Onset = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "onsetString":
							result.Onset = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".onset"); // 180
							break;
						case "recordedDate":
							result.RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.RecordedDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recordedDate"); // 190
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 200
							break;
						case "asserter":
							result.Asserter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Asserter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".asserter"); // 210
							break;
						case "lastOccurrence":
							result.LastOccurrenceElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.LastOccurrenceElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".lastOccurrence"); // 220
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 230
							result.Note.Add(newItem_note);
							break;
						case "reaction":
							var newItem_reaction = new Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent();
							await ParseAsync(newItem_reaction, reader, outcome, locationPath + ".reaction["+result.Reaction.Count+"]"); // 240
							result.Reaction.Add(newItem_reaction);
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
