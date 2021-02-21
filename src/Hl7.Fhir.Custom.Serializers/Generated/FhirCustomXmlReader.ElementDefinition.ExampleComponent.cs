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
		public void Parse(Hl7.Fhir.Model.ElementDefinition.ExampleComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "valueBase64Binary":
							result.Value = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.Value as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 50
							break;
						case "valueBoolean":
							result.Value = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Value as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "valueCanonical":
							result.Value = new Hl7.Fhir.Model.Canonical();
							Parse(result.Value as Hl7.Fhir.Model.Canonical, reader, outcome); // 50
							break;
						case "valueCode":
							result.Value = new Hl7.Fhir.Model.Code();
							Parse(result.Value as Hl7.Fhir.Model.Code, reader, outcome); // 50
							break;
						case "valueDate":
							result.Value = new Hl7.Fhir.Model.Date();
							Parse(result.Value as Hl7.Fhir.Model.Date, reader, outcome); // 50
							break;
						case "valueDateTime":
							result.Value = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Value as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 50
							break;
						case "valueDecimal":
							result.Value = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.Value as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 50
							break;
						case "valueId":
							result.Value = new Hl7.Fhir.Model.Id();
							Parse(result.Value as Hl7.Fhir.Model.Id, reader, outcome); // 50
							break;
						case "valueInstant":
							result.Value = new Hl7.Fhir.Model.Instant();
							Parse(result.Value as Hl7.Fhir.Model.Instant, reader, outcome); // 50
							break;
						case "valueInteger":
							result.Value = new Hl7.Fhir.Model.Integer();
							Parse(result.Value as Hl7.Fhir.Model.Integer, reader, outcome); // 50
							break;
						case "valueMarkdown":
							result.Value = new Hl7.Fhir.Model.Markdown();
							Parse(result.Value as Hl7.Fhir.Model.Markdown, reader, outcome); // 50
							break;
						case "valueOid":
							result.Value = new Hl7.Fhir.Model.Oid();
							Parse(result.Value as Hl7.Fhir.Model.Oid, reader, outcome); // 50
							break;
						case "valuePositiveInt":
							result.Value = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.Value as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 50
							break;
						case "valueString":
							result.Value = new Hl7.Fhir.Model.FhirString();
							Parse(result.Value as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "valueTime":
							result.Value = new Hl7.Fhir.Model.Time();
							Parse(result.Value as Hl7.Fhir.Model.Time, reader, outcome); // 50
							break;
						case "valueUnsignedInt":
							result.Value = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.Value as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 50
							break;
						case "valueUri":
							result.Value = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Value as Hl7.Fhir.Model.FhirUri, reader, outcome); // 50
							break;
						case "valueUrl":
							result.Value = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.Value as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 50
							break;
						case "valueUuid":
							result.Value = new Hl7.Fhir.Model.Uuid();
							Parse(result.Value as Hl7.Fhir.Model.Uuid, reader, outcome); // 50
							break;
						case "valueAddress":
							result.Value = new Hl7.Fhir.Model.Address();
							Parse(result.Value as Hl7.Fhir.Model.Address, reader, outcome); // 50
							break;
						case "valueAge":
							result.Value = new Hl7.Fhir.Model.Age();
							Parse(result.Value as Hl7.Fhir.Model.Age, reader, outcome); // 50
							break;
						case "valueAnnotation":
							result.Value = new Hl7.Fhir.Model.Annotation();
							Parse(result.Value as Hl7.Fhir.Model.Annotation, reader, outcome); // 50
							break;
						case "valueAttachment":
							result.Value = new Hl7.Fhir.Model.Attachment();
							Parse(result.Value as Hl7.Fhir.Model.Attachment, reader, outcome); // 50
							break;
						case "valueCodeableConcept":
							result.Value = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Value as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "valueCoding":
							result.Value = new Hl7.Fhir.Model.Coding();
							Parse(result.Value as Hl7.Fhir.Model.Coding, reader, outcome); // 50
							break;
						case "valueContactPoint":
							result.Value = new Hl7.Fhir.Model.ContactPoint();
							Parse(result.Value as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 50
							break;
						case "valueCount":
							result.Value = new Hl7.Fhir.Model.Count();
							Parse(result.Value as Hl7.Fhir.Model.Count, reader, outcome); // 50
							break;
						case "valueDistance":
							result.Value = new Hl7.Fhir.Model.Distance();
							Parse(result.Value as Hl7.Fhir.Model.Distance, reader, outcome); // 50
							break;
						case "valueDuration":
							result.Value = new Hl7.Fhir.Model.Duration();
							Parse(result.Value as Hl7.Fhir.Model.Duration, reader, outcome); // 50
							break;
						case "valueHumanName":
							result.Value = new Hl7.Fhir.Model.HumanName();
							Parse(result.Value as Hl7.Fhir.Model.HumanName, reader, outcome); // 50
							break;
						case "valueIdentifier":
							result.Value = new Hl7.Fhir.Model.Identifier();
							Parse(result.Value as Hl7.Fhir.Model.Identifier, reader, outcome); // 50
							break;
						case "valueMoney":
							result.Value = new Hl7.Fhir.Model.Money();
							Parse(result.Value as Hl7.Fhir.Model.Money, reader, outcome); // 50
							break;
						case "valuePeriod":
							result.Value = new Hl7.Fhir.Model.Period();
							Parse(result.Value as Hl7.Fhir.Model.Period, reader, outcome); // 50
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							Parse(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome); // 50
							break;
						case "valueRange":
							result.Value = new Hl7.Fhir.Model.Range();
							Parse(result.Value as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "valueRatio":
							result.Value = new Hl7.Fhir.Model.Ratio();
							Parse(result.Value as Hl7.Fhir.Model.Ratio, reader, outcome); // 50
							break;
						case "valueReference":
							result.Value = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Value as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 50
							break;
						case "valueSampledData":
							result.Value = new Hl7.Fhir.Model.SampledData();
							Parse(result.Value as Hl7.Fhir.Model.SampledData, reader, outcome); // 50
							break;
						case "valueSignature":
							result.Value = new Hl7.Fhir.Model.Signature();
							Parse(result.Value as Hl7.Fhir.Model.Signature, reader, outcome); // 50
							break;
						case "valueTiming":
							result.Value = new Hl7.Fhir.Model.Timing();
							Parse(result.Value as Hl7.Fhir.Model.Timing, reader, outcome); // 50
							break;
						case "valueContactDetail":
							result.Value = new Hl7.Fhir.Model.ContactDetail();
							Parse(result.Value as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 50
							break;
						case "valueContributor":
							result.Value = new Hl7.Fhir.Model.Contributor();
							Parse(result.Value as Hl7.Fhir.Model.Contributor, reader, outcome); // 50
							break;
						case "valueDataRequirement":
							result.Value = new Hl7.Fhir.Model.DataRequirement();
							Parse(result.Value as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 50
							break;
						case "valueExpression":
							result.Value = new Hl7.Fhir.Model.Expression();
							Parse(result.Value as Hl7.Fhir.Model.Expression, reader, outcome); // 50
							break;
						case "valueParameterDefinition":
							result.Value = new Hl7.Fhir.Model.ParameterDefinition();
							Parse(result.Value as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 50
							break;
						case "valueRelatedArtifact":
							result.Value = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(result.Value as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 50
							break;
						case "valueTriggerDefinition":
							result.Value = new Hl7.Fhir.Model.TriggerDefinition();
							Parse(result.Value as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 50
							break;
						case "valueUsageContext":
							result.Value = new Hl7.Fhir.Model.UsageContext();
							Parse(result.Value as Hl7.Fhir.Model.UsageContext, reader, outcome); // 50
							break;
						case "valueDosage":
							result.Value = new Hl7.Fhir.Model.Dosage();
							Parse(result.Value as Hl7.Fhir.Model.Dosage, reader, outcome); // 50
							break;
						case "valueMeta":
							result.Value = new Hl7.Fhir.Model.Meta();
							Parse(result.Value as Hl7.Fhir.Model.Meta, reader, outcome); // 50
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ElementDefinition.ExampleComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "label":
							result.LabelElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LabelElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "valueBase64Binary":
							result.Value = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Base64Binary, reader, outcome); // 50
							break;
						case "valueBoolean":
							result.Value = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 50
							break;
						case "valueCanonical":
							result.Value = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Canonical, reader, outcome); // 50
							break;
						case "valueCode":
							result.Value = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Code, reader, outcome); // 50
							break;
						case "valueDate":
							result.Value = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Date, reader, outcome); // 50
							break;
						case "valueDateTime":
							result.Value = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 50
							break;
						case "valueDecimal":
							result.Value = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 50
							break;
						case "valueId":
							result.Value = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Id, reader, outcome); // 50
							break;
						case "valueInstant":
							result.Value = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Instant, reader, outcome); // 50
							break;
						case "valueInteger":
							result.Value = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Integer, reader, outcome); // 50
							break;
						case "valueMarkdown":
							result.Value = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Markdown, reader, outcome); // 50
							break;
						case "valueOid":
							result.Value = new Hl7.Fhir.Model.Oid();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Oid, reader, outcome); // 50
							break;
						case "valuePositiveInt":
							result.Value = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.Value as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 50
							break;
						case "valueString":
							result.Value = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "valueTime":
							result.Value = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Time, reader, outcome); // 50
							break;
						case "valueUnsignedInt":
							result.Value = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.Value as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 50
							break;
						case "valueUri":
							result.Value = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirUri, reader, outcome); // 50
							break;
						case "valueUrl":
							result.Value = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.Value as Hl7.Fhir.Model.FhirUrl, reader, outcome); // 50
							break;
						case "valueUuid":
							result.Value = new Hl7.Fhir.Model.Uuid();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Uuid, reader, outcome); // 50
							break;
						case "valueAddress":
							result.Value = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Address, reader, outcome); // 50
							break;
						case "valueAge":
							result.Value = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Age, reader, outcome); // 50
							break;
						case "valueAnnotation":
							result.Value = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Annotation, reader, outcome); // 50
							break;
						case "valueAttachment":
							result.Value = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Attachment, reader, outcome); // 50
							break;
						case "valueCodeableConcept":
							result.Value = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Value as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "valueCoding":
							result.Value = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Coding, reader, outcome); // 50
							break;
						case "valueContactPoint":
							result.Value = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(result.Value as Hl7.Fhir.Model.ContactPoint, reader, outcome); // 50
							break;
						case "valueCount":
							result.Value = new Hl7.Fhir.Model.Count();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Count, reader, outcome); // 50
							break;
						case "valueDistance":
							result.Value = new Hl7.Fhir.Model.Distance();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Distance, reader, outcome); // 50
							break;
						case "valueDuration":
							result.Value = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Duration, reader, outcome); // 50
							break;
						case "valueHumanName":
							result.Value = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.Value as Hl7.Fhir.Model.HumanName, reader, outcome); // 50
							break;
						case "valueIdentifier":
							result.Value = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Identifier, reader, outcome); // 50
							break;
						case "valueMoney":
							result.Value = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Money, reader, outcome); // 50
							break;
						case "valuePeriod":
							result.Value = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Period, reader, outcome); // 50
							break;
						case "valueQuantity":
							result.Value = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Quantity, reader, outcome); // 50
							break;
						case "valueRange":
							result.Value = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Range, reader, outcome); // 50
							break;
						case "valueRatio":
							result.Value = new Hl7.Fhir.Model.Ratio();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Ratio, reader, outcome); // 50
							break;
						case "valueReference":
							result.Value = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Value as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 50
							break;
						case "valueSampledData":
							result.Value = new Hl7.Fhir.Model.SampledData();
							await ParseAsync(result.Value as Hl7.Fhir.Model.SampledData, reader, outcome); // 50
							break;
						case "valueSignature":
							result.Value = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Signature, reader, outcome); // 50
							break;
						case "valueTiming":
							result.Value = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Timing, reader, outcome); // 50
							break;
						case "valueContactDetail":
							result.Value = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(result.Value as Hl7.Fhir.Model.ContactDetail, reader, outcome); // 50
							break;
						case "valueContributor":
							result.Value = new Hl7.Fhir.Model.Contributor();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Contributor, reader, outcome); // 50
							break;
						case "valueDataRequirement":
							result.Value = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(result.Value as Hl7.Fhir.Model.DataRequirement, reader, outcome); // 50
							break;
						case "valueExpression":
							result.Value = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Expression, reader, outcome); // 50
							break;
						case "valueParameterDefinition":
							result.Value = new Hl7.Fhir.Model.ParameterDefinition();
							await ParseAsync(result.Value as Hl7.Fhir.Model.ParameterDefinition, reader, outcome); // 50
							break;
						case "valueRelatedArtifact":
							result.Value = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(result.Value as Hl7.Fhir.Model.RelatedArtifact, reader, outcome); // 50
							break;
						case "valueTriggerDefinition":
							result.Value = new Hl7.Fhir.Model.TriggerDefinition();
							await ParseAsync(result.Value as Hl7.Fhir.Model.TriggerDefinition, reader, outcome); // 50
							break;
						case "valueUsageContext":
							result.Value = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(result.Value as Hl7.Fhir.Model.UsageContext, reader, outcome); // 50
							break;
						case "valueDosage":
							result.Value = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Dosage, reader, outcome); // 50
							break;
						case "valueMeta":
							result.Value = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Value as Hl7.Fhir.Model.Meta, reader, outcome); // 50
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
