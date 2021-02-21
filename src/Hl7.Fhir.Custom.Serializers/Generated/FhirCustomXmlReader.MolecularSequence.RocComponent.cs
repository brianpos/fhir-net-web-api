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
		public void Parse(Hl7.Fhir.Model.MolecularSequence.RocComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "score":
							var newItem_score = new Hl7.Fhir.Model.Integer();
							Parse(newItem_score, reader, outcome, locationPath + ".score["+result.ScoreElement.Count+"]"); // 40
							result.ScoreElement.Add(newItem_score);
							break;
						case "numTP":
							var newItem_numTP = new Hl7.Fhir.Model.Integer();
							Parse(newItem_numTP, reader, outcome, locationPath + ".numTP["+result.NumTPElement.Count+"]"); // 50
							result.NumTPElement.Add(newItem_numTP);
							break;
						case "numFP":
							var newItem_numFP = new Hl7.Fhir.Model.Integer();
							Parse(newItem_numFP, reader, outcome, locationPath + ".numFP["+result.NumFPElement.Count+"]"); // 60
							result.NumFPElement.Add(newItem_numFP);
							break;
						case "numFN":
							var newItem_numFN = new Hl7.Fhir.Model.Integer();
							Parse(newItem_numFN, reader, outcome, locationPath + ".numFN["+result.NumFNElement.Count+"]"); // 70
							result.NumFNElement.Add(newItem_numFN);
							break;
						case "precision":
							var newItem_precision = new Hl7.Fhir.Model.FhirDecimal();
							Parse(newItem_precision, reader, outcome, locationPath + ".precision["+result.PrecisionElement.Count+"]"); // 80
							result.PrecisionElement.Add(newItem_precision);
							break;
						case "sensitivity":
							var newItem_sensitivity = new Hl7.Fhir.Model.FhirDecimal();
							Parse(newItem_sensitivity, reader, outcome, locationPath + ".sensitivity["+result.SensitivityElement.Count+"]"); // 90
							result.SensitivityElement.Add(newItem_sensitivity);
							break;
						case "fMeasure":
							var newItem_fMeasure = new Hl7.Fhir.Model.FhirDecimal();
							Parse(newItem_fMeasure, reader, outcome, locationPath + ".fMeasure["+result.FMeasureElement.Count+"]"); // 100
							result.FMeasureElement.Add(newItem_fMeasure);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MolecularSequence.RocComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "score":
							var newItem_score = new Hl7.Fhir.Model.Integer();
							await ParseAsync(newItem_score, reader, outcome, locationPath + ".score["+result.ScoreElement.Count+"]"); // 40
							result.ScoreElement.Add(newItem_score);
							break;
						case "numTP":
							var newItem_numTP = new Hl7.Fhir.Model.Integer();
							await ParseAsync(newItem_numTP, reader, outcome, locationPath + ".numTP["+result.NumTPElement.Count+"]"); // 50
							result.NumTPElement.Add(newItem_numTP);
							break;
						case "numFP":
							var newItem_numFP = new Hl7.Fhir.Model.Integer();
							await ParseAsync(newItem_numFP, reader, outcome, locationPath + ".numFP["+result.NumFPElement.Count+"]"); // 60
							result.NumFPElement.Add(newItem_numFP);
							break;
						case "numFN":
							var newItem_numFN = new Hl7.Fhir.Model.Integer();
							await ParseAsync(newItem_numFN, reader, outcome, locationPath + ".numFN["+result.NumFNElement.Count+"]"); // 70
							result.NumFNElement.Add(newItem_numFN);
							break;
						case "precision":
							var newItem_precision = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(newItem_precision, reader, outcome, locationPath + ".precision["+result.PrecisionElement.Count+"]"); // 80
							result.PrecisionElement.Add(newItem_precision);
							break;
						case "sensitivity":
							var newItem_sensitivity = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(newItem_sensitivity, reader, outcome, locationPath + ".sensitivity["+result.SensitivityElement.Count+"]"); // 90
							result.SensitivityElement.Add(newItem_sensitivity);
							break;
						case "fMeasure":
							var newItem_fMeasure = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(newItem_fMeasure, reader, outcome, locationPath + ".fMeasure["+result.FMeasureElement.Count+"]"); // 100
							result.FMeasureElement.Add(newItem_fMeasure);
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
