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
		private void Parse(MessageHeader result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "eventCoding":
							result.Event = new Hl7.Fhir.Model.Coding();
							Parse(result.Event as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".event"); // 90
							break;
						case "eventUri":
							result.Event = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Event as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".event"); // 90
							break;
						case "destination":
							var newItem_destination = new Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent();
							Parse(newItem_destination, reader, outcome, locationPath + ".destination["+result.Destination.Count+"]"); // 100
							result.Destination.Add(newItem_destination);
							break;
						case "sender":
							result.Sender = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Sender as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".sender"); // 110
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".enterer"); // 120
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".author"); // 130
							break;
						case "source":
							result.Source = new Hl7.Fhir.Model.MessageHeader.MessageSourceComponent();
							Parse(result.Source as Hl7.Fhir.Model.MessageHeader.MessageSourceComponent, reader, outcome, locationPath + ".source"); // 140
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".responsible"); // 150
							break;
						case "reason":
							result.Reason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Reason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".reason"); // 160
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.MessageHeader.ResponseComponent();
							Parse(result.Response as Hl7.Fhir.Model.MessageHeader.ResponseComponent, reader, outcome, locationPath + ".response"); // 170
							break;
						case "focus":
							var newItem_focus = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_focus, reader, outcome, locationPath + ".focus["+result.Focus.Count+"]"); // 180
							result.Focus.Add(newItem_focus);
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.DefinitionElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".definition"); // 190
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(MessageHeader result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "eventCoding":
							result.Event = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Event as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".event"); // 90
							break;
						case "eventUri":
							result.Event = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Event as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".event"); // 90
							break;
						case "destination":
							var newItem_destination = new Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent();
							await ParseAsync(newItem_destination, reader, outcome, locationPath + ".destination["+result.Destination.Count+"]"); // 100
							result.Destination.Add(newItem_destination);
							break;
						case "sender":
							result.Sender = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Sender as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".sender"); // 110
							break;
						case "enterer":
							result.Enterer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Enterer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".enterer"); // 120
							break;
						case "author":
							result.Author = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Author as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".author"); // 130
							break;
						case "source":
							result.Source = new Hl7.Fhir.Model.MessageHeader.MessageSourceComponent();
							await ParseAsync(result.Source as Hl7.Fhir.Model.MessageHeader.MessageSourceComponent, reader, outcome, locationPath + ".source"); // 140
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".responsible"); // 150
							break;
						case "reason":
							result.Reason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Reason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".reason"); // 160
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.MessageHeader.ResponseComponent();
							await ParseAsync(result.Response as Hl7.Fhir.Model.MessageHeader.ResponseComponent, reader, outcome, locationPath + ".response"); // 170
							break;
						case "focus":
							var newItem_focus = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_focus, reader, outcome, locationPath + ".focus["+result.Focus.Count+"]"); // 180
							result.Focus.Add(newItem_focus);
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.DefinitionElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".definition"); // 190
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
