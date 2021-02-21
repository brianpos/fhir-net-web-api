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
		private void Parse(SupplyRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 110
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 120
							break;
						case "itemCodeableConcept":
							result.Item = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Item as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".item"); // 130
							break;
						case "itemReference":
							result.Item = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Item as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".item"); // 130
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity"); // 140
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.SupplyRequest.ParameterComponent();
							Parse(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]"); // 150
							result.Parameter.Add(newItem_parameter);
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 160
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							Parse(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 160
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							Parse(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".occurrence"); // 160
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 170
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 180
							break;
						case "supplier":
							var newItem_supplier = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supplier, reader, outcome, locationPath + ".supplier["+result.Supplier.Count+"]"); // 190
							result.Supplier.Add(newItem_supplier);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 200
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 210
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "deliverFrom":
							result.DeliverFrom = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.DeliverFrom as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".deliverFrom"); // 220
							break;
						case "deliverTo":
							result.DeliverTo = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.DeliverTo as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".deliverTo"); // 230
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(SupplyRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 110
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 120
							break;
						case "itemCodeableConcept":
							result.Item = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Item as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".item"); // 130
							break;
						case "itemReference":
							result.Item = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Item as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".item"); // 130
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity"); // 140
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.SupplyRequest.ParameterComponent();
							await ParseAsync(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]"); // 150
							result.Parameter.Add(newItem_parameter);
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 160
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 160
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".occurrence"); // 160
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 170
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 180
							break;
						case "supplier":
							var newItem_supplier = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supplier, reader, outcome, locationPath + ".supplier["+result.Supplier.Count+"]"); // 190
							result.Supplier.Add(newItem_supplier);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 200
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 210
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "deliverFrom":
							result.DeliverFrom = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.DeliverFrom as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".deliverFrom"); // 220
							break;
						case "deliverTo":
							result.DeliverTo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.DeliverTo as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".deliverTo"); // 230
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
