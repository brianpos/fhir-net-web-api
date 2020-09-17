// -----------------------------------------------------------------------------
// GENERATED CODE - DO NOT EDIT
// Generated: 09/17/2020 09:24:14
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
    public partial class CustomFhirXmlSerializer : XmlSerializer
    {
		public static void Serialize(Account name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Account", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.ServicePeriod, writer, "servicePeriod", cancellationToken); // 140
			Serialize(name.Coverage, writer, "coverage", cancellationToken); // 150
			Serialize(name.Owner, writer, "owner", cancellationToken); // 160
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 170
			Serialize(name.Guarantor, writer, "guarantor", cancellationToken); // 180
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(ActivityDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ActivityDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 170
			Serialize(name.DateElement, writer, "date", cancellationToken); // 180
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Serialize(name.Contact, writer, "contact", cancellationToken); // 200
			Serialize(name.Description, writer, "description", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 240
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 250
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 260
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 270
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 280
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 290
			Serialize(name.Topic, writer, "topic", cancellationToken); // 300
			Serialize(name.Author, writer, "author", cancellationToken); // 310
			Serialize(name.Editor, writer, "editor", cancellationToken); // 320
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 330
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 340
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 350
			Serialize(name.LibraryElement, writer, "library", cancellationToken); // 360
			Serialize(name.KindElement, writer, "kind", cancellationToken); // 370
			Serialize(name.ProfileElement, writer, "profile", cancellationToken); // 380
			Serialize(name.Code, writer, "code", cancellationToken); // 390
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 400
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 410
			Serialize(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 420
			Serialize(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 430
			Serialize(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 430
			Serialize(name.Timing as Hl7.Fhir.Model.Age, writer, "timingAge", cancellationToken); // 430
			Serialize(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 430
			Serialize(name.Timing as Hl7.Fhir.Model.Range, writer, "timingRange", cancellationToken); // 430
			Serialize(name.Timing as Hl7.Fhir.Model.Duration, writer, "timingDuration", cancellationToken); // 430
			Serialize(name.Location, writer, "location", cancellationToken); // 440
			Serialize(name.Participant, writer, "participant", cancellationToken); // 450
			Serialize(name.Product as Hl7.Fhir.Model.ResourceReference, writer, "productReference", cancellationToken); // 460
			Serialize(name.Product as Hl7.Fhir.Model.CodeableConcept, writer, "productCodeableConcept", cancellationToken); // 460
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 470
			Serialize(name.Dosage, writer, "dosage", cancellationToken); // 480
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 490
			Serialize(name.SpecimenRequirement, writer, "specimenRequirement", cancellationToken); // 500
			Serialize(name.ObservationRequirement, writer, "observationRequirement", cancellationToken); // 510
			Serialize(name.ObservationResultRequirement, writer, "observationResultRequirement", cancellationToken); // 520
			Serialize(name.TransformElement, writer, "transform", cancellationToken); // 530
			Serialize(name.DynamicValue, writer, "dynamicValue", cancellationToken); // 540
			writer.WriteEndElement();
		}

		public static void Serialize(AdverseEvent name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AdverseEvent", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActualityElement, writer, "actuality", cancellationToken); // 100
			Serialize(name.Category, writer, "category", cancellationToken); // 110
			Serialize(name.Event, writer, "event", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.DetectedElement, writer, "detected", cancellationToken); // 160
			Serialize(name.RecordedDateElement, writer, "recordedDate", cancellationToken); // 170
			Serialize(name.ResultingCondition, writer, "resultingCondition", cancellationToken); // 180
			Serialize(name.Location, writer, "location", cancellationToken); // 190
			Serialize(name.Seriousness, writer, "seriousness", cancellationToken); // 200
			Serialize(name.Severity, writer, "severity", cancellationToken); // 210
			Serialize(name.Outcome, writer, "outcome", cancellationToken); // 220
			Serialize(name.Recorder, writer, "recorder", cancellationToken); // 230
			Serialize(name.Contributor, writer, "contributor", cancellationToken); // 240
			Serialize(name.SuspectEntity, writer, "suspectEntity", cancellationToken); // 250
			Serialize(name.SubjectMedicalHistory, writer, "subjectMedicalHistory", cancellationToken); // 260
			Serialize(name.ReferenceDocument, writer, "referenceDocument", cancellationToken); // 270
			Serialize(name.Study, writer, "study", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Serialize(AllergyIntolerance name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AllergyIntolerance", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ClinicalStatus, writer, "clinicalStatus", cancellationToken); // 100
			Serialize(name.VerificationStatus, writer, "verificationStatus", cancellationToken); // 110
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 120
			Serialize(name.CategoryElement, writer, "category", cancellationToken); // 130
			Serialize(name.CriticalityElement, writer, "criticality", cancellationToken); // 140
			Serialize(name.Code, writer, "code", cancellationToken); // 150
			Serialize(name.Patient, writer, "patient", cancellationToken); // 160
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 170
			Serialize(name.Onset as Hl7.Fhir.Model.FhirDateTime, writer, "onsetDateTime", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.Age, writer, "onsetAge", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.Period, writer, "onsetPeriod", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.Range, writer, "onsetRange", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.FhirString, writer, "onsetString", cancellationToken); // 180
			Serialize(name.RecordedDateElement, writer, "recordedDate", cancellationToken); // 190
			Serialize(name.Recorder, writer, "recorder", cancellationToken); // 200
			Serialize(name.Asserter, writer, "asserter", cancellationToken); // 210
			Serialize(name.LastOccurrenceElement, writer, "lastOccurrence", cancellationToken); // 220
			Serialize(name.Note, writer, "note", cancellationToken); // 230
			Serialize(name.Reaction, writer, "reaction", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(Appointment name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Appointment", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.CancelationReason, writer, "cancelationReason", cancellationToken); // 110
			Serialize(name.ServiceCategory, writer, "serviceCategory", cancellationToken); // 120
			Serialize(name.ServiceType, writer, "serviceType", cancellationToken); // 130
			Serialize(name.Specialty, writer, "specialty", cancellationToken); // 140
			Serialize(name.AppointmentType, writer, "appointmentType", cancellationToken); // 150
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 160
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 170
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 180
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 190
			Serialize(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 200
			Serialize(name.StartElement, writer, "start", cancellationToken); // 210
			Serialize(name.EndElement, writer, "end", cancellationToken); // 220
			Serialize(name.MinutesDurationElement, writer, "minutesDuration", cancellationToken); // 230
			Serialize(name.Slot, writer, "slot", cancellationToken); // 240
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 250
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 260
			Serialize(name.PatientInstructionElement, writer, "patientInstruction", cancellationToken); // 270
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 280
			Serialize(name.Participant, writer, "participant", cancellationToken); // 290
			Serialize(name.RequestedPeriod, writer, "requestedPeriod", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Serialize(AppointmentResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AppointmentResponse", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Appointment, writer, "appointment", cancellationToken); // 100
			Serialize(name.StartElement, writer, "start", cancellationToken); // 110
			Serialize(name.EndElement, writer, "end", cancellationToken); // 120
			Serialize(name.ParticipantType, writer, "participantType", cancellationToken); // 130
			Serialize(name.Actor, writer, "actor", cancellationToken); // 140
			Serialize(name.ParticipantStatusElement, writer, "participantStatus", cancellationToken); // 150
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(AuditEvent name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AuditEvent", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Type, writer, "type", cancellationToken); // 90
			Serialize(name.Subtype, writer, "subtype", cancellationToken); // 100
			Serialize(name.ActionElement, writer, "action", cancellationToken); // 110
			Serialize(name.Period, writer, "period", cancellationToken); // 120
			Serialize(name.RecordedElement, writer, "recorded", cancellationToken); // 130
			Serialize(name.OutcomeElement, writer, "outcome", cancellationToken); // 140
			Serialize(name.OutcomeDescElement, writer, "outcomeDesc", cancellationToken); // 150
			Serialize(name.PurposeOfEvent, writer, "purposeOfEvent", cancellationToken); // 160
			Serialize(name.Agent, writer, "agent", cancellationToken); // 170
			Serialize(name.Source, writer, "source", cancellationToken); // 180
			Serialize(name.Entity, writer, "entity", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(Basic name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Basic", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Code, writer, "code", cancellationToken); // 100
			Serialize(name.Subject, writer, "subject", cancellationToken); // 110
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 120
			Serialize(name.Author, writer, "author", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Serialize(Binary name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Binary", XmlNs.FHIR);
			SerializeResource(name, writer, cancellationToken);
			Serialize(name.ContentTypeElement, writer, "contentType", cancellationToken); // 50
			Serialize(name.SecurityContext, writer, "securityContext", cancellationToken); // 60
			Serialize(name.DataElement, writer, "data", cancellationToken); // 70
			writer.WriteEndElement();
		}

		public static void Serialize(BiologicallyDerivedProduct name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("BiologicallyDerivedProduct", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ProductCategoryElement, writer, "productCategory", cancellationToken); // 100
			Serialize(name.ProductCode, writer, "productCode", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.Request, writer, "request", cancellationToken); // 130
			Serialize(name.QuantityElement, writer, "quantity", cancellationToken); // 140
			Serialize(name.Parent, writer, "parent", cancellationToken); // 150
			Serialize(name.Collection, writer, "collection", cancellationToken); // 160
			Serialize(name.Processing, writer, "processing", cancellationToken); // 170
			Serialize(name.Manipulation, writer, "manipulation", cancellationToken); // 180
			Serialize(name.Storage, writer, "storage", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(BodyStructure name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("BodyStructure", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Morphology, writer, "morphology", cancellationToken); // 110
			Serialize(name.Location, writer, "location", cancellationToken); // 120
			Serialize(name.LocationQualifier, writer, "locationQualifier", cancellationToken); // 130
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 140
			Serialize(name.Image, writer, "image", cancellationToken); // 150
			Serialize(name.Patient, writer, "patient", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(Bundle name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Bundle", XmlNs.FHIR);
			SerializeResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 50
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 60
			Serialize(name.TimestampElement, writer, "timestamp", cancellationToken); // 70
			Serialize(name.TotalElement, writer, "total", cancellationToken); // 80
			Serialize(name.Link, writer, "link", cancellationToken); // 90
			Serialize(name.Entry, writer, "entry", cancellationToken); // 100
			Serialize(name.Signature, writer, "signature", cancellationToken); // 110
			writer.WriteEndElement();
		}

		public static void Serialize(CapabilityStatement name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CapabilityStatement", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Description, writer, "description", cancellationToken); // 180
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 190
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 210
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 220
			Serialize(name.KindElement, writer, "kind", cancellationToken); // 230
			Serialize(name.InstantiatesElement, writer, "instantiates", cancellationToken); // 240
			Serialize(name.ImportsElement, writer, "imports", cancellationToken); // 250
			Serialize(name.Software, writer, "software", cancellationToken); // 260
			Serialize(name.Implementation, writer, "implementation", cancellationToken); // 270
			Serialize(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 280
			Serialize(name.FormatElement, writer, "format", cancellationToken); // 290
			Serialize(name.PatchFormatElement, writer, "patchFormat", cancellationToken); // 300
			Serialize(name.ImplementationGuideElement, writer, "implementationGuide", cancellationToken); // 310
			Serialize(name.Rest, writer, "rest", cancellationToken); // 320
			Serialize(name.Messaging, writer, "messaging", cancellationToken); // 330
			Serialize(name.Document, writer, "document", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Serialize(CarePlan name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CarePlan", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.Replaces, writer, "replaces", cancellationToken); // 130
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 160
			Serialize(name.Category, writer, "category", cancellationToken); // 170
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 180
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 190
			Serialize(name.Subject, writer, "subject", cancellationToken); // 200
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 210
			Serialize(name.Period, writer, "period", cancellationToken); // 220
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 230
			Serialize(name.Author, writer, "author", cancellationToken); // 240
			Serialize(name.Contributor, writer, "contributor", cancellationToken); // 250
			Serialize(name.CareTeam, writer, "careTeam", cancellationToken); // 260
			Serialize(name.Addresses, writer, "addresses", cancellationToken); // 270
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 280
			Serialize(name.Goal, writer, "goal", cancellationToken); // 290
			Serialize(name.Activity, writer, "activity", cancellationToken); // 300
			Serialize(name.Note, writer, "note", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Serialize(CareTeam name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CareTeam", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Category, writer, "category", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 140
			Serialize(name.Period, writer, "period", cancellationToken); // 150
			Serialize(name.Participant, writer, "participant", cancellationToken); // 160
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 170
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 180
			Serialize(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 190
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 200
			Serialize(name.Note, writer, "note", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(CatalogEntry name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CatalogEntry", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Type, writer, "type", cancellationToken); // 100
			Serialize(name.OrderableElement, writer, "orderable", cancellationToken); // 110
			Serialize(name.ReferencedItem, writer, "referencedItem", cancellationToken); // 120
			Serialize(name.AdditionalIdentifier, writer, "additionalIdentifier", cancellationToken); // 130
			Serialize(name.Classification, writer, "classification", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 160
			Serialize(name.ValidToElement, writer, "validTo", cancellationToken); // 170
			Serialize(name.LastUpdatedElement, writer, "lastUpdated", cancellationToken); // 180
			Serialize(name.AdditionalCharacteristic, writer, "additionalCharacteristic", cancellationToken); // 190
			Serialize(name.AdditionalClassification, writer, "additionalClassification", cancellationToken); // 200
			Serialize(name.RelatedEntry, writer, "relatedEntry", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(ChargeItem name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ChargeItem", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.DefinitionUriElement, writer, "definitionUri", cancellationToken); // 100
			Serialize(name.DefinitionCanonicalElement, writer, "definitionCanonical", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 130
			Serialize(name.Code, writer, "code", cancellationToken); // 140
			Serialize(name.Subject, writer, "subject", cancellationToken); // 150
			Serialize(name.Context, writer, "context", cancellationToken); // 160
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 170
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 170
			Serialize(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 170
			Serialize(name.Performer, writer, "performer", cancellationToken); // 180
			Serialize(name.PerformingOrganization, writer, "performingOrganization", cancellationToken); // 190
			Serialize(name.RequestingOrganization, writer, "requestingOrganization", cancellationToken); // 200
			Serialize(name.CostCenter, writer, "costCenter", cancellationToken); // 210
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 220
			Serialize(name.Bodysite, writer, "bodysite", cancellationToken); // 230
			Serialize(name.FactorOverrideElement, writer, "factorOverride", cancellationToken); // 240
			Serialize(name.PriceOverride, writer, "priceOverride", cancellationToken); // 250
			Serialize(name.OverrideReasonElement, writer, "overrideReason", cancellationToken); // 260
			Serialize(name.Enterer, writer, "enterer", cancellationToken); // 270
			Serialize(name.EnteredDateElement, writer, "enteredDate", cancellationToken); // 280
			Serialize(name.Reason, writer, "reason", cancellationToken); // 290
			Serialize(name.Service, writer, "service", cancellationToken); // 300
			Serialize(name.Product as Hl7.Fhir.Model.ResourceReference, writer, "productReference", cancellationToken); // 310
			Serialize(name.Product as Hl7.Fhir.Model.CodeableConcept, writer, "productCodeableConcept", cancellationToken); // 310
			Serialize(name.Account, writer, "account", cancellationToken); // 320
			Serialize(name.Note, writer, "note", cancellationToken); // 330
			Serialize(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Serialize(ChargeItemDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ChargeItemDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 120
			Serialize(name.DerivedFromUriElement, writer, "derivedFromUri", cancellationToken); // 130
			Serialize(name.PartOfElement, writer, "partOf", cancellationToken); // 140
			Serialize(name.ReplacesElement, writer, "replaces", cancellationToken); // 150
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 160
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Serialize(name.DateElement, writer, "date", cancellationToken); // 180
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Serialize(name.Contact, writer, "contact", cancellationToken); // 200
			Serialize(name.Description, writer, "description", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 240
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 250
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 260
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 270
			Serialize(name.Code, writer, "code", cancellationToken); // 280
			Serialize(name.Instance, writer, "instance", cancellationToken); // 290
			Serialize(name.Applicability, writer, "applicability", cancellationToken); // 300
			Serialize(name.PropertyGroup, writer, "propertyGroup", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Serialize(Claim name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Claim", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.SubType, writer, "subType", cancellationToken); // 120
			Serialize(name.UseElement, writer, "use", cancellationToken); // 130
			Serialize(name.Patient, writer, "patient", cancellationToken); // 140
			Serialize(name.BillablePeriod, writer, "billablePeriod", cancellationToken); // 150
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 160
			Serialize(name.Enterer, writer, "enterer", cancellationToken); // 170
			Serialize(name.Insurer, writer, "insurer", cancellationToken); // 180
			Serialize(name.Provider, writer, "provider", cancellationToken); // 190
			Serialize(name.Priority, writer, "priority", cancellationToken); // 200
			Serialize(name.FundsReserve, writer, "fundsReserve", cancellationToken); // 210
			Serialize(name.Related, writer, "related", cancellationToken); // 220
			Serialize(name.Prescription, writer, "prescription", cancellationToken); // 230
			Serialize(name.OriginalPrescription, writer, "originalPrescription", cancellationToken); // 240
			Serialize(name.Payee, writer, "payee", cancellationToken); // 250
			Serialize(name.Referral, writer, "referral", cancellationToken); // 260
			Serialize(name.Facility, writer, "facility", cancellationToken); // 270
			Serialize(name.CareTeam, writer, "careTeam", cancellationToken); // 280
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 290
			Serialize(name.Diagnosis, writer, "diagnosis", cancellationToken); // 300
			Serialize(name.Procedure, writer, "procedure", cancellationToken); // 310
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 320
			Serialize(name.Accident, writer, "accident", cancellationToken); // 330
			Serialize(name.Item, writer, "item", cancellationToken); // 340
			Serialize(name.Total, writer, "total", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Serialize(ClaimResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ClaimResponse", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.SubType, writer, "subType", cancellationToken); // 120
			Serialize(name.UseElement, writer, "use", cancellationToken); // 130
			Serialize(name.Patient, writer, "patient", cancellationToken); // 140
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 150
			Serialize(name.Insurer, writer, "insurer", cancellationToken); // 160
			Serialize(name.Requestor, writer, "requestor", cancellationToken); // 170
			Serialize(name.Request, writer, "request", cancellationToken); // 180
			Serialize(name.OutcomeElement, writer, "outcome", cancellationToken); // 190
			Serialize(name.DispositionElement, writer, "disposition", cancellationToken); // 200
			Serialize(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 210
			Serialize(name.PreAuthPeriod, writer, "preAuthPeriod", cancellationToken); // 220
			Serialize(name.PayeeType, writer, "payeeType", cancellationToken); // 230
			Serialize(name.Item, writer, "item", cancellationToken); // 240
			Serialize(name.AddItem, writer, "addItem", cancellationToken); // 250
			Serialize(name.Adjudication, writer, "adjudication", cancellationToken); // 260
			Serialize(name.Total, writer, "total", cancellationToken); // 270
			Serialize(name.Payment, writer, "payment", cancellationToken); // 280
			Serialize(name.FundsReserve, writer, "fundsReserve", cancellationToken); // 290
			Serialize(name.FormCode, writer, "formCode", cancellationToken); // 300
			Serialize(name.Form, writer, "form", cancellationToken); // 310
			Serialize(name.ProcessNote, writer, "processNote", cancellationToken); // 320
			Serialize(name.CommunicationRequest, writer, "communicationRequest", cancellationToken); // 330
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 340
			Serialize(name.Error, writer, "error", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Serialize(ClinicalImpression name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ClinicalImpression", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 110
			Serialize(name.Code, writer, "code", cancellationToken); // 120
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 130
			Serialize(name.Subject, writer, "subject", cancellationToken); // 140
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 150
			Serialize(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 160
			Serialize(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 160
			Serialize(name.DateElement, writer, "date", cancellationToken); // 170
			Serialize(name.Assessor, writer, "assessor", cancellationToken); // 180
			Serialize(name.Previous, writer, "previous", cancellationToken); // 190
			Serialize(name.Problem, writer, "problem", cancellationToken); // 200
			Serialize(name.Investigation, writer, "investigation", cancellationToken); // 210
			Serialize(name.ProtocolElement, writer, "protocol", cancellationToken); // 220
			Serialize(name.SummaryElement, writer, "summary", cancellationToken); // 230
			Serialize(name.Finding, writer, "finding", cancellationToken); // 240
			Serialize(name.PrognosisCodeableConcept, writer, "prognosisCodeableConcept", cancellationToken); // 250
			Serialize(name.PrognosisReference, writer, "prognosisReference", cancellationToken); // 260
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 270
			Serialize(name.Note, writer, "note", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Serialize(CodeSystem name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CodeSystem", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 220
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 230
			Serialize(name.CaseSensitiveElement, writer, "caseSensitive", cancellationToken); // 240
			Serialize(name.ValueSetElement, writer, "valueSet", cancellationToken); // 250
			Serialize(name.HierarchyMeaningElement, writer, "hierarchyMeaning", cancellationToken); // 260
			Serialize(name.CompositionalElement, writer, "compositional", cancellationToken); // 270
			Serialize(name.VersionNeededElement, writer, "versionNeeded", cancellationToken); // 280
			Serialize(name.ContentElement, writer, "content", cancellationToken); // 290
			Serialize(name.SupplementsElement, writer, "supplements", cancellationToken); // 300
			Serialize(name.CountElement, writer, "count", cancellationToken); // 310
			Serialize(name.Filter, writer, "filter", cancellationToken); // 320
			Serialize(name.Property, writer, "property", cancellationToken); // 330
			Serialize(name.Concept, writer, "concept", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Serialize(Communication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Communication", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 130
			Serialize(name.InResponseTo, writer, "inResponseTo", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 160
			Serialize(name.Category, writer, "category", cancellationToken); // 170
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 180
			Serialize(name.Medium, writer, "medium", cancellationToken); // 190
			Serialize(name.Subject, writer, "subject", cancellationToken); // 200
			Serialize(name.Topic, writer, "topic", cancellationToken); // 210
			Serialize(name.About, writer, "about", cancellationToken); // 220
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 230
			Serialize(name.SentElement, writer, "sent", cancellationToken); // 240
			Serialize(name.ReceivedElement, writer, "received", cancellationToken); // 250
			Serialize(name.Recipient, writer, "recipient", cancellationToken); // 260
			Serialize(name.Sender, writer, "sender", cancellationToken); // 270
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 280
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 290
			Serialize(name.Payload, writer, "payload", cancellationToken); // 300
			Serialize(name.Note, writer, "note", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Serialize(CommunicationRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CommunicationRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.Replaces, writer, "replaces", cancellationToken); // 110
			Serialize(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 140
			Serialize(name.Category, writer, "category", cancellationToken); // 150
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 160
			Serialize(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 170
			Serialize(name.Medium, writer, "medium", cancellationToken); // 180
			Serialize(name.Subject, writer, "subject", cancellationToken); // 190
			Serialize(name.About, writer, "about", cancellationToken); // 200
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 210
			Serialize(name.Payload, writer, "payload", cancellationToken); // 220
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 230
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 230
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 240
			Serialize(name.Requester, writer, "requester", cancellationToken); // 250
			Serialize(name.Recipient, writer, "recipient", cancellationToken); // 260
			Serialize(name.Sender, writer, "sender", cancellationToken); // 270
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 280
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 290
			Serialize(name.Note, writer, "note", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Serialize(CompartmentDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CompartmentDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 130
			Serialize(name.DateElement, writer, "date", cancellationToken); // 140
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 150
			Serialize(name.Contact, writer, "contact", cancellationToken); // 160
			Serialize(name.Description, writer, "description", cancellationToken); // 170
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 180
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 190
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 200
			Serialize(name.SearchElement, writer, "search", cancellationToken); // 210
			Serialize(name.Resource, writer, "resource", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Serialize(Composition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Composition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.Category, writer, "category", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.Author, writer, "author", cancellationToken); // 160
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 170
			Serialize(name.ConfidentialityElement, writer, "confidentiality", cancellationToken); // 180
			Serialize(name.Attester, writer, "attester", cancellationToken); // 190
			Serialize(name.Custodian, writer, "custodian", cancellationToken); // 200
			Serialize(name.RelatesTo, writer, "relatesTo", cancellationToken); // 210
			Serialize(name.Event, writer, "event", cancellationToken); // 220
			Serialize(name.Section, writer, "section", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Serialize(ConceptMap name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ConceptMap", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 220
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 230
			Serialize(name.Source as Hl7.Fhir.Model.FhirUri, writer, "sourceUri", cancellationToken); // 240
			Serialize(name.Source as Hl7.Fhir.Model.Canonical, writer, "sourceCanonical", cancellationToken); // 240
			Serialize(name.Target as Hl7.Fhir.Model.FhirUri, writer, "targetUri", cancellationToken); // 250
			Serialize(name.Target as Hl7.Fhir.Model.Canonical, writer, "targetCanonical", cancellationToken); // 250
			Serialize(name.Group, writer, "group", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Serialize(Condition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Condition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ClinicalStatus, writer, "clinicalStatus", cancellationToken); // 100
			Serialize(name.VerificationStatus, writer, "verificationStatus", cancellationToken); // 110
			Serialize(name.Category, writer, "category", cancellationToken); // 120
			Serialize(name.Severity, writer, "severity", cancellationToken); // 130
			Serialize(name.Code, writer, "code", cancellationToken); // 140
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 150
			Serialize(name.Subject, writer, "subject", cancellationToken); // 160
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 170
			Serialize(name.Onset as Hl7.Fhir.Model.FhirDateTime, writer, "onsetDateTime", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.Age, writer, "onsetAge", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.Period, writer, "onsetPeriod", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.Range, writer, "onsetRange", cancellationToken); // 180
			Serialize(name.Onset as Hl7.Fhir.Model.FhirString, writer, "onsetString", cancellationToken); // 180
			Serialize(name.Abatement as Hl7.Fhir.Model.FhirDateTime, writer, "abatementDateTime", cancellationToken); // 190
			Serialize(name.Abatement as Hl7.Fhir.Model.Age, writer, "abatementAge", cancellationToken); // 190
			Serialize(name.Abatement as Hl7.Fhir.Model.Period, writer, "abatementPeriod", cancellationToken); // 190
			Serialize(name.Abatement as Hl7.Fhir.Model.Range, writer, "abatementRange", cancellationToken); // 190
			Serialize(name.Abatement as Hl7.Fhir.Model.FhirString, writer, "abatementString", cancellationToken); // 190
			Serialize(name.RecordedDateElement, writer, "recordedDate", cancellationToken); // 200
			Serialize(name.Recorder, writer, "recorder", cancellationToken); // 210
			Serialize(name.Asserter, writer, "asserter", cancellationToken); // 220
			Serialize(name.Stage, writer, "stage", cancellationToken); // 230
			Serialize(name.Evidence, writer, "evidence", cancellationToken); // 240
			Serialize(name.Note, writer, "note", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(Consent name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Consent", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Scope, writer, "scope", cancellationToken); // 110
			Serialize(name.Category, writer, "category", cancellationToken); // 120
			Serialize(name.Patient, writer, "patient", cancellationToken); // 130
			Serialize(name.DateTimeElement, writer, "dateTime", cancellationToken); // 140
			Serialize(name.Performer, writer, "performer", cancellationToken); // 150
			Serialize(name.Organization, writer, "organization", cancellationToken); // 160
			Serialize(name.Source as Hl7.Fhir.Model.Attachment, writer, "sourceAttachment", cancellationToken); // 170
			Serialize(name.Source as Hl7.Fhir.Model.ResourceReference, writer, "sourceReference", cancellationToken); // 170
			Serialize(name.Policy, writer, "policy", cancellationToken); // 180
			Serialize(name.PolicyRule, writer, "policyRule", cancellationToken); // 190
			Serialize(name.Verification, writer, "verification", cancellationToken); // 200
			Serialize(name.Provision, writer, "provision", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(Contract name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Contract", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.LegalState, writer, "legalState", cancellationToken); // 130
			Serialize(name.InstantiatesCanonical, writer, "instantiatesCanonical", cancellationToken); // 140
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 150
			Serialize(name.ContentDerivative, writer, "contentDerivative", cancellationToken); // 160
			Serialize(name.IssuedElement, writer, "issued", cancellationToken); // 170
			Serialize(name.Applies, writer, "applies", cancellationToken); // 180
			Serialize(name.ExpirationType, writer, "expirationType", cancellationToken); // 190
			Serialize(name.Subject, writer, "subject", cancellationToken); // 200
			Serialize(name.Authority, writer, "authority", cancellationToken); // 210
			Serialize(name.Domain, writer, "domain", cancellationToken); // 220
			Serialize(name.Site, writer, "site", cancellationToken); // 230
			Serialize(name.NameElement, writer, "name", cancellationToken); // 240
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 250
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 260
			Serialize(name.AliasElement, writer, "alias", cancellationToken); // 270
			Serialize(name.Author, writer, "author", cancellationToken); // 280
			Serialize(name.Scope, writer, "scope", cancellationToken); // 290
			Serialize(name.Topic as Hl7.Fhir.Model.CodeableConcept, writer, "topicCodeableConcept", cancellationToken); // 300
			Serialize(name.Topic as Hl7.Fhir.Model.ResourceReference, writer, "topicReference", cancellationToken); // 300
			Serialize(name.Type, writer, "type", cancellationToken); // 310
			Serialize(name.SubType, writer, "subType", cancellationToken); // 320
			Serialize(name.ContentDefinition, writer, "contentDefinition", cancellationToken); // 330
			Serialize(name.Term, writer, "term", cancellationToken); // 340
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 350
			Serialize(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 360
			Serialize(name.Signer, writer, "signer", cancellationToken); // 370
			Serialize(name.Friendly, writer, "friendly", cancellationToken); // 380
			Serialize(name.Legal, writer, "legal", cancellationToken); // 390
			Serialize(name.Rule, writer, "rule", cancellationToken); // 400
			Serialize(name.LegallyBinding as Hl7.Fhir.Model.Attachment, writer, "legallyBindingAttachment", cancellationToken); // 410
			Serialize(name.LegallyBinding as Hl7.Fhir.Model.ResourceReference, writer, "legallyBindingReference", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Serialize(Coverage name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Coverage", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.PolicyHolder, writer, "policyHolder", cancellationToken); // 120
			Serialize(name.Subscriber, writer, "subscriber", cancellationToken); // 130
			Serialize(name.SubscriberIdElement, writer, "subscriberId", cancellationToken); // 140
			Serialize(name.Beneficiary, writer, "beneficiary", cancellationToken); // 150
			Serialize(name.DependentElement, writer, "dependent", cancellationToken); // 160
			Serialize(name.Relationship, writer, "relationship", cancellationToken); // 170
			Serialize(name.Period, writer, "period", cancellationToken); // 180
			Serialize(name.Payor, writer, "payor", cancellationToken); // 190
			Serialize(name.Class, writer, "class", cancellationToken); // 200
			Serialize(name.OrderElement, writer, "order", cancellationToken); // 210
			Serialize(name.NetworkElement, writer, "network", cancellationToken); // 220
			Serialize(name.CostToBeneficiary, writer, "costToBeneficiary", cancellationToken); // 230
			Serialize(name.SubrogationElement, writer, "subrogation", cancellationToken); // 240
			Serialize(name.Contract, writer, "contract", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(CoverageEligibilityRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CoverageEligibilityRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Priority, writer, "priority", cancellationToken); // 110
			Serialize(name.PurposeElement, writer, "purpose", cancellationToken); // 120
			Serialize(name.Patient, writer, "patient", cancellationToken); // 130
			Serialize(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 140
			Serialize(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 140
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 150
			Serialize(name.Enterer, writer, "enterer", cancellationToken); // 160
			Serialize(name.Provider, writer, "provider", cancellationToken); // 170
			Serialize(name.Insurer, writer, "insurer", cancellationToken); // 180
			Serialize(name.Facility, writer, "facility", cancellationToken); // 190
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 200
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 210
			Serialize(name.Item, writer, "item", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Serialize(CoverageEligibilityResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CoverageEligibilityResponse", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.PurposeElement, writer, "purpose", cancellationToken); // 110
			Serialize(name.Patient, writer, "patient", cancellationToken); // 120
			Serialize(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 130
			Serialize(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 130
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 140
			Serialize(name.Requestor, writer, "requestor", cancellationToken); // 150
			Serialize(name.Request, writer, "request", cancellationToken); // 160
			Serialize(name.OutcomeElement, writer, "outcome", cancellationToken); // 170
			Serialize(name.DispositionElement, writer, "disposition", cancellationToken); // 180
			Serialize(name.Insurer, writer, "insurer", cancellationToken); // 190
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 200
			Serialize(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 210
			Serialize(name.Form, writer, "form", cancellationToken); // 220
			Serialize(name.Error, writer, "error", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Serialize(DetectedIssue name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DetectedIssue", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Code, writer, "code", cancellationToken); // 110
			Serialize(name.SeverityElement, writer, "severity", cancellationToken); // 120
			Serialize(name.Patient, writer, "patient", cancellationToken); // 130
			Serialize(name.Identified as Hl7.Fhir.Model.FhirDateTime, writer, "identifiedDateTime", cancellationToken); // 140
			Serialize(name.Identified as Hl7.Fhir.Model.Period, writer, "identifiedPeriod", cancellationToken); // 140
			Serialize(name.Author, writer, "author", cancellationToken); // 150
			Serialize(name.Implicated, writer, "implicated", cancellationToken); // 160
			Serialize(name.Evidence, writer, "evidence", cancellationToken); // 170
			Serialize(name.DetailElement, writer, "detail", cancellationToken); // 180
			Serialize(name.ReferenceElement, writer, "reference", cancellationToken); // 190
			Serialize(name.Mitigation, writer, "mitigation", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(Device name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Device", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Definition, writer, "definition", cancellationToken); // 100
			Serialize(name.UdiCarrier, writer, "udiCarrier", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 130
			Serialize(name.DistinctIdentifierElement, writer, "distinctIdentifier", cancellationToken); // 140
			Serialize(name.ManufacturerElement, writer, "manufacturer", cancellationToken); // 150
			Serialize(name.ManufactureDateElement, writer, "manufactureDate", cancellationToken); // 160
			Serialize(name.ExpirationDateElement, writer, "expirationDate", cancellationToken); // 170
			Serialize(name.LotNumberElement, writer, "lotNumber", cancellationToken); // 180
			Serialize(name.SerialNumberElement, writer, "serialNumber", cancellationToken); // 190
			Serialize(name.DeviceName, writer, "deviceName", cancellationToken); // 200
			Serialize(name.ModelNumberElement, writer, "modelNumber", cancellationToken); // 210
			Serialize(name.PartNumberElement, writer, "partNumber", cancellationToken); // 220
			Serialize(name.Type, writer, "type", cancellationToken); // 230
			Serialize(name.Specialization, writer, "specialization", cancellationToken); // 240
			Serialize(name.Version, writer, "version", cancellationToken); // 250
			Serialize(name.Property, writer, "property", cancellationToken); // 260
			Serialize(name.Patient, writer, "patient", cancellationToken); // 270
			Serialize(name.Owner, writer, "owner", cancellationToken); // 280
			Serialize(name.Contact, writer, "contact", cancellationToken); // 290
			Serialize(name.Location, writer, "location", cancellationToken); // 300
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 310
			Serialize(name.Note, writer, "note", cancellationToken); // 320
			Serialize(name.Safety, writer, "safety", cancellationToken); // 330
			Serialize(name.Parent, writer, "parent", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Serialize(DeviceDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.UdiDeviceIdentifier, writer, "udiDeviceIdentifier", cancellationToken); // 100
			Serialize(name.Manufacturer as Hl7.Fhir.Model.FhirString, writer, "manufacturerString", cancellationToken); // 110
			Serialize(name.Manufacturer as Hl7.Fhir.Model.ResourceReference, writer, "manufacturerReference", cancellationToken); // 110
			Serialize(name.DeviceName, writer, "deviceName", cancellationToken); // 120
			Serialize(name.ModelNumberElement, writer, "modelNumber", cancellationToken); // 130
			Serialize(name.Type, writer, "type", cancellationToken); // 140
			Serialize(name.Specialization, writer, "specialization", cancellationToken); // 150
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 160
			Serialize(name.Safety, writer, "safety", cancellationToken); // 170
			Serialize(name.ShelfLifeStorage, writer, "shelfLifeStorage", cancellationToken); // 180
			Serialize(name.PhysicalCharacteristics, writer, "physicalCharacteristics", cancellationToken); // 190
			Serialize(name.LanguageCode, writer, "languageCode", cancellationToken); // 200
			Serialize(name.Capability, writer, "capability", cancellationToken); // 210
			Serialize(name.Property, writer, "property", cancellationToken); // 220
			Serialize(name.Owner, writer, "owner", cancellationToken); // 230
			Serialize(name.Contact, writer, "contact", cancellationToken); // 240
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 250
			Serialize(name.OnlineInformationElement, writer, "onlineInformation", cancellationToken); // 260
			Serialize(name.Note, writer, "note", cancellationToken); // 270
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 280
			Serialize(name.ParentDevice, writer, "parentDevice", cancellationToken); // 290
			Serialize(name.Material, writer, "material", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Serialize(DeviceMetric name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceMetric", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Type, writer, "type", cancellationToken); // 100
			Serialize(name.Unit, writer, "unit", cancellationToken); // 110
			Serialize(name.Source, writer, "source", cancellationToken); // 120
			Serialize(name.Parent, writer, "parent", cancellationToken); // 130
			Serialize(name.OperationalStatusElement, writer, "operationalStatus", cancellationToken); // 140
			Serialize(name.ColorElement, writer, "color", cancellationToken); // 150
			Serialize(name.CategoryElement, writer, "category", cancellationToken); // 160
			Serialize(name.MeasurementPeriod, writer, "measurementPeriod", cancellationToken); // 170
			Serialize(name.Calibration, writer, "calibration", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Serialize(DeviceRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.PriorRequest, writer, "priorRequest", cancellationToken); // 130
			Serialize(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 160
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 170
			Serialize(name.Code as Hl7.Fhir.Model.ResourceReference, writer, "codeReference", cancellationToken); // 180
			Serialize(name.Code as Hl7.Fhir.Model.CodeableConcept, writer, "codeCodeableConcept", cancellationToken); // 180
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 190
			Serialize(name.Subject, writer, "subject", cancellationToken); // 200
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 210
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 220
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 220
			Serialize(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 220
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 230
			Serialize(name.Requester, writer, "requester", cancellationToken); // 240
			Serialize(name.PerformerType, writer, "performerType", cancellationToken); // 250
			Serialize(name.Performer, writer, "performer", cancellationToken); // 260
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 270
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 280
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 290
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 300
			Serialize(name.Note, writer, "note", cancellationToken); // 310
			Serialize(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(DeviceUseStatement name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceUseStatement", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.Subject, writer, "subject", cancellationToken); // 120
			Serialize(name.DerivedFrom, writer, "derivedFrom", cancellationToken); // 130
			Serialize(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 140
			Serialize(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 140
			Serialize(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 140
			Serialize(name.RecordedOnElement, writer, "recordedOn", cancellationToken); // 150
			Serialize(name.Source, writer, "source", cancellationToken); // 160
			Serialize(name.Device, writer, "device", cancellationToken); // 170
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 180
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 190
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 200
			Serialize(name.Note, writer, "note", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(DiagnosticReport name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DiagnosticReport", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.Category, writer, "category", cancellationToken); // 120
			Serialize(name.Code, writer, "code", cancellationToken); // 130
			Serialize(name.Subject, writer, "subject", cancellationToken); // 140
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 150
			Serialize(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 160
			Serialize(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 160
			Serialize(name.IssuedElement, writer, "issued", cancellationToken); // 170
			Serialize(name.Performer, writer, "performer", cancellationToken); // 180
			Serialize(name.ResultsInterpreter, writer, "resultsInterpreter", cancellationToken); // 190
			Serialize(name.Specimen, writer, "specimen", cancellationToken); // 200
			Serialize(name.Result, writer, "result", cancellationToken); // 210
			Serialize(name.ImagingStudy, writer, "imagingStudy", cancellationToken); // 220
			Serialize(name.Media, writer, "media", cancellationToken); // 230
			Serialize(name.ConclusionElement, writer, "conclusion", cancellationToken); // 240
			Serialize(name.ConclusionCode, writer, "conclusionCode", cancellationToken); // 250
			Serialize(name.PresentedForm, writer, "presentedForm", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Serialize(DocumentManifest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DocumentManifest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.MasterIdentifier, writer, "masterIdentifier", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.Type, writer, "type", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 140
			Serialize(name.Author, writer, "author", cancellationToken); // 150
			Serialize(name.Recipient, writer, "recipient", cancellationToken); // 160
			Serialize(name.SourceElement, writer, "source", cancellationToken); // 170
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 180
			Serialize(name.Content, writer, "content", cancellationToken); // 190
			Serialize(name.Related, writer, "related", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(DocumentReference name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DocumentReference", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.MasterIdentifier, writer, "masterIdentifier", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.DocStatusElement, writer, "docStatus", cancellationToken); // 120
			Serialize(name.Type, writer, "type", cancellationToken); // 130
			Serialize(name.Category, writer, "category", cancellationToken); // 140
			Serialize(name.Subject, writer, "subject", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.Author, writer, "author", cancellationToken); // 170
			Serialize(name.Authenticator, writer, "authenticator", cancellationToken); // 180
			Serialize(name.Custodian, writer, "custodian", cancellationToken); // 190
			Serialize(name.RelatesTo, writer, "relatesTo", cancellationToken); // 200
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 210
			Serialize(name.SecurityLabel, writer, "securityLabel", cancellationToken); // 220
			Serialize(name.Content, writer, "content", cancellationToken); // 230
			Serialize(name.Context, writer, "context", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(EffectEvidenceSynthesis name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EffectEvidenceSynthesis", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Description, writer, "description", cancellationToken); // 180
			Serialize(name.Note, writer, "note", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 220
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 230
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 240
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 250
			Serialize(name.Topic, writer, "topic", cancellationToken); // 260
			Serialize(name.Author, writer, "author", cancellationToken); // 270
			Serialize(name.Editor, writer, "editor", cancellationToken); // 280
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 290
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 300
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 310
			Serialize(name.SynthesisType, writer, "synthesisType", cancellationToken); // 320
			Serialize(name.StudyType, writer, "studyType", cancellationToken); // 330
			Serialize(name.Population, writer, "population", cancellationToken); // 340
			Serialize(name.Exposure, writer, "exposure", cancellationToken); // 350
			Serialize(name.ExposureAlternative, writer, "exposureAlternative", cancellationToken); // 360
			Serialize(name.Outcome, writer, "outcome", cancellationToken); // 370
			Serialize(name.SampleSize, writer, "sampleSize", cancellationToken); // 380
			Serialize(name.ResultsByExposure, writer, "resultsByExposure", cancellationToken); // 390
			Serialize(name.EffectEstimate, writer, "effectEstimate", cancellationToken); // 400
			Serialize(name.Certainty, writer, "certainty", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Serialize(Encounter name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Encounter", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.StatusHistory, writer, "statusHistory", cancellationToken); // 110
			Serialize(name.Class, writer, "class", cancellationToken); // 120
			Serialize(name.ClassHistory, writer, "classHistory", cancellationToken); // 130
			Serialize(name.Type, writer, "type", cancellationToken); // 140
			Serialize(name.ServiceType, writer, "serviceType", cancellationToken); // 150
			Serialize(name.Priority, writer, "priority", cancellationToken); // 160
			Serialize(name.Subject, writer, "subject", cancellationToken); // 170
			Serialize(name.EpisodeOfCare, writer, "episodeOfCare", cancellationToken); // 180
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 190
			Serialize(name.Participant, writer, "participant", cancellationToken); // 200
			Serialize(name.Appointment, writer, "appointment", cancellationToken); // 210
			Serialize(name.Period, writer, "period", cancellationToken); // 220
			Serialize(name.Length, writer, "length", cancellationToken); // 230
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 240
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 250
			Serialize(name.Diagnosis, writer, "diagnosis", cancellationToken); // 260
			Serialize(name.Account, writer, "account", cancellationToken); // 270
			Serialize(name.Hospitalization, writer, "hospitalization", cancellationToken); // 280
			Serialize(name.Location, writer, "location", cancellationToken); // 290
			Serialize(name.ServiceProvider, writer, "serviceProvider", cancellationToken); // 300
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Serialize(Endpoint name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Endpoint", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.ConnectionType, writer, "connectionType", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 130
			Serialize(name.Contact, writer, "contact", cancellationToken); // 140
			Serialize(name.Period, writer, "period", cancellationToken); // 150
			Serialize(name.PayloadType, writer, "payloadType", cancellationToken); // 160
			Serialize(name.PayloadMimeTypeElement, writer, "payloadMimeType", cancellationToken); // 170
			Serialize(name.AddressElement, writer, "address", cancellationToken); // 180
			Serialize(name.HeaderElement, writer, "header", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(EnrollmentRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EnrollmentRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 110
			Serialize(name.Insurer, writer, "insurer", cancellationToken); // 120
			Serialize(name.Provider, writer, "provider", cancellationToken); // 130
			Serialize(name.Candidate, writer, "candidate", cancellationToken); // 140
			Serialize(name.Coverage, writer, "coverage", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(EnrollmentResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EnrollmentResponse", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Request, writer, "request", cancellationToken); // 110
			Serialize(name.OutcomeElement, writer, "outcome", cancellationToken); // 120
			Serialize(name.DispositionElement, writer, "disposition", cancellationToken); // 130
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 140
			Serialize(name.Organization, writer, "organization", cancellationToken); // 150
			Serialize(name.RequestProvider, writer, "requestProvider", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(EpisodeOfCare name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EpisodeOfCare", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.StatusHistory, writer, "statusHistory", cancellationToken); // 110
			Serialize(name.Type, writer, "type", cancellationToken); // 120
			Serialize(name.Diagnosis, writer, "diagnosis", cancellationToken); // 130
			Serialize(name.Patient, writer, "patient", cancellationToken); // 140
			Serialize(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 150
			Serialize(name.Period, writer, "period", cancellationToken); // 160
			Serialize(name.ReferralRequest, writer, "referralRequest", cancellationToken); // 170
			Serialize(name.CareManager, writer, "careManager", cancellationToken); // 180
			Serialize(name.Team, writer, "team", cancellationToken); // 190
			Serialize(name.Account, writer, "account", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(EventDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EventDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 170
			Serialize(name.DateElement, writer, "date", cancellationToken); // 180
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Serialize(name.Contact, writer, "contact", cancellationToken); // 200
			Serialize(name.Description, writer, "description", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 240
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 250
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 260
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 270
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 280
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 290
			Serialize(name.Topic, writer, "topic", cancellationToken); // 300
			Serialize(name.Author, writer, "author", cancellationToken); // 310
			Serialize(name.Editor, writer, "editor", cancellationToken); // 320
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 330
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 340
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 350
			Serialize(name.Trigger, writer, "trigger", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Serialize(Evidence name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Evidence", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 160
			Serialize(name.DateElement, writer, "date", cancellationToken); // 170
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 180
			Serialize(name.Contact, writer, "contact", cancellationToken); // 190
			Serialize(name.Description, writer, "description", cancellationToken); // 200
			Serialize(name.Note, writer, "note", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 240
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 250
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 260
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 270
			Serialize(name.Topic, writer, "topic", cancellationToken); // 280
			Serialize(name.Author, writer, "author", cancellationToken); // 290
			Serialize(name.Editor, writer, "editor", cancellationToken); // 300
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 310
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 320
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 330
			Serialize(name.ExposureBackground, writer, "exposureBackground", cancellationToken); // 340
			Serialize(name.ExposureVariant, writer, "exposureVariant", cancellationToken); // 350
			Serialize(name.Outcome, writer, "outcome", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Serialize(EvidenceVariable name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EvidenceVariable", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 160
			Serialize(name.DateElement, writer, "date", cancellationToken); // 170
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 180
			Serialize(name.Contact, writer, "contact", cancellationToken); // 190
			Serialize(name.Description, writer, "description", cancellationToken); // 200
			Serialize(name.Note, writer, "note", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 240
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 250
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 260
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 270
			Serialize(name.Topic, writer, "topic", cancellationToken); // 280
			Serialize(name.Author, writer, "author", cancellationToken); // 290
			Serialize(name.Editor, writer, "editor", cancellationToken); // 300
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 310
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 320
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 330
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 340
			Serialize(name.Characteristic, writer, "characteristic", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Serialize(ExampleScenario name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ExampleScenario", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 180
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 190
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 200
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 210
			Serialize(name.Actor, writer, "actor", cancellationToken); // 220
			Serialize(name.Instance, writer, "instance", cancellationToken); // 230
			Serialize(name.Process, writer, "process", cancellationToken); // 240
			Serialize(name.WorkflowElement, writer, "workflow", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(ExplanationOfBenefit name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ExplanationOfBenefit", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.SubType, writer, "subType", cancellationToken); // 120
			Serialize(name.UseElement, writer, "use", cancellationToken); // 130
			Serialize(name.Patient, writer, "patient", cancellationToken); // 140
			Serialize(name.BillablePeriod, writer, "billablePeriod", cancellationToken); // 150
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 160
			Serialize(name.Enterer, writer, "enterer", cancellationToken); // 170
			Serialize(name.Insurer, writer, "insurer", cancellationToken); // 180
			Serialize(name.Provider, writer, "provider", cancellationToken); // 190
			Serialize(name.Priority, writer, "priority", cancellationToken); // 200
			Serialize(name.FundsReserveRequested, writer, "fundsReserveRequested", cancellationToken); // 210
			Serialize(name.FundsReserve, writer, "fundsReserve", cancellationToken); // 220
			Serialize(name.Related, writer, "related", cancellationToken); // 230
			Serialize(name.Prescription, writer, "prescription", cancellationToken); // 240
			Serialize(name.OriginalPrescription, writer, "originalPrescription", cancellationToken); // 250
			Serialize(name.Payee, writer, "payee", cancellationToken); // 260
			Serialize(name.Referral, writer, "referral", cancellationToken); // 270
			Serialize(name.Facility, writer, "facility", cancellationToken); // 280
			Serialize(name.Claim, writer, "claim", cancellationToken); // 290
			Serialize(name.ClaimResponse, writer, "claimResponse", cancellationToken); // 300
			Serialize(name.OutcomeElement, writer, "outcome", cancellationToken); // 310
			Serialize(name.DispositionElement, writer, "disposition", cancellationToken); // 320
			Serialize(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 330
			Serialize(name.PreAuthRefPeriod, writer, "preAuthRefPeriod", cancellationToken); // 340
			Serialize(name.CareTeam, writer, "careTeam", cancellationToken); // 350
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 360
			Serialize(name.Diagnosis, writer, "diagnosis", cancellationToken); // 370
			Serialize(name.Procedure, writer, "procedure", cancellationToken); // 380
			Serialize(name.PrecedenceElement, writer, "precedence", cancellationToken); // 390
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 400
			Serialize(name.Accident, writer, "accident", cancellationToken); // 410
			Serialize(name.Item, writer, "item", cancellationToken); // 420
			Serialize(name.AddItem, writer, "addItem", cancellationToken); // 430
			Serialize(name.Adjudication, writer, "adjudication", cancellationToken); // 440
			Serialize(name.Total, writer, "total", cancellationToken); // 450
			Serialize(name.Payment, writer, "payment", cancellationToken); // 460
			Serialize(name.FormCode, writer, "formCode", cancellationToken); // 470
			Serialize(name.Form, writer, "form", cancellationToken); // 480
			Serialize(name.ProcessNote, writer, "processNote", cancellationToken); // 490
			Serialize(name.BenefitPeriod, writer, "benefitPeriod", cancellationToken); // 500
			Serialize(name.BenefitBalance, writer, "benefitBalance", cancellationToken); // 510
			writer.WriteEndElement();
		}

		public static void Serialize(FamilyMemberHistory name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("FamilyMemberHistory", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.DataAbsentReason, writer, "dataAbsentReason", cancellationToken); // 130
			Serialize(name.Patient, writer, "patient", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.NameElement, writer, "name", cancellationToken); // 160
			Serialize(name.Relationship, writer, "relationship", cancellationToken); // 170
			Serialize(name.Sex, writer, "sex", cancellationToken); // 180
			Serialize(name.Born as Hl7.Fhir.Model.Period, writer, "bornPeriod", cancellationToken); // 190
			Serialize(name.Born as Hl7.Fhir.Model.Date, writer, "bornDate", cancellationToken); // 190
			Serialize(name.Born as Hl7.Fhir.Model.FhirString, writer, "bornString", cancellationToken); // 190
			Serialize(name.Age as Hl7.Fhir.Model.Age, writer, "ageAge", cancellationToken); // 200
			Serialize(name.Age as Hl7.Fhir.Model.Range, writer, "ageRange", cancellationToken); // 200
			Serialize(name.Age as Hl7.Fhir.Model.FhirString, writer, "ageString", cancellationToken); // 200
			Serialize(name.EstimatedAgeElement, writer, "estimatedAge", cancellationToken); // 210
			Serialize(name.Deceased as Hl7.Fhir.Model.FhirBoolean, writer, "deceasedBoolean", cancellationToken); // 220
			Serialize(name.Deceased as Hl7.Fhir.Model.Age, writer, "deceasedAge", cancellationToken); // 220
			Serialize(name.Deceased as Hl7.Fhir.Model.Range, writer, "deceasedRange", cancellationToken); // 220
			Serialize(name.Deceased as Hl7.Fhir.Model.Date, writer, "deceasedDate", cancellationToken); // 220
			Serialize(name.Deceased as Hl7.Fhir.Model.FhirString, writer, "deceasedString", cancellationToken); // 220
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 230
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 240
			Serialize(name.Note, writer, "note", cancellationToken); // 250
			Serialize(name.Condition, writer, "condition", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Serialize(Flag name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Flag", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Category, writer, "category", cancellationToken); // 110
			Serialize(name.Code, writer, "code", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.Period, writer, "period", cancellationToken); // 140
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 150
			Serialize(name.Author, writer, "author", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(Goal name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Goal", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.LifecycleStatusElement, writer, "lifecycleStatus", cancellationToken); // 100
			Serialize(name.AchievementStatus, writer, "achievementStatus", cancellationToken); // 110
			Serialize(name.Category, writer, "category", cancellationToken); // 120
			Serialize(name.Priority, writer, "priority", cancellationToken); // 130
			Serialize(name.Description, writer, "description", cancellationToken); // 140
			Serialize(name.Subject, writer, "subject", cancellationToken); // 150
			Serialize(name.Start as Hl7.Fhir.Model.Date, writer, "startDate", cancellationToken); // 160
			Serialize(name.Start as Hl7.Fhir.Model.CodeableConcept, writer, "startCodeableConcept", cancellationToken); // 160
			Serialize(name.Target, writer, "target", cancellationToken); // 170
			Serialize(name.StatusDateElement, writer, "statusDate", cancellationToken); // 180
			Serialize(name.StatusReasonElement, writer, "statusReason", cancellationToken); // 190
			Serialize(name.ExpressedBy, writer, "expressedBy", cancellationToken); // 200
			Serialize(name.Addresses, writer, "addresses", cancellationToken); // 210
			Serialize(name.Note, writer, "note", cancellationToken); // 220
			Serialize(name.OutcomeCode, writer, "outcomeCode", cancellationToken); // 230
			Serialize(name.OutcomeReference, writer, "outcomeReference", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(GraphDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("GraphDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 130
			Serialize(name.DateElement, writer, "date", cancellationToken); // 140
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 150
			Serialize(name.Contact, writer, "contact", cancellationToken); // 160
			Serialize(name.Description, writer, "description", cancellationToken); // 170
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 180
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 190
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 200
			Serialize(name.StartElement, writer, "start", cancellationToken); // 210
			Serialize(name.ProfileElement, writer, "profile", cancellationToken); // 220
			Serialize(name.Link, writer, "link", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Serialize(Group name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Group", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 110
			Serialize(name.ActualElement, writer, "actual", cancellationToken); // 120
			Serialize(name.Code, writer, "code", cancellationToken); // 130
			Serialize(name.NameElement, writer, "name", cancellationToken); // 140
			Serialize(name.QuantityElement, writer, "quantity", cancellationToken); // 150
			Serialize(name.ManagingEntity, writer, "managingEntity", cancellationToken); // 160
			Serialize(name.Characteristic, writer, "characteristic", cancellationToken); // 170
			Serialize(name.Member, writer, "member", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Serialize(GuidanceResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("GuidanceResponse", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.RequestIdentifier, writer, "requestIdentifier", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.Module as Hl7.Fhir.Model.FhirUri, writer, "moduleUri", cancellationToken); // 110
			Serialize(name.Module as Hl7.Fhir.Model.Canonical, writer, "moduleCanonical", cancellationToken); // 110
			Serialize(name.Module as Hl7.Fhir.Model.CodeableConcept, writer, "moduleCodeableConcept", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 140
			Serialize(name.OccurrenceDateTimeElement, writer, "occurrenceDateTime", cancellationToken); // 150
			Serialize(name.Performer, writer, "performer", cancellationToken); // 160
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 170
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 180
			Serialize(name.Note, writer, "note", cancellationToken); // 190
			Serialize(name.EvaluationMessage, writer, "evaluationMessage", cancellationToken); // 200
			Serialize(name.OutputParameters, writer, "outputParameters", cancellationToken); // 210
			Serialize(name.Result, writer, "result", cancellationToken); // 220
			Serialize(name.DataRequirement, writer, "dataRequirement", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Serialize(HealthcareService name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("HealthcareService", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.ProvidedBy, writer, "providedBy", cancellationToken); // 110
			Serialize(name.Category, writer, "category", cancellationToken); // 120
			Serialize(name.Type, writer, "type", cancellationToken); // 130
			Serialize(name.Specialty, writer, "specialty", cancellationToken); // 140
			Serialize(name.Location, writer, "location", cancellationToken); // 150
			Serialize(name.NameElement, writer, "name", cancellationToken); // 160
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 170
			Serialize(name.ExtraDetails, writer, "extraDetails", cancellationToken); // 180
			Serialize(name.Photo, writer, "photo", cancellationToken); // 190
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 200
			Serialize(name.CoverageArea, writer, "coverageArea", cancellationToken); // 210
			Serialize(name.ServiceProvisionCode, writer, "serviceProvisionCode", cancellationToken); // 220
			Serialize(name.Eligibility, writer, "eligibility", cancellationToken); // 230
			Serialize(name.Program, writer, "program", cancellationToken); // 240
			Serialize(name.Characteristic, writer, "characteristic", cancellationToken); // 250
			Serialize(name.Communication, writer, "communication", cancellationToken); // 260
			Serialize(name.ReferralMethod, writer, "referralMethod", cancellationToken); // 270
			Serialize(name.AppointmentRequiredElement, writer, "appointmentRequired", cancellationToken); // 280
			Serialize(name.AvailableTime, writer, "availableTime", cancellationToken); // 290
			Serialize(name.NotAvailable, writer, "notAvailable", cancellationToken); // 300
			Serialize(name.AvailabilityExceptionsElement, writer, "availabilityExceptions", cancellationToken); // 310
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(ImagingStudy name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImagingStudy", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Modality, writer, "modality", cancellationToken); // 110
			Serialize(name.Subject, writer, "subject", cancellationToken); // 120
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 130
			Serialize(name.StartedElement, writer, "started", cancellationToken); // 140
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 150
			Serialize(name.Referrer, writer, "referrer", cancellationToken); // 160
			Serialize(name.Interpreter, writer, "interpreter", cancellationToken); // 170
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 180
			Serialize(name.NumberOfSeriesElement, writer, "numberOfSeries", cancellationToken); // 190
			Serialize(name.NumberOfInstancesElement, writer, "numberOfInstances", cancellationToken); // 200
			Serialize(name.ProcedureReference, writer, "procedureReference", cancellationToken); // 210
			Serialize(name.ProcedureCode, writer, "procedureCode", cancellationToken); // 220
			Serialize(name.Location, writer, "location", cancellationToken); // 230
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 240
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 250
			Serialize(name.Note, writer, "note", cancellationToken); // 260
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 270
			Serialize(name.Series, writer, "series", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Serialize(Immunization name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Immunization", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 110
			Serialize(name.VaccineCode, writer, "vaccineCode", cancellationToken); // 120
			Serialize(name.Patient, writer, "patient", cancellationToken); // 130
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 140
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 150
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirString, writer, "occurrenceString", cancellationToken); // 150
			Serialize(name.RecordedElement, writer, "recorded", cancellationToken); // 160
			Serialize(name.PrimarySourceElement, writer, "primarySource", cancellationToken); // 170
			Serialize(name.ReportOrigin, writer, "reportOrigin", cancellationToken); // 180
			Serialize(name.Location, writer, "location", cancellationToken); // 190
			Serialize(name.Manufacturer, writer, "manufacturer", cancellationToken); // 200
			Serialize(name.LotNumberElement, writer, "lotNumber", cancellationToken); // 210
			Serialize(name.ExpirationDateElement, writer, "expirationDate", cancellationToken); // 220
			Serialize(name.Site, writer, "site", cancellationToken); // 230
			Serialize(name.Route, writer, "route", cancellationToken); // 240
			Serialize(name.DoseQuantity, writer, "doseQuantity", cancellationToken); // 250
			Serialize(name.Performer, writer, "performer", cancellationToken); // 260
			Serialize(name.Note, writer, "note", cancellationToken); // 270
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 280
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 290
			Serialize(name.IsSubpotentElement, writer, "isSubpotent", cancellationToken); // 300
			Serialize(name.SubpotentReason, writer, "subpotentReason", cancellationToken); // 310
			Serialize(name.Education, writer, "education", cancellationToken); // 320
			Serialize(name.ProgramEligibility, writer, "programEligibility", cancellationToken); // 330
			Serialize(name.FundingSource, writer, "fundingSource", cancellationToken); // 340
			Serialize(name.Reaction, writer, "reaction", cancellationToken); // 350
			Serialize(name.ProtocolApplied, writer, "protocolApplied", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Serialize(ImmunizationEvaluation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImmunizationEvaluation", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Patient, writer, "patient", cancellationToken); // 110
			Serialize(name.DateElement, writer, "date", cancellationToken); // 120
			Serialize(name.Authority, writer, "authority", cancellationToken); // 130
			Serialize(name.TargetDisease, writer, "targetDisease", cancellationToken); // 140
			Serialize(name.ImmunizationEvent, writer, "immunizationEvent", cancellationToken); // 150
			Serialize(name.DoseStatus, writer, "doseStatus", cancellationToken); // 160
			Serialize(name.DoseStatusReason, writer, "doseStatusReason", cancellationToken); // 170
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 180
			Serialize(name.SeriesElement, writer, "series", cancellationToken); // 190
			Serialize(name.DoseNumber as Hl7.Fhir.Model.PositiveInt, writer, "doseNumberPositiveInt", cancellationToken); // 200
			Serialize(name.DoseNumber as Hl7.Fhir.Model.FhirString, writer, "doseNumberString", cancellationToken); // 200
			Serialize(name.SeriesDoses as Hl7.Fhir.Model.PositiveInt, writer, "seriesDosesPositiveInt", cancellationToken); // 210
			Serialize(name.SeriesDoses as Hl7.Fhir.Model.FhirString, writer, "seriesDosesString", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(ImmunizationRecommendation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImmunizationRecommendation", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Patient, writer, "patient", cancellationToken); // 100
			Serialize(name.DateElement, writer, "date", cancellationToken); // 110
			Serialize(name.Authority, writer, "authority", cancellationToken); // 120
			Serialize(name.Recommendation, writer, "recommendation", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Serialize(ImplementationGuide name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImplementationGuide", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Description, writer, "description", cancellationToken); // 180
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 190
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 210
			Serialize(name.PackageIdElement, writer, "packageId", cancellationToken); // 220
			Serialize(name.LicenseElement, writer, "license", cancellationToken); // 230
			Serialize(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 240
			Serialize(name.DependsOn, writer, "dependsOn", cancellationToken); // 250
			Serialize(name.Global, writer, "global", cancellationToken); // 260
			Serialize(name.Definition, writer, "definition", cancellationToken); // 270
			Serialize(name.Manifest, writer, "manifest", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Serialize(InsurancePlan name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("InsurancePlan", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.AliasElement, writer, "alias", cancellationToken); // 130
			Serialize(name.Period, writer, "period", cancellationToken); // 140
			Serialize(name.OwnedBy, writer, "ownedBy", cancellationToken); // 150
			Serialize(name.AdministeredBy, writer, "administeredBy", cancellationToken); // 160
			Serialize(name.CoverageArea, writer, "coverageArea", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 190
			Serialize(name.Network, writer, "network", cancellationToken); // 200
			Serialize(name.Coverage, writer, "coverage", cancellationToken); // 210
			Serialize(name.Plan, writer, "plan", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Serialize(Invoice name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Invoice", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.CancelledReasonElement, writer, "cancelledReason", cancellationToken); // 110
			Serialize(name.Type, writer, "type", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.Recipient, writer, "recipient", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.Participant, writer, "participant", cancellationToken); // 160
			Serialize(name.Issuer, writer, "issuer", cancellationToken); // 170
			Serialize(name.Account, writer, "account", cancellationToken); // 180
			Serialize(name.LineItem, writer, "lineItem", cancellationToken); // 190
			Serialize(name.TotalPriceComponent, writer, "totalPriceComponent", cancellationToken); // 200
			Serialize(name.TotalNet, writer, "totalNet", cancellationToken); // 210
			Serialize(name.TotalGross, writer, "totalGross", cancellationToken); // 220
			Serialize(name.PaymentTerms, writer, "paymentTerms", cancellationToken); // 230
			Serialize(name.Note, writer, "note", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(Library name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Library", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Serialize(name.Type, writer, "type", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Serialize(name.DateElement, writer, "date", cancellationToken); // 190
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Serialize(name.Contact, writer, "contact", cancellationToken); // 210
			Serialize(name.Description, writer, "description", cancellationToken); // 220
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 230
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 240
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 250
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 260
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 270
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 280
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 290
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 300
			Serialize(name.Topic, writer, "topic", cancellationToken); // 310
			Serialize(name.Author, writer, "author", cancellationToken); // 320
			Serialize(name.Editor, writer, "editor", cancellationToken); // 330
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 340
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 350
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 360
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 370
			Serialize(name.DataRequirement, writer, "dataRequirement", cancellationToken); // 380
			Serialize(name.Content, writer, "content", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Serialize(Linkage name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Linkage", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 90
			Serialize(name.Author, writer, "author", cancellationToken); // 100
			Serialize(name.Item, writer, "item", cancellationToken); // 110
			writer.WriteEndElement();
		}

		public static void Serialize(List name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("List", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.ModeElement, writer, "mode", cancellationToken); // 110
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 120
			Serialize(name.Code, writer, "code", cancellationToken); // 130
			Serialize(name.Subject, writer, "subject", cancellationToken); // 140
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.Source, writer, "source", cancellationToken); // 170
			Serialize(name.OrderedBy, writer, "orderedBy", cancellationToken); // 180
			Serialize(name.Note, writer, "note", cancellationToken); // 190
			Serialize(name.Entry, writer, "entry", cancellationToken); // 200
			Serialize(name.EmptyReason, writer, "emptyReason", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(Location name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Location", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.OperationalStatus, writer, "operationalStatus", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.AliasElement, writer, "alias", cancellationToken); // 130
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 140
			Serialize(name.ModeElement, writer, "mode", cancellationToken); // 150
			Serialize(name.Type, writer, "type", cancellationToken); // 160
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 170
			Serialize(name.Address, writer, "address", cancellationToken); // 180
			Serialize(name.PhysicalType, writer, "physicalType", cancellationToken); // 190
			Serialize(name.Position, writer, "position", cancellationToken); // 200
			Serialize(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 210
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 220
			Serialize(name.HoursOfOperation, writer, "hoursOfOperation", cancellationToken); // 230
			Serialize(name.AvailabilityExceptionsElement, writer, "availabilityExceptions", cancellationToken); // 240
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(Measure name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Measure", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 170
			Serialize(name.DateElement, writer, "date", cancellationToken); // 180
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Serialize(name.Contact, writer, "contact", cancellationToken); // 200
			Serialize(name.Description, writer, "description", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 240
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 250
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 260
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 270
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 280
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 290
			Serialize(name.Topic, writer, "topic", cancellationToken); // 300
			Serialize(name.Author, writer, "author", cancellationToken); // 310
			Serialize(name.Editor, writer, "editor", cancellationToken); // 320
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 330
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 340
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 350
			Serialize(name.LibraryElement, writer, "library", cancellationToken); // 360
			Serialize(name.Disclaimer, writer, "disclaimer", cancellationToken); // 370
			Serialize(name.Scoring, writer, "scoring", cancellationToken); // 380
			Serialize(name.CompositeScoring, writer, "compositeScoring", cancellationToken); // 390
			Serialize(name.Type, writer, "type", cancellationToken); // 400
			Serialize(name.RiskAdjustmentElement, writer, "riskAdjustment", cancellationToken); // 410
			Serialize(name.RateAggregationElement, writer, "rateAggregation", cancellationToken); // 420
			Serialize(name.Rationale, writer, "rationale", cancellationToken); // 430
			Serialize(name.ClinicalRecommendationStatement, writer, "clinicalRecommendationStatement", cancellationToken); // 440
			Serialize(name.ImprovementNotation, writer, "improvementNotation", cancellationToken); // 450
			Serialize(name.Definition, writer, "definition", cancellationToken); // 460
			Serialize(name.Guidance, writer, "guidance", cancellationToken); // 470
			Serialize(name.Group, writer, "group", cancellationToken); // 480
			Serialize(name.SupplementalData, writer, "supplementalData", cancellationToken); // 490
			writer.WriteEndElement();
		}

		public static void Serialize(MeasureReport name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MeasureReport", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 110
			Serialize(name.MeasureElement, writer, "measure", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.DateElement, writer, "date", cancellationToken); // 140
			Serialize(name.Reporter, writer, "reporter", cancellationToken); // 150
			Serialize(name.Period, writer, "period", cancellationToken); // 160
			Serialize(name.ImprovementNotation, writer, "improvementNotation", cancellationToken); // 170
			Serialize(name.Group, writer, "group", cancellationToken); // 180
			Serialize(name.EvaluatedResource, writer, "evaluatedResource", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(Media name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Media", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.Type, writer, "type", cancellationToken); // 130
			Serialize(name.Modality, writer, "modality", cancellationToken); // 140
			Serialize(name.View, writer, "view", cancellationToken); // 150
			Serialize(name.Subject, writer, "subject", cancellationToken); // 160
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 170
			Serialize(name.Created as Hl7.Fhir.Model.FhirDateTime, writer, "createdDateTime", cancellationToken); // 180
			Serialize(name.Created as Hl7.Fhir.Model.Period, writer, "createdPeriod", cancellationToken); // 180
			Serialize(name.IssuedElement, writer, "issued", cancellationToken); // 190
			Serialize(name.Operator, writer, "operator", cancellationToken); // 200
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 210
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 220
			Serialize(name.DeviceNameElement, writer, "deviceName", cancellationToken); // 230
			Serialize(name.Device, writer, "device", cancellationToken); // 240
			Serialize(name.HeightElement, writer, "height", cancellationToken); // 250
			Serialize(name.WidthElement, writer, "width", cancellationToken); // 260
			Serialize(name.FramesElement, writer, "frames", cancellationToken); // 270
			Serialize(name.DurationElement, writer, "duration", cancellationToken); // 280
			Serialize(name.Content, writer, "content", cancellationToken); // 290
			Serialize(name.Note, writer, "note", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Serialize(Medication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Medication", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Code, writer, "code", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.Manufacturer, writer, "manufacturer", cancellationToken); // 120
			Serialize(name.Form, writer, "form", cancellationToken); // 130
			Serialize(name.Amount, writer, "amount", cancellationToken); // 140
			Serialize(name.Ingredient, writer, "ingredient", cancellationToken); // 150
			Serialize(name.Batch, writer, "batch", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(MedicationAdministration name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationAdministration", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesElement, writer, "instantiates", cancellationToken); // 100
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 130
			Serialize(name.Category, writer, "category", cancellationToken); // 140
			Serialize(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 150
			Serialize(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 150
			Serialize(name.Subject, writer, "subject", cancellationToken); // 160
			Serialize(name.Context, writer, "context", cancellationToken); // 170
			Serialize(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 180
			Serialize(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 190
			Serialize(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 190
			Serialize(name.Performer, writer, "performer", cancellationToken); // 200
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 210
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 220
			Serialize(name.Request, writer, "request", cancellationToken); // 230
			Serialize(name.Device, writer, "device", cancellationToken); // 240
			Serialize(name.Note, writer, "note", cancellationToken); // 250
			Serialize(name.Dosage, writer, "dosage", cancellationToken); // 260
			Serialize(name.EventHistory, writer, "eventHistory", cancellationToken); // 270
			writer.WriteEndElement();
		}

		public static void Serialize(MedicationDispense name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationDispense", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.StatusReason as Hl7.Fhir.Model.CodeableConcept, writer, "statusReasonCodeableConcept", cancellationToken); // 120
			Serialize(name.StatusReason as Hl7.Fhir.Model.ResourceReference, writer, "statusReasonReference", cancellationToken); // 120
			Serialize(name.Category, writer, "category", cancellationToken); // 130
			Serialize(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 140
			Serialize(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 140
			Serialize(name.Subject, writer, "subject", cancellationToken); // 150
			Serialize(name.Context, writer, "context", cancellationToken); // 160
			Serialize(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 170
			Serialize(name.Performer, writer, "performer", cancellationToken); // 180
			Serialize(name.Location, writer, "location", cancellationToken); // 190
			Serialize(name.AuthorizingPrescription, writer, "authorizingPrescription", cancellationToken); // 200
			Serialize(name.Type, writer, "type", cancellationToken); // 210
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 220
			Serialize(name.DaysSupply, writer, "daysSupply", cancellationToken); // 230
			Serialize(name.WhenPreparedElement, writer, "whenPrepared", cancellationToken); // 240
			Serialize(name.WhenHandedOverElement, writer, "whenHandedOver", cancellationToken); // 250
			Serialize(name.Destination, writer, "destination", cancellationToken); // 260
			Serialize(name.Receiver, writer, "receiver", cancellationToken); // 270
			Serialize(name.Note, writer, "note", cancellationToken); // 280
			Serialize(name.DosageInstruction, writer, "dosageInstruction", cancellationToken); // 290
			Serialize(name.Substitution, writer, "substitution", cancellationToken); // 300
			Serialize(name.DetectedIssue, writer, "detectedIssue", cancellationToken); // 310
			Serialize(name.EventHistory, writer, "eventHistory", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(MedicationKnowledge name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationKnowledge", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Code, writer, "code", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Manufacturer, writer, "manufacturer", cancellationToken); // 110
			Serialize(name.DoseForm, writer, "doseForm", cancellationToken); // 120
			Serialize(name.Amount, writer, "amount", cancellationToken); // 130
			Serialize(name.SynonymElement, writer, "synonym", cancellationToken); // 140
			Serialize(name.RelatedMedicationKnowledge, writer, "relatedMedicationKnowledge", cancellationToken); // 150
			Serialize(name.AssociatedMedication, writer, "associatedMedication", cancellationToken); // 160
			Serialize(name.ProductType, writer, "productType", cancellationToken); // 170
			Serialize(name.Monograph, writer, "monograph", cancellationToken); // 180
			Serialize(name.Ingredient, writer, "ingredient", cancellationToken); // 190
			Serialize(name.PreparationInstruction, writer, "preparationInstruction", cancellationToken); // 200
			Serialize(name.IntendedRoute, writer, "intendedRoute", cancellationToken); // 210
			Serialize(name.Cost, writer, "cost", cancellationToken); // 220
			Serialize(name.MonitoringProgram, writer, "monitoringProgram", cancellationToken); // 230
			Serialize(name.AdministrationGuidelines, writer, "administrationGuidelines", cancellationToken); // 240
			Serialize(name.MedicineClassification, writer, "medicineClassification", cancellationToken); // 250
			Serialize(name.Packaging, writer, "packaging", cancellationToken); // 260
			Serialize(name.DrugCharacteristic, writer, "drugCharacteristic", cancellationToken); // 270
			Serialize(name.Contraindication, writer, "contraindication", cancellationToken); // 280
			Serialize(name.Regulatory, writer, "regulatory", cancellationToken); // 290
			Serialize(name.Kinetics, writer, "kinetics", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Serialize(MedicationRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 110
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 120
			Serialize(name.Category, writer, "category", cancellationToken); // 130
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 140
			Serialize(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 150
			Serialize(name.Reported as Hl7.Fhir.Model.FhirBoolean, writer, "reportedBoolean", cancellationToken); // 160
			Serialize(name.Reported as Hl7.Fhir.Model.ResourceReference, writer, "reportedReference", cancellationToken); // 160
			Serialize(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 170
			Serialize(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 170
			Serialize(name.Subject, writer, "subject", cancellationToken); // 180
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 190
			Serialize(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 200
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 210
			Serialize(name.Requester, writer, "requester", cancellationToken); // 220
			Serialize(name.Performer, writer, "performer", cancellationToken); // 230
			Serialize(name.PerformerType, writer, "performerType", cancellationToken); // 240
			Serialize(name.Recorder, writer, "recorder", cancellationToken); // 250
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 260
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 270
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 280
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 290
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 300
			Serialize(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 310
			Serialize(name.CourseOfTherapyType, writer, "courseOfTherapyType", cancellationToken); // 320
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 330
			Serialize(name.Note, writer, "note", cancellationToken); // 340
			Serialize(name.DosageInstruction, writer, "dosageInstruction", cancellationToken); // 350
			Serialize(name.DispenseRequest, writer, "dispenseRequest", cancellationToken); // 360
			Serialize(name.Substitution, writer, "substitution", cancellationToken); // 370
			Serialize(name.PriorPrescription, writer, "priorPrescription", cancellationToken); // 380
			Serialize(name.DetectedIssue, writer, "detectedIssue", cancellationToken); // 390
			Serialize(name.EventHistory, writer, "eventHistory", cancellationToken); // 400
			writer.WriteEndElement();
		}

		public static void Serialize(MedicationStatement name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationStatement", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 130
			Serialize(name.Category, writer, "category", cancellationToken); // 140
			Serialize(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 150
			Serialize(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 150
			Serialize(name.Subject, writer, "subject", cancellationToken); // 160
			Serialize(name.Context, writer, "context", cancellationToken); // 170
			Serialize(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 180
			Serialize(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 180
			Serialize(name.DateAssertedElement, writer, "dateAsserted", cancellationToken); // 190
			Serialize(name.InformationSource, writer, "informationSource", cancellationToken); // 200
			Serialize(name.DerivedFrom, writer, "derivedFrom", cancellationToken); // 210
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 220
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 230
			Serialize(name.Note, writer, "note", cancellationToken); // 240
			Serialize(name.Dosage, writer, "dosage", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProduct name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProduct", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Type, writer, "type", cancellationToken); // 100
			Serialize(name.Domain, writer, "domain", cancellationToken); // 110
			Serialize(name.CombinedPharmaceuticalDoseForm, writer, "combinedPharmaceuticalDoseForm", cancellationToken); // 120
			Serialize(name.LegalStatusOfSupply, writer, "legalStatusOfSupply", cancellationToken); // 130
			Serialize(name.AdditionalMonitoringIndicator, writer, "additionalMonitoringIndicator", cancellationToken); // 140
			Serialize(name.SpecialMeasuresElement, writer, "specialMeasures", cancellationToken); // 150
			Serialize(name.PaediatricUseIndicator, writer, "paediatricUseIndicator", cancellationToken); // 160
			Serialize(name.ProductClassification, writer, "productClassification", cancellationToken); // 170
			Serialize(name.MarketingStatus, writer, "marketingStatus", cancellationToken); // 180
			Serialize(name.PharmaceuticalProduct, writer, "pharmaceuticalProduct", cancellationToken); // 190
			Serialize(name.PackagedMedicinalProduct, writer, "packagedMedicinalProduct", cancellationToken); // 200
			Serialize(name.AttachedDocument, writer, "attachedDocument", cancellationToken); // 210
			Serialize(name.MasterFile, writer, "masterFile", cancellationToken); // 220
			Serialize(name.Contact, writer, "contact", cancellationToken); // 230
			Serialize(name.ClinicalTrial, writer, "clinicalTrial", cancellationToken); // 240
			Serialize(name.Name, writer, "name", cancellationToken); // 250
			Serialize(name.CrossReference, writer, "crossReference", cancellationToken); // 260
			Serialize(name.ManufacturingBusinessOperation, writer, "manufacturingBusinessOperation", cancellationToken); // 270
			Serialize(name.SpecialDesignation, writer, "specialDesignation", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductAuthorization name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductAuthorization", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Subject, writer, "subject", cancellationToken); // 100
			Serialize(name.Country, writer, "country", cancellationToken); // 110
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 120
			Serialize(name.Status, writer, "status", cancellationToken); // 130
			Serialize(name.StatusDateElement, writer, "statusDate", cancellationToken); // 140
			Serialize(name.RestoreDateElement, writer, "restoreDate", cancellationToken); // 150
			Serialize(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 160
			Serialize(name.DataExclusivityPeriod, writer, "dataExclusivityPeriod", cancellationToken); // 170
			Serialize(name.DateOfFirstAuthorizationElement, writer, "dateOfFirstAuthorization", cancellationToken); // 180
			Serialize(name.InternationalBirthDateElement, writer, "internationalBirthDate", cancellationToken); // 190
			Serialize(name.LegalBasis, writer, "legalBasis", cancellationToken); // 200
			Serialize(name.JurisdictionalAuthorization, writer, "jurisdictionalAuthorization", cancellationToken); // 210
			Serialize(name.Holder, writer, "holder", cancellationToken); // 220
			Serialize(name.Regulator, writer, "regulator", cancellationToken); // 230
			Serialize(name.Procedure, writer, "procedure", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductContraindication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductContraindication", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Subject, writer, "subject", cancellationToken); // 90
			Serialize(name.Disease, writer, "disease", cancellationToken); // 100
			Serialize(name.DiseaseStatus, writer, "diseaseStatus", cancellationToken); // 110
			Serialize(name.Comorbidity, writer, "comorbidity", cancellationToken); // 120
			Serialize(name.TherapeuticIndication, writer, "therapeuticIndication", cancellationToken); // 130
			Serialize(name.OtherTherapy, writer, "otherTherapy", cancellationToken); // 140
			Serialize(name.Population, writer, "population", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductIndication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductIndication", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Subject, writer, "subject", cancellationToken); // 90
			Serialize(name.DiseaseSymptomProcedure, writer, "diseaseSymptomProcedure", cancellationToken); // 100
			Serialize(name.DiseaseStatus, writer, "diseaseStatus", cancellationToken); // 110
			Serialize(name.Comorbidity, writer, "comorbidity", cancellationToken); // 120
			Serialize(name.IntendedEffect, writer, "intendedEffect", cancellationToken); // 130
			Serialize(name.Duration, writer, "duration", cancellationToken); // 140
			Serialize(name.OtherTherapy, writer, "otherTherapy", cancellationToken); // 150
			Serialize(name.UndesirableEffect, writer, "undesirableEffect", cancellationToken); // 160
			Serialize(name.Population, writer, "population", cancellationToken); // 170
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductIngredient name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductIngredient", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Role, writer, "role", cancellationToken); // 100
			Serialize(name.AllergenicIndicatorElement, writer, "allergenicIndicator", cancellationToken); // 110
			Serialize(name.Manufacturer, writer, "manufacturer", cancellationToken); // 120
			Serialize(name.SpecifiedSubstance, writer, "specifiedSubstance", cancellationToken); // 130
			Serialize(name.Substance, writer, "substance", cancellationToken); // 140
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductInteraction name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductInteraction", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Subject, writer, "subject", cancellationToken); // 90
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 100
			Serialize(name.Interactant, writer, "interactant", cancellationToken); // 110
			Serialize(name.Type, writer, "type", cancellationToken); // 120
			Serialize(name.Effect, writer, "effect", cancellationToken); // 130
			Serialize(name.Incidence, writer, "incidence", cancellationToken); // 140
			Serialize(name.Management, writer, "management", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductManufactured name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductManufactured", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.ManufacturedDoseForm, writer, "manufacturedDoseForm", cancellationToken); // 90
			Serialize(name.UnitOfPresentation, writer, "unitOfPresentation", cancellationToken); // 100
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 110
			Serialize(name.Manufacturer, writer, "manufacturer", cancellationToken); // 120
			Serialize(name.Ingredient, writer, "ingredient", cancellationToken); // 130
			Serialize(name.PhysicalCharacteristics, writer, "physicalCharacteristics", cancellationToken); // 140
			Serialize(name.OtherCharacteristics, writer, "otherCharacteristics", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductPackaged name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductPackaged", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Subject, writer, "subject", cancellationToken); // 100
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 110
			Serialize(name.LegalStatusOfSupply, writer, "legalStatusOfSupply", cancellationToken); // 120
			Serialize(name.MarketingStatus, writer, "marketingStatus", cancellationToken); // 130
			Serialize(name.MarketingAuthorization, writer, "marketingAuthorization", cancellationToken); // 140
			Serialize(name.Manufacturer, writer, "manufacturer", cancellationToken); // 150
			Serialize(name.BatchIdentifier, writer, "batchIdentifier", cancellationToken); // 160
			Serialize(name.PackageItem, writer, "packageItem", cancellationToken); // 170
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductPharmaceutical name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductPharmaceutical", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.AdministrableDoseForm, writer, "administrableDoseForm", cancellationToken); // 100
			Serialize(name.UnitOfPresentation, writer, "unitOfPresentation", cancellationToken); // 110
			Serialize(name.Ingredient, writer, "ingredient", cancellationToken); // 120
			Serialize(name.Device, writer, "device", cancellationToken); // 130
			Serialize(name.Characteristics, writer, "characteristics", cancellationToken); // 140
			Serialize(name.RouteOfAdministration, writer, "routeOfAdministration", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(MedicinalProductUndesirableEffect name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductUndesirableEffect", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Subject, writer, "subject", cancellationToken); // 90
			Serialize(name.SymptomConditionEffect, writer, "symptomConditionEffect", cancellationToken); // 100
			Serialize(name.Classification, writer, "classification", cancellationToken); // 110
			Serialize(name.FrequencyOfOccurrence, writer, "frequencyOfOccurrence", cancellationToken); // 120
			Serialize(name.Population, writer, "population", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Serialize(MessageDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MessageDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.ReplacesElement, writer, "replaces", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Serialize(name.DateElement, writer, "date", cancellationToken); // 170
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 180
			Serialize(name.Contact, writer, "contact", cancellationToken); // 190
			Serialize(name.Description, writer, "description", cancellationToken); // 200
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 210
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 220
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 230
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 240
			Serialize(name.BaseElement, writer, "base", cancellationToken); // 250
			Serialize(name.ParentElement, writer, "parent", cancellationToken); // 260
			Serialize(name.Event as Hl7.Fhir.Model.Coding, writer, "eventCoding", cancellationToken); // 270
			Serialize(name.Event as Hl7.Fhir.Model.FhirUri, writer, "eventUri", cancellationToken); // 270
			Serialize(name.CategoryElement, writer, "category", cancellationToken); // 280
			Serialize(name.Focus, writer, "focus", cancellationToken); // 290
			Serialize(name.ResponseRequiredElement, writer, "responseRequired", cancellationToken); // 300
			Serialize(name.AllowedResponse, writer, "allowedResponse", cancellationToken); // 310
			Serialize(name.GraphElement, writer, "graph", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(MessageHeader name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MessageHeader", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Event as Hl7.Fhir.Model.Coding, writer, "eventCoding", cancellationToken); // 90
			Serialize(name.Event as Hl7.Fhir.Model.FhirUri, writer, "eventUri", cancellationToken); // 90
			Serialize(name.Destination, writer, "destination", cancellationToken); // 100
			Serialize(name.Sender, writer, "sender", cancellationToken); // 110
			Serialize(name.Enterer, writer, "enterer", cancellationToken); // 120
			Serialize(name.Author, writer, "author", cancellationToken); // 130
			Serialize(name.Source, writer, "source", cancellationToken); // 140
			Serialize(name.Responsible, writer, "responsible", cancellationToken); // 150
			Serialize(name.Reason, writer, "reason", cancellationToken); // 160
			Serialize(name.Response, writer, "response", cancellationToken); // 170
			Serialize(name.Focus, writer, "focus", cancellationToken); // 180
			Serialize(name.DefinitionElement, writer, "definition", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(MolecularSequence name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MolecularSequence", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 100
			Serialize(name.CoordinateSystemElement, writer, "coordinateSystem", cancellationToken); // 110
			Serialize(name.Patient, writer, "patient", cancellationToken); // 120
			Serialize(name.Specimen, writer, "specimen", cancellationToken); // 130
			Serialize(name.Device, writer, "device", cancellationToken); // 140
			Serialize(name.Performer, writer, "performer", cancellationToken); // 150
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 160
			Serialize(name.ReferenceSeq, writer, "referenceSeq", cancellationToken); // 170
			Serialize(name.Variant, writer, "variant", cancellationToken); // 180
			Serialize(name.ObservedSeqElement, writer, "observedSeq", cancellationToken); // 190
			Serialize(name.Quality, writer, "quality", cancellationToken); // 200
			Serialize(name.ReadCoverageElement, writer, "readCoverage", cancellationToken); // 210
			Serialize(name.Repository, writer, "repository", cancellationToken); // 220
			Serialize(name.Pointer, writer, "pointer", cancellationToken); // 230
			Serialize(name.StructureVariant, writer, "structureVariant", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(NamingSystem name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("NamingSystem", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.NameElement, writer, "name", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.KindElement, writer, "kind", cancellationToken); // 110
			Serialize(name.DateElement, writer, "date", cancellationToken); // 120
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 130
			Serialize(name.Contact, writer, "contact", cancellationToken); // 140
			Serialize(name.ResponsibleElement, writer, "responsible", cancellationToken); // 150
			Serialize(name.Type, writer, "type", cancellationToken); // 160
			Serialize(name.Description, writer, "description", cancellationToken); // 170
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 180
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 190
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 200
			Serialize(name.UniqueId, writer, "uniqueId", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(NutritionOrder name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("NutritionOrder", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.InstantiatesElement, writer, "instantiates", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 140
			Serialize(name.Patient, writer, "patient", cancellationToken); // 150
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 160
			Serialize(name.DateTimeElement, writer, "dateTime", cancellationToken); // 170
			Serialize(name.Orderer, writer, "orderer", cancellationToken); // 180
			Serialize(name.AllergyIntolerance, writer, "allergyIntolerance", cancellationToken); // 190
			Serialize(name.FoodPreferenceModifier, writer, "foodPreferenceModifier", cancellationToken); // 200
			Serialize(name.ExcludeFoodModifier, writer, "excludeFoodModifier", cancellationToken); // 210
			Serialize(name.OralDiet, writer, "oralDiet", cancellationToken); // 220
			Serialize(name.Supplement, writer, "supplement", cancellationToken); // 230
			Serialize(name.EnteralFormula, writer, "enteralFormula", cancellationToken); // 240
			Serialize(name.Note, writer, "note", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(Observation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Observation", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.Category, writer, "category", cancellationToken); // 130
			Serialize(name.Code, writer, "code", cancellationToken); // 140
			Serialize(name.Subject, writer, "subject", cancellationToken); // 150
			Serialize(name.Focus, writer, "focus", cancellationToken); // 160
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 170
			Serialize(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 180
			Serialize(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 180
			Serialize(name.Effective as Hl7.Fhir.Model.Timing, writer, "effectiveTiming", cancellationToken); // 180
			Serialize(name.Effective as Hl7.Fhir.Model.Instant, writer, "effectiveInstant", cancellationToken); // 180
			Serialize(name.IssuedElement, writer, "issued", cancellationToken); // 190
			Serialize(name.Performer, writer, "performer", cancellationToken); // 200
			Serialize(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 210
			Serialize(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 210
			Serialize(name.DataAbsentReason, writer, "dataAbsentReason", cancellationToken); // 220
			Serialize(name.Interpretation, writer, "interpretation", cancellationToken); // 230
			Serialize(name.Note, writer, "note", cancellationToken); // 240
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 250
			Serialize(name.Method, writer, "method", cancellationToken); // 260
			Serialize(name.Specimen, writer, "specimen", cancellationToken); // 270
			Serialize(name.Device, writer, "device", cancellationToken); // 280
			Serialize(name.ReferenceRange, writer, "referenceRange", cancellationToken); // 290
			Serialize(name.HasMember, writer, "hasMember", cancellationToken); // 300
			Serialize(name.DerivedFrom, writer, "derivedFrom", cancellationToken); // 310
			Serialize(name.Component, writer, "component", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(ObservationDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ObservationDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Category, writer, "category", cancellationToken); // 90
			Serialize(name.Code, writer, "code", cancellationToken); // 100
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 110
			Serialize(name.PermittedDataTypeElement, writer, "permittedDataType", cancellationToken); // 120
			Serialize(name.MultipleResultsAllowedElement, writer, "multipleResultsAllowed", cancellationToken); // 130
			Serialize(name.Method, writer, "method", cancellationToken); // 140
			Serialize(name.PreferredReportNameElement, writer, "preferredReportName", cancellationToken); // 150
			Serialize(name.QuantitativeDetails, writer, "quantitativeDetails", cancellationToken); // 160
			Serialize(name.QualifiedInterval, writer, "qualifiedInterval", cancellationToken); // 170
			Serialize(name.ValidCodedValueSet, writer, "validCodedValueSet", cancellationToken); // 180
			Serialize(name.NormalCodedValueSet, writer, "normalCodedValueSet", cancellationToken); // 190
			Serialize(name.AbnormalCodedValueSet, writer, "abnormalCodedValueSet", cancellationToken); // 200
			Serialize(name.CriticalCodedValueSet, writer, "criticalCodedValueSet", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(OperationDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("OperationDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.KindElement, writer, "kind", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 220
			Serialize(name.AffectsStateElement, writer, "affectsState", cancellationToken); // 230
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 240
			Serialize(name.Comment, writer, "comment", cancellationToken); // 250
			Serialize(name.BaseElement, writer, "base", cancellationToken); // 260
			Serialize(name.ResourceElement, writer, "resource", cancellationToken); // 270
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 280
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 290
			Serialize(name.InstanceElement, writer, "instance", cancellationToken); // 300
			Serialize(name.InputProfileElement, writer, "inputProfile", cancellationToken); // 310
			Serialize(name.OutputProfileElement, writer, "outputProfile", cancellationToken); // 320
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 330
			Serialize(name.Overload, writer, "overload", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Serialize(OperationOutcome name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("OperationOutcome", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Issue, writer, "issue", cancellationToken); // 90
			writer.WriteEndElement();
		}

		public static void Serialize(Organization name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Organization", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Type, writer, "type", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.AliasElement, writer, "alias", cancellationToken); // 130
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 140
			Serialize(name.Address, writer, "address", cancellationToken); // 150
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Serialize(OrganizationAffiliation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("OrganizationAffiliation", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Period, writer, "period", cancellationToken); // 110
			Serialize(name.Organization, writer, "organization", cancellationToken); // 120
			Serialize(name.ParticipatingOrganization, writer, "participatingOrganization", cancellationToken); // 130
			Serialize(name.Network, writer, "network", cancellationToken); // 140
			Serialize(name.Code, writer, "code", cancellationToken); // 150
			Serialize(name.Specialty, writer, "specialty", cancellationToken); // 160
			Serialize(name.Location, writer, "location", cancellationToken); // 170
			Serialize(name.HealthcareService, writer, "healthcareService", cancellationToken); // 180
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 190
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(Parameters name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Parameters", XmlNs.FHIR);
			SerializeResource(name, writer, cancellationToken);
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 50
			writer.WriteEndElement();
		}

		public static void Serialize(Patient name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Patient", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Name, writer, "name", cancellationToken); // 110
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 120
			Serialize(name.GenderElement, writer, "gender", cancellationToken); // 130
			Serialize(name.BirthDateElement, writer, "birthDate", cancellationToken); // 140
			Serialize(name.Deceased as Hl7.Fhir.Model.FhirBoolean, writer, "deceasedBoolean", cancellationToken); // 150
			Serialize(name.Deceased as Hl7.Fhir.Model.FhirDateTime, writer, "deceasedDateTime", cancellationToken); // 150
			Serialize(name.Address, writer, "address", cancellationToken); // 160
			Serialize(name.MaritalStatus, writer, "maritalStatus", cancellationToken); // 170
			Serialize(name.MultipleBirth as Hl7.Fhir.Model.FhirBoolean, writer, "multipleBirthBoolean", cancellationToken); // 180
			Serialize(name.MultipleBirth as Hl7.Fhir.Model.Integer, writer, "multipleBirthInteger", cancellationToken); // 180
			Serialize(name.Photo, writer, "photo", cancellationToken); // 190
			Serialize(name.Contact, writer, "contact", cancellationToken); // 200
			Serialize(name.Communication, writer, "communication", cancellationToken); // 210
			Serialize(name.GeneralPractitioner, writer, "generalPractitioner", cancellationToken); // 220
			Serialize(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 230
			Serialize(name.Link, writer, "link", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Serialize(PaymentNotice name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PaymentNotice", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Request, writer, "request", cancellationToken); // 110
			Serialize(name.Response, writer, "response", cancellationToken); // 120
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 130
			Serialize(name.Provider, writer, "provider", cancellationToken); // 140
			Serialize(name.Payment, writer, "payment", cancellationToken); // 150
			Serialize(name.PaymentDateElement, writer, "paymentDate", cancellationToken); // 160
			Serialize(name.Payee, writer, "payee", cancellationToken); // 170
			Serialize(name.Recipient, writer, "recipient", cancellationToken); // 180
			Serialize(name.Amount, writer, "amount", cancellationToken); // 190
			Serialize(name.PaymentStatus, writer, "paymentStatus", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(PaymentReconciliation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PaymentReconciliation", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Period, writer, "period", cancellationToken); // 110
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 120
			Serialize(name.PaymentIssuer, writer, "paymentIssuer", cancellationToken); // 130
			Serialize(name.Request, writer, "request", cancellationToken); // 140
			Serialize(name.Requestor, writer, "requestor", cancellationToken); // 150
			Serialize(name.OutcomeElement, writer, "outcome", cancellationToken); // 160
			Serialize(name.DispositionElement, writer, "disposition", cancellationToken); // 170
			Serialize(name.PaymentDateElement, writer, "paymentDate", cancellationToken); // 180
			Serialize(name.PaymentAmount, writer, "paymentAmount", cancellationToken); // 190
			Serialize(name.PaymentIdentifier, writer, "paymentIdentifier", cancellationToken); // 200
			Serialize(name.Detail, writer, "detail", cancellationToken); // 210
			Serialize(name.FormCode, writer, "formCode", cancellationToken); // 220
			Serialize(name.ProcessNote, writer, "processNote", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Serialize(Person name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Person", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Name, writer, "name", cancellationToken); // 100
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 110
			Serialize(name.GenderElement, writer, "gender", cancellationToken); // 120
			Serialize(name.BirthDateElement, writer, "birthDate", cancellationToken); // 130
			Serialize(name.Address, writer, "address", cancellationToken); // 140
			Serialize(name.Photo, writer, "photo", cancellationToken); // 150
			Serialize(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 160
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 170
			Serialize(name.Link, writer, "link", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Serialize(PlanDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PlanDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Serialize(name.Type, writer, "type", cancellationToken); // 150
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 160
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Serialize(name.DateElement, writer, "date", cancellationToken); // 190
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Serialize(name.Contact, writer, "contact", cancellationToken); // 210
			Serialize(name.Description, writer, "description", cancellationToken); // 220
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 230
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 240
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 250
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 260
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 270
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 280
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 290
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 300
			Serialize(name.Topic, writer, "topic", cancellationToken); // 310
			Serialize(name.Author, writer, "author", cancellationToken); // 320
			Serialize(name.Editor, writer, "editor", cancellationToken); // 330
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 340
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 350
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 360
			Serialize(name.LibraryElement, writer, "library", cancellationToken); // 370
			Serialize(name.Goal, writer, "goal", cancellationToken); // 380
			Serialize(name.Action, writer, "action", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Serialize(Practitioner name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Practitioner", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Name, writer, "name", cancellationToken); // 110
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 120
			Serialize(name.Address, writer, "address", cancellationToken); // 130
			Serialize(name.GenderElement, writer, "gender", cancellationToken); // 140
			Serialize(name.BirthDateElement, writer, "birthDate", cancellationToken); // 150
			Serialize(name.Photo, writer, "photo", cancellationToken); // 160
			Serialize(name.Qualification, writer, "qualification", cancellationToken); // 170
			Serialize(name.Communication, writer, "communication", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Serialize(PractitionerRole name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PractitionerRole", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Period, writer, "period", cancellationToken); // 110
			Serialize(name.Practitioner, writer, "practitioner", cancellationToken); // 120
			Serialize(name.Organization, writer, "organization", cancellationToken); // 130
			Serialize(name.Code, writer, "code", cancellationToken); // 140
			Serialize(name.Specialty, writer, "specialty", cancellationToken); // 150
			Serialize(name.Location, writer, "location", cancellationToken); // 160
			Serialize(name.HealthcareService, writer, "healthcareService", cancellationToken); // 170
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 180
			Serialize(name.AvailableTime, writer, "availableTime", cancellationToken); // 190
			Serialize(name.NotAvailable, writer, "notAvailable", cancellationToken); // 200
			Serialize(name.AvailabilityExceptionsElement, writer, "availabilityExceptions", cancellationToken); // 210
			Serialize(name.Endpoint, writer, "endpoint", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Serialize(Procedure name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Procedure", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 150
			Serialize(name.Category, writer, "category", cancellationToken); // 160
			Serialize(name.Code, writer, "code", cancellationToken); // 170
			Serialize(name.Subject, writer, "subject", cancellationToken); // 180
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 190
			Serialize(name.Performed as Hl7.Fhir.Model.FhirDateTime, writer, "performedDateTime", cancellationToken); // 200
			Serialize(name.Performed as Hl7.Fhir.Model.Period, writer, "performedPeriod", cancellationToken); // 200
			Serialize(name.Performed as Hl7.Fhir.Model.FhirString, writer, "performedString", cancellationToken); // 200
			Serialize(name.Performed as Hl7.Fhir.Model.Age, writer, "performedAge", cancellationToken); // 200
			Serialize(name.Performed as Hl7.Fhir.Model.Range, writer, "performedRange", cancellationToken); // 200
			Serialize(name.Recorder, writer, "recorder", cancellationToken); // 210
			Serialize(name.Asserter, writer, "asserter", cancellationToken); // 220
			Serialize(name.Performer, writer, "performer", cancellationToken); // 230
			Serialize(name.Location, writer, "location", cancellationToken); // 240
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 250
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 260
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 270
			Serialize(name.Outcome, writer, "outcome", cancellationToken); // 280
			Serialize(name.Report, writer, "report", cancellationToken); // 290
			Serialize(name.Complication, writer, "complication", cancellationToken); // 300
			Serialize(name.ComplicationDetail, writer, "complicationDetail", cancellationToken); // 310
			Serialize(name.FollowUp, writer, "followUp", cancellationToken); // 320
			Serialize(name.Note, writer, "note", cancellationToken); // 330
			Serialize(name.FocalDevice, writer, "focalDevice", cancellationToken); // 340
			Serialize(name.UsedReference, writer, "usedReference", cancellationToken); // 350
			Serialize(name.UsedCode, writer, "usedCode", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Serialize(Provenance name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Provenance", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Target, writer, "target", cancellationToken); // 90
			Serialize(name.Occurred as Hl7.Fhir.Model.Period, writer, "occurredPeriod", cancellationToken); // 100
			Serialize(name.Occurred as Hl7.Fhir.Model.FhirDateTime, writer, "occurredDateTime", cancellationToken); // 100
			Serialize(name.RecordedElement, writer, "recorded", cancellationToken); // 110
			Serialize(name.PolicyElement, writer, "policy", cancellationToken); // 120
			Serialize(name.Location, writer, "location", cancellationToken); // 130
			Serialize(name.Reason, writer, "reason", cancellationToken); // 140
			Serialize(name.Activity, writer, "activity", cancellationToken); // 150
			Serialize(name.Agent, writer, "agent", cancellationToken); // 160
			Serialize(name.Entity, writer, "entity", cancellationToken); // 170
			Serialize(name.Signature, writer, "signature", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Serialize(Questionnaire name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Questionnaire", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.DerivedFromElement, writer, "derivedFrom", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Serialize(name.SubjectTypeElement, writer, "subjectType", cancellationToken); // 170
			Serialize(name.DateElement, writer, "date", cancellationToken); // 180
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Serialize(name.Contact, writer, "contact", cancellationToken); // 200
			Serialize(name.Description, writer, "description", cancellationToken); // 210
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 220
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 240
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 250
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 260
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 270
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 280
			Serialize(name.Code, writer, "code", cancellationToken); // 290
			Serialize(name.Item, writer, "item", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Serialize(QuestionnaireResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("QuestionnaireResponse", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 110
			Serialize(name.QuestionnaireElement, writer, "questionnaire", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.Subject, writer, "subject", cancellationToken); // 140
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 150
			Serialize(name.AuthoredElement, writer, "authored", cancellationToken); // 160
			Serialize(name.Author, writer, "author", cancellationToken); // 170
			Serialize(name.Source, writer, "source", cancellationToken); // 180
			Serialize(name.Item, writer, "item", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(RelatedPerson name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RelatedPerson", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.Patient, writer, "patient", cancellationToken); // 110
			Serialize(name.Relationship, writer, "relationship", cancellationToken); // 120
			Serialize(name.Name, writer, "name", cancellationToken); // 130
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 140
			Serialize(name.GenderElement, writer, "gender", cancellationToken); // 150
			Serialize(name.BirthDateElement, writer, "birthDate", cancellationToken); // 160
			Serialize(name.Address, writer, "address", cancellationToken); // 170
			Serialize(name.Photo, writer, "photo", cancellationToken); // 180
			Serialize(name.Period, writer, "period", cancellationToken); // 190
			Serialize(name.Communication, writer, "communication", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(RequestGroup name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RequestGroup", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.Replaces, writer, "replaces", cancellationToken); // 130
			Serialize(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 160
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 170
			Serialize(name.Code, writer, "code", cancellationToken); // 180
			Serialize(name.Subject, writer, "subject", cancellationToken); // 190
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 200
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 210
			Serialize(name.Author, writer, "author", cancellationToken); // 220
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 230
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 240
			Serialize(name.Note, writer, "note", cancellationToken); // 250
			Serialize(name.Action, writer, "action", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Serialize(ResearchDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 160
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Serialize(name.DateElement, writer, "date", cancellationToken); // 190
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Serialize(name.Contact, writer, "contact", cancellationToken); // 210
			Serialize(name.Description, writer, "description", cancellationToken); // 220
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 230
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 240
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 250
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 260
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 270
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 280
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 290
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 300
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 310
			Serialize(name.Topic, writer, "topic", cancellationToken); // 320
			Serialize(name.Author, writer, "author", cancellationToken); // 330
			Serialize(name.Editor, writer, "editor", cancellationToken); // 340
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 350
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 360
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 370
			Serialize(name.LibraryElement, writer, "library", cancellationToken); // 380
			Serialize(name.Population, writer, "population", cancellationToken); // 390
			Serialize(name.Exposure, writer, "exposure", cancellationToken); // 400
			Serialize(name.ExposureAlternative, writer, "exposureAlternative", cancellationToken); // 410
			Serialize(name.Outcome, writer, "outcome", cancellationToken); // 420
			writer.WriteEndElement();
		}

		public static void Serialize(ResearchElementDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchElementDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Serialize(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 160
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Serialize(name.DateElement, writer, "date", cancellationToken); // 190
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Serialize(name.Contact, writer, "contact", cancellationToken); // 210
			Serialize(name.Description, writer, "description", cancellationToken); // 220
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 230
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 240
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 250
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 260
			Serialize(name.UsageElement, writer, "usage", cancellationToken); // 270
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 280
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 290
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 300
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 310
			Serialize(name.Topic, writer, "topic", cancellationToken); // 320
			Serialize(name.Author, writer, "author", cancellationToken); // 330
			Serialize(name.Editor, writer, "editor", cancellationToken); // 340
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 350
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 360
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 370
			Serialize(name.LibraryElement, writer, "library", cancellationToken); // 380
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 390
			Serialize(name.VariableTypeElement, writer, "variableType", cancellationToken); // 400
			Serialize(name.Characteristic, writer, "characteristic", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Serialize(ResearchStudy name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchStudy", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 100
			Serialize(name.Protocol, writer, "protocol", cancellationToken); // 110
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.PrimaryPurposeType, writer, "primaryPurposeType", cancellationToken); // 140
			Serialize(name.Phase, writer, "phase", cancellationToken); // 150
			Serialize(name.Category, writer, "category", cancellationToken); // 160
			Serialize(name.Focus, writer, "focus", cancellationToken); // 170
			Serialize(name.Condition, writer, "condition", cancellationToken); // 180
			Serialize(name.Contact, writer, "contact", cancellationToken); // 190
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 200
			Serialize(name.Keyword, writer, "keyword", cancellationToken); // 210
			Serialize(name.Location, writer, "location", cancellationToken); // 220
			Serialize(name.Description, writer, "description", cancellationToken); // 230
			Serialize(name.Enrollment, writer, "enrollment", cancellationToken); // 240
			Serialize(name.Period, writer, "period", cancellationToken); // 250
			Serialize(name.Sponsor, writer, "sponsor", cancellationToken); // 260
			Serialize(name.PrincipalInvestigator, writer, "principalInvestigator", cancellationToken); // 270
			Serialize(name.Site, writer, "site", cancellationToken); // 280
			Serialize(name.ReasonStopped, writer, "reasonStopped", cancellationToken); // 290
			Serialize(name.Note, writer, "note", cancellationToken); // 300
			Serialize(name.Arm, writer, "arm", cancellationToken); // 310
			Serialize(name.Objective, writer, "objective", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(ResearchSubject name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchSubject", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Period, writer, "period", cancellationToken); // 110
			Serialize(name.Study, writer, "study", cancellationToken); // 120
			Serialize(name.Individual, writer, "individual", cancellationToken); // 130
			Serialize(name.AssignedArmElement, writer, "assignedArm", cancellationToken); // 140
			Serialize(name.ActualArmElement, writer, "actualArm", cancellationToken); // 150
			Serialize(name.Consent, writer, "consent", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(RiskAssessment name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RiskAssessment", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.Parent, writer, "parent", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.Method, writer, "method", cancellationToken); // 130
			Serialize(name.Code, writer, "code", cancellationToken); // 140
			Serialize(name.Subject, writer, "subject", cancellationToken); // 150
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 160
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 170
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 170
			Serialize(name.Condition, writer, "condition", cancellationToken); // 180
			Serialize(name.Performer, writer, "performer", cancellationToken); // 190
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 200
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 210
			Serialize(name.Basis, writer, "basis", cancellationToken); // 220
			Serialize(name.Prediction, writer, "prediction", cancellationToken); // 230
			Serialize(name.MitigationElement, writer, "mitigation", cancellationToken); // 240
			Serialize(name.Note, writer, "note", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Serialize(RiskEvidenceSynthesis name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RiskEvidenceSynthesis", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Description, writer, "description", cancellationToken); // 180
			Serialize(name.Note, writer, "note", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 220
			Serialize(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 230
			Serialize(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 240
			Serialize(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 250
			Serialize(name.Topic, writer, "topic", cancellationToken); // 260
			Serialize(name.Author, writer, "author", cancellationToken); // 270
			Serialize(name.Editor, writer, "editor", cancellationToken); // 280
			Serialize(name.Reviewer, writer, "reviewer", cancellationToken); // 290
			Serialize(name.Endorser, writer, "endorser", cancellationToken); // 300
			Serialize(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 310
			Serialize(name.SynthesisType, writer, "synthesisType", cancellationToken); // 320
			Serialize(name.StudyType, writer, "studyType", cancellationToken); // 330
			Serialize(name.Population, writer, "population", cancellationToken); // 340
			Serialize(name.Exposure, writer, "exposure", cancellationToken); // 350
			Serialize(name.Outcome, writer, "outcome", cancellationToken); // 360
			Serialize(name.SampleSize, writer, "sampleSize", cancellationToken); // 370
			Serialize(name.RiskEstimate, writer, "riskEstimate", cancellationToken); // 380
			Serialize(name.Certainty, writer, "certainty", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Serialize(Schedule name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Schedule", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ActiveElement, writer, "active", cancellationToken); // 100
			Serialize(name.ServiceCategory, writer, "serviceCategory", cancellationToken); // 110
			Serialize(name.ServiceType, writer, "serviceType", cancellationToken); // 120
			Serialize(name.Specialty, writer, "specialty", cancellationToken); // 130
			Serialize(name.Actor, writer, "actor", cancellationToken); // 140
			Serialize(name.PlanningHorizon, writer, "planningHorizon", cancellationToken); // 150
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Serialize(SearchParameter name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SearchParameter", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.DerivedFromElement, writer, "derivedFrom", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Description, writer, "description", cancellationToken); // 180
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 190
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 210
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 220
			Serialize(name.BaseElement, writer, "base", cancellationToken); // 230
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 240
			Serialize(name.ExpressionElement, writer, "expression", cancellationToken); // 250
			Serialize(name.XpathElement, writer, "xpath", cancellationToken); // 260
			Serialize(name.XpathUsageElement, writer, "xpathUsage", cancellationToken); // 270
			Serialize(name.TargetElement, writer, "target", cancellationToken); // 280
			Serialize(name.MultipleOrElement, writer, "multipleOr", cancellationToken); // 290
			Serialize(name.MultipleAndElement, writer, "multipleAnd", cancellationToken); // 300
			Serialize(name.ComparatorElement, writer, "comparator", cancellationToken); // 310
			Serialize(name.ModifierElement, writer, "modifier", cancellationToken); // 320
			Serialize(name.ChainElement, writer, "chain", cancellationToken); // 330
			Serialize(name.Component, writer, "component", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Serialize(ServiceRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ServiceRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.Replaces, writer, "replaces", cancellationToken); // 130
			Serialize(name.Requisition, writer, "requisition", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 160
			Serialize(name.Category, writer, "category", cancellationToken); // 170
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 180
			Serialize(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 190
			Serialize(name.Code, writer, "code", cancellationToken); // 200
			Serialize(name.OrderDetail, writer, "orderDetail", cancellationToken); // 210
			Serialize(name.Quantity as Hl7.Fhir.Model.Quantity, writer, "quantityQuantity", cancellationToken); // 220
			Serialize(name.Quantity as Hl7.Fhir.Model.Ratio, writer, "quantityRatio", cancellationToken); // 220
			Serialize(name.Quantity as Hl7.Fhir.Model.Range, writer, "quantityRange", cancellationToken); // 220
			Serialize(name.Subject, writer, "subject", cancellationToken); // 230
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 240
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 250
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 250
			Serialize(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 250
			Serialize(name.AsNeeded as Hl7.Fhir.Model.FhirBoolean, writer, "asNeededBoolean", cancellationToken); // 260
			Serialize(name.AsNeeded as Hl7.Fhir.Model.CodeableConcept, writer, "asNeededCodeableConcept", cancellationToken); // 260
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 270
			Serialize(name.Requester, writer, "requester", cancellationToken); // 280
			Serialize(name.PerformerType, writer, "performerType", cancellationToken); // 290
			Serialize(name.Performer, writer, "performer", cancellationToken); // 300
			Serialize(name.LocationCode, writer, "locationCode", cancellationToken); // 310
			Serialize(name.LocationReference, writer, "locationReference", cancellationToken); // 320
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 330
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 340
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 350
			Serialize(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 360
			Serialize(name.Specimen, writer, "specimen", cancellationToken); // 370
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 380
			Serialize(name.Note, writer, "note", cancellationToken); // 390
			Serialize(name.PatientInstructionElement, writer, "patientInstruction", cancellationToken); // 400
			Serialize(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Serialize(Slot name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Slot", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.ServiceCategory, writer, "serviceCategory", cancellationToken); // 100
			Serialize(name.ServiceType, writer, "serviceType", cancellationToken); // 110
			Serialize(name.Specialty, writer, "specialty", cancellationToken); // 120
			Serialize(name.AppointmentType, writer, "appointmentType", cancellationToken); // 130
			Serialize(name.Schedule, writer, "schedule", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.StartElement, writer, "start", cancellationToken); // 160
			Serialize(name.EndElement, writer, "end", cancellationToken); // 170
			Serialize(name.OverbookedElement, writer, "overbooked", cancellationToken); // 180
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(Specimen name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Specimen", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.AccessionIdentifier, writer, "accessionIdentifier", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.Type, writer, "type", cancellationToken); // 120
			Serialize(name.Subject, writer, "subject", cancellationToken); // 130
			Serialize(name.ReceivedTimeElement, writer, "receivedTime", cancellationToken); // 140
			Serialize(name.Parent, writer, "parent", cancellationToken); // 150
			Serialize(name.Request, writer, "request", cancellationToken); // 160
			Serialize(name.Collection, writer, "collection", cancellationToken); // 170
			Serialize(name.Processing, writer, "processing", cancellationToken); // 180
			Serialize(name.Container, writer, "container", cancellationToken); // 190
			Serialize(name.Condition, writer, "condition", cancellationToken); // 200
			Serialize(name.Note, writer, "note", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(SpecimenDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SpecimenDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.TypeCollected, writer, "typeCollected", cancellationToken); // 100
			Serialize(name.PatientPreparation, writer, "patientPreparation", cancellationToken); // 110
			Serialize(name.TimeAspectElement, writer, "timeAspect", cancellationToken); // 120
			Serialize(name.Collection, writer, "collection", cancellationToken); // 130
			Serialize(name.TypeTested, writer, "typeTested", cancellationToken); // 140
			writer.WriteEndElement();
		}

		public static void Serialize(StructureDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("StructureDefinition", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 220
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 230
			Serialize(name.Keyword, writer, "keyword", cancellationToken); // 240
			Serialize(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 250
			Serialize(name.Mapping, writer, "mapping", cancellationToken); // 260
			Serialize(name.KindElement, writer, "kind", cancellationToken); // 270
			Serialize(name.AbstractElement, writer, "abstract", cancellationToken); // 280
			Serialize(name.Context, writer, "context", cancellationToken); // 290
			Serialize(name.ContextInvariantElement, writer, "contextInvariant", cancellationToken); // 300
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 310
			Serialize(name.BaseDefinitionElement, writer, "baseDefinition", cancellationToken); // 320
			Serialize(name.DerivationElement, writer, "derivation", cancellationToken); // 330
			Serialize(name.Snapshot, writer, "snapshot", cancellationToken); // 340
			Serialize(name.Differential, writer, "differential", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Serialize(StructureMap name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("StructureMap", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 220
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 230
			Serialize(name.Structure, writer, "structure", cancellationToken); // 240
			Serialize(name.ImportElement, writer, "import", cancellationToken); // 250
			Serialize(name.Group, writer, "group", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Serialize(Subscription name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Subscription", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 90
			Serialize(name.Contact, writer, "contact", cancellationToken); // 100
			Serialize(name.EndElement, writer, "end", cancellationToken); // 110
			Serialize(name.ReasonElement, writer, "reason", cancellationToken); // 120
			Serialize(name.CriteriaElement, writer, "criteria", cancellationToken); // 130
			Serialize(name.ErrorElement, writer, "error", cancellationToken); // 140
			Serialize(name.Channel, writer, "channel", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(Substance name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Substance", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Category, writer, "category", cancellationToken); // 110
			Serialize(name.Code, writer, "code", cancellationToken); // 120
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 130
			Serialize(name.Instance, writer, "instance", cancellationToken); // 140
			Serialize(name.Ingredient, writer, "ingredient", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Serialize(SubstanceNucleicAcid name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceNucleicAcid", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.SequenceType, writer, "sequenceType", cancellationToken); // 90
			Serialize(name.NumberOfSubunitsElement, writer, "numberOfSubunits", cancellationToken); // 100
			Serialize(name.AreaOfHybridisationElement, writer, "areaOfHybridisation", cancellationToken); // 110
			Serialize(name.OligoNucleotideType, writer, "oligoNucleotideType", cancellationToken); // 120
			Serialize(name.Subunit, writer, "subunit", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Serialize(SubstancePolymer name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstancePolymer", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Class, writer, "class", cancellationToken); // 90
			Serialize(name.Geometry, writer, "geometry", cancellationToken); // 100
			Serialize(name.CopolymerConnectivity, writer, "copolymerConnectivity", cancellationToken); // 110
			Serialize(name.ModificationElement, writer, "modification", cancellationToken); // 120
			Serialize(name.MonomerSet, writer, "monomerSet", cancellationToken); // 130
			Serialize(name.Repeat, writer, "repeat", cancellationToken); // 140
			writer.WriteEndElement();
		}

		public static void Serialize(SubstanceProtein name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceProtein", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.SequenceType, writer, "sequenceType", cancellationToken); // 90
			Serialize(name.NumberOfSubunitsElement, writer, "numberOfSubunits", cancellationToken); // 100
			Serialize(name.DisulfideLinkageElement, writer, "disulfideLinkage", cancellationToken); // 110
			Serialize(name.Subunit, writer, "subunit", cancellationToken); // 120
			writer.WriteEndElement();
		}

		public static void Serialize(SubstanceReferenceInformation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceReferenceInformation", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 90
			Serialize(name.Gene, writer, "gene", cancellationToken); // 100
			Serialize(name.GeneElement, writer, "geneElement", cancellationToken); // 110
			Serialize(name.Classification, writer, "classification", cancellationToken); // 120
			Serialize(name.Target, writer, "target", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Serialize(SubstanceSourceMaterial name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceSourceMaterial", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.SourceMaterialClass, writer, "sourceMaterialClass", cancellationToken); // 90
			Serialize(name.SourceMaterialType, writer, "sourceMaterialType", cancellationToken); // 100
			Serialize(name.SourceMaterialState, writer, "sourceMaterialState", cancellationToken); // 110
			Serialize(name.OrganismId, writer, "organismId", cancellationToken); // 120
			Serialize(name.OrganismNameElement, writer, "organismName", cancellationToken); // 130
			Serialize(name.ParentSubstanceId, writer, "parentSubstanceId", cancellationToken); // 140
			Serialize(name.ParentSubstanceNameElement, writer, "parentSubstanceName", cancellationToken); // 150
			Serialize(name.CountryOfOrigin, writer, "countryOfOrigin", cancellationToken); // 160
			Serialize(name.GeographicalLocationElement, writer, "geographicalLocation", cancellationToken); // 170
			Serialize(name.DevelopmentStage, writer, "developmentStage", cancellationToken); // 180
			Serialize(name.FractionDescription, writer, "fractionDescription", cancellationToken); // 190
			Serialize(name.Organism, writer, "organism", cancellationToken); // 200
			Serialize(name.PartDescription, writer, "partDescription", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Serialize(SubstanceSpecification name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceSpecification", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Type, writer, "type", cancellationToken); // 100
			Serialize(name.Status, writer, "status", cancellationToken); // 110
			Serialize(name.Domain, writer, "domain", cancellationToken); // 120
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 130
			Serialize(name.Source, writer, "source", cancellationToken); // 140
			Serialize(name.CommentElement, writer, "comment", cancellationToken); // 150
			Serialize(name.Moiety, writer, "moiety", cancellationToken); // 160
			Serialize(name.Property, writer, "property", cancellationToken); // 170
			Serialize(name.ReferenceInformation, writer, "referenceInformation", cancellationToken); // 180
			Serialize(name.Structure, writer, "structure", cancellationToken); // 190
			Serialize(name.Code, writer, "code", cancellationToken); // 200
			Serialize(name.Name, writer, "name", cancellationToken); // 210
			Serialize(name.MolecularWeight, writer, "molecularWeight", cancellationToken); // 220
			Serialize(name.Relationship, writer, "relationship", cancellationToken); // 230
			Serialize(name.NucleicAcid, writer, "nucleicAcid", cancellationToken); // 240
			Serialize(name.Polymer, writer, "polymer", cancellationToken); // 250
			Serialize(name.Protein, writer, "protein", cancellationToken); // 260
			Serialize(name.SourceMaterial, writer, "sourceMaterial", cancellationToken); // 270
			writer.WriteEndElement();
		}

		public static void Serialize(SupplyDelivery name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SupplyDelivery", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.Patient, writer, "patient", cancellationToken); // 130
			Serialize(name.Type, writer, "type", cancellationToken); // 140
			Serialize(name.SuppliedItem, writer, "suppliedItem", cancellationToken); // 150
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 160
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 160
			Serialize(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 160
			Serialize(name.Supplier, writer, "supplier", cancellationToken); // 170
			Serialize(name.Destination, writer, "destination", cancellationToken); // 180
			Serialize(name.Receiver, writer, "receiver", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Serialize(SupplyRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SupplyRequest", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.Category, writer, "category", cancellationToken); // 110
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 120
			Serialize(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 130
			Serialize(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 130
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 140
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 150
			Serialize(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 160
			Serialize(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 160
			Serialize(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 160
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 170
			Serialize(name.Requester, writer, "requester", cancellationToken); // 180
			Serialize(name.Supplier, writer, "supplier", cancellationToken); // 190
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 200
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 210
			Serialize(name.DeliverFrom, writer, "deliverFrom", cancellationToken); // 220
			Serialize(name.DeliverTo, writer, "deliverTo", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Serialize(Task name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Task", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Serialize(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Serialize(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Serialize(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 130
			Serialize(name.PartOf, writer, "partOf", cancellationToken); // 140
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 150
			Serialize(name.StatusReason, writer, "statusReason", cancellationToken); // 160
			Serialize(name.BusinessStatus, writer, "businessStatus", cancellationToken); // 170
			Serialize(name.IntentElement, writer, "intent", cancellationToken); // 180
			Serialize(name.PriorityElement, writer, "priority", cancellationToken); // 190
			Serialize(name.Code, writer, "code", cancellationToken); // 200
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 210
			Serialize(name.Focus, writer, "focus", cancellationToken); // 220
			Serialize(name.For, writer, "for", cancellationToken); // 230
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 240
			Serialize(name.ExecutionPeriod, writer, "executionPeriod", cancellationToken); // 250
			Serialize(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 260
			Serialize(name.LastModifiedElement, writer, "lastModified", cancellationToken); // 270
			Serialize(name.Requester, writer, "requester", cancellationToken); // 280
			Serialize(name.PerformerType, writer, "performerType", cancellationToken); // 290
			Serialize(name.Owner, writer, "owner", cancellationToken); // 300
			Serialize(name.Location, writer, "location", cancellationToken); // 310
			Serialize(name.ReasonCode, writer, "reasonCode", cancellationToken); // 320
			Serialize(name.ReasonReference, writer, "reasonReference", cancellationToken); // 330
			Serialize(name.Insurance, writer, "insurance", cancellationToken); // 340
			Serialize(name.Note, writer, "note", cancellationToken); // 350
			Serialize(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 360
			Serialize(name.Restriction, writer, "restriction", cancellationToken); // 370
			Serialize(name.Input, writer, "input", cancellationToken); // 380
			Serialize(name.Output, writer, "output", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Serialize(TerminologyCapabilities name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("TerminologyCapabilities", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 100
			Serialize(name.NameElement, writer, "name", cancellationToken); // 110
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 120
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 130
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Serialize(name.DateElement, writer, "date", cancellationToken); // 150
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Serialize(name.Contact, writer, "contact", cancellationToken); // 170
			Serialize(name.Description, writer, "description", cancellationToken); // 180
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 190
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 210
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 220
			Serialize(name.KindElement, writer, "kind", cancellationToken); // 230
			Serialize(name.Software, writer, "software", cancellationToken); // 240
			Serialize(name.Implementation, writer, "implementation", cancellationToken); // 250
			Serialize(name.LockedDateElement, writer, "lockedDate", cancellationToken); // 260
			Serialize(name.CodeSystem, writer, "codeSystem", cancellationToken); // 270
			Serialize(name.Expansion, writer, "expansion", cancellationToken); // 280
			Serialize(name.CodeSearchElement, writer, "codeSearch", cancellationToken); // 290
			Serialize(name.ValidateCode, writer, "validateCode", cancellationToken); // 300
			Serialize(name.Translation, writer, "translation", cancellationToken); // 310
			Serialize(name.Closure, writer, "closure", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(TestReport name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("TestReport", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.NameElement, writer, "name", cancellationToken); // 100
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 110
			Serialize(name.TestScript, writer, "testScript", cancellationToken); // 120
			Serialize(name.ResultElement, writer, "result", cancellationToken); // 130
			Serialize(name.ScoreElement, writer, "score", cancellationToken); // 140
			Serialize(name.TesterElement, writer, "tester", cancellationToken); // 150
			Serialize(name.IssuedElement, writer, "issued", cancellationToken); // 160
			Serialize(name.Participant, writer, "participant", cancellationToken); // 170
			Serialize(name.Setup, writer, "setup", cancellationToken); // 180
			Serialize(name.Test, writer, "test", cancellationToken); // 190
			Serialize(name.Teardown, writer, "teardown", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Serialize(TestScript name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("TestScript", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 220
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 230
			Serialize(name.Origin, writer, "origin", cancellationToken); // 240
			Serialize(name.Destination, writer, "destination", cancellationToken); // 250
			Serialize(name.Metadata, writer, "metadata", cancellationToken); // 260
			Serialize(name.Fixture, writer, "fixture", cancellationToken); // 270
			Serialize(name.Profile, writer, "profile", cancellationToken); // 280
			Serialize(name.Variable, writer, "variable", cancellationToken); // 290
			Serialize(name.Setup, writer, "setup", cancellationToken); // 300
			Serialize(name.Test, writer, "test", cancellationToken); // 310
			Serialize(name.Teardown, writer, "teardown", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Serialize(ValueSet name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ValueSet", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 90
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 100
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 110
			Serialize(name.NameElement, writer, "name", cancellationToken); // 120
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 130
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 140
			Serialize(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Serialize(name.DateElement, writer, "date", cancellationToken); // 160
			Serialize(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Serialize(name.Contact, writer, "contact", cancellationToken); // 180
			Serialize(name.Description, writer, "description", cancellationToken); // 190
			Serialize(name.UseContext, writer, "useContext", cancellationToken); // 200
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Serialize(name.ImmutableElement, writer, "immutable", cancellationToken); // 220
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 230
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 240
			Serialize(name.Compose, writer, "compose", cancellationToken); // 250
			Serialize(name.Expansion, writer, "expansion", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Serialize(VerificationResult name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("VerificationResult", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Target, writer, "target", cancellationToken); // 90
			Serialize(name.TargetLocationElement, writer, "targetLocation", cancellationToken); // 100
			Serialize(name.Need, writer, "need", cancellationToken); // 110
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 120
			Serialize(name.StatusDateElement, writer, "statusDate", cancellationToken); // 130
			Serialize(name.ValidationType, writer, "validationType", cancellationToken); // 140
			Serialize(name.ValidationProcess, writer, "validationProcess", cancellationToken); // 150
			Serialize(name.Frequency, writer, "frequency", cancellationToken); // 160
			Serialize(name.LastPerformedElement, writer, "lastPerformed", cancellationToken); // 170
			Serialize(name.NextScheduledElement, writer, "nextScheduled", cancellationToken); // 180
			Serialize(name.FailureAction, writer, "failureAction", cancellationToken); // 190
			Serialize(name.PrimarySource, writer, "primarySource", cancellationToken); // 200
			Serialize(name.Attestation, writer, "attestation", cancellationToken); // 210
			Serialize(name.Validator, writer, "validator", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Serialize(VisionPrescription name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("VisionPrescription", XmlNs.FHIR);
			SerializeDomainResource(name, writer, cancellationToken);
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 100
			Serialize(name.CreatedElement, writer, "created", cancellationToken); // 110
			Serialize(name.Patient, writer, "patient", cancellationToken); // 120
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 130
			Serialize(name.DateWrittenElement, writer, "dateWritten", cancellationToken); // 140
			Serialize(name.Prescriber, writer, "prescriber", cancellationToken); // 150
			Serialize(name.LensSpecification, writer, "lensSpecification", cancellationToken); // 160
			writer.WriteEndElement();
		}

// ---------------------------
		// Hl7.Fhir.Model.Address
		public static void Serialize(Hl7.Fhir.Model.Address name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.UseElement, writer, "use", cancellationToken); // 30
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 40
			Serialize(name.TextElement, writer, "text", cancellationToken); // 50
			Serialize(name.LineElement, writer, "line", cancellationToken); // 60
			Serialize(name.CityElement, writer, "city", cancellationToken); // 70
			Serialize(name.DistrictElement, writer, "district", cancellationToken); // 80
			Serialize(name.StateElement, writer, "state", cancellationToken); // 90
			Serialize(name.PostalCodeElement, writer, "postalCode", cancellationToken); // 100
			Serialize(name.CountryElement, writer, "country", cancellationToken); // 110
			Serialize(name.Period, writer, "period", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Age
		public static void Serialize(Hl7.Fhir.Model.Age name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 30
			Serialize(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Serialize(name.UnitElement, writer, "unit", cancellationToken); // 50
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 60
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Annotation
		public static void Serialize(Hl7.Fhir.Model.Annotation name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Author as Hl7.Fhir.Model.ResourceReference, writer, "authorReference", cancellationToken); // 30
			Serialize(name.Author as Hl7.Fhir.Model.FhirString, writer, "authorString", cancellationToken); // 30
			Serialize(name.TimeElement, writer, "time", cancellationToken); // 40
			Serialize(name.Text, writer, "text", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Attachment
		public static void Serialize(Hl7.Fhir.Model.Attachment name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ContentTypeElement, writer, "contentType", cancellationToken); // 30
			Serialize(name.LanguageElement, writer, "language", cancellationToken); // 40
			Serialize(name.DataElement, writer, "data", cancellationToken); // 50
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 60
			Serialize(name.SizeElement, writer, "size", cancellationToken); // 70
			Serialize(name.HashElement, writer, "hash", cancellationToken); // 80
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 90
			Serialize(name.CreationElement, writer, "creation", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BackboneElement
		public static void Serialize(Hl7.Fhir.Model.BackboneElement name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Base64Binary
		public static void Serialize(Hl7.Fhir.Model.Base64Binary name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirBoolean
		public static void Serialize(Hl7.Fhir.Model.FhirBoolean name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Canonical
		public static void Serialize(Hl7.Fhir.Model.Canonical name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Code
		public static void Serialize(Hl7.Fhir.Model.Code name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeableConcept
		public static void Serialize(Hl7.Fhir.Model.CodeableConcept name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Coding, writer, "coding", cancellationToken); // 30
			Serialize(name.TextElement, writer, "text", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Coding
		public static void Serialize(Hl7.Fhir.Model.Coding name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 30
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 40
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 50
			Serialize(name.DisplayElement, writer, "display", cancellationToken); // 60
			Serialize(name.UserSelectedElement, writer, "userSelected", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ContactDetail
		public static void Serialize(Hl7.Fhir.Model.ContactDetail name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.NameElement, writer, "name", cancellationToken); // 30
			Serialize(name.Telecom, writer, "telecom", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ContactPoint
		public static void Serialize(Hl7.Fhir.Model.ContactPoint name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 30
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 40
			Serialize(name.UseElement, writer, "use", cancellationToken); // 50
			Serialize(name.RankElement, writer, "rank", cancellationToken); // 60
			Serialize(name.Period, writer, "period", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contributor
		public static void Serialize(Hl7.Fhir.Model.Contributor name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 30
			Serialize(name.NameElement, writer, "name", cancellationToken); // 40
			Serialize(name.Contact, writer, "contact", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Count
		public static void Serialize(Hl7.Fhir.Model.Count name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 30
			Serialize(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Serialize(name.UnitElement, writer, "unit", cancellationToken); // 50
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 60
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DataRequirement
		public static void Serialize(Hl7.Fhir.Model.DataRequirement name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 30
			Serialize(name.ProfileElement, writer, "profile", cancellationToken); // 40
			Serialize(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 50
			Serialize(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 50
			Serialize(name.MustSupportElement, writer, "mustSupport", cancellationToken); // 60
			Serialize(name.CodeFilter, writer, "codeFilter", cancellationToken); // 70
			Serialize(name.DateFilter, writer, "dateFilter", cancellationToken); // 80
			Serialize(name.LimitElement, writer, "limit", cancellationToken); // 90
			Serialize(name.Sort, writer, "sort", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Date
		public static void Serialize(Hl7.Fhir.Model.Date name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirDateTime
		public static void Serialize(Hl7.Fhir.Model.FhirDateTime name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirDecimal
		public static void Serialize(Hl7.Fhir.Model.FhirDecimal name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Distance
		public static void Serialize(Hl7.Fhir.Model.Distance name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 30
			Serialize(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Serialize(name.UnitElement, writer, "unit", cancellationToken); // 50
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 60
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Dosage
		public static void Serialize(Hl7.Fhir.Model.Dosage name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.SequenceElement, writer, "sequence", cancellationToken); // 90
			Serialize(name.TextElement, writer, "text", cancellationToken); // 100
			Serialize(name.AdditionalInstruction, writer, "additionalInstruction", cancellationToken); // 110
			Serialize(name.PatientInstructionElement, writer, "patientInstruction", cancellationToken); // 120
			Serialize(name.Timing, writer, "timing", cancellationToken); // 130
			Serialize(name.AsNeeded as Hl7.Fhir.Model.FhirBoolean, writer, "asNeededBoolean", cancellationToken); // 140
			Serialize(name.AsNeeded as Hl7.Fhir.Model.CodeableConcept, writer, "asNeededCodeableConcept", cancellationToken); // 140
			Serialize(name.Site, writer, "site", cancellationToken); // 150
			Serialize(name.Route, writer, "route", cancellationToken); // 160
			Serialize(name.Method, writer, "method", cancellationToken); // 170
			Serialize(name.DoseAndRate, writer, "doseAndRate", cancellationToken); // 180
			Serialize(name.MaxDosePerPeriod, writer, "maxDosePerPeriod", cancellationToken); // 190
			Serialize(name.MaxDosePerAdministration, writer, "maxDosePerAdministration", cancellationToken); // 200
			Serialize(name.MaxDosePerLifetime, writer, "maxDosePerLifetime", cancellationToken); // 210
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition
		public static void Serialize(Hl7.Fhir.Model.ElementDefinition name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.PathElement, writer, "path", cancellationToken); // 90
			Serialize(name.RepresentationElement, writer, "representation", cancellationToken); // 100
			Serialize(name.SliceNameElement, writer, "sliceName", cancellationToken); // 110
			Serialize(name.SliceIsConstrainingElement, writer, "sliceIsConstraining", cancellationToken); // 120
			Serialize(name.LabelElement, writer, "label", cancellationToken); // 130
			Serialize(name.Code, writer, "code", cancellationToken); // 140
			Serialize(name.Slicing, writer, "slicing", cancellationToken); // 150
			Serialize(name.ShortElement, writer, "short", cancellationToken); // 160
			Serialize(name.Definition, writer, "definition", cancellationToken); // 170
			Serialize(name.Comment, writer, "comment", cancellationToken); // 180
			Serialize(name.Requirements, writer, "requirements", cancellationToken); // 190
			Serialize(name.AliasElement, writer, "alias", cancellationToken); // 200
			Serialize(name.MinElement, writer, "min", cancellationToken); // 210
			Serialize(name.MaxElement, writer, "max", cancellationToken); // 220
			Serialize(name.Base, writer, "base", cancellationToken); // 230
			Serialize(name.ContentReferenceElement, writer, "contentReference", cancellationToken); // 240
			Serialize(name.Type, writer, "type", cancellationToken); // 250
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Base64Binary, writer, "defaultValueBase64Binary", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.FhirBoolean, writer, "defaultValueBoolean", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Canonical, writer, "defaultValueCanonical", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Code, writer, "defaultValueCode", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Date, writer, "defaultValueDate", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.FhirDateTime, writer, "defaultValueDateTime", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.FhirDecimal, writer, "defaultValueDecimal", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Id, writer, "defaultValueId", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Instant, writer, "defaultValueInstant", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Integer, writer, "defaultValueInteger", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Markdown, writer, "defaultValueMarkdown", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Oid, writer, "defaultValueOid", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.PositiveInt, writer, "defaultValuePositiveInt", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.FhirString, writer, "defaultValueString", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Time, writer, "defaultValueTime", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.UnsignedInt, writer, "defaultValueUnsignedInt", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.FhirUri, writer, "defaultValueUri", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.FhirUrl, writer, "defaultValueUrl", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Uuid, writer, "defaultValueUuid", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Address, writer, "defaultValueAddress", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Age, writer, "defaultValueAge", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Annotation, writer, "defaultValueAnnotation", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Attachment, writer, "defaultValueAttachment", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.CodeableConcept, writer, "defaultValueCodeableConcept", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Coding, writer, "defaultValueCoding", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.ContactPoint, writer, "defaultValueContactPoint", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Count, writer, "defaultValueCount", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Distance, writer, "defaultValueDistance", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Duration, writer, "defaultValueDuration", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.HumanName, writer, "defaultValueHumanName", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Identifier, writer, "defaultValueIdentifier", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Money, writer, "defaultValueMoney", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Period, writer, "defaultValuePeriod", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Quantity, writer, "defaultValueQuantity", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Range, writer, "defaultValueRange", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Ratio, writer, "defaultValueRatio", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.ResourceReference, writer, "defaultValueReference", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.SampledData, writer, "defaultValueSampledData", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Signature, writer, "defaultValueSignature", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Timing, writer, "defaultValueTiming", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.ContactDetail, writer, "defaultValueContactDetail", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Contributor, writer, "defaultValueContributor", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.DataRequirement, writer, "defaultValueDataRequirement", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Expression, writer, "defaultValueExpression", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, writer, "defaultValueParameterDefinition", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, writer, "defaultValueRelatedArtifact", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, writer, "defaultValueTriggerDefinition", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.UsageContext, writer, "defaultValueUsageContext", cancellationToken); // 260
			Serialize(name.DefaultValue as Hl7.Fhir.Model.Dosage, writer, "defaultValueDosage", cancellationToken); // 260
			Serialize(name.MeaningWhenMissing, writer, "meaningWhenMissing", cancellationToken); // 270
			Serialize(name.OrderMeaningElement, writer, "orderMeaning", cancellationToken); // 280
			Serialize(name.Fixed as Hl7.Fhir.Model.Base64Binary, writer, "fixedBase64Binary", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.FhirBoolean, writer, "fixedBoolean", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Canonical, writer, "fixedCanonical", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Code, writer, "fixedCode", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Date, writer, "fixedDate", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.FhirDateTime, writer, "fixedDateTime", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.FhirDecimal, writer, "fixedDecimal", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Id, writer, "fixedId", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Instant, writer, "fixedInstant", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Integer, writer, "fixedInteger", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Markdown, writer, "fixedMarkdown", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Oid, writer, "fixedOid", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.PositiveInt, writer, "fixedPositiveInt", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.FhirString, writer, "fixedString", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Time, writer, "fixedTime", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.UnsignedInt, writer, "fixedUnsignedInt", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.FhirUri, writer, "fixedUri", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.FhirUrl, writer, "fixedUrl", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Uuid, writer, "fixedUuid", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Address, writer, "fixedAddress", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Age, writer, "fixedAge", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Annotation, writer, "fixedAnnotation", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Attachment, writer, "fixedAttachment", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.CodeableConcept, writer, "fixedCodeableConcept", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Coding, writer, "fixedCoding", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.ContactPoint, writer, "fixedContactPoint", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Count, writer, "fixedCount", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Distance, writer, "fixedDistance", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Duration, writer, "fixedDuration", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.HumanName, writer, "fixedHumanName", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Identifier, writer, "fixedIdentifier", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Money, writer, "fixedMoney", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Period, writer, "fixedPeriod", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Quantity, writer, "fixedQuantity", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Range, writer, "fixedRange", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Ratio, writer, "fixedRatio", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.ResourceReference, writer, "fixedReference", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.SampledData, writer, "fixedSampledData", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Signature, writer, "fixedSignature", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Timing, writer, "fixedTiming", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.ContactDetail, writer, "fixedContactDetail", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Contributor, writer, "fixedContributor", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.DataRequirement, writer, "fixedDataRequirement", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Expression, writer, "fixedExpression", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.ParameterDefinition, writer, "fixedParameterDefinition", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.RelatedArtifact, writer, "fixedRelatedArtifact", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.TriggerDefinition, writer, "fixedTriggerDefinition", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.UsageContext, writer, "fixedUsageContext", cancellationToken); // 290
			Serialize(name.Fixed as Hl7.Fhir.Model.Dosage, writer, "fixedDosage", cancellationToken); // 290
			Serialize(name.Pattern as Hl7.Fhir.Model.Base64Binary, writer, "patternBase64Binary", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.FhirBoolean, writer, "patternBoolean", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Canonical, writer, "patternCanonical", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Code, writer, "patternCode", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Date, writer, "patternDate", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.FhirDateTime, writer, "patternDateTime", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.FhirDecimal, writer, "patternDecimal", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Id, writer, "patternId", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Instant, writer, "patternInstant", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Integer, writer, "patternInteger", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Markdown, writer, "patternMarkdown", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Oid, writer, "patternOid", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.PositiveInt, writer, "patternPositiveInt", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.FhirString, writer, "patternString", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Time, writer, "patternTime", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.UnsignedInt, writer, "patternUnsignedInt", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.FhirUri, writer, "patternUri", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.FhirUrl, writer, "patternUrl", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Uuid, writer, "patternUuid", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Address, writer, "patternAddress", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Age, writer, "patternAge", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Annotation, writer, "patternAnnotation", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Attachment, writer, "patternAttachment", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.CodeableConcept, writer, "patternCodeableConcept", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Coding, writer, "patternCoding", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.ContactPoint, writer, "patternContactPoint", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Count, writer, "patternCount", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Distance, writer, "patternDistance", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Duration, writer, "patternDuration", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.HumanName, writer, "patternHumanName", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Identifier, writer, "patternIdentifier", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Money, writer, "patternMoney", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Period, writer, "patternPeriod", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Quantity, writer, "patternQuantity", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Range, writer, "patternRange", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Ratio, writer, "patternRatio", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.ResourceReference, writer, "patternReference", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.SampledData, writer, "patternSampledData", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Signature, writer, "patternSignature", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Timing, writer, "patternTiming", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.ContactDetail, writer, "patternContactDetail", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Contributor, writer, "patternContributor", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.DataRequirement, writer, "patternDataRequirement", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Expression, writer, "patternExpression", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.ParameterDefinition, writer, "patternParameterDefinition", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.RelatedArtifact, writer, "patternRelatedArtifact", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.TriggerDefinition, writer, "patternTriggerDefinition", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.UsageContext, writer, "patternUsageContext", cancellationToken); // 300
			Serialize(name.Pattern as Hl7.Fhir.Model.Dosage, writer, "patternDosage", cancellationToken); // 300
			Serialize(name.Example, writer, "example", cancellationToken); // 310
			Serialize(name.MinValue as Hl7.Fhir.Model.Date, writer, "minValueDate", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.FhirDateTime, writer, "minValueDateTime", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.Instant, writer, "minValueInstant", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.Time, writer, "minValueTime", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.FhirDecimal, writer, "minValueDecimal", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.Integer, writer, "minValueInteger", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.PositiveInt, writer, "minValuePositiveInt", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.UnsignedInt, writer, "minValueUnsignedInt", cancellationToken); // 320
			Serialize(name.MinValue as Hl7.Fhir.Model.Quantity, writer, "minValueQuantity", cancellationToken); // 320
			Serialize(name.MaxValue as Hl7.Fhir.Model.Date, writer, "maxValueDate", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.FhirDateTime, writer, "maxValueDateTime", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.Instant, writer, "maxValueInstant", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.Time, writer, "maxValueTime", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.FhirDecimal, writer, "maxValueDecimal", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.Integer, writer, "maxValueInteger", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.PositiveInt, writer, "maxValuePositiveInt", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.UnsignedInt, writer, "maxValueUnsignedInt", cancellationToken); // 330
			Serialize(name.MaxValue as Hl7.Fhir.Model.Quantity, writer, "maxValueQuantity", cancellationToken); // 330
			Serialize(name.MaxLengthElement, writer, "maxLength", cancellationToken); // 340
			Serialize(name.ConditionElement, writer, "condition", cancellationToken); // 350
			Serialize(name.Constraint, writer, "constraint", cancellationToken); // 360
			Serialize(name.MustSupportElement, writer, "mustSupport", cancellationToken); // 370
			Serialize(name.IsModifierElement, writer, "isModifier", cancellationToken); // 380
			Serialize(name.IsModifierReasonElement, writer, "isModifierReason", cancellationToken); // 390
			Serialize(name.IsSummaryElement, writer, "isSummary", cancellationToken); // 400
			Serialize(name.Binding, writer, "binding", cancellationToken); // 410
			Serialize(name.Mapping, writer, "mapping", cancellationToken); // 420
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Expression
		public static void Serialize(Hl7.Fhir.Model.Expression name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 30
			Serialize(name.NameElement, writer, "name", cancellationToken); // 40
			Serialize(name.LanguageElement, writer, "language", cancellationToken); // 50
			Serialize(name.ExpressionElement, writer, "expression", cancellationToken); // 60
			Serialize(name.ReferenceElement, writer, "reference", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Extension
		public static void Serialize(Hl7.Fhir.Model.Extension name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Url, writer, "url", cancellationToken); // 30
			Serialize(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Canonical, writer, "valueCanonical", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Instant, writer, "valueInstant", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Markdown, writer, "valueMarkdown", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Oid, writer, "valueOid", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.PositiveInt, writer, "valuePositiveInt", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.UnsignedInt, writer, "valueUnsignedInt", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.FhirUrl, writer, "valueUrl", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Uuid, writer, "valueUuid", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Address, writer, "valueAddress", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Age, writer, "valueAge", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Annotation, writer, "valueAnnotation", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.ContactPoint, writer, "valueContactPoint", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Count, writer, "valueCount", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Distance, writer, "valueDistance", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.HumanName, writer, "valueHumanName", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Identifier, writer, "valueIdentifier", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Signature, writer, "valueSignature", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Timing, writer, "valueTiming", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.ContactDetail, writer, "valueContactDetail", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Contributor, writer, "valueContributor", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.DataRequirement, writer, "valueDataRequirement", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Expression, writer, "valueExpression", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.ParameterDefinition, writer, "valueParameterDefinition", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.RelatedArtifact, writer, "valueRelatedArtifact", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.TriggerDefinition, writer, "valueTriggerDefinition", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.UsageContext, writer, "valueUsageContext", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Dosage, writer, "valueDosage", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.HumanName
		public static void Serialize(Hl7.Fhir.Model.HumanName name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.UseElement, writer, "use", cancellationToken); // 30
			Serialize(name.TextElement, writer, "text", cancellationToken); // 40
			Serialize(name.FamilyElement, writer, "family", cancellationToken); // 50
			Serialize(name.GivenElement, writer, "given", cancellationToken); // 60
			Serialize(name.PrefixElement, writer, "prefix", cancellationToken); // 70
			Serialize(name.SuffixElement, writer, "suffix", cancellationToken); // 80
			Serialize(name.Period, writer, "period", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Id
		public static void Serialize(Hl7.Fhir.Model.Id name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Identifier
		public static void Serialize(Hl7.Fhir.Model.Identifier name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.UseElement, writer, "use", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 50
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 60
			Serialize(name.Period, writer, "period", cancellationToken); // 70
			Serialize(name.Assigner, writer, "assigner", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Instant
		public static void Serialize(Hl7.Fhir.Model.Instant name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Integer
		public static void Serialize(Hl7.Fhir.Model.Integer name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Markdown
		public static void Serialize(Hl7.Fhir.Model.Markdown name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MarketingStatus
		public static void Serialize(Hl7.Fhir.Model.MarketingStatus name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Country, writer, "country", cancellationToken); // 90
			Serialize(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 100
			Serialize(name.Status, writer, "status", cancellationToken); // 110
			Serialize(name.DateRange, writer, "dateRange", cancellationToken); // 120
			Serialize(name.RestoreDateElement, writer, "restoreDate", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Meta
		public static void Serialize(Hl7.Fhir.Model.Meta name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.VersionIdElement, writer, "versionId", cancellationToken); // 30
			Serialize(name.LastUpdatedElement, writer, "lastUpdated", cancellationToken); // 40
			Serialize(name.SourceElement, writer, "source", cancellationToken); // 50
			Serialize(name.ProfileElement, writer, "profile", cancellationToken); // 60
			Serialize(name.Security, writer, "security", cancellationToken); // 70
			Serialize(name.Tag, writer, "tag", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Money
		public static void Serialize(Hl7.Fhir.Model.Money name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 30
			Serialize(name.CurrencyElement, writer, "currency", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Narrative
		public static void Serialize(Hl7.Fhir.Model.Narrative name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.StatusElement, writer, "status", cancellationToken); // 30
			// Xml Serialization: XHtml
			XElement.Parse(name.Div).WriteTo(writer); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Oid
		public static void Serialize(Hl7.Fhir.Model.Oid name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ParameterDefinition
		public static void Serialize(Hl7.Fhir.Model.ParameterDefinition name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.NameElement, writer, "name", cancellationToken); // 30
			Serialize(name.UseElement, writer, "use", cancellationToken); // 40
			Serialize(name.MinElement, writer, "min", cancellationToken); // 50
			Serialize(name.MaxElement, writer, "max", cancellationToken); // 60
			Serialize(name.DocumentationElement, writer, "documentation", cancellationToken); // 70
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 80
			Serialize(name.ProfileElement, writer, "profile", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Period
		public static void Serialize(Hl7.Fhir.Model.Period name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.StartElement, writer, "start", cancellationToken); // 30
			Serialize(name.EndElement, writer, "end", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Population
		public static void Serialize(Hl7.Fhir.Model.Population name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Age as Hl7.Fhir.Model.Range, writer, "ageRange", cancellationToken); // 90
			Serialize(name.Age as Hl7.Fhir.Model.CodeableConcept, writer, "ageCodeableConcept", cancellationToken); // 90
			Serialize(name.Gender, writer, "gender", cancellationToken); // 100
			Serialize(name.Race, writer, "race", cancellationToken); // 110
			Serialize(name.PhysiologicalCondition, writer, "physiologicalCondition", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PositiveInt
		public static void Serialize(Hl7.Fhir.Model.PositiveInt name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ProdCharacteristic
		public static void Serialize(Hl7.Fhir.Model.ProdCharacteristic name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Height, writer, "height", cancellationToken); // 90
			Serialize(name.Width, writer, "width", cancellationToken); // 100
			Serialize(name.Depth, writer, "depth", cancellationToken); // 110
			Serialize(name.Weight, writer, "weight", cancellationToken); // 120
			Serialize(name.NominalVolume, writer, "nominalVolume", cancellationToken); // 130
			Serialize(name.ExternalDiameter, writer, "externalDiameter", cancellationToken); // 140
			Serialize(name.ShapeElement, writer, "shape", cancellationToken); // 150
			Serialize(name.ColorElement, writer, "color", cancellationToken); // 160
			Serialize(name.ImprintElement, writer, "imprint", cancellationToken); // 170
			Serialize(name.Image, writer, "image", cancellationToken); // 180
			Serialize(name.Scoring, writer, "scoring", cancellationToken); // 190
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ProductShelfLife
		public static void Serialize(Hl7.Fhir.Model.ProductShelfLife name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			Serialize(name.Type, writer, "type", cancellationToken); // 100
			Serialize(name.Period, writer, "period", cancellationToken); // 110
			Serialize(name.SpecialPrecautionsForStorage, writer, "specialPrecautionsForStorage", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Quantity
		public static void Serialize(Hl7.Fhir.Model.Quantity name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 30
			Serialize(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Serialize(name.UnitElement, writer, "unit", cancellationToken); // 50
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 60
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Range
		public static void Serialize(Hl7.Fhir.Model.Range name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Low, writer, "low", cancellationToken); // 30
			Serialize(name.High, writer, "high", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Ratio
		public static void Serialize(Hl7.Fhir.Model.Ratio name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Numerator, writer, "numerator", cancellationToken); // 30
			Serialize(name.Denominator, writer, "denominator", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ResourceReference
		public static void Serialize(Hl7.Fhir.Model.ResourceReference name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ReferenceElement, writer, "reference", cancellationToken); // 30
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 40
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 50
			Serialize(name.DisplayElement, writer, "display", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RelatedArtifact
		public static void Serialize(Hl7.Fhir.Model.RelatedArtifact name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 30
			Serialize(name.LabelElement, writer, "label", cancellationToken); // 40
			Serialize(name.DisplayElement, writer, "display", cancellationToken); // 50
			Serialize(name.Citation, writer, "citation", cancellationToken); // 60
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 70
			Serialize(name.Document, writer, "document", cancellationToken); // 80
			Serialize(name.ResourceElement, writer, "resource", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SampledData
		public static void Serialize(Hl7.Fhir.Model.SampledData name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Origin, writer, "origin", cancellationToken); // 30
			Serialize(name.PeriodElement, writer, "period", cancellationToken); // 40
			Serialize(name.FactorElement, writer, "factor", cancellationToken); // 50
			Serialize(name.LowerLimitElement, writer, "lowerLimit", cancellationToken); // 60
			Serialize(name.UpperLimitElement, writer, "upperLimit", cancellationToken); // 70
			Serialize(name.DimensionsElement, writer, "dimensions", cancellationToken); // 80
			Serialize(name.DataElement, writer, "data", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Signature
		public static void Serialize(Hl7.Fhir.Model.Signature name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Type, writer, "type", cancellationToken); // 30
			Serialize(name.WhenElement, writer, "when", cancellationToken); // 40
			Serialize(name.Who, writer, "who", cancellationToken); // 50
			Serialize(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 60
			Serialize(name.TargetFormatElement, writer, "targetFormat", cancellationToken); // 70
			Serialize(name.SigFormatElement, writer, "sigFormat", cancellationToken); // 80
			Serialize(name.DataElement, writer, "data", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirString
		public static void Serialize(Hl7.Fhir.Model.FhirString name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceAmount
		public static void Serialize(Hl7.Fhir.Model.SubstanceAmount name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Amount as Hl7.Fhir.Model.Quantity, writer, "amountQuantity", cancellationToken); // 90
			Serialize(name.Amount as Hl7.Fhir.Model.Range, writer, "amountRange", cancellationToken); // 90
			Serialize(name.Amount as Hl7.Fhir.Model.FhirString, writer, "amountString", cancellationToken); // 90
			Serialize(name.AmountType, writer, "amountType", cancellationToken); // 100
			Serialize(name.AmountTextElement, writer, "amountText", cancellationToken); // 110
			Serialize(name.ReferenceRange, writer, "referenceRange", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Time
		public static void Serialize(Hl7.Fhir.Model.Time name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Timing
		public static void Serialize(Hl7.Fhir.Model.Timing name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.EventElement, writer, "event", cancellationToken); // 90
			Serialize(name.Repeat, writer, "repeat", cancellationToken); // 100
			Serialize(name.Code, writer, "code", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TriggerDefinition
		public static void Serialize(Hl7.Fhir.Model.TriggerDefinition name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 30
			Serialize(name.NameElement, writer, "name", cancellationToken); // 40
			Serialize(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 50
			Serialize(name.Timing as Hl7.Fhir.Model.ResourceReference, writer, "timingReference", cancellationToken); // 50
			Serialize(name.Timing as Hl7.Fhir.Model.Date, writer, "timingDate", cancellationToken); // 50
			Serialize(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 50
			Serialize(name.Data, writer, "data", cancellationToken); // 60
			Serialize(name.Condition, writer, "condition", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.UnsignedInt
		public static void Serialize(Hl7.Fhir.Model.UnsignedInt name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirUri
		public static void Serialize(Hl7.Fhir.Model.FhirUri name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirUrl
		public static void Serialize(Hl7.Fhir.Model.FhirUrl name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.UsageContext
		public static void Serialize(Hl7.Fhir.Model.UsageContext name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Code, writer, "code", cancellationToken); // 30
			Serialize(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 40
			Serialize(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Uuid
		public static void Serialize(Hl7.Fhir.Model.Uuid name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.XHtml
		public static void Serialize(Hl7.Fhir.Model.XHtml name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.Value, writer, "value", cancellationToken); // 30
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DomainResource
		public static void SerializeDomainResource(Hl7.Fhir.Model.DomainResource name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			SerializeResource(name, writer, cancellationToken);
			Serialize(name.Text, writer, "text", cancellationToken); // 50
			Serialize(name.Contained, writer, "contained", cancellationToken); // 60
			Serialize(name.Extension, writer, "extension", cancellationToken); // 70
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 80
		}

		// Hl7.Fhir.Model.Resource
		public static void SerializeResource(Hl7.Fhir.Model.Resource name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			Serialize(name.IdElement, writer, "id", cancellationToken); // 10
			Serialize(name.Meta, writer, "meta", cancellationToken); // 20
			Serialize(name.ImplicitRulesElement, writer, "implicitRules", cancellationToken); // 30
			Serialize(name.LanguageElement, writer, "language", cancellationToken); // 40
		}

		// Hl7.Fhir.Model.ImplementationGuide.PageComponent
		public static void Serialize(Hl7.Fhir.Model.ImplementationGuide.PageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Name as Hl7.Fhir.Model.FhirUrl, writer, "nameUrl", cancellationToken); // 40
			Serialize(name.Name as Hl7.Fhir.Model.ResourceReference, writer, "nameReference", cancellationToken); // 40
			Serialize(name.TitleElement, writer, "title", cancellationToken); // 50
			Serialize(name.GenerationElement, writer, "generation", cancellationToken); // 60
			Serialize(name.Page, writer, "page", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationRequest.InitialFillComponent
		public static void Serialize(Hl7.Fhir.Model.MedicationRequest.InitialFillComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 40
			Serialize(name.Duration, writer, "duration", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent
		public static void Serialize(Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.MaternalOrganismIdElement, writer, "maternalOrganismId", cancellationToken); // 40
			Serialize(name.MaternalOrganismNameElement, writer, "maternalOrganismName", cancellationToken); // 50
			Serialize(name.PaternalOrganismIdElement, writer, "paternalOrganismId", cancellationToken); // 60
			Serialize(name.PaternalOrganismNameElement, writer, "paternalOrganismName", cancellationToken); // 70
			Serialize(name.HybridType, writer, "hybridType", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent
		public static void Serialize(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Kingdom, writer, "kingdom", cancellationToken); // 40
			Serialize(name.Phylum, writer, "phylum", cancellationToken); // 50
			Serialize(name.Class, writer, "class", cancellationToken); // 60
			Serialize(name.Order, writer, "order", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent
		public static void Serialize(Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Method, writer, "method", cancellationToken); // 40
			Serialize(name.Type, writer, "type", cancellationToken); // 50
			Serialize(name.Amount, writer, "amount", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.SlicingComponent
		public static void Serialize(Hl7.Fhir.Model.ElementDefinition.SlicingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Discriminator, writer, "discriminator", cancellationToken); // 40
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Serialize(name.OrderedElement, writer, "ordered", cancellationToken); // 60
			Serialize(name.RulesElement, writer, "rules", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.BaseComponent
		public static void Serialize(Hl7.Fhir.Model.ElementDefinition.BaseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.PathElement, writer, "path", cancellationToken); // 40
			Serialize(name.MinElement, writer, "min", cancellationToken); // 50
			Serialize(name.MaxElement, writer, "max", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent
		public static void Serialize(Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.StrengthElement, writer, "strength", cancellationToken); // 40
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Serialize(name.ValueSetElement, writer, "valueSet", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent
		public static void Serialize(Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.LowLimit, writer, "lowLimit", cancellationToken); // 40
			Serialize(name.HighLimit, writer, "highLimit", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Timing.RepeatComponent
		public static void Serialize(Hl7.Fhir.Model.Timing.RepeatComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.Bounds as Hl7.Fhir.Model.Duration, writer, "boundsDuration", cancellationToken); // 40
			Serialize(name.Bounds as Hl7.Fhir.Model.Range, writer, "boundsRange", cancellationToken); // 40
			Serialize(name.Bounds as Hl7.Fhir.Model.Period, writer, "boundsPeriod", cancellationToken); // 40
			Serialize(name.CountElement, writer, "count", cancellationToken); // 50
			Serialize(name.CountMaxElement, writer, "countMax", cancellationToken); // 60
			Serialize(name.DurationElement, writer, "duration", cancellationToken); // 70
			Serialize(name.DurationMaxElement, writer, "durationMax", cancellationToken); // 80
			Serialize(name.DurationUnitElement, writer, "durationUnit", cancellationToken); // 90
			Serialize(name.FrequencyElement, writer, "frequency", cancellationToken); // 100
			Serialize(name.FrequencyMaxElement, writer, "frequencyMax", cancellationToken); // 110
			Serialize(name.PeriodElement, writer, "period", cancellationToken); // 120
			Serialize(name.PeriodMaxElement, writer, "periodMax", cancellationToken); // 130
			Serialize(name.PeriodUnitElement, writer, "periodUnit", cancellationToken); // 140
			Serialize(name.DayOfWeekElement, writer, "dayOfWeek", cancellationToken); // 150
			Serialize(name.TimeOfDayElement, writer, "timeOfDay", cancellationToken); // 160
			Serialize(name.WhenElement, writer, "when", cancellationToken); // 170
			Serialize(name.OffsetElement, writer, "offset", cancellationToken); // 180
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SimpleQuantity
		public static void Serialize(Hl7.Fhir.Model.SimpleQuantity name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 30
			Serialize(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Serialize(name.UnitElement, writer, "unit", cancellationToken); // 50
			Serialize(name.SystemElement, writer, "system", cancellationToken); // 60
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AuditEvent.SourceComponent
		public static void Serialize(Hl7.Fhir.Model.AuditEvent.SourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.SiteElement, writer, "site", cancellationToken); // 40
			Serialize(name.Observer, writer, "observer", cancellationToken); // 50
			Serialize(name.Type, writer, "type", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent
		public static void Serialize(Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Collector, writer, "collector", cancellationToken); // 40
			Serialize(name.Source, writer, "source", cancellationToken); // 50
			Serialize(name.Collected as Hl7.Fhir.Model.FhirDateTime, writer, "collectedDateTime", cancellationToken); // 60
			Serialize(name.Collected as Hl7.Fhir.Model.Period, writer, "collectedPeriod", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent
		public static void Serialize(Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Serialize(name.Time as Hl7.Fhir.Model.FhirDateTime, writer, "timeDateTime", cancellationToken); // 50
			Serialize(name.Time as Hl7.Fhir.Model.Period, writer, "timePeriod", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent
		public static void Serialize(Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.NameElement, writer, "name", cancellationToken); // 40
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 50
			Serialize(name.ReleaseDateElement, writer, "releaseDate", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent
		public static void Serialize(Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 50
			Serialize(name.Custodian, writer, "custodian", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.PayeeComponent
		public static void Serialize(Hl7.Fhir.Model.Claim.PayeeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.Party, writer, "party", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.AccidentComponent
		public static void Serialize(Hl7.Fhir.Model.Claim.AccidentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DateElement, writer, "date", cancellationToken); // 40
			Serialize(name.Type, writer, "type", cancellationToken); // 50
			Serialize(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 60
			Serialize(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.PaymentComponent
		public static void Serialize(Hl7.Fhir.Model.ClaimResponse.PaymentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.Adjustment, writer, "adjustment", cancellationToken); // 50
			Serialize(name.AdjustmentReason, writer, "adjustmentReason", cancellationToken); // 60
			Serialize(name.DateElement, writer, "date", cancellationToken); // 70
			Serialize(name.Amount, writer, "amount", cancellationToken); // 80
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Consent.provisionComponent
		public static void Serialize(Hl7.Fhir.Model.Consent.provisionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 40
			Serialize(name.Period, writer, "period", cancellationToken); // 50
			Serialize(name.Actor, writer, "actor", cancellationToken); // 60
			Serialize(name.Action, writer, "action", cancellationToken); // 70
			Serialize(name.SecurityLabel, writer, "securityLabel", cancellationToken); // 80
			Serialize(name.Purpose, writer, "purpose", cancellationToken); // 90
			Serialize(name.Class, writer, "class", cancellationToken); // 100
			Serialize(name.Code, writer, "code", cancellationToken); // 110
			Serialize(name.DataPeriod, writer, "dataPeriod", cancellationToken); // 120
			Serialize(name.Data, writer, "data", cancellationToken); // 130
			Serialize(name.Provision, writer, "provision", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ContentDefinitionComponent
		public static void Serialize(Hl7.Fhir.Model.Contract.ContentDefinitionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.SubType, writer, "subType", cancellationToken); // 50
			Serialize(name.Publisher, writer, "publisher", cancellationToken); // 60
			Serialize(name.PublicationDateElement, writer, "publicationDate", cancellationToken); // 70
			Serialize(name.PublicationStatusElement, writer, "publicationStatus", cancellationToken); // 80
			Serialize(name.Copyright, writer, "copyright", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DocumentReference.ContextComponent
		public static void Serialize(Hl7.Fhir.Model.DocumentReference.ContextComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Encounter, writer, "encounter", cancellationToken); // 40
			Serialize(name.Event, writer, "event", cancellationToken); // 50
			Serialize(name.Period, writer, "period", cancellationToken); // 60
			Serialize(name.FacilityType, writer, "facilityType", cancellationToken); // 70
			Serialize(name.PracticeSetting, writer, "practiceSetting", cancellationToken); // 80
			Serialize(name.SourcePatientInfo, writer, "sourcePatientInfo", cancellationToken); // 90
			Serialize(name.Related, writer, "related", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.SampleSizeComponent
		public static void Serialize(Hl7.Fhir.Model.EffectEvidenceSynthesis.SampleSizeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Serialize(name.NumberOfStudiesElement, writer, "numberOfStudies", cancellationToken); // 50
			Serialize(name.NumberOfParticipantsElement, writer, "numberOfParticipants", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.HospitalizationComponent
		public static void Serialize(Hl7.Fhir.Model.Encounter.HospitalizationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.PreAdmissionIdentifier, writer, "preAdmissionIdentifier", cancellationToken); // 40
			Serialize(name.Origin, writer, "origin", cancellationToken); // 50
			Serialize(name.AdmitSource, writer, "admitSource", cancellationToken); // 60
			Serialize(name.ReAdmission, writer, "reAdmission", cancellationToken); // 70
			Serialize(name.DietPreference, writer, "dietPreference", cancellationToken); // 80
			Serialize(name.SpecialCourtesy, writer, "specialCourtesy", cancellationToken); // 90
			Serialize(name.SpecialArrangement, writer, "specialArrangement", cancellationToken); // 100
			Serialize(name.Destination, writer, "destination", cancellationToken); // 110
			Serialize(name.DischargeDisposition, writer, "dischargeDisposition", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent
		public static void Serialize(Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.Party, writer, "party", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent
		public static void Serialize(Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DateElement, writer, "date", cancellationToken); // 40
			Serialize(name.Type, writer, "type", cancellationToken); // 50
			Serialize(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 60
			Serialize(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent
		public static void Serialize(Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.Adjustment, writer, "adjustment", cancellationToken); // 50
			Serialize(name.AdjustmentReason, writer, "adjustmentReason", cancellationToken); // 60
			Serialize(name.DateElement, writer, "date", cancellationToken); // 70
			Serialize(name.Amount, writer, "amount", cancellationToken); // 80
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.DefinitionComponent
		public static void Serialize(Hl7.Fhir.Model.ImplementationGuide.DefinitionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Grouping, writer, "grouping", cancellationToken); // 40
			Serialize(name.Resource, writer, "resource", cancellationToken); // 50
			Serialize(name.Page, writer, "page", cancellationToken); // 60
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 70
			Serialize(name.Template, writer, "template", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.ManifestComponent
		public static void Serialize(Hl7.Fhir.Model.ImplementationGuide.ManifestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.RenderingElement, writer, "rendering", cancellationToken); // 40
			Serialize(name.Resource, writer, "resource", cancellationToken); // 50
			Serialize(name.Page, writer, "page", cancellationToken); // 60
			Serialize(name.ImageElement, writer, "image", cancellationToken); // 70
			Serialize(name.OtherElement, writer, "other", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Location.PositionComponent
		public static void Serialize(Hl7.Fhir.Model.Location.PositionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.LongitudeElement, writer, "longitude", cancellationToken); // 40
			Serialize(name.LatitudeElement, writer, "latitude", cancellationToken); // 50
			Serialize(name.AltitudeElement, writer, "altitude", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Medication.BatchComponent
		public static void Serialize(Hl7.Fhir.Model.Medication.BatchComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.LotNumberElement, writer, "lotNumber", cancellationToken); // 40
			Serialize(name.ExpirationDateElement, writer, "expirationDate", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationAdministration.DosageComponent
		public static void Serialize(Hl7.Fhir.Model.MedicationAdministration.DosageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.TextElement, writer, "text", cancellationToken); // 40
			Serialize(name.Site, writer, "site", cancellationToken); // 50
			Serialize(name.Route, writer, "route", cancellationToken); // 60
			Serialize(name.Method, writer, "method", cancellationToken); // 70
			Serialize(name.Dose, writer, "dose", cancellationToken); // 80
			Serialize(name.Rate as Hl7.Fhir.Model.Ratio, writer, "rateRatio", cancellationToken); // 90
			Serialize(name.Rate as Hl7.Fhir.Model.SimpleQuantity, writer, "rateQuantity", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent
		public static void Serialize(Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.WasSubstitutedElement, writer, "wasSubstituted", cancellationToken); // 40
			Serialize(name.Type, writer, "type", cancellationToken); // 50
			Serialize(name.Reason, writer, "reason", cancellationToken); // 60
			Serialize(name.ResponsibleParty, writer, "responsibleParty", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent
		public static void Serialize(Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent
		public static void Serialize(Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.InitialFill, writer, "initialFill", cancellationToken); // 40
			Serialize(name.DispenseInterval, writer, "dispenseInterval", cancellationToken); // 50
			Serialize(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 60
			Serialize(name.NumberOfRepeatsAllowedElement, writer, "numberOfRepeatsAllowed", cancellationToken); // 70
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 80
			Serialize(name.ExpectedSupplyDuration, writer, "expectedSupplyDuration", cancellationToken); // 90
			Serialize(name.Performer, writer, "performer", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent
		public static void Serialize(Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Allowed as Hl7.Fhir.Model.FhirBoolean, writer, "allowedBoolean", cancellationToken); // 40
			Serialize(name.Allowed as Hl7.Fhir.Model.CodeableConcept, writer, "allowedCodeableConcept", cancellationToken); // 40
			Serialize(name.Reason, writer, "reason", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent
		public static void Serialize(Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Identifier, writer, "identifier", cancellationToken); // 40
			Serialize(name.Type, writer, "type", cancellationToken); // 50
			Serialize(name.Date as Hl7.Fhir.Model.Period, writer, "datePeriod", cancellationToken); // 60
			Serialize(name.Date as Hl7.Fhir.Model.FhirDateTime, writer, "dateDateTime", cancellationToken); // 60
			Serialize(name.Application, writer, "application", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent
		public static void Serialize(Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Code, writer, "code", cancellationToken); // 40
			Serialize(name.Strength, writer, "strength", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageHeader.MessageSourceComponent
		public static void Serialize(Hl7.Fhir.Model.MessageHeader.MessageSourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.NameElement, writer, "name", cancellationToken); // 40
			Serialize(name.SoftwareElement, writer, "software", cancellationToken); // 50
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 60
			Serialize(name.Contact, writer, "contact", cancellationToken); // 70
			Serialize(name.EndpointElement, writer, "endpoint", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageHeader.ResponseComponent
		public static void Serialize(Hl7.Fhir.Model.MessageHeader.ResponseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.IdentifierElement, writer, "identifier", cancellationToken); // 40
			Serialize(name.CodeElement, writer, "code", cancellationToken); // 50
			Serialize(name.Details, writer, "details", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent
		public static void Serialize(Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Chromosome, writer, "chromosome", cancellationToken); // 40
			Serialize(name.GenomeBuildElement, writer, "genomeBuild", cancellationToken); // 50
			Serialize(name.OrientationElement, writer, "orientation", cancellationToken); // 60
			Serialize(name.ReferenceSeqId, writer, "referenceSeqId", cancellationToken); // 70
			Serialize(name.ReferenceSeqPointer, writer, "referenceSeqPointer", cancellationToken); // 80
			Serialize(name.ReferenceSeqStringElement, writer, "referenceSeqString", cancellationToken); // 90
			Serialize(name.StrandElement, writer, "strand", cancellationToken); // 100
			Serialize(name.WindowStartElement, writer, "windowStart", cancellationToken); // 110
			Serialize(name.WindowEndElement, writer, "windowEnd", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.OralDietComponent
		public static void Serialize(Hl7.Fhir.Model.NutritionOrder.OralDietComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Type, writer, "type", cancellationToken); // 40
			Serialize(name.Schedule, writer, "schedule", cancellationToken); // 50
			Serialize(name.Nutrient, writer, "nutrient", cancellationToken); // 60
			Serialize(name.Texture, writer, "texture", cancellationToken); // 70
			Serialize(name.FluidConsistencyType, writer, "fluidConsistencyType", cancellationToken); // 80
			Serialize(name.InstructionElement, writer, "instruction", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent
		public static void Serialize(Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.BaseFormulaType, writer, "baseFormulaType", cancellationToken); // 40
			Serialize(name.BaseFormulaProductNameElement, writer, "baseFormulaProductName", cancellationToken); // 50
			Serialize(name.AdditiveType, writer, "additiveType", cancellationToken); // 60
			Serialize(name.AdditiveProductNameElement, writer, "additiveProductName", cancellationToken); // 70
			Serialize(name.CaloricDensity, writer, "caloricDensity", cancellationToken); // 80
			Serialize(name.RouteofAdministration, writer, "routeofAdministration", cancellationToken); // 90
			Serialize(name.Administration, writer, "administration", cancellationToken); // 100
			Serialize(name.MaxVolumeToDeliver, writer, "maxVolumeToDeliver", cancellationToken); // 110
			Serialize(name.AdministrationInstructionElement, writer, "administrationInstruction", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent
		public static void Serialize(Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.CustomaryUnit, writer, "customaryUnit", cancellationToken); // 40
			Serialize(name.Unit, writer, "unit", cancellationToken); // 50
			Serialize(name.ConversionFactorElement, writer, "conversionFactor", cancellationToken); // 60
			Serialize(name.DecimalPrecisionElement, writer, "decimalPrecision", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent
		public static void Serialize(Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Serialize(name.NumberOfStudiesElement, writer, "numberOfStudies", cancellationToken); // 50
			Serialize(name.NumberOfParticipantsElement, writer, "numberOfParticipants", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent
		public static void Serialize(Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Serialize(name.Type, writer, "type", cancellationToken); // 50
			Serialize(name.ValueElement, writer, "value", cancellationToken); // 60
			Serialize(name.UnitOfMeasure, writer, "unitOfMeasure", cancellationToken); // 70
			Serialize(name.DenominatorCountElement, writer, "denominatorCount", cancellationToken); // 80
			Serialize(name.NumeratorCountElement, writer, "numeratorCount", cancellationToken); // 90
			Serialize(name.PrecisionEstimate, writer, "precisionEstimate", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Specimen.CollectionComponent
		public static void Serialize(Hl7.Fhir.Model.Specimen.CollectionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Collector, writer, "collector", cancellationToken); // 40
			Serialize(name.Collected as Hl7.Fhir.Model.FhirDateTime, writer, "collectedDateTime", cancellationToken); // 50
			Serialize(name.Collected as Hl7.Fhir.Model.Period, writer, "collectedPeriod", cancellationToken); // 50
			Serialize(name.Duration, writer, "duration", cancellationToken); // 60
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 70
			Serialize(name.Method, writer, "method", cancellationToken); // 80
			Serialize(name.BodySite, writer, "bodySite", cancellationToken); // 90
			Serialize(name.FastingStatus as Hl7.Fhir.Model.CodeableConcept, writer, "fastingStatusCodeableConcept", cancellationToken); // 100
			Serialize(name.FastingStatus as Hl7.Fhir.Model.Duration, writer, "fastingStatusDuration", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureDefinition.SnapshotComponent
		public static void Serialize(Hl7.Fhir.Model.StructureDefinition.SnapshotComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Element, writer, "element", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureDefinition.DifferentialComponent
		public static void Serialize(Hl7.Fhir.Model.StructureDefinition.DifferentialComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Element, writer, "element", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Subscription.ChannelComponent
		public static void Serialize(Hl7.Fhir.Model.Subscription.ChannelComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.TypeElement, writer, "type", cancellationToken); // 40
			Serialize(name.EndpointElement, writer, "endpoint", cancellationToken); // 50
			Serialize(name.PayloadElement, writer, "payload", cancellationToken); // 60
			Serialize(name.HeaderElement, writer, "header", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent
		public static void Serialize(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Family, writer, "family", cancellationToken); // 40
			Serialize(name.Genus, writer, "genus", cancellationToken); // 50
			Serialize(name.Species, writer, "species", cancellationToken); // 60
			Serialize(name.IntraspecificType, writer, "intraspecificType", cancellationToken); // 70
			Serialize(name.IntraspecificDescriptionElement, writer, "intraspecificDescription", cancellationToken); // 80
			Serialize(name.Author, writer, "author", cancellationToken); // 90
			Serialize(name.Hybrid, writer, "hybrid", cancellationToken); // 100
			Serialize(name.OrganismGeneral, writer, "organismGeneral", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.StructureComponent
		public static void Serialize(Hl7.Fhir.Model.SubstanceSpecification.StructureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Stereochemistry, writer, "stereochemistry", cancellationToken); // 40
			Serialize(name.OpticalActivity, writer, "opticalActivity", cancellationToken); // 50
			Serialize(name.MolecularFormulaElement, writer, "molecularFormula", cancellationToken); // 60
			Serialize(name.MolecularFormulaByMoietyElement, writer, "molecularFormulaByMoiety", cancellationToken); // 70
			Serialize(name.Isotope, writer, "isotope", cancellationToken); // 80
			Serialize(name.MolecularWeight, writer, "molecularWeight", cancellationToken); // 90
			Serialize(name.Source, writer, "source", cancellationToken); // 100
			Serialize(name.Representation, writer, "representation", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent
		public static void Serialize(Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Quantity, writer, "quantity", cancellationToken); // 40
			Serialize(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 50
			Serialize(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Task.RestrictionComponent
		public static void Serialize(Hl7.Fhir.Model.Task.RestrictionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.RepetitionsElement, writer, "repetitions", cancellationToken); // 40
			Serialize(name.Period, writer, "period", cancellationToken); // 50
			Serialize(name.Recipient, writer, "recipient", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.SoftwareComponent
		public static void Serialize(Hl7.Fhir.Model.TerminologyCapabilities.SoftwareComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.NameElement, writer, "name", cancellationToken); // 40
			Serialize(name.VersionElement, writer, "version", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ImplementationComponent
		public static void Serialize(Hl7.Fhir.Model.TerminologyCapabilities.ImplementationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Serialize(name.UrlElement, writer, "url", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent
		public static void Serialize(Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.HierarchicalElement, writer, "hierarchical", cancellationToken); // 40
			Serialize(name.PagingElement, writer, "paging", cancellationToken); // 50
			Serialize(name.IncompleteElement, writer, "incomplete", cancellationToken); // 60
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 70
			Serialize(name.TextFilter, writer, "textFilter", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ValidateCodeComponent
		public static void Serialize(Hl7.Fhir.Model.TerminologyCapabilities.ValidateCodeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.TranslationsElement, writer, "translations", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.TranslationComponent
		public static void Serialize(Hl7.Fhir.Model.TerminologyCapabilities.TranslationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.NeedsMapElement, writer, "needsMap", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ClosureComponent
		public static void Serialize(Hl7.Fhir.Model.TerminologyCapabilities.ClosureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.TranslationElement, writer, "translation", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.SetupComponent
		public static void Serialize(Hl7.Fhir.Model.TestReport.SetupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.TeardownComponent
		public static void Serialize(Hl7.Fhir.Model.TestReport.TeardownComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.MetadataComponent
		public static void Serialize(Hl7.Fhir.Model.TestScript.MetadataComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Link, writer, "link", cancellationToken); // 40
			Serialize(name.Capability, writer, "capability", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.SetupComponent
		public static void Serialize(Hl7.Fhir.Model.TestScript.SetupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.TeardownComponent
		public static void Serialize(Hl7.Fhir.Model.TestScript.TeardownComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ComposeComponent
		public static void Serialize(Hl7.Fhir.Model.ValueSet.ComposeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.LockedDateElement, writer, "lockedDate", cancellationToken); // 40
			Serialize(name.InactiveElement, writer, "inactive", cancellationToken); // 50
			Serialize(name.Include, writer, "include", cancellationToken); // 60
			Serialize(name.Exclude, writer, "exclude", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ExpansionComponent
		public static void Serialize(Hl7.Fhir.Model.ValueSet.ExpansionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.IdentifierElement, writer, "identifier", cancellationToken); // 40
			Serialize(name.TimestampElement, writer, "timestamp", cancellationToken); // 50
			Serialize(name.TotalElement, writer, "total", cancellationToken); // 60
			Serialize(name.OffsetElement, writer, "offset", cancellationToken); // 70
			Serialize(name.Parameter, writer, "parameter", cancellationToken); // 80
			Serialize(name.Contains, writer, "contains", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.VerificationResult.AttestationComponent
		public static void Serialize(Hl7.Fhir.Model.VerificationResult.AttestationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Serialize(name.ElementId, writer, "id", cancellationToken); // 10
			Serialize(name.Extension, writer, "extension", cancellationToken); // 20
			Serialize(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Serialize(name.Who, writer, "who", cancellationToken); // 40
			Serialize(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 50
			Serialize(name.CommunicationMethod, writer, "communicationMethod", cancellationToken); // 60
			Serialize(name.DateElement, writer, "date", cancellationToken); // 70
			Serialize(name.SourceIdentityCertificateElement, writer, "sourceIdentityCertificate", cancellationToken); // 80
			Serialize(name.ProxyIdentityCertificateElement, writer, "proxyIdentityCertificate", cancellationToken); // 90
			Serialize(name.ProxySignature, writer, "proxySignature", cancellationToken); // 100
			Serialize(name.SourceSignature, writer, "sourceSignature", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// ---------------------------
		public static void SerializeBase(Base value, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			switch(value)
			{
				case Hl7.Fhir.Model.Account account:
							Serialize(account, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ActivityDefinition activitydefinition:
							Serialize(activitydefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AdverseEvent adverseevent:
							Serialize(adverseevent, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AllergyIntolerance allergyintolerance:
							Serialize(allergyintolerance, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Appointment appointment:
							Serialize(appointment, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AppointmentResponse appointmentresponse:
							Serialize(appointmentresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent auditevent:
							Serialize(auditevent, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Basic basic:
							Serialize(basic, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Binary binary:
							Serialize(binary, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct biologicallyderivedproduct:
							Serialize(biologicallyderivedproduct, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.BodyStructure bodystructure:
							Serialize(bodystructure, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle bundle:
							Serialize(bundle, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement capabilitystatement:
							Serialize(capabilitystatement, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CarePlan careplan:
							Serialize(careplan, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CareTeam careteam:
							Serialize(careteam, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CatalogEntry catalogentry:
							Serialize(catalogentry, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItem chargeitem:
							Serialize(chargeitem, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItemDefinition chargeitemdefinition:
							Serialize(chargeitemdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim claim:
							Serialize(claim, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse claimresponse:
							Serialize(claimresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClinicalImpression clinicalimpression:
							Serialize(clinicalimpression, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem codesystem:
							Serialize(codesystem, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Communication communication:
							Serialize(communication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CommunicationRequest communicationrequest:
							Serialize(communicationrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CompartmentDefinition compartmentdefinition:
							Serialize(compartmentdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Composition composition:
							Serialize(composition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap conceptmap:
							Serialize(conceptmap, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Condition condition:
							Serialize(condition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent consent:
							Serialize(consent, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract contract:
							Serialize(contract, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coverage coverage:
							Serialize(coverage, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityRequest coverageeligibilityrequest:
							Serialize(coverageeligibilityrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityResponse coverageeligibilityresponse:
							Serialize(coverageeligibilityresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DetectedIssue detectedissue:
							Serialize(detectedissue, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device device:
							Serialize(device, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition devicedefinition:
							Serialize(devicedefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceMetric devicemetric:
							Serialize(devicemetric, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceRequest devicerequest:
							Serialize(devicerequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceUseStatement deviceusestatement:
							Serialize(deviceusestatement, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DiagnosticReport diagnosticreport:
							Serialize(diagnosticreport, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentManifest documentmanifest:
							Serialize(documentmanifest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentReference documentreference:
							Serialize(documentreference, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis effectevidencesynthesis:
							Serialize(effectevidencesynthesis, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter encounter:
							Serialize(encounter, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Endpoint endpoint:
							Serialize(endpoint, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EnrollmentRequest enrollmentrequest:
							Serialize(enrollmentrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EnrollmentResponse enrollmentresponse:
							Serialize(enrollmentresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EpisodeOfCare episodeofcare:
							Serialize(episodeofcare, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EventDefinition eventdefinition:
							Serialize(eventdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Evidence evidence:
							Serialize(evidence, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EvidenceVariable evidencevariable:
							Serialize(evidencevariable, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario examplescenario:
							Serialize(examplescenario, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit explanationofbenefit:
							Serialize(explanationofbenefit, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.FamilyMemberHistory familymemberhistory:
							Serialize(familymemberhistory, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Flag flag:
							Serialize(flag, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Goal goal:
							Serialize(goal, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.GraphDefinition graphdefinition:
							Serialize(graphdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Group group:
							Serialize(group, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.GuidanceResponse guidanceresponse:
							Serialize(guidanceresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.HealthcareService healthcareservice:
							Serialize(healthcareservice, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImagingStudy imagingstudy:
							Serialize(imagingstudy, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Immunization immunization:
							Serialize(immunization, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImmunizationEvaluation immunizationevaluation:
							Serialize(immunizationevaluation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImmunizationRecommendation immunizationrecommendation:
							Serialize(immunizationrecommendation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide implementationguide:
							Serialize(implementationguide, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan insuranceplan:
							Serialize(insuranceplan, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Invoice invoice:
							Serialize(invoice, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Library library:
							Serialize(library, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Linkage linkage:
							Serialize(linkage, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.List list:
							Serialize(list, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Location location:
							Serialize(location, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure measure:
							Serialize(measure, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport measurereport:
							Serialize(measurereport, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Media media:
							Serialize(media, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Medication medication:
							Serialize(medication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationAdministration medicationadministration:
							Serialize(medicationadministration, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationDispense medicationdispense:
							Serialize(medicationdispense, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge medicationknowledge:
							Serialize(medicationknowledge, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest medicationrequest:
							Serialize(medicationrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationStatement medicationstatement:
							Serialize(medicationstatement, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct medicinalproduct:
							Serialize(medicinalproduct, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductAuthorization medicinalproductauthorization:
							Serialize(medicinalproductauthorization, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductContraindication medicinalproductcontraindication:
							Serialize(medicinalproductcontraindication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIndication medicinalproductindication:
							Serialize(medicinalproductindication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient medicinalproductingredient:
							Serialize(medicinalproductingredient, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductInteraction medicinalproductinteraction:
							Serialize(medicinalproductinteraction, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductManufactured medicinalproductmanufactured:
							Serialize(medicinalproductmanufactured, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPackaged medicinalproductpackaged:
							Serialize(medicinalproductpackaged, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPharmaceutical medicinalproductpharmaceutical:
							Serialize(medicinalproductpharmaceutical, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductUndesirableEffect medicinalproductundesirableeffect:
							Serialize(medicinalproductundesirableeffect, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageDefinition messagedefinition:
							Serialize(messagedefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader messageheader:
							Serialize(messageheader, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence molecularsequence:
							Serialize(molecularsequence, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.NamingSystem namingsystem:
							Serialize(namingsystem, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder nutritionorder:
							Serialize(nutritionorder, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Observation observation:
							Serialize(observation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ObservationDefinition observationdefinition:
							Serialize(observationdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationDefinition operationdefinition:
							Serialize(operationdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationOutcome operationoutcome:
							Serialize(operationoutcome, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Organization organization:
							Serialize(organization, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.OrganizationAffiliation organizationaffiliation:
							Serialize(organizationaffiliation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Parameters parameters:
							Serialize(parameters, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Patient patient:
							Serialize(patient, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PaymentNotice paymentnotice:
							Serialize(paymentnotice, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PaymentReconciliation paymentreconciliation:
							Serialize(paymentreconciliation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Person person:
							Serialize(person, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition plandefinition:
							Serialize(plandefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Practitioner practitioner:
							Serialize(practitioner, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PractitionerRole practitionerrole:
							Serialize(practitionerrole, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Procedure procedure:
							Serialize(procedure, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Provenance provenance:
							Serialize(provenance, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Questionnaire questionnaire:
							Serialize(questionnaire, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.QuestionnaireResponse questionnaireresponse:
							Serialize(questionnaireresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RelatedPerson relatedperson:
							Serialize(relatedperson, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RequestGroup requestgroup:
							Serialize(requestgroup, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchDefinition researchdefinition:
							Serialize(researchdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchElementDefinition researchelementdefinition:
							Serialize(researchelementdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchStudy researchstudy:
							Serialize(researchstudy, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchSubject researchsubject:
							Serialize(researchsubject, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskAssessment riskassessment:
							Serialize(riskassessment, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis riskevidencesynthesis:
							Serialize(riskevidencesynthesis, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Schedule schedule:
							Serialize(schedule, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SearchParameter searchparameter:
							Serialize(searchparameter, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ServiceRequest servicerequest:
							Serialize(servicerequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Slot slot:
							Serialize(slot, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Specimen specimen:
							Serialize(specimen, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SpecimenDefinition specimendefinition:
							Serialize(specimendefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition structuredefinition:
							Serialize(structuredefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap structuremap:
							Serialize(structuremap, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Subscription subscription:
							Serialize(subscription, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Substance substance:
							Serialize(substance, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceNucleicAcid substancenucleicacid:
							Serialize(substancenucleicacid, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer substancepolymer:
							Serialize(substancepolymer, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceProtein substanceprotein:
							Serialize(substanceprotein, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceReferenceInformation substancereferenceinformation:
							Serialize(substancereferenceinformation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial substancesourcematerial:
							Serialize(substancesourcematerial, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification substancespecification:
							Serialize(substancespecification, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyDelivery supplydelivery:
							Serialize(supplydelivery, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyRequest supplyrequest:
							Serialize(supplyrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Task task:
							Serialize(task, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities terminologycapabilities:
							Serialize(terminologycapabilities, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport testreport:
							Serialize(testreport, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript testscript:
							Serialize(testscript, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet valueset:
							Serialize(valueset, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.VerificationResult verificationresult:
							Serialize(verificationresult, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.VisionPrescription visionprescription:
							Serialize(visionprescription, writer, cancellationToken);
							break;
			// ---------------------------
				case Hl7.Fhir.Model.Address address:
							Serialize(address, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Annotation annotation:
							Serialize(annotation, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Attachment attachment:
							Serialize(attachment, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Base64Binary base64binary:
							Serialize(base64binary, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirBoolean fhirboolean:
							Serialize(fhirboolean, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Canonical canonical:
							Serialize(canonical, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code code:
							Serialize(code, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeableConcept codeableconcept:
							Serialize(codeableconcept, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coding coding:
							Serialize(coding, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ContactDetail contactdetail:
							Serialize(contactdetail, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ContactPoint contactpoint:
							Serialize(contactpoint, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contributor contributor:
							Serialize(contributor, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DataRequirement datarequirement:
							Serialize(datarequirement, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Date date:
							Serialize(date, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirDateTime fhirdatetime:
							Serialize(fhirdatetime, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirDecimal fhirdecimal:
							Serialize(fhirdecimal, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Dosage dosage:
							Serialize(dosage, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition elementdefinition:
							Serialize(elementdefinition, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Expression expression:
							Serialize(expression, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Extension extension:
							Serialize(extension, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.HumanName humanname:
							Serialize(humanname, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Id id:
							Serialize(id, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Identifier identifier:
							Serialize(identifier, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Instant instant:
							Serialize(instant, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Integer integer:
							Serialize(integer, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Markdown markdown:
							Serialize(markdown, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MarketingStatus marketingstatus:
							Serialize(marketingstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Meta meta:
							Serialize(meta, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Money money:
							Serialize(money, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Narrative narrative:
							Serialize(narrative, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Oid oid:
							Serialize(oid, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ParameterDefinition parameterdefinition:
							Serialize(parameterdefinition, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Period period:
							Serialize(period, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Population population:
							Serialize(population, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PositiveInt positiveint:
							Serialize(positiveint, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ProdCharacteristic prodcharacteristic:
							Serialize(prodcharacteristic, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ProductShelfLife productshelflife:
							Serialize(productshelflife, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Quantity quantity:
							Serialize(quantity, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Range range:
							Serialize(range, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Ratio ratio:
							Serialize(ratio, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResourceReference resourcereference:
							Serialize(resourcereference, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RelatedArtifact relatedartifact:
							Serialize(relatedartifact, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SampledData sampleddata:
							Serialize(sampleddata, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Signature signature:
							Serialize(signature, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirString fhirstring:
							Serialize(fhirstring, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceAmount substanceamount:
							Serialize(substanceamount, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Time time:
							Serialize(time, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Timing timing:
							Serialize(timing, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TriggerDefinition triggerdefinition:
							Serialize(triggerdefinition, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.UnsignedInt unsignedint:
							Serialize(unsignedint, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirUri fhiruri:
							Serialize(fhiruri, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirUrl fhirurl:
							Serialize(fhirurl, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.UsageContext usagecontext:
							Serialize(usagecontext, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Uuid uuid:
							Serialize(uuid, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.XHtml xhtml:
							Serialize(xhtml, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.PageComponent implementationguide_pagecomponent:
							Serialize(implementationguide_pagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest.InitialFillComponent medicationrequest_initialfillcomponent:
							Serialize(medicationrequest_initialfillcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent substancesourcematerial_hybridcomponent:
							Serialize(substancesourcematerial_hybridcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent substancesourcematerial_organismgeneralcomponent:
							Serialize(substancesourcematerial_organismgeneralcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent substancespecification_molecularweightcomponent:
							Serialize(substancespecification_molecularweightcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.SlicingComponent elementdefinition_slicingcomponent:
							Serialize(elementdefinition_slicingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.BaseComponent elementdefinition_basecomponent:
							Serialize(elementdefinition_basecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent elementdefinition_elementdefinitionbindingcomponent:
							Serialize(elementdefinition_elementdefinitionbindingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent substanceamount_referencerangecomponent:
							Serialize(substanceamount_referencerangecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Timing.RepeatComponent timing_repeatcomponent:
							Serialize(timing_repeatcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Account.AccountStatus> code_account_accountstatus:
							Serialize(code_account_accountstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus> code_publicationstatus:
							Serialize(code_publicationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActivityDefinition.RequestResourceType> code_activitydefinition_requestresourcetype:
							Serialize(code_activitydefinition_requestresourcetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent> code_requestintent:
							Serialize(code_requestintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority> code_requestpriority:
							Serialize(code_requestpriority, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality> code_adverseevent_adverseeventactuality:
							Serialize(code_adverseevent_adverseeventactuality, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType> code_allergyintolerance_allergyintolerancetype:
							Serialize(code_allergyintolerance_allergyintolerancetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality> code_allergyintolerance_allergyintolerancecriticality:
							Serialize(code_allergyintolerance_allergyintolerancecriticality, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Appointment.AppointmentStatus> code_appointment_appointmentstatus:
							Serialize(code_appointment_appointmentstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ParticipationStatus> code_participationstatus:
							Serialize(code_participationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction> code_auditevent_auditeventaction:
							Serialize(code_auditevent_auditeventaction, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome> code_auditevent_auditeventoutcome:
							Serialize(code_auditevent_auditeventoutcome, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent.SourceComponent auditevent_sourcecomponent:
							Serialize(auditevent_sourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> code_biologicallyderivedproduct_biologicallyderivedproductcategory:
							Serialize(code_biologicallyderivedproduct_biologicallyderivedproductcategory, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> code_biologicallyderivedproduct_biologicallyderivedproductstatus:
							Serialize(code_biologicallyderivedproduct_biologicallyderivedproductstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent biologicallyderivedproduct_collectioncomponent:
							Serialize(biologicallyderivedproduct_collectioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent biologicallyderivedproduct_manipulationcomponent:
							Serialize(biologicallyderivedproduct_manipulationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Bundle.BundleType> code_bundle_bundletype:
							Serialize(code_bundle_bundletype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatementKind> code_capabilitystatementkind:
							Serialize(code_capabilitystatementkind, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent capabilitystatement_softwarecomponent:
							Serialize(capabilitystatement_softwarecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent capabilitystatement_implementationcomponent:
							Serialize(capabilitystatement_implementationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion> code_fhirversion:
							Serialize(code_fhirversion, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus> code_requeststatus:
							Serialize(code_requeststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanIntent> code_careplan_careplanintent:
							Serialize(code_careplan_careplanintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CareTeam.CareTeamStatus> code_careteam_careteamstatus:
							Serialize(code_careteam_careteamstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ChargeItem.ChargeItemStatus> code_chargeitem_chargeitemstatus:
							Serialize(code_chargeitem_chargeitemstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes> code_financialresourcestatuscodes:
							Serialize(code_financialresourcestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use> code_use:
							Serialize(code_use, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.PayeeComponent claim_payeecomponent:
							Serialize(claim_payeecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.AccidentComponent claim_accidentcomponent:
							Serialize(claim_accidentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes> code_claimprocessingcodes:
							Serialize(code_claimprocessingcodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.PaymentComponent claimresponse_paymentcomponent:
							Serialize(claimresponse_paymentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus> code_clinicalimpression_clinicalimpressionstatus:
							Serialize(code_clinicalimpression_clinicalimpressionstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemHierarchyMeaning> code_codesystem_codesystemhierarchymeaning:
							Serialize(code_codesystem_codesystemhierarchymeaning, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemContentMode> code_codesystem_codesystemcontentmode:
							Serialize(code_codesystem_codesystemcontentmode, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus> code_eventstatus:
							Serialize(code_eventstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompartmentType> code_compartmenttype:
							Serialize(code_compartmenttype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus> code_compositionstatus:
							Serialize(code_compositionstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification> code_composition_v3_confidentialityclassification:
							Serialize(code_composition_v3_confidentialityclassification, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentState> code_consent_consentstate:
							Serialize(code_consent_consentstate, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent.provisionComponent consent_provisioncomponent:
							Serialize(consent_provisioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes> code_contract_contractresourcestatuscodes:
							Serialize(code_contract_contractresourcestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ContentDefinitionComponent contract_contentdefinitioncomponent:
							Serialize(contract_contentdefinitioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus> code_observationstatus:
							Serialize(code_observationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DetectedIssue.DetectedIssueSeverity> code_detectedissue_detectedissueseverity:
							Serialize(code_detectedissue_detectedissueseverity, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Device.FHIRDeviceStatus> code_device_fhirdevicestatus:
							Serialize(code_device_fhirdevicestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricOperationalStatus> code_devicemetric_devicemetricoperationalstatus:
							Serialize(code_devicemetric_devicemetricoperationalstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricColor> code_devicemetric_devicemetriccolor:
							Serialize(code_devicemetric_devicemetriccolor, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricCategory> code_devicemetric_devicemetriccategory:
							Serialize(code_devicemetric_devicemetriccategory, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus> code_deviceusestatement_deviceusestatementstatus:
							Serialize(code_deviceusestatement_deviceusestatementstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus> code_diagnosticreport_diagnosticreportstatus:
							Serialize(code_diagnosticreport_diagnosticreportstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DocumentReferenceStatus> code_documentreferencestatus:
							Serialize(code_documentreferencestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentReference.ContextComponent documentreference_contextcomponent:
							Serialize(documentreference_contextcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.SampleSizeComponent effectevidencesynthesis_samplesizecomponent:
							Serialize(effectevidencesynthesis_samplesizecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Encounter.EncounterStatus> code_encounter_encounterstatus:
							Serialize(code_encounter_encounterstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.HospitalizationComponent encounter_hospitalizationcomponent:
							Serialize(encounter_hospitalizationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Endpoint.EndpointStatus> code_endpoint_endpointstatus:
							Serialize(code_endpoint_endpointstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus> code_episodeofcare_episodeofcarestatus:
							Serialize(code_episodeofcare_episodeofcarestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EvidenceVariableType> code_evidencevariabletype:
							Serialize(code_evidencevariabletype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ExplanationOfBenefit.ExplanationOfBenefitStatus> code_explanationofbenefit_explanationofbenefitstatus:
							Serialize(code_explanationofbenefit_explanationofbenefitstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent explanationofbenefit_payeecomponent:
							Serialize(explanationofbenefit_payeecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent explanationofbenefit_accidentcomponent:
							Serialize(explanationofbenefit_accidentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent explanationofbenefit_paymentcomponent:
							Serialize(explanationofbenefit_paymentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FamilyMemberHistory.FamilyHistoryStatus> code_familymemberhistory_familyhistorystatus:
							Serialize(code_familymemberhistory_familyhistorystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Flag.FlagStatus> code_flag_flagstatus:
							Serialize(code_flag_flagstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus> code_goal_goallifecyclestatus:
							Serialize(code_goal_goallifecyclestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType> code_resourcetype:
							Serialize(code_resourcetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Group.GroupType> code_group_grouptype:
							Serialize(code_group_grouptype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus> code_guidanceresponse_guidanceresponsestatus:
							Serialize(code_guidanceresponse_guidanceresponsestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImagingStudy.ImagingStudyStatus> code_imagingstudy_imagingstudystatus:
							Serialize(code_imagingstudy_imagingstudystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes> code_immunization_immunizationstatuscodes:
							Serialize(code_immunization_immunizationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> code_immunizationevaluation_immunizationevaluationstatuscodes:
							Serialize(code_immunizationevaluation_immunizationevaluationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImplementationGuide.SPDXLicense> code_implementationguide_spdxlicense:
							Serialize(code_implementationguide_spdxlicense, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.DefinitionComponent implementationguide_definitioncomponent:
							Serialize(implementationguide_definitioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.ManifestComponent implementationguide_manifestcomponent:
							Serialize(implementationguide_manifestcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Invoice.InvoiceStatus> code_invoice_invoicestatus:
							Serialize(code_invoice_invoicestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.List.ListStatus> code_list_liststatus:
							Serialize(code_list_liststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode> code_listmode:
							Serialize(code_listmode, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationStatus> code_location_locationstatus:
							Serialize(code_location_locationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationMode> code_location_locationmode:
							Serialize(code_location_locationmode, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Location.PositionComponent location_positioncomponent:
							Serialize(location_positioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MeasureReport.MeasureReportStatus> code_measurereport_measurereportstatus:
							Serialize(code_measurereport_measurereportstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MeasureReport.MeasureReportType> code_measurereport_measurereporttype:
							Serialize(code_measurereport_measurereporttype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes> code_medication_medicationstatuscodes:
							Serialize(code_medication_medicationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Medication.BatchComponent medication_batchcomponent:
							Serialize(medication_batchcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusCodes> code_medicationadministration_medicationadministrationstatuscodes:
							Serialize(code_medicationadministration_medicationadministrationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationAdministration.DosageComponent medicationadministration_dosagecomponent:
							Serialize(medicationadministration_dosagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes> code_medicationdispense_medicationdispensestatuscodes:
							Serialize(code_medicationdispense_medicationdispensestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent medicationdispense_substitutioncomponent:
							Serialize(medicationdispense_substitutioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes> code_medicationknowledge_medicationknowledgestatuscodes:
							Serialize(code_medicationknowledge_medicationknowledgestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent medicationknowledge_packagingcomponent:
							Serialize(medicationknowledge_packagingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationrequestStatus> code_medicationrequest_medicationrequeststatus:
							Serialize(code_medicationrequest_medicationrequeststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationRequestIntent> code_medicationrequest_medicationrequestintent:
							Serialize(code_medicationrequest_medicationrequestintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent medicationrequest_dispenserequestcomponent:
							Serialize(medicationrequest_dispenserequestcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent medicationrequest_substitutioncomponent:
							Serialize(medicationrequest_substitutioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes> code_medicationstatement_medicationstatuscodes:
							Serialize(code_medicationstatement_medicationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent medicinalproductauthorization_procedurecomponent:
							Serialize(medicinalproductauthorization_procedurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent medicinalproductingredient_substancecomponent:
							Serialize(medicinalproductingredient_substancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MessageDefinition.MessageSignificanceCategory> code_messagedefinition_messagesignificancecategory:
							Serialize(code_messagedefinition_messagesignificancecategory, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MessageDefinition.messageheader_response_request> code_messagedefinition_messageheader_response_request:
							Serialize(code_messagedefinition_messageheader_response_request, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader.MessageSourceComponent messageheader_messagesourcecomponent:
							Serialize(messageheader_messagesourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader.ResponseComponent messageheader_responsecomponent:
							Serialize(messageheader_responsecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.sequenceType> code_molecularsequence_sequencetype:
							Serialize(code_molecularsequence_sequencetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent molecularsequence_referenceseqcomponent:
							Serialize(molecularsequence_referenceseqcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.NamingSystem.NamingSystemType> code_namingsystem_namingsystemtype:
							Serialize(code_namingsystem_namingsystemtype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.OralDietComponent nutritionorder_oraldietcomponent:
							Serialize(nutritionorder_oraldietcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent nutritionorder_enteralformulacomponent:
							Serialize(nutritionorder_enteralformulacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent observationdefinition_quantitativedetailscomponent:
							Serialize(observationdefinition_quantitativedetailscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationDefinition.OperationKind> code_operationdefinition_operationkind:
							Serialize(code_operationdefinition_operationkind, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender> code_administrativegender:
							Serialize(code_administrativegender, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.QuestionnaireResponse.QuestionnaireResponseStatus> code_questionnaireresponse_questionnaireresponsestatus:
							Serialize(code_questionnaireresponse_questionnaireresponsestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchElementDefinition.ResearchElementType> code_researchelementdefinition_researchelementtype:
							Serialize(code_researchelementdefinition_researchelementtype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus> code_researchstudy_researchstudystatus:
							Serialize(code_researchstudy_researchstudystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus> code_researchsubject_researchsubjectstatus:
							Serialize(code_researchsubject_researchsubjectstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent riskevidencesynthesis_samplesizecomponent:
							Serialize(riskevidencesynthesis_samplesizecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent riskevidencesynthesis_riskestimatecomponent:
							Serialize(riskevidencesynthesis_riskestimatecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType> code_searchparamtype:
							Serialize(code_searchparamtype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType> code_searchparameter_xpathusagetype:
							Serialize(code_searchparameter_xpathusagetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Slot.SlotStatus> code_slot_slotstatus:
							Serialize(code_slot_slotstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Specimen.SpecimenStatus> code_specimen_specimenstatus:
							Serialize(code_specimen_specimenstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Specimen.CollectionComponent specimen_collectioncomponent:
							Serialize(specimen_collectioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind> code_structuredefinition_structuredefinitionkind:
							Serialize(code_structuredefinition_structuredefinitionkind, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule> code_structuredefinition_typederivationrule:
							Serialize(code_structuredefinition_typederivationrule, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition.SnapshotComponent structuredefinition_snapshotcomponent:
							Serialize(structuredefinition_snapshotcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition.DifferentialComponent structuredefinition_differentialcomponent:
							Serialize(structuredefinition_differentialcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus> code_subscription_subscriptionstatus:
							Serialize(code_subscription_subscriptionstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Subscription.ChannelComponent subscription_channelcomponent:
							Serialize(subscription_channelcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Substance.FHIRSubstanceStatus> code_substance_fhirsubstancestatus:
							Serialize(code_substance_fhirsubstancestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent substancesourcematerial_organismcomponent:
							Serialize(substancesourcematerial_organismcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.StructureComponent substancespecification_structurecomponent:
							Serialize(substancespecification_structurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus> code_supplydelivery_supplydeliverystatus:
							Serialize(code_supplydelivery_supplydeliverystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent supplydelivery_supplieditemcomponent:
							Serialize(supplydelivery_supplieditemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus> code_supplyrequest_supplyrequeststatus:
							Serialize(code_supplyrequest_supplyrequeststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskStatus> code_task_taskstatus:
							Serialize(code_task_taskstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskIntent> code_task_taskintent:
							Serialize(code_task_taskintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Task.RestrictionComponent task_restrictioncomponent:
							Serialize(task_restrictioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.SoftwareComponent terminologycapabilities_softwarecomponent:
							Serialize(terminologycapabilities_softwarecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ImplementationComponent terminologycapabilities_implementationcomponent:
							Serialize(terminologycapabilities_implementationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent terminologycapabilities_expansioncomponent:
							Serialize(terminologycapabilities_expansioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TerminologyCapabilities.CodeSearchSupport> code_terminologycapabilities_codesearchsupport:
							Serialize(code_terminologycapabilities_codesearchsupport, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ValidateCodeComponent terminologycapabilities_validatecodecomponent:
							Serialize(terminologycapabilities_validatecodecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.TranslationComponent terminologycapabilities_translationcomponent:
							Serialize(terminologycapabilities_translationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ClosureComponent terminologycapabilities_closurecomponent:
							Serialize(terminologycapabilities_closurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportStatus> code_testreport_testreportstatus:
							Serialize(code_testreport_testreportstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportResult> code_testreport_testreportresult:
							Serialize(code_testreport_testreportresult, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.SetupComponent testreport_setupcomponent:
							Serialize(testreport_setupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.TeardownComponent testreport_teardowncomponent:
							Serialize(testreport_teardowncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.MetadataComponent testscript_metadatacomponent:
							Serialize(testscript_metadatacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.SetupComponent testscript_setupcomponent:
							Serialize(testscript_setupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.TeardownComponent testscript_teardowncomponent:
							Serialize(testscript_teardowncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ComposeComponent valueset_composecomponent:
							Serialize(valueset_composecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ExpansionComponent valueset_expansioncomponent:
							Serialize(valueset_expansioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VerificationResult.status> code_verificationresult_status:
							Serialize(code_verificationresult_status, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.VerificationResult.AttestationComponent verificationresult_attestationcomponent:
							Serialize(verificationresult_attestationcomponent, writer, propertyName, cancellationToken);
							break;
				default:	System.Diagnostics.Trace.WriteLine($"No Serialization defined for {value?.TypeName}");
							break;
			}
		}
	}
}
