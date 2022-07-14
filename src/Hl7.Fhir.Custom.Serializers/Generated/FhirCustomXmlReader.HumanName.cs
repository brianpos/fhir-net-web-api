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
		public void Parse(Hl7.Fhir.Model.HumanName result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.HumanName.NameUse>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.HumanName.NameUse>, reader, outcome, locationPath + ".use", cancellationToken); // 30
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 40
							break;
						case "family":
							result.FamilyElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.FamilyElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".family", cancellationToken); // 50
							break;
						case "given":
							var newItem_given = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_given, reader, outcome, locationPath + ".given["+result.GivenElement.Count+"]", cancellationToken); // 60
							result.GivenElement.Add(newItem_given);
							break;
						case "prefix":
							var newItem_prefix = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_prefix, reader, outcome, locationPath + ".prefix["+result.PrefixElement.Count+"]", cancellationToken); // 70
							result.PrefixElement.Add(newItem_prefix);
							break;
						case "suffix":
							var newItem_suffix = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_suffix, reader, outcome, locationPath + ".suffix["+result.SuffixElement.Count+"]", cancellationToken); // 80
							result.SuffixElement.Add(newItem_suffix);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.HumanName result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.HumanName.NameUse>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.HumanName.NameUse>, reader, outcome, locationPath + ".use", cancellationToken); // 30
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 40
							break;
						case "family":
							result.FamilyElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.FamilyElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".family", cancellationToken); // 50
							break;
						case "given":
							var newItem_given = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_given, reader, outcome, locationPath + ".given["+result.GivenElement.Count+"]", cancellationToken); // 60
							result.GivenElement.Add(newItem_given);
							break;
						case "prefix":
							var newItem_prefix = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_prefix, reader, outcome, locationPath + ".prefix["+result.PrefixElement.Count+"]", cancellationToken); // 70
							result.PrefixElement.Add(newItem_prefix);
							break;
						case "suffix":
							var newItem_suffix = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_suffix, reader, outcome, locationPath + ".suffix["+result.SuffixElement.Count+"]", cancellationToken); // 80
							result.SuffixElement.Add(newItem_suffix);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 90
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
