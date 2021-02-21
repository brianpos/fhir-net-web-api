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
		public void Parse(Hl7.Fhir.Model.CapabilityStatement.ResourceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>, reader, outcome, locationPath + ".type"); // 40
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile"); // 50
							break;
						case "supportedProfile":
							var newItem_supportedProfile = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_supportedProfile, reader, outcome, locationPath + ".supportedProfile["+result.SupportedProfileElement.Count+"]"); // 60
							result.SupportedProfileElement.Add(newItem_supportedProfile);
							break;
						case "documentation":
							result.Documentation = new Hl7.Fhir.Model.Markdown();
							Parse(result.Documentation as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".documentation"); // 70
							break;
						case "interaction":
							var newItem_interaction = new Hl7.Fhir.Model.CapabilityStatement.ResourceInteractionComponent();
							Parse(newItem_interaction, reader, outcome, locationPath + ".interaction["+result.Interaction.Count+"]"); // 80
							result.Interaction.Add(newItem_interaction);
							break;
						case "versioning":
							result.VersioningElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ResourceVersionPolicy>();
							Parse(result.VersioningElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ResourceVersionPolicy>, reader, outcome, locationPath + ".versioning"); // 90
							break;
						case "readHistory":
							result.ReadHistoryElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ReadHistoryElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".readHistory"); // 100
							break;
						case "updateCreate":
							result.UpdateCreateElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.UpdateCreateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".updateCreate"); // 110
							break;
						case "conditionalCreate":
							result.ConditionalCreateElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ConditionalCreateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".conditionalCreate"); // 120
							break;
						case "conditionalRead":
							result.ConditionalReadElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalReadStatus>();
							Parse(result.ConditionalReadElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalReadStatus>, reader, outcome, locationPath + ".conditionalRead"); // 130
							break;
						case "conditionalUpdate":
							result.ConditionalUpdateElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ConditionalUpdateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".conditionalUpdate"); // 140
							break;
						case "conditionalDelete":
							result.ConditionalDeleteElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalDeleteStatus>();
							Parse(result.ConditionalDeleteElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalDeleteStatus>, reader, outcome, locationPath + ".conditionalDelete"); // 150
							break;
						case "referencePolicy":
							var newItem_referencePolicy = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ReferenceHandlingPolicy>();
							Parse(newItem_referencePolicy, reader, outcome, locationPath + ".referencePolicy["+result.ReferencePolicyElement.Count+"]"); // 160
							result.ReferencePolicyElement.Add(newItem_referencePolicy);
							break;
						case "searchInclude":
							var newItem_searchInclude = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_searchInclude, reader, outcome, locationPath + ".searchInclude["+result.SearchIncludeElement.Count+"]"); // 170
							result.SearchIncludeElement.Add(newItem_searchInclude);
							break;
						case "searchRevInclude":
							var newItem_searchRevInclude = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_searchRevInclude, reader, outcome, locationPath + ".searchRevInclude["+result.SearchRevIncludeElement.Count+"]"); // 180
							result.SearchRevIncludeElement.Add(newItem_searchRevInclude);
							break;
						case "searchParam":
							var newItem_searchParam = new Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent();
							Parse(newItem_searchParam, reader, outcome, locationPath + ".searchParam["+result.SearchParam.Count+"]"); // 190
							result.SearchParam.Add(newItem_searchParam);
							break;
						case "operation":
							var newItem_operation = new Hl7.Fhir.Model.CapabilityStatement.OperationComponent();
							Parse(newItem_operation, reader, outcome, locationPath + ".operation["+result.Operation.Count+"]"); // 200
							result.Operation.Add(newItem_operation);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CapabilityStatement.ResourceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>, reader, outcome, locationPath + ".type"); // 40
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile"); // 50
							break;
						case "supportedProfile":
							var newItem_supportedProfile = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_supportedProfile, reader, outcome, locationPath + ".supportedProfile["+result.SupportedProfileElement.Count+"]"); // 60
							result.SupportedProfileElement.Add(newItem_supportedProfile);
							break;
						case "documentation":
							result.Documentation = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Documentation as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".documentation"); // 70
							break;
						case "interaction":
							var newItem_interaction = new Hl7.Fhir.Model.CapabilityStatement.ResourceInteractionComponent();
							await ParseAsync(newItem_interaction, reader, outcome, locationPath + ".interaction["+result.Interaction.Count+"]"); // 80
							result.Interaction.Add(newItem_interaction);
							break;
						case "versioning":
							result.VersioningElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ResourceVersionPolicy>();
							await ParseAsync(result.VersioningElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ResourceVersionPolicy>, reader, outcome, locationPath + ".versioning"); // 90
							break;
						case "readHistory":
							result.ReadHistoryElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ReadHistoryElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".readHistory"); // 100
							break;
						case "updateCreate":
							result.UpdateCreateElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.UpdateCreateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".updateCreate"); // 110
							break;
						case "conditionalCreate":
							result.ConditionalCreateElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ConditionalCreateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".conditionalCreate"); // 120
							break;
						case "conditionalRead":
							result.ConditionalReadElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalReadStatus>();
							await ParseAsync(result.ConditionalReadElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalReadStatus>, reader, outcome, locationPath + ".conditionalRead"); // 130
							break;
						case "conditionalUpdate":
							result.ConditionalUpdateElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ConditionalUpdateElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".conditionalUpdate"); // 140
							break;
						case "conditionalDelete":
							result.ConditionalDeleteElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalDeleteStatus>();
							await ParseAsync(result.ConditionalDeleteElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ConditionalDeleteStatus>, reader, outcome, locationPath + ".conditionalDelete"); // 150
							break;
						case "referencePolicy":
							var newItem_referencePolicy = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatement.ReferenceHandlingPolicy>();
							await ParseAsync(newItem_referencePolicy, reader, outcome, locationPath + ".referencePolicy["+result.ReferencePolicyElement.Count+"]"); // 160
							result.ReferencePolicyElement.Add(newItem_referencePolicy);
							break;
						case "searchInclude":
							var newItem_searchInclude = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_searchInclude, reader, outcome, locationPath + ".searchInclude["+result.SearchIncludeElement.Count+"]"); // 170
							result.SearchIncludeElement.Add(newItem_searchInclude);
							break;
						case "searchRevInclude":
							var newItem_searchRevInclude = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_searchRevInclude, reader, outcome, locationPath + ".searchRevInclude["+result.SearchRevIncludeElement.Count+"]"); // 180
							result.SearchRevIncludeElement.Add(newItem_searchRevInclude);
							break;
						case "searchParam":
							var newItem_searchParam = new Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent();
							await ParseAsync(newItem_searchParam, reader, outcome, locationPath + ".searchParam["+result.SearchParam.Count+"]"); // 190
							result.SearchParam.Add(newItem_searchParam);
							break;
						case "operation":
							var newItem_operation = new Hl7.Fhir.Model.CapabilityStatement.OperationComponent();
							await ParseAsync(newItem_operation, reader, outcome, locationPath + ".operation["+result.Operation.Count+"]"); // 200
							result.Operation.Add(newItem_operation);
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
