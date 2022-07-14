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
		public void Parse(Hl7.Fhir.Model.Signature result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							var newItem_type = new Hl7.Fhir.Model.Coding();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 30
							result.Type.Add(newItem_type);
							break;
						case "when":
							result.WhenElement = new Hl7.Fhir.Model.Instant();
							Parse(result.WhenElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".when", cancellationToken); // 40
							break;
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who", cancellationToken); // 50
							break;
						case "onBehalfOf":
							result.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OnBehalfOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".onBehalfOf", cancellationToken); // 60
							break;
						case "targetFormat":
							result.TargetFormatElement = new Hl7.Fhir.Model.Code();
							Parse(result.TargetFormatElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".targetFormat", cancellationToken); // 70
							break;
						case "sigFormat":
							result.SigFormatElement = new Hl7.Fhir.Model.Code();
							Parse(result.SigFormatElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".sigFormat", cancellationToken); // 80
							break;
						case "data":
							result.DataElement = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.DataElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".data", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Signature result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "type":
							var newItem_type = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 30
							result.Type.Add(newItem_type);
							break;
						case "when":
							result.WhenElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.WhenElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".when", cancellationToken); // 40
							break;
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who", cancellationToken); // 50
							break;
						case "onBehalfOf":
							result.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OnBehalfOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".onBehalfOf", cancellationToken); // 60
							break;
						case "targetFormat":
							result.TargetFormatElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.TargetFormatElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".targetFormat", cancellationToken); // 70
							break;
						case "sigFormat":
							result.SigFormatElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.SigFormatElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".sigFormat", cancellationToken); // 80
							break;
						case "data":
							result.DataElement = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.DataElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".data", cancellationToken); // 90
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
