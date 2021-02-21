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
		public void Parse(Hl7.Fhir.Model.VerificationResult.AttestationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who"); // 40
							break;
						case "onBehalfOf":
							result.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OnBehalfOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".onBehalfOf"); // 50
							break;
						case "communicationMethod":
							result.CommunicationMethod = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CommunicationMethod as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".communicationMethod"); // 60
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.Date();
							Parse(result.DateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".date"); // 70
							break;
						case "sourceIdentityCertificate":
							result.SourceIdentityCertificateElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SourceIdentityCertificateElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sourceIdentityCertificate"); // 80
							break;
						case "proxyIdentityCertificate":
							result.ProxyIdentityCertificateElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ProxyIdentityCertificateElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".proxyIdentityCertificate"); // 90
							break;
						case "proxySignature":
							result.ProxySignature = new Hl7.Fhir.Model.Signature();
							Parse(result.ProxySignature as Hl7.Fhir.Model.Signature, reader, outcome, locationPath + ".proxySignature"); // 100
							break;
						case "sourceSignature":
							result.SourceSignature = new Hl7.Fhir.Model.Signature();
							Parse(result.SourceSignature as Hl7.Fhir.Model.Signature, reader, outcome, locationPath + ".sourceSignature"); // 110
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.VerificationResult.AttestationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who"); // 40
							break;
						case "onBehalfOf":
							result.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OnBehalfOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".onBehalfOf"); // 50
							break;
						case "communicationMethod":
							result.CommunicationMethod = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CommunicationMethod as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".communicationMethod"); // 60
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".date"); // 70
							break;
						case "sourceIdentityCertificate":
							result.SourceIdentityCertificateElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SourceIdentityCertificateElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sourceIdentityCertificate"); // 80
							break;
						case "proxyIdentityCertificate":
							result.ProxyIdentityCertificateElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ProxyIdentityCertificateElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".proxyIdentityCertificate"); // 90
							break;
						case "proxySignature":
							result.ProxySignature = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.ProxySignature as Hl7.Fhir.Model.Signature, reader, outcome, locationPath + ".proxySignature"); // 100
							break;
						case "sourceSignature":
							result.SourceSignature = new Hl7.Fhir.Model.Signature();
							await ParseAsync(result.SourceSignature as Hl7.Fhir.Model.Signature, reader, outcome, locationPath + ".sourceSignature"); // 110
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
