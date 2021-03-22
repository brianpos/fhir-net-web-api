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
		private void Parse(InsurancePlan result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 110
							result.Type.Add(newItem_type);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_alias, reader, outcome, locationPath + ".alias["+result.AliasElement.Count+"]", cancellationToken); // 130
							result.AliasElement.Add(newItem_alias);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 140
							break;
						case "ownedBy":
							result.OwnedBy = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OwnedBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".ownedBy", cancellationToken); // 150
							break;
						case "administeredBy":
							result.AdministeredBy = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.AdministeredBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".administeredBy", cancellationToken); // 160
							break;
						case "coverageArea":
							var newItem_coverageArea = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_coverageArea, reader, outcome, locationPath + ".coverageArea["+result.CoverageArea.Count+"]", cancellationToken); // 170
							result.CoverageArea.Add(newItem_coverageArea);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.InsurancePlan.ContactComponent();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 180
							result.Contact.Add(newItem_contact);
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 190
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "network":
							var newItem_network = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_network, reader, outcome, locationPath + ".network["+result.Network.Count+"]", cancellationToken); // 200
							result.Network.Add(newItem_network);
							break;
						case "coverage":
							var newItem_coverage = new Hl7.Fhir.Model.InsurancePlan.CoverageComponent();
							Parse(newItem_coverage, reader, outcome, locationPath + ".coverage["+result.Coverage.Count+"]", cancellationToken); // 210
							result.Coverage.Add(newItem_coverage);
							break;
						case "plan":
							var newItem_plan = new Hl7.Fhir.Model.InsurancePlan.PlanComponent();
							Parse(newItem_plan, reader, outcome, locationPath + ".plan["+result.Plan.Count+"]", cancellationToken); // 220
							result.Plan.Add(newItem_plan);
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

		private async System.Threading.Tasks.Task ParseAsync(InsurancePlan result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 110
							result.Type.Add(newItem_type);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_alias, reader, outcome, locationPath + ".alias["+result.AliasElement.Count+"]", cancellationToken); // 130
							result.AliasElement.Add(newItem_alias);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 140
							break;
						case "ownedBy":
							result.OwnedBy = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OwnedBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".ownedBy", cancellationToken); // 150
							break;
						case "administeredBy":
							result.AdministeredBy = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.AdministeredBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".administeredBy", cancellationToken); // 160
							break;
						case "coverageArea":
							var newItem_coverageArea = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_coverageArea, reader, outcome, locationPath + ".coverageArea["+result.CoverageArea.Count+"]", cancellationToken); // 170
							result.CoverageArea.Add(newItem_coverageArea);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.InsurancePlan.ContactComponent();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 180
							result.Contact.Add(newItem_contact);
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 190
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "network":
							var newItem_network = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_network, reader, outcome, locationPath + ".network["+result.Network.Count+"]", cancellationToken); // 200
							result.Network.Add(newItem_network);
							break;
						case "coverage":
							var newItem_coverage = new Hl7.Fhir.Model.InsurancePlan.CoverageComponent();
							await ParseAsync(newItem_coverage, reader, outcome, locationPath + ".coverage["+result.Coverage.Count+"]", cancellationToken); // 210
							result.Coverage.Add(newItem_coverage);
							break;
						case "plan":
							var newItem_plan = new Hl7.Fhir.Model.InsurancePlan.PlanComponent();
							await ParseAsync(newItem_plan, reader, outcome, locationPath + ".plan["+result.Plan.Count+"]", cancellationToken); // 220
							result.Plan.Add(newItem_plan);
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
