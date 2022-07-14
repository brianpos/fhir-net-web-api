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
		private void Parse(CapabilityStatement result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 120
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
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							Parse(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright", cancellationToken); // 220
							break;
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatementKind>();
							Parse(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatementKind>, reader, outcome, locationPath + ".kind", cancellationToken); // 230
							break;
						case "instantiates":
							var newItem_instantiates = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiates, reader, outcome, locationPath + ".instantiates["+result.InstantiatesElement.Count+"]", cancellationToken); // 240
							result.InstantiatesElement.Add(newItem_instantiates);
							break;
						case "imports":
							var newItem_imports = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_imports, reader, outcome, locationPath + ".imports["+result.ImportsElement.Count+"]", cancellationToken); // 250
							result.ImportsElement.Add(newItem_imports);
							break;
						case "software":
							result.Software = new Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent();
							Parse(result.Software as Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent, reader, outcome, locationPath + ".software", cancellationToken); // 260
							break;
						case "implementation":
							result.Implementation = new Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent();
							Parse(result.Implementation as Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent, reader, outcome, locationPath + ".implementation", cancellationToken); // 270
							break;
						case "fhirVersion":
							result.FhirVersionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>();
							Parse(result.FhirVersionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>, reader, outcome, locationPath + ".fhirVersion", cancellationToken); // 280
							break;
						case "format":
							var newItem_format = new Hl7.Fhir.Model.Code();
							Parse(newItem_format, reader, outcome, locationPath + ".format["+result.FormatElement.Count+"]", cancellationToken); // 290
							result.FormatElement.Add(newItem_format);
							break;
						case "patchFormat":
							var newItem_patchFormat = new Hl7.Fhir.Model.Code();
							Parse(newItem_patchFormat, reader, outcome, locationPath + ".patchFormat["+result.PatchFormatElement.Count+"]", cancellationToken); // 300
							result.PatchFormatElement.Add(newItem_patchFormat);
							break;
						case "implementationGuide":
							var newItem_implementationGuide = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_implementationGuide, reader, outcome, locationPath + ".implementationGuide["+result.ImplementationGuideElement.Count+"]", cancellationToken); // 310
							result.ImplementationGuideElement.Add(newItem_implementationGuide);
							break;
						case "rest":
							var newItem_rest = new Hl7.Fhir.Model.CapabilityStatement.RestComponent();
							Parse(newItem_rest, reader, outcome, locationPath + ".rest["+result.Rest.Count+"]", cancellationToken); // 320
							result.Rest.Add(newItem_rest);
							break;
						case "messaging":
							var newItem_messaging = new Hl7.Fhir.Model.CapabilityStatement.MessagingComponent();
							Parse(newItem_messaging, reader, outcome, locationPath + ".messaging["+result.Messaging.Count+"]", cancellationToken); // 330
							result.Messaging.Add(newItem_messaging);
							break;
						case "document":
							var newItem_document = new Hl7.Fhir.Model.CapabilityStatement.DocumentComponent();
							Parse(newItem_document, reader, outcome, locationPath + ".document["+result.Document.Count+"]", cancellationToken); // 340
							result.Document.Add(newItem_document);
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

		private async System.Threading.Tasks.Task ParseAsync(CapabilityStatement result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 120
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
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright", cancellationToken); // 220
							break;
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatementKind>();
							await ParseAsync(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatementKind>, reader, outcome, locationPath + ".kind", cancellationToken); // 230
							break;
						case "instantiates":
							var newItem_instantiates = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiates, reader, outcome, locationPath + ".instantiates["+result.InstantiatesElement.Count+"]", cancellationToken); // 240
							result.InstantiatesElement.Add(newItem_instantiates);
							break;
						case "imports":
							var newItem_imports = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_imports, reader, outcome, locationPath + ".imports["+result.ImportsElement.Count+"]", cancellationToken); // 250
							result.ImportsElement.Add(newItem_imports);
							break;
						case "software":
							result.Software = new Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent();
							await ParseAsync(result.Software as Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent, reader, outcome, locationPath + ".software", cancellationToken); // 260
							break;
						case "implementation":
							result.Implementation = new Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent();
							await ParseAsync(result.Implementation as Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent, reader, outcome, locationPath + ".implementation", cancellationToken); // 270
							break;
						case "fhirVersion":
							result.FhirVersionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>();
							await ParseAsync(result.FhirVersionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>, reader, outcome, locationPath + ".fhirVersion", cancellationToken); // 280
							break;
						case "format":
							var newItem_format = new Hl7.Fhir.Model.Code();
							await ParseAsync(newItem_format, reader, outcome, locationPath + ".format["+result.FormatElement.Count+"]", cancellationToken); // 290
							result.FormatElement.Add(newItem_format);
							break;
						case "patchFormat":
							var newItem_patchFormat = new Hl7.Fhir.Model.Code();
							await ParseAsync(newItem_patchFormat, reader, outcome, locationPath + ".patchFormat["+result.PatchFormatElement.Count+"]", cancellationToken); // 300
							result.PatchFormatElement.Add(newItem_patchFormat);
							break;
						case "implementationGuide":
							var newItem_implementationGuide = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_implementationGuide, reader, outcome, locationPath + ".implementationGuide["+result.ImplementationGuideElement.Count+"]", cancellationToken); // 310
							result.ImplementationGuideElement.Add(newItem_implementationGuide);
							break;
						case "rest":
							var newItem_rest = new Hl7.Fhir.Model.CapabilityStatement.RestComponent();
							await ParseAsync(newItem_rest, reader, outcome, locationPath + ".rest["+result.Rest.Count+"]", cancellationToken); // 320
							result.Rest.Add(newItem_rest);
							break;
						case "messaging":
							var newItem_messaging = new Hl7.Fhir.Model.CapabilityStatement.MessagingComponent();
							await ParseAsync(newItem_messaging, reader, outcome, locationPath + ".messaging["+result.Messaging.Count+"]", cancellationToken); // 330
							result.Messaging.Add(newItem_messaging);
							break;
						case "document":
							var newItem_document = new Hl7.Fhir.Model.CapabilityStatement.DocumentComponent();
							await ParseAsync(newItem_document, reader, outcome, locationPath + ".document["+result.Document.Count+"]", cancellationToken); // 340
							result.Document.Add(newItem_document);
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
