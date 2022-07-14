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
		public void Parse(Hl7.Fhir.Model.EvidenceVariable.CharacteristicComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "definitionReference":
							result.Definition = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Definition as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "definitionCanonical":
							result.Definition = new Hl7.Fhir.Model.Canonical();
							Parse(result.Definition as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "definitionCodeableConcept":
							result.Definition = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Definition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "definitionExpression":
							result.Definition = new Hl7.Fhir.Model.Expression();
							Parse(result.Definition as Hl7.Fhir.Model.Expression, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method", cancellationToken); // 60
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device", cancellationToken); // 70
							break;
						case "exclude":
							result.ExcludeElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExcludeElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".exclude", cancellationToken); // 80
							break;
						case "timeFromStart":
							result.TimeFromStart = new Hl7.Fhir.Model.EvidenceVariable.TimeFromStartComponent();
							Parse(result.TimeFromStart as Hl7.Fhir.Model.EvidenceVariable.TimeFromStartComponent, reader, outcome, locationPath + ".timeFromStart", cancellationToken); // 90
							break;
						case "groupMeasure":
							result.GroupMeasureElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GroupMeasure>();
							Parse(result.GroupMeasureElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GroupMeasure>, reader, outcome, locationPath + ".groupMeasure", cancellationToken); // 100
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.EvidenceVariable.CharacteristicComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "definitionReference":
							result.Definition = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "definitionCanonical":
							result.Definition = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "definitionCodeableConcept":
							result.Definition = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "definitionExpression":
							result.Definition = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.Expression, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method", cancellationToken); // 60
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device", cancellationToken); // 70
							break;
						case "exclude":
							result.ExcludeElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExcludeElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".exclude", cancellationToken); // 80
							break;
						case "timeFromStart":
							result.TimeFromStart = new Hl7.Fhir.Model.EvidenceVariable.TimeFromStartComponent();
							await ParseAsync(result.TimeFromStart as Hl7.Fhir.Model.EvidenceVariable.TimeFromStartComponent, reader, outcome, locationPath + ".timeFromStart", cancellationToken); // 90
							break;
						case "groupMeasure":
							result.GroupMeasureElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GroupMeasure>();
							await ParseAsync(result.GroupMeasureElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GroupMeasure>, reader, outcome, locationPath + ".groupMeasure", cancellationToken); // 100
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
