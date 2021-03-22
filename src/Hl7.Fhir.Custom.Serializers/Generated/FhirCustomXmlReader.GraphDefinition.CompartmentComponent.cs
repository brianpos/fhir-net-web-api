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
		public void Parse(Hl7.Fhir.Model.GraphDefinition.CompartmentComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentUse>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentUse>, reader, outcome, locationPath + ".use", cancellationToken); // 40
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompartmentType>();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompartmentType>, reader, outcome, locationPath + ".code", cancellationToken); // 50
							break;
						case "rule":
							result.RuleElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentRule>();
							Parse(result.RuleElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentRule>, reader, outcome, locationPath + ".rule", cancellationToken); // 60
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".expression", cancellationToken); // 70
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.GraphDefinition.CompartmentComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentUse>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentUse>, reader, outcome, locationPath + ".use", cancellationToken); // 40
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompartmentType>();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompartmentType>, reader, outcome, locationPath + ".code", cancellationToken); // 50
							break;
						case "rule":
							result.RuleElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentRule>();
							await ParseAsync(result.RuleElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GraphDefinition.GraphCompartmentRule>, reader, outcome, locationPath + ".rule", cancellationToken); // 60
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".expression", cancellationToken); // 70
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 80
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
