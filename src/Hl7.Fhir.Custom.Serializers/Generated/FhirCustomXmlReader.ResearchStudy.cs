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
		private void Parse(ResearchStudy result, XmlReader reader, OperationOutcome outcome)
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
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 100
							break;
						case "protocol":
							var newItem_protocol = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_protocol, reader, outcome); // 110
							result.Protocol.Add(newItem_protocol);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome); // 120
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus>, reader, outcome); // 130
							break;
						case "primaryPurposeType":
							result.PrimaryPurposeType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PrimaryPurposeType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "phase":
							result.Phase = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Phase as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 150
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome); // 160
							result.Category.Add(newItem_category);
							break;
						case "focus":
							var newItem_focus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_focus, reader, outcome); // 170
							result.Focus.Add(newItem_focus);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_condition, reader, outcome); // 180
							result.Condition.Add(newItem_condition);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome); // 190
							result.Contact.Add(newItem_contact);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_relatedArtifact, reader, outcome); // 200
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "keyword":
							var newItem_keyword = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_keyword, reader, outcome); // 210
							result.Keyword.Add(newItem_keyword);
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_location, reader, outcome); // 220
							result.Location.Add(newItem_location);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 230
							break;
						case "enrollment":
							var newItem_enrollment = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_enrollment, reader, outcome); // 240
							result.Enrollment.Add(newItem_enrollment);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 250
							break;
						case "sponsor":
							result.Sponsor = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Sponsor as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "principalInvestigator":
							result.PrincipalInvestigator = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.PrincipalInvestigator as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "site":
							var newItem_site = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_site, reader, outcome); // 280
							result.Site.Add(newItem_site);
							break;
						case "reasonStopped":
							result.ReasonStopped = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ReasonStopped as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 290
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 300
							result.Note.Add(newItem_note);
							break;
						case "arm":
							var newItem_arm = new Hl7.Fhir.Model.ResearchStudy.ArmComponent();
							Parse(newItem_arm, reader, outcome); // 310
							result.Arm.Add(newItem_arm);
							break;
						case "objective":
							var newItem_objective = new Hl7.Fhir.Model.ResearchStudy.ObjectiveComponent();
							Parse(newItem_objective, reader, outcome); // 320
							result.Objective.Add(newItem_objective);
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

		private async System.Threading.Tasks.Task ParseAsync(ResearchStudy result, XmlReader reader, OperationOutcome outcome)
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
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 100
							break;
						case "protocol":
							var newItem_protocol = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_protocol, reader, outcome); // 110
							result.Protocol.Add(newItem_protocol);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome); // 120
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus>, reader, outcome); // 130
							break;
						case "primaryPurposeType":
							result.PrimaryPurposeType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PrimaryPurposeType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "phase":
							result.Phase = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Phase as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 150
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome); // 160
							result.Category.Add(newItem_category);
							break;
						case "focus":
							var newItem_focus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_focus, reader, outcome); // 170
							result.Focus.Add(newItem_focus);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_condition, reader, outcome); // 180
							result.Condition.Add(newItem_condition);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome); // 190
							result.Contact.Add(newItem_contact);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_relatedArtifact, reader, outcome); // 200
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "keyword":
							var newItem_keyword = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_keyword, reader, outcome); // 210
							result.Keyword.Add(newItem_keyword);
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_location, reader, outcome); // 220
							result.Location.Add(newItem_location);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 230
							break;
						case "enrollment":
							var newItem_enrollment = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_enrollment, reader, outcome); // 240
							result.Enrollment.Add(newItem_enrollment);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 250
							break;
						case "sponsor":
							result.Sponsor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Sponsor as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "principalInvestigator":
							result.PrincipalInvestigator = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.PrincipalInvestigator as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "site":
							var newItem_site = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_site, reader, outcome); // 280
							result.Site.Add(newItem_site);
							break;
						case "reasonStopped":
							result.ReasonStopped = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ReasonStopped as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 290
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 300
							result.Note.Add(newItem_note);
							break;
						case "arm":
							var newItem_arm = new Hl7.Fhir.Model.ResearchStudy.ArmComponent();
							await ParseAsync(newItem_arm, reader, outcome); // 310
							result.Arm.Add(newItem_arm);
							break;
						case "objective":
							var newItem_objective = new Hl7.Fhir.Model.ResearchStudy.ObjectiveComponent();
							await ParseAsync(newItem_objective, reader, outcome); // 320
							result.Objective.Add(newItem_objective);
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
