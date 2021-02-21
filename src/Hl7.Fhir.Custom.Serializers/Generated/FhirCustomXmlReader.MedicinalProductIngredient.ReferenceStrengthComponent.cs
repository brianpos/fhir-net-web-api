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
		public void Parse(Hl7.Fhir.Model.MedicinalProductIngredient.ReferenceStrengthComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "substance":
							result.Substance = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Substance as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substance"); // 40
							break;
						case "strength":
							result.Strength = new Hl7.Fhir.Model.Ratio();
							Parse(result.Strength as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".strength"); // 50
							break;
						case "strengthLowLimit":
							result.StrengthLowLimit = new Hl7.Fhir.Model.Ratio();
							Parse(result.StrengthLowLimit as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".strengthLowLimit"); // 60
							break;
						case "measurementPoint":
							result.MeasurementPointElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MeasurementPointElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".measurementPoint"); // 70
							break;
						case "country":
							var newItem_country = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_country, reader, outcome, locationPath + ".country["+result.Country.Count+"]"); // 80
							result.Country.Add(newItem_country);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicinalProductIngredient.ReferenceStrengthComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "substance":
							result.Substance = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Substance as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substance"); // 40
							break;
						case "strength":
							result.Strength = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Strength as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".strength"); // 50
							break;
						case "strengthLowLimit":
							result.StrengthLowLimit = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.StrengthLowLimit as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".strengthLowLimit"); // 60
							break;
						case "measurementPoint":
							result.MeasurementPointElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MeasurementPointElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".measurementPoint"); // 70
							break;
						case "country":
							var newItem_country = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_country, reader, outcome, locationPath + ".country["+result.Country.Count+"]"); // 80
							result.Country.Add(newItem_country);
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
