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
		public void Parse(Hl7.Fhir.Model.ValueSet.ComposeComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "lockedDate":
							result.LockedDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.LockedDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".lockedDate"); // 40
							break;
						case "inactive":
							result.InactiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.InactiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".inactive"); // 50
							break;
						case "include":
							var newItem_include = new Hl7.Fhir.Model.ValueSet.ConceptSetComponent();
							Parse(newItem_include, reader, outcome, locationPath + ".include["+result.Include.Count+"]"); // 60
							result.Include.Add(newItem_include);
							break;
						case "exclude":
							var newItem_exclude = new Hl7.Fhir.Model.ValueSet.ConceptSetComponent();
							Parse(newItem_exclude, reader, outcome, locationPath + ".exclude["+result.Exclude.Count+"]"); // 70
							result.Exclude.Add(newItem_exclude);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ValueSet.ComposeComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "lockedDate":
							result.LockedDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.LockedDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".lockedDate"); // 40
							break;
						case "inactive":
							result.InactiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.InactiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".inactive"); // 50
							break;
						case "include":
							var newItem_include = new Hl7.Fhir.Model.ValueSet.ConceptSetComponent();
							await ParseAsync(newItem_include, reader, outcome, locationPath + ".include["+result.Include.Count+"]"); // 60
							result.Include.Add(newItem_include);
							break;
						case "exclude":
							var newItem_exclude = new Hl7.Fhir.Model.ValueSet.ConceptSetComponent();
							await ParseAsync(newItem_exclude, reader, outcome, locationPath + ".exclude["+result.Exclude.Count+"]"); // 70
							result.Exclude.Add(newItem_exclude);
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
