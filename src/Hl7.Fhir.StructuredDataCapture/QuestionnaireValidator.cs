﻿using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.FhirPath;
using Hl7.FhirPath.Expressions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Hl7.Fhir.StructuredDataCapture.StructuredDataCaptureExtensions;
using Expression = Hl7.Fhir.Model.Expression;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.StructuredDataCapture
{
	/// <summary>
	/// TODO: Other validation options
	/// * When copying for the QuestionnaireValidator refer to FHIR-41196
	///   - validate warning for missing unitOption or unitValueSet on quantity types
	/// *
	/// </summary>
	public class QuestionnaireValidator
	{
		public const string ErrorCodeSystem = "http://fhir.forms-lab.com/CodeSystem/errors";

		public enum ValidationResult
		{
			unknown,

			/// <summary>
			/// A variable has been defined that has no expression
			/// </summary>
			variableNoExpression,

			/// <summary>
			/// A variable has been defined without a name to use in fhirpath expressions
			/// </summary>
			variableHasNoName,

			/// <summary>
			/// The invariant has an invalid fhirpath expression
			/// </summary>
			invalidFhirpathExpression,

			/// <summary>
			/// The fhirquery expression is invalid
			/// </summary>
			invalidFhirQuery,

			/// <summary>
			/// Fhirpath expression refers to a variable that is not defined
			/// </summary>
			undefinedVariable,
			invalidExtensionType,
			sourceQueryNotFound,
			questionnaireRetired,
			invalidRegex,

			// TODO: Add in validation error types as new checks are included
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
		/// <param name="Q"></param>
		/// <param name="itemDefinition"></param>
		/// <param name="locationExpression"></param>
		/// <param name="answerIndex"></param>
		/// <param name="invariant"></param>
		/// <param name="exceptionThrown"></param>
		/// <returns></returns>
		OperationOutcome.IssueComponent ReportValidationMessage(ValidationResult error, Questionnaire Q, Questionnaire.ItemComponent itemDefinition, IEnumerable<string> locationExpression, QuestionnaireInvariant invariant, string fhirpathExpressionText = null, Exception exceptionThrown = null)
		{
			var severity = OperationOutcome.IssueSeverity.Error;
			var code = OperationOutcome.IssueType.Unknown;
			var details = new CodeableConcept(ErrorCodeSystem, error.ToString());
			var fieldDisplayText = itemDefinition?.ShortText() ?? itemDefinition?.Text ?? (itemDefinition?.Code?.FirstOrDefault()?.Display) ?? itemDefinition?.LinkId;
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

				case ValidationResult.questionnaireRetired:
					severity = OperationOutcome.IssueSeverity.Information;
					code = OperationOutcome.IssueType.BusinessRule;
					details.Coding[0].Display = "Questionnaire retired";
					details.Text = $"The Questionnaire has been marked as retired";
					break;

				//case ValidationResult.questionnaireDraft:
				//    severity = OperationOutcome.IssueSeverity.Warning;
				//    code = OperationOutcome.IssueType.BusinessRule;
				//    details.Coding[0].Display = "Questionnaire inactive";
				//    details.Text = $"The Questionnaire is defined as a draft template";
				//    break;

				//case ValidationResult.questionnaireRetired:
				//    severity = OperationOutcome.IssueSeverity.Warning;
				//    code = OperationOutcome.IssueType.BusinessRule;
				//    details.Coding[0].Display = "Questionnaire inactive";
				//    details.Text = $"The Questionnaire has been retired";
				//    break;

				//case ValidationResult.questionnaireInactive:
				//    severity = OperationOutcome.IssueSeverity.Warning;
				//    code = OperationOutcome.IssueType.BusinessRule;
				//    details.Coding[0].Display = "Questionnaire inactive";
				//    details.Text = $"The authored date is outside the permitted period defined in the Questionnaire";
				//    break;

				//case ValidationResult.groupShouldNotHaveAnswers:
				//    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
				//    code = OperationOutcome.IssueType.Structure;
				//    details.Coding[0].Display = "invalid group child items";
				//    details.Text = $"{fieldDisplayText}: The type 'Group' should not use the 'answer' property, use the 'item' property for children";
				//    break;

				//case ValidationResult.invalidType:
				//    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
				//    code = OperationOutcome.IssueType.Structure;
				//    details.Coding[0].Display = "invalid item Type";
				//    details.Text = $"{fieldDisplayText}: The type 'Question' is not selectable - use a specific child item type instead";
				//    break;

				//case ValidationResult.displayAnswer:
				//    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
				//    code = OperationOutcome.IssueType.Structure;
				//    details.Coding[0].Display = "Display has answer";
				//    details.Text = $"{fieldDisplayText}: Display items do not support answers";
				//    break;

				//case ValidationResult.invalidAnswerOption:
				//    code = OperationOutcome.IssueType.BusinessRule;
				//    details.Coding[0].Display = "invalid value";
				//    details.Text = $"{fieldDisplayText}: was not in the set of permitted values";
				//    break;

				//case ValidationResult.required:
				//    code = OperationOutcome.IssueType.Required;
				//    details.Coding[0].Display = "required";
				//    details.Text = $"{fieldDisplayText}: Mandatory field does not have an answer";
				//    break;

				case ValidationResult.invalidFhirpathExpression:
					code = OperationOutcome.IssueType.Exception;
					severity = OperationOutcome.IssueSeverity.Error;
					details.Coding[0].Display = "Invalid fhirpath expression";
					details.Text = $"{fieldDisplayText}: fhirpath expression does not compile";
					diagnostics = $"Expression: {fhirpathExpressionText}\r\nException: {exceptionThrown.Message}";
					break;

				case ValidationResult.invalidRegex:
					code = OperationOutcome.IssueType.Exception;
					severity = OperationOutcome.IssueSeverity.Error;
					details.Coding[0].Display = "Invalid regex expression";
					details.Text = $"{fieldDisplayText}: regex expression does not compile";
					diagnostics = exceptionThrown.Message;
					break;

				//case ValidationResult.invariantExecution:
				//    severity = OperationOutcome.IssueSeverity.Warning; // not sure if this is right...
				//    code = OperationOutcome.IssueType.Invariant;
				//    details.Coding[0].Display = "invalid validation expression";
				//    if (!string.IsNullOrEmpty(fieldDisplayText))
				//        details.Text = $"{fieldDisplayText}: Unable to evaluate custom validation rule {invariant.Human}";
				//    else
				//        details.Text = $"Unable to evaluate custom validation rule {invariant.Human}";
				//    diagnostics = invariant.Expression;
				//    diagnostics = String.Join("\r\n", diagnostics, exceptionThrown.Message);
				//    break;

				//case ValidationResult.invalidNewLine:
				//    severity = OperationOutcome.IssueSeverity.Fatal; // mark corrupt type issues as fatal
				//    code = OperationOutcome.IssueType.BusinessRule;
				//    details.Coding[0].Display = "contains newline";
				//    details.Text = $"{fieldDisplayText}: 'string' type questions cannot contain newline characters";
				//    break;

				//case ValidationResult.tsError:
				//    code = OperationOutcome.IssueType.Exception;
				//    details.Coding[0].Display = "server error";
				//    details.Text = $"{fieldDisplayText}: error checking terminology server";
				//    if (exceptionThrown is FhirOperationException fex)
				//    {
				//        if (fex.Status == System.Net.HttpStatusCode.NotFound)
				//            details.Text = $"{fieldDisplayText}: ValueSet not available on the terminology server";
				//        else
				//        if (fex.Status == System.Net.HttpStatusCode.Unauthorized)
				//            details.Text = $"{fieldDisplayText}: Unauthorized connection to the terminology server";
				//        else
				//            details.Text = $"{fieldDisplayText}: Error checking terminology server (Http Status: {fex.Status})";
				//    }
				//    else
				//    {
				//        diagnostics = String.Join("\r\n", diagnostics, exceptionThrown.Message);
				//    }
				//    break;

				default:
					severity = OperationOutcome.IssueSeverity.Fatal; // mark unknown issues as fatal
					diagnostics = exceptionThrown?.Message;
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

			if (!string.IsNullOrEmpty(diagnostics))
				_settings.Logger?.Log(LogLevel.Debug, diagnostics);

			var result = new OperationOutcome.IssueComponent()
			{
				Severity = severity,
				Code = code,
				Expression = locationExpression,
				Location = new[] { $"linkId='{itemDefinition?.LinkId}'" },
				Details = details,
				Diagnostics = diagnostics
			};
			if (string.IsNullOrEmpty(itemDefinition?.LinkId))
			{
				result.Location = null;
			}

			outcomeIssues.Enqueue(result);
			return result;
		}

		/// <summary>
		/// Convert the value that is provided into a simple message for user display (so the number is more readable)
		/// This should also be translated for multiple languages too
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public string NumericBytesForErrorMessage(int? value)
		{
			if (!value.HasValue)
				return "(unknown) bytes";

			if (value < 1000)
				return $"{value:n0} bytes";

			if (value < 10000000)
				return $"{(value / 1000.0):g3} KB";

			return $"{(value / 1000000.0):g3} MB";
		}

		public QuestionnaireValidator(ValidationSettings settings = null)
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

		public static void AddVariable(Hl7.FhirPath.Expressions.SymbolTable table, string name, IEnumerable<ITypedElement> value)
		{
			table.Add(name, () => { return value; });
		}

		public async Task<OperationOutcome> Validate(Questionnaire q)
		{
			// Check the canonical versioning algorithm and version don't contradict each other
			// Add a warning that the canonical URL is highly recommended
			// if status = published, ensure that has a canonical URL
			// information/warning if derivedFRom isn't a versioned canonical URL
			// Should subjectType and launch context be the same?
			// Check the copyright label is from the set of approved licenses?
			// Should there be some date checks on the approved, review and date etc?
			// definitionBased flag
			// anything needed for the replaces extension?
			// Validate libraries? (from behaviour profile)
			// Check for any cqf-calculatedValue extensions - these must produce the same datatype as the property that they are attached to
			// source/target structure maps?
			// assemble expectation?
			// assembleContext & subQuestionnaire
			// this will also need to actually resolve the canonical to the sub-questionnaire to be able to check that all the names are present when required



			// Report an information message if the questionnaire definition is retired
			if (q.Status == PublicationStatus.Retired)
			{
				ReportValidationMessage(ValidationResult.questionnaireRetired, q, null, new[] { "Questionnaire.status" }, null);
			}

			//// Check that the structure matches
			var symbolTable = new Hl7.FhirPath.Expressions.SymbolTable(Hl7.FhirPath.FhirPathCompiler.DefaultSymbolTable);
			symbolTable.AddVar("questionnaire", q.ToTypedElement());

			// Register any launch contexts
			foreach (var lc in q.LaunchContexts())
			{
				if (string.IsNullOrEmpty(lc.Name))
				{
					// TODO: Path for error nee to be reported.
					ReportValidationMessage(ValidationResult.variableHasNoName, q, null, new[] { "Questionnaire" }, null, null);
					continue;
				}
				AddVariable(symbolTable, lc.Name, ElementNode.EmptyList); // the type of this will be in lc.Type
			}

			// Register a sourceQuery
			foreach (var sq in q.SourceQueries())
			{
				var sqBundle = q.Contained.Where(c => "#" + c.Id == sq.Reference);
				if (!sqBundle.Any())
				{
					// TODO: Path for error nee to be reported.
					ReportValidationMessage(ValidationResult.sourceQueryNotFound, q, null, new[] { "Questionnaire" }, null, null);
				}
				foreach (var b in sqBundle)
				{
					symbolTable.AddVar(b.Id, b.ToTypedElement());
				}
			}

			// AssembleContext (shame this doesn't provide the expected type for this)
			foreach (var ext in q.Extension.Where(ext => ext.Url == "http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-assembleContext"))
			{
				var pathExpression = $"Questionnaire.extension[{q.Extension.IndexOf(ext)}]";
				if (ext.Value is FhirString fs)
				{
					if (!string.IsNullOrEmpty(fs.Value))
					{
						// Add the context to the symbol table so that it can be found in expressions down the tree
						AddVariable(symbolTable, fs.Value, ElementNode.EmptyList);
					}
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, q, null, new[] { pathExpression }, null, null, null);
				}
			}

			// Register any variable, candidate expression && item population contexts
			foreach (var expr in q.Extension.Where(ext => _namedExpressionExtensions.Contains(ext.Url)).Select(ext => ext.Value as Expression))
			{
				var pathExpression = $"Questionnaire.extension[{q.Extension.IndexOf(q.Extension.First(e => e.Value == expr))}]";
				ValidateExpression(expr, q, symbolTable, pathExpression, null, true);

				if (!string.IsNullOrEmpty(expr.Expression_) && !string.IsNullOrEmpty(expr.Name))
				{
					// Add the context to the symbol table so that it can be found in expressions down the tree
					AddVariable(symbolTable, expr.Name, ElementNode.EmptyList);
				}
			}

			ValidateItems(q, symbolTable, "Questionnaire.item", q.Item);

			// check that all the top level invariants/extensions all pass
			ValidateConstraints(q, symbolTable, null, "Questionnaire");

			// await for any background tasks to complete
			if (AsyncValidations.Any())
			{
				await Task.WhenAll(AsyncValidations);
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

		List<string> _namedExpressionExtensions = new List<string>(new[] {
			"http://hl7.org/fhir/StructureDefinition/variable",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-candidateExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemPopulationContext",
		});

		List<string> _expressionExtensions = new List<string>(new[] {
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-answerExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-initialExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-contextExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-calculatedExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-enableWhenExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-answerOptionsToggleExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemExtractionContext",
		});

		private void ValidateItems(Questionnaire Q, SymbolTable symbolTable, string pathExpression, List<Questionnaire.ItemComponent> itemDefinitions)
		{
			foreach (var itemDef in itemDefinitions)
			{
				ValidateItem(Q, symbolTable, $"{pathExpression}[{itemDefinitions.IndexOf(itemDef)}]", itemDef);
			}
		}

		private void ValidateItem(Questionnaire Q, SymbolTable symbolTable, string itemPathExpression, Questionnaire.ItemComponent itemDef)
		{
			// System.Diagnostics.Trace.WriteLine($"Validating item '{itemDef.LinkId}' - {itemDef.Text}");
			var itemSymbolTable = new SymbolTable(symbolTable);
			AddVariable(itemSymbolTable, "qitem", ElementNode.EmptyList);

			// Process all the expression based details
			// http://build.fhir.org/ig/HL7/sdc/expressions.html
			// Validate and register any variable, candidate expression && item population contexts
			foreach (var expr in itemDef.Extension.Where(ext => _namedExpressionExtensions.Contains(ext.Url)).Select(ext => ext.Value as Expression))
			{
				var pathExpression = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(itemDef.Extension.First(e => e.Value == expr))}]";
				ValidateExpression(expr, Q, symbolTable, pathExpression, itemDef, true);

				if (!string.IsNullOrEmpty(expr.Expression_) && !string.IsNullOrEmpty(expr.Name))
				{
					// Add the context to the symbol table so that it can be found in expressions down the tree
					AddVariable(symbolTable, expr.Name, ElementNode.EmptyList);
				}
			}

			// Validate all the other expression extensions (except constraint)
			foreach (var ext in itemDef.Extension.Where(ext => _expressionExtensions.Contains(ext.Url)))
			{
				string extPath = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(ext)}]";
				if (ext.Value is Hl7.Fhir.Model.Expression expr)
				{
					ValidateExpression(expr, Q, symbolTable, extPath, itemDef, false);
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, Q, itemDef, new[] { extPath }, null, null);
				}
			}

			// constraint http://hl7.org/fhir/StructureDefinition/questionnaire-constraint
			ValidateConstraints(Q, symbolTable, itemDef, itemPathExpression);

			// Validate any regex expressions will compile (are valid)
			foreach (var extensionRegex in itemDef.Extension.Where(ext => ext.Url == "http://hl7.org/fhir/StructureDefinition/regex"))
			{
				string extPath = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(extensionRegex)}]";
				if (extensionRegex.Value is FhirString regex)
				{
					try
					{
						Regex.Match("", regex.Value);
					}
					catch (Exception ex)
					{
						ReportValidationMessage(ValidationResult.invalidRegex, Q, itemDef, new[] { extPath }, null, null, ex);
					}
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, Q, itemDef, new[] { extPath }, null, null);
				}
			}

			/// * When copying for the QuestionnaireValidator refer to FHIR-41196
			///   - validate warning for missing unitOption or unitValueSet on quantity types

			// check repeats/mandatory/min count/max count
			//if (item.Answer.Count > 1 && itemDef.Repeats != true)
			//{
			//    // too many responses (for non repeating item)
			//    ReportValidationMessage(ValidationResult.repeats, itemDef, new[] { pathExpression }, status, item, null, null);
			//}
			//if (item.Answer.Count == 0 && itemDef.Required == true)
			//{
			//    // Mandatory
			//    ReportValidationMessage(ValidationResult.required, itemDef, new[] { pathExpression }, status, item, null, null);
			//}
			//var minOccurs = itemDef.MinOccurs();
			//if (minOccurs.HasValue && item.Answer.Count < minOccurs.Value)
			//{
			//    // not enough answers
			//    ReportValidationMessage(ValidationResult.minCount, itemDef, new[] { pathExpression }, status, item, null, null);
			//}

			//// May need to move the invariant processing up to here

			//// This was a Fake Item introduced to check for Mandatory/min count child items
			//// so bail any further testing
			//if (item is FakeItem) return;

			//var maxOccurs = itemDef.MaxOccurs();
			//if (maxOccurs.HasValue && item.Answer.Count > maxOccurs.Value)
			//{
			//    // too many answers
			//    ReportValidationMessage(ValidationResult.maxCount, itemDef, new[] { pathExpression }, status, item, null, null);
			//}
			//if (itemDef.Type == Questionnaire.QuestionnaireItemType.Display && item.Answer.Count > 0)
			//{
			//    // Display Items should't have answers
			//    ReportValidationMessage(ValidationResult.displayAnswer, itemDef, new[] { pathExpression }, status, item, null, null);
			//}
			//if (itemDef.Type == Questionnaire.QuestionnaireItemType.Question)
			//{
			//    // "Question" Items should't be used
			//    ReportValidationMessage(ValidationResult.invalidType, itemDef, new[] { pathExpression }, status, item, null, null);
			//}

			// process any child items too
			if (itemDef.Item != null)
			{
				ValidateItems(Q, itemSymbolTable, $"{itemPathExpression}.item", itemDef.Item);
			}
		}

		void ValidateExpression(Hl7.Fhir.Model.Expression expr, Questionnaire Q, SymbolTable symbolTable, string pathExpression, Questionnaire.ItemComponent itemDef, bool requiresName)
		{
			if (string.IsNullOrEmpty(expr.Expression_))
			{
				ReportValidationMessage(ValidationResult.variableNoExpression, Q, itemDef, new[] { pathExpression }, null, null);
			}
			else
			{
				if (expr.Language == "text/fhirpath")
				{
					// Validate this fhirpath expression
					FhirPathCompiler fpc = new FhirPathCompiler(symbolTable);
					try
					{
						fpc.Compile(expr.Expression_);
					}
					catch (Exception ex)
					{
						ReportValidationMessage(ValidationResult.invalidFhirpathExpression, Q, itemDef, new[] { pathExpression + ".expression" }, null, expr.Expression_, ex);
					}
				}
				if (expr.Language == "application/x-fhir-query")
				{
					// validate this fhir-query expression
					// parse out any embedded fhirpath expressions, and use those
					var matches = Regex.Matches(expr.Expression_, @"\{\{.*?\}\}");
					foreach (Match m in matches)
					{
						var expression = m.Value.Substring(2, m.Value.Length - 4);
						FhirPathCompiler fpc = new FhirPathCompiler(symbolTable);
						try
						{
							fpc.Compile(expression);
						}
						catch (Exception ex)
						{
							ReportValidationMessage(ValidationResult.invalidFhirpathExpression, Q, itemDef, new[] { pathExpression + ".expression" }, null, expression, ex);
						}
					}
				}
			}

			if (requiresName)
			{
				if (string.IsNullOrEmpty(expr.Name))
				{
					ReportValidationMessage(ValidationResult.variableHasNoName, Q, itemDef, new[] { pathExpression }, null, null);
				}
			}
		}

		void ValidateConstraints(Questionnaire Q, SymbolTable symbolTable, Questionnaire.ItemComponent itemDef, string pathToConstraint)
		{
			IExtendable context = (IExtendable)itemDef ?? Q;
			foreach (var inv in StructuredDataCaptureExtensions.ConstraintExtensions(context))
			{
				var pathToConstraintExpression = $"{pathToConstraint}.extension[{context.Extension.IndexOf(inv.sourceExtension)}]";

				if (string.IsNullOrEmpty(inv.Expression))
				{
					// No expression defined, so can't exactly test anything ;) 
					ReportValidationMessage(ValidationResult.variableNoExpression, Q, itemDef, new[] { pathToConstraintExpression }, inv);
				}
				else
				{
					// Validate this fhirpath expression
					FhirPathCompiler fpc = new FhirPathCompiler(symbolTable);
					try
					{
						fpc.Compile(inv.Expression);
					}
					catch (Exception ex)
					{
						var indexOfExpression = inv.sourceExtension.Extension.IndexOf(inv.sourceExtension.Extension.First(ext => ext.Url == "expression"));
						ReportValidationMessage(ValidationResult.invalidFhirpathExpression, Q, itemDef, new[] { $"{pathToConstraintExpression}.extension[{indexOfExpression}]" }, inv, inv.Expression, ex);
					}
				}
			}
		}

		/*
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



		*/
	}
}