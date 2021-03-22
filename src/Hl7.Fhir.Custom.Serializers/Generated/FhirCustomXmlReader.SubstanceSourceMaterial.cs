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
		private void Parse(SubstanceSourceMaterial result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "sourceMaterialClass":
							result.SourceMaterialClass = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SourceMaterialClass as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".sourceMaterialClass", cancellationToken); // 90
							break;
						case "sourceMaterialType":
							result.SourceMaterialType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SourceMaterialType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".sourceMaterialType", cancellationToken); // 100
							break;
						case "sourceMaterialState":
							result.SourceMaterialState = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SourceMaterialState as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".sourceMaterialState", cancellationToken); // 110
							break;
						case "organismId":
							result.OrganismId = new Hl7.Fhir.Model.Identifier();
							Parse(result.OrganismId as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".organismId", cancellationToken); // 120
							break;
						case "organismName":
							result.OrganismNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.OrganismNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".organismName", cancellationToken); // 130
							break;
						case "parentSubstanceId":
							var newItem_parentSubstanceId = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_parentSubstanceId, reader, outcome, locationPath + ".parentSubstanceId["+result.ParentSubstanceId.Count+"]", cancellationToken); // 140
							result.ParentSubstanceId.Add(newItem_parentSubstanceId);
							break;
						case "parentSubstanceName":
							var newItem_parentSubstanceName = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_parentSubstanceName, reader, outcome, locationPath + ".parentSubstanceName["+result.ParentSubstanceNameElement.Count+"]", cancellationToken); // 150
							result.ParentSubstanceNameElement.Add(newItem_parentSubstanceName);
							break;
						case "countryOfOrigin":
							var newItem_countryOfOrigin = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_countryOfOrigin, reader, outcome, locationPath + ".countryOfOrigin["+result.CountryOfOrigin.Count+"]", cancellationToken); // 160
							result.CountryOfOrigin.Add(newItem_countryOfOrigin);
							break;
						case "geographicalLocation":
							var newItem_geographicalLocation = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_geographicalLocation, reader, outcome, locationPath + ".geographicalLocation["+result.GeographicalLocationElement.Count+"]", cancellationToken); // 170
							result.GeographicalLocationElement.Add(newItem_geographicalLocation);
							break;
						case "developmentStage":
							result.DevelopmentStage = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DevelopmentStage as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".developmentStage", cancellationToken); // 180
							break;
						case "fractionDescription":
							var newItem_fractionDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent();
							Parse(newItem_fractionDescription, reader, outcome, locationPath + ".fractionDescription["+result.FractionDescription.Count+"]", cancellationToken); // 190
							result.FractionDescription.Add(newItem_fractionDescription);
							break;
						case "organism":
							result.Organism = new Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent();
							Parse(result.Organism as Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent, reader, outcome, locationPath + ".organism", cancellationToken); // 200
							break;
						case "partDescription":
							var newItem_partDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent();
							Parse(newItem_partDescription, reader, outcome, locationPath + ".partDescription["+result.PartDescription.Count+"]", cancellationToken); // 210
							result.PartDescription.Add(newItem_partDescription);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
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

		private async System.Threading.Tasks.Task ParseAsync(SubstanceSourceMaterial result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "sourceMaterialClass":
							result.SourceMaterialClass = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SourceMaterialClass as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".sourceMaterialClass", cancellationToken); // 90
							break;
						case "sourceMaterialType":
							result.SourceMaterialType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SourceMaterialType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".sourceMaterialType", cancellationToken); // 100
							break;
						case "sourceMaterialState":
							result.SourceMaterialState = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SourceMaterialState as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".sourceMaterialState", cancellationToken); // 110
							break;
						case "organismId":
							result.OrganismId = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.OrganismId as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".organismId", cancellationToken); // 120
							break;
						case "organismName":
							result.OrganismNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.OrganismNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".organismName", cancellationToken); // 130
							break;
						case "parentSubstanceId":
							var newItem_parentSubstanceId = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_parentSubstanceId, reader, outcome, locationPath + ".parentSubstanceId["+result.ParentSubstanceId.Count+"]", cancellationToken); // 140
							result.ParentSubstanceId.Add(newItem_parentSubstanceId);
							break;
						case "parentSubstanceName":
							var newItem_parentSubstanceName = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_parentSubstanceName, reader, outcome, locationPath + ".parentSubstanceName["+result.ParentSubstanceNameElement.Count+"]", cancellationToken); // 150
							result.ParentSubstanceNameElement.Add(newItem_parentSubstanceName);
							break;
						case "countryOfOrigin":
							var newItem_countryOfOrigin = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_countryOfOrigin, reader, outcome, locationPath + ".countryOfOrigin["+result.CountryOfOrigin.Count+"]", cancellationToken); // 160
							result.CountryOfOrigin.Add(newItem_countryOfOrigin);
							break;
						case "geographicalLocation":
							var newItem_geographicalLocation = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_geographicalLocation, reader, outcome, locationPath + ".geographicalLocation["+result.GeographicalLocationElement.Count+"]", cancellationToken); // 170
							result.GeographicalLocationElement.Add(newItem_geographicalLocation);
							break;
						case "developmentStage":
							result.DevelopmentStage = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DevelopmentStage as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".developmentStage", cancellationToken); // 180
							break;
						case "fractionDescription":
							var newItem_fractionDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent();
							await ParseAsync(newItem_fractionDescription, reader, outcome, locationPath + ".fractionDescription["+result.FractionDescription.Count+"]", cancellationToken); // 190
							result.FractionDescription.Add(newItem_fractionDescription);
							break;
						case "organism":
							result.Organism = new Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent();
							await ParseAsync(result.Organism as Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent, reader, outcome, locationPath + ".organism", cancellationToken); // 200
							break;
						case "partDescription":
							var newItem_partDescription = new Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent();
							await ParseAsync(newItem_partDescription, reader, outcome, locationPath + ".partDescription["+result.PartDescription.Count+"]", cancellationToken); // 210
							result.PartDescription.Add(newItem_partDescription);
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
