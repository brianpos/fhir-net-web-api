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
		public void Parse(Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "initialFill":
							result.InitialFill = new Hl7.Fhir.Model.MedicationRequest.InitialFillComponent();
							Parse(result.InitialFill as Hl7.Fhir.Model.MedicationRequest.InitialFillComponent, reader, outcome, locationPath + ".initialFill", cancellationToken); // 40
							break;
						case "dispenseInterval":
							result.DispenseInterval = new Hl7.Fhir.Model.Duration();
							Parse(result.DispenseInterval as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".dispenseInterval", cancellationToken); // 50
							break;
						case "validityPeriod":
							result.ValidityPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.ValidityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".validityPeriod", cancellationToken); // 60
							break;
						case "numberOfRepeatsAllowed":
							result.NumberOfRepeatsAllowedElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberOfRepeatsAllowedElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfRepeatsAllowed", cancellationToken); // 70
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 80
							break;
						case "expectedSupplyDuration":
							result.ExpectedSupplyDuration = new Hl7.Fhir.Model.Duration();
							Parse(result.ExpectedSupplyDuration as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".expectedSupplyDuration", cancellationToken); // 90
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer", cancellationToken); // 100
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "initialFill":
							result.InitialFill = new Hl7.Fhir.Model.MedicationRequest.InitialFillComponent();
							await ParseAsync(result.InitialFill as Hl7.Fhir.Model.MedicationRequest.InitialFillComponent, reader, outcome, locationPath + ".initialFill", cancellationToken); // 40
							break;
						case "dispenseInterval":
							result.DispenseInterval = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.DispenseInterval as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".dispenseInterval", cancellationToken); // 50
							break;
						case "validityPeriod":
							result.ValidityPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.ValidityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".validityPeriod", cancellationToken); // 60
							break;
						case "numberOfRepeatsAllowed":
							result.NumberOfRepeatsAllowedElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberOfRepeatsAllowedElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfRepeatsAllowed", cancellationToken); // 70
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 80
							break;
						case "expectedSupplyDuration":
							result.ExpectedSupplyDuration = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.ExpectedSupplyDuration as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".expectedSupplyDuration", cancellationToken); // 90
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".performer", cancellationToken); // 100
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
