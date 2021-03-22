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
		public void Parse(Hl7.Fhir.Model.ExampleScenario.OperationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "number":
							result.NumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".number", cancellationToken); // 40
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TypeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 60
							break;
						case "initiator":
							result.InitiatorElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.InitiatorElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".initiator", cancellationToken); // 70
							break;
						case "receiver":
							result.ReceiverElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ReceiverElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".receiver", cancellationToken); // 80
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 90
							break;
						case "initiatorActive":
							result.InitiatorActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.InitiatorActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".initiatorActive", cancellationToken); // 100
							break;
						case "receiverActive":
							result.ReceiverActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ReceiverActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".receiverActive", cancellationToken); // 110
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent();
							Parse(result.Request as Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent, reader, outcome, locationPath + ".request", cancellationToken); // 120
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent();
							Parse(result.Response as Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent, reader, outcome, locationPath + ".response", cancellationToken); // 130
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ExampleScenario.OperationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "number":
							result.NumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".number", cancellationToken); // 40
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 60
							break;
						case "initiator":
							result.InitiatorElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.InitiatorElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".initiator", cancellationToken); // 70
							break;
						case "receiver":
							result.ReceiverElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ReceiverElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".receiver", cancellationToken); // 80
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 90
							break;
						case "initiatorActive":
							result.InitiatorActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.InitiatorActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".initiatorActive", cancellationToken); // 100
							break;
						case "receiverActive":
							result.ReceiverActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ReceiverActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".receiverActive", cancellationToken); // 110
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent();
							await ParseAsync(result.Request as Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent, reader, outcome, locationPath + ".request", cancellationToken); // 120
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent();
							await ParseAsync(result.Response as Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent, reader, outcome, locationPath + ".response", cancellationToken); // 130
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
