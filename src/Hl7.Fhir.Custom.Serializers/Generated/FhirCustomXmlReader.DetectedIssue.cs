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
		private void Parse(DetectedIssue result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 110
							break;
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DetectedIssue.DetectedIssueSeverity>();
							Parse(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DetectedIssue.DetectedIssueSeverity>, reader, outcome, locationPath + ".severity"); // 120
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 130
							break;
						case "identifiedDateTime":
							result.Identified = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Identified as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".identified"); // 140
							break;
						case "identifiedPeriod":
							result.Identified = new Hl7.Fhir.Model.Period();
							Parse(result.Identified as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".identified"); // 140
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".author"); // 150
							break;
						case "implicated":
							var newItem_implicated = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_implicated, reader, outcome, locationPath + ".implicated["+result.Implicated.Count+"]"); // 160
							result.Implicated.Add(newItem_implicated);
							break;
						case "evidence":
							var newItem_evidence = new Hl7.Fhir.Model.DetectedIssue.EvidenceComponent();
							Parse(newItem_evidence, reader, outcome, locationPath + ".evidence["+result.Evidence.Count+"]"); // 170
							result.Evidence.Add(newItem_evidence);
							break;
						case "detail":
							result.DetailElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DetailElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".detail"); // 180
							break;
						case "reference":
							result.ReferenceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ReferenceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".reference"); // 190
							break;
						case "mitigation":
							var newItem_mitigation = new Hl7.Fhir.Model.DetectedIssue.MitigationComponent();
							Parse(newItem_mitigation, reader, outcome, locationPath + ".mitigation["+result.Mitigation.Count+"]"); // 200
							result.Mitigation.Add(newItem_mitigation);
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

		private async System.Threading.Tasks.Task ParseAsync(DetectedIssue result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 110
							break;
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DetectedIssue.DetectedIssueSeverity>();
							await ParseAsync(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DetectedIssue.DetectedIssueSeverity>, reader, outcome, locationPath + ".severity"); // 120
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 130
							break;
						case "identifiedDateTime":
							result.Identified = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Identified as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".identified"); // 140
							break;
						case "identifiedPeriod":
							result.Identified = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Identified as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".identified"); // 140
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".author"); // 150
							break;
						case "implicated":
							var newItem_implicated = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_implicated, reader, outcome, locationPath + ".implicated["+result.Implicated.Count+"]"); // 160
							result.Implicated.Add(newItem_implicated);
							break;
						case "evidence":
							var newItem_evidence = new Hl7.Fhir.Model.DetectedIssue.EvidenceComponent();
							await ParseAsync(newItem_evidence, reader, outcome, locationPath + ".evidence["+result.Evidence.Count+"]"); // 170
							result.Evidence.Add(newItem_evidence);
							break;
						case "detail":
							result.DetailElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DetailElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".detail"); // 180
							break;
						case "reference":
							result.ReferenceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ReferenceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".reference"); // 190
							break;
						case "mitigation":
							var newItem_mitigation = new Hl7.Fhir.Model.DetectedIssue.MitigationComponent();
							await ParseAsync(newItem_mitigation, reader, outcome, locationPath + ".mitigation["+result.Mitigation.Count+"]"); // 200
							result.Mitigation.Add(newItem_mitigation);
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
