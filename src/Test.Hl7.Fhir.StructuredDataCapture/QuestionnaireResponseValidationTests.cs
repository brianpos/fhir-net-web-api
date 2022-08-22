using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Fhir.StructuredDataCapture;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.StructuredDataCapture.Test
{
    [TestClass]
    public class QuestionnaireResponseValidationTests : TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            Hl7.Fhir.FhirPath.ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();
        }

        [TestMethod]
        public async Task ValidateQuestionnaireNotResolved()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireNotResolved" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = false });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireNotResolved" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q2" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a2") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, null);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.NotFound, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("questionnaireNotFound", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.questionnaire", outcome.Issue[0].Expression.First());
        }


        [TestMethod]
        public async Task ValidateInvalidLinkId()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateInvalidLinkId" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = false });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateInvalidLinkId" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q2" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a2") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidLinkId", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringDraftDowngrade()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringDraftDowngrade" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            var qr = new QuestionnaireResponse()
            {
                Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringDraftDowngrade",
                Status = QuestionnaireResponse.QuestionnaireResponseStatus.InProgress
            };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a2") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("repeats", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateString()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateString" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateString" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a2") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("repeats", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringMaxOccurs()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringMaxOccurs" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-maxOccurs", new Integer(2));
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringMaxOccurs" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a2") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a3") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("maxCount", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringMinOccurs()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringMinOccurs" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-minOccurs", new Integer(2));
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringMinOccurs" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minCount", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringAnswerOption()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringAnswerOption" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new FhirString("str1") });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new FhirString("str2") });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringAnswerOption" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new FhirString("str1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new FhirString("str2") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new FhirString("str3") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerOption", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[2]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringRequired()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringRequired" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringRequired" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Required, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("required", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringVsText()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringVsText" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q2", Type = Questionnaire.QuestionnaireItemType.Text, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringVsText" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1\r\nsmile") });
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q2" });
            qr.Item[1].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1\r\nsmile") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidNewLine", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateTextInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateTextInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Text, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateTextInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringMinMaxLength()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringMinMaxLength" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/minLength", new Integer(20));
            q.Item[0].MaxLength = 2;

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringMinMaxLength" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("fasdfa") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minLength", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxLength", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringRegex()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringRegex" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/regex", new FhirString(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"));
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/entryFormat", new FhirString(@"blah@example.com"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringRegex" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("fasdfa@test.com.au") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("fasdfa@@test.com.au") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("regex", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateStringWithCodingAsync()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateStringWithCodingAsync" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true, AnswerValueSet = "http://hl7.org/fhir/ValueSet/jurisdiction" });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateStringWithCodingAsync" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("AU") }); // this is code
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("Australia") }); // this is display (it should not pass validation)
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.CodeInvalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidCoding", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateBooleanInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateBooleanInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Boolean, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateBooleanInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateIntegerInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateIntegerInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Integer, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateIntegerInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateInteger()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateInteger" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Integer, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateInteger" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Integer(5) });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateIntegerMinMax()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateIntegerMinMax" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Integer });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/minValue", new Integer(20));
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/maxValue", new Integer(2));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateIntegerMinMax" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Integer(5) });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateIntegerAnswerOption()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateIntegerAnswerOption" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Integer, Repeats = true });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Integer(1) });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Integer(2) });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateIntegerAnswerOption" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Integer(1) });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Integer(2) });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Integer(3) });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerOption", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[2]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDecimalInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDecimalInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Decimal, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDecimalInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDecimal()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDecimal" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Decimal, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDecimal" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDecimal(5.6M) });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateDecimalMinMax()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDecimalMinMax" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Decimal });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/minValue", new FhirDecimal(20));
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/maxValue", new FhirDecimal(2));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDecimalMinMax" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDecimal(5.6M) });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDecimalMaxDecimalPlaces()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDecimalMaxDecimalPlaces" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Decimal });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/maxDecimalPlaces", new Integer(2));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDecimalMaxDecimalPlaces" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDecimal(-5.12340M) });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("maxDecimalPlaces", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDisplayAnswerIncluded()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDisplayAnswerIncluded" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Display });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDisplayAnswerIncluded" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("displayAnswer", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateAbstractQuestionTypeIncluded()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateAbstractQuestionTypeIncluded" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Question });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateAbstractQuestionTypeIncluded" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateGroupWithStringInvalidNesting()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateGroupWithStringInvalidNesting" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "grp1", Type = Questionnaire.QuestionnaireItemType.Group });
            q.Item[0].Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            q.Item[0].Item.Add(new Questionnaire.ItemComponent { LinkId = "q2", Type = Questionnaire.QuestionnaireItemType.String, Required = true });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateGroupWithStringInvalidNesting" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "grp1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent());
            qr.Item[0].Answer[0].Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer[0].Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1 smile") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(3, outcome.Issue.Count); // 1 for invalid nesting, 2 for mandatory fields missing (due to nesting)
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("groupShouldNotHaveAnswers", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Required, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("required", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateGroupWithStringInvalidNestingLinkId()
        {
            // check that the mandatory fields in grp1 weren't fired, as there is no grp1 included
            // should just report out that the grp2 doesn't exist in the questionnaire
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateGroupWithStringInvalidNestingLinkId" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "grp1", Type = Questionnaire.QuestionnaireItemType.Group });
            q.Item[0].Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            q.Item[0].Item.Add(new Questionnaire.ItemComponent { LinkId = "q2", Type = Questionnaire.QuestionnaireItemType.String, Required = true });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateGroupWithStringInvalidNestingLinkId" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "grp2" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent());
            qr.Item[0].Answer[0].Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer[0].Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1 smile") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidLinkId", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateGroupWithString()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateGroupWithString" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "grp1", Type = Questionnaire.QuestionnaireItemType.Group });
            q.Item[0].Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Required = true });
            q.Item[0].Item.Add(new Questionnaire.ItemComponent { LinkId = "q2", Type = Questionnaire.QuestionnaireItemType.String, Required = true });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateGroupWithString" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "grp1" });
            qr.Item[0].Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("a1 smile") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Required, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("required", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDateTimeInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDateTimeInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.DateTime, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDateTimeInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDateTimeMinMax()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDateTimeMinMax" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.DateTime, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/minValue", new FhirDateTime("2020"));
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/maxValue", new FhirDateTime("2022-06"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDateTimeMinMax" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDateTime("2021") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDateTime("2020") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDateTime("2022-06-30") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDateTime("1998") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirDateTime("2022-07") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[3]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[4]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDateInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDateInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Date, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDateInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDateMinMax()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDateMinMax" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Date, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/minValue", new Date("2020"));
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/maxValue", new Date("2022"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDateMinMax" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Date("2021") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Date("2020") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Date("2022") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Date("1998") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Date("2023") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[3]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[4]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateDateAnswerOption()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateDateAnswerOption" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Date, Repeats = true });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Date("2022-01-01") });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Date("2022-02-01") });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateDateAnswerOption" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Date("2022-01-01") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Date("2022-02-01") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Date("2022-03-01") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerOption", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[2]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateChoiceAsync()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateChoiceAsync" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice, Repeats = true, AnswerValueSet = "http://hl7.org/fhir/ValueSet/jurisdiction" });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateChoiceAsync" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("urn:iso:std:iso:3166", "AU", "Australia") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("urn:iso:std:iso:3166", "BD", "Australia") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.CodeInvalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidCoding", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateChoiceInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateChoiceInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateChoiceInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("http://example.org") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateOpenChoiceInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateOpenChoiceInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.OpenChoice, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateOpenChoiceInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Code("http://example.org") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateChoiceInvalidValueSetAsync()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateChoiceInvalidValueSetAsync" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice, AnswerValueSet = "http://example.org/invalid-valueset-canonical" });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateChoiceInvalidValueSetAsync" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("urn:iso:std:iso:3166", "AU", "Australia") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Exception, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("tsError", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateChoiceGenderCodingAsync()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateChoiceGenderCodingAsync" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice, Repeats = true, AnswerValueSet = "http://hl7.org/fhir/ValueSet/item-type" });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateChoiceGenderCodingAsync" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "string", "Australia") });
            var validator = new QuestionnaireResponse_Validator(new ValidationSettings { TerminologyServerAddress = "https://r4.ontoserver.csiro.au/fhir" });
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.CodeInvalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidCoding", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateOpenChoiceGenderCodingAsync()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateOpenChoiceGenderCodingAsync" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.OpenChoice, Repeats = true, AnswerValueSet = "http://hl7.org/fhir/ValueSet/item-type" });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateOpenChoiceGenderCodingAsync" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "string", "Australia") });
            var validator = new QuestionnaireResponse_Validator(new ValidationSettings { TerminologyServerAddress = "https://r4.ontoserver.csiro.au/fhir" });
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.CodeInvalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidCoding", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateOpenChoiceStringAsync()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateOpenChoiceStringAsync" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.OpenChoice, Repeats = true, AnswerValueSet = "http://hl7.org/fhir/ValueSet/item-type" });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateOpenChoiceStringAsync" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("Example free text") });
            var validator = new QuestionnaireResponse_Validator(new ValidationSettings { TerminologyServerAddress = "https://r4.ontoserver.csiro.au/fhir" });
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateChoiceAnswerOption()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateChoiceAnswerOption" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice, Repeats = true });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Coding("http://example.org", "c1") });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Coding("http://example.org", "c2", "Code 2") });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateChoiceAnswerOption" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Coding("http://example.org", "c1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Coding("http://example.org", "c2", "Code 2") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Coding("http://example.org", "c2") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Coding("http://example.org", "c3") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerOption", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[3]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateChoiceAnswerOptionExclusive()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateChoiceAnswerOptionExclusive" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice, Repeats = true });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Coding("http://example.org", "c1") });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Coding("http://example.org", "c2") });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Coding("http://example.org", "c3") });
            q.Item[0].AnswerOption[1].AddExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-optionExclusive", new FhirBoolean(true));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateChoiceAnswerOptionExclusive" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Coding("http://example.org", "c1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent() { Value = new Coding("http://example.org", "c2") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("exclusiveAnswerOption", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateTime()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateTime" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Time, Repeats = true });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Time("10:00:00") });
            q.Item[0].AnswerOption.Add(new Questionnaire.AnswerOptionComponent() { Value = new Time("11:00:00") });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateTime" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Time("10:00:00") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Time("09:00:00") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerOption", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateTimeInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateTimeInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Time, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateTimeInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateUrlValue()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateUrlValue" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Url, Repeats = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateUrlValue" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirUri(@"Patient/1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirUri(@"c:\temp\example.txt") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirUri(@"https://example.org/Patient/1") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirUri(@"urn:uuid:c757873d-ec9a-4326-a141-556f43239520") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirUri(@"urn:uuid:c757873d-ec9a-4326-a141-556f43239520asdf") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidUrlValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
            Assert.AreEqual("invalidUrlValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[4]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateUrlInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateUrlInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Url, Required = true });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateUrlInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://example.org", "1", "First Choice") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateAttachment()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateAttachment" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Attachment });
            q.Item[0].SetStringExtension("http://hl7.org/fhir/StructureDefinition/mimeType", "application/pdf");
            q.Item[0].MaxLength = 1000;
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateAttachment" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            byte[] dataSimulated = new byte[500];
            dataSimulated[0] = (byte)'a';
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent
            {
                Value = new Attachment()
                {
                    ContentType = "application/pdf",
                    Data = dataSimulated,
                    Size = 500
                }
            });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateAttachmentContentType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateAttachmentContentType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Attachment });
            q.Item[0].SetStringExtension("http://hl7.org/fhir/StructureDefinition/mimeType", "iamge/gif");
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateAttachmentContentType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            byte[] dataSimulated = new byte[500];
            dataSimulated[0] = (byte)'a';
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent
            {
                Value = new Attachment()
                {
                    ContentType = "application/pdf",
                    Data = dataSimulated,
                    Size = 500
                }
            });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAttachmentType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateAttachmentMaxSize()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateAttachmentMaxSize" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Attachment });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/maxSize", new FhirDecimal(50));
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateAttachmentMaxSize" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            byte[] dataSimulated = new byte[500];
            dataSimulated[0] = (byte)'a';
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent
            {
                Value = new Attachment()
                {
                    ContentType = "application/pdf",
                    Data = dataSimulated,
                    Size = 500
                }
            });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("maxAttachmentSize", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateAttachmentInconsistentSize()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateAttachmentInconsistentSize" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Attachment });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateAttachmentInconsistentSize" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            byte[] dataSimulated = new byte[500];
            dataSimulated[0] = (byte)'a';
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent
            {
                Value = new Attachment()
                {
                    ContentType = "application/pdf",
                    Data = dataSimulated,
                    Size = 50200200
                }
            });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("attachmentSizeInconsistent", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateAttachmentInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateAttachmentInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Attachment });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateAttachmentInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuestionnaireDraft()
        {
            var q = new Questionnaire()
            {
                Url = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireDraft",
                Status = PublicationStatus.Draft
            };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireDraft" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("questionnaireDraft", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.questionnaire", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuestionnaireRetired()
        {
            var q = new Questionnaire()
            {
                Url = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireRetired",
                Status = PublicationStatus.Retired
            };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireRetired" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("questionnaireRetired", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.questionnaire", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuestionnaireInactiveStart()
        {
            var q = new Questionnaire()
            {
                Url = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireInactiveStart",
                EffectivePeriod = new Period(new FhirDateTime("2022"), null)
            };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice });
            var qr = new QuestionnaireResponse()
            {
                Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireInactiveStart",
                Authored = "2021-12-12"
            };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("questionnaireInactive", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.authored", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuestionnaireInactiveEnd()
        {
            var q = new Questionnaire()
            {
                Url = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireInactiveEnd",
                EffectivePeriod = new Period(null, new FhirDateTime("2021-12-11"))
            };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Choice });
            var qr = new QuestionnaireResponse()
            {
                Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuestionnaireInactiveEnd",
                Authored = "2021-12-12"
            };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Coding("http://hl7.org/fhir/item-type", "boolean", "Boolean") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("questionnaireInactive", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.authored", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateReferenceInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateReferenceInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Reference });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateReferenceInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("example value") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateReferenceRelative()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateReferenceRelative" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Reference });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateReferenceRelative" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new ResourceReference("Patient/example", "Example Patient") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateReferenceAbsolute()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateReferenceAbsolute" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Reference });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateReferenceAbsolute" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new ResourceReference("https://example.org/Patient/example", "Example Patient") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateReferenceInvalidURL()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateReferenceInvalidURL" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Reference });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateReferenceInvalidURL" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new ResourceReference("htsdtps://example.org/Chicken/example", "Example Patient") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidRefValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateReferenceInvalidResourceType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateReferenceInvalidResourceType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Reference });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateReferenceInvalidResourceType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new ResourceReference("https://example.org/Chicken/example", "Example Patient") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidRefResourceType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateReferenceUnconstrainedResourceType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateReferenceUnconstrainedResourceType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Reference, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-referenceResource", new Code("Patient"));
            q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-referenceResource", new Code("Practitioner"));
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateReferenceUnconstrainedResourceType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new ResourceReference("Patient/example", "Example Patient") });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new ResourceReference("Organization/example", "Example Organization") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidRefResourceTypeRestriction", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuantity()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantity" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-minQuantity", new Quantity() { Value = 5, Unit = "Kg" });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-maxQuantity", new Quantity() { Value = 50, Unit = "Kg" });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantity" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "Kg" } });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateQuantityInvalidType()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityInvalidType" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity });
            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityInvalidType" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString("example value") });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(1, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual(OperationOutcome.IssueSeverity.Fatal, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Structure, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidAnswerType", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuantityMinMax()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityMinMax" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-maxQuantity", new Quantity() { Value = 5, Unit = "Kg" });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-minQuantity", new Quantity() { Value = 50, Unit = "Kg" });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityMinMax" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "Kg" } });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuantityMinMaxCompatUnits()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityMinMaxCompatUnits" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-maxQuantity", new Quantity() { Value = 5, Unit = "km", Code = "km", System = "http://unitsofmeasure.org" });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-minQuantity", new Quantity() { Value = 50, Unit = "km", Code = "km", System = "http://unitsofmeasure.org" });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityMinMaxCompatUnits" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10000, Unit = "m", Code = "m" } });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValue", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.BusinessRule, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValue", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuantityMinMaxIncompatUnits()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityMinMaxIncompatUnits" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-maxQuantity", new Quantity() { Value = 5, Unit = "Kg", Code = "kg", System = "http://unitsofmeasure.org" });
            q.Item[0].SetExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-minQuantity", new Quantity() { Value = 50, Unit = "Kg", Code = "kg", System = "http://unitsofmeasure.org" });

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityMinMaxIncompatUnits" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "Miles", Code = "[mi_i]" } });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("minValueIncompatUnits", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("maxValueIncompatUnits", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuantityUnits()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityUnits" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption", new Coding("http://unitsofmeasure.org", "km", "kilometer"));
            q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption", new Coding("http://unitsofmeasure.org", "m"));
            q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption", new Coding("http://unitsofmeasure.org", "[mi_i]", "miles"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityUnits" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "kilometer", Code = "km", System = "http://unitsofmeasure.org" } });
            // provide more than is in the unitOption will pass
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "meter", Code = "m", System = "http://unitsofmeasure.org" } });
            // providing no Unit (but still code) when there is no display defined in the unitOption will pass
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Code = "m", System = "http://unitsofmeasure.org" } });

            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateQuantityUnitsInValueSet()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityUnitsInValueSet" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitValueSet", new Canonical("http://hl7.org/fhir/ValueSet/jurisdiction"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityUnitsInValueSet" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "Australia", Code = "AU", System = "urn:iso:std:iso:3166" } });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Code = "BD", System = "urn:iso:std:iso:3166" } });

            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(0, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);
        }

        [TestMethod]
        public async Task ValidateQuantityUnitsNotInValueSet()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityUnitsNotInValueSet", Version = "0.1" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitValueSet", new Canonical("http://hl7.org/fhir/ValueSet/jurisdiction"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityUnitsNotInValueSet|0.1" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "kilometer", System = "http://unitsofmeasure.org" } });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "kilometer", Code = "km", System = "http://unitsofmeasure.org" } });

            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(2, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(2, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.CodeInvalid, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidUnitValueSet", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[1].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.CodeInvalid, outcome.Issue[1].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[1].Details.Coding[0].System);
            Assert.AreEqual("invalidUnitValueSet", outcome.Issue[1].Details.Coding[0].Code);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[1]", outcome.Issue[1].Expression.First());
        }

        [TestMethod]
        public async Task ValidateQuantityUnitsInvalid()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateQuantityUnitsInvalid" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.Quantity, Repeats = true });
            q.Item[0].SetExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption", new Coding("http://unitsofmeasure.org", "km", "kilometer"));
            q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption", new Coding("http://unitsofmeasure.org", "m", "meter"));
            q.Item[0].AddExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption", new Coding("http://unitsofmeasure.org", "[mi_i]", "miles"));

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateQuantityUnitsInvalid" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new Quantity() { Value = 10, Unit = "Kg", Code = "kg", System = "http://unitsofmeasure.org" } });
            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(1, outcome.Errors);
            Assert.AreEqual(0, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Error, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Value, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invalidUnit", outcome.Issue[0].Details.Coding[0].Code);
            Assert.AreEqual(0, outcome.Warnings);
            Assert.AreEqual("QuestionnaireResponse.item[0].answer[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateInvariantQuestionnaire()
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

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateInvariantQuestionnaire" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a1" } });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a2" } });
            // qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invariant, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invariant", outcome.Issue[0].Details.Coding[0].Code);
            // Also need to determine what location the report is on, the answer, or the item?
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task ValidateInvariantCorruptedExpression()
        {
            var q = new Questionnaire() { Url = "http://forms-lab.com/Questionnaire/ValidateInvariantCorruptedExpression" };
            q.Item.Add(new Questionnaire.ItemComponent { LinkId = "q1", Type = Questionnaire.QuestionnaireItemType.String, Repeats = true });
            var ce = new Extension() { Url = "http://hl7.org/fhir/StructureDefinition/questionnaire-constraint" };
            ce.SetExtension("key", new Id("k1"));
            ce.SetStringExtension("requirements", "Example item invariant");
            ce.SetExtension("severity", new Code("warning"));
            ce.SetStringExtension("expression", "answer.count() = 3 asdf aqwe");
            ce.SetStringExtension("human", "Must have 3 answers");
            q.Item[0].Extension.Add(ce);

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateInvariantCorruptedExpression" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a1" } });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a2" } });
            // qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invariant, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invariantExecution", outcome.Issue[0].Details.Coding[0].Code);
            // Also need to determine what location the report is on, the answer, or the item?
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
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

            var qr = new QuestionnaireResponse() { Questionnaire = "http://forms-lab.com/Questionnaire/ValidateInvariantUndefinedVariable" };
            qr.Item.Add(new QuestionnaireResponse.ItemComponent { LinkId = "q1" });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a1" } });
            qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a2" } });
            // qr.Item[0].Answer.Add(new QuestionnaireResponse.AnswerComponent { Value = new FhirString() { Value = "a3" } });

            var validator = new QuestionnaireResponse_Validator();
            var outcome = await validator.Validate(qr, q);
            DebugDumpXml(q);
            DebugDumpXml(qr);
            DebugDumpXml(outcome);

            Assert.AreEqual(1, outcome.Issue.Count);
            Assert.AreEqual(0, outcome.Fatals);
            Assert.AreEqual(0, outcome.Errors);
            Assert.AreEqual(1, outcome.Warnings);

            Assert.AreEqual(OperationOutcome.IssueSeverity.Warning, outcome.Issue[0].Severity);
            Assert.AreEqual(OperationOutcome.IssueType.Invariant, outcome.Issue[0].Code);
            Assert.AreEqual(QuestionnaireResponse_Validator.ErrorCodeSystem, outcome.Issue[0].Details.Coding[0].System);
            Assert.AreEqual("invariantExecution", outcome.Issue[0].Details.Coding[0].Code);
            // Also need to determine what location the report is on, the answer, or the item?
            Assert.AreEqual("QuestionnaireResponse.item[0]", outcome.Issue[0].Expression.First());
        }

        [TestMethod]
        public async Task TestLargeBundleSampleData()
        {
            // Load in the Questionnaire Bundle
            Bundle qs = GetTestQuestionnaires();
            Dictionary<string, Questionnaire> qDict = new Dictionary<string, Questionnaire>();
            foreach (var item in qs.Entry)
            {
                var qt = item.Resource as Questionnaire;
                qDict.Add($"Questionnaire/{qt.Id}", qt);
                qDict.Add(item.FullUrl.Replace("http://", "https://"), qt);
                qDict.Add(item.FullUrl.Replace("https://", "http://"), qt);
                if (!string.IsNullOrEmpty(qt.Url))
                {
                    if (!qDict.ContainsKey(qt.Url))
                        qDict.Add(qt.Url, qt);
                    if (!string.IsNullOrEmpty(qt.Version))
                        qDict.Add($"{qt.Url}|{qt.Version}", qt);
                }
            }

            // Load in the QuestionnaireResponse Bundle
            Bundle qrs = GetTestQuestionnaireResponsess();

            int totalValidated = 0;
            foreach (var qr in qrs.Entry.Select(e => e.Resource as QuestionnaireResponse))
            {
                if (string.IsNullOrEmpty(qr.Questionnaire))
                {
                    Trace.WriteLine($"* Validating {qr.Id} against '{qr.Questionnaire}': No questionnaire definition");
                    continue;
                }
                Questionnaire q;
                if (!qDict.ContainsKey(qr.Questionnaire))
                {
                    Trace.WriteLine($"* Validating {qr.Id} against '{qr.Questionnaire}': No questionnaire definition for {qr.Questionnaire}");
                    continue;
                }
                totalValidated++;
                q = qDict[qr.Questionnaire];
                Trace.WriteLine($"Validating {qr.Id} against '{qr.Questionnaire}'");

                var validator = new QuestionnaireResponse_Validator();
                var outcome = await validator.Validate(qr, q);

                // strip out the warnings for the draft questionnaires
                outcome.Issue.RemoveAll(i => i.Details.Text == "The Questionnaire is defined as a draft template");

                if (!outcome.Success)
                {
                    // DebugDumpXml(q);
                    // DebugDumpXml(qr);
                }
                if (outcome.Issue.Any())
                    DebugDumpXml(outcome);
                //Assert.AreEqual(1, outcome.Issue.Count);
                //Assert.AreEqual(0, outcome.Fatals);
                //Assert.AreEqual(0, outcome.Errors);
                // Assert.AreEqual(1, outcome.Warnings);
            }
            Trace.WriteLine("--------");
            Trace.WriteLine($"Validated QRs: {totalValidated}");
        }

        private Bundle GetTestQuestionnaires()
        {
            string testFile = @"TestData\sqlonfhir-r4-questionnaires.xml";
            return new Hl7.Fhir.Serialization.FhirXmlParser().Parse<Bundle>(System.IO.File.ReadAllText(testFile));
        }

        private Bundle GetTestQuestionnaireResponsess()
        {
            string testFile = @"TestData\sqlonfhir-r4-questionnaireresponses.xml";
            return new Hl7.Fhir.Serialization.FhirXmlParser().Parse<Bundle>(System.IO.File.ReadAllText(testFile));
        }

        // [TestMethod]
        public async Task ServerTestDataHapi()
        {
            var hapiServer = new FhirClient("http://hapi.fhir.org/baseR4", new FhirClientSettings() { VerifyFhirVersion = false, PreferCompressedResponses = true, ParserSettings = new ParserSettings() { PermissiveParsing = true } });

            // Load in the Questionnaire Bundle
            Bundle qs = await hapiServer.SearchAsync<Questionnaire>(pageSize: 6000);
            Dictionary<string, Questionnaire> qDict = new Dictionary<string, Questionnaire>();
            IndexDefinitions(qs, qDict);
            try
            {
                while (qs.NextLink != null)
                {
                    qs = await hapiServer.ContinueAsync(qs);
                    IndexDefinitions(qs, qDict);
                }
            }
            catch (Hl7.Fhir.ElementModel.StructuralTypeException fex)
            {
                Trace.WriteLine($"* Error parsing content {fex.Message}");
            }

            // Load in the QuestionnaireResponse Bundle
            Bundle qrs = hapiServer.Search<QuestionnaireResponse>(pageSize: 1000);

            int totalValidated = 0;
            foreach (var qr in qrs.Entry.Select(e => e.Resource as QuestionnaireResponse))
            {
                if (string.IsNullOrEmpty(qr.Questionnaire))
                {
                    Trace.WriteLine($"* Validating {qr.Id} against '{qr.Questionnaire}': No questionnaire definition");
                    continue;
                }
                Questionnaire q;
                if (!qDict.ContainsKey(qr.Questionnaire))
                {
                    Trace.WriteLine($"* Validating {qr.Id} against '{qr.Questionnaire}': No questionnaire definition for {qr.Questionnaire}");
                    continue;
                }
                totalValidated++;
                q = qDict[qr.Questionnaire];
                Trace.WriteLine($"Validating {qr.Id} against '{qr.Questionnaire}'");

                var validator = new QuestionnaireResponse_Validator();
                var outcome = await validator.Validate(qr, q);

                // strip out the warnings for the draft questionnaires
                outcome.Issue.RemoveAll(i => i.Details.Text == "The Questionnaire is defined as a draft template");

                if (!outcome.Success)
                {
                    // DebugDumpXml(q);
                    // DebugDumpXml(qr);
                }
                if (outcome.Issue.Any())
                    DebugDumpXml(outcome);
                //Assert.AreEqual(1, outcome.Issue.Count);
                //Assert.AreEqual(0, outcome.Fatals);
                //Assert.AreEqual(0, outcome.Errors);
                // Assert.AreEqual(1, outcome.Warnings);
            }
            Trace.WriteLine("--------");
            Trace.WriteLine($"Validated QRs: {totalValidated}");
        }

        private static void IndexDefinitions(Bundle qs, Dictionary<string, Questionnaire> qDict)
        {
            foreach (var item in qs.Entry)
            {
                var qt = item.Resource as Questionnaire;
                qDict.Add($"Questionnaire/{qt.Id}", qt);
                qDict.Add(item.FullUrl.Replace("http://", "https://"), qt);
                qDict.Add(item.FullUrl.Replace("https://", "http://"), qt);
                if (!string.IsNullOrEmpty(qt.Url))
                {
                    if (!qDict.ContainsKey(qt.Url))
                        qDict.Add(qt.Url, qt);
                    if (!string.IsNullOrEmpty(qt.Version))
                    {
                        if (!qDict.ContainsKey($"{qt.Url}|{qt.Version}"))
                            qDict.Add($"{qt.Url}|{qt.Version}", qt);
                        else
                            Trace.WriteLine($"* Definition '{qt.Url}|{qt.Version}': already indexed");
                    }
                }
            }
        }
    }
}
