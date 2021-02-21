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
		public void Parse(Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "operationType":
							result.OperationType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OperationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".operationType"); // 40
							break;
						case "authorisationReferenceNumber":
							result.AuthorisationReferenceNumber = new Hl7.Fhir.Model.Identifier();
							Parse(result.AuthorisationReferenceNumber as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".authorisationReferenceNumber"); // 50
							break;
						case "effectiveDate":
							result.EffectiveDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.EffectiveDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effectiveDate"); // 60
							break;
						case "confidentialityIndicator":
							result.ConfidentialityIndicator = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ConfidentialityIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".confidentialityIndicator"); // 70
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]"); // 80
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "regulator":
							result.Regulator = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Regulator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".regulator"); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "operationType":
							result.OperationType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OperationType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".operationType"); // 40
							break;
						case "authorisationReferenceNumber":
							result.AuthorisationReferenceNumber = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.AuthorisationReferenceNumber as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".authorisationReferenceNumber"); // 50
							break;
						case "effectiveDate":
							result.EffectiveDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.EffectiveDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effectiveDate"); // 60
							break;
						case "confidentialityIndicator":
							result.ConfidentialityIndicator = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ConfidentialityIndicator as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".confidentialityIndicator"); // 70
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]"); // 80
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "regulator":
							result.Regulator = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Regulator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".regulator"); // 90
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
