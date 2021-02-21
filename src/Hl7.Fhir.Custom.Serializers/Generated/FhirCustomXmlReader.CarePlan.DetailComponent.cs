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
		public void Parse(Hl7.Fhir.Model.CarePlan.DetailComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityKind>();
							Parse(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityKind>, reader, outcome); // 40
							break;
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome); // 50
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome); // 60
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome); // 80
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome); // 90
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "goal":
							var newItem_goal = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_goal, reader, outcome); // 100
							result.Goal.Add(newItem_goal);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>, reader, outcome); // 110
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 130
							break;
						case "scheduledTiming":
							result.Scheduled = new Hl7.Fhir.Model.Timing();
							Parse(result.Scheduled as Hl7.Fhir.Model.Timing, reader, outcome); // 140
							break;
						case "scheduledPeriod":
							result.Scheduled = new Hl7.Fhir.Model.Period();
							Parse(result.Scheduled as Hl7.Fhir.Model.Period, reader, outcome); // 140
							break;
						case "scheduledString":
							result.Scheduled = new Hl7.Fhir.Model.FhirString();
							Parse(result.Scheduled as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_performer, reader, outcome); // 160
							result.Performer.Add(newItem_performer);
							break;
						case "productCodeableConcept":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 170
							break;
						case "productReference":
							result.Product = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Product as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 170
							break;
						case "dailyAmount":
							result.DailyAmount = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.DailyAmount as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 180
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 190
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CarePlan.DetailComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityKind>();
							await ParseAsync(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityKind>, reader, outcome); // 40
							break;
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome); // 50
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome); // 60
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome); // 80
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome); // 90
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "goal":
							var newItem_goal = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_goal, reader, outcome); // 100
							result.Goal.Add(newItem_goal);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>, reader, outcome); // 110
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 130
							break;
						case "scheduledTiming":
							result.Scheduled = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Scheduled as Hl7.Fhir.Model.Timing, reader, outcome); // 140
							break;
						case "scheduledPeriod":
							result.Scheduled = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Scheduled as Hl7.Fhir.Model.Period, reader, outcome); // 140
							break;
						case "scheduledString":
							result.Scheduled = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Scheduled as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_performer, reader, outcome); // 160
							result.Performer.Add(newItem_performer);
							break;
						case "productCodeableConcept":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 170
							break;
						case "productReference":
							result.Product = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Product as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 170
							break;
						case "dailyAmount":
							result.DailyAmount = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.DailyAmount as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 180
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 190
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
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
