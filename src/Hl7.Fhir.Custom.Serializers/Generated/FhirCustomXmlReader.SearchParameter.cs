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
		private void Parse(SearchParameter result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url", cancellationToken); // 90
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 100
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 110
							break;
						case "derivedFrom":
							result.DerivedFromElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.DerivedFromElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".derivedFrom", cancellationToken); // 120
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental", cancellationToken); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 150
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 160
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 170
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 180
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							Parse(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 190
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 200
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							Parse(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose", cancellationToken); // 210
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 220
							break;
						case "base":
							var newItem_base = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							Parse(newItem_base, reader, outcome, locationPath + ".base["+result.BaseElement.Count+"]", cancellationToken); // 230
							result.BaseElement.Add(newItem_base);
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>, reader, outcome, locationPath + ".type", cancellationToken); // 240
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".expression", cancellationToken); // 250
							break;
						case "xpath":
							result.XpathElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.XpathElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".xpath", cancellationToken); // 260
							break;
						case "xpathUsage":
							result.XpathUsageElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType>();
							Parse(result.XpathUsageElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType>, reader, outcome, locationPath + ".xpathUsage", cancellationToken); // 270
							break;
						case "target":
							var newItem_target = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							Parse(newItem_target, reader, outcome, locationPath + ".target["+result.TargetElement.Count+"]", cancellationToken); // 280
							result.TargetElement.Add(newItem_target);
							break;
						case "multipleOr":
							result.MultipleOrElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.MultipleOrElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".multipleOr", cancellationToken); // 290
							break;
						case "multipleAnd":
							result.MultipleAndElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.MultipleAndElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".multipleAnd", cancellationToken); // 300
							break;
						case "comparator":
							var newItem_comparator = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.SearchComparator>();
							Parse(newItem_comparator, reader, outcome, locationPath + ".comparator["+result.ComparatorElement.Count+"]", cancellationToken); // 310
							result.ComparatorElement.Add(newItem_comparator);
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.SearchModifierCode>();
							Parse(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.ModifierElement.Count+"]", cancellationToken); // 320
							result.ModifierElement.Add(newItem_modifier);
							break;
						case "chain":
							var newItem_chain = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_chain, reader, outcome, locationPath + ".chain["+result.ChainElement.Count+"]", cancellationToken); // 330
							result.ChainElement.Add(newItem_chain);
							break;
						case "component":
							var newItem_component = new Hl7.Fhir.Model.SearchParameter.ComponentComponent();
							Parse(newItem_component, reader, outcome, locationPath + ".component["+result.Component.Count+"]", cancellationToken); // 340
							result.Component.Add(newItem_component);
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

		private async System.Threading.Tasks.Task ParseAsync(SearchParameter result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url", cancellationToken); // 90
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 100
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 110
							break;
						case "derivedFrom":
							result.DerivedFromElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.DerivedFromElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".derivedFrom", cancellationToken); // 120
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental", cancellationToken); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 150
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 160
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 170
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 180
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 190
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 200
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose", cancellationToken); // 210
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 220
							break;
						case "base":
							var newItem_base = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							await ParseAsync(newItem_base, reader, outcome, locationPath + ".base["+result.BaseElement.Count+"]", cancellationToken); // 230
							result.BaseElement.Add(newItem_base);
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>, reader, outcome, locationPath + ".type", cancellationToken); // 240
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".expression", cancellationToken); // 250
							break;
						case "xpath":
							result.XpathElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.XpathElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".xpath", cancellationToken); // 260
							break;
						case "xpathUsage":
							result.XpathUsageElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType>();
							await ParseAsync(result.XpathUsageElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType>, reader, outcome, locationPath + ".xpathUsage", cancellationToken); // 270
							break;
						case "target":
							var newItem_target = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							await ParseAsync(newItem_target, reader, outcome, locationPath + ".target["+result.TargetElement.Count+"]", cancellationToken); // 280
							result.TargetElement.Add(newItem_target);
							break;
						case "multipleOr":
							result.MultipleOrElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.MultipleOrElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".multipleOr", cancellationToken); // 290
							break;
						case "multipleAnd":
							result.MultipleAndElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.MultipleAndElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".multipleAnd", cancellationToken); // 300
							break;
						case "comparator":
							var newItem_comparator = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.SearchComparator>();
							await ParseAsync(newItem_comparator, reader, outcome, locationPath + ".comparator["+result.ComparatorElement.Count+"]", cancellationToken); // 310
							result.ComparatorElement.Add(newItem_comparator);
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.SearchModifierCode>();
							await ParseAsync(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.ModifierElement.Count+"]", cancellationToken); // 320
							result.ModifierElement.Add(newItem_modifier);
							break;
						case "chain":
							var newItem_chain = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_chain, reader, outcome, locationPath + ".chain["+result.ChainElement.Count+"]", cancellationToken); // 330
							result.ChainElement.Add(newItem_chain);
							break;
						case "component":
							var newItem_component = new Hl7.Fhir.Model.SearchParameter.ComponentComponent();
							await ParseAsync(newItem_component, reader, outcome, locationPath + ".component["+result.Component.Count+"]", cancellationToken); // 340
							result.Component.Add(newItem_component);
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
