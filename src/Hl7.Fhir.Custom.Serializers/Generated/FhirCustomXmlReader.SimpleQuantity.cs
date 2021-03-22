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
		public void Parse(Hl7.Fhir.Model.SimpleQuantity result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.ValueElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".value", cancellationToken); // 30
							break;
						case "comparator":
							result.ComparatorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Quantity.QuantityComparator>();
							Parse(result.ComparatorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Quantity.QuantityComparator>, reader, outcome, locationPath + ".comparator", cancellationToken); // 40
							break;
						case "unit":
							result.UnitElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.UnitElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".unit", cancellationToken); // 50
							break;
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.SystemElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".system", cancellationToken); // 60
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SimpleQuantity result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.ValueElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".value", cancellationToken); // 30
							break;
						case "comparator":
							result.ComparatorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Quantity.QuantityComparator>();
							await ParseAsync(result.ComparatorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Quantity.QuantityComparator>, reader, outcome, locationPath + ".comparator", cancellationToken); // 40
							break;
						case "unit":
							result.UnitElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.UnitElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".unit", cancellationToken); // 50
							break;
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.SystemElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".system", cancellationToken); // 60
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 70
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
