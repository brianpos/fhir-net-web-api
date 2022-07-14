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
		private void Parse(SubscriptionStatus result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 90
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType>, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "eventsSinceSubscriptionStart":
							result.EventsSinceSubscriptionStartElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.EventsSinceSubscriptionStartElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".eventsSinceSubscriptionStart", cancellationToken); // 110
							break;
						case "notificationEvent":
							var newItem_notificationEvent = new Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent();
							Parse(newItem_notificationEvent, reader, outcome, locationPath + ".notificationEvent["+result.NotificationEvent.Count+"]", cancellationToken); // 120
							result.NotificationEvent.Add(newItem_notificationEvent);
							break;
						case "subscription":
							result.Subscription = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subscription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subscription", cancellationToken); // 130
							break;
						case "topic":
							result.TopicElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.TopicElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".topic", cancellationToken); // 140
							break;
						case "error":
							var newItem_error = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_error, reader, outcome, locationPath + ".error["+result.Error.Count+"]", cancellationToken); // 150
							result.Error.Add(newItem_error);
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

		private async System.Threading.Tasks.Task ParseAsync(SubscriptionStatus result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 90
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType>, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "eventsSinceSubscriptionStart":
							result.EventsSinceSubscriptionStartElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.EventsSinceSubscriptionStartElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".eventsSinceSubscriptionStart", cancellationToken); // 110
							break;
						case "notificationEvent":
							var newItem_notificationEvent = new Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent();
							await ParseAsync(newItem_notificationEvent, reader, outcome, locationPath + ".notificationEvent["+result.NotificationEvent.Count+"]", cancellationToken); // 120
							result.NotificationEvent.Add(newItem_notificationEvent);
							break;
						case "subscription":
							result.Subscription = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subscription as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subscription", cancellationToken); // 130
							break;
						case "topic":
							result.TopicElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.TopicElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".topic", cancellationToken); // 140
							break;
						case "error":
							var newItem_error = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_error, reader, outcome, locationPath + ".error["+result.Error.Count+"]", cancellationToken); // 150
							result.Error.Add(newItem_error);
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
