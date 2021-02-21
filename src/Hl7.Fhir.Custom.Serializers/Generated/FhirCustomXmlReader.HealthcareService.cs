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
		private void Parse(HealthcareService result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".active"); // 100
							break;
						case "providedBy":
							result.ProvidedBy = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ProvidedBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".providedBy"); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 120
							result.Category.Add(newItem_category);
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 130
							result.Type.Add(newItem_type);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]"); // 140
							result.Specialty.Add(newItem_specialty);
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_location, reader, outcome, locationPath + ".location["+result.Location.Count+"]"); // 150
							result.Location.Add(newItem_location);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name"); // 160
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment"); // 170
							break;
						case "extraDetails":
							result.ExtraDetails = new Hl7.Fhir.Model.Markdown();
							Parse(result.ExtraDetails as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".extraDetails"); // 180
							break;
						case "photo":
							result.Photo = new Hl7.Fhir.Model.Attachment();
							Parse(result.Photo as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".photo"); // 190
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]"); // 200
							result.Telecom.Add(newItem_telecom);
							break;
						case "coverageArea":
							var newItem_coverageArea = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_coverageArea, reader, outcome, locationPath + ".coverageArea["+result.CoverageArea.Count+"]"); // 210
							result.CoverageArea.Add(newItem_coverageArea);
							break;
						case "serviceProvisionCode":
							var newItem_serviceProvisionCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_serviceProvisionCode, reader, outcome, locationPath + ".serviceProvisionCode["+result.ServiceProvisionCode.Count+"]"); // 220
							result.ServiceProvisionCode.Add(newItem_serviceProvisionCode);
							break;
						case "eligibility":
							var newItem_eligibility = new Hl7.Fhir.Model.HealthcareService.EligibilityComponent();
							Parse(newItem_eligibility, reader, outcome, locationPath + ".eligibility["+result.Eligibility.Count+"]"); // 230
							result.Eligibility.Add(newItem_eligibility);
							break;
						case "program":
							var newItem_program = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_program, reader, outcome, locationPath + ".program["+result.Program.Count+"]"); // 240
							result.Program.Add(newItem_program);
							break;
						case "characteristic":
							var newItem_characteristic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_characteristic, reader, outcome, locationPath + ".characteristic["+result.Characteristic.Count+"]"); // 250
							result.Characteristic.Add(newItem_characteristic);
							break;
						case "communication":
							var newItem_communication = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_communication, reader, outcome, locationPath + ".communication["+result.Communication.Count+"]"); // 260
							result.Communication.Add(newItem_communication);
							break;
						case "referralMethod":
							var newItem_referralMethod = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_referralMethod, reader, outcome, locationPath + ".referralMethod["+result.ReferralMethod.Count+"]"); // 270
							result.ReferralMethod.Add(newItem_referralMethod);
							break;
						case "appointmentRequired":
							result.AppointmentRequiredElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AppointmentRequiredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".appointmentRequired"); // 280
							break;
						case "availableTime":
							var newItem_availableTime = new Hl7.Fhir.Model.HealthcareService.AvailableTimeComponent();
							Parse(newItem_availableTime, reader, outcome, locationPath + ".availableTime["+result.AvailableTime.Count+"]"); // 290
							result.AvailableTime.Add(newItem_availableTime);
							break;
						case "notAvailable":
							var newItem_notAvailable = new Hl7.Fhir.Model.HealthcareService.NotAvailableComponent();
							Parse(newItem_notAvailable, reader, outcome, locationPath + ".notAvailable["+result.NotAvailable.Count+"]"); // 300
							result.NotAvailable.Add(newItem_notAvailable);
							break;
						case "availabilityExceptions":
							result.AvailabilityExceptionsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AvailabilityExceptionsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".availabilityExceptions"); // 310
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]"); // 320
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

		private async System.Threading.Tasks.Task ParseAsync(HealthcareService result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".active"); // 100
							break;
						case "providedBy":
							result.ProvidedBy = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ProvidedBy as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".providedBy"); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 120
							result.Category.Add(newItem_category);
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]"); // 130
							result.Type.Add(newItem_type);
							break;
						case "specialty":
							var newItem_specialty = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_specialty, reader, outcome, locationPath + ".specialty["+result.Specialty.Count+"]"); // 140
							result.Specialty.Add(newItem_specialty);
							break;
						case "location":
							var newItem_location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_location, reader, outcome, locationPath + ".location["+result.Location.Count+"]"); // 150
							result.Location.Add(newItem_location);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name"); // 160
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment"); // 170
							break;
						case "extraDetails":
							result.ExtraDetails = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.ExtraDetails as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".extraDetails"); // 180
							break;
						case "photo":
							result.Photo = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Photo as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".photo"); // 190
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]"); // 200
							result.Telecom.Add(newItem_telecom);
							break;
						case "coverageArea":
							var newItem_coverageArea = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_coverageArea, reader, outcome, locationPath + ".coverageArea["+result.CoverageArea.Count+"]"); // 210
							result.CoverageArea.Add(newItem_coverageArea);
							break;
						case "serviceProvisionCode":
							var newItem_serviceProvisionCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_serviceProvisionCode, reader, outcome, locationPath + ".serviceProvisionCode["+result.ServiceProvisionCode.Count+"]"); // 220
							result.ServiceProvisionCode.Add(newItem_serviceProvisionCode);
							break;
						case "eligibility":
							var newItem_eligibility = new Hl7.Fhir.Model.HealthcareService.EligibilityComponent();
							await ParseAsync(newItem_eligibility, reader, outcome, locationPath + ".eligibility["+result.Eligibility.Count+"]"); // 230
							result.Eligibility.Add(newItem_eligibility);
							break;
						case "program":
							var newItem_program = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_program, reader, outcome, locationPath + ".program["+result.Program.Count+"]"); // 240
							result.Program.Add(newItem_program);
							break;
						case "characteristic":
							var newItem_characteristic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_characteristic, reader, outcome, locationPath + ".characteristic["+result.Characteristic.Count+"]"); // 250
							result.Characteristic.Add(newItem_characteristic);
							break;
						case "communication":
							var newItem_communication = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_communication, reader, outcome, locationPath + ".communication["+result.Communication.Count+"]"); // 260
							result.Communication.Add(newItem_communication);
							break;
						case "referralMethod":
							var newItem_referralMethod = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_referralMethod, reader, outcome, locationPath + ".referralMethod["+result.ReferralMethod.Count+"]"); // 270
							result.ReferralMethod.Add(newItem_referralMethod);
							break;
						case "appointmentRequired":
							result.AppointmentRequiredElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AppointmentRequiredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".appointmentRequired"); // 280
							break;
						case "availableTime":
							var newItem_availableTime = new Hl7.Fhir.Model.HealthcareService.AvailableTimeComponent();
							await ParseAsync(newItem_availableTime, reader, outcome, locationPath + ".availableTime["+result.AvailableTime.Count+"]"); // 290
							result.AvailableTime.Add(newItem_availableTime);
							break;
						case "notAvailable":
							var newItem_notAvailable = new Hl7.Fhir.Model.HealthcareService.NotAvailableComponent();
							await ParseAsync(newItem_notAvailable, reader, outcome, locationPath + ".notAvailable["+result.NotAvailable.Count+"]"); // 300
							result.NotAvailable.Add(newItem_notAvailable);
							break;
						case "availabilityExceptions":
							result.AvailabilityExceptionsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AvailabilityExceptionsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".availabilityExceptions"); // 310
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]"); // 320
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
