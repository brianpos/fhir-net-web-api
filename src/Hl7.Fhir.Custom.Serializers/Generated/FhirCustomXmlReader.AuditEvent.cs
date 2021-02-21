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
		private void Parse(AuditEvent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.Coding();
							Parse(result.Type as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".type"); // 90
							break;
						case "subtype":
							var newItem_subtype = new Hl7.Fhir.Model.Coding();
							Parse(newItem_subtype, reader, outcome, locationPath + ".subtype["+result.Subtype.Count+"]"); // 100
							result.Subtype.Add(newItem_subtype);
							break;
						case "action":
							result.ActionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction>();
							Parse(result.ActionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction>, reader, outcome, locationPath + ".action"); // 110
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 120
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.RecordedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".recorded"); // 130
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome>();
							Parse(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome>, reader, outcome, locationPath + ".outcome"); // 140
							break;
						case "outcomeDesc":
							result.OutcomeDescElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.OutcomeDescElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".outcomeDesc"); // 150
							break;
						case "purposeOfEvent":
							var newItem_purposeOfEvent = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_purposeOfEvent, reader, outcome, locationPath + ".purposeOfEvent["+result.PurposeOfEvent.Count+"]"); // 160
							result.PurposeOfEvent.Add(newItem_purposeOfEvent);
							break;
						case "agent":
							var newItem_agent = new Hl7.Fhir.Model.AuditEvent.AgentComponent();
							Parse(newItem_agent, reader, outcome, locationPath + ".agent["+result.Agent.Count+"]"); // 170
							result.Agent.Add(newItem_agent);
							break;
						case "source":
							result.Source = new Hl7.Fhir.Model.AuditEvent.SourceComponent();
							Parse(result.Source as Hl7.Fhir.Model.AuditEvent.SourceComponent, reader, outcome, locationPath + ".source"); // 180
							break;
						case "entity":
							var newItem_entity = new Hl7.Fhir.Model.AuditEvent.EntityComponent();
							Parse(newItem_entity, reader, outcome, locationPath + ".entity["+result.Entity.Count+"]"); // 190
							result.Entity.Add(newItem_entity);
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

		private async System.Threading.Tasks.Task ParseAsync(AuditEvent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Type as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".type"); // 90
							break;
						case "subtype":
							var newItem_subtype = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_subtype, reader, outcome, locationPath + ".subtype["+result.Subtype.Count+"]"); // 100
							result.Subtype.Add(newItem_subtype);
							break;
						case "action":
							result.ActionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction>();
							await ParseAsync(result.ActionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction>, reader, outcome, locationPath + ".action"); // 110
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 120
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.RecordedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".recorded"); // 130
							break;
						case "outcome":
							result.OutcomeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome>();
							await ParseAsync(result.OutcomeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome>, reader, outcome, locationPath + ".outcome"); // 140
							break;
						case "outcomeDesc":
							result.OutcomeDescElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.OutcomeDescElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".outcomeDesc"); // 150
							break;
						case "purposeOfEvent":
							var newItem_purposeOfEvent = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_purposeOfEvent, reader, outcome, locationPath + ".purposeOfEvent["+result.PurposeOfEvent.Count+"]"); // 160
							result.PurposeOfEvent.Add(newItem_purposeOfEvent);
							break;
						case "agent":
							var newItem_agent = new Hl7.Fhir.Model.AuditEvent.AgentComponent();
							await ParseAsync(newItem_agent, reader, outcome, locationPath + ".agent["+result.Agent.Count+"]"); // 170
							result.Agent.Add(newItem_agent);
							break;
						case "source":
							result.Source = new Hl7.Fhir.Model.AuditEvent.SourceComponent();
							await ParseAsync(result.Source as Hl7.Fhir.Model.AuditEvent.SourceComponent, reader, outcome, locationPath + ".source"); // 180
							break;
						case "entity":
							var newItem_entity = new Hl7.Fhir.Model.AuditEvent.EntityComponent();
							await ParseAsync(newItem_entity, reader, outcome, locationPath + ".entity["+result.Entity.Count+"]"); // 190
							result.Entity.Add(newItem_entity);
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
