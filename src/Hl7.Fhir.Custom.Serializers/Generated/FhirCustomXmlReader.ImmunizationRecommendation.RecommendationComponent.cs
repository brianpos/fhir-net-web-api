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
		public void Parse(Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "vaccineCode":
							var newItem_vaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_vaccineCode, reader, outcome); // 40
							result.VaccineCode.Add(newItem_vaccineCode);
							break;
						case "targetDisease":
							result.TargetDisease = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.TargetDisease as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "contraindicatedVaccineCode":
							var newItem_contraindicatedVaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_contraindicatedVaccineCode, reader, outcome); // 60
							result.ContraindicatedVaccineCode.Add(newItem_contraindicatedVaccineCode);
							break;
						case "forecastStatus":
							result.ForecastStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ForecastStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "forecastReason":
							var newItem_forecastReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_forecastReason, reader, outcome); // 80
							result.ForecastReason.Add(newItem_forecastReason);
							break;
						case "dateCriterion":
							var newItem_dateCriterion = new Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent();
							Parse(newItem_dateCriterion, reader, outcome); // 90
							result.DateCriterion.Add(newItem_dateCriterion);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 100
							break;
						case "series":
							result.SeriesElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SeriesElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "doseNumberPositiveInt":
							result.DoseNumber = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.DoseNumber as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 120
							break;
						case "doseNumberString":
							result.DoseNumber = new Hl7.Fhir.Model.FhirString();
							Parse(result.DoseNumber as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "seriesDosesPositiveInt":
							result.SeriesDoses = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.SeriesDoses as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 130
							break;
						case "seriesDosesString":
							result.SeriesDoses = new Hl7.Fhir.Model.FhirString();
							Parse(result.SeriesDoses as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "supportingImmunization":
							var newItem_supportingImmunization = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingImmunization, reader, outcome); // 140
							result.SupportingImmunization.Add(newItem_supportingImmunization);
							break;
						case "supportingPatientInformation":
							var newItem_supportingPatientInformation = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supportingPatientInformation, reader, outcome); // 150
							result.SupportingPatientInformation.Add(newItem_supportingPatientInformation);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "vaccineCode":
							var newItem_vaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_vaccineCode, reader, outcome); // 40
							result.VaccineCode.Add(newItem_vaccineCode);
							break;
						case "targetDisease":
							result.TargetDisease = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.TargetDisease as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "contraindicatedVaccineCode":
							var newItem_contraindicatedVaccineCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_contraindicatedVaccineCode, reader, outcome); // 60
							result.ContraindicatedVaccineCode.Add(newItem_contraindicatedVaccineCode);
							break;
						case "forecastStatus":
							result.ForecastStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ForecastStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "forecastReason":
							var newItem_forecastReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_forecastReason, reader, outcome); // 80
							result.ForecastReason.Add(newItem_forecastReason);
							break;
						case "dateCriterion":
							var newItem_dateCriterion = new Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent();
							await ParseAsync(newItem_dateCriterion, reader, outcome); // 90
							result.DateCriterion.Add(newItem_dateCriterion);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 100
							break;
						case "series":
							result.SeriesElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SeriesElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "doseNumberPositiveInt":
							result.DoseNumber = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.DoseNumber as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 120
							break;
						case "doseNumberString":
							result.DoseNumber = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DoseNumber as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "seriesDosesPositiveInt":
							result.SeriesDoses = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.SeriesDoses as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 130
							break;
						case "seriesDosesString":
							result.SeriesDoses = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SeriesDoses as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "supportingImmunization":
							var newItem_supportingImmunization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingImmunization, reader, outcome); // 140
							result.SupportingImmunization.Add(newItem_supportingImmunization);
							break;
						case "supportingPatientInformation":
							var newItem_supportingPatientInformation = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supportingPatientInformation, reader, outcome); // 150
							result.SupportingPatientInformation.Add(newItem_supportingPatientInformation);
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
