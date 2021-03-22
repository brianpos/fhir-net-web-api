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
		private void Parse(NutritionOrder result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]", cancellationToken); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]", cancellationToken); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "instantiates":
							var newItem_instantiates = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiates, reader, outcome, locationPath + ".instantiates["+result.InstantiatesElement.Count+"]", cancellationToken); // 120
							result.InstantiatesElement.Add(newItem_instantiates);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>();
							Parse(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>, reader, outcome, locationPath + ".intent", cancellationToken); // 140
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 150
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 160
							break;
						case "dateTime":
							result.DateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateTime", cancellationToken); // 170
							break;
						case "orderer":
							result.Orderer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Orderer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".orderer", cancellationToken); // 180
							break;
						case "allergyIntolerance":
							var newItem_allergyIntolerance = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_allergyIntolerance, reader, outcome, locationPath + ".allergyIntolerance["+result.AllergyIntolerance.Count+"]", cancellationToken); // 190
							result.AllergyIntolerance.Add(newItem_allergyIntolerance);
							break;
						case "foodPreferenceModifier":
							var newItem_foodPreferenceModifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_foodPreferenceModifier, reader, outcome, locationPath + ".foodPreferenceModifier["+result.FoodPreferenceModifier.Count+"]", cancellationToken); // 200
							result.FoodPreferenceModifier.Add(newItem_foodPreferenceModifier);
							break;
						case "excludeFoodModifier":
							var newItem_excludeFoodModifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_excludeFoodModifier, reader, outcome, locationPath + ".excludeFoodModifier["+result.ExcludeFoodModifier.Count+"]", cancellationToken); // 210
							result.ExcludeFoodModifier.Add(newItem_excludeFoodModifier);
							break;
						case "oralDiet":
							result.OralDiet = new Hl7.Fhir.Model.NutritionOrder.OralDietComponent();
							Parse(result.OralDiet as Hl7.Fhir.Model.NutritionOrder.OralDietComponent, reader, outcome, locationPath + ".oralDiet", cancellationToken); // 220
							break;
						case "supplement":
							var newItem_supplement = new Hl7.Fhir.Model.NutritionOrder.SupplementComponent();
							Parse(newItem_supplement, reader, outcome, locationPath + ".supplement["+result.Supplement.Count+"]", cancellationToken); // 230
							result.Supplement.Add(newItem_supplement);
							break;
						case "enteralFormula":
							result.EnteralFormula = new Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent();
							Parse(result.EnteralFormula as Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent, reader, outcome, locationPath + ".enteralFormula", cancellationToken); // 240
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 250
							result.Note.Add(newItem_note);
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

		private async System.Threading.Tasks.Task ParseAsync(NutritionOrder result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]", cancellationToken); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]", cancellationToken); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "instantiates":
							var newItem_instantiates = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiates, reader, outcome, locationPath + ".instantiates["+result.InstantiatesElement.Count+"]", cancellationToken); // 120
							result.InstantiatesElement.Add(newItem_instantiates);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>();
							await ParseAsync(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>, reader, outcome, locationPath + ".intent", cancellationToken); // 140
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 150
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 160
							break;
						case "dateTime":
							result.DateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateTime", cancellationToken); // 170
							break;
						case "orderer":
							result.Orderer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Orderer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".orderer", cancellationToken); // 180
							break;
						case "allergyIntolerance":
							var newItem_allergyIntolerance = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_allergyIntolerance, reader, outcome, locationPath + ".allergyIntolerance["+result.AllergyIntolerance.Count+"]", cancellationToken); // 190
							result.AllergyIntolerance.Add(newItem_allergyIntolerance);
							break;
						case "foodPreferenceModifier":
							var newItem_foodPreferenceModifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_foodPreferenceModifier, reader, outcome, locationPath + ".foodPreferenceModifier["+result.FoodPreferenceModifier.Count+"]", cancellationToken); // 200
							result.FoodPreferenceModifier.Add(newItem_foodPreferenceModifier);
							break;
						case "excludeFoodModifier":
							var newItem_excludeFoodModifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_excludeFoodModifier, reader, outcome, locationPath + ".excludeFoodModifier["+result.ExcludeFoodModifier.Count+"]", cancellationToken); // 210
							result.ExcludeFoodModifier.Add(newItem_excludeFoodModifier);
							break;
						case "oralDiet":
							result.OralDiet = new Hl7.Fhir.Model.NutritionOrder.OralDietComponent();
							await ParseAsync(result.OralDiet as Hl7.Fhir.Model.NutritionOrder.OralDietComponent, reader, outcome, locationPath + ".oralDiet", cancellationToken); // 220
							break;
						case "supplement":
							var newItem_supplement = new Hl7.Fhir.Model.NutritionOrder.SupplementComponent();
							await ParseAsync(newItem_supplement, reader, outcome, locationPath + ".supplement["+result.Supplement.Count+"]", cancellationToken); // 230
							result.Supplement.Add(newItem_supplement);
							break;
						case "enteralFormula":
							result.EnteralFormula = new Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent();
							await ParseAsync(result.EnteralFormula as Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent, reader, outcome, locationPath + ".enteralFormula", cancellationToken); // 240
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 250
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
