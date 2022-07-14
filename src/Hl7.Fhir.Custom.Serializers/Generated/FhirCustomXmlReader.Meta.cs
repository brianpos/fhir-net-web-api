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
		public void Parse(Hl7.Fhir.Model.Meta result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "versionId":
							result.VersionIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.VersionIdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".versionId", cancellationToken); // 30
							break;
						case "lastUpdated":
							result.LastUpdatedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.LastUpdatedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".lastUpdated", cancellationToken); // 40
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.SourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".source", cancellationToken); // 50
							break;
						case "profile":
							var newItem_profile = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_profile, reader, outcome, locationPath + ".profile["+result.ProfileElement.Count+"]", cancellationToken); // 60
							result.ProfileElement.Add(newItem_profile);
							break;
						case "security":
							var newItem_security = new Hl7.Fhir.Model.Coding();
							Parse(newItem_security, reader, outcome, locationPath + ".security["+result.Security.Count+"]", cancellationToken); // 70
							result.Security.Add(newItem_security);
							break;
						case "tag":
							var newItem_tag = new Hl7.Fhir.Model.Coding();
							Parse(newItem_tag, reader, outcome, locationPath + ".tag["+result.Tag.Count+"]", cancellationToken); // 80
							result.Tag.Add(newItem_tag);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Meta result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "versionId":
							result.VersionIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.VersionIdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".versionId", cancellationToken); // 30
							break;
						case "lastUpdated":
							result.LastUpdatedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.LastUpdatedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".lastUpdated", cancellationToken); // 40
							break;
						case "source":
							result.SourceElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.SourceElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".source", cancellationToken); // 50
							break;
						case "profile":
							var newItem_profile = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_profile, reader, outcome, locationPath + ".profile["+result.ProfileElement.Count+"]", cancellationToken); // 60
							result.ProfileElement.Add(newItem_profile);
							break;
						case "security":
							var newItem_security = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_security, reader, outcome, locationPath + ".security["+result.Security.Count+"]", cancellationToken); // 70
							result.Security.Add(newItem_security);
							break;
						case "tag":
							var newItem_tag = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_tag, reader, outcome, locationPath + ".tag["+result.Tag.Count+"]", cancellationToken); // 80
							result.Tag.Add(newItem_tag);
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
