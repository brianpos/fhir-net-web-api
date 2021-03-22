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
		private void Parse(MedicinalProductIndication result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]", cancellationToken); // 90
							result.Subject.Add(newItem_subject);
							break;
						case "diseaseSymptomProcedure":
							result.DiseaseSymptomProcedure = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DiseaseSymptomProcedure as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".diseaseSymptomProcedure", cancellationToken); // 100
							break;
						case "diseaseStatus":
							result.DiseaseStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DiseaseStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".diseaseStatus", cancellationToken); // 110
							break;
						case "comorbidity":
							var newItem_comorbidity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_comorbidity, reader, outcome, locationPath + ".comorbidity["+result.Comorbidity.Count+"]", cancellationToken); // 120
							result.Comorbidity.Add(newItem_comorbidity);
							break;
						case "intendedEffect":
							result.IntendedEffect = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.IntendedEffect as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".intendedEffect", cancellationToken); // 130
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.Quantity();
							Parse(result.Duration as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".duration", cancellationToken); // 140
							break;
						case "otherTherapy":
							var newItem_otherTherapy = new Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent();
							Parse(newItem_otherTherapy, reader, outcome, locationPath + ".otherTherapy["+result.OtherTherapy.Count+"]", cancellationToken); // 150
							result.OtherTherapy.Add(newItem_otherTherapy);
							break;
						case "undesirableEffect":
							var newItem_undesirableEffect = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_undesirableEffect, reader, outcome, locationPath + ".undesirableEffect["+result.UndesirableEffect.Count+"]", cancellationToken); // 160
							result.UndesirableEffect.Add(newItem_undesirableEffect);
							break;
						case "population":
							var newItem_population = new Hl7.Fhir.Model.Population();
							Parse(newItem_population, reader, outcome, locationPath + ".population["+result.Population.Count+"]", cancellationToken); // 170
							result.Population.Add(newItem_population);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProductIndication result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "subject":
							var newItem_subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_subject, reader, outcome, locationPath + ".subject["+result.Subject.Count+"]", cancellationToken); // 90
							result.Subject.Add(newItem_subject);
							break;
						case "diseaseSymptomProcedure":
							result.DiseaseSymptomProcedure = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DiseaseSymptomProcedure as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".diseaseSymptomProcedure", cancellationToken); // 100
							break;
						case "diseaseStatus":
							result.DiseaseStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DiseaseStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".diseaseStatus", cancellationToken); // 110
							break;
						case "comorbidity":
							var newItem_comorbidity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_comorbidity, reader, outcome, locationPath + ".comorbidity["+result.Comorbidity.Count+"]", cancellationToken); // 120
							result.Comorbidity.Add(newItem_comorbidity);
							break;
						case "intendedEffect":
							result.IntendedEffect = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.IntendedEffect as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".intendedEffect", cancellationToken); // 130
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Duration as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".duration", cancellationToken); // 140
							break;
						case "otherTherapy":
							var newItem_otherTherapy = new Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent();
							await ParseAsync(newItem_otherTherapy, reader, outcome, locationPath + ".otherTherapy["+result.OtherTherapy.Count+"]", cancellationToken); // 150
							result.OtherTherapy.Add(newItem_otherTherapy);
							break;
						case "undesirableEffect":
							var newItem_undesirableEffect = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_undesirableEffect, reader, outcome, locationPath + ".undesirableEffect["+result.UndesirableEffect.Count+"]", cancellationToken); // 160
							result.UndesirableEffect.Add(newItem_undesirableEffect);
							break;
						case "population":
							var newItem_population = new Hl7.Fhir.Model.Population();
							await ParseAsync(newItem_population, reader, outcome, locationPath + ".population["+result.Population.Count+"]", cancellationToken); // 170
							result.Population.Add(newItem_population);
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
