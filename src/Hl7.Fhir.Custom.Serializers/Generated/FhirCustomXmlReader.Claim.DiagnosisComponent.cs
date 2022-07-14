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
		public void Parse(Hl7.Fhir.Model.Claim.DiagnosisComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "diagnosisCodeableConcept":
							result.Diagnosis = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Diagnosis as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".diagnosis", cancellationToken); // 50
							break;
						case "diagnosisReference":
							result.Diagnosis = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Diagnosis as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".diagnosis", cancellationToken); // 50
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 60
							result.Type.Add(newItem_type);
							break;
						case "onAdmission":
							result.OnAdmission = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OnAdmission as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".onAdmission", cancellationToken); // 70
							break;
						case "packageCode":
							result.PackageCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PackageCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".packageCode", cancellationToken); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Claim.DiagnosisComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "diagnosisCodeableConcept":
							result.Diagnosis = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Diagnosis as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".diagnosis", cancellationToken); // 50
							break;
						case "diagnosisReference":
							result.Diagnosis = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Diagnosis as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".diagnosis", cancellationToken); // 50
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 60
							result.Type.Add(newItem_type);
							break;
						case "onAdmission":
							result.OnAdmission = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OnAdmission as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".onAdmission", cancellationToken); // 70
							break;
						case "packageCode":
							result.PackageCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PackageCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".packageCode", cancellationToken); // 80
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
