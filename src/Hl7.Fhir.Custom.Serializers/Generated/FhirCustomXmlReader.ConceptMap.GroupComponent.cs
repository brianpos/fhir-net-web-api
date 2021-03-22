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
		public void Parse(Hl7.Fhir.Model.ConceptMap.GroupComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.SourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".source", cancellationToken); // 40
							break;
						case "sourceVersion":
							result.SourceVersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SourceVersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sourceVersion", cancellationToken); // 50
							break;
						case "target":
							result.TargetElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.TargetElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".target", cancellationToken); // 60
							break;
						case "targetVersion":
							result.TargetVersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TargetVersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".targetVersion", cancellationToken); // 70
							break;
						case "element":
							var newItem_element = new Hl7.Fhir.Model.ConceptMap.SourceElementComponent();
							Parse(newItem_element, reader, outcome, locationPath + ".element["+result.Element.Count+"]", cancellationToken); // 80
							result.Element.Add(newItem_element);
							break;
						case "unmapped":
							result.Unmapped = new Hl7.Fhir.Model.ConceptMap.UnmappedComponent();
							Parse(result.Unmapped as Hl7.Fhir.Model.ConceptMap.UnmappedComponent, reader, outcome, locationPath + ".unmapped", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ConceptMap.GroupComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.SourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".source", cancellationToken); // 40
							break;
						case "sourceVersion":
							result.SourceVersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SourceVersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sourceVersion", cancellationToken); // 50
							break;
						case "target":
							result.TargetElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.TargetElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".target", cancellationToken); // 60
							break;
						case "targetVersion":
							result.TargetVersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TargetVersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".targetVersion", cancellationToken); // 70
							break;
						case "element":
							var newItem_element = new Hl7.Fhir.Model.ConceptMap.SourceElementComponent();
							await ParseAsync(newItem_element, reader, outcome, locationPath + ".element["+result.Element.Count+"]", cancellationToken); // 80
							result.Element.Add(newItem_element);
							break;
						case "unmapped":
							result.Unmapped = new Hl7.Fhir.Model.ConceptMap.UnmappedComponent();
							await ParseAsync(result.Unmapped as Hl7.Fhir.Model.ConceptMap.UnmappedComponent, reader, outcome, locationPath + ".unmapped", cancellationToken); // 90
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
