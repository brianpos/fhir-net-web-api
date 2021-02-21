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
		public void Parse(Hl7.Fhir.Model.ElementDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "path":
							result.PathElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "representation":
							var newItem_representation = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.PropertyRepresentation>();
							Parse(newItem_representation, reader, outcome); // 100
							result.RepresentationElement.Add(newItem_representation);
							break;
						case "sliceName":
							result.SliceNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SliceNameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "sliceIsConstraining":
							result.SliceIsConstrainingElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.SliceIsConstrainingElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 120
							break;
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							Parse(newItem_code, reader, outcome); // 140
							result.Code.Add(newItem_code);
							break;
						case "slicing":
							result.Slicing = new Hl7.Fhir.Model.ElementDefinition.SlicingComponent();
							Parse(result.Slicing as Hl7.Fhir.Model.ElementDefinition.SlicingComponent, reader, outcome); // 150
							break;
						case "short":
							result.ShortElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ShortElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "definition":
							result.Definition = new Hl7.Fhir.Model.Markdown();
							Parse(result.Definition as Hl7.Fhir.Model.Markdown, reader, outcome); // 170
							break;
						case "comment":
							result.Comment = new Hl7.Fhir.Model.Markdown();
							Parse(result.Comment as Hl7.Fhir.Model.Markdown, reader, outcome); // 180
							break;
						case "requirements":
							result.Requirements = new Hl7.Fhir.Model.Markdown();
							Parse(result.Requirements as Hl7.Fhir.Model.Markdown, reader, outcome); // 190
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_alias, reader, outcome); // 200
							result.AliasElement.Add(newItem_alias);
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.MinElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 210
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 220
							break;
						case "base":
							result.Base = new Hl7.Fhir.Model.ElementDefinition.BaseComponent();
							Parse(result.Base as Hl7.Fhir.Model.ElementDefinition.BaseComponent, reader, outcome); // 230
							break;
						case "contentReference":
							result.ContentReferenceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ContentReferenceElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 240
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.ElementDefinition.TypeRefComponent();
							Parse(newItem_type, reader, outcome); // 250
							result.Type.Add(newItem_type);
							break;
						case "defaultValueBase64Binary":
							result.DefaultValue = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 260
							break;
						case "defaultValueBoolean":
							result.DefaultValue = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 260
							break;
						case "defaultValueCanonical":
							result.DefaultValue = new Hl7.Fhir.Model.Canonical();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Canonical, reader, outcome); // 260
							break;
						case "defaultValueCode":
							result.DefaultValue = new Hl7.Fhir.Model.Code();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Code, reader, outcome); // 260
							break;
						case "defaultValueDate":
							result.DefaultValue = new Hl7.Fhir.Model.Date();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Date, reader, outcome); // 260
							break;
						case "defaultValueDateTime":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 260
							break;
						case "defaultValueDecimal":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 260
							break;
						case "defaultValueId":
							result.DefaultValue = new Hl7.Fhir.Model.Id();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Id, reader, outcome); // 260
							break;
						case "defaultValueInstant":
							result.DefaultValue = new Hl7.Fhir.Model.Instant();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Instant, reader, outcome); // 260
							break;
						case "defaultValueInteger":
							result.DefaultValue = new Hl7.Fhir.Model.Integer();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Integer, reader, outcome); // 260
							break;
						case "defaultValueMarkdown":
							result.DefaultValue = new Hl7.Fhir.Model.Markdown();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Markdown, reader, outcome); // 260
							break;
						case "defaultValueOid":
							result.DefaultValue = new Hl7.Fhir.Model.Oid();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Oid, reader, outcome); // 260
							break;
						case "defaultValuePositiveInt":
							result.DefaultValue = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.DefaultValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 260
							break;
						case "defaultValueString":
							result.DefaultValue = new Hl7.Fhir.Model.FhirString();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirString, reader, outcome); // 260
							break;
						case "defaultValueTime":
							result.DefaultValue = new Hl7.Fhir.Model.Time();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Time, reader, outcome); // 260
							break;
						case "defaultValueUnsignedInt":
							result.DefaultValue = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.DefaultValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 260
							break;
						case "defaultValueUri":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUri();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirUri, reader, outcome); // 260
							break;
						case "defaultValueUrl":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 260
							break;
						case "defaultValueUuid":
							result.DefaultValue = new Hl7.Fhir.Model.Uuid();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Uuid, reader, outcome); // 260
							break;
						case "defaultValueAddress":
							result.DefaultValue = new Hl7.Fhir.Model.Address();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Address, reader, outcome); // 260
							break;
						case "defaultValueAge":
							result.DefaultValue = new Hl7.Fhir.Model.Age();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Age, reader, outcome); // 260
							break;
						case "defaultValueAnnotation":
							result.DefaultValue = new Hl7.Fhir.Model.Annotation();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Annotation, reader, outcome); // 260
							break;
						case "defaultValueAttachment":
							result.DefaultValue = new Hl7.Fhir.Model.Attachment();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Attachment, reader, outcome); // 260
							break;
						case "defaultValueCodeableConcept":
							result.DefaultValue = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DefaultValue as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 260
							break;
						case "defaultValueCoding":
							result.DefaultValue = new Hl7.Fhir.Model.Coding();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Coding, reader, outcome); // 260
							break;
						case "defaultValueContactPoint":
							result.DefaultValue = new Hl7.Fhir.Model.ContactPoint();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 260
							break;
						case "defaultValueCount":
							result.DefaultValue = new Hl7.Fhir.Model.Count();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Count, reader, outcome); // 260
							break;
						case "defaultValueDistance":
							result.DefaultValue = new Hl7.Fhir.Model.Distance();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Distance, reader, outcome); // 260
							break;
						case "defaultValueDuration":
							result.DefaultValue = new Hl7.Fhir.Model.Duration();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Duration, reader, outcome); // 260
							break;
						case "defaultValueHumanName":
							result.DefaultValue = new Hl7.Fhir.Model.HumanName();
							Parse(result.DefaultValue as Hl7.Fhir.Model.HumanName, reader, outcome); // 260
							break;
						case "defaultValueIdentifier":
							result.DefaultValue = new Hl7.Fhir.Model.Identifier();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Identifier, reader, outcome); // 260
							break;
						case "defaultValueMoney":
							result.DefaultValue = new Hl7.Fhir.Model.Money();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Money, reader, outcome); // 260
							break;
						case "defaultValuePeriod":
							result.DefaultValue = new Hl7.Fhir.Model.Period();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Period, reader, outcome); // 260
							break;
						case "defaultValueQuantity":
							result.DefaultValue = new Hl7.Fhir.Model.Quantity();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 260
							break;
						case "defaultValueRange":
							result.DefaultValue = new Hl7.Fhir.Model.Range();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Range, reader, outcome); // 260
							break;
						case "defaultValueRatio":
							result.DefaultValue = new Hl7.Fhir.Model.Ratio();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Ratio, reader, outcome); // 260
							break;
						case "defaultValueReference":
							result.DefaultValue = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "defaultValueSampledData":
							result.DefaultValue = new Hl7.Fhir.Model.SampledData();
							Parse(result.DefaultValue as Hl7.Fhir.Model.SampledData, reader, outcome); // 260
							break;
						case "defaultValueSignature":
							result.DefaultValue = new Hl7.Fhir.Model.Signature();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Signature, reader, outcome); // 260
							break;
						case "defaultValueTiming":
							result.DefaultValue = new Hl7.Fhir.Model.Timing();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Timing, reader, outcome); // 260
							break;
						case "defaultValueContactDetail":
							result.DefaultValue = new Hl7.Fhir.Model.ContactDetail();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 260
							break;
						case "defaultValueContributor":
							result.DefaultValue = new Hl7.Fhir.Model.Contributor();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Contributor, reader, outcome); // 260
							break;
						case "defaultValueDataRequirement":
							result.DefaultValue = new Hl7.Fhir.Model.DataRequirement();
							Parse(result.DefaultValue as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 260
							break;
						case "defaultValueExpression":
							result.DefaultValue = new Hl7.Fhir.Model.Expression();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Expression, reader, outcome); // 260
							break;
						case "defaultValueParameterDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.ParameterDefinition();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 260
							break;
						case "defaultValueRelatedArtifact":
							result.DefaultValue = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(result.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 260
							break;
						case "defaultValueTriggerDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.TriggerDefinition();
							Parse(result.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 260
							break;
						case "defaultValueUsageContext":
							result.DefaultValue = new Hl7.Fhir.Model.UsageContext();
							Parse(result.DefaultValue as Hl7.Fhir.Model.UsageContext, reader, outcome); // 260
							break;
						case "defaultValueDosage":
							result.DefaultValue = new Hl7.Fhir.Model.Dosage();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Dosage, reader, outcome); // 260
							break;
						case "defaultValueMeta":
							result.DefaultValue = new Hl7.Fhir.Model.Meta();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Meta, reader, outcome); // 260
							break;
						case "meaningWhenMissing":
							result.MeaningWhenMissing = new Hl7.Fhir.Model.Markdown();
							Parse(result.MeaningWhenMissing as Hl7.Fhir.Model.Markdown, reader, outcome); // 270
							break;
						case "orderMeaning":
							result.OrderMeaningElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.OrderMeaningElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 280
							break;
						case "fixedBase64Binary":
							result.Fixed = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.Fixed as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 290
							break;
						case "fixedBoolean":
							result.Fixed = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Fixed as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 290
							break;
						case "fixedCanonical":
							result.Fixed = new Hl7.Fhir.Model.Canonical();
							Parse(result.Fixed as Hl7.Fhir.Model.Canonical, reader, outcome); // 290
							break;
						case "fixedCode":
							result.Fixed = new Hl7.Fhir.Model.Code();
							Parse(result.Fixed as Hl7.Fhir.Model.Code, reader, outcome); // 290
							break;
						case "fixedDate":
							result.Fixed = new Hl7.Fhir.Model.Date();
							Parse(result.Fixed as Hl7.Fhir.Model.Date, reader, outcome); // 290
							break;
						case "fixedDateTime":
							result.Fixed = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Fixed as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 290
							break;
						case "fixedDecimal":
							result.Fixed = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.Fixed as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 290
							break;
						case "fixedId":
							result.Fixed = new Hl7.Fhir.Model.Id();
							Parse(result.Fixed as Hl7.Fhir.Model.Id, reader, outcome); // 290
							break;
						case "fixedInstant":
							result.Fixed = new Hl7.Fhir.Model.Instant();
							Parse(result.Fixed as Hl7.Fhir.Model.Instant, reader, outcome); // 290
							break;
						case "fixedInteger":
							result.Fixed = new Hl7.Fhir.Model.Integer();
							Parse(result.Fixed as Hl7.Fhir.Model.Integer, reader, outcome); // 290
							break;
						case "fixedMarkdown":
							result.Fixed = new Hl7.Fhir.Model.Markdown();
							Parse(result.Fixed as Hl7.Fhir.Model.Markdown, reader, outcome); // 290
							break;
						case "fixedOid":
							result.Fixed = new Hl7.Fhir.Model.Oid();
							Parse(result.Fixed as Hl7.Fhir.Model.Oid, reader, outcome); // 290
							break;
						case "fixedPositiveInt":
							result.Fixed = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.Fixed as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 290
							break;
						case "fixedString":
							result.Fixed = new Hl7.Fhir.Model.FhirString();
							Parse(result.Fixed as Hl7.Fhir.Model.FhirString, reader, outcome); // 290
							break;
						case "fixedTime":
							result.Fixed = new Hl7.Fhir.Model.Time();
							Parse(result.Fixed as Hl7.Fhir.Model.Time, reader, outcome); // 290
							break;
						case "fixedUnsignedInt":
							result.Fixed = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.Fixed as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 290
							break;
						case "fixedUri":
							result.Fixed = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Fixed as Hl7.Fhir.Model.FhirUri, reader, outcome); // 290
							break;
						case "fixedUrl":
							result.Fixed = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.Fixed as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 290
							break;
						case "fixedUuid":
							result.Fixed = new Hl7.Fhir.Model.Uuid();
							Parse(result.Fixed as Hl7.Fhir.Model.Uuid, reader, outcome); // 290
							break;
						case "fixedAddress":
							result.Fixed = new Hl7.Fhir.Model.Address();
							Parse(result.Fixed as Hl7.Fhir.Model.Address, reader, outcome); // 290
							break;
						case "fixedAge":
							result.Fixed = new Hl7.Fhir.Model.Age();
							Parse(result.Fixed as Hl7.Fhir.Model.Age, reader, outcome); // 290
							break;
						case "fixedAnnotation":
							result.Fixed = new Hl7.Fhir.Model.Annotation();
							Parse(result.Fixed as Hl7.Fhir.Model.Annotation, reader, outcome); // 290
							break;
						case "fixedAttachment":
							result.Fixed = new Hl7.Fhir.Model.Attachment();
							Parse(result.Fixed as Hl7.Fhir.Model.Attachment, reader, outcome); // 290
							break;
						case "fixedCodeableConcept":
							result.Fixed = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Fixed as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 290
							break;
						case "fixedCoding":
							result.Fixed = new Hl7.Fhir.Model.Coding();
							Parse(result.Fixed as Hl7.Fhir.Model.Coding, reader, outcome); // 290
							break;
						case "fixedContactPoint":
							result.Fixed = new Hl7.Fhir.Model.ContactPoint();
							Parse(result.Fixed as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 290
							break;
						case "fixedCount":
							result.Fixed = new Hl7.Fhir.Model.Count();
							Parse(result.Fixed as Hl7.Fhir.Model.Count, reader, outcome); // 290
							break;
						case "fixedDistance":
							result.Fixed = new Hl7.Fhir.Model.Distance();
							Parse(result.Fixed as Hl7.Fhir.Model.Distance, reader, outcome); // 290
							break;
						case "fixedDuration":
							result.Fixed = new Hl7.Fhir.Model.Duration();
							Parse(result.Fixed as Hl7.Fhir.Model.Duration, reader, outcome); // 290
							break;
						case "fixedHumanName":
							result.Fixed = new Hl7.Fhir.Model.HumanName();
							Parse(result.Fixed as Hl7.Fhir.Model.HumanName, reader, outcome); // 290
							break;
						case "fixedIdentifier":
							result.Fixed = new Hl7.Fhir.Model.Identifier();
							Parse(result.Fixed as Hl7.Fhir.Model.Identifier, reader, outcome); // 290
							break;
						case "fixedMoney":
							result.Fixed = new Hl7.Fhir.Model.Money();
							Parse(result.Fixed as Hl7.Fhir.Model.Money, reader, outcome); // 290
							break;
						case "fixedPeriod":
							result.Fixed = new Hl7.Fhir.Model.Period();
							Parse(result.Fixed as Hl7.Fhir.Model.Period, reader, outcome); // 290
							break;
						case "fixedQuantity":
							result.Fixed = new Hl7.Fhir.Model.Quantity();
							Parse(result.Fixed as Hl7.Fhir.Model.Quantity, reader, outcome); // 290
							break;
						case "fixedRange":
							result.Fixed = new Hl7.Fhir.Model.Range();
							Parse(result.Fixed as Hl7.Fhir.Model.Range, reader, outcome); // 290
							break;
						case "fixedRatio":
							result.Fixed = new Hl7.Fhir.Model.Ratio();
							Parse(result.Fixed as Hl7.Fhir.Model.Ratio, reader, outcome); // 290
							break;
						case "fixedReference":
							result.Fixed = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Fixed as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 290
							break;
						case "fixedSampledData":
							result.Fixed = new Hl7.Fhir.Model.SampledData();
							Parse(result.Fixed as Hl7.Fhir.Model.SampledData, reader, outcome); // 290
							break;
						case "fixedSignature":
							result.Fixed = new Hl7.Fhir.Model.Signature();
							Parse(result.Fixed as Hl7.Fhir.Model.Signature, reader, outcome); // 290
							break;
						case "fixedTiming":
							result.Fixed = new Hl7.Fhir.Model.Timing();
							Parse(result.Fixed as Hl7.Fhir.Model.Timing, reader, outcome); // 290
							break;
						case "fixedContactDetail":
							result.Fixed = new Hl7.Fhir.Model.ContactDetail();
							Parse(result.Fixed as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 290
							break;
						case "fixedContributor":
							result.Fixed = new Hl7.Fhir.Model.Contributor();
							Parse(result.Fixed as Hl7.Fhir.Model.Contributor, reader, outcome); // 290
							break;
						case "fixedDataRequirement":
							result.Fixed = new Hl7.Fhir.Model.DataRequirement();
							Parse(result.Fixed as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 290
							break;
						case "fixedExpression":
							result.Fixed = new Hl7.Fhir.Model.Expression();
							Parse(result.Fixed as Hl7.Fhir.Model.Expression, reader, outcome); // 290
							break;
						case "fixedParameterDefinition":
							result.Fixed = new Hl7.Fhir.Model.ParameterDefinition();
							Parse(result.Fixed as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 290
							break;
						case "fixedRelatedArtifact":
							result.Fixed = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(result.Fixed as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 290
							break;
						case "fixedTriggerDefinition":
							result.Fixed = new Hl7.Fhir.Model.TriggerDefinition();
							Parse(result.Fixed as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 290
							break;
						case "fixedUsageContext":
							result.Fixed = new Hl7.Fhir.Model.UsageContext();
							Parse(result.Fixed as Hl7.Fhir.Model.UsageContext, reader, outcome); // 290
							break;
						case "fixedDosage":
							result.Fixed = new Hl7.Fhir.Model.Dosage();
							Parse(result.Fixed as Hl7.Fhir.Model.Dosage, reader, outcome); // 290
							break;
						case "fixedMeta":
							result.Fixed = new Hl7.Fhir.Model.Meta();
							Parse(result.Fixed as Hl7.Fhir.Model.Meta, reader, outcome); // 290
							break;
						case "patternBase64Binary":
							result.Pattern = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.Pattern as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 300
							break;
						case "patternBoolean":
							result.Pattern = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Pattern as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 300
							break;
						case "patternCanonical":
							result.Pattern = new Hl7.Fhir.Model.Canonical();
							Parse(result.Pattern as Hl7.Fhir.Model.Canonical, reader, outcome); // 300
							break;
						case "patternCode":
							result.Pattern = new Hl7.Fhir.Model.Code();
							Parse(result.Pattern as Hl7.Fhir.Model.Code, reader, outcome); // 300
							break;
						case "patternDate":
							result.Pattern = new Hl7.Fhir.Model.Date();
							Parse(result.Pattern as Hl7.Fhir.Model.Date, reader, outcome); // 300
							break;
						case "patternDateTime":
							result.Pattern = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Pattern as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 300
							break;
						case "patternDecimal":
							result.Pattern = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.Pattern as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 300
							break;
						case "patternId":
							result.Pattern = new Hl7.Fhir.Model.Id();
							Parse(result.Pattern as Hl7.Fhir.Model.Id, reader, outcome); // 300
							break;
						case "patternInstant":
							result.Pattern = new Hl7.Fhir.Model.Instant();
							Parse(result.Pattern as Hl7.Fhir.Model.Instant, reader, outcome); // 300
							break;
						case "patternInteger":
							result.Pattern = new Hl7.Fhir.Model.Integer();
							Parse(result.Pattern as Hl7.Fhir.Model.Integer, reader, outcome); // 300
							break;
						case "patternMarkdown":
							result.Pattern = new Hl7.Fhir.Model.Markdown();
							Parse(result.Pattern as Hl7.Fhir.Model.Markdown, reader, outcome); // 300
							break;
						case "patternOid":
							result.Pattern = new Hl7.Fhir.Model.Oid();
							Parse(result.Pattern as Hl7.Fhir.Model.Oid, reader, outcome); // 300
							break;
						case "patternPositiveInt":
							result.Pattern = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.Pattern as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 300
							break;
						case "patternString":
							result.Pattern = new Hl7.Fhir.Model.FhirString();
							Parse(result.Pattern as Hl7.Fhir.Model.FhirString, reader, outcome); // 300
							break;
						case "patternTime":
							result.Pattern = new Hl7.Fhir.Model.Time();
							Parse(result.Pattern as Hl7.Fhir.Model.Time, reader, outcome); // 300
							break;
						case "patternUnsignedInt":
							result.Pattern = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.Pattern as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 300
							break;
						case "patternUri":
							result.Pattern = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Pattern as Hl7.Fhir.Model.FhirUri, reader, outcome); // 300
							break;
						case "patternUrl":
							result.Pattern = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.Pattern as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 300
							break;
						case "patternUuid":
							result.Pattern = new Hl7.Fhir.Model.Uuid();
							Parse(result.Pattern as Hl7.Fhir.Model.Uuid, reader, outcome); // 300
							break;
						case "patternAddress":
							result.Pattern = new Hl7.Fhir.Model.Address();
							Parse(result.Pattern as Hl7.Fhir.Model.Address, reader, outcome); // 300
							break;
						case "patternAge":
							result.Pattern = new Hl7.Fhir.Model.Age();
							Parse(result.Pattern as Hl7.Fhir.Model.Age, reader, outcome); // 300
							break;
						case "patternAnnotation":
							result.Pattern = new Hl7.Fhir.Model.Annotation();
							Parse(result.Pattern as Hl7.Fhir.Model.Annotation, reader, outcome); // 300
							break;
						case "patternAttachment":
							result.Pattern = new Hl7.Fhir.Model.Attachment();
							Parse(result.Pattern as Hl7.Fhir.Model.Attachment, reader, outcome); // 300
							break;
						case "patternCodeableConcept":
							result.Pattern = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Pattern as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 300
							break;
						case "patternCoding":
							result.Pattern = new Hl7.Fhir.Model.Coding();
							Parse(result.Pattern as Hl7.Fhir.Model.Coding, reader, outcome); // 300
							break;
						case "patternContactPoint":
							result.Pattern = new Hl7.Fhir.Model.ContactPoint();
							Parse(result.Pattern as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 300
							break;
						case "patternCount":
							result.Pattern = new Hl7.Fhir.Model.Count();
							Parse(result.Pattern as Hl7.Fhir.Model.Count, reader, outcome); // 300
							break;
						case "patternDistance":
							result.Pattern = new Hl7.Fhir.Model.Distance();
							Parse(result.Pattern as Hl7.Fhir.Model.Distance, reader, outcome); // 300
							break;
						case "patternDuration":
							result.Pattern = new Hl7.Fhir.Model.Duration();
							Parse(result.Pattern as Hl7.Fhir.Model.Duration, reader, outcome); // 300
							break;
						case "patternHumanName":
							result.Pattern = new Hl7.Fhir.Model.HumanName();
							Parse(result.Pattern as Hl7.Fhir.Model.HumanName, reader, outcome); // 300
							break;
						case "patternIdentifier":
							result.Pattern = new Hl7.Fhir.Model.Identifier();
							Parse(result.Pattern as Hl7.Fhir.Model.Identifier, reader, outcome); // 300
							break;
						case "patternMoney":
							result.Pattern = new Hl7.Fhir.Model.Money();
							Parse(result.Pattern as Hl7.Fhir.Model.Money, reader, outcome); // 300
							break;
						case "patternPeriod":
							result.Pattern = new Hl7.Fhir.Model.Period();
							Parse(result.Pattern as Hl7.Fhir.Model.Period, reader, outcome); // 300
							break;
						case "patternQuantity":
							result.Pattern = new Hl7.Fhir.Model.Quantity();
							Parse(result.Pattern as Hl7.Fhir.Model.Quantity, reader, outcome); // 300
							break;
						case "patternRange":
							result.Pattern = new Hl7.Fhir.Model.Range();
							Parse(result.Pattern as Hl7.Fhir.Model.Range, reader, outcome); // 300
							break;
						case "patternRatio":
							result.Pattern = new Hl7.Fhir.Model.Ratio();
							Parse(result.Pattern as Hl7.Fhir.Model.Ratio, reader, outcome); // 300
							break;
						case "patternReference":
							result.Pattern = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Pattern as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "patternSampledData":
							result.Pattern = new Hl7.Fhir.Model.SampledData();
							Parse(result.Pattern as Hl7.Fhir.Model.SampledData, reader, outcome); // 300
							break;
						case "patternSignature":
							result.Pattern = new Hl7.Fhir.Model.Signature();
							Parse(result.Pattern as Hl7.Fhir.Model.Signature, reader, outcome); // 300
							break;
						case "patternTiming":
							result.Pattern = new Hl7.Fhir.Model.Timing();
							Parse(result.Pattern as Hl7.Fhir.Model.Timing, reader, outcome); // 300
							break;
						case "patternContactDetail":
							result.Pattern = new Hl7.Fhir.Model.ContactDetail();
							Parse(result.Pattern as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 300
							break;
						case "patternContributor":
							result.Pattern = new Hl7.Fhir.Model.Contributor();
							Parse(result.Pattern as Hl7.Fhir.Model.Contributor, reader, outcome); // 300
							break;
						case "patternDataRequirement":
							result.Pattern = new Hl7.Fhir.Model.DataRequirement();
							Parse(result.Pattern as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 300
							break;
						case "patternExpression":
							result.Pattern = new Hl7.Fhir.Model.Expression();
							Parse(result.Pattern as Hl7.Fhir.Model.Expression, reader, outcome); // 300
							break;
						case "patternParameterDefinition":
							result.Pattern = new Hl7.Fhir.Model.ParameterDefinition();
							Parse(result.Pattern as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 300
							break;
						case "patternRelatedArtifact":
							result.Pattern = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(result.Pattern as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 300
							break;
						case "patternTriggerDefinition":
							result.Pattern = new Hl7.Fhir.Model.TriggerDefinition();
							Parse(result.Pattern as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 300
							break;
						case "patternUsageContext":
							result.Pattern = new Hl7.Fhir.Model.UsageContext();
							Parse(result.Pattern as Hl7.Fhir.Model.UsageContext, reader, outcome); // 300
							break;
						case "patternDosage":
							result.Pattern = new Hl7.Fhir.Model.Dosage();
							Parse(result.Pattern as Hl7.Fhir.Model.Dosage, reader, outcome); // 300
							break;
						case "patternMeta":
							result.Pattern = new Hl7.Fhir.Model.Meta();
							Parse(result.Pattern as Hl7.Fhir.Model.Meta, reader, outcome); // 300
							break;
						case "example":
							var newItem_example = new Hl7.Fhir.Model.ElementDefinition.ExampleComponent();
							Parse(newItem_example, reader, outcome); // 310
							result.Example.Add(newItem_example);
							break;
						case "minValueDate":
							result.MinValue = new Hl7.Fhir.Model.Date();
							Parse(result.MinValue as Hl7.Fhir.Model.Date, reader, outcome); // 320
							break;
						case "minValueDateTime":
							result.MinValue = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.MinValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 320
							break;
						case "minValueInstant":
							result.MinValue = new Hl7.Fhir.Model.Instant();
							Parse(result.MinValue as Hl7.Fhir.Model.Instant, reader, outcome); // 320
							break;
						case "minValueTime":
							result.MinValue = new Hl7.Fhir.Model.Time();
							Parse(result.MinValue as Hl7.Fhir.Model.Time, reader, outcome); // 320
							break;
						case "minValueDecimal":
							result.MinValue = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.MinValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 320
							break;
						case "minValueInteger":
							result.MinValue = new Hl7.Fhir.Model.Integer();
							Parse(result.MinValue as Hl7.Fhir.Model.Integer, reader, outcome); // 320
							break;
						case "minValuePositiveInt":
							result.MinValue = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.MinValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 320
							break;
						case "minValueUnsignedInt":
							result.MinValue = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.MinValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 320
							break;
						case "minValueQuantity":
							result.MinValue = new Hl7.Fhir.Model.Quantity();
							Parse(result.MinValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 320
							break;
						case "maxValueDate":
							result.MaxValue = new Hl7.Fhir.Model.Date();
							Parse(result.MaxValue as Hl7.Fhir.Model.Date, reader, outcome); // 330
							break;
						case "maxValueDateTime":
							result.MaxValue = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.MaxValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 330
							break;
						case "maxValueInstant":
							result.MaxValue = new Hl7.Fhir.Model.Instant();
							Parse(result.MaxValue as Hl7.Fhir.Model.Instant, reader, outcome); // 330
							break;
						case "maxValueTime":
							result.MaxValue = new Hl7.Fhir.Model.Time();
							Parse(result.MaxValue as Hl7.Fhir.Model.Time, reader, outcome); // 330
							break;
						case "maxValueDecimal":
							result.MaxValue = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.MaxValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 330
							break;
						case "maxValueInteger":
							result.MaxValue = new Hl7.Fhir.Model.Integer();
							Parse(result.MaxValue as Hl7.Fhir.Model.Integer, reader, outcome); // 330
							break;
						case "maxValuePositiveInt":
							result.MaxValue = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.MaxValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 330
							break;
						case "maxValueUnsignedInt":
							result.MaxValue = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.MaxValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 330
							break;
						case "maxValueQuantity":
							result.MaxValue = new Hl7.Fhir.Model.Quantity();
							Parse(result.MaxValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 330
							break;
						case "maxLength":
							result.MaxLengthElement = new Hl7.Fhir.Model.Integer();
							Parse(result.MaxLengthElement as Hl7.Fhir.Model.Integer, reader, outcome); // 340
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.Id();
							Parse(newItem_condition, reader, outcome); // 350
							result.ConditionElement.Add(newItem_condition);
							break;
						case "constraint":
							var newItem_constraint = new Hl7.Fhir.Model.ElementDefinition.ConstraintComponent();
							Parse(newItem_constraint, reader, outcome); // 360
							result.Constraint.Add(newItem_constraint);
							break;
						case "mustSupport":
							result.MustSupportElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.MustSupportElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 370
							break;
						case "isModifier":
							result.IsModifierElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsModifierElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 380
							break;
						case "isModifierReason":
							result.IsModifierReasonElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.IsModifierReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 390
							break;
						case "isSummary":
							result.IsSummaryElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsSummaryElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 400
							break;
						case "binding":
							result.Binding = new Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent();
							Parse(result.Binding as Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent, reader, outcome); // 410
							break;
						case "mapping":
							var newItem_mapping = new Hl7.Fhir.Model.ElementDefinition.MappingComponent();
							Parse(newItem_mapping, reader, outcome); // 420
							result.Mapping.Add(newItem_mapping);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ElementDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "path":
							result.PathElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PathElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "representation":
							var newItem_representation = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.PropertyRepresentation>();
							await ParseAsync(newItem_representation, reader, outcome); // 100
							result.RepresentationElement.Add(newItem_representation);
							break;
						case "sliceName":
							result.SliceNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SliceNameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 110
							break;
						case "sliceIsConstraining":
							result.SliceIsConstrainingElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.SliceIsConstrainingElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 120
							break;
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_code, reader, outcome); // 140
							result.Code.Add(newItem_code);
							break;
						case "slicing":
							result.Slicing = new Hl7.Fhir.Model.ElementDefinition.SlicingComponent();
							await ParseAsync(result.Slicing as Hl7.Fhir.Model.ElementDefinition.SlicingComponent, reader, outcome); // 150
							break;
						case "short":
							result.ShortElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ShortElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "definition":
							result.Definition = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.Markdown, reader, outcome); // 170
							break;
						case "comment":
							result.Comment = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Comment as Hl7.Fhir.Model.Markdown, reader, outcome); // 180
							break;
						case "requirements":
							result.Requirements = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Requirements as Hl7.Fhir.Model.Markdown, reader, outcome); // 190
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_alias, reader, outcome); // 200
							result.AliasElement.Add(newItem_alias);
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.MinElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 210
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 220
							break;
						case "base":
							result.Base = new Hl7.Fhir.Model.ElementDefinition.BaseComponent();
							await ParseAsync(result.Base as Hl7.Fhir.Model.ElementDefinition.BaseComponent, reader, outcome); // 230
							break;
						case "contentReference":
							result.ContentReferenceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ContentReferenceElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 240
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.ElementDefinition.TypeRefComponent();
							await ParseAsync(newItem_type, reader, outcome); // 250
							result.Type.Add(newItem_type);
							break;
						case "defaultValueBase64Binary":
							result.DefaultValue = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 260
							break;
						case "defaultValueBoolean":
							result.DefaultValue = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 260
							break;
						case "defaultValueCanonical":
							result.DefaultValue = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Canonical, reader, outcome); // 260
							break;
						case "defaultValueCode":
							result.DefaultValue = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Code, reader, outcome); // 260
							break;
						case "defaultValueDate":
							result.DefaultValue = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Date, reader, outcome); // 260
							break;
						case "defaultValueDateTime":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 260
							break;
						case "defaultValueDecimal":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 260
							break;
						case "defaultValueId":
							result.DefaultValue = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Id, reader, outcome); // 260
							break;
						case "defaultValueInstant":
							result.DefaultValue = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Instant, reader, outcome); // 260
							break;
						case "defaultValueInteger":
							result.DefaultValue = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Integer, reader, outcome); // 260
							break;
						case "defaultValueMarkdown":
							result.DefaultValue = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Markdown, reader, outcome); // 260
							break;
						case "defaultValueOid":
							result.DefaultValue = new Hl7.Fhir.Model.Oid();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Oid, reader, outcome); // 260
							break;
						case "defaultValuePositiveInt":
							result.DefaultValue = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 260
							break;
						case "defaultValueString":
							result.DefaultValue = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirString, reader, outcome); // 260
							break;
						case "defaultValueTime":
							result.DefaultValue = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Time, reader, outcome); // 260
							break;
						case "defaultValueUnsignedInt":
							result.DefaultValue = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 260
							break;
						case "defaultValueUri":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirUri, reader, outcome); // 260
							break;
						case "defaultValueUrl":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 260
							break;
						case "defaultValueUuid":
							result.DefaultValue = new Hl7.Fhir.Model.Uuid();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Uuid, reader, outcome); // 260
							break;
						case "defaultValueAddress":
							result.DefaultValue = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Address, reader, outcome); // 260
							break;
						case "defaultValueAge":
							result.DefaultValue = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Age, reader, outcome); // 260
							break;
						case "defaultValueAnnotation":
							result.DefaultValue = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Annotation, reader, outcome); // 260
							break;
						case "defaultValueAttachment":
							result.DefaultValue = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Attachment, reader, outcome); // 260
							break;
						case "defaultValueCodeableConcept":
							result.DefaultValue = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 260
							break;
						case "defaultValueCoding":
							result.DefaultValue = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Coding, reader, outcome); // 260
							break;
						case "defaultValueContactPoint":
							result.DefaultValue = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 260
							break;
						case "defaultValueCount":
							result.DefaultValue = new Hl7.Fhir.Model.Count();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Count, reader, outcome); // 260
							break;
						case "defaultValueDistance":
							result.DefaultValue = new Hl7.Fhir.Model.Distance();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Distance, reader, outcome); // 260
							break;
						case "defaultValueDuration":
							result.DefaultValue = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Duration, reader, outcome); // 260
							break;
						case "defaultValueHumanName":
							result.DefaultValue = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.HumanName, reader, outcome); // 260
							break;
						case "defaultValueIdentifier":
							result.DefaultValue = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Identifier, reader, outcome); // 260
							break;
						case "defaultValueMoney":
							result.DefaultValue = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Money, reader, outcome); // 260
							break;
						case "defaultValuePeriod":
							result.DefaultValue = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Period, reader, outcome); // 260
							break;
						case "defaultValueQuantity":
							result.DefaultValue = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 260
							break;
						case "defaultValueRange":
							result.DefaultValue = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Range, reader, outcome); // 260
							break;
						case "defaultValueRatio":
							result.DefaultValue = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Ratio, reader, outcome); // 260
							break;
						case "defaultValueReference":
							result.DefaultValue = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 260
							break;
						case "defaultValueSampledData":
							result.DefaultValue = new Hl7.Fhir.Model.SampledData();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.SampledData, reader, outcome); // 260
							break;
						case "defaultValueSignature":
							result.DefaultValue = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Signature, reader, outcome); // 260
							break;
						case "defaultValueTiming":
							result.DefaultValue = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Timing, reader, outcome); // 260
							break;
						case "defaultValueContactDetail":
							result.DefaultValue = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 260
							break;
						case "defaultValueContributor":
							result.DefaultValue = new Hl7.Fhir.Model.Contributor();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Contributor, reader, outcome); // 260
							break;
						case "defaultValueDataRequirement":
							result.DefaultValue = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 260
							break;
						case "defaultValueExpression":
							result.DefaultValue = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Expression, reader, outcome); // 260
							break;
						case "defaultValueParameterDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.ParameterDefinition();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 260
							break;
						case "defaultValueRelatedArtifact":
							result.DefaultValue = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 260
							break;
						case "defaultValueTriggerDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.TriggerDefinition();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 260
							break;
						case "defaultValueUsageContext":
							result.DefaultValue = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.UsageContext, reader, outcome); // 260
							break;
						case "defaultValueDosage":
							result.DefaultValue = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Dosage, reader, outcome); // 260
							break;
						case "defaultValueMeta":
							result.DefaultValue = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Meta, reader, outcome); // 260
							break;
						case "meaningWhenMissing":
							result.MeaningWhenMissing = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.MeaningWhenMissing as Hl7.Fhir.Model.Markdown, reader, outcome); // 270
							break;
						case "orderMeaning":
							result.OrderMeaningElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.OrderMeaningElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 280
							break;
						case "fixedBase64Binary":
							result.Fixed = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 290
							break;
						case "fixedBoolean":
							result.Fixed = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 290
							break;
						case "fixedCanonical":
							result.Fixed = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Canonical, reader, outcome); // 290
							break;
						case "fixedCode":
							result.Fixed = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Code, reader, outcome); // 290
							break;
						case "fixedDate":
							result.Fixed = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Date, reader, outcome); // 290
							break;
						case "fixedDateTime":
							result.Fixed = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 290
							break;
						case "fixedDecimal":
							result.Fixed = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 290
							break;
						case "fixedId":
							result.Fixed = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Id, reader, outcome); // 290
							break;
						case "fixedInstant":
							result.Fixed = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Instant, reader, outcome); // 290
							break;
						case "fixedInteger":
							result.Fixed = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Integer, reader, outcome); // 290
							break;
						case "fixedMarkdown":
							result.Fixed = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Markdown, reader, outcome); // 290
							break;
						case "fixedOid":
							result.Fixed = new Hl7.Fhir.Model.Oid();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Oid, reader, outcome); // 290
							break;
						case "fixedPositiveInt":
							result.Fixed = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 290
							break;
						case "fixedString":
							result.Fixed = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.FhirString, reader, outcome); // 290
							break;
						case "fixedTime":
							result.Fixed = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Time, reader, outcome); // 290
							break;
						case "fixedUnsignedInt":
							result.Fixed = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 290
							break;
						case "fixedUri":
							result.Fixed = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.FhirUri, reader, outcome); // 290
							break;
						case "fixedUrl":
							result.Fixed = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 290
							break;
						case "fixedUuid":
							result.Fixed = new Hl7.Fhir.Model.Uuid();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Uuid, reader, outcome); // 290
							break;
						case "fixedAddress":
							result.Fixed = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Address, reader, outcome); // 290
							break;
						case "fixedAge":
							result.Fixed = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Age, reader, outcome); // 290
							break;
						case "fixedAnnotation":
							result.Fixed = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Annotation, reader, outcome); // 290
							break;
						case "fixedAttachment":
							result.Fixed = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Attachment, reader, outcome); // 290
							break;
						case "fixedCodeableConcept":
							result.Fixed = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 290
							break;
						case "fixedCoding":
							result.Fixed = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Coding, reader, outcome); // 290
							break;
						case "fixedContactPoint":
							result.Fixed = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 290
							break;
						case "fixedCount":
							result.Fixed = new Hl7.Fhir.Model.Count();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Count, reader, outcome); // 290
							break;
						case "fixedDistance":
							result.Fixed = new Hl7.Fhir.Model.Distance();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Distance, reader, outcome); // 290
							break;
						case "fixedDuration":
							result.Fixed = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Duration, reader, outcome); // 290
							break;
						case "fixedHumanName":
							result.Fixed = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.HumanName, reader, outcome); // 290
							break;
						case "fixedIdentifier":
							result.Fixed = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Identifier, reader, outcome); // 290
							break;
						case "fixedMoney":
							result.Fixed = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Money, reader, outcome); // 290
							break;
						case "fixedPeriod":
							result.Fixed = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Period, reader, outcome); // 290
							break;
						case "fixedQuantity":
							result.Fixed = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Quantity, reader, outcome); // 290
							break;
						case "fixedRange":
							result.Fixed = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Range, reader, outcome); // 290
							break;
						case "fixedRatio":
							result.Fixed = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Ratio, reader, outcome); // 290
							break;
						case "fixedReference":
							result.Fixed = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 290
							break;
						case "fixedSampledData":
							result.Fixed = new Hl7.Fhir.Model.SampledData();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.SampledData, reader, outcome); // 290
							break;
						case "fixedSignature":
							result.Fixed = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Signature, reader, outcome); // 290
							break;
						case "fixedTiming":
							result.Fixed = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Timing, reader, outcome); // 290
							break;
						case "fixedContactDetail":
							result.Fixed = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 290
							break;
						case "fixedContributor":
							result.Fixed = new Hl7.Fhir.Model.Contributor();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Contributor, reader, outcome); // 290
							break;
						case "fixedDataRequirement":
							result.Fixed = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 290
							break;
						case "fixedExpression":
							result.Fixed = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Expression, reader, outcome); // 290
							break;
						case "fixedParameterDefinition":
							result.Fixed = new Hl7.Fhir.Model.ParameterDefinition();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 290
							break;
						case "fixedRelatedArtifact":
							result.Fixed = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 290
							break;
						case "fixedTriggerDefinition":
							result.Fixed = new Hl7.Fhir.Model.TriggerDefinition();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 290
							break;
						case "fixedUsageContext":
							result.Fixed = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.UsageContext, reader, outcome); // 290
							break;
						case "fixedDosage":
							result.Fixed = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Dosage, reader, outcome); // 290
							break;
						case "fixedMeta":
							result.Fixed = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Fixed as Hl7.Fhir.Model.Meta, reader, outcome); // 290
							break;
						case "patternBase64Binary":
							result.Pattern = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 300
							break;
						case "patternBoolean":
							result.Pattern = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 300
							break;
						case "patternCanonical":
							result.Pattern = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Canonical, reader, outcome); // 300
							break;
						case "patternCode":
							result.Pattern = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Code, reader, outcome); // 300
							break;
						case "patternDate":
							result.Pattern = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Date, reader, outcome); // 300
							break;
						case "patternDateTime":
							result.Pattern = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 300
							break;
						case "patternDecimal":
							result.Pattern = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 300
							break;
						case "patternId":
							result.Pattern = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Id, reader, outcome); // 300
							break;
						case "patternInstant":
							result.Pattern = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Instant, reader, outcome); // 300
							break;
						case "patternInteger":
							result.Pattern = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Integer, reader, outcome); // 300
							break;
						case "patternMarkdown":
							result.Pattern = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Markdown, reader, outcome); // 300
							break;
						case "patternOid":
							result.Pattern = new Hl7.Fhir.Model.Oid();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Oid, reader, outcome); // 300
							break;
						case "patternPositiveInt":
							result.Pattern = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 300
							break;
						case "patternString":
							result.Pattern = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.FhirString, reader, outcome); // 300
							break;
						case "patternTime":
							result.Pattern = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Time, reader, outcome); // 300
							break;
						case "patternUnsignedInt":
							result.Pattern = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 300
							break;
						case "patternUri":
							result.Pattern = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.FhirUri, reader, outcome); // 300
							break;
						case "patternUrl":
							result.Pattern = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 300
							break;
						case "patternUuid":
							result.Pattern = new Hl7.Fhir.Model.Uuid();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Uuid, reader, outcome); // 300
							break;
						case "patternAddress":
							result.Pattern = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Address, reader, outcome); // 300
							break;
						case "patternAge":
							result.Pattern = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Age, reader, outcome); // 300
							break;
						case "patternAnnotation":
							result.Pattern = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Annotation, reader, outcome); // 300
							break;
						case "patternAttachment":
							result.Pattern = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Attachment, reader, outcome); // 300
							break;
						case "patternCodeableConcept":
							result.Pattern = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 300
							break;
						case "patternCoding":
							result.Pattern = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Coding, reader, outcome); // 300
							break;
						case "patternContactPoint":
							result.Pattern = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 300
							break;
						case "patternCount":
							result.Pattern = new Hl7.Fhir.Model.Count();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Count, reader, outcome); // 300
							break;
						case "patternDistance":
							result.Pattern = new Hl7.Fhir.Model.Distance();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Distance, reader, outcome); // 300
							break;
						case "patternDuration":
							result.Pattern = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Duration, reader, outcome); // 300
							break;
						case "patternHumanName":
							result.Pattern = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.HumanName, reader, outcome); // 300
							break;
						case "patternIdentifier":
							result.Pattern = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Identifier, reader, outcome); // 300
							break;
						case "patternMoney":
							result.Pattern = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Money, reader, outcome); // 300
							break;
						case "patternPeriod":
							result.Pattern = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Period, reader, outcome); // 300
							break;
						case "patternQuantity":
							result.Pattern = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Quantity, reader, outcome); // 300
							break;
						case "patternRange":
							result.Pattern = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Range, reader, outcome); // 300
							break;
						case "patternRatio":
							result.Pattern = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Ratio, reader, outcome); // 300
							break;
						case "patternReference":
							result.Pattern = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 300
							break;
						case "patternSampledData":
							result.Pattern = new Hl7.Fhir.Model.SampledData();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.SampledData, reader, outcome); // 300
							break;
						case "patternSignature":
							result.Pattern = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Signature, reader, outcome); // 300
							break;
						case "patternTiming":
							result.Pattern = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Timing, reader, outcome); // 300
							break;
						case "patternContactDetail":
							result.Pattern = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 300
							break;
						case "patternContributor":
							result.Pattern = new Hl7.Fhir.Model.Contributor();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Contributor, reader, outcome); // 300
							break;
						case "patternDataRequirement":
							result.Pattern = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 300
							break;
						case "patternExpression":
							result.Pattern = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Expression, reader, outcome); // 300
							break;
						case "patternParameterDefinition":
							result.Pattern = new Hl7.Fhir.Model.ParameterDefinition();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 300
							break;
						case "patternRelatedArtifact":
							result.Pattern = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 300
							break;
						case "patternTriggerDefinition":
							result.Pattern = new Hl7.Fhir.Model.TriggerDefinition();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 300
							break;
						case "patternUsageContext":
							result.Pattern = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.UsageContext, reader, outcome); // 300
							break;
						case "patternDosage":
							result.Pattern = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Dosage, reader, outcome); // 300
							break;
						case "patternMeta":
							result.Pattern = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Pattern as Hl7.Fhir.Model.Meta, reader, outcome); // 300
							break;
						case "example":
							var newItem_example = new Hl7.Fhir.Model.ElementDefinition.ExampleComponent();
							await ParseAsync(newItem_example, reader, outcome); // 310
							result.Example.Add(newItem_example);
							break;
						case "minValueDate":
							result.MinValue = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.Date, reader, outcome); // 320
							break;
						case "minValueDateTime":
							result.MinValue = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 320
							break;
						case "minValueInstant":
							result.MinValue = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.Instant, reader, outcome); // 320
							break;
						case "minValueTime":
							result.MinValue = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.Time, reader, outcome); // 320
							break;
						case "minValueDecimal":
							result.MinValue = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 320
							break;
						case "minValueInteger":
							result.MinValue = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.Integer, reader, outcome); // 320
							break;
						case "minValuePositiveInt":
							result.MinValue = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 320
							break;
						case "minValueUnsignedInt":
							result.MinValue = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 320
							break;
						case "minValueQuantity":
							result.MinValue = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.MinValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 320
							break;
						case "maxValueDate":
							result.MaxValue = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.Date, reader, outcome); // 330
							break;
						case "maxValueDateTime":
							result.MaxValue = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 330
							break;
						case "maxValueInstant":
							result.MaxValue = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.Instant, reader, outcome); // 330
							break;
						case "maxValueTime":
							result.MaxValue = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.Time, reader, outcome); // 330
							break;
						case "maxValueDecimal":
							result.MaxValue = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 330
							break;
						case "maxValueInteger":
							result.MaxValue = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.Integer, reader, outcome); // 330
							break;
						case "maxValuePositiveInt":
							result.MaxValue = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 330
							break;
						case "maxValueUnsignedInt":
							result.MaxValue = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 330
							break;
						case "maxValueQuantity":
							result.MaxValue = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.MaxValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 330
							break;
						case "maxLength":
							result.MaxLengthElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MaxLengthElement as Hl7.Fhir.Model.Integer, reader, outcome); // 340
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.Id();
							await ParseAsync(newItem_condition, reader, outcome); // 350
							result.ConditionElement.Add(newItem_condition);
							break;
						case "constraint":
							var newItem_constraint = new Hl7.Fhir.Model.ElementDefinition.ConstraintComponent();
							await ParseAsync(newItem_constraint, reader, outcome); // 360
							result.Constraint.Add(newItem_constraint);
							break;
						case "mustSupport":
							result.MustSupportElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.MustSupportElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 370
							break;
						case "isModifier":
							result.IsModifierElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsModifierElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 380
							break;
						case "isModifierReason":
							result.IsModifierReasonElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.IsModifierReasonElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 390
							break;
						case "isSummary":
							result.IsSummaryElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsSummaryElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 400
							break;
						case "binding":
							result.Binding = new Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent();
							await ParseAsync(result.Binding as Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent, reader, outcome); // 410
							break;
						case "mapping":
							var newItem_mapping = new Hl7.Fhir.Model.ElementDefinition.MappingComponent();
							await ParseAsync(newItem_mapping, reader, outcome); // 420
							result.Mapping.Add(newItem_mapping);
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
