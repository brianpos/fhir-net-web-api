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
		public void Parse(Hl7.Fhir.Model.Contract.ValuedItemComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "entityCodeableConcept":
							result.Entity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Entity as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "entityReference":
							result.Entity = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Entity as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 40
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 50
							break;
						case "effectiveTime":
							result.EffectiveTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.EffectiveTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 60
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 70
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							Parse(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome); // 80
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 90
							break;
						case "points":
							result.PointsElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PointsElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 100
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							Parse(result.Net as Hl7.Fhir.Model.Money, reader, outcome); // 110
							break;
						case "payment":
							result.PaymentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PaymentElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "paymentDate":
							result.PaymentDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.PaymentDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 130
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_linkId, reader, outcome); // 160
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							Parse(newItem_securityLabelNumber, reader, outcome); // 170
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.ValuedItemComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "entityCodeableConcept":
							result.Entity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Entity as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "entityReference":
							result.Entity = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Entity as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 40
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 50
							break;
						case "effectiveTime":
							result.EffectiveTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.EffectiveTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 60
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 70
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome); // 80
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 90
							break;
						case "points":
							result.PointsElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PointsElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 100
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Net as Hl7.Fhir.Model.Money, reader, outcome); // 110
							break;
						case "payment":
							result.PaymentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PaymentElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "paymentDate":
							result.PaymentDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.PaymentDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 130
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_linkId, reader, outcome); // 160
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(newItem_securityLabelNumber, reader, outcome); // 170
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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
