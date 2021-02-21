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
		private void Parse(GuidanceResponse result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "requestIdentifier":
							result.RequestIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.RequestIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".requestIdentifier"); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "moduleUri":
							result.Module = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Module as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".module"); // 110
							break;
						case "moduleCanonical":
							result.Module = new Hl7.Fhir.Model.Canonical();
							Parse(result.Module as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".module"); // 110
							break;
						case "moduleCodeableConcept":
							result.Module = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Module as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".module"); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>, reader, outcome, locationPath + ".status"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 140
							break;
						case "occurrenceDateTime":
							result.OccurrenceDateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.OccurrenceDateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrenceDateTime"); // 150
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer"); // 160
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 170
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 180
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 190
							result.Note.Add(newItem_note);
							break;
						case "evaluationMessage":
							var newItem_evaluationMessage = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_evaluationMessage, reader, outcome, locationPath + ".evaluationMessage["+result.EvaluationMessage.Count+"]"); // 200
							result.EvaluationMessage.Add(newItem_evaluationMessage);
							break;
						case "outputParameters":
							result.OutputParameters = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OutputParameters as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".outputParameters"); // 210
							break;
						case "result":
							result.Result = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Result as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".result"); // 220
							break;
						case "dataRequirement":
							var newItem_dataRequirement = new Hl7.Fhir.Model.DataRequirement();
							Parse(newItem_dataRequirement, reader, outcome, locationPath + ".dataRequirement["+result.DataRequirement.Count+"]"); // 230
							result.DataRequirement.Add(newItem_dataRequirement);
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

		private async System.Threading.Tasks.Task ParseAsync(GuidanceResponse result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "requestIdentifier":
							result.RequestIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.RequestIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".requestIdentifier"); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "moduleUri":
							result.Module = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Module as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".module"); // 110
							break;
						case "moduleCanonical":
							result.Module = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Module as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".module"); // 110
							break;
						case "moduleCodeableConcept":
							result.Module = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Module as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".module"); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>, reader, outcome, locationPath + ".status"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 140
							break;
						case "occurrenceDateTime":
							result.OccurrenceDateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.OccurrenceDateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurrenceDateTime"); // 150
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer"); // 160
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 170
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 180
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 190
							result.Note.Add(newItem_note);
							break;
						case "evaluationMessage":
							var newItem_evaluationMessage = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_evaluationMessage, reader, outcome, locationPath + ".evaluationMessage["+result.EvaluationMessage.Count+"]"); // 200
							result.EvaluationMessage.Add(newItem_evaluationMessage);
							break;
						case "outputParameters":
							result.OutputParameters = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OutputParameters as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".outputParameters"); // 210
							break;
						case "result":
							result.Result = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Result as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".result"); // 220
							break;
						case "dataRequirement":
							var newItem_dataRequirement = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(newItem_dataRequirement, reader, outcome, locationPath + ".dataRequirement["+result.DataRequirement.Count+"]"); // 230
							result.DataRequirement.Add(newItem_dataRequirement);
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
