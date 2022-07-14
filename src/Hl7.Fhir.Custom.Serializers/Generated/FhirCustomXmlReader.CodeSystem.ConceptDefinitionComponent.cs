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
		public void Parse(Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".display", cancellationToken); // 50
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DefinitionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".definition", cancellationToken); // 60
							break;
						case "designation":
							var newItem_designation = new Hl7.Fhir.Model.CodeSystem.DesignationComponent();
							Parse(newItem_designation, reader, outcome, locationPath + ".designation["+result.Designation.Count+"]", cancellationToken); // 70
							result.Designation.Add(newItem_designation);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.CodeSystem.ConceptPropertyComponent();
							Parse(newItem_property, reader, outcome, locationPath + ".property["+result.Property.Count+"]", cancellationToken); // 80
							result.Property.Add(newItem_property);
							break;
						case "concept":
							var newItem_concept = new Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent();
							Parse(newItem_concept, reader, outcome, locationPath + ".concept["+result.Concept.Count+"]", cancellationToken); // 90
							result.Concept.Add(newItem_concept);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".display", cancellationToken); // 50
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DefinitionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".definition", cancellationToken); // 60
							break;
						case "designation":
							var newItem_designation = new Hl7.Fhir.Model.CodeSystem.DesignationComponent();
							await ParseAsync(newItem_designation, reader, outcome, locationPath + ".designation["+result.Designation.Count+"]", cancellationToken); // 70
							result.Designation.Add(newItem_designation);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.CodeSystem.ConceptPropertyComponent();
							await ParseAsync(newItem_property, reader, outcome, locationPath + ".property["+result.Property.Count+"]", cancellationToken); // 80
							result.Property.Add(newItem_property);
							break;
						case "concept":
							var newItem_concept = new Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent();
							await ParseAsync(newItem_concept, reader, outcome, locationPath + ".concept["+result.Concept.Count+"]", cancellationToken); // 90
							result.Concept.Add(newItem_concept);
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
