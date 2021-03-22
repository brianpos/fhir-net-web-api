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
		public void Parse(Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "coverage":
							result.Coverage = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Coverage as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".coverage", cancellationToken); // 40
							break;
						case "inforce":
							result.InforceElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.InforceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".inforce", cancellationToken); // 50
							break;
						case "benefitPeriod":
							result.BenefitPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.BenefitPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".benefitPeriod", cancellationToken); // 60
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent();
							Parse(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]", cancellationToken); // 70
							result.Item.Add(newItem_item);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "coverage":
							result.Coverage = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Coverage as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".coverage", cancellationToken); // 40
							break;
						case "inforce":
							result.InforceElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.InforceElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".inforce", cancellationToken); // 50
							break;
						case "benefitPeriod":
							result.BenefitPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.BenefitPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".benefitPeriod", cancellationToken); // 60
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent();
							await ParseAsync(newItem_item, reader, outcome, locationPath + ".item["+result.Item.Count+"]", cancellationToken); // 70
							result.Item.Add(newItem_item);
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
