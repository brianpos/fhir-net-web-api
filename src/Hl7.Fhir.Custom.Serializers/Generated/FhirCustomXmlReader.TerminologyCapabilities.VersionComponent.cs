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
		public void Parse(Hl7.Fhir.Model.TerminologyCapabilities.VersionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CodeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "isDefault":
							result.IsDefaultElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsDefaultElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isDefault", cancellationToken); // 50
							break;
						case "compositional":
							result.CompositionalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.CompositionalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".compositional", cancellationToken); // 60
							break;
						case "language":
							var newItem_language = new Hl7.Fhir.Model.Code();
							Parse(newItem_language, reader, outcome, locationPath + ".language["+result.LanguageElement.Count+"]", cancellationToken); // 70
							result.LanguageElement.Add(newItem_language);
							break;
						case "filter":
							var newItem_filter = new Hl7.Fhir.Model.TerminologyCapabilities.FilterComponent();
							Parse(newItem_filter, reader, outcome, locationPath + ".filter["+result.Filter.Count+"]", cancellationToken); // 80
							result.Filter.Add(newItem_filter);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.Code();
							Parse(newItem_property, reader, outcome, locationPath + ".property["+result.PropertyElement.Count+"]", cancellationToken); // 90
							result.PropertyElement.Add(newItem_property);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.TerminologyCapabilities.VersionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "isDefault":
							result.IsDefaultElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsDefaultElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isDefault", cancellationToken); // 50
							break;
						case "compositional":
							result.CompositionalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.CompositionalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".compositional", cancellationToken); // 60
							break;
						case "language":
							var newItem_language = new Hl7.Fhir.Model.Code();
							await ParseAsync(newItem_language, reader, outcome, locationPath + ".language["+result.LanguageElement.Count+"]", cancellationToken); // 70
							result.LanguageElement.Add(newItem_language);
							break;
						case "filter":
							var newItem_filter = new Hl7.Fhir.Model.TerminologyCapabilities.FilterComponent();
							await ParseAsync(newItem_filter, reader, outcome, locationPath + ".filter["+result.Filter.Count+"]", cancellationToken); // 80
							result.Filter.Add(newItem_filter);
							break;
						case "property":
							var newItem_property = new Hl7.Fhir.Model.Code();
							await ParseAsync(newItem_property, reader, outcome, locationPath + ".property["+result.PropertyElement.Count+"]", cancellationToken); // 90
							result.PropertyElement.Add(newItem_property);
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
