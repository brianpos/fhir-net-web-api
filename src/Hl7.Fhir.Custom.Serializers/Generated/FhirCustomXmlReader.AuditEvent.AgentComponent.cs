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
		public void Parse(Hl7.Fhir.Model.AuditEvent.AgentComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 40
							break;
						case "role":
							var newItem_role = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_role, reader, outcome, locationPath + ".role["+result.Role.Count+"]", cancellationToken); // 50
							result.Role.Add(newItem_role);
							break;
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who", cancellationToken); // 60
							break;
						case "altId":
							result.AltIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AltIdElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".altId", cancellationToken); // 70
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 80
							break;
						case "requestor":
							result.RequestorElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.RequestorElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".requestor", cancellationToken); // 90
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 100
							break;
						case "policy":
							var newItem_policy = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_policy, reader, outcome, locationPath + ".policy["+result.PolicyElement.Count+"]", cancellationToken); // 110
							result.PolicyElement.Add(newItem_policy);
							break;
						case "media":
							result.Media = new Hl7.Fhir.Model.Coding();
							Parse(result.Media as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".media", cancellationToken); // 120
							break;
						case "network":
							result.Network = new Hl7.Fhir.Model.AuditEvent.NetworkComponent();
							Parse(result.Network as Hl7.Fhir.Model.AuditEvent.NetworkComponent, reader, outcome, locationPath + ".network", cancellationToken); // 130
							break;
						case "purposeOfUse":
							var newItem_purposeOfUse = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_purposeOfUse, reader, outcome, locationPath + ".purposeOfUse["+result.PurposeOfUse.Count+"]", cancellationToken); // 140
							result.PurposeOfUse.Add(newItem_purposeOfUse);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.AuditEvent.AgentComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 40
							break;
						case "role":
							var newItem_role = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_role, reader, outcome, locationPath + ".role["+result.Role.Count+"]", cancellationToken); // 50
							result.Role.Add(newItem_role);
							break;
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who", cancellationToken); // 60
							break;
						case "altId":
							result.AltIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AltIdElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".altId", cancellationToken); // 70
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 80
							break;
						case "requestor":
							result.RequestorElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.RequestorElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".requestor", cancellationToken); // 90
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 100
							break;
						case "policy":
							var newItem_policy = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_policy, reader, outcome, locationPath + ".policy["+result.PolicyElement.Count+"]", cancellationToken); // 110
							result.PolicyElement.Add(newItem_policy);
							break;
						case "media":
							result.Media = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Media as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".media", cancellationToken); // 120
							break;
						case "network":
							result.Network = new Hl7.Fhir.Model.AuditEvent.NetworkComponent();
							await ParseAsync(result.Network as Hl7.Fhir.Model.AuditEvent.NetworkComponent, reader, outcome, locationPath + ".network", cancellationToken); // 130
							break;
						case "purposeOfUse":
							var newItem_purposeOfUse = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_purposeOfUse, reader, outcome, locationPath + ".purposeOfUse["+result.PurposeOfUse.Count+"]", cancellationToken); // 140
							result.PurposeOfUse.Add(newItem_purposeOfUse);
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
