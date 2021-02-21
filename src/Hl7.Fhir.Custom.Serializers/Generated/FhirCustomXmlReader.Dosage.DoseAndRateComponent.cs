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
		public void Parse(Hl7.Fhir.Model.Dosage.DoseAndRateComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "doseRange":
							result.Dose = new Hl7.Fhir.Model.Range();
							Parse(result.Dose as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "doseQuantity":
							result.Dose = new Hl7.Fhir.Model.Quantity();
							Parse(result.Dose as Hl7.Fhir.Model.Quantity, reader, outcome); // 50
							break;
						case "rateRatio":
							result.Rate = new Hl7.Fhir.Model.Ratio();
							Parse(result.Rate as Hl7.Fhir.Model.Ratio, reader, outcome); // 60
							break;
						case "rateRange":
							result.Rate = new Hl7.Fhir.Model.Range();
							Parse(result.Rate as Hl7.Fhir.Model.Range, reader, outcome); // 60
							break;
						case "rateQuantity":
							result.Rate = new Hl7.Fhir.Model.Quantity();
							Parse(result.Rate as Hl7.Fhir.Model.Quantity, reader, outcome); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Dosage.DoseAndRateComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "doseRange":
							result.Dose = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Dose as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "doseQuantity":
							result.Dose = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Dose as Hl7.Fhir.Model.Quantity, reader, outcome); // 50
							break;
						case "rateRatio":
							result.Rate = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Rate as Hl7.Fhir.Model.Ratio, reader, outcome); // 60
							break;
						case "rateRange":
							result.Rate = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Rate as Hl7.Fhir.Model.Range, reader, outcome); // 60
							break;
						case "rateQuantity":
							result.Rate = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Rate as Hl7.Fhir.Model.Quantity, reader, outcome); // 60
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
