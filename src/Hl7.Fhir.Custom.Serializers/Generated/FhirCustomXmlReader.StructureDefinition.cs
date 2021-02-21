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
		private void Parse(StructureDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "keyword":
							var newItem_keyword = new Hl7.Fhir.Model.Coding();
							Parse(newItem_keyword, reader, outcome); // 240
							result.Keyword.Add(newItem_keyword);
							break;
						case "fhirVersion":
							result.FhirVersionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>();
							Parse(result.FhirVersionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>, reader, outcome); // 250
							break;
						case "mapping":
							var newItem_mapping = new Hl7.Fhir.Model.StructureDefinition.MappingComponent();
							Parse(newItem_mapping, reader, outcome); // 260
							result.Mapping.Add(newItem_mapping);
							break;
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind>();
							Parse(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind>, reader, outcome); // 270
							break;
						case "abstract":
							result.AbstractElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AbstractElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 280
							break;
						case "context":
							var newItem_context = new Hl7.Fhir.Model.StructureDefinition.ContextComponent();
							Parse(newItem_context, reader, outcome); // 290
							result.Context.Add(newItem_context);
							break;
						case "contextInvariant":
							var newItem_contextInvariant = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_contextInvariant, reader, outcome); // 300
							result.ContextInvariantElement.Add(newItem_contextInvariant);
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.TypeElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 310
							break;
						case "baseDefinition":
							result.BaseDefinitionElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.BaseDefinitionElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 320
							break;
						case "derivation":
							result.DerivationElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule>();
							Parse(result.DerivationElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule>, reader, outcome); // 330
							break;
						case "snapshot":
							result.Snapshot = new Hl7.Fhir.Model.StructureDefinition.SnapshotComponent();
							Parse(result.Snapshot as Hl7.Fhir.Model.StructureDefinition.SnapshotComponent, reader, outcome); // 340
							break;
						case "differential":
							result.Differential = new Hl7.Fhir.Model.StructureDefinition.DifferentialComponent();
							Parse(result.Differential as Hl7.Fhir.Model.StructureDefinition.DifferentialComponent, reader, outcome); // 350
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

		private async System.Threading.Tasks.Task ParseAsync(StructureDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "keyword":
							var newItem_keyword = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_keyword, reader, outcome); // 240
							result.Keyword.Add(newItem_keyword);
							break;
						case "fhirVersion":
							result.FhirVersionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>();
							await ParseAsync(result.FhirVersionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>, reader, outcome); // 250
							break;
						case "mapping":
							var newItem_mapping = new Hl7.Fhir.Model.StructureDefinition.MappingComponent();
							await ParseAsync(newItem_mapping, reader, outcome); // 260
							result.Mapping.Add(newItem_mapping);
							break;
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind>();
							await ParseAsync(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind>, reader, outcome); // 270
							break;
						case "abstract":
							result.AbstractElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AbstractElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 280
							break;
						case "context":
							var newItem_context = new Hl7.Fhir.Model.StructureDefinition.ContextComponent();
							await ParseAsync(newItem_context, reader, outcome); // 290
							result.Context.Add(newItem_context);
							break;
						case "contextInvariant":
							var newItem_contextInvariant = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_contextInvariant, reader, outcome); // 300
							result.ContextInvariantElement.Add(newItem_contextInvariant);
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 310
							break;
						case "baseDefinition":
							result.BaseDefinitionElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.BaseDefinitionElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 320
							break;
						case "derivation":
							result.DerivationElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule>();
							await ParseAsync(result.DerivationElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule>, reader, outcome); // 330
							break;
						case "snapshot":
							result.Snapshot = new Hl7.Fhir.Model.StructureDefinition.SnapshotComponent();
							await ParseAsync(result.Snapshot as Hl7.Fhir.Model.StructureDefinition.SnapshotComponent, reader, outcome); // 340
							break;
						case "differential":
							result.Differential = new Hl7.Fhir.Model.StructureDefinition.DifferentialComponent();
							await ParseAsync(result.Differential as Hl7.Fhir.Model.StructureDefinition.DifferentialComponent, reader, outcome); // 350
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
