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
		private void Parse(Bundle result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 50
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Bundle.BundleType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Bundle.BundleType>, reader, outcome, locationPath + ".type"); // 60
							break;
						case "timestamp":
							result.TimestampElement = new Hl7.Fhir.Model.Instant();
							Parse(result.TimestampElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".timestamp"); // 70
							break;
						case "total":
							result.TotalElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.TotalElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".total"); // 80
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.Bundle.LinkComponent();
							Parse(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]"); // 90
							result.Link.Add(newItem_link);
							break;
						case "entry":
							var newItem_entry = new Hl7.Fhir.Model.Bundle.EntryComponent();
							Parse(newItem_entry, reader, outcome, locationPath + ".entry["+result.Entry.Count+"]"); // 100
							result.Entry.Add(newItem_entry);
							break;
						case "signature":
							result.Signature = new Hl7.Fhir.Model.Signature();
							Parse(result.Signature as Hl7.Fhir.Model.Signature, reader, outcome, locationPath + ".signature"); // 110
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

		private async System.Threading.Tasks.Task ParseAsync(Bundle result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier"); // 50
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Bundle.BundleType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Bundle.BundleType>, reader, outcome, locationPath + ".type"); // 60
							break;
						case "timestamp":
							result.TimestampElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.TimestampElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".timestamp"); // 70
							break;
						case "total":
							result.TotalElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.TotalElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".total"); // 80
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.Bundle.LinkComponent();
							await ParseAsync(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]"); // 90
							result.Link.Add(newItem_link);
							break;
						case "entry":
							var newItem_entry = new Hl7.Fhir.Model.Bundle.EntryComponent();
							await ParseAsync(newItem_entry, reader, outcome, locationPath + ".entry["+result.Entry.Count+"]"); // 100
							result.Entry.Add(newItem_entry);
							break;
						case "signature":
							result.Signature = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.Signature as Hl7.Fhir.Model.Signature, reader, outcome, locationPath + ".signature"); // 110
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
