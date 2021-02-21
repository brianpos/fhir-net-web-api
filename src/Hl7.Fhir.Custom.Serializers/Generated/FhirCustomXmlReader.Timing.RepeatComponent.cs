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
		public void Parse(Hl7.Fhir.Model.Timing.RepeatComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "boundsDuration":
							result.Bounds = new Hl7.Fhir.Model.Duration();
							Parse(result.Bounds as Hl7.Fhir.Model.Duration, reader, outcome); // 40
							break;
						case "boundsRange":
							result.Bounds = new Hl7.Fhir.Model.Range();
							Parse(result.Bounds as Hl7.Fhir.Model.Range, reader, outcome); // 40
							break;
						case "boundsPeriod":
							result.Bounds = new Hl7.Fhir.Model.Period();
							Parse(result.Bounds as Hl7.Fhir.Model.Period, reader, outcome); // 40
							break;
						case "count":
							result.CountElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.CountElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 50
							break;
						case "countMax":
							result.CountMaxElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.CountMaxElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 60
							break;
						case "duration":
							result.DurationElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DurationElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 70
							break;
						case "durationMax":
							result.DurationMaxElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DurationMaxElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 80
							break;
						case "durationUnit":
							result.DurationUnitElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>();
							Parse(result.DurationUnitElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>, reader, outcome); // 90
							break;
						case "frequency":
							result.FrequencyElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.FrequencyElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 100
							break;
						case "frequencyMax":
							result.FrequencyMaxElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.FrequencyMaxElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 110
							break;
						case "period":
							result.PeriodElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PeriodElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 120
							break;
						case "periodMax":
							result.PeriodMaxElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PeriodMaxElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 130
							break;
						case "periodUnit":
							result.PeriodUnitElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>();
							Parse(result.PeriodUnitElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>, reader, outcome); // 140
							break;
						case "dayOfWeek":
							var newItem_dayOfWeek = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>();
							Parse(newItem_dayOfWeek, reader, outcome); // 150
							result.DayOfWeekElement.Add(newItem_dayOfWeek);
							break;
						case "timeOfDay":
							var newItem_timeOfDay = new Hl7.Fhir.Model.Time();
							Parse(newItem_timeOfDay, reader, outcome); // 160
							result.TimeOfDayElement.Add(newItem_timeOfDay);
							break;
						case "when":
							var newItem_when = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.EventTiming>();
							Parse(newItem_when, reader, outcome); // 170
							result.WhenElement.Add(newItem_when);
							break;
						case "offset":
							result.OffsetElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.OffsetElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 180
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Timing.RepeatComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "boundsDuration":
							result.Bounds = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Bounds as Hl7.Fhir.Model.Duration, reader, outcome); // 40
							break;
						case "boundsRange":
							result.Bounds = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Bounds as Hl7.Fhir.Model.Range, reader, outcome); // 40
							break;
						case "boundsPeriod":
							result.Bounds = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Bounds as Hl7.Fhir.Model.Period, reader, outcome); // 40
							break;
						case "count":
							result.CountElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.CountElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 50
							break;
						case "countMax":
							result.CountMaxElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.CountMaxElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 60
							break;
						case "duration":
							result.DurationElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DurationElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 70
							break;
						case "durationMax":
							result.DurationMaxElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DurationMaxElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 80
							break;
						case "durationUnit":
							result.DurationUnitElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>();
							await ParseAsync(result.DurationUnitElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>, reader, outcome); // 90
							break;
						case "frequency":
							result.FrequencyElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.FrequencyElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 100
							break;
						case "frequencyMax":
							result.FrequencyMaxElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.FrequencyMaxElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 110
							break;
						case "period":
							result.PeriodElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PeriodElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 120
							break;
						case "periodMax":
							result.PeriodMaxElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PeriodMaxElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 130
							break;
						case "periodUnit":
							result.PeriodUnitElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>();
							await ParseAsync(result.PeriodUnitElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.UnitsOfTime>, reader, outcome); // 140
							break;
						case "dayOfWeek":
							var newItem_dayOfWeek = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>();
							await ParseAsync(newItem_dayOfWeek, reader, outcome); // 150
							result.DayOfWeekElement.Add(newItem_dayOfWeek);
							break;
						case "timeOfDay":
							var newItem_timeOfDay = new Hl7.Fhir.Model.Time();
							await ParseAsync(newItem_timeOfDay, reader, outcome); // 160
							result.TimeOfDayElement.Add(newItem_timeOfDay);
							break;
						case "when":
							var newItem_when = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Timing.EventTiming>();
							await ParseAsync(newItem_when, reader, outcome); // 170
							result.WhenElement.Add(newItem_when);
							break;
						case "offset":
							result.OffsetElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.OffsetElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome); // 180
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
