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
		private void Parse(SubstanceDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 100
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 110
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]", cancellationToken); // 120
							result.Classification.Add(newItem_classification);
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Domain as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".domain", cancellationToken); // 130
							break;
						case "grade":
							var newItem_grade = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_grade, reader, outcome, locationPath + ".grade["+result.Grade.Count+"]", cancellationToken); // 140
							result.Grade.Add(newItem_grade);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 150
							break;
						case "informationSource":
							var newItem_informationSource = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_informationSource, reader, outcome, locationPath + ".informationSource["+result.InformationSource.Count+"]", cancellationToken); // 160
							result.InformationSource.Add(newItem_informationSource);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 170
							result.Note.Add(newItem_note);
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 180
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "supplier":
							var newItem_supplier = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_supplier, reader, outcome, locationPath + ".supplier["+result.Supplier.Count+"]", cancellationToken); // 190
							result.Supplier.Add(newItem_supplier);
							break;
						case "moiety":
							var newItem_moiety = new Hl7.Fhir.Model.SubstanceDefinition.MoietyComponent();
							Parse(newItem_moiety, reader, outcome, locationPath + ".moiety["+result.Moiety.Count+"]", cancellationToken); // 200
							result.Moiety.Add(newItem_moiety);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.SubstanceDefinition.PropertyComponent();
							Parse(newItem_property, reader, outcome, locationPath + ".property["+result.Property.Count+"]", cancellationToken); // 210
							result.Property.Add(newItem_property);
							break;
						case "molecularWeight":
							var newItem_molecularWeight = new Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent();
							Parse(newItem_molecularWeight, reader, outcome, locationPath + ".molecularWeight["+result.MolecularWeight.Count+"]", cancellationToken); // 220
							result.MolecularWeight.Add(newItem_molecularWeight);
							break;
						case "structure":
							result.Structure = new Hl7.Fhir.Model.SubstanceDefinition.StructureComponent();
							Parse(result.Structure as Hl7.Fhir.Model.SubstanceDefinition.StructureComponent, reader, outcome, locationPath + ".structure", cancellationToken); // 230
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.SubstanceDefinition.CodeComponent();
							Parse(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 240
							result.Code.Add(newItem_code);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.SubstanceDefinition.NameComponent();
							Parse(newItem_name, reader, outcome, locationPath + ".name["+result.Name.Count+"]", cancellationToken); // 250
							result.Name.Add(newItem_name);
							break;
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent();
							Parse(newItem_relationship, reader, outcome, locationPath + ".relationship["+result.Relationship.Count+"]", cancellationToken); // 260
							result.Relationship.Add(newItem_relationship);
							break;
						case "sourceMaterial":
							result.SourceMaterial = new Hl7.Fhir.Model.SubstanceDefinition.SourceMaterialComponent();
							Parse(result.SourceMaterial as Hl7.Fhir.Model.SubstanceDefinition.SourceMaterialComponent, reader, outcome, locationPath + ".sourceMaterial", cancellationToken); // 270
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

		private async System.Threading.Tasks.Task ParseAsync(SubstanceDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 100
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 110
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]", cancellationToken); // 120
							result.Classification.Add(newItem_classification);
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Domain as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".domain", cancellationToken); // 130
							break;
						case "grade":
							var newItem_grade = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_grade, reader, outcome, locationPath + ".grade["+result.Grade.Count+"]", cancellationToken); // 140
							result.Grade.Add(newItem_grade);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 150
							break;
						case "informationSource":
							var newItem_informationSource = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_informationSource, reader, outcome, locationPath + ".informationSource["+result.InformationSource.Count+"]", cancellationToken); // 160
							result.InformationSource.Add(newItem_informationSource);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 170
							result.Note.Add(newItem_note);
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 180
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "supplier":
							var newItem_supplier = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_supplier, reader, outcome, locationPath + ".supplier["+result.Supplier.Count+"]", cancellationToken); // 190
							result.Supplier.Add(newItem_supplier);
							break;
						case "moiety":
							var newItem_moiety = new Hl7.Fhir.Model.SubstanceDefinition.MoietyComponent();
							await ParseAsync(newItem_moiety, reader, outcome, locationPath + ".moiety["+result.Moiety.Count+"]", cancellationToken); // 200
							result.Moiety.Add(newItem_moiety);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.SubstanceDefinition.PropertyComponent();
							await ParseAsync(newItem_property, reader, outcome, locationPath + ".property["+result.Property.Count+"]", cancellationToken); // 210
							result.Property.Add(newItem_property);
							break;
						case "molecularWeight":
							var newItem_molecularWeight = new Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent();
							await ParseAsync(newItem_molecularWeight, reader, outcome, locationPath + ".molecularWeight["+result.MolecularWeight.Count+"]", cancellationToken); // 220
							result.MolecularWeight.Add(newItem_molecularWeight);
							break;
						case "structure":
							result.Structure = new Hl7.Fhir.Model.SubstanceDefinition.StructureComponent();
							await ParseAsync(result.Structure as Hl7.Fhir.Model.SubstanceDefinition.StructureComponent, reader, outcome, locationPath + ".structure", cancellationToken); // 230
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.SubstanceDefinition.CodeComponent();
							await ParseAsync(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 240
							result.Code.Add(newItem_code);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.SubstanceDefinition.NameComponent();
							await ParseAsync(newItem_name, reader, outcome, locationPath + ".name["+result.Name.Count+"]", cancellationToken); // 250
							result.Name.Add(newItem_name);
							break;
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent();
							await ParseAsync(newItem_relationship, reader, outcome, locationPath + ".relationship["+result.Relationship.Count+"]", cancellationToken); // 260
							result.Relationship.Add(newItem_relationship);
							break;
						case "sourceMaterial":
							result.SourceMaterial = new Hl7.Fhir.Model.SubstanceDefinition.SourceMaterialComponent();
							await ParseAsync(result.SourceMaterial as Hl7.Fhir.Model.SubstanceDefinition.SourceMaterialComponent, reader, outcome, locationPath + ".sourceMaterial", cancellationToken); // 270
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
