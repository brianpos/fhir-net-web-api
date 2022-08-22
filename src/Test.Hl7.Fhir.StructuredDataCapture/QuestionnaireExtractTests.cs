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
    public class QuestionnaireExtractTests : TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            Hl7.Fhir.FhirPath.ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();
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
    }
}
