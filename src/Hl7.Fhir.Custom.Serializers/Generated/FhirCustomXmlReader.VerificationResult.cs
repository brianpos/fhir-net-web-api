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
		private void Parse(VerificationResult result, XmlReader reader, OperationOutcome outcome)
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
						case "target":
							var newItem_target = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_target, reader, outcome); // 90
							result.Target.Add(newItem_target);
							break;
						case "targetLocation":
							var newItem_targetLocation = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_targetLocation, reader, outcome); // 100
							result.TargetLocationElement.Add(newItem_targetLocation);
							break;
						case "need":
							result.Need = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Need as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VerificationResult.status>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VerificationResult.status>, reader, outcome); // 120
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 130
							break;
						case "validationType":
							result.ValidationType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ValidationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "validationProcess":
							var newItem_validationProcess = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_validationProcess, reader, outcome); // 150
							result.ValidationProcess.Add(newItem_validationProcess);
							break;
						case "frequency":
							result.Frequency = new Hl7.Fhir.Model.Timing();
							Parse(result.Frequency as Hl7.Fhir.Model.Timing, reader, outcome); // 160
							break;
						case "lastPerformed":
							result.LastPerformedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.LastPerformedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "nextScheduled":
							result.NextScheduledElement = new Hl7.Fhir.Model.Date();
							Parse(result.NextScheduledElement as Hl7.Fhir.Model.Date, reader, outcome); // 180
							break;
						case "failureAction":
							result.FailureAction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FailureAction as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 190
							break;
						case "primarySource":
							var newItem_primarySource = new Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent();
							Parse(newItem_primarySource, reader, outcome); // 200
							result.PrimarySource.Add(newItem_primarySource);
							break;
						case "attestation":
							result.Attestation = new Hl7.Fhir.Model.VerificationResult.AttestationComponent();
							Parse(result.Attestation as Hl7.Fhir.Model.VerificationResult.AttestationComponent, reader, outcome); // 210
							break;
						case "validator":
							var newItem_validator = new Hl7.Fhir.Model.VerificationResult.ValidatorComponent();
							Parse(newItem_validator, reader, outcome); // 220
							result.Validator.Add(newItem_validator);
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

		private async System.Threading.Tasks.Task ParseAsync(VerificationResult result, XmlReader reader, OperationOutcome outcome)
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
						case "target":
							var newItem_target = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_target, reader, outcome); // 90
							result.Target.Add(newItem_target);
							break;
						case "targetLocation":
							var newItem_targetLocation = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_targetLocation, reader, outcome); // 100
							result.TargetLocationElement.Add(newItem_targetLocation);
							break;
						case "need":
							result.Need = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Need as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VerificationResult.status>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VerificationResult.status>, reader, outcome); // 120
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 130
							break;
						case "validationType":
							result.ValidationType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ValidationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "validationProcess":
							var newItem_validationProcess = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_validationProcess, reader, outcome); // 150
							result.ValidationProcess.Add(newItem_validationProcess);
							break;
						case "frequency":
							result.Frequency = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Frequency as Hl7.Fhir.Model.Timing, reader, outcome); // 160
							break;
						case "lastPerformed":
							result.LastPerformedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.LastPerformedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 170
							break;
						case "nextScheduled":
							result.NextScheduledElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.NextScheduledElement as Hl7.Fhir.Model.Date, reader, outcome); // 180
							break;
						case "failureAction":
							result.FailureAction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FailureAction as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 190
							break;
						case "primarySource":
							var newItem_primarySource = new Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent();
							await ParseAsync(newItem_primarySource, reader, outcome); // 200
							result.PrimarySource.Add(newItem_primarySource);
							break;
						case "attestation":
							result.Attestation = new Hl7.Fhir.Model.VerificationResult.AttestationComponent();
							await ParseAsync(result.Attestation as Hl7.Fhir.Model.VerificationResult.AttestationComponent, reader, outcome); // 210
							break;
						case "validator":
							var newItem_validator = new Hl7.Fhir.Model.VerificationResult.ValidatorComponent();
							await ParseAsync(newItem_validator, reader, outcome); // 220
							result.Validator.Add(newItem_validator);
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
