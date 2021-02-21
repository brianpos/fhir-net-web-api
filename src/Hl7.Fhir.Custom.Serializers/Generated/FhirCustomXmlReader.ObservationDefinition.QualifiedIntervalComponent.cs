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
		public void Parse(Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "category":
							result.CategoryElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>();
							Parse(result.CategoryElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>, reader, outcome); // 40
							break;
						case "range":
							result.Range = new Hl7.Fhir.Model.Range();
							Parse(result.Range as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Context as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 60
							break;
						case "appliesTo":
							var newItem_appliesTo = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_appliesTo, reader, outcome); // 70
							result.AppliesTo.Add(newItem_appliesTo);
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							Parse(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome); // 80
							break;
						case "age":
							result.Age = new Hl7.Fhir.Model.Range();
							Parse(result.Age as Hl7.Fhir.Model.Range, reader, outcome); // 90
							break;
						case "gestationalAge":
							result.GestationalAge = new Hl7.Fhir.Model.Range();
							Parse(result.GestationalAge as Hl7.Fhir.Model.Range, reader, outcome); // 100
							break;
						case "condition":
							result.ConditionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ConditionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "category":
							result.CategoryElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>();
							await ParseAsync(result.CategoryElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>, reader, outcome); // 40
							break;
						case "range":
							result.Range = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Range as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Context as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 60
							break;
						case "appliesTo":
							var newItem_appliesTo = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_appliesTo, reader, outcome); // 70
							result.AppliesTo.Add(newItem_appliesTo);
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							await ParseAsync(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome); // 80
							break;
						case "age":
							result.Age = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Age as Hl7.Fhir.Model.Range, reader, outcome); // 90
							break;
						case "gestationalAge":
							result.GestationalAge = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.GestationalAge as Hl7.Fhir.Model.Range, reader, outcome); // 100
							break;
						case "condition":
							result.ConditionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ConditionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
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
