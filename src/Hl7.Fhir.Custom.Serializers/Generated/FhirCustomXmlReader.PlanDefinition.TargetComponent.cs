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
		public void Parse(Hl7.Fhir.Model.PlanDefinition.TargetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "measure":
							result.Measure = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Measure as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".measure"); // 40
							break;
						case "detailQuantity":
							result.Detail = new Hl7.Fhir.Model.Quantity();
							Parse(result.Detail as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".detail"); // 50
							break;
						case "detailRange":
							result.Detail = new Hl7.Fhir.Model.Range();
							Parse(result.Detail as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".detail"); // 50
							break;
						case "detailCodeableConcept":
							result.Detail = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Detail as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".detail"); // 50
							break;
						case "due":
							result.Due = new Hl7.Fhir.Model.Duration();
							Parse(result.Due as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".due"); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.PlanDefinition.TargetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "measure":
							result.Measure = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Measure as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".measure"); // 40
							break;
						case "detailQuantity":
							result.Detail = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".detail"); // 50
							break;
						case "detailRange":
							result.Detail = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".detail"); // 50
							break;
						case "detailCodeableConcept":
							result.Detail = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".detail"); // 50
							break;
						case "due":
							result.Due = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Due as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".due"); // 60
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
