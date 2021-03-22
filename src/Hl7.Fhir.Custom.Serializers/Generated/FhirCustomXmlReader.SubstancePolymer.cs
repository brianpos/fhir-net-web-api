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
		private void Parse(SubstancePolymer result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "class":
							result.Class = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Class as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".class", cancellationToken); // 90
							break;
						case "geometry":
							result.Geometry = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Geometry as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".geometry", cancellationToken); // 100
							break;
						case "copolymerConnectivity":
							var newItem_copolymerConnectivity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_copolymerConnectivity, reader, outcome, locationPath + ".copolymerConnectivity["+result.CopolymerConnectivity.Count+"]", cancellationToken); // 110
							result.CopolymerConnectivity.Add(newItem_copolymerConnectivity);
							break;
						case "modification":
							var newItem_modification = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_modification, reader, outcome, locationPath + ".modification["+result.ModificationElement.Count+"]", cancellationToken); // 120
							result.ModificationElement.Add(newItem_modification);
							break;
						case "monomerSet":
							var newItem_monomerSet = new Hl7.Fhir.Model.SubstancePolymer.MonomerSetComponent();
							Parse(newItem_monomerSet, reader, outcome, locationPath + ".monomerSet["+result.MonomerSet.Count+"]", cancellationToken); // 130
							result.MonomerSet.Add(newItem_monomerSet);
							break;
						case "repeat":
							var newItem_repeat = new Hl7.Fhir.Model.SubstancePolymer.RepeatComponent();
							Parse(newItem_repeat, reader, outcome, locationPath + ".repeat["+result.Repeat.Count+"]", cancellationToken); // 140
							result.Repeat.Add(newItem_repeat);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(SubstancePolymer result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "class":
							result.Class = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Class as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".class", cancellationToken); // 90
							break;
						case "geometry":
							result.Geometry = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Geometry as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".geometry", cancellationToken); // 100
							break;
						case "copolymerConnectivity":
							var newItem_copolymerConnectivity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_copolymerConnectivity, reader, outcome, locationPath + ".copolymerConnectivity["+result.CopolymerConnectivity.Count+"]", cancellationToken); // 110
							result.CopolymerConnectivity.Add(newItem_copolymerConnectivity);
							break;
						case "modification":
							var newItem_modification = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_modification, reader, outcome, locationPath + ".modification["+result.ModificationElement.Count+"]", cancellationToken); // 120
							result.ModificationElement.Add(newItem_modification);
							break;
						case "monomerSet":
							var newItem_monomerSet = new Hl7.Fhir.Model.SubstancePolymer.MonomerSetComponent();
							await ParseAsync(newItem_monomerSet, reader, outcome, locationPath + ".monomerSet["+result.MonomerSet.Count+"]", cancellationToken); // 130
							result.MonomerSet.Add(newItem_monomerSet);
							break;
						case "repeat":
							var newItem_repeat = new Hl7.Fhir.Model.SubstancePolymer.RepeatComponent();
							await ParseAsync(newItem_repeat, reader, outcome, locationPath + ".repeat["+result.Repeat.Count+"]", cancellationToken); // 140
							result.Repeat.Add(newItem_repeat);
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
