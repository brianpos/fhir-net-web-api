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
		public void Parse(Hl7.Fhir.Model.MolecularSequence.QualityComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.qualityType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.qualityType>, reader, outcome); // 40
							break;
						case "standardSequence":
							result.StandardSequence = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StandardSequence as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Integer();
							Parse(result.StartElement as Hl7.Fhir.Model.Integer, reader, outcome); // 60
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Integer();
							Parse(result.EndElement as Hl7.Fhir.Model.Integer, reader, outcome); // 70
							break;
						case "score":
							result.Score = new Hl7.Fhir.Model.Quantity();
							Parse(result.Score as Hl7.Fhir.Model.Quantity, reader, outcome); // 80
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "truthTP":
							result.TruthTPElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.TruthTPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 100
							break;
						case "queryTP":
							result.QueryTPElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.QueryTPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 110
							break;
						case "truthFN":
							result.TruthFNElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.TruthFNElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 120
							break;
						case "queryFP":
							result.QueryFPElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.QueryFPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 130
							break;
						case "gtFP":
							result.GtFPElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.GtFPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 140
							break;
						case "precision":
							result.PrecisionElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PrecisionElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 150
							break;
						case "recall":
							result.RecallElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.RecallElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 160
							break;
						case "fScore":
							result.FScoreElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FScoreElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 170
							break;
						case "roc":
							result.Roc = new Hl7.Fhir.Model.MolecularSequence.RocComponent();
							Parse(result.Roc as Hl7.Fhir.Model.MolecularSequence.RocComponent, reader, outcome); // 180
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MolecularSequence.QualityComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.qualityType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.qualityType>, reader, outcome); // 40
							break;
						case "standardSequence":
							result.StandardSequence = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StandardSequence as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.StartElement as Hl7.Fhir.Model.Integer, reader, outcome); // 60
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.EndElement as Hl7.Fhir.Model.Integer, reader, outcome); // 70
							break;
						case "score":
							result.Score = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Score as Hl7.Fhir.Model.Quantity, reader, outcome); // 80
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "truthTP":
							result.TruthTPElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.TruthTPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 100
							break;
						case "queryTP":
							result.QueryTPElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.QueryTPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 110
							break;
						case "truthFN":
							result.TruthFNElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.TruthFNElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 120
							break;
						case "queryFP":
							result.QueryFPElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.QueryFPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 130
							break;
						case "gtFP":
							result.GtFPElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.GtFPElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 140
							break;
						case "precision":
							result.PrecisionElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PrecisionElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 150
							break;
						case "recall":
							result.RecallElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.RecallElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 160
							break;
						case "fScore":
							result.FScoreElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FScoreElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 170
							break;
						case "roc":
							result.Roc = new Hl7.Fhir.Model.MolecularSequence.RocComponent();
							await ParseAsync(result.Roc as Hl7.Fhir.Model.MolecularSequence.RocComponent, reader, outcome); // 180
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
