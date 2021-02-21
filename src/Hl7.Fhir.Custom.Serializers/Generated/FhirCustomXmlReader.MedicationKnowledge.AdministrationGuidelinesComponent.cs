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
		public void Parse(Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "dosage":
							var newItem_dosage = new Hl7.Fhir.Model.MedicationKnowledge.DosageComponent();
							Parse(newItem_dosage, reader, outcome, locationPath + ".dosage["+result.Dosage.Count+"]"); // 40
							result.Dosage.Add(newItem_dosage);
							break;
						case "indicationCodeableConcept":
							result.Indication = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Indication as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".indication"); // 50
							break;
						case "indicationReference":
							result.Indication = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Indication as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".indication"); // 50
							break;
						case "patientCharacteristics":
							var newItem_patientCharacteristics = new Hl7.Fhir.Model.MedicationKnowledge.PatientCharacteristicsComponent();
							Parse(newItem_patientCharacteristics, reader, outcome, locationPath + ".patientCharacteristics["+result.PatientCharacteristics.Count+"]"); // 60
							result.PatientCharacteristics.Add(newItem_patientCharacteristics);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "dosage":
							var newItem_dosage = new Hl7.Fhir.Model.MedicationKnowledge.DosageComponent();
							await ParseAsync(newItem_dosage, reader, outcome, locationPath + ".dosage["+result.Dosage.Count+"]"); // 40
							result.Dosage.Add(newItem_dosage);
							break;
						case "indicationCodeableConcept":
							result.Indication = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Indication as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".indication"); // 50
							break;
						case "indicationReference":
							result.Indication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Indication as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".indication"); // 50
							break;
						case "patientCharacteristics":
							var newItem_patientCharacteristics = new Hl7.Fhir.Model.MedicationKnowledge.PatientCharacteristicsComponent();
							await ParseAsync(newItem_patientCharacteristics, reader, outcome, locationPath + ".patientCharacteristics["+result.PatientCharacteristics.Count+"]"); // 60
							result.PatientCharacteristics.Add(newItem_patientCharacteristics);
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
