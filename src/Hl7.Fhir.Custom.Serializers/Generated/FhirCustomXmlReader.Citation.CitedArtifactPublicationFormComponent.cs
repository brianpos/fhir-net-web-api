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
		public void Parse(Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "publishedIn":
							result.PublishedIn = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPublishedInComponent();
							Parse(result.PublishedIn as Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPublishedInComponent, reader, outcome, locationPath + ".publishedIn", cancellationToken); // 40
							break;
						case "periodicRelease":
							result.PeriodicRelease = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseComponent();
							Parse(result.PeriodicRelease as Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseComponent, reader, outcome, locationPath + ".periodicRelease", cancellationToken); // 50
							break;
						case "articleDate":
							result.ArticleDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ArticleDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".articleDate", cancellationToken); // 60
							break;
						case "lastRevisionDate":
							result.LastRevisionDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.LastRevisionDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".lastRevisionDate", cancellationToken); // 70
							break;
						case "language":
							var newItem_language = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_language, reader, outcome, locationPath + ".language["+result.Language.Count+"]", cancellationToken); // 80
							result.Language.Add(newItem_language);
							break;
						case "accessionNumber":
							result.AccessionNumberElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AccessionNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".accessionNumber", cancellationToken); // 90
							break;
						case "pageString":
							result.PageStringElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PageStringElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".pageString", cancellationToken); // 100
							break;
						case "firstPage":
							result.FirstPageElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.FirstPageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".firstPage", cancellationToken); // 110
							break;
						case "lastPage":
							result.LastPageElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LastPageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".lastPage", cancellationToken); // 120
							break;
						case "pageCount":
							result.PageCountElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PageCountElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".pageCount", cancellationToken); // 130
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							Parse(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright", cancellationToken); // 140
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "publishedIn":
							result.PublishedIn = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPublishedInComponent();
							await ParseAsync(result.PublishedIn as Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPublishedInComponent, reader, outcome, locationPath + ".publishedIn", cancellationToken); // 40
							break;
						case "periodicRelease":
							result.PeriodicRelease = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseComponent();
							await ParseAsync(result.PeriodicRelease as Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormPeriodicReleaseComponent, reader, outcome, locationPath + ".periodicRelease", cancellationToken); // 50
							break;
						case "articleDate":
							result.ArticleDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ArticleDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".articleDate", cancellationToken); // 60
							break;
						case "lastRevisionDate":
							result.LastRevisionDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.LastRevisionDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".lastRevisionDate", cancellationToken); // 70
							break;
						case "language":
							var newItem_language = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_language, reader, outcome, locationPath + ".language["+result.Language.Count+"]", cancellationToken); // 80
							result.Language.Add(newItem_language);
							break;
						case "accessionNumber":
							result.AccessionNumberElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AccessionNumberElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".accessionNumber", cancellationToken); // 90
							break;
						case "pageString":
							result.PageStringElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PageStringElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".pageString", cancellationToken); // 100
							break;
						case "firstPage":
							result.FirstPageElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.FirstPageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".firstPage", cancellationToken); // 110
							break;
						case "lastPage":
							result.LastPageElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LastPageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".lastPage", cancellationToken); // 120
							break;
						case "pageCount":
							result.PageCountElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PageCountElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".pageCount", cancellationToken); // 130
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright", cancellationToken); // 140
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
