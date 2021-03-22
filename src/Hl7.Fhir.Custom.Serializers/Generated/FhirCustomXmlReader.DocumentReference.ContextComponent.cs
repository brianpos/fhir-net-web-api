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
		public void Parse(Hl7.Fhir.Model.DocumentReference.ContextComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "encounter":
							var newItem_encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_encounter, reader, outcome, locationPath + ".encounter["+result.Encounter.Count+"]", cancellationToken); // 40
							result.Encounter.Add(newItem_encounter);
							break;
						case "event":
							var newItem_event = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_event, reader, outcome, locationPath + ".event["+result.Event.Count+"]", cancellationToken); // 50
							result.Event.Add(newItem_event);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 60
							break;
						case "facilityType":
							result.FacilityType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.FacilityType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".facilityType", cancellationToken); // 70
							break;
						case "practiceSetting":
							result.PracticeSetting = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PracticeSetting as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".practiceSetting", cancellationToken); // 80
							break;
						case "sourcePatientInfo":
							result.SourcePatientInfo = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.SourcePatientInfo as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".sourcePatientInfo", cancellationToken); // 90
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_related, reader, outcome, locationPath + ".related["+result.Related.Count+"]", cancellationToken); // 100
							result.Related.Add(newItem_related);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.DocumentReference.ContextComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "encounter":
							var newItem_encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_encounter, reader, outcome, locationPath + ".encounter["+result.Encounter.Count+"]", cancellationToken); // 40
							result.Encounter.Add(newItem_encounter);
							break;
						case "event":
							var newItem_event = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_event, reader, outcome, locationPath + ".event["+result.Event.Count+"]", cancellationToken); // 50
							result.Event.Add(newItem_event);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 60
							break;
						case "facilityType":
							result.FacilityType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.FacilityType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".facilityType", cancellationToken); // 70
							break;
						case "practiceSetting":
							result.PracticeSetting = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PracticeSetting as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".practiceSetting", cancellationToken); // 80
							break;
						case "sourcePatientInfo":
							result.SourcePatientInfo = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.SourcePatientInfo as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".sourcePatientInfo", cancellationToken); // 90
							break;
						case "related":
							var newItem_related = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_related, reader, outcome, locationPath + ".related["+result.Related.Count+"]", cancellationToken); // 100
							result.Related.Add(newItem_related);
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
