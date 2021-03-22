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
		private void Parse(MedicinalProductAuthorization result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 100
							break;
						case "country":
							var newItem_country = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_country, reader, outcome, locationPath + ".country["+result.Country.Count+"]", cancellationToken); // 110
							result.Country.Add(newItem_country);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 120
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".statusDate", cancellationToken); // 140
							break;
						case "restoreDate":
							result.RestoreDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.RestoreDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".restoreDate", cancellationToken); // 150
							break;
						case "validityPeriod":
							result.ValidityPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.ValidityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".validityPeriod", cancellationToken); // 160
							break;
						case "dataExclusivityPeriod":
							result.DataExclusivityPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.DataExclusivityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".dataExclusivityPeriod", cancellationToken); // 170
							break;
						case "dateOfFirstAuthorization":
							result.DateOfFirstAuthorizationElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateOfFirstAuthorizationElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateOfFirstAuthorization", cancellationToken); // 180
							break;
						case "internationalBirthDate":
							result.InternationalBirthDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.InternationalBirthDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".internationalBirthDate", cancellationToken); // 190
							break;
						case "legalBasis":
							result.LegalBasis = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.LegalBasis as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalBasis", cancellationToken); // 200
							break;
						case "jurisdictionalAuthorization":
							var newItem_jurisdictionalAuthorization = new Hl7.Fhir.Model.MedicinalProductAuthorization.JurisdictionalAuthorizationComponent();
							Parse(newItem_jurisdictionalAuthorization, reader, outcome, locationPath + ".jurisdictionalAuthorization["+result.JurisdictionalAuthorization.Count+"]", cancellationToken); // 210
							result.JurisdictionalAuthorization.Add(newItem_jurisdictionalAuthorization);
							break;
						case "holder":
							result.Holder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Holder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".holder", cancellationToken); // 220
							break;
						case "regulator":
							result.Regulator = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Regulator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".regulator", cancellationToken); // 230
							break;
						case "procedure":
							result.Procedure = new Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent();
							Parse(result.Procedure as Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent, reader, outcome, locationPath + ".procedure", cancellationToken); // 240
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

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProductAuthorization result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 100
							break;
						case "country":
							var newItem_country = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_country, reader, outcome, locationPath + ".country["+result.Country.Count+"]", cancellationToken); // 110
							result.Country.Add(newItem_country);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 120
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".status", cancellationToken); // 130
							break;
						case "statusDate":
							result.StatusDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.StatusDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".statusDate", cancellationToken); // 140
							break;
						case "restoreDate":
							result.RestoreDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.RestoreDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".restoreDate", cancellationToken); // 150
							break;
						case "validityPeriod":
							result.ValidityPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.ValidityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".validityPeriod", cancellationToken); // 160
							break;
						case "dataExclusivityPeriod":
							result.DataExclusivityPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.DataExclusivityPeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".dataExclusivityPeriod", cancellationToken); // 170
							break;
						case "dateOfFirstAuthorization":
							result.DateOfFirstAuthorizationElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateOfFirstAuthorizationElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateOfFirstAuthorization", cancellationToken); // 180
							break;
						case "internationalBirthDate":
							result.InternationalBirthDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.InternationalBirthDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".internationalBirthDate", cancellationToken); // 190
							break;
						case "legalBasis":
							result.LegalBasis = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.LegalBasis as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".legalBasis", cancellationToken); // 200
							break;
						case "jurisdictionalAuthorization":
							var newItem_jurisdictionalAuthorization = new Hl7.Fhir.Model.MedicinalProductAuthorization.JurisdictionalAuthorizationComponent();
							await ParseAsync(newItem_jurisdictionalAuthorization, reader, outcome, locationPath + ".jurisdictionalAuthorization["+result.JurisdictionalAuthorization.Count+"]", cancellationToken); // 210
							result.JurisdictionalAuthorization.Add(newItem_jurisdictionalAuthorization);
							break;
						case "holder":
							result.Holder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Holder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".holder", cancellationToken); // 220
							break;
						case "regulator":
							result.Regulator = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Regulator as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".regulator", cancellationToken); // 230
							break;
						case "procedure":
							result.Procedure = new Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent();
							await ParseAsync(result.Procedure as Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent, reader, outcome, locationPath + ".procedure", cancellationToken); // 240
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
