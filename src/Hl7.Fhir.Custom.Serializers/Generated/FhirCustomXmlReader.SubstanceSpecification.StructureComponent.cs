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
		public void Parse(Hl7.Fhir.Model.SubstanceSpecification.StructureComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "stereochemistry":
							result.Stereochemistry = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Stereochemistry as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".stereochemistry"); // 40
							break;
						case "opticalActivity":
							result.OpticalActivity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OpticalActivity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".opticalActivity"); // 50
							break;
						case "molecularFormula":
							result.MolecularFormulaElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MolecularFormulaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormula"); // 60
							break;
						case "molecularFormulaByMoiety":
							result.MolecularFormulaByMoietyElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MolecularFormulaByMoietyElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormulaByMoiety"); // 70
							break;
						case "isotope":
							var newItem_isotope = new Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent();
							Parse(newItem_isotope, reader, outcome, locationPath + ".isotope["+result.Isotope.Count+"]"); // 80
							result.Isotope.Add(newItem_isotope);
							break;
						case "molecularWeight":
							result.MolecularWeight = new Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent();
							Parse(result.MolecularWeight as Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent, reader, outcome, locationPath + ".molecularWeight"); // 90
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_source, reader, outcome, locationPath + ".source["+result.Source.Count+"]"); // 100
							result.Source.Add(newItem_source);
							break;
						case "representation":
							var newItem_representation = new Hl7.Fhir.Model.SubstanceSpecification.RepresentationComponent();
							Parse(newItem_representation, reader, outcome, locationPath + ".representation["+result.Representation.Count+"]"); // 110
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceSpecification.StructureComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "stereochemistry":
							result.Stereochemistry = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Stereochemistry as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".stereochemistry"); // 40
							break;
						case "opticalActivity":
							result.OpticalActivity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OpticalActivity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".opticalActivity"); // 50
							break;
						case "molecularFormula":
							result.MolecularFormulaElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MolecularFormulaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormula"); // 60
							break;
						case "molecularFormulaByMoiety":
							result.MolecularFormulaByMoietyElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MolecularFormulaByMoietyElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".molecularFormulaByMoiety"); // 70
							break;
						case "isotope":
							var newItem_isotope = new Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent();
							await ParseAsync(newItem_isotope, reader, outcome, locationPath + ".isotope["+result.Isotope.Count+"]"); // 80
							result.Isotope.Add(newItem_isotope);
							break;
						case "molecularWeight":
							result.MolecularWeight = new Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent();
							await ParseAsync(result.MolecularWeight as Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent, reader, outcome, locationPath + ".molecularWeight"); // 90
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_source, reader, outcome, locationPath + ".source["+result.Source.Count+"]"); // 100
							result.Source.Add(newItem_source);
							break;
						case "representation":
							var newItem_representation = new Hl7.Fhir.Model.SubstanceSpecification.RepresentationComponent();
							await ParseAsync(newItem_representation, reader, outcome, locationPath + ".representation["+result.Representation.Count+"]"); // 110
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
