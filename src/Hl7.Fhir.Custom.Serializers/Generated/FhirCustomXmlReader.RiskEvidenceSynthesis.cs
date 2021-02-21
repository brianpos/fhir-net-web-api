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
		private void Parse(RiskEvidenceSynthesis result, XmlReader reader, OperationOutcome outcome)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome); // 170
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 180
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 190
							result.Note.Add(newItem_note);
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							Parse(newItem_useContext, reader, outcome); // 200
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome); // 210
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							Parse(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome); // 220
							break;
						case "approvalDate":
							result.ApprovalDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.ApprovalDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 230
							break;
						case "lastReviewDate":
							result.LastReviewDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.LastReviewDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 240
							break;
						case "effectivePeriod":
							result.EffectivePeriod = new Hl7.Fhir.Model.Period();
							Parse(result.EffectivePeriod as Hl7.Fhir.Model.Period, reader, outcome); // 250
							break;
						case "topic":
							var newItem_topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_topic, reader, outcome); // 260
							result.Topic.Add(newItem_topic);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_author, reader, outcome); // 270
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_editor, reader, outcome); // 280
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_reviewer, reader, outcome); // 290
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_endorser, reader, outcome); // 300
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_relatedArtifact, reader, outcome); // 310
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "synthesisType":
							result.SynthesisType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SynthesisType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 320
							break;
						case "studyType":
							result.StudyType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StudyType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 330
							break;
						case "population":
							result.Population = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Population as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 340
							break;
						case "exposure":
							result.Exposure = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Exposure as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 350
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Outcome as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 360
							break;
						case "sampleSize":
							result.SampleSize = new Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent();
							Parse(result.SampleSize as Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent, reader, outcome); // 370
							break;
						case "riskEstimate":
							result.RiskEstimate = new Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent();
							Parse(result.RiskEstimate as Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent, reader, outcome); // 380
							break;
						case "certainty":
							var newItem_certainty = new Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintyComponent();
							Parse(newItem_certainty, reader, outcome); // 390
							result.Certainty.Add(newItem_certainty);
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

		private async System.Threading.Tasks.Task ParseAsync(RiskEvidenceSynthesis result, XmlReader reader, OperationOutcome outcome)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome); // 170
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 180
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 190
							result.Note.Add(newItem_note);
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(newItem_useContext, reader, outcome); // 200
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome); // 210
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome); // 220
							break;
						case "approvalDate":
							result.ApprovalDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.ApprovalDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 230
							break;
						case "lastReviewDate":
							result.LastReviewDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.LastReviewDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 240
							break;
						case "effectivePeriod":
							result.EffectivePeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.EffectivePeriod as Hl7.Fhir.Model.Period, reader, outcome); // 250
							break;
						case "topic":
							var newItem_topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_topic, reader, outcome); // 260
							result.Topic.Add(newItem_topic);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_author, reader, outcome); // 270
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_editor, reader, outcome); // 280
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_reviewer, reader, outcome); // 290
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_endorser, reader, outcome); // 300
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_relatedArtifact, reader, outcome); // 310
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "synthesisType":
							result.SynthesisType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SynthesisType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 320
							break;
						case "studyType":
							result.StudyType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StudyType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 330
							break;
						case "population":
							result.Population = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Population as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 340
							break;
						case "exposure":
							result.Exposure = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Exposure as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 350
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Outcome as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 360
							break;
						case "sampleSize":
							result.SampleSize = new Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent();
							await ParseAsync(result.SampleSize as Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent, reader, outcome); // 370
							break;
						case "riskEstimate":
							result.RiskEstimate = new Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent();
							await ParseAsync(result.RiskEstimate as Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent, reader, outcome); // 380
							break;
						case "certainty":
							var newItem_certainty = new Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintyComponent();
							await ParseAsync(newItem_certainty, reader, outcome); // 390
							result.Certainty.Add(newItem_certainty);
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
