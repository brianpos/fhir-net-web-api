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
		public void Parse(Hl7.Fhir.Model.MolecularSequence.VariantComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Integer();
							Parse(result.StartElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".start", cancellationToken); // 40
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Integer();
							Parse(result.EndElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".end", cancellationToken); // 50
							break;
						case "observedAllele":
							result.ObservedAlleleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ObservedAlleleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".observedAllele", cancellationToken); // 60
							break;
						case "referenceAllele":
							result.ReferenceAlleleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ReferenceAlleleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".referenceAllele", cancellationToken); // 70
							break;
						case "cigar":
							result.CigarElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CigarElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".cigar", cancellationToken); // 80
							break;
						case "variantPointer":
							result.VariantPointer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.VariantPointer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".variantPointer", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MolecularSequence.VariantComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "start":
							result.StartElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.StartElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".start", cancellationToken); // 40
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.EndElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".end", cancellationToken); // 50
							break;
						case "observedAllele":
							result.ObservedAlleleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ObservedAlleleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".observedAllele", cancellationToken); // 60
							break;
						case "referenceAllele":
							result.ReferenceAlleleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ReferenceAlleleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".referenceAllele", cancellationToken); // 70
							break;
						case "cigar":
							result.CigarElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CigarElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".cigar", cancellationToken); // 80
							break;
						case "variantPointer":
							result.VariantPointer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.VariantPointer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".variantPointer", cancellationToken); // 90
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
