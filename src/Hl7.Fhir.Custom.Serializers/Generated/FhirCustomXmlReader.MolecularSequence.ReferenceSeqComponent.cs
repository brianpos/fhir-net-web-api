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
		public void Parse(Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "chromosome":
							result.Chromosome = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Chromosome as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "genomeBuild":
							result.GenomeBuildElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.GenomeBuildElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "orientation":
							result.OrientationElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.orientationType>();
							Parse(result.OrientationElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.orientationType>, reader, outcome); // 60
							break;
						case "referenceSeqId":
							result.ReferenceSeqId = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ReferenceSeqId as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "referenceSeqPointer":
							result.ReferenceSeqPointer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ReferenceSeqPointer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 80
							break;
						case "referenceSeqString":
							result.ReferenceSeqStringElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ReferenceSeqStringElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "strand":
							result.StrandElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.strandType>();
							Parse(result.StrandElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.strandType>, reader, outcome); // 100
							break;
						case "windowStart":
							result.WindowStartElement = new Hl7.Fhir.Model.Integer();
							Parse(result.WindowStartElement as Hl7.Fhir.Model.Integer, reader, outcome); // 110
							break;
						case "windowEnd":
							result.WindowEndElement = new Hl7.Fhir.Model.Integer();
							Parse(result.WindowEndElement as Hl7.Fhir.Model.Integer, reader, outcome); // 120
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "chromosome":
							result.Chromosome = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Chromosome as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "genomeBuild":
							result.GenomeBuildElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.GenomeBuildElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "orientation":
							result.OrientationElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.orientationType>();
							await ParseAsync(result.OrientationElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.orientationType>, reader, outcome); // 60
							break;
						case "referenceSeqId":
							result.ReferenceSeqId = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ReferenceSeqId as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "referenceSeqPointer":
							result.ReferenceSeqPointer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ReferenceSeqPointer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 80
							break;
						case "referenceSeqString":
							result.ReferenceSeqStringElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ReferenceSeqStringElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "strand":
							result.StrandElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.strandType>();
							await ParseAsync(result.StrandElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.strandType>, reader, outcome); // 100
							break;
						case "windowStart":
							result.WindowStartElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.WindowStartElement as Hl7.Fhir.Model.Integer, reader, outcome); // 110
							break;
						case "windowEnd":
							result.WindowEndElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.WindowEndElement as Hl7.Fhir.Model.Integer, reader, outcome); // 120
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
