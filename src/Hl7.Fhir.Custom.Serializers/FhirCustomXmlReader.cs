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
                case "AdministrableProductDefinition":
                    result = new AdministrableProductDefinition();
                    Parse(result as AdministrableProductDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "Citation":
                    result = new Citation();
                    Parse(result as Citation, reader, outcome, locationPath, cancellationToken);
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
                case "ClinicalUseDefinition":
                    result = new ClinicalUseDefinition();
                    Parse(result as ClinicalUseDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "EvidenceReport":
                    result = new EvidenceReport();
                    Parse(result as EvidenceReport, reader, outcome, locationPath, cancellationToken);
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
                case "Ingredient":
                    result = new Ingredient();
                    Parse(result as Ingredient, reader, outcome, locationPath, cancellationToken);
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
                case "ManufacturedItemDefinition":
                    result = new ManufacturedItemDefinition();
                    Parse(result as ManufacturedItemDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "MedicinalProductDefinition":
                    result = new MedicinalProductDefinition();
                    Parse(result as MedicinalProductDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "NutritionProduct":
                    result = new NutritionProduct();
                    Parse(result as NutritionProduct, reader, outcome, locationPath, cancellationToken);
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
                case "PackagedProductDefinition":
                    result = new PackagedProductDefinition();
                    Parse(result as PackagedProductDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "RegulatedAuthorization":
                    result = new RegulatedAuthorization();
                    Parse(result as RegulatedAuthorization, reader, outcome, locationPath, cancellationToken);
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
                case "SubscriptionStatus":
                    result = new SubscriptionStatus();
                    Parse(result as SubscriptionStatus, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubscriptionTopic":
                    result = new SubscriptionTopic();
                    Parse(result as SubscriptionTopic, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Substance":
                    result = new Substance();
                    Parse(result as Substance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceDefinition":
                    result = new SubstanceDefinition();
                    Parse(result as SubstanceDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "AdministrableProductDefinition":
                    result = new AdministrableProductDefinition();
                    await ParseAsync(result as AdministrableProductDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "Citation":
                    result = new Citation();
                    await ParseAsync(result as Citation, reader, outcome, locationPath, cancellationToken);
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
                case "ClinicalUseDefinition":
                    result = new ClinicalUseDefinition();
                    await ParseAsync(result as ClinicalUseDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "EvidenceReport":
                    result = new EvidenceReport();
                    await ParseAsync(result as EvidenceReport, reader, outcome, locationPath, cancellationToken);
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
                case "Ingredient":
                    result = new Ingredient();
                    await ParseAsync(result as Ingredient, reader, outcome, locationPath, cancellationToken);
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
                case "ManufacturedItemDefinition":
                    result = new ManufacturedItemDefinition();
                    await ParseAsync(result as ManufacturedItemDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "MedicinalProductDefinition":
                    result = new MedicinalProductDefinition();
                    await ParseAsync(result as MedicinalProductDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "NutritionProduct":
                    result = new NutritionProduct();
                    await ParseAsync(result as NutritionProduct, reader, outcome, locationPath, cancellationToken);
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
                case "PackagedProductDefinition":
                    result = new PackagedProductDefinition();
                    await ParseAsync(result as PackagedProductDefinition, reader, outcome, locationPath, cancellationToken);
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
                case "RegulatedAuthorization":
                    result = new RegulatedAuthorization();
                    await ParseAsync(result as RegulatedAuthorization, reader, outcome, locationPath, cancellationToken);
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
                case "SubscriptionStatus":
                    result = new SubscriptionStatus();
                    await ParseAsync(result as SubscriptionStatus, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubscriptionTopic":
                    result = new SubscriptionTopic();
                    await ParseAsync(result as SubscriptionTopic, reader, outcome, locationPath, cancellationToken);
                    break;
                case "Substance":
                    result = new Substance();
                    await ParseAsync(result as Substance, reader, outcome, locationPath, cancellationToken);
                    break;
                case "SubstanceDefinition":
                    result = new SubstanceDefinition();
                    await ParseAsync(result as SubstanceDefinition, reader, outcome, locationPath, cancellationToken);
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
