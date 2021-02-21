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
		private void Parse(DocumentReference result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "docStatus":
							result.DocStatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>();
							Parse(result.DocStatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>, reader, outcome, locationPath + ".docStatus"); // 120
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 130
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 140
							result.Category.Add(newItem_category);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 150
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.Instant();
							Parse(result.DateElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".date"); // 160
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]"); // 170
							result.Author.Add(newItem_author);
							break;
						case "authenticator":
							result.Authenticator = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Authenticator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".authenticator"); // 180
							break;
						case "custodian":
							result.Custodian = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Custodian as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".custodian"); // 190
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.DocumentReference.RelatesToComponent();
							Parse(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]"); // 200
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 210
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_securityLabel, reader, outcome, locationPath + ".securityLabel["+result.SecurityLabel.Count+"]"); // 220
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "content":
							var newItem_content = new Hl7.Fhir.Model.DocumentReference.ContentComponent();
							Parse(newItem_content, reader, outcome, locationPath + ".content["+result.Content.Count+"]"); // 230
							result.Content.Add(newItem_content);
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.DocumentReference.ContextComponent();
							Parse(result.Context as Hl7.Fhir.Model.DocumentReference.ContextComponent, reader, outcome, locationPath + ".context"); // 240
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

		private async System.Threading.Tasks.Task ParseAsync(DocumentReference result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "docStatus":
							result.DocStatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>();
							await ParseAsync(result.DocStatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus>, reader, outcome, locationPath + ".docStatus"); // 120
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 130
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 140
							result.Category.Add(newItem_category);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 150
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".date"); // 160
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]"); // 170
							result.Author.Add(newItem_author);
							break;
						case "authenticator":
							result.Authenticator = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Authenticator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".authenticator"); // 180
							break;
						case "custodian":
							result.Custodian = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Custodian as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".custodian"); // 190
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.DocumentReference.RelatesToComponent();
							await ParseAsync(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]"); // 200
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 210
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_securityLabel, reader, outcome, locationPath + ".securityLabel["+result.SecurityLabel.Count+"]"); // 220
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "content":
							var newItem_content = new Hl7.Fhir.Model.DocumentReference.ContentComponent();
							await ParseAsync(newItem_content, reader, outcome, locationPath + ".content["+result.Content.Count+"]"); // 230
							result.Content.Add(newItem_content);
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.DocumentReference.ContextComponent();
							await ParseAsync(result.Context as Hl7.Fhir.Model.DocumentReference.ContextComponent, reader, outcome, locationPath + ".context"); // 240
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
