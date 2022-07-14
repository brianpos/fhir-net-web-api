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
		public void Parse(Hl7.Fhir.Model.Bundle.ResponseComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.StatusElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".status", cancellationToken); // 40
							break;
						case "location":
							result.LocationElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.LocationElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".location", cancellationToken); // 50
							break;
						case "etag":
							result.EtagElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.EtagElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".etag", cancellationToken); // 60
							break;
						case "lastModified":
							result.LastModifiedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.LastModifiedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".lastModified", cancellationToken); // 70
							break;
						case "outcome":
							// FirstChildOf(reader); // 80
							var OutcomeResource = Parse(reader, outcome, locationPath + ".outcome", cancellationToken);
							result.Outcome = OutcomeResource;
							if (!reader.Read()) return;
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Bundle.ResponseComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".status", cancellationToken); // 40
							break;
						case "location":
							result.LocationElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.LocationElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".location", cancellationToken); // 50
							break;
						case "etag":
							result.EtagElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.EtagElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".etag", cancellationToken); // 60
							break;
						case "lastModified":
							result.LastModifiedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.LastModifiedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".lastModified", cancellationToken); // 70
							break;
						case "outcome":
							// FirstChildOf(reader); // 80
							var OutcomeResource = await ParseAsync(reader, outcome, locationPath + ".outcome", cancellationToken);
							result.Outcome = OutcomeResource;
							if (!reader.Read()) return;
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
