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
		public void Parse(Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "previous":
							result.PreviousElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PreviousElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".previous", cancellationToken); // 40
							break;
						case "resultForCreate":
							result.ResultForCreateElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>();
							Parse(result.ResultForCreateElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>, reader, outcome, locationPath + ".resultForCreate", cancellationToken); // 50
							break;
						case "current":
							result.CurrentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CurrentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".current", cancellationToken); // 60
							break;
						case "resultForDelete":
							result.ResultForDeleteElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>();
							Parse(result.ResultForDeleteElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>, reader, outcome, locationPath + ".resultForDelete", cancellationToken); // 70
							break;
						case "requireBoth":
							result.RequireBothElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.RequireBothElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".requireBoth", cancellationToken); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "previous":
							result.PreviousElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PreviousElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".previous", cancellationToken); // 40
							break;
						case "resultForCreate":
							result.ResultForCreateElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>();
							await ParseAsync(result.ResultForCreateElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>, reader, outcome, locationPath + ".resultForCreate", cancellationToken); // 50
							break;
						case "current":
							result.CurrentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CurrentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".current", cancellationToken); // 60
							break;
						case "resultForDelete":
							result.ResultForDeleteElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>();
							await ParseAsync(result.ResultForDeleteElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.CriteriaNotExistsBehavior>, reader, outcome, locationPath + ".resultForDelete", cancellationToken); // 70
							break;
						case "requireBoth":
							result.RequireBothElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.RequireBothElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".requireBoth", cancellationToken); // 80
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
