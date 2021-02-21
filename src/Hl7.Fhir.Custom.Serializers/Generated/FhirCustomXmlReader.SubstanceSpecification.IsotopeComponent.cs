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
		public void Parse(Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 40
							break;
						case "name":
							result.Name = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Name as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".name"); // 50
							break;
						case "substitution":
							result.Substitution = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Substitution as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substitution"); // 60
							break;
						case "halfLife":
							result.HalfLife = new Hl7.Fhir.Model.Quantity();
							Parse(result.HalfLife as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".halfLife"); // 70
							break;
						case "molecularWeight":
							result.MolecularWeight = new Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent();
							Parse(result.MolecularWeight as Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent, reader, outcome, locationPath + ".molecularWeight"); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 40
							break;
						case "name":
							result.Name = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Name as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".name"); // 50
							break;
						case "substitution":
							result.Substitution = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Substitution as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substitution"); // 60
							break;
						case "halfLife":
							result.HalfLife = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.HalfLife as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".halfLife"); // 70
							break;
						case "molecularWeight":
							result.MolecularWeight = new Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent();
							await ParseAsync(result.MolecularWeight as Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent, reader, outcome, locationPath + ".molecularWeight"); // 80
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
