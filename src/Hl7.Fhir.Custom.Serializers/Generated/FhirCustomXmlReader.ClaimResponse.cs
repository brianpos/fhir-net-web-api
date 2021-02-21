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
		private void Parse(ClaimResponse result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 110
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subType"); // 120
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>, reader, outcome, locationPath + ".use"); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 140
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 150
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".insurer"); // 160
							break;
						case "requestor":
							result.Requestor = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requestor as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requestor"); // 170
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 180
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>();
							Parse(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>, reader, outcome, locationPath + ".outcome"); // 190
							break;
						case "disposition":
							result.DispositionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DispositionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".disposition"); // 200
							break;
						case "preAuthRef":
							result.PreAuthRefElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PreAuthRefElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".preAuthRef"); // 210
							break;
						case "preAuthPeriod":
							result.PreAuthPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.PreAuthPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".preAuthPeriod"); // 220
							break;
						case "payeeType":
							result.PayeeType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PayeeType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".payeeType"); // 230
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.ClaimResponse.ItemComponent();
							Parse(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]"); // 240
							result.Item.Add(newItem_item);
							break;
						case "addItem":
							var newItem_addItem = new Hl7.Fhir.Model.ClaimResponse.AddedItemComponent();
							Parse(newItem_addItem, reader, outcome, locationPath + ".addItem["+result.AddItem.Count+"]"); // 250
							result.AddItem.Add(newItem_addItem);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent();
							Parse(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]"); // 260
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "total":
							var newItem_total = new Hl7.Fhir.Model.ClaimResponse.TotalComponent();
							Parse(newItem_total, reader, outcome, locationPath + ".total["+result.Total.Count+"]"); // 270
							result.Total.Add(newItem_total);
							break;
						case "payment":
							result.Payment = new Hl7.Fhir.Model.ClaimResponse.PaymentComponent();
							Parse(result.Payment as Hl7.Fhir.Model.ClaimResponse.PaymentComponent, reader, outcome, locationPath + ".payment"); // 280
							break;
						case "fundsReserve":
							result.FundsReserve = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FundsReserve as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundsReserve"); // 290
							break;
						case "formCode":
							result.FormCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FormCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".formCode"); // 300
							break;
						case "form":
							result.Form = new Hl7.Fhir.Model.Attachment();
							Parse(result.Form as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".form"); // 310
							break;
						case "processNote":
							var newItem_processNote = new Hl7.Fhir.Model.ClaimResponse.NoteComponent();
							Parse(newItem_processNote, reader, outcome, locationPath + ".processNote["+result.ProcessNote.Count+"]"); // 320
							result.ProcessNote.Add(newItem_processNote);
							break;
						case "communicationRequest":
							var newItem_communicationRequest = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_communicationRequest, reader, outcome, locationPath + ".communicationRequest["+result.CommunicationRequest.Count+"]"); // 330
							result.CommunicationRequest.Add(newItem_communicationRequest);
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ClaimResponse.InsuranceComponent();
							Parse(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 340
							result.Insurance.Add(newItem_insurance);
							break;
						case "error":
							var newItem_error = new Hl7.Fhir.Model.ClaimResponse.ErrorComponent();
							Parse(newItem_error, reader, outcome, locationPath + ".error["+result.Error.Count+"]"); // 350
							result.Error.Add(newItem_error);
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

		private async System.Threading.Tasks.Task ParseAsync(ClaimResponse result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 110
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subType"); // 120
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>, reader, outcome, locationPath + ".use"); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 140
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 150
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".insurer"); // 160
							break;
						case "requestor":
							result.Requestor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requestor as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requestor"); // 170
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 180
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>();
							await ParseAsync(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>, reader, outcome, locationPath + ".outcome"); // 190
							break;
						case "disposition":
							result.DispositionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DispositionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".disposition"); // 200
							break;
						case "preAuthRef":
							result.PreAuthRefElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PreAuthRefElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".preAuthRef"); // 210
							break;
						case "preAuthPeriod":
							result.PreAuthPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.PreAuthPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".preAuthPeriod"); // 220
							break;
						case "payeeType":
							result.PayeeType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PayeeType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".payeeType"); // 230
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.ClaimResponse.ItemComponent();
							await ParseAsync(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]"); // 240
							result.Item.Add(newItem_item);
							break;
						case "addItem":
							var newItem_addItem = new Hl7.Fhir.Model.ClaimResponse.AddedItemComponent();
							await ParseAsync(newItem_addItem, reader, outcome, locationPath + ".addItem["+result.AddItem.Count+"]"); // 250
							result.AddItem.Add(newItem_addItem);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent();
							await ParseAsync(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]"); // 260
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "total":
							var newItem_total = new Hl7.Fhir.Model.ClaimResponse.TotalComponent();
							await ParseAsync(newItem_total, reader, outcome, locationPath + ".total["+result.Total.Count+"]"); // 270
							result.Total.Add(newItem_total);
							break;
						case "payment":
							result.Payment = new Hl7.Fhir.Model.ClaimResponse.PaymentComponent();
							await ParseAsync(result.Payment as Hl7.Fhir.Model.ClaimResponse.PaymentComponent, reader, outcome, locationPath + ".payment"); // 280
							break;
						case "fundsReserve":
							result.FundsReserve = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FundsReserve as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundsReserve"); // 290
							break;
						case "formCode":
							result.FormCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FormCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".formCode"); // 300
							break;
						case "form":
							result.Form = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Form as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".form"); // 310
							break;
						case "processNote":
							var newItem_processNote = new Hl7.Fhir.Model.ClaimResponse.NoteComponent();
							await ParseAsync(newItem_processNote, reader, outcome, locationPath + ".processNote["+result.ProcessNote.Count+"]"); // 320
							result.ProcessNote.Add(newItem_processNote);
							break;
						case "communicationRequest":
							var newItem_communicationRequest = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_communicationRequest, reader, outcome, locationPath + ".communicationRequest["+result.CommunicationRequest.Count+"]"); // 330
							result.CommunicationRequest.Add(newItem_communicationRequest);
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ClaimResponse.InsuranceComponent();
							await ParseAsync(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 340
							result.Insurance.Add(newItem_insurance);
							break;
						case "error":
							var newItem_error = new Hl7.Fhir.Model.ClaimResponse.ErrorComponent();
							await ParseAsync(newItem_error, reader, outcome, locationPath + ".error["+result.Error.Count+"]"); // 350
							result.Error.Add(newItem_error);
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
