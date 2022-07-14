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
		public void Parse(Hl7.Fhir.Model.Claim.InsuranceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.SequenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".sequence", cancellationToken); // 40
							break;
						case "focal":
							result.FocalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.FocalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".focal", cancellationToken); // 50
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 60
							break;
						case "coverage":
							result.Coverage = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Coverage as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".coverage", cancellationToken); // 70
							break;
						case "businessArrangement":
							result.BusinessArrangementElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.BusinessArrangementElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".businessArrangement", cancellationToken); // 80
							break;
						case "preAuthRef":
							var newItem_preAuthRef = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_preAuthRef, reader, outcome, locationPath + ".preAuthRef["+result.PreAuthRefElement.Count+"]", cancellationToken); // 90
							result.PreAuthRefElement.Add(newItem_preAuthRef);
							break;
						case "claimResponse":
							result.ClaimResponse = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ClaimResponse as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".claimResponse", cancellationToken); // 100
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Claim.InsuranceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.SequenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".sequence", cancellationToken); // 40
							break;
						case "focal":
							result.FocalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.FocalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".focal", cancellationToken); // 50
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 60
							break;
						case "coverage":
							result.Coverage = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Coverage as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".coverage", cancellationToken); // 70
							break;
						case "businessArrangement":
							result.BusinessArrangementElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.BusinessArrangementElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".businessArrangement", cancellationToken); // 80
							break;
						case "preAuthRef":
							var newItem_preAuthRef = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_preAuthRef, reader, outcome, locationPath + ".preAuthRef["+result.PreAuthRefElement.Count+"]", cancellationToken); // 90
							result.PreAuthRefElement.Add(newItem_preAuthRef);
							break;
						case "claimResponse":
							result.ClaimResponse = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ClaimResponse as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".claimResponse", cancellationToken); // 100
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
