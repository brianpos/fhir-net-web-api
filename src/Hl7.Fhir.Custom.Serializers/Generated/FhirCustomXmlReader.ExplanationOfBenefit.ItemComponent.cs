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
		public void Parse(Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent result, XmlReader reader, OperationOutcome outcome)
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
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.SequenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 40
							break;
						case "careTeamSequence":
							var newItem_careTeamSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_careTeamSequence, reader, outcome); // 50
							result.CareTeamSequenceElement.Add(newItem_careTeamSequence);
							break;
						case "diagnosisSequence":
							var newItem_diagnosisSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_diagnosisSequence, reader, outcome); // 60
							result.DiagnosisSequenceElement.Add(newItem_diagnosisSequence);
							break;
						case "procedureSequence":
							var newItem_procedureSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_procedureSequence, reader, outcome); // 70
							result.ProcedureSequenceElement.Add(newItem_procedureSequence);
							break;
						case "informationSequence":
							var newItem_informationSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_informationSequence, reader, outcome); // 80
							result.InformationSequenceElement.Add(newItem_informationSequence);
							break;
						case "revenue":
							result.Revenue = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Revenue as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_modifier, reader, outcome); // 120
							result.Modifier.Add(newItem_modifier);
							break;
						case "programCode":
							var newItem_programCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_programCode, reader, outcome); // 130
							result.ProgramCode.Add(newItem_programCode);
							break;
						case "servicedDate":
							result.Serviced = new Hl7.Fhir.Model.Date();
							Parse(result.Serviced as Hl7.Fhir.Model.Date, reader, outcome); // 140
							break;
						case "servicedPeriod":
							result.Serviced = new Hl7.Fhir.Model.Period();
							Parse(result.Serviced as Hl7.Fhir.Model.Period, reader, outcome); // 140
							break;
						case "locationCodeableConcept":
							result.Location = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Location as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 150
							break;
						case "locationAddress":
							result.Location = new Hl7.Fhir.Model.Address();
							Parse(result.Location as Hl7.Fhir.Model.Address, reader, outcome); // 150
							break;
						case "locationReference":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 160
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							Parse(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome); // 170
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 180
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							Parse(result.Net as Hl7.Fhir.Model.Money, reader, outcome); // 190
							break;
						case "udi":
							var newItem_udi = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_udi, reader, outcome); // 200
							result.Udi.Add(newItem_udi);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 210
							break;
						case "subSite":
							var newItem_subSite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subSite, reader, outcome); // 220
							result.SubSite.Add(newItem_subSite);
							break;
						case "encounter":
							var newItem_encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_encounter, reader, outcome); // 230
							result.Encounter.Add(newItem_encounter);
							break;
						case "noteNumber":
							var newItem_noteNumber = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_noteNumber, reader, outcome); // 240
							result.NoteNumberElement.Add(newItem_noteNumber);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent();
							Parse(newItem_adjudication, reader, outcome); // 250
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.ExplanationOfBenefit.DetailComponent();
							Parse(newItem_detail, reader, outcome); // 260
							result.Detail.Add(newItem_detail);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent result, XmlReader reader, OperationOutcome outcome)
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
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.SequenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 40
							break;
						case "careTeamSequence":
							var newItem_careTeamSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_careTeamSequence, reader, outcome); // 50
							result.CareTeamSequenceElement.Add(newItem_careTeamSequence);
							break;
						case "diagnosisSequence":
							var newItem_diagnosisSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_diagnosisSequence, reader, outcome); // 60
							result.DiagnosisSequenceElement.Add(newItem_diagnosisSequence);
							break;
						case "procedureSequence":
							var newItem_procedureSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_procedureSequence, reader, outcome); // 70
							result.ProcedureSequenceElement.Add(newItem_procedureSequence);
							break;
						case "informationSequence":
							var newItem_informationSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_informationSequence, reader, outcome); // 80
							result.InformationSequenceElement.Add(newItem_informationSequence);
							break;
						case "revenue":
							result.Revenue = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Revenue as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 90
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 100
							break;
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_modifier, reader, outcome); // 120
							result.Modifier.Add(newItem_modifier);
							break;
						case "programCode":
							var newItem_programCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_programCode, reader, outcome); // 130
							result.ProgramCode.Add(newItem_programCode);
							break;
						case "servicedDate":
							result.Serviced = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Serviced as Hl7.Fhir.Model.Date, reader, outcome); // 140
							break;
						case "servicedPeriod":
							result.Serviced = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Serviced as Hl7.Fhir.Model.Period, reader, outcome); // 140
							break;
						case "locationCodeableConcept":
							result.Location = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Location as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 150
							break;
						case "locationAddress":
							result.Location = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Location as Hl7.Fhir.Model.Address, reader, outcome); // 150
							break;
						case "locationReference":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 150
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 160
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome); // 170
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 180
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Net as Hl7.Fhir.Model.Money, reader, outcome); // 190
							break;
						case "udi":
							var newItem_udi = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_udi, reader, outcome); // 200
							result.Udi.Add(newItem_udi);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 210
							break;
						case "subSite":
							var newItem_subSite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subSite, reader, outcome); // 220
							result.SubSite.Add(newItem_subSite);
							break;
						case "encounter":
							var newItem_encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_encounter, reader, outcome); // 230
							result.Encounter.Add(newItem_encounter);
							break;
						case "noteNumber":
							var newItem_noteNumber = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_noteNumber, reader, outcome); // 240
							result.NoteNumberElement.Add(newItem_noteNumber);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent();
							await ParseAsync(newItem_adjudication, reader, outcome); // 250
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.ExplanationOfBenefit.DetailComponent();
							await ParseAsync(newItem_detail, reader, outcome); // 260
							result.Detail.Add(newItem_detail);
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
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
