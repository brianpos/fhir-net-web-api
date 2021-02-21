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
		public void Parse(Hl7.Fhir.Model.SubstanceNucleicAcid.SubunitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "subunit":
							result.SubunitElement = new Hl7.Fhir.Model.Integer();
							Parse(result.SubunitElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".subunit"); // 40
							break;
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SequenceElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sequence"); // 50
							break;
						case "length":
							result.LengthElement = new Hl7.Fhir.Model.Integer();
							Parse(result.LengthElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".length"); // 60
							break;
						case "sequenceAttachment":
							result.SequenceAttachment = new Hl7.Fhir.Model.Attachment();
							Parse(result.SequenceAttachment as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".sequenceAttachment"); // 70
							break;
						case "fivePrime":
							result.FivePrime = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FivePrime as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fivePrime"); // 80
							break;
						case "threePrime":
							result.ThreePrime = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ThreePrime as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".threePrime"); // 90
							break;
						case "linkage":
							var newItem_linkage = new Hl7.Fhir.Model.SubstanceNucleicAcid.LinkageComponent();
							Parse(newItem_linkage, reader, outcome, locationPath + ".linkage["+result.Linkage.Count+"]"); // 100
							result.Linkage.Add(newItem_linkage);
							break;
						case "sugar":
							var newItem_sugar = new Hl7.Fhir.Model.SubstanceNucleicAcid.SugarComponent();
							Parse(newItem_sugar, reader, outcome, locationPath + ".sugar["+result.Sugar.Count+"]"); // 110
							result.Sugar.Add(newItem_sugar);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceNucleicAcid.SubunitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "subunit":
							result.SubunitElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.SubunitElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".subunit"); // 40
							break;
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SequenceElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sequence"); // 50
							break;
						case "length":
							result.LengthElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.LengthElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".length"); // 60
							break;
						case "sequenceAttachment":
							result.SequenceAttachment = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.SequenceAttachment as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".sequenceAttachment"); // 70
							break;
						case "fivePrime":
							result.FivePrime = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FivePrime as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fivePrime"); // 80
							break;
						case "threePrime":
							result.ThreePrime = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ThreePrime as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".threePrime"); // 90
							break;
						case "linkage":
							var newItem_linkage = new Hl7.Fhir.Model.SubstanceNucleicAcid.LinkageComponent();
							await ParseAsync(newItem_linkage, reader, outcome, locationPath + ".linkage["+result.Linkage.Count+"]"); // 100
							result.Linkage.Add(newItem_linkage);
							break;
						case "sugar":
							var newItem_sugar = new Hl7.Fhir.Model.SubstanceNucleicAcid.SugarComponent();
							await ParseAsync(newItem_sugar, reader, outcome, locationPath + ".sugar["+result.Sugar.Count+"]"); // 110
							result.Sugar.Add(newItem_sugar);
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
