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
		public void Parse(Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "eventNumber":
							result.EventNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.EventNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".eventNumber", cancellationToken); // 40
							break;
						case "timestamp":
							result.TimestampElement = new Hl7.Fhir.Model.Instant();
							Parse(result.TimestampElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".timestamp", cancellationToken); // 50
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Focus as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".focus", cancellationToken); // 60
							break;
						case "additionalContext":
							var newItem_additionalContext = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_additionalContext, reader, outcome, locationPath + ".additionalContext["+result.AdditionalContext.Count+"]", cancellationToken); // 70
							result.AdditionalContext.Add(newItem_additionalContext);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "eventNumber":
							result.EventNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.EventNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".eventNumber", cancellationToken); // 40
							break;
						case "timestamp":
							result.TimestampElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.TimestampElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".timestamp", cancellationToken); // 50
							break;
						case "focus":
							result.Focus = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Focus as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".focus", cancellationToken); // 60
							break;
						case "additionalContext":
							var newItem_additionalContext = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_additionalContext, reader, outcome, locationPath + ".additionalContext["+result.AdditionalContext.Count+"]", cancellationToken); // 70
							result.AdditionalContext.Add(newItem_additionalContext);
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
