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
		public void Parse(Hl7.Fhir.Model.Contract.ContractOfferComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "party":
							var newItem_party = new Hl7.Fhir.Model.Contract.ContractPartyComponent();
							Parse(newItem_party, reader, outcome); // 50
							result.Party.Add(newItem_party);
							break;
						case "topic":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 60
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "decision":
							result.Decision = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Decision as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 80
							break;
						case "decisionMode":
							var newItem_decisionMode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_decisionMode, reader, outcome); // 90
							result.DecisionMode.Add(newItem_decisionMode);
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.Contract.AnswerComponent();
							Parse(newItem_answer, reader, outcome); // 100
							result.Answer.Add(newItem_answer);
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_linkId, reader, outcome); // 120
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							Parse(newItem_securityLabelNumber, reader, outcome); // 130
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.ContractOfferComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "party":
							var newItem_party = new Hl7.Fhir.Model.Contract.ContractPartyComponent();
							await ParseAsync(newItem_party, reader, outcome); // 50
							result.Party.Add(newItem_party);
							break;
						case "topic":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 60
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "decision":
							result.Decision = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Decision as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 80
							break;
						case "decisionMode":
							var newItem_decisionMode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_decisionMode, reader, outcome); // 90
							result.DecisionMode.Add(newItem_decisionMode);
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.Contract.AnswerComponent();
							await ParseAsync(newItem_answer, reader, outcome); // 100
							result.Answer.Add(newItem_answer);
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_linkId, reader, outcome); // 120
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(newItem_securityLabelNumber, reader, outcome); // 130
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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
