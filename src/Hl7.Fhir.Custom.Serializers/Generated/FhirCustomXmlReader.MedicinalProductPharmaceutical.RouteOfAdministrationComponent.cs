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
		public void Parse(Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 40
							break;
						case "firstDose":
							result.FirstDose = new Hl7.Fhir.Model.Quantity();
							Parse(result.FirstDose as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".firstDose"); // 50
							break;
						case "maxSingleDose":
							result.MaxSingleDose = new Hl7.Fhir.Model.Quantity();
							Parse(result.MaxSingleDose as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".maxSingleDose"); // 60
							break;
						case "maxDosePerDay":
							result.MaxDosePerDay = new Hl7.Fhir.Model.Quantity();
							Parse(result.MaxDosePerDay as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".maxDosePerDay"); // 70
							break;
						case "maxDosePerTreatmentPeriod":
							result.MaxDosePerTreatmentPeriod = new Hl7.Fhir.Model.Ratio();
							Parse(result.MaxDosePerTreatmentPeriod as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".maxDosePerTreatmentPeriod"); // 80
							break;
						case "maxTreatmentPeriod":
							result.MaxTreatmentPeriod = new Hl7.Fhir.Model.Duration();
							Parse(result.MaxTreatmentPeriod as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".maxTreatmentPeriod"); // 90
							break;
						case "targetSpecies":
							var newItem_targetSpecies = new Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent();
							Parse(newItem_targetSpecies, reader, outcome, locationPath + ".targetSpecies["+result.TargetSpecies.Count+"]"); // 100
							result.TargetSpecies.Add(newItem_targetSpecies);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 40
							break;
						case "firstDose":
							result.FirstDose = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.FirstDose as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".firstDose"); // 50
							break;
						case "maxSingleDose":
							result.MaxSingleDose = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.MaxSingleDose as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".maxSingleDose"); // 60
							break;
						case "maxDosePerDay":
							result.MaxDosePerDay = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.MaxDosePerDay as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".maxDosePerDay"); // 70
							break;
						case "maxDosePerTreatmentPeriod":
							result.MaxDosePerTreatmentPeriod = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.MaxDosePerTreatmentPeriod as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".maxDosePerTreatmentPeriod"); // 80
							break;
						case "maxTreatmentPeriod":
							result.MaxTreatmentPeriod = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.MaxTreatmentPeriod as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".maxTreatmentPeriod"); // 90
							break;
						case "targetSpecies":
							var newItem_targetSpecies = new Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent();
							await ParseAsync(newItem_targetSpecies, reader, outcome, locationPath + ".targetSpecies["+result.TargetSpecies.Count+"]"); // 100
							result.TargetSpecies.Add(newItem_targetSpecies);
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
