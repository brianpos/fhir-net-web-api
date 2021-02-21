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
		public void Parse(Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 40
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 50
							break;
						case "parameters":
							result.ParametersElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ParametersElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".parameters"); // 60
							break;
						case "definingSubstanceReference":
							result.DefiningSubstance = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.DefiningSubstance as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".definingSubstance"); // 70
							break;
						case "definingSubstanceCodeableConcept":
							result.DefiningSubstance = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DefiningSubstance as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".definingSubstance"); // 70
							break;
						case "amountQuantity":
							result.Amount = new Hl7.Fhir.Model.Quantity();
							Parse(result.Amount as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".amount"); // 80
							break;
						case "amountString":
							result.Amount = new Hl7.Fhir.Model.FhirString();
							Parse(result.Amount as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amount"); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 40
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 50
							break;
						case "parameters":
							result.ParametersElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ParametersElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".parameters"); // 60
							break;
						case "definingSubstanceReference":
							result.DefiningSubstance = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.DefiningSubstance as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".definingSubstance"); // 70
							break;
						case "definingSubstanceCodeableConcept":
							result.DefiningSubstance = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DefiningSubstance as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".definingSubstance"); // 70
							break;
						case "amountQuantity":
							result.Amount = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".amount"); // 80
							break;
						case "amountString":
							result.Amount = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".amount"); // 80
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
