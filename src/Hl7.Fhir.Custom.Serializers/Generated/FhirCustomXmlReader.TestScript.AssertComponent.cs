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
		public void Parse(Hl7.Fhir.Model.TestScript.AssertComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "direction":
							result.DirectionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType>();
							Parse(result.DirectionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType>, reader, outcome); // 60
							break;
						case "compareToSourceId":
							result.CompareToSourceIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CompareToSourceIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "compareToSourceExpression":
							result.CompareToSourceExpressionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CompareToSourceExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 80
							break;
						case "compareToSourcePath":
							result.CompareToSourcePathElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CompareToSourcePathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "contentType":
							result.ContentTypeElement = new Hl7.Fhir.Model.Code();
							Parse(result.ContentTypeElement as Hl7.Fhir.Model.Code, reader, outcome); // 100
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "headerField":
							result.HeaderFieldElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.HeaderFieldElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "minimumId":
							result.MinimumIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MinimumIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "navigationLinks":
							result.NavigationLinksElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.NavigationLinksElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 140
							break;
						case "operator":
							result.OperatorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType>();
							Parse(result.OperatorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType>, reader, outcome); // 150
							break;
						case "path":
							result.PathElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "requestMethod":
							result.RequestMethodElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>();
							Parse(result.RequestMethodElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>, reader, outcome); // 170
							break;
						case "requestURL":
							result.RequestURLElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RequestURLElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 180
							break;
						case "resource":
							result.ResourceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>();
							Parse(result.ResourceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>, reader, outcome); // 190
							break;
						case "response":
							result.ResponseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes>();
							Parse(result.ResponseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes>, reader, outcome); // 200
							break;
						case "responseCode":
							result.ResponseCodeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ResponseCodeElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "sourceId":
							result.SourceIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.SourceIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 220
							break;
						case "validateProfileId":
							result.ValidateProfileIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.ValidateProfileIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 230
							break;
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ValueElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 240
							break;
						case "warningOnly":
							result.WarningOnlyElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.WarningOnlyElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 250
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.TestScript.AssertComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "direction":
							result.DirectionElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType>();
							await ParseAsync(result.DirectionElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType>, reader, outcome); // 60
							break;
						case "compareToSourceId":
							result.CompareToSourceIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CompareToSourceIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "compareToSourceExpression":
							result.CompareToSourceExpressionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CompareToSourceExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 80
							break;
						case "compareToSourcePath":
							result.CompareToSourcePathElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CompareToSourcePathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "contentType":
							result.ContentTypeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.ContentTypeElement as Hl7.Fhir.Model.Code, reader, outcome); // 100
							break;
						case "expression":
							result.ExpressionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ExpressionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "headerField":
							result.HeaderFieldElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.HeaderFieldElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "minimumId":
							result.MinimumIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MinimumIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "navigationLinks":
							result.NavigationLinksElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.NavigationLinksElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 140
							break;
						case "operator":
							result.OperatorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType>();
							await ParseAsync(result.OperatorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType>, reader, outcome); // 150
							break;
						case "path":
							result.PathElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "requestMethod":
							result.RequestMethodElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>();
							await ParseAsync(result.RequestMethodElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>, reader, outcome); // 170
							break;
						case "requestURL":
							result.RequestURLElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RequestURLElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 180
							break;
						case "resource":
							result.ResourceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>();
							await ParseAsync(result.ResourceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>, reader, outcome); // 190
							break;
						case "response":
							result.ResponseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes>();
							await ParseAsync(result.ResponseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes>, reader, outcome); // 200
							break;
						case "responseCode":
							result.ResponseCodeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ResponseCodeElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 210
							break;
						case "sourceId":
							result.SourceIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.SourceIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 220
							break;
						case "validateProfileId":
							result.ValidateProfileIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ValidateProfileIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 230
							break;
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ValueElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 240
							break;
						case "warningOnly":
							result.WarningOnlyElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.WarningOnlyElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 250
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
