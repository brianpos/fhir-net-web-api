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
		private void Parse(ClinicalImpression result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 110
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 120
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 130
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 140
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 150
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective"); // 160
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							Parse(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective"); // 160
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 170
							break;
						case "assessor":
							result.Assessor = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Assessor as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".assessor"); // 180
							break;
						case "previous":
							result.Previous = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Previous as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".previous"); // 190
							break;
						case "problem":
							var newItem_problem = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_problem, reader, outcome, locationPath + ".problem["+result.Problem.Count+"]"); // 200
							result.Problem.Add(newItem_problem);
							break;
						case "investigation":
							var newItem_investigation = new Hl7.Fhir.Model.ClinicalImpression.InvestigationComponent();
							Parse(newItem_investigation, reader, outcome, locationPath + ".investigation["+result.Investigation.Count+"]"); // 210
							result.Investigation.Add(newItem_investigation);
							break;
						case "protocol":
							var newItem_protocol = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_protocol, reader, outcome, locationPath + ".protocol["+result.ProtocolElement.Count+"]"); // 220
							result.ProtocolElement.Add(newItem_protocol);
							break;
						case "summary":
							result.SummaryElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SummaryElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".summary"); // 230
							break;
						case "finding":
							var newItem_finding = new Hl7.Fhir.Model.ClinicalImpression.FindingComponent();
							Parse(newItem_finding, reader, outcome, locationPath + ".finding["+result.Finding.Count+"]"); // 240
							result.Finding.Add(newItem_finding);
							break;
						case "prognosisCodeableConcept":
							var newItem_prognosisCodeableConcept = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_prognosisCodeableConcept, reader, outcome, locationPath + ".prognosisCodeableConcept["+result.PrognosisCodeableConcept.Count+"]"); // 250
							result.PrognosisCodeableConcept.Add(newItem_prognosisCodeableConcept);
							break;
						case "prognosisReference":
							var newItem_prognosisReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_prognosisReference, reader, outcome, locationPath + ".prognosisReference["+result.PrognosisReference.Count+"]"); // 260
							result.PrognosisReference.Add(newItem_prognosisReference);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]"); // 270
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 280
							result.Note.Add(newItem_note);
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

		private async System.Threading.Tasks.Task ParseAsync(ClinicalImpression result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 110
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 120
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 130
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 140
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 150
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective"); // 160
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective"); // 160
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 170
							break;
						case "assessor":
							result.Assessor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Assessor as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".assessor"); // 180
							break;
						case "previous":
							result.Previous = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Previous as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".previous"); // 190
							break;
						case "problem":
							var newItem_problem = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_problem, reader, outcome, locationPath + ".problem["+result.Problem.Count+"]"); // 200
							result.Problem.Add(newItem_problem);
							break;
						case "investigation":
							var newItem_investigation = new Hl7.Fhir.Model.ClinicalImpression.InvestigationComponent();
							await ParseAsync(newItem_investigation, reader, outcome, locationPath + ".investigation["+result.Investigation.Count+"]"); // 210
							result.Investigation.Add(newItem_investigation);
							break;
						case "protocol":
							var newItem_protocol = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_protocol, reader, outcome, locationPath + ".protocol["+result.ProtocolElement.Count+"]"); // 220
							result.ProtocolElement.Add(newItem_protocol);
							break;
						case "summary":
							result.SummaryElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SummaryElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".summary"); // 230
							break;
						case "finding":
							var newItem_finding = new Hl7.Fhir.Model.ClinicalImpression.FindingComponent();
							await ParseAsync(newItem_finding, reader, outcome, locationPath + ".finding["+result.Finding.Count+"]"); // 240
							result.Finding.Add(newItem_finding);
							break;
						case "prognosisCodeableConcept":
							var newItem_prognosisCodeableConcept = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_prognosisCodeableConcept, reader, outcome, locationPath + ".prognosisCodeableConcept["+result.PrognosisCodeableConcept.Count+"]"); // 250
							result.PrognosisCodeableConcept.Add(newItem_prognosisCodeableConcept);
							break;
						case "prognosisReference":
							var newItem_prognosisReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_prognosisReference, reader, outcome, locationPath + ".prognosisReference["+result.PrognosisReference.Count+"]"); // 260
							result.PrognosisReference.Add(newItem_prognosisReference);
							break;
						case "supportingInfo":
							var newItem_supportingInfo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingInfo, reader, outcome, locationPath + ".supportingInfo["+result.SupportingInfo.Count+"]"); // 270
							result.SupportingInfo.Add(newItem_supportingInfo);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 280
							result.Note.Add(newItem_note);
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
