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
		public void Parse(Hl7.Fhir.Model.ClinicalUseDefinition.InteractionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "interactant":
							var newItem_interactant = new Hl7.Fhir.Model.ClinicalUseDefinition.InteractantComponent();
							Parse(newItem_interactant, reader, outcome, locationPath + ".interactant["+result.Interactant.Count+"]", cancellationToken); // 40
							result.Interactant.Add(newItem_interactant);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "effect":
							result.Effect = new Hl7.Fhir.Model.CodeableReference();
							Parse(result.Effect as Hl7.Fhir.Model.CodeableReference, reader, outcome, locationPath + ".effect", cancellationToken); // 60
							break;
						case "incidence":
							result.Incidence = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Incidence as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".incidence", cancellationToken); // 70
							break;
						case "management":
							var newItem_management = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_management, reader, outcome, locationPath + ".management["+result.Management.Count+"]", cancellationToken); // 80
							result.Management.Add(newItem_management);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ClinicalUseDefinition.InteractionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "interactant":
							var newItem_interactant = new Hl7.Fhir.Model.ClinicalUseDefinition.InteractantComponent();
							await ParseAsync(newItem_interactant, reader, outcome, locationPath + ".interactant["+result.Interactant.Count+"]", cancellationToken); // 40
							result.Interactant.Add(newItem_interactant);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "effect":
							result.Effect = new Hl7.Fhir.Model.CodeableReference();
							await ParseAsync(result.Effect as Hl7.Fhir.Model.CodeableReference, reader, outcome, locationPath + ".effect", cancellationToken); // 60
							break;
						case "incidence":
							result.Incidence = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Incidence as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".incidence", cancellationToken); // 70
							break;
						case "management":
							var newItem_management = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_management, reader, outcome, locationPath + ".management["+result.Management.Count+"]", cancellationToken); // 80
							result.Management.Add(newItem_management);
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
