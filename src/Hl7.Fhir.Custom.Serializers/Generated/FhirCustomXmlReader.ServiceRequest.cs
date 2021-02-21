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
		private void Parse(ServiceRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "replaces":
							var newItem_replaces = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_replaces, reader, outcome, locationPath + ".replaces["+result.Replaces.Count+"]"); // 130
							result.Replaces.Add(newItem_replaces);
							break;
						case "requisition":
							result.Requisition = new Hl7.Fhir.Model.Identifier();
							Parse(result.Requisition as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".requisition"); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>();
							Parse(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>, reader, outcome, locationPath + ".intent"); // 160
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 170
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 180
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 190
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 200
							break;
						case "orderDetail":
							var newItem_orderDetail = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_orderDetail, reader, outcome, locationPath + ".orderDetail["+result.OrderDetail.Count+"]"); // 210
							result.OrderDetail.Add(newItem_orderDetail);
							break;
						case "quantityQuantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity"); // 220
							break;
						case "quantityRatio":
							result.Quantity = new Hl7.Fhir.Model.Ratio();
							Parse(result.Quantity as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".quantity"); // 220
							break;
						case "quantityRange":
							result.Quantity = new Hl7.Fhir.Model.Range();
							Parse(result.Quantity as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".quantity"); // 220
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 230
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 240
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 250
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							Parse(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 250
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							Parse(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".occurrence"); // 250
							break;
						case "asNeededBoolean":
							result.AsNeeded = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AsNeeded as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".asNeeded"); // 260
							break;
						case "asNeededCodeableConcept":
							result.AsNeeded = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AsNeeded as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".asNeeded"); // 260
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 270
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 280
							break;
						case "performerType":
							result.PerformerType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PerformerType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".performerType"); // 290
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]"); // 300
							result.Performer.Add(newItem_performer);
							break;
						case "locationCode":
							var newItem_locationCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_locationCode, reader, outcome, locationPath + ".locationCode["+result.LocationCode.Count+"]"); // 310
							result.LocationCode.Add(newItem_locationCode);
							break;
						case "locationReference":
							var newItem_locationReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_locationReference, reader, outcome, locationPath + ".locationReference["+result.LocationReference.Count+"]"); // 320
							result.LocationReference.Add(newItem_locationReference);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 330
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 340
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 350
							result.Insurance.Add(newItem_insurance);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]"); // 360
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "specimen":
							var newItem_specimen = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_specimen, reader, outcome, locationPath + ".specimen["+result.Specimen.Count+"]"); // 370
							result.Specimen.Add(newItem_specimen);
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]"); // 380
							result.BodySite.Add(newItem_bodySite);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 390
							result.Note.Add(newItem_note);
							break;
						case "patientInstruction":
							result.PatientInstructionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PatientInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".patientInstruction"); // 400
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_relevantHistory, reader, outcome, locationPath + ".relevantHistory["+result.RelevantHistory.Count+"]"); // 410
							result.RelevantHistory.Add(newItem_relevantHistory);
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

		private async System.Threading.Tasks.Task ParseAsync(ServiceRequest result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "replaces":
							var newItem_replaces = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_replaces, reader, outcome, locationPath + ".replaces["+result.Replaces.Count+"]"); // 130
							result.Replaces.Add(newItem_replaces);
							break;
						case "requisition":
							result.Requisition = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Requisition as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".requisition"); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>, reader, outcome, locationPath + ".status"); // 150
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>();
							await ParseAsync(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>, reader, outcome, locationPath + ".intent"); // 160
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 170
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority"); // 180
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform"); // 190
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 200
							break;
						case "orderDetail":
							var newItem_orderDetail = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_orderDetail, reader, outcome, locationPath + ".orderDetail["+result.OrderDetail.Count+"]"); // 210
							result.OrderDetail.Add(newItem_orderDetail);
							break;
						case "quantityQuantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity"); // 220
							break;
						case "quantityRatio":
							result.Quantity = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".quantity"); // 220
							break;
						case "quantityRange":
							result.Quantity = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".quantity"); // 220
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 230
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 240
							break;
						case "occurrenceDateTime":
							result.Occurrence = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrence"); // 250
							break;
						case "occurrencePeriod":
							result.Occurrence = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurrence"); // 250
							break;
						case "occurrenceTiming":
							result.Occurrence = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Occurrence as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".occurrence"); // 250
							break;
						case "asNeededBoolean":
							result.AsNeeded = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AsNeeded as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".asNeeded"); // 260
							break;
						case "asNeededCodeableConcept":
							result.AsNeeded = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AsNeeded as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".asNeeded"); // 260
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".authoredOn"); // 270
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requester"); // 280
							break;
						case "performerType":
							result.PerformerType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PerformerType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".performerType"); // 290
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]"); // 300
							result.Performer.Add(newItem_performer);
							break;
						case "locationCode":
							var newItem_locationCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_locationCode, reader, outcome, locationPath + ".locationCode["+result.LocationCode.Count+"]"); // 310
							result.LocationCode.Add(newItem_locationCode);
							break;
						case "locationReference":
							var newItem_locationReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_locationReference, reader, outcome, locationPath + ".locationReference["+result.LocationReference.Count+"]"); // 320
							result.LocationReference.Add(newItem_locationReference);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 330
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 340
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 350
							result.Insurance.Add(newItem_insurance);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]"); // 360
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "specimen":
							var newItem_specimen = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_specimen, reader, outcome, locationPath + ".specimen["+result.Specimen.Count+"]"); // 370
							result.Specimen.Add(newItem_specimen);
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]"); // 380
							result.BodySite.Add(newItem_bodySite);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 390
							result.Note.Add(newItem_note);
							break;
						case "patientInstruction":
							result.PatientInstructionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PatientInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".patientInstruction"); // 400
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_relevantHistory, reader, outcome, locationPath + ".relevantHistory["+result.RelevantHistory.Count+"]"); // 410
							result.RelevantHistory.Add(newItem_relevantHistory);
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
