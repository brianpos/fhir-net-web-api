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
		public void Parse(Hl7.Fhir.Model.TestScript.CapabilityComponent result, XmlReader reader, OperationOutcome outcome)
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
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "required":
							result.RequiredElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.RequiredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 40
							break;
						case "validated":
							result.ValidatedElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ValidatedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "origin":
							var newItem_origin = new Hl7.Fhir.Model.Integer();
							Parse(newItem_origin, reader, outcome); // 70
							result.OriginElement.Add(newItem_origin);
							break;
						case "destination":
							result.DestinationElement = new Hl7.Fhir.Model.Integer();
							Parse(result.DestinationElement as Hl7.Fhir.Model.Integer, reader, outcome); // 80
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_link, reader, outcome); // 90
							result.LinkElement.Add(newItem_link);
							break;
						case "capabilities":
							result.CapabilitiesElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.CapabilitiesElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 100
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.TestScript.CapabilityComponent result, XmlReader reader, OperationOutcome outcome)
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
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "required":
							result.RequiredElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.RequiredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 40
							break;
						case "validated":
							result.ValidatedElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ValidatedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "origin":
							var newItem_origin = new Hl7.Fhir.Model.Integer();
							await ParseAsync(newItem_origin, reader, outcome); // 70
							result.OriginElement.Add(newItem_origin);
							break;
						case "destination":
							result.DestinationElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.DestinationElement as Hl7.Fhir.Model.Integer, reader, outcome); // 80
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_link, reader, outcome); // 90
							result.LinkElement.Add(newItem_link);
							break;
						case "capabilities":
							result.CapabilitiesElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.CapabilitiesElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 100
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
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
