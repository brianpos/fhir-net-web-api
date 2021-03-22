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
		public void Parse(Hl7.Fhir.Model.TriggerDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>, reader, outcome, locationPath + ".type", cancellationToken); // 30
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							Parse(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "timingReference":
							result.Timing = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Timing as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "timingDate":
							result.Timing = new Hl7.Fhir.Model.Date();
							Parse(result.Timing as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "data":
							var newItem_data = new Hl7.Fhir.Model.DataRequirement();
							Parse(newItem_data, reader, outcome, locationPath + ".data["+result.Data.Count+"]", cancellationToken); // 60
							result.Data.Add(newItem_data);
							break;
						case "condition":
							result.Condition = new Hl7.Fhir.Model.Expression();
							Parse(result.Condition as Hl7.Fhir.Model.Expression, reader, outcome, locationPath + ".condition", cancellationToken); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.TriggerDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>, reader, outcome, locationPath + ".type", cancellationToken); // 30
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "timingReference":
							result.Timing = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "timingDate":
							result.Timing = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timing", cancellationToken); // 50
							break;
						case "data":
							var newItem_data = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(newItem_data, reader, outcome, locationPath + ".data["+result.Data.Count+"]", cancellationToken); // 60
							result.Data.Add(newItem_data);
							break;
						case "condition":
							result.Condition = new Hl7.Fhir.Model.Expression();
							await ParseAsync(result.Condition as Hl7.Fhir.Model.Expression, reader, outcome, locationPath + ".condition", cancellationToken); // 70
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
