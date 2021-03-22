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
		public void Parse(Hl7.Fhir.Model.StructureMap.GroupComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.Id();
							Parse(result.NameElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "extends":
							result.ExtendsElement = new Hl7.Fhir.Model.Id();
							Parse(result.ExtendsElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".extends", cancellationToken); // 50
							break;
						case "typeMode":
							result.TypeModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapGroupTypeMode>();
							Parse(result.TypeModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapGroupTypeMode>, reader, outcome, locationPath + ".typeMode", cancellationToken); // 60
							break;
						case "documentation":
							result.DocumentationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DocumentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentation", cancellationToken); // 70
							break;
						case "input":
							var newItem_input = new Hl7.Fhir.Model.StructureMap.InputComponent();
							Parse(newItem_input, reader, outcome, locationPath + ".input["+result.Input.Count+"]", cancellationToken); // 80
							result.Input.Add(newItem_input);
							break;
						case "rule":
							var newItem_rule = new Hl7.Fhir.Model.StructureMap.RuleComponent();
							Parse(newItem_rule, reader, outcome, locationPath + ".rule["+result.Rule.Count+"]", cancellationToken); // 90
							result.Rule.Add(newItem_rule);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.StructureMap.GroupComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "extends":
							result.ExtendsElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ExtendsElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".extends", cancellationToken); // 50
							break;
						case "typeMode":
							result.TypeModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapGroupTypeMode>();
							await ParseAsync(result.TypeModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapGroupTypeMode>, reader, outcome, locationPath + ".typeMode", cancellationToken); // 60
							break;
						case "documentation":
							result.DocumentationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DocumentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentation", cancellationToken); // 70
							break;
						case "input":
							var newItem_input = new Hl7.Fhir.Model.StructureMap.InputComponent();
							await ParseAsync(newItem_input, reader, outcome, locationPath + ".input["+result.Input.Count+"]", cancellationToken); // 80
							result.Input.Add(newItem_input);
							break;
						case "rule":
							var newItem_rule = new Hl7.Fhir.Model.StructureMap.RuleComponent();
							await ParseAsync(newItem_rule, reader, outcome, locationPath + ".rule["+result.Rule.Count+"]", cancellationToken); // 90
							result.Rule.Add(newItem_rule);
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
