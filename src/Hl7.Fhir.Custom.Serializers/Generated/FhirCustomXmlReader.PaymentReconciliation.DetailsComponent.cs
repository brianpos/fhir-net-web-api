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
		public void Parse(Hl7.Fhir.Model.PaymentReconciliation.DetailsComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 40
							break;
						case "predecessor":
							result.Predecessor = new Hl7.Fhir.Model.Identifier();
							Parse(result.Predecessor as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".predecessor"); // 50
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 60
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 70
							break;
						case "submitter":
							result.Submitter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Submitter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".submitter"); // 80
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Response as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".response"); // 90
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.Date();
							Parse(result.DateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".date"); // 100
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".responsible"); // 110
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Payee as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".payee"); // 120
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.Money();
							Parse(result.Amount as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".amount"); // 130
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.PaymentReconciliation.DetailsComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 40
							break;
						case "predecessor":
							result.Predecessor = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Predecessor as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".predecessor"); // 50
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 60
							break;
						case "request":
							result.Request = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Request as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".request"); // 70
							break;
						case "submitter":
							result.Submitter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Submitter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".submitter"); // 80
							break;
						case "response":
							result.Response = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Response as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".response"); // 90
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".date"); // 100
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".responsible"); // 110
							break;
						case "payee":
							result.Payee = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Payee as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".payee"); // 120
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".amount"); // 130
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
