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
		private void Parse(MedicationStatement result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]", cancellationToken); // 110
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 120
							break;
						case "statusReason":
							var newItem_statusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_statusReason, reader, outcome, locationPath + ".statusReason["+result.StatusReason.Count+"]", cancellationToken); // 130
							result.StatusReason.Add(newItem_statusReason);
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 140
							break;
						case "medicationCodeableConcept":
							result.Medication = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Medication as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".medication", cancellationToken); // 150
							break;
						case "medicationReference":
							result.Medication = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Medication as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".medication", cancellationToken); // 150
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 160
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".context", cancellationToken); // 170
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							Parse(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "dateAsserted":
							result.DateAssertedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateAssertedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateAsserted", cancellationToken); // 190
							break;
						case "informationSource":
							result.InformationSource = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.InformationSource as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".informationSource", cancellationToken); // 200
							break;
						case "derivedFrom":
							var newItem_derivedFrom = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_derivedFrom, reader, outcome, locationPath + ".derivedFrom["+result.DerivedFrom.Count+"]", cancellationToken); // 210
							result.DerivedFrom.Add(newItem_derivedFrom);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 220
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 230
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 240
							result.Note.Add(newItem_note);
							break;
						case "dosage":
							var newItem_dosage = new Hl7.Fhir.Model.Dosage();
							Parse(newItem_dosage, reader, outcome, locationPath + ".dosage["+result.Dosage.Count+"]", cancellationToken); // 250
							result.Dosage.Add(newItem_dosage);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicationStatement result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]", cancellationToken); // 110
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes>, reader, outcome, locationPath + ".status", cancellationToken); // 120
							break;
						case "statusReason":
							var newItem_statusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_statusReason, reader, outcome, locationPath + ".statusReason["+result.StatusReason.Count+"]", cancellationToken); // 130
							result.StatusReason.Add(newItem_statusReason);
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 140
							break;
						case "medicationCodeableConcept":
							result.Medication = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Medication as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".medication", cancellationToken); // 150
							break;
						case "medicationReference":
							result.Medication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Medication as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".medication", cancellationToken); // 150
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 160
							break;
						case "context":
							result.Context = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Context as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".context", cancellationToken); // 170
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "dateAsserted":
							result.DateAssertedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateAssertedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateAsserted", cancellationToken); // 190
							break;
						case "informationSource":
							result.InformationSource = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.InformationSource as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".informationSource", cancellationToken); // 200
							break;
						case "derivedFrom":
							var newItem_derivedFrom = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_derivedFrom, reader, outcome, locationPath + ".derivedFrom["+result.DerivedFrom.Count+"]", cancellationToken); // 210
							result.DerivedFrom.Add(newItem_derivedFrom);
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 220
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 230
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 240
							result.Note.Add(newItem_note);
							break;
						case "dosage":
							var newItem_dosage = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(newItem_dosage, reader, outcome, locationPath + ".dosage["+result.Dosage.Count+"]", cancellationToken); // 250
							result.Dosage.Add(newItem_dosage);
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
