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
		private void Parse(CodeSystem result, XmlReader reader, OperationOutcome outcome)
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
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 150
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 170
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome); // 180
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 190
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
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							Parse(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome); // 220
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							Parse(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome); // 230
							break;
						case "caseSensitive":
							result.CaseSensitiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.CaseSensitiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 240
							break;
						case "valueSet":
							result.ValueSetElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 250
							break;
						case "hierarchyMeaning":
							result.HierarchyMeaningElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemHierarchyMeaning>();
							Parse(result.HierarchyMeaningElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemHierarchyMeaning>, reader, outcome); // 260
							break;
						case "compositional":
							result.CompositionalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.CompositionalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 270
							break;
						case "versionNeeded":
							result.VersionNeededElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.VersionNeededElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 280
							break;
						case "content":
							result.ContentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemContentMode>();
							Parse(result.ContentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemContentMode>, reader, outcome); // 290
							break;
						case "supplements":
							result.SupplementsElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.SupplementsElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 300
							break;
						case "count":
							result.CountElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.CountElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 310
							break;
						case "filter":
							var newItem_filter = new Hl7.Fhir.Model.CodeSystem.FilterComponent();
							Parse(newItem_filter, reader, outcome); // 320
							result.Filter.Add(newItem_filter);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.CodeSystem.PropertyComponent();
							Parse(newItem_property, reader, outcome); // 330
							result.Property.Add(newItem_property);
							break;
						case "concept":
							var newItem_concept = new Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent();
							Parse(newItem_concept, reader, outcome); // 340
							result.Concept.Add(newItem_concept);
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

		private async System.Threading.Tasks.Task ParseAsync(CodeSystem result, XmlReader reader, OperationOutcome outcome)
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
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 150
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 170
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome); // 180
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 190
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
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome); // 220
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome); // 230
							break;
						case "caseSensitive":
							result.CaseSensitiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.CaseSensitiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 240
							break;
						case "valueSet":
							result.ValueSetElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 250
							break;
						case "hierarchyMeaning":
							result.HierarchyMeaningElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemHierarchyMeaning>();
							await ParseAsync(result.HierarchyMeaningElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemHierarchyMeaning>, reader, outcome); // 260
							break;
						case "compositional":
							result.CompositionalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.CompositionalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 270
							break;
						case "versionNeeded":
							result.VersionNeededElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.VersionNeededElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 280
							break;
						case "content":
							result.ContentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemContentMode>();
							await ParseAsync(result.ContentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemContentMode>, reader, outcome); // 290
							break;
						case "supplements":
							result.SupplementsElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.SupplementsElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 300
							break;
						case "count":
							result.CountElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.CountElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 310
							break;
						case "filter":
							var newItem_filter = new Hl7.Fhir.Model.CodeSystem.FilterComponent();
							await ParseAsync(newItem_filter, reader, outcome); // 320
							result.Filter.Add(newItem_filter);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.CodeSystem.PropertyComponent();
							await ParseAsync(newItem_property, reader, outcome); // 330
							result.Property.Add(newItem_property);
							break;
						case "concept":
							var newItem_concept = new Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent();
							await ParseAsync(newItem_concept, reader, outcome); // 340
							result.Concept.Add(newItem_concept);
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
