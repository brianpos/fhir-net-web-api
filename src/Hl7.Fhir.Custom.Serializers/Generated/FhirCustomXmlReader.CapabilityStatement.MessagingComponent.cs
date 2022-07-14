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
		public void Parse(Hl7.Fhir.Model.CapabilityStatement.MessagingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.CapabilityStatement.EndpointComponent();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 40
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "reliableCache":
							result.ReliableCacheElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.ReliableCacheElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".reliableCache", cancellationToken); // 50
							break;
						case "documentation":
							result.Documentation = new Hl7.Fhir.Model.Markdown();
							Parse(result.Documentation as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".documentation", cancellationToken); // 60
							break;
						case "supportedMessage":
							var newItem_supportedMessage = new Hl7.Fhir.Model.CapabilityStatement.SupportedMessageComponent();
							Parse(newItem_supportedMessage, reader, outcome, locationPath + ".supportedMessage["+result.SupportedMessage.Count+"]", cancellationToken); // 70
							result.SupportedMessage.Add(newItem_supportedMessage);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CapabilityStatement.MessagingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.CapabilityStatement.EndpointComponent();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 40
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "reliableCache":
							result.ReliableCacheElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.ReliableCacheElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".reliableCache", cancellationToken); // 50
							break;
						case "documentation":
							result.Documentation = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Documentation as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".documentation", cancellationToken); // 60
							break;
						case "supportedMessage":
							var newItem_supportedMessage = new Hl7.Fhir.Model.CapabilityStatement.SupportedMessageComponent();
							await ParseAsync(newItem_supportedMessage, reader, outcome, locationPath + ".supportedMessage["+result.SupportedMessage.Count+"]", cancellationToken); // 70
							result.SupportedMessage.Add(newItem_supportedMessage);
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
