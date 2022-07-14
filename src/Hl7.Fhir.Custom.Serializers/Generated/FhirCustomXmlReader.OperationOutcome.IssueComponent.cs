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
		public void Parse(Hl7.Fhir.Model.OperationOutcome.IssueComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>();
							Parse(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>, reader, outcome, locationPath + ".severity", cancellationToken); // 40
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueType>();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueType>, reader, outcome, locationPath + ".code", cancellationToken); // 50
							break;
						case "details":
							result.Details = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Details as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".details", cancellationToken); // 60
							break;
						case "diagnostics":
							result.DiagnosticsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DiagnosticsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".diagnostics", cancellationToken); // 70
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_location, reader, outcome, locationPath + ".location["+result.LocationElement.Count+"]", cancellationToken); // 80
							result.LocationElement.Add(newItem_location);
							break;
						case "expression":
							var newItem_expression = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_expression, reader, outcome, locationPath + ".expression["+result.ExpressionElement.Count+"]", cancellationToken); // 90
							result.ExpressionElement.Add(newItem_expression);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.OperationOutcome.IssueComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>();
							await ParseAsync(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>, reader, outcome, locationPath + ".severity", cancellationToken); // 40
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueType>();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationOutcome.IssueType>, reader, outcome, locationPath + ".code", cancellationToken); // 50
							break;
						case "details":
							result.Details = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Details as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".details", cancellationToken); // 60
							break;
						case "diagnostics":
							result.DiagnosticsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DiagnosticsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".diagnostics", cancellationToken); // 70
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_location, reader, outcome, locationPath + ".location["+result.LocationElement.Count+"]", cancellationToken); // 80
							result.LocationElement.Add(newItem_location);
							break;
						case "expression":
							var newItem_expression = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_expression, reader, outcome, locationPath + ".expression["+result.ExpressionElement.Count+"]", cancellationToken); // 90
							result.ExpressionElement.Add(newItem_expression);
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
