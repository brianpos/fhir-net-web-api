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
		private void Parse(ImagingStudy result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImagingStudy.ImagingStudyStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImagingStudy.ImagingStudyStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "modality":
							var newItem_modality = new Hl7.Fhir.Model.Coding();
							Parse(newItem_modality, reader, outcome, locationPath + ".modality["+result.Modality.Count+"]", cancellationToken); // 110
							result.Modality.Add(newItem_modality);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 120
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 130
							break;
						case "started":
							result.StartedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.StartedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".started", cancellationToken); // 140
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 150
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "referrer":
							result.Referrer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Referrer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".referrer", cancellationToken); // 160
							break;
						case "interpreter":
							var newItem_interpreter = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_interpreter, reader, outcome, locationPath + ".interpreter["+result.Interpreter.Count+"]", cancellationToken); // 170
							result.Interpreter.Add(newItem_interpreter);
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 180
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "numberOfSeries":
							result.NumberOfSeriesElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberOfSeriesElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfSeries", cancellationToken); // 190
							break;
						case "numberOfInstances":
							result.NumberOfInstancesElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberOfInstancesElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfInstances", cancellationToken); // 200
							break;
						case "procedureReference":
							result.ProcedureReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ProcedureReference as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".procedureReference", cancellationToken); // 210
							break;
						case "procedureCode":
							var newItem_procedureCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_procedureCode, reader, outcome, locationPath + ".procedureCode["+result.ProcedureCode.Count+"]", cancellationToken); // 220
							result.ProcedureCode.Add(newItem_procedureCode);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 230
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 240
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 250
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 260
							result.Note.Add(newItem_note);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 270
							break;
						case "series":
							var newItem_series = new Hl7.Fhir.Model.ImagingStudy.SeriesComponent();
							Parse(newItem_series, reader, outcome, locationPath + ".series["+result.Series.Count+"]", cancellationToken); // 280
							result.Series.Add(newItem_series);
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

		private async System.Threading.Tasks.Task ParseAsync(ImagingStudy result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImagingStudy.ImagingStudyStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImagingStudy.ImagingStudyStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "modality":
							var newItem_modality = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_modality, reader, outcome, locationPath + ".modality["+result.Modality.Count+"]", cancellationToken); // 110
							result.Modality.Add(newItem_modality);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 120
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 130
							break;
						case "started":
							result.StartedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.StartedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".started", cancellationToken); // 140
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 150
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "referrer":
							result.Referrer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Referrer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".referrer", cancellationToken); // 160
							break;
						case "interpreter":
							var newItem_interpreter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_interpreter, reader, outcome, locationPath + ".interpreter["+result.Interpreter.Count+"]", cancellationToken); // 170
							result.Interpreter.Add(newItem_interpreter);
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 180
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "numberOfSeries":
							result.NumberOfSeriesElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberOfSeriesElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfSeries", cancellationToken); // 190
							break;
						case "numberOfInstances":
							result.NumberOfInstancesElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberOfInstancesElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfInstances", cancellationToken); // 200
							break;
						case "procedureReference":
							result.ProcedureReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ProcedureReference as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".procedureReference", cancellationToken); // 210
							break;
						case "procedureCode":
							var newItem_procedureCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_procedureCode, reader, outcome, locationPath + ".procedureCode["+result.ProcedureCode.Count+"]", cancellationToken); // 220
							result.ProcedureCode.Add(newItem_procedureCode);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 230
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]", cancellationToken); // 240
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]", cancellationToken); // 250
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 260
							result.Note.Add(newItem_note);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 270
							break;
						case "series":
							var newItem_series = new Hl7.Fhir.Model.ImagingStudy.SeriesComponent();
							await ParseAsync(newItem_series, reader, outcome, locationPath + ".series["+result.Series.Count+"]", cancellationToken); // 280
							result.Series.Add(newItem_series);
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
