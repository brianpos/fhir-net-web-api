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
		private void Parse(DeviceMetric result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "unit":
							result.Unit = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Unit as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unit", cancellationToken); // 110
							break;
						case "source":
							result.Source = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Source as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".source", cancellationToken); // 120
							break;
						case "parent":
							result.Parent = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Parent as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".parent", cancellationToken); // 130
							break;
						case "operationalStatus":
							result.OperationalStatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricOperationalStatus>();
							Parse(result.OperationalStatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricOperationalStatus>, reader, outcome, locationPath + ".operationalStatus", cancellationToken); // 140
							break;
						case "color":
							result.ColorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricColor>();
							Parse(result.ColorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricColor>, reader, outcome, locationPath + ".color", cancellationToken); // 150
							break;
						case "category":
							result.CategoryElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricCategory>();
							Parse(result.CategoryElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricCategory>, reader, outcome, locationPath + ".category", cancellationToken); // 160
							break;
						case "measurementPeriod":
							result.MeasurementPeriod = new Hl7.Fhir.Model.Timing();
							Parse(result.MeasurementPeriod as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".measurementPeriod", cancellationToken); // 170
							break;
						case "calibration":
							var newItem_calibration = new Hl7.Fhir.Model.DeviceMetric.CalibrationComponent();
							Parse(newItem_calibration, reader, outcome, locationPath + ".calibration["+result.Calibration.Count+"]", cancellationToken); // 180
							result.Calibration.Add(newItem_calibration);
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

		private async System.Threading.Tasks.Task ParseAsync(DeviceMetric result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 100
							break;
						case "unit":
							result.Unit = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Unit as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unit", cancellationToken); // 110
							break;
						case "source":
							result.Source = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Source as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".source", cancellationToken); // 120
							break;
						case "parent":
							result.Parent = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Parent as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".parent", cancellationToken); // 130
							break;
						case "operationalStatus":
							result.OperationalStatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricOperationalStatus>();
							await ParseAsync(result.OperationalStatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricOperationalStatus>, reader, outcome, locationPath + ".operationalStatus", cancellationToken); // 140
							break;
						case "color":
							result.ColorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricColor>();
							await ParseAsync(result.ColorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricColor>, reader, outcome, locationPath + ".color", cancellationToken); // 150
							break;
						case "category":
							result.CategoryElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricCategory>();
							await ParseAsync(result.CategoryElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricCategory>, reader, outcome, locationPath + ".category", cancellationToken); // 160
							break;
						case "measurementPeriod":
							result.MeasurementPeriod = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.MeasurementPeriod as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".measurementPeriod", cancellationToken); // 170
							break;
						case "calibration":
							var newItem_calibration = new Hl7.Fhir.Model.DeviceMetric.CalibrationComponent();
							await ParseAsync(newItem_calibration, reader, outcome, locationPath + ".calibration["+result.Calibration.Count+"]", cancellationToken); // 180
							result.Calibration.Add(newItem_calibration);
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
