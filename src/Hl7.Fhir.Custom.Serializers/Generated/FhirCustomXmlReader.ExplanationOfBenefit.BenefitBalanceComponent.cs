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
		public void Parse(Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 40
							break;
						case "excluded":
							result.ExcludedElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExcludedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".excluded", cancellationToken); // 50
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 70
							break;
						case "network":
							result.Network = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Network as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".network", cancellationToken); // 80
							break;
						case "unit":
							result.Unit = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Unit as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unit", cancellationToken); // 90
							break;
						case "term":
							result.Term = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Term as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".term", cancellationToken); // 100
							break;
						case "financial":
							var newItem_financial = new Hl7.Fhir.Model.ExplanationOfBenefit.BenefitComponent();
							Parse(newItem_financial, reader, outcome, locationPath + ".financial["+result.Financial.Count+"]", cancellationToken); // 110
							result.Financial.Add(newItem_financial);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 40
							break;
						case "excluded":
							result.ExcludedElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExcludedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".excluded", cancellationToken); // 50
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 70
							break;
						case "network":
							result.Network = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Network as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".network", cancellationToken); // 80
							break;
						case "unit":
							result.Unit = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Unit as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unit", cancellationToken); // 90
							break;
						case "term":
							result.Term = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Term as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".term", cancellationToken); // 100
							break;
						case "financial":
							var newItem_financial = new Hl7.Fhir.Model.ExplanationOfBenefit.BenefitComponent();
							await ParseAsync(newItem_financial, reader, outcome, locationPath + ".financial["+result.Financial.Count+"]", cancellationToken); // 110
							result.Financial.Add(newItem_financial);
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
