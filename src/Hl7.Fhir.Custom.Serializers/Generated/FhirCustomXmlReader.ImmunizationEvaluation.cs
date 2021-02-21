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
		private void Parse(ImmunizationEvaluation result, XmlReader reader, OperationOutcome outcome)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>, reader, outcome); // 100
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 120
							break;
						case "authority":
							result.Authority = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Authority as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 130
							break;
						case "targetDisease":
							result.TargetDisease = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.TargetDisease as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "immunizationEvent":
							result.ImmunizationEvent = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ImmunizationEvent as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "doseStatus":
							result.DoseStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DoseStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "doseStatusReason":
							var newItem_doseStatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_doseStatusReason, reader, outcome); // 170
							result.DoseStatusReason.Add(newItem_doseStatusReason);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 180
							break;
						case "series":
							result.SeriesElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SeriesElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 190
							break;
						case "doseNumberPositiveInt":
							result.DoseNumber = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.DoseNumber as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 200
							break;
						case "doseNumberString":
							result.DoseNumber = new Hl7.Fhir.Model.FhirString();
							Parse(result.DoseNumber as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
							break;
						case "seriesDosesPositiveInt":
							result.SeriesDoses = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.SeriesDoses as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 210
							break;
						case "seriesDosesString":
							result.SeriesDoses = new Hl7.Fhir.Model.FhirString();
							Parse(result.SeriesDoses as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
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

		private async System.Threading.Tasks.Task ParseAsync(ImmunizationEvaluation result, XmlReader reader, OperationOutcome outcome)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>, reader, outcome); // 100
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 120
							break;
						case "authority":
							result.Authority = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Authority as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 130
							break;
						case "targetDisease":
							result.TargetDisease = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.TargetDisease as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "immunizationEvent":
							result.ImmunizationEvent = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ImmunizationEvent as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "doseStatus":
							result.DoseStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DoseStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "doseStatusReason":
							var newItem_doseStatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_doseStatusReason, reader, outcome); // 170
							result.DoseStatusReason.Add(newItem_doseStatusReason);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 180
							break;
						case "series":
							result.SeriesElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SeriesElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 190
							break;
						case "doseNumberPositiveInt":
							result.DoseNumber = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.DoseNumber as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 200
							break;
						case "doseNumberString":
							result.DoseNumber = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DoseNumber as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
							break;
						case "seriesDosesPositiveInt":
							result.SeriesDoses = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.SeriesDoses as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 210
							break;
						case "seriesDosesString":
							result.SeriesDoses = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SeriesDoses as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
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
