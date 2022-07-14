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
		public void Parse(Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome", cancellationToken); // 50
							break;
						case "contributedToDeath":
							result.ContributedToDeathElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ContributedToDeathElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".contributedToDeath", cancellationToken); // 60
							break;
						case "onsetAge":
							result.Onset = new Hl7.Fhir.Model.Age();
							Parse(result.Onset as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "onsetRange":
							result.Onset = new Hl7.Fhir.Model.Range();
							Parse(result.Onset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "onsetPeriod":
							result.Onset = new Hl7.Fhir.Model.Period();
							Parse(result.Onset as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "onsetString":
							result.Onset = new Hl7.Fhir.Model.FhirString();
							Parse(result.Onset as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 80
							result.Note.Add(newItem_note);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome", cancellationToken); // 50
							break;
						case "contributedToDeath":
							result.ContributedToDeathElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ContributedToDeathElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".contributedToDeath", cancellationToken); // 60
							break;
						case "onsetAge":
							result.Onset = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "onsetRange":
							result.Onset = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "onsetPeriod":
							result.Onset = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "onsetString":
							result.Onset = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Onset as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 80
							result.Note.Add(newItem_note);
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
