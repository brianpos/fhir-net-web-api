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
		public void Parse(Hl7.Fhir.Model.Dosage result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.Integer();
							Parse(result.SequenceElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".sequence"); // 90
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text"); // 100
							break;
						case "additionalInstruction":
							var newItem_additionalInstruction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_additionalInstruction, reader, outcome, locationPath + ".additionalInstruction["+result.AdditionalInstruction.Count+"]"); // 110
							result.AdditionalInstruction.Add(newItem_additionalInstruction);
							break;
						case "patientInstruction":
							result.PatientInstructionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PatientInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".patientInstruction"); // 120
							break;
						case "timing":
							result.Timing = new Hl7.Fhir.Model.Timing();
							Parse(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing"); // 130
							break;
						case "asNeededBoolean":
							result.AsNeeded = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AsNeeded as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".asNeeded"); // 140
							break;
						case "asNeededCodeableConcept":
							result.AsNeeded = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AsNeeded as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".asNeeded"); // 140
							break;
						case "site":
							result.Site = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Site as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".site"); // 150
							break;
						case "route":
							result.Route = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Route as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".route"); // 160
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method"); // 170
							break;
						case "doseAndRate":
							var newItem_doseAndRate = new Hl7.Fhir.Model.Dosage.DoseAndRateComponent();
							Parse(newItem_doseAndRate, reader, outcome, locationPath + ".doseAndRate["+result.DoseAndRate.Count+"]"); // 180
							result.DoseAndRate.Add(newItem_doseAndRate);
							break;
						case "maxDosePerPeriod":
							result.MaxDosePerPeriod = new Hl7.Fhir.Model.Ratio();
							Parse(result.MaxDosePerPeriod as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".maxDosePerPeriod"); // 190
							break;
						case "maxDosePerAdministration":
							result.MaxDosePerAdministration = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.MaxDosePerAdministration as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".maxDosePerAdministration"); // 200
							break;
						case "maxDosePerLifetime":
							result.MaxDosePerLifetime = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.MaxDosePerLifetime as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".maxDosePerLifetime"); // 210
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Dosage result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.SequenceElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".sequence"); // 90
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text"); // 100
							break;
						case "additionalInstruction":
							var newItem_additionalInstruction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_additionalInstruction, reader, outcome, locationPath + ".additionalInstruction["+result.AdditionalInstruction.Count+"]"); // 110
							result.AdditionalInstruction.Add(newItem_additionalInstruction);
							break;
						case "patientInstruction":
							result.PatientInstructionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PatientInstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".patientInstruction"); // 120
							break;
						case "timing":
							result.Timing = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing"); // 130
							break;
						case "asNeededBoolean":
							result.AsNeeded = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AsNeeded as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".asNeeded"); // 140
							break;
						case "asNeededCodeableConcept":
							result.AsNeeded = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AsNeeded as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".asNeeded"); // 140
							break;
						case "site":
							result.Site = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Site as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".site"); // 150
							break;
						case "route":
							result.Route = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Route as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".route"); // 160
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method"); // 170
							break;
						case "doseAndRate":
							var newItem_doseAndRate = new Hl7.Fhir.Model.Dosage.DoseAndRateComponent();
							await ParseAsync(newItem_doseAndRate, reader, outcome, locationPath + ".doseAndRate["+result.DoseAndRate.Count+"]"); // 180
							result.DoseAndRate.Add(newItem_doseAndRate);
							break;
						case "maxDosePerPeriod":
							result.MaxDosePerPeriod = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.MaxDosePerPeriod as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".maxDosePerPeriod"); // 190
							break;
						case "maxDosePerAdministration":
							result.MaxDosePerAdministration = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.MaxDosePerAdministration as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".maxDosePerAdministration"); // 200
							break;
						case "maxDosePerLifetime":
							result.MaxDosePerLifetime = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.MaxDosePerLifetime as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".maxDosePerLifetime"); // 210
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
