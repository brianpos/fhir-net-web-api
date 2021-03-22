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
		private void Parse(Observation result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 120
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 130
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 150
							break;
						case "focus":
							var newItem_focus = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_focus, reader, outcome, locationPath + ".focus["+result.Focus.Count+"]", cancellationToken); // 160
							result.Focus.Add(newItem_focus);
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 170
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							Parse(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectiveTiming":
							result.Effective = new Hl7.Fhir.Model.Timing();
							Parse(result.Effective as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectiveInstant":
							result.Effective = new Hl7.Fhir.Model.Instant();
							Parse(result.Effective as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.IssuedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".issued", cancellationToken); // 190
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 200
							result.Performer.Add(newItem_performer);
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							Parse(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueCodeableConcept":
							result.Value = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Value as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueString":
							result.Value = new Hl7.Fhir.Model.FhirString();
							Parse(result.Value as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueBoolean":
							result.Value = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Value as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueInteger":
							result.Value = new Hl7.Fhir.Model.Integer();
							Parse(result.Value as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueRange":
							result.Value = new Hl7.Fhir.Model.Range();
							Parse(result.Value as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueRatio":
							result.Value = new Hl7.Fhir.Model.Ratio();
							Parse(result.Value as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueSampledData":
							result.Value = new Hl7.Fhir.Model.SampledData();
							Parse(result.Value as Hl7.Fhir.Model.SampledData, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueTime":
							result.Value = new Hl7.Fhir.Model.Time();
							Parse(result.Value as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueDateTime":
							result.Value = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Value as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valuePeriod":
							result.Value = new Hl7.Fhir.Model.Period();
							Parse(result.Value as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "dataAbsentReason":
							result.DataAbsentReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DataAbsentReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".dataAbsentReason", cancellationToken); // 220
							break;
						case "interpretation":
							var newItem_interpretation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_interpretation, reader, outcome, locationPath + ".interpretation["+result.Interpretation.Count+"]", cancellationToken); // 230
							result.Interpretation.Add(newItem_interpretation);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 240
							result.Note.Add(newItem_note);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite", cancellationToken); // 250
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method", cancellationToken); // 260
							break;
						case "specimen":
							result.Specimen = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Specimen as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".specimen", cancellationToken); // 270
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device", cancellationToken); // 280
							break;
						case "referenceRange":
							var newItem_referenceRange = new Hl7.Fhir.Model.Observation.ReferenceRangeComponent();
							Parse(newItem_referenceRange, reader, outcome, locationPath + ".referenceRange["+result.ReferenceRange.Count+"]", cancellationToken); // 290
							result.ReferenceRange.Add(newItem_referenceRange);
							break;
						case "hasMember":
							var newItem_hasMember = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_hasMember, reader, outcome, locationPath + ".hasMember["+result.HasMember.Count+"]", cancellationToken); // 300
							result.HasMember.Add(newItem_hasMember);
							break;
						case "derivedFrom":
							var newItem_derivedFrom = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_derivedFrom, reader, outcome, locationPath + ".derivedFrom["+result.DerivedFrom.Count+"]", cancellationToken); // 310
							result.DerivedFrom.Add(newItem_derivedFrom);
							break;
						case "component":
							var newItem_component = new Hl7.Fhir.Model.Observation.ComponentComponent();
							Parse(newItem_component, reader, outcome, locationPath + ".component["+result.Component.Count+"]", cancellationToken); // 320
							result.Component.Add(newItem_component);
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

		private async System.Threading.Tasks.Task ParseAsync(Observation result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 120
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 130
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 140
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 150
							break;
						case "focus":
							var newItem_focus = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_focus, reader, outcome, locationPath + ".focus["+result.Focus.Count+"]", cancellationToken); // 160
							result.Focus.Add(newItem_focus);
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 170
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectiveTiming":
							result.Effective = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "effectiveInstant":
							result.Effective = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".effective", cancellationToken); // 180
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".issued", cancellationToken); // 190
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 200
							result.Performer.Add(newItem_performer);
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueCodeableConcept":
							result.Value = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Value as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueString":
							result.Value = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueBoolean":
							result.Value = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueInteger":
							result.Value = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueRange":
							result.Value = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueRatio":
							result.Value = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Ratio, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueSampledData":
							result.Value = new Hl7.Fhir.Model.SampledData();
							await ParseAsync(result.Value as Hl7.Fhir.Model.SampledData, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueTime":
							result.Value = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valueDateTime":
							result.Value = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "valuePeriod":
							result.Value = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".value", cancellationToken); // 210
							break;
						case "dataAbsentReason":
							result.DataAbsentReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DataAbsentReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".dataAbsentReason", cancellationToken); // 220
							break;
						case "interpretation":
							var newItem_interpretation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_interpretation, reader, outcome, locationPath + ".interpretation["+result.Interpretation.Count+"]", cancellationToken); // 230
							result.Interpretation.Add(newItem_interpretation);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 240
							result.Note.Add(newItem_note);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite", cancellationToken); // 250
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method", cancellationToken); // 260
							break;
						case "specimen":
							result.Specimen = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Specimen as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".specimen", cancellationToken); // 270
							break;
						case "device":
							result.Device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Device as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".device", cancellationToken); // 280
							break;
						case "referenceRange":
							var newItem_referenceRange = new Hl7.Fhir.Model.Observation.ReferenceRangeComponent();
							await ParseAsync(newItem_referenceRange, reader, outcome, locationPath + ".referenceRange["+result.ReferenceRange.Count+"]", cancellationToken); // 290
							result.ReferenceRange.Add(newItem_referenceRange);
							break;
						case "hasMember":
							var newItem_hasMember = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_hasMember, reader, outcome, locationPath + ".hasMember["+result.HasMember.Count+"]", cancellationToken); // 300
							result.HasMember.Add(newItem_hasMember);
							break;
						case "derivedFrom":
							var newItem_derivedFrom = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_derivedFrom, reader, outcome, locationPath + ".derivedFrom["+result.DerivedFrom.Count+"]", cancellationToken); // 310
							result.DerivedFrom.Add(newItem_derivedFrom);
							break;
						case "component":
							var newItem_component = new Hl7.Fhir.Model.Observation.ComponentComponent();
							await ParseAsync(newItem_component, reader, outcome, locationPath + ".component["+result.Component.Count+"]", cancellationToken); // 320
							result.Component.Add(newItem_component);
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
