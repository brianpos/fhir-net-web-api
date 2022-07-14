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
		public void Parse(Hl7.Fhir.Model.SubscriptionTopic.ResourceTriggerComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "resource":
							result.ResourceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ResourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".resource", cancellationToken); // 50
							break;
						case "supportedInteraction":
							var newItem_supportedInteraction = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>();
							Parse(newItem_supportedInteraction, reader, outcome, locationPath + ".supportedInteraction["+result.SupportedInteractionElement.Count+"]", cancellationToken); // 60
							result.SupportedInteractionElement.Add(newItem_supportedInteraction);
							break;
						case "queryCriteria":
							result.QueryCriteria = new Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent();
							Parse(result.QueryCriteria as Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent, reader, outcome, locationPath + ".queryCriteria", cancellationToken); // 70
							break;
						case "fhirPathCriteria":
							result.FhirPathCriteriaElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.FhirPathCriteriaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".fhirPathCriteria", cancellationToken); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubscriptionTopic.ResourceTriggerComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "resource":
							result.ResourceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ResourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".resource", cancellationToken); // 50
							break;
						case "supportedInteraction":
							var newItem_supportedInteraction = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>();
							await ParseAsync(newItem_supportedInteraction, reader, outcome, locationPath + ".supportedInteraction["+result.SupportedInteractionElement.Count+"]", cancellationToken); // 60
							result.SupportedInteractionElement.Add(newItem_supportedInteraction);
							break;
						case "queryCriteria":
							result.QueryCriteria = new Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent();
							await ParseAsync(result.QueryCriteria as Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent, reader, outcome, locationPath + ".queryCriteria", cancellationToken); // 70
							break;
						case "fhirPathCriteria":
							result.FhirPathCriteriaElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.FhirPathCriteriaElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".fhirPathCriteria", cancellationToken); // 80
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
