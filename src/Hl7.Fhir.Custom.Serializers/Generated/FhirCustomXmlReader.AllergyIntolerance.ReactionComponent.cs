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
		public void Parse(Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "substance":
							result.Substance = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Substance as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substance", cancellationToken); // 40
							break;
						case "manifestation":
							var newItem_manifestation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_manifestation, reader, outcome, locationPath + ".manifestation["+result.Manifestation.Count+"]", cancellationToken); // 50
							result.Manifestation.Add(newItem_manifestation);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 60
							break;
						case "onset":
							result.OnsetElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.OnsetElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity>();
							Parse(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity>, reader, outcome, locationPath + ".severity", cancellationToken); // 80
							break;
						case "exposureRoute":
							result.ExposureRoute = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ExposureRoute as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".exposureRoute", cancellationToken); // 90
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 100
							result.Note.Add(newItem_note);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "substance":
							result.Substance = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Substance as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".substance", cancellationToken); // 40
							break;
						case "manifestation":
							var newItem_manifestation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_manifestation, reader, outcome, locationPath + ".manifestation["+result.Manifestation.Count+"]", cancellationToken); // 50
							result.Manifestation.Add(newItem_manifestation);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 60
							break;
						case "onset":
							result.OnsetElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.OnsetElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".onset", cancellationToken); // 70
							break;
						case "severity":
							result.SeverityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity>();
							await ParseAsync(result.SeverityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity>, reader, outcome, locationPath + ".severity", cancellationToken); // 80
							break;
						case "exposureRoute":
							result.ExposureRoute = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ExposureRoute as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".exposureRoute", cancellationToken); // 90
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 100
							result.Note.Add(newItem_note);
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
