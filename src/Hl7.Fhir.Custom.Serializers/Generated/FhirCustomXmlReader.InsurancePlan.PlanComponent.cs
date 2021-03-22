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
		public void Parse(Hl7.Fhir.Model.InsurancePlan.PlanComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "coverageArea":
							var newItem_coverageArea = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_coverageArea, reader, outcome, locationPath + ".coverageArea["+result.CoverageArea.Count+"]", cancellationToken); // 60
							result.CoverageArea.Add(newItem_coverageArea);
							break;
						case "network":
							var newItem_network = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_network, reader, outcome, locationPath + ".network["+result.Network.Count+"]", cancellationToken); // 70
							result.Network.Add(newItem_network);
							break;
						case "generalCost":
							var newItem_generalCost = new Hl7.Fhir.Model.InsurancePlan.GeneralCostComponent();
							Parse(newItem_generalCost, reader, outcome, locationPath + ".generalCost["+result.GeneralCost.Count+"]", cancellationToken); // 80
							result.GeneralCost.Add(newItem_generalCost);
							break;
						case "specificCost":
							var newItem_specificCost = new Hl7.Fhir.Model.InsurancePlan.SpecificCostComponent();
							Parse(newItem_specificCost, reader, outcome, locationPath + ".specificCost["+result.SpecificCost.Count+"]", cancellationToken); // 90
							result.SpecificCost.Add(newItem_specificCost);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.InsurancePlan.PlanComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "coverageArea":
							var newItem_coverageArea = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_coverageArea, reader, outcome, locationPath + ".coverageArea["+result.CoverageArea.Count+"]", cancellationToken); // 60
							result.CoverageArea.Add(newItem_coverageArea);
							break;
						case "network":
							var newItem_network = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_network, reader, outcome, locationPath + ".network["+result.Network.Count+"]", cancellationToken); // 70
							result.Network.Add(newItem_network);
							break;
						case "generalCost":
							var newItem_generalCost = new Hl7.Fhir.Model.InsurancePlan.GeneralCostComponent();
							await ParseAsync(newItem_generalCost, reader, outcome, locationPath + ".generalCost["+result.GeneralCost.Count+"]", cancellationToken); // 80
							result.GeneralCost.Add(newItem_generalCost);
							break;
						case "specificCost":
							var newItem_specificCost = new Hl7.Fhir.Model.InsurancePlan.SpecificCostComponent();
							await ParseAsync(newItem_specificCost, reader, outcome, locationPath + ".specificCost["+result.SpecificCost.Count+"]", cancellationToken); // 90
							result.SpecificCost.Add(newItem_specificCost);
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
