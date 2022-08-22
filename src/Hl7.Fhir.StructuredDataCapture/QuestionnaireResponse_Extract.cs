using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.StructuredDataCapture
{
    /// <summary>
    /// http://build.fhir.org/ig/HL7/sdc/extraction.html#obs-extract
    /// </summary>
    public class QuestionnaireResponse_Extract
    {
        public Task<Resource> PerformExtractOperation(QuestionnaireResponse qr, Questionnaire q)
        {
            OperationOutcome outcome = new OperationOutcome();
            Bundle results = new Bundle();
            results.Type = Bundle.BundleType.Transaction;

            // Observation based extraction
            bool extractAllItems = q.observationExtract() == true;
            IEnumerable<CodeableConcept> defaultObservationExtractCategory = q.observationExtractCategory();
            foreach (var itemDef in q.Item)
            {
                var itemsA = qr.Item.Where(i => i.LinkId == itemDef.LinkId);
                ExtractItemObservationData(qr, results, outcome, itemDef, itemsA, extractAllItems, defaultObservationExtractCategory);
            }

            // Definition based extraction
            // ...

            // StructureMap based extraction
            foreach (var sm in q.targetStructureMap())
            {
                // retrieve the StructureMap

                // execute the StructureMap extraction

                // Add the results into the output
            }


            // If there are any issues, then we should return the parameters resource instead of the Bundle itself
            if (outcome.Issue.Any())
            {
                Parameters resultParameters = new Parameters();
                resultParameters.Parameter.Add(new Parameters.ParameterComponent() { Name = "return", Resource = results });
                resultParameters.Parameter.Add(new Parameters.ParameterComponent() { Name = "issues", Resource = outcome });
                return Task.FromResult(resultParameters as Resource);
            }
            return Task.FromResult(results as Resource);
        }

        private void ExtractItemObservationData(QuestionnaireResponse qr, Bundle results, OperationOutcome outcome, Questionnaire.ItemComponent itemDef, IEnumerable<QuestionnaireResponse.ItemComponent> itemsA, bool extractAllItems, IEnumerable<CodeableConcept> defaultObservationExtractCategory)
        {
            if (extractAllItems || itemDef.observationExtract() == true || itemDef.observationExtractCategory().Any())
            {
                if (itemDef.observationExtractCategory().Any())
                    defaultObservationExtractCategory = itemDef.observationExtractCategory();
                foreach (var answer in itemsA.SelectMany(a => a.Answer))
                {
                    // this item is expected to be extracted
                    Observation obs = new Observation();
                    obs.BasedOn = qr.BasedOn;
                    obs.PartOf = qr.PartOf;
                    obs.Status = ObservationStatus.Final;
                    obs.Subject = qr.Subject;
                    obs.Encounter = qr.Encounter;
                    obs.Effective = qr.AuthoredElement;
                    obs.DerivedFrom.Add(new ResourceReference($"QuestionnaireResponse/{qr.Id}"));
                    if (!string.IsNullOrEmpty(qr.Authored))
                    {
                        if (qr.Authored.Length > 10)
                        {
                            // type clash here, If there was insufficient precision, we just drop the value
                            if (DateTimeOffset.TryParse(qr.Authored, out var value))
                                obs.Issued = value;
                        }
                        else
                        {
                            // Log this into the warnings
                            outcome.Issue.Add(new OperationOutcome.IssueComponent()
                            {
                                Severity = OperationOutcome.IssueSeverity.Information,
                                Code = OperationOutcome.IssueType.Value,
                                Details = new CodeableConcept() { Text = $"Precision of Authored value {qr.Authored} cannot be used in the objservation issued property"}
                            });
                        }
                    }
                    if (qr.Author != null)
                        obs.Performer.Add(qr.Author);
                    if (itemDef.observationExtractCategory().Any())
                        obs.Category.AddRange(itemDef.observationExtractCategory());
                    obs.Code = new CodeableConcept();
                    if (itemDef.Code.Any(code => code.observationExtract().HasValue))
                    {
                        if (itemDef.Code.Any(code => code.observationExtract() == true))
                        {
                            // there was an item explicitly indicated to be included
                            obs.Code.Coding.AddRange(itemDef.Code.Where(code => code.observationExtract() == true));
                        }
                        else
                        {
                            // there were no explicitly included items, but there was some that were to be excluded (so include all the others)
                            obs.Code.Coding.AddRange(itemDef.Code.Where(code => code.observationExtract() != false));
                        }
                    }
                    else
                    {
                        // there are no explicit directions for the codings, so include them all
                        obs.Code.Coding = itemDef.Code;
                    }
                    // remove any extensions that might have come across into the observaton
                    foreach (var code in obs.Code?.Coding)
                    {
                        code.Extension.Clear();
                    }
                    if (itemDef.unit() != null && (answer.Value is FhirDecimal || answer.Value is Integer))
                    {
                        var unit = itemDef.unit();
                        var qty = new Quantity();
                        qty.Unit = unit.Display;
                        qty.System = unit.System;
                        qty.Code = unit.Code;

                        // Convert this value into a quantity
                        if (answer.Value is FhirDecimal decValue)
                        {
                            qty.Value = decValue.Value;
                            obs.Value = qty;
                        }
                        else if (answer.Value is Integer intValue)
                        {
                            qty.Value = intValue.Value;
                            obs.Value = qty;
                        }
                        else
                        {
                            obs.Value = answer.Value;
                        }
                    }
                    else
                    {
                        obs.Value = answer.Value;
                    }
                    results.AddResourceEntry(obs, $"urn:uuid:{Guid.NewGuid().ToFhirId()}");
                }
            }

            // Check for child items
            foreach (var childDef in itemDef.Item)
            {
                foreach (var childA in itemsA.Select(i => i.Item.Where(ch => ch.LinkId == childDef.LinkId)))
                {
                    ExtractItemObservationData(qr, results, outcome, childDef, childA, extractAllItems, defaultObservationExtractCategory);
                }
            }
        }
    }
}
