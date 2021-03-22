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
		private void Parse(OperationDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationDefinition.OperationKind>();
							Parse(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationDefinition.OperationKind>, reader, outcome, locationPath + ".kind", cancellationToken); // 140
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental", cancellationToken); // 150
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 160
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 170
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 180
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 190
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							Parse(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 200
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 210
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							Parse(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose", cancellationToken); // 220
							break;
						case "affectsState":
							result.AffectsStateElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AffectsStateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".affectsState", cancellationToken); // 230
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 240
							break;
						case "comment":
							result.Comment = new Hl7.Fhir.Model.Markdown();
							Parse(result.Comment as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".comment", cancellationToken); // 250
							break;
						case "base":
							result.BaseElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.BaseElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".base", cancellationToken); // 260
							break;
						case "resource":
							var newItem_resource = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							Parse(newItem_resource, reader, outcome, locationPath + ".resource["+result.ResourceElement.Count+"]", cancellationToken); // 270
							result.ResourceElement.Add(newItem_resource);
							break;
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.SystemElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".system", cancellationToken); // 280
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.TypeElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".type", cancellationToken); // 290
							break;
						case "instance":
							result.InstanceElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.InstanceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".instance", cancellationToken); // 300
							break;
						case "inputProfile":
							result.InputProfileElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.InputProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".inputProfile", cancellationToken); // 310
							break;
						case "outputProfile":
							result.OutputProfileElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.OutputProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".outputProfile", cancellationToken); // 320
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.OperationDefinition.ParameterComponent();
							Parse(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]", cancellationToken); // 330
							result.Parameter.Add(newItem_parameter);
							break;
						case "overload":
							var newItem_overload = new Hl7.Fhir.Model.OperationDefinition.OverloadComponent();
							Parse(newItem_overload, reader, outcome, locationPath + ".overload["+result.Overload.Count+"]", cancellationToken); // 340
							result.Overload.Add(newItem_overload);
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

		private async System.Threading.Tasks.Task ParseAsync(OperationDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationDefinition.OperationKind>();
							await ParseAsync(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationDefinition.OperationKind>, reader, outcome, locationPath + ".kind", cancellationToken); // 140
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental", cancellationToken); // 150
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 160
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 170
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 180
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 190
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 200
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 210
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose", cancellationToken); // 220
							break;
						case "affectsState":
							result.AffectsStateElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AffectsStateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".affectsState", cancellationToken); // 230
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 240
							break;
						case "comment":
							result.Comment = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Comment as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".comment", cancellationToken); // 250
							break;
						case "base":
							result.BaseElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.BaseElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".base", cancellationToken); // 260
							break;
						case "resource":
							var newItem_resource = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							await ParseAsync(newItem_resource, reader, outcome, locationPath + ".resource["+result.ResourceElement.Count+"]", cancellationToken); // 270
							result.ResourceElement.Add(newItem_resource);
							break;
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.SystemElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".system", cancellationToken); // 280
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".type", cancellationToken); // 290
							break;
						case "instance":
							result.InstanceElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.InstanceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".instance", cancellationToken); // 300
							break;
						case "inputProfile":
							result.InputProfileElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.InputProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".inputProfile", cancellationToken); // 310
							break;
						case "outputProfile":
							result.OutputProfileElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.OutputProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".outputProfile", cancellationToken); // 320
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.OperationDefinition.ParameterComponent();
							await ParseAsync(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]", cancellationToken); // 330
							result.Parameter.Add(newItem_parameter);
							break;
						case "overload":
							var newItem_overload = new Hl7.Fhir.Model.OperationDefinition.OverloadComponent();
							await ParseAsync(newItem_overload, reader, outcome, locationPath + ".overload["+result.Overload.Count+"]", cancellationToken); // 340
							result.Overload.Add(newItem_overload);
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
