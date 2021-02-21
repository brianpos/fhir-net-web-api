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
		public void Parse(Hl7.Fhir.Model.MedicinalProduct.NameComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
			{
				// contextLocation.Pop();
				return;
			}

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
						case "productName":
							result.ProductNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ProductNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".productName"); // 40
							break;
						case "namePart":
							var newItem_namePart = new Hl7.Fhir.Model.MedicinalProduct.NamePartComponent();
							Parse(newItem_namePart, reader, outcome, locationPath + ".namePart["+result.NamePart.Count+"]"); // 50
							result.NamePart.Add(newItem_namePart);
							break;
						case "countryLanguage":
							var newItem_countryLanguage = new Hl7.Fhir.Model.MedicinalProduct.CountryLanguageComponent();
							Parse(newItem_countryLanguage, reader, outcome, locationPath + ".countryLanguage["+result.CountryLanguage.Count+"]"); // 60
							result.CountryLanguage.Add(newItem_countryLanguage);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicinalProduct.NameComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
			{
				// contextLocation.Pop();
				return;
			}

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
						case "productName":
							result.ProductNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ProductNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".productName"); // 40
							break;
						case "namePart":
							var newItem_namePart = new Hl7.Fhir.Model.MedicinalProduct.NamePartComponent();
							await ParseAsync(newItem_namePart, reader, outcome, locationPath + ".namePart["+result.NamePart.Count+"]"); // 50
							result.NamePart.Add(newItem_namePart);
							break;
						case "countryLanguage":
							var newItem_countryLanguage = new Hl7.Fhir.Model.MedicinalProduct.CountryLanguageComponent();
							await ParseAsync(newItem_countryLanguage, reader, outcome, locationPath + ".countryLanguage["+result.CountryLanguage.Count+"]"); // 60
							result.CountryLanguage.Add(newItem_countryLanguage);
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
