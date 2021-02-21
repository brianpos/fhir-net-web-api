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
		public void Parse(Hl7.Fhir.Model.ExampleScenario.InstanceComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "resourceId":
							result.ResourceIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ResourceIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "resourceType":
							result.ResourceTypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							Parse(result.ResourceTypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>, reader, outcome); // 50
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 70
							break;
						case "version":
							var newItem_version = new Hl7.Fhir.Model.ExampleScenario.VersionComponent();
							Parse(newItem_version, reader, outcome); // 80
							result.Version.Add(newItem_version);
							break;
						case "containedInstance":
							var newItem_containedInstance = new Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent();
							Parse(newItem_containedInstance, reader, outcome); // 90
							result.ContainedInstance.Add(newItem_containedInstance);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ExampleScenario.InstanceComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "resourceId":
							result.ResourceIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ResourceIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "resourceType":
							result.ResourceTypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							await ParseAsync(result.ResourceTypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>, reader, outcome); // 50
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome); // 70
							break;
						case "version":
							var newItem_version = new Hl7.Fhir.Model.ExampleScenario.VersionComponent();
							await ParseAsync(newItem_version, reader, outcome); // 80
							result.Version.Add(newItem_version);
							break;
						case "containedInstance":
							var newItem_containedInstance = new Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent();
							await ParseAsync(newItem_containedInstance, reader, outcome); // 90
							result.ContainedInstance.Add(newItem_containedInstance);
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
