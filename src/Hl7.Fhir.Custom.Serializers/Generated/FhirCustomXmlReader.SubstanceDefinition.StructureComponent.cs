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
		public void Parse(Hl7.Fhir.Model.SubstanceDefinition.StructureComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "stereochemistry":
							result.Stereochemistry = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Stereochemistry as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".stereochemistry", cancellationToken); // 40
							break;
						case "opticalActivity":
							result.OpticalActivity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OpticalActivity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".opticalActivity", cancellationToken); // 50
							break;
						case "molecularFormula":
							result.MolecularFormulaElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MolecularFormulaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormula", cancellationToken); // 60
							break;
						case "molecularFormulaByMoiety":
							result.MolecularFormulaByMoietyElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MolecularFormulaByMoietyElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormulaByMoiety", cancellationToken); // 70
							break;
						case "molecularWeight":
							result.MolecularWeight = new Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent();
							Parse(result.MolecularWeight as Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent, reader, outcome, locationPath + ".molecularWeight", cancellationToken); // 80
							break;
						case "technique":
							var newItem_technique = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_technique, reader, outcome, locationPath + ".technique["+result.Technique.Count+"]", cancellationToken); // 90
							result.Technique.Add(newItem_technique);
							break;
						case "sourceDocument":
							var newItem_sourceDocument = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_sourceDocument, reader, outcome, locationPath + ".sourceDocument["+result.SourceDocument.Count+"]", cancellationToken); // 100
							result.SourceDocument.Add(newItem_sourceDocument);
							break;
						case "representation":
							var newItem_representation = new Hl7.Fhir.Model.SubstanceDefinition.RepresentationComponent();
							Parse(newItem_representation, reader, outcome, locationPath + ".representation["+result.Representation.Count+"]", cancellationToken); // 110
							result.Representation.Add(newItem_representation);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceDefinition.StructureComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "stereochemistry":
							result.Stereochemistry = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Stereochemistry as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".stereochemistry", cancellationToken); // 40
							break;
						case "opticalActivity":
							result.OpticalActivity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OpticalActivity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".opticalActivity", cancellationToken); // 50
							break;
						case "molecularFormula":
							result.MolecularFormulaElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MolecularFormulaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormula", cancellationToken); // 60
							break;
						case "molecularFormulaByMoiety":
							result.MolecularFormulaByMoietyElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MolecularFormulaByMoietyElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormulaByMoiety", cancellationToken); // 70
							break;
						case "molecularWeight":
							result.MolecularWeight = new Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent();
							await ParseAsync(result.MolecularWeight as Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent, reader, outcome, locationPath + ".molecularWeight", cancellationToken); // 80
							break;
						case "technique":
							var newItem_technique = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_technique, reader, outcome, locationPath + ".technique["+result.Technique.Count+"]", cancellationToken); // 90
							result.Technique.Add(newItem_technique);
							break;
						case "sourceDocument":
							var newItem_sourceDocument = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_sourceDocument, reader, outcome, locationPath + ".sourceDocument["+result.SourceDocument.Count+"]", cancellationToken); // 100
							result.SourceDocument.Add(newItem_sourceDocument);
							break;
						case "representation":
							var newItem_representation = new Hl7.Fhir.Model.SubstanceDefinition.RepresentationComponent();
							await ParseAsync(newItem_representation, reader, outcome, locationPath + ".representation["+result.Representation.Count+"]", cancellationToken); // 110
							result.Representation.Add(newItem_representation);
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
