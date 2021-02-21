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
		public void Parse(Hl7.Fhir.Model.RequestGroup.ActionComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "prefix":
							result.PrefixElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PrefixElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "textEquivalent":
							result.TextEquivalentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextEquivalentElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome); // 80
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_code, reader, outcome); // 90
							result.Code.Add(newItem_code);
							break;
						case "documentation":
							var newItem_documentation = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_documentation, reader, outcome); // 100
							result.Documentation.Add(newItem_documentation);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.RequestGroup.ConditionComponent();
							Parse(newItem_condition, reader, outcome); // 110
							result.Condition.Add(newItem_condition);
							break;
						case "relatedAction":
							var newItem_relatedAction = new Hl7.Fhir.Model.RequestGroup.RelatedActionComponent();
							Parse(newItem_relatedAction, reader, outcome); // 120
							result.RelatedAction.Add(newItem_relatedAction);
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 130
							break;
						case "timingAge":
							result.Timing = new Hl7.Fhir.Model.Age();
							Parse(result.Timing as Hl7.Fhir.Model.Age, reader, outcome); // 130
							break;
						case "timingPeriod":
							result.Timing = new Hl7.Fhir.Model.Period();
							Parse(result.Timing as Hl7.Fhir.Model.Period, reader, outcome); // 130
							break;
						case "timingDuration":
							result.Timing = new Hl7.Fhir.Model.Duration();
							Parse(result.Timing as Hl7.Fhir.Model.Duration, reader, outcome); // 130
							break;
						case "timingRange":
							result.Timing = new Hl7.Fhir.Model.Range();
							Parse(result.Timing as Hl7.Fhir.Model.Range, reader, outcome); // 130
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							Parse(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome); // 130
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_participant, reader, outcome); // 140
							result.Participant.Add(newItem_participant);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 150
							break;
						case "groupingBehavior":
							result.GroupingBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>();
							Parse(result.GroupingBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>, reader, outcome); // 160
							break;
						case "selectionBehavior":
							result.SelectionBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>();
							Parse(result.SelectionBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>, reader, outcome); // 170
							break;
						case "requiredBehavior":
							result.RequiredBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>();
							Parse(result.RequiredBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>, reader, outcome); // 180
							break;
						case "precheckBehavior":
							result.PrecheckBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>();
							Parse(result.PrecheckBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>, reader, outcome); // 190
							break;
						case "cardinalityBehavior":
							result.CardinalityBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>();
							Parse(result.CardinalityBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>, reader, outcome); // 200
							break;
						case "resource":
							result.Resource = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Resource as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.RequestGroup.ActionComponent();
							Parse(newItem_action, reader, outcome); // 220
							result.Action.Add(newItem_action);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.RequestGroup.ActionComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "prefix":
							result.PrefixElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PrefixElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "textEquivalent":
							result.TextEquivalentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextEquivalentElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome); // 80
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_code, reader, outcome); // 90
							result.Code.Add(newItem_code);
							break;
						case "documentation":
							var newItem_documentation = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_documentation, reader, outcome); // 100
							result.Documentation.Add(newItem_documentation);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.RequestGroup.ConditionComponent();
							await ParseAsync(newItem_condition, reader, outcome); // 110
							result.Condition.Add(newItem_condition);
							break;
						case "relatedAction":
							var newItem_relatedAction = new Hl7.Fhir.Model.RequestGroup.RelatedActionComponent();
							await ParseAsync(newItem_relatedAction, reader, outcome); // 120
							result.RelatedAction.Add(newItem_relatedAction);
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 130
							break;
						case "timingAge":
							result.Timing = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Age, reader, outcome); // 130
							break;
						case "timingPeriod":
							result.Timing = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Period, reader, outcome); // 130
							break;
						case "timingDuration":
							result.Timing = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Duration, reader, outcome); // 130
							break;
						case "timingRange":
							result.Timing = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Range, reader, outcome); // 130
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome); // 130
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_participant, reader, outcome); // 140
							result.Participant.Add(newItem_participant);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 150
							break;
						case "groupingBehavior":
							result.GroupingBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>();
							await ParseAsync(result.GroupingBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>, reader, outcome); // 160
							break;
						case "selectionBehavior":
							result.SelectionBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>();
							await ParseAsync(result.SelectionBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>, reader, outcome); // 170
							break;
						case "requiredBehavior":
							result.RequiredBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>();
							await ParseAsync(result.RequiredBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>, reader, outcome); // 180
							break;
						case "precheckBehavior":
							result.PrecheckBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>();
							await ParseAsync(result.PrecheckBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>, reader, outcome); // 190
							break;
						case "cardinalityBehavior":
							result.CardinalityBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>();
							await ParseAsync(result.CardinalityBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>, reader, outcome); // 200
							break;
						case "resource":
							result.Resource = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Resource as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.RequestGroup.ActionComponent();
							await ParseAsync(newItem_action, reader, outcome); // 220
							result.Action.Add(newItem_action);
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
