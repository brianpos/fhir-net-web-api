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
		private void Parse(RelatedPerson result, XmlReader reader, OperationOutcome outcome)
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
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 100
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_relationship, reader, outcome); // 120
							result.Relationship.Add(newItem_relationship);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.HumanName();
							Parse(newItem_name, reader, outcome); // 130
							result.Name.Add(newItem_name);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome); // 140
							result.Telecom.Add(newItem_telecom);
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							Parse(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome); // 150
							break;
						case "birthDate":
							result.BirthDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.BirthDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 160
							break;
						case "address":
							var newItem_address = new Hl7.Fhir.Model.Address();
							Parse(newItem_address, reader, outcome); // 170
							result.Address.Add(newItem_address);
							break;
						case "photo":
							var newItem_photo = new Hl7.Fhir.Model.Attachment();
							Parse(newItem_photo, reader, outcome); // 180
							result.Photo.Add(newItem_photo);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 190
							break;
						case "communication":
							var newItem_communication = new Hl7.Fhir.Model.RelatedPerson.CommunicationComponent();
							Parse(newItem_communication, reader, outcome); // 200
							result.Communication.Add(newItem_communication);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
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

		private async System.Threading.Tasks.Task ParseAsync(RelatedPerson result, XmlReader reader, OperationOutcome outcome)
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
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 100
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 110
							break;
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_relationship, reader, outcome); // 120
							result.Relationship.Add(newItem_relationship);
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(newItem_name, reader, outcome); // 130
							result.Name.Add(newItem_name);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome); // 140
							result.Telecom.Add(newItem_telecom);
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							await ParseAsync(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome); // 150
							break;
						case "birthDate":
							result.BirthDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.BirthDateElement as Hl7.Fhir.Model.Date, reader, outcome); // 160
							break;
						case "address":
							var newItem_address = new Hl7.Fhir.Model.Address();
							await ParseAsync(newItem_address, reader, outcome); // 170
							result.Address.Add(newItem_address);
							break;
						case "photo":
							var newItem_photo = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(newItem_photo, reader, outcome); // 180
							result.Photo.Add(newItem_photo);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 190
							break;
						case "communication":
							var newItem_communication = new Hl7.Fhir.Model.RelatedPerson.CommunicationComponent();
							await ParseAsync(newItem_communication, reader, outcome); // 200
							result.Communication.Add(newItem_communication);
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
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
