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
        public Resource Parse(XmlReader reader, OperationOutcome outcome, string locationPath = null, CancellationToken cancellationToken = new CancellationToken())
        {
			while (reader.Read())
			{
				// skip to the first start element node (over the processing instructions)
				if (reader.IsStartElement())
					break;
			}
            if (string.IsNullOrEmpty(locationPath))
                locationPath = reader.Name;
            Resource result;
            switch (reader.Name)
            {
                case "Account":
                    result = new Account();
                    Parse(result as Account, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ActivityDefinition":
                    result = new ActivityDefinition();
                    Parse(result as ActivityDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AdverseEvent":
                    result = new AdverseEvent();
                    Parse(result as AdverseEvent, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AllergyIntolerance":
                    result = new AllergyIntolerance();
                    Parse(result as AllergyIntolerance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Appointment":
                    result = new Appointment();
                    Parse(result as Appointment, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AppointmentResponse":
                    result = new AppointmentResponse();
                    Parse(result as AppointmentResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AuditEvent":
                    result = new AuditEvent();
                    Parse(result as AuditEvent, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Basic":
                    result = new Basic();
                    Parse(result as Basic, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Binary":
                    result = new Binary();
                    Parse(result as Binary, reader, outcome, locationPath, cancellationToken);
                    break;
                case "BiologicallyDerivedProduct":
                    result = new BiologicallyDerivedProduct();
                    Parse(result as BiologicallyDerivedProduct, reader, outcome, locationPath, cancellationToken);
                    break;
                case "BodyStructure":
                    result = new BodyStructure();
                    Parse(result as BodyStructure, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Bundle":
                    result = new Bundle();
                    Parse(result as Bundle, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CapabilityStatement":
                    result = new CapabilityStatement();
                    Parse(result as CapabilityStatement, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CarePlan":
                    result = new CarePlan();
                    Parse(result as CarePlan, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CareTeam":
                    result = new CareTeam();
                    Parse(result as CareTeam, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CatalogEntry":
                    result = new CatalogEntry();
                    Parse(result as CatalogEntry, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ChargeItem":
                    result = new ChargeItem();
                    Parse(result as ChargeItem, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ChargeItemDefinition":
                    result = new ChargeItemDefinition();
                    Parse(result as ChargeItemDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Claim":
                    result = new Claim();
                    Parse(result as Claim, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ClaimResponse":
                    result = new ClaimResponse();
                    Parse(result as ClaimResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ClinicalImpression":
                    result = new ClinicalImpression();
                    Parse(result as ClinicalImpression, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CodeSystem":
                    result = new CodeSystem();
                    Parse(result as CodeSystem, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Communication":
                    result = new Communication();
                    Parse(result as Communication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CommunicationRequest":
                    result = new CommunicationRequest();
                    Parse(result as CommunicationRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CompartmentDefinition":
                    result = new CompartmentDefinition();
                    Parse(result as CompartmentDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Composition":
                    result = new Composition();
                    Parse(result as Composition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ConceptMap":
                    result = new ConceptMap();
                    Parse(result as ConceptMap, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Condition":
                    result = new Condition();
                    Parse(result as Condition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Consent":
                    result = new Consent();
                    Parse(result as Consent, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Contract":
                    result = new Contract();
                    Parse(result as Contract, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Coverage":
                    result = new Coverage();
                    Parse(result as Coverage, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CoverageEligibilityRequest":
                    result = new CoverageEligibilityRequest();
                    Parse(result as CoverageEligibilityRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CoverageEligibilityResponse":
                    result = new CoverageEligibilityResponse();
                    Parse(result as CoverageEligibilityResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DetectedIssue":
                    result = new DetectedIssue();
                    Parse(result as DetectedIssue, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Device":
                    result = new Device();
                    Parse(result as Device, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceDefinition":
                    result = new DeviceDefinition();
                    Parse(result as DeviceDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceMetric":
                    result = new DeviceMetric();
                    Parse(result as DeviceMetric, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceRequest":
                    result = new DeviceRequest();
                    Parse(result as DeviceRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceUseStatement":
                    result = new DeviceUseStatement();
                    Parse(result as DeviceUseStatement, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DiagnosticReport":
                    result = new DiagnosticReport();
                    Parse(result as DiagnosticReport, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DocumentManifest":
                    result = new DocumentManifest();
                    Parse(result as DocumentManifest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DocumentReference":
                    result = new DocumentReference();
                    Parse(result as DocumentReference, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EffectEvidenceSynthesis":
                    result = new EffectEvidenceSynthesis();
                    Parse(result as EffectEvidenceSynthesis, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Encounter":
                    result = new Encounter();
                    Parse(result as Encounter, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Endpoint":
                    result = new Endpoint();
                    Parse(result as Endpoint, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EnrollmentRequest":
                    result = new EnrollmentRequest();
                    Parse(result as EnrollmentRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EnrollmentResponse":
                    result = new EnrollmentResponse();
                    Parse(result as EnrollmentResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EpisodeOfCare":
                    result = new EpisodeOfCare();
                    Parse(result as EpisodeOfCare, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EventDefinition":
                    result = new EventDefinition();
                    Parse(result as EventDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Evidence":
                    result = new Evidence();
                    Parse(result as Evidence, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EvidenceVariable":
                    result = new EvidenceVariable();
                    Parse(result as EvidenceVariable, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ExampleScenario":
                    result = new ExampleScenario();
                    Parse(result as ExampleScenario, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ExplanationOfBenefit":
                    result = new ExplanationOfBenefit();
                    Parse(result as ExplanationOfBenefit, reader, outcome, locationPath, cancellationToken);
                    break;
                case "FamilyMemberHistory":
                    result = new FamilyMemberHistory();
                    Parse(result as FamilyMemberHistory, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Flag":
                    result = new Flag();
                    Parse(result as Flag, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Goal":
                    result = new Goal();
                    Parse(result as Goal, reader, outcome, locationPath, cancellationToken);
                    break;
                case "GraphDefinition":
                    result = new GraphDefinition();
                    Parse(result as GraphDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Group":
                    result = new Group();
                    Parse(result as Group, reader, outcome, locationPath, cancellationToken);
                    break;
                case "GuidanceResponse":
                    result = new GuidanceResponse();
                    Parse(result as GuidanceResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "HealthcareService":
                    result = new HealthcareService();
                    Parse(result as HealthcareService, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImagingStudy":
                    result = new ImagingStudy();
                    Parse(result as ImagingStudy, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Immunization":
                    result = new Immunization();
                    Parse(result as Immunization, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImmunizationEvaluation":
                    result = new ImmunizationEvaluation();
                    Parse(result as ImmunizationEvaluation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImmunizationRecommendation":
                    result = new ImmunizationRecommendation();
                    Parse(result as ImmunizationRecommendation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImplementationGuide":
                    result = new ImplementationGuide();
                    Parse(result as ImplementationGuide, reader, outcome, locationPath, cancellationToken);
                    break;
                case "InsurancePlan":
                    result = new InsurancePlan();
                    Parse(result as InsurancePlan, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Invoice":
                    result = new Invoice();
                    Parse(result as Invoice, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Library":
                    result = new Library();
                    Parse(result as Library, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Linkage":
                    result = new Linkage();
                    Parse(result as Linkage, reader, outcome, locationPath, cancellationToken);
                    break;
                case "List":
                    result = new List();
                    Parse(result as List, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Location":
                    result = new Location();
                    Parse(result as Location, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Measure":
                    result = new Measure();
                    Parse(result as Measure, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MeasureReport":
                    result = new MeasureReport();
                    Parse(result as MeasureReport, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Media":
                    result = new Media();
                    Parse(result as Media, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Medication":
                    result = new Medication();
                    Parse(result as Medication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationAdministration":
                    result = new MedicationAdministration();
                    Parse(result as MedicationAdministration, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationDispense":
                    result = new MedicationDispense();
                    Parse(result as MedicationDispense, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationKnowledge":
                    result = new MedicationKnowledge();
                    Parse(result as MedicationKnowledge, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationRequest":
                    result = new MedicationRequest();
                    Parse(result as MedicationRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationStatement":
                    result = new MedicationStatement();
                    Parse(result as MedicationStatement, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProduct":
                    result = new MedicinalProduct();
                    Parse(result as MedicinalProduct, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductAuthorization":
                    result = new MedicinalProductAuthorization();
                    Parse(result as MedicinalProductAuthorization, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductContraindication":
                    result = new MedicinalProductContraindication();
                    Parse(result as MedicinalProductContraindication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductIndication":
                    result = new MedicinalProductIndication();
                    Parse(result as MedicinalProductIndication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductIngredient":
                    result = new MedicinalProductIngredient();
                    Parse(result as MedicinalProductIngredient, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductInteraction":
                    result = new MedicinalProductInteraction();
                    Parse(result as MedicinalProductInteraction, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductManufactured":
                    result = new MedicinalProductManufactured();
                    Parse(result as MedicinalProductManufactured, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductPackaged":
                    result = new MedicinalProductPackaged();
                    Parse(result as MedicinalProductPackaged, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductPharmaceutical":
                    result = new MedicinalProductPharmaceutical();
                    Parse(result as MedicinalProductPharmaceutical, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductUndesirableEffect":
                    result = new MedicinalProductUndesirableEffect();
                    Parse(result as MedicinalProductUndesirableEffect, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MessageDefinition":
                    result = new MessageDefinition();
                    Parse(result as MessageDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MessageHeader":
                    result = new MessageHeader();
                    Parse(result as MessageHeader, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MolecularSequence":
                    result = new MolecularSequence();
                    Parse(result as MolecularSequence, reader, outcome, locationPath, cancellationToken);
                    break;
                case "NamingSystem":
                    result = new NamingSystem();
                    Parse(result as NamingSystem, reader, outcome, locationPath, cancellationToken);
                    break;
                case "NutritionOrder":
                    result = new NutritionOrder();
                    Parse(result as NutritionOrder, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Observation":
                    result = new Observation();
                    Parse(result as Observation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ObservationDefinition":
                    result = new ObservationDefinition();
                    Parse(result as ObservationDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "OperationDefinition":
                    result = new OperationDefinition();
                    Parse(result as OperationDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "OperationOutcome":
                    result = new OperationOutcome();
                    Parse(result as OperationOutcome, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Organization":
                    result = new Organization();
                    Parse(result as Organization, reader, outcome, locationPath, cancellationToken);
                    break;
                case "OrganizationAffiliation":
                    result = new OrganizationAffiliation();
                    Parse(result as OrganizationAffiliation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Parameters":
                    result = new Parameters();
                    Parse(result as Parameters, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Patient":
                    result = new Patient();
                    Parse(result as Patient, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PaymentNotice":
                    result = new PaymentNotice();
                    Parse(result as PaymentNotice, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PaymentReconciliation":
                    result = new PaymentReconciliation();
                    Parse(result as PaymentReconciliation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Person":
                    result = new Person();
                    Parse(result as Person, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PlanDefinition":
                    result = new PlanDefinition();
                    Parse(result as PlanDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Practitioner":
                    result = new Practitioner();
                    Parse(result as Practitioner, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PractitionerRole":
                    result = new PractitionerRole();
                    Parse(result as PractitionerRole, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Procedure":
                    result = new Procedure();
                    Parse(result as Procedure, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Provenance":
                    result = new Provenance();
                    Parse(result as Provenance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Questionnaire":
                    result = new Questionnaire();
                    Parse(result as Questionnaire, reader, outcome, locationPath, cancellationToken);
                    break;
                case "QuestionnaireResponse":
                    result = new QuestionnaireResponse();
                    Parse(result as QuestionnaireResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RelatedPerson":
                    result = new RelatedPerson();
                    Parse(result as RelatedPerson, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RequestGroup":
                    result = new RequestGroup();
                    Parse(result as RequestGroup, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchDefinition":
                    result = new ResearchDefinition();
                    Parse(result as ResearchDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchElementDefinition":
                    result = new ResearchElementDefinition();
                    Parse(result as ResearchElementDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchStudy":
                    result = new ResearchStudy();
                    Parse(result as ResearchStudy, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchSubject":
                    result = new ResearchSubject();
                    Parse(result as ResearchSubject, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RiskAssessment":
                    result = new RiskAssessment();
                    Parse(result as RiskAssessment, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RiskEvidenceSynthesis":
                    result = new RiskEvidenceSynthesis();
                    Parse(result as RiskEvidenceSynthesis, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Schedule":
                    result = new Schedule();
                    Parse(result as Schedule, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SearchParameter":
                    result = new SearchParameter();
                    Parse(result as SearchParameter, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ServiceRequest":
                    result = new ServiceRequest();
                    Parse(result as ServiceRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Slot":
                    result = new Slot();
                    Parse(result as Slot, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Specimen":
                    result = new Specimen();
                    Parse(result as Specimen, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SpecimenDefinition":
                    result = new SpecimenDefinition();
                    Parse(result as SpecimenDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "StructureDefinition":
                    result = new StructureDefinition();
                    Parse(result as StructureDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "StructureMap":
                    result = new StructureMap();
                    Parse(result as StructureMap, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Subscription":
                    result = new Subscription();
                    Parse(result as Subscription, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Substance":
                    result = new Substance();
                    Parse(result as Substance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceNucleicAcid":
                    result = new SubstanceNucleicAcid();
                    Parse(result as SubstanceNucleicAcid, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstancePolymer":
                    result = new SubstancePolymer();
                    Parse(result as SubstancePolymer, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceProtein":
                    result = new SubstanceProtein();
                    Parse(result as SubstanceProtein, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceReferenceInformation":
                    result = new SubstanceReferenceInformation();
                    Parse(result as SubstanceReferenceInformation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceSourceMaterial":
                    result = new SubstanceSourceMaterial();
                    Parse(result as SubstanceSourceMaterial, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceSpecification":
                    result = new SubstanceSpecification();
                    Parse(result as SubstanceSpecification, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SupplyDelivery":
                    result = new SupplyDelivery();
                    Parse(result as SupplyDelivery, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SupplyRequest":
                    result = new SupplyRequest();
                    Parse(result as SupplyRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Task":
                    result = new Task();
                    Parse(result as Task, reader, outcome, locationPath, cancellationToken);
                    break;
                case "TerminologyCapabilities":
                    result = new TerminologyCapabilities();
                    Parse(result as TerminologyCapabilities, reader, outcome, locationPath, cancellationToken);
                    break;
                case "TestReport":
                    result = new TestReport();
                    Parse(result as TestReport, reader, outcome, locationPath, cancellationToken);
                    break;
                case "TestScript":
                    result = new TestScript();
                    Parse(result as TestScript, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ValueSet":
                    result = new ValueSet();
                    Parse(result as ValueSet, reader, outcome, locationPath, cancellationToken);
                    break;
                case "VerificationResult":
                    result = new VerificationResult();
                    Parse(result as VerificationResult, reader, outcome, locationPath, cancellationToken);
                    break;
                case "VisionPrescription":
                    result = new VisionPrescription();
                    Parse(result as VisionPrescription, reader, outcome, locationPath, cancellationToken);
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }

        public async System.Threading.Tasks.Task<Resource> ParseAsync(XmlReader reader, OperationOutcome outcome, string locationPath = null, CancellationToken cancellationToken = new CancellationToken())
        {
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				// skip to the first start element node (over the processing instructions)
				if (reader.IsStartElement())
					break;
			}
            if (string.IsNullOrEmpty(locationPath))
                locationPath = reader.Name;
            Resource result;
            switch (reader.Name)
            {
                case "Account":
                    result = new Account();
                    await ParseAsync(result as Account, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ActivityDefinition":
                    result = new ActivityDefinition();
                    await ParseAsync(result as ActivityDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AdverseEvent":
                    result = new AdverseEvent();
                    await ParseAsync(result as AdverseEvent, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AllergyIntolerance":
                    result = new AllergyIntolerance();
                    await ParseAsync(result as AllergyIntolerance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Appointment":
                    result = new Appointment();
                    await ParseAsync(result as Appointment, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AppointmentResponse":
                    result = new AppointmentResponse();
                    await ParseAsync(result as AppointmentResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "AuditEvent":
                    result = new AuditEvent();
                    await ParseAsync(result as AuditEvent, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Basic":
                    result = new Basic();
                    await ParseAsync(result as Basic, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Binary":
                    result = new Binary();
                    await ParseAsync(result as Binary, reader, outcome, locationPath, cancellationToken);
                    break;
                case "BiologicallyDerivedProduct":
                    result = new BiologicallyDerivedProduct();
                    await ParseAsync(result as BiologicallyDerivedProduct, reader, outcome, locationPath, cancellationToken);
                    break;
                case "BodyStructure":
                    result = new BodyStructure();
                    await ParseAsync(result as BodyStructure, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Bundle":
                    result = new Bundle();
                    await ParseAsync(result as Bundle, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CapabilityStatement":
                    result = new CapabilityStatement();
                    await ParseAsync(result as CapabilityStatement, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CarePlan":
                    result = new CarePlan();
                    await ParseAsync(result as CarePlan, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CareTeam":
                    result = new CareTeam();
                    await ParseAsync(result as CareTeam, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CatalogEntry":
                    result = new CatalogEntry();
                    await ParseAsync(result as CatalogEntry, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ChargeItem":
                    result = new ChargeItem();
                    await ParseAsync(result as ChargeItem, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ChargeItemDefinition":
                    result = new ChargeItemDefinition();
                    await ParseAsync(result as ChargeItemDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Claim":
                    result = new Claim();
                    await ParseAsync(result as Claim, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ClaimResponse":
                    result = new ClaimResponse();
                    await ParseAsync(result as ClaimResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ClinicalImpression":
                    result = new ClinicalImpression();
                    await ParseAsync(result as ClinicalImpression, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CodeSystem":
                    result = new CodeSystem();
                    await ParseAsync(result as CodeSystem, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Communication":
                    result = new Communication();
                    await ParseAsync(result as Communication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CommunicationRequest":
                    result = new CommunicationRequest();
                    await ParseAsync(result as CommunicationRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CompartmentDefinition":
                    result = new CompartmentDefinition();
                    await ParseAsync(result as CompartmentDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Composition":
                    result = new Composition();
                    await ParseAsync(result as Composition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ConceptMap":
                    result = new ConceptMap();
                    await ParseAsync(result as ConceptMap, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Condition":
                    result = new Condition();
                    await ParseAsync(result as Condition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Consent":
                    result = new Consent();
                    await ParseAsync(result as Consent, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Contract":
                    result = new Contract();
                    await ParseAsync(result as Contract, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Coverage":
                    result = new Coverage();
                    await ParseAsync(result as Coverage, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CoverageEligibilityRequest":
                    result = new CoverageEligibilityRequest();
                    await ParseAsync(result as CoverageEligibilityRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "CoverageEligibilityResponse":
                    result = new CoverageEligibilityResponse();
                    await ParseAsync(result as CoverageEligibilityResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DetectedIssue":
                    result = new DetectedIssue();
                    await ParseAsync(result as DetectedIssue, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Device":
                    result = new Device();
                    await ParseAsync(result as Device, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceDefinition":
                    result = new DeviceDefinition();
                    await ParseAsync(result as DeviceDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceMetric":
                    result = new DeviceMetric();
                    await ParseAsync(result as DeviceMetric, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceRequest":
                    result = new DeviceRequest();
                    await ParseAsync(result as DeviceRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DeviceUseStatement":
                    result = new DeviceUseStatement();
                    await ParseAsync(result as DeviceUseStatement, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DiagnosticReport":
                    result = new DiagnosticReport();
                    await ParseAsync(result as DiagnosticReport, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DocumentManifest":
                    result = new DocumentManifest();
                    await ParseAsync(result as DocumentManifest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "DocumentReference":
                    result = new DocumentReference();
                    await ParseAsync(result as DocumentReference, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EffectEvidenceSynthesis":
                    result = new EffectEvidenceSynthesis();
                    await ParseAsync(result as EffectEvidenceSynthesis, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Encounter":
                    result = new Encounter();
                    await ParseAsync(result as Encounter, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Endpoint":
                    result = new Endpoint();
                    await ParseAsync(result as Endpoint, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EnrollmentRequest":
                    result = new EnrollmentRequest();
                    await ParseAsync(result as EnrollmentRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EnrollmentResponse":
                    result = new EnrollmentResponse();
                    await ParseAsync(result as EnrollmentResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EpisodeOfCare":
                    result = new EpisodeOfCare();
                    await ParseAsync(result as EpisodeOfCare, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EventDefinition":
                    result = new EventDefinition();
                    await ParseAsync(result as EventDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Evidence":
                    result = new Evidence();
                    await ParseAsync(result as Evidence, reader, outcome, locationPath, cancellationToken);
                    break;
                case "EvidenceVariable":
                    result = new EvidenceVariable();
                    await ParseAsync(result as EvidenceVariable, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ExampleScenario":
                    result = new ExampleScenario();
                    await ParseAsync(result as ExampleScenario, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ExplanationOfBenefit":
                    result = new ExplanationOfBenefit();
                    await ParseAsync(result as ExplanationOfBenefit, reader, outcome, locationPath, cancellationToken);
                    break;
                case "FamilyMemberHistory":
                    result = new FamilyMemberHistory();
                    await ParseAsync(result as FamilyMemberHistory, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Flag":
                    result = new Flag();
                    await ParseAsync(result as Flag, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Goal":
                    result = new Goal();
                    await ParseAsync(result as Goal, reader, outcome, locationPath, cancellationToken);
                    break;
                case "GraphDefinition":
                    result = new GraphDefinition();
                    await ParseAsync(result as GraphDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Group":
                    result = new Group();
                    await ParseAsync(result as Group, reader, outcome, locationPath, cancellationToken);
                    break;
                case "GuidanceResponse":
                    result = new GuidanceResponse();
                    await ParseAsync(result as GuidanceResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "HealthcareService":
                    result = new HealthcareService();
                    await ParseAsync(result as HealthcareService, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImagingStudy":
                    result = new ImagingStudy();
                    await ParseAsync(result as ImagingStudy, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Immunization":
                    result = new Immunization();
                    await ParseAsync(result as Immunization, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImmunizationEvaluation":
                    result = new ImmunizationEvaluation();
                    await ParseAsync(result as ImmunizationEvaluation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImmunizationRecommendation":
                    result = new ImmunizationRecommendation();
                    await ParseAsync(result as ImmunizationRecommendation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ImplementationGuide":
                    result = new ImplementationGuide();
                    await ParseAsync(result as ImplementationGuide, reader, outcome, locationPath, cancellationToken);
                    break;
                case "InsurancePlan":
                    result = new InsurancePlan();
                    await ParseAsync(result as InsurancePlan, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Invoice":
                    result = new Invoice();
                    await ParseAsync(result as Invoice, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Library":
                    result = new Library();
                    await ParseAsync(result as Library, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Linkage":
                    result = new Linkage();
                    await ParseAsync(result as Linkage, reader, outcome, locationPath, cancellationToken);
                    break;
                case "List":
                    result = new List();
                    await ParseAsync(result as List, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Location":
                    result = new Location();
                    await ParseAsync(result as Location, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Measure":
                    result = new Measure();
                    await ParseAsync(result as Measure, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MeasureReport":
                    result = new MeasureReport();
                    await ParseAsync(result as MeasureReport, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Media":
                    result = new Media();
                    await ParseAsync(result as Media, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Medication":
                    result = new Medication();
                    await ParseAsync(result as Medication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationAdministration":
                    result = new MedicationAdministration();
                    await ParseAsync(result as MedicationAdministration, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationDispense":
                    result = new MedicationDispense();
                    await ParseAsync(result as MedicationDispense, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationKnowledge":
                    result = new MedicationKnowledge();
                    await ParseAsync(result as MedicationKnowledge, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationRequest":
                    result = new MedicationRequest();
                    await ParseAsync(result as MedicationRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicationStatement":
                    result = new MedicationStatement();
                    await ParseAsync(result as MedicationStatement, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProduct":
                    result = new MedicinalProduct();
                    await ParseAsync(result as MedicinalProduct, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductAuthorization":
                    result = new MedicinalProductAuthorization();
                    await ParseAsync(result as MedicinalProductAuthorization, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductContraindication":
                    result = new MedicinalProductContraindication();
                    await ParseAsync(result as MedicinalProductContraindication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductIndication":
                    result = new MedicinalProductIndication();
                    await ParseAsync(result as MedicinalProductIndication, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductIngredient":
                    result = new MedicinalProductIngredient();
                    await ParseAsync(result as MedicinalProductIngredient, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductInteraction":
                    result = new MedicinalProductInteraction();
                    await ParseAsync(result as MedicinalProductInteraction, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductManufactured":
                    result = new MedicinalProductManufactured();
                    await ParseAsync(result as MedicinalProductManufactured, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductPackaged":
                    result = new MedicinalProductPackaged();
                    await ParseAsync(result as MedicinalProductPackaged, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductPharmaceutical":
                    result = new MedicinalProductPharmaceutical();
                    await ParseAsync(result as MedicinalProductPharmaceutical, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MedicinalProductUndesirableEffect":
                    result = new MedicinalProductUndesirableEffect();
                    await ParseAsync(result as MedicinalProductUndesirableEffect, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MessageDefinition":
                    result = new MessageDefinition();
                    await ParseAsync(result as MessageDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MessageHeader":
                    result = new MessageHeader();
                    await ParseAsync(result as MessageHeader, reader, outcome, locationPath, cancellationToken);
                    break;
                case "MolecularSequence":
                    result = new MolecularSequence();
                    await ParseAsync(result as MolecularSequence, reader, outcome, locationPath, cancellationToken);
                    break;
                case "NamingSystem":
                    result = new NamingSystem();
                    await ParseAsync(result as NamingSystem, reader, outcome, locationPath, cancellationToken);
                    break;
                case "NutritionOrder":
                    result = new NutritionOrder();
                    await ParseAsync(result as NutritionOrder, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Observation":
                    result = new Observation();
                    await ParseAsync(result as Observation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ObservationDefinition":
                    result = new ObservationDefinition();
                    await ParseAsync(result as ObservationDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "OperationDefinition":
                    result = new OperationDefinition();
                    await ParseAsync(result as OperationDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "OperationOutcome":
                    result = new OperationOutcome();
                    await ParseAsync(result as OperationOutcome, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Organization":
                    result = new Organization();
                    await ParseAsync(result as Organization, reader, outcome, locationPath, cancellationToken);
                    break;
                case "OrganizationAffiliation":
                    result = new OrganizationAffiliation();
                    await ParseAsync(result as OrganizationAffiliation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Parameters":
                    result = new Parameters();
                    await ParseAsync(result as Parameters, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Patient":
                    result = new Patient();
                    await ParseAsync(result as Patient, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PaymentNotice":
                    result = new PaymentNotice();
                    await ParseAsync(result as PaymentNotice, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PaymentReconciliation":
                    result = new PaymentReconciliation();
                    await ParseAsync(result as PaymentReconciliation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Person":
                    result = new Person();
                    await ParseAsync(result as Person, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PlanDefinition":
                    result = new PlanDefinition();
                    await ParseAsync(result as PlanDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Practitioner":
                    result = new Practitioner();
                    await ParseAsync(result as Practitioner, reader, outcome, locationPath, cancellationToken);
                    break;
                case "PractitionerRole":
                    result = new PractitionerRole();
                    await ParseAsync(result as PractitionerRole, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Procedure":
                    result = new Procedure();
                    await ParseAsync(result as Procedure, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Provenance":
                    result = new Provenance();
                    await ParseAsync(result as Provenance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Questionnaire":
                    result = new Questionnaire();
                    await ParseAsync(result as Questionnaire, reader, outcome, locationPath, cancellationToken);
                    break;
                case "QuestionnaireResponse":
                    result = new QuestionnaireResponse();
                    await ParseAsync(result as QuestionnaireResponse, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RelatedPerson":
                    result = new RelatedPerson();
                    await ParseAsync(result as RelatedPerson, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RequestGroup":
                    result = new RequestGroup();
                    await ParseAsync(result as RequestGroup, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchDefinition":
                    result = new ResearchDefinition();
                    await ParseAsync(result as ResearchDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchElementDefinition":
                    result = new ResearchElementDefinition();
                    await ParseAsync(result as ResearchElementDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchStudy":
                    result = new ResearchStudy();
                    await ParseAsync(result as ResearchStudy, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ResearchSubject":
                    result = new ResearchSubject();
                    await ParseAsync(result as ResearchSubject, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RiskAssessment":
                    result = new RiskAssessment();
                    await ParseAsync(result as RiskAssessment, reader, outcome, locationPath, cancellationToken);
                    break;
                case "RiskEvidenceSynthesis":
                    result = new RiskEvidenceSynthesis();
                    await ParseAsync(result as RiskEvidenceSynthesis, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Schedule":
                    result = new Schedule();
                    await ParseAsync(result as Schedule, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SearchParameter":
                    result = new SearchParameter();
                    await ParseAsync(result as SearchParameter, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ServiceRequest":
                    result = new ServiceRequest();
                    await ParseAsync(result as ServiceRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Slot":
                    result = new Slot();
                    await ParseAsync(result as Slot, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Specimen":
                    result = new Specimen();
                    await ParseAsync(result as Specimen, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SpecimenDefinition":
                    result = new SpecimenDefinition();
                    await ParseAsync(result as SpecimenDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "StructureDefinition":
                    result = new StructureDefinition();
                    await ParseAsync(result as StructureDefinition, reader, outcome, locationPath, cancellationToken);
                    break;
                case "StructureMap":
                    result = new StructureMap();
                    await ParseAsync(result as StructureMap, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Subscription":
                    result = new Subscription();
                    await ParseAsync(result as Subscription, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Substance":
                    result = new Substance();
                    await ParseAsync(result as Substance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceNucleicAcid":
                    result = new SubstanceNucleicAcid();
                    await ParseAsync(result as SubstanceNucleicAcid, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstancePolymer":
                    result = new SubstancePolymer();
                    await ParseAsync(result as SubstancePolymer, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceProtein":
                    result = new SubstanceProtein();
                    await ParseAsync(result as SubstanceProtein, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceReferenceInformation":
                    result = new SubstanceReferenceInformation();
                    await ParseAsync(result as SubstanceReferenceInformation, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceSourceMaterial":
                    result = new SubstanceSourceMaterial();
                    await ParseAsync(result as SubstanceSourceMaterial, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceSpecification":
                    result = new SubstanceSpecification();
                    await ParseAsync(result as SubstanceSpecification, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SupplyDelivery":
                    result = new SupplyDelivery();
                    await ParseAsync(result as SupplyDelivery, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SupplyRequest":
                    result = new SupplyRequest();
                    await ParseAsync(result as SupplyRequest, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Task":
                    result = new Task();
                    await ParseAsync(result as Task, reader, outcome, locationPath, cancellationToken);
                    break;
                case "TerminologyCapabilities":
                    result = new TerminologyCapabilities();
                    await ParseAsync(result as TerminologyCapabilities, reader, outcome, locationPath, cancellationToken);
                    break;
                case "TestReport":
                    result = new TestReport();
                    await ParseAsync(result as TestReport, reader, outcome, locationPath, cancellationToken);
                    break;
                case "TestScript":
                    result = new TestScript();
                    await ParseAsync(result as TestScript, reader, outcome, locationPath, cancellationToken);
                    break;
                case "ValueSet":
                    result = new ValueSet();
                    await ParseAsync(result as ValueSet, reader, outcome, locationPath, cancellationToken);
                    break;
                case "VerificationResult":
                    result = new VerificationResult();
                    await ParseAsync(result as VerificationResult, reader, outcome, locationPath, cancellationToken);
                    break;
                case "VisionPrescription":
                    result = new VisionPrescription();
                    await ParseAsync(result as VisionPrescription, reader, outcome, locationPath, cancellationToken);
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
	}
}
// Generated helper templates
// Generated items
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SimpleQuantity.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VisionPrescription.PrismComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VisionPrescription.LensSpecificationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VerificationResult.ValidatorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VerificationResult.AttestationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VerificationResult.PrimarySourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.ContainsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.ExpansionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.FilterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.DesignationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.ConceptReferenceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.ConceptSetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.ComposeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.TeardownActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.TeardownComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.TestActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.TestComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.AssertComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.RequestHeaderComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.OperationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.SetupActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.SetupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.VariableComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.FixtureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.CapabilityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.LinkComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.MetadataComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.DestinationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.OriginComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.TeardownActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.TeardownComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.TestActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.TestComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.AssertComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.OperationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.SetupActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.SetupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.ClosureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.TranslationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.ValidateCodeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.ExpansionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.FilterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.VersionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.CodeSystemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.ImplementationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.SoftwareComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Task.OutputComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Task.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Task.RestrictionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SupplyRequest.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SupplyDelivery.SuppliedItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.RelationshipComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.OfficialComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.NameComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.CodeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.RepresentationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.MolecularWeightComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.IsotopeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.StructureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.PropertyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.MoietyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.PartDescriptionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.OrganismGeneralComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.HybridComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.AuthorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.OrganismComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.FractionDescriptionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceReferenceInformation.TargetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceReferenceInformation.ClassificationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceReferenceInformation.GeneElementComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceReferenceInformation.GeneComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceProtein.SubunitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.StructuralRepresentationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.DegreeOfPolymerisationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.RepeatUnitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.RepeatComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.StartingMaterialComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.MonomerSetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceNucleicAcid.SugarComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceNucleicAcid.LinkageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceNucleicAcid.SubunitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Substance.IngredientComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Substance.InstanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Subscription.ChannelComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.DependentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.TargetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.SourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.RuleComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.InputComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.GroupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.StructureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureDefinition.DifferentialComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureDefinition.SnapshotComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureDefinition.ContextComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureDefinition.MappingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SpecimenDefinition.HandlingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SpecimenDefinition.AdditiveComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SpecimenDefinition.ContainerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SpecimenDefinition.TypeTestedComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Specimen.ContainerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Specimen.ProcessingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Specimen.CollectionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SearchParameter.ComponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskEvidenceSynthesis.CertaintySubcomponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskEvidenceSynthesis.CertaintyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskEvidenceSynthesis.PrecisionEstimateComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskEvidenceSynthesis.RiskEstimateComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskEvidenceSynthesis.SampleSizeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskAssessment.PredictionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchStudy.ObjectiveComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchStudy.ArmComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchElementDefinition.CharacteristicComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RequestGroup.RelatedActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RequestGroup.ConditionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RequestGroup.ActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RelatedPerson.CommunicationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.QuestionnaireResponse.AnswerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.QuestionnaireResponse.ItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Questionnaire.InitialComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Questionnaire.AnswerOptionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Questionnaire.EnableWhenComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Questionnaire.ItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Provenance.EntityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Provenance.AgentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Procedure.FocalDeviceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Procedure.PerformerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PractitionerRole.NotAvailableComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PractitionerRole.AvailableTimeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Practitioner.QualificationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.DynamicValueComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.RelatedActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.ConditionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.ActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.TargetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.GoalComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Person.LinkComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PaymentReconciliation.NotesComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PaymentReconciliation.DetailsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Patient.LinkComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Patient.CommunicationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Patient.ContactComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Parameters.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Organization.ContactComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationOutcome.IssueComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationDefinition.OverloadComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationDefinition.ReferencedFromComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationDefinition.BindingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationDefinition.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ObservationDefinition.QualifiedIntervalComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ObservationDefinition.QuantitativeDetailsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Observation.ComponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Observation.ReferenceRangeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.AdministrationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.EnteralFormulaComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.SupplementComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.TextureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.NutrientComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.OralDietComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NamingSystem.UniqueIdComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.InnerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.OuterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.StructureVariantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.RepositoryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.RocComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.QualityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.VariantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.ReferenceSeqComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageHeader.ResponseComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageHeader.MessageSourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageHeader.MessageDestinationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageDefinition.AllowedResponseComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageDefinition.FocusComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPharmaceutical.WithdrawalPeriodComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPharmaceutical.TargetSpeciesComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPharmaceutical.RouteOfAdministrationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPharmaceutical.CharacteristicsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPackaged.PackageItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPackaged.BatchIdentifierComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductInteraction.InteractantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIngredient.SubstanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIngredient.ReferenceStrengthComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIngredient.StrengthComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIngredient.SpecifiedSubstanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIndication.OtherTherapyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductContraindication.OtherTherapyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductAuthorization.ProcedureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductAuthorization.JurisdictionalAuthorizationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProduct.SpecialDesignationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProduct.ManufacturingBusinessOperationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProduct.CountryLanguageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProduct.NamePartComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProduct.NameComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationRequest.SubstitutionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationRequest.InitialFillComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationRequest.DispenseRequestComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.KineticsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.MaxDispenseComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.ScheduleComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.SubstitutionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.RegulatoryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.DrugCharacteristicComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.PackagingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.MedicineClassificationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.PatientCharacteristicsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.DosageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.AdministrationGuidelinesComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.MonitoringProgramComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.CostComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.IngredientComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.MonographComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.RelatedMedicationKnowledgeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationDispense.SubstitutionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationDispense.PerformerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationAdministration.DosageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationAdministration.PerformerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Medication.BatchComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Medication.IngredientComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.StratifierGroupPopulationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.ComponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.StratifierGroupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.StratifierComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.PopulationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.GroupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Measure.SupplementalDataComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Measure.ComponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Measure.StratifierComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Measure.PopulationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Measure.GroupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Location.HoursOfOperationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Location.PositionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.List.EntryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Linkage.ItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Invoice.PriceComponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Invoice.LineItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Invoice.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.CostComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.PlanBenefitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.SpecificCostComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.GeneralCostComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.PlanComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.LimitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.CoverageBenefitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.CoverageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.ContactComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.ManifestPageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.ManifestResourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.ManifestComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.TemplateComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.PageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.ResourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.GroupingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.DefinitionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.GlobalComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.DependsOnComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImmunizationRecommendation.DateCriterionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImmunizationRecommendation.RecommendationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Immunization.ProtocolAppliedComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Immunization.ReactionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Immunization.EducationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Immunization.PerformerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImagingStudy.InstanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImagingStudy.PerformerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImagingStudy.SeriesComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.HealthcareService.NotAvailableComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.HealthcareService.AvailableTimeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.HealthcareService.EligibilityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Group.MemberComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Group.CharacteristicComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.GraphDefinition.CompartmentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.GraphDefinition.TargetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.GraphDefinition.LinkComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Goal.TargetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FamilyMemberHistory.ConditionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.BenefitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.BenefitBalanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.NoteComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.PaymentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.TotalComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.AddedItemDetailSubDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.AddedItemDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.AddedItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.SubDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.DetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.AdjudicationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.ItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.AccidentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.InsuranceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.ProcedureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.DiagnosisComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.SupportingInformationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.CareTeamComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.PayeeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.RelatedClaimComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.AlternativeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.OperationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.StepComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.ProcessComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.ContainedInstanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.VersionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.InstanceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.ActorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EvidenceVariable.CharacteristicComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EpisodeOfCare.DiagnosisComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EpisodeOfCare.StatusHistoryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.LocationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.HospitalizationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.DiagnosisComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.ClassHistoryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.StatusHistoryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.CertaintySubcomponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.CertaintyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.PrecisionEstimateComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.EffectEstimateComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.ResultsByExposureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.SampleSizeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DocumentReference.ContextComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DocumentReference.ContentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DocumentReference.RelatesToComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DocumentManifest.RelatedComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DiagnosticReport.MediaComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceRequest.ParameterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceMetric.CalibrationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.MaterialComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.PropertyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.CapabilityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.SpecializationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.DeviceNameComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.UdiDeviceIdentifierComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Device.PropertyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Device.VersionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Device.SpecializationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Device.DeviceNameComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Device.UdiCarrierComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DetectedIssue.MitigationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DetectedIssue.EvidenceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityResponse.ErrorsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityResponse.BenefitComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityResponse.ItemsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityResponse.InsuranceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityRequest.DiagnosisComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityRequest.DetailsComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityRequest.InsuranceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityRequest.SupportingInformationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Coverage.ExemptionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Coverage.CostToBeneficiaryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Coverage.ClassComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ComputableLanguageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.LegalLanguageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.FriendlyLanguageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.SignatoryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ActionSubjectComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ActionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ValuedItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.AssetContextComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ContractAssetComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.AnswerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ContractPartyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ContractOfferComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.SecurityLabelComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.TermComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.ContentDefinitionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Consent.provisionDataComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Consent.provisionActorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Consent.provisionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Consent.VerificationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Consent.PolicyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Condition.EvidenceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Condition.StageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ConceptMap.UnmappedComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ConceptMap.OtherElementComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ConceptMap.TargetElementComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ConceptMap.SourceElementComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ConceptMap.GroupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Composition.SectionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Composition.EventComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Composition.RelatesToComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Composition.AttesterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CompartmentDefinition.ResourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CommunicationRequest.PayloadComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Communication.PayloadComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeSystem.ConceptPropertyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeSystem.DesignationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeSystem.ConceptDefinitionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeSystem.PropertyComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeSystem.FilterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClinicalImpression.FindingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClinicalImpression.InvestigationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.ErrorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.InsuranceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.NoteComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.PaymentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.TotalComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.AddedItemSubDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.AddedItemDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.AddedItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.SubDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.ItemDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.AdjudicationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.ItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.SubDetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.DetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.ItemComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.AccidentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.InsuranceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.ProcedureComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.DiagnosisComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.SupportingInformationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.CareTeamComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.PayeeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.RelatedClaimComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ChargeItemDefinition.PriceComponentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ChargeItemDefinition.PropertyGroupComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ChargeItemDefinition.ApplicabilityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ChargeItem.PerformerComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CatalogEntry.RelatedEntryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CareTeam.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CarePlan.DetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CarePlan.ActivityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.DocumentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.SupportedMessageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.EndpointComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.MessagingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.SystemInteractionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.OperationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.SearchParamComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.ResourceInteractionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.ResourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.SecurityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.RestComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.ImplementationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.SoftwareComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Bundle.ResponseComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Bundle.RequestComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Bundle.SearchComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Bundle.LinkComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Bundle.EntryComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BiologicallyDerivedProduct.StorageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BiologicallyDerivedProduct.ManipulationComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BiologicallyDerivedProduct.ProcessingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BiologicallyDerivedProduct.CollectionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AuditEvent.DetailComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AuditEvent.EntityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AuditEvent.SourceComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AuditEvent.NetworkComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AuditEvent.AgentComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Appointment.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AllergyIntolerance.ReactionComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AdverseEvent.CausalityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AdverseEvent.SuspectEntityComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ActivityDefinition.DynamicValueComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ActivityDefinition.ParticipantComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Account.GuarantorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Account.CoverageComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.XHtml.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Uuid.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.UsageContext.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FhirUrl.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FhirUri.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.UnsignedInt.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TriggerDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Timing.RepeatComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Timing.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Time.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceAmount.ReferenceRangeComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceAmount.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FhirString.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Signature.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SampledData.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RelatedArtifact.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResourceReference.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Ratio.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Range.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Quantity.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ProductShelfLife.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ProdCharacteristic.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PositiveInt.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Population.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Period.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ParameterDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Oid.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Narrative.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Money.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Meta.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MarketingStatus.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Markdown.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Integer.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Instant.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Identifier.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Id.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.HumanName.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Extension.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Expression.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.MappingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.ElementDefinitionBindingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.ConstraintComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.ExampleComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.BaseComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.SlicingComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.TypeRefComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.DiscriminatorComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ElementDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Dosage.DoseAndRateComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Dosage.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Distance.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FhirDecimal.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FhirDateTime.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Date.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DataRequirement.SortComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DataRequirement.DateFilterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DataRequirement.CodeFilterComponent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DataRequirement.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Count.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contributor.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ContactPoint.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ContactDetail.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Coding.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeableConcept.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Code.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Canonical.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FhirBoolean.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Base64Binary.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BackboneElement.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Attachment.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Annotation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Age.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Address.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VisionPrescription.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.VerificationResult.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ValueSet.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestScript.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TestReport.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.TerminologyCapabilities.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Task.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SupplyRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SupplyDelivery.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSpecification.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceSourceMaterial.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceReferenceInformation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceProtein.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstancePolymer.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SubstanceNucleicAcid.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Substance.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Subscription.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureMap.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.StructureDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SpecimenDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Specimen.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Slot.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ServiceRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.SearchParameter.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Schedule.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskEvidenceSynthesis.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RiskAssessment.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchSubject.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchStudy.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchElementDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ResearchDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RequestGroup.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.RelatedPerson.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.QuestionnaireResponse.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Questionnaire.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Provenance.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Procedure.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PractitionerRole.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Practitioner.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PlanDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Person.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PaymentReconciliation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.PaymentNotice.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Patient.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Parameters.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OrganizationAffiliation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Organization.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationOutcome.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.OperationDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ObservationDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Observation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NutritionOrder.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.NamingSystem.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MolecularSequence.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageHeader.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MessageDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductUndesirableEffect.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPharmaceutical.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductPackaged.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductManufactured.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductInteraction.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIngredient.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductIndication.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductContraindication.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProductAuthorization.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicinalProduct.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationStatement.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationKnowledge.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationDispense.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MedicationAdministration.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Medication.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Media.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.MeasureReport.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Measure.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Location.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.List.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Linkage.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Library.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Invoice.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.InsurancePlan.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImplementationGuide.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImmunizationRecommendation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImmunizationEvaluation.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Immunization.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ImagingStudy.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.HealthcareService.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.GuidanceResponse.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Group.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.GraphDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Goal.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Flag.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.FamilyMemberHistory.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExplanationOfBenefit.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ExampleScenario.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EvidenceVariable.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Evidence.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EventDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EpisodeOfCare.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EnrollmentResponse.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EnrollmentRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Endpoint.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Encounter.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.EffectEvidenceSynthesis.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DocumentReference.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DocumentManifest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DiagnosticReport.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceUseStatement.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceMetric.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DeviceDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Device.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.DetectedIssue.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityResponse.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CoverageEligibilityRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Coverage.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Contract.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Consent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Condition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ConceptMap.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Composition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CompartmentDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CommunicationRequest.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Communication.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CodeSystem.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClinicalImpression.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ClaimResponse.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Claim.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ChargeItemDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ChargeItem.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CatalogEntry.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CareTeam.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CarePlan.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.CapabilityStatement.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Bundle.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BodyStructure.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.BiologicallyDerivedProduct.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Binary.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Basic.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AuditEvent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AppointmentResponse.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Appointment.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AllergyIntolerance.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.AdverseEvent.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.ActivityDefinition.cs
// C:\git\fhir-net-web-api\src\Hl7.Fhir.Custom.Serializers\Generated\FhirCustomXmlReader.Account.cs
