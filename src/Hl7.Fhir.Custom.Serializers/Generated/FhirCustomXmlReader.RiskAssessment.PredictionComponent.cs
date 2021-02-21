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
		public void Parse(Hl7.Fhir.Model.RiskAssessment.PredictionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome"); // 40
							break;
						case "probabilityDecimal":
							result.Probability = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.Probability as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".probability"); // 50
							break;
						case "probabilityRange":
							result.Probability = new Hl7.Fhir.Model.Range();
							Parse(result.Probability as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".probability"); // 50
							break;
						case "qualitativeRisk":
							result.QualitativeRisk = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.QualitativeRisk as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".qualitativeRisk"); // 60
							break;
						case "relativeRisk":
							result.RelativeRiskElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.RelativeRiskElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".relativeRisk"); // 70
							break;
						case "whenPeriod":
							result.When = new Hl7.Fhir.Model.Period();
							Parse(result.When as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".when"); // 80
							break;
						case "whenRange":
							result.When = new Hl7.Fhir.Model.Range();
							Parse(result.When as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".when"); // 80
							break;
						case "rationale":
							result.RationaleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RationaleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".rationale"); // 90
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.RiskAssessment.PredictionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome"); // 40
							break;
						case "probabilityDecimal":
							result.Probability = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.Probability as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".probability"); // 50
							break;
						case "probabilityRange":
							result.Probability = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Probability as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".probability"); // 50
							break;
						case "qualitativeRisk":
							result.QualitativeRisk = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.QualitativeRisk as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".qualitativeRisk"); // 60
							break;
						case "relativeRisk":
							result.RelativeRiskElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.RelativeRiskElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".relativeRisk"); // 70
							break;
						case "whenPeriod":
							result.When = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.When as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".when"); // 80
							break;
						case "whenRange":
							result.When = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.When as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".when"); // 80
							break;
						case "rationale":
							result.RationaleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RationaleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".rationale"); // 90
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
