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
		public void Parse(Hl7.Fhir.Model.PlanDefinition.GoalComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 40
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Description as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".description"); // 50
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority"); // 60
							break;
						case "start":
							result.Start = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Start as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".start"); // 70
							break;
						case "addresses":
							var newItem_addresses = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_addresses, reader, outcome, locationPath + ".addresses["+result.Addresses.Count+"]"); // 80
							result.Addresses.Add(newItem_addresses);
							break;
						case "documentation":
							var newItem_documentation = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_documentation, reader, outcome, locationPath + ".documentation["+result.Documentation.Count+"]"); // 90
							result.Documentation.Add(newItem_documentation);
							break;
						case "target":
							var newItem_target = new Hl7.Fhir.Model.PlanDefinition.TargetComponent();
							Parse(newItem_target, reader, outcome, locationPath + ".target["+result.Target.Count+"]"); // 100
							result.Target.Add(newItem_target);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.PlanDefinition.GoalComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 40
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Description as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".description"); // 50
							break;
						case "priority":
							result.Priority = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Priority as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".priority"); // 60
							break;
						case "start":
							result.Start = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Start as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".start"); // 70
							break;
						case "addresses":
							var newItem_addresses = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_addresses, reader, outcome, locationPath + ".addresses["+result.Addresses.Count+"]"); // 80
							result.Addresses.Add(newItem_addresses);
							break;
						case "documentation":
							var newItem_documentation = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_documentation, reader, outcome, locationPath + ".documentation["+result.Documentation.Count+"]"); // 90
							result.Documentation.Add(newItem_documentation);
							break;
						case "target":
							var newItem_target = new Hl7.Fhir.Model.PlanDefinition.TargetComponent();
							await ParseAsync(newItem_target, reader, outcome, locationPath + ".target["+result.Target.Count+"]"); // 100
							result.Target.Add(newItem_target);
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
