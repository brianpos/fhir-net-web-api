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
		public void Parse(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "kingdom":
							result.Kingdom = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Kingdom as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".kingdom"); // 40
							break;
						case "phylum":
							result.Phylum = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Phylum as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".phylum"); // 50
							break;
						case "class":
							result.Class = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Class as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".class"); // 60
							break;
						case "order":
							result.Order = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Order as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".order"); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "kingdom":
							result.Kingdom = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Kingdom as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".kingdom"); // 40
							break;
						case "phylum":
							result.Phylum = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Phylum as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".phylum"); // 50
							break;
						case "class":
							result.Class = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Class as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".class"); // 60
							break;
						case "order":
							result.Order = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Order as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".order"); // 70
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
