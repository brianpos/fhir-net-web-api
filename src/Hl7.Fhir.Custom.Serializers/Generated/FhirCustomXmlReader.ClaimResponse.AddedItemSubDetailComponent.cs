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
		public void Parse(Hl7.Fhir.Model.ClaimResponse.AddedItemSubDetailComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".productOrService", cancellationToken); // 40
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.Modifier.Count+"]", cancellationToken); // 50
							result.Modifier.Add(newItem_modifier);
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 60
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							Parse(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 70
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 80
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							Parse(result.Net as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".net", cancellationToken); // 90
							break;
						case "noteNumber":
							var newItem_noteNumber = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_noteNumber, reader, outcome, locationPath + ".noteNumber["+result.NoteNumberElement.Count+"]", cancellationToken); // 100
							result.NoteNumberElement.Add(newItem_noteNumber);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent();
							Parse(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]", cancellationToken); // 110
							result.Adjudication.Add(newItem_adjudication);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ClaimResponse.AddedItemSubDetailComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".productOrService", cancellationToken); // 40
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.Modifier.Count+"]", cancellationToken); // 50
							result.Modifier.Add(newItem_modifier);
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 60
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 70
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 80
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Net as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".net", cancellationToken); // 90
							break;
						case "noteNumber":
							var newItem_noteNumber = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_noteNumber, reader, outcome, locationPath + ".noteNumber["+result.NoteNumberElement.Count+"]", cancellationToken); // 100
							result.NoteNumberElement.Add(newItem_noteNumber);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent();
							await ParseAsync(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]", cancellationToken); // 110
							result.Adjudication.Add(newItem_adjudication);
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
