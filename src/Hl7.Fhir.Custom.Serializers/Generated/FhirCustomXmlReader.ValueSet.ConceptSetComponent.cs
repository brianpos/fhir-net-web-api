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
		public void Parse(Hl7.Fhir.Model.ValueSet.ConceptSetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.SystemElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".system"); // 40
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version"); // 50
							break;
						case "concept":
							var newItem_concept = new Hl7.Fhir.Model.ValueSet.ConceptReferenceComponent();
							Parse(newItem_concept, reader, outcome, locationPath + ".concept["+result.Concept.Count+"]"); // 60
							result.Concept.Add(newItem_concept);
							break;
						case "filter":
							var newItem_filter = new Hl7.Fhir.Model.ValueSet.FilterComponent();
							Parse(newItem_filter, reader, outcome, locationPath + ".filter["+result.Filter.Count+"]"); // 70
							result.Filter.Add(newItem_filter);
							break;
						case "valueSet":
							var newItem_valueSet = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_valueSet, reader, outcome, locationPath + ".valueSet["+result.ValueSetElement.Count+"]"); // 80
							result.ValueSetElement.Add(newItem_valueSet);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ValueSet.ConceptSetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.SystemElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".system"); // 40
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version"); // 50
							break;
						case "concept":
							var newItem_concept = new Hl7.Fhir.Model.ValueSet.ConceptReferenceComponent();
							await ParseAsync(newItem_concept, reader, outcome, locationPath + ".concept["+result.Concept.Count+"]"); // 60
							result.Concept.Add(newItem_concept);
							break;
						case "filter":
							var newItem_filter = new Hl7.Fhir.Model.ValueSet.FilterComponent();
							await ParseAsync(newItem_filter, reader, outcome, locationPath + ".filter["+result.Filter.Count+"]"); // 70
							result.Filter.Add(newItem_filter);
							break;
						case "valueSet":
							var newItem_valueSet = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_valueSet, reader, outcome, locationPath + ".valueSet["+result.ValueSetElement.Count+"]"); // 80
							result.ValueSetElement.Add(newItem_valueSet);
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
