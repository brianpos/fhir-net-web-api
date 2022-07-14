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
		private void Parse(NutritionProduct result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.NutritionProduct.NutritionProductStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.NutritionProduct.NutritionProductStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 90
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 100
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 110
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 120
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "nutrient":
							var newItem_nutrient = new Hl7.Fhir.Model.NutritionProduct.NutrientComponent();
							Parse(newItem_nutrient, reader, outcome, locationPath + ".nutrient["+result.Nutrient.Count+"]", cancellationToken); // 130
							result.Nutrient.Add(newItem_nutrient);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.NutritionProduct.IngredientComponent();
							Parse(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 140
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "knownAllergen":
							var newItem_knownAllergen = new Hl7.Fhir.Model.CodeableReference();
							Parse(newItem_knownAllergen, reader, outcome, locationPath + ".knownAllergen["+result.KnownAllergen.Count+"]", cancellationToken); // 150
							result.KnownAllergen.Add(newItem_knownAllergen);
							break;
						case "productCharacteristic":
							var newItem_productCharacteristic = new Hl7.Fhir.Model.NutritionProduct.ProductCharacteristicComponent();
							Parse(newItem_productCharacteristic, reader, outcome, locationPath + ".productCharacteristic["+result.ProductCharacteristic.Count+"]", cancellationToken); // 160
							result.ProductCharacteristic.Add(newItem_productCharacteristic);
							break;
						case "instance":
							result.Instance = new Hl7.Fhir.Model.NutritionProduct.InstanceComponent();
							Parse(result.Instance as Hl7.Fhir.Model.NutritionProduct.InstanceComponent, reader, outcome, locationPath + ".instance", cancellationToken); // 170
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 180
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

		private async System.Threading.Tasks.Task ParseAsync(NutritionProduct result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.NutritionProduct.NutritionProductStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.NutritionProduct.NutritionProductStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 90
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 100
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 110
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 120
							result.Manufacturer.Add(newItem_manufacturer);
							break;
						case "nutrient":
							var newItem_nutrient = new Hl7.Fhir.Model.NutritionProduct.NutrientComponent();
							await ParseAsync(newItem_nutrient, reader, outcome, locationPath + ".nutrient["+result.Nutrient.Count+"]", cancellationToken); // 130
							result.Nutrient.Add(newItem_nutrient);
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.NutritionProduct.IngredientComponent();
							await ParseAsync(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 140
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "knownAllergen":
							var newItem_knownAllergen = new Hl7.Fhir.Model.CodeableReference();
							await ParseAsync(newItem_knownAllergen, reader, outcome, locationPath + ".knownAllergen["+result.KnownAllergen.Count+"]", cancellationToken); // 150
							result.KnownAllergen.Add(newItem_knownAllergen);
							break;
						case "productCharacteristic":
							var newItem_productCharacteristic = new Hl7.Fhir.Model.NutritionProduct.ProductCharacteristicComponent();
							await ParseAsync(newItem_productCharacteristic, reader, outcome, locationPath + ".productCharacteristic["+result.ProductCharacteristic.Count+"]", cancellationToken); // 160
							result.ProductCharacteristic.Add(newItem_productCharacteristic);
							break;
						case "instance":
							result.Instance = new Hl7.Fhir.Model.NutritionProduct.InstanceComponent();
							await ParseAsync(result.Instance as Hl7.Fhir.Model.NutritionProduct.InstanceComponent, reader, outcome, locationPath + ".instance", cancellationToken); // 170
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 180
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
