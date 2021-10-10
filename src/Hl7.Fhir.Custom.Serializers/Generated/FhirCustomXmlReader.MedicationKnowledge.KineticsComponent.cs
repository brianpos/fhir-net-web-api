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
		public void Parse(Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "areaUnderCurve":
							var newItem_areaUnderCurve = new Hl7.Fhir.Model.Quantity();
							Parse(newItem_areaUnderCurve, reader, outcome, locationPath + ".areaUnderCurve["+result.AreaUnderCurve.Count+"]", cancellationToken); // 40
							result.AreaUnderCurve.Add(newItem_areaUnderCurve);
							break;
						case "lethalDose50":
							var newItem_lethalDose50 = new Hl7.Fhir.Model.Quantity();
							Parse(newItem_lethalDose50, reader, outcome, locationPath + ".lethalDose50["+result.LethalDose50.Count+"]", cancellationToken); // 50
							result.LethalDose50.Add(newItem_lethalDose50);
							break;
						case "halfLifePeriod":
							result.HalfLifePeriod = new Hl7.Fhir.Model.Duration();
							Parse(result.HalfLifePeriod as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".halfLifePeriod", cancellationToken); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "areaUnderCurve":
							var newItem_areaUnderCurve = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(newItem_areaUnderCurve, reader, outcome, locationPath + ".areaUnderCurve["+result.AreaUnderCurve.Count+"]", cancellationToken); // 40
							result.AreaUnderCurve.Add(newItem_areaUnderCurve);
							break;
						case "lethalDose50":
							var newItem_lethalDose50 = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(newItem_lethalDose50, reader, outcome, locationPath + ".lethalDose50["+result.LethalDose50.Count+"]", cancellationToken); // 50
							result.LethalDose50.Add(newItem_lethalDose50);
							break;
						case "halfLifePeriod":
							result.HalfLifePeriod = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.HalfLifePeriod as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".halfLifePeriod", cancellationToken); // 60
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
