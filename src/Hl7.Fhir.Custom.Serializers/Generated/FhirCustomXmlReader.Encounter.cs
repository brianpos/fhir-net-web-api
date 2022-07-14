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
		private void Parse(Encounter result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Encounter.EncounterStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Encounter.EncounterStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "statusHistory":
							var newItem_statusHistory = new Hl7.Fhir.Model.Encounter.StatusHistoryComponent();
							Parse(newItem_statusHistory, reader, outcome, locationPath + ".statusHistory["+result.StatusHistory.Count+"]", cancellationToken); // 110
							result.StatusHistory.Add(newItem_statusHistory);
							break;
						case "class":
							result.Class = new Hl7.Fhir.Model.Coding();
							Parse(result.Class as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".class", cancellationToken); // 120
							break;
						case "classHistory":
							var newItem_classHistory = new Hl7.Fhir.Model.Encounter.ClassHistoryComponent();
							Parse(newItem_classHistory, reader, outcome, locationPath + ".classHistory["+result.ClassHistory.Count+"]", cancellationToken); // 130
							result.ClassHistory.Add(newItem_classHistory);
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 140
							result.Type.Add(newItem_type);
							break;
						case "serviceType":
							result.ServiceType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ServiceType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".serviceType", cancellationToken); // 150
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority", cancellationToken); // 160
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 170
							break;
						case "episodeOfCare":
							var newItem_episodeOfCare = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_episodeOfCare, reader, outcome, locationPath + ".episodeOfCare["+result.EpisodeOfCare.Count+"]", cancellationToken); // 180
							result.EpisodeOfCare.Add(newItem_episodeOfCare);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 190
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.Encounter.ParticipantComponent();
							Parse(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]", cancellationToken); // 200
							result.Participant.Add(newItem_participant);
							break;
						case "appointment":
							var newItem_appointment = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_appointment, reader, outcome, locationPath + ".appointment["+result.Appointment.Count+"]", cancellationToken); // 210
							result.Appointment.Add(newItem_appointment);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 220
							break;
						case "length":
							result.Length = new Hl7.Fhir.Model.Duration();
							Parse(result.Length as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".length", cancellationToken); // 230
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 240
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 250
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.Encounter.DiagnosisComponent();
							Parse(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]", cancellationToken); // 260
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "account":
							var newItem_account = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_account, reader, outcome, locationPath + ".account["+result.Account.Count+"]", cancellationToken); // 270
							result.Account.Add(newItem_account);
							break;
						case "hospitalization":
							result.Hospitalization = new Hl7.Fhir.Model.Encounter.HospitalizationComponent();
							Parse(result.Hospitalization as Hl7.Fhir.Model.Encounter.HospitalizationComponent, reader, outcome, locationPath + ".hospitalization", cancellationToken); // 280
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.Encounter.LocationComponent();
							Parse(newItem_location, reader, outcome, locationPath + ".location["+result.Location.Count+"]", cancellationToken); // 290
							result.Location.Add(newItem_location);
							break;
						case "serviceProvider":
							result.ServiceProvider = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ServiceProvider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".serviceProvider", cancellationToken); // 300
							break;
						case "partOf":
							result.PartOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.PartOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".partOf", cancellationToken); // 310
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

		private async System.Threading.Tasks.Task ParseAsync(Encounter result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Encounter.EncounterStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Encounter.EncounterStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "statusHistory":
							var newItem_statusHistory = new Hl7.Fhir.Model.Encounter.StatusHistoryComponent();
							await ParseAsync(newItem_statusHistory, reader, outcome, locationPath + ".statusHistory["+result.StatusHistory.Count+"]", cancellationToken); // 110
							result.StatusHistory.Add(newItem_statusHistory);
							break;
						case "class":
							result.Class = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Class as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".class", cancellationToken); // 120
							break;
						case "classHistory":
							var newItem_classHistory = new Hl7.Fhir.Model.Encounter.ClassHistoryComponent();
							await ParseAsync(newItem_classHistory, reader, outcome, locationPath + ".classHistory["+result.ClassHistory.Count+"]", cancellationToken); // 130
							result.ClassHistory.Add(newItem_classHistory);
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 140
							result.Type.Add(newItem_type);
							break;
						case "serviceType":
							result.ServiceType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ServiceType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".serviceType", cancellationToken); // 150
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority", cancellationToken); // 160
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 170
							break;
						case "episodeOfCare":
							var newItem_episodeOfCare = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_episodeOfCare, reader, outcome, locationPath + ".episodeOfCare["+result.EpisodeOfCare.Count+"]", cancellationToken); // 180
							result.EpisodeOfCare.Add(newItem_episodeOfCare);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 190
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.Encounter.ParticipantComponent();
							await ParseAsync(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]", cancellationToken); // 200
							result.Participant.Add(newItem_participant);
							break;
						case "appointment":
							var newItem_appointment = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_appointment, reader, outcome, locationPath + ".appointment["+result.Appointment.Count+"]", cancellationToken); // 210
							result.Appointment.Add(newItem_appointment);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 220
							break;
						case "length":
							result.Length = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Length as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".length", cancellationToken); // 230
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 240
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 250
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.Encounter.DiagnosisComponent();
							await ParseAsync(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]", cancellationToken); // 260
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "account":
							var newItem_account = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_account, reader, outcome, locationPath + ".account["+result.Account.Count+"]", cancellationToken); // 270
							result.Account.Add(newItem_account);
							break;
						case "hospitalization":
							result.Hospitalization = new Hl7.Fhir.Model.Encounter.HospitalizationComponent();
							await ParseAsync(result.Hospitalization as Hl7.Fhir.Model.Encounter.HospitalizationComponent, reader, outcome, locationPath + ".hospitalization", cancellationToken); // 280
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.Encounter.LocationComponent();
							await ParseAsync(newItem_location, reader, outcome, locationPath + ".location["+result.Location.Count+"]", cancellationToken); // 290
							result.Location.Add(newItem_location);
							break;
						case "serviceProvider":
							result.ServiceProvider = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ServiceProvider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".serviceProvider", cancellationToken); // 300
							break;
						case "partOf":
							result.PartOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.PartOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".partOf", cancellationToken); // 310
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
