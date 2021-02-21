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
		public void Parse(Hl7.Fhir.Model.Contract.ContractAssetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scope"); // 40
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 50
							result.Type.Add(newItem_type);
							break;
						case "typeReference":
							var newItem_typeReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_typeReference, reader, outcome, locationPath + ".typeReference["+result.TypeReference.Count+"]"); // 60
							result.TypeReference.Add(newItem_typeReference);
							break;
						case "subtype":
							var newItem_subtype = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subtype, reader, outcome, locationPath + ".subtype["+result.Subtype.Count+"]"); // 70
							result.Subtype.Add(newItem_subtype);
							break;
						case "relationship":
							result.Relationship = new Hl7.Fhir.Model.Coding();
							Parse(result.Relationship as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".relationship"); // 80
							break;
						case "context":
							var newItem_context = new Hl7.Fhir.Model.Contract.AssetContextComponent();
							Parse(newItem_context, reader, outcome, locationPath + ".context["+result.Context.Count+"]"); // 90
							result.Context.Add(newItem_context);
							break;
						case "condition":
							result.ConditionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ConditionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".condition"); // 100
							break;
						case "periodType":
							var newItem_periodType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_periodType, reader, outcome, locationPath + ".periodType["+result.PeriodType.Count+"]"); // 110
							result.PeriodType.Add(newItem_periodType);
							break;
						case "period":
							var newItem_period = new Hl7.Fhir.Model.Period();
							Parse(newItem_period, reader, outcome, locationPath + ".period["+result.Period.Count+"]"); // 120
							result.Period.Add(newItem_period);
							break;
						case "usePeriod":
							var newItem_usePeriod = new Hl7.Fhir.Model.Period();
							Parse(newItem_usePeriod, reader, outcome, locationPath + ".usePeriod["+result.UsePeriod.Count+"]"); // 130
							result.UsePeriod.Add(newItem_usePeriod);
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text"); // 140
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]"); // 150
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.Contract.AnswerComponent();
							Parse(newItem_answer, reader, outcome, locationPath + ".answer["+result.Answer.Count+"]"); // 160
							result.Answer.Add(newItem_answer);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							Parse(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]"); // 170
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
							break;
						case "valuedItem":
							var newItem_valuedItem = new Hl7.Fhir.Model.Contract.ValuedItemComponent();
							Parse(newItem_valuedItem, reader, outcome, locationPath + ".valuedItem["+result.ValuedItem.Count+"]"); // 180
							result.ValuedItem.Add(newItem_valuedItem);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.ContractAssetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scope"); // 40
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 50
							result.Type.Add(newItem_type);
							break;
						case "typeReference":
							var newItem_typeReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_typeReference, reader, outcome, locationPath + ".typeReference["+result.TypeReference.Count+"]"); // 60
							result.TypeReference.Add(newItem_typeReference);
							break;
						case "subtype":
							var newItem_subtype = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subtype, reader, outcome, locationPath + ".subtype["+result.Subtype.Count+"]"); // 70
							result.Subtype.Add(newItem_subtype);
							break;
						case "relationship":
							result.Relationship = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Relationship as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".relationship"); // 80
							break;
						case "context":
							var newItem_context = new Hl7.Fhir.Model.Contract.AssetContextComponent();
							await ParseAsync(newItem_context, reader, outcome, locationPath + ".context["+result.Context.Count+"]"); // 90
							result.Context.Add(newItem_context);
							break;
						case "condition":
							result.ConditionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ConditionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".condition"); // 100
							break;
						case "periodType":
							var newItem_periodType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_periodType, reader, outcome, locationPath + ".periodType["+result.PeriodType.Count+"]"); // 110
							result.PeriodType.Add(newItem_periodType);
							break;
						case "period":
							var newItem_period = new Hl7.Fhir.Model.Period();
							await ParseAsync(newItem_period, reader, outcome, locationPath + ".period["+result.Period.Count+"]"); // 120
							result.Period.Add(newItem_period);
							break;
						case "usePeriod":
							var newItem_usePeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(newItem_usePeriod, reader, outcome, locationPath + ".usePeriod["+result.UsePeriod.Count+"]"); // 130
							result.UsePeriod.Add(newItem_usePeriod);
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text"); // 140
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]"); // 150
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.Contract.AnswerComponent();
							await ParseAsync(newItem_answer, reader, outcome, locationPath + ".answer["+result.Answer.Count+"]"); // 160
							result.Answer.Add(newItem_answer);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]"); // 170
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
							break;
						case "valuedItem":
							var newItem_valuedItem = new Hl7.Fhir.Model.Contract.ValuedItemComponent();
							await ParseAsync(newItem_valuedItem, reader, outcome, locationPath + ".valuedItem["+result.ValuedItem.Count+"]"); // 180
							result.ValuedItem.Add(newItem_valuedItem);
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
