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
		public void Parse(Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "citedMedium":
							result.CitedMedium = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CitedMedium as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".citedMedium", cancellationToken); // 40
							break;
						case "volume":
							result.VolumeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VolumeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".volume", cancellationToken); // 50
							break;
						case "issue":
							result.IssueElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.IssueElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".issue", cancellationToken); // 60
							break;
						case "dateOfPublication":
							result.DateOfPublication = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseDateOfPublicationComponent();
							Parse(result.DateOfPublication as Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseDateOfPublicationComponent, reader, outcome, locationPath + ".dateOfPublication", cancellationToken); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "citedMedium":
							result.CitedMedium = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CitedMedium as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".citedMedium", cancellationToken); // 40
							break;
						case "volume":
							result.VolumeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VolumeElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".volume", cancellationToken); // 50
							break;
						case "issue":
							result.IssueElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.IssueElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".issue", cancellationToken); // 60
							break;
						case "dateOfPublication":
							result.DateOfPublication = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseDateOfPublicationComponent();
							await ParseAsync(result.DateOfPublication as Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseDateOfPublicationComponent, reader, outcome, locationPath + ".dateOfPublication", cancellationToken); // 70
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
