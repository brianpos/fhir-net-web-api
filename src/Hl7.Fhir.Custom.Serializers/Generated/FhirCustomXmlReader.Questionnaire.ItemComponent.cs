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
		public void Parse(Hl7.Fhir.Model.Questionnaire.ItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "linkId":
							result.LinkIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LinkIdElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".linkId", cancellationToken); // 40
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.DefinitionElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							Parse(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 60
							result.Code.Add(newItem_code);
							break;
						case "prefix":
							result.PrefixElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PrefixElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".prefix", cancellationToken); // 70
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 80
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemType>, reader, outcome, locationPath + ".type", cancellationToken); // 90
							break;
						case "enableWhen":
							var newItem_enableWhen = new Hl7.Fhir.Model.Questionnaire.EnableWhenComponent();
							Parse(newItem_enableWhen, reader, outcome, locationPath + ".enableWhen["+result.EnableWhen.Count+"]", cancellationToken); // 100
							result.EnableWhen.Add(newItem_enableWhen);
							break;
						case "enableBehavior":
							result.EnableBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.EnableWhenBehavior>();
							Parse(result.EnableBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.EnableWhenBehavior>, reader, outcome, locationPath + ".enableBehavior", cancellationToken); // 110
							break;
						case "required":
							result.RequiredElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.RequiredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".required", cancellationToken); // 120
							break;
						case "repeats":
							result.RepeatsElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.RepeatsElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".repeats", cancellationToken); // 130
							break;
						case "readOnly":
							result.ReadOnlyElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ReadOnlyElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".readOnly", cancellationToken); // 140
							break;
						case "maxLength":
							result.MaxLengthElement = new Hl7.Fhir.Model.Integer();
							Parse(result.MaxLengthElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".maxLength", cancellationToken); // 150
							break;
						case "answerValueSet":
							result.AnswerValueSetElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.AnswerValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".answerValueSet", cancellationToken); // 160
							break;
						case "answerOption":
							var newItem_answerOption = new Hl7.Fhir.Model.Questionnaire.AnswerOptionComponent();
							Parse(newItem_answerOption, reader, outcome, locationPath + ".answerOption["+result.AnswerOption.Count+"]", cancellationToken); // 170
							result.AnswerOption.Add(newItem_answerOption);
							break;
						case "initial":
							var newItem_initial = new Hl7.Fhir.Model.Questionnaire.InitialComponent();
							Parse(newItem_initial, reader, outcome, locationPath + ".initial["+result.Initial.Count+"]", cancellationToken); // 180
							result.Initial.Add(newItem_initial);
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.Questionnaire.ItemComponent();
							Parse(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]", cancellationToken); // 190
							result.Item.Add(newItem_item);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Questionnaire.ItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "linkId":
							result.LinkIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LinkIdElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".linkId", cancellationToken); // 40
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.DefinitionElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".definition", cancellationToken); // 50
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 60
							result.Code.Add(newItem_code);
							break;
						case "prefix":
							result.PrefixElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PrefixElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".prefix", cancellationToken); // 70
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 80
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemType>, reader, outcome, locationPath + ".type", cancellationToken); // 90
							break;
						case "enableWhen":
							var newItem_enableWhen = new Hl7.Fhir.Model.Questionnaire.EnableWhenComponent();
							await ParseAsync(newItem_enableWhen, reader, outcome, locationPath + ".enableWhen["+result.EnableWhen.Count+"]", cancellationToken); // 100
							result.EnableWhen.Add(newItem_enableWhen);
							break;
						case "enableBehavior":
							result.EnableBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.EnableWhenBehavior>();
							await ParseAsync(result.EnableBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.EnableWhenBehavior>, reader, outcome, locationPath + ".enableBehavior", cancellationToken); // 110
							break;
						case "required":
							result.RequiredElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.RequiredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".required", cancellationToken); // 120
							break;
						case "repeats":
							result.RepeatsElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.RepeatsElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".repeats", cancellationToken); // 130
							break;
						case "readOnly":
							result.ReadOnlyElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ReadOnlyElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".readOnly", cancellationToken); // 140
							break;
						case "maxLength":
							result.MaxLengthElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MaxLengthElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".maxLength", cancellationToken); // 150
							break;
						case "answerValueSet":
							result.AnswerValueSetElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.AnswerValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".answerValueSet", cancellationToken); // 160
							break;
						case "answerOption":
							var newItem_answerOption = new Hl7.Fhir.Model.Questionnaire.AnswerOptionComponent();
							await ParseAsync(newItem_answerOption, reader, outcome, locationPath + ".answerOption["+result.AnswerOption.Count+"]", cancellationToken); // 170
							result.AnswerOption.Add(newItem_answerOption);
							break;
						case "initial":
							var newItem_initial = new Hl7.Fhir.Model.Questionnaire.InitialComponent();
							await ParseAsync(newItem_initial, reader, outcome, locationPath + ".initial["+result.Initial.Count+"]", cancellationToken); // 180
							result.Initial.Add(newItem_initial);
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.Questionnaire.ItemComponent();
							await ParseAsync(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]", cancellationToken); // 190
							result.Item.Add(newItem_item);
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
