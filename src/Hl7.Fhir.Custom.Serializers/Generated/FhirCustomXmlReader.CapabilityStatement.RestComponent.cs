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
		public void Parse(Hl7.Fhir.Model.CapabilityStatement.RestComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.RestfulCapabilityMode>();
							Parse(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.RestfulCapabilityMode>, reader, outcome, locationPath + ".mode"); // 40
							break;
						case "documentation":
							result.Documentation = new Hl7.Fhir.Model.Markdown();
							Parse(result.Documentation as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".documentation"); // 50
							break;
						case "security":
							result.Security = new Hl7.Fhir.Model.CapabilityStatement.SecurityComponent();
							Parse(result.Security as Hl7.Fhir.Model.CapabilityStatement.SecurityComponent, reader, outcome, locationPath + ".security"); // 60
							break;
						case "resource":
							var newItem_resource = new Hl7.Fhir.Model.CapabilityStatement.ResourceComponent();
							Parse(newItem_resource, reader, outcome, locationPath + ".resource["+result.Resource.Count+"]"); // 70
							result.Resource.Add(newItem_resource);
							break;
						case "interaction":
							var newItem_interaction = new Hl7.Fhir.Model.CapabilityStatement.SystemInteractionComponent();
							Parse(newItem_interaction, reader, outcome, locationPath + ".interaction["+result.Interaction.Count+"]"); // 80
							result.Interaction.Add(newItem_interaction);
							break;
						case "searchParam":
							var newItem_searchParam = new Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent();
							Parse(newItem_searchParam, reader, outcome, locationPath + ".searchParam["+result.SearchParam.Count+"]"); // 90
							result.SearchParam.Add(newItem_searchParam);
							break;
						case "operation":
							var newItem_operation = new Hl7.Fhir.Model.CapabilityStatement.OperationComponent();
							Parse(newItem_operation, reader, outcome, locationPath + ".operation["+result.Operation.Count+"]"); // 100
							result.Operation.Add(newItem_operation);
							break;
						case "compartment":
							var newItem_compartment = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_compartment, reader, outcome, locationPath + ".compartment["+result.CompartmentElement.Count+"]"); // 110
							result.CompartmentElement.Add(newItem_compartment);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CapabilityStatement.RestComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.RestfulCapabilityMode>();
							await ParseAsync(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.RestfulCapabilityMode>, reader, outcome, locationPath + ".mode"); // 40
							break;
						case "documentation":
							result.Documentation = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Documentation as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".documentation"); // 50
							break;
						case "security":
							result.Security = new Hl7.Fhir.Model.CapabilityStatement.SecurityComponent();
							await ParseAsync(result.Security as Hl7.Fhir.Model.CapabilityStatement.SecurityComponent, reader, outcome, locationPath + ".security"); // 60
							break;
						case "resource":
							var newItem_resource = new Hl7.Fhir.Model.CapabilityStatement.ResourceComponent();
							await ParseAsync(newItem_resource, reader, outcome, locationPath + ".resource["+result.Resource.Count+"]"); // 70
							result.Resource.Add(newItem_resource);
							break;
						case "interaction":
							var newItem_interaction = new Hl7.Fhir.Model.CapabilityStatement.SystemInteractionComponent();
							await ParseAsync(newItem_interaction, reader, outcome, locationPath + ".interaction["+result.Interaction.Count+"]"); // 80
							result.Interaction.Add(newItem_interaction);
							break;
						case "searchParam":
							var newItem_searchParam = new Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent();
							await ParseAsync(newItem_searchParam, reader, outcome, locationPath + ".searchParam["+result.SearchParam.Count+"]"); // 90
							result.SearchParam.Add(newItem_searchParam);
							break;
						case "operation":
							var newItem_operation = new Hl7.Fhir.Model.CapabilityStatement.OperationComponent();
							await ParseAsync(newItem_operation, reader, outcome, locationPath + ".operation["+result.Operation.Count+"]"); // 100
							result.Operation.Add(newItem_operation);
							break;
						case "compartment":
							var newItem_compartment = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_compartment, reader, outcome, locationPath + ".compartment["+result.CompartmentElement.Count+"]"); // 110
							result.CompartmentElement.Add(newItem_compartment);
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
