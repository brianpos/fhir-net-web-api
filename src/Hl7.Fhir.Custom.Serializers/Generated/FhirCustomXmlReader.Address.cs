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
		public void Parse(Hl7.Fhir.Model.Address result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressUse>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressUse>, reader, outcome, locationPath + ".use"); // 30
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressType>, reader, outcome, locationPath + ".type"); // 40
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text"); // 50
							break;
						case "line":
							var newItem_line = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_line, reader, outcome, locationPath + ".line["+result.LineElement.Count+"]"); // 60
							result.LineElement.Add(newItem_line);
							break;
						case "city":
							result.CityElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CityElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".city"); // 70
							break;
						case "district":
							result.DistrictElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DistrictElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".district"); // 80
							break;
						case "state":
							result.StateElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.StateElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".state"); // 90
							break;
						case "postalCode":
							result.PostalCodeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PostalCodeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".postalCode"); // 100
							break;
						case "country":
							result.CountryElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CountryElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".country"); // 110
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 120
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Address result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressUse>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressUse>, reader, outcome, locationPath + ".use"); // 30
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressType>, reader, outcome, locationPath + ".type"); // 40
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text"); // 50
							break;
						case "line":
							var newItem_line = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_line, reader, outcome, locationPath + ".line["+result.LineElement.Count+"]"); // 60
							result.LineElement.Add(newItem_line);
							break;
						case "city":
							result.CityElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CityElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".city"); // 70
							break;
						case "district":
							result.DistrictElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DistrictElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".district"); // 80
							break;
						case "state":
							result.StateElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.StateElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".state"); // 90
							break;
						case "postalCode":
							result.PostalCodeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PostalCodeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".postalCode"); // 100
							break;
						case "country":
							result.CountryElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CountryElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".country"); // 110
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 120
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
