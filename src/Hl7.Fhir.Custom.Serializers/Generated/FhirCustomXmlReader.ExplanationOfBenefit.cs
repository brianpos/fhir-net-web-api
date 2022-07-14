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
		private void Parse(ExplanationOfBenefit result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ExplanationOfBenefit.ExplanationOfBenefitStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ExplanationOfBenefit.ExplanationOfBenefitStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 110
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subType", cancellationToken); // 120
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>, reader, outcome, locationPath + ".use", cancellationToken); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 140
							break;
						case "billablePeriod":
							result.BillablePeriod = new Hl7.Fhir.Model.Period();
							Parse(result.BillablePeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".billablePeriod", cancellationToken); // 150
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created", cancellationToken); // 160
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".enterer", cancellationToken); // 170
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".insurer", cancellationToken); // 180
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".provider", cancellationToken); // 190
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority", cancellationToken); // 200
							break;
						case "fundsReserveRequested":
							result.FundsReserveRequested = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FundsReserveRequested as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundsReserveRequested", cancellationToken); // 210
							break;
						case "fundsReserve":
							result.FundsReserve = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FundsReserve as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundsReserve", cancellationToken); // 220
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.ExplanationOfBenefit.RelatedClaimComponent();
							Parse(newItem_related, reader, outcome, locationPath + ".related["+result.Related.Count+"]", cancellationToken); // 230
							result.Related.Add(newItem_related);
							break;
						case "prescription":
							result.Prescription = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Prescription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".prescription", cancellationToken); // 240
							break;
						case "originalPrescription":
							result.OriginalPrescription = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OriginalPrescription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".originalPrescription", cancellationToken); // 250
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent();
							Parse(result.Payee as Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent, reader, outcome, locationPath + ".payee", cancellationToken); // 260
							break;
						case "referral":
							result.Referral = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Referral as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".referral", cancellationToken); // 270
							break;
						case "facility":
							result.Facility = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Facility as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".facility", cancellationToken); // 280
							break;
						case "claim":
							result.Claim = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Claim as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".claim", cancellationToken); // 290
							break;
						case "claimResponse":
							result.ClaimResponse = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ClaimResponse as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".claimResponse", cancellationToken); // 300
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RemittanceOutcome>();
							Parse(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RemittanceOutcome>, reader, outcome, locationPath + ".outcome", cancellationToken); // 310
							break;
						case "disposition":
							result.DispositionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DispositionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".disposition", cancellationToken); // 320
							break;
						case "preAuthRef":
							var newItem_preAuthRef = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_preAuthRef, reader, outcome, locationPath + ".preAuthRef["+result.PreAuthRefElement.Count+"]", cancellationToken); // 330
							result.PreAuthRefElement.Add(newItem_preAuthRef);
							break;
						case "preAuthRefPeriod":
							var newItem_preAuthRefPeriod = new Hl7.Fhir.Model.Period();
							Parse(newItem_preAuthRefPeriod, reader, outcome, locationPath + ".preAuthRefPeriod["+result.PreAuthRefPeriod.Count+"]", cancellationToken); // 340
							result.PreAuthRefPeriod.Add(newItem_preAuthRefPeriod);
							break;
						case "careTeam":
							var newItem_careTeam = new Hl7.Fhir.Model.ExplanationOfBenefit.CareTeamComponent();
							Parse(newItem_careTeam, reader, outcome, locationPath + ".careTeam["+result.CareTeam.Count+"]", cancellationToken); // 350
							result.CareTeam.Add(newItem_careTeam);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ExplanationOfBenefit.SupportingInformationComponent();
							Parse(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]", cancellationToken); // 360
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.ExplanationOfBenefit.DiagnosisComponent();
							Parse(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]", cancellationToken); // 370
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "procedure":
							var newItem_procedure = new Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent();
							Parse(newItem_procedure, reader, outcome, locationPath + ".procedure["+result.Procedure.Count+"]", cancellationToken); // 380
							result.Procedure.Add(newItem_procedure);
							break;
						case "precedence":
							result.PrecedenceElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.PrecedenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".precedence", cancellationToken); // 390
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ExplanationOfBenefit.InsuranceComponent();
							Parse(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]", cancellationToken); // 400
							result.Insurance.Add(newItem_insurance);
							break;
						case "accident":
							result.Accident = new Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent();
							Parse(result.Accident as Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent, reader, outcome, locationPath + ".accident", cancellationToken); // 410
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent();
							Parse(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]", cancellationToken); // 420
							result.Item.Add(newItem_item);
							break;
						case "addItem":
							var newItem_addItem = new Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent();
							Parse(newItem_addItem, reader, outcome, locationPath + ".addItem["+result.AddItem.Count+"]", cancellationToken); // 430
							result.AddItem.Add(newItem_addItem);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent();
							Parse(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]", cancellationToken); // 440
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "total":
							var newItem_total = new Hl7.Fhir.Model.ExplanationOfBenefit.TotalComponent();
							Parse(newItem_total, reader, outcome, locationPath + ".total["+result.Total.Count+"]", cancellationToken); // 450
							result.Total.Add(newItem_total);
							break;
						case "payment":
							result.Payment = new Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent();
							Parse(result.Payment as Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent, reader, outcome, locationPath + ".payment", cancellationToken); // 460
							break;
						case "formCode":
							result.FormCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FormCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".formCode", cancellationToken); // 470
							break;
						case "form":
							result.Form = new Hl7.Fhir.Model.Attachment();
							Parse(result.Form as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".form", cancellationToken); // 480
							break;
						case "processNote":
							var newItem_processNote = new Hl7.Fhir.Model.ExplanationOfBenefit.NoteComponent();
							Parse(newItem_processNote, reader, outcome, locationPath + ".processNote["+result.ProcessNote.Count+"]", cancellationToken); // 490
							result.ProcessNote.Add(newItem_processNote);
							break;
						case "benefitPeriod":
							result.BenefitPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.BenefitPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".benefitPeriod", cancellationToken); // 500
							break;
						case "benefitBalance":
							var newItem_benefitBalance = new Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent();
							Parse(newItem_benefitBalance, reader, outcome, locationPath + ".benefitBalance["+result.BenefitBalance.Count+"]", cancellationToken); // 510
							result.BenefitBalance.Add(newItem_benefitBalance);
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

		private async System.Threading.Tasks.Task ParseAsync(ExplanationOfBenefit result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ExplanationOfBenefit.ExplanationOfBenefitStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ExplanationOfBenefit.ExplanationOfBenefitStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 110
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subType", cancellationToken); // 120
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>, reader, outcome, locationPath + ".use", cancellationToken); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 140
							break;
						case "billablePeriod":
							result.BillablePeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.BillablePeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".billablePeriod", cancellationToken); // 150
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created", cancellationToken); // 160
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".enterer", cancellationToken); // 170
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".insurer", cancellationToken); // 180
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".provider", cancellationToken); // 190
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority", cancellationToken); // 200
							break;
						case "fundsReserveRequested":
							result.FundsReserveRequested = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FundsReserveRequested as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundsReserveRequested", cancellationToken); // 210
							break;
						case "fundsReserve":
							result.FundsReserve = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FundsReserve as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fundsReserve", cancellationToken); // 220
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.ExplanationOfBenefit.RelatedClaimComponent();
							await ParseAsync(newItem_related, reader, outcome, locationPath + ".related["+result.Related.Count+"]", cancellationToken); // 230
							result.Related.Add(newItem_related);
							break;
						case "prescription":
							result.Prescription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Prescription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".prescription", cancellationToken); // 240
							break;
						case "originalPrescription":
							result.OriginalPrescription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OriginalPrescription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".originalPrescription", cancellationToken); // 250
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent();
							await ParseAsync(result.Payee as Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent, reader, outcome, locationPath + ".payee", cancellationToken); // 260
							break;
						case "referral":
							result.Referral = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Referral as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".referral", cancellationToken); // 270
							break;
						case "facility":
							result.Facility = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Facility as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".facility", cancellationToken); // 280
							break;
						case "claim":
							result.Claim = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Claim as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".claim", cancellationToken); // 290
							break;
						case "claimResponse":
							result.ClaimResponse = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ClaimResponse as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".claimResponse", cancellationToken); // 300
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RemittanceOutcome>();
							await ParseAsync(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RemittanceOutcome>, reader, outcome, locationPath + ".outcome", cancellationToken); // 310
							break;
						case "disposition":
							result.DispositionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DispositionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".disposition", cancellationToken); // 320
							break;
						case "preAuthRef":
							var newItem_preAuthRef = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_preAuthRef, reader, outcome, locationPath + ".preAuthRef["+result.PreAuthRefElement.Count+"]", cancellationToken); // 330
							result.PreAuthRefElement.Add(newItem_preAuthRef);
							break;
						case "preAuthRefPeriod":
							var newItem_preAuthRefPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(newItem_preAuthRefPeriod, reader, outcome, locationPath + ".preAuthRefPeriod["+result.PreAuthRefPeriod.Count+"]", cancellationToken); // 340
							result.PreAuthRefPeriod.Add(newItem_preAuthRefPeriod);
							break;
						case "careTeam":
							var newItem_careTeam = new Hl7.Fhir.Model.ExplanationOfBenefit.CareTeamComponent();
							await ParseAsync(newItem_careTeam, reader, outcome, locationPath + ".careTeam["+result.CareTeam.Count+"]", cancellationToken); // 350
							result.CareTeam.Add(newItem_careTeam);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ExplanationOfBenefit.SupportingInformationComponent();
							await ParseAsync(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]", cancellationToken); // 360
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.ExplanationOfBenefit.DiagnosisComponent();
							await ParseAsync(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]", cancellationToken); // 370
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "procedure":
							var newItem_procedure = new Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent();
							await ParseAsync(newItem_procedure, reader, outcome, locationPath + ".procedure["+result.Procedure.Count+"]", cancellationToken); // 380
							result.Procedure.Add(newItem_procedure);
							break;
						case "precedence":
							result.PrecedenceElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.PrecedenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".precedence", cancellationToken); // 390
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ExplanationOfBenefit.InsuranceComponent();
							await ParseAsync(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]", cancellationToken); // 400
							result.Insurance.Add(newItem_insurance);
							break;
						case "accident":
							result.Accident = new Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent();
							await ParseAsync(result.Accident as Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent, reader, outcome, locationPath + ".accident", cancellationToken); // 410
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent();
							await ParseAsync(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]", cancellationToken); // 420
							result.Item.Add(newItem_item);
							break;
						case "addItem":
							var newItem_addItem = new Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent();
							await ParseAsync(newItem_addItem, reader, outcome, locationPath + ".addItem["+result.AddItem.Count+"]", cancellationToken); // 430
							result.AddItem.Add(newItem_addItem);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent();
							await ParseAsync(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]", cancellationToken); // 440
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "total":
							var newItem_total = new Hl7.Fhir.Model.ExplanationOfBenefit.TotalComponent();
							await ParseAsync(newItem_total, reader, outcome, locationPath + ".total["+result.Total.Count+"]", cancellationToken); // 450
							result.Total.Add(newItem_total);
							break;
						case "payment":
							result.Payment = new Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent();
							await ParseAsync(result.Payment as Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent, reader, outcome, locationPath + ".payment", cancellationToken); // 460
							break;
						case "formCode":
							result.FormCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FormCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".formCode", cancellationToken); // 470
							break;
						case "form":
							result.Form = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Form as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".form", cancellationToken); // 480
							break;
						case "processNote":
							var newItem_processNote = new Hl7.Fhir.Model.ExplanationOfBenefit.NoteComponent();
							await ParseAsync(newItem_processNote, reader, outcome, locationPath + ".processNote["+result.ProcessNote.Count+"]", cancellationToken); // 490
							result.ProcessNote.Add(newItem_processNote);
							break;
						case "benefitPeriod":
							result.BenefitPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.BenefitPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".benefitPeriod", cancellationToken); // 500
							break;
						case "benefitBalance":
							var newItem_benefitBalance = new Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent();
							await ParseAsync(newItem_benefitBalance, reader, outcome, locationPath + ".benefitBalance["+result.BenefitBalance.Count+"]", cancellationToken); // 510
							result.BenefitBalance.Add(newItem_benefitBalance);
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
