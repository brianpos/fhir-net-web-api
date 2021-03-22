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
		public void Parse(Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "orientationOfPolymerisation":
							result.OrientationOfPolymerisation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OrientationOfPolymerisation as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".orientationOfPolymerisation", cancellationToken); // 40
							break;
						case "repeatUnit":
							result.RepeatUnitElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RepeatUnitElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".repeatUnit", cancellationToken); // 50
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SubstanceAmount();
							Parse(result.Amount as Hl7.Fhir.Model.SubstanceAmount, reader, outcome, locationPath + ".amount", cancellationToken); // 60
							break;
						case "degreeOfPolymerisation":
							var newItem_degreeOfPolymerisation = new Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent();
							Parse(newItem_degreeOfPolymerisation, reader, outcome, locationPath + ".degreeOfPolymerisation["+result.DegreeOfPolymerisation.Count+"]", cancellationToken); // 70
							result.DegreeOfPolymerisation.Add(newItem_degreeOfPolymerisation);
							break;
						case "structuralRepresentation":
							var newItem_structuralRepresentation = new Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent();
							Parse(newItem_structuralRepresentation, reader, outcome, locationPath + ".structuralRepresentation["+result.StructuralRepresentation.Count+"]", cancellationToken); // 80
							result.StructuralRepresentation.Add(newItem_structuralRepresentation);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "orientationOfPolymerisation":
							result.OrientationOfPolymerisation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OrientationOfPolymerisation as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".orientationOfPolymerisation", cancellationToken); // 40
							break;
						case "repeatUnit":
							result.RepeatUnitElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RepeatUnitElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".repeatUnit", cancellationToken); // 50
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SubstanceAmount();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.SubstanceAmount, reader, outcome, locationPath + ".amount", cancellationToken); // 60
							break;
						case "degreeOfPolymerisation":
							var newItem_degreeOfPolymerisation = new Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent();
							await ParseAsync(newItem_degreeOfPolymerisation, reader, outcome, locationPath + ".degreeOfPolymerisation["+result.DegreeOfPolymerisation.Count+"]", cancellationToken); // 70
							result.DegreeOfPolymerisation.Add(newItem_degreeOfPolymerisation);
							break;
						case "structuralRepresentation":
							var newItem_structuralRepresentation = new Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent();
							await ParseAsync(newItem_structuralRepresentation, reader, outcome, locationPath + ".structuralRepresentation["+result.StructuralRepresentation.Count+"]", cancellationToken); // 80
							result.StructuralRepresentation.Add(newItem_structuralRepresentation);
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
