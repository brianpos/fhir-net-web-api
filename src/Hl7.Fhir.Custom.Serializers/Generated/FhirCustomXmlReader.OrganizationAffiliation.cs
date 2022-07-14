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
		private void Parse(OrganizationAffiliation result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".active", cancellationToken); // 100
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 110
							break;
						case "organization":
							result.Organization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Organization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".organization", cancellationToken); // 120
							break;
						case "participatingOrganization":
							result.ParticipatingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ParticipatingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".participatingOrganization", cancellationToken); // 130
							break;
						case "network":
							var newItem_network = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_network, reader, outcome, locationPath + ".network["+result.Network.Count+"]", cancellationToken); // 140
							result.Network.Add(newItem_network);
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 150
							result.Code.Add(newItem_code);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]", cancellationToken); // 160
							result.Specialty.Add(newItem_specialty);
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_location, reader, outcome, locationPath + ".location["+result.Location.Count+"]", cancellationToken); // 170
							result.Location.Add(newItem_location);
							break;
						case "healthcareService":
							var newItem_healthcareService = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_healthcareService, reader, outcome, locationPath + ".healthcareService["+result.HealthcareService.Count+"]", cancellationToken); // 180
							result.HealthcareService.Add(newItem_healthcareService);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]", cancellationToken); // 190
							result.Telecom.Add(newItem_telecom);
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 200
							result.Endpoint.Add(newItem_endpoint);
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

		private async System.Threading.Tasks.Task ParseAsync(OrganizationAffiliation result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".active", cancellationToken); // 100
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 110
							break;
						case "organization":
							result.Organization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Organization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".organization", cancellationToken); // 120
							break;
						case "participatingOrganization":
							result.ParticipatingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ParticipatingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".participatingOrganization", cancellationToken); // 130
							break;
						case "network":
							var newItem_network = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_network, reader, outcome, locationPath + ".network["+result.Network.Count+"]", cancellationToken); // 140
							result.Network.Add(newItem_network);
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 150
							result.Code.Add(newItem_code);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]", cancellationToken); // 160
							result.Specialty.Add(newItem_specialty);
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_location, reader, outcome, locationPath + ".location["+result.Location.Count+"]", cancellationToken); // 170
							result.Location.Add(newItem_location);
							break;
						case "healthcareService":
							var newItem_healthcareService = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_healthcareService, reader, outcome, locationPath + ".healthcareService["+result.HealthcareService.Count+"]", cancellationToken); // 180
							result.HealthcareService.Add(newItem_healthcareService);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]", cancellationToken); // 190
							result.Telecom.Add(newItem_telecom);
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 200
							result.Endpoint.Add(newItem_endpoint);
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
