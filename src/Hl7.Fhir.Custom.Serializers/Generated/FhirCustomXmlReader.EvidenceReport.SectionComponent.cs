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
		public void Parse(Hl7.Fhir.Model.EvidenceReport.SectionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 40
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Focus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".focus", cancellationToken); // 50
							break;
						case "focusReference":
							result.FocusReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.FocusReference as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".focusReference", cancellationToken); // 60
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 70
							result.Author.Add(newItem_author);
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 80
							break;
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>();
							Parse(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>, reader, outcome, locationPath + ".mode", cancellationToken); // 90
							break;
						case "orderedBy":
							result.OrderedBy = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OrderedBy as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".orderedBy", cancellationToken); // 100
							break;
						case "entryClassifier":
							var newItem_entryClassifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_entryClassifier, reader, outcome, locationPath + ".entryClassifier["+result.EntryClassifier.Count+"]", cancellationToken); // 110
							result.EntryClassifier.Add(newItem_entryClassifier);
							break;
						case "entryReference":
							var newItem_entryReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_entryReference, reader, outcome, locationPath + ".entryReference["+result.EntryReference.Count+"]", cancellationToken); // 120
							result.EntryReference.Add(newItem_entryReference);
							break;
						case "entryQuantity":
							var newItem_entryQuantity = new Hl7.Fhir.Model.Quantity();
							Parse(newItem_entryQuantity, reader, outcome, locationPath + ".entryQuantity["+result.EntryQuantity.Count+"]", cancellationToken); // 130
							result.EntryQuantity.Add(newItem_entryQuantity);
							break;
						case "emptyReason":
							result.EmptyReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.EmptyReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".emptyReason", cancellationToken); // 140
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.EvidenceReport.SectionComponent();
							Parse(newItem_section, reader, outcome, locationPath + ".section["+result.Section.Count+"]", cancellationToken); // 150
							result.Section.Add(newItem_section);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.EvidenceReport.SectionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 40
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Focus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".focus", cancellationToken); // 50
							break;
						case "focusReference":
							result.FocusReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.FocusReference as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".focusReference", cancellationToken); // 60
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 70
							result.Author.Add(newItem_author);
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 80
							break;
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>();
							await ParseAsync(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>, reader, outcome, locationPath + ".mode", cancellationToken); // 90
							break;
						case "orderedBy":
							result.OrderedBy = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OrderedBy as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".orderedBy", cancellationToken); // 100
							break;
						case "entryClassifier":
							var newItem_entryClassifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_entryClassifier, reader, outcome, locationPath + ".entryClassifier["+result.EntryClassifier.Count+"]", cancellationToken); // 110
							result.EntryClassifier.Add(newItem_entryClassifier);
							break;
						case "entryReference":
							var newItem_entryReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_entryReference, reader, outcome, locationPath + ".entryReference["+result.EntryReference.Count+"]", cancellationToken); // 120
							result.EntryReference.Add(newItem_entryReference);
							break;
						case "entryQuantity":
							var newItem_entryQuantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(newItem_entryQuantity, reader, outcome, locationPath + ".entryQuantity["+result.EntryQuantity.Count+"]", cancellationToken); // 130
							result.EntryQuantity.Add(newItem_entryQuantity);
							break;
						case "emptyReason":
							result.EmptyReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.EmptyReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".emptyReason", cancellationToken); // 140
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.EvidenceReport.SectionComponent();
							await ParseAsync(newItem_section, reader, outcome, locationPath + ".section["+result.Section.Count+"]", cancellationToken); // 150
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
