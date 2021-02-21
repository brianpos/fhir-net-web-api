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
		private void Parse(Contract result, XmlReader reader, OperationOutcome outcome)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 100
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>, reader, outcome); // 120
							break;
						case "legalState":
							result.LegalState = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.LegalState as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "instantiatesCanonical":
							result.InstantiatesCanonical = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.InstantiatesCanonical as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "instantiatesUri":
							result.InstantiatesUriElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.InstantiatesUriElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 150
							break;
						case "contentDerivative":
							result.ContentDerivative = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ContentDerivative as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "applies":
							result.Applies = new Hl7.Fhir.Model.Period();
							Parse(result.Applies as Hl7.Fhir.Model.Period, reader, outcome); // 180
							break;
						case "expirationType":
							result.ExpirationType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ExpirationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 190
							break;
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_subject, reader, outcome); // 200
							result.Subject.Add(newItem_subject);
							break;
						case "authority":
							var newItem_authority = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_authority, reader, outcome); // 210
							result.Authority.Add(newItem_authority);
							break;
						case "domain":
							var newItem_domain = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_domain, reader, outcome); // 220
							result.Domain.Add(newItem_domain);
							break;
						case "site":
							var newItem_site = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_site, reader, outcome); // 230
							result.Site.Add(newItem_site);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 240
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 250
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 260
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_alias, reader, outcome); // 270
							result.AliasElement.Add(newItem_alias);
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 280
							break;
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 290
							break;
						case "topicCodeableConcept":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 300
							break;
						case "topicReference":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 310
							break;
						case "subType":
							var newItem_subType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subType, reader, outcome); // 320
							result.SubType.Add(newItem_subType);
							break;
						case "contentDefinition":
							result.ContentDefinition = new Hl7.Fhir.Model.Contract.ContentDefinitionComponent();
							Parse(result.ContentDefinition as Hl7.Fhir.Model.Contract.ContentDefinitionComponent, reader, outcome); // 330
							break;
						case "term":
							var newItem_term = new Hl7.Fhir.Model.Contract.TermComponent();
							Parse(newItem_term, reader, outcome); // 340
							result.Term.Add(newItem_term);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInfo, reader, outcome); // 350
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_relevantHistory, reader, outcome); // 360
							result.RelevantHistory.Add(newItem_relevantHistory);
							break;
						case "signer":
							var newItem_signer = new Hl7.Fhir.Model.Contract.SignatoryComponent();
							Parse(newItem_signer, reader, outcome); // 370
							result.Signer.Add(newItem_signer);
							break;
						case "friendly":
							var newItem_friendly = new Hl7.Fhir.Model.Contract.FriendlyLanguageComponent();
							Parse(newItem_friendly, reader, outcome); // 380
							result.Friendly.Add(newItem_friendly);
							break;
						case "legal":
							var newItem_legal = new Hl7.Fhir.Model.Contract.LegalLanguageComponent();
							Parse(newItem_legal, reader, outcome); // 390
							result.Legal.Add(newItem_legal);
							break;
						case "rule":
							var newItem_rule = new Hl7.Fhir.Model.Contract.ComputableLanguageComponent();
							Parse(newItem_rule, reader, outcome); // 400
							result.Rule.Add(newItem_rule);
							break;
						case "legallyBindingAttachment":
							result.LegallyBinding = new Hl7.Fhir.Model.Attachment();
							Parse(result.LegallyBinding as Hl7.Fhir.Model.Attachment, reader, outcome); // 410
							break;
						case "legallyBindingReference":
							result.LegallyBinding = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.LegallyBinding as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 410
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

		private async System.Threading.Tasks.Task ParseAsync(Contract result, XmlReader reader, OperationOutcome outcome)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 100
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>, reader, outcome); // 120
							break;
						case "legalState":
							result.LegalState = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.LegalState as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "instantiatesCanonical":
							result.InstantiatesCanonical = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.InstantiatesCanonical as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "instantiatesUri":
							result.InstantiatesUriElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.InstantiatesUriElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 150
							break;
						case "contentDerivative":
							result.ContentDerivative = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ContentDerivative as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "applies":
							result.Applies = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Applies as Hl7.Fhir.Model.Period, reader, outcome); // 180
							break;
						case "expirationType":
							result.ExpirationType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ExpirationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 190
							break;
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_subject, reader, outcome); // 200
							result.Subject.Add(newItem_subject);
							break;
						case "authority":
							var newItem_authority = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_authority, reader, outcome); // 210
							result.Authority.Add(newItem_authority);
							break;
						case "domain":
							var newItem_domain = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_domain, reader, outcome); // 220
							result.Domain.Add(newItem_domain);
							break;
						case "site":
							var newItem_site = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_site, reader, outcome); // 230
							result.Site.Add(newItem_site);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 240
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 250
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 260
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_alias, reader, outcome); // 270
							result.AliasElement.Add(newItem_alias);
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 280
							break;
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 290
							break;
						case "topicCodeableConcept":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 300
							break;
						case "topicReference":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 310
							break;
						case "subType":
							var newItem_subType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subType, reader, outcome); // 320
							result.SubType.Add(newItem_subType);
							break;
						case "contentDefinition":
							result.ContentDefinition = new Hl7.Fhir.Model.Contract.ContentDefinitionComponent();
							await ParseAsync(result.ContentDefinition as Hl7.Fhir.Model.Contract.ContentDefinitionComponent, reader, outcome); // 330
							break;
						case "term":
							var newItem_term = new Hl7.Fhir.Model.Contract.TermComponent();
							await ParseAsync(newItem_term, reader, outcome); // 340
							result.Term.Add(newItem_term);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInfo, reader, outcome); // 350
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_relevantHistory, reader, outcome); // 360
							result.RelevantHistory.Add(newItem_relevantHistory);
							break;
						case "signer":
							var newItem_signer = new Hl7.Fhir.Model.Contract.SignatoryComponent();
							await ParseAsync(newItem_signer, reader, outcome); // 370
							result.Signer.Add(newItem_signer);
							break;
						case "friendly":
							var newItem_friendly = new Hl7.Fhir.Model.Contract.FriendlyLanguageComponent();
							await ParseAsync(newItem_friendly, reader, outcome); // 380
							result.Friendly.Add(newItem_friendly);
							break;
						case "legal":
							var newItem_legal = new Hl7.Fhir.Model.Contract.LegalLanguageComponent();
							await ParseAsync(newItem_legal, reader, outcome); // 390
							result.Legal.Add(newItem_legal);
							break;
						case "rule":
							var newItem_rule = new Hl7.Fhir.Model.Contract.ComputableLanguageComponent();
							await ParseAsync(newItem_rule, reader, outcome); // 400
							result.Rule.Add(newItem_rule);
							break;
						case "legallyBindingAttachment":
							result.LegallyBinding = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.LegallyBinding as Hl7.Fhir.Model.Attachment, reader, outcome); // 410
							break;
						case "legallyBindingReference":
							result.LegallyBinding = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.LegallyBinding as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 410
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
