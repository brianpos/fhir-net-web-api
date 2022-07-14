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
		public void Parse(Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "itemSequence":
							var newItem_itemSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_itemSequence, reader, outcome, locationPath + ".itemSequence["+result.ItemSequenceElement.Count+"]", cancellationToken); // 40
							result.ItemSequenceElement.Add(newItem_itemSequence);
							break;
						case "detailSequence":
							var newItem_detailSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_detailSequence, reader, outcome, locationPath + ".detailSequence["+result.DetailSequenceElement.Count+"]", cancellationToken); // 50
							result.DetailSequenceElement.Add(newItem_detailSequence);
							break;
						case "subDetailSequence":
							var newItem_subDetailSequence = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_subDetailSequence, reader, outcome, locationPath + ".subDetailSequence["+result.SubDetailSequenceElement.Count+"]", cancellationToken); // 60
							result.SubDetailSequenceElement.Add(newItem_subDetailSequence);
							break;
						case "provider":
							var newItem_provider = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_provider, reader, outcome, locationPath + ".provider["+result.Provider.Count+"]", cancellationToken); // 70
							result.Provider.Add(newItem_provider);
							break;
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".productOrService", cancellationToken); // 80
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.Modifier.Count+"]", cancellationToken); // 90
							result.Modifier.Add(newItem_modifier);
							break;
						case "programCode":
							var newItem_programCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_programCode, reader, outcome, locationPath + ".programCode["+result.ProgramCode.Count+"]", cancellationToken); // 100
							result.ProgramCode.Add(newItem_programCode);
							break;
						case "servicedDate":
							result.Serviced = new Hl7.Fhir.Model.Date();
							Parse(result.Serviced as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".serviced", cancellationToken); // 110
							break;
						case "servicedPeriod":
							result.Serviced = new Hl7.Fhir.Model.Period();
							Parse(result.Serviced as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".serviced", cancellationToken); // 110
							break;
						case "locationCodeableConcept":
							result.Location = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Location as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".location", cancellationToken); // 120
							break;
						case "locationAddress":
							result.Location = new Hl7.Fhir.Model.Address();
							Parse(result.Location as Hl7.Fhir.Model.Address, reader, outcome, locationPath + ".location", cancellationToken); // 120
							break;
						case "locationReference":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 120
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 130
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							Parse(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 140
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 150
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							Parse(result.Net as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".net", cancellationToken); // 160
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite", cancellationToken); // 170
							break;
						case "subSite":
							var newItem_subSite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_subSite, reader, outcome, locationPath + ".subSite["+result.SubSite.Count+"]", cancellationToken); // 180
							result.SubSite.Add(newItem_subSite);
							break;
						case "noteNumber":
							var newItem_noteNumber = new Hl7.Fhir.Model.PositiveInt();
							Parse(newItem_noteNumber, reader, outcome, locationPath + ".noteNumber["+result.NoteNumberElement.Count+"]", cancellationToken); // 190
							result.NoteNumberElement.Add(newItem_noteNumber);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent();
							Parse(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]", cancellationToken); // 200
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailComponent();
							Parse(newItem_detail, reader, outcome, locationPath + ".detail["+result.Detail.Count+"]", cancellationToken); // 210
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "itemSequence":
							var newItem_itemSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_itemSequence, reader, outcome, locationPath + ".itemSequence["+result.ItemSequenceElement.Count+"]", cancellationToken); // 40
							result.ItemSequenceElement.Add(newItem_itemSequence);
							break;
						case "detailSequence":
							var newItem_detailSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_detailSequence, reader, outcome, locationPath + ".detailSequence["+result.DetailSequenceElement.Count+"]", cancellationToken); // 50
							result.DetailSequenceElement.Add(newItem_detailSequence);
							break;
						case "subDetailSequence":
							var newItem_subDetailSequence = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_subDetailSequence, reader, outcome, locationPath + ".subDetailSequence["+result.SubDetailSequenceElement.Count+"]", cancellationToken); // 60
							result.SubDetailSequenceElement.Add(newItem_subDetailSequence);
							break;
						case "provider":
							var newItem_provider = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_provider, reader, outcome, locationPath + ".provider["+result.Provider.Count+"]", cancellationToken); // 70
							result.Provider.Add(newItem_provider);
							break;
						case "productOrService":
							result.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ProductOrService as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".productOrService", cancellationToken); // 80
							break;
						case "modifier":
							var newItem_modifier = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_modifier, reader, outcome, locationPath + ".modifier["+result.Modifier.Count+"]", cancellationToken); // 90
							result.Modifier.Add(newItem_modifier);
							break;
						case "programCode":
							var newItem_programCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_programCode, reader, outcome, locationPath + ".programCode["+result.ProgramCode.Count+"]", cancellationToken); // 100
							result.ProgramCode.Add(newItem_programCode);
							break;
						case "servicedDate":
							result.Serviced = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.Serviced as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".serviced", cancellationToken); // 110
							break;
						case "servicedPeriod":
							result.Serviced = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Serviced as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".serviced", cancellationToken); // 110
							break;
						case "locationCodeableConcept":
							result.Location = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Location as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".location", cancellationToken); // 120
							break;
						case "locationAddress":
							result.Location = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Location as Hl7.Fhir.Model.Address, reader, outcome, locationPath + ".location", cancellationToken); // 120
							break;
						case "locationReference":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 120
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 130
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 140
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 150
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Net as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".net", cancellationToken); // 160
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.BodySite as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".bodySite", cancellationToken); // 170
							break;
						case "subSite":
							var newItem_subSite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_subSite, reader, outcome, locationPath + ".subSite["+result.SubSite.Count+"]", cancellationToken); // 180
							result.SubSite.Add(newItem_subSite);
							break;
						case "noteNumber":
							var newItem_noteNumber = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(newItem_noteNumber, reader, outcome, locationPath + ".noteNumber["+result.NoteNumberElement.Count+"]", cancellationToken); // 190
							result.NoteNumberElement.Add(newItem_noteNumber);
							break;
						case "adjudication":
							var newItem_adjudication = new Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent();
							await ParseAsync(newItem_adjudication, reader, outcome, locationPath + ".adjudication["+result.Adjudication.Count+"]", cancellationToken); // 200
							result.Adjudication.Add(newItem_adjudication);
							break;
						case "detail":
							var newItem_detail = new Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailComponent();
							await ParseAsync(newItem_detail, reader, outcome, locationPath + ".detail["+result.Detail.Count+"]", cancellationToken); // 210
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
