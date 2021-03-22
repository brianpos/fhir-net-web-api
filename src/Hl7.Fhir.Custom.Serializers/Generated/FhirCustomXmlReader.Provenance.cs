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
		private void Parse(Provenance result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "target":
							var newItem_target = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_target, reader, outcome, locationPath + ".target["+result.Target.Count+"]", cancellationToken); // 90
							result.Target.Add(newItem_target);
							break;
						case "occurredPeriod":
							result.Occurred = new Hl7.Fhir.Model.Period();
							Parse(result.Occurred as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurred", cancellationToken); // 100
							break;
						case "occurredDateTime":
							result.Occurred = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Occurred as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurred", cancellationToken); // 100
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.RecordedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".recorded", cancellationToken); // 110
							break;
						case "policy":
							var newItem_policy = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_policy, reader, outcome, locationPath + ".policy["+result.PolicyElement.Count+"]", cancellationToken); // 120
							result.PolicyElement.Add(newItem_policy);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 130
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reason, reader, outcome, locationPath + ".reason["+result.Reason.Count+"]", cancellationToken); // 140
							result.Reason.Add(newItem_reason);
							break;
						case "activity":
							result.Activity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Activity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".activity", cancellationToken); // 150
							break;
						case "agent":
							var newItem_agent = new Hl7.Fhir.Model.Provenance.AgentComponent();
							Parse(newItem_agent, reader, outcome, locationPath + ".agent["+result.Agent.Count+"]", cancellationToken); // 160
							result.Agent.Add(newItem_agent);
							break;
						case "entity":
							var newItem_entity = new Hl7.Fhir.Model.Provenance.EntityComponent();
							Parse(newItem_entity, reader, outcome, locationPath + ".entity["+result.Entity.Count+"]", cancellationToken); // 170
							result.Entity.Add(newItem_entity);
							break;
						case "signature":
							var newItem_signature = new Hl7.Fhir.Model.Signature();
							Parse(newItem_signature, reader, outcome, locationPath + ".signature["+result.Signature.Count+"]", cancellationToken); // 180
							result.Signature.Add(newItem_signature);
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

		private async System.Threading.Tasks.Task ParseAsync(Provenance result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "target":
							var newItem_target = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_target, reader, outcome, locationPath + ".target["+result.Target.Count+"]", cancellationToken); // 90
							result.Target.Add(newItem_target);
							break;
						case "occurredPeriod":
							result.Occurred = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Occurred as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".occurred", cancellationToken); // 100
							break;
						case "occurredDateTime":
							result.Occurred = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Occurred as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".occurred", cancellationToken); // 100
							break;
						case "recorded":
							result.RecordedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.RecordedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".recorded", cancellationToken); // 110
							break;
						case "policy":
							var newItem_policy = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_policy, reader, outcome, locationPath + ".policy["+result.PolicyElement.Count+"]", cancellationToken); // 120
							result.PolicyElement.Add(newItem_policy);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 130
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reason, reader, outcome, locationPath + ".reason["+result.Reason.Count+"]", cancellationToken); // 140
							result.Reason.Add(newItem_reason);
							break;
						case "activity":
							result.Activity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Activity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".activity", cancellationToken); // 150
							break;
						case "agent":
							var newItem_agent = new Hl7.Fhir.Model.Provenance.AgentComponent();
							await ParseAsync(newItem_agent, reader, outcome, locationPath + ".agent["+result.Agent.Count+"]", cancellationToken); // 160
							result.Agent.Add(newItem_agent);
							break;
						case "entity":
							var newItem_entity = new Hl7.Fhir.Model.Provenance.EntityComponent();
							await ParseAsync(newItem_entity, reader, outcome, locationPath + ".entity["+result.Entity.Count+"]", cancellationToken); // 170
							result.Entity.Add(newItem_entity);
							break;
						case "signature":
							var newItem_signature = new Hl7.Fhir.Model.Signature();
							await ParseAsync(newItem_signature, reader, outcome, locationPath + ".signature["+result.Signature.Count+"]", cancellationToken); // 180
							result.Signature.Add(newItem_signature);
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
