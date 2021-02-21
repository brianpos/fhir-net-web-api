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
		private void Parse(Media result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]"); // 110
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>, reader, outcome, locationPath + ".status"); // 120
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 130
							break;
						case "modality":
							result.Modality = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Modality as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".modality"); // 140
							break;
						case "view":
							result.View = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.View as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".view"); // 150
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 160
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 170
							break;
						case "createdDateTime":
							result.Created = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Created as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 180
							break;
						case "createdPeriod":
							result.Created = new Hl7.Fhir.Model.Period();
							Parse(result.Created as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".created"); // 180
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.IssuedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".issued"); // 190
							break;
						case "operator":
							result.Operator = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Operator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".operator"); // 200
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 210
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite"); // 220
							break;
						case "deviceName":
							result.DeviceNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DeviceNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".deviceName"); // 230
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device"); // 240
							break;
						case "height":
							result.HeightElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.HeightElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".height"); // 250
							break;
						case "width":
							result.WidthElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.WidthElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".width"); // 260
							break;
						case "frames":
							result.FramesElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.FramesElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".frames"); // 270
							break;
						case "duration":
							result.DurationElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DurationElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".duration"); // 280
							break;
						case "content":
							result.Content = new Hl7.Fhir.Model.Attachment();
							Parse(result.Content as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".content"); // 290
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 300
							result.Note.Add(newItem_note);
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

		private async System.Threading.Tasks.Task ParseAsync(Media result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]"); // 110
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>, reader, outcome, locationPath + ".status"); // 120
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 130
							break;
						case "modality":
							result.Modality = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Modality as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".modality"); // 140
							break;
						case "view":
							result.View = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.View as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".view"); // 150
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 160
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 170
							break;
						case "createdDateTime":
							result.Created = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Created as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".created"); // 180
							break;
						case "createdPeriod":
							result.Created = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Created as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".created"); // 180
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".issued"); // 190
							break;
						case "operator":
							result.Operator = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Operator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".operator"); // 200
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 210
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite"); // 220
							break;
						case "deviceName":
							result.DeviceNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DeviceNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".deviceName"); // 230
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device"); // 240
							break;
						case "height":
							result.HeightElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.HeightElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".height"); // 250
							break;
						case "width":
							result.WidthElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.WidthElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".width"); // 260
							break;
						case "frames":
							result.FramesElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.FramesElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".frames"); // 270
							break;
						case "duration":
							result.DurationElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DurationElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".duration"); // 280
							break;
						case "content":
							result.Content = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Content as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".content"); // 290
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 300
							result.Note.Add(newItem_note);
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
