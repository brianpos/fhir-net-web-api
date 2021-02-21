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
		private void Parse(Subscription result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			if (reader.IsEmptyElement)
				return;

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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>, reader, outcome, locationPath + ".status"); // 90
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]"); // 100
							result.Contact.Add(newItem_contact);
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Instant();
							Parse(result.EndElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".end"); // 110
							break;
						case "reason":
							result.ReasonElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".reason"); // 120
							break;
						case "criteria":
							result.CriteriaElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CriteriaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".criteria"); // 130
							break;
						case "error":
							result.ErrorElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ErrorElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".error"); // 140
							break;
						case "channel":
							result.Channel = new Hl7.Fhir.Model.Subscription.ChannelComponent();
							Parse(result.Channel as Hl7.Fhir.Model.Subscription.ChannelComponent, reader, outcome, locationPath + ".channel"); // 150
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

		private async System.Threading.Tasks.Task ParseAsync(Subscription result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			if (reader.IsEmptyElement)
				return;

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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>, reader, outcome, locationPath + ".status"); // 90
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]"); // 100
							result.Contact.Add(newItem_contact);
							break;
						case "end":
							result.EndElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.EndElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".end"); // 110
							break;
						case "reason":
							result.ReasonElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".reason"); // 120
							break;
						case "criteria":
							result.CriteriaElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CriteriaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".criteria"); // 130
							break;
						case "error":
							result.ErrorElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ErrorElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".error"); // 140
							break;
						case "channel":
							result.Channel = new Hl7.Fhir.Model.Subscription.ChannelComponent();
							await ParseAsync(result.Channel as Hl7.Fhir.Model.Subscription.ChannelComponent, reader, outcome, locationPath + ".channel"); // 150
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
