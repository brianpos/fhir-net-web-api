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
		public void Parse(Hl7.Fhir.Model.ImplementationGuide.ManifestComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "rendering":
							result.RenderingElement = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.RenderingElement as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".rendering", cancellationToken); // 40
							break;
						case "resource":
							var newItem_resource = new Hl7.Fhir.Model.ImplementationGuide.ManifestResourceComponent();
							Parse(newItem_resource, reader, outcome, locationPath + ".resource["+result.Resource.Count+"]", cancellationToken); // 50
							result.Resource.Add(newItem_resource);
							break;
						case "page":
							var newItem_page = new Hl7.Fhir.Model.ImplementationGuide.ManifestPageComponent();
							Parse(newItem_page, reader, outcome, locationPath + ".page["+result.Page.Count+"]", cancellationToken); // 60
							result.Page.Add(newItem_page);
							break;
						case "image":
							var newItem_image = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_image, reader, outcome, locationPath + ".image["+result.ImageElement.Count+"]", cancellationToken); // 70
							result.ImageElement.Add(newItem_image);
							break;
						case "other":
							var newItem_other = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_other, reader, outcome, locationPath + ".other["+result.OtherElement.Count+"]", cancellationToken); // 80
							result.OtherElement.Add(newItem_other);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ImplementationGuide.ManifestComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "rendering":
							result.RenderingElement = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.RenderingElement as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".rendering", cancellationToken); // 40
							break;
						case "resource":
							var newItem_resource = new Hl7.Fhir.Model.ImplementationGuide.ManifestResourceComponent();
							await ParseAsync(newItem_resource, reader, outcome, locationPath + ".resource["+result.Resource.Count+"]", cancellationToken); // 50
							result.Resource.Add(newItem_resource);
							break;
						case "page":
							var newItem_page = new Hl7.Fhir.Model.ImplementationGuide.ManifestPageComponent();
							await ParseAsync(newItem_page, reader, outcome, locationPath + ".page["+result.Page.Count+"]", cancellationToken); // 60
							result.Page.Add(newItem_page);
							break;
						case "image":
							var newItem_image = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_image, reader, outcome, locationPath + ".image["+result.ImageElement.Count+"]", cancellationToken); // 70
							result.ImageElement.Add(newItem_image);
							break;
						case "other":
							var newItem_other = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_other, reader, outcome, locationPath + ".other["+result.OtherElement.Count+"]", cancellationToken); // 80
							result.OtherElement.Add(newItem_other);
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
