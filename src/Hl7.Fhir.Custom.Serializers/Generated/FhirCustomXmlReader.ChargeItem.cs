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
		private void Parse(ChargeItem result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "definitionUri":
							var newItem_definitionUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_definitionUri, reader, outcome); // 100
							result.DefinitionUriElement.Add(newItem_definitionUri);
							break;
						case "definitionCanonical":
							var newItem_definitionCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_definitionCanonical, reader, outcome); // 110
							result.DefinitionCanonicalElement.Add(newItem_definitionCanonical);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ChargeItem.ChargeItemStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ChargeItem.ChargeItemStatus>, reader, outcome); // 120
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome); // 130
							result.PartOf.Add(newItem_partOf);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 160
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							Parse(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome); // 170
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							Parse(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome); // 170
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ChargeItem.PerformerComponent();
							Parse(newItem_performer, reader, outcome); // 180
							result.Performer.Add(newItem_performer);
							break;
						case "performingOrganization":
							result.PerformingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.PerformingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "requestingOrganization":
							result.RequestingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.RequestingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 200
							break;
						case "costCenter":
							result.CostCenter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.CostCenter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 220
							break;
						case "bodysite":
							var newItem_bodysite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_bodysite, reader, outcome); // 230
							result.Bodysite.Add(newItem_bodysite);
							break;
						case "factorOverride":
							result.FactorOverrideElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorOverrideElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 240
							break;
						case "priceOverride":
							result.PriceOverride = new Hl7.Fhir.Model.Money();
							Parse(result.PriceOverride as Hl7.Fhir.Model.Money, reader, outcome); // 250
							break;
						case "overrideReason":
							result.OverrideReasonElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.OverrideReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 260
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "enteredDate":
							result.EnteredDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.EnteredDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 280
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reason, reader, outcome); // 290
							result.Reason.Add(newItem_reason);
							break;
						case "service":
							var newItem_service = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_service, reader, outcome); // 300
							result.Service.Add(newItem_service);
							break;
						case "productReference":
							result.Product = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Product as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 310
							break;
						case "productCodeableConcept":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 310
							break;
						case "account":
							var newItem_account = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_account, reader, outcome); // 320
							result.Account.Add(newItem_account);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 330
							result.Note.Add(newItem_note);
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInformation, reader, outcome); // 340
							result.SupportingInformation.Add(newItem_supportingInformation);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
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

		private async System.Threading.Tasks.Task ParseAsync(ChargeItem result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "definitionUri":
							var newItem_definitionUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_definitionUri, reader, outcome); // 100
							result.DefinitionUriElement.Add(newItem_definitionUri);
							break;
						case "definitionCanonical":
							var newItem_definitionCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_definitionCanonical, reader, outcome); // 110
							result.DefinitionCanonicalElement.Add(newItem_definitionCanonical);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ChargeItem.ChargeItemStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ChargeItem.ChargeItemStatus>, reader, outcome); // 120
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome); // 130
							result.PartOf.Add(newItem_partOf);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 160
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome); // 170
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome); // 170
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ChargeItem.PerformerComponent();
							await ParseAsync(newItem_performer, reader, outcome); // 180
							result.Performer.Add(newItem_performer);
							break;
						case "performingOrganization":
							result.PerformingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.PerformingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "requestingOrganization":
							result.RequestingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.RequestingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 200
							break;
						case "costCenter":
							result.CostCenter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.CostCenter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 220
							break;
						case "bodysite":
							var newItem_bodysite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_bodysite, reader, outcome); // 230
							result.Bodysite.Add(newItem_bodysite);
							break;
						case "factorOverride":
							result.FactorOverrideElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorOverrideElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 240
							break;
						case "priceOverride":
							result.PriceOverride = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.PriceOverride as Hl7.Fhir.Model.Money, reader, outcome); // 250
							break;
						case "overrideReason":
							result.OverrideReasonElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.OverrideReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 260
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "enteredDate":
							result.EnteredDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.EnteredDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 280
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reason, reader, outcome); // 290
							result.Reason.Add(newItem_reason);
							break;
						case "service":
							var newItem_service = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_service, reader, outcome); // 300
							result.Service.Add(newItem_service);
							break;
						case "productReference":
							result.Product = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Product as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 310
							break;
						case "productCodeableConcept":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 310
							break;
						case "account":
							var newItem_account = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_account, reader, outcome); // 320
							result.Account.Add(newItem_account);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 330
							result.Note.Add(newItem_note);
							break;
						case "supportingInformation":
							var newItem_supportingInformation = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInformation, reader, outcome); // 340
							result.SupportingInformation.Add(newItem_supportingInformation);
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
