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
		public void Parse(Hl7.Fhir.Model.UsageContext result, XmlReader reader, OperationOutcome outcome)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.Coding();
							Parse(result.Code as Hl7.Fhir.Model.Coding, reader, outcome); // 30
							break;
						case "valueCodeableConcept":
							result.Value = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Value as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							Parse(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome); // 40
							break;
						case "valueRange":
							result.Value = new Hl7.Fhir.Model.Range();
							Parse(result.Value as Hl7.Fhir.Model.Range, reader, outcome); // 40
							break;
						case "valueReference":
							result.Value = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Value as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 40
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.UsageContext result, XmlReader reader, OperationOutcome outcome)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Code as Hl7.Fhir.Model.Coding, reader, outcome); // 30
							break;
						case "valueCodeableConcept":
							result.Value = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Value as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome); // 40
							break;
						case "valueRange":
							result.Value = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Range, reader, outcome); // 40
							break;
						case "valueReference":
							result.Value = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Value as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 40
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
