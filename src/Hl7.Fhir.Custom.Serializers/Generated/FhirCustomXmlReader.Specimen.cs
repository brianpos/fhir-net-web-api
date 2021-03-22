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
		private void Parse(Specimen result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "accessionIdentifier":
							result.AccessionIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.AccessionIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".accessionIdentifier", cancellationToken); // 100
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 110
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "receivedTime":
							result.ReceivedTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ReceivedTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".receivedTime", cancellationToken); // 140
							break;
						case "parent":
							var newItem_parent = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_parent, reader, outcome, locationPath + ".parent["+result.Parent.Count+"]", cancellationToken); // 150
							result.Parent.Add(newItem_parent);
							break;
						case "request":
							var newItem_request = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_request, reader, outcome, locationPath + ".request["+result.Request.Count+"]", cancellationToken); // 160
							result.Request.Add(newItem_request);
							break;
						case "collection":
							result.Collection = new Hl7.Fhir.Model.Specimen.CollectionComponent();
							Parse(result.Collection as Hl7.Fhir.Model.Specimen.CollectionComponent, reader, outcome, locationPath + ".collection", cancellationToken); // 170
							break;
						case "processing":
							var newItem_processing = new Hl7.Fhir.Model.Specimen.ProcessingComponent();
							Parse(newItem_processing, reader, outcome, locationPath + ".processing["+result.Processing.Count+"]", cancellationToken); // 180
							result.Processing.Add(newItem_processing);
							break;
						case "container":
							var newItem_container = new Hl7.Fhir.Model.Specimen.ContainerComponent();
							Parse(newItem_container, reader, outcome, locationPath + ".container["+result.Container.Count+"]", cancellationToken); // 190
							result.Container.Add(newItem_container);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_condition, reader, outcome, locationPath + ".condition["+result.Condition.Count+"]", cancellationToken); // 200
							result.Condition.Add(newItem_condition);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 210
							result.Note.Add(newItem_note);
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

		private async System.Threading.Tasks.Task ParseAsync(Specimen result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "accessionIdentifier":
							result.AccessionIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.AccessionIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".accessionIdentifier", cancellationToken); // 100
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 110
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "receivedTime":
							result.ReceivedTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ReceivedTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".receivedTime", cancellationToken); // 140
							break;
						case "parent":
							var newItem_parent = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_parent, reader, outcome, locationPath + ".parent["+result.Parent.Count+"]", cancellationToken); // 150
							result.Parent.Add(newItem_parent);
							break;
						case "request":
							var newItem_request = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_request, reader, outcome, locationPath + ".request["+result.Request.Count+"]", cancellationToken); // 160
							result.Request.Add(newItem_request);
							break;
						case "collection":
							result.Collection = new Hl7.Fhir.Model.Specimen.CollectionComponent();
							await ParseAsync(result.Collection as Hl7.Fhir.Model.Specimen.CollectionComponent, reader, outcome, locationPath + ".collection", cancellationToken); // 170
							break;
						case "processing":
							var newItem_processing = new Hl7.Fhir.Model.Specimen.ProcessingComponent();
							await ParseAsync(newItem_processing, reader, outcome, locationPath + ".processing["+result.Processing.Count+"]", cancellationToken); // 180
							result.Processing.Add(newItem_processing);
							break;
						case "container":
							var newItem_container = new Hl7.Fhir.Model.Specimen.ContainerComponent();
							await ParseAsync(newItem_container, reader, outcome, locationPath + ".container["+result.Container.Count+"]", cancellationToken); // 190
							result.Container.Add(newItem_container);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_condition, reader, outcome, locationPath + ".condition["+result.Condition.Count+"]", cancellationToken); // 200
							result.Condition.Add(newItem_condition);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 210
							result.Note.Add(newItem_note);
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
