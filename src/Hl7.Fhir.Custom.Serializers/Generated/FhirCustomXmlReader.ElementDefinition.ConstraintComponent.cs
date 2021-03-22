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
		public void Parse(Hl7.Fhir.Model.ElementDefinition.ConstraintComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "key":
							result.KeyElement = new Hl7.Fhir.Model.Id();
							Parse(result.KeyElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".key", cancellationToken); // 40
							break;
						case "requirements":
							result.RequirementsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RequirementsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".requirements", cancellationToken); // 50
							break;
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ConstraintSeverity>();
							Parse(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ConstraintSeverity>, reader, outcome, locationPath + ".severity", cancellationToken); // 60
							break;
						case "human":
							result.HumanElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.HumanElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".human", cancellationToken); // 70
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".expression", cancellationToken); // 80
							break;
						case "xpath":
							result.XpathElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.XpathElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".xpath", cancellationToken); // 90
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.SourceElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".source", cancellationToken); // 100
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ElementDefinition.ConstraintComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "key":
							result.KeyElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.KeyElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".key", cancellationToken); // 40
							break;
						case "requirements":
							result.RequirementsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RequirementsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".requirements", cancellationToken); // 50
							break;
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ConstraintSeverity>();
							await ParseAsync(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ConstraintSeverity>, reader, outcome, locationPath + ".severity", cancellationToken); // 60
							break;
						case "human":
							result.HumanElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.HumanElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".human", cancellationToken); // 70
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".expression", cancellationToken); // 80
							break;
						case "xpath":
							result.XpathElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.XpathElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".xpath", cancellationToken); // 90
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.SourceElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".source", cancellationToken); // 100
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
