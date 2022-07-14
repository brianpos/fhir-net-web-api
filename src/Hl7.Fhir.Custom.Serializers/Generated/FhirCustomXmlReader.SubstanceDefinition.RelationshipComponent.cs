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
		public void Parse(Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "substanceDefinitionReference":
							result.SubstanceDefinition = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.SubstanceDefinition as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".substanceDefinition", cancellationToken); // 40
							break;
						case "substanceDefinitionCodeableConcept":
							result.SubstanceDefinition = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SubstanceDefinition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substanceDefinition", cancellationToken); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "isDefining":
							result.IsDefiningElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsDefiningElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isDefining", cancellationToken); // 60
							break;
						case "amountQuantity":
							result.Amount = new Hl7.Fhir.Model.Quantity();
							Parse(result.Amount as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".amount", cancellationToken); // 70
							break;
						case "amountRatio":
							result.Amount = new Hl7.Fhir.Model.Ratio();
							Parse(result.Amount as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".amount", cancellationToken); // 70
							break;
						case "amountString":
							result.Amount = new Hl7.Fhir.Model.FhirString();
							Parse(result.Amount as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amount", cancellationToken); // 70
							break;
						case "ratioHighLimitAmount":
							result.RatioHighLimitAmount = new Hl7.Fhir.Model.Ratio();
							Parse(result.RatioHighLimitAmount as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".ratioHighLimitAmount", cancellationToken); // 80
							break;
						case "comparator":
							result.Comparator = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Comparator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".comparator", cancellationToken); // 90
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_source, reader, outcome, locationPath + ".source["+result.Source.Count+"]", cancellationToken); // 100
							result.Source.Add(newItem_source);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "substanceDefinitionReference":
							result.SubstanceDefinition = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.SubstanceDefinition as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".substanceDefinition", cancellationToken); // 40
							break;
						case "substanceDefinitionCodeableConcept":
							result.SubstanceDefinition = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SubstanceDefinition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substanceDefinition", cancellationToken); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "isDefining":
							result.IsDefiningElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsDefiningElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isDefining", cancellationToken); // 60
							break;
						case "amountQuantity":
							result.Amount = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".amount", cancellationToken); // 70
							break;
						case "amountRatio":
							result.Amount = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".amount", cancellationToken); // 70
							break;
						case "amountString":
							result.Amount = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amount", cancellationToken); // 70
							break;
						case "ratioHighLimitAmount":
							result.RatioHighLimitAmount = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.RatioHighLimitAmount as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".ratioHighLimitAmount", cancellationToken); // 80
							break;
						case "comparator":
							result.Comparator = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Comparator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".comparator", cancellationToken); // 90
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_source, reader, outcome, locationPath + ".source["+result.Source.Count+"]", cancellationToken); // 100
							result.Source.Add(newItem_source);
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
