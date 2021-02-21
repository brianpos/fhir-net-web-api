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
		public void Parse(Hl7.Fhir.Model.Questionnaire.EnableWhenComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "question":
							result.QuestionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.QuestionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".question"); // 40
							break;
						case "operator":
							result.OperatorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemOperator>();
							Parse(result.OperatorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemOperator>, reader, outcome, locationPath + ".operator"); // 50
							break;
						case "answerBoolean":
							result.Answer = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Answer as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerDecimal":
							result.Answer = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.Answer as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerInteger":
							result.Answer = new Hl7.Fhir.Model.Integer();
							Parse(result.Answer as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerDate":
							result.Answer = new Hl7.Fhir.Model.Date();
							Parse(result.Answer as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerDateTime":
							result.Answer = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Answer as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerTime":
							result.Answer = new Hl7.Fhir.Model.Time();
							Parse(result.Answer as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerString":
							result.Answer = new Hl7.Fhir.Model.FhirString();
							Parse(result.Answer as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerCoding":
							result.Answer = new Hl7.Fhir.Model.Coding();
							Parse(result.Answer as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerQuantity":
							result.Answer = new Hl7.Fhir.Model.Quantity();
							Parse(result.Answer as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerReference":
							result.Answer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Answer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".answer"); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Questionnaire.EnableWhenComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "question":
							result.QuestionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.QuestionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".question"); // 40
							break;
						case "operator":
							result.OperatorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemOperator>();
							await ParseAsync(result.OperatorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireItemOperator>, reader, outcome, locationPath + ".operator"); // 50
							break;
						case "answerBoolean":
							result.Answer = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerDecimal":
							result.Answer = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerInteger":
							result.Answer = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerDate":
							result.Answer = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerDateTime":
							result.Answer = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerTime":
							result.Answer = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerString":
							result.Answer = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerCoding":
							result.Answer = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerQuantity":
							result.Answer = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".answer"); // 60
							break;
						case "answerReference":
							result.Answer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Answer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".answer"); // 60
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
