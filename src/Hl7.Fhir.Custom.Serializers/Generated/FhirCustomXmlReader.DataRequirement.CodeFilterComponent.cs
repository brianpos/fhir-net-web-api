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
		public void Parse(Hl7.Fhir.Model.DataRequirement.CodeFilterComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "path":
							result.PathElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "searchParam":
							result.SearchParamElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SearchParamElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "valueSet":
							result.ValueSetElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 60
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							Parse(newItem_code, reader, outcome); // 70
							result.Code.Add(newItem_code);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.DataRequirement.CodeFilterComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "path":
							result.PathElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "searchParam":
							result.SearchParamElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SearchParamElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "valueSet":
							result.ValueSetElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome); // 60
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_code, reader, outcome); // 70
							result.Code.Add(newItem_code);
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
