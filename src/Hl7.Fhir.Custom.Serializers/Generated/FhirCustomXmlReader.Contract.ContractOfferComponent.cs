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
		public void Parse(Hl7.Fhir.Model.Contract.ContractOfferComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "party":
							var newItem_party = new Hl7.Fhir.Model.Contract.ContractPartyComponent();
							Parse(newItem_party, reader, outcome, locationPath + ".party["+result.Party.Count+"]", cancellationToken); // 50
							result.Party.Add(newItem_party);
							break;
						case "topic":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".topic", cancellationToken); // 60
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 70
							break;
						case "decision":
							result.Decision = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Decision as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".decision", cancellationToken); // 80
							break;
						case "decisionMode":
							var newItem_decisionMode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_decisionMode, reader, outcome, locationPath + ".decisionMode["+result.DecisionMode.Count+"]", cancellationToken); // 90
							result.DecisionMode.Add(newItem_decisionMode);
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.Contract.AnswerComponent();
							Parse(newItem_answer, reader, outcome, locationPath + ".answer["+result.Answer.Count+"]", cancellationToken); // 100
							result.Answer.Add(newItem_answer);
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 110
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]", cancellationToken); // 120
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							Parse(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]", cancellationToken); // 130
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.ContractOfferComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "party":
							var newItem_party = new Hl7.Fhir.Model.Contract.ContractPartyComponent();
							await ParseAsync(newItem_party, reader, outcome, locationPath + ".party["+result.Party.Count+"]", cancellationToken); // 50
							result.Party.Add(newItem_party);
							break;
						case "topic":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".topic", cancellationToken); // 60
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 70
							break;
						case "decision":
							result.Decision = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Decision as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".decision", cancellationToken); // 80
							break;
						case "decisionMode":
							var newItem_decisionMode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_decisionMode, reader, outcome, locationPath + ".decisionMode["+result.DecisionMode.Count+"]", cancellationToken); // 90
							result.DecisionMode.Add(newItem_decisionMode);
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.Contract.AnswerComponent();
							await ParseAsync(newItem_answer, reader, outcome, locationPath + ".answer["+result.Answer.Count+"]", cancellationToken); // 100
							result.Answer.Add(newItem_answer);
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 110
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]", cancellationToken); // 120
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]", cancellationToken); // 130
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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
