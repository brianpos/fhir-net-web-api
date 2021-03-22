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
		public void Parse(Hl7.Fhir.Model.Population result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "ageRange":
							result.Age = new Hl7.Fhir.Model.Range();
							Parse(result.Age as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".age", cancellationToken); // 90
							break;
						case "ageCodeableConcept":
							result.Age = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Age as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".age", cancellationToken); // 90
							break;
						case "gender":
							result.Gender = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Gender as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".gender", cancellationToken); // 100
							break;
						case "race":
							result.Race = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Race as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".race", cancellationToken); // 110
							break;
						case "physiologicalCondition":
							result.PhysiologicalCondition = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PhysiologicalCondition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".physiologicalCondition", cancellationToken); // 120
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Population result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "ageRange":
							result.Age = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Age as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".age", cancellationToken); // 90
							break;
						case "ageCodeableConcept":
							result.Age = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Age as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".age", cancellationToken); // 90
							break;
						case "gender":
							result.Gender = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Gender as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".gender", cancellationToken); // 100
							break;
						case "race":
							result.Race = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Race as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".race", cancellationToken); // 110
							break;
						case "physiologicalCondition":
							result.PhysiologicalCondition = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PhysiologicalCondition as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".physiologicalCondition", cancellationToken); // 120
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
