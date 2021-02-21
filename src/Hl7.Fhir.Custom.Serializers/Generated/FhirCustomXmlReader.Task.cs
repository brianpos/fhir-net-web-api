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
		private void Parse(Task result, XmlReader reader, OperationOutcome outcome)
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
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "instantiatesCanonical":
							result.InstantiatesCanonicalElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.InstantiatesCanonicalElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 100
							break;
						case "instantiatesUri":
							result.InstantiatesUriElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.InstantiatesUriElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 110
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "groupIdentifier":
							result.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.GroupIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 130
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome); // 140
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskStatus>, reader, outcome); // 150
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "businessStatus":
							result.BusinessStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BusinessStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 170
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskIntent>();
							Parse(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskIntent>, reader, outcome); // 180
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome); // 190
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 200
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Focus as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 220
							break;
						case "for":
							result.For = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.For as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 230
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 240
							break;
						case "executionPeriod":
							result.ExecutionPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.ExecutionPeriod as Hl7.Fhir.Model.Period, reader, outcome); // 250
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 260
							break;
						case "lastModified":
							result.LastModifiedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.LastModifiedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 270
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 280
							break;
						case "performerType":
							var newItem_performerType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_performerType, reader, outcome); // 290
							result.PerformerType.Add(newItem_performerType);
							break;
						case "owner":
							result.Owner = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Owner as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 310
							break;
						case "reasonCode":
							result.ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ReasonCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 320
							break;
						case "reasonReference":
							result.ReasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ReasonReference as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 330
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_insurance, reader, outcome); // 340
							result.Insurance.Add(newItem_insurance);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 350
							result.Note.Add(newItem_note);
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_relevantHistory, reader, outcome); // 360
							result.RelevantHistory.Add(newItem_relevantHistory);
							break;
						case "restriction":
							result.Restriction = new Hl7.Fhir.Model.Task.RestrictionComponent();
							Parse(result.Restriction as Hl7.Fhir.Model.Task.RestrictionComponent, reader, outcome); // 370
							break;
						case "input":
							var newItem_input = new Hl7.Fhir.Model.Task.ParameterComponent();
							Parse(newItem_input, reader, outcome); // 380
							result.Input.Add(newItem_input);
							break;
						case "output":
							var newItem_output = new Hl7.Fhir.Model.Task.OutputComponent();
							Parse(newItem_output, reader, outcome); // 390
							result.Output.Add(newItem_output);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
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

		private async System.Threading.Tasks.Task ParseAsync(Task result, XmlReader reader, OperationOutcome outcome)
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
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "instantiatesCanonical":
							result.InstantiatesCanonicalElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.InstantiatesCanonicalElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 100
							break;
						case "instantiatesUri":
							result.InstantiatesUriElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.InstantiatesUriElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 110
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "groupIdentifier":
							result.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.GroupIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 130
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome); // 140
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskStatus>, reader, outcome); // 150
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 160
							break;
						case "businessStatus":
							result.BusinessStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BusinessStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 170
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskIntent>();
							await ParseAsync(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskIntent>, reader, outcome); // 180
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome); // 190
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 200
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Focus as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 220
							break;
						case "for":
							result.For = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.For as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 230
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 240
							break;
						case "executionPeriod":
							result.ExecutionPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.ExecutionPeriod as Hl7.Fhir.Model.Period, reader, outcome); // 250
							break;
						case "authoredOn":
							result.AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.AuthoredOnElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 260
							break;
						case "lastModified":
							result.LastModifiedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.LastModifiedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 270
							break;
						case "requester":
							result.Requester = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Requester as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 280
							break;
						case "performerType":
							var newItem_performerType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_performerType, reader, outcome); // 290
							result.PerformerType.Add(newItem_performerType);
							break;
						case "owner":
							result.Owner = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Owner as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 310
							break;
						case "reasonCode":
							result.ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ReasonCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 320
							break;
						case "reasonReference":
							result.ReasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ReasonReference as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 330
							break;
						case "insurance":
							var newItem_insurance = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_insurance, reader, outcome); // 340
							result.Insurance.Add(newItem_insurance);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 350
							result.Note.Add(newItem_note);
							break;
						case "relevantHistory":
							var newItem_relevantHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_relevantHistory, reader, outcome); // 360
							result.RelevantHistory.Add(newItem_relevantHistory);
							break;
						case "restriction":
							result.Restriction = new Hl7.Fhir.Model.Task.RestrictionComponent();
							await ParseAsync(result.Restriction as Hl7.Fhir.Model.Task.RestrictionComponent, reader, outcome); // 370
							break;
						case "input":
							var newItem_input = new Hl7.Fhir.Model.Task.ParameterComponent();
							await ParseAsync(newItem_input, reader, outcome); // 380
							result.Input.Add(newItem_input);
							break;
						case "output":
							var newItem_output = new Hl7.Fhir.Model.Task.OutputComponent();
							await ParseAsync(newItem_output, reader, outcome); // 390
							result.Output.Add(newItem_output);
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
