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
		public void Parse(Hl7.Fhir.Model.SubstanceAmount result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "amountQuantity":
							result.Amount = new Hl7.Fhir.Model.Quantity();
							Parse(result.Amount as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".amount", cancellationToken); // 90
							break;
						case "amountRange":
							result.Amount = new Hl7.Fhir.Model.Range();
							Parse(result.Amount as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".amount", cancellationToken); // 90
							break;
						case "amountString":
							result.Amount = new Hl7.Fhir.Model.FhirString();
							Parse(result.Amount as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amount", cancellationToken); // 90
							break;
						case "amountType":
							result.AmountType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AmountType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".amountType", cancellationToken); // 100
							break;
						case "amountText":
							result.AmountTextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AmountTextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amountText", cancellationToken); // 110
							break;
						case "referenceRange":
							result.ReferenceRange = new Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent();
							Parse(result.ReferenceRange as Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent, reader, outcome, locationPath + ".referenceRange", cancellationToken); // 120
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceAmount result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "amountQuantity":
							result.Amount = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".amount", cancellationToken); // 90
							break;
						case "amountRange":
							result.Amount = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".amount", cancellationToken); // 90
							break;
						case "amountString":
							result.Amount = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amount", cancellationToken); // 90
							break;
						case "amountType":
							result.AmountType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AmountType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".amountType", cancellationToken); // 100
							break;
						case "amountText":
							result.AmountTextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AmountTextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amountText", cancellationToken); // 110
							break;
						case "referenceRange":
							result.ReferenceRange = new Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent();
							await ParseAsync(result.ReferenceRange as Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent, reader, outcome, locationPath + ".referenceRange", cancellationToken); // 120
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
