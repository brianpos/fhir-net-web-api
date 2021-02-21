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
		private void Parse(AdverseEvent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 90
							break;
						case "actuality":
							result.ActualityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>();
							Parse(result.ActualityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>, reader, outcome, locationPath + ".actuality"); // 100
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 110
							result.Category.Add(newItem_category);
							break;
						case "event":
							result.Event = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Event as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".event"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 150
							break;
						case "detected":
							result.DetectedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DetectedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".detected"); // 160
							break;
						case "recordedDate":
							result.RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.RecordedDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recordedDate"); // 170
							break;
						case "resultingCondition":
							var newItem_resultingCondition = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_resultingCondition, reader, outcome, locationPath + ".resultingCondition["+result.ResultingCondition.Count+"]"); // 180
							result.ResultingCondition.Add(newItem_resultingCondition);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location"); // 190
							break;
						case "seriousness":
							result.Seriousness = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Seriousness as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".seriousness"); // 200
							break;
						case "severity":
							result.Severity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Severity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".severity"); // 210
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome"); // 220
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 230
							break;
						case "contributor":
							var newItem_contributor = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_contributor, reader, outcome, locationPath + ".contributor["+result.Contributor.Count+"]"); // 240
							result.Contributor.Add(newItem_contributor);
							break;
						case "suspectEntity":
							var newItem_suspectEntity = new Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent();
							Parse(newItem_suspectEntity, reader, outcome, locationPath + ".suspectEntity["+result.SuspectEntity.Count+"]"); // 250
							result.SuspectEntity.Add(newItem_suspectEntity);
							break;
						case "subjectMedicalHistory":
							var newItem_subjectMedicalHistory = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_subjectMedicalHistory, reader, outcome, locationPath + ".subjectMedicalHistory["+result.SubjectMedicalHistory.Count+"]"); // 260
							result.SubjectMedicalHistory.Add(newItem_subjectMedicalHistory);
							break;
						case "referenceDocument":
							var newItem_referenceDocument = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_referenceDocument, reader, outcome, locationPath + ".referenceDocument["+result.ReferenceDocument.Count+"]"); // 270
							result.ReferenceDocument.Add(newItem_referenceDocument);
							break;
						case "study":
							var newItem_study = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_study, reader, outcome, locationPath + ".study["+result.Study.Count+"]"); // 280
							result.Study.Add(newItem_study);
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

		private async System.Threading.Tasks.Task ParseAsync(AdverseEvent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 90
							break;
						case "actuality":
							result.ActualityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>();
							await ParseAsync(result.ActualityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>, reader, outcome, locationPath + ".actuality"); // 100
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]"); // 110
							result.Category.Add(newItem_category);
							break;
						case "event":
							result.Event = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Event as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".event"); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 140
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date"); // 150
							break;
						case "detected":
							result.DetectedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DetectedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".detected"); // 160
							break;
						case "recordedDate":
							result.RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.RecordedDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".recordedDate"); // 170
							break;
						case "resultingCondition":
							var newItem_resultingCondition = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_resultingCondition, reader, outcome, locationPath + ".resultingCondition["+result.ResultingCondition.Count+"]"); // 180
							result.ResultingCondition.Add(newItem_resultingCondition);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location"); // 190
							break;
						case "seriousness":
							result.Seriousness = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Seriousness as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".seriousness"); // 200
							break;
						case "severity":
							result.Severity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Severity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".severity"); // 210
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome"); // 220
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 230
							break;
						case "contributor":
							var newItem_contributor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_contributor, reader, outcome, locationPath + ".contributor["+result.Contributor.Count+"]"); // 240
							result.Contributor.Add(newItem_contributor);
							break;
						case "suspectEntity":
							var newItem_suspectEntity = new Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent();
							await ParseAsync(newItem_suspectEntity, reader, outcome, locationPath + ".suspectEntity["+result.SuspectEntity.Count+"]"); // 250
							result.SuspectEntity.Add(newItem_suspectEntity);
							break;
						case "subjectMedicalHistory":
							var newItem_subjectMedicalHistory = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_subjectMedicalHistory, reader, outcome, locationPath + ".subjectMedicalHistory["+result.SubjectMedicalHistory.Count+"]"); // 260
							result.SubjectMedicalHistory.Add(newItem_subjectMedicalHistory);
							break;
						case "referenceDocument":
							var newItem_referenceDocument = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_referenceDocument, reader, outcome, locationPath + ".referenceDocument["+result.ReferenceDocument.Count+"]"); // 270
							result.ReferenceDocument.Add(newItem_referenceDocument);
							break;
						case "study":
							var newItem_study = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_study, reader, outcome, locationPath + ".study["+result.Study.Count+"]"); // 280
							result.Study.Add(newItem_study);
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
