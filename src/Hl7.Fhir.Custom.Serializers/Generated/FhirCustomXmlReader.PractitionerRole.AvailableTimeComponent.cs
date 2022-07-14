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
		public void Parse(Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "daysOfWeek":
							var newItem_daysOfWeek = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>();
							Parse(newItem_daysOfWeek, reader, outcome, locationPath + ".daysOfWeek["+result.DaysOfWeekElement.Count+"]", cancellationToken); // 40
							result.DaysOfWeekElement.Add(newItem_daysOfWeek);
							break;
						case "allDay":
							result.AllDayElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.AllDayElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".allDay", cancellationToken); // 50
							break;
						case "availableStartTime":
							result.AvailableStartTimeElement = new Hl7.Fhir.Model.Time();
							Parse(result.AvailableStartTimeElement as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".availableStartTime", cancellationToken); // 60
							break;
						case "availableEndTime":
							result.AvailableEndTimeElement = new Hl7.Fhir.Model.Time();
							Parse(result.AvailableEndTimeElement as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".availableEndTime", cancellationToken); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "daysOfWeek":
							var newItem_daysOfWeek = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DaysOfWeek>();
							await ParseAsync(newItem_daysOfWeek, reader, outcome, locationPath + ".daysOfWeek["+result.DaysOfWeekElement.Count+"]", cancellationToken); // 40
							result.DaysOfWeekElement.Add(newItem_daysOfWeek);
							break;
						case "allDay":
							result.AllDayElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.AllDayElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".allDay", cancellationToken); // 50
							break;
						case "availableStartTime":
							result.AvailableStartTimeElement = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.AvailableStartTimeElement as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".availableStartTime", cancellationToken); // 60
							break;
						case "availableEndTime":
							result.AvailableEndTimeElement = new Hl7.Fhir.Model.Time();
							await ParseAsync(result.AvailableEndTimeElement as Hl7.Fhir.Model.Time, reader, outcome, locationPath + ".availableEndTime", cancellationToken); // 70
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
