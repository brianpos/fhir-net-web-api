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
		public void Parse(Hl7.Fhir.Model.StructureMap.SourceComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "context":
							result.ContextElement = new Hl7.Fhir.Model.Id();
							Parse(result.ContextElement as Hl7.Fhir.Model.Id, reader, outcome); // 40
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.Integer();
							Parse(result.MinElement as Hl7.Fhir.Model.Integer, reader, outcome); // 50
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TypeElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "defaultValueBase64Binary":
							result.DefaultValue = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 80
							break;
						case "defaultValueBoolean":
							result.DefaultValue = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 80
							break;
						case "defaultValueCanonical":
							result.DefaultValue = new Hl7.Fhir.Model.Canonical();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Canonical, reader, outcome); // 80
							break;
						case "defaultValueCode":
							result.DefaultValue = new Hl7.Fhir.Model.Code();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Code, reader, outcome); // 80
							break;
						case "defaultValueDate":
							result.DefaultValue = new Hl7.Fhir.Model.Date();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Date, reader, outcome); // 80
							break;
						case "defaultValueDateTime":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 80
							break;
						case "defaultValueDecimal":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 80
							break;
						case "defaultValueId":
							result.DefaultValue = new Hl7.Fhir.Model.Id();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Id, reader, outcome); // 80
							break;
						case "defaultValueInstant":
							result.DefaultValue = new Hl7.Fhir.Model.Instant();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Instant, reader, outcome); // 80
							break;
						case "defaultValueInteger":
							result.DefaultValue = new Hl7.Fhir.Model.Integer();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Integer, reader, outcome); // 80
							break;
						case "defaultValueMarkdown":
							result.DefaultValue = new Hl7.Fhir.Model.Markdown();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Markdown, reader, outcome); // 80
							break;
						case "defaultValueOid":
							result.DefaultValue = new Hl7.Fhir.Model.Oid();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Oid, reader, outcome); // 80
							break;
						case "defaultValuePositiveInt":
							result.DefaultValue = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.DefaultValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 80
							break;
						case "defaultValueString":
							result.DefaultValue = new Hl7.Fhir.Model.FhirString();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirString, reader, outcome); // 80
							break;
						case "defaultValueTime":
							result.DefaultValue = new Hl7.Fhir.Model.Time();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Time, reader, outcome); // 80
							break;
						case "defaultValueUnsignedInt":
							result.DefaultValue = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.DefaultValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 80
							break;
						case "defaultValueUri":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUri();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirUri, reader, outcome); // 80
							break;
						case "defaultValueUrl":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.DefaultValue as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 80
							break;
						case "defaultValueUuid":
							result.DefaultValue = new Hl7.Fhir.Model.Uuid();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Uuid, reader, outcome); // 80
							break;
						case "defaultValueAddress":
							result.DefaultValue = new Hl7.Fhir.Model.Address();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Address, reader, outcome); // 80
							break;
						case "defaultValueAge":
							result.DefaultValue = new Hl7.Fhir.Model.Age();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Age, reader, outcome); // 80
							break;
						case "defaultValueAnnotation":
							result.DefaultValue = new Hl7.Fhir.Model.Annotation();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Annotation, reader, outcome); // 80
							break;
						case "defaultValueAttachment":
							result.DefaultValue = new Hl7.Fhir.Model.Attachment();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Attachment, reader, outcome); // 80
							break;
						case "defaultValueCodeableConcept":
							result.DefaultValue = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DefaultValue as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 80
							break;
						case "defaultValueCoding":
							result.DefaultValue = new Hl7.Fhir.Model.Coding();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Coding, reader, outcome); // 80
							break;
						case "defaultValueContactPoint":
							result.DefaultValue = new Hl7.Fhir.Model.ContactPoint();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 80
							break;
						case "defaultValueCount":
							result.DefaultValue = new Hl7.Fhir.Model.Count();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Count, reader, outcome); // 80
							break;
						case "defaultValueDistance":
							result.DefaultValue = new Hl7.Fhir.Model.Distance();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Distance, reader, outcome); // 80
							break;
						case "defaultValueDuration":
							result.DefaultValue = new Hl7.Fhir.Model.Duration();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Duration, reader, outcome); // 80
							break;
						case "defaultValueHumanName":
							result.DefaultValue = new Hl7.Fhir.Model.HumanName();
							Parse(result.DefaultValue as Hl7.Fhir.Model.HumanName, reader, outcome); // 80
							break;
						case "defaultValueIdentifier":
							result.DefaultValue = new Hl7.Fhir.Model.Identifier();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Identifier, reader, outcome); // 80
							break;
						case "defaultValueMoney":
							result.DefaultValue = new Hl7.Fhir.Model.Money();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Money, reader, outcome); // 80
							break;
						case "defaultValuePeriod":
							result.DefaultValue = new Hl7.Fhir.Model.Period();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Period, reader, outcome); // 80
							break;
						case "defaultValueQuantity":
							result.DefaultValue = new Hl7.Fhir.Model.Quantity();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 80
							break;
						case "defaultValueRange":
							result.DefaultValue = new Hl7.Fhir.Model.Range();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Range, reader, outcome); // 80
							break;
						case "defaultValueRatio":
							result.DefaultValue = new Hl7.Fhir.Model.Ratio();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Ratio, reader, outcome); // 80
							break;
						case "defaultValueReference":
							result.DefaultValue = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 80
							break;
						case "defaultValueSampledData":
							result.DefaultValue = new Hl7.Fhir.Model.SampledData();
							Parse(result.DefaultValue as Hl7.Fhir.Model.SampledData, reader, outcome); // 80
							break;
						case "defaultValueSignature":
							result.DefaultValue = new Hl7.Fhir.Model.Signature();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Signature, reader, outcome); // 80
							break;
						case "defaultValueTiming":
							result.DefaultValue = new Hl7.Fhir.Model.Timing();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Timing, reader, outcome); // 80
							break;
						case "defaultValueContactDetail":
							result.DefaultValue = new Hl7.Fhir.Model.ContactDetail();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 80
							break;
						case "defaultValueContributor":
							result.DefaultValue = new Hl7.Fhir.Model.Contributor();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Contributor, reader, outcome); // 80
							break;
						case "defaultValueDataRequirement":
							result.DefaultValue = new Hl7.Fhir.Model.DataRequirement();
							Parse(result.DefaultValue as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 80
							break;
						case "defaultValueExpression":
							result.DefaultValue = new Hl7.Fhir.Model.Expression();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Expression, reader, outcome); // 80
							break;
						case "defaultValueParameterDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.ParameterDefinition();
							Parse(result.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 80
							break;
						case "defaultValueRelatedArtifact":
							result.DefaultValue = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(result.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 80
							break;
						case "defaultValueTriggerDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.TriggerDefinition();
							Parse(result.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 80
							break;
						case "defaultValueUsageContext":
							result.DefaultValue = new Hl7.Fhir.Model.UsageContext();
							Parse(result.DefaultValue as Hl7.Fhir.Model.UsageContext, reader, outcome); // 80
							break;
						case "defaultValueDosage":
							result.DefaultValue = new Hl7.Fhir.Model.Dosage();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Dosage, reader, outcome); // 80
							break;
						case "defaultValueMeta":
							result.DefaultValue = new Hl7.Fhir.Model.Meta();
							Parse(result.DefaultValue as Hl7.Fhir.Model.Meta, reader, outcome); // 80
							break;
						case "element":
							result.ElementElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ElementElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "listMode":
							result.ListModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapSourceListMode>();
							Parse(result.ListModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapSourceListMode>, reader, outcome); // 100
							break;
						case "variable":
							result.VariableElement = new Hl7.Fhir.Model.Id();
							Parse(result.VariableElement as Hl7.Fhir.Model.Id, reader, outcome); // 110
							break;
						case "condition":
							result.ConditionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ConditionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "check":
							result.CheckElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CheckElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "logMessage":
							result.LogMessageElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LogMessageElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.StructureMap.SourceComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "context":
							result.ContextElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ContextElement as Hl7.Fhir.Model.Id, reader, outcome); // 40
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MinElement as Hl7.Fhir.Model.Integer, reader, outcome); // 50
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 70
							break;
						case "defaultValueBase64Binary":
							result.DefaultValue = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 80
							break;
						case "defaultValueBoolean":
							result.DefaultValue = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 80
							break;
						case "defaultValueCanonical":
							result.DefaultValue = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Canonical, reader, outcome); // 80
							break;
						case "defaultValueCode":
							result.DefaultValue = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Code, reader, outcome); // 80
							break;
						case "defaultValueDate":
							result.DefaultValue = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Date, reader, outcome); // 80
							break;
						case "defaultValueDateTime":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 80
							break;
						case "defaultValueDecimal":
							result.DefaultValue = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 80
							break;
						case "defaultValueId":
							result.DefaultValue = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Id, reader, outcome); // 80
							break;
						case "defaultValueInstant":
							result.DefaultValue = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Instant, reader, outcome); // 80
							break;
						case "defaultValueInteger":
							result.DefaultValue = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Integer, reader, outcome); // 80
							break;
						case "defaultValueMarkdown":
							result.DefaultValue = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Markdown, reader, outcome); // 80
							break;
						case "defaultValueOid":
							result.DefaultValue = new Hl7.Fhir.Model.Oid();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Oid, reader, outcome); // 80
							break;
						case "defaultValuePositiveInt":
							result.DefaultValue = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 80
							break;
						case "defaultValueString":
							result.DefaultValue = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirString, reader, outcome); // 80
							break;
						case "defaultValueTime":
							result.DefaultValue = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Time, reader, outcome); // 80
							break;
						case "defaultValueUnsignedInt":
							result.DefaultValue = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 80
							break;
						case "defaultValueUri":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirUri, reader, outcome); // 80
							break;
						case "defaultValueUrl":
							result.DefaultValue = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 80
							break;
						case "defaultValueUuid":
							result.DefaultValue = new Hl7.Fhir.Model.Uuid();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Uuid, reader, outcome); // 80
							break;
						case "defaultValueAddress":
							result.DefaultValue = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Address, reader, outcome); // 80
							break;
						case "defaultValueAge":
							result.DefaultValue = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Age, reader, outcome); // 80
							break;
						case "defaultValueAnnotation":
							result.DefaultValue = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Annotation, reader, outcome); // 80
							break;
						case "defaultValueAttachment":
							result.DefaultValue = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Attachment, reader, outcome); // 80
							break;
						case "defaultValueCodeableConcept":
							result.DefaultValue = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 80
							break;
						case "defaultValueCoding":
							result.DefaultValue = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Coding, reader, outcome); // 80
							break;
						case "defaultValueContactPoint":
							result.DefaultValue = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 80
							break;
						case "defaultValueCount":
							result.DefaultValue = new Hl7.Fhir.Model.Count();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Count, reader, outcome); // 80
							break;
						case "defaultValueDistance":
							result.DefaultValue = new Hl7.Fhir.Model.Distance();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Distance, reader, outcome); // 80
							break;
						case "defaultValueDuration":
							result.DefaultValue = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Duration, reader, outcome); // 80
							break;
						case "defaultValueHumanName":
							result.DefaultValue = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.HumanName, reader, outcome); // 80
							break;
						case "defaultValueIdentifier":
							result.DefaultValue = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Identifier, reader, outcome); // 80
							break;
						case "defaultValueMoney":
							result.DefaultValue = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Money, reader, outcome); // 80
							break;
						case "defaultValuePeriod":
							result.DefaultValue = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Period, reader, outcome); // 80
							break;
						case "defaultValueQuantity":
							result.DefaultValue = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Quantity, reader, outcome); // 80
							break;
						case "defaultValueRange":
							result.DefaultValue = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Range, reader, outcome); // 80
							break;
						case "defaultValueRatio":
							result.DefaultValue = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Ratio, reader, outcome); // 80
							break;
						case "defaultValueReference":
							result.DefaultValue = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 80
							break;
						case "defaultValueSampledData":
							result.DefaultValue = new Hl7.Fhir.Model.SampledData();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.SampledData, reader, outcome); // 80
							break;
						case "defaultValueSignature":
							result.DefaultValue = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Signature, reader, outcome); // 80
							break;
						case "defaultValueTiming":
							result.DefaultValue = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Timing, reader, outcome); // 80
							break;
						case "defaultValueContactDetail":
							result.DefaultValue = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 80
							break;
						case "defaultValueContributor":
							result.DefaultValue = new Hl7.Fhir.Model.Contributor();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Contributor, reader, outcome); // 80
							break;
						case "defaultValueDataRequirement":
							result.DefaultValue = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 80
							break;
						case "defaultValueExpression":
							result.DefaultValue = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Expression, reader, outcome); // 80
							break;
						case "defaultValueParameterDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.ParameterDefinition();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 80
							break;
						case "defaultValueRelatedArtifact":
							result.DefaultValue = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 80
							break;
						case "defaultValueTriggerDefinition":
							result.DefaultValue = new Hl7.Fhir.Model.TriggerDefinition();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 80
							break;
						case "defaultValueUsageContext":
							result.DefaultValue = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.UsageContext, reader, outcome); // 80
							break;
						case "defaultValueDosage":
							result.DefaultValue = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Dosage, reader, outcome); // 80
							break;
						case "defaultValueMeta":
							result.DefaultValue = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.DefaultValue as Hl7.Fhir.Model.Meta, reader, outcome); // 80
							break;
						case "element":
							result.ElementElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ElementElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 90
							break;
						case "listMode":
							result.ListModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapSourceListMode>();
							await ParseAsync(result.ListModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureMap.StructureMapSourceListMode>, reader, outcome); // 100
							break;
						case "variable":
							result.VariableElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.VariableElement as Hl7.Fhir.Model.Id, reader, outcome); // 110
							break;
						case "condition":
							result.ConditionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ConditionElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 120
							break;
						case "check":
							result.CheckElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CheckElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 130
							break;
						case "logMessage":
							result.LogMessageElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LogMessageElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 140
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
