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
		public void Parse(Hl7.Fhir.Model.Specimen.CollectionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "collector":
							result.Collector = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Collector as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".collector", cancellationToken); // 40
							break;
						case "collectedDateTime":
							result.Collected = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Collected as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".collected", cancellationToken); // 50
							break;
						case "collectedPeriod":
							result.Collected = new Hl7.Fhir.Model.Period();
							Parse(result.Collected as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".collected", cancellationToken); // 50
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.Duration();
							Parse(result.Duration as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".duration", cancellationToken); // 60
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 70
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method", cancellationToken); // 80
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite", cancellationToken); // 90
							break;
						case "fastingStatusCodeableConcept":
							result.FastingStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FastingStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fastingStatus", cancellationToken); // 100
							break;
						case "fastingStatusDuration":
							result.FastingStatus = new Hl7.Fhir.Model.Duration();
							Parse(result.FastingStatus as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".fastingStatus", cancellationToken); // 100
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Specimen.CollectionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "collector":
							result.Collector = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Collector as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".collector", cancellationToken); // 40
							break;
						case "collectedDateTime":
							result.Collected = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Collected as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".collected", cancellationToken); // 50
							break;
						case "collectedPeriod":
							result.Collected = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Collected as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".collected", cancellationToken); // 50
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Duration as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".duration", cancellationToken); // 60
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 70
							break;
						case "method":
							result.Method = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Method as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".method", cancellationToken); // 80
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite", cancellationToken); // 90
							break;
						case "fastingStatusCodeableConcept":
							result.FastingStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FastingStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".fastingStatus", cancellationToken); // 100
							break;
						case "fastingStatusDuration":
							result.FastingStatus = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.FastingStatus as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".fastingStatus", cancellationToken); // 100
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
