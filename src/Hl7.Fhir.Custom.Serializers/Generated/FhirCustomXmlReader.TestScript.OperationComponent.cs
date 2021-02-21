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
		public void Parse(Hl7.Fhir.Model.TestScript.OperationComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.Coding();
							Parse(result.Type as Hl7.Fhir.Model.Coding, reader, outcome); // 40
							break;
						case "resource":
							result.ResourceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>();
							Parse(result.ResourceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>, reader, outcome); // 50
							break;
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "accept":
							result.AcceptElement = new Hl7.Fhir.Model.Code();
							Parse(result.AcceptElement as Hl7.Fhir.Model.Code, reader, outcome); // 80
							break;
						case "contentType":
							result.ContentTypeElement = new Hl7.Fhir.Model.Code();
							Parse(result.ContentTypeElement as Hl7.Fhir.Model.Code, reader, outcome); // 90
							break;
						case "destination":
							result.DestinationElement = new Hl7.Fhir.Model.Integer();
							Parse(result.DestinationElement as Hl7.Fhir.Model.Integer, reader, outcome); // 100
							break;
						case "encodeRequestUrl":
							result.EncodeRequestUrlElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.EncodeRequestUrlElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 110
							break;
						case "method":
							result.MethodElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>();
							Parse(result.MethodElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>, reader, outcome); // 120
							break;
						case "origin":
							result.OriginElement = new Hl7.Fhir.Model.Integer();
							Parse(result.OriginElement as Hl7.Fhir.Model.Integer, reader, outcome); // 130
							break;
						case "params":
							result.ParamsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ParamsElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
							break;
						case "requestHeader":
							var newItem_requestHeader = new Hl7.Fhir.Model.TestScript.RequestHeaderComponent();
							Parse(newItem_requestHeader, reader, outcome); // 150
							result.RequestHeader.Add(newItem_requestHeader);
							break;
						case "requestId":
							result.RequestIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.RequestIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 160
							break;
						case "responseId":
							result.ResponseIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.ResponseIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 170
							break;
						case "sourceId":
							result.SourceIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.SourceIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 180
							break;
						case "targetId":
							result.TargetIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.TargetIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 190
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.TestScript.OperationComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Type as Hl7.Fhir.Model.Coding, reader, outcome); // 40
							break;
						case "resource":
							result.ResourceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>();
							await ParseAsync(result.ResourceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.FHIRDefinedType>, reader, outcome); // 50
							break;
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "accept":
							result.AcceptElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.AcceptElement as Hl7.Fhir.Model.Code, reader, outcome); // 80
							break;
						case "contentType":
							result.ContentTypeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.ContentTypeElement as Hl7.Fhir.Model.Code, reader, outcome); // 90
							break;
						case "destination":
							result.DestinationElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.DestinationElement as Hl7.Fhir.Model.Integer, reader, outcome); // 100
							break;
						case "encodeRequestUrl":
							result.EncodeRequestUrlElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.EncodeRequestUrlElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 110
							break;
						case "method":
							result.MethodElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>();
							await ParseAsync(result.MethodElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestScript.TestScriptRequestMethodCode>, reader, outcome); // 120
							break;
						case "origin":
							result.OriginElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.OriginElement as Hl7.Fhir.Model.Integer, reader, outcome); // 130
							break;
						case "params":
							result.ParamsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ParamsElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
							break;
						case "requestHeader":
							var newItem_requestHeader = new Hl7.Fhir.Model.TestScript.RequestHeaderComponent();
							await ParseAsync(newItem_requestHeader, reader, outcome); // 150
							result.RequestHeader.Add(newItem_requestHeader);
							break;
						case "requestId":
							result.RequestIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.RequestIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 160
							break;
						case "responseId":
							result.ResponseIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ResponseIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 170
							break;
						case "sourceId":
							result.SourceIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.SourceIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 180
							break;
						case "targetId":
							result.TargetIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.TargetIdElement as Hl7.Fhir.Model.Id, reader, outcome); // 190
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 200
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
