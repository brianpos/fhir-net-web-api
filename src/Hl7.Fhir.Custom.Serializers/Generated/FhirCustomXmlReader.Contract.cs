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
		private void Parse(Contract result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url"); // 100
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version"); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 120
							break;
						case "legalState":
							result.LegalState = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.LegalState as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalState"); // 130
							break;
						case "instantiatesCanonical":
							result.InstantiatesCanonical = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.InstantiatesCanonical as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".instantiatesCanonical"); // 140
							break;
						case "instantiatesUri":
							result.InstantiatesUriElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.InstantiatesUriElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".instantiatesUri"); // 150
							break;
						case "contentDerivative":
							result.ContentDerivative = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ContentDerivative as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".contentDerivative"); // 160
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".issued"); // 170
							break;
						case "applies":
							result.Applies = new Hl7.Fhir.Model.Period();
							Parse(result.Applies as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".applies"); // 180
							break;
						case "expirationType":
							result.ExpirationType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ExpirationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".expirationType"); // 190
							break;
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]"); // 200
							result.Subject.Add(newItem_subject);
							break;
						case "authority":
							var newItem_authority = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_authority, reader, outcome, locationPath + ".authority["+result.Authority.Count+"]"); // 210
							result.Authority.Add(newItem_authority);
							break;
						case "domain":
							var newItem_domain = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_domain, reader, outcome, locationPath + ".domain["+result.Domain.Count+"]"); // 220
							result.Domain.Add(newItem_domain);
							break;
						case "site":
							var newItem_site = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_site, reader, outcome, locationPath + ".site["+result.Site.Count+"]"); // 230
							result.Site.Add(newItem_site);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name"); // 240
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title"); // 250
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subtitle"); // 260
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_alias, reader, outcome, locationPath + ".alias["+result.AliasElement.Count+"]"); // 270
							result.AliasElement.Add(newItem_alias);
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".author"); // 280
							break;
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scope"); // 290
							break;
						case "topicCodeableConcept":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".topic"); // 300
							break;
						case "topicReference":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".topic"); // 300
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 310
							break;
						case "subType":
							var newItem_subType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subType, reader, outcome, locationPath + ".subType["+result.SubType.Count+"]"); // 320
							result.SubType.Add(newItem_subType);
							break;
						case "contentDefinition":
							result.ContentDefinition = new Hl7.Fhir.Model.Contract.ContentDefinitionComponent();
							Parse(result.ContentDefinition as Hl7.Fhir.Model.Contract.ContentDefinitionComponent, reader, outcome, locationPath + ".contentDefinition"); // 330
							break;
						case "term":
							var newItem_term = new Hl7.Fhir.Model.Contract.TermComponent();
							Parse(newItem_term, reader, outcome, locationPath + ".term["+result.Term.Count+"]"); // 340
							result.Term.Add(newItem_term);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]"); // 350
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_relevantHistory, reader, outcome, locationPath + ".relevantHistory["+result.RelevantHistory.Count+"]"); // 360
							result.RelevantHistory.Add(newItem_relevantHistory);
							break;
						case "signer":
							var newItem_signer = new Hl7.Fhir.Model.Contract.SignatoryComponent();
							Parse(newItem_signer, reader, outcome, locationPath + ".signer["+result.Signer.Count+"]"); // 370
							result.Signer.Add(newItem_signer);
							break;
						case "friendly":
							var newItem_friendly = new Hl7.Fhir.Model.Contract.FriendlyLanguageComponent();
							Parse(newItem_friendly, reader, outcome, locationPath + ".friendly["+result.Friendly.Count+"]"); // 380
							result.Friendly.Add(newItem_friendly);
							break;
						case "legal":
							var newItem_legal = new Hl7.Fhir.Model.Contract.LegalLanguageComponent();
							Parse(newItem_legal, reader, outcome, locationPath + ".legal["+result.Legal.Count+"]"); // 390
							result.Legal.Add(newItem_legal);
							break;
						case "rule":
							var newItem_rule = new Hl7.Fhir.Model.Contract.ComputableLanguageComponent();
							Parse(newItem_rule, reader, outcome, locationPath + ".rule["+result.Rule.Count+"]"); // 400
							result.Rule.Add(newItem_rule);
							break;
						case "legallyBindingAttachment":
							result.LegallyBinding = new Hl7.Fhir.Model.Attachment();
							Parse(result.LegallyBinding as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".legallyBinding"); // 410
							break;
						case "legallyBindingReference":
							result.LegallyBinding = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.LegallyBinding as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".legallyBinding"); // 410
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

		private async System.Threading.Tasks.Task ParseAsync(Contract result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url"); // 100
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version"); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 120
							break;
						case "legalState":
							result.LegalState = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.LegalState as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalState"); // 130
							break;
						case "instantiatesCanonical":
							result.InstantiatesCanonical = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.InstantiatesCanonical as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".instantiatesCanonical"); // 140
							break;
						case "instantiatesUri":
							result.InstantiatesUriElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.InstantiatesUriElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".instantiatesUri"); // 150
							break;
						case "contentDerivative":
							result.ContentDerivative = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ContentDerivative as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".contentDerivative"); // 160
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".issued"); // 170
							break;
						case "applies":
							result.Applies = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Applies as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".applies"); // 180
							break;
						case "expirationType":
							result.ExpirationType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ExpirationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".expirationType"); // 190
							break;
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]"); // 200
							result.Subject.Add(newItem_subject);
							break;
						case "authority":
							var newItem_authority = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_authority, reader, outcome, locationPath + ".authority["+result.Authority.Count+"]"); // 210
							result.Authority.Add(newItem_authority);
							break;
						case "domain":
							var newItem_domain = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_domain, reader, outcome, locationPath + ".domain["+result.Domain.Count+"]"); // 220
							result.Domain.Add(newItem_domain);
							break;
						case "site":
							var newItem_site = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_site, reader, outcome, locationPath + ".site["+result.Site.Count+"]"); // 230
							result.Site.Add(newItem_site);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name"); // 240
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title"); // 250
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subtitle"); // 260
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_alias, reader, outcome, locationPath + ".alias["+result.AliasElement.Count+"]"); // 270
							result.AliasElement.Add(newItem_alias);
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".author"); // 280
							break;
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scope"); // 290
							break;
						case "topicCodeableConcept":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".topic"); // 300
							break;
						case "topicReference":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".topic"); // 300
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 310
							break;
						case "subType":
							var newItem_subType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subType, reader, outcome, locationPath + ".subType["+result.SubType.Count+"]"); // 320
							result.SubType.Add(newItem_subType);
							break;
						case "contentDefinition":
							result.ContentDefinition = new Hl7.Fhir.Model.Contract.ContentDefinitionComponent();
							await ParseAsync(result.ContentDefinition as Hl7.Fhir.Model.Contract.ContentDefinitionComponent, reader, outcome, locationPath + ".contentDefinition"); // 330
							break;
						case "term":
							var newItem_term = new Hl7.Fhir.Model.Contract.TermComponent();
							await ParseAsync(newItem_term, reader, outcome, locationPath + ".term["+result.Term.Count+"]"); // 340
							result.Term.Add(newItem_term);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]"); // 350
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_relevantHistory, reader, outcome, locationPath + ".relevantHistory["+result.RelevantHistory.Count+"]"); // 360
							result.RelevantHistory.Add(newItem_relevantHistory);
							break;
						case "signer":
							var newItem_signer = new Hl7.Fhir.Model.Contract.SignatoryComponent();
							await ParseAsync(newItem_signer, reader, outcome, locationPath + ".signer["+result.Signer.Count+"]"); // 370
							result.Signer.Add(newItem_signer);
							break;
						case "friendly":
							var newItem_friendly = new Hl7.Fhir.Model.Contract.FriendlyLanguageComponent();
							await ParseAsync(newItem_friendly, reader, outcome, locationPath + ".friendly["+result.Friendly.Count+"]"); // 380
							result.Friendly.Add(newItem_friendly);
							break;
						case "legal":
							var newItem_legal = new Hl7.Fhir.Model.Contract.LegalLanguageComponent();
							await ParseAsync(newItem_legal, reader, outcome, locationPath + ".legal["+result.Legal.Count+"]"); // 390
							result.Legal.Add(newItem_legal);
							break;
						case "rule":
							var newItem_rule = new Hl7.Fhir.Model.Contract.ComputableLanguageComponent();
							await ParseAsync(newItem_rule, reader, outcome, locationPath + ".rule["+result.Rule.Count+"]"); // 400
							result.Rule.Add(newItem_rule);
							break;
						case "legallyBindingAttachment":
							result.LegallyBinding = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.LegallyBinding as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".legallyBinding"); // 410
							break;
						case "legallyBindingReference":
							result.LegallyBinding = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.LegallyBinding as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".legallyBinding"); // 410
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
