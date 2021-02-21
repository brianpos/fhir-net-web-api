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
		private void Parse(FamilyMemberHistory result, XmlReader reader, OperationOutcome outcome)
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
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FamilyMemberHistory.FamilyHistoryStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FamilyMemberHistory.FamilyHistoryStatus>, reader, outcome); // 120
							break;
						case "dataAbsentReason":
							result.DataAbsentReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DataAbsentReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "relationship":
							result.Relationship = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Relationship as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 170
							break;
						case "sex":
							result.Sex = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Sex as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 180
							break;
						case "bornPeriod":
							result.Born = new Hl7.Fhir.Model.Period();
							Parse(result.Born as Hl7.Fhir.Model.Period, reader, outcome); // 190
							break;
						case "bornDate":
							result.Born = new Hl7.Fhir.Model.Date();
							Parse(result.Born as Hl7.Fhir.Model.Date, reader, outcome); // 190
							break;
						case "bornString":
							result.Born = new Hl7.Fhir.Model.FhirString();
							Parse(result.Born as Hl7.Fhir.Model.FhirString, reader, outcome); // 190
							break;
						case "ageAge":
							result.Age = new Hl7.Fhir.Model.Age();
							Parse(result.Age as Hl7.Fhir.Model.Age, reader, outcome); // 200
							break;
						case "ageRange":
							result.Age = new Hl7.Fhir.Model.Range();
							Parse(result.Age as Hl7.Fhir.Model.Range, reader, outcome); // 200
							break;
						case "ageString":
							result.Age = new Hl7.Fhir.Model.FhirString();
							Parse(result.Age as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
							break;
						case "estimatedAge":
							result.EstimatedAgeElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.EstimatedAgeElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 210
							break;
						case "deceasedBoolean":
							result.Deceased = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Deceased as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 220
							break;
						case "deceasedAge":
							result.Deceased = new Hl7.Fhir.Model.Age();
							Parse(result.Deceased as Hl7.Fhir.Model.Age, reader, outcome); // 220
							break;
						case "deceasedRange":
							result.Deceased = new Hl7.Fhir.Model.Range();
							Parse(result.Deceased as Hl7.Fhir.Model.Range, reader, outcome); // 220
							break;
						case "deceasedDate":
							result.Deceased = new Hl7.Fhir.Model.Date();
							Parse(result.Deceased as Hl7.Fhir.Model.Date, reader, outcome); // 220
							break;
						case "deceasedString":
							result.Deceased = new Hl7.Fhir.Model.FhirString();
							Parse(result.Deceased as Hl7.Fhir.Model.FhirString, reader, outcome); // 220
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome); // 230
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome); // 240
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 250
							result.Note.Add(newItem_note);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent();
							Parse(newItem_condition, reader, outcome); // 260
							result.Condition.Add(newItem_condition);
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

		private async System.Threading.Tasks.Task ParseAsync(FamilyMemberHistory result, XmlReader reader, OperationOutcome outcome)
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
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FamilyMemberHistory.FamilyHistoryStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FamilyMemberHistory.FamilyHistoryStatus>, reader, outcome); // 120
							break;
						case "dataAbsentReason":
							result.DataAbsentReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DataAbsentReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 130
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "relationship":
							result.Relationship = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Relationship as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 170
							break;
						case "sex":
							result.Sex = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Sex as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 180
							break;
						case "bornPeriod":
							result.Born = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Born as Hl7.Fhir.Model.Period, reader, outcome); // 190
							break;
						case "bornDate":
							result.Born = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Born as Hl7.Fhir.Model.Date, reader, outcome); // 190
							break;
						case "bornString":
							result.Born = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Born as Hl7.Fhir.Model.FhirString, reader, outcome); // 190
							break;
						case "ageAge":
							result.Age = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Age as Hl7.Fhir.Model.Age, reader, outcome); // 200
							break;
						case "ageRange":
							result.Age = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Age as Hl7.Fhir.Model.Range, reader, outcome); // 200
							break;
						case "ageString":
							result.Age = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Age as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
							break;
						case "estimatedAge":
							result.EstimatedAgeElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.EstimatedAgeElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 210
							break;
						case "deceasedBoolean":
							result.Deceased = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 220
							break;
						case "deceasedAge":
							result.Deceased = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.Age, reader, outcome); // 220
							break;
						case "deceasedRange":
							result.Deceased = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.Range, reader, outcome); // 220
							break;
						case "deceasedDate":
							result.Deceased = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.Date, reader, outcome); // 220
							break;
						case "deceasedString":
							result.Deceased = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.FhirString, reader, outcome); // 220
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome); // 230
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome); // 240
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 250
							result.Note.Add(newItem_note);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent();
							await ParseAsync(newItem_condition, reader, outcome); // 260
							result.Condition.Add(newItem_condition);
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
