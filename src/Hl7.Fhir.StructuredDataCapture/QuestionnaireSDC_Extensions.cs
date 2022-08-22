using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.StructuredDataCapture
{
    public static class QuestionnaireSDC_Extensions
    {
        public static Expression initialExpression(this Questionnaire.ItemComponent item)
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
        public static Duration observationLinkPeriod(this Questionnaire.ItemComponent item)
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
        public static IEnumerable<Coding> unitOptions(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensions("http://hl7.org/fhir/StructureDefinition/questionnaire-unitOption");
            return result.Where(e => e.Value is Coding).Select(e => e.Value as Coding);
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-questionnaire-unit.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Coding unit(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Coding>("http://hl7.org/fhir/StructureDefinition/questionnaire-unit");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-unitvalueset.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string unitValueSet(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensionValue<Canonical>("http://hl7.org/fhir/StructureDefinition/questionnaire-unitValueSet")?.Value;
            return result;
        }

        /// <summary>
        /// https://www.hl7.org/fhir/extension-mimetype.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEnumerable<string> mimeTypes(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensions("http://hl7.org/fhir/StructureDefinition/mimeType");
            return result.Select(e => (e.Value as FhirString)?.Value).SkipWhile(s => string.IsNullOrEmpty(s));
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-maxsize.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static decimal? maxSize(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<FhirDecimal>("http://hl7.org/fhir/StructureDefinition/maxSize")?.Value;
            return result;
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-minlength.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? minLength(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Integer>("http://hl7.org/fhir/StructureDefinition/minLength")?.Value;
            return result;
        }

        /// <summary>
        /// <a href="https://hl7.org/fhir/extension-questionnaire-minoccurs.html">https://hl7.org/fhir/extension-questionnaire-minoccurs.html</a>
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? minOccurs(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Integer>("http://hl7.org/fhir/StructureDefinition/questionnaire-minOccurs")?.Value;
            return result;
        }

        /// <summary>
        /// https://hl7.org/fhir/extension-questionnaire-maxoccurs.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? maxOccurs(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Integer>("http://hl7.org/fhir/StructureDefinition/questionnaire-maxOccurs")?.Value;
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/StructureDefinition/minValue
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Base minValue(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtension("http://hl7.org/fhir/StructureDefinition/minValue");
            return result?.Value;
        }

        /// <summary>
        /// http://hl7.org/fhir/StructureDefinition/maxValue
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Base maxValue(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtension("http://hl7.org/fhir/StructureDefinition/maxValue");
            return result?.Value;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/STU3/StructureDefinition-sdc-questionnaire-minQuantity.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Quantity minQuantity(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Quantity>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-minQuantity");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/STU3/StructureDefinition-sdc-questionnaire-maxQuantity.html
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Quantity maxQuantity(this Questionnaire.ItemComponent item)
        {
            var result = item.GetExtensionValue<Quantity>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-maxQuantity");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/StructureDefinition/maxDecimalPlaces
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int? maxDecimalPlaces(this Questionnaire.ItemComponent item)
        {
            var result = item.GetIntegerExtension("http://hl7.org/fhir/StructureDefinition/maxDecimalPlaces");
            return result;
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-sourceQueries.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<ResourceReference> sourceQueries(this Questionnaire me)
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
            public string name { get; set; }
            public Code type { get; set; }
            public string description { get; set; }
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-launchContext.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<LaunchContext> launchContexts(this Questionnaire me)
        {
            List<LaunchContext> results = new List<LaunchContext>();
            var extensions = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-launchContext");
            foreach (var e in extensions)
            {
                var lc = new LaunchContext()
                {
                    name = e.GetExtensionValue<Id>("name")?.Value ?? e.GetStringExtension("name"),
                    type = e.GetExtensionValue<Code>("type"),
                    description = e.GetStringExtension("description")
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
        public static IEnumerable<Expression> variables(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/variable");
            return result.Where(e => e.Value is Expression).Select(e => e.Value as Expression);
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-variable.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<Expression> variables(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/variable");
            return result.Where(e => e.Value is Expression).Select(e => e.Value as Expression);
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-itemPopulationContext.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static Expression itemPopulationContext(this Questionnaire me)
        {
            var result = me.GetExtensionValue<Expression>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemPopulationContext");
            return result;
        }

        /// <summary>
        /// http://build.fhir.org/ig/HL7/sdc/StructureDefinition-sdc-questionnaire-itemPopulationContext.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static Expression itemPopulationContext(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensionValue<Expression>("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-itemPopulationContext");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-targetStructureMap
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<Canonical> targetStructureMap(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-targetStructureMap");
            return result.Where(e => e.Value is Canonical).Select(e => e.Value as Canonical);
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<CodeableConcept> observationExtractCategory(this Questionnaire me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category");
            return result.Where(e => e.Value is CodeableConcept).Select(e => e.Value as CodeableConcept);
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<CodeableConcept> observationExtractCategory(this Questionnaire.ItemComponent me)
        {
            var result = me.GetExtensions("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observation-extract-category");
            return result.Where(e => e.Value is CodeableConcept).Select(e => e.Value as CodeableConcept);
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? observationExtract(this Questionnaire me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? observationExtract(this Questionnaire.ItemComponent me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? observationExtract(this Coding me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-observationExtract");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-optionexclusive.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static bool? optionExclusive(this Questionnaire.AnswerOptionComponent me)
        {
            var result = me.GetBoolExtension("http://hl7.org/fhir/StructureDefinition/questionnaire-optionExclusive");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/uv/sdc/STU3/StructureDefinition-sdc-questionnaire-shortText.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string shortText(this Questionnaire.ItemComponent me)
        {
            var result = me.GetStringExtension("http://hl7.org/fhir/uv/sdc/StructureDefinition/sdc-questionnaire-shortText");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-regex.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string regex(this Questionnaire.ItemComponent me)
        {
            var result = me.GetStringExtension("http://hl7.org/fhir/StructureDefinition/regex");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-entryformat.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static string entryFormat(this Questionnaire.ItemComponent me)
        {
            var result = me.GetStringExtension("http://hl7.org/fhir/StructureDefinition/entryFormat");
            return result;
        }

        /// <summary>
        /// http://hl7.org/fhir/extension-questionnaire-referenceresource.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<string> referenceResource(this Questionnaire.ItemComponent me)
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
            public string key { get; set; }
            public string requirements { get; set; }
            public OperationOutcome.IssueSeverity? severity { get; set; }
            public string expression { get; set; }
            public string human { get; set; }
            public IEnumerable<string> location { get; set; }
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-constraint.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<QuestionnaireInvariant> constraints(this Questionnaire me)
        {
            return me.constraintsInternal();
        }

        /// <summary>
        /// http://hl7.org/fhir/R4/extension-questionnaire-constraint.html
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static IEnumerable<QuestionnaireInvariant> constraints(this Questionnaire.ItemComponent me)
        {
            return me.constraintsInternal();
        }

        private static IEnumerable<QuestionnaireInvariant> constraintsInternal(this IExtendable me)
        {
            List<QuestionnaireInvariant> results = new List<QuestionnaireInvariant>();
            var extensions = me.GetExtensions("http://hl7.org/fhir/StructureDefinition/questionnaire-constraint");
            foreach (var e in extensions)
            {
                var invariant = new QuestionnaireInvariant()
                {
                    key = e.GetExtensionValue<Id>("key")?.Value ?? e.GetStringExtension("key"),
                    requirements = e.GetStringExtension("requirements"),
                    expression = e.GetStringExtension("expression"),
                    human = e.GetStringExtension("human"),
                    location = e.GetExtensions("location").Select(e => (e.Value as FhirString)?.Value).SkipWhile(s => string.IsNullOrEmpty(s)),
                };
                var severity = e.GetExtensionValue<Code>("severity")?.Value ?? e.GetStringExtension("severity");
                if (!string.IsNullOrEmpty(severity))
                    invariant.severity = Hl7.Fhir.Utility.EnumUtility.ParseLiteral<OperationOutcome.IssueSeverity>(severity);
                results.Add(invariant);
            }
            return results;
        }
    }
}
