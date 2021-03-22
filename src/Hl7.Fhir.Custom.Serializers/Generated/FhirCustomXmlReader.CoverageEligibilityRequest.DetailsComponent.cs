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
		public void Parse(Hl7.Fhir.Model.CoverageEligibilityRequest.DetailsComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "supportingInfoSequence":
							var newItem_supportingInfoSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_supportingInfoSequence, reader, outcome, locationPath + ".supportingInfoSequence["+result.SupportingInfoSequenceElement.Count+"]", cancellationToken); // 40
							result.SupportingInfoSequenceElement.Add(newItem_supportingInfoSequence);
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 50
							break;
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".productOrService", cancellationToken); // 60
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.Modifier.Count+"]", cancellationToken); // 70
							result.Modifier.Add(newItem_modifier);
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".provider", cancellationToken); // 80
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 90
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							Parse(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 100
							break;
						case "facility":
							result.Facility = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Facility as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".facility", cancellationToken); // 110
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.CoverageEligibilityRequest.DiagnosisComponent();
							Parse(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]", cancellationToken); // 120
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_detail, reader, outcome, locationPath + ".detail["+result.Detail.Count+"]", cancellationToken); // 130
							result.Detail.Add(newItem_detail);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CoverageEligibilityRequest.DetailsComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "supportingInfoSequence":
							var newItem_supportingInfoSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_supportingInfoSequence, reader, outcome, locationPath + ".supportingInfoSequence["+result.SupportingInfoSequenceElement.Count+"]", cancellationToken); // 40
							result.SupportingInfoSequenceElement.Add(newItem_supportingInfoSequence);
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 50
							break;
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".productOrService", cancellationToken); // 60
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.Modifier.Count+"]", cancellationToken); // 70
							result.Modifier.Add(newItem_modifier);
							break;
						case "provider":
							result.Provider = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Provider as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".provider", cancellationToken); // 80
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 90
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 100
							break;
						case "facility":
							result.Facility = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Facility as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".facility", cancellationToken); // 110
							break;
						case "diagnosis":
							var newItem_diagnosis = new Hl7.Fhir.Model.CoverageEligibilityRequest.DiagnosisComponent();
							await ParseAsync(newItem_diagnosis, reader, outcome, locationPath + ".diagnosis["+result.Diagnosis.Count+"]", cancellationToken); // 120
							result.Diagnosis.Add(newItem_diagnosis);
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_detail, reader, outcome, locationPath + ".detail["+result.Detail.Count+"]", cancellationToken); // 130
							result.Detail.Add(newItem_detail);
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
