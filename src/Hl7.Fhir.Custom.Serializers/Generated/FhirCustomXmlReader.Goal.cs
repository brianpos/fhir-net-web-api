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
		private void Parse(Goal result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "lifecycleStatus":
							result.LifecycleStatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus>();
							Parse(result.LifecycleStatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus>, reader, outcome, locationPath + ".lifecycleStatus", cancellationToken); // 100
							break;
						case "achievementStatus":
							result.AchievementStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AchievementStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".achievementStatus", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority", cancellationToken); // 130
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Description as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".description", cancellationToken); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 150
							break;
						case "startDate":
							result.Start = new Hl7.Fhir.Model.Date();
							Parse(result.Start as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".start", cancellationToken); // 160
							break;
						case "startCodeableConcept":
							result.Start = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Start as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".start", cancellationToken); // 160
							break;
						case "target":
							var newItem_target = new Hl7.Fhir.Model.Goal.TargetComponent();
							Parse(newItem_target, reader, outcome, locationPath + ".target["+result.Target.Count+"]", cancellationToken); // 170
							result.Target.Add(newItem_target);
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.StatusDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".statusDate", cancellationToken); // 180
							break;
						case "statusReason":
							result.StatusReasonElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.StatusReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".statusReason", cancellationToken); // 190
							break;
						case "expressedBy":
							result.ExpressedBy = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ExpressedBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".expressedBy", cancellationToken); // 200
							break;
						case "addresses":
							var newItem_addresses = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_addresses, reader, outcome, locationPath + ".addresses["+result.Addresses.Count+"]", cancellationToken); // 210
							result.Addresses.Add(newItem_addresses);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 220
							result.Note.Add(newItem_note);
							break;
						case "outcomeCode":
							var newItem_outcomeCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_outcomeCode, reader, outcome, locationPath + ".outcomeCode["+result.OutcomeCode.Count+"]", cancellationToken); // 230
							result.OutcomeCode.Add(newItem_outcomeCode);
							break;
						case "outcomeReference":
							var newItem_outcomeReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_outcomeReference, reader, outcome, locationPath + ".outcomeReference["+result.OutcomeReference.Count+"]", cancellationToken); // 240
							result.OutcomeReference.Add(newItem_outcomeReference);
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

		private async System.Threading.Tasks.Task ParseAsync(Goal result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "lifecycleStatus":
							result.LifecycleStatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus>();
							await ParseAsync(result.LifecycleStatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus>, reader, outcome, locationPath + ".lifecycleStatus", cancellationToken); // 100
							break;
						case "achievementStatus":
							result.AchievementStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AchievementStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".achievementStatus", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority", cancellationToken); // 130
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Description as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".description", cancellationToken); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 150
							break;
						case "startDate":
							result.Start = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Start as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".start", cancellationToken); // 160
							break;
						case "startCodeableConcept":
							result.Start = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Start as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".start", cancellationToken); // 160
							break;
						case "target":
							var newItem_target = new Hl7.Fhir.Model.Goal.TargetComponent();
							await ParseAsync(newItem_target, reader, outcome, locationPath + ".target["+result.Target.Count+"]", cancellationToken); // 170
							result.Target.Add(newItem_target);
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.StatusDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".statusDate", cancellationToken); // 180
							break;
						case "statusReason":
							result.StatusReasonElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.StatusReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".statusReason", cancellationToken); // 190
							break;
						case "expressedBy":
							result.ExpressedBy = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ExpressedBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".expressedBy", cancellationToken); // 200
							break;
						case "addresses":
							var newItem_addresses = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_addresses, reader, outcome, locationPath + ".addresses["+result.Addresses.Count+"]", cancellationToken); // 210
							result.Addresses.Add(newItem_addresses);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 220
							result.Note.Add(newItem_note);
							break;
						case "outcomeCode":
							var newItem_outcomeCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_outcomeCode, reader, outcome, locationPath + ".outcomeCode["+result.OutcomeCode.Count+"]", cancellationToken); // 230
							result.OutcomeCode.Add(newItem_outcomeCode);
							break;
						case "outcomeReference":
							var newItem_outcomeReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_outcomeReference, reader, outcome, locationPath + ".outcomeReference["+result.OutcomeReference.Count+"]", cancellationToken); // 240
							result.OutcomeReference.Add(newItem_outcomeReference);
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
