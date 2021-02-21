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
		private void Parse(ObservationDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome); // 90
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 110
							result.Identifier.Add(newItem_identifier);
							break;
						case "permittedDataType":
							var newItem_permittedDataType = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>();
							Parse(newItem_permittedDataType, reader, outcome); // 120
							result.PermittedDataTypeElement.Add(newItem_permittedDataType);
							break;
						case "multipleResultsAllowed":
							result.MultipleResultsAllowedElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.MultipleResultsAllowedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 130
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "preferredReportName":
							result.PreferredReportNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PreferredReportNameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "quantitativeDetails":
							result.QuantitativeDetails = new Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent();
							Parse(result.QuantitativeDetails as Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent, reader, outcome); // 160
							break;
						case "qualifiedInterval":
							var newItem_qualifiedInterval = new Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent();
							Parse(newItem_qualifiedInterval, reader, outcome); // 170
							result.QualifiedInterval.Add(newItem_qualifiedInterval);
							break;
						case "validCodedValueSet":
							result.ValidCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ValidCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 180
							break;
						case "normalCodedValueSet":
							result.NormalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.NormalCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "abnormalCodedValueSet":
							result.AbnormalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.AbnormalCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 200
							break;
						case "criticalCodedValueSet":
							result.CriticalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.CriticalCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
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

		private async System.Threading.Tasks.Task ParseAsync(ObservationDefinition result, XmlReader reader, OperationOutcome outcome)
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
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome); // 90
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 110
							result.Identifier.Add(newItem_identifier);
							break;
						case "permittedDataType":
							var newItem_permittedDataType = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>();
							await ParseAsync(newItem_permittedDataType, reader, outcome); // 120
							result.PermittedDataTypeElement.Add(newItem_permittedDataType);
							break;
						case "multipleResultsAllowed":
							result.MultipleResultsAllowedElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.MultipleResultsAllowedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 130
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 140
							break;
						case "preferredReportName":
							result.PreferredReportNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PreferredReportNameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "quantitativeDetails":
							result.QuantitativeDetails = new Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent();
							await ParseAsync(result.QuantitativeDetails as Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent, reader, outcome); // 160
							break;
						case "qualifiedInterval":
							var newItem_qualifiedInterval = new Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent();
							await ParseAsync(newItem_qualifiedInterval, reader, outcome); // 170
							result.QualifiedInterval.Add(newItem_qualifiedInterval);
							break;
						case "validCodedValueSet":
							result.ValidCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ValidCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 180
							break;
						case "normalCodedValueSet":
							result.NormalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.NormalCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 190
							break;
						case "abnormalCodedValueSet":
							result.AbnormalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.AbnormalCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 200
							break;
						case "criticalCodedValueSet":
							result.CriticalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.CriticalCodedValueSet as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
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
