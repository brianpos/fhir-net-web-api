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
		public void Parse(Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				return;

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
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 50
							break;
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.ValueElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".value"); // 60
							break;
						case "unitOfMeasure":
							result.UnitOfMeasure = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.UnitOfMeasure as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unitOfMeasure"); // 70
							break;
						case "denominatorCount":
							result.DenominatorCountElement = new Hl7.Fhir.Model.Integer();
							Parse(result.DenominatorCountElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".denominatorCount"); // 80
							break;
						case "numeratorCount":
							result.NumeratorCountElement = new Hl7.Fhir.Model.Integer();
							Parse(result.NumeratorCountElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".numeratorCount"); // 90
							break;
						case "precisionEstimate":
							var newItem_precisionEstimate = new Hl7.Fhir.Model.RiskEvidenceSynthesis.PrecisionEstimateComponent();
							Parse(newItem_precisionEstimate, reader, outcome, locationPath + ".precisionEstimate["+result.PrecisionEstimate.Count+"]"); // 100
							result.PrecisionEstimate.Add(newItem_precisionEstimate);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				return;

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
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description"); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 50
							break;
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.ValueElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".value"); // 60
							break;
						case "unitOfMeasure":
							result.UnitOfMeasure = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.UnitOfMeasure as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unitOfMeasure"); // 70
							break;
						case "denominatorCount":
							result.DenominatorCountElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.DenominatorCountElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".denominatorCount"); // 80
							break;
						case "numeratorCount":
							result.NumeratorCountElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.NumeratorCountElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".numeratorCount"); // 90
							break;
						case "precisionEstimate":
							var newItem_precisionEstimate = new Hl7.Fhir.Model.RiskEvidenceSynthesis.PrecisionEstimateComponent();
							await ParseAsync(newItem_precisionEstimate, reader, outcome, locationPath + ".precisionEstimate["+result.PrecisionEstimate.Count+"]"); // 100
							result.PrecisionEstimate.Add(newItem_precisionEstimate);
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
