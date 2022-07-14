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
		public void Parse(Hl7.Fhir.Model.Ingredient.StrengthComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "presentationRatio":
							result.Presentation = new Hl7.Fhir.Model.Ratio();
							Parse(result.Presentation as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".presentation", cancellationToken); // 40
							break;
						case "presentationRatioRange":
							result.Presentation = new Hl7.Fhir.Model.RatioRange();
							Parse(result.Presentation as Hl7.Fhir.Model.RatioRange, reader, outcome, locationPath + ".presentation", cancellationToken); // 40
							break;
						case "textPresentation":
							result.TextPresentationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextPresentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".textPresentation", cancellationToken); // 50
							break;
						case "concentrationRatio":
							result.Concentration = new Hl7.Fhir.Model.Ratio();
							Parse(result.Concentration as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".concentration", cancellationToken); // 60
							break;
						case "concentrationRatioRange":
							result.Concentration = new Hl7.Fhir.Model.RatioRange();
							Parse(result.Concentration as Hl7.Fhir.Model.RatioRange, reader, outcome, locationPath + ".concentration", cancellationToken); // 60
							break;
						case "textConcentration":
							result.TextConcentrationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextConcentrationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".textConcentration", cancellationToken); // 70
							break;
						case "measurementPoint":
							result.MeasurementPointElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MeasurementPointElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".measurementPoint", cancellationToken); // 80
							break;
						case "country":
							var newItem_country = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_country, reader, outcome, locationPath + ".country["+result.Country.Count+"]", cancellationToken); // 90
							result.Country.Add(newItem_country);
							break;
						case "referenceStrength":
							var newItem_referenceStrength = new Hl7.Fhir.Model.Ingredient.ReferenceStrengthComponent();
							Parse(newItem_referenceStrength, reader, outcome, locationPath + ".referenceStrength["+result.ReferenceStrength.Count+"]", cancellationToken); // 100
							result.ReferenceStrength.Add(newItem_referenceStrength);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Ingredient.StrengthComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "presentationRatio":
							result.Presentation = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Presentation as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".presentation", cancellationToken); // 40
							break;
						case "presentationRatioRange":
							result.Presentation = new Hl7.Fhir.Model.RatioRange();
							await ParseAsync(result.Presentation as Hl7.Fhir.Model.RatioRange, reader, outcome, locationPath + ".presentation", cancellationToken); // 40
							break;
						case "textPresentation":
							result.TextPresentationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextPresentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".textPresentation", cancellationToken); // 50
							break;
						case "concentrationRatio":
							result.Concentration = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Concentration as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".concentration", cancellationToken); // 60
							break;
						case "concentrationRatioRange":
							result.Concentration = new Hl7.Fhir.Model.RatioRange();
							await ParseAsync(result.Concentration as Hl7.Fhir.Model.RatioRange, reader, outcome, locationPath + ".concentration", cancellationToken); // 60
							break;
						case "textConcentration":
							result.TextConcentrationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextConcentrationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".textConcentration", cancellationToken); // 70
							break;
						case "measurementPoint":
							result.MeasurementPointElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MeasurementPointElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".measurementPoint", cancellationToken); // 80
							break;
						case "country":
							var newItem_country = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_country, reader, outcome, locationPath + ".country["+result.Country.Count+"]", cancellationToken); // 90
							result.Country.Add(newItem_country);
							break;
						case "referenceStrength":
							var newItem_referenceStrength = new Hl7.Fhir.Model.Ingredient.ReferenceStrengthComponent();
							await ParseAsync(newItem_referenceStrength, reader, outcome, locationPath + ".referenceStrength["+result.ReferenceStrength.Count+"]", cancellationToken); // 100
							result.ReferenceStrength.Add(newItem_referenceStrength);
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
