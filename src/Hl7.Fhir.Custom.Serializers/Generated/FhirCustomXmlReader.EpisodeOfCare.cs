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
		private void Parse(EpisodeOfCare result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "statusHistory":
							var newItem_statusHistory = new Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent();
							Parse(newItem_statusHistory, reader, outcome, locationPath + ".statusHistory["+result.StatusHistory.Count+"]"); // 110
							result.StatusHistory.Add(newItem_statusHistory);
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 120
							result.Type.Add(newItem_type);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent();
							Parse(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]"); // 130
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 140
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization"); // 150
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 160
							break;
						case "referralRequest":
							var newItem_referralRequest = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_referralRequest, reader, outcome, locationPath + ".referralRequest["+result.ReferralRequest.Count+"]"); // 170
							result.ReferralRequest.Add(newItem_referralRequest);
							break;
						case "careManager":
							result.CareManager = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.CareManager as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".careManager"); // 180
							break;
						case "team":
							var newItem_team = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_team, reader, outcome, locationPath + ".team["+result.Team.Count+"]"); // 190
							result.Team.Add(newItem_team);
							break;
						case "account":
							var newItem_account = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_account, reader, outcome, locationPath + ".account["+result.Account.Count+"]"); // 200
							result.Account.Add(newItem_account);
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

		private async System.Threading.Tasks.Task ParseAsync(EpisodeOfCare result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "statusHistory":
							var newItem_statusHistory = new Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent();
							await ParseAsync(newItem_statusHistory, reader, outcome, locationPath + ".statusHistory["+result.StatusHistory.Count+"]"); // 110
							result.StatusHistory.Add(newItem_statusHistory);
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 120
							result.Type.Add(newItem_type);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent();
							await ParseAsync(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]"); // 130
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient"); // 140
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization"); // 150
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 160
							break;
						case "referralRequest":
							var newItem_referralRequest = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_referralRequest, reader, outcome, locationPath + ".referralRequest["+result.ReferralRequest.Count+"]"); // 170
							result.ReferralRequest.Add(newItem_referralRequest);
							break;
						case "careManager":
							result.CareManager = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.CareManager as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".careManager"); // 180
							break;
						case "team":
							var newItem_team = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_team, reader, outcome, locationPath + ".team["+result.Team.Count+"]"); // 190
							result.Team.Add(newItem_team);
							break;
						case "account":
							var newItem_account = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_account, reader, outcome, locationPath + ".account["+result.Account.Count+"]"); // 200
							result.Account.Add(newItem_account);
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
