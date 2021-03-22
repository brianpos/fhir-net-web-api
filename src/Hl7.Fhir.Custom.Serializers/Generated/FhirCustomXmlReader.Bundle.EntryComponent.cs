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
		public void Parse(Hl7.Fhir.Model.Bundle.EntryComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "link":
							var newItem_link = new Hl7.Fhir.Model.Bundle.LinkComponent();
							Parse(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]", cancellationToken); // 40
							result.Link.Add(newItem_link);
							break;
						case "fullUrl":
							result.FullUrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.FullUrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".fullUrl", cancellationToken); // 50
							break;
						case "resource":
							// FirstChildOf(reader); // 60
							var ResourceResource = Parse(reader, outcome, locationPath + ".resource", cancellationToken);
							result.Resource = ResourceResource;
							if (!reader.Read()) return;
							break;
						case "search":
							result.Search = new Hl7.Fhir.Model.Bundle.SearchComponent();
							Parse(result.Search as Hl7.Fhir.Model.Bundle.SearchComponent, reader, outcome, locationPath + ".search", cancellationToken); // 70
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.Bundle.RequestComponent();
							Parse(result.Request as Hl7.Fhir.Model.Bundle.RequestComponent, reader, outcome, locationPath + ".request", cancellationToken); // 80
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.Bundle.ResponseComponent();
							Parse(result.Response as Hl7.Fhir.Model.Bundle.ResponseComponent, reader, outcome, locationPath + ".response", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Bundle.EntryComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "link":
							var newItem_link = new Hl7.Fhir.Model.Bundle.LinkComponent();
							await ParseAsync(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]", cancellationToken); // 40
							result.Link.Add(newItem_link);
							break;
						case "fullUrl":
							result.FullUrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.FullUrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".fullUrl", cancellationToken); // 50
							break;
						case "resource":
							// FirstChildOf(reader); // 60
							var ResourceResource = await ParseAsync(reader, outcome, locationPath + ".resource", cancellationToken);
							result.Resource = ResourceResource;
							if (!reader.Read()) return;
							break;
						case "search":
							result.Search = new Hl7.Fhir.Model.Bundle.SearchComponent();
							await ParseAsync(result.Search as Hl7.Fhir.Model.Bundle.SearchComponent, reader, outcome, locationPath + ".search", cancellationToken); // 70
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.Bundle.RequestComponent();
							await ParseAsync(result.Request as Hl7.Fhir.Model.Bundle.RequestComponent, reader, outcome, locationPath + ".request", cancellationToken); // 80
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.Bundle.ResponseComponent();
							await ParseAsync(result.Response as Hl7.Fhir.Model.Bundle.ResponseComponent, reader, outcome, locationPath + ".response", cancellationToken); // 90
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
