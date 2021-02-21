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
		public void Parse(Hl7.Fhir.Model.Goal.TargetComponent result, XmlReader reader, OperationOutcome outcome)
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
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "measure":
							result.Measure = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Measure as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "detailQuantity":
							result.Detail = new Hl7.Fhir.Model.Quantity();
							Parse(result.Detail as Hl7.Fhir.Model.Quantity, reader, outcome); // 50
							break;
						case "detailRange":
							result.Detail = new Hl7.Fhir.Model.Range();
							Parse(result.Detail as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "detailCodeableConcept":
							result.Detail = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Detail as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "detailString":
							result.Detail = new Hl7.Fhir.Model.FhirString();
							Parse(result.Detail as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "detailBoolean":
							result.Detail = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Detail as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "detailInteger":
							result.Detail = new Hl7.Fhir.Model.Integer();
							Parse(result.Detail as Hl7.Fhir.Model.Integer, reader, outcome); // 50
							break;
						case "detailRatio":
							result.Detail = new Hl7.Fhir.Model.Ratio();
							Parse(result.Detail as Hl7.Fhir.Model.Ratio, reader, outcome); // 50
							break;
						case "dueDate":
							result.Due = new Hl7.Fhir.Model.Date();
							Parse(result.Due as Hl7.Fhir.Model.Date, reader, outcome); // 60
							break;
						case "dueDuration":
							result.Due = new Hl7.Fhir.Model.Duration();
							Parse(result.Due as Hl7.Fhir.Model.Duration, reader, outcome); // 60
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Goal.TargetComponent result, XmlReader reader, OperationOutcome outcome)
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
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "measure":
							result.Measure = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Measure as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "detailQuantity":
							result.Detail = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.Quantity, reader, outcome); // 50
							break;
						case "detailRange":
							result.Detail = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "detailCodeableConcept":
							result.Detail = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "detailString":
							result.Detail = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "detailBoolean":
							result.Detail = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "detailInteger":
							result.Detail = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.Integer, reader, outcome); // 50
							break;
						case "detailRatio":
							result.Detail = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.Ratio, reader, outcome); // 50
							break;
						case "dueDate":
							result.Due = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Due as Hl7.Fhir.Model.Date, reader, outcome); // 60
							break;
						case "dueDuration":
							result.Due = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Due as Hl7.Fhir.Model.Duration, reader, outcome); // 60
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
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
