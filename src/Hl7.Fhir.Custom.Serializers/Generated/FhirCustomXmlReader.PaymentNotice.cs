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
		private void Parse(PaymentNotice result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 110
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Response as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".response"); // 120
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 130
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".provider"); // 140
							break;
						case "payment":
							result.Payment = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Payment as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".payment"); // 150
							break;
						case "paymentDate":
							result.PaymentDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.PaymentDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".paymentDate"); // 160
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Payee as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".payee"); // 170
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recipient"); // 180
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.Money();
							Parse(result.Amount as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".amount"); // 190
							break;
						case "paymentStatus":
							result.PaymentStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PaymentStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".paymentStatus"); // 200
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

		private async System.Threading.Tasks.Task ParseAsync(PaymentNotice result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 110
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Response as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".response"); // 120
							break;
						case "created":
							result.CreatedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.CreatedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 130
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".provider"); // 140
							break;
						case "payment":
							result.Payment = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Payment as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".payment"); // 150
							break;
						case "paymentDate":
							result.PaymentDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.PaymentDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".paymentDate"); // 160
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Payee as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".payee"); // 170
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recipient"); // 180
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".amount"); // 190
							break;
						case "paymentStatus":
							result.PaymentStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PaymentStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".paymentStatus"); // 200
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
