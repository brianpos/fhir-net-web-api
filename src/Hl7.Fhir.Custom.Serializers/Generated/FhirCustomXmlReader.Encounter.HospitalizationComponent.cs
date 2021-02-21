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
		public void Parse(Hl7.Fhir.Model.Encounter.HospitalizationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "preAdmissionIdentifier":
							result.PreAdmissionIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.PreAdmissionIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".preAdmissionIdentifier"); // 40
							break;
						case "origin":
							result.Origin = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Origin as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".origin"); // 50
							break;
						case "admitSource":
							result.AdmitSource = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AdmitSource as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".admitSource"); // 60
							break;
						case "reAdmission":
							result.ReAdmission = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ReAdmission as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".reAdmission"); // 70
							break;
						case "dietPreference":
							var newItem_dietPreference = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_dietPreference, reader, outcome, locationPath + ".dietPreference["+result.DietPreference.Count+"]"); // 80
							result.DietPreference.Add(newItem_dietPreference);
							break;
						case "specialCourtesy":
							var newItem_specialCourtesy = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialCourtesy, reader, outcome, locationPath + ".specialCourtesy["+result.SpecialCourtesy.Count+"]"); // 90
							result.SpecialCourtesy.Add(newItem_specialCourtesy);
							break;
						case "specialArrangement":
							var newItem_specialArrangement = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialArrangement, reader, outcome, locationPath + ".specialArrangement["+result.SpecialArrangement.Count+"]"); // 100
							result.SpecialArrangement.Add(newItem_specialArrangement);
							break;
						case "destination":
							result.Destination = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Destination as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".destination"); // 110
							break;
						case "dischargeDisposition":
							result.DischargeDisposition = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DischargeDisposition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".dischargeDisposition"); // 120
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Encounter.HospitalizationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "preAdmissionIdentifier":
							result.PreAdmissionIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.PreAdmissionIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".preAdmissionIdentifier"); // 40
							break;
						case "origin":
							result.Origin = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Origin as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".origin"); // 50
							break;
						case "admitSource":
							result.AdmitSource = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AdmitSource as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".admitSource"); // 60
							break;
						case "reAdmission":
							result.ReAdmission = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ReAdmission as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".reAdmission"); // 70
							break;
						case "dietPreference":
							var newItem_dietPreference = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_dietPreference, reader, outcome, locationPath + ".dietPreference["+result.DietPreference.Count+"]"); // 80
							result.DietPreference.Add(newItem_dietPreference);
							break;
						case "specialCourtesy":
							var newItem_specialCourtesy = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialCourtesy, reader, outcome, locationPath + ".specialCourtesy["+result.SpecialCourtesy.Count+"]"); // 90
							result.SpecialCourtesy.Add(newItem_specialCourtesy);
							break;
						case "specialArrangement":
							var newItem_specialArrangement = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialArrangement, reader, outcome, locationPath + ".specialArrangement["+result.SpecialArrangement.Count+"]"); // 100
							result.SpecialArrangement.Add(newItem_specialArrangement);
							break;
						case "destination":
							result.Destination = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Destination as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".destination"); // 110
							break;
						case "dischargeDisposition":
							result.DischargeDisposition = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DischargeDisposition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".dischargeDisposition"); // 120
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
