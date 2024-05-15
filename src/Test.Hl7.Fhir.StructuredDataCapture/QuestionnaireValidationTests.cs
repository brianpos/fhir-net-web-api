using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.StructuredDataCapture.Test
{
    [TestClass]
    public class QuestionnaireValidationTests : TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            Hl7.Fhir.FhirPath.ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();
        }

        private Questionnaire GetTestQuestionnaire()
        {
            string testFile = @"TestData\Questionnaire.health-status-example.json";
            return new Hl7.Fhir.Serialization.FhirJsonParser().Parse<Questionnaire>(System.IO.File.ReadAllText(testFile));
        }

		private Questionnaire GetLargeComplexQuestionnaire()
		{
			string testFile = @"TestData\MBS715-NoReadOnly.json";
			return new Hl7.Fhir.Serialization.FhirJsonParser().Parse<Questionnaire>(System.IO.File.ReadAllText(testFile));
		}

		private Bundle GetTestQuestionnaires()
		{
			string testFile = @"TestData\sqlonfhir-r4-questionnaires.xml";
			return new Hl7.Fhir.Serialization.FhirXmlParser().Parse<Bundle>(System.IO.File.ReadAllText(testFile));
		}

		[TestMethod, Ignore]
		public async Task TestLargeBundleSampleData()
		{
			// Load in the Questionnaire Bundle
			Bundle qs = GetTestQuestionnaires();
			int totalValidated = 0;
			int errors = 0, warnings = 0;
			foreach (var item in qs.Entry)
			{
				var qt = item.Resource as Questionnaire;
				Trace.WriteLine($"\r\nTesting {qt.Id}: {qt.Name} {qt.Description}");
				var validator = new QuestionnaireValidator();
				var outcome = await validator.Validate(qt);
				totalValidated++;

				if (!outcome.Success)
					errors++;
				if (outcome.Warnings > 0)
					warnings++;

				if (outcome.Issue.Any())
					DebugDumpXmlDiagnostics(outcome);
			}

			Trace.WriteLine("--------");
			Trace.WriteLine($"Validated Qs: {totalValidated}");
			Trace.WriteLine($"Errors: {errors}");
			Trace.WriteLine($"Warnings: {warnings}");
			Assert.AreEqual(13, errors, $"Expected 3 errors, found Errors:{errors} - Warnings:{warnings}");
		}

		[TestMethod, Ignore]
		public async Task TestHapiServerTestData()
		{
			var hapiServer = new FhirClient("http://hapi.fhir.org/baseR4", new FhirClientSettings() { VerifyFhirVersion = false, PreferCompressedResponses = true, ParserSettings = new ParserSettings() { PermissiveParsing = true } });
			// Need to discover why this isn't working, and how to select the parser that I enhanced.
			hapiServer.Settings.SerializationEngine = new BlindParsingEngine(ModelInfo.ModelInspector, _ => true);
			hapiServer.Settings.ParserSettings.AllowUnrecognizedEnums = true;
			hapiServer.Settings.ParserSettings.TruncateDateTimeToDate = true;
			Bundle bun = new Bundle();

			int totalValidated = 0;
			int errors = 0, warnings = 0;
			var IndexDefinitions = async Task (Bundle qs) =>
			{
				foreach (var item in qs.Entry)
				{
					var qt = item.Resource as Questionnaire;
					Trace.WriteLine($"\r\nTesting {qt.Id}: {qt.Name} {qt.Description}");
					var validator = new QuestionnaireValidator();
					var outcome = await validator.Validate(qt);
					totalValidated++;

					if (!outcome.Success)
						errors++;
					if (outcome.Warnings > 0)
						warnings++;

					if (outcome.Issue.Any())
						DebugDumpXmlDiagnostics(outcome);

					bun.Entry.AddRange(qs.Entry);
				}
			};

			// Load in the Questionnaire Bundle
			Bundle qs = await hapiServer.SearchAsync<Questionnaire>(pageSize: 10);

			await IndexDefinitions(qs);
			try
			{
				while (qs.NextLink != null)
				{
					qs = await hapiServer.ContinueAsync(qs);
					await IndexDefinitions(qs);
				}
			}
			catch (Hl7.Fhir.ElementModel.StructuralTypeException fex)
			{
				Trace.WriteLine($"* Error parsing content {fex.Message}");
				Trace.WriteLine("--------");
				Trace.WriteLine(hapiServer.LastBodyAsText);
			}

			Trace.WriteLine("--------");
			Trace.WriteLine($"Validated Qs: {totalValidated}");
			Trace.WriteLine($"Errors: {errors}");
			Trace.WriteLine($"Warnings: {warnings}");

			// Dump out the entire bundle of HAPI questionnaires
			System.IO.File.WriteAllText(@"c:\temp\hapi-questionnaires.json", bun.ToJson(new FhirJsonSerializationSettings() { Pretty = true }));

			Assert.AreEqual(0, errors, $"Expected no errors, found {errors}/{warnings}");
		}

		[TestMethod]
        public async Task TestHealthStatusExample()
        {
            var q = GetTestQuestionnaire();
            var validator = new QuestionnaireValidator();
            var outcome = await validator.Validate(q);

            if (outcome.Issue.Any())
				DebugDumpXmlDiagnostics(outcome);

			// Cool we found 4 errors with the validator!
            Assert.AreEqual(7, outcome.Errors);
			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Exception, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidFhirpathExpression", outcome.Issue[0].Details.Coding[0].Code);
			Assert.AreEqual(1, outcome.Warnings);
			Assert.AreEqual("Questionnaire.extension[1].expression", outcome.Issue[0].Expression.First());

		}

		[TestMethod]
		public async Task TestLargeComplexExample()
		{
			var q = GetLargeComplexQuestionnaire();
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);

			if (outcome.Issue.Any())
				DebugDumpXmlDiagnostics(outcome);

			// Cool we found 4 errors with the validator!
			Assert.AreEqual(0, outcome.Errors);
			Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.MultipleMatches, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidFhirpathExpressionTypes", outcome.Issue[0].Details.Coding[0].Code);
			Assert.AreEqual(176, outcome.Warnings);
			Assert.AreEqual("Questionnaire.item[0].item[1].item[2].extension[0].expression", outcome.Issue[0].Expression.First());
		}

		public static void DebugDumpXmlDiagnostics(OperationOutcome outcome)
		{
			foreach (var issue in outcome.Issue)
			{
				Trace.WriteLine($"# {issue.Severity} {issue.Code} {issue.Details?.Text}");
				if (issue.Details != null)
				{
					foreach (var coding in issue.Details.Coding)
					{
						Trace.WriteLine($"    * {coding.Code} \"{coding.Display}\"");
					}
				}
				if (issue.Expression.Any())
				{
					Trace.WriteLine($"    * Location: {string.Join(",", issue.Expression)}");
				}
				if (issue.Location.Any())
				{
					Trace.WriteLine($"    * Location (alternate): {string.Join(",", issue.Location)}");
				}
				if (!string.IsNullOrEmpty(issue.Diagnostics))
					Trace.WriteLine($"    => {issue.Diagnostics.Replace("\r\n", "\r\n       ")}");
				Trace.WriteLine("");
			}
			DebugDumpXml(outcome);
		}

		[TestMethod]
		public async Task TestVariablesExampleFromSpec()
		{
			// https://build.fhir.org/ig/HL7/sdc/Questionnaire-questionnaire-sdc-profile-example-framingham-hchd-lhc.json
			string testFile = @"TestData\Questionnaire.variables-example.json";
			var q = new Hl7.Fhir.Serialization.FhirJsonParser().Parse<Questionnaire>(System.IO.File.ReadAllText(testFile));
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);

			if (outcome.Issue.Any())
				DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(6, outcome.Issue.Count, "Expected 6 total issues");
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(6, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.NotFound, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidFhirpathExpressionTypes", outcome.Issue[0].Details.Coding[0].Code);
			// Also need to determine what location the report is on, the answer, or the item?
			Assert.AreEqual("Questionnaire.extension[0].expression", outcome.Issue[0].Expression.First());
		}

		[TestMethod]
		public async Task ValidateInvariantWithQuestionnaireVariable()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateInvariantQuestionnaire", Version = "0.1" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			var ce = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
			ce.SetExtension("key", new Id("k1"));
			ce.SetStringExtension("requirements", "Example item invariant");
			ce.SetExtension("severity", new Code("warning"));
			ce.SetStringExtension("expression", "answer.count() = 3");
			ce.SetStringExtension("human", "Must have 3 answers");
			// This location field needs additional work to ensure that we know how to populate it...
			ce.AddExtension("location", new FhirString("linkId='q1'"));
			ce.AddExtension("location", new FhirString("QuestionnaireResponse.author"));
			q.Item[0].Extension.Add(ce);

			var ce2 = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
			ce2.SetExtension("key", new Id("k2"));
			ce2.SetStringExtension("requirements", "Example item invariant");
			ce2.SetExtension("severity", new Code("warning"));
			ce2.SetStringExtension("expression", "answer.count() = %questionnaire.item.count()+1");
			ce2.SetStringExtension("human", "Must have 2 answers");
			// This location field needs additional work to ensure that we know how to populate it...
			ce2.AddExtension("location", new FhirString("linkId='q1'"));
			ce2.AddExtension("location", new FhirString("QuestionnaireResponse.author"));
			q.Item[0].Extension.Add(ce2);

			// qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			// This a completely clean questionnaire with multiple expressions, one using the %questionnaire variable
			Assert.AreEqual(0, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(0, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);
		}

		[TestMethod]
		public async Task ValidateInvariantCorruptedConstraintExpression()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateInvariantCorruptedExpression" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			var ce = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
			ce.SetExtension("key", new Id("k1"));
			ce.SetExtension("severity", new Code("warning"));
			ce.SetStringExtension("expression", "answer.count() = 3 asdf aqwe");
			ce.SetStringExtension("human", "Must have 3 answers");
			q.Item[0].Extension.Add(ce);

			// qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(1, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(1, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Exception, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidFhirpathExpression", outcome.Issue[0].Details.Coding[0].Code);
			// Also need to determine what location the report is on, the answer, or the item?
			Assert.AreEqual("Questionnaire.item[0].extension[0].extension[2]", outcome.Issue[0].Expression.First());
		}

		[TestMethod]
		public async Task ValidateConstraintExpression()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateConstraintExpression" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			var ce = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
			ce.SetExtension("key", new Id("k1"));
			ce.SetExtension("severity", new Code("warning"));
			ce.SetStringExtension("expression", "true");
			ce.SetStringExtension("human", "Dodgy invariant/constraint");
			q.Item[0].Extension.Add(ce);

			// qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(0, outcome.Issue.Count);
		}

		[TestMethod]
		public async Task ValidateConstraintExpressionReturningAString()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateConstraintExpressionReturningAString" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			var ce = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
			ce.SetExtension("key", new Id("k1"));
			ce.SetExtension("severity", new Code("warning"));
			ce.SetStringExtension("expression", "'a string' | 'some other string'");
			ce.SetStringExtension("human", "Dodgy invariant/constraint");
			q.Item[0].Extension.Add(ce);

			// qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(1, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(1, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidConstraint", outcome.Issue[0].Details.Coding[0].Code);
			// Also need to determine what location the report is on, the answer, or the item?
			Assert.AreEqual("Questionnaire.item[0].extension[0].extension[2]", outcome.Issue[0].Expression.First());
		}

		[TestMethod]
		public async Task ValidateInvariantUndefinedVariable()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateInvariantUndefinedVariable" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			var ce = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
			ce.SetExtension("key", new Id("k1"));
			ce.SetStringExtension("requirements", "Example item invariant");
			ce.SetExtension("severity", new Code("warning"));
			ce.SetStringExtension("expression", "answer.count() = %unknown");
			ce.SetStringExtension("human", "Must have 3 answers");
			q.Item[0].Extension.Add(ce);

			// qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(1, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(1, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Exception, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidFhirpathExpression", outcome.Issue[0].Details.Coding[0].Code);
			// Also need to determine what location the report is on, the answer, or the item?
			Assert.AreEqual("Questionnaire.item[0].extension[0].extension[3]", outcome.Issue[0].Expression.First());
		}


		// Now start the unit tests rather than the integration tests above

        [TestMethod]
		public async Task ValidateSDC_Fuction()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringRegex" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/entryFormat", new FhirString(@"blah@example.com"));
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);
			DebugDumpXmlDiagnostics(outcome);
			Assert.AreEqual(0, outcome.Issue.Count);
		}


		[TestMethod]
        public async Task ValidateStringRegex()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringRegex" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/regex", new FhirString(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"));
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/entryFormat", new FhirString(@"blah@example.com"));
            var validator = new QuestionnaireValidator();
            var outcome = await validator.Validate(q);
            DebugDumpXml(q);
			DebugDumpXmlDiagnostics(outcome);
            Assert.AreEqual(0, outcome.Issue.Count);
        }

		[TestMethod]
		public async Task ValidateStringInvalidRegex()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringRegex" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/entryFormat", new FhirString(@"blah@example.com"));
			q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/regex", new FhirString(@"^abc[")); // incomplete expression, possibly truncated
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(1, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(1, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Exception, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidRegex", outcome.Issue[0].Details.Coding[0].Code);
			Assert.AreEqual(0, outcome.Warnings);
			Assert.AreEqual("Questionnaire.item[0].extension[1]", outcome.Issue[0].Expression.First());
		}

		[TestMethod]
		public async Task ValidateXFhirQuery()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateXFhirQuery" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/variable", new Expression() 
			{
				Name = "patId",
				Language = "text/fhirpath",
				Expression_ = "'1'"
			});
			q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/variable", new Expression()
			{
				Name = "var1",
				Language = "application/x-fhir-query",
				Expression_ = "Procedure?patient={{%patId}}"
			});
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(0, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(0, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);
		}

		[TestMethod]
		public async Task ValidateXFhirQueryWithResourceId()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateXFhirQuery" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/variable", new Expression()
			{
				Name = "var1",
				Language = "application/x-fhir-query",
				Expression_ = "Procedure/45"
			});
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(0, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(0, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);
		}

		[TestMethod]
		public async Task ValidateXFhirQueryNoParamsWarning()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateXFhirQuery" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/variable", new Expression()
			{
				Name = "var1",
				Language = "application/x-fhir-query",
				Expression_ = "Procedure"
			});
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(1, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(0, outcome.Errors);
			Assert.AreEqual(1, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("xpathQueryNoFilter", outcome.Issue[0].Details.Coding[0].Code);
			Assert.AreEqual("Questionnaire.item[0].extension[0].expression", outcome.Issue[0].Expression.First());
		}

		[TestMethod]
		public async Task ValidateXFhirQueryWrongType()
		{
			var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateXFhirQuery" };
			q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
			q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/variable", new FhirString(@"blah@example.com"));
			var validator = new QuestionnaireValidator();
			var outcome = await validator.Validate(q);
			DebugDumpXml(q);

			DebugDumpXmlDiagnostics(outcome);

			Assert.AreEqual(1, outcome.Issue.Count);
			Assert.AreEqual(0, outcome.Fatals);
			Assert.AreEqual(1, outcome.Errors);
			Assert.AreEqual(0, outcome.Warnings);

			Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
			Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
			Assert.AreEqual(QuestionnaireValidator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
			Assert.AreEqual("invalidExtensionType", outcome.Issue[0].Details.Coding[0].Code);
			Assert.AreEqual(0, outcome.Warnings);
			Assert.AreEqual("Questionnaire.item[0].extension[0]", outcome.Issue[0].Expression.First());
		}
	}
}
