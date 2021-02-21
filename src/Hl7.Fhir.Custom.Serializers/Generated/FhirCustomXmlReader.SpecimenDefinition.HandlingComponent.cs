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
		public void Parse(Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "temperatureQualifier":
							result.TemperatureQualifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.TemperatureQualifier as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".temperatureQualifier"); // 40
							break;
						case "temperatureRange":
							result.TemperatureRange = new Hl7.Fhir.Model.Range();
							Parse(result.TemperatureRange as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".temperatureRange"); // 50
							break;
						case "maxDuration":
							result.MaxDuration = new Hl7.Fhir.Model.Duration();
							Parse(result.MaxDuration as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".maxDuration"); // 60
							break;
						case "instruction":
							result.InstructionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.InstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".instruction"); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "temperatureQualifier":
							result.TemperatureQualifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.TemperatureQualifier as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".temperatureQualifier"); // 40
							break;
						case "temperatureRange":
							result.TemperatureRange = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.TemperatureRange as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".temperatureRange"); // 50
							break;
						case "maxDuration":
							result.MaxDuration = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.MaxDuration as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".maxDuration"); // 60
							break;
						case "instruction":
							result.InstructionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.InstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".instruction"); // 70
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
