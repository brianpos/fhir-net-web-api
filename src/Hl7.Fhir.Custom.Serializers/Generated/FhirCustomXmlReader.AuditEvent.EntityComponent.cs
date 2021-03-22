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
		public void Parse(Hl7.Fhir.Model.AuditEvent.EntityComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "what":
							result.What = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.What as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".what", cancellationToken); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.Coding();
							Parse(result.Type as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "role":
							result.Role = new Hl7.Fhir.Model.Coding();
							Parse(result.Role as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".role", cancellationToken); // 60
							break;
						case "lifecycle":
							result.Lifecycle = new Hl7.Fhir.Model.Coding();
							Parse(result.Lifecycle as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".lifecycle", cancellationToken); // 70
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.Coding();
							Parse(newItem_securityLabel, reader, outcome, locationPath + ".securityLabel["+result.SecurityLabel.Count+"]", cancellationToken); // 80
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 90
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 100
							break;
						case "query":
							result.QueryElement = new Hl7.Fhir.Model.Base64Binary();
							Parse(result.QueryElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".query", cancellationToken); // 110
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.AuditEvent.DetailComponent();
							Parse(newItem_detail, reader, outcome, locationPath + ".detail["+result.Detail.Count+"]", cancellationToken); // 120
							result.Detail.Add(newItem_detail);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.AuditEvent.EntityComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "what":
							result.What = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.What as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".what", cancellationToken); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Type as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "role":
							result.Role = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Role as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".role", cancellationToken); // 60
							break;
						case "lifecycle":
							result.Lifecycle = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Lifecycle as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".lifecycle", cancellationToken); // 70
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_securityLabel, reader, outcome, locationPath + ".securityLabel["+result.SecurityLabel.Count+"]", cancellationToken); // 80
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 90
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 100
							break;
						case "query":
							result.QueryElement = new Hl7.Fhir.Model.Base64Binary();
							await ParseAsync(result.QueryElement as Hl7.Fhir.Model.Base64Binary, reader, outcome, locationPath + ".query", cancellationToken); // 110
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.AuditEvent.DetailComponent();
							await ParseAsync(newItem_detail, reader, outcome, locationPath + ".detail["+result.Detail.Count+"]", cancellationToken); // 120
							result.Detail.Add(newItem_detail);
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
