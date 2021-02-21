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
		public void Parse(Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 40
							break;
						case "allowedUnsignedInt":
							result.Allowed = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.Allowed as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".allowed"); // 50
							break;
						case "allowedString":
							result.Allowed = new Hl7.Fhir.Model.FhirString();
							Parse(result.Allowed as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".allowed"); // 50
							break;
						case "allowedMoney":
							result.Allowed = new Hl7.Fhir.Model.Money();
							Parse(result.Allowed as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".allowed"); // 50
							break;
						case "usedUnsignedInt":
							result.Used = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.Used as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".used"); // 60
							break;
						case "usedString":
							result.Used = new Hl7.Fhir.Model.FhirString();
							Parse(result.Used as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".used"); // 60
							break;
						case "usedMoney":
							result.Used = new Hl7.Fhir.Model.Money();
							Parse(result.Used as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".used"); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 40
							break;
						case "allowedUnsignedInt":
							result.Allowed = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.Allowed as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".allowed"); // 50
							break;
						case "allowedString":
							result.Allowed = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Allowed as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".allowed"); // 50
							break;
						case "allowedMoney":
							result.Allowed = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Allowed as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".allowed"); // 50
							break;
						case "usedUnsignedInt":
							result.Used = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.Used as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".used"); // 60
							break;
						case "usedString":
							result.Used = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Used as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".used"); // 60
							break;
						case "usedMoney":
							result.Used = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Used as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".used"); // 60
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
