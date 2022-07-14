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
		public void Parse(Hl7.Fhir.Model.Evidence.VariableComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "variableDefinition":
							result.VariableDefinition = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.VariableDefinition as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".variableDefinition", cancellationToken); // 40
							break;
						case "handling":
							result.HandlingElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EvidenceVariableHandling>();
							Parse(result.HandlingElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EvidenceVariableHandling>, reader, outcome, locationPath + ".handling", cancellationToken); // 50
							break;
						case "valueCategory":
							var newItem_valueCategory = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_valueCategory, reader, outcome, locationPath + ".valueCategory["+result.ValueCategory.Count+"]", cancellationToken); // 60
							result.ValueCategory.Add(newItem_valueCategory);
							break;
						case "valueQuantity":
							var newItem_valueQuantity = new Hl7.Fhir.Model.Quantity();
							Parse(newItem_valueQuantity, reader, outcome, locationPath + ".valueQuantity["+result.ValueQuantity.Count+"]", cancellationToken); // 70
							result.ValueQuantity.Add(newItem_valueQuantity);
							break;
						case "valueRange":
							var newItem_valueRange = new Hl7.Fhir.Model.Range();
							Parse(newItem_valueRange, reader, outcome, locationPath + ".valueRange["+result.ValueRange.Count+"]", cancellationToken); // 80
							result.ValueRange.Add(newItem_valueRange);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Evidence.VariableComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "variableDefinition":
							result.VariableDefinition = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.VariableDefinition as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".variableDefinition", cancellationToken); // 40
							break;
						case "handling":
							result.HandlingElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EvidenceVariableHandling>();
							await ParseAsync(result.HandlingElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EvidenceVariableHandling>, reader, outcome, locationPath + ".handling", cancellationToken); // 50
							break;
						case "valueCategory":
							var newItem_valueCategory = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_valueCategory, reader, outcome, locationPath + ".valueCategory["+result.ValueCategory.Count+"]", cancellationToken); // 60
							result.ValueCategory.Add(newItem_valueCategory);
							break;
						case "valueQuantity":
							var newItem_valueQuantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(newItem_valueQuantity, reader, outcome, locationPath + ".valueQuantity["+result.ValueQuantity.Count+"]", cancellationToken); // 70
							result.ValueQuantity.Add(newItem_valueQuantity);
							break;
						case "valueRange":
							var newItem_valueRange = new Hl7.Fhir.Model.Range();
							await ParseAsync(newItem_valueRange, reader, outcome, locationPath + ".valueRange["+result.ValueRange.Count+"]", cancellationToken); // 80
							result.ValueRange.Add(newItem_valueRange);
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
