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
		private void Parse(MolecularSequence result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.sequenceType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.sequenceType>, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "coordinateSystem":
							result.CoordinateSystemElement = new Hl7.Fhir.Model.Integer();
							Parse(result.CoordinateSystemElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".coordinateSystem", cancellationToken); // 110
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 120
							break;
						case "specimen":
							result.Specimen = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Specimen as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".specimen", cancellationToken); // 130
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device", cancellationToken); // 140
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer", cancellationToken); // 150
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 160
							break;
						case "referenceSeq":
							result.ReferenceSeq = new Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent();
							Parse(result.ReferenceSeq as Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent, reader, outcome, locationPath + ".referenceSeq", cancellationToken); // 170
							break;
						case "variant":
							var newItem_variant = new Hl7.Fhir.Model.MolecularSequence.VariantComponent();
							Parse(newItem_variant, reader, outcome, locationPath + ".variant["+result.Variant.Count+"]", cancellationToken); // 180
							result.Variant.Add(newItem_variant);
							break;
						case "observedSeq":
							result.ObservedSeqElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ObservedSeqElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".observedSeq", cancellationToken); // 190
							break;
						case "quality":
							var newItem_quality = new Hl7.Fhir.Model.MolecularSequence.QualityComponent();
							Parse(newItem_quality, reader, outcome, locationPath + ".quality["+result.Quality.Count+"]", cancellationToken); // 200
							result.Quality.Add(newItem_quality);
							break;
						case "readCoverage":
							result.ReadCoverageElement = new Hl7.Fhir.Model.Integer();
							Parse(result.ReadCoverageElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".readCoverage", cancellationToken); // 210
							break;
						case "repository":
							var newItem_repository = new Hl7.Fhir.Model.MolecularSequence.RepositoryComponent();
							Parse(newItem_repository, reader, outcome, locationPath + ".repository["+result.Repository.Count+"]", cancellationToken); // 220
							result.Repository.Add(newItem_repository);
							break;
						case "pointer":
							var newItem_pointer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_pointer, reader, outcome, locationPath + ".pointer["+result.Pointer.Count+"]", cancellationToken); // 230
							result.Pointer.Add(newItem_pointer);
							break;
						case "structureVariant":
							var newItem_structureVariant = new Hl7.Fhir.Model.MolecularSequence.StructureVariantComponent();
							Parse(newItem_structureVariant, reader, outcome, locationPath + ".structureVariant["+result.StructureVariant.Count+"]", cancellationToken); // 240
							result.StructureVariant.Add(newItem_structureVariant);
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

		private async System.Threading.Tasks.Task ParseAsync(MolecularSequence result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.sequenceType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.sequenceType>, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "coordinateSystem":
							result.CoordinateSystemElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.CoordinateSystemElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".coordinateSystem", cancellationToken); // 110
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 120
							break;
						case "specimen":
							result.Specimen = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Specimen as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".specimen", cancellationToken); // 130
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device", cancellationToken); // 140
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer", cancellationToken); // 150
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 160
							break;
						case "referenceSeq":
							result.ReferenceSeq = new Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent();
							await ParseAsync(result.ReferenceSeq as Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent, reader, outcome, locationPath + ".referenceSeq", cancellationToken); // 170
							break;
						case "variant":
							var newItem_variant = new Hl7.Fhir.Model.MolecularSequence.VariantComponent();
							await ParseAsync(newItem_variant, reader, outcome, locationPath + ".variant["+result.Variant.Count+"]", cancellationToken); // 180
							result.Variant.Add(newItem_variant);
							break;
						case "observedSeq":
							result.ObservedSeqElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ObservedSeqElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".observedSeq", cancellationToken); // 190
							break;
						case "quality":
							var newItem_quality = new Hl7.Fhir.Model.MolecularSequence.QualityComponent();
							await ParseAsync(newItem_quality, reader, outcome, locationPath + ".quality["+result.Quality.Count+"]", cancellationToken); // 200
							result.Quality.Add(newItem_quality);
							break;
						case "readCoverage":
							result.ReadCoverageElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.ReadCoverageElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".readCoverage", cancellationToken); // 210
							break;
						case "repository":
							var newItem_repository = new Hl7.Fhir.Model.MolecularSequence.RepositoryComponent();
							await ParseAsync(newItem_repository, reader, outcome, locationPath + ".repository["+result.Repository.Count+"]", cancellationToken); // 220
							result.Repository.Add(newItem_repository);
							break;
						case "pointer":
							var newItem_pointer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_pointer, reader, outcome, locationPath + ".pointer["+result.Pointer.Count+"]", cancellationToken); // 230
							result.Pointer.Add(newItem_pointer);
							break;
						case "structureVariant":
							var newItem_structureVariant = new Hl7.Fhir.Model.MolecularSequence.StructureVariantComponent();
							await ParseAsync(newItem_structureVariant, reader, outcome, locationPath + ".structureVariant["+result.StructureVariant.Count+"]", cancellationToken); // 240
							result.StructureVariant.Add(newItem_structureVariant);
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
