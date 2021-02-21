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
		private void Parse(Measure result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url"); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version"); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name"); // 120
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title"); // 130
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subtitle"); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental"); // 160
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subject"); // 170
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 170
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 180
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher"); // 190
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]"); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description"); // 210
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							Parse(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]"); // 220
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]"); // 230
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							Parse(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose"); // 240
							break;
						case "usage":
							result.UsageElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.UsageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".usage"); // 250
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							Parse(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright"); // 260
							break;
						case "approvalDate":
							result.ApprovalDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.ApprovalDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".approvalDate"); // 270
							break;
						case "lastReviewDate":
							result.LastReviewDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.LastReviewDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".lastReviewDate"); // 280
							break;
						case "effectivePeriod":
							result.EffectivePeriod = new Hl7.Fhir.Model.Period();
							Parse(result.EffectivePeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effectivePeriod"); // 290
							break;
						case "topic":
							var newItem_topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_topic, reader, outcome, locationPath + ".topic["+result.Topic.Count+"]"); // 300
							result.Topic.Add(newItem_topic);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]"); // 310
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_editor, reader, outcome, locationPath + ".editor["+result.Editor.Count+"]"); // 320
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_reviewer, reader, outcome, locationPath + ".reviewer["+result.Reviewer.Count+"]"); // 330
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_endorser, reader, outcome, locationPath + ".endorser["+result.Endorser.Count+"]"); // 340
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_relatedArtifact, reader, outcome, locationPath + ".relatedArtifact["+result.RelatedArtifact.Count+"]"); // 350
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "library":
							var newItem_library = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_library, reader, outcome, locationPath + ".library["+result.LibraryElement.Count+"]"); // 360
							result.LibraryElement.Add(newItem_library);
							break;
						case "disclaimer":
							result.Disclaimer = new Hl7.Fhir.Model.Markdown();
							Parse(result.Disclaimer as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".disclaimer"); // 370
							break;
						case "scoring":
							result.Scoring = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Scoring as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scoring"); // 380
							break;
						case "compositeScoring":
							result.CompositeScoring = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CompositeScoring as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".compositeScoring"); // 390
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 400
							result.Type.Add(newItem_type);
							break;
						case "riskAdjustment":
							result.RiskAdjustmentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RiskAdjustmentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".riskAdjustment"); // 410
							break;
						case "rateAggregation":
							result.RateAggregationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RateAggregationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".rateAggregation"); // 420
							break;
						case "rationale":
							result.Rationale = new Hl7.Fhir.Model.Markdown();
							Parse(result.Rationale as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".rationale"); // 430
							break;
						case "clinicalRecommendationStatement":
							result.ClinicalRecommendationStatement = new Hl7.Fhir.Model.Markdown();
							Parse(result.ClinicalRecommendationStatement as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".clinicalRecommendationStatement"); // 440
							break;
						case "improvementNotation":
							result.ImprovementNotation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ImprovementNotation as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".improvementNotation"); // 450
							break;
						case "definition":
							var newItem_definition = new Hl7.Fhir.Model.Markdown();
							Parse(newItem_definition, reader, outcome, locationPath + ".definition["+result.Definition.Count+"]"); // 460
							result.Definition.Add(newItem_definition);
							break;
						case "guidance":
							result.Guidance = new Hl7.Fhir.Model.Markdown();
							Parse(result.Guidance as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".guidance"); // 470
							break;
						case "group":
							var newItem_group = new Hl7.Fhir.Model.Measure.GroupComponent();
							Parse(newItem_group, reader, outcome, locationPath + ".group["+result.Group.Count+"]"); // 480
							result.Group.Add(newItem_group);
							break;
						case "supplementalData":
							var newItem_supplementalData = new Hl7.Fhir.Model.Measure.SupplementalDataComponent();
							Parse(newItem_supplementalData, reader, outcome, locationPath + ".supplementalData["+result.SupplementalData.Count+"]"); // 490
							result.SupplementalData.Add(newItem_supplementalData);
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

		private async System.Threading.Tasks.Task ParseAsync(Measure result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url"); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version"); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name"); // 120
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title"); // 130
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subtitle"); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental"); // 160
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subject"); // 170
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 170
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 180
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher"); // 190
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]"); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description"); // 210
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]"); // 220
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]"); // 230
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose"); // 240
							break;
						case "usage":
							result.UsageElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.UsageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".usage"); // 250
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright"); // 260
							break;
						case "approvalDate":
							result.ApprovalDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.ApprovalDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".approvalDate"); // 270
							break;
						case "lastReviewDate":
							result.LastReviewDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.LastReviewDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".lastReviewDate"); // 280
							break;
						case "effectivePeriod":
							result.EffectivePeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.EffectivePeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effectivePeriod"); // 290
							break;
						case "topic":
							var newItem_topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_topic, reader, outcome, locationPath + ".topic["+result.Topic.Count+"]"); // 300
							result.Topic.Add(newItem_topic);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]"); // 310
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_editor, reader, outcome, locationPath + ".editor["+result.Editor.Count+"]"); // 320
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_reviewer, reader, outcome, locationPath + ".reviewer["+result.Reviewer.Count+"]"); // 330
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_endorser, reader, outcome, locationPath + ".endorser["+result.Endorser.Count+"]"); // 340
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_relatedArtifact, reader, outcome, locationPath + ".relatedArtifact["+result.RelatedArtifact.Count+"]"); // 350
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "library":
							var newItem_library = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_library, reader, outcome, locationPath + ".library["+result.LibraryElement.Count+"]"); // 360
							result.LibraryElement.Add(newItem_library);
							break;
						case "disclaimer":
							result.Disclaimer = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Disclaimer as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".disclaimer"); // 370
							break;
						case "scoring":
							result.Scoring = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Scoring as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scoring"); // 380
							break;
						case "compositeScoring":
							result.CompositeScoring = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CompositeScoring as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".compositeScoring"); // 390
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 400
							result.Type.Add(newItem_type);
							break;
						case "riskAdjustment":
							result.RiskAdjustmentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RiskAdjustmentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".riskAdjustment"); // 410
							break;
						case "rateAggregation":
							result.RateAggregationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RateAggregationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".rateAggregation"); // 420
							break;
						case "rationale":
							result.Rationale = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Rationale as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".rationale"); // 430
							break;
						case "clinicalRecommendationStatement":
							result.ClinicalRecommendationStatement = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.ClinicalRecommendationStatement as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".clinicalRecommendationStatement"); // 440
							break;
						case "improvementNotation":
							result.ImprovementNotation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ImprovementNotation as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".improvementNotation"); // 450
							break;
						case "definition":
							var newItem_definition = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(newItem_definition, reader, outcome, locationPath + ".definition["+result.Definition.Count+"]"); // 460
							result.Definition.Add(newItem_definition);
							break;
						case "guidance":
							result.Guidance = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Guidance as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".guidance"); // 470
							break;
						case "group":
							var newItem_group = new Hl7.Fhir.Model.Measure.GroupComponent();
							await ParseAsync(newItem_group, reader, outcome, locationPath + ".group["+result.Group.Count+"]"); // 480
							result.Group.Add(newItem_group);
							break;
						case "supplementalData":
							var newItem_supplementalData = new Hl7.Fhir.Model.Measure.SupplementalDataComponent();
							await ParseAsync(newItem_supplementalData, reader, outcome, locationPath + ".supplementalData["+result.SupplementalData.Count+"]"); // 490
							result.SupplementalData.Add(newItem_supplementalData);
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
