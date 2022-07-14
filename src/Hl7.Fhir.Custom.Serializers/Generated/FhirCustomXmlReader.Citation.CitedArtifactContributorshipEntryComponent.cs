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
		public void Parse(Hl7.Fhir.Model.Citation.CitedArtifactContributorshipEntryComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.Name = new Hl7.Fhir.Model.HumanName();
							Parse(result.Name as Hl7.Fhir.Model.HumanName, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "initials":
							result.InitialsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.InitialsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".initials", cancellationToken); // 50
							break;
						case "collectiveName":
							result.CollectiveNameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CollectiveNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".collectiveName", cancellationToken); // 60
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 70
							result.Identifier.Add(newItem_identifier);
							break;
						case "affiliationInfo":
							var newItem_affiliationInfo = new Hl7.Fhir.Model.Citation.CitedArtifactContributorshipEntryAffiliationInfoComponent();
							Parse(newItem_affiliationInfo, reader, outcome, locationPath + ".affiliationInfo["+result.AffiliationInfo.Count+"]", cancellationToken); // 80
							result.AffiliationInfo.Add(newItem_affiliationInfo);
							break;
						case "address":
							var newItem_address = new Hl7.Fhir.Model.Address();
							Parse(newItem_address, reader, outcome, locationPath + ".address["+result.Address.Count+"]", cancellationToken); // 90
							result.Address.Add(newItem_address);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]", cancellationToken); // 100
							result.Telecom.Add(newItem_telecom);
							break;
						case "contributionType":
							var newItem_contributionType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_contributionType, reader, outcome, locationPath + ".contributionType["+result.ContributionType.Count+"]", cancellationToken); // 110
							result.ContributionType.Add(newItem_contributionType);
							break;
						case "role":
							result.Role = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Role as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".role", cancellationToken); // 120
							break;
						case "contributionInstance":
							var newItem_contributionInstance = new Hl7.Fhir.Model.Citation.CitedArtifactContributorshipEntryContributionInstanceComponent();
							Parse(newItem_contributionInstance, reader, outcome, locationPath + ".contributionInstance["+result.ContributionInstance.Count+"]", cancellationToken); // 130
							result.ContributionInstance.Add(newItem_contributionInstance);
							break;
						case "correspondingContact":
							result.CorrespondingContactElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.CorrespondingContactElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".correspondingContact", cancellationToken); // 140
							break;
						case "listOrder":
							result.ListOrderElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.ListOrderElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".listOrder", cancellationToken); // 150
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Citation.CitedArtifactContributorshipEntryComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.Name = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.Name as Hl7.Fhir.Model.HumanName, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "initials":
							result.InitialsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.InitialsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".initials", cancellationToken); // 50
							break;
						case "collectiveName":
							result.CollectiveNameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CollectiveNameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".collectiveName", cancellationToken); // 60
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 70
							result.Identifier.Add(newItem_identifier);
							break;
						case "affiliationInfo":
							var newItem_affiliationInfo = new Hl7.Fhir.Model.Citation.CitedArtifactContributorshipEntryAffiliationInfoComponent();
							await ParseAsync(newItem_affiliationInfo, reader, outcome, locationPath + ".affiliationInfo["+result.AffiliationInfo.Count+"]", cancellationToken); // 80
							result.AffiliationInfo.Add(newItem_affiliationInfo);
							break;
						case "address":
							var newItem_address = new Hl7.Fhir.Model.Address();
							await ParseAsync(newItem_address, reader, outcome, locationPath + ".address["+result.Address.Count+"]", cancellationToken); // 90
							result.Address.Add(newItem_address);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]", cancellationToken); // 100
							result.Telecom.Add(newItem_telecom);
							break;
						case "contributionType":
							var newItem_contributionType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_contributionType, reader, outcome, locationPath + ".contributionType["+result.ContributionType.Count+"]", cancellationToken); // 110
							result.ContributionType.Add(newItem_contributionType);
							break;
						case "role":
							result.Role = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Role as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".role", cancellationToken); // 120
							break;
						case "contributionInstance":
							var newItem_contributionInstance = new Hl7.Fhir.Model.Citation.CitedArtifactContributorshipEntryContributionInstanceComponent();
							await ParseAsync(newItem_contributionInstance, reader, outcome, locationPath + ".contributionInstance["+result.ContributionInstance.Count+"]", cancellationToken); // 130
							result.ContributionInstance.Add(newItem_contributionInstance);
							break;
						case "correspondingContact":
							result.CorrespondingContactElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.CorrespondingContactElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".correspondingContact", cancellationToken); // 140
							break;
						case "listOrder":
							result.ListOrderElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.ListOrderElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".listOrder", cancellationToken); // 150
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
