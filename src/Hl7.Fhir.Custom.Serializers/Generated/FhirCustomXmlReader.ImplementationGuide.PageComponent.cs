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
		public void Parse(Hl7.Fhir.Model.ImplementationGuide.PageComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "nameUrl":
							result.Name = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.Name as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".name"); // 40
							break;
						case "nameReference":
							result.Name = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Name as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".name"); // 40
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title"); // 50
							break;
						case "generation":
							result.GenerationElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageGeneration>();
							Parse(result.GenerationElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageGeneration>, reader, outcome, locationPath + ".generation"); // 60
							break;
						case "page":
							var newItem_page = new Hl7.Fhir.Model.ImplementationGuide.PageComponent();
							Parse(newItem_page, reader, outcome, locationPath + ".page["+result.Page.Count+"]"); // 70
							result.Page.Add(newItem_page);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ImplementationGuide.PageComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "nameUrl":
							result.Name = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.Name as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".name"); // 40
							break;
						case "nameReference":
							result.Name = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Name as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".name"); // 40
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title"); // 50
							break;
						case "generation":
							result.GenerationElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageGeneration>();
							await ParseAsync(result.GenerationElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageGeneration>, reader, outcome, locationPath + ".generation"); // 60
							break;
						case "page":
							var newItem_page = new Hl7.Fhir.Model.ImplementationGuide.PageComponent();
							await ParseAsync(newItem_page, reader, outcome, locationPath + ".page["+result.Page.Count+"]"); // 70
							result.Page.Add(newItem_page);
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
