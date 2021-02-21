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
		private void Parse(Claim result, XmlReader reader, OperationOutcome outcome)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>, reader, outcome); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "billablePeriod":
							result.BillablePeriod = new Hl7.Fhir.Model.Period();
							Parse(result.BillablePeriod as Hl7.Fhir.Model.Period, reader, outcome); // 150
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 170
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 180
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 200
							break;
						case "fundsReserve":
							result.FundsReserve = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FundsReserve as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 210
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.Claim.RelatedClaimComponent();
							Parse(newItem_related, reader, outcome); // 220
							result.Related.Add(newItem_related);
							break;
						case "prescription":
							result.Prescription = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Prescription as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 230
							break;
						case "originalPrescription":
							result.OriginalPrescription = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OriginalPrescription as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 240
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.Claim.PayeeComponent();
							Parse(result.Payee as Hl7.Fhir.Model.Claim.PayeeComponent, reader, outcome); // 250
							break;
						case "referral":
							result.Referral = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Referral as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "facility":
							result.Facility = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Facility as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "careTeam":
							var newItem_careTeam = new Hl7.Fhir.Model.Claim.CareTeamComponent();
							Parse(newItem_careTeam, reader, outcome); // 280
							result.CareTeam.Add(newItem_careTeam);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.Claim.SupportingInformationComponent();
							Parse(newItem_supportingInfo, reader, outcome); // 290
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.Claim.DiagnosisComponent();
							Parse(newItem_diagnosis, reader, outcome); // 300
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "procedure":
							var newItem_procedure = new Hl7.Fhir.Model.Claim.ProcedureComponent();
							Parse(newItem_procedure, reader, outcome); // 310
							result.Procedure.Add(newItem_procedure);
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.Claim.InsuranceComponent();
							Parse(newItem_insurance, reader, outcome); // 320
							result.Insurance.Add(newItem_insurance);
							break;
						case "accident":
							result.Accident = new Hl7.Fhir.Model.Claim.AccidentComponent();
							Parse(result.Accident as Hl7.Fhir.Model.Claim.AccidentComponent, reader, outcome); // 330
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.Claim.ItemComponent();
							Parse(newItem_item, reader, outcome); // 340
							result.Item.Add(newItem_item);
							break;
						case "total":
							result.Total = new Hl7.Fhir.Model.Money();
							Parse(result.Total as Hl7.Fhir.Model.Money, reader, outcome); // 350
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

		private async System.Threading.Tasks.Task ParseAsync(Claim result, XmlReader reader, OperationOutcome outcome)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use>, reader, outcome); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "billablePeriod":
							result.BillablePeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.BillablePeriod as Hl7.Fhir.Model.Period, reader, outcome); // 150
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 170
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 180
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 200
							break;
						case "fundsReserve":
							result.FundsReserve = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FundsReserve as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 210
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.Claim.RelatedClaimComponent();
							await ParseAsync(newItem_related, reader, outcome); // 220
							result.Related.Add(newItem_related);
							break;
						case "prescription":
							result.Prescription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Prescription as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 230
							break;
						case "originalPrescription":
							result.OriginalPrescription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OriginalPrescription as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 240
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.Claim.PayeeComponent();
							await ParseAsync(result.Payee as Hl7.Fhir.Model.Claim.PayeeComponent, reader, outcome); // 250
							break;
						case "referral":
							result.Referral = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Referral as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "facility":
							result.Facility = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Facility as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
							break;
						case "careTeam":
							var newItem_careTeam = new Hl7.Fhir.Model.Claim.CareTeamComponent();
							await ParseAsync(newItem_careTeam, reader, outcome); // 280
							result.CareTeam.Add(newItem_careTeam);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.Claim.SupportingInformationComponent();
							await ParseAsync(newItem_supportingInfo, reader, outcome); // 290
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.Claim.DiagnosisComponent();
							await ParseAsync(newItem_diagnosis, reader, outcome); // 300
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "procedure":
							var newItem_procedure = new Hl7.Fhir.Model.Claim.ProcedureComponent();
							await ParseAsync(newItem_procedure, reader, outcome); // 310
							result.Procedure.Add(newItem_procedure);
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.Claim.InsuranceComponent();
							await ParseAsync(newItem_insurance, reader, outcome); // 320
							result.Insurance.Add(newItem_insurance);
							break;
						case "accident":
							result.Accident = new Hl7.Fhir.Model.Claim.AccidentComponent();
							await ParseAsync(result.Accident as Hl7.Fhir.Model.Claim.AccidentComponent, reader, outcome); // 330
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.Claim.ItemComponent();
							await ParseAsync(newItem_item, reader, outcome); // 340
							result.Item.Add(newItem_item);
							break;
						case "total":
							result.Total = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Total as Hl7.Fhir.Model.Money, reader, outcome); // 350
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
