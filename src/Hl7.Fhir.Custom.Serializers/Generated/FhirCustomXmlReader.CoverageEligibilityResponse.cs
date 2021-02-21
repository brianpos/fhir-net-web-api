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
		private void Parse(CoverageEligibilityResponse result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "purpose":
							var newItem_purpose = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CoverageEligibilityResponse.EligibilityResponsePurpose>();
							Parse(newItem_purpose, reader, outcome, locationPath + ".purpose["+result.PurposeElement.Count+"]"); // 110
							result.PurposeElement.Add(newItem_purpose);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 120
							break;
						case "servicedDate":
							result.Serviced = new Hl7.Fhir.Model.Date();
							Parse(result.Serviced as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".serviced"); // 130
							break;
						case "servicedPeriod":
							result.Serviced = new Hl7.Fhir.Model.Period();
							Parse(result.Serviced as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".serviced"); // 130
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 140
							break;
						case "requestor":
							result.Requestor = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requestor as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requestor"); // 150
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 160
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>();
							Parse(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>, reader, outcome, locationPath + ".outcome"); // 170
							break;
						case "disposition":
							result.DispositionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DispositionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".disposition"); // 180
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".insurer"); // 190
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent();
							Parse(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 200
							result.Insurance.Add(newItem_insurance);
							break;
						case "preAuthRef":
							result.PreAuthRefElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PreAuthRefElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".preAuthRef"); // 210
							break;
						case "form":
							result.Form = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Form as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".form"); // 220
							break;
						case "error":
							var newItem_error = new Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent();
							Parse(newItem_error, reader, outcome, locationPath + ".error["+result.Error.Count+"]"); // 230
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

		private async System.Threading.Tasks.Task ParseAsync(CoverageEligibilityResponse result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "purpose":
							var newItem_purpose = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CoverageEligibilityResponse.EligibilityResponsePurpose>();
							await ParseAsync(newItem_purpose, reader, outcome, locationPath + ".purpose["+result.PurposeElement.Count+"]"); // 110
							result.PurposeElement.Add(newItem_purpose);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 120
							break;
						case "servicedDate":
							result.Serviced = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Serviced as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".serviced"); // 130
							break;
						case "servicedPeriod":
							result.Serviced = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Serviced as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".serviced"); // 130
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 140
							break;
						case "requestor":
							result.Requestor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requestor as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".requestor"); // 150
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 160
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>();
							await ParseAsync(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes>, reader, outcome, locationPath + ".outcome"); // 170
							break;
						case "disposition":
							result.DispositionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DispositionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".disposition"); // 180
							break;
						case "insurer":
							result.Insurer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Insurer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".insurer"); // 190
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent();
							await ParseAsync(newItem_insurance, reader, outcome, locationPath + ".insurance["+result.Insurance.Count+"]"); // 200
							result.Insurance.Add(newItem_insurance);
							break;
						case "preAuthRef":
							result.PreAuthRefElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PreAuthRefElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".preAuthRef"); // 210
							break;
						case "form":
							result.Form = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Form as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".form"); // 220
							break;
						case "error":
							var newItem_error = new Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent();
							await ParseAsync(newItem_error, reader, outcome, locationPath + ".error["+result.Error.Count+"]"); // 230
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
