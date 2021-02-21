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
		public void Parse(Hl7.Fhir.Model.StructureMap.TargetComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "context":
							result.ContextElement = new Hl7.Fhir.Model.Id();
							Parse(result.ContextElement as Hl7.Fhir.Model.Id, reader, outcome); // 40
							break;
						case "contextType":
							result.ContextTypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapContextType>();
							Parse(result.ContextTypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapContextType>, reader, outcome); // 50
							break;
						case "element":
							result.ElementElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ElementElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "variable":
							result.VariableElement = new Hl7.Fhir.Model.Id();
							Parse(result.VariableElement as Hl7.Fhir.Model.Id, reader, outcome); // 70
							break;
						case "listMode":
							var newItem_listMode = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapTargetListMode>();
							Parse(newItem_listMode, reader, outcome); // 80
							result.ListModeElement.Add(newItem_listMode);
							break;
						case "listRuleId":
							result.ListRuleIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.ListRuleIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 90
							break;
						case "transform":
							result.TransformElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapTransform>();
							Parse(result.TransformElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapTransform>, reader, outcome); // 100
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.StructureMap.ParameterComponent();
							Parse(newItem_parameter, reader, outcome); // 110
							result.Parameter.Add(newItem_parameter);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.StructureMap.TargetComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "context":
							result.ContextElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ContextElement as Hl7.Fhir.Model.Id, reader, outcome); // 40
							break;
						case "contextType":
							result.ContextTypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapContextType>();
							await ParseAsync(result.ContextTypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapContextType>, reader, outcome); // 50
							break;
						case "element":
							result.ElementElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ElementElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "variable":
							result.VariableElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.VariableElement as Hl7.Fhir.Model.Id, reader, outcome); // 70
							break;
						case "listMode":
							var newItem_listMode = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapTargetListMode>();
							await ParseAsync(newItem_listMode, reader, outcome); // 80
							result.ListModeElement.Add(newItem_listMode);
							break;
						case "listRuleId":
							result.ListRuleIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ListRuleIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 90
							break;
						case "transform":
							result.TransformElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapTransform>();
							await ParseAsync(result.TransformElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapTransform>, reader, outcome); // 100
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.StructureMap.ParameterComponent();
							await ParseAsync(newItem_parameter, reader, outcome); // 110
							result.Parameter.Add(newItem_parameter);
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
