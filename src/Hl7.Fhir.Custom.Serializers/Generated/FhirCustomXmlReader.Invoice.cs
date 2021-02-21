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
		private void Parse(Invoice result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Invoice.InvoiceStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Invoice.InvoiceStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "cancelledReason":
							result.CancelledReasonElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CancelledReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".cancelledReason"); // 110
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recipient"); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 150
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.Invoice.ParticipantComponent();
							Parse(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]"); // 160
							result.Participant.Add(newItem_participant);
							break;
						case "issuer":
							result.Issuer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Issuer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".issuer"); // 170
							break;
						case "account":
							result.Account = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Account as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".account"); // 180
							break;
						case "lineItem":
							var newItem_lineItem = new Hl7.Fhir.Model.Invoice.LineItemComponent();
							Parse(newItem_lineItem, reader, outcome, locationPath + ".lineItem["+result.LineItem.Count+"]"); // 190
							result.LineItem.Add(newItem_lineItem);
							break;
						case "totalPriceComponent":
							var newItem_totalPriceComponent = new Hl7.Fhir.Model.Invoice.PriceComponentComponent();
							Parse(newItem_totalPriceComponent, reader, outcome, locationPath + ".totalPriceComponent["+result.TotalPriceComponent.Count+"]"); // 200
							result.TotalPriceComponent.Add(newItem_totalPriceComponent);
							break;
						case "totalNet":
							result.TotalNet = new Hl7.Fhir.Model.Money();
							Parse(result.TotalNet as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".totalNet"); // 210
							break;
						case "totalGross":
							result.TotalGross = new Hl7.Fhir.Model.Money();
							Parse(result.TotalGross as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".totalGross"); // 220
							break;
						case "paymentTerms":
							result.PaymentTerms = new Hl7.Fhir.Model.Markdown();
							Parse(result.PaymentTerms as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".paymentTerms"); // 230
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 240
							result.Note.Add(newItem_note);
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

		private async System.Threading.Tasks.Task ParseAsync(Invoice result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Invoice.InvoiceStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Invoice.InvoiceStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "cancelledReason":
							result.CancelledReasonElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CancelledReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".cancelledReason"); // 110
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recipient"); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 150
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.Invoice.ParticipantComponent();
							await ParseAsync(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]"); // 160
							result.Participant.Add(newItem_participant);
							break;
						case "issuer":
							result.Issuer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Issuer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".issuer"); // 170
							break;
						case "account":
							result.Account = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Account as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".account"); // 180
							break;
						case "lineItem":
							var newItem_lineItem = new Hl7.Fhir.Model.Invoice.LineItemComponent();
							await ParseAsync(newItem_lineItem, reader, outcome, locationPath + ".lineItem["+result.LineItem.Count+"]"); // 190
							result.LineItem.Add(newItem_lineItem);
							break;
						case "totalPriceComponent":
							var newItem_totalPriceComponent = new Hl7.Fhir.Model.Invoice.PriceComponentComponent();
							await ParseAsync(newItem_totalPriceComponent, reader, outcome, locationPath + ".totalPriceComponent["+result.TotalPriceComponent.Count+"]"); // 200
							result.TotalPriceComponent.Add(newItem_totalPriceComponent);
							break;
						case "totalNet":
							result.TotalNet = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.TotalNet as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".totalNet"); // 210
							break;
						case "totalGross":
							result.TotalGross = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.TotalGross as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".totalGross"); // 220
							break;
						case "paymentTerms":
							result.PaymentTerms = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.PaymentTerms as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".paymentTerms"); // 230
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 240
							result.Note.Add(newItem_note);
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
