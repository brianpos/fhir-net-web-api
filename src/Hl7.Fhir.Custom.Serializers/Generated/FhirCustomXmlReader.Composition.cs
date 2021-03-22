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
		private void Parse(Composition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 150
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 160
							result.Author.Add(newItem_author);
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 170
							break;
						case "confidentiality":
							result.ConfidentialityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>();
							Parse(result.ConfidentialityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>, reader, outcome, locationPath + ".confidentiality", cancellationToken); // 180
							break;
						case "attester":
							var newItem_attester = new Hl7.Fhir.Model.Composition.AttesterComponent();
							Parse(newItem_attester, reader, outcome, locationPath + ".attester["+result.Attester.Count+"]", cancellationToken); // 190
							result.Attester.Add(newItem_attester);
							break;
						case "custodian":
							result.Custodian = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Custodian as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".custodian", cancellationToken); // 200
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.Composition.RelatesToComponent();
							Parse(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]", cancellationToken); // 210
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "event":
							var newItem_event = new Hl7.Fhir.Model.Composition.EventComponent();
							Parse(newItem_event, reader, outcome, locationPath + ".event["+result.Event.Count+"]", cancellationToken); // 220
							result.Event.Add(newItem_event);
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.Composition.SectionComponent();
							Parse(newItem_section, reader, outcome, locationPath + ".section["+result.Section.Count+"]", cancellationToken); // 230
							result.Section.Add(newItem_section);
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

		private async System.Threading.Tasks.Task ParseAsync(Composition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 150
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 160
							result.Author.Add(newItem_author);
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 170
							break;
						case "confidentiality":
							result.ConfidentialityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>();
							await ParseAsync(result.ConfidentialityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>, reader, outcome, locationPath + ".confidentiality", cancellationToken); // 180
							break;
						case "attester":
							var newItem_attester = new Hl7.Fhir.Model.Composition.AttesterComponent();
							await ParseAsync(newItem_attester, reader, outcome, locationPath + ".attester["+result.Attester.Count+"]", cancellationToken); // 190
							result.Attester.Add(newItem_attester);
							break;
						case "custodian":
							result.Custodian = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Custodian as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".custodian", cancellationToken); // 200
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.Composition.RelatesToComponent();
							await ParseAsync(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]", cancellationToken); // 210
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "event":
							var newItem_event = new Hl7.Fhir.Model.Composition.EventComponent();
							await ParseAsync(newItem_event, reader, outcome, locationPath + ".event["+result.Event.Count+"]", cancellationToken); // 220
							result.Event.Add(newItem_event);
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.Composition.SectionComponent();
							await ParseAsync(newItem_section, reader, outcome, locationPath + ".section["+result.Section.Count+"]", cancellationToken); // 230
							result.Section.Add(newItem_section);
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
