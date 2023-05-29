using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.StructuredDataCapture
{
    public static class StructuredDataCaptureExtensions
    {
        public static Expression InitialExpression(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Expression>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-initialExpression");
            return result;
        }

        /// <summary>
        /// observationLinkPeriod
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-observationLinkPeriod.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Duration ObservationLinkPeriod(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Duration>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationLinkPeriod");
            if (result == null) // also check the older name for this extension
                result = item.GetExtensionValue<Duration>("http://hl7.org/fhir/StructureDefinition/questionnaire-observationLinkPeriod");
            return result;
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-questionnaire-unitoption.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEnumerable<Coding> UnitOptions(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensions("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption");
            return result.Where(e => e.Value is Coding).Select(e => e.Value as Coding);
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-questionnaire-unit.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Coding Unit(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Coding>("http://hl7.org/fhir/StructureDefinition/questionnaire-unit");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-unitvalueset.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string UnitValueSet(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensionValue<Canonical>("http://hl7.org/fhir/StructureDefinition/questionnaire-unitValueSet")?.Value;
            return result;
        }

        /// <summary>
        /// https://www.hl7.org/fhir/extension-mimetype.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEnumerable<string> MimeTypes(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensions("http://hl7.org/fhir/StructureDefinition/mimeType");
            return result.Select(e => (e.Value as FhirString)?.Value).SkipWhile(s => string.IsNullOrEmpty(s));
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-maxsize.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static decimal? MaxSize(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<FhirDecimal>("http://hl7.org/fhir/StructureDefinition/maxSize")?.Value;
            return result;
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-minlength.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? MinLength(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Integer>("http://hl7.org/fhir/StructureDefinition/minLength")?.Value;
            return result;
        }

        /// <summary>
        /// <a href="https://hl7.org/fhir/extension-questionnaire-minoccurs.html">https://hl7.org/fhir/extension-questionnaire-minoccurs.html</a>
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? MinOccurs(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Integer>("http://hl7.org/fhir/StructureDefinition/questionnaire-minOccurs")?.Value;
            return result;
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-questionnaire-maxoccurs.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? MaxOccurs(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Integer>("http://hl7.org/fhir/StructureDefinition/questionnaire-maxOccurs")?.Value;
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/StructureDefinition/minValue
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Base MinValue(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtension("http://hl7.org/fhir/StructureDefinition/minValue");
            return result?.Value;
        }

        /// <summary>
        /// http://hl7.org/fhir/StructureDefinition/maxValue
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Base MaxValue(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtension("http://hl7.org/fhir/StructureDefinition/maxValue");
            return result?.Value;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/STU3/StructureDefinition-sdc-questionnaire-minQuantity.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Quantity MinQuantity(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Quantity>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-minQuantity");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/STU3/StructureDefinition-sdc-questionnaire-maxQuantity.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Quantity MaxQuantity(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Quantity>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-maxQuantity");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/StructureDefinition/maxDecimalPlaces
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? MaxDecimalPlaces(this Questionnaire.ItemComponent item)
        {
            var result = item.GetIntegerExtension("http://hl7.org/fhir/StructureDefinition/maxDecimalPlaces");
            return result;
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-sourceQueries.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<ResourceReference> SourceQueries(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-sourceQueries");
            return result.Where(e => e.Value is ResourceReference).Select(e => e.Value as ResourceReference);
        }

        /// <summary>
        /// Class used to contain the complex extension details from the Launch Context
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-launchContext.html
        /// </summary>
        public class LaunchContext
        {
            public string Name { get; set; }

            public Code Type { get; set; }

            public string Description { get; set; }
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-launchContext.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<LaunchContext> LaunchContexts(this Questionnaire me)
        {
            List<LaunchContext> results = new List<LaunchContext>();
            var extensions = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-launchContext");
            foreach (var e in extensions)
            {
                var lc = new LaunchContext()
                {
                    Name = e.GetExtensionValue<Id>("name")?.Value ?? e.GetStringExtension("name"),
                    Type = e.GetExtensionValue<Code>("type"),
                    Description = e.GetStringExtension("description")
                };
                results.Add(lc);
            }
            return results;
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-variable.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<Expression> Variables(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/variable");
            return result.Where(e => e.Value is Expression).Select(e => e.Value as Expression);
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-variable.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<Expression> Variables(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/variable");
            return result.Where(e => e.Value is Expression).Select(e => e.Value as Expression);
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-itemPopulationContext.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static Expression ItemPopulationContext(this Questionnaire me)
        {
            var result = me.GetExtensionValue<Expression>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemPopulationContext");
            return result;
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-itemPopulationContext.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static Expression ItemPopulationContext(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensionValue<Expression>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemPopulationContext");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-targetStructureMap
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<Canonical> TargetStructureMap(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-targetStructureMap");
            return result.Where(e => e.Value is Canonical).Select(e => e.Value as Canonical);
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<CodeableConcept> ObservationExtractCategory(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category");
            return result.Where(e => e.Value is CodeableConcept).Select(e => e.Value as CodeableConcept);
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<CodeableConcept> ObservationExtractCategory(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category");
            return result.Where(e => e.Value is CodeableConcept).Select(e => e.Value as CodeableConcept);
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? ObservationExtract(this Questionnaire me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-isSubject
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? IsSubject(this Questionnaire.ItemComponent me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-isSubject");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaireresponse-isSubject
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? IsSubject(this QuestionnaireResponse.ItemComponent me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaireresponse-isSubject");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? ObservationExtract(this Questionnaire.ItemComponent me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? ObservationExtract(this Coding me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-optionexclusive.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? OptionExclusive(this Questionnaire.AnswerOptionComponent me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-optionExclusive");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/STU3/StructureDefinition-sdc-questionnaire-shortText.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string ShortText(this Questionnaire.ItemComponent me)
        {
            var result = me.GetStringExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-shortText");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-regex.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string Regex(this Questionnaire.ItemComponent me)
        {
            var result = me.GetStringExtension("http://hl7.org/fhir/StructureDefinition/regex");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-entryformat.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string EntryFormat(this Questionnaire.ItemComponent me)
        {
            var result = me.GetStringExtension("http://hl7.org/fhir/StructureDefinition/entryFormat");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-questionnaire-referenceresource.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReferenceResource(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/questionnaire-referenceResource");
            return result.Select(e => (e.Value as Code)?.Value).SkipWhile(s => string.IsNullOrEmpty(s));
        }

        /// <summary>
        /// Class used to contain the complex extension details from the Launch Context
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-launchContext.html
        /// </summary>
        public class QuestionnaireInvariant
        {
            public string Key { get; set; }

            public string Requirements { get; set; }

            public OperationOutcome.IssueSeverity? Severity { get; set; }

            public string Expression { get; set; }
            
            public string Human { get; set; }
            
            public IEnumerable<string> Location { get; set; }
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-constraint.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<QuestionnaireInvariant> Constraints(this Questionnaire me)
        {
            return me.ConstraintsInternal();
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-constraint.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<QuestionnaireInvariant> Constraints(this Questionnaire.ItemComponent me)
        {
            return me.ConstraintsInternal();
        }

        private static IEnumerable<QuestionnaireInvariant> ConstraintsInternal(this IExtendable me)
        {
            List<QuestionnaireInvariant> results = new List<QuestionnaireInvariant>();
            var extensions = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/questionnaire-constraint");
            foreach (var e in extensions)
            {
                var invariant = new QuestionnaireInvariant()
                {
                    Key = e.GetExtensionValue<Id>("key")?.Value ?? e.GetStringExtension("key"),
                    Requirements = e.GetStringExtension("requirements"),
                    Expression = e.GetStringExtension("expression"),
                    Human = e.GetStringExtension("human"),
                    Location = e.GetExtensions("location").Select(e => (e.Value as FhirString)?.Value).SkipWhile(s => string.IsNullOrEmpty(s)),
                };
                var severity = e.GetExtensionValue<Code>("severity")?.Value ?? e.GetStringExtension("severity");
                if (!string.IsNullOrEmpty(severity))
                    invariant.Severity = Hl7.Fhir.Utility.EnumUtility.ParseLiteral<OperationOutcome.IssueSeverity>(severity);
                results.Add(invariant);
            }
            return results;
        }
    }
}
