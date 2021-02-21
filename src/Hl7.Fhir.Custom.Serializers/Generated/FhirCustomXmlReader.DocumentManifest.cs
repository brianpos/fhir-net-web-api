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
		private void Parse(DocumentManifest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "masterIdentifier":
							result.MasterIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.MasterIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".masterIdentifier"); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DocumentReferenceStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DocumentReferenceStatus>, reader, outcome, locationPath + ".status"); // 110
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 140
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]"); // 150
							result.Author.Add(newItem_author);
							break;
						case "recipient":
							var newItem_recipient = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_recipient, reader, outcome, locationPath + ".recipient["+result.Recipient.Count+"]"); // 160
							result.Recipient.Add(newItem_recipient);
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.SourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".source"); // 170
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 180
							break;
						case "content":
							var newItem_content = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_content, reader, outcome, locationPath + ".content["+result.Content.Count+"]"); // 190
							result.Content.Add(newItem_content);
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.DocumentManifest.RelatedComponent();
							Parse(newItem_related, reader, outcome, locationPath + ".related["+result.Related.Count+"]"); // 200
							result.Related.Add(newItem_related);
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

		private async System.Threading.Tasks.Task ParseAsync(DocumentManifest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "masterIdentifier":
							result.MasterIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.MasterIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".masterIdentifier"); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DocumentReferenceStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DocumentReferenceStatus>, reader, outcome, locationPath + ".status"); // 110
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 140
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]"); // 150
							result.Author.Add(newItem_author);
							break;
						case "recipient":
							var newItem_recipient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_recipient, reader, outcome, locationPath + ".recipient["+result.Recipient.Count+"]"); // 160
							result.Recipient.Add(newItem_recipient);
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.SourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".source"); // 170
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 180
							break;
						case "content":
							var newItem_content = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_content, reader, outcome, locationPath + ".content["+result.Content.Count+"]"); // 190
							result.Content.Add(newItem_content);
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.DocumentManifest.RelatedComponent();
							await ParseAsync(newItem_related, reader, outcome, locationPath + ".related["+result.Related.Count+"]"); // 200
							result.Related.Add(newItem_related);
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
