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
		public void Parse(Hl7.Fhir.Model.ValueSet.ExpansionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							result.IdentifierElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.IdentifierElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".identifier", cancellationToken); // 40
							break;
						case "timestamp":
							result.TimestampElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.TimestampElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timestamp", cancellationToken); // 50
							break;
						case "total":
							result.TotalElement = new Hl7.Fhir.Model.Integer();
							Parse(result.TotalElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".total", cancellationToken); // 60
							break;
						case "offset":
							result.OffsetElement = new Hl7.Fhir.Model.Integer();
							Parse(result.OffsetElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".offset", cancellationToken); // 70
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.ValueSet.ParameterComponent();
							Parse(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]", cancellationToken); // 80
							result.Parameter.Add(newItem_parameter);
							break;
						case "contains":
							var newItem_contains = new Hl7.Fhir.Model.ValueSet.ContainsComponent();
							Parse(newItem_contains, reader, outcome, locationPath + ".contains["+result.Contains.Count+"]", cancellationToken); // 90
							result.Contains.Add(newItem_contains);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ValueSet.ExpansionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							result.IdentifierElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.IdentifierElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".identifier", cancellationToken); // 40
							break;
						case "timestamp":
							result.TimestampElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.TimestampElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timestamp", cancellationToken); // 50
							break;
						case "total":
							result.TotalElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.TotalElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".total", cancellationToken); // 60
							break;
						case "offset":
							result.OffsetElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.OffsetElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".offset", cancellationToken); // 70
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.ValueSet.ParameterComponent();
							await ParseAsync(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]", cancellationToken); // 80
							result.Parameter.Add(newItem_parameter);
							break;
						case "contains":
							var newItem_contains = new Hl7.Fhir.Model.ValueSet.ContainsComponent();
							await ParseAsync(newItem_contains, reader, outcome, locationPath + ".contains["+result.Contains.Count+"]", cancellationToken); // 90
							result.Contains.Add(newItem_contains);
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
