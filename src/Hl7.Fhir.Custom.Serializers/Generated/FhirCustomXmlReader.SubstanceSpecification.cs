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
		private void Parse(SubstanceSpecification result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 90
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Domain as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_source, reader, outcome); // 140
							result.Source.Add(newItem_source);
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "moiety":
							var newItem_moiety = new Hl7.Fhir.Model.SubstanceSpecification.MoietyComponent();
							Parse(newItem_moiety, reader, outcome); // 160
							result.Moiety.Add(newItem_moiety);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent();
							Parse(newItem_property, reader, outcome); // 170
							result.Property.Add(newItem_property);
							break;
						case "referenceInformation":
							result.ReferenceInformation = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ReferenceInformation as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 180
							break;
						case "structure":
							result.Structure = new Hl7.Fhir.Model.SubstanceSpecification.StructureComponent();
							Parse(result.Structure as Hl7.Fhir.Model.SubstanceSpecification.StructureComponent, reader, outcome); // 190
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.SubstanceSpecification.CodeComponent();
							Parse(newItem_code, reader, outcome); // 200
							result.Code.Add(newItem_code);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.SubstanceSpecification.NameComponent();
							Parse(newItem_name, reader, outcome); // 210
							result.Name.Add(newItem_name);
							break;
						case "molecularWeight":
							var newItem_molecularWeight = new Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent();
							Parse(newItem_molecularWeight, reader, outcome); // 220
							result.MolecularWeight.Add(newItem_molecularWeight);
							break;
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.SubstanceSpecification.RelationshipComponent();
							Parse(newItem_relationship, reader, outcome); // 230
							result.Relationship.Add(newItem_relationship);
							break;
						case "nucleicAcid":
							result.NucleicAcid = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.NucleicAcid as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 240
							break;
						case "polymer":
							result.Polymer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Polymer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 250
							break;
						case "protein":
							result.Protein = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Protein as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "sourceMaterial":
							result.SourceMaterial = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.SourceMaterial as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
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

		private async System.Threading.Tasks.Task ParseAsync(SubstanceSpecification result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 90
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "domain":
							result.Domain = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Domain as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 120
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_source, reader, outcome); // 140
							result.Source.Add(newItem_source);
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "moiety":
							var newItem_moiety = new Hl7.Fhir.Model.SubstanceSpecification.MoietyComponent();
							await ParseAsync(newItem_moiety, reader, outcome); // 160
							result.Moiety.Add(newItem_moiety);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent();
							await ParseAsync(newItem_property, reader, outcome); // 170
							result.Property.Add(newItem_property);
							break;
						case "referenceInformation":
							result.ReferenceInformation = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ReferenceInformation as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 180
							break;
						case "structure":
							result.Structure = new Hl7.Fhir.Model.SubstanceSpecification.StructureComponent();
							await ParseAsync(result.Structure as Hl7.Fhir.Model.SubstanceSpecification.StructureComponent, reader, outcome); // 190
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.SubstanceSpecification.CodeComponent();
							await ParseAsync(newItem_code, reader, outcome); // 200
							result.Code.Add(newItem_code);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.SubstanceSpecification.NameComponent();
							await ParseAsync(newItem_name, reader, outcome); // 210
							result.Name.Add(newItem_name);
							break;
						case "molecularWeight":
							var newItem_molecularWeight = new Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent();
							await ParseAsync(newItem_molecularWeight, reader, outcome); // 220
							result.MolecularWeight.Add(newItem_molecularWeight);
							break;
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.SubstanceSpecification.RelationshipComponent();
							await ParseAsync(newItem_relationship, reader, outcome); // 230
							result.Relationship.Add(newItem_relationship);
							break;
						case "nucleicAcid":
							result.NucleicAcid = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.NucleicAcid as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 240
							break;
						case "polymer":
							result.Polymer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Polymer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 250
							break;
						case "protein":
							result.Protein = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Protein as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "sourceMaterial":
							result.SourceMaterial = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.SourceMaterial as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 270
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
