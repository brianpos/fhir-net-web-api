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
		public void Parse(Hl7.Fhir.Model.NutritionOrder.OralDietComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 40
							result.Type.Add(newItem_type);
							break;
						case "schedule":
							var newItem_schedule = new Hl7.Fhir.Model.Timing();
							Parse(newItem_schedule, reader, outcome, locationPath + ".schedule["+result.Schedule.Count+"]", cancellationToken); // 50
							result.Schedule.Add(newItem_schedule);
							break;
						case "nutrient":
							var newItem_nutrient = new Hl7.Fhir.Model.NutritionOrder.NutrientComponent();
							Parse(newItem_nutrient, reader, outcome, locationPath + ".nutrient["+result.Nutrient.Count+"]", cancellationToken); // 60
							result.Nutrient.Add(newItem_nutrient);
							break;
						case "texture":
							var newItem_texture = new Hl7.Fhir.Model.NutritionOrder.TextureComponent();
							Parse(newItem_texture, reader, outcome, locationPath + ".texture["+result.Texture.Count+"]", cancellationToken); // 70
							result.Texture.Add(newItem_texture);
							break;
						case "fluidConsistencyType":
							var newItem_fluidConsistencyType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_fluidConsistencyType, reader, outcome, locationPath + ".fluidConsistencyType["+result.FluidConsistencyType.Count+"]", cancellationToken); // 80
							result.FluidConsistencyType.Add(newItem_fluidConsistencyType);
							break;
						case "instruction":
							result.InstructionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.InstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".instruction", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.NutritionOrder.OralDietComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 40
							result.Type.Add(newItem_type);
							break;
						case "schedule":
							var newItem_schedule = new Hl7.Fhir.Model.Timing();
							await ParseAsync(newItem_schedule, reader, outcome, locationPath + ".schedule["+result.Schedule.Count+"]", cancellationToken); // 50
							result.Schedule.Add(newItem_schedule);
							break;
						case "nutrient":
							var newItem_nutrient = new Hl7.Fhir.Model.NutritionOrder.NutrientComponent();
							await ParseAsync(newItem_nutrient, reader, outcome, locationPath + ".nutrient["+result.Nutrient.Count+"]", cancellationToken); // 60
							result.Nutrient.Add(newItem_nutrient);
							break;
						case "texture":
							var newItem_texture = new Hl7.Fhir.Model.NutritionOrder.TextureComponent();
							await ParseAsync(newItem_texture, reader, outcome, locationPath + ".texture["+result.Texture.Count+"]", cancellationToken); // 70
							result.Texture.Add(newItem_texture);
							break;
						case "fluidConsistencyType":
							var newItem_fluidConsistencyType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_fluidConsistencyType, reader, outcome, locationPath + ".fluidConsistencyType["+result.FluidConsistencyType.Count+"]", cancellationToken); // 80
							result.FluidConsistencyType.Add(newItem_fluidConsistencyType);
							break;
						case "instruction":
							result.InstructionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.InstructionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".instruction", cancellationToken); // 90
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
