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
		public void Parse(Hl7.Fhir.Model.GraphDefinition.TargetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>, reader, outcome, locationPath + ".type"); // 40
							break;
						case "params":
							result.ParamsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ParamsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".params"); // 50
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile"); // 60
							break;
						case "compartment":
							var newItem_compartment = new Hl7.Fhir.Model.GraphDefinition.CompartmentComponent();
							Parse(newItem_compartment, reader, outcome, locationPath + ".compartment["+result.Compartment.Count+"]"); // 70
							result.Compartment.Add(newItem_compartment);
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.GraphDefinition.LinkComponent();
							Parse(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]"); // 80
							result.Link.Add(newItem_link);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.GraphDefinition.TargetComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>, reader, outcome, locationPath + ".type"); // 40
							break;
						case "params":
							result.ParamsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ParamsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".params"); // 50
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile"); // 60
							break;
						case "compartment":
							var newItem_compartment = new Hl7.Fhir.Model.GraphDefinition.CompartmentComponent();
							await ParseAsync(newItem_compartment, reader, outcome, locationPath + ".compartment["+result.Compartment.Count+"]"); // 70
							result.Compartment.Add(newItem_compartment);
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.GraphDefinition.LinkComponent();
							await ParseAsync(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]"); // 80
							result.Link.Add(newItem_link);
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
