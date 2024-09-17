using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Utility;
using Hl7.FhirPath;
using Hl7.FhirPath.Expressions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Hl7.Fhir.StructuredDataCapture.StructuredDataCaptureExtensions;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.StructuredDataCapture
{
    public class ValidationSettings
    {
        public string TerminologyServerAddress { get; set; }
        public System.Net.Http.HttpMessageHandler TerminologyServerMessageHandler { get; set; }
        public FhirClientSettings TerminologyServerFhirClientSettings { get; set; }
        public ILogger Logger { get; set; }
        public TimeSpan RegexTimeout { get; set; } = TimeSpan.FromSeconds(2); // default 2 seconds
        // System.Globalization.CultureInfo ci
    }

    public class QuestionnaireResponseValidator
    {
        public const string ErrorCodeSystem = "http://fhir.forms-lab.com/CodeSystem/errors";

        public enum ValidationResult
        {
            unknown,

            /// <summary>
            /// The Questionnaire referenced by the QR was not found
            /// </summary>
            questionnaireNotFound,

            /// <summary>
            /// The QuestionnaireResponse.authored is outside the defined Questionnaire.effectivePeriod
            /// </summary>
            questionnaireInactive,

            /// <summary>
            /// The Questionnaire.status was not active (draft)
            /// </summary>
            questionnaireDraft,

            /// <summary>
            /// The Questionnaire.status was not active (retired)
            /// </summary>
            questionnaireRetired,

            /// <summary>
            /// LinkId was not found in the questionnaire
            /// </summary>
            invalidLinkId,

            /// <summary>
            /// The Question Type should not be included in Response (or Definition) data
            /// </summary>
            invalidType,

            /// <summary>
            /// The Answer does not conform to the Item.Type value required
            /// (also taking into consideration the fhir-type extension)
            /// </summary>
            invalidAnswerType,

            /// <summary>
            /// A set of valid AnswerOptions were provided in the definition, but the value entered was not in the set
            /// </summary>
            invalidAnswerOption,

            /// <summary>
            /// The selected answer cannot be used in conjuction with other answers in this multi-select choice option
            /// </summary>
            exclusiveAnswerOption,

            /// <summary>
            /// URL value not formatted correctly as a uuid, or relative/absolute URL
            /// </summary>
            invalidUrlValue,

            /// <summary>
            /// A Group Item should not use the `answer` child, it should use the `item` child,
            /// </summary>
            groupShouldNotHaveAnswers,

            /// <summary>
            /// There was no answer provided for a mandatory field
            /// </summary>
            required,

            /// <summary>
            /// A FHIRPATH validation expression did not pass
            /// </summary>
            invariant,

            /// <summary>
            /// A FHIRPATH validation expression failed to execute
            /// </summary>
            invariantExecution,

            /// <summary>
            /// There was more than one answer provided for an item with repeats = false (which is the default)
            /// </summary>
            repeats,

            /// <summary>
            /// Minimum number of answers required for the item was not provided
            /// </summary>
            minCount,

            /// <summary>
            /// Number of answers provided exceeded the maximum permitted
            /// </summary>
            maxCount,

            /// <summary>
            /// Minimum value constraint violated
            /// </summary>
            minValue,

            /// <summary>
            /// Maximum value constraint violated
            /// </summary>
            maxValue,

            /// <summary>
            /// Maximum decimal places constraint violated
            /// </summary>
            maxDecimalPlaces,

            /// <summary>
            /// Minimum length constraint violated
            /// </summary>
            minLength,

            /// <summary>
            /// Maximum length constraint violated
            /// </summary>
            maxLength,

            /// <summary>
            /// 'string' type items cannot include newline characters, use a 'text' type for these
            /// </summary>
            invalidNewLine,

            /// <summary>
            /// coding value not valid in the ValueSet
            /// </summary>
            invalidCoding,

            /// <summary>
            /// Error accessing the Terminology Server
            /// </summary>
            tsError,

            /// <summary>
            /// Maximum attachment size constraint violated
            /// </summary>
            maxAttachmentSize,

            /// <summary>
            /// The Size of the attachment data and the reported size are different
            /// </summary>
            attachmentSizeInconsistent,

            /// <summary>
            /// Attachment type constraint violated
            /// </summary>
            invalidAttachmentType,

            /// <summary>
            /// display Items should not have an answer provided
            /// </summary>
            displayAnswer,

            /// <summary>
            /// The answer does not match the provided regex expression
            /// </summary>
            regex,

            /// <summary>
            /// Evaluating the regex expression timedout
            /// </summary>
            regexTimeout,

            /// <summary>
            /// The Reference value was not a valid URL value (relative or absolute)
            /// </summary>
            invalidRefValue,

            /// <summary>
            /// The Reference value did not refer to a valid FHIR resource type
            /// </summary>
            invalidRefResourceType,

            /// <summary>
            /// The Reference value was not
            /// </summary>
            invalidRefResourceTypeRestriction,

            /// <summary>
            /// The units provided in the Quantity cannont be converted to the min Quantity units
            /// </summary>
            minValueIncompatUnits,

            /// <summary>
            /// The units provided in the Quantity cannont be converted to the max Quantity units
            /// </summary>
            maxValueIncompatUnits,

            /// <summary>
            /// The unit provided was not among the list selected (or did not have all the properties defined in the unit coding)
            /// </summary>
            invalidUnit,

            /// <summary>
            /// The unit provided was not in the provided valueset
            /// </summary>
            invalidUnitValueSet,
        }

        /// <summary>
        /// Report an error to the issue collector (thread safe)
        /// </summary>
        /// <remarks>
        /// short error message display will be in the details.coding.display
        /// long error message display will be in the details.text
        /// linkId will be in the location field (as format linkId='xxx') - which is deprecated, expected not to be used)
        /// expression contains the QustionnaireResponse fhirpath location
        /// </remarks>
        /// <param name="error"></param>
        /// <param name="itemDefinition"></param>
        /// <param name="locationExpression"></param>
        /// <param name="status"></param>
        /// <param name="responseItem"></param>
        /// <param name="answerIndex"></param>
        /// <param name="invariant"></param>
        /// <param name="exceptionThrown"></param>
        /// <param name="questionaireCanonicalUrl"></param>
        /// <returns></returns>
        OperationOutcome.IssueComponent ReportValidationMessage(ValidationResult error, Questionnaire.ItemComponent itemDefinition, IEnumerable<string> locationExpression, QuestionnaireResponse.QuestionnaireResponseStatus status, QuestionnaireResponse.ItemComponent responseItem, int? answerIndex, QuestionnaireInvariant invariant, Exception exceptionThrown = null, string questionaireCanonicalUrl = null)
        {
            var severity = OperationOutcome.IssueSeverity.Error;
            var code = OperationOutcome.IssueType.Unknown;
            var details = new CodeableConcept(ErrorCodeSystem, error.ToString());
            var fieldDisplayText = responseItem?.Text ?? itemDefinition?.ShortText() ?? itemDefinition?.Text ?? (itemDefinition?.Code?.FirstOrDefault()?.Display) ?? itemDefinition?.LinkId ?? responseItem?.LinkId;
            if (!string.IsNullOrEmpty(fieldDisplayText) && fieldDisplayText.EndsWith(":"))
                fieldDisplayText = fieldDisplayText.Substring(0, fieldDisplayText.Length - 1);
            string diagnostics = null;

            switch (error)
            {
                case ValidationResult.unknown:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark unknown issues as fatal
                    details.Coding[0].Display = "unknown";
                    if (!string.IsNullOrEmpty(fieldDisplayText))
                        details.Text = $"{fieldDisplayText}: Unknown validation error occurred";
                    else
                        details.Text = $"Unknown validation error occurred";
                    System.Diagnostics.Debugger.Break(); // wake up/slap the developer to actually deal with this
                    break;

                case ValidationResult.questionnaireNotFound:
                    code = OperationOutcome.IssueType.NotFound;
                    details.Coding[0].Display = "Questionnaire not found";
                    details.Text = $"The Questionnaire '{questionaireCanonicalUrl}' could not be resolved";
                    break;

                case ValidationResult.questionnaireDraft:
                    severity = OperationOutcome.IssueSeverity.Warning;
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "Questionnaire inactive";
                    details.Text = $"The Questionnaire is defined as a draft template";
                    break;

                case ValidationResult.questionnaireRetired:
                    severity = OperationOutcome.IssueSeverity.Warning;
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "Questionnaire inactive";
                    details.Text = $"The Questionnaire has been retired";
                    break;

                case ValidationResult.questionnaireInactive:
                    severity = OperationOutcome.IssueSeverity.Warning;
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "Questionnaire inactive";
                    details.Text = $"The authored date is outside the permitted period defined in the Questionnaire";
                    break;

                case ValidationResult.invalidLinkId:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
                    code = OperationOutcome.IssueType.Structure;
                    details.Coding[0].Display = "invalid LinkID";
                    details.Text = $"{fieldDisplayText}: The linkId '{responseItem.LinkId}' was not found in the Questionnaire";
                    break;

                case ValidationResult.groupShouldNotHaveAnswers:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
                    code = OperationOutcome.IssueType.Structure;
                    details.Coding[0].Display = "invalid group child items";
                    details.Text = $"{fieldDisplayText}: The type 'Group' should not use the 'answer' property, use the 'item' property for children";
                    break;

                case ValidationResult.invalidType:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
                    code = OperationOutcome.IssueType.Structure;
                    details.Coding[0].Display = "invalid item Type";
                    details.Text = $"{fieldDisplayText}: The type 'Question' is not selectable - use a specific child item type instead";
                    break;

                case ValidationResult.displayAnswer:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
                    code = OperationOutcome.IssueType.Structure;
                    details.Coding[0].Display = "Display has answer";
                    details.Text = $"{fieldDisplayText}: Display items do not support answers";
                    break;

                case ValidationResult.invalidAnswerType: // usually client system error
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
                    code = OperationOutcome.IssueType.Structure;
                    details.Coding[0].Display = "invalid value type";
                    details.Text = $"{fieldDisplayText}: Invalid datatype {responseItem.Answer[answerIndex.Value].Value?.TypeName} provided for a {itemDefinition.Type} item";
                    if (itemDefinition.Type == Questionnaire.QuestionnaireItemType.Url) details.Text += " (datatype: uri)";
                    break;

                case ValidationResult.invalidAnswerOption:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "invalid value";
                    details.Text = $"{fieldDisplayText}: was not in the set of permitted values";
                    break;

                case ValidationResult.exclusiveAnswerOption:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "exclusive option";
                    details.Text = $"{fieldDisplayText}: Selected answer {ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)} is an exclusive option";
                    break;

                case ValidationResult.invalidUrlValue:
                    code = OperationOutcome.IssueType.Value;
                    details.Coding[0].Display = "invalid value";
                    details.Text = $"{fieldDisplayText}: The value '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}' is not a valid URL";
                    break;

                case ValidationResult.required:
                    code = OperationOutcome.IssueType.Required;
                    details.Coding[0].Display = "required";
                    if (itemDefinition.Type == Questionnaire.QuestionnaireItemType.Group)
                        details.Text = $"{fieldDisplayText}: Mandatory group does not have answer(s)";
                    else
                        details.Text = $"{fieldDisplayText}: Mandatory field does not have an answer";
                    break;

                case ValidationResult.invariant:
                    code = OperationOutcome.IssueType.Invariant;
                    severity = invariant.Severity ?? OperationOutcome.IssueSeverity.Error;
                    details.Coding[0].Display = invariant.Human;
                    details.Coding.Add(new Coding(questionaireCanonicalUrl, invariant.Key, invariant.Human));
                    if (!string.IsNullOrEmpty(fieldDisplayText))
                        details.Text = $"{fieldDisplayText}: {invariant.Human}";
                    else
                        details.Text = $"{invariant.Human}";
                    diagnostics = invariant.Expression;
                    break;

                case ValidationResult.invariantExecution:
                    severity = OperationOutcome.IssueSeverity.Warning; // not sure if this is right...
                    code = OperationOutcome.IssueType.Invariant;
                    details.Coding[0].Display = "invalid validation expression";
                    if (!string.IsNullOrEmpty(fieldDisplayText))
                        details.Text = $"{fieldDisplayText}: Unable to evaluate custom validation rule {invariant.Human}";
                    else
                        details.Text = $"Unable to evaluate custom validation rule {invariant.Human}";
                    diagnostics = invariant.Expression;
                    diagnostics = String.Join("\r\n", diagnostics, exceptionThrown.Message);
                    break;

                case ValidationResult.repeats:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "multiple values";
                    details.Text = $"{fieldDisplayText}: Provided {responseItem.Answer.Count} answers for a question that only permits 1 answer";
                    break;

                case ValidationResult.minCount:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "not enough";
                    details.Text = $"{fieldDisplayText}: Expected minimum of {itemDefinition.MinOccurs()} answers, received {responseItem.Answer.Count}";
                    break;

                case ValidationResult.maxCount:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "too many";
                    details.Text = $"{fieldDisplayText}: Exceeded maximum of {itemDefinition.MaxOccurs()} answers, received {responseItem.Answer.Count}";
                    break;

                case ValidationResult.minValue:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "too small";
                    details.Text = $"{fieldDisplayText}: Expected the minimum value {ConvertValueForErrorMessage(itemDefinition, itemDefinition.MinValue() ?? itemDefinition.MinQuantity())}, received {ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}";
                    break;

                case ValidationResult.maxValue:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "too big";
                    details.Text = $"{fieldDisplayText}: Exceeded the maximum value {ConvertValueForErrorMessage(itemDefinition, itemDefinition.MaxValue() ?? itemDefinition.MaxQuantity())}, received {ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}";
                    break;

                case ValidationResult.maxDecimalPlaces:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "too precise";
                    details.Text = $"{fieldDisplayText}: Exceeded maximum decimal places {itemDefinition.MaxDecimalPlaces()}, received {CountDecimalDigits((responseItem.Answer[answerIndex.Value].Value as FhirDecimal).Value.Value)}";
                    break;

                case ValidationResult.minLength:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "too short";
                    details.Text = $"{fieldDisplayText}: Expected the minimum value {itemDefinition.MinLength()} characters, received {responseItem.Answer[answerIndex.Value].Value.ToString().Length}";
                    break;

                case ValidationResult.maxLength:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "too long";
                    details.Text = $"{fieldDisplayText}: Exceeded maximum of {itemDefinition.MaxLength} characters, received {responseItem.Answer[answerIndex.Value].Value.ToString().Length}";
                    break;

                case ValidationResult.invalidNewLine:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "contains newline";
                    details.Text = $"{fieldDisplayText}: 'string' type questions cannot contain newline characters";
                    break;

                case ValidationResult.tsError:
                    code = OperationOutcome.IssueType.Exception;
                    details.Coding[0].Display = "server error";
                    details.Text = $"{fieldDisplayText}: error checking terminology server";
                    if (exceptionThrown is FhirOperationException fex)
                    {
                        if (fex.Status == System.Net.HttpStatusCode.NotFound)
                            details.Text = $"{fieldDisplayText}: ValueSet not available on the terminology server";
                        else
                        if (fex.Status == System.Net.HttpStatusCode.Unauthorized)
                            details.Text = $"{fieldDisplayText}: Unauthorized connection to the terminology server";
                        else
                            details.Text = $"{fieldDisplayText}: Error checking terminology server (Http Status: {fex.Status})";
                    }
                    else
                    {
                        diagnostics = String.Join("\r\n", diagnostics, exceptionThrown.Message);
                    }
                    break;

                case ValidationResult.invalidCoding:
                    code = OperationOutcome.IssueType.CodeInvalid;
                    details.Coding[0].Display = "invalid code";
                    details.Text = $"{fieldDisplayText}: invalid selection '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}'";
                    break;

                case ValidationResult.maxAttachmentSize:
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = "attachment too large";
                    var att2 = responseItem.Answer[answerIndex.Value].Value as Attachment;
                    details.Text = $"{fieldDisplayText}: Exceeded the maximum attachment size {NumericBytesForErrorMessage((int)itemDefinition.MaxSize())}, received {NumericBytesForErrorMessage(att2.Data?.Length)}";
                    break;

                case ValidationResult.attachmentSizeInconsistent:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark unknown issues as fatal
                    code = OperationOutcome.IssueType.Invalid;
                    details.Coding[0].Display = "attachment size inconsistent";
                    var att3 = responseItem.Answer[answerIndex.Value].Value as Attachment;
                    details.Text = $"{fieldDisplayText}: attachment size reported {(att3.Size ?? 0):n} bytes, does not match the actual data size {(att3.Data?.Length ?? 0):n} bytes";
                    break;

                case ValidationResult.invalidAttachmentType:
                    var att4 = responseItem.Answer[answerIndex.Value].Value as Attachment;
                    code = OperationOutcome.IssueType.BusinessRule;
                    details.Coding[0].Display = $"unsupported attachment type '{att4.ContentType}'";
                    // TODO: Make the mime type(s) more user friendly
                    // use this package? https://www.nuget.org/packages/MimeTypeMapOfficial
                    details.Text = $"{fieldDisplayText}: attachment '{att4.ContentType}' is not one of the supported types {String.Join(", ", itemDefinition?.MimeTypes())}";
                    break;

                case ValidationResult.regex:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Invalid;
                    details.Coding[0].Display = "invalid format";
                    details.Text = $"{fieldDisplayText}: The value '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}' does not match the defined format";
                    if (!string.IsNullOrEmpty(itemDefinition.EntryFormat())) details.Text += $" {itemDefinition.EntryFormat()}";
                    diagnostics = itemDefinition.Regex();
                    break;

                case ValidationResult.regexTimeout:
                    severity = OperationOutcome.IssueSeverity.Warning;
                    code = OperationOutcome.IssueType.Exception;
                    details.Coding[0].Display = "can't verify format";
                    details.Text = $"{fieldDisplayText}: was unable to verify the format of the entry within {_settings.RegexTimeout.TotalSeconds} seconds";
                    diagnostics = itemDefinition.Regex();
                    break;

                case ValidationResult.invalidRefValue:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Invalid;
                    details.Coding[0].Display = "invalid format";
                    details.Text = $"{fieldDisplayText}: The value '{(responseItem.Answer[answerIndex.Value].Value as ResourceReference)?.Reference}' is not a valid FHIR Resource Reference";
                    break;

                case ValidationResult.invalidRefResourceType:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Invalid;
                    details.Coding[0].Display = "invalid FHIR resource type";
                    details.Text = $"{fieldDisplayText}: The value '{(responseItem.Answer[answerIndex.Value].Value as ResourceReference)?.Reference}' is not a valid FHIR Resource Reference";
                    break;

                case ValidationResult.invalidRefResourceTypeRestriction:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Value;
                    details.Coding[0].Display = "incorrect resource type";
                    details.Text = $"{fieldDisplayText}: The value '{(responseItem.Answer[answerIndex.Value].Value as ResourceReference)?.Reference}' does not refer to a {String.Join(", ", itemDefinition.ReferenceResource())}";
                    break;

                case ValidationResult.minValueIncompatUnits:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Value;
                    details.Coding[0].Display = "incompatible units";
                    details.Text = $"{fieldDisplayText}: Cannot convert value '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}' to '{itemDefinition.MinQuantity()?.Unit}' to verify minimum value";
                    break;

                case ValidationResult.maxValueIncompatUnits:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Value;
                    details.Coding[0].Display = "incompatible units";
                    details.Text = $"{fieldDisplayText}: Cannot convert value '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}' to '{itemDefinition.MaxQuantity()?.Unit}' to verify maximum value";
                    break;

                case ValidationResult.invalidUnit:
                    severity = OperationOutcome.IssueSeverity.Error;
                    code = OperationOutcome.IssueType.Value;
                    details.Coding[0].Display = "invalid units";
                    details.Text = $"{fieldDisplayText}: The value '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}' does not use '{string.Join("', '", itemDefinition.UnitOptions().Select(uo => uo.Display ?? uo.Code))}'";
                    break;

                case ValidationResult.invalidUnitValueSet:
                    code = OperationOutcome.IssueType.CodeInvalid;
                    details.Coding[0].Display = "invalid unit";
                    details.Text = $"{fieldDisplayText}: invalid unit '{ConvertValueForErrorMessage(itemDefinition, responseItem.Answer[answerIndex.Value].Value)}', is not in '{itemDefinition.UnitValueSet()}'";
                    break;

                default:
                    severity = OperationOutcome.IssueSeverity.Fatal; // mark unknown issues as fatal
                    System.Diagnostics.Debugger.Break(); // wake up/slap the developer to actually deal with this
                    break;
            }

            if (_settings.Logger != null)
            {
                LogLevel ll = LogLevel.Debug;
                switch (severity)
                {
                    case OperationOutcome.IssueSeverity.Fatal:
                        ll = LogLevel.Critical;
                        break;
                    case OperationOutcome.IssueSeverity.Error:
                        ll = LogLevel.Error;
                        break;
                    case OperationOutcome.IssueSeverity.Warning:
                        ll = LogLevel.Warning;
                        break;
                    case OperationOutcome.IssueSeverity.Information:
                        ll = LogLevel.Information;
                        break;
                }
                _settings.Logger.Log(ll, $"{code}: {details.Text}");
                if (exceptionThrown != null)
                {
                    _settings.Logger.Log(LogLevel.Error, exceptionThrown.Message);
                }
            }

            if (status == QuestionnaireResponse.QuestionnaireResponseStatus.InProgress)
            {
                // when the response is in progress, downgrade errors to warnings
                severity = OperationOutcome.IssueSeverity.Warning;
                diagnostics = String.Join("\r\n", diagnostics, "InProgress QuestionnaireResponse downgraded to warning");
            }

            if (!string.IsNullOrEmpty(diagnostics))
                _settings.Logger?.Log(LogLevel.Debug, diagnostics);

            var result = new OperationOutcome.IssueComponent()
            {
                Severity = severity,
                Code = code,
                Expression = locationExpression,
                Location = new[] { $"linkId='{responseItem?.LinkId ?? itemDefinition?.LinkId}'" },
                Details = details,
                Diagnostics = diagnostics
            };
            if (string.IsNullOrEmpty(responseItem?.LinkId ?? itemDefinition?.LinkId))
            {
                result.Location = null;
            }

            // Check if the item is visible (thanks to enablewhen logic) and thus the validation message should be ignored
            if (IsVisible(itemDefinition, responseItem))
            {
                outcomeIssues.Enqueue(result);
            }
            return result;
        }

        /// <summary>
        /// Convert the value that is provided into a simple message for user display (so the number is more readable)
        /// This should also be translated for multiple languages too
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string NumericBytesForErrorMessage(long? value)
        {
            if (!value.HasValue)
                return "(unknown) bytes";

            if (value < 1000)
                return $"{value:n0} bytes";

            if (value < 10000000)
                return $"{(value / 1000.0):g3} KB";

            return $"{(value / 1000000.0):g3} MB";
        }

        /// <summary>
        /// Is the Item visible thanks to an enableWhen rule (or more accurately, hidden depending on the ruling)
        /// </summary>
        /// <param name="itemDefinition"></param>
        /// <param name="responseItem"></param>
        /// <returns></returns>
        bool IsVisible(Questionnaire.ItemComponent itemDefinition, QuestionnaireResponse.ItemComponent responseItem)
        {
            // TODO: Check EnableWhen visibility rules
            if (itemDefinition?.EnableWhen?.Any() == true)
            {

            }
            return true;
        }

        /// <summary>
        /// Convert the output for user display format, which may include units if provided
        /// </summary>
        /// <returns></returns>
        string ConvertValueForErrorMessage(Questionnaire.ItemComponent itemDefinition, Base value)
        {
            if (value == null) return "";
            string units = itemDefinition.Unit()?.Display;

            switch (itemDefinition.Type)
            {
                case Questionnaire.QuestionnaireItemType.Decimal:
                    if (!string.IsNullOrEmpty(units))
                        return string.Join(" ", value.ToString(), units);
                    break;
                case Questionnaire.QuestionnaireItemType.Integer:
                    if (!string.IsNullOrEmpty(units))
                        return string.Join(" ", value.ToString(), units);
                    break;
                case Questionnaire.QuestionnaireItemType.Date:
                    // TODO: Date value output formatting - needs to be able to handle client side language
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
                    return string.Join(" ", (value as Date).ToDateTimeOffset().Value.Date.ToString(ci), units);
                case Questionnaire.QuestionnaireItemType.DateTime:
                    // TODO: DateTime value output formatting - needs to be able to handle client side language
                    break;
#if FHIR_R5
				case Questionnaire.QuestionnaireItemType.Coding:
					if (value is Coding coding) return coding.Display ?? coding.Code;
					break;
#else
				case Questionnaire.QuestionnaireItemType.Choice:
                    if (value is Coding coding) return coding.Display ?? coding.Code;
                    break;
                case Questionnaire.QuestionnaireItemType.OpenChoice:
                    if (value is Coding codingOpen) return codingOpen.Display ?? codingOpen.Code;
                    break;
#endif
				case Questionnaire.QuestionnaireItemType.Attachment:
                    // just return the first n chars of the attachment?
                    if (value is Attachment att)
                    {
                        return String.Join(" ",
                            att.Title,
                            (att.Size.HasValue ? $"size: {NumericBytesForErrorMessage(att.Size)}" : null),
                            (!string.IsNullOrEmpty(att.ContentType) ? $"type: {att.ContentType}" : null)
                            );
                    }
                    break;
                case Questionnaire.QuestionnaireItemType.Reference:
                    if (value is ResourceReference resRef) return resRef.Display ?? resRef.Reference;
                    break;
                case Questionnaire.QuestionnaireItemType.Quantity:
                    if (value is Quantity quantity)
                    {
                        // also include the units
                        string qUnits = quantity.Unit ?? quantity.Code;
                        if (!string.IsNullOrEmpty(qUnits)) return $"{quantity.Value} {qUnits}";
                        return quantity.Value?.ToString();
                    }
                    break;
            }
            // all other types can just use the ToString variant
            return value.ToString();
        }

        public QuestionnaireResponseValidator(ValidationSettings settings = null)
        {
            _settings = settings ?? new ValidationSettings()
            {
                TerminologyServerAddress = "https://sqlonfhir-r4.azurewebsites.net/fhir",
                TerminologyServerFhirClientSettings = new FhirClientSettings()
                {
                    VerifyFhirVersion = false,
                    PreferCompressedResponses = true
                }
            };
        }
        ValidationSettings _settings;
        List<Task> AsyncValidations = new List<System.Threading.Tasks.Task>();
        ConcurrentQueue<OperationOutcome.IssueComponent> outcomeIssues = new ConcurrentQueue<OperationOutcome.IssueComponent>();

        private int DateCompare(string date1, string date2)
        {
            if (string.IsNullOrEmpty(date1) || string.IsNullOrEmpty(date2)) return 0;
            int minPrecision = Math.Min(date1.Length, date2.Length);
            return String.Compare(date1.Substring(0, minPrecision), date2.Substring(0, minPrecision));
        }

        public async Task<OperationOutcome> Validate(QuestionnaireResponse qr, Questionnaire q)
        {
            if (q == null)
            {
                ReportValidationMessage(ValidationResult.questionnaireNotFound, null, new[] { "QuestionnaireResponse.questionnaire" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed, null, null, null, questionaireCanonicalUrl: qr.Questionnaire);
            }
            else
            {
                // Check the versioning of the canonical URLs match (this is really a sanity check that the resolver found the correct definition)
                var cu = new CanonicalUrl(qr.Questionnaire);
                if (cu.Url?.Value != q.Url || string.IsNullOrEmpty(q.Url))
                {
                    ReportValidationMessage(ValidationResult.unknown, null, new[] { "QuestionnaireResponse.questionnaire" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed, null, null, null);
                }
                if (!string.IsNullOrEmpty(cu.Version?.Value))
                {
                    if (cu.Version.Value != q.Version)
                    {
                        ReportValidationMessage(ValidationResult.unknown, null, new[] { "QuestionnaireResponse.questionnaire" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed, null, null, null);
                    }
                }

                // Check that the form definition was active/effective dates
                if (q.EffectivePeriod != null && !string.IsNullOrEmpty(qr.Authored) && (DateCompare(q.EffectivePeriod.Start, qr.Authored) > 0 || DateCompare(q.EffectivePeriod.End, qr.Authored) < 0))
                {
                    ReportValidationMessage(ValidationResult.questionnaireInactive, null, new[] { "QuestionnaireResponse.authored" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed, null, null, null);
                }

                // check if the questionnaire definition is in draft
                if (q.Status == PublicationStatus.Draft)
                {
                    ReportValidationMessage(ValidationResult.questionnaireDraft, null, new[] { "QuestionnaireResponse.questionnaire" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed, null, null, null);
                }

                // check if the questionnaire definition is in draft
                if (q.Status == PublicationStatus.Retired)
                {
                    ReportValidationMessage(ValidationResult.questionnaireRetired, null, new[] { "QuestionnaireResponse.questionnaire" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed, null, null, null);
                }

                // Check that the structure matches
                var symbolTable = new Hl7.FhirPath.Expressions.SymbolTable(Hl7.FhirPath.FhirPathCompiler.DefaultSymbolTable);
                symbolTable.AddVar("questionnaire", q.ToTypedElement());
                foreach (var variableExpression in q.Variables())
                {
                    //    var values = EvaluateFhirPath(symbolTable, variableExpression, outcome, "variable");
                    //    Questionnaire_PrePopulate_Observation.AddVariable(symbolTable, variableExpression.Name, values);
                }
                ValidateItems(qr, q, symbolTable, "QuestionnaireResponse.item", qr.Item, q.Item, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed);

                // check that all the top level invariants/extensions all pass
                ValidateInvariants(qr, q, symbolTable, null, null, new[] { "QuestionnaireResponse" }, qr.Status ?? QuestionnaireResponse.QuestionnaireResponseStatus.Completed);

                // await for any background tasks to complete
                if (AsyncValidations.Any())
                {
                    await Task.WhenAll(AsyncValidations);
                }
            }

            // append all the outcomes into the output results
            var outcome = new OperationOutcome();
            outcome.Issue.AddRange(outcomeIssues);

            // and clear out the data
            AsyncValidations.Clear();
#if NET462 || NETSTANDARD2_0
            outcomeIssues = new ConcurrentQueue<OperationOutcome.IssueComponent>();
#else
            outcomeIssues.Clear();
#endif

            return outcome;
        }

        private void ValidateItems(QuestionnaireResponse QR, Questionnaire Q, SymbolTable symbolTable, string pathExpression, List<QuestionnaireResponse.ItemComponent> items, IEnumerable<Questionnaire.ItemComponent> itemDefinitions, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            List<QuestionnaireResponse.ItemComponent> itemsRemaining = items.ToList();
            foreach (var itemDef in itemDefinitions)
            {
                var itemsForItemDefinition = itemsRemaining.Where(i => i.LinkId == itemDef.LinkId).ToArray();
                foreach (var i in itemsForItemDefinition)
                    itemsRemaining.Remove(i);

                foreach (var item in itemsForItemDefinition)
                {
                    ValidateItem(QR, Q, symbolTable, $"{pathExpression}[{items.IndexOf(item)}]", item, itemDef, status);
                }
                if (!itemsForItemDefinition.Any())
                {
                    // Check if the definition was a required field... (fake an item, but can't use it's path as it isn't real)
                    var fakeItem = new FakeItem() { LinkId = itemDef.LinkId };
                    ValidateItem(QR, Q, symbolTable, $"{pathExpression.Substring(0, pathExpression.Length - 5)}", fakeItem, itemDef, status);
                }
            }

            // Check if there are any items left that did not have a definition (as these are in error)
            foreach (var item in itemsRemaining)
            {
                ReportValidationMessage(ValidationResult.invalidLinkId, null, new[] { $"{pathExpression}[{items.IndexOf(item)}]" }, status, item, null, null);
            }

            // Should we be checking the order of the items in the collection(s) too?
            // Lloyd, yes we should be - that can help with the performance too (don't need to split/join items)
        }

        /// <summary>
        /// This FakeItem class is just used to be a marker
        /// when validating a group that has no children
        /// so that mandatory fields are checked consistently
        /// </summary>
        private class FakeItem : QuestionnaireResponse.ItemComponent
        {
        }

        private void ValidateItem(QuestionnaireResponse QR, Questionnaire Q, SymbolTable symbolTable, string pathExpression, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // check repeats/mandatory/min count/max count
            if (item.Answer.Count > 1 && itemDef.Repeats != true)
            {
                // too many responses (for non repeating item)
                ReportValidationMessage(ValidationResult.repeats, itemDef, new[] { pathExpression }, status, item, null, null);
            }
            if (item.Answer.Count == 0 && itemDef.Required == true)
            {
                // Mandatory
                ReportValidationMessage(ValidationResult.required, itemDef, new[] { pathExpression }, status, item, null, null);
            }
            var minOccurs = itemDef.MinOccurs();
            if (minOccurs.HasValue && item.Answer.Count < minOccurs.Value)
            {
                // not enough answers
                ReportValidationMessage(ValidationResult.minCount, itemDef, new[] { pathExpression }, status, item, null, null);
            }

            // May need to move the invariant processing up to here

            // This was a Fake Item introduced to check for Mandatory/min count child items
            // so bail any further testing
            if (item is FakeItem) return;

            var maxOccurs = itemDef.MaxOccurs();
            if (maxOccurs.HasValue && item.Answer.Count > maxOccurs.Value)
            {
                // too many answers
                ReportValidationMessage(ValidationResult.maxCount, itemDef, new[] { pathExpression }, status, item, null, null);
            }
            if (itemDef.Type == Questionnaire.QuestionnaireItemType.Display && item.Answer.Count > 0)
            {
                // Display Items should't have answers
                ReportValidationMessage(ValidationResult.displayAnswer, itemDef, new[] { pathExpression }, status, item, null, null);
            }
            if (itemDef.Type == Questionnaire.QuestionnaireItemType.Question)
            {
                // "Question" Items shouldn't be used
                ReportValidationMessage(ValidationResult.invalidType, itemDef, new[] { pathExpression }, status, item, null, null);
            }

            if (itemDef.Type == Questionnaire.QuestionnaireItemType.Group)
            {
                // Check for children
                if (item.Answer.Any())
                {
                    ReportValidationMessage(ValidationResult.groupShouldNotHaveAnswers, itemDef, new[] { $"{pathExpression}.answer" }, status, item, null, null);
                }
                if (itemDef.Item?.Any() == true)
                {
                    ValidateItems(QR, Q, symbolTable, $"{pathExpression}.item", item.Item, itemDef.Item, status);
                }
            }
            else
            {
                if (item.Item.Any())
                {
                    // This is meant to be that there is no group intended to be found here...
                    ReportValidationMessage(ValidationResult.invalidType, itemDef, new[] { pathExpression }, status, item, null, null);
                }
                int answerIndex = 0;
                foreach (var answer in item.Answer)
                {
                    var answerItemPathExpression = new[] { $"{pathExpression}.answer[{answerIndex}]" };
                    // check that the datatypes for all the answers match the definition
                    ValidateItemTypeData(item, itemDef, answerIndex, answerItemPathExpression, status);

                    // Check for children
                    if (itemDef.Item?.Any() == true)
                    {
                        ValidateItems(QR, Q, symbolTable, $"{pathExpression}.answer[{answerIndex}].item", answer.Item, itemDef.Item, status);
                    }
                    answerIndex++;
                }
            }

            // check that all the invariants/extensions all pass
            ValidateInvariants(QR, Q, symbolTable, item, itemDef, new[] { pathExpression }, status);
        }

        private void ValidateItemTypeData(QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            switch (itemDef.Type)
            {
                case Questionnaire.QuestionnaireItemType.Group:
                    // Nothing to see here - no spec defined rules applicable
                    break;
                case Questionnaire.QuestionnaireItemType.Display:
                    // Nothing to see here - handled above
                    break;
                case Questionnaire.QuestionnaireItemType.Question:
                    // Nothing to see here - handled above
                    break;
                case Questionnaire.QuestionnaireItemType.Boolean:
                    if (item.Answer[answerIndex].Value is FhirBoolean fb)
                    {
                        // There are no Boolean specific validation rules
                        // ValidateBooleanValue(false, item, itemDef, answerIndex, answerItemPathExpression, fb);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Decimal:
                    if (item.Answer[answerIndex].Value is FhirDecimal fd)
                    {
                        ValidateDecimalValue(false, item, itemDef, answerIndex, answerItemPathExpression, fd, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Integer:
                    if (item.Answer[answerIndex].Value is Integer fi)
                    {
                        ValidateIntegerValue(false, item, itemDef, answerIndex, answerItemPathExpression, fi, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Date:
                    if (item.Answer[answerIndex].Value is Date fdate)
                    {
                        ValidateDateValue(false, item, itemDef, answerIndex, answerItemPathExpression, fdate, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.DateTime:
                    if (item.Answer[answerIndex].Value is FhirDateTime fdateTime)
                    {
                        ValidateDateTimeValue(false, item, itemDef, answerIndex, answerItemPathExpression, fdateTime, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Time:
                    if (item.Answer[answerIndex].Value is Time ft)
                    {
                        ValidateTimeValue(false, item, itemDef, answerIndex, answerItemPathExpression, ft, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.String:
                    if (item.Answer[answerIndex].Value is FhirString str)
                    {
                        ValidateStringValue(false, item, itemDef, answerIndex, answerItemPathExpression, str, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Text:
                    if (item.Answer[answerIndex].Value is FhirString strText)
                    {
                        ValidateStringValue(true, item, itemDef, answerIndex, answerItemPathExpression, strText, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Url:
                    if (item.Answer[answerIndex].Value is FhirUri furl)
                    {
                        ValidateUrlValue(false, item, itemDef, answerIndex, answerItemPathExpression, furl, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
#if FHIR_R5
                case Questionnaire.QuestionnaireItemType.Coding:
					if (item.Answer[answerIndex].Value is Coding coding)
					{
						// validate the coding
						ValidateCodingValue(item, itemDef, answerIndex, answerItemPathExpression, coding, status);
					}
					else
                    {
                        // The answerConstraint property can permit other types of values
                        if (itemDef.AnswerConstraint == Questionnaire.QuestionnaireAnswerConstraint.OptionsOrString)
                        {
                            // This is the equivalent of open-choice in R4/R4B
                            if (item.Answer[answerIndex].Value is FhirString strVal)
                            {
                                ValidateStringValue(false, item, itemDef, answerIndex, answerItemPathExpression, strVal, status);
                            }
                            else
                                ReportValidationMessage(ValidationResult.invalidAnswerOption, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                        }
                        else
                        {
						ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                        }
                    }
					break;
#else
                case Questionnaire.QuestionnaireItemType.Choice:
                    if (item.Answer[answerIndex].Value is Coding coding)
                    {
                        // validate the coding
                        ValidateCodingValue(item, itemDef, answerIndex, answerItemPathExpression, coding, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.OpenChoice:
                    if (item.Answer[answerIndex].Value is Coding codingOpen)
                    {
                        // validate the coding
                        ValidateCodingValue(item, itemDef, answerIndex, answerItemPathExpression, codingOpen, status);
                    }
                    else if (item.Answer[answerIndex].Value is FhirString strOpen)
                    {
                        // String values not TEXT values (don't have newlines)
                        ValidateStringValue(false, item, itemDef, answerIndex, answerItemPathExpression, strOpen, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
#endif
                case Questionnaire.QuestionnaireItemType.Attachment:
                    if (item.Answer[answerIndex].Value is Attachment att)
                    {
                        // validate the attahcment
                        ValidateAttachmentValue(item, itemDef, answerIndex, answerItemPathExpression, att, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Reference:
                    if (item.Answer[answerIndex].Value is ResourceReference resref)
                    {
                        ValidateReferenceValue(false, item, itemDef, answerIndex, answerItemPathExpression, resref, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
                case Questionnaire.QuestionnaireItemType.Quantity:
                    if (item.Answer[answerIndex].Value is Quantity fq)
                    {
                        ValidateQuantityValue(false, item, itemDef, answerIndex, answerItemPathExpression, fq, status);
                    }
                    else
                        ReportValidationMessage(ValidationResult.invalidAnswerType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    break;
            }
        }

        private void ValidateAnswerOption<T>(QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, T value, QuestionnaireResponse.QuestionnaireResponseStatus status)
            where T : DataType
        {
            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            var typeOptions = itemDef.AnswerOption.Where(ao => ao.Value is T && ao.Value.Matches(value));
            if (itemDef.AnswerOption.Any())
            {
                if (!typeOptions.Any()) // Check as a "pattern"
                {
                    ReportValidationMessage(ValidationResult.invalidAnswerOption, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                }

                // Check option Exclusive http://hl7.org/fhir/StructureDefinition/questionnaire-optionExclusive
                if (typeOptions.Any(to => to.OptionExclusive() == true))
                {
                    if (item.Answer.Count > 1)
                    {
                        ReportValidationMessage(ValidationResult.exclusiveAnswerOption, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    }
                }
            }
        }

        private void ValidateCodingValue(QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Coding coding, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            ValidateAnswerOption(item, itemDef, answerIndex, answerItemPathExpression, coding, status);

            // Check against answerValueSet
            ValidateCodingValueAgainstValueSet(item, itemDef, answerIndex, answerItemPathExpression, coding, status);

            // TODO: ??? Check ordinal Value too (and populate if it not provided -- requires a lookup, not validate-code)
        }

        private void ValidateCodingValueAgainstValueSet(QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Coding coding, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            if (!string.IsNullOrEmpty(itemDef.AnswerValueSet))
            {
                // TODO: Check for the preferrred terminology server extension
                FhirClient ts;
                if (_settings.TerminologyServerMessageHandler != null)
                    ts = new FhirClient(_settings.TerminologyServerAddress, _settings.TerminologyServerFhirClientSettings, _settings.TerminologyServerMessageHandler);
                else
                    ts = new FhirClient(_settings.TerminologyServerAddress, _settings.TerminologyServerFhirClientSettings);

                // split the AnswerValueSet value into canonical and version.
                var canonical = new CanonicalUrl(itemDef.AnswerValueSet);
                Task validateCode = ts.ValidateCodeAsync(url: canonical.Url, version: canonical.Version, coding: coding)
                    .ContinueWith((result) =>
                    {
                        Console.WriteLine(ts.LastBodyAsText);
                        if (result.IsFaulted)
                        {
                            result.Exception?.Handle(ex =>
                            {
                                Console.WriteLine(ex.ToString());
                                ReportValidationMessage(ValidationResult.tsError, itemDef, answerItemPathExpression, status, item, answerIndex, null, ex);
                                return true;
                            });
                            return;
                        }
                        if (result.Result.Result.Value.Value != true)
                        {
                            ReportValidationMessage(ValidationResult.invalidCoding, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                        }
                    });
                this.AsyncValidations.Add(validateCode);
            }

            // Check against answerExpression? (assuming have access to all data - maybe this becomes a warning only)
            //if (itemDef.answerExpression.any())
            {
                // just log an info message that this isn't supported yet
            }

            // External Dependencies: (data access incl. permissions)
            // * launch context
            // * source queries
            // * answerValueSet
            // * fhirpath/cql expressions & resolve()
            // * x-fhirquery expressions
        }

        private void ValidateQuantityUnitValueAgainstValueSet(QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Coding coding, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            if (!string.IsNullOrEmpty(itemDef.UnitValueSet()))
            {
                // if there are no computable units (code) specified, then this needs to be reported as an error
                if (string.IsNullOrEmpty(coding.System) || string.IsNullOrEmpty(coding.Code))
                {
                    // this value isn't testable, so bail here.
                    ReportValidationMessage(ValidationResult.invalidUnitValueSet, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    return;
                }

                // TODO: Check for the preferrred terminology server extension
                FhirClient ts;
                if (_settings.TerminologyServerMessageHandler != null)
                    ts = new FhirClient(_settings.TerminologyServerAddress, _settings.TerminologyServerFhirClientSettings, _settings.TerminologyServerMessageHandler);
                else
                    ts = new FhirClient(_settings.TerminologyServerAddress, _settings.TerminologyServerFhirClientSettings);

                // split the AnswerValueSet value into canonical and version.
                var canonical = new CanonicalUrl(itemDef.UnitValueSet());
                Task validateCode = ts.ValidateCodeAsync(url: canonical.Url, version: canonical.Version, coding: coding)
                    .ContinueWith((result) =>
                    {
                        Console.WriteLine(ts.LastBodyAsText);
                        if (result.IsFaulted)
                        {
                            result.Exception?.Handle(ex =>
                            {
                                Console.WriteLine(ex.ToString());
                                ReportValidationMessage(ValidationResult.tsError, itemDef, answerItemPathExpression, status, item, answerIndex, null, ex);
                                return true;
                            });
                            return;
                        }
                        if (result.Result.Result.Value.Value != true)
                        {
                            ReportValidationMessage(ValidationResult.invalidUnitValueSet, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                        }
                    });
                this.AsyncValidations.Add(validateCode);
            }
        }

        private void ValidateQuantityValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Quantity value, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Check for units http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption
            var unitOptions = itemDef.UnitOptions().ToList();
            if (unitOptions.Any())
            {
                if (!unitOptions.Any(uo =>
                {
                    if (!string.IsNullOrEmpty(uo.System) && uo.System != value.System) return false;
                    if (!string.IsNullOrEmpty(uo.Code) && uo.Code != value.Code) return false;
                    // Not sure on this one, as if there are translations or other designations then this could legitimately be different
                    // if (!string.IsNullOrEmpty(uo.Display) && uo.Display != value.Unit) return false;
                    return true;
                }))
                {
                    ReportValidationMessage(ValidationResult.invalidUnit, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                }
            }

            // and also from here http://hl7.org/fhir/StructureDefinition/questionnaire-unitValueSet
            // which can be done as a ValidateCode call (just like coded items)
            ValidateQuantityUnitValueAgainstValueSet(item, itemDef, answerIndex, answerItemPathExpression, new Coding(value.System, value.Code, value.Unit), status);

            // Min value
            if (itemDef.MinQuantity() != null)
            {
                if (!CanConvertUnits(itemDef.MinQuantity(), value))
                    ReportValidationMessage(ValidationResult.minValueIncompatUnits, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                else if (CompareQuantity(itemDef.MinQuantity(), value) > 0)
                    ReportValidationMessage(ValidationResult.minValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }

            // max value
            if (itemDef.MaxQuantity() != null)
            {
                if (!CanConvertUnits(itemDef.MaxQuantity(), value))
                    ReportValidationMessage(ValidationResult.maxValueIncompatUnits, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                else if (CompareQuantity(itemDef.MaxQuantity(), value) < 0)
                    ReportValidationMessage(ValidationResult.maxValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }

            // Referenced content? e.g. reference ranges?
        }

        private static global::Fhir.Metrics.SystemOfUnits _system;

        bool CanConvertUnits(Quantity l, Quantity r)
        {
            // this implementation only supports converting UCUM units (but will default to ucum if not specified)
            var lSys = l.System ?? Hl7.Fhir.ElementModel.Types.Quantity.UCUM;
            var rSys = r.System ?? Hl7.Fhir.ElementModel.Types.Quantity.UCUM;
            if (rSys != lSys) return false;
            if (!string.IsNullOrEmpty(r.Code) && r.Code == l.Code) return true;
            if (!string.IsNullOrEmpty(r.Unit) && r.Unit == l.Unit) return true;
            if (rSys != Hl7.Fhir.ElementModel.Types.Quantity.UCUM) return false;


            // Check by converting to the canonical types (lazy load the ucum values)
            if (_system == null) _system = global::Fhir.Metrics.UCUM.Load();
            try
            {
                // new Fhir.Metrics.SystemOfUnits().Conversions.
                var lv = _system.Quantity(l.Value.ToString(), l.Code ?? l.Unit);
                var lc = _system.Canonical(lv);
                var rv = _system.Quantity(r.Value.ToString(), r.Code ?? r.Unit);
                var rc = _system.Canonical(rv);
                if (rc.Metric.Symbols != lc.Metric.Symbols) return false;
            }
            catch (ArgumentException)
            {
                // unable to read the value/codes in the converter (therefore can't convert them)
                return false;
            }

            return true;
        }

        int CompareQuantity(Quantity l, Quantity r)
        {
            if (!string.IsNullOrEmpty(r.Code) && r.Code == l.Code || !string.IsNullOrEmpty(r.Unit) && r.Unit == l.Unit)
                return Decimal.Compare(l.Value.Value, r.Value.Value);

            // Perform the ucum conversion (_system was lazy initialized during the CanConvertUnits routine)
            var lv = _system.Quantity(l.Value.ToString(), l.Code ?? l.Unit);
            var lc = _system.Canonical(lv);
            var rv = _system.Quantity(r.Value.ToString(), r.Code ?? r.Unit);
            var rc = _system.Canonical(rv);
            return Decimal.Compare(lc.Value.ToDecimal(), rc.Value.ToDecimal());
        }

        private void ValidateReferenceValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, ResourceReference resref, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Check the format (option for RI checks?)
            if (!string.IsNullOrEmpty(resref.Reference))
            {
                // Check that the URL is a well formed URL
                if (!Uri.IsWellFormedUriString(resref.Reference, UriKind.RelativeOrAbsolute))
                {
                    ReportValidationMessage(ValidationResult.invalidRefValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                }
                else
                {
                    var ri = new ResourceIdentity(resref.Reference);
                    var schemes = new[] { "http", "https" };
                    if (ri.IsAbsoluteUri && !schemes.Contains(ri.Scheme))
                    {
                        ReportValidationMessage(ValidationResult.invalidRefValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    }
                    else
                    {

                        if (!ModelInfo.IsKnownResource(ri.ResourceType))
                        {
                            ReportValidationMessage(ValidationResult.invalidRefResourceType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                        }

                        // http://hl7.org/fhir/StructureDefinition/questionnaire-referenceResource
                        var resourceTypes = itemDef.ReferenceResource().ToList();
                        if (!string.IsNullOrEmpty(ri.ResourceType) && resourceTypes.Any())
                        {
                            if (!resourceTypes.Contains(ri.ResourceType))
                            {
                                ReportValidationMessage(ValidationResult.invalidRefResourceTypeRestriction, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                            }
                        }

                        // If we can resolve the target of the instance, then we should be able to validate that this profile is correct
                        // http://hl7.org/fhir/StructureDefinition/questionnaire-referenceProfile
                        // TODO: Enable an async hook to go check these in the setting object
                    }

                    // Can't do any validations on this one http://hl7.org/fhir/StructureDefinition/questionnaire-referenceFilter
                }
            }

            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            ValidateAnswerOption(item, itemDef, answerIndex, answerItemPathExpression, resref, status);
        }

        private void ValidateUrlValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, FhirUri furl, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Validate the format (uuid)
            if (furl.Value.StartsWith("urn:uuid:"))
            {
                if (!Guid.TryParse(furl.Value.Substring("urn:uuid:".Length), out Guid valueGuid))
                {
                    ReportValidationMessage(ValidationResult.invalidUrlValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                }
                return;
            }

            // Validate the format
            if (!Uri.IsWellFormedUriString(furl.Value, UriKind.RelativeOrAbsolute))
            {
                ReportValidationMessage(ValidationResult.invalidUrlValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }
        }

        private void ValidateTimeValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Time value, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            ValidateAnswerOption(item, itemDef, answerIndex, answerItemPathExpression, value, status);
        }

        private void ValidateDateTimeValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, FhirDateTime value, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // min value
            var min = itemDef.MinValue() as FhirDateTime;
            if (min != null && DateCompare(min.Value, value.Value) > 0)
                ReportValidationMessage(ValidationResult.minValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // max value
            var max = itemDef.MaxValue() as FhirDateTime;
            if (max != null && DateCompare(max.Value, value.Value) < 0)
                ReportValidationMessage(ValidationResult.maxValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);
        }

        private void ValidateDateValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Date value, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // min value
            var min = itemDef.MinValue() as Date;
            if (min != null && DateCompare(min.Value, value.Value) > 0)
                ReportValidationMessage(ValidationResult.minValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // max value
            var max = itemDef.MaxValue() as Date;
            if (max != null && DateCompare(max.Value, value.Value) < 0)
                ReportValidationMessage(ValidationResult.maxValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            ValidateAnswerOption(item, itemDef, answerIndex, answerItemPathExpression, value, status);
        }

        private void ValidateIntegerValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Integer fi, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // min value
            var min = itemDef.MinValue() as Integer;
            if (min != null && min.Value > fi.Value)
                ReportValidationMessage(ValidationResult.minValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // max value
            var max = itemDef.MaxValue() as Integer;
            if (max != null && max.Value < fi.Value)
                ReportValidationMessage(ValidationResult.maxValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            ValidateAnswerOption(item, itemDef, answerIndex, answerItemPathExpression, fi, status);
        }

        private void ValidateDecimalValue(bool v, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, FhirDecimal fd, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // min value
            var min = itemDef.MinValue() as FhirDecimal;
            if (min != null && min.Value > fd.Value)
                ReportValidationMessage(ValidationResult.minValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // max value
            var max = itemDef.MaxValue() as FhirDecimal;
            if (max != null && max.Value < fd.Value)
                ReportValidationMessage(ValidationResult.maxValue, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // max decimal places
            var maxDecPlaces = itemDef.MaxDecimalPlaces();
            if (fd.Value.HasValue && maxDecPlaces.HasValue && CountDecimalDigits(fd.Value.Value) > maxDecPlaces.Value)
            {
                ReportValidationMessage(ValidationResult.maxDecimalPlaces, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }
            // TODO: https://build.fhir.org/extension-quantity-precision.html
        }

        int CountDecimalDigits(decimal n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture)
                    .SkipWhile(c => c != '.')
                    .Skip(1)
                    .Count();
        }

        private void ValidateAttachmentValue(QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, Attachment att, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Size of attachment inconsistent
            if (att.Size.HasValue && att.Data?.Length != att.Size)
            {
                ReportValidationMessage(ValidationResult.attachmentSizeInconsistent, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }

            // Max File Size (bytes)
            if (att.Data?.Length > itemDef.MaxSize())
            {
                ReportValidationMessage(ValidationResult.maxAttachmentSize, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }

            // Supported Types
            var mimeTypes = itemDef.MimeTypes();
            if (mimeTypes?.Any() == true && (!mimeTypes.Contains(att.ContentType) || string.IsNullOrEmpty(att.ContentType)))
            {
                ReportValidationMessage(ValidationResult.invalidAttachmentType, itemDef, answerItemPathExpression, status, item, answerIndex, null);
            }
        }

        private void ValidateStringValue(bool PermitNewLines, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, int answerIndex, string[] answerItemPathExpression, FhirString strOpen, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            // Newlines are only valid for TEXT not STRING
            if (!PermitNewLines && strOpen.Value?.IndexOfAny(new[] { '\r', '\n' }) > -1)
                ReportValidationMessage(ValidationResult.invalidNewLine, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // Min Length
            if (strOpen.Value?.Length < itemDef.MinLength())
                ReportValidationMessage(ValidationResult.minLength, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // Max length
            if (strOpen.Value?.Length > itemDef.MaxLength)
                ReportValidationMessage(ValidationResult.maxLength, itemDef, answerItemPathExpression, status, item, answerIndex, null);

            // Check the Regex rules http://hl7.org/fhir/StructureDefinition/regex
            // Suggest including the entryFormat extension to guide the use of the regex violation (placeholder text)
            var regexValue = itemDef.Regex();
            if (!string.IsNullOrEmpty(regexValue))
            {
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/best-practices
                try
                {
                    // By using the static IsMatch method .net will cache the expression compilation in memory
                    // (defaults to 15 instances, if more are needed, update the System.Text.RegularExpressions.Regex.CacheSize value)
                    var resultRegex = System.Text.RegularExpressions.Regex.IsMatch(strOpen.Value, regexValue, System.Text.RegularExpressions.RegexOptions.None, _settings.RegexTimeout);
                    if (!resultRegex)
                    {
                        ReportValidationMessage(ValidationResult.regex, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                    }
                }
                catch (System.Text.RegularExpressions.RegexMatchTimeoutException ex)
                {
                    // TODO: probably something to specifically log (should the checked data be in this message?)
                    _settings.Logger?.Log(LogLevel.Error, $"Timeout attempting to evaluate regex expression: {regexValue} on string {strOpen.Value}");

                    // Regex validation processing timed out
                    ReportValidationMessage(ValidationResult.regexTimeout, itemDef, answerItemPathExpression, status, item, answerIndex, null);
                }
            }

            // Check if constrained by AnswerOptions (closed in R4 - option in R5)
            ValidateAnswerOption(item, itemDef, answerIndex, answerItemPathExpression, strOpen, status);

            // Check if constrained by AnswerValueSet... CODE value in the codings :(
            if (itemDef.Type == Questionnaire.QuestionnaireItemType.String) // TEXT doesn't use it
            {
                // This is prevented by que-5 - Brian to log this for R5 to fix.
                // https://build.fhir.org/terminologies.html#strings
                // https://build.fhir.org/extension-originaltext.html
                ValidateCodingValueAgainstValueSet(item, itemDef, answerIndex, answerItemPathExpression, new Coding(null, strOpen.Value), status);
            }
        }

        void ValidateInvariants(QuestionnaireResponse QR, Questionnaire Q, SymbolTable symbolTable, QuestionnaireResponse.ItemComponent item, Questionnaire.ItemComponent itemDef, string[] answerItemPathExpression, QuestionnaireResponse.QuestionnaireResponseStatus status)
        {
            IEnumerable<QuestionnaireInvariant> invariants;
            if (itemDef != null)
            {
                //foreach (var variableExpression in itemDef.variables())
                //{
                //    var values = EvaluateFhirPath(symbolTable, variableExpression, outcome, "variable");
                //    Questionnaire_PrePopulate_Observation.AddVariable(symbolTable, variableExpression.Name, values);
                //}
                invariants = itemDef.Constraints();
            }
            else
                invariants = Q.Constraints();
            if (invariants != null && invariants.Any())
            {
                FhirEvaluationContext ctxt;
                ctxt = new FhirEvaluationContext(QR.ToTypedElement());
                foreach (var invariant in invariants)
                {
                    try
                    {
                        var itemSpecificTable = new SymbolTable(symbolTable);
                        if (itemDef != null)
                        {
                            itemSpecificTable.AddVar("qitem", itemDef.ToTypedElement());
                        }
                        var compiler = new FhirPathCompiler(itemSpecificTable);
                        var expr = compiler.Compile(invariant.Expression);

                        IEnumerable<ITypedElement> result;
                        if (itemDef != null)
                            result = expr(item.ToTypedElement(), ctxt);
                        else
                            result = expr(QR.ToTypedElement(), ctxt);

                        if (result.Count() != 1 || !(bool)result.First().Value)
                        {
                            // TODO: Need to re-evaluate the location paths (if specified)
                            if (invariant.Location.Any())
                            {

                            }
                            ReportValidationMessage(ValidationResult.invariant, itemDef, answerItemPathExpression, status, item, null, invariant, questionaireCanonicalUrl: QR.Questionnaire ?? new CanonicalUrl(Q.Url) { Version = Q.VersionElement }.Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        ReportValidationMessage(ValidationResult.invariantExecution, itemDef, answerItemPathExpression, status, item, null, invariant, ex);
                    }
                }
            }
        }
    }
}
