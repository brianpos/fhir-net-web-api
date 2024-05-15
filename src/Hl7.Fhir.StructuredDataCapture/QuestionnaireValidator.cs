using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath.Validator;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Utility;
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
			/// <summary>
			/// This type should never be used, and is the catchall '0' case
			/// </summary>
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
			/// Extended fhirpath validation checking failed
			/// </summary>
			invalidFhirpathExpressionTypes,

			/// <summary>
			/// The constraint fhirpath expression does not return a boolean value
			/// </summary>
			invalidConstraint,

			/// <summary>
			/// Fhirpath expression refers to a variable that is not defined
			/// </summary>
			undefinedVariable,

			/// <summary>
			/// A variable with the same name has already been defined for this item/context
			/// </summary>
			duplicateVariable,

			/// <summary>
			/// An expression extension was provided that did not use an expression datatype
			/// </summary>
			invalidExtensionType,

			/// <summary>
			/// The source query bundle was not able to be resolved
			/// </summary>
			sourceQueryNotFound,

			/// <summary>
			/// Simple information message that this resource has been retired
			/// </summary>
			questionnaireRetired,

			/// <summary>
			/// The regex expression doesn't compile
			/// </summary>
			invalidRegex,

			/// <summary>
			/// x-fhir-query provided that has no filter criteria on an open search!
			/// </summary>
			xpathQueryNoFilter,

			/// <summary>
			/// The expression language is unknown (fhirpath, CQL, x-fhir-query)
			/// </summary>
			unknownExpressionLanguage,

			/// <summary>
			/// The enableWhen question is not found in the questionnaire
			/// </summary>
			enableWhenQuestionNotFound,

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

				case ValidationResult.sourceQueryNotFound:
					severity = OperationOutcome.IssueSeverity.Error;
					code = OperationOutcome.IssueType.NotFound;
					details.Coding[0].Display = "Source Query not found";
					details.Text = $"The Source Query not found";
					break;

				case ValidationResult.invalidExtensionType:
					severity = OperationOutcome.IssueSeverity.Error;
					code = OperationOutcome.IssueType.Structure;
					details.Coding[0].Display = "invalid extension value type";
					details.Text = $"{fieldDisplayText}: An unexpected extension value type was encountered.";
					if (exceptionThrown is ExtensionValidationMessageException evme)
					{
						details.Text = $"{fieldDisplayText}: Extension {evme.Url} requires type: '{evme.TypeRequired}',  found: '{evme.TypeUsed}'";
					}
					break;

				case ValidationResult.variableNoExpression:
					severity = OperationOutcome.IssueSeverity.Error;
					code = OperationOutcome.IssueType.Value;
					details.Coding[0].Display = "Missing expression";
					details.Text = $"{fieldDisplayText}: No expression has been provided";
					break;

				case ValidationResult.variableHasNoName:
					severity = OperationOutcome.IssueSeverity.Error;
					code = OperationOutcome.IssueType.Value;
					details.Coding[0].Display = "Missing name";
					details.Text = $"{fieldDisplayText}: Variable requires a name";
					break;

				case ValidationResult.duplicateVariable:
					severity = OperationOutcome.IssueSeverity.Error;
					code = OperationOutcome.IssueType.BusinessRule;
					details.Coding[0].Display = "duplicate variable";
					if (exceptionThrown is ValidationMessageException vmeDv)
					{
						details.Text = $"{fieldDisplayText}: A duplicate variable name '{vmeDv.VariableName}' has been defined";
						diagnostics = $"All defined local variables: '{string.Join("', '", vmeDv.SymbolTable.LocalVariableNames())}'";
					}
					break;

				case ValidationResult.invalidFhirpathExpression:
					code = OperationOutcome.IssueType.Exception;
					severity = OperationOutcome.IssueSeverity.Error;
					details.Coding[0].Display = "Invalid fhirpath expression (grammar)";
					details.Text = $"{fieldDisplayText}: fhirpath expression does not compile";
					diagnostics = $"Expression: {fhirpathExpressionText}\r\nException: {exceptionThrown?.Message ?? "(null)"}";
					break;

				case ValidationResult.invalidConstraint:
					code = OperationOutcome.IssueType.Value;
					severity = OperationOutcome.IssueSeverity.Error;
					details.Coding[0].Display = "Expression does not return a boolean";
					details.Text = $"{fieldDisplayText}: Constraint expression does not return a boolean value";
					if (exceptionThrown is ValidationMessageException vme)
						diagnostics = $"Expression: {fhirpathExpressionText}\r\nExpression returns: {vme.ReturnType}";
					break;

				case ValidationResult.invalidFhirpathExpressionTypes:
					code = OperationOutcome.IssueType.Invalid;
					severity = OperationOutcome.IssueSeverity.Error;
					details.Coding[0].Display = "Invalid fhirpath expression (types)";
					details.Text = $"{fieldDisplayText}: fhirpath expression returns unexpected type";
					diagnostics = $"Expression: {fhirpathExpressionText}";
					if (exceptionThrown != null)
						diagnostics += $"\r\nException: {exceptionThrown?.Message ?? "(null)"}";
					break;

				case ValidationResult.invalidRegex:
					code = OperationOutcome.IssueType.Exception;
					severity = OperationOutcome.IssueSeverity.Error;
					details.Coding[0].Display = "Invalid regex expression";
					details.Text = $"{fieldDisplayText}: regex expression does not compile";
					diagnostics = exceptionThrown.Message;
					break;

				case ValidationResult.xpathQueryNoFilter:
					code = OperationOutcome.IssueType.Value;
					severity = OperationOutcome.IssueSeverity.Warning;
					details.Coding[0].Display = "x-fhir-query expression has no query parameters";
					details.Text = $"{fieldDisplayText}: x-fhir-query expression does not contain any query parameters - may return more data than desired (unless something constrains output - such as security)";
					diagnostics = $"Expression: {fhirpathExpressionText}";
					break;

				case ValidationResult.unknownExpressionLanguage:
					code = OperationOutcome.IssueType.Value;
					severity = OperationOutcome.IssueSeverity.Warning;
					details.Coding[0].Display = "x-fhir-query unknown expression language";
					details.Text = $"{fieldDisplayText}: x-fhir-query unknown expression language";
					diagnostics = exceptionThrown?.Message;
					break;

				case ValidationResult.enableWhenQuestionNotFound:
					code = OperationOutcome.IssueType.NotFound;
					severity = OperationOutcome.IssueSeverity.Error;
					if (exceptionThrown is EnableWhenValidationMessageException ewe) // always should be
					{
						details.Coding[0].Display = $"EnableWhen refers to a question '{ewe.EnableWhen.Question}' that doesn't exist";
						details.Text = $"{fieldDisplayText}: enableWhen refers to question '{ewe.EnableWhen.Question}' that doesn't exist";
					}
					break;

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

			if (details.Text?.StartsWith(":") == true)
				details.Text = details.Text.TrimStart(new char[] { ' ', ':' });

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
			_source = new CachedResolver(ZipSource.CreateValidationSource());
		}

		public QuestionnaireValidator(IResourceResolver source, ValidationSettings settings = null)
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
			_source = source;
		}
		IResourceResolver _source;
		ValidationSettings _settings;
		List<Task> AsyncValidations = new List<System.Threading.Tasks.Task>();
		ConcurrentQueue<OperationOutcome.IssueComponent> outcomeIssues = new ConcurrentQueue<OperationOutcome.IssueComponent>();

		private int DateCompare(string date1, string date2)
		{
			if (string.IsNullOrEmpty(date1) || string.IsNullOrEmpty(date2)) return 0;
			int minPrecision = Math.Min(date1.Length, date2.Length);
			return String.Compare(date1.Substring(0, minPrecision), date2.Substring(0, minPrecision));
		}

		public static void AddFakeFunction(TypedVariableSymbolTable table, string name)
		{
			table.Add(name, (IEnumerable<ITypedElement> f) => { return ElementNode.EmptyList; }, doNullProp: true);
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

			// Before doing the validations index the linkIds so that expression checking has direct access to the items.
			IndexItems(q.Item, _itemsByLinkId);


			// Report an information message if the questionnaire definition is retired
			if (q.Status == PublicationStatus.Retired)
			{
				ReportValidationMessage(ValidationResult.questionnaireRetired, q, null, new[] { "Questionnaire.status" }, null);
			}

			// Check that the structure matches
			var symbolTable = new TypedVariableSymbolTable(Hl7.FhirPath.FhirPathCompiler.DefaultSymbolTable);
			// Register the SDC specific functions/variables
			// from http://build.fhir.org/ig/HL7/sdc/expressions.html#fhirpath-supplements
			symbolTable.AddVar("questionnaire", q.ToTypedElement(), typeof(Questionnaire));
			AddFakeFunction(symbolTable, "answers");
			AddFakeFunction(symbolTable, "ordinal");
			AddFakeFunction(symbolTable, "sum");
			AddFakeFunction(symbolTable, "min");
			AddFakeFunction(symbolTable, "max");
			// AddVariable(symbolTable, "count"); Isn't this already a function?
			AddFakeFunction(symbolTable, "avg");

			// Register any launch contexts
			foreach (var lc in q.LaunchContexts())
			{
				var lcExtensionIndex = q.Extension.IndexOf(lc.sourceExtension);
				if (string.IsNullOrEmpty(lc.Name))
				{
					ReportValidationMessage(ValidationResult.variableHasNoName, q, null, new[] { $"Questionnaire.extension[{lcExtensionIndex}]" }, null, null);
					continue;
				}
				if (!symbolTable.HasLocalVariable(lc.Name))
					symbolTable.AddVar(lc.Name, ElementNode.EmptyList, ModelInfo.ModelInspector.FindClassMapping(lc.Type.Value)); // the type of this will be in lc.Type
				else
					ReportValidationMessage(ValidationResult.duplicateVariable, q, null, new[] { $"Questionnaire.extension[{lcExtensionIndex}]" }, null, null, new ValidationMessageException() { VariableName = lc.Name, SymbolTable = symbolTable });
			}

			// Register a sourceQuery
			foreach (var sq in q.SourceQueries())
			{
				int sqIndex = q.Extension.IndexOf(sq.Annotation<Extension>());
				var sqBundle = q.Contained.Where(c => "#" + c.Id == sq.Reference);
				if (!sqBundle.Any())
				{
					// TODO: Path for error nee to be reported.
					ReportValidationMessage(ValidationResult.sourceQueryNotFound, q, null, new[] { $"Questionnaire.extension[{sqIndex}]" }, null, null);
				}
				foreach (var b in sqBundle)
				{
					if (!symbolTable.HasLocalVariable(b.Id))
						symbolTable.AddVar(b.Id, b.ToTypedElement(), typeof(Bundle));
					else
						ReportValidationMessage(ValidationResult.duplicateVariable, q, null, new[] { $"Questionnaire.extension[{sqIndex}]" }, null, null, new ValidationMessageException() { VariableName = b.Id, SymbolTable = symbolTable });
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
						if (!symbolTable.HasLocalVariable(fs.Value))
							symbolTable.AddVar(fs.Value, ElementNode.EmptyList);
						else
							ReportValidationMessage(ValidationResult.duplicateVariable, q, null, new[] { pathExpression }, null, null, new ValidationMessageException() { VariableName = fs.Value, SymbolTable = symbolTable });
					}
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, q, null, new[] { pathExpression }, null, null, new ExtensionValidationMessageException("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-assembleContext", "string", ext.Value?.TypeName ?? "(null)"));
				}
			}

			// Register any variable, candidate expression && item population contexts
			foreach (var ext in q.Extension.Where(ext => _namedExpressionExtensions.Contains(ext.Url)))
			{
				var expr = ext.Value as Expression;
				var pathExpression = $"Questionnaire.extension[{q.Extension.IndexOf(ext)}]";
				var expressionResultTypes = ValidateExpression(expr, q, symbolTable, pathExpression, null, ext.Url != candidateExpressionUrl);

				if (!string.IsNullOrEmpty(expr.Expression_) && !string.IsNullOrEmpty(expr.Name))
				{
					// Add the context to the symbol table so that it can be found in expressions down the tree
					if (!symbolTable.HasLocalVariable(expr.Name))
						symbolTable.AddVar(expr.Name, ElementNode.EmptyList, expressionResultTypes);
					else
						ReportValidationMessage(ValidationResult.duplicateVariable, q, null, new[] { pathExpression }, null, null, new ValidationMessageException() { VariableName = expr.Name, SymbolTable = symbolTable });
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

		const string candidateExpressionUrl = "http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-candidateExpression";
		readonly List<string> _namedExpressionExtensions = new List<string>(new[] {
			candidateExpressionUrl,
			"http://hl7.org/fhir/StructureDefinition/variable",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemPopulationContext",
		});

		readonly List<string> _expressionExtensions = new List<string>(new[] {
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-answerExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-initialExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-contextExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-calculatedExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-enableWhenExpression",
			"http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemExtractionContext",
		});

		private void ValidateItems(Questionnaire Q, TypedVariableSymbolTable symbolTable, string pathExpression, List<Questionnaire.ItemComponent> itemDefinitions)
		{
			foreach (var itemDef in itemDefinitions)
			{
				ValidateItem(Q, symbolTable, $"{pathExpression}[{itemDefinitions.IndexOf(itemDef)}]", itemDef);
			}
		}

		private void ValidateItem(Questionnaire Q, TypedVariableSymbolTable parentSymbolTable, string itemPathExpression, Questionnaire.ItemComponent itemDef)
		{
			// Validate native properties
			// Should this one actually be an invariant?
			foreach (var ew in itemDef.EnableWhen)
			{
				// Ensure that the question being referenced exists (by LinkId)
				if (!_itemsByLinkId.ContainsKey(ew.Question))
				{
					// No such question exists!
					ReportValidationMessage(ValidationResult.enableWhenQuestionNotFound, 
						Q, null, new[] { $"{itemPathExpression}.enableWhen[{itemDef.EnableWhen.IndexOf(ew)}].question" }, null, null, new EnableWhenValidationMessageException(ew));
				}
			}

			// System.Diagnostics.Trace.WriteLine($"Validating item '{itemDef.LinkId}' - {itemDef.Text}");
			var itemSymbolTable = new TypedVariableSymbolTable(parentSymbolTable);
			itemSymbolTable.AddVar("qitem", ElementNode.EmptyList, typeof(QuestionnaireResponse.ItemComponent));

			// Process all the expression based details
			// http://build.fhir.org/ig/HL7/sdc/expressions.html
			// Validate and register any variable, candidate expression && item population contexts
			foreach (var ext in itemDef.Extension.Where(ext => _namedExpressionExtensions.Contains(ext.Url)))
			{
				string extPath = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(ext)}]";
				if (ext.Value is Hl7.Fhir.Model.Expression expr)
				{
					if (String.Compare(expr.Language, "text/CQL", true) == 0)
						continue;
					var pathExpression = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(itemDef.Extension.First(e => e.Value == expr))}]";
					var expressionReturnTypes = ValidateExpression(expr, Q, itemSymbolTable, pathExpression, itemDef, ext.Url != candidateExpressionUrl);

					if (string.IsNullOrEmpty(expr.Language)) {
						// No expression defined, so can't exactly test anything ;) 
						ReportValidationMessage(ValidationResult.variableNoExpression, Q, itemDef, new[] { pathExpression }, null);
					}
					else if (!string.IsNullOrEmpty(expr.Name))
					{
						// Add the context to the symbol table so that it can be found in expressions down the tree
						if (!itemSymbolTable.HasLocalVariable(expr.Name))
							itemSymbolTable.AddVar(expr.Name, ElementNode.EmptyList, expressionReturnTypes);
						else
						{
							ReportValidationMessage(ValidationResult.duplicateVariable, Q, itemDef, new[] { pathExpression }, null, null, new ValidationMessageException() { VariableName = expr.Name, SymbolTable = itemSymbolTable });
						}
					}
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, Q, itemDef, new[] { extPath }, null, null, new ExtensionValidationMessageException(ext.Url, "Expression", ext.Value?.TypeName ?? "(null)"));
				}
			}

			// Validate all the other expression extensions (except constraint)
			foreach (var ext in itemDef.Extension.Where(ext => _expressionExtensions.Contains(ext.Url)))
			{
				string extPath = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(ext)}]";
				if (ext.Value is Hl7.Fhir.Model.Expression expr)
				{
					ValidateExpression(expr, Q, itemSymbolTable, extPath, itemDef, false);
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, Q, itemDef, new[] { extPath }, null, null, new ExtensionValidationMessageException(ext.Url, "Expression", ext.Value?.TypeName ?? "(null)"));
				}
			}
			const string aote = "http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-answerOptionsToggleExpression";
			foreach (var ext in itemDef.Extension.Where(ext => ext.Url == aote))
			{
				string extPath = $"{itemPathExpression}.extension[{itemDef.Extension.IndexOf(ext)}]";
				// it's in a child expression of this one
				var exprExtension = ext.GetExtension("expression");
				if (exprExtension != null)
					extPath += $".extension[{ext.Extension.IndexOf(exprExtension)}]";

				if (exprExtension?.Value is Hl7.Fhir.Model.Expression expr)
				{
					ValidateExpression(expr, Q, itemSymbolTable, extPath, itemDef, false);
				}
				else
				{
					ReportValidationMessage(ValidationResult.invalidExtensionType, Q, itemDef, new[] { extPath }, null, null, new ExtensionValidationMessageException(ext.Url, "Expression", ext.Value?.TypeName ?? "(null)"));
				}
			}

			// constraint http://hl7.org/fhir/StructureDefinition/questionnaire-constraint
			ValidateConstraints(Q, itemSymbolTable, itemDef, itemPathExpression);

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
					ReportValidationMessage(ValidationResult.invalidExtensionType, Q, itemDef, new[] { extPath }, null, null, new ExtensionValidationMessageException(extensionRegex.Url, "Expression", extensionRegex.Value?.TypeName ?? "(null)"));
				}
			}

			// * When copying for the QuestionnaireValidator refer to FHIR-41196
			//   - validate warning for missing unitOption or unitValueSet on quantity types


			// process any child items too
			if (itemDef.Item != null)
			{
				ValidateItems(Q, itemSymbolTable, $"{itemPathExpression}.item", itemDef.Item);
			}
		}

		FhirPathVisitorProps ValidateExpression(Hl7.Fhir.Model.Expression expr, Questionnaire Q, TypedVariableSymbolTable symbolTable, string pathExpression, Questionnaire.ItemComponent itemDef, bool requiresName)
		{
			FhirPathVisitorProps result = null;
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
						result = ValidateFhirPathExpressionValidity(Q, symbolTable, itemDef, new[] { pathExpression + ".expression" }, $"Name='{expr.Name}'", expr.Expression_, fpc);
						// TODO: Now check if the output is of the correct type
					}
					catch (Exception ex)
					{
						ReportValidationMessage(ValidationResult.invalidFhirpathExpression, Q, itemDef, new[] { pathExpression + ".expression" }, null, expr.Expression_, ex);
					}
				}
				else if (expr.Language == "application/x-fhir-query")
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
							var partType = ValidateFhirPathExpressionValidity(Q, symbolTable, itemDef, new[] { pathExpression + ".expression" }, $"Name='{expr.Name}'", expression, fpc);
							// Verify if this is one of the acceptable formats according to
							// http://hl7.org/fhir/uv/sdc/STU3/expressions.html#x-fhir-query-enhancements
							List<string> xfhirquerytypes = new List<string>() { "string", "coding", "identifier", "reference", "Quantity" };
							if (!xfhirquerytypes.Any(t => partType.CanBeOfType(t)))
							{
								// x-fhir-query fragments need to return a string to be injected into the query string.
								ReportValidationMessage(ValidationResult.invalidFhirpathExpressionTypes, Q, itemDef, new[] { pathExpression + ".expression" }, null, expression, new ValidationMessageException($"Requires type: string\r\nReturns: {partType}"));
							}
						}
						catch (Exception ex)
						{
							ReportValidationMessage(ValidationResult.invalidFhirpathExpression, Q, itemDef, new[] { pathExpression + ".expression" }, null, expression, ex);
						}
					}

					// Infer what return type this query variable should contain.
					// is it a search, or a get of a single resource?
					result = new FhirPathVisitorProps();
					var replacedQuery = Regex.Replace(expr.Expression_, @"\{\{.*?\}\}", "example");
					var uriQuery = new Uri(replacedQuery, UriKind.RelativeOrAbsolute);
					if (!uriQuery.IsAbsoluteUri)
						uriQuery = new Uri("http://example.org/" + uriQuery.OriginalString);
					var queryParams = uriQuery.Query;

					// Check if there is a valid resource type in the query (yup, this is wrong, need to calc the segments correctly)
					string resourceType = null; // the default type
					string resourceId = null;
					foreach (var segment in uriQuery.Segments)
					{
						if (ModelInfo.SupportedResources.Contains(segment.TrimEnd('/')))
						{
							resourceType = segment.TrimEnd('/');
						}
						else
						{
							if (resourceType != null && !segment.StartsWith("$") && !segment.StartsWith("_history"))
							{
								resourceId = segment.TrimEnd('/');
							}
						}
					}
					var segments = uriQuery.Segments.Where(s => ModelInfo.SupportedResources.Contains(s.TrimEnd('/'))).ToList();
					var segmentfiltered = uriQuery.Segments.Where(s => ModelInfo.SupportedResources.Contains(s.TrimEnd('/'))).ToList();
					if (segmentfiltered.Any())
						resourceType = segmentfiltered.First().TrimEnd('/');

					if (uriQuery.AbsolutePath.Contains("$"))
					{
						// This is an operation!
						string opName = uriQuery.Segments.Last();
						var OpResultTypeName = opName.Substring(1).ToLower() switch
						{
							"validate" => "OperationOutcome",
							"meta" => "Parameters",
							"meta-add" => "Parameters",
							"meta-delete" => "Parameters",
							"convert" => "Resource", // can't do any better than this
							"graphql" => "Bundle",

							// Large Resource ops
							"add" => resourceType,
							"remove" => resourceType,
							"filter" => resourceType,
							"current-canonical" => resourceType,

							// Resource based ops
							"apply" => "Resource", // can't do any better than this
							"subset" => "CapabilityStatement",
							"implements" => "OperationOutcome",
							"conforms" => "OperationOutcome,CapabilityStatement",
							"versions" => "Parameters",
							"lookup" => "Parameters",
							"validate-code" => "Parameters",
							"subsumes" => "Parameters,OperationOutcome",
							"find-matches" => "Parameters",
							"document" => "Bundle",
							"translate" => "Parameters",
							"generate" => "Bundle",
							"docref" => "Bundle",
							"everything" => "Bundle",
							"find" => "Bundle",
							"evaluate-measure" => "Bundle",
							"care-gaps" => "Bundle",
							"lastn" => "Bundle",
							"stats" => "Parameters",
							"match" => "Bundle",
							"transform" => "Resource",  // can't do any better than this
							"expand" => "ValueSet",

							// The default
							_ => "Bundle"
						};
						foreach (var t in OpResultTypeName.Split(','))
						{
							result.AddType(ModelInfo.ModelInspector, ModelInfo.ModelInspector.GetTypeForFhirType(t));
						}
					}
					else
					{
						if (resourceId != null)
							result.AddType(ModelInfo.ModelInspector, ModelInfo.ModelInspector.GetTypeForFhirType(resourceType));
						else
						{
							// for now assume it is a search and hence a bundle being returned
							result.AddType(ModelInfo.ModelInspector, typeof(Bundle));

							// if there are no parameters, create a warning that the query being applied has no filter applied
							// and may return more than is desired
							if (string.IsNullOrEmpty(queryParams))
							{
								ReportValidationMessage(ValidationResult.xpathQueryNoFilter, Q, itemDef, new[] { pathExpression + ".expression" }, null, expr.Expression_);
							}
						}
					}
				}
				else if (expr.Language == "text/CQL")
				{
					// these are ok, we can just skip these
				}
				else
				{
					// unknown language provided
					ReportValidationMessage(ValidationResult.unknownExpressionLanguage, Q, itemDef, new[] { pathExpression + ".expression" }, null, expr.Expression_, new ExtensionValidationMessageException("Language: " + expr.Language));
				}
			}

			if (requiresName)
			{
				if (string.IsNullOrEmpty(expr.Name))
				{
					ReportValidationMessage(ValidationResult.variableHasNoName, Q, itemDef, new[] { pathExpression }, null, null);
				}
			}
			return result;
		}

		void ValidateConstraints(Questionnaire Q, TypedVariableSymbolTable symbolTable, Questionnaire.ItemComponent itemDef, string pathToConstraint)
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
					var indexOfExpression = inv.sourceExtension.Extension.IndexOf(inv.sourceExtension.Extension.First(ext => ext.Url == "expression"));
					try
					{
						fpc.Compile(inv.Expression);
						FhirPathVisitorProps result = ValidateFhirPathExpressionValidity(Q, symbolTable, itemDef, new[] { $"{pathToConstraintExpression}.extension[{indexOfExpression}]" }, $"Invariant={inv.Key}", inv.Expression, fpc);

						// Now check if the resulting output type  is a boolean, as that's what invariants need to have
						if (result.ToString() != "boolean")
						{
							// This is not a valid invariant style expression
							var exVal = new ValidationMessageException() { ReturnType = result.ToString() };
							ReportValidationMessage(ValidationResult.invalidConstraint, Q, itemDef, new[] { $"{pathToConstraintExpression}.extension[{indexOfExpression}]" }, inv, inv.Expression, exVal);
						}
					}
					catch (Exception ex)
					{
						// The questionnaire constraint doesn't use the `expression` datatype, so we need to refer to the correct complex extension part
						ReportValidationMessage(ValidationResult.invalidFhirpathExpression, Q, itemDef, new[] { $"{pathToConstraintExpression}.extension[{indexOfExpression}]" }, inv, inv.Expression, ex);
					}
				}
			}
		}

		public Dictionary<string, Questionnaire.ItemComponent> _itemsByLinkId = new Dictionary<string, Questionnaire.ItemComponent>();

		public static Dictionary<string, Questionnaire.ItemComponent> IndexItems(Questionnaire q)
		{
			var itemsByLinkId = new Dictionary<string, Questionnaire.ItemComponent>();
			IndexItems(q.Item, itemsByLinkId);
			return itemsByLinkId;
		}

		private static void IndexItems(List<Questionnaire.ItemComponent> items, Dictionary<string, Questionnaire.ItemComponent> itemsByLinkId)
		{
			foreach (var item in items)
			{
				if (!itemsByLinkId.ContainsKey(item.LinkId))
				{
					itemsByLinkId.Add(item.LinkId, item);
				}
				else
				{
					// There are duplicate linkIds in the questionnaire!
				}

				if (item.Item.Any())
					IndexItems(item.Item, itemsByLinkId);
			}
		}

		private FhirPathVisitorProps ValidateFhirPathExpressionValidity(Questionnaire Q, TypedVariableSymbolTable symbolTable, Questionnaire.ItemComponent itemDef, string[] pathToExpressionForError, string name, string expression, FhirPathCompiler fpc)
		{
			var ce = fpc.Parse(expression);

			// Now that we know we have a valid fhirpath expression (from compilation perspective)
			// let's check that the types will all work!
			BaseFhirPathExpressionVisitor visitor = new BaseFhirPathExpressionVisitor(ModelInfo.ModelInspector, ModelInfo.SupportedResources, ModelInfo.OpenTypes);
			foreach (var vr in symbolTable.GetVariableMappings())
			{
				visitor.RegisterVariable(vr.Key, vr.Value);
			}
			// visitor.RegisterVariable("questionnaire", ModelInfo.ModelInspector.FindOrImportClassMapping(typeof(Questionnaire)));
			if (itemDef != null)
			{
				// visitor.RegisterVariable("qItem", ModelInfo.ModelInspector.FindOrImportClassMapping(typeof(Questionnaire.ItemComponent)));
				visitor.SetContext("QuestionnaireResponse.item");
			}
			else
			{
				visitor.SetContext("QuestionnaireResponse");
			}

			var result = ce.Accept(visitor);

			// TODO: Cleanup how this validation issue message is converted from the fhirpath checker into an
			// issue in this validator's outcome results - so that it can be better localised 
			if (visitor.Outcome.Issue.Any())
			{
				foreach (var issue in visitor.Outcome.Issue)
				{
					issue.Diagnostics = $"Expression: {expression}\r\nExpression Return Type(s): {result.ToString()}\r\n{visitor.ToString()}";
					issue.Expression = pathToExpressionForError;
					if (!string.IsNullOrEmpty(itemDef?.LinkId))
					{
						string loc = $"linkId='{itemDef.LinkId}'";
						if (name?.EndsWith("=''") != true)
							loc += $"\r\n{name}";
						issue.Location = new[] { loc };
					}

					// prefix the details text value with the item label
					if (itemDef != null)
					{
						issue.Details.Text = $"{itemDef.Text ?? itemDef.LinkId}: {issue.Details.Text}";
					}

					// If there was no coding added, we'll put our own in here.
					if (!issue.Details.Coding.Any())
					{
						issue.Details.Coding.Add(
							new Coding(
								ErrorCodeSystem,
								ValidationResult.invalidFhirpathExpressionTypes.ToString(),
								"Invalid fhirpath expression (type check)"
								)
							);
					}
					outcomeIssues.Enqueue(issue);
				}
			}
			return result;
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

		private class ValidationMessageException : Exception
		{
			public ValidationMessageException()
			{
			}
			public ValidationMessageException(string message) : base(message)
			{
			}
			public string ParseTreeDebug { get; set; }
			public string ReturnType { get; set; }
			public string VariableName { get; set; }
			public TypedVariableSymbolTable SymbolTable { get; set; }
		}

		
		private class EnableWhenValidationMessageException : Exception
		{
			public EnableWhenValidationMessageException(Questionnaire.EnableWhenComponent ew)
			{
				this.EnableWhen = ew;
			}

			public Questionnaire.EnableWhenComponent EnableWhen { get; set; }
		}

		private class ExtensionValidationMessageException : Exception
		{
			public ExtensionValidationMessageException(string url, string TypeRequired, string TypeUsed)
			{
				this.Url = url;
				this.TypeRequired = TypeRequired;
				this.TypeUsed = TypeUsed;
			}

			public ExtensionValidationMessageException(string message) : base(message)
			{
			}

			public string Url { get; set; }
			public string TypeUsed { get; set; }
			public string TypeRequired { get; set; }
		}
	}
}
