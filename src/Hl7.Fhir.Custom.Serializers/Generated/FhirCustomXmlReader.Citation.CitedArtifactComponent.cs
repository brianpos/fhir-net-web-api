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
		public void Parse(Hl7.Fhir.Model.Citation.CitedArtifactComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "relatedIdentifier":
							var newItem_relatedIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_relatedIdentifier, reader, outcome, locationPath + ".relatedIdentifier["+result.RelatedIdentifier.Count+"]", cancellationToken); // 50
							result.RelatedIdentifier.Add(newItem_relatedIdentifier);
							break;
						case "dateAccessed":
							result.DateAccessedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateAccessedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateAccessed", cancellationToken); // 60
							break;
						case "version":
							result.Version = new Hl7.Fhir.Model.Citation.CitedArtifactVersionComponent();
							Parse(result.Version as Hl7.Fhir.Model.Citation.CitedArtifactVersionComponent, reader, outcome, locationPath + ".version", cancellationToken); // 70
							break;
						case "currentState":
							var newItem_currentState = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_currentState, reader, outcome, locationPath + ".currentState["+result.CurrentState.Count+"]", cancellationToken); // 80
							result.CurrentState.Add(newItem_currentState);
							break;
						case "statusDate":
							var newItem_statusDate = new Hl7.Fhir.Model.Citation.CitedArtifactStatusDateComponent();
							Parse(newItem_statusDate, reader, outcome, locationPath + ".statusDate["+result.StatusDate.Count+"]", cancellationToken); // 90
							result.StatusDate.Add(newItem_statusDate);
							break;
						case "title":
							var newItem_title = new Hl7.Fhir.Model.Citation.CitedArtifactTitleComponent();
							Parse(newItem_title, reader, outcome, locationPath + ".title["+result.Title.Count+"]", cancellationToken); // 100
							result.Title.Add(newItem_title);
							break;
						case "abstract":
							var newItem_abstract = new Hl7.Fhir.Model.Citation.CitedArtifactAbstractComponent();
							Parse(newItem_abstract, reader, outcome, locationPath + ".abstract["+result.Abstract.Count+"]", cancellationToken); // 110
							result.Abstract.Add(newItem_abstract);
							break;
						case "part":
							result.Part = new Hl7.Fhir.Model.Citation.CitedArtifactPartComponent();
							Parse(result.Part as Hl7.Fhir.Model.Citation.CitedArtifactPartComponent, reader, outcome, locationPath + ".part", cancellationToken); // 120
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.Citation.CitedArtifactRelatesToComponent();
							Parse(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]", cancellationToken); // 130
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "publicationForm":
							var newItem_publicationForm = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormComponent();
							Parse(newItem_publicationForm, reader, outcome, locationPath + ".publicationForm["+result.PublicationForm.Count+"]", cancellationToken); // 140
							result.PublicationForm.Add(newItem_publicationForm);
							break;
						case "webLocation":
							var newItem_webLocation = new Hl7.Fhir.Model.Citation.CitedArtifactWebLocationComponent();
							Parse(newItem_webLocation, reader, outcome, locationPath + ".webLocation["+result.WebLocation.Count+"]", cancellationToken); // 150
							result.WebLocation.Add(newItem_webLocation);
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.Citation.CitedArtifactClassificationComponent();
							Parse(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]", cancellationToken); // 160
							result.Classification.Add(newItem_classification);
							break;
						case "contributorship":
							result.Contributorship = new Hl7.Fhir.Model.Citation.CitedArtifactContributorshipComponent();
							Parse(result.Contributorship as Hl7.Fhir.Model.Citation.CitedArtifactContributorshipComponent, reader, outcome, locationPath + ".contributorship", cancellationToken); // 170
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 180
							result.Note.Add(newItem_note);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Citation.CitedArtifactComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "relatedIdentifier":
							var newItem_relatedIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_relatedIdentifier, reader, outcome, locationPath + ".relatedIdentifier["+result.RelatedIdentifier.Count+"]", cancellationToken); // 50
							result.RelatedIdentifier.Add(newItem_relatedIdentifier);
							break;
						case "dateAccessed":
							result.DateAccessedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateAccessedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateAccessed", cancellationToken); // 60
							break;
						case "version":
							result.Version = new Hl7.Fhir.Model.Citation.CitedArtifactVersionComponent();
							await ParseAsync(result.Version as Hl7.Fhir.Model.Citation.CitedArtifactVersionComponent, reader, outcome, locationPath + ".version", cancellationToken); // 70
							break;
						case "currentState":
							var newItem_currentState = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_currentState, reader, outcome, locationPath + ".currentState["+result.CurrentState.Count+"]", cancellationToken); // 80
							result.CurrentState.Add(newItem_currentState);
							break;
						case "statusDate":
							var newItem_statusDate = new Hl7.Fhir.Model.Citation.CitedArtifactStatusDateComponent();
							await ParseAsync(newItem_statusDate, reader, outcome, locationPath + ".statusDate["+result.StatusDate.Count+"]", cancellationToken); // 90
							result.StatusDate.Add(newItem_statusDate);
							break;
						case "title":
							var newItem_title = new Hl7.Fhir.Model.Citation.CitedArtifactTitleComponent();
							await ParseAsync(newItem_title, reader, outcome, locationPath + ".title["+result.Title.Count+"]", cancellationToken); // 100
							result.Title.Add(newItem_title);
							break;
						case "abstract":
							var newItem_abstract = new Hl7.Fhir.Model.Citation.CitedArtifactAbstractComponent();
							await ParseAsync(newItem_abstract, reader, outcome, locationPath + ".abstract["+result.Abstract.Count+"]", cancellationToken); // 110
							result.Abstract.Add(newItem_abstract);
							break;
						case "part":
							result.Part = new Hl7.Fhir.Model.Citation.CitedArtifactPartComponent();
							await ParseAsync(result.Part as Hl7.Fhir.Model.Citation.CitedArtifactPartComponent, reader, outcome, locationPath + ".part", cancellationToken); // 120
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.Citation.CitedArtifactRelatesToComponent();
							await ParseAsync(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]", cancellationToken); // 130
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "publicationForm":
							var newItem_publicationForm = new Hl7.Fhir.Model.Citation.CitedArtifactPublicationFormComponent();
							await ParseAsync(newItem_publicationForm, reader, outcome, locationPath + ".publicationForm["+result.PublicationForm.Count+"]", cancellationToken); // 140
							result.PublicationForm.Add(newItem_publicationForm);
							break;
						case "webLocation":
							var newItem_webLocation = new Hl7.Fhir.Model.Citation.CitedArtifactWebLocationComponent();
							await ParseAsync(newItem_webLocation, reader, outcome, locationPath + ".webLocation["+result.WebLocation.Count+"]", cancellationToken); // 150
							result.WebLocation.Add(newItem_webLocation);
							break;
						case "classification":
							var newItem_classification = new Hl7.Fhir.Model.Citation.CitedArtifactClassificationComponent();
							await ParseAsync(newItem_classification, reader, outcome, locationPath + ".classification["+result.Classification.Count+"]", cancellationToken); // 160
							result.Classification.Add(newItem_classification);
							break;
						case "contributorship":
							result.Contributorship = new Hl7.Fhir.Model.Citation.CitedArtifactContributorshipComponent();
							await ParseAsync(result.Contributorship as Hl7.Fhir.Model.Citation.CitedArtifactContributorshipComponent, reader, outcome, locationPath + ".contributorship", cancellationToken); // 170
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 180
							result.Note.Add(newItem_note);
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
