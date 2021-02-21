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
		private void Parse(TestReport result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 90
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 100
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportStatus>, reader, outcome); // 110
							break;
						case "testScript":
							result.TestScript = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.TestScript as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 120
							break;
						case "result":
							result.ResultElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportResult>();
							Parse(result.ResultElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportResult>, reader, outcome); // 130
							break;
						case "score":
							result.ScoreElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.ScoreElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 140
							break;
						case "tester":
							result.TesterElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TesterElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.TestReport.ParticipantComponent();
							Parse(newItem_participant, reader, outcome); // 170
							result.Participant.Add(newItem_participant);
							break;
						case "setup":
							result.Setup = new Hl7.Fhir.Model.TestReport.SetupComponent();
							Parse(result.Setup as Hl7.Fhir.Model.TestReport.SetupComponent, reader, outcome); // 180
							break;
						case "test":
							var newItem_test = new Hl7.Fhir.Model.TestReport.TestComponent();
							Parse(newItem_test, reader, outcome); // 190
							result.Test.Add(newItem_test);
							break;
						case "teardown":
							result.Teardown = new Hl7.Fhir.Model.TestReport.TeardownComponent();
							Parse(result.Teardown as Hl7.Fhir.Model.TestReport.TeardownComponent, reader, outcome); // 200
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
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

		private async System.Threading.Tasks.Task ParseAsync(TestReport result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 90
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 100
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportStatus>, reader, outcome); // 110
							break;
						case "testScript":
							result.TestScript = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.TestScript as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 120
							break;
						case "result":
							result.ResultElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportResult>();
							await ParseAsync(result.ResultElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportResult>, reader, outcome); // 130
							break;
						case "score":
							result.ScoreElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.ScoreElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 140
							break;
						case "tester":
							result.TesterElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TesterElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 160
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.TestReport.ParticipantComponent();
							await ParseAsync(newItem_participant, reader, outcome); // 170
							result.Participant.Add(newItem_participant);
							break;
						case "setup":
							result.Setup = new Hl7.Fhir.Model.TestReport.SetupComponent();
							await ParseAsync(result.Setup as Hl7.Fhir.Model.TestReport.SetupComponent, reader, outcome); // 180
							break;
						case "test":
							var newItem_test = new Hl7.Fhir.Model.TestReport.TestComponent();
							await ParseAsync(newItem_test, reader, outcome); // 190
							result.Test.Add(newItem_test);
							break;
						case "teardown":
							result.Teardown = new Hl7.Fhir.Model.TestReport.TeardownComponent();
							await ParseAsync(result.Teardown as Hl7.Fhir.Model.TestReport.TeardownComponent, reader, outcome); // 200
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
