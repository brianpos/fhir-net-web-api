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
		private void Parse(SubstanceSourceMaterial result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "sourceMaterialClass":
							result.SourceMaterialClass = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SourceMaterialClass as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "sourceMaterialType":
							result.SourceMaterialType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SourceMaterialType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "sourceMaterialState":
							result.SourceMaterialState = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SourceMaterialState as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "organismId":
							result.OrganismId = new Hl7.Fhir.Model.Identifier();
							Parse(result.OrganismId as Hl7.Fhir.Model.Identifier, reader, outcome); // 120
							break;
						case "organismName":
							result.OrganismNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.OrganismNameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "parentSubstanceId":
							var newItem_parentSubstanceId = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_parentSubstanceId, reader, outcome); // 140
							result.ParentSubstanceId.Add(newItem_parentSubstanceId);
							break;
						case "parentSubstanceName":
							var newItem_parentSubstanceName = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_parentSubstanceName, reader, outcome); // 150
							result.ParentSubstanceNameElement.Add(newItem_parentSubstanceName);
							break;
						case "countryOfOrigin":
							var newItem_countryOfOrigin = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_countryOfOrigin, reader, outcome); // 160
							result.CountryOfOrigin.Add(newItem_countryOfOrigin);
							break;
						case "geographicalLocation":
							var newItem_geographicalLocation = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_geographicalLocation, reader, outcome); // 170
							result.GeographicalLocationElement.Add(newItem_geographicalLocation);
							break;
						case "developmentStage":
							result.DevelopmentStage = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DevelopmentStage as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 180
							break;
						case "fractionDescription":
							var newItem_fractionDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent();
							Parse(newItem_fractionDescription, reader, outcome); // 190
							result.FractionDescription.Add(newItem_fractionDescription);
							break;
						case "organism":
							result.Organism = new Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent();
							Parse(result.Organism as Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent, reader, outcome); // 200
							break;
						case "partDescription":
							var newItem_partDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent();
							Parse(newItem_partDescription, reader, outcome); // 210
							result.PartDescription.Add(newItem_partDescription);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(SubstanceSourceMaterial result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "sourceMaterialClass":
							result.SourceMaterialClass = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SourceMaterialClass as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "sourceMaterialType":
							result.SourceMaterialType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SourceMaterialType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "sourceMaterialState":
							result.SourceMaterialState = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SourceMaterialState as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "organismId":
							result.OrganismId = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.OrganismId as Hl7.Fhir.Model.Identifier, reader, outcome); // 120
							break;
						case "organismName":
							result.OrganismNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.OrganismNameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "parentSubstanceId":
							var newItem_parentSubstanceId = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_parentSubstanceId, reader, outcome); // 140
							result.ParentSubstanceId.Add(newItem_parentSubstanceId);
							break;
						case "parentSubstanceName":
							var newItem_parentSubstanceName = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_parentSubstanceName, reader, outcome); // 150
							result.ParentSubstanceNameElement.Add(newItem_parentSubstanceName);
							break;
						case "countryOfOrigin":
							var newItem_countryOfOrigin = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_countryOfOrigin, reader, outcome); // 160
							result.CountryOfOrigin.Add(newItem_countryOfOrigin);
							break;
						case "geographicalLocation":
							var newItem_geographicalLocation = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_geographicalLocation, reader, outcome); // 170
							result.GeographicalLocationElement.Add(newItem_geographicalLocation);
							break;
						case "developmentStage":
							result.DevelopmentStage = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DevelopmentStage as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 180
							break;
						case "fractionDescription":
							var newItem_fractionDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent();
							await ParseAsync(newItem_fractionDescription, reader, outcome); // 190
							result.FractionDescription.Add(newItem_fractionDescription);
							break;
						case "organism":
							result.Organism = new Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent();
							await ParseAsync(result.Organism as Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent, reader, outcome); // 200
							break;
						case "partDescription":
							var newItem_partDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent();
							await ParseAsync(newItem_partDescription, reader, outcome); // 210
							result.PartDescription.Add(newItem_partDescription);
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
