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
		public void Parse(Hl7.Fhir.Model.Composition.SectionComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_author, reader, outcome); // 60
							result.Author.Add(newItem_author);
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Focus as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 70
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 80
							break;
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>();
							Parse(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>, reader, outcome); // 90
							break;
						case "orderedBy":
							result.OrderedBy = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OrderedBy as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "entry":
							var newItem_entry = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_entry, reader, outcome); // 110
							result.Entry.Add(newItem_entry);
							break;
						case "emptyReason":
							result.EmptyReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.EmptyReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.Composition.SectionComponent();
							Parse(newItem_section, reader, outcome); // 130
							result.Section.Add(newItem_section);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Composition.SectionComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_author, reader, outcome); // 60
							result.Author.Add(newItem_author);
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Focus as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 70
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 80
							break;
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>();
							await ParseAsync(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode>, reader, outcome); // 90
							break;
						case "orderedBy":
							result.OrderedBy = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OrderedBy as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "entry":
							var newItem_entry = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_entry, reader, outcome); // 110
							result.Entry.Add(newItem_entry);
							break;
						case "emptyReason":
							result.EmptyReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.EmptyReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.Composition.SectionComponent();
							await ParseAsync(newItem_section, reader, outcome); // 130
							result.Section.Add(newItem_section);
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
