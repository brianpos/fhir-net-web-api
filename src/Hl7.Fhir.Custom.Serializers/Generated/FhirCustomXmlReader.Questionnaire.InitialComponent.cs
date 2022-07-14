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
		public void Parse(Hl7.Fhir.Model.Questionnaire.InitialComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "valueBoolean":
							result.Value = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Value as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueDecimal":
							result.Value = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.Value as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueInteger":
							result.Value = new Hl7.Fhir.Model.Integer();
							Parse(result.Value as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueDate":
							result.Value = new Hl7.Fhir.Model.Date();
							Parse(result.Value as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueDateTime":
							result.Value = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Value as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueTime":
							result.Value = new Hl7.Fhir.Model.Time();
							Parse(result.Value as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueString":
							result.Value = new Hl7.Fhir.Model.FhirString();
							Parse(result.Value as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueUri":
							result.Value = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Value as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueAttachment":
							result.Value = new Hl7.Fhir.Model.Attachment();
							Parse(result.Value as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueCoding":
							result.Value = new Hl7.Fhir.Model.Coding();
							Parse(result.Value as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							Parse(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueReference":
							result.Value = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Value as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".value", cancellationToken); // 40
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Questionnaire.InitialComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "valueBoolean":
							result.Value = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueDecimal":
							result.Value = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueInteger":
							result.Value = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueDate":
							result.Value = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueDateTime":
							result.Value = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueTime":
							result.Value = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueString":
							result.Value = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueUri":
							result.Value = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueAttachment":
							result.Value = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueCoding":
							result.Value = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "valueReference":
							result.Value = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Value as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".value", cancellationToken); // 40
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
