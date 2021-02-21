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
		public void Parse(Hl7.Fhir.Model.ValueSet.ContainsComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.SystemElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 40
							break;
						case "abstract":
							result.AbstractElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AbstractElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "inactive":
							result.InactiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.InactiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 60
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome); // 80
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "designation":
							var newItem_designation = new Hl7.Fhir.Model.ValueSet.DesignationComponent();
							Parse(newItem_designation, reader, outcome); // 100
							result.Designation.Add(newItem_designation);
							break;
						case "contains":
							var newItem_contains = new Hl7.Fhir.Model.ValueSet.ContainsComponent();
							Parse(newItem_contains, reader, outcome); // 110
							result.Contains.Add(newItem_contains);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ValueSet.ContainsComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.SystemElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 40
							break;
						case "abstract":
							result.AbstractElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AbstractElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "inactive":
							result.InactiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.InactiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 60
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome); // 80
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "designation":
							var newItem_designation = new Hl7.Fhir.Model.ValueSet.DesignationComponent();
							await ParseAsync(newItem_designation, reader, outcome); // 100
							result.Designation.Add(newItem_designation);
							break;
						case "contains":
							var newItem_contains = new Hl7.Fhir.Model.ValueSet.ContainsComponent();
							await ParseAsync(newItem_contains, reader, outcome); // 110
							result.Contains.Add(newItem_contains);
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
