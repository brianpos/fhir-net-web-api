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
		public void Parse(Hl7.Fhir.Model.Evidence.VariableDefinitionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 50
							result.Note.Add(newItem_note);
							break;
						case "variableRole":
							result.VariableRole = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.VariableRole as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".variableRole", cancellationToken); // 60
							break;
						case "observed":
							result.Observed = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Observed as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".observed", cancellationToken); // 70
							break;
						case "intended":
							result.Intended = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Intended as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".intended", cancellationToken); // 80
							break;
						case "directnessMatch":
							result.DirectnessMatch = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.DirectnessMatch as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".directnessMatch", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Evidence.VariableDefinitionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 50
							result.Note.Add(newItem_note);
							break;
						case "variableRole":
							result.VariableRole = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.VariableRole as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".variableRole", cancellationToken); // 60
							break;
						case "observed":
							result.Observed = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Observed as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".observed", cancellationToken); // 70
							break;
						case "intended":
							result.Intended = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Intended as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".intended", cancellationToken); // 80
							break;
						case "directnessMatch":
							result.DirectnessMatch = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.DirectnessMatch as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".directnessMatch", cancellationToken); // 90
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
