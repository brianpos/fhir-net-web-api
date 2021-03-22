// -----------------------------------------------------------------------------
// GENERATED CODE - DO NOT EDIT
// Generated: 03/22/2021 11:51:26
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
    public partial class FhirCustomXmlWriter
    {
		public static void Write(Account name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Account", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.ServicePeriod, writer, "servicePeriod", cancellationToken); // 140
			Write(name.Coverage, writer, "coverage", cancellationToken); // 150
			Write(name.Owner, writer, "owner", cancellationToken); // 160
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 170
			Write(name.Guarantor, writer, "guarantor", cancellationToken); // 180
			Write(name.PartOf, writer, "partOf", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(ActivityDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ActivityDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 170
			Write(name.DateElement, writer, "date", cancellationToken); // 180
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Write(name.Contact, writer, "contact", cancellationToken); // 200
			Write(name.Description, writer, "description", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Purpose, writer, "purpose", cancellationToken); // 240
			Write(name.UsageElement, writer, "usage", cancellationToken); // 250
			Write(name.Copyright, writer, "copyright", cancellationToken); // 260
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 270
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 280
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 290
			Write(name.Topic, writer, "topic", cancellationToken); // 300
			Write(name.Author, writer, "author", cancellationToken); // 310
			Write(name.Editor, writer, "editor", cancellationToken); // 320
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 330
			Write(name.Endorser, writer, "endorser", cancellationToken); // 340
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 350
			Write(name.LibraryElement, writer, "library", cancellationToken); // 360
			Write(name.KindElement, writer, "kind", cancellationToken); // 370
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 380
			Write(name.Code, writer, "code", cancellationToken); // 390
			Write(name.IntentElement, writer, "intent", cancellationToken); // 400
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 410
			Write(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 420
			Write(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 430
			Write(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 430
			Write(name.Timing as Hl7.Fhir.Model.Age, writer, "timingAge", cancellationToken); // 430
			Write(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 430
			Write(name.Timing as Hl7.Fhir.Model.Range, writer, "timingRange", cancellationToken); // 430
			Write(name.Timing as Hl7.Fhir.Model.Duration, writer, "timingDuration", cancellationToken); // 430
			Write(name.Location, writer, "location", cancellationToken); // 440
			Write(name.Participant, writer, "participant", cancellationToken); // 450
			Write(name.Product as Hl7.Fhir.Model.ResourceReference, writer, "productReference", cancellationToken); // 460
			Write(name.Product as Hl7.Fhir.Model.CodeableConcept, writer, "productCodeableConcept", cancellationToken); // 460
			Write(name.Quantity, writer, "quantity", cancellationToken); // 470
			Write(name.Dosage, writer, "dosage", cancellationToken); // 480
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 490
			Write(name.SpecimenRequirement, writer, "specimenRequirement", cancellationToken); // 500
			Write(name.ObservationRequirement, writer, "observationRequirement", cancellationToken); // 510
			Write(name.ObservationResultRequirement, writer, "observationResultRequirement", cancellationToken); // 520
			Write(name.TransformElement, writer, "transform", cancellationToken); // 530
			Write(name.DynamicValue, writer, "dynamicValue", cancellationToken); // 540
			writer.WriteEndElement();
		}

		public static void Write(AdverseEvent name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AdverseEvent", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActualityElement, writer, "actuality", cancellationToken); // 100
			Write(name.Category, writer, "category", cancellationToken); // 110
			Write(name.Event, writer, "event", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.Encounter, writer, "encounter", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.DetectedElement, writer, "detected", cancellationToken); // 160
			Write(name.RecordedDateElement, writer, "recordedDate", cancellationToken); // 170
			Write(name.ResultingCondition, writer, "resultingCondition", cancellationToken); // 180
			Write(name.Location, writer, "location", cancellationToken); // 190
			Write(name.Seriousness, writer, "seriousness", cancellationToken); // 200
			Write(name.Severity, writer, "severity", cancellationToken); // 210
			Write(name.Outcome, writer, "outcome", cancellationToken); // 220
			Write(name.Recorder, writer, "recorder", cancellationToken); // 230
			Write(name.Contributor, writer, "contributor", cancellationToken); // 240
			Write(name.SuspectEntity, writer, "suspectEntity", cancellationToken); // 250
			Write(name.SubjectMedicalHistory, writer, "subjectMedicalHistory", cancellationToken); // 260
			Write(name.ReferenceDocument, writer, "referenceDocument", cancellationToken); // 270
			Write(name.Study, writer, "study", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Write(AllergyIntolerance name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AllergyIntolerance", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ClinicalStatus, writer, "clinicalStatus", cancellationToken); // 100
			Write(name.VerificationStatus, writer, "verificationStatus", cancellationToken); // 110
			Write(name.TypeElement, writer, "type", cancellationToken); // 120
			Write(name.CategoryElement, writer, "category", cancellationToken); // 130
			Write(name.CriticalityElement, writer, "criticality", cancellationToken); // 140
			Write(name.Code, writer, "code", cancellationToken); // 150
			Write(name.Patient, writer, "patient", cancellationToken); // 160
			Write(name.Encounter, writer, "encounter", cancellationToken); // 170
			Write(name.Onset as Hl7.Fhir.Model.FhirDateTime, writer, "onsetDateTime", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.Age, writer, "onsetAge", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.Period, writer, "onsetPeriod", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.Range, writer, "onsetRange", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.FhirString, writer, "onsetString", cancellationToken); // 180
			Write(name.RecordedDateElement, writer, "recordedDate", cancellationToken); // 190
			Write(name.Recorder, writer, "recorder", cancellationToken); // 200
			Write(name.Asserter, writer, "asserter", cancellationToken); // 210
			Write(name.LastOccurrenceElement, writer, "lastOccurrence", cancellationToken); // 220
			Write(name.Note, writer, "note", cancellationToken); // 230
			Write(name.Reaction, writer, "reaction", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(Appointment name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Appointment", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.CancelationReason, writer, "cancelationReason", cancellationToken); // 110
			Write(name.ServiceCategory, writer, "serviceCategory", cancellationToken); // 120
			Write(name.ServiceType, writer, "serviceType", cancellationToken); // 130
			Write(name.Specialty, writer, "specialty", cancellationToken); // 140
			Write(name.AppointmentType, writer, "appointmentType", cancellationToken); // 150
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 160
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 170
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 180
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 190
			Write(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 200
			Write(name.StartElement, writer, "start", cancellationToken); // 210
			Write(name.EndElement, writer, "end", cancellationToken); // 220
			Write(name.MinutesDurationElement, writer, "minutesDuration", cancellationToken); // 230
			Write(name.Slot, writer, "slot", cancellationToken); // 240
			Write(name.CreatedElement, writer, "created", cancellationToken); // 250
			Write(name.CommentElement, writer, "comment", cancellationToken); // 260
			Write(name.PatientInstructionElement, writer, "patientInstruction", cancellationToken); // 270
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 280
			Write(name.Participant, writer, "participant", cancellationToken); // 290
			Write(name.RequestedPeriod, writer, "requestedPeriod", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Write(AppointmentResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AppointmentResponse", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Appointment, writer, "appointment", cancellationToken); // 100
			Write(name.StartElement, writer, "start", cancellationToken); // 110
			Write(name.EndElement, writer, "end", cancellationToken); // 120
			Write(name.ParticipantType, writer, "participantType", cancellationToken); // 130
			Write(name.Actor, writer, "actor", cancellationToken); // 140
			Write(name.ParticipantStatusElement, writer, "participantStatus", cancellationToken); // 150
			Write(name.CommentElement, writer, "comment", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(AuditEvent name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("AuditEvent", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Type, writer, "type", cancellationToken); // 90
			Write(name.Subtype, writer, "subtype", cancellationToken); // 100
			Write(name.ActionElement, writer, "action", cancellationToken); // 110
			Write(name.Period, writer, "period", cancellationToken); // 120
			Write(name.RecordedElement, writer, "recorded", cancellationToken); // 130
			Write(name.OutcomeElement, writer, "outcome", cancellationToken); // 140
			Write(name.OutcomeDescElement, writer, "outcomeDesc", cancellationToken); // 150
			Write(name.PurposeOfEvent, writer, "purposeOfEvent", cancellationToken); // 160
			Write(name.Agent, writer, "agent", cancellationToken); // 170
			Write(name.Source, writer, "source", cancellationToken); // 180
			Write(name.Entity, writer, "entity", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(Basic name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Basic", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Code, writer, "code", cancellationToken); // 100
			Write(name.Subject, writer, "subject", cancellationToken); // 110
			Write(name.CreatedElement, writer, "created", cancellationToken); // 120
			Write(name.Author, writer, "author", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Write(Binary name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Binary", XmlNs.FHIR);
			WriteResource(name, writer, cancellationToken);
			Write(name.ContentTypeElement, writer, "contentType", cancellationToken); // 50
			Write(name.SecurityContext, writer, "securityContext", cancellationToken); // 60
			Write(name.DataElement, writer, "data", cancellationToken); // 70
			writer.WriteEndElement();
		}

		public static void Write(BiologicallyDerivedProduct name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("BiologicallyDerivedProduct", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ProductCategoryElement, writer, "productCategory", cancellationToken); // 100
			Write(name.ProductCode, writer, "productCode", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.Request, writer, "request", cancellationToken); // 130
			Write(name.QuantityElement, writer, "quantity", cancellationToken); // 140
			Write(name.Parent, writer, "parent", cancellationToken); // 150
			Write(name.Collection, writer, "collection", cancellationToken); // 160
			Write(name.Processing, writer, "processing", cancellationToken); // 170
			Write(name.Manipulation, writer, "manipulation", cancellationToken); // 180
			Write(name.Storage, writer, "storage", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(BodyStructure name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("BodyStructure", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Morphology, writer, "morphology", cancellationToken); // 110
			Write(name.Location, writer, "location", cancellationToken); // 120
			Write(name.LocationQualifier, writer, "locationQualifier", cancellationToken); // 130
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 140
			Write(name.Image, writer, "image", cancellationToken); // 150
			Write(name.Patient, writer, "patient", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(Bundle name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Bundle", XmlNs.FHIR);
			WriteResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 50
			Write(name.TypeElement, writer, "type", cancellationToken); // 60
			Write(name.TimestampElement, writer, "timestamp", cancellationToken); // 70
			Write(name.TotalElement, writer, "total", cancellationToken); // 80
			Write(name.Link, writer, "link", cancellationToken); // 90
			Write(name.Entry, writer, "entry", cancellationToken); // 100
			Write(name.Signature, writer, "signature", cancellationToken); // 110
			writer.WriteEndElement();
		}

		public static void Write(CapabilityStatement name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CapabilityStatement", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.TitleElement, writer, "title", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Description, writer, "description", cancellationToken); // 180
			Write(name.UseContext, writer, "useContext", cancellationToken); // 190
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Write(name.Purpose, writer, "purpose", cancellationToken); // 210
			Write(name.Copyright, writer, "copyright", cancellationToken); // 220
			Write(name.KindElement, writer, "kind", cancellationToken); // 230
			Write(name.InstantiatesElement, writer, "instantiates", cancellationToken); // 240
			Write(name.ImportsElement, writer, "imports", cancellationToken); // 250
			Write(name.Software, writer, "software", cancellationToken); // 260
			Write(name.Implementation, writer, "implementation", cancellationToken); // 270
			Write(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 280
			Write(name.FormatElement, writer, "format", cancellationToken); // 290
			Write(name.PatchFormatElement, writer, "patchFormat", cancellationToken); // 300
			Write(name.ImplementationGuideElement, writer, "implementationGuide", cancellationToken); // 310
			Write(name.Rest, writer, "rest", cancellationToken); // 320
			Write(name.Messaging, writer, "messaging", cancellationToken); // 330
			Write(name.Document, writer, "document", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Write(CarePlan name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CarePlan", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.Replaces, writer, "replaces", cancellationToken); // 130
			Write(name.PartOf, writer, "partOf", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.IntentElement, writer, "intent", cancellationToken); // 160
			Write(name.Category, writer, "category", cancellationToken); // 170
			Write(name.TitleElement, writer, "title", cancellationToken); // 180
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 190
			Write(name.Subject, writer, "subject", cancellationToken); // 200
			Write(name.Encounter, writer, "encounter", cancellationToken); // 210
			Write(name.Period, writer, "period", cancellationToken); // 220
			Write(name.CreatedElement, writer, "created", cancellationToken); // 230
			Write(name.Author, writer, "author", cancellationToken); // 240
			Write(name.Contributor, writer, "contributor", cancellationToken); // 250
			Write(name.CareTeam, writer, "careTeam", cancellationToken); // 260
			Write(name.Addresses, writer, "addresses", cancellationToken); // 270
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 280
			Write(name.Goal, writer, "goal", cancellationToken); // 290
			Write(name.Activity, writer, "activity", cancellationToken); // 300
			Write(name.Note, writer, "note", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Write(CareTeam name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CareTeam", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Category, writer, "category", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.Encounter, writer, "encounter", cancellationToken); // 140
			Write(name.Period, writer, "period", cancellationToken); // 150
			Write(name.Participant, writer, "participant", cancellationToken); // 160
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 170
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 180
			Write(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 190
			Write(name.Telecom, writer, "telecom", cancellationToken); // 200
			Write(name.Note, writer, "note", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(CatalogEntry name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CatalogEntry", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Type, writer, "type", cancellationToken); // 100
			Write(name.OrderableElement, writer, "orderable", cancellationToken); // 110
			Write(name.ReferencedItem, writer, "referencedItem", cancellationToken); // 120
			Write(name.AdditionalIdentifier, writer, "additionalIdentifier", cancellationToken); // 130
			Write(name.Classification, writer, "classification", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 160
			Write(name.ValidToElement, writer, "validTo", cancellationToken); // 170
			Write(name.LastUpdatedElement, writer, "lastUpdated", cancellationToken); // 180
			Write(name.AdditionalCharacteristic, writer, "additionalCharacteristic", cancellationToken); // 190
			Write(name.AdditionalClassification, writer, "additionalClassification", cancellationToken); // 200
			Write(name.RelatedEntry, writer, "relatedEntry", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(ChargeItem name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ChargeItem", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.DefinitionUriElement, writer, "definitionUri", cancellationToken); // 100
			Write(name.DefinitionCanonicalElement, writer, "definitionCanonical", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.PartOf, writer, "partOf", cancellationToken); // 130
			Write(name.Code, writer, "code", cancellationToken); // 140
			Write(name.Subject, writer, "subject", cancellationToken); // 150
			Write(name.Context, writer, "context", cancellationToken); // 160
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 170
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 170
			Write(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 170
			Write(name.Performer, writer, "performer", cancellationToken); // 180
			Write(name.PerformingOrganization, writer, "performingOrganization", cancellationToken); // 190
			Write(name.RequestingOrganization, writer, "requestingOrganization", cancellationToken); // 200
			Write(name.CostCenter, writer, "costCenter", cancellationToken); // 210
			Write(name.Quantity, writer, "quantity", cancellationToken); // 220
			Write(name.Bodysite, writer, "bodysite", cancellationToken); // 230
			Write(name.FactorOverrideElement, writer, "factorOverride", cancellationToken); // 240
			Write(name.PriceOverride, writer, "priceOverride", cancellationToken); // 250
			Write(name.OverrideReasonElement, writer, "overrideReason", cancellationToken); // 260
			Write(name.Enterer, writer, "enterer", cancellationToken); // 270
			Write(name.EnteredDateElement, writer, "enteredDate", cancellationToken); // 280
			Write(name.Reason, writer, "reason", cancellationToken); // 290
			Write(name.Service, writer, "service", cancellationToken); // 300
			Write(name.Product as Hl7.Fhir.Model.ResourceReference, writer, "productReference", cancellationToken); // 310
			Write(name.Product as Hl7.Fhir.Model.CodeableConcept, writer, "productCodeableConcept", cancellationToken); // 310
			Write(name.Account, writer, "account", cancellationToken); // 320
			Write(name.Note, writer, "note", cancellationToken); // 330
			Write(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Write(ChargeItemDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ChargeItemDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.TitleElement, writer, "title", cancellationToken); // 120
			Write(name.DerivedFromUriElement, writer, "derivedFromUri", cancellationToken); // 130
			Write(name.PartOfElement, writer, "partOf", cancellationToken); // 140
			Write(name.ReplacesElement, writer, "replaces", cancellationToken); // 150
			Write(name.StatusElement, writer, "status", cancellationToken); // 160
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Write(name.DateElement, writer, "date", cancellationToken); // 180
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Write(name.Contact, writer, "contact", cancellationToken); // 200
			Write(name.Description, writer, "description", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Copyright, writer, "copyright", cancellationToken); // 240
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 250
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 260
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 270
			Write(name.Code, writer, "code", cancellationToken); // 280
			Write(name.Instance, writer, "instance", cancellationToken); // 290
			Write(name.Applicability, writer, "applicability", cancellationToken); // 300
			Write(name.PropertyGroup, writer, "propertyGroup", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Write(Claim name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Claim", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.SubType, writer, "subType", cancellationToken); // 120
			Write(name.UseElement, writer, "use", cancellationToken); // 130
			Write(name.Patient, writer, "patient", cancellationToken); // 140
			Write(name.BillablePeriod, writer, "billablePeriod", cancellationToken); // 150
			Write(name.CreatedElement, writer, "created", cancellationToken); // 160
			Write(name.Enterer, writer, "enterer", cancellationToken); // 170
			Write(name.Insurer, writer, "insurer", cancellationToken); // 180
			Write(name.Provider, writer, "provider", cancellationToken); // 190
			Write(name.Priority, writer, "priority", cancellationToken); // 200
			Write(name.FundsReserve, writer, "fundsReserve", cancellationToken); // 210
			Write(name.Related, writer, "related", cancellationToken); // 220
			Write(name.Prescription, writer, "prescription", cancellationToken); // 230
			Write(name.OriginalPrescription, writer, "originalPrescription", cancellationToken); // 240
			Write(name.Payee, writer, "payee", cancellationToken); // 250
			Write(name.Referral, writer, "referral", cancellationToken); // 260
			Write(name.Facility, writer, "facility", cancellationToken); // 270
			Write(name.CareTeam, writer, "careTeam", cancellationToken); // 280
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 290
			Write(name.Diagnosis, writer, "diagnosis", cancellationToken); // 300
			Write(name.Procedure, writer, "procedure", cancellationToken); // 310
			Write(name.Insurance, writer, "insurance", cancellationToken); // 320
			Write(name.Accident, writer, "accident", cancellationToken); // 330
			Write(name.Item, writer, "item", cancellationToken); // 340
			Write(name.Total, writer, "total", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Write(ClaimResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ClaimResponse", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.SubType, writer, "subType", cancellationToken); // 120
			Write(name.UseElement, writer, "use", cancellationToken); // 130
			Write(name.Patient, writer, "patient", cancellationToken); // 140
			Write(name.CreatedElement, writer, "created", cancellationToken); // 150
			Write(name.Insurer, writer, "insurer", cancellationToken); // 160
			Write(name.Requestor, writer, "requestor", cancellationToken); // 170
			Write(name.Request, writer, "request", cancellationToken); // 180
			Write(name.OutcomeElement, writer, "outcome", cancellationToken); // 190
			Write(name.DispositionElement, writer, "disposition", cancellationToken); // 200
			Write(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 210
			Write(name.PreAuthPeriod, writer, "preAuthPeriod", cancellationToken); // 220
			Write(name.PayeeType, writer, "payeeType", cancellationToken); // 230
			Write(name.Item, writer, "item", cancellationToken); // 240
			Write(name.AddItem, writer, "addItem", cancellationToken); // 250
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 260
			Write(name.Total, writer, "total", cancellationToken); // 270
			Write(name.Payment, writer, "payment", cancellationToken); // 280
			Write(name.FundsReserve, writer, "fundsReserve", cancellationToken); // 290
			Write(name.FormCode, writer, "formCode", cancellationToken); // 300
			Write(name.Form, writer, "form", cancellationToken); // 310
			Write(name.ProcessNote, writer, "processNote", cancellationToken); // 320
			Write(name.CommunicationRequest, writer, "communicationRequest", cancellationToken); // 330
			Write(name.Insurance, writer, "insurance", cancellationToken); // 340
			Write(name.Error, writer, "error", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Write(ClinicalImpression name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ClinicalImpression", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 110
			Write(name.Code, writer, "code", cancellationToken); // 120
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 130
			Write(name.Subject, writer, "subject", cancellationToken); // 140
			Write(name.Encounter, writer, "encounter", cancellationToken); // 150
			Write(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 160
			Write(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 160
			Write(name.DateElement, writer, "date", cancellationToken); // 170
			Write(name.Assessor, writer, "assessor", cancellationToken); // 180
			Write(name.Previous, writer, "previous", cancellationToken); // 190
			Write(name.Problem, writer, "problem", cancellationToken); // 200
			Write(name.Investigation, writer, "investigation", cancellationToken); // 210
			Write(name.ProtocolElement, writer, "protocol", cancellationToken); // 220
			Write(name.SummaryElement, writer, "summary", cancellationToken); // 230
			Write(name.Finding, writer, "finding", cancellationToken); // 240
			Write(name.PrognosisCodeableConcept, writer, "prognosisCodeableConcept", cancellationToken); // 250
			Write(name.PrognosisReference, writer, "prognosisReference", cancellationToken); // 260
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 270
			Write(name.Note, writer, "note", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Write(CodeSystem name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CodeSystem", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Purpose, writer, "purpose", cancellationToken); // 220
			Write(name.Copyright, writer, "copyright", cancellationToken); // 230
			Write(name.CaseSensitiveElement, writer, "caseSensitive", cancellationToken); // 240
			Write(name.ValueSetElement, writer, "valueSet", cancellationToken); // 250
			Write(name.HierarchyMeaningElement, writer, "hierarchyMeaning", cancellationToken); // 260
			Write(name.CompositionalElement, writer, "compositional", cancellationToken); // 270
			Write(name.VersionNeededElement, writer, "versionNeeded", cancellationToken); // 280
			Write(name.ContentElement, writer, "content", cancellationToken); // 290
			Write(name.SupplementsElement, writer, "supplements", cancellationToken); // 300
			Write(name.CountElement, writer, "count", cancellationToken); // 310
			Write(name.Filter, writer, "filter", cancellationToken); // 320
			Write(name.Property, writer, "property", cancellationToken); // 330
			Write(name.Concept, writer, "concept", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Write(Communication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Communication", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.PartOf, writer, "partOf", cancellationToken); // 130
			Write(name.InResponseTo, writer, "inResponseTo", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 160
			Write(name.Category, writer, "category", cancellationToken); // 170
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 180
			Write(name.Medium, writer, "medium", cancellationToken); // 190
			Write(name.Subject, writer, "subject", cancellationToken); // 200
			Write(name.Topic, writer, "topic", cancellationToken); // 210
			Write(name.About, writer, "about", cancellationToken); // 220
			Write(name.Encounter, writer, "encounter", cancellationToken); // 230
			Write(name.SentElement, writer, "sent", cancellationToken); // 240
			Write(name.ReceivedElement, writer, "received", cancellationToken); // 250
			Write(name.Recipient, writer, "recipient", cancellationToken); // 260
			Write(name.Sender, writer, "sender", cancellationToken); // 270
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 280
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 290
			Write(name.Payload, writer, "payload", cancellationToken); // 300
			Write(name.Note, writer, "note", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Write(CommunicationRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CommunicationRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.Replaces, writer, "replaces", cancellationToken); // 110
			Write(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 140
			Write(name.Category, writer, "category", cancellationToken); // 150
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 160
			Write(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 170
			Write(name.Medium, writer, "medium", cancellationToken); // 180
			Write(name.Subject, writer, "subject", cancellationToken); // 190
			Write(name.About, writer, "about", cancellationToken); // 200
			Write(name.Encounter, writer, "encounter", cancellationToken); // 210
			Write(name.Payload, writer, "payload", cancellationToken); // 220
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 230
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 230
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 240
			Write(name.Requester, writer, "requester", cancellationToken); // 250
			Write(name.Recipient, writer, "recipient", cancellationToken); // 260
			Write(name.Sender, writer, "sender", cancellationToken); // 270
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 280
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 290
			Write(name.Note, writer, "note", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Write(CompartmentDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CompartmentDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 130
			Write(name.DateElement, writer, "date", cancellationToken); // 140
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 150
			Write(name.Contact, writer, "contact", cancellationToken); // 160
			Write(name.Description, writer, "description", cancellationToken); // 170
			Write(name.UseContext, writer, "useContext", cancellationToken); // 180
			Write(name.Purpose, writer, "purpose", cancellationToken); // 190
			Write(name.CodeElement, writer, "code", cancellationToken); // 200
			Write(name.SearchElement, writer, "search", cancellationToken); // 210
			Write(name.Resource, writer, "resource", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Write(Composition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Composition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.Category, writer, "category", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.Encounter, writer, "encounter", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.Author, writer, "author", cancellationToken); // 160
			Write(name.TitleElement, writer, "title", cancellationToken); // 170
			Write(name.ConfidentialityElement, writer, "confidentiality", cancellationToken); // 180
			Write(name.Attester, writer, "attester", cancellationToken); // 190
			Write(name.Custodian, writer, "custodian", cancellationToken); // 200
			Write(name.RelatesTo, writer, "relatesTo", cancellationToken); // 210
			Write(name.Event, writer, "event", cancellationToken); // 220
			Write(name.Section, writer, "section", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Write(ConceptMap name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ConceptMap", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Purpose, writer, "purpose", cancellationToken); // 220
			Write(name.Copyright, writer, "copyright", cancellationToken); // 230
			Write(name.Source as Hl7.Fhir.Model.FhirUri, writer, "sourceUri", cancellationToken); // 240
			Write(name.Source as Hl7.Fhir.Model.Canonical, writer, "sourceCanonical", cancellationToken); // 240
			Write(name.Target as Hl7.Fhir.Model.FhirUri, writer, "targetUri", cancellationToken); // 250
			Write(name.Target as Hl7.Fhir.Model.Canonical, writer, "targetCanonical", cancellationToken); // 250
			Write(name.Group, writer, "group", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Write(Condition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Condition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ClinicalStatus, writer, "clinicalStatus", cancellationToken); // 100
			Write(name.VerificationStatus, writer, "verificationStatus", cancellationToken); // 110
			Write(name.Category, writer, "category", cancellationToken); // 120
			Write(name.Severity, writer, "severity", cancellationToken); // 130
			Write(name.Code, writer, "code", cancellationToken); // 140
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 150
			Write(name.Subject, writer, "subject", cancellationToken); // 160
			Write(name.Encounter, writer, "encounter", cancellationToken); // 170
			Write(name.Onset as Hl7.Fhir.Model.FhirDateTime, writer, "onsetDateTime", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.Age, writer, "onsetAge", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.Period, writer, "onsetPeriod", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.Range, writer, "onsetRange", cancellationToken); // 180
			Write(name.Onset as Hl7.Fhir.Model.FhirString, writer, "onsetString", cancellationToken); // 180
			Write(name.Abatement as Hl7.Fhir.Model.FhirDateTime, writer, "abatementDateTime", cancellationToken); // 190
			Write(name.Abatement as Hl7.Fhir.Model.Age, writer, "abatementAge", cancellationToken); // 190
			Write(name.Abatement as Hl7.Fhir.Model.Period, writer, "abatementPeriod", cancellationToken); // 190
			Write(name.Abatement as Hl7.Fhir.Model.Range, writer, "abatementRange", cancellationToken); // 190
			Write(name.Abatement as Hl7.Fhir.Model.FhirString, writer, "abatementString", cancellationToken); // 190
			Write(name.RecordedDateElement, writer, "recordedDate", cancellationToken); // 200
			Write(name.Recorder, writer, "recorder", cancellationToken); // 210
			Write(name.Asserter, writer, "asserter", cancellationToken); // 220
			Write(name.Stage, writer, "stage", cancellationToken); // 230
			Write(name.Evidence, writer, "evidence", cancellationToken); // 240
			Write(name.Note, writer, "note", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(Consent name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Consent", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Scope, writer, "scope", cancellationToken); // 110
			Write(name.Category, writer, "category", cancellationToken); // 120
			Write(name.Patient, writer, "patient", cancellationToken); // 130
			Write(name.DateTimeElement, writer, "dateTime", cancellationToken); // 140
			Write(name.Performer, writer, "performer", cancellationToken); // 150
			Write(name.Organization, writer, "organization", cancellationToken); // 160
			Write(name.Source as Hl7.Fhir.Model.Attachment, writer, "sourceAttachment", cancellationToken); // 170
			Write(name.Source as Hl7.Fhir.Model.ResourceReference, writer, "sourceReference", cancellationToken); // 170
			Write(name.Policy, writer, "policy", cancellationToken); // 180
			Write(name.PolicyRule, writer, "policyRule", cancellationToken); // 190
			Write(name.Verification, writer, "verification", cancellationToken); // 200
			Write(name.Provision, writer, "provision", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(Contract name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Contract", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.UrlElement, writer, "url", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.LegalState, writer, "legalState", cancellationToken); // 130
			Write(name.InstantiatesCanonical, writer, "instantiatesCanonical", cancellationToken); // 140
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 150
			Write(name.ContentDerivative, writer, "contentDerivative", cancellationToken); // 160
			Write(name.IssuedElement, writer, "issued", cancellationToken); // 170
			Write(name.Applies, writer, "applies", cancellationToken); // 180
			Write(name.ExpirationType, writer, "expirationType", cancellationToken); // 190
			Write(name.Subject, writer, "subject", cancellationToken); // 200
			Write(name.Authority, writer, "authority", cancellationToken); // 210
			Write(name.Domain, writer, "domain", cancellationToken); // 220
			Write(name.Site, writer, "site", cancellationToken); // 230
			Write(name.NameElement, writer, "name", cancellationToken); // 240
			Write(name.TitleElement, writer, "title", cancellationToken); // 250
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 260
			Write(name.AliasElement, writer, "alias", cancellationToken); // 270
			Write(name.Author, writer, "author", cancellationToken); // 280
			Write(name.Scope, writer, "scope", cancellationToken); // 290
			Write(name.Topic as Hl7.Fhir.Model.CodeableConcept, writer, "topicCodeableConcept", cancellationToken); // 300
			Write(name.Topic as Hl7.Fhir.Model.ResourceReference, writer, "topicReference", cancellationToken); // 300
			Write(name.Type, writer, "type", cancellationToken); // 310
			Write(name.SubType, writer, "subType", cancellationToken); // 320
			Write(name.ContentDefinition, writer, "contentDefinition", cancellationToken); // 330
			Write(name.Term, writer, "term", cancellationToken); // 340
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 350
			Write(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 360
			Write(name.Signer, writer, "signer", cancellationToken); // 370
			Write(name.Friendly, writer, "friendly", cancellationToken); // 380
			Write(name.Legal, writer, "legal", cancellationToken); // 390
			Write(name.Rule, writer, "rule", cancellationToken); // 400
			Write(name.LegallyBinding as Hl7.Fhir.Model.Attachment, writer, "legallyBindingAttachment", cancellationToken); // 410
			Write(name.LegallyBinding as Hl7.Fhir.Model.ResourceReference, writer, "legallyBindingReference", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Write(Coverage name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Coverage", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.PolicyHolder, writer, "policyHolder", cancellationToken); // 120
			Write(name.Subscriber, writer, "subscriber", cancellationToken); // 130
			Write(name.SubscriberIdElement, writer, "subscriberId", cancellationToken); // 140
			Write(name.Beneficiary, writer, "beneficiary", cancellationToken); // 150
			Write(name.DependentElement, writer, "dependent", cancellationToken); // 160
			Write(name.Relationship, writer, "relationship", cancellationToken); // 170
			Write(name.Period, writer, "period", cancellationToken); // 180
			Write(name.Payor, writer, "payor", cancellationToken); // 190
			Write(name.Class, writer, "class", cancellationToken); // 200
			Write(name.OrderElement, writer, "order", cancellationToken); // 210
			Write(name.NetworkElement, writer, "network", cancellationToken); // 220
			Write(name.CostToBeneficiary, writer, "costToBeneficiary", cancellationToken); // 230
			Write(name.SubrogationElement, writer, "subrogation", cancellationToken); // 240
			Write(name.Contract, writer, "contract", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(CoverageEligibilityRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CoverageEligibilityRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Priority, writer, "priority", cancellationToken); // 110
			Write(name.PurposeElement, writer, "purpose", cancellationToken); // 120
			Write(name.Patient, writer, "patient", cancellationToken); // 130
			Write(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 140
			Write(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 140
			Write(name.CreatedElement, writer, "created", cancellationToken); // 150
			Write(name.Enterer, writer, "enterer", cancellationToken); // 160
			Write(name.Provider, writer, "provider", cancellationToken); // 170
			Write(name.Insurer, writer, "insurer", cancellationToken); // 180
			Write(name.Facility, writer, "facility", cancellationToken); // 190
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 200
			Write(name.Insurance, writer, "insurance", cancellationToken); // 210
			Write(name.Item, writer, "item", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Write(CoverageEligibilityResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("CoverageEligibilityResponse", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.PurposeElement, writer, "purpose", cancellationToken); // 110
			Write(name.Patient, writer, "patient", cancellationToken); // 120
			Write(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 130
			Write(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 130
			Write(name.CreatedElement, writer, "created", cancellationToken); // 140
			Write(name.Requestor, writer, "requestor", cancellationToken); // 150
			Write(name.Request, writer, "request", cancellationToken); // 160
			Write(name.OutcomeElement, writer, "outcome", cancellationToken); // 170
			Write(name.DispositionElement, writer, "disposition", cancellationToken); // 180
			Write(name.Insurer, writer, "insurer", cancellationToken); // 190
			Write(name.Insurance, writer, "insurance", cancellationToken); // 200
			Write(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 210
			Write(name.Form, writer, "form", cancellationToken); // 220
			Write(name.Error, writer, "error", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Write(DetectedIssue name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DetectedIssue", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Code, writer, "code", cancellationToken); // 110
			Write(name.SeverityElement, writer, "severity", cancellationToken); // 120
			Write(name.Patient, writer, "patient", cancellationToken); // 130
			Write(name.Identified as Hl7.Fhir.Model.FhirDateTime, writer, "identifiedDateTime", cancellationToken); // 140
			Write(name.Identified as Hl7.Fhir.Model.Period, writer, "identifiedPeriod", cancellationToken); // 140
			Write(name.Author, writer, "author", cancellationToken); // 150
			Write(name.Implicated, writer, "implicated", cancellationToken); // 160
			Write(name.Evidence, writer, "evidence", cancellationToken); // 170
			Write(name.DetailElement, writer, "detail", cancellationToken); // 180
			Write(name.ReferenceElement, writer, "reference", cancellationToken); // 190
			Write(name.Mitigation, writer, "mitigation", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(Device name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Device", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Definition, writer, "definition", cancellationToken); // 100
			Write(name.UdiCarrier, writer, "udiCarrier", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 130
			Write(name.DistinctIdentifierElement, writer, "distinctIdentifier", cancellationToken); // 140
			Write(name.ManufacturerElement, writer, "manufacturer", cancellationToken); // 150
			Write(name.ManufactureDateElement, writer, "manufactureDate", cancellationToken); // 160
			Write(name.ExpirationDateElement, writer, "expirationDate", cancellationToken); // 170
			Write(name.LotNumberElement, writer, "lotNumber", cancellationToken); // 180
			Write(name.SerialNumberElement, writer, "serialNumber", cancellationToken); // 190
			Write(name.DeviceName, writer, "deviceName", cancellationToken); // 200
			Write(name.ModelNumberElement, writer, "modelNumber", cancellationToken); // 210
			Write(name.PartNumberElement, writer, "partNumber", cancellationToken); // 220
			Write(name.Type, writer, "type", cancellationToken); // 230
			Write(name.Specialization, writer, "specialization", cancellationToken); // 240
			Write(name.Version, writer, "version", cancellationToken); // 250
			Write(name.Property, writer, "property", cancellationToken); // 260
			Write(name.Patient, writer, "patient", cancellationToken); // 270
			Write(name.Owner, writer, "owner", cancellationToken); // 280
			Write(name.Contact, writer, "contact", cancellationToken); // 290
			Write(name.Location, writer, "location", cancellationToken); // 300
			Write(name.UrlElement, writer, "url", cancellationToken); // 310
			Write(name.Note, writer, "note", cancellationToken); // 320
			Write(name.Safety, writer, "safety", cancellationToken); // 330
			Write(name.Parent, writer, "parent", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Write(DeviceDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.UdiDeviceIdentifier, writer, "udiDeviceIdentifier", cancellationToken); // 100
			Write(name.Manufacturer as Hl7.Fhir.Model.FhirString, writer, "manufacturerString", cancellationToken); // 110
			Write(name.Manufacturer as Hl7.Fhir.Model.ResourceReference, writer, "manufacturerReference", cancellationToken); // 110
			Write(name.DeviceName, writer, "deviceName", cancellationToken); // 120
			Write(name.ModelNumberElement, writer, "modelNumber", cancellationToken); // 130
			Write(name.Type, writer, "type", cancellationToken); // 140
			Write(name.Specialization, writer, "specialization", cancellationToken); // 150
			Write(name.VersionElement, writer, "version", cancellationToken); // 160
			Write(name.Safety, writer, "safety", cancellationToken); // 170
			Write(name.ShelfLifeStorage, writer, "shelfLifeStorage", cancellationToken); // 180
			Write(name.PhysicalCharacteristics, writer, "physicalCharacteristics", cancellationToken); // 190
			Write(name.LanguageCode, writer, "languageCode", cancellationToken); // 200
			Write(name.Capability, writer, "capability", cancellationToken); // 210
			Write(name.Property, writer, "property", cancellationToken); // 220
			Write(name.Owner, writer, "owner", cancellationToken); // 230
			Write(name.Contact, writer, "contact", cancellationToken); // 240
			Write(name.UrlElement, writer, "url", cancellationToken); // 250
			Write(name.OnlineInformationElement, writer, "onlineInformation", cancellationToken); // 260
			Write(name.Note, writer, "note", cancellationToken); // 270
			Write(name.Quantity, writer, "quantity", cancellationToken); // 280
			Write(name.ParentDevice, writer, "parentDevice", cancellationToken); // 290
			Write(name.Material, writer, "material", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Write(DeviceMetric name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceMetric", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Type, writer, "type", cancellationToken); // 100
			Write(name.Unit, writer, "unit", cancellationToken); // 110
			Write(name.Source, writer, "source", cancellationToken); // 120
			Write(name.Parent, writer, "parent", cancellationToken); // 130
			Write(name.OperationalStatusElement, writer, "operationalStatus", cancellationToken); // 140
			Write(name.ColorElement, writer, "color", cancellationToken); // 150
			Write(name.CategoryElement, writer, "category", cancellationToken); // 160
			Write(name.MeasurementPeriod, writer, "measurementPeriod", cancellationToken); // 170
			Write(name.Calibration, writer, "calibration", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Write(DeviceRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.PriorRequest, writer, "priorRequest", cancellationToken); // 130
			Write(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.IntentElement, writer, "intent", cancellationToken); // 160
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 170
			Write(name.Code as Hl7.Fhir.Model.ResourceReference, writer, "codeReference", cancellationToken); // 180
			Write(name.Code as Hl7.Fhir.Model.CodeableConcept, writer, "codeCodeableConcept", cancellationToken); // 180
			Write(name.Parameter, writer, "parameter", cancellationToken); // 190
			Write(name.Subject, writer, "subject", cancellationToken); // 200
			Write(name.Encounter, writer, "encounter", cancellationToken); // 210
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 220
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 220
			Write(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 220
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 230
			Write(name.Requester, writer, "requester", cancellationToken); // 240
			Write(name.PerformerType, writer, "performerType", cancellationToken); // 250
			Write(name.Performer, writer, "performer", cancellationToken); // 260
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 270
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 280
			Write(name.Insurance, writer, "insurance", cancellationToken); // 290
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 300
			Write(name.Note, writer, "note", cancellationToken); // 310
			Write(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(DeviceUseStatement name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DeviceUseStatement", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.Subject, writer, "subject", cancellationToken); // 120
			Write(name.DerivedFrom, writer, "derivedFrom", cancellationToken); // 130
			Write(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 140
			Write(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 140
			Write(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 140
			Write(name.RecordedOnElement, writer, "recordedOn", cancellationToken); // 150
			Write(name.Source, writer, "source", cancellationToken); // 160
			Write(name.Device, writer, "device", cancellationToken); // 170
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 180
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 190
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 200
			Write(name.Note, writer, "note", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(DiagnosticReport name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DiagnosticReport", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.Category, writer, "category", cancellationToken); // 120
			Write(name.Code, writer, "code", cancellationToken); // 130
			Write(name.Subject, writer, "subject", cancellationToken); // 140
			Write(name.Encounter, writer, "encounter", cancellationToken); // 150
			Write(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 160
			Write(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 160
			Write(name.IssuedElement, writer, "issued", cancellationToken); // 170
			Write(name.Performer, writer, "performer", cancellationToken); // 180
			Write(name.ResultsInterpreter, writer, "resultsInterpreter", cancellationToken); // 190
			Write(name.Specimen, writer, "specimen", cancellationToken); // 200
			Write(name.Result, writer, "result", cancellationToken); // 210
			Write(name.ImagingStudy, writer, "imagingStudy", cancellationToken); // 220
			Write(name.Media, writer, "media", cancellationToken); // 230
			Write(name.ConclusionElement, writer, "conclusion", cancellationToken); // 240
			Write(name.ConclusionCode, writer, "conclusionCode", cancellationToken); // 250
			Write(name.PresentedForm, writer, "presentedForm", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Write(DocumentManifest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DocumentManifest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.MasterIdentifier, writer, "masterIdentifier", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.Type, writer, "type", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.CreatedElement, writer, "created", cancellationToken); // 140
			Write(name.Author, writer, "author", cancellationToken); // 150
			Write(name.Recipient, writer, "recipient", cancellationToken); // 160
			Write(name.SourceElement, writer, "source", cancellationToken); // 170
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 180
			Write(name.Content, writer, "content", cancellationToken); // 190
			Write(name.Related, writer, "related", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(DocumentReference name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("DocumentReference", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.MasterIdentifier, writer, "masterIdentifier", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.DocStatusElement, writer, "docStatus", cancellationToken); // 120
			Write(name.Type, writer, "type", cancellationToken); // 130
			Write(name.Category, writer, "category", cancellationToken); // 140
			Write(name.Subject, writer, "subject", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.Author, writer, "author", cancellationToken); // 170
			Write(name.Authenticator, writer, "authenticator", cancellationToken); // 180
			Write(name.Custodian, writer, "custodian", cancellationToken); // 190
			Write(name.RelatesTo, writer, "relatesTo", cancellationToken); // 200
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 210
			Write(name.SecurityLabel, writer, "securityLabel", cancellationToken); // 220
			Write(name.Content, writer, "content", cancellationToken); // 230
			Write(name.Context, writer, "context", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(EffectEvidenceSynthesis name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EffectEvidenceSynthesis", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Description, writer, "description", cancellationToken); // 180
			Write(name.Note, writer, "note", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Copyright, writer, "copyright", cancellationToken); // 220
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 230
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 240
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 250
			Write(name.Topic, writer, "topic", cancellationToken); // 260
			Write(name.Author, writer, "author", cancellationToken); // 270
			Write(name.Editor, writer, "editor", cancellationToken); // 280
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 290
			Write(name.Endorser, writer, "endorser", cancellationToken); // 300
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 310
			Write(name.SynthesisType, writer, "synthesisType", cancellationToken); // 320
			Write(name.StudyType, writer, "studyType", cancellationToken); // 330
			Write(name.Population, writer, "population", cancellationToken); // 340
			Write(name.Exposure, writer, "exposure", cancellationToken); // 350
			Write(name.ExposureAlternative, writer, "exposureAlternative", cancellationToken); // 360
			Write(name.Outcome, writer, "outcome", cancellationToken); // 370
			Write(name.SampleSize, writer, "sampleSize", cancellationToken); // 380
			Write(name.ResultsByExposure, writer, "resultsByExposure", cancellationToken); // 390
			Write(name.EffectEstimate, writer, "effectEstimate", cancellationToken); // 400
			Write(name.Certainty, writer, "certainty", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Write(Encounter name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Encounter", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.StatusHistory, writer, "statusHistory", cancellationToken); // 110
			Write(name.Class, writer, "class", cancellationToken); // 120
			Write(name.ClassHistory, writer, "classHistory", cancellationToken); // 130
			Write(name.Type, writer, "type", cancellationToken); // 140
			Write(name.ServiceType, writer, "serviceType", cancellationToken); // 150
			Write(name.Priority, writer, "priority", cancellationToken); // 160
			Write(name.Subject, writer, "subject", cancellationToken); // 170
			Write(name.EpisodeOfCare, writer, "episodeOfCare", cancellationToken); // 180
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 190
			Write(name.Participant, writer, "participant", cancellationToken); // 200
			Write(name.Appointment, writer, "appointment", cancellationToken); // 210
			Write(name.Period, writer, "period", cancellationToken); // 220
			Write(name.Length, writer, "length", cancellationToken); // 230
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 240
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 250
			Write(name.Diagnosis, writer, "diagnosis", cancellationToken); // 260
			Write(name.Account, writer, "account", cancellationToken); // 270
			Write(name.Hospitalization, writer, "hospitalization", cancellationToken); // 280
			Write(name.Location, writer, "location", cancellationToken); // 290
			Write(name.ServiceProvider, writer, "serviceProvider", cancellationToken); // 300
			Write(name.PartOf, writer, "partOf", cancellationToken); // 310
			writer.WriteEndElement();
		}

		public static void Write(Endpoint name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Endpoint", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.ConnectionType, writer, "connectionType", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 130
			Write(name.Contact, writer, "contact", cancellationToken); // 140
			Write(name.Period, writer, "period", cancellationToken); // 150
			Write(name.PayloadType, writer, "payloadType", cancellationToken); // 160
			Write(name.PayloadMimeTypeElement, writer, "payloadMimeType", cancellationToken); // 170
			Write(name.AddressElement, writer, "address", cancellationToken); // 180
			Write(name.HeaderElement, writer, "header", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(EnrollmentRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EnrollmentRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.CreatedElement, writer, "created", cancellationToken); // 110
			Write(name.Insurer, writer, "insurer", cancellationToken); // 120
			Write(name.Provider, writer, "provider", cancellationToken); // 130
			Write(name.Candidate, writer, "candidate", cancellationToken); // 140
			Write(name.Coverage, writer, "coverage", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(EnrollmentResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EnrollmentResponse", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Request, writer, "request", cancellationToken); // 110
			Write(name.OutcomeElement, writer, "outcome", cancellationToken); // 120
			Write(name.DispositionElement, writer, "disposition", cancellationToken); // 130
			Write(name.CreatedElement, writer, "created", cancellationToken); // 140
			Write(name.Organization, writer, "organization", cancellationToken); // 150
			Write(name.RequestProvider, writer, "requestProvider", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(EpisodeOfCare name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EpisodeOfCare", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.StatusHistory, writer, "statusHistory", cancellationToken); // 110
			Write(name.Type, writer, "type", cancellationToken); // 120
			Write(name.Diagnosis, writer, "diagnosis", cancellationToken); // 130
			Write(name.Patient, writer, "patient", cancellationToken); // 140
			Write(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 150
			Write(name.Period, writer, "period", cancellationToken); // 160
			Write(name.ReferralRequest, writer, "referralRequest", cancellationToken); // 170
			Write(name.CareManager, writer, "careManager", cancellationToken); // 180
			Write(name.Team, writer, "team", cancellationToken); // 190
			Write(name.Account, writer, "account", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(EventDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EventDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 170
			Write(name.DateElement, writer, "date", cancellationToken); // 180
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Write(name.Contact, writer, "contact", cancellationToken); // 200
			Write(name.Description, writer, "description", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Purpose, writer, "purpose", cancellationToken); // 240
			Write(name.UsageElement, writer, "usage", cancellationToken); // 250
			Write(name.Copyright, writer, "copyright", cancellationToken); // 260
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 270
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 280
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 290
			Write(name.Topic, writer, "topic", cancellationToken); // 300
			Write(name.Author, writer, "author", cancellationToken); // 310
			Write(name.Editor, writer, "editor", cancellationToken); // 320
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 330
			Write(name.Endorser, writer, "endorser", cancellationToken); // 340
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 350
			Write(name.Trigger, writer, "trigger", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Write(Evidence name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Evidence", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Write(name.StatusElement, writer, "status", cancellationToken); // 160
			Write(name.DateElement, writer, "date", cancellationToken); // 170
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 180
			Write(name.Contact, writer, "contact", cancellationToken); // 190
			Write(name.Description, writer, "description", cancellationToken); // 200
			Write(name.Note, writer, "note", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Copyright, writer, "copyright", cancellationToken); // 240
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 250
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 260
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 270
			Write(name.Topic, writer, "topic", cancellationToken); // 280
			Write(name.Author, writer, "author", cancellationToken); // 290
			Write(name.Editor, writer, "editor", cancellationToken); // 300
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 310
			Write(name.Endorser, writer, "endorser", cancellationToken); // 320
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 330
			Write(name.ExposureBackground, writer, "exposureBackground", cancellationToken); // 340
			Write(name.ExposureVariant, writer, "exposureVariant", cancellationToken); // 350
			Write(name.Outcome, writer, "outcome", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Write(EvidenceVariable name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("EvidenceVariable", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Write(name.StatusElement, writer, "status", cancellationToken); // 160
			Write(name.DateElement, writer, "date", cancellationToken); // 170
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 180
			Write(name.Contact, writer, "contact", cancellationToken); // 190
			Write(name.Description, writer, "description", cancellationToken); // 200
			Write(name.Note, writer, "note", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Copyright, writer, "copyright", cancellationToken); // 240
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 250
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 260
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 270
			Write(name.Topic, writer, "topic", cancellationToken); // 280
			Write(name.Author, writer, "author", cancellationToken); // 290
			Write(name.Editor, writer, "editor", cancellationToken); // 300
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 310
			Write(name.Endorser, writer, "endorser", cancellationToken); // 320
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 330
			Write(name.TypeElement, writer, "type", cancellationToken); // 340
			Write(name.Characteristic, writer, "characteristic", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Write(ExampleScenario name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ExampleScenario", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.UseContext, writer, "useContext", cancellationToken); // 180
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 190
			Write(name.Copyright, writer, "copyright", cancellationToken); // 200
			Write(name.Purpose, writer, "purpose", cancellationToken); // 210
			Write(name.Actor, writer, "actor", cancellationToken); // 220
			Write(name.Instance, writer, "instance", cancellationToken); // 230
			Write(name.Process, writer, "process", cancellationToken); // 240
			Write(name.WorkflowElement, writer, "workflow", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(ExplanationOfBenefit name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ExplanationOfBenefit", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.SubType, writer, "subType", cancellationToken); // 120
			Write(name.UseElement, writer, "use", cancellationToken); // 130
			Write(name.Patient, writer, "patient", cancellationToken); // 140
			Write(name.BillablePeriod, writer, "billablePeriod", cancellationToken); // 150
			Write(name.CreatedElement, writer, "created", cancellationToken); // 160
			Write(name.Enterer, writer, "enterer", cancellationToken); // 170
			Write(name.Insurer, writer, "insurer", cancellationToken); // 180
			Write(name.Provider, writer, "provider", cancellationToken); // 190
			Write(name.Priority, writer, "priority", cancellationToken); // 200
			Write(name.FundsReserveRequested, writer, "fundsReserveRequested", cancellationToken); // 210
			Write(name.FundsReserve, writer, "fundsReserve", cancellationToken); // 220
			Write(name.Related, writer, "related", cancellationToken); // 230
			Write(name.Prescription, writer, "prescription", cancellationToken); // 240
			Write(name.OriginalPrescription, writer, "originalPrescription", cancellationToken); // 250
			Write(name.Payee, writer, "payee", cancellationToken); // 260
			Write(name.Referral, writer, "referral", cancellationToken); // 270
			Write(name.Facility, writer, "facility", cancellationToken); // 280
			Write(name.Claim, writer, "claim", cancellationToken); // 290
			Write(name.ClaimResponse, writer, "claimResponse", cancellationToken); // 300
			Write(name.OutcomeElement, writer, "outcome", cancellationToken); // 310
			Write(name.DispositionElement, writer, "disposition", cancellationToken); // 320
			Write(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 330
			Write(name.PreAuthRefPeriod, writer, "preAuthRefPeriod", cancellationToken); // 340
			Write(name.CareTeam, writer, "careTeam", cancellationToken); // 350
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 360
			Write(name.Diagnosis, writer, "diagnosis", cancellationToken); // 370
			Write(name.Procedure, writer, "procedure", cancellationToken); // 380
			Write(name.PrecedenceElement, writer, "precedence", cancellationToken); // 390
			Write(name.Insurance, writer, "insurance", cancellationToken); // 400
			Write(name.Accident, writer, "accident", cancellationToken); // 410
			Write(name.Item, writer, "item", cancellationToken); // 420
			Write(name.AddItem, writer, "addItem", cancellationToken); // 430
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 440
			Write(name.Total, writer, "total", cancellationToken); // 450
			Write(name.Payment, writer, "payment", cancellationToken); // 460
			Write(name.FormCode, writer, "formCode", cancellationToken); // 470
			Write(name.Form, writer, "form", cancellationToken); // 480
			Write(name.ProcessNote, writer, "processNote", cancellationToken); // 490
			Write(name.BenefitPeriod, writer, "benefitPeriod", cancellationToken); // 500
			Write(name.BenefitBalance, writer, "benefitBalance", cancellationToken); // 510
			writer.WriteEndElement();
		}

		public static void Write(FamilyMemberHistory name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("FamilyMemberHistory", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.DataAbsentReason, writer, "dataAbsentReason", cancellationToken); // 130
			Write(name.Patient, writer, "patient", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.NameElement, writer, "name", cancellationToken); // 160
			Write(name.Relationship, writer, "relationship", cancellationToken); // 170
			Write(name.Sex, writer, "sex", cancellationToken); // 180
			Write(name.Born as Hl7.Fhir.Model.Period, writer, "bornPeriod", cancellationToken); // 190
			Write(name.Born as Hl7.Fhir.Model.Date, writer, "bornDate", cancellationToken); // 190
			Write(name.Born as Hl7.Fhir.Model.FhirString, writer, "bornString", cancellationToken); // 190
			Write(name.Age as Hl7.Fhir.Model.Age, writer, "ageAge", cancellationToken); // 200
			Write(name.Age as Hl7.Fhir.Model.Range, writer, "ageRange", cancellationToken); // 200
			Write(name.Age as Hl7.Fhir.Model.FhirString, writer, "ageString", cancellationToken); // 200
			Write(name.EstimatedAgeElement, writer, "estimatedAge", cancellationToken); // 210
			Write(name.Deceased as Hl7.Fhir.Model.FhirBoolean, writer, "deceasedBoolean", cancellationToken); // 220
			Write(name.Deceased as Hl7.Fhir.Model.Age, writer, "deceasedAge", cancellationToken); // 220
			Write(name.Deceased as Hl7.Fhir.Model.Range, writer, "deceasedRange", cancellationToken); // 220
			Write(name.Deceased as Hl7.Fhir.Model.Date, writer, "deceasedDate", cancellationToken); // 220
			Write(name.Deceased as Hl7.Fhir.Model.FhirString, writer, "deceasedString", cancellationToken); // 220
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 230
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 240
			Write(name.Note, writer, "note", cancellationToken); // 250
			Write(name.Condition, writer, "condition", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Write(Flag name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Flag", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Category, writer, "category", cancellationToken); // 110
			Write(name.Code, writer, "code", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.Period, writer, "period", cancellationToken); // 140
			Write(name.Encounter, writer, "encounter", cancellationToken); // 150
			Write(name.Author, writer, "author", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(Goal name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Goal", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.LifecycleStatusElement, writer, "lifecycleStatus", cancellationToken); // 100
			Write(name.AchievementStatus, writer, "achievementStatus", cancellationToken); // 110
			Write(name.Category, writer, "category", cancellationToken); // 120
			Write(name.Priority, writer, "priority", cancellationToken); // 130
			Write(name.Description, writer, "description", cancellationToken); // 140
			Write(name.Subject, writer, "subject", cancellationToken); // 150
			Write(name.Start as Hl7.Fhir.Model.Date, writer, "startDate", cancellationToken); // 160
			Write(name.Start as Hl7.Fhir.Model.CodeableConcept, writer, "startCodeableConcept", cancellationToken); // 160
			Write(name.Target, writer, "target", cancellationToken); // 170
			Write(name.StatusDateElement, writer, "statusDate", cancellationToken); // 180
			Write(name.StatusReasonElement, writer, "statusReason", cancellationToken); // 190
			Write(name.ExpressedBy, writer, "expressedBy", cancellationToken); // 200
			Write(name.Addresses, writer, "addresses", cancellationToken); // 210
			Write(name.Note, writer, "note", cancellationToken); // 220
			Write(name.OutcomeCode, writer, "outcomeCode", cancellationToken); // 230
			Write(name.OutcomeReference, writer, "outcomeReference", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(GraphDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("GraphDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 130
			Write(name.DateElement, writer, "date", cancellationToken); // 140
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 150
			Write(name.Contact, writer, "contact", cancellationToken); // 160
			Write(name.Description, writer, "description", cancellationToken); // 170
			Write(name.UseContext, writer, "useContext", cancellationToken); // 180
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 190
			Write(name.Purpose, writer, "purpose", cancellationToken); // 200
			Write(name.StartElement, writer, "start", cancellationToken); // 210
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 220
			Write(name.Link, writer, "link", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Write(Group name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Group", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.TypeElement, writer, "type", cancellationToken); // 110
			Write(name.ActualElement, writer, "actual", cancellationToken); // 120
			Write(name.Code, writer, "code", cancellationToken); // 130
			Write(name.NameElement, writer, "name", cancellationToken); // 140
			Write(name.QuantityElement, writer, "quantity", cancellationToken); // 150
			Write(name.ManagingEntity, writer, "managingEntity", cancellationToken); // 160
			Write(name.Characteristic, writer, "characteristic", cancellationToken); // 170
			Write(name.Member, writer, "member", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Write(GuidanceResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("GuidanceResponse", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.RequestIdentifier, writer, "requestIdentifier", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.Module as Hl7.Fhir.Model.FhirUri, writer, "moduleUri", cancellationToken); // 110
			Write(name.Module as Hl7.Fhir.Model.Canonical, writer, "moduleCanonical", cancellationToken); // 110
			Write(name.Module as Hl7.Fhir.Model.CodeableConcept, writer, "moduleCodeableConcept", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.Encounter, writer, "encounter", cancellationToken); // 140
			Write(name.OccurrenceDateTimeElement, writer, "occurrenceDateTime", cancellationToken); // 150
			Write(name.Performer, writer, "performer", cancellationToken); // 160
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 170
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 180
			Write(name.Note, writer, "note", cancellationToken); // 190
			Write(name.EvaluationMessage, writer, "evaluationMessage", cancellationToken); // 200
			Write(name.OutputParameters, writer, "outputParameters", cancellationToken); // 210
			Write(name.Result, writer, "result", cancellationToken); // 220
			Write(name.DataRequirement, writer, "dataRequirement", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Write(HealthcareService name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("HealthcareService", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.ProvidedBy, writer, "providedBy", cancellationToken); // 110
			Write(name.Category, writer, "category", cancellationToken); // 120
			Write(name.Type, writer, "type", cancellationToken); // 130
			Write(name.Specialty, writer, "specialty", cancellationToken); // 140
			Write(name.Location, writer, "location", cancellationToken); // 150
			Write(name.NameElement, writer, "name", cancellationToken); // 160
			Write(name.CommentElement, writer, "comment", cancellationToken); // 170
			Write(name.ExtraDetails, writer, "extraDetails", cancellationToken); // 180
			Write(name.Photo, writer, "photo", cancellationToken); // 190
			Write(name.Telecom, writer, "telecom", cancellationToken); // 200
			Write(name.CoverageArea, writer, "coverageArea", cancellationToken); // 210
			Write(name.ServiceProvisionCode, writer, "serviceProvisionCode", cancellationToken); // 220
			Write(name.Eligibility, writer, "eligibility", cancellationToken); // 230
			Write(name.Program, writer, "program", cancellationToken); // 240
			Write(name.Characteristic, writer, "characteristic", cancellationToken); // 250
			Write(name.Communication, writer, "communication", cancellationToken); // 260
			Write(name.ReferralMethod, writer, "referralMethod", cancellationToken); // 270
			Write(name.AppointmentRequiredElement, writer, "appointmentRequired", cancellationToken); // 280
			Write(name.AvailableTime, writer, "availableTime", cancellationToken); // 290
			Write(name.NotAvailable, writer, "notAvailable", cancellationToken); // 300
			Write(name.AvailabilityExceptionsElement, writer, "availabilityExceptions", cancellationToken); // 310
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(ImagingStudy name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImagingStudy", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Modality, writer, "modality", cancellationToken); // 110
			Write(name.Subject, writer, "subject", cancellationToken); // 120
			Write(name.Encounter, writer, "encounter", cancellationToken); // 130
			Write(name.StartedElement, writer, "started", cancellationToken); // 140
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 150
			Write(name.Referrer, writer, "referrer", cancellationToken); // 160
			Write(name.Interpreter, writer, "interpreter", cancellationToken); // 170
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 180
			Write(name.NumberOfSeriesElement, writer, "numberOfSeries", cancellationToken); // 190
			Write(name.NumberOfInstancesElement, writer, "numberOfInstances", cancellationToken); // 200
			Write(name.ProcedureReference, writer, "procedureReference", cancellationToken); // 210
			Write(name.ProcedureCode, writer, "procedureCode", cancellationToken); // 220
			Write(name.Location, writer, "location", cancellationToken); // 230
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 240
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 250
			Write(name.Note, writer, "note", cancellationToken); // 260
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 270
			Write(name.Series, writer, "series", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Write(Immunization name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Immunization", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 110
			Write(name.VaccineCode, writer, "vaccineCode", cancellationToken); // 120
			Write(name.Patient, writer, "patient", cancellationToken); // 130
			Write(name.Encounter, writer, "encounter", cancellationToken); // 140
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 150
			Write(name.Occurrence as Hl7.Fhir.Model.FhirString, writer, "occurrenceString", cancellationToken); // 150
			Write(name.RecordedElement, writer, "recorded", cancellationToken); // 160
			Write(name.PrimarySourceElement, writer, "primarySource", cancellationToken); // 170
			Write(name.ReportOrigin, writer, "reportOrigin", cancellationToken); // 180
			Write(name.Location, writer, "location", cancellationToken); // 190
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 200
			Write(name.LotNumberElement, writer, "lotNumber", cancellationToken); // 210
			Write(name.ExpirationDateElement, writer, "expirationDate", cancellationToken); // 220
			Write(name.Site, writer, "site", cancellationToken); // 230
			Write(name.Route, writer, "route", cancellationToken); // 240
			Write(name.DoseQuantity, writer, "doseQuantity", cancellationToken); // 250
			Write(name.Performer, writer, "performer", cancellationToken); // 260
			Write(name.Note, writer, "note", cancellationToken); // 270
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 280
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 290
			Write(name.IsSubpotentElement, writer, "isSubpotent", cancellationToken); // 300
			Write(name.SubpotentReason, writer, "subpotentReason", cancellationToken); // 310
			Write(name.Education, writer, "education", cancellationToken); // 320
			Write(name.ProgramEligibility, writer, "programEligibility", cancellationToken); // 330
			Write(name.FundingSource, writer, "fundingSource", cancellationToken); // 340
			Write(name.Reaction, writer, "reaction", cancellationToken); // 350
			Write(name.ProtocolApplied, writer, "protocolApplied", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Write(ImmunizationEvaluation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImmunizationEvaluation", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Patient, writer, "patient", cancellationToken); // 110
			Write(name.DateElement, writer, "date", cancellationToken); // 120
			Write(name.Authority, writer, "authority", cancellationToken); // 130
			Write(name.TargetDisease, writer, "targetDisease", cancellationToken); // 140
			Write(name.ImmunizationEvent, writer, "immunizationEvent", cancellationToken); // 150
			Write(name.DoseStatus, writer, "doseStatus", cancellationToken); // 160
			Write(name.DoseStatusReason, writer, "doseStatusReason", cancellationToken); // 170
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 180
			Write(name.SeriesElement, writer, "series", cancellationToken); // 190
			Write(name.DoseNumber as Hl7.Fhir.Model.PositiveInt, writer, "doseNumberPositiveInt", cancellationToken); // 200
			Write(name.DoseNumber as Hl7.Fhir.Model.FhirString, writer, "doseNumberString", cancellationToken); // 200
			Write(name.SeriesDoses as Hl7.Fhir.Model.PositiveInt, writer, "seriesDosesPositiveInt", cancellationToken); // 210
			Write(name.SeriesDoses as Hl7.Fhir.Model.FhirString, writer, "seriesDosesString", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(ImmunizationRecommendation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImmunizationRecommendation", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Patient, writer, "patient", cancellationToken); // 100
			Write(name.DateElement, writer, "date", cancellationToken); // 110
			Write(name.Authority, writer, "authority", cancellationToken); // 120
			Write(name.Recommendation, writer, "recommendation", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Write(ImplementationGuide name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ImplementationGuide", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.TitleElement, writer, "title", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Description, writer, "description", cancellationToken); // 180
			Write(name.UseContext, writer, "useContext", cancellationToken); // 190
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Write(name.Copyright, writer, "copyright", cancellationToken); // 210
			Write(name.PackageIdElement, writer, "packageId", cancellationToken); // 220
			Write(name.LicenseElement, writer, "license", cancellationToken); // 230
			Write(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 240
			Write(name.DependsOn, writer, "dependsOn", cancellationToken); // 250
			Write(name.Global, writer, "global", cancellationToken); // 260
			Write(name.Definition, writer, "definition", cancellationToken); // 270
			Write(name.Manifest, writer, "manifest", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Write(InsurancePlan name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("InsurancePlan", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.AliasElement, writer, "alias", cancellationToken); // 130
			Write(name.Period, writer, "period", cancellationToken); // 140
			Write(name.OwnedBy, writer, "ownedBy", cancellationToken); // 150
			Write(name.AdministeredBy, writer, "administeredBy", cancellationToken); // 160
			Write(name.CoverageArea, writer, "coverageArea", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 190
			Write(name.Network, writer, "network", cancellationToken); // 200
			Write(name.Coverage, writer, "coverage", cancellationToken); // 210
			Write(name.Plan, writer, "plan", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Write(Invoice name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Invoice", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.CancelledReasonElement, writer, "cancelledReason", cancellationToken); // 110
			Write(name.Type, writer, "type", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.Recipient, writer, "recipient", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.Participant, writer, "participant", cancellationToken); // 160
			Write(name.Issuer, writer, "issuer", cancellationToken); // 170
			Write(name.Account, writer, "account", cancellationToken); // 180
			Write(name.LineItem, writer, "lineItem", cancellationToken); // 190
			Write(name.TotalPriceComponent, writer, "totalPriceComponent", cancellationToken); // 200
			Write(name.TotalNet, writer, "totalNet", cancellationToken); // 210
			Write(name.TotalGross, writer, "totalGross", cancellationToken); // 220
			Write(name.PaymentTerms, writer, "paymentTerms", cancellationToken); // 230
			Write(name.Note, writer, "note", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(Library name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Library", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Write(name.Type, writer, "type", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Write(name.DateElement, writer, "date", cancellationToken); // 190
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Write(name.Contact, writer, "contact", cancellationToken); // 210
			Write(name.Description, writer, "description", cancellationToken); // 220
			Write(name.UseContext, writer, "useContext", cancellationToken); // 230
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 240
			Write(name.Purpose, writer, "purpose", cancellationToken); // 250
			Write(name.UsageElement, writer, "usage", cancellationToken); // 260
			Write(name.Copyright, writer, "copyright", cancellationToken); // 270
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 280
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 290
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 300
			Write(name.Topic, writer, "topic", cancellationToken); // 310
			Write(name.Author, writer, "author", cancellationToken); // 320
			Write(name.Editor, writer, "editor", cancellationToken); // 330
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 340
			Write(name.Endorser, writer, "endorser", cancellationToken); // 350
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 360
			Write(name.Parameter, writer, "parameter", cancellationToken); // 370
			Write(name.DataRequirement, writer, "dataRequirement", cancellationToken); // 380
			Write(name.Content, writer, "content", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Write(Linkage name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Linkage", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.ActiveElement, writer, "active", cancellationToken); // 90
			Write(name.Author, writer, "author", cancellationToken); // 100
			Write(name.Item, writer, "item", cancellationToken); // 110
			writer.WriteEndElement();
		}

		public static void Write(List name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("List", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.ModeElement, writer, "mode", cancellationToken); // 110
			Write(name.TitleElement, writer, "title", cancellationToken); // 120
			Write(name.Code, writer, "code", cancellationToken); // 130
			Write(name.Subject, writer, "subject", cancellationToken); // 140
			Write(name.Encounter, writer, "encounter", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.Source, writer, "source", cancellationToken); // 170
			Write(name.OrderedBy, writer, "orderedBy", cancellationToken); // 180
			Write(name.Note, writer, "note", cancellationToken); // 190
			Write(name.Entry, writer, "entry", cancellationToken); // 200
			Write(name.EmptyReason, writer, "emptyReason", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(Location name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Location", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.OperationalStatus, writer, "operationalStatus", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.AliasElement, writer, "alias", cancellationToken); // 130
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 140
			Write(name.ModeElement, writer, "mode", cancellationToken); // 150
			Write(name.Type, writer, "type", cancellationToken); // 160
			Write(name.Telecom, writer, "telecom", cancellationToken); // 170
			Write(name.Address, writer, "address", cancellationToken); // 180
			Write(name.PhysicalType, writer, "physicalType", cancellationToken); // 190
			Write(name.Position, writer, "position", cancellationToken); // 200
			Write(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 210
			Write(name.PartOf, writer, "partOf", cancellationToken); // 220
			Write(name.HoursOfOperation, writer, "hoursOfOperation", cancellationToken); // 230
			Write(name.AvailabilityExceptionsElement, writer, "availabilityExceptions", cancellationToken); // 240
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(Measure name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Measure", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 170
			Write(name.DateElement, writer, "date", cancellationToken); // 180
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Write(name.Contact, writer, "contact", cancellationToken); // 200
			Write(name.Description, writer, "description", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Purpose, writer, "purpose", cancellationToken); // 240
			Write(name.UsageElement, writer, "usage", cancellationToken); // 250
			Write(name.Copyright, writer, "copyright", cancellationToken); // 260
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 270
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 280
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 290
			Write(name.Topic, writer, "topic", cancellationToken); // 300
			Write(name.Author, writer, "author", cancellationToken); // 310
			Write(name.Editor, writer, "editor", cancellationToken); // 320
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 330
			Write(name.Endorser, writer, "endorser", cancellationToken); // 340
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 350
			Write(name.LibraryElement, writer, "library", cancellationToken); // 360
			Write(name.Disclaimer, writer, "disclaimer", cancellationToken); // 370
			Write(name.Scoring, writer, "scoring", cancellationToken); // 380
			Write(name.CompositeScoring, writer, "compositeScoring", cancellationToken); // 390
			Write(name.Type, writer, "type", cancellationToken); // 400
			Write(name.RiskAdjustmentElement, writer, "riskAdjustment", cancellationToken); // 410
			Write(name.RateAggregationElement, writer, "rateAggregation", cancellationToken); // 420
			Write(name.Rationale, writer, "rationale", cancellationToken); // 430
			Write(name.ClinicalRecommendationStatement, writer, "clinicalRecommendationStatement", cancellationToken); // 440
			Write(name.ImprovementNotation, writer, "improvementNotation", cancellationToken); // 450
			Write(name.Definition, writer, "definition", cancellationToken); // 460
			Write(name.Guidance, writer, "guidance", cancellationToken); // 470
			Write(name.Group, writer, "group", cancellationToken); // 480
			Write(name.SupplementalData, writer, "supplementalData", cancellationToken); // 490
			writer.WriteEndElement();
		}

		public static void Write(MeasureReport name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MeasureReport", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.TypeElement, writer, "type", cancellationToken); // 110
			Write(name.MeasureElement, writer, "measure", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.DateElement, writer, "date", cancellationToken); // 140
			Write(name.Reporter, writer, "reporter", cancellationToken); // 150
			Write(name.Period, writer, "period", cancellationToken); // 160
			Write(name.ImprovementNotation, writer, "improvementNotation", cancellationToken); // 170
			Write(name.Group, writer, "group", cancellationToken); // 180
			Write(name.EvaluatedResource, writer, "evaluatedResource", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(Media name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Media", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.PartOf, writer, "partOf", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.Type, writer, "type", cancellationToken); // 130
			Write(name.Modality, writer, "modality", cancellationToken); // 140
			Write(name.View, writer, "view", cancellationToken); // 150
			Write(name.Subject, writer, "subject", cancellationToken); // 160
			Write(name.Encounter, writer, "encounter", cancellationToken); // 170
			Write(name.Created as Hl7.Fhir.Model.FhirDateTime, writer, "createdDateTime", cancellationToken); // 180
			Write(name.Created as Hl7.Fhir.Model.Period, writer, "createdPeriod", cancellationToken); // 180
			Write(name.IssuedElement, writer, "issued", cancellationToken); // 190
			Write(name.Operator, writer, "operator", cancellationToken); // 200
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 210
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 220
			Write(name.DeviceNameElement, writer, "deviceName", cancellationToken); // 230
			Write(name.Device, writer, "device", cancellationToken); // 240
			Write(name.HeightElement, writer, "height", cancellationToken); // 250
			Write(name.WidthElement, writer, "width", cancellationToken); // 260
			Write(name.FramesElement, writer, "frames", cancellationToken); // 270
			Write(name.DurationElement, writer, "duration", cancellationToken); // 280
			Write(name.Content, writer, "content", cancellationToken); // 290
			Write(name.Note, writer, "note", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Write(Medication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Medication", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Code, writer, "code", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 120
			Write(name.Form, writer, "form", cancellationToken); // 130
			Write(name.Amount, writer, "amount", cancellationToken); // 140
			Write(name.Ingredient, writer, "ingredient", cancellationToken); // 150
			Write(name.Batch, writer, "batch", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(MedicationAdministration name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationAdministration", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesElement, writer, "instantiates", cancellationToken); // 100
			Write(name.PartOf, writer, "partOf", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 130
			Write(name.Category, writer, "category", cancellationToken); // 140
			Write(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 150
			Write(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 150
			Write(name.Subject, writer, "subject", cancellationToken); // 160
			Write(name.Context, writer, "context", cancellationToken); // 170
			Write(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 180
			Write(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 190
			Write(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 190
			Write(name.Performer, writer, "performer", cancellationToken); // 200
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 210
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 220
			Write(name.Request, writer, "request", cancellationToken); // 230
			Write(name.Device, writer, "device", cancellationToken); // 240
			Write(name.Note, writer, "note", cancellationToken); // 250
			Write(name.Dosage, writer, "dosage", cancellationToken); // 260
			Write(name.EventHistory, writer, "eventHistory", cancellationToken); // 270
			writer.WriteEndElement();
		}

		public static void Write(MedicationDispense name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationDispense", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.PartOf, writer, "partOf", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.StatusReason as Hl7.Fhir.Model.CodeableConcept, writer, "statusReasonCodeableConcept", cancellationToken); // 120
			Write(name.StatusReason as Hl7.Fhir.Model.ResourceReference, writer, "statusReasonReference", cancellationToken); // 120
			Write(name.Category, writer, "category", cancellationToken); // 130
			Write(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 140
			Write(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 140
			Write(name.Subject, writer, "subject", cancellationToken); // 150
			Write(name.Context, writer, "context", cancellationToken); // 160
			Write(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 170
			Write(name.Performer, writer, "performer", cancellationToken); // 180
			Write(name.Location, writer, "location", cancellationToken); // 190
			Write(name.AuthorizingPrescription, writer, "authorizingPrescription", cancellationToken); // 200
			Write(name.Type, writer, "type", cancellationToken); // 210
			Write(name.Quantity, writer, "quantity", cancellationToken); // 220
			Write(name.DaysSupply, writer, "daysSupply", cancellationToken); // 230
			Write(name.WhenPreparedElement, writer, "whenPrepared", cancellationToken); // 240
			Write(name.WhenHandedOverElement, writer, "whenHandedOver", cancellationToken); // 250
			Write(name.Destination, writer, "destination", cancellationToken); // 260
			Write(name.Receiver, writer, "receiver", cancellationToken); // 270
			Write(name.Note, writer, "note", cancellationToken); // 280
			Write(name.DosageInstruction, writer, "dosageInstruction", cancellationToken); // 290
			Write(name.Substitution, writer, "substitution", cancellationToken); // 300
			Write(name.DetectedIssue, writer, "detectedIssue", cancellationToken); // 310
			Write(name.EventHistory, writer, "eventHistory", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(MedicationKnowledge name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationKnowledge", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Code, writer, "code", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 110
			Write(name.DoseForm, writer, "doseForm", cancellationToken); // 120
			Write(name.Amount, writer, "amount", cancellationToken); // 130
			Write(name.SynonymElement, writer, "synonym", cancellationToken); // 140
			Write(name.RelatedMedicationKnowledge, writer, "relatedMedicationKnowledge", cancellationToken); // 150
			Write(name.AssociatedMedication, writer, "associatedMedication", cancellationToken); // 160
			Write(name.ProductType, writer, "productType", cancellationToken); // 170
			Write(name.Monograph, writer, "monograph", cancellationToken); // 180
			Write(name.Ingredient, writer, "ingredient", cancellationToken); // 190
			Write(name.PreparationInstruction, writer, "preparationInstruction", cancellationToken); // 200
			Write(name.IntendedRoute, writer, "intendedRoute", cancellationToken); // 210
			Write(name.Cost, writer, "cost", cancellationToken); // 220
			Write(name.MonitoringProgram, writer, "monitoringProgram", cancellationToken); // 230
			Write(name.AdministrationGuidelines, writer, "administrationGuidelines", cancellationToken); // 240
			Write(name.MedicineClassification, writer, "medicineClassification", cancellationToken); // 250
			Write(name.Packaging, writer, "packaging", cancellationToken); // 260
			Write(name.DrugCharacteristic, writer, "drugCharacteristic", cancellationToken); // 270
			Write(name.Contraindication, writer, "contraindication", cancellationToken); // 280
			Write(name.Regulatory, writer, "regulatory", cancellationToken); // 290
			Write(name.Kinetics, writer, "kinetics", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Write(MedicationRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 110
			Write(name.IntentElement, writer, "intent", cancellationToken); // 120
			Write(name.Category, writer, "category", cancellationToken); // 130
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 140
			Write(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 150
			Write(name.Reported as Hl7.Fhir.Model.FhirBoolean, writer, "reportedBoolean", cancellationToken); // 160
			Write(name.Reported as Hl7.Fhir.Model.ResourceReference, writer, "reportedReference", cancellationToken); // 160
			Write(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 170
			Write(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 170
			Write(name.Subject, writer, "subject", cancellationToken); // 180
			Write(name.Encounter, writer, "encounter", cancellationToken); // 190
			Write(name.SupportingInformation, writer, "supportingInformation", cancellationToken); // 200
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 210
			Write(name.Requester, writer, "requester", cancellationToken); // 220
			Write(name.Performer, writer, "performer", cancellationToken); // 230
			Write(name.PerformerType, writer, "performerType", cancellationToken); // 240
			Write(name.Recorder, writer, "recorder", cancellationToken); // 250
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 260
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 270
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 280
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 290
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 300
			Write(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 310
			Write(name.CourseOfTherapyType, writer, "courseOfTherapyType", cancellationToken); // 320
			Write(name.Insurance, writer, "insurance", cancellationToken); // 330
			Write(name.Note, writer, "note", cancellationToken); // 340
			Write(name.DosageInstruction, writer, "dosageInstruction", cancellationToken); // 350
			Write(name.DispenseRequest, writer, "dispenseRequest", cancellationToken); // 360
			Write(name.Substitution, writer, "substitution", cancellationToken); // 370
			Write(name.PriorPrescription, writer, "priorPrescription", cancellationToken); // 380
			Write(name.DetectedIssue, writer, "detectedIssue", cancellationToken); // 390
			Write(name.EventHistory, writer, "eventHistory", cancellationToken); // 400
			writer.WriteEndElement();
		}

		public static void Write(MedicationStatement name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicationStatement", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.PartOf, writer, "partOf", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 130
			Write(name.Category, writer, "category", cancellationToken); // 140
			Write(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 150
			Write(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 150
			Write(name.Subject, writer, "subject", cancellationToken); // 160
			Write(name.Context, writer, "context", cancellationToken); // 170
			Write(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 180
			Write(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 180
			Write(name.DateAssertedElement, writer, "dateAsserted", cancellationToken); // 190
			Write(name.InformationSource, writer, "informationSource", cancellationToken); // 200
			Write(name.DerivedFrom, writer, "derivedFrom", cancellationToken); // 210
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 220
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 230
			Write(name.Note, writer, "note", cancellationToken); // 240
			Write(name.Dosage, writer, "dosage", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProduct name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProduct", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Type, writer, "type", cancellationToken); // 100
			Write(name.Domain, writer, "domain", cancellationToken); // 110
			Write(name.CombinedPharmaceuticalDoseForm, writer, "combinedPharmaceuticalDoseForm", cancellationToken); // 120
			Write(name.LegalStatusOfSupply, writer, "legalStatusOfSupply", cancellationToken); // 130
			Write(name.AdditionalMonitoringIndicator, writer, "additionalMonitoringIndicator", cancellationToken); // 140
			Write(name.SpecialMeasuresElement, writer, "specialMeasures", cancellationToken); // 150
			Write(name.PaediatricUseIndicator, writer, "paediatricUseIndicator", cancellationToken); // 160
			Write(name.ProductClassification, writer, "productClassification", cancellationToken); // 170
			Write(name.MarketingStatus, writer, "marketingStatus", cancellationToken); // 180
			Write(name.PharmaceuticalProduct, writer, "pharmaceuticalProduct", cancellationToken); // 190
			Write(name.PackagedMedicinalProduct, writer, "packagedMedicinalProduct", cancellationToken); // 200
			Write(name.AttachedDocument, writer, "attachedDocument", cancellationToken); // 210
			Write(name.MasterFile, writer, "masterFile", cancellationToken); // 220
			Write(name.Contact, writer, "contact", cancellationToken); // 230
			Write(name.ClinicalTrial, writer, "clinicalTrial", cancellationToken); // 240
			Write(name.Name, writer, "name", cancellationToken); // 250
			Write(name.CrossReference, writer, "crossReference", cancellationToken); // 260
			Write(name.ManufacturingBusinessOperation, writer, "manufacturingBusinessOperation", cancellationToken); // 270
			Write(name.SpecialDesignation, writer, "specialDesignation", cancellationToken); // 280
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductAuthorization name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductAuthorization", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Subject, writer, "subject", cancellationToken); // 100
			Write(name.Country, writer, "country", cancellationToken); // 110
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 120
			Write(name.Status, writer, "status", cancellationToken); // 130
			Write(name.StatusDateElement, writer, "statusDate", cancellationToken); // 140
			Write(name.RestoreDateElement, writer, "restoreDate", cancellationToken); // 150
			Write(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 160
			Write(name.DataExclusivityPeriod, writer, "dataExclusivityPeriod", cancellationToken); // 170
			Write(name.DateOfFirstAuthorizationElement, writer, "dateOfFirstAuthorization", cancellationToken); // 180
			Write(name.InternationalBirthDateElement, writer, "internationalBirthDate", cancellationToken); // 190
			Write(name.LegalBasis, writer, "legalBasis", cancellationToken); // 200
			Write(name.JurisdictionalAuthorization, writer, "jurisdictionalAuthorization", cancellationToken); // 210
			Write(name.Holder, writer, "holder", cancellationToken); // 220
			Write(name.Regulator, writer, "regulator", cancellationToken); // 230
			Write(name.Procedure, writer, "procedure", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductContraindication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductContraindication", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Subject, writer, "subject", cancellationToken); // 90
			Write(name.Disease, writer, "disease", cancellationToken); // 100
			Write(name.DiseaseStatus, writer, "diseaseStatus", cancellationToken); // 110
			Write(name.Comorbidity, writer, "comorbidity", cancellationToken); // 120
			Write(name.TherapeuticIndication, writer, "therapeuticIndication", cancellationToken); // 130
			Write(name.OtherTherapy, writer, "otherTherapy", cancellationToken); // 140
			Write(name.Population, writer, "population", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductIndication name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductIndication", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Subject, writer, "subject", cancellationToken); // 90
			Write(name.DiseaseSymptomProcedure, writer, "diseaseSymptomProcedure", cancellationToken); // 100
			Write(name.DiseaseStatus, writer, "diseaseStatus", cancellationToken); // 110
			Write(name.Comorbidity, writer, "comorbidity", cancellationToken); // 120
			Write(name.IntendedEffect, writer, "intendedEffect", cancellationToken); // 130
			Write(name.Duration, writer, "duration", cancellationToken); // 140
			Write(name.OtherTherapy, writer, "otherTherapy", cancellationToken); // 150
			Write(name.UndesirableEffect, writer, "undesirableEffect", cancellationToken); // 160
			Write(name.Population, writer, "population", cancellationToken); // 170
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductIngredient name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductIngredient", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Role, writer, "role", cancellationToken); // 100
			Write(name.AllergenicIndicatorElement, writer, "allergenicIndicator", cancellationToken); // 110
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 120
			Write(name.SpecifiedSubstance, writer, "specifiedSubstance", cancellationToken); // 130
			Write(name.Substance, writer, "substance", cancellationToken); // 140
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductInteraction name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductInteraction", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Subject, writer, "subject", cancellationToken); // 90
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 100
			Write(name.Interactant, writer, "interactant", cancellationToken); // 110
			Write(name.Type, writer, "type", cancellationToken); // 120
			Write(name.Effect, writer, "effect", cancellationToken); // 130
			Write(name.Incidence, writer, "incidence", cancellationToken); // 140
			Write(name.Management, writer, "management", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductManufactured name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductManufactured", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.ManufacturedDoseForm, writer, "manufacturedDoseForm", cancellationToken); // 90
			Write(name.UnitOfPresentation, writer, "unitOfPresentation", cancellationToken); // 100
			Write(name.Quantity, writer, "quantity", cancellationToken); // 110
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 120
			Write(name.Ingredient, writer, "ingredient", cancellationToken); // 130
			Write(name.PhysicalCharacteristics, writer, "physicalCharacteristics", cancellationToken); // 140
			Write(name.OtherCharacteristics, writer, "otherCharacteristics", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductPackaged name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductPackaged", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Subject, writer, "subject", cancellationToken); // 100
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 110
			Write(name.LegalStatusOfSupply, writer, "legalStatusOfSupply", cancellationToken); // 120
			Write(name.MarketingStatus, writer, "marketingStatus", cancellationToken); // 130
			Write(name.MarketingAuthorization, writer, "marketingAuthorization", cancellationToken); // 140
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 150
			Write(name.BatchIdentifier, writer, "batchIdentifier", cancellationToken); // 160
			Write(name.PackageItem, writer, "packageItem", cancellationToken); // 170
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductPharmaceutical name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductPharmaceutical", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.AdministrableDoseForm, writer, "administrableDoseForm", cancellationToken); // 100
			Write(name.UnitOfPresentation, writer, "unitOfPresentation", cancellationToken); // 110
			Write(name.Ingredient, writer, "ingredient", cancellationToken); // 120
			Write(name.Device, writer, "device", cancellationToken); // 130
			Write(name.Characteristics, writer, "characteristics", cancellationToken); // 140
			Write(name.RouteOfAdministration, writer, "routeOfAdministration", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(MedicinalProductUndesirableEffect name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MedicinalProductUndesirableEffect", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Subject, writer, "subject", cancellationToken); // 90
			Write(name.SymptomConditionEffect, writer, "symptomConditionEffect", cancellationToken); // 100
			Write(name.Classification, writer, "classification", cancellationToken); // 110
			Write(name.FrequencyOfOccurrence, writer, "frequencyOfOccurrence", cancellationToken); // 120
			Write(name.Population, writer, "population", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Write(MessageDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MessageDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.ReplacesElement, writer, "replaces", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Write(name.DateElement, writer, "date", cancellationToken); // 170
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 180
			Write(name.Contact, writer, "contact", cancellationToken); // 190
			Write(name.Description, writer, "description", cancellationToken); // 200
			Write(name.UseContext, writer, "useContext", cancellationToken); // 210
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 220
			Write(name.Purpose, writer, "purpose", cancellationToken); // 230
			Write(name.Copyright, writer, "copyright", cancellationToken); // 240
			Write(name.BaseElement, writer, "base", cancellationToken); // 250
			Write(name.ParentElement, writer, "parent", cancellationToken); // 260
			Write(name.Event as Hl7.Fhir.Model.Coding, writer, "eventCoding", cancellationToken); // 270
			Write(name.Event as Hl7.Fhir.Model.FhirUri, writer, "eventUri", cancellationToken); // 270
			Write(name.CategoryElement, writer, "category", cancellationToken); // 280
			Write(name.Focus, writer, "focus", cancellationToken); // 290
			Write(name.ResponseRequiredElement, writer, "responseRequired", cancellationToken); // 300
			Write(name.AllowedResponse, writer, "allowedResponse", cancellationToken); // 310
			Write(name.GraphElement, writer, "graph", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(MessageHeader name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MessageHeader", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Event as Hl7.Fhir.Model.Coding, writer, "eventCoding", cancellationToken); // 90
			Write(name.Event as Hl7.Fhir.Model.FhirUri, writer, "eventUri", cancellationToken); // 90
			Write(name.Destination, writer, "destination", cancellationToken); // 100
			Write(name.Sender, writer, "sender", cancellationToken); // 110
			Write(name.Enterer, writer, "enterer", cancellationToken); // 120
			Write(name.Author, writer, "author", cancellationToken); // 130
			Write(name.Source, writer, "source", cancellationToken); // 140
			Write(name.Responsible, writer, "responsible", cancellationToken); // 150
			Write(name.Reason, writer, "reason", cancellationToken); // 160
			Write(name.Response, writer, "response", cancellationToken); // 170
			Write(name.Focus, writer, "focus", cancellationToken); // 180
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(MolecularSequence name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("MolecularSequence", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.TypeElement, writer, "type", cancellationToken); // 100
			Write(name.CoordinateSystemElement, writer, "coordinateSystem", cancellationToken); // 110
			Write(name.Patient, writer, "patient", cancellationToken); // 120
			Write(name.Specimen, writer, "specimen", cancellationToken); // 130
			Write(name.Device, writer, "device", cancellationToken); // 140
			Write(name.Performer, writer, "performer", cancellationToken); // 150
			Write(name.Quantity, writer, "quantity", cancellationToken); // 160
			Write(name.ReferenceSeq, writer, "referenceSeq", cancellationToken); // 170
			Write(name.Variant, writer, "variant", cancellationToken); // 180
			Write(name.ObservedSeqElement, writer, "observedSeq", cancellationToken); // 190
			Write(name.Quality, writer, "quality", cancellationToken); // 200
			Write(name.ReadCoverageElement, writer, "readCoverage", cancellationToken); // 210
			Write(name.Repository, writer, "repository", cancellationToken); // 220
			Write(name.Pointer, writer, "pointer", cancellationToken); // 230
			Write(name.StructureVariant, writer, "structureVariant", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(NamingSystem name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("NamingSystem", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.NameElement, writer, "name", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.KindElement, writer, "kind", cancellationToken); // 110
			Write(name.DateElement, writer, "date", cancellationToken); // 120
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 130
			Write(name.Contact, writer, "contact", cancellationToken); // 140
			Write(name.ResponsibleElement, writer, "responsible", cancellationToken); // 150
			Write(name.Type, writer, "type", cancellationToken); // 160
			Write(name.Description, writer, "description", cancellationToken); // 170
			Write(name.UseContext, writer, "useContext", cancellationToken); // 180
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 190
			Write(name.UsageElement, writer, "usage", cancellationToken); // 200
			Write(name.UniqueId, writer, "uniqueId", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(NutritionOrder name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("NutritionOrder", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.InstantiatesElement, writer, "instantiates", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.IntentElement, writer, "intent", cancellationToken); // 140
			Write(name.Patient, writer, "patient", cancellationToken); // 150
			Write(name.Encounter, writer, "encounter", cancellationToken); // 160
			Write(name.DateTimeElement, writer, "dateTime", cancellationToken); // 170
			Write(name.Orderer, writer, "orderer", cancellationToken); // 180
			Write(name.AllergyIntolerance, writer, "allergyIntolerance", cancellationToken); // 190
			Write(name.FoodPreferenceModifier, writer, "foodPreferenceModifier", cancellationToken); // 200
			Write(name.ExcludeFoodModifier, writer, "excludeFoodModifier", cancellationToken); // 210
			Write(name.OralDiet, writer, "oralDiet", cancellationToken); // 220
			Write(name.Supplement, writer, "supplement", cancellationToken); // 230
			Write(name.EnteralFormula, writer, "enteralFormula", cancellationToken); // 240
			Write(name.Note, writer, "note", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(Observation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Observation", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.PartOf, writer, "partOf", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.Category, writer, "category", cancellationToken); // 130
			Write(name.Code, writer, "code", cancellationToken); // 140
			Write(name.Subject, writer, "subject", cancellationToken); // 150
			Write(name.Focus, writer, "focus", cancellationToken); // 160
			Write(name.Encounter, writer, "encounter", cancellationToken); // 170
			Write(name.Effective as Hl7.Fhir.Model.FhirDateTime, writer, "effectiveDateTime", cancellationToken); // 180
			Write(name.Effective as Hl7.Fhir.Model.Period, writer, "effectivePeriod", cancellationToken); // 180
			Write(name.Effective as Hl7.Fhir.Model.Timing, writer, "effectiveTiming", cancellationToken); // 180
			Write(name.Effective as Hl7.Fhir.Model.Instant, writer, "effectiveInstant", cancellationToken); // 180
			Write(name.IssuedElement, writer, "issued", cancellationToken); // 190
			Write(name.Performer, writer, "performer", cancellationToken); // 200
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 210
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 210
			Write(name.DataAbsentReason, writer, "dataAbsentReason", cancellationToken); // 220
			Write(name.Interpretation, writer, "interpretation", cancellationToken); // 230
			Write(name.Note, writer, "note", cancellationToken); // 240
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 250
			Write(name.Method, writer, "method", cancellationToken); // 260
			Write(name.Specimen, writer, "specimen", cancellationToken); // 270
			Write(name.Device, writer, "device", cancellationToken); // 280
			Write(name.ReferenceRange, writer, "referenceRange", cancellationToken); // 290
			Write(name.HasMember, writer, "hasMember", cancellationToken); // 300
			Write(name.DerivedFrom, writer, "derivedFrom", cancellationToken); // 310
			Write(name.Component, writer, "component", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(ObservationDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ObservationDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Category, writer, "category", cancellationToken); // 90
			Write(name.Code, writer, "code", cancellationToken); // 100
			Write(name.Identifier, writer, "identifier", cancellationToken); // 110
			Write(name.PermittedDataTypeElement, writer, "permittedDataType", cancellationToken); // 120
			Write(name.MultipleResultsAllowedElement, writer, "multipleResultsAllowed", cancellationToken); // 130
			Write(name.Method, writer, "method", cancellationToken); // 140
			Write(name.PreferredReportNameElement, writer, "preferredReportName", cancellationToken); // 150
			Write(name.QuantitativeDetails, writer, "quantitativeDetails", cancellationToken); // 160
			Write(name.QualifiedInterval, writer, "qualifiedInterval", cancellationToken); // 170
			Write(name.ValidCodedValueSet, writer, "validCodedValueSet", cancellationToken); // 180
			Write(name.NormalCodedValueSet, writer, "normalCodedValueSet", cancellationToken); // 190
			Write(name.AbnormalCodedValueSet, writer, "abnormalCodedValueSet", cancellationToken); // 200
			Write(name.CriticalCodedValueSet, writer, "criticalCodedValueSet", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(OperationDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("OperationDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.TitleElement, writer, "title", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.KindElement, writer, "kind", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Purpose, writer, "purpose", cancellationToken); // 220
			Write(name.AffectsStateElement, writer, "affectsState", cancellationToken); // 230
			Write(name.CodeElement, writer, "code", cancellationToken); // 240
			Write(name.Comment, writer, "comment", cancellationToken); // 250
			Write(name.BaseElement, writer, "base", cancellationToken); // 260
			Write(name.ResourceElement, writer, "resource", cancellationToken); // 270
			Write(name.SystemElement, writer, "system", cancellationToken); // 280
			Write(name.TypeElement, writer, "type", cancellationToken); // 290
			Write(name.InstanceElement, writer, "instance", cancellationToken); // 300
			Write(name.InputProfileElement, writer, "inputProfile", cancellationToken); // 310
			Write(name.OutputProfileElement, writer, "outputProfile", cancellationToken); // 320
			Write(name.Parameter, writer, "parameter", cancellationToken); // 330
			Write(name.Overload, writer, "overload", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Write(OperationOutcome name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("OperationOutcome", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Issue, writer, "issue", cancellationToken); // 90
			writer.WriteEndElement();
		}

		public static void Write(Organization name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Organization", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Type, writer, "type", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.AliasElement, writer, "alias", cancellationToken); // 130
			Write(name.Telecom, writer, "telecom", cancellationToken); // 140
			Write(name.Address, writer, "address", cancellationToken); // 150
			Write(name.PartOf, writer, "partOf", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Write(OrganizationAffiliation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("OrganizationAffiliation", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Period, writer, "period", cancellationToken); // 110
			Write(name.Organization, writer, "organization", cancellationToken); // 120
			Write(name.ParticipatingOrganization, writer, "participatingOrganization", cancellationToken); // 130
			Write(name.Network, writer, "network", cancellationToken); // 140
			Write(name.Code, writer, "code", cancellationToken); // 150
			Write(name.Specialty, writer, "specialty", cancellationToken); // 160
			Write(name.Location, writer, "location", cancellationToken); // 170
			Write(name.HealthcareService, writer, "healthcareService", cancellationToken); // 180
			Write(name.Telecom, writer, "telecom", cancellationToken); // 190
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(Parameters name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Parameters", XmlNs.FHIR);
			WriteResource(name, writer, cancellationToken);
			Write(name.Parameter, writer, "parameter", cancellationToken); // 50
			writer.WriteEndElement();
		}

		public static void Write(Patient name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Patient", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Name, writer, "name", cancellationToken); // 110
			Write(name.Telecom, writer, "telecom", cancellationToken); // 120
			Write(name.GenderElement, writer, "gender", cancellationToken); // 130
			Write(name.BirthDateElement, writer, "birthDate", cancellationToken); // 140
			Write(name.Deceased as Hl7.Fhir.Model.FhirBoolean, writer, "deceasedBoolean", cancellationToken); // 150
			Write(name.Deceased as Hl7.Fhir.Model.FhirDateTime, writer, "deceasedDateTime", cancellationToken); // 150
			Write(name.Address, writer, "address", cancellationToken); // 160
			Write(name.MaritalStatus, writer, "maritalStatus", cancellationToken); // 170
			Write(name.MultipleBirth as Hl7.Fhir.Model.FhirBoolean, writer, "multipleBirthBoolean", cancellationToken); // 180
			Write(name.MultipleBirth as Hl7.Fhir.Model.Integer, writer, "multipleBirthInteger", cancellationToken); // 180
			Write(name.Photo, writer, "photo", cancellationToken); // 190
			Write(name.Contact, writer, "contact", cancellationToken); // 200
			Write(name.Communication, writer, "communication", cancellationToken); // 210
			Write(name.GeneralPractitioner, writer, "generalPractitioner", cancellationToken); // 220
			Write(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 230
			Write(name.Link, writer, "link", cancellationToken); // 240
			writer.WriteEndElement();
		}

		public static void Write(PaymentNotice name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PaymentNotice", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Request, writer, "request", cancellationToken); // 110
			Write(name.Response, writer, "response", cancellationToken); // 120
			Write(name.CreatedElement, writer, "created", cancellationToken); // 130
			Write(name.Provider, writer, "provider", cancellationToken); // 140
			Write(name.Payment, writer, "payment", cancellationToken); // 150
			Write(name.PaymentDateElement, writer, "paymentDate", cancellationToken); // 160
			Write(name.Payee, writer, "payee", cancellationToken); // 170
			Write(name.Recipient, writer, "recipient", cancellationToken); // 180
			Write(name.Amount, writer, "amount", cancellationToken); // 190
			Write(name.PaymentStatus, writer, "paymentStatus", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(PaymentReconciliation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PaymentReconciliation", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Period, writer, "period", cancellationToken); // 110
			Write(name.CreatedElement, writer, "created", cancellationToken); // 120
			Write(name.PaymentIssuer, writer, "paymentIssuer", cancellationToken); // 130
			Write(name.Request, writer, "request", cancellationToken); // 140
			Write(name.Requestor, writer, "requestor", cancellationToken); // 150
			Write(name.OutcomeElement, writer, "outcome", cancellationToken); // 160
			Write(name.DispositionElement, writer, "disposition", cancellationToken); // 170
			Write(name.PaymentDateElement, writer, "paymentDate", cancellationToken); // 180
			Write(name.PaymentAmount, writer, "paymentAmount", cancellationToken); // 190
			Write(name.PaymentIdentifier, writer, "paymentIdentifier", cancellationToken); // 200
			Write(name.Detail, writer, "detail", cancellationToken); // 210
			Write(name.FormCode, writer, "formCode", cancellationToken); // 220
			Write(name.ProcessNote, writer, "processNote", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Write(Person name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Person", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Name, writer, "name", cancellationToken); // 100
			Write(name.Telecom, writer, "telecom", cancellationToken); // 110
			Write(name.GenderElement, writer, "gender", cancellationToken); // 120
			Write(name.BirthDateElement, writer, "birthDate", cancellationToken); // 130
			Write(name.Address, writer, "address", cancellationToken); // 140
			Write(name.Photo, writer, "photo", cancellationToken); // 150
			Write(name.ManagingOrganization, writer, "managingOrganization", cancellationToken); // 160
			Write(name.ActiveElement, writer, "active", cancellationToken); // 170
			Write(name.Link, writer, "link", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Write(PlanDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PlanDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 140
			Write(name.Type, writer, "type", cancellationToken); // 150
			Write(name.StatusElement, writer, "status", cancellationToken); // 160
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Write(name.DateElement, writer, "date", cancellationToken); // 190
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Write(name.Contact, writer, "contact", cancellationToken); // 210
			Write(name.Description, writer, "description", cancellationToken); // 220
			Write(name.UseContext, writer, "useContext", cancellationToken); // 230
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 240
			Write(name.Purpose, writer, "purpose", cancellationToken); // 250
			Write(name.UsageElement, writer, "usage", cancellationToken); // 260
			Write(name.Copyright, writer, "copyright", cancellationToken); // 270
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 280
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 290
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 300
			Write(name.Topic, writer, "topic", cancellationToken); // 310
			Write(name.Author, writer, "author", cancellationToken); // 320
			Write(name.Editor, writer, "editor", cancellationToken); // 330
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 340
			Write(name.Endorser, writer, "endorser", cancellationToken); // 350
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 360
			Write(name.LibraryElement, writer, "library", cancellationToken); // 370
			Write(name.Goal, writer, "goal", cancellationToken); // 380
			Write(name.Action, writer, "action", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Write(Practitioner name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Practitioner", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Name, writer, "name", cancellationToken); // 110
			Write(name.Telecom, writer, "telecom", cancellationToken); // 120
			Write(name.Address, writer, "address", cancellationToken); // 130
			Write(name.GenderElement, writer, "gender", cancellationToken); // 140
			Write(name.BirthDateElement, writer, "birthDate", cancellationToken); // 150
			Write(name.Photo, writer, "photo", cancellationToken); // 160
			Write(name.Qualification, writer, "qualification", cancellationToken); // 170
			Write(name.Communication, writer, "communication", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Write(PractitionerRole name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("PractitionerRole", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Period, writer, "period", cancellationToken); // 110
			Write(name.Practitioner, writer, "practitioner", cancellationToken); // 120
			Write(name.Organization, writer, "organization", cancellationToken); // 130
			Write(name.Code, writer, "code", cancellationToken); // 140
			Write(name.Specialty, writer, "specialty", cancellationToken); // 150
			Write(name.Location, writer, "location", cancellationToken); // 160
			Write(name.HealthcareService, writer, "healthcareService", cancellationToken); // 170
			Write(name.Telecom, writer, "telecom", cancellationToken); // 180
			Write(name.AvailableTime, writer, "availableTime", cancellationToken); // 190
			Write(name.NotAvailable, writer, "notAvailable", cancellationToken); // 200
			Write(name.AvailabilityExceptionsElement, writer, "availabilityExceptions", cancellationToken); // 210
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Write(Procedure name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Procedure", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.PartOf, writer, "partOf", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 150
			Write(name.Category, writer, "category", cancellationToken); // 160
			Write(name.Code, writer, "code", cancellationToken); // 170
			Write(name.Subject, writer, "subject", cancellationToken); // 180
			Write(name.Encounter, writer, "encounter", cancellationToken); // 190
			Write(name.Performed as Hl7.Fhir.Model.FhirDateTime, writer, "performedDateTime", cancellationToken); // 200
			Write(name.Performed as Hl7.Fhir.Model.Period, writer, "performedPeriod", cancellationToken); // 200
			Write(name.Performed as Hl7.Fhir.Model.FhirString, writer, "performedString", cancellationToken); // 200
			Write(name.Performed as Hl7.Fhir.Model.Age, writer, "performedAge", cancellationToken); // 200
			Write(name.Performed as Hl7.Fhir.Model.Range, writer, "performedRange", cancellationToken); // 200
			Write(name.Recorder, writer, "recorder", cancellationToken); // 210
			Write(name.Asserter, writer, "asserter", cancellationToken); // 220
			Write(name.Performer, writer, "performer", cancellationToken); // 230
			Write(name.Location, writer, "location", cancellationToken); // 240
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 250
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 260
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 270
			Write(name.Outcome, writer, "outcome", cancellationToken); // 280
			Write(name.Report, writer, "report", cancellationToken); // 290
			Write(name.Complication, writer, "complication", cancellationToken); // 300
			Write(name.ComplicationDetail, writer, "complicationDetail", cancellationToken); // 310
			Write(name.FollowUp, writer, "followUp", cancellationToken); // 320
			Write(name.Note, writer, "note", cancellationToken); // 330
			Write(name.FocalDevice, writer, "focalDevice", cancellationToken); // 340
			Write(name.UsedReference, writer, "usedReference", cancellationToken); // 350
			Write(name.UsedCode, writer, "usedCode", cancellationToken); // 360
			writer.WriteEndElement();
		}

		public static void Write(Provenance name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Provenance", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Target, writer, "target", cancellationToken); // 90
			Write(name.Occurred as Hl7.Fhir.Model.Period, writer, "occurredPeriod", cancellationToken); // 100
			Write(name.Occurred as Hl7.Fhir.Model.FhirDateTime, writer, "occurredDateTime", cancellationToken); // 100
			Write(name.RecordedElement, writer, "recorded", cancellationToken); // 110
			Write(name.PolicyElement, writer, "policy", cancellationToken); // 120
			Write(name.Location, writer, "location", cancellationToken); // 130
			Write(name.Reason, writer, "reason", cancellationToken); // 140
			Write(name.Activity, writer, "activity", cancellationToken); // 150
			Write(name.Agent, writer, "agent", cancellationToken); // 160
			Write(name.Entity, writer, "entity", cancellationToken); // 170
			Write(name.Signature, writer, "signature", cancellationToken); // 180
			writer.WriteEndElement();
		}

		public static void Write(Questionnaire name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Questionnaire", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.DerivedFromElement, writer, "derivedFrom", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 160
			Write(name.SubjectTypeElement, writer, "subjectType", cancellationToken); // 170
			Write(name.DateElement, writer, "date", cancellationToken); // 180
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 190
			Write(name.Contact, writer, "contact", cancellationToken); // 200
			Write(name.Description, writer, "description", cancellationToken); // 210
			Write(name.UseContext, writer, "useContext", cancellationToken); // 220
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 230
			Write(name.Purpose, writer, "purpose", cancellationToken); // 240
			Write(name.Copyright, writer, "copyright", cancellationToken); // 250
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 260
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 270
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 280
			Write(name.Code, writer, "code", cancellationToken); // 290
			Write(name.Item, writer, "item", cancellationToken); // 300
			writer.WriteEndElement();
		}

		public static void Write(QuestionnaireResponse name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("QuestionnaireResponse", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.PartOf, writer, "partOf", cancellationToken); // 110
			Write(name.QuestionnaireElement, writer, "questionnaire", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.Subject, writer, "subject", cancellationToken); // 140
			Write(name.Encounter, writer, "encounter", cancellationToken); // 150
			Write(name.AuthoredElement, writer, "authored", cancellationToken); // 160
			Write(name.Author, writer, "author", cancellationToken); // 170
			Write(name.Source, writer, "source", cancellationToken); // 180
			Write(name.Item, writer, "item", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(RelatedPerson name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RelatedPerson", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.Patient, writer, "patient", cancellationToken); // 110
			Write(name.Relationship, writer, "relationship", cancellationToken); // 120
			Write(name.Name, writer, "name", cancellationToken); // 130
			Write(name.Telecom, writer, "telecom", cancellationToken); // 140
			Write(name.GenderElement, writer, "gender", cancellationToken); // 150
			Write(name.BirthDateElement, writer, "birthDate", cancellationToken); // 160
			Write(name.Address, writer, "address", cancellationToken); // 170
			Write(name.Photo, writer, "photo", cancellationToken); // 180
			Write(name.Period, writer, "period", cancellationToken); // 190
			Write(name.Communication, writer, "communication", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(RequestGroup name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RequestGroup", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.Replaces, writer, "replaces", cancellationToken); // 130
			Write(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.IntentElement, writer, "intent", cancellationToken); // 160
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 170
			Write(name.Code, writer, "code", cancellationToken); // 180
			Write(name.Subject, writer, "subject", cancellationToken); // 190
			Write(name.Encounter, writer, "encounter", cancellationToken); // 200
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 210
			Write(name.Author, writer, "author", cancellationToken); // 220
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 230
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 240
			Write(name.Note, writer, "note", cancellationToken); // 250
			Write(name.Action, writer, "action", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Write(ResearchDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Write(name.StatusElement, writer, "status", cancellationToken); // 160
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Write(name.DateElement, writer, "date", cancellationToken); // 190
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Write(name.Contact, writer, "contact", cancellationToken); // 210
			Write(name.Description, writer, "description", cancellationToken); // 220
			Write(name.CommentElement, writer, "comment", cancellationToken); // 230
			Write(name.UseContext, writer, "useContext", cancellationToken); // 240
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 250
			Write(name.Purpose, writer, "purpose", cancellationToken); // 260
			Write(name.UsageElement, writer, "usage", cancellationToken); // 270
			Write(name.Copyright, writer, "copyright", cancellationToken); // 280
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 290
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 300
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 310
			Write(name.Topic, writer, "topic", cancellationToken); // 320
			Write(name.Author, writer, "author", cancellationToken); // 330
			Write(name.Editor, writer, "editor", cancellationToken); // 340
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 350
			Write(name.Endorser, writer, "endorser", cancellationToken); // 360
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 370
			Write(name.LibraryElement, writer, "library", cancellationToken); // 380
			Write(name.Population, writer, "population", cancellationToken); // 390
			Write(name.Exposure, writer, "exposure", cancellationToken); // 400
			Write(name.ExposureAlternative, writer, "exposureAlternative", cancellationToken); // 410
			Write(name.Outcome, writer, "outcome", cancellationToken); // 420
			writer.WriteEndElement();
		}

		public static void Write(ResearchElementDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchElementDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.ShortTitleElement, writer, "shortTitle", cancellationToken); // 140
			Write(name.SubtitleElement, writer, "subtitle", cancellationToken); // 150
			Write(name.StatusElement, writer, "status", cancellationToken); // 160
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 170
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 180
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 180
			Write(name.DateElement, writer, "date", cancellationToken); // 190
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 200
			Write(name.Contact, writer, "contact", cancellationToken); // 210
			Write(name.Description, writer, "description", cancellationToken); // 220
			Write(name.CommentElement, writer, "comment", cancellationToken); // 230
			Write(name.UseContext, writer, "useContext", cancellationToken); // 240
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 250
			Write(name.Purpose, writer, "purpose", cancellationToken); // 260
			Write(name.UsageElement, writer, "usage", cancellationToken); // 270
			Write(name.Copyright, writer, "copyright", cancellationToken); // 280
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 290
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 300
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 310
			Write(name.Topic, writer, "topic", cancellationToken); // 320
			Write(name.Author, writer, "author", cancellationToken); // 330
			Write(name.Editor, writer, "editor", cancellationToken); // 340
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 350
			Write(name.Endorser, writer, "endorser", cancellationToken); // 360
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 370
			Write(name.LibraryElement, writer, "library", cancellationToken); // 380
			Write(name.TypeElement, writer, "type", cancellationToken); // 390
			Write(name.VariableTypeElement, writer, "variableType", cancellationToken); // 400
			Write(name.Characteristic, writer, "characteristic", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Write(ResearchStudy name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchStudy", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.TitleElement, writer, "title", cancellationToken); // 100
			Write(name.Protocol, writer, "protocol", cancellationToken); // 110
			Write(name.PartOf, writer, "partOf", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.PrimaryPurposeType, writer, "primaryPurposeType", cancellationToken); // 140
			Write(name.Phase, writer, "phase", cancellationToken); // 150
			Write(name.Category, writer, "category", cancellationToken); // 160
			Write(name.Focus, writer, "focus", cancellationToken); // 170
			Write(name.Condition, writer, "condition", cancellationToken); // 180
			Write(name.Contact, writer, "contact", cancellationToken); // 190
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 200
			Write(name.Keyword, writer, "keyword", cancellationToken); // 210
			Write(name.Location, writer, "location", cancellationToken); // 220
			Write(name.Description, writer, "description", cancellationToken); // 230
			Write(name.Enrollment, writer, "enrollment", cancellationToken); // 240
			Write(name.Period, writer, "period", cancellationToken); // 250
			Write(name.Sponsor, writer, "sponsor", cancellationToken); // 260
			Write(name.PrincipalInvestigator, writer, "principalInvestigator", cancellationToken); // 270
			Write(name.Site, writer, "site", cancellationToken); // 280
			Write(name.ReasonStopped, writer, "reasonStopped", cancellationToken); // 290
			Write(name.Note, writer, "note", cancellationToken); // 300
			Write(name.Arm, writer, "arm", cancellationToken); // 310
			Write(name.Objective, writer, "objective", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(ResearchSubject name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ResearchSubject", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Period, writer, "period", cancellationToken); // 110
			Write(name.Study, writer, "study", cancellationToken); // 120
			Write(name.Individual, writer, "individual", cancellationToken); // 130
			Write(name.AssignedArmElement, writer, "assignedArm", cancellationToken); // 140
			Write(name.ActualArmElement, writer, "actualArm", cancellationToken); // 150
			Write(name.Consent, writer, "consent", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(RiskAssessment name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RiskAssessment", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.Parent, writer, "parent", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.Method, writer, "method", cancellationToken); // 130
			Write(name.Code, writer, "code", cancellationToken); // 140
			Write(name.Subject, writer, "subject", cancellationToken); // 150
			Write(name.Encounter, writer, "encounter", cancellationToken); // 160
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 170
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 170
			Write(name.Condition, writer, "condition", cancellationToken); // 180
			Write(name.Performer, writer, "performer", cancellationToken); // 190
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 200
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 210
			Write(name.Basis, writer, "basis", cancellationToken); // 220
			Write(name.Prediction, writer, "prediction", cancellationToken); // 230
			Write(name.MitigationElement, writer, "mitigation", cancellationToken); // 240
			Write(name.Note, writer, "note", cancellationToken); // 250
			writer.WriteEndElement();
		}

		public static void Write(RiskEvidenceSynthesis name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("RiskEvidenceSynthesis", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Description, writer, "description", cancellationToken); // 180
			Write(name.Note, writer, "note", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Copyright, writer, "copyright", cancellationToken); // 220
			Write(name.ApprovalDateElement, writer, "approvalDate", cancellationToken); // 230
			Write(name.LastReviewDateElement, writer, "lastReviewDate", cancellationToken); // 240
			Write(name.EffectivePeriod, writer, "effectivePeriod", cancellationToken); // 250
			Write(name.Topic, writer, "topic", cancellationToken); // 260
			Write(name.Author, writer, "author", cancellationToken); // 270
			Write(name.Editor, writer, "editor", cancellationToken); // 280
			Write(name.Reviewer, writer, "reviewer", cancellationToken); // 290
			Write(name.Endorser, writer, "endorser", cancellationToken); // 300
			Write(name.RelatedArtifact, writer, "relatedArtifact", cancellationToken); // 310
			Write(name.SynthesisType, writer, "synthesisType", cancellationToken); // 320
			Write(name.StudyType, writer, "studyType", cancellationToken); // 330
			Write(name.Population, writer, "population", cancellationToken); // 340
			Write(name.Exposure, writer, "exposure", cancellationToken); // 350
			Write(name.Outcome, writer, "outcome", cancellationToken); // 360
			Write(name.SampleSize, writer, "sampleSize", cancellationToken); // 370
			Write(name.RiskEstimate, writer, "riskEstimate", cancellationToken); // 380
			Write(name.Certainty, writer, "certainty", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Write(Schedule name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Schedule", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ActiveElement, writer, "active", cancellationToken); // 100
			Write(name.ServiceCategory, writer, "serviceCategory", cancellationToken); // 110
			Write(name.ServiceType, writer, "serviceType", cancellationToken); // 120
			Write(name.Specialty, writer, "specialty", cancellationToken); // 130
			Write(name.Actor, writer, "actor", cancellationToken); // 140
			Write(name.PlanningHorizon, writer, "planningHorizon", cancellationToken); // 150
			Write(name.CommentElement, writer, "comment", cancellationToken); // 160
			writer.WriteEndElement();
		}

		public static void Write(SearchParameter name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SearchParameter", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.DerivedFromElement, writer, "derivedFrom", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Description, writer, "description", cancellationToken); // 180
			Write(name.UseContext, writer, "useContext", cancellationToken); // 190
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Write(name.Purpose, writer, "purpose", cancellationToken); // 210
			Write(name.CodeElement, writer, "code", cancellationToken); // 220
			Write(name.BaseElement, writer, "base", cancellationToken); // 230
			Write(name.TypeElement, writer, "type", cancellationToken); // 240
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 250
			Write(name.XpathElement, writer, "xpath", cancellationToken); // 260
			Write(name.XpathUsageElement, writer, "xpathUsage", cancellationToken); // 270
			Write(name.TargetElement, writer, "target", cancellationToken); // 280
			Write(name.MultipleOrElement, writer, "multipleOr", cancellationToken); // 290
			Write(name.MultipleAndElement, writer, "multipleAnd", cancellationToken); // 300
			Write(name.ComparatorElement, writer, "comparator", cancellationToken); // 310
			Write(name.ModifierElement, writer, "modifier", cancellationToken); // 320
			Write(name.ChainElement, writer, "chain", cancellationToken); // 330
			Write(name.Component, writer, "component", cancellationToken); // 340
			writer.WriteEndElement();
		}

		public static void Write(ServiceRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ServiceRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.Replaces, writer, "replaces", cancellationToken); // 130
			Write(name.Requisition, writer, "requisition", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.IntentElement, writer, "intent", cancellationToken); // 160
			Write(name.Category, writer, "category", cancellationToken); // 170
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 180
			Write(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 190
			Write(name.Code, writer, "code", cancellationToken); // 200
			Write(name.OrderDetail, writer, "orderDetail", cancellationToken); // 210
			Write(name.Quantity as Hl7.Fhir.Model.Quantity, writer, "quantityQuantity", cancellationToken); // 220
			Write(name.Quantity as Hl7.Fhir.Model.Ratio, writer, "quantityRatio", cancellationToken); // 220
			Write(name.Quantity as Hl7.Fhir.Model.Range, writer, "quantityRange", cancellationToken); // 220
			Write(name.Subject, writer, "subject", cancellationToken); // 230
			Write(name.Encounter, writer, "encounter", cancellationToken); // 240
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 250
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 250
			Write(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 250
			Write(name.AsNeeded as Hl7.Fhir.Model.FhirBoolean, writer, "asNeededBoolean", cancellationToken); // 260
			Write(name.AsNeeded as Hl7.Fhir.Model.CodeableConcept, writer, "asNeededCodeableConcept", cancellationToken); // 260
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 270
			Write(name.Requester, writer, "requester", cancellationToken); // 280
			Write(name.PerformerType, writer, "performerType", cancellationToken); // 290
			Write(name.Performer, writer, "performer", cancellationToken); // 300
			Write(name.LocationCode, writer, "locationCode", cancellationToken); // 310
			Write(name.LocationReference, writer, "locationReference", cancellationToken); // 320
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 330
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 340
			Write(name.Insurance, writer, "insurance", cancellationToken); // 350
			Write(name.SupportingInfo, writer, "supportingInfo", cancellationToken); // 360
			Write(name.Specimen, writer, "specimen", cancellationToken); // 370
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 380
			Write(name.Note, writer, "note", cancellationToken); // 390
			Write(name.PatientInstructionElement, writer, "patientInstruction", cancellationToken); // 400
			Write(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 410
			writer.WriteEndElement();
		}

		public static void Write(Slot name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Slot", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.ServiceCategory, writer, "serviceCategory", cancellationToken); // 100
			Write(name.ServiceType, writer, "serviceType", cancellationToken); // 110
			Write(name.Specialty, writer, "specialty", cancellationToken); // 120
			Write(name.AppointmentType, writer, "appointmentType", cancellationToken); // 130
			Write(name.Schedule, writer, "schedule", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.StartElement, writer, "start", cancellationToken); // 160
			Write(name.EndElement, writer, "end", cancellationToken); // 170
			Write(name.OverbookedElement, writer, "overbooked", cancellationToken); // 180
			Write(name.CommentElement, writer, "comment", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(Specimen name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Specimen", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.AccessionIdentifier, writer, "accessionIdentifier", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.Type, writer, "type", cancellationToken); // 120
			Write(name.Subject, writer, "subject", cancellationToken); // 130
			Write(name.ReceivedTimeElement, writer, "receivedTime", cancellationToken); // 140
			Write(name.Parent, writer, "parent", cancellationToken); // 150
			Write(name.Request, writer, "request", cancellationToken); // 160
			Write(name.Collection, writer, "collection", cancellationToken); // 170
			Write(name.Processing, writer, "processing", cancellationToken); // 180
			Write(name.Container, writer, "container", cancellationToken); // 190
			Write(name.Condition, writer, "condition", cancellationToken); // 200
			Write(name.Note, writer, "note", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(SpecimenDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SpecimenDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.TypeCollected, writer, "typeCollected", cancellationToken); // 100
			Write(name.PatientPreparation, writer, "patientPreparation", cancellationToken); // 110
			Write(name.TimeAspectElement, writer, "timeAspect", cancellationToken); // 120
			Write(name.Collection, writer, "collection", cancellationToken); // 130
			Write(name.TypeTested, writer, "typeTested", cancellationToken); // 140
			writer.WriteEndElement();
		}

		public static void Write(StructureDefinition name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("StructureDefinition", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Purpose, writer, "purpose", cancellationToken); // 220
			Write(name.Copyright, writer, "copyright", cancellationToken); // 230
			Write(name.Keyword, writer, "keyword", cancellationToken); // 240
			Write(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 250
			Write(name.Mapping, writer, "mapping", cancellationToken); // 260
			Write(name.KindElement, writer, "kind", cancellationToken); // 270
			Write(name.AbstractElement, writer, "abstract", cancellationToken); // 280
			Write(name.Context, writer, "context", cancellationToken); // 290
			Write(name.ContextInvariantElement, writer, "contextInvariant", cancellationToken); // 300
			Write(name.TypeElement, writer, "type", cancellationToken); // 310
			Write(name.BaseDefinitionElement, writer, "baseDefinition", cancellationToken); // 320
			Write(name.DerivationElement, writer, "derivation", cancellationToken); // 330
			Write(name.Snapshot, writer, "snapshot", cancellationToken); // 340
			Write(name.Differential, writer, "differential", cancellationToken); // 350
			writer.WriteEndElement();
		}

		public static void Write(StructureMap name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("StructureMap", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Purpose, writer, "purpose", cancellationToken); // 220
			Write(name.Copyright, writer, "copyright", cancellationToken); // 230
			Write(name.Structure, writer, "structure", cancellationToken); // 240
			Write(name.ImportElement, writer, "import", cancellationToken); // 250
			Write(name.Group, writer, "group", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Write(Subscription name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Subscription", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.StatusElement, writer, "status", cancellationToken); // 90
			Write(name.Contact, writer, "contact", cancellationToken); // 100
			Write(name.EndElement, writer, "end", cancellationToken); // 110
			Write(name.ReasonElement, writer, "reason", cancellationToken); // 120
			Write(name.CriteriaElement, writer, "criteria", cancellationToken); // 130
			Write(name.ErrorElement, writer, "error", cancellationToken); // 140
			Write(name.Channel, writer, "channel", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(Substance name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Substance", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Category, writer, "category", cancellationToken); // 110
			Write(name.Code, writer, "code", cancellationToken); // 120
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 130
			Write(name.Instance, writer, "instance", cancellationToken); // 140
			Write(name.Ingredient, writer, "ingredient", cancellationToken); // 150
			writer.WriteEndElement();
		}

		public static void Write(SubstanceNucleicAcid name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceNucleicAcid", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.SequenceType, writer, "sequenceType", cancellationToken); // 90
			Write(name.NumberOfSubunitsElement, writer, "numberOfSubunits", cancellationToken); // 100
			Write(name.AreaOfHybridisationElement, writer, "areaOfHybridisation", cancellationToken); // 110
			Write(name.OligoNucleotideType, writer, "oligoNucleotideType", cancellationToken); // 120
			Write(name.Subunit, writer, "subunit", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Write(SubstancePolymer name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstancePolymer", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Class, writer, "class", cancellationToken); // 90
			Write(name.Geometry, writer, "geometry", cancellationToken); // 100
			Write(name.CopolymerConnectivity, writer, "copolymerConnectivity", cancellationToken); // 110
			Write(name.ModificationElement, writer, "modification", cancellationToken); // 120
			Write(name.MonomerSet, writer, "monomerSet", cancellationToken); // 130
			Write(name.Repeat, writer, "repeat", cancellationToken); // 140
			writer.WriteEndElement();
		}

		public static void Write(SubstanceProtein name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceProtein", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.SequenceType, writer, "sequenceType", cancellationToken); // 90
			Write(name.NumberOfSubunitsElement, writer, "numberOfSubunits", cancellationToken); // 100
			Write(name.DisulfideLinkageElement, writer, "disulfideLinkage", cancellationToken); // 110
			Write(name.Subunit, writer, "subunit", cancellationToken); // 120
			writer.WriteEndElement();
		}

		public static void Write(SubstanceReferenceInformation name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceReferenceInformation", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.CommentElement, writer, "comment", cancellationToken); // 90
			Write(name.Gene, writer, "gene", cancellationToken); // 100
			Write(name.GeneElement, writer, "geneElement", cancellationToken); // 110
			Write(name.Classification, writer, "classification", cancellationToken); // 120
			Write(name.Target, writer, "target", cancellationToken); // 130
			writer.WriteEndElement();
		}

		public static void Write(SubstanceSourceMaterial name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceSourceMaterial", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.SourceMaterialClass, writer, "sourceMaterialClass", cancellationToken); // 90
			Write(name.SourceMaterialType, writer, "sourceMaterialType", cancellationToken); // 100
			Write(name.SourceMaterialState, writer, "sourceMaterialState", cancellationToken); // 110
			Write(name.OrganismId, writer, "organismId", cancellationToken); // 120
			Write(name.OrganismNameElement, writer, "organismName", cancellationToken); // 130
			Write(name.ParentSubstanceId, writer, "parentSubstanceId", cancellationToken); // 140
			Write(name.ParentSubstanceNameElement, writer, "parentSubstanceName", cancellationToken); // 150
			Write(name.CountryOfOrigin, writer, "countryOfOrigin", cancellationToken); // 160
			Write(name.GeographicalLocationElement, writer, "geographicalLocation", cancellationToken); // 170
			Write(name.DevelopmentStage, writer, "developmentStage", cancellationToken); // 180
			Write(name.FractionDescription, writer, "fractionDescription", cancellationToken); // 190
			Write(name.Organism, writer, "organism", cancellationToken); // 200
			Write(name.PartDescription, writer, "partDescription", cancellationToken); // 210
			writer.WriteEndElement();
		}

		public static void Write(SubstanceSpecification name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SubstanceSpecification", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Type, writer, "type", cancellationToken); // 100
			Write(name.Status, writer, "status", cancellationToken); // 110
			Write(name.Domain, writer, "domain", cancellationToken); // 120
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 130
			Write(name.Source, writer, "source", cancellationToken); // 140
			Write(name.CommentElement, writer, "comment", cancellationToken); // 150
			Write(name.Moiety, writer, "moiety", cancellationToken); // 160
			Write(name.Property, writer, "property", cancellationToken); // 170
			Write(name.ReferenceInformation, writer, "referenceInformation", cancellationToken); // 180
			Write(name.Structure, writer, "structure", cancellationToken); // 190
			Write(name.Code, writer, "code", cancellationToken); // 200
			Write(name.Name, writer, "name", cancellationToken); // 210
			Write(name.MolecularWeight, writer, "molecularWeight", cancellationToken); // 220
			Write(name.Relationship, writer, "relationship", cancellationToken); // 230
			Write(name.NucleicAcid, writer, "nucleicAcid", cancellationToken); // 240
			Write(name.Polymer, writer, "polymer", cancellationToken); // 250
			Write(name.Protein, writer, "protein", cancellationToken); // 260
			Write(name.SourceMaterial, writer, "sourceMaterial", cancellationToken); // 270
			writer.WriteEndElement();
		}

		public static void Write(SupplyDelivery name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SupplyDelivery", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 100
			Write(name.PartOf, writer, "partOf", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.Patient, writer, "patient", cancellationToken); // 130
			Write(name.Type, writer, "type", cancellationToken); // 140
			Write(name.SuppliedItem, writer, "suppliedItem", cancellationToken); // 150
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 160
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 160
			Write(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 160
			Write(name.Supplier, writer, "supplier", cancellationToken); // 170
			Write(name.Destination, writer, "destination", cancellationToken); // 180
			Write(name.Receiver, writer, "receiver", cancellationToken); // 190
			writer.WriteEndElement();
		}

		public static void Write(SupplyRequest name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("SupplyRequest", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.Category, writer, "category", cancellationToken); // 110
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 120
			Write(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 130
			Write(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 130
			Write(name.Quantity, writer, "quantity", cancellationToken); // 140
			Write(name.Parameter, writer, "parameter", cancellationToken); // 150
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 160
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 160
			Write(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 160
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 170
			Write(name.Requester, writer, "requester", cancellationToken); // 180
			Write(name.Supplier, writer, "supplier", cancellationToken); // 190
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 200
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 210
			Write(name.DeliverFrom, writer, "deliverFrom", cancellationToken); // 220
			Write(name.DeliverTo, writer, "deliverTo", cancellationToken); // 230
			writer.WriteEndElement();
		}

		public static void Write(Task name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("Task", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 100
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 110
			Write(name.BasedOn, writer, "basedOn", cancellationToken); // 120
			Write(name.GroupIdentifier, writer, "groupIdentifier", cancellationToken); // 130
			Write(name.PartOf, writer, "partOf", cancellationToken); // 140
			Write(name.StatusElement, writer, "status", cancellationToken); // 150
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 160
			Write(name.BusinessStatus, writer, "businessStatus", cancellationToken); // 170
			Write(name.IntentElement, writer, "intent", cancellationToken); // 180
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 190
			Write(name.Code, writer, "code", cancellationToken); // 200
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 210
			Write(name.Focus, writer, "focus", cancellationToken); // 220
			Write(name.For, writer, "for", cancellationToken); // 230
			Write(name.Encounter, writer, "encounter", cancellationToken); // 240
			Write(name.ExecutionPeriod, writer, "executionPeriod", cancellationToken); // 250
			Write(name.AuthoredOnElement, writer, "authoredOn", cancellationToken); // 260
			Write(name.LastModifiedElement, writer, "lastModified", cancellationToken); // 270
			Write(name.Requester, writer, "requester", cancellationToken); // 280
			Write(name.PerformerType, writer, "performerType", cancellationToken); // 290
			Write(name.Owner, writer, "owner", cancellationToken); // 300
			Write(name.Location, writer, "location", cancellationToken); // 310
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 320
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 330
			Write(name.Insurance, writer, "insurance", cancellationToken); // 340
			Write(name.Note, writer, "note", cancellationToken); // 350
			Write(name.RelevantHistory, writer, "relevantHistory", cancellationToken); // 360
			Write(name.Restriction, writer, "restriction", cancellationToken); // 370
			Write(name.Input, writer, "input", cancellationToken); // 380
			Write(name.Output, writer, "output", cancellationToken); // 390
			writer.WriteEndElement();
		}

		public static void Write(TerminologyCapabilities name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("TerminologyCapabilities", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.VersionElement, writer, "version", cancellationToken); // 100
			Write(name.NameElement, writer, "name", cancellationToken); // 110
			Write(name.TitleElement, writer, "title", cancellationToken); // 120
			Write(name.StatusElement, writer, "status", cancellationToken); // 130
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 140
			Write(name.DateElement, writer, "date", cancellationToken); // 150
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 160
			Write(name.Contact, writer, "contact", cancellationToken); // 170
			Write(name.Description, writer, "description", cancellationToken); // 180
			Write(name.UseContext, writer, "useContext", cancellationToken); // 190
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 200
			Write(name.Purpose, writer, "purpose", cancellationToken); // 210
			Write(name.Copyright, writer, "copyright", cancellationToken); // 220
			Write(name.KindElement, writer, "kind", cancellationToken); // 230
			Write(name.Software, writer, "software", cancellationToken); // 240
			Write(name.Implementation, writer, "implementation", cancellationToken); // 250
			Write(name.LockedDateElement, writer, "lockedDate", cancellationToken); // 260
			Write(name.CodeSystem, writer, "codeSystem", cancellationToken); // 270
			Write(name.Expansion, writer, "expansion", cancellationToken); // 280
			Write(name.CodeSearchElement, writer, "codeSearch", cancellationToken); // 290
			Write(name.ValidateCode, writer, "validateCode", cancellationToken); // 300
			Write(name.Translation, writer, "translation", cancellationToken); // 310
			Write(name.Closure, writer, "closure", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(TestReport name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("TestReport", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.NameElement, writer, "name", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.TestScript, writer, "testScript", cancellationToken); // 120
			Write(name.ResultElement, writer, "result", cancellationToken); // 130
			Write(name.ScoreElement, writer, "score", cancellationToken); // 140
			Write(name.TesterElement, writer, "tester", cancellationToken); // 150
			Write(name.IssuedElement, writer, "issued", cancellationToken); // 160
			Write(name.Participant, writer, "participant", cancellationToken); // 170
			Write(name.Setup, writer, "setup", cancellationToken); // 180
			Write(name.Test, writer, "test", cancellationToken); // 190
			Write(name.Teardown, writer, "teardown", cancellationToken); // 200
			writer.WriteEndElement();
		}

		public static void Write(TestScript name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("TestScript", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.Purpose, writer, "purpose", cancellationToken); // 220
			Write(name.Copyright, writer, "copyright", cancellationToken); // 230
			Write(name.Origin, writer, "origin", cancellationToken); // 240
			Write(name.Destination, writer, "destination", cancellationToken); // 250
			Write(name.Metadata, writer, "metadata", cancellationToken); // 260
			Write(name.Fixture, writer, "fixture", cancellationToken); // 270
			Write(name.Profile, writer, "profile", cancellationToken); // 280
			Write(name.Variable, writer, "variable", cancellationToken); // 290
			Write(name.Setup, writer, "setup", cancellationToken); // 300
			Write(name.Test, writer, "test", cancellationToken); // 310
			Write(name.Teardown, writer, "teardown", cancellationToken); // 320
			writer.WriteEndElement();
		}

		public static void Write(ValueSet name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("ValueSet", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.UrlElement, writer, "url", cancellationToken); // 90
			Write(name.Identifier, writer, "identifier", cancellationToken); // 100
			Write(name.VersionElement, writer, "version", cancellationToken); // 110
			Write(name.NameElement, writer, "name", cancellationToken); // 120
			Write(name.TitleElement, writer, "title", cancellationToken); // 130
			Write(name.StatusElement, writer, "status", cancellationToken); // 140
			Write(name.ExperimentalElement, writer, "experimental", cancellationToken); // 150
			Write(name.DateElement, writer, "date", cancellationToken); // 160
			Write(name.PublisherElement, writer, "publisher", cancellationToken); // 170
			Write(name.Contact, writer, "contact", cancellationToken); // 180
			Write(name.Description, writer, "description", cancellationToken); // 190
			Write(name.UseContext, writer, "useContext", cancellationToken); // 200
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 210
			Write(name.ImmutableElement, writer, "immutable", cancellationToken); // 220
			Write(name.Purpose, writer, "purpose", cancellationToken); // 230
			Write(name.Copyright, writer, "copyright", cancellationToken); // 240
			Write(name.Compose, writer, "compose", cancellationToken); // 250
			Write(name.Expansion, writer, "expansion", cancellationToken); // 260
			writer.WriteEndElement();
		}

		public static void Write(VerificationResult name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("VerificationResult", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Target, writer, "target", cancellationToken); // 90
			Write(name.TargetLocationElement, writer, "targetLocation", cancellationToken); // 100
			Write(name.Need, writer, "need", cancellationToken); // 110
			Write(name.StatusElement, writer, "status", cancellationToken); // 120
			Write(name.StatusDateElement, writer, "statusDate", cancellationToken); // 130
			Write(name.ValidationType, writer, "validationType", cancellationToken); // 140
			Write(name.ValidationProcess, writer, "validationProcess", cancellationToken); // 150
			Write(name.Frequency, writer, "frequency", cancellationToken); // 160
			Write(name.LastPerformedElement, writer, "lastPerformed", cancellationToken); // 170
			Write(name.NextScheduledElement, writer, "nextScheduled", cancellationToken); // 180
			Write(name.FailureAction, writer, "failureAction", cancellationToken); // 190
			Write(name.PrimarySource, writer, "primarySource", cancellationToken); // 200
			Write(name.Attestation, writer, "attestation", cancellationToken); // 210
			Write(name.Validator, writer, "validator", cancellationToken); // 220
			writer.WriteEndElement();
		}

		public static void Write(VisionPrescription name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement("VisionPrescription", XmlNs.FHIR);
			WriteDomainResource(name, writer, cancellationToken);
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.StatusElement, writer, "status", cancellationToken); // 100
			Write(name.CreatedElement, writer, "created", cancellationToken); // 110
			Write(name.Patient, writer, "patient", cancellationToken); // 120
			Write(name.Encounter, writer, "encounter", cancellationToken); // 130
			Write(name.DateWrittenElement, writer, "dateWritten", cancellationToken); // 140
			Write(name.Prescriber, writer, "prescriber", cancellationToken); // 150
			Write(name.LensSpecification, writer, "lensSpecification", cancellationToken); // 160
			writer.WriteEndElement();
		}

// ---------------------------
		// Hl7.Fhir.Model.Address
		public static void Write(Hl7.Fhir.Model.Address name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.UseElement, writer, "use", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.TextElement, writer, "text", cancellationToken); // 50
			Write(name.LineElement, writer, "line", cancellationToken); // 60
			Write(name.CityElement, writer, "city", cancellationToken); // 70
			Write(name.DistrictElement, writer, "district", cancellationToken); // 80
			Write(name.StateElement, writer, "state", cancellationToken); // 90
			Write(name.PostalCodeElement, writer, "postalCode", cancellationToken); // 100
			Write(name.CountryElement, writer, "country", cancellationToken); // 110
			Write(name.Period, writer, "period", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Age
		public static void Write(Hl7.Fhir.Model.Age name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ValueElement, writer, "value", cancellationToken); // 30
			Write(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Write(name.UnitElement, writer, "unit", cancellationToken); // 50
			Write(name.SystemElement, writer, "system", cancellationToken); // 60
			Write(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Annotation
		public static void Write(Hl7.Fhir.Model.Annotation name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Author as Hl7.Fhir.Model.ResourceReference, writer, "authorReference", cancellationToken); // 30
			Write(name.Author as Hl7.Fhir.Model.FhirString, writer, "authorString", cancellationToken); // 30
			Write(name.TimeElement, writer, "time", cancellationToken); // 40
			Write(name.Text, writer, "text", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Attachment
		public static void Write(Hl7.Fhir.Model.Attachment name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ContentTypeElement, writer, "contentType", cancellationToken); // 30
			Write(name.LanguageElement, writer, "language", cancellationToken); // 40
			Write(name.DataElement, writer, "data", cancellationToken); // 50
			Write(name.UrlElement, writer, "url", cancellationToken); // 60
			Write(name.SizeElement, writer, "size", cancellationToken); // 70
			Write(name.HashElement, writer, "hash", cancellationToken); // 80
			Write(name.TitleElement, writer, "title", cancellationToken); // 90
			Write(name.CreationElement, writer, "creation", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BackboneElement
		public static void Write(Hl7.Fhir.Model.BackboneElement name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Base64Binary
		public static void Write(Hl7.Fhir.Model.Base64Binary name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirBoolean
		public static void Write(Hl7.Fhir.Model.FhirBoolean name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Canonical
		public static void Write(Hl7.Fhir.Model.Canonical name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Code
		public static void Write(Hl7.Fhir.Model.Code name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeableConcept
		public static void Write(Hl7.Fhir.Model.CodeableConcept name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Coding, writer, "coding", cancellationToken); // 30
			Write(name.TextElement, writer, "text", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Coding
		public static void Write(Hl7.Fhir.Model.Coding name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.SystemElement, writer, "system", cancellationToken); // 30
			Write(name.VersionElement, writer, "version", cancellationToken); // 40
			Write(name.CodeElement, writer, "code", cancellationToken); // 50
			Write(name.DisplayElement, writer, "display", cancellationToken); // 60
			Write(name.UserSelectedElement, writer, "userSelected", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ContactDetail
		public static void Write(Hl7.Fhir.Model.ContactDetail name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.NameElement, writer, "name", cancellationToken); // 30
			Write(name.Telecom, writer, "telecom", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ContactPoint
		public static void Write(Hl7.Fhir.Model.ContactPoint name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.SystemElement, writer, "system", cancellationToken); // 30
			Write(name.ValueElement, writer, "value", cancellationToken); // 40
			Write(name.UseElement, writer, "use", cancellationToken); // 50
			Write(name.RankElement, writer, "rank", cancellationToken); // 60
			Write(name.Period, writer, "period", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contributor
		public static void Write(Hl7.Fhir.Model.Contributor name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.TypeElement, writer, "type", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Contact, writer, "contact", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Count
		public static void Write(Hl7.Fhir.Model.Count name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ValueElement, writer, "value", cancellationToken); // 30
			Write(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Write(name.UnitElement, writer, "unit", cancellationToken); // 50
			Write(name.SystemElement, writer, "system", cancellationToken); // 60
			Write(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DataRequirement
		public static void Write(Hl7.Fhir.Model.DataRequirement name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.TypeElement, writer, "type", cancellationToken); // 30
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 40
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 50
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 50
			Write(name.MustSupportElement, writer, "mustSupport", cancellationToken); // 60
			Write(name.CodeFilter, writer, "codeFilter", cancellationToken); // 70
			Write(name.DateFilter, writer, "dateFilter", cancellationToken); // 80
			Write(name.LimitElement, writer, "limit", cancellationToken); // 90
			Write(name.Sort, writer, "sort", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DataRequirement.CodeFilterComponent
		public static void Write(Hl7.Fhir.Model.DataRequirement.CodeFilterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.SearchParamElement, writer, "searchParam", cancellationToken); // 50
			Write(name.ValueSetElement, writer, "valueSet", cancellationToken); // 60
			Write(name.Code, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DataRequirement.DateFilterComponent
		public static void Write(Hl7.Fhir.Model.DataRequirement.DateFilterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.SearchParamElement, writer, "searchParam", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 60
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 60
			Write(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DataRequirement.SortComponent
		public static void Write(Hl7.Fhir.Model.DataRequirement.SortComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.DirectionElement, writer, "direction", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Date
		public static void Write(Hl7.Fhir.Model.Date name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirDateTime
		public static void Write(Hl7.Fhir.Model.FhirDateTime name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirDecimal
		public static void Write(Hl7.Fhir.Model.FhirDecimal name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Distance
		public static void Write(Hl7.Fhir.Model.Distance name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ValueElement, writer, "value", cancellationToken); // 30
			Write(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Write(name.UnitElement, writer, "unit", cancellationToken); // 50
			Write(name.SystemElement, writer, "system", cancellationToken); // 60
			Write(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Dosage
		public static void Write(Hl7.Fhir.Model.Dosage name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 90
			Write(name.TextElement, writer, "text", cancellationToken); // 100
			Write(name.AdditionalInstruction, writer, "additionalInstruction", cancellationToken); // 110
			Write(name.PatientInstructionElement, writer, "patientInstruction", cancellationToken); // 120
			Write(name.Timing, writer, "timing", cancellationToken); // 130
			Write(name.AsNeeded as Hl7.Fhir.Model.FhirBoolean, writer, "asNeededBoolean", cancellationToken); // 140
			Write(name.AsNeeded as Hl7.Fhir.Model.CodeableConcept, writer, "asNeededCodeableConcept", cancellationToken); // 140
			Write(name.Site, writer, "site", cancellationToken); // 150
			Write(name.Route, writer, "route", cancellationToken); // 160
			Write(name.Method, writer, "method", cancellationToken); // 170
			Write(name.DoseAndRate, writer, "doseAndRate", cancellationToken); // 180
			Write(name.MaxDosePerPeriod, writer, "maxDosePerPeriod", cancellationToken); // 190
			Write(name.MaxDosePerAdministration, writer, "maxDosePerAdministration", cancellationToken); // 200
			Write(name.MaxDosePerLifetime, writer, "maxDosePerLifetime", cancellationToken); // 210
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Dosage.DoseAndRateComponent
		public static void Write(Hl7.Fhir.Model.Dosage.DoseAndRateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Dose as Hl7.Fhir.Model.Range, writer, "doseRange", cancellationToken); // 50
			Write(name.Dose as Hl7.Fhir.Model.Quantity, writer, "doseQuantity", cancellationToken); // 50
			Write(name.Rate as Hl7.Fhir.Model.Ratio, writer, "rateRatio", cancellationToken); // 60
			Write(name.Rate as Hl7.Fhir.Model.Range, writer, "rateRange", cancellationToken); // 60
			Write(name.Rate as Hl7.Fhir.Model.Quantity, writer, "rateQuantity", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition
		public static void Write(Hl7.Fhir.Model.ElementDefinition name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PathElement, writer, "path", cancellationToken); // 90
			Write(name.RepresentationElement, writer, "representation", cancellationToken); // 100
			Write(name.SliceNameElement, writer, "sliceName", cancellationToken); // 110
			Write(name.SliceIsConstrainingElement, writer, "sliceIsConstraining", cancellationToken); // 120
			Write(name.LabelElement, writer, "label", cancellationToken); // 130
			Write(name.Code, writer, "code", cancellationToken); // 140
			Write(name.Slicing, writer, "slicing", cancellationToken); // 150
			Write(name.ShortElement, writer, "short", cancellationToken); // 160
			Write(name.Definition, writer, "definition", cancellationToken); // 170
			Write(name.Comment, writer, "comment", cancellationToken); // 180
			Write(name.Requirements, writer, "requirements", cancellationToken); // 190
			Write(name.AliasElement, writer, "alias", cancellationToken); // 200
			Write(name.MinElement, writer, "min", cancellationToken); // 210
			Write(name.MaxElement, writer, "max", cancellationToken); // 220
			Write(name.Base, writer, "base", cancellationToken); // 230
			Write(name.ContentReferenceElement, writer, "contentReference", cancellationToken); // 240
			Write(name.Type, writer, "type", cancellationToken); // 250
			Write(name.DefaultValue as Hl7.Fhir.Model.Base64Binary, writer, "defaultValueBase64Binary", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirBoolean, writer, "defaultValueBoolean", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Canonical, writer, "defaultValueCanonical", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Code, writer, "defaultValueCode", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Date, writer, "defaultValueDate", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirDateTime, writer, "defaultValueDateTime", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirDecimal, writer, "defaultValueDecimal", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Id, writer, "defaultValueId", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Instant, writer, "defaultValueInstant", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Integer, writer, "defaultValueInteger", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Markdown, writer, "defaultValueMarkdown", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Oid, writer, "defaultValueOid", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.PositiveInt, writer, "defaultValuePositiveInt", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirString, writer, "defaultValueString", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Time, writer, "defaultValueTime", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.UnsignedInt, writer, "defaultValueUnsignedInt", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirUri, writer, "defaultValueUri", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirUrl, writer, "defaultValueUrl", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Uuid, writer, "defaultValueUuid", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Address, writer, "defaultValueAddress", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Age, writer, "defaultValueAge", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Annotation, writer, "defaultValueAnnotation", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Attachment, writer, "defaultValueAttachment", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.CodeableConcept, writer, "defaultValueCodeableConcept", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Coding, writer, "defaultValueCoding", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.ContactPoint, writer, "defaultValueContactPoint", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Count, writer, "defaultValueCount", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Distance, writer, "defaultValueDistance", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Duration, writer, "defaultValueDuration", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.HumanName, writer, "defaultValueHumanName", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Identifier, writer, "defaultValueIdentifier", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Money, writer, "defaultValueMoney", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Period, writer, "defaultValuePeriod", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Quantity, writer, "defaultValueQuantity", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Range, writer, "defaultValueRange", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Ratio, writer, "defaultValueRatio", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.ResourceReference, writer, "defaultValueReference", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.SampledData, writer, "defaultValueSampledData", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Signature, writer, "defaultValueSignature", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Timing, writer, "defaultValueTiming", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.ContactDetail, writer, "defaultValueContactDetail", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Contributor, writer, "defaultValueContributor", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.DataRequirement, writer, "defaultValueDataRequirement", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Expression, writer, "defaultValueExpression", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, writer, "defaultValueParameterDefinition", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, writer, "defaultValueRelatedArtifact", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, writer, "defaultValueTriggerDefinition", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.UsageContext, writer, "defaultValueUsageContext", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Dosage, writer, "defaultValueDosage", cancellationToken); // 260
			Write(name.DefaultValue as Hl7.Fhir.Model.Meta, writer, "defaultValueMeta", cancellationToken); // 260
			Write(name.MeaningWhenMissing, writer, "meaningWhenMissing", cancellationToken); // 270
			Write(name.OrderMeaningElement, writer, "orderMeaning", cancellationToken); // 280
			Write(name.Fixed as Hl7.Fhir.Model.Base64Binary, writer, "fixedBase64Binary", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.FhirBoolean, writer, "fixedBoolean", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Canonical, writer, "fixedCanonical", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Code, writer, "fixedCode", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Date, writer, "fixedDate", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.FhirDateTime, writer, "fixedDateTime", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.FhirDecimal, writer, "fixedDecimal", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Id, writer, "fixedId", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Instant, writer, "fixedInstant", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Integer, writer, "fixedInteger", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Markdown, writer, "fixedMarkdown", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Oid, writer, "fixedOid", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.PositiveInt, writer, "fixedPositiveInt", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.FhirString, writer, "fixedString", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Time, writer, "fixedTime", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.UnsignedInt, writer, "fixedUnsignedInt", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.FhirUri, writer, "fixedUri", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.FhirUrl, writer, "fixedUrl", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Uuid, writer, "fixedUuid", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Address, writer, "fixedAddress", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Age, writer, "fixedAge", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Annotation, writer, "fixedAnnotation", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Attachment, writer, "fixedAttachment", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.CodeableConcept, writer, "fixedCodeableConcept", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Coding, writer, "fixedCoding", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.ContactPoint, writer, "fixedContactPoint", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Count, writer, "fixedCount", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Distance, writer, "fixedDistance", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Duration, writer, "fixedDuration", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.HumanName, writer, "fixedHumanName", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Identifier, writer, "fixedIdentifier", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Money, writer, "fixedMoney", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Period, writer, "fixedPeriod", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Quantity, writer, "fixedQuantity", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Range, writer, "fixedRange", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Ratio, writer, "fixedRatio", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.ResourceReference, writer, "fixedReference", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.SampledData, writer, "fixedSampledData", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Signature, writer, "fixedSignature", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Timing, writer, "fixedTiming", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.ContactDetail, writer, "fixedContactDetail", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Contributor, writer, "fixedContributor", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.DataRequirement, writer, "fixedDataRequirement", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Expression, writer, "fixedExpression", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.ParameterDefinition, writer, "fixedParameterDefinition", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.RelatedArtifact, writer, "fixedRelatedArtifact", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.TriggerDefinition, writer, "fixedTriggerDefinition", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.UsageContext, writer, "fixedUsageContext", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Dosage, writer, "fixedDosage", cancellationToken); // 290
			Write(name.Fixed as Hl7.Fhir.Model.Meta, writer, "fixedMeta", cancellationToken); // 290
			Write(name.Pattern as Hl7.Fhir.Model.Base64Binary, writer, "patternBase64Binary", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.FhirBoolean, writer, "patternBoolean", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Canonical, writer, "patternCanonical", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Code, writer, "patternCode", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Date, writer, "patternDate", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.FhirDateTime, writer, "patternDateTime", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.FhirDecimal, writer, "patternDecimal", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Id, writer, "patternId", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Instant, writer, "patternInstant", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Integer, writer, "patternInteger", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Markdown, writer, "patternMarkdown", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Oid, writer, "patternOid", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.PositiveInt, writer, "patternPositiveInt", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.FhirString, writer, "patternString", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Time, writer, "patternTime", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.UnsignedInt, writer, "patternUnsignedInt", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.FhirUri, writer, "patternUri", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.FhirUrl, writer, "patternUrl", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Uuid, writer, "patternUuid", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Address, writer, "patternAddress", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Age, writer, "patternAge", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Annotation, writer, "patternAnnotation", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Attachment, writer, "patternAttachment", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.CodeableConcept, writer, "patternCodeableConcept", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Coding, writer, "patternCoding", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.ContactPoint, writer, "patternContactPoint", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Count, writer, "patternCount", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Distance, writer, "patternDistance", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Duration, writer, "patternDuration", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.HumanName, writer, "patternHumanName", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Identifier, writer, "patternIdentifier", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Money, writer, "patternMoney", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Period, writer, "patternPeriod", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Quantity, writer, "patternQuantity", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Range, writer, "patternRange", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Ratio, writer, "patternRatio", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.ResourceReference, writer, "patternReference", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.SampledData, writer, "patternSampledData", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Signature, writer, "patternSignature", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Timing, writer, "patternTiming", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.ContactDetail, writer, "patternContactDetail", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Contributor, writer, "patternContributor", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.DataRequirement, writer, "patternDataRequirement", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Expression, writer, "patternExpression", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.ParameterDefinition, writer, "patternParameterDefinition", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.RelatedArtifact, writer, "patternRelatedArtifact", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.TriggerDefinition, writer, "patternTriggerDefinition", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.UsageContext, writer, "patternUsageContext", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Dosage, writer, "patternDosage", cancellationToken); // 300
			Write(name.Pattern as Hl7.Fhir.Model.Meta, writer, "patternMeta", cancellationToken); // 300
			Write(name.Example, writer, "example", cancellationToken); // 310
			Write(name.MinValue as Hl7.Fhir.Model.Date, writer, "minValueDate", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.FhirDateTime, writer, "minValueDateTime", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.Instant, writer, "minValueInstant", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.Time, writer, "minValueTime", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.FhirDecimal, writer, "minValueDecimal", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.Integer, writer, "minValueInteger", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.PositiveInt, writer, "minValuePositiveInt", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.UnsignedInt, writer, "minValueUnsignedInt", cancellationToken); // 320
			Write(name.MinValue as Hl7.Fhir.Model.Quantity, writer, "minValueQuantity", cancellationToken); // 320
			Write(name.MaxValue as Hl7.Fhir.Model.Date, writer, "maxValueDate", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.FhirDateTime, writer, "maxValueDateTime", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.Instant, writer, "maxValueInstant", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.Time, writer, "maxValueTime", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.FhirDecimal, writer, "maxValueDecimal", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.Integer, writer, "maxValueInteger", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.PositiveInt, writer, "maxValuePositiveInt", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.UnsignedInt, writer, "maxValueUnsignedInt", cancellationToken); // 330
			Write(name.MaxValue as Hl7.Fhir.Model.Quantity, writer, "maxValueQuantity", cancellationToken); // 330
			Write(name.MaxLengthElement, writer, "maxLength", cancellationToken); // 340
			Write(name.ConditionElement, writer, "condition", cancellationToken); // 350
			Write(name.Constraint, writer, "constraint", cancellationToken); // 360
			Write(name.MustSupportElement, writer, "mustSupport", cancellationToken); // 370
			Write(name.IsModifierElement, writer, "isModifier", cancellationToken); // 380
			Write(name.IsModifierReasonElement, writer, "isModifierReason", cancellationToken); // 390
			Write(name.IsSummaryElement, writer, "isSummary", cancellationToken); // 400
			Write(name.Binding, writer, "binding", cancellationToken); // 410
			Write(name.Mapping, writer, "mapping", cancellationToken); // 420
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.DiscriminatorComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.DiscriminatorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.PathElement, writer, "path", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.TypeRefComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.TypeRefComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 50
			Write(name.TargetProfileElement, writer, "targetProfile", cancellationToken); // 60
			Write(name.AggregationElement, writer, "aggregation", cancellationToken); // 70
			Write(name.VersioningElement, writer, "versioning", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.SlicingComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.SlicingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Discriminator, writer, "discriminator", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.OrderedElement, writer, "ordered", cancellationToken); // 60
			Write(name.RulesElement, writer, "rules", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.BaseComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.BaseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.MinElement, writer, "min", cancellationToken); // 50
			Write(name.MaxElement, writer, "max", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.ExampleComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.ExampleComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.LabelElement, writer, "label", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Canonical, writer, "valueCanonical", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Instant, writer, "valueInstant", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Markdown, writer, "valueMarkdown", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Oid, writer, "valueOid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.PositiveInt, writer, "valuePositiveInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UnsignedInt, writer, "valueUnsignedInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUrl, writer, "valueUrl", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Uuid, writer, "valueUuid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Address, writer, "valueAddress", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Age, writer, "valueAge", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Annotation, writer, "valueAnnotation", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactPoint, writer, "valueContactPoint", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Count, writer, "valueCount", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Distance, writer, "valueDistance", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.HumanName, writer, "valueHumanName", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Identifier, writer, "valueIdentifier", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Signature, writer, "valueSignature", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Timing, writer, "valueTiming", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactDetail, writer, "valueContactDetail", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Contributor, writer, "valueContributor", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.DataRequirement, writer, "valueDataRequirement", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Expression, writer, "valueExpression", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ParameterDefinition, writer, "valueParameterDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.RelatedArtifact, writer, "valueRelatedArtifact", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.TriggerDefinition, writer, "valueTriggerDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UsageContext, writer, "valueUsageContext", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Dosage, writer, "valueDosage", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Meta, writer, "valueMeta", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.ConstraintComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.ConstraintComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.KeyElement, writer, "key", cancellationToken); // 40
			Write(name.RequirementsElement, writer, "requirements", cancellationToken); // 50
			Write(name.SeverityElement, writer, "severity", cancellationToken); // 60
			Write(name.HumanElement, writer, "human", cancellationToken); // 70
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 80
			Write(name.XpathElement, writer, "xpath", cancellationToken); // 90
			Write(name.SourceElement, writer, "source", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.StrengthElement, writer, "strength", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.ValueSetElement, writer, "valueSet", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ElementDefinition.MappingComponent
		public static void Write(Hl7.Fhir.Model.ElementDefinition.MappingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.IdentityElement, writer, "identity", cancellationToken); // 40
			Write(name.LanguageElement, writer, "language", cancellationToken); // 50
			Write(name.MapElement, writer, "map", cancellationToken); // 60
			Write(name.CommentElement, writer, "comment", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Expression
		public static void Write(Hl7.Fhir.Model.Expression name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.LanguageElement, writer, "language", cancellationToken); // 50
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 60
			Write(name.ReferenceElement, writer, "reference", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Extension
		public static void Write(Hl7.Fhir.Model.Extension name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Url, writer, "url", cancellationToken); // 30
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Canonical, writer, "valueCanonical", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Instant, writer, "valueInstant", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Markdown, writer, "valueMarkdown", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Oid, writer, "valueOid", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.PositiveInt, writer, "valuePositiveInt", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.UnsignedInt, writer, "valueUnsignedInt", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirUrl, writer, "valueUrl", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Uuid, writer, "valueUuid", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Address, writer, "valueAddress", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Age, writer, "valueAge", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Annotation, writer, "valueAnnotation", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ContactPoint, writer, "valueContactPoint", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Count, writer, "valueCount", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Distance, writer, "valueDistance", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.HumanName, writer, "valueHumanName", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Identifier, writer, "valueIdentifier", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Signature, writer, "valueSignature", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Timing, writer, "valueTiming", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ContactDetail, writer, "valueContactDetail", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Contributor, writer, "valueContributor", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.DataRequirement, writer, "valueDataRequirement", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Expression, writer, "valueExpression", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ParameterDefinition, writer, "valueParameterDefinition", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.RelatedArtifact, writer, "valueRelatedArtifact", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.TriggerDefinition, writer, "valueTriggerDefinition", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.UsageContext, writer, "valueUsageContext", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Dosage, writer, "valueDosage", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.HumanName
		public static void Write(Hl7.Fhir.Model.HumanName name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.UseElement, writer, "use", cancellationToken); // 30
			Write(name.TextElement, writer, "text", cancellationToken); // 40
			Write(name.FamilyElement, writer, "family", cancellationToken); // 50
			Write(name.GivenElement, writer, "given", cancellationToken); // 60
			Write(name.PrefixElement, writer, "prefix", cancellationToken); // 70
			Write(name.SuffixElement, writer, "suffix", cancellationToken); // 80
			Write(name.Period, writer, "period", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Id
		public static void Write(Hl7.Fhir.Model.Id name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Identifier
		public static void Write(Hl7.Fhir.Model.Identifier name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.UseElement, writer, "use", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.SystemElement, writer, "system", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			Write(name.Period, writer, "period", cancellationToken); // 70
			Write(name.Assigner, writer, "assigner", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Instant
		public static void Write(Hl7.Fhir.Model.Instant name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Integer
		public static void Write(Hl7.Fhir.Model.Integer name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Markdown
		public static void Write(Hl7.Fhir.Model.Markdown name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MarketingStatus
		public static void Write(Hl7.Fhir.Model.MarketingStatus name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Country, writer, "country", cancellationToken); // 90
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 100
			Write(name.Status, writer, "status", cancellationToken); // 110
			Write(name.DateRange, writer, "dateRange", cancellationToken); // 120
			Write(name.RestoreDateElement, writer, "restoreDate", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Meta
		public static void Write(Hl7.Fhir.Model.Meta name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.VersionIdElement, writer, "versionId", cancellationToken); // 30
			Write(name.LastUpdatedElement, writer, "lastUpdated", cancellationToken); // 40
			Write(name.SourceElement, writer, "source", cancellationToken); // 50
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 60
			Write(name.Security, writer, "security", cancellationToken); // 70
			Write(name.Tag, writer, "tag", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Money
		public static void Write(Hl7.Fhir.Model.Money name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ValueElement, writer, "value", cancellationToken); // 30
			Write(name.CurrencyElement, writer, "currency", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Narrative
		public static void Write(Hl7.Fhir.Model.Narrative name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.StatusElement, writer, "status", cancellationToken); // 30
			// Xml Serialization: XHtml
			XElement.Parse(name.Div).WriteTo(writer); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Oid
		public static void Write(Hl7.Fhir.Model.Oid name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ParameterDefinition
		public static void Write(Hl7.Fhir.Model.ParameterDefinition name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.NameElement, writer, "name", cancellationToken); // 30
			Write(name.UseElement, writer, "use", cancellationToken); // 40
			Write(name.MinElement, writer, "min", cancellationToken); // 50
			Write(name.MaxElement, writer, "max", cancellationToken); // 60
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 70
			Write(name.TypeElement, writer, "type", cancellationToken); // 80
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Period
		public static void Write(Hl7.Fhir.Model.Period name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.StartElement, writer, "start", cancellationToken); // 30
			Write(name.EndElement, writer, "end", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Population
		public static void Write(Hl7.Fhir.Model.Population name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Age as Hl7.Fhir.Model.Range, writer, "ageRange", cancellationToken); // 90
			Write(name.Age as Hl7.Fhir.Model.CodeableConcept, writer, "ageCodeableConcept", cancellationToken); // 90
			Write(name.Gender, writer, "gender", cancellationToken); // 100
			Write(name.Race, writer, "race", cancellationToken); // 110
			Write(name.PhysiologicalCondition, writer, "physiologicalCondition", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PositiveInt
		public static void Write(Hl7.Fhir.Model.PositiveInt name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ProdCharacteristic
		public static void Write(Hl7.Fhir.Model.ProdCharacteristic name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Height, writer, "height", cancellationToken); // 90
			Write(name.Width, writer, "width", cancellationToken); // 100
			Write(name.Depth, writer, "depth", cancellationToken); // 110
			Write(name.Weight, writer, "weight", cancellationToken); // 120
			Write(name.NominalVolume, writer, "nominalVolume", cancellationToken); // 130
			Write(name.ExternalDiameter, writer, "externalDiameter", cancellationToken); // 140
			Write(name.ShapeElement, writer, "shape", cancellationToken); // 150
			Write(name.ColorElement, writer, "color", cancellationToken); // 160
			Write(name.ImprintElement, writer, "imprint", cancellationToken); // 170
			Write(name.Image, writer, "image", cancellationToken); // 180
			Write(name.Scoring, writer, "scoring", cancellationToken); // 190
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ProductShelfLife
		public static void Write(Hl7.Fhir.Model.ProductShelfLife name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			Write(name.Type, writer, "type", cancellationToken); // 100
			Write(name.Period, writer, "period", cancellationToken); // 110
			Write(name.SpecialPrecautionsForStorage, writer, "specialPrecautionsForStorage", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Quantity
		public static void Write(Hl7.Fhir.Model.Quantity name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ValueElement, writer, "value", cancellationToken); // 30
			Write(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Write(name.UnitElement, writer, "unit", cancellationToken); // 50
			Write(name.SystemElement, writer, "system", cancellationToken); // 60
			Write(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Range
		public static void Write(Hl7.Fhir.Model.Range name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Low, writer, "low", cancellationToken); // 30
			Write(name.High, writer, "high", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Ratio
		public static void Write(Hl7.Fhir.Model.Ratio name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Numerator, writer, "numerator", cancellationToken); // 30
			Write(name.Denominator, writer, "denominator", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ResourceReference
		public static void Write(Hl7.Fhir.Model.ResourceReference name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ReferenceElement, writer, "reference", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Identifier, writer, "identifier", cancellationToken); // 50
			Write(name.DisplayElement, writer, "display", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RelatedArtifact
		public static void Write(Hl7.Fhir.Model.RelatedArtifact name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.TypeElement, writer, "type", cancellationToken); // 30
			Write(name.LabelElement, writer, "label", cancellationToken); // 40
			Write(name.DisplayElement, writer, "display", cancellationToken); // 50
			Write(name.Citation, writer, "citation", cancellationToken); // 60
			Write(name.UrlElement, writer, "url", cancellationToken); // 70
			Write(name.Document, writer, "document", cancellationToken); // 80
			Write(name.ResourceElement, writer, "resource", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SampledData
		public static void Write(Hl7.Fhir.Model.SampledData name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Origin, writer, "origin", cancellationToken); // 30
			Write(name.PeriodElement, writer, "period", cancellationToken); // 40
			Write(name.FactorElement, writer, "factor", cancellationToken); // 50
			Write(name.LowerLimitElement, writer, "lowerLimit", cancellationToken); // 60
			Write(name.UpperLimitElement, writer, "upperLimit", cancellationToken); // 70
			Write(name.DimensionsElement, writer, "dimensions", cancellationToken); // 80
			Write(name.DataElement, writer, "data", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Signature
		public static void Write(Hl7.Fhir.Model.Signature name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Type, writer, "type", cancellationToken); // 30
			Write(name.WhenElement, writer, "when", cancellationToken); // 40
			Write(name.Who, writer, "who", cancellationToken); // 50
			Write(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 60
			Write(name.TargetFormatElement, writer, "targetFormat", cancellationToken); // 70
			Write(name.SigFormatElement, writer, "sigFormat", cancellationToken); // 80
			Write(name.DataElement, writer, "data", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirString
		public static void Write(Hl7.Fhir.Model.FhirString name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceAmount
		public static void Write(Hl7.Fhir.Model.SubstanceAmount name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Amount as Hl7.Fhir.Model.Quantity, writer, "amountQuantity", cancellationToken); // 90
			Write(name.Amount as Hl7.Fhir.Model.Range, writer, "amountRange", cancellationToken); // 90
			Write(name.Amount as Hl7.Fhir.Model.FhirString, writer, "amountString", cancellationToken); // 90
			Write(name.AmountType, writer, "amountType", cancellationToken); // 100
			Write(name.AmountTextElement, writer, "amountText", cancellationToken); // 110
			Write(name.ReferenceRange, writer, "referenceRange", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent
		public static void Write(Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.LowLimit, writer, "lowLimit", cancellationToken); // 40
			Write(name.HighLimit, writer, "highLimit", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Time
		public static void Write(Hl7.Fhir.Model.Time name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Timing
		public static void Write(Hl7.Fhir.Model.Timing name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.EventElement, writer, "event", cancellationToken); // 90
			Write(name.Repeat, writer, "repeat", cancellationToken); // 100
			Write(name.Code, writer, "code", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Timing.RepeatComponent
		public static void Write(Hl7.Fhir.Model.Timing.RepeatComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Bounds as Hl7.Fhir.Model.Duration, writer, "boundsDuration", cancellationToken); // 40
			Write(name.Bounds as Hl7.Fhir.Model.Range, writer, "boundsRange", cancellationToken); // 40
			Write(name.Bounds as Hl7.Fhir.Model.Period, writer, "boundsPeriod", cancellationToken); // 40
			Write(name.CountElement, writer, "count", cancellationToken); // 50
			Write(name.CountMaxElement, writer, "countMax", cancellationToken); // 60
			Write(name.DurationElement, writer, "duration", cancellationToken); // 70
			Write(name.DurationMaxElement, writer, "durationMax", cancellationToken); // 80
			Write(name.DurationUnitElement, writer, "durationUnit", cancellationToken); // 90
			Write(name.FrequencyElement, writer, "frequency", cancellationToken); // 100
			Write(name.FrequencyMaxElement, writer, "frequencyMax", cancellationToken); // 110
			Write(name.PeriodElement, writer, "period", cancellationToken); // 120
			Write(name.PeriodMaxElement, writer, "periodMax", cancellationToken); // 130
			Write(name.PeriodUnitElement, writer, "periodUnit", cancellationToken); // 140
			Write(name.DayOfWeekElement, writer, "dayOfWeek", cancellationToken); // 150
			Write(name.TimeOfDayElement, writer, "timeOfDay", cancellationToken); // 160
			Write(name.WhenElement, writer, "when", cancellationToken); // 170
			Write(name.OffsetElement, writer, "offset", cancellationToken); // 180
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TriggerDefinition
		public static void Write(Hl7.Fhir.Model.TriggerDefinition name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.TypeElement, writer, "type", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 50
			Write(name.Timing as Hl7.Fhir.Model.ResourceReference, writer, "timingReference", cancellationToken); // 50
			Write(name.Timing as Hl7.Fhir.Model.Date, writer, "timingDate", cancellationToken); // 50
			Write(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 50
			Write(name.Data, writer, "data", cancellationToken); // 60
			Write(name.Condition, writer, "condition", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.UnsignedInt
		public static void Write(Hl7.Fhir.Model.UnsignedInt name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirUri
		public static void Write(Hl7.Fhir.Model.FhirUri name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FhirUrl
		public static void Write(Hl7.Fhir.Model.FhirUrl name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.UsageContext
		public static void Write(Hl7.Fhir.Model.UsageContext name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.Code, writer, "code", cancellationToken); // 30
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Uuid
		public static void Write(Hl7.Fhir.Model.Uuid name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.XHtml
		public static void Write(Hl7.Fhir.Model.XHtml name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.Value, writer, "value", cancellationToken); // 30
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Account.CoverageComponent
		public static void Write(Hl7.Fhir.Model.Account.CoverageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Coverage, writer, "coverage", cancellationToken); // 40
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Account.GuarantorComponent
		public static void Write(Hl7.Fhir.Model.Account.GuarantorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Party, writer, "party", cancellationToken); // 40
			Write(name.OnHoldElement, writer, "onHold", cancellationToken); // 50
			Write(name.Period, writer, "period", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ActivityDefinition.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.ActivityDefinition.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ActivityDefinition.DynamicValueComponent
		public static void Write(Hl7.Fhir.Model.ActivityDefinition.DynamicValueComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.Expression, writer, "expression", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent
		public static void Write(Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Instance, writer, "instance", cancellationToken); // 40
			Write(name.Causality, writer, "causality", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AdverseEvent.CausalityComponent
		public static void Write(Hl7.Fhir.Model.AdverseEvent.CausalityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Assessment, writer, "assessment", cancellationToken); // 40
			Write(name.ProductRelatednessElement, writer, "productRelatedness", cancellationToken); // 50
			Write(name.Author, writer, "author", cancellationToken); // 60
			Write(name.Method, writer, "method", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent
		public static void Write(Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Substance, writer, "substance", cancellationToken); // 40
			Write(name.Manifestation, writer, "manifestation", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.OnsetElement, writer, "onset", cancellationToken); // 70
			Write(name.SeverityElement, writer, "severity", cancellationToken); // 80
			Write(name.ExposureRoute, writer, "exposureRoute", cancellationToken); // 90
			Write(name.Note, writer, "note", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Appointment.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.Appointment.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			Write(name.RequiredElement, writer, "required", cancellationToken); // 60
			Write(name.StatusElement, writer, "status", cancellationToken); // 70
			Write(name.Period, writer, "period", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AuditEvent.AgentComponent
		public static void Write(Hl7.Fhir.Model.AuditEvent.AgentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			Write(name.Who, writer, "who", cancellationToken); // 60
			Write(name.AltIdElement, writer, "altId", cancellationToken); // 70
			Write(name.NameElement, writer, "name", cancellationToken); // 80
			Write(name.RequestorElement, writer, "requestor", cancellationToken); // 90
			Write(name.Location, writer, "location", cancellationToken); // 100
			Write(name.PolicyElement, writer, "policy", cancellationToken); // 110
			Write(name.Media, writer, "media", cancellationToken); // 120
			Write(name.Network, writer, "network", cancellationToken); // 130
			Write(name.PurposeOfUse, writer, "purposeOfUse", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AuditEvent.NetworkComponent
		public static void Write(Hl7.Fhir.Model.AuditEvent.NetworkComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.AddressElement, writer, "address", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AuditEvent.SourceComponent
		public static void Write(Hl7.Fhir.Model.AuditEvent.SourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SiteElement, writer, "site", cancellationToken); // 40
			Write(name.Observer, writer, "observer", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AuditEvent.EntityComponent
		public static void Write(Hl7.Fhir.Model.AuditEvent.EntityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.What, writer, "what", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Role, writer, "role", cancellationToken); // 60
			Write(name.Lifecycle, writer, "lifecycle", cancellationToken); // 70
			Write(name.SecurityLabel, writer, "securityLabel", cancellationToken); // 80
			Write(name.NameElement, writer, "name", cancellationToken); // 90
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 100
			Write(name.QueryElement, writer, "query", cancellationToken); // 110
			Write(name.Detail, writer, "detail", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.AuditEvent.DetailComponent
		public static void Write(Hl7.Fhir.Model.AuditEvent.DetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent
		public static void Write(Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Collector, writer, "collector", cancellationToken); // 40
			Write(name.Source, writer, "source", cancellationToken); // 50
			Write(name.Collected as Hl7.Fhir.Model.FhirDateTime, writer, "collectedDateTime", cancellationToken); // 60
			Write(name.Collected as Hl7.Fhir.Model.Period, writer, "collectedPeriod", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent
		public static void Write(Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.Procedure, writer, "procedure", cancellationToken); // 50
			Write(name.Additive, writer, "additive", cancellationToken); // 60
			Write(name.Time as Hl7.Fhir.Model.FhirDateTime, writer, "timeDateTime", cancellationToken); // 70
			Write(name.Time as Hl7.Fhir.Model.Period, writer, "timePeriod", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent
		public static void Write(Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.Time as Hl7.Fhir.Model.FhirDateTime, writer, "timeDateTime", cancellationToken); // 50
			Write(name.Time as Hl7.Fhir.Model.Period, writer, "timePeriod", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent
		public static void Write(Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.TemperatureElement, writer, "temperature", cancellationToken); // 50
			Write(name.ScaleElement, writer, "scale", cancellationToken); // 60
			Write(name.Duration, writer, "duration", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Bundle.EntryComponent
		public static void Write(Hl7.Fhir.Model.Bundle.EntryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Link, writer, "link", cancellationToken); // 40
			Write(name.FullUrlElement, writer, "fullUrl", cancellationToken); // 50
			WriteBase(name.Resource, writer, "resource", cancellationToken); // 60
			Write(name.Search, writer, "search", cancellationToken); // 70
			Write(name.Request, writer, "request", cancellationToken); // 80
			Write(name.Response, writer, "response", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Bundle.LinkComponent
		public static void Write(Hl7.Fhir.Model.Bundle.LinkComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RelationElement, writer, "relation", cancellationToken); // 40
			Write(name.UrlElement, writer, "url", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Bundle.SearchComponent
		public static void Write(Hl7.Fhir.Model.Bundle.SearchComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ModeElement, writer, "mode", cancellationToken); // 40
			Write(name.ScoreElement, writer, "score", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Bundle.RequestComponent
		public static void Write(Hl7.Fhir.Model.Bundle.RequestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.MethodElement, writer, "method", cancellationToken); // 40
			Write(name.UrlElement, writer, "url", cancellationToken); // 50
			Write(name.IfNoneMatchElement, writer, "ifNoneMatch", cancellationToken); // 60
			Write(name.IfModifiedSinceElement, writer, "ifModifiedSince", cancellationToken); // 70
			Write(name.IfMatchElement, writer, "ifMatch", cancellationToken); // 80
			Write(name.IfNoneExistElement, writer, "ifNoneExist", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Bundle.ResponseComponent
		public static void Write(Hl7.Fhir.Model.Bundle.ResponseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StatusElement, writer, "status", cancellationToken); // 40
			Write(name.LocationElement, writer, "location", cancellationToken); // 50
			Write(name.EtagElement, writer, "etag", cancellationToken); // 60
			Write(name.LastModifiedElement, writer, "lastModified", cancellationToken); // 70
			WriteBase(name.Outcome, writer, "outcome", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.VersionElement, writer, "version", cancellationToken); // 50
			Write(name.ReleaseDateElement, writer, "releaseDate", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.UrlElement, writer, "url", cancellationToken); // 50
			Write(name.Custodian, writer, "custodian", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.RestComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.RestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ModeElement, writer, "mode", cancellationToken); // 40
			Write(name.Documentation, writer, "documentation", cancellationToken); // 50
			Write(name.Security, writer, "security", cancellationToken); // 60
			Write(name.Resource, writer, "resource", cancellationToken); // 70
			Write(name.Interaction, writer, "interaction", cancellationToken); // 80
			Write(name.SearchParam, writer, "searchParam", cancellationToken); // 90
			Write(name.Operation, writer, "operation", cancellationToken); // 100
			Write(name.CompartmentElement, writer, "compartment", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.SecurityComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.SecurityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CorsElement, writer, "cors", cancellationToken); // 40
			Write(name.Service, writer, "service", cancellationToken); // 50
			Write(name.Description, writer, "description", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.ResourceComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.ResourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 50
			Write(name.SupportedProfileElement, writer, "supportedProfile", cancellationToken); // 60
			Write(name.Documentation, writer, "documentation", cancellationToken); // 70
			Write(name.Interaction, writer, "interaction", cancellationToken); // 80
			Write(name.VersioningElement, writer, "versioning", cancellationToken); // 90
			Write(name.ReadHistoryElement, writer, "readHistory", cancellationToken); // 100
			Write(name.UpdateCreateElement, writer, "updateCreate", cancellationToken); // 110
			Write(name.ConditionalCreateElement, writer, "conditionalCreate", cancellationToken); // 120
			Write(name.ConditionalReadElement, writer, "conditionalRead", cancellationToken); // 130
			Write(name.ConditionalUpdateElement, writer, "conditionalUpdate", cancellationToken); // 140
			Write(name.ConditionalDeleteElement, writer, "conditionalDelete", cancellationToken); // 150
			Write(name.ReferencePolicyElement, writer, "referencePolicy", cancellationToken); // 160
			Write(name.SearchIncludeElement, writer, "searchInclude", cancellationToken); // 170
			Write(name.SearchRevIncludeElement, writer, "searchRevInclude", cancellationToken); // 180
			Write(name.SearchParam, writer, "searchParam", cancellationToken); // 190
			Write(name.Operation, writer, "operation", cancellationToken); // 200
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.ResourceInteractionComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.ResourceInteractionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.Documentation, writer, "documentation", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 50
			Write(name.TypeElement, writer, "type", cancellationToken); // 60
			Write(name.Documentation, writer, "documentation", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.OperationComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.OperationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 50
			Write(name.Documentation, writer, "documentation", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.SystemInteractionComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.SystemInteractionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.Documentation, writer, "documentation", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.MessagingComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.MessagingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 40
			Write(name.ReliableCacheElement, writer, "reliableCache", cancellationToken); // 50
			Write(name.Documentation, writer, "documentation", cancellationToken); // 60
			Write(name.SupportedMessage, writer, "supportedMessage", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.EndpointComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.EndpointComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Protocol, writer, "protocol", cancellationToken); // 40
			Write(name.AddressElement, writer, "address", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.SupportedMessageComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.SupportedMessageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ModeElement, writer, "mode", cancellationToken); // 40
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CapabilityStatement.DocumentComponent
		public static void Write(Hl7.Fhir.Model.CapabilityStatement.DocumentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ModeElement, writer, "mode", cancellationToken); // 40
			Write(name.Documentation, writer, "documentation", cancellationToken); // 50
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CarePlan.ActivityComponent
		public static void Write(Hl7.Fhir.Model.CarePlan.ActivityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.OutcomeCodeableConcept, writer, "outcomeCodeableConcept", cancellationToken); // 40
			Write(name.OutcomeReference, writer, "outcomeReference", cancellationToken); // 50
			Write(name.Progress, writer, "progress", cancellationToken); // 60
			Write(name.Reference, writer, "reference", cancellationToken); // 70
			Write(name.Detail, writer, "detail", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CarePlan.DetailComponent
		public static void Write(Hl7.Fhir.Model.CarePlan.DetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.KindElement, writer, "kind", cancellationToken); // 40
			Write(name.InstantiatesCanonicalElement, writer, "instantiatesCanonical", cancellationToken); // 50
			Write(name.InstantiatesUriElement, writer, "instantiatesUri", cancellationToken); // 60
			Write(name.Code, writer, "code", cancellationToken); // 70
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 80
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 90
			Write(name.Goal, writer, "goal", cancellationToken); // 100
			Write(name.StatusElement, writer, "status", cancellationToken); // 110
			Write(name.StatusReason, writer, "statusReason", cancellationToken); // 120
			Write(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 130
			Write(name.Scheduled as Hl7.Fhir.Model.Timing, writer, "scheduledTiming", cancellationToken); // 140
			Write(name.Scheduled as Hl7.Fhir.Model.Period, writer, "scheduledPeriod", cancellationToken); // 140
			Write(name.Scheduled as Hl7.Fhir.Model.FhirString, writer, "scheduledString", cancellationToken); // 140
			Write(name.Location, writer, "location", cancellationToken); // 150
			Write(name.Performer, writer, "performer", cancellationToken); // 160
			Write(name.Product as Hl7.Fhir.Model.CodeableConcept, writer, "productCodeableConcept", cancellationToken); // 170
			Write(name.Product as Hl7.Fhir.Model.ResourceReference, writer, "productReference", cancellationToken); // 170
			Write(name.DailyAmount, writer, "dailyAmount", cancellationToken); // 180
			Write(name.Quantity, writer, "quantity", cancellationToken); // 190
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 200
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CareTeam.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.CareTeam.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Role, writer, "role", cancellationToken); // 40
			Write(name.Member, writer, "member", cancellationToken); // 50
			Write(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 60
			Write(name.Period, writer, "period", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CatalogEntry.RelatedEntryComponent
		public static void Write(Hl7.Fhir.Model.CatalogEntry.RelatedEntryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RelationtypeElement, writer, "relationtype", cancellationToken); // 40
			Write(name.Item, writer, "item", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ChargeItem.PerformerComponent
		public static void Write(Hl7.Fhir.Model.ChargeItem.PerformerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Function, writer, "function", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent
		public static void Write(Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.LanguageElement, writer, "language", cancellationToken); // 50
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ChargeItemDefinition.PropertyGroupComponent
		public static void Write(Hl7.Fhir.Model.ChargeItemDefinition.PropertyGroupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Applicability, writer, "applicability", cancellationToken); // 40
			Write(name.PriceComponent, writer, "priceComponent", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ChargeItemDefinition.PriceComponentComponent
		public static void Write(Hl7.Fhir.Model.ChargeItemDefinition.PriceComponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			Write(name.FactorElement, writer, "factor", cancellationToken); // 60
			Write(name.Amount, writer, "amount", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.RelatedClaimComponent
		public static void Write(Hl7.Fhir.Model.Claim.RelatedClaimComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Claim, writer, "claim", cancellationToken); // 40
			Write(name.Relationship, writer, "relationship", cancellationToken); // 50
			Write(name.Reference, writer, "reference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.PayeeComponent
		public static void Write(Hl7.Fhir.Model.Claim.PayeeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Party, writer, "party", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.CareTeamComponent
		public static void Write(Hl7.Fhir.Model.Claim.CareTeamComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Provider, writer, "provider", cancellationToken); // 50
			Write(name.ResponsibleElement, writer, "responsible", cancellationToken); // 60
			Write(name.Role, writer, "role", cancellationToken); // 70
			Write(name.Qualification, writer, "qualification", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.SupportingInformationComponent
		public static void Write(Hl7.Fhir.Model.Claim.SupportingInformationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Category, writer, "category", cancellationToken); // 50
			Write(name.Code, writer, "code", cancellationToken); // 60
			Write(name.Timing as Hl7.Fhir.Model.Date, writer, "timingDate", cancellationToken); // 70
			Write(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 70
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 80
			Write(name.Reason, writer, "reason", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.DiagnosisComponent
		public static void Write(Hl7.Fhir.Model.Claim.DiagnosisComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Diagnosis as Hl7.Fhir.Model.CodeableConcept, writer, "diagnosisCodeableConcept", cancellationToken); // 50
			Write(name.Diagnosis as Hl7.Fhir.Model.ResourceReference, writer, "diagnosisReference", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			Write(name.OnAdmission, writer, "onAdmission", cancellationToken); // 70
			Write(name.PackageCode, writer, "packageCode", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.ProcedureComponent
		public static void Write(Hl7.Fhir.Model.Claim.ProcedureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.DateElement, writer, "date", cancellationToken); // 60
			Write(name.Procedure as Hl7.Fhir.Model.CodeableConcept, writer, "procedureCodeableConcept", cancellationToken); // 70
			Write(name.Procedure as Hl7.Fhir.Model.ResourceReference, writer, "procedureReference", cancellationToken); // 70
			Write(name.Udi, writer, "udi", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.InsuranceComponent
		public static void Write(Hl7.Fhir.Model.Claim.InsuranceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.FocalElement, writer, "focal", cancellationToken); // 50
			Write(name.Identifier, writer, "identifier", cancellationToken); // 60
			Write(name.Coverage, writer, "coverage", cancellationToken); // 70
			Write(name.BusinessArrangementElement, writer, "businessArrangement", cancellationToken); // 80
			Write(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 90
			Write(name.ClaimResponse, writer, "claimResponse", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.AccidentComponent
		public static void Write(Hl7.Fhir.Model.Claim.AccidentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DateElement, writer, "date", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 60
			Write(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.ItemComponent
		public static void Write(Hl7.Fhir.Model.Claim.ItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.CareTeamSequenceElement, writer, "careTeamSequence", cancellationToken); // 50
			Write(name.DiagnosisSequenceElement, writer, "diagnosisSequence", cancellationToken); // 60
			Write(name.ProcedureSequenceElement, writer, "procedureSequence", cancellationToken); // 70
			Write(name.InformationSequenceElement, writer, "informationSequence", cancellationToken); // 80
			Write(name.Revenue, writer, "revenue", cancellationToken); // 90
			Write(name.Category, writer, "category", cancellationToken); // 100
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 110
			Write(name.Modifier, writer, "modifier", cancellationToken); // 120
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 130
			Write(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 140
			Write(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 140
			Write(name.Location as Hl7.Fhir.Model.CodeableConcept, writer, "locationCodeableConcept", cancellationToken); // 150
			Write(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 150
			Write(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 150
			Write(name.Quantity, writer, "quantity", cancellationToken); // 160
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 170
			Write(name.FactorElement, writer, "factor", cancellationToken); // 180
			Write(name.Net, writer, "net", cancellationToken); // 190
			Write(name.Udi, writer, "udi", cancellationToken); // 200
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 210
			Write(name.SubSite, writer, "subSite", cancellationToken); // 220
			Write(name.Encounter, writer, "encounter", cancellationToken); // 230
			Write(name.Detail, writer, "detail", cancellationToken); // 240
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.DetailComponent
		public static void Write(Hl7.Fhir.Model.Claim.DetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Revenue, writer, "revenue", cancellationToken); // 50
			Write(name.Category, writer, "category", cancellationToken); // 60
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 70
			Write(name.Modifier, writer, "modifier", cancellationToken); // 80
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 90
			Write(name.Quantity, writer, "quantity", cancellationToken); // 100
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 110
			Write(name.FactorElement, writer, "factor", cancellationToken); // 120
			Write(name.Net, writer, "net", cancellationToken); // 130
			Write(name.Udi, writer, "udi", cancellationToken); // 140
			Write(name.SubDetail, writer, "subDetail", cancellationToken); // 150
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Claim.SubDetailComponent
		public static void Write(Hl7.Fhir.Model.Claim.SubDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Revenue, writer, "revenue", cancellationToken); // 50
			Write(name.Category, writer, "category", cancellationToken); // 60
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 70
			Write(name.Modifier, writer, "modifier", cancellationToken); // 80
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 90
			Write(name.Quantity, writer, "quantity", cancellationToken); // 100
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 110
			Write(name.FactorElement, writer, "factor", cancellationToken); // 120
			Write(name.Net, writer, "net", cancellationToken); // 130
			Write(name.Udi, writer, "udi", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.ItemComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.ItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ItemSequenceElement, writer, "itemSequence", cancellationToken); // 40
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 50
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 60
			Write(name.Detail, writer, "detail", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Reason, writer, "reason", cancellationToken); // 50
			Write(name.Amount, writer, "amount", cancellationToken); // 60
			Write(name.ValueElement, writer, "value", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.ItemDetailComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.ItemDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DetailSequenceElement, writer, "detailSequence", cancellationToken); // 40
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 50
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 60
			Write(name.SubDetail, writer, "subDetail", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.SubDetailComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.SubDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SubDetailSequenceElement, writer, "subDetailSequence", cancellationToken); // 40
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 50
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.AddedItemComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.AddedItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ItemSequenceElement, writer, "itemSequence", cancellationToken); // 40
			Write(name.DetailSequenceElement, writer, "detailSequence", cancellationToken); // 50
			Write(name.SubdetailSequenceElement, writer, "subdetailSequence", cancellationToken); // 60
			Write(name.Provider, writer, "provider", cancellationToken); // 70
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 80
			Write(name.Modifier, writer, "modifier", cancellationToken); // 90
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 100
			Write(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 110
			Write(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 110
			Write(name.Location as Hl7.Fhir.Model.CodeableConcept, writer, "locationCodeableConcept", cancellationToken); // 120
			Write(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 120
			Write(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 120
			Write(name.Quantity, writer, "quantity", cancellationToken); // 130
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 140
			Write(name.FactorElement, writer, "factor", cancellationToken); // 150
			Write(name.Net, writer, "net", cancellationToken); // 160
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 170
			Write(name.SubSite, writer, "subSite", cancellationToken); // 180
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 190
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 200
			Write(name.Detail, writer, "detail", cancellationToken); // 210
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.AddedItemDetailComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.AddedItemDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 40
			Write(name.Modifier, writer, "modifier", cancellationToken); // 50
			Write(name.Quantity, writer, "quantity", cancellationToken); // 60
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 70
			Write(name.FactorElement, writer, "factor", cancellationToken); // 80
			Write(name.Net, writer, "net", cancellationToken); // 90
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 100
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 110
			Write(name.SubDetail, writer, "subDetail", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.AddedItemSubDetailComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.AddedItemSubDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 40
			Write(name.Modifier, writer, "modifier", cancellationToken); // 50
			Write(name.Quantity, writer, "quantity", cancellationToken); // 60
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 70
			Write(name.FactorElement, writer, "factor", cancellationToken); // 80
			Write(name.Net, writer, "net", cancellationToken); // 90
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 100
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.TotalComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.TotalComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Amount, writer, "amount", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.PaymentComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.PaymentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Adjustment, writer, "adjustment", cancellationToken); // 50
			Write(name.AdjustmentReason, writer, "adjustmentReason", cancellationToken); // 60
			Write(name.DateElement, writer, "date", cancellationToken); // 70
			Write(name.Amount, writer, "amount", cancellationToken); // 80
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.NoteComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.NoteComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NumberElement, writer, "number", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			Write(name.TextElement, writer, "text", cancellationToken); // 60
			Write(name.Language, writer, "language", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.InsuranceComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.InsuranceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.FocalElement, writer, "focal", cancellationToken); // 50
			Write(name.Coverage, writer, "coverage", cancellationToken); // 60
			Write(name.BusinessArrangementElement, writer, "businessArrangement", cancellationToken); // 70
			Write(name.ClaimResponse, writer, "claimResponse", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClaimResponse.ErrorComponent
		public static void Write(Hl7.Fhir.Model.ClaimResponse.ErrorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ItemSequenceElement, writer, "itemSequence", cancellationToken); // 40
			Write(name.DetailSequenceElement, writer, "detailSequence", cancellationToken); // 50
			Write(name.SubDetailSequenceElement, writer, "subDetailSequence", cancellationToken); // 60
			Write(name.Code, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClinicalImpression.InvestigationComponent
		public static void Write(Hl7.Fhir.Model.ClinicalImpression.InvestigationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Item, writer, "item", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ClinicalImpression.FindingComponent
		public static void Write(Hl7.Fhir.Model.ClinicalImpression.FindingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ItemCodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 40
			Write(name.ItemReference, writer, "itemReference", cancellationToken); // 50
			Write(name.BasisElement, writer, "basis", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeSystem.FilterComponent
		public static void Write(Hl7.Fhir.Model.CodeSystem.FilterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.OperatorElement, writer, "operator", cancellationToken); // 60
			Write(name.ValueElement, writer, "value", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeSystem.PropertyComponent
		public static void Write(Hl7.Fhir.Model.CodeSystem.PropertyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.UriElement, writer, "uri", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.TypeElement, writer, "type", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent
		public static void Write(Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.DisplayElement, writer, "display", cancellationToken); // 50
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 60
			Write(name.Designation, writer, "designation", cancellationToken); // 70
			Write(name.Property, writer, "property", cancellationToken); // 80
			Write(name.Concept, writer, "concept", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeSystem.DesignationComponent
		public static void Write(Hl7.Fhir.Model.CodeSystem.DesignationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LanguageElement, writer, "language", cancellationToken); // 40
			Write(name.Use, writer, "use", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CodeSystem.ConceptPropertyComponent
		public static void Write(Hl7.Fhir.Model.CodeSystem.ConceptPropertyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Communication.PayloadComponent
		public static void Write(Hl7.Fhir.Model.Communication.PayloadComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Content as Hl7.Fhir.Model.FhirString, writer, "contentString", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.Attachment, writer, "contentAttachment", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.ResourceReference, writer, "contentReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CommunicationRequest.PayloadComponent
		public static void Write(Hl7.Fhir.Model.CommunicationRequest.PayloadComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Content as Hl7.Fhir.Model.FhirString, writer, "contentString", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.Attachment, writer, "contentAttachment", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.ResourceReference, writer, "contentReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CompartmentDefinition.ResourceComponent
		public static void Write(Hl7.Fhir.Model.CompartmentDefinition.ResourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.ParamElement, writer, "param", cancellationToken); // 50
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Composition.AttesterComponent
		public static void Write(Hl7.Fhir.Model.Composition.AttesterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ModeElement, writer, "mode", cancellationToken); // 40
			Write(name.TimeElement, writer, "time", cancellationToken); // 50
			Write(name.Party, writer, "party", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Composition.RelatesToComponent
		public static void Write(Hl7.Fhir.Model.Composition.RelatesToComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.Target as Hl7.Fhir.Model.Identifier, writer, "targetIdentifier", cancellationToken); // 50
			Write(name.Target as Hl7.Fhir.Model.ResourceReference, writer, "targetReference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Composition.EventComponent
		public static void Write(Hl7.Fhir.Model.Composition.EventComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			Write(name.Detail, writer, "detail", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Composition.SectionComponent
		public static void Write(Hl7.Fhir.Model.Composition.SectionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TitleElement, writer, "title", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			Write(name.Author, writer, "author", cancellationToken); // 60
			Write(name.Focus, writer, "focus", cancellationToken); // 70
			Write(name.Text, writer, "text", cancellationToken); // 80
			Write(name.ModeElement, writer, "mode", cancellationToken); // 90
			Write(name.OrderedBy, writer, "orderedBy", cancellationToken); // 100
			Write(name.Entry, writer, "entry", cancellationToken); // 110
			Write(name.EmptyReason, writer, "emptyReason", cancellationToken); // 120
			Write(name.Section, writer, "section", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ConceptMap.GroupComponent
		public static void Write(Hl7.Fhir.Model.ConceptMap.GroupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SourceElement, writer, "source", cancellationToken); // 40
			Write(name.SourceVersionElement, writer, "sourceVersion", cancellationToken); // 50
			Write(name.TargetElement, writer, "target", cancellationToken); // 60
			Write(name.TargetVersionElement, writer, "targetVersion", cancellationToken); // 70
			Write(name.Element, writer, "element", cancellationToken); // 80
			Write(name.Unmapped, writer, "unmapped", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ConceptMap.SourceElementComponent
		public static void Write(Hl7.Fhir.Model.ConceptMap.SourceElementComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.DisplayElement, writer, "display", cancellationToken); // 50
			Write(name.Target, writer, "target", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ConceptMap.TargetElementComponent
		public static void Write(Hl7.Fhir.Model.ConceptMap.TargetElementComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.DisplayElement, writer, "display", cancellationToken); // 50
			Write(name.EquivalenceElement, writer, "equivalence", cancellationToken); // 60
			Write(name.CommentElement, writer, "comment", cancellationToken); // 70
			Write(name.DependsOn, writer, "dependsOn", cancellationToken); // 80
			Write(name.Product, writer, "product", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ConceptMap.OtherElementComponent
		public static void Write(Hl7.Fhir.Model.ConceptMap.OtherElementComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PropertyElement, writer, "property", cancellationToken); // 40
			Write(name.SystemElement, writer, "system", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			Write(name.DisplayElement, writer, "display", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ConceptMap.UnmappedComponent
		public static void Write(Hl7.Fhir.Model.ConceptMap.UnmappedComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ModeElement, writer, "mode", cancellationToken); // 40
			Write(name.CodeElement, writer, "code", cancellationToken); // 50
			Write(name.DisplayElement, writer, "display", cancellationToken); // 60
			Write(name.UrlElement, writer, "url", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Condition.StageComponent
		public static void Write(Hl7.Fhir.Model.Condition.StageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Summary, writer, "summary", cancellationToken); // 40
			Write(name.Assessment, writer, "assessment", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Condition.EvidenceComponent
		public static void Write(Hl7.Fhir.Model.Condition.EvidenceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Detail, writer, "detail", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Consent.PolicyComponent
		public static void Write(Hl7.Fhir.Model.Consent.PolicyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.AuthorityElement, writer, "authority", cancellationToken); // 40
			Write(name.UriElement, writer, "uri", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Consent.VerificationComponent
		public static void Write(Hl7.Fhir.Model.Consent.VerificationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.VerifiedElement, writer, "verified", cancellationToken); // 40
			Write(name.VerifiedWith, writer, "verifiedWith", cancellationToken); // 50
			Write(name.VerificationDateElement, writer, "verificationDate", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Consent.provisionComponent
		public static void Write(Hl7.Fhir.Model.Consent.provisionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			Write(name.Actor, writer, "actor", cancellationToken); // 60
			Write(name.Action, writer, "action", cancellationToken); // 70
			Write(name.SecurityLabel, writer, "securityLabel", cancellationToken); // 80
			Write(name.Purpose, writer, "purpose", cancellationToken); // 90
			Write(name.Class, writer, "class", cancellationToken); // 100
			Write(name.Code, writer, "code", cancellationToken); // 110
			Write(name.DataPeriod, writer, "dataPeriod", cancellationToken); // 120
			Write(name.Data, writer, "data", cancellationToken); // 130
			Write(name.Provision, writer, "provision", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Consent.provisionActorComponent
		public static void Write(Hl7.Fhir.Model.Consent.provisionActorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Role, writer, "role", cancellationToken); // 40
			Write(name.Reference, writer, "reference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Consent.provisionDataComponent
		public static void Write(Hl7.Fhir.Model.Consent.provisionDataComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.MeaningElement, writer, "meaning", cancellationToken); // 40
			Write(name.Reference, writer, "reference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ContentDefinitionComponent
		public static void Write(Hl7.Fhir.Model.Contract.ContentDefinitionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.SubType, writer, "subType", cancellationToken); // 50
			Write(name.Publisher, writer, "publisher", cancellationToken); // 60
			Write(name.PublicationDateElement, writer, "publicationDate", cancellationToken); // 70
			Write(name.PublicationStatusElement, writer, "publicationStatus", cancellationToken); // 80
			Write(name.Copyright, writer, "copyright", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.TermComponent
		public static void Write(Hl7.Fhir.Model.Contract.TermComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.IssuedElement, writer, "issued", cancellationToken); // 50
			Write(name.Applies, writer, "applies", cancellationToken); // 60
			Write(name.Topic as Hl7.Fhir.Model.CodeableConcept, writer, "topicCodeableConcept", cancellationToken); // 70
			Write(name.Topic as Hl7.Fhir.Model.ResourceReference, writer, "topicReference", cancellationToken); // 70
			Write(name.Type, writer, "type", cancellationToken); // 80
			Write(name.SubType, writer, "subType", cancellationToken); // 90
			Write(name.TextElement, writer, "text", cancellationToken); // 100
			Write(name.SecurityLabel, writer, "securityLabel", cancellationToken); // 110
			Write(name.Offer, writer, "offer", cancellationToken); // 120
			Write(name.Asset, writer, "asset", cancellationToken); // 130
			Write(name.Action, writer, "action", cancellationToken); // 140
			Write(name.Group, writer, "group", cancellationToken); // 150
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.SecurityLabelComponent
		public static void Write(Hl7.Fhir.Model.Contract.SecurityLabelComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NumberElement, writer, "number", cancellationToken); // 40
			Write(name.Classification, writer, "classification", cancellationToken); // 50
			Write(name.Category, writer, "category", cancellationToken); // 60
			Write(name.Control, writer, "control", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ContractOfferComponent
		public static void Write(Hl7.Fhir.Model.Contract.ContractOfferComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Party, writer, "party", cancellationToken); // 50
			Write(name.Topic, writer, "topic", cancellationToken); // 60
			Write(name.Type, writer, "type", cancellationToken); // 70
			Write(name.Decision, writer, "decision", cancellationToken); // 80
			Write(name.DecisionMode, writer, "decisionMode", cancellationToken); // 90
			Write(name.Answer, writer, "answer", cancellationToken); // 100
			Write(name.TextElement, writer, "text", cancellationToken); // 110
			Write(name.LinkIdElement, writer, "linkId", cancellationToken); // 120
			Write(name.SecurityLabelNumberElement, writer, "securityLabelNumber", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ContractPartyComponent
		public static void Write(Hl7.Fhir.Model.Contract.ContractPartyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Reference, writer, "reference", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.AnswerComponent
		public static void Write(Hl7.Fhir.Model.Contract.AnswerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ContractAssetComponent
		public static void Write(Hl7.Fhir.Model.Contract.ContractAssetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Scope, writer, "scope", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.TypeReference, writer, "typeReference", cancellationToken); // 60
			Write(name.Subtype, writer, "subtype", cancellationToken); // 70
			Write(name.Relationship, writer, "relationship", cancellationToken); // 80
			Write(name.Context, writer, "context", cancellationToken); // 90
			Write(name.ConditionElement, writer, "condition", cancellationToken); // 100
			Write(name.PeriodType, writer, "periodType", cancellationToken); // 110
			Write(name.Period, writer, "period", cancellationToken); // 120
			Write(name.UsePeriod, writer, "usePeriod", cancellationToken); // 130
			Write(name.TextElement, writer, "text", cancellationToken); // 140
			Write(name.LinkIdElement, writer, "linkId", cancellationToken); // 150
			Write(name.Answer, writer, "answer", cancellationToken); // 160
			Write(name.SecurityLabelNumberElement, writer, "securityLabelNumber", cancellationToken); // 170
			Write(name.ValuedItem, writer, "valuedItem", cancellationToken); // 180
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.AssetContextComponent
		public static void Write(Hl7.Fhir.Model.Contract.AssetContextComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Reference, writer, "reference", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			Write(name.TextElement, writer, "text", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ValuedItemComponent
		public static void Write(Hl7.Fhir.Model.Contract.ValuedItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Entity as Hl7.Fhir.Model.CodeableConcept, writer, "entityCodeableConcept", cancellationToken); // 40
			Write(name.Entity as Hl7.Fhir.Model.ResourceReference, writer, "entityReference", cancellationToken); // 40
			Write(name.Identifier, writer, "identifier", cancellationToken); // 50
			Write(name.EffectiveTimeElement, writer, "effectiveTime", cancellationToken); // 60
			Write(name.Quantity, writer, "quantity", cancellationToken); // 70
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 80
			Write(name.FactorElement, writer, "factor", cancellationToken); // 90
			Write(name.PointsElement, writer, "points", cancellationToken); // 100
			Write(name.Net, writer, "net", cancellationToken); // 110
			Write(name.PaymentElement, writer, "payment", cancellationToken); // 120
			Write(name.PaymentDateElement, writer, "paymentDate", cancellationToken); // 130
			Write(name.Responsible, writer, "responsible", cancellationToken); // 140
			Write(name.Recipient, writer, "recipient", cancellationToken); // 150
			Write(name.LinkIdElement, writer, "linkId", cancellationToken); // 160
			Write(name.SecurityLabelNumberElement, writer, "securityLabelNumber", cancellationToken); // 170
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ActionComponent
		public static void Write(Hl7.Fhir.Model.Contract.ActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DoNotPerformElement, writer, "doNotPerform", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Subject, writer, "subject", cancellationToken); // 60
			Write(name.Intent, writer, "intent", cancellationToken); // 70
			Write(name.LinkIdElement, writer, "linkId", cancellationToken); // 80
			Write(name.Status, writer, "status", cancellationToken); // 90
			Write(name.Context, writer, "context", cancellationToken); // 100
			Write(name.ContextLinkIdElement, writer, "contextLinkId", cancellationToken); // 110
			Write(name.Occurrence as Hl7.Fhir.Model.FhirDateTime, writer, "occurrenceDateTime", cancellationToken); // 120
			Write(name.Occurrence as Hl7.Fhir.Model.Period, writer, "occurrencePeriod", cancellationToken); // 120
			Write(name.Occurrence as Hl7.Fhir.Model.Timing, writer, "occurrenceTiming", cancellationToken); // 120
			Write(name.Requester, writer, "requester", cancellationToken); // 130
			Write(name.RequesterLinkIdElement, writer, "requesterLinkId", cancellationToken); // 140
			Write(name.PerformerType, writer, "performerType", cancellationToken); // 150
			Write(name.PerformerRole, writer, "performerRole", cancellationToken); // 160
			Write(name.Performer, writer, "performer", cancellationToken); // 170
			Write(name.PerformerLinkIdElement, writer, "performerLinkId", cancellationToken); // 180
			Write(name.ReasonCode, writer, "reasonCode", cancellationToken); // 190
			Write(name.ReasonReference, writer, "reasonReference", cancellationToken); // 200
			Write(name.ReasonElement, writer, "reason", cancellationToken); // 210
			Write(name.ReasonLinkIdElement, writer, "reasonLinkId", cancellationToken); // 220
			Write(name.Note, writer, "note", cancellationToken); // 230
			Write(name.SecurityLabelNumberElement, writer, "securityLabelNumber", cancellationToken); // 240
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ActionSubjectComponent
		public static void Write(Hl7.Fhir.Model.Contract.ActionSubjectComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Reference, writer, "reference", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.SignatoryComponent
		public static void Write(Hl7.Fhir.Model.Contract.SignatoryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Party, writer, "party", cancellationToken); // 50
			Write(name.Signature, writer, "signature", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.FriendlyLanguageComponent
		public static void Write(Hl7.Fhir.Model.Contract.FriendlyLanguageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Content as Hl7.Fhir.Model.Attachment, writer, "contentAttachment", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.ResourceReference, writer, "contentReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.LegalLanguageComponent
		public static void Write(Hl7.Fhir.Model.Contract.LegalLanguageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Content as Hl7.Fhir.Model.Attachment, writer, "contentAttachment", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.ResourceReference, writer, "contentReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Contract.ComputableLanguageComponent
		public static void Write(Hl7.Fhir.Model.Contract.ComputableLanguageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Content as Hl7.Fhir.Model.Attachment, writer, "contentAttachment", cancellationToken); // 40
			Write(name.Content as Hl7.Fhir.Model.ResourceReference, writer, "contentReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Coverage.ClassComponent
		public static void Write(Hl7.Fhir.Model.Coverage.ClassComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.ValueElement, writer, "value", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Coverage.CostToBeneficiaryComponent
		public static void Write(Hl7.Fhir.Model.Coverage.CostToBeneficiaryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.SimpleQuantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 50
			Write(name.Exception, writer, "exception", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Coverage.ExemptionComponent
		public static void Write(Hl7.Fhir.Model.Coverage.ExemptionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityRequest.SupportingInformationComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityRequest.SupportingInformationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Information, writer, "information", cancellationToken); // 50
			Write(name.AppliesToAllElement, writer, "appliesToAll", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityRequest.InsuranceComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityRequest.InsuranceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.FocalElement, writer, "focal", cancellationToken); // 40
			Write(name.Coverage, writer, "coverage", cancellationToken); // 50
			Write(name.BusinessArrangementElement, writer, "businessArrangement", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityRequest.DetailsComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityRequest.DetailsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SupportingInfoSequenceElement, writer, "supportingInfoSequence", cancellationToken); // 40
			Write(name.Category, writer, "category", cancellationToken); // 50
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 60
			Write(name.Modifier, writer, "modifier", cancellationToken); // 70
			Write(name.Provider, writer, "provider", cancellationToken); // 80
			Write(name.Quantity, writer, "quantity", cancellationToken); // 90
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 100
			Write(name.Facility, writer, "facility", cancellationToken); // 110
			Write(name.Diagnosis, writer, "diagnosis", cancellationToken); // 120
			Write(name.Detail, writer, "detail", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityRequest.DiagnosisComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityRequest.DiagnosisComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Diagnosis as Hl7.Fhir.Model.CodeableConcept, writer, "diagnosisCodeableConcept", cancellationToken); // 40
			Write(name.Diagnosis as Hl7.Fhir.Model.ResourceReference, writer, "diagnosisReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Coverage, writer, "coverage", cancellationToken); // 40
			Write(name.InforceElement, writer, "inforce", cancellationToken); // 50
			Write(name.BenefitPeriod, writer, "benefitPeriod", cancellationToken); // 60
			Write(name.Item, writer, "item", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 50
			Write(name.Modifier, writer, "modifier", cancellationToken); // 60
			Write(name.Provider, writer, "provider", cancellationToken); // 70
			Write(name.ExcludedElement, writer, "excluded", cancellationToken); // 80
			Write(name.NameElement, writer, "name", cancellationToken); // 90
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 100
			Write(name.Network, writer, "network", cancellationToken); // 110
			Write(name.Unit, writer, "unit", cancellationToken); // 120
			Write(name.Term, writer, "term", cancellationToken); // 130
			Write(name.Benefit, writer, "benefit", cancellationToken); // 140
			Write(name.AuthorizationRequiredElement, writer, "authorizationRequired", cancellationToken); // 150
			Write(name.AuthorizationSupporting, writer, "authorizationSupporting", cancellationToken); // 160
			Write(name.AuthorizationUrlElement, writer, "authorizationUrl", cancellationToken); // 170
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Allowed as Hl7.Fhir.Model.UnsignedInt, writer, "allowedUnsignedInt", cancellationToken); // 50
			Write(name.Allowed as Hl7.Fhir.Model.FhirString, writer, "allowedString", cancellationToken); // 50
			Write(name.Allowed as Hl7.Fhir.Model.Money, writer, "allowedMoney", cancellationToken); // 50
			Write(name.Used as Hl7.Fhir.Model.UnsignedInt, writer, "usedUnsignedInt", cancellationToken); // 60
			Write(name.Used as Hl7.Fhir.Model.FhirString, writer, "usedString", cancellationToken); // 60
			Write(name.Used as Hl7.Fhir.Model.Money, writer, "usedMoney", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent
		public static void Write(Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DetectedIssue.EvidenceComponent
		public static void Write(Hl7.Fhir.Model.DetectedIssue.EvidenceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Detail, writer, "detail", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DetectedIssue.MitigationComponent
		public static void Write(Hl7.Fhir.Model.DetectedIssue.MitigationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Action, writer, "action", cancellationToken); // 40
			Write(name.DateElement, writer, "date", cancellationToken); // 50
			Write(name.Author, writer, "author", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Device.UdiCarrierComponent
		public static void Write(Hl7.Fhir.Model.Device.UdiCarrierComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DeviceIdentifierElement, writer, "deviceIdentifier", cancellationToken); // 40
			Write(name.IssuerElement, writer, "issuer", cancellationToken); // 50
			Write(name.JurisdictionElement, writer, "jurisdiction", cancellationToken); // 60
			Write(name.CarrierAIDCElement, writer, "carrierAIDC", cancellationToken); // 70
			Write(name.CarrierHRFElement, writer, "carrierHRF", cancellationToken); // 80
			Write(name.EntryTypeElement, writer, "entryType", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Device.DeviceNameComponent
		public static void Write(Hl7.Fhir.Model.Device.DeviceNameComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Device.SpecializationComponent
		public static void Write(Hl7.Fhir.Model.Device.SpecializationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SystemType, writer, "systemType", cancellationToken); // 40
			Write(name.VersionElement, writer, "version", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Device.VersionComponent
		public static void Write(Hl7.Fhir.Model.Device.VersionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Component, writer, "component", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Device.PropertyComponent
		public static void Write(Hl7.Fhir.Model.Device.PropertyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.ValueQuantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.ValueCode, writer, "valueCode", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceDefinition.UdiDeviceIdentifierComponent
		public static void Write(Hl7.Fhir.Model.DeviceDefinition.UdiDeviceIdentifierComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DeviceIdentifierElement, writer, "deviceIdentifier", cancellationToken); // 40
			Write(name.IssuerElement, writer, "issuer", cancellationToken); // 50
			Write(name.JurisdictionElement, writer, "jurisdiction", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceDefinition.DeviceNameComponent
		public static void Write(Hl7.Fhir.Model.DeviceDefinition.DeviceNameComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceDefinition.SpecializationComponent
		public static void Write(Hl7.Fhir.Model.DeviceDefinition.SpecializationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SystemTypeElement, writer, "systemType", cancellationToken); // 40
			Write(name.VersionElement, writer, "version", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceDefinition.CapabilityComponent
		public static void Write(Hl7.Fhir.Model.DeviceDefinition.CapabilityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Description, writer, "description", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceDefinition.PropertyComponent
		public static void Write(Hl7.Fhir.Model.DeviceDefinition.PropertyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.ValueQuantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.ValueCode, writer, "valueCode", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceDefinition.MaterialComponent
		public static void Write(Hl7.Fhir.Model.DeviceDefinition.MaterialComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Substance, writer, "substance", cancellationToken); // 40
			Write(name.AlternateElement, writer, "alternate", cancellationToken); // 50
			Write(name.AllergenicIndicatorElement, writer, "allergenicIndicator", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceMetric.CalibrationComponent
		public static void Write(Hl7.Fhir.Model.DeviceMetric.CalibrationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.StateElement, writer, "state", cancellationToken); // 50
			Write(name.TimeElement, writer, "time", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DeviceRequest.ParameterComponent
		public static void Write(Hl7.Fhir.Model.DeviceRequest.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DiagnosticReport.MediaComponent
		public static void Write(Hl7.Fhir.Model.DiagnosticReport.MediaComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CommentElement, writer, "comment", cancellationToken); // 40
			Write(name.Link, writer, "link", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DocumentManifest.RelatedComponent
		public static void Write(Hl7.Fhir.Model.DocumentManifest.RelatedComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Ref, writer, "ref", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DocumentReference.RelatesToComponent
		public static void Write(Hl7.Fhir.Model.DocumentReference.RelatesToComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.Target, writer, "target", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DocumentReference.ContentComponent
		public static void Write(Hl7.Fhir.Model.DocumentReference.ContentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Attachment, writer, "attachment", cancellationToken); // 40
			Write(name.Format, writer, "format", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DocumentReference.ContextComponent
		public static void Write(Hl7.Fhir.Model.DocumentReference.ContextComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Encounter, writer, "encounter", cancellationToken); // 40
			Write(name.Event, writer, "event", cancellationToken); // 50
			Write(name.Period, writer, "period", cancellationToken); // 60
			Write(name.FacilityType, writer, "facilityType", cancellationToken); // 70
			Write(name.PracticeSetting, writer, "practiceSetting", cancellationToken); // 80
			Write(name.SourcePatientInfo, writer, "sourcePatientInfo", cancellationToken); // 90
			Write(name.Related, writer, "related", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.DomainResource
		public static void WriteDomainResource(Hl7.Fhir.Model.DomainResource name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			WriteResource(name, writer, cancellationToken);
			Write(name.Text, writer, "text", cancellationToken); // 50
			Write(name.Contained, writer, "contained", cancellationToken); // 60
			Write(name.Extension, writer, "extension", cancellationToken); // 70
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 80
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.SampleSizeComponent
		public static void Write(Hl7.Fhir.Model.EffectEvidenceSynthesis.SampleSizeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.NumberOfStudiesElement, writer, "numberOfStudies", cancellationToken); // 50
			Write(name.NumberOfParticipantsElement, writer, "numberOfParticipants", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.ResultsByExposureComponent
		public static void Write(Hl7.Fhir.Model.EffectEvidenceSynthesis.ResultsByExposureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.ExposureState_Element, writer, "exposureState", cancellationToken); // 50
			Write(name.VariantState, writer, "variantState", cancellationToken); // 60
			Write(name.RiskEvidenceSynthesis, writer, "riskEvidenceSynthesis", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.EffectEstimateComponent
		public static void Write(Hl7.Fhir.Model.EffectEvidenceSynthesis.EffectEstimateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.VariantState, writer, "variantState", cancellationToken); // 60
			Write(name.ValueElement, writer, "value", cancellationToken); // 70
			Write(name.UnitOfMeasure, writer, "unitOfMeasure", cancellationToken); // 80
			Write(name.PrecisionEstimate, writer, "precisionEstimate", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.PrecisionEstimateComponent
		public static void Write(Hl7.Fhir.Model.EffectEvidenceSynthesis.PrecisionEstimateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.LevelElement, writer, "level", cancellationToken); // 50
			Write(name.FromElement, writer, "from", cancellationToken); // 60
			Write(name.ToElement, writer, "to", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.CertaintyComponent
		public static void Write(Hl7.Fhir.Model.EffectEvidenceSynthesis.CertaintyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Rating, writer, "rating", cancellationToken); // 40
			Write(name.Note, writer, "note", cancellationToken); // 50
			Write(name.CertaintySubcomponent, writer, "certaintySubcomponent", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EffectEvidenceSynthesis.CertaintySubcomponentComponent
		public static void Write(Hl7.Fhir.Model.EffectEvidenceSynthesis.CertaintySubcomponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Rating, writer, "rating", cancellationToken); // 50
			Write(name.Note, writer, "note", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.StatusHistoryComponent
		public static void Write(Hl7.Fhir.Model.Encounter.StatusHistoryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StatusElement, writer, "status", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.ClassHistoryComponent
		public static void Write(Hl7.Fhir.Model.Encounter.ClassHistoryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Class, writer, "class", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.Encounter.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			Write(name.Individual, writer, "individual", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.DiagnosisComponent
		public static void Write(Hl7.Fhir.Model.Encounter.DiagnosisComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Condition, writer, "condition", cancellationToken); // 40
			Write(name.Use, writer, "use", cancellationToken); // 50
			Write(name.RankElement, writer, "rank", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.HospitalizationComponent
		public static void Write(Hl7.Fhir.Model.Encounter.HospitalizationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PreAdmissionIdentifier, writer, "preAdmissionIdentifier", cancellationToken); // 40
			Write(name.Origin, writer, "origin", cancellationToken); // 50
			Write(name.AdmitSource, writer, "admitSource", cancellationToken); // 60
			Write(name.ReAdmission, writer, "reAdmission", cancellationToken); // 70
			Write(name.DietPreference, writer, "dietPreference", cancellationToken); // 80
			Write(name.SpecialCourtesy, writer, "specialCourtesy", cancellationToken); // 90
			Write(name.SpecialArrangement, writer, "specialArrangement", cancellationToken); // 100
			Write(name.Destination, writer, "destination", cancellationToken); // 110
			Write(name.DischargeDisposition, writer, "dischargeDisposition", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Encounter.LocationComponent
		public static void Write(Hl7.Fhir.Model.Encounter.LocationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Location, writer, "location", cancellationToken); // 40
			Write(name.StatusElement, writer, "status", cancellationToken); // 50
			Write(name.PhysicalType, writer, "physicalType", cancellationToken); // 60
			Write(name.Period, writer, "period", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent
		public static void Write(Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StatusElement, writer, "status", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent
		public static void Write(Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Condition, writer, "condition", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			Write(name.RankElement, writer, "rank", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.EvidenceVariable.CharacteristicComponent
		public static void Write(Hl7.Fhir.Model.EvidenceVariable.CharacteristicComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.Definition as Hl7.Fhir.Model.ResourceReference, writer, "definitionReference", cancellationToken); // 50
			Write(name.Definition as Hl7.Fhir.Model.Canonical, writer, "definitionCanonical", cancellationToken); // 50
			Write(name.Definition as Hl7.Fhir.Model.CodeableConcept, writer, "definitionCodeableConcept", cancellationToken); // 50
			Write(name.Definition as Hl7.Fhir.Model.Expression, writer, "definitionExpression", cancellationToken); // 50
			Write(name.Definition as Hl7.Fhir.Model.DataRequirement, writer, "definitionDataRequirement", cancellationToken); // 50
			Write(name.Definition as Hl7.Fhir.Model.TriggerDefinition, writer, "definitionTriggerDefinition", cancellationToken); // 50
			Write(name.UsageContext, writer, "usageContext", cancellationToken); // 60
			Write(name.ExcludeElement, writer, "exclude", cancellationToken); // 70
			Write(name.ParticipantEffective as Hl7.Fhir.Model.FhirDateTime, writer, "participantEffectiveDateTime", cancellationToken); // 80
			Write(name.ParticipantEffective as Hl7.Fhir.Model.Period, writer, "participantEffectivePeriod", cancellationToken); // 80
			Write(name.ParticipantEffective as Hl7.Fhir.Model.Duration, writer, "participantEffectiveDuration", cancellationToken); // 80
			Write(name.ParticipantEffective as Hl7.Fhir.Model.Timing, writer, "participantEffectiveTiming", cancellationToken); // 80
			Write(name.TimeFromStart, writer, "timeFromStart", cancellationToken); // 90
			Write(name.GroupMeasureElement, writer, "groupMeasure", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.ActorComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.ActorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ActorIdElement, writer, "actorId", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.Description, writer, "description", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.InstanceComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.InstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ResourceIdElement, writer, "resourceId", cancellationToken); // 40
			Write(name.ResourceTypeElement, writer, "resourceType", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.Description, writer, "description", cancellationToken); // 70
			Write(name.Version, writer, "version", cancellationToken); // 80
			Write(name.ContainedInstance, writer, "containedInstance", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.VersionComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.VersionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.VersionIdElement, writer, "versionId", cancellationToken); // 40
			Write(name.Description, writer, "description", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ResourceIdElement, writer, "resourceId", cancellationToken); // 40
			Write(name.VersionIdElement, writer, "versionId", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.ProcessComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.ProcessComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TitleElement, writer, "title", cancellationToken); // 40
			Write(name.Description, writer, "description", cancellationToken); // 50
			Write(name.PreConditions, writer, "preConditions", cancellationToken); // 60
			Write(name.PostConditions, writer, "postConditions", cancellationToken); // 70
			Write(name.Step, writer, "step", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.StepComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.StepComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Process, writer, "process", cancellationToken); // 40
			Write(name.PauseElement, writer, "pause", cancellationToken); // 50
			Write(name.Operation, writer, "operation", cancellationToken); // 60
			Write(name.Alternative, writer, "alternative", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.OperationComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.OperationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NumberElement, writer, "number", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.InitiatorElement, writer, "initiator", cancellationToken); // 70
			Write(name.ReceiverElement, writer, "receiver", cancellationToken); // 80
			Write(name.Description, writer, "description", cancellationToken); // 90
			Write(name.InitiatorActiveElement, writer, "initiatorActive", cancellationToken); // 100
			Write(name.ReceiverActiveElement, writer, "receiverActive", cancellationToken); // 110
			Write(name.Request, writer, "request", cancellationToken); // 120
			Write(name.Response, writer, "response", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExampleScenario.AlternativeComponent
		public static void Write(Hl7.Fhir.Model.ExampleScenario.AlternativeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TitleElement, writer, "title", cancellationToken); // 40
			Write(name.Description, writer, "description", cancellationToken); // 50
			Write(name.Step, writer, "step", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.RelatedClaimComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.RelatedClaimComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Claim, writer, "claim", cancellationToken); // 40
			Write(name.Relationship, writer, "relationship", cancellationToken); // 50
			Write(name.Reference, writer, "reference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Party, writer, "party", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.CareTeamComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.CareTeamComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Provider, writer, "provider", cancellationToken); // 50
			Write(name.ResponsibleElement, writer, "responsible", cancellationToken); // 60
			Write(name.Role, writer, "role", cancellationToken); // 70
			Write(name.Qualification, writer, "qualification", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.SupportingInformationComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.SupportingInformationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Category, writer, "category", cancellationToken); // 50
			Write(name.Code, writer, "code", cancellationToken); // 60
			Write(name.Timing as Hl7.Fhir.Model.Date, writer, "timingDate", cancellationToken); // 70
			Write(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 70
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 80
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 80
			Write(name.Reason, writer, "reason", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.DiagnosisComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.DiagnosisComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Diagnosis as Hl7.Fhir.Model.CodeableConcept, writer, "diagnosisCodeableConcept", cancellationToken); // 50
			Write(name.Diagnosis as Hl7.Fhir.Model.ResourceReference, writer, "diagnosisReference", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			Write(name.OnAdmission, writer, "onAdmission", cancellationToken); // 70
			Write(name.PackageCode, writer, "packageCode", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.DateElement, writer, "date", cancellationToken); // 60
			Write(name.Procedure as Hl7.Fhir.Model.CodeableConcept, writer, "procedureCodeableConcept", cancellationToken); // 70
			Write(name.Procedure as Hl7.Fhir.Model.ResourceReference, writer, "procedureReference", cancellationToken); // 70
			Write(name.Udi, writer, "udi", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.InsuranceComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.InsuranceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.FocalElement, writer, "focal", cancellationToken); // 40
			Write(name.Coverage, writer, "coverage", cancellationToken); // 50
			Write(name.PreAuthRefElement, writer, "preAuthRef", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DateElement, writer, "date", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 60
			Write(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.CareTeamSequenceElement, writer, "careTeamSequence", cancellationToken); // 50
			Write(name.DiagnosisSequenceElement, writer, "diagnosisSequence", cancellationToken); // 60
			Write(name.ProcedureSequenceElement, writer, "procedureSequence", cancellationToken); // 70
			Write(name.InformationSequenceElement, writer, "informationSequence", cancellationToken); // 80
			Write(name.Revenue, writer, "revenue", cancellationToken); // 90
			Write(name.Category, writer, "category", cancellationToken); // 100
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 110
			Write(name.Modifier, writer, "modifier", cancellationToken); // 120
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 130
			Write(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 140
			Write(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 140
			Write(name.Location as Hl7.Fhir.Model.CodeableConcept, writer, "locationCodeableConcept", cancellationToken); // 150
			Write(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 150
			Write(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 150
			Write(name.Quantity, writer, "quantity", cancellationToken); // 160
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 170
			Write(name.FactorElement, writer, "factor", cancellationToken); // 180
			Write(name.Net, writer, "net", cancellationToken); // 190
			Write(name.Udi, writer, "udi", cancellationToken); // 200
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 210
			Write(name.SubSite, writer, "subSite", cancellationToken); // 220
			Write(name.Encounter, writer, "encounter", cancellationToken); // 230
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 240
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 250
			Write(name.Detail, writer, "detail", cancellationToken); // 260
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Reason, writer, "reason", cancellationToken); // 50
			Write(name.Amount, writer, "amount", cancellationToken); // 60
			Write(name.ValueElement, writer, "value", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.DetailComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.DetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Revenue, writer, "revenue", cancellationToken); // 50
			Write(name.Category, writer, "category", cancellationToken); // 60
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 70
			Write(name.Modifier, writer, "modifier", cancellationToken); // 80
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 90
			Write(name.Quantity, writer, "quantity", cancellationToken); // 100
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 110
			Write(name.FactorElement, writer, "factor", cancellationToken); // 120
			Write(name.Net, writer, "net", cancellationToken); // 130
			Write(name.Udi, writer, "udi", cancellationToken); // 140
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 150
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 160
			Write(name.SubDetail, writer, "subDetail", cancellationToken); // 170
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.SubDetailComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.SubDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.Revenue, writer, "revenue", cancellationToken); // 50
			Write(name.Category, writer, "category", cancellationToken); // 60
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 70
			Write(name.Modifier, writer, "modifier", cancellationToken); // 80
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 90
			Write(name.Quantity, writer, "quantity", cancellationToken); // 100
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 110
			Write(name.FactorElement, writer, "factor", cancellationToken); // 120
			Write(name.Net, writer, "net", cancellationToken); // 130
			Write(name.Udi, writer, "udi", cancellationToken); // 140
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 150
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 160
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ItemSequenceElement, writer, "itemSequence", cancellationToken); // 40
			Write(name.DetailSequenceElement, writer, "detailSequence", cancellationToken); // 50
			Write(name.SubDetailSequenceElement, writer, "subDetailSequence", cancellationToken); // 60
			Write(name.Provider, writer, "provider", cancellationToken); // 70
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 80
			Write(name.Modifier, writer, "modifier", cancellationToken); // 90
			Write(name.ProgramCode, writer, "programCode", cancellationToken); // 100
			Write(name.Serviced as Hl7.Fhir.Model.Date, writer, "servicedDate", cancellationToken); // 110
			Write(name.Serviced as Hl7.Fhir.Model.Period, writer, "servicedPeriod", cancellationToken); // 110
			Write(name.Location as Hl7.Fhir.Model.CodeableConcept, writer, "locationCodeableConcept", cancellationToken); // 120
			Write(name.Location as Hl7.Fhir.Model.Address, writer, "locationAddress", cancellationToken); // 120
			Write(name.Location as Hl7.Fhir.Model.ResourceReference, writer, "locationReference", cancellationToken); // 120
			Write(name.Quantity, writer, "quantity", cancellationToken); // 130
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 140
			Write(name.FactorElement, writer, "factor", cancellationToken); // 150
			Write(name.Net, writer, "net", cancellationToken); // 160
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 170
			Write(name.SubSite, writer, "subSite", cancellationToken); // 180
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 190
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 200
			Write(name.Detail, writer, "detail", cancellationToken); // 210
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 40
			Write(name.Modifier, writer, "modifier", cancellationToken); // 50
			Write(name.Quantity, writer, "quantity", cancellationToken); // 60
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 70
			Write(name.FactorElement, writer, "factor", cancellationToken); // 80
			Write(name.Net, writer, "net", cancellationToken); // 90
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 100
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 110
			Write(name.SubDetail, writer, "subDetail", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailSubDetailComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailSubDetailComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ProductOrService, writer, "productOrService", cancellationToken); // 40
			Write(name.Modifier, writer, "modifier", cancellationToken); // 50
			Write(name.Quantity, writer, "quantity", cancellationToken); // 60
			Write(name.UnitPrice, writer, "unitPrice", cancellationToken); // 70
			Write(name.FactorElement, writer, "factor", cancellationToken); // 80
			Write(name.Net, writer, "net", cancellationToken); // 90
			Write(name.NoteNumberElement, writer, "noteNumber", cancellationToken); // 100
			Write(name.Adjudication, writer, "adjudication", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.TotalComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.TotalComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Amount, writer, "amount", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Adjustment, writer, "adjustment", cancellationToken); // 50
			Write(name.AdjustmentReason, writer, "adjustmentReason", cancellationToken); // 60
			Write(name.DateElement, writer, "date", cancellationToken); // 70
			Write(name.Amount, writer, "amount", cancellationToken); // 80
			Write(name.Identifier, writer, "identifier", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.NoteComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.NoteComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NumberElement, writer, "number", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			Write(name.TextElement, writer, "text", cancellationToken); // 60
			Write(name.Language, writer, "language", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.ExcludedElement, writer, "excluded", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 70
			Write(name.Network, writer, "network", cancellationToken); // 80
			Write(name.Unit, writer, "unit", cancellationToken); // 90
			Write(name.Term, writer, "term", cancellationToken); // 100
			Write(name.Financial, writer, "financial", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ExplanationOfBenefit.BenefitComponent
		public static void Write(Hl7.Fhir.Model.ExplanationOfBenefit.BenefitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Allowed as Hl7.Fhir.Model.UnsignedInt, writer, "allowedUnsignedInt", cancellationToken); // 50
			Write(name.Allowed as Hl7.Fhir.Model.FhirString, writer, "allowedString", cancellationToken); // 50
			Write(name.Allowed as Hl7.Fhir.Model.Money, writer, "allowedMoney", cancellationToken); // 50
			Write(name.Used as Hl7.Fhir.Model.UnsignedInt, writer, "usedUnsignedInt", cancellationToken); // 60
			Write(name.Used as Hl7.Fhir.Model.Money, writer, "usedMoney", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent
		public static void Write(Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Outcome, writer, "outcome", cancellationToken); // 50
			Write(name.ContributedToDeathElement, writer, "contributedToDeath", cancellationToken); // 60
			Write(name.Onset as Hl7.Fhir.Model.Age, writer, "onsetAge", cancellationToken); // 70
			Write(name.Onset as Hl7.Fhir.Model.Range, writer, "onsetRange", cancellationToken); // 70
			Write(name.Onset as Hl7.Fhir.Model.Period, writer, "onsetPeriod", cancellationToken); // 70
			Write(name.Onset as Hl7.Fhir.Model.FhirString, writer, "onsetString", cancellationToken); // 70
			Write(name.Note, writer, "note", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Goal.TargetComponent
		public static void Write(Hl7.Fhir.Model.Goal.TargetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Measure, writer, "measure", cancellationToken); // 40
			Write(name.Detail as Hl7.Fhir.Model.Quantity, writer, "detailQuantity", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.Range, writer, "detailRange", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.CodeableConcept, writer, "detailCodeableConcept", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.FhirString, writer, "detailString", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.FhirBoolean, writer, "detailBoolean", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.Integer, writer, "detailInteger", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.Ratio, writer, "detailRatio", cancellationToken); // 50
			Write(name.Due as Hl7.Fhir.Model.Date, writer, "dueDate", cancellationToken); // 60
			Write(name.Due as Hl7.Fhir.Model.Duration, writer, "dueDuration", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.GraphDefinition.LinkComponent
		public static void Write(Hl7.Fhir.Model.GraphDefinition.LinkComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.SliceNameElement, writer, "sliceName", cancellationToken); // 50
			Write(name.MinElement, writer, "min", cancellationToken); // 60
			Write(name.MaxElement, writer, "max", cancellationToken); // 70
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 80
			Write(name.Target, writer, "target", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.GraphDefinition.TargetComponent
		public static void Write(Hl7.Fhir.Model.GraphDefinition.TargetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.ParamsElement, writer, "params", cancellationToken); // 50
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 60
			Write(name.Compartment, writer, "compartment", cancellationToken); // 70
			Write(name.Link, writer, "link", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.GraphDefinition.CompartmentComponent
		public static void Write(Hl7.Fhir.Model.GraphDefinition.CompartmentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UseElement, writer, "use", cancellationToken); // 40
			Write(name.CodeElement, writer, "code", cancellationToken); // 50
			Write(name.RuleElement, writer, "rule", cancellationToken); // 60
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 70
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Group.CharacteristicComponent
		public static void Write(Hl7.Fhir.Model.Group.CharacteristicComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 50
			Write(name.ExcludeElement, writer, "exclude", cancellationToken); // 60
			Write(name.Period, writer, "period", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Group.MemberComponent
		public static void Write(Hl7.Fhir.Model.Group.MemberComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Entity, writer, "entity", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			Write(name.InactiveElement, writer, "inactive", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.HealthcareService.EligibilityComponent
		public static void Write(Hl7.Fhir.Model.HealthcareService.EligibilityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Comment, writer, "comment", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.HealthcareService.AvailableTimeComponent
		public static void Write(Hl7.Fhir.Model.HealthcareService.AvailableTimeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DaysOfWeekElement, writer, "daysOfWeek", cancellationToken); // 40
			Write(name.AllDayElement, writer, "allDay", cancellationToken); // 50
			Write(name.AvailableStartTimeElement, writer, "availableStartTime", cancellationToken); // 60
			Write(name.AvailableEndTimeElement, writer, "availableEndTime", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.HealthcareService.NotAvailableComponent
		public static void Write(Hl7.Fhir.Model.HealthcareService.NotAvailableComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.During, writer, "during", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImagingStudy.SeriesComponent
		public static void Write(Hl7.Fhir.Model.ImagingStudy.SeriesComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UidElement, writer, "uid", cancellationToken); // 40
			Write(name.NumberElement, writer, "number", cancellationToken); // 50
			Write(name.Modality, writer, "modality", cancellationToken); // 60
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 70
			Write(name.NumberOfInstancesElement, writer, "numberOfInstances", cancellationToken); // 80
			Write(name.Endpoint, writer, "endpoint", cancellationToken); // 90
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 100
			Write(name.Laterality, writer, "laterality", cancellationToken); // 110
			Write(name.Specimen, writer, "specimen", cancellationToken); // 120
			Write(name.StartedElement, writer, "started", cancellationToken); // 130
			Write(name.Performer, writer, "performer", cancellationToken); // 140
			Write(name.Instance, writer, "instance", cancellationToken); // 150
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImagingStudy.PerformerComponent
		public static void Write(Hl7.Fhir.Model.ImagingStudy.PerformerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Function, writer, "function", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImagingStudy.InstanceComponent
		public static void Write(Hl7.Fhir.Model.ImagingStudy.InstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UidElement, writer, "uid", cancellationToken); // 40
			Write(name.SopClass, writer, "sopClass", cancellationToken); // 50
			Write(name.NumberElement, writer, "number", cancellationToken); // 60
			Write(name.TitleElement, writer, "title", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Immunization.PerformerComponent
		public static void Write(Hl7.Fhir.Model.Immunization.PerformerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Function, writer, "function", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Immunization.EducationComponent
		public static void Write(Hl7.Fhir.Model.Immunization.EducationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DocumentTypeElement, writer, "documentType", cancellationToken); // 40
			Write(name.ReferenceElement, writer, "reference", cancellationToken); // 50
			Write(name.PublicationDateElement, writer, "publicationDate", cancellationToken); // 60
			Write(name.PresentationDateElement, writer, "presentationDate", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Immunization.ReactionComponent
		public static void Write(Hl7.Fhir.Model.Immunization.ReactionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DateElement, writer, "date", cancellationToken); // 40
			Write(name.Detail, writer, "detail", cancellationToken); // 50
			Write(name.ReportedElement, writer, "reported", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent
		public static void Write(Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SeriesElement, writer, "series", cancellationToken); // 40
			Write(name.Authority, writer, "authority", cancellationToken); // 50
			Write(name.TargetDisease, writer, "targetDisease", cancellationToken); // 60
			Write(name.DoseNumber as Hl7.Fhir.Model.PositiveInt, writer, "doseNumberPositiveInt", cancellationToken); // 70
			Write(name.DoseNumber as Hl7.Fhir.Model.FhirString, writer, "doseNumberString", cancellationToken); // 70
			Write(name.SeriesDoses as Hl7.Fhir.Model.PositiveInt, writer, "seriesDosesPositiveInt", cancellationToken); // 80
			Write(name.SeriesDoses as Hl7.Fhir.Model.FhirString, writer, "seriesDosesString", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent
		public static void Write(Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.VaccineCode, writer, "vaccineCode", cancellationToken); // 40
			Write(name.TargetDisease, writer, "targetDisease", cancellationToken); // 50
			Write(name.ContraindicatedVaccineCode, writer, "contraindicatedVaccineCode", cancellationToken); // 60
			Write(name.ForecastStatus, writer, "forecastStatus", cancellationToken); // 70
			Write(name.ForecastReason, writer, "forecastReason", cancellationToken); // 80
			Write(name.DateCriterion, writer, "dateCriterion", cancellationToken); // 90
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 100
			Write(name.SeriesElement, writer, "series", cancellationToken); // 110
			Write(name.DoseNumber as Hl7.Fhir.Model.PositiveInt, writer, "doseNumberPositiveInt", cancellationToken); // 120
			Write(name.DoseNumber as Hl7.Fhir.Model.FhirString, writer, "doseNumberString", cancellationToken); // 120
			Write(name.SeriesDoses as Hl7.Fhir.Model.PositiveInt, writer, "seriesDosesPositiveInt", cancellationToken); // 130
			Write(name.SeriesDoses as Hl7.Fhir.Model.FhirString, writer, "seriesDosesString", cancellationToken); // 130
			Write(name.SupportingImmunization, writer, "supportingImmunization", cancellationToken); // 140
			Write(name.SupportingPatientInformation, writer, "supportingPatientInformation", cancellationToken); // 150
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent
		public static void Write(Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.ValueElement, writer, "value", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.DependsOnComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.DependsOnComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UriElement, writer, "uri", cancellationToken); // 40
			Write(name.PackageIdElement, writer, "packageId", cancellationToken); // 50
			Write(name.VersionElement, writer, "version", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.GlobalComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.GlobalComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.DefinitionComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.DefinitionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Grouping, writer, "grouping", cancellationToken); // 40
			Write(name.Resource, writer, "resource", cancellationToken); // 50
			Write(name.Page, writer, "page", cancellationToken); // 60
			Write(name.Parameter, writer, "parameter", cancellationToken); // 70
			Write(name.Template, writer, "template", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.GroupingComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.GroupingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.ResourceComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.ResourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Reference, writer, "reference", cancellationToken); // 40
			Write(name.FhirVersionElement, writer, "fhirVersion", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 70
			Write(name.Example as Hl7.Fhir.Model.FhirBoolean, writer, "exampleBoolean", cancellationToken); // 80
			Write(name.Example as Hl7.Fhir.Model.Canonical, writer, "exampleCanonical", cancellationToken); // 80
			Write(name.GroupingIdElement, writer, "groupingId", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.PageComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.PageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Name as Hl7.Fhir.Model.FhirUrl, writer, "nameUrl", cancellationToken); // 40
			Write(name.Name as Hl7.Fhir.Model.ResourceReference, writer, "nameReference", cancellationToken); // 40
			Write(name.TitleElement, writer, "title", cancellationToken); // 50
			Write(name.GenerationElement, writer, "generation", cancellationToken); // 60
			Write(name.Page, writer, "page", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.ParameterComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.ValueElement, writer, "value", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.TemplateComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.TemplateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.SourceElement, writer, "source", cancellationToken); // 50
			Write(name.ScopeElement, writer, "scope", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.ManifestComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.ManifestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RenderingElement, writer, "rendering", cancellationToken); // 40
			Write(name.Resource, writer, "resource", cancellationToken); // 50
			Write(name.Page, writer, "page", cancellationToken); // 60
			Write(name.ImageElement, writer, "image", cancellationToken); // 70
			Write(name.OtherElement, writer, "other", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.ManifestResourceComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.ManifestResourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Reference, writer, "reference", cancellationToken); // 40
			Write(name.Example as Hl7.Fhir.Model.FhirBoolean, writer, "exampleBoolean", cancellationToken); // 50
			Write(name.Example as Hl7.Fhir.Model.Canonical, writer, "exampleCanonical", cancellationToken); // 50
			Write(name.RelativePathElement, writer, "relativePath", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ImplementationGuide.ManifestPageComponent
		public static void Write(Hl7.Fhir.Model.ImplementationGuide.ManifestPageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.TitleElement, writer, "title", cancellationToken); // 50
			Write(name.AnchorElement, writer, "anchor", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.ContactComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.ContactComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Purpose, writer, "purpose", cancellationToken); // 40
			Write(name.Name, writer, "name", cancellationToken); // 50
			Write(name.Telecom, writer, "telecom", cancellationToken); // 60
			Write(name.Address, writer, "address", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.CoverageComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.CoverageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Network, writer, "network", cancellationToken); // 50
			Write(name.Benefit, writer, "benefit", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.CoverageBenefitComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.CoverageBenefitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.RequirementElement, writer, "requirement", cancellationToken); // 50
			Write(name.Limit, writer, "limit", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.LimitComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.LimitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value, writer, "value", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.PlanComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.PlanComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.CoverageArea, writer, "coverageArea", cancellationToken); // 60
			Write(name.Network, writer, "network", cancellationToken); // 70
			Write(name.GeneralCost, writer, "generalCost", cancellationToken); // 80
			Write(name.SpecificCost, writer, "specificCost", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.GeneralCostComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.GeneralCostComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.GroupSizeElement, writer, "groupSize", cancellationToken); // 50
			Write(name.Cost, writer, "cost", cancellationToken); // 60
			Write(name.CommentElement, writer, "comment", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.SpecificCostComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.SpecificCostComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Benefit, writer, "benefit", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.PlanBenefitComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.PlanBenefitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Cost, writer, "cost", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.InsurancePlan.CostComponent
		public static void Write(Hl7.Fhir.Model.InsurancePlan.CostComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Applicability, writer, "applicability", cancellationToken); // 50
			Write(name.Qualifiers, writer, "qualifiers", cancellationToken); // 60
			Write(name.Value, writer, "value", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Invoice.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.Invoice.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Role, writer, "role", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Invoice.LineItemComponent
		public static void Write(Hl7.Fhir.Model.Invoice.LineItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 40
			Write(name.ChargeItem as Hl7.Fhir.Model.ResourceReference, writer, "chargeItemReference", cancellationToken); // 50
			Write(name.ChargeItem as Hl7.Fhir.Model.CodeableConcept, writer, "chargeItemCodeableConcept", cancellationToken); // 50
			Write(name.PriceComponent, writer, "priceComponent", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Invoice.PriceComponentComponent
		public static void Write(Hl7.Fhir.Model.Invoice.PriceComponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			Write(name.FactorElement, writer, "factor", cancellationToken); // 60
			Write(name.Amount, writer, "amount", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Linkage.ItemComponent
		public static void Write(Hl7.Fhir.Model.Linkage.ItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Resource, writer, "resource", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.List.EntryComponent
		public static void Write(Hl7.Fhir.Model.List.EntryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Flag, writer, "flag", cancellationToken); // 40
			Write(name.DeletedElement, writer, "deleted", cancellationToken); // 50
			Write(name.DateElement, writer, "date", cancellationToken); // 60
			Write(name.Item, writer, "item", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Location.PositionComponent
		public static void Write(Hl7.Fhir.Model.Location.PositionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LongitudeElement, writer, "longitude", cancellationToken); // 40
			Write(name.LatitudeElement, writer, "latitude", cancellationToken); // 50
			Write(name.AltitudeElement, writer, "altitude", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Location.HoursOfOperationComponent
		public static void Write(Hl7.Fhir.Model.Location.HoursOfOperationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DaysOfWeekElement, writer, "daysOfWeek", cancellationToken); // 40
			Write(name.AllDayElement, writer, "allDay", cancellationToken); // 50
			Write(name.OpeningTimeElement, writer, "openingTime", cancellationToken); // 60
			Write(name.ClosingTimeElement, writer, "closingTime", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Measure.GroupComponent
		public static void Write(Hl7.Fhir.Model.Measure.GroupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Population, writer, "population", cancellationToken); // 60
			Write(name.Stratifier, writer, "stratifier", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Measure.PopulationComponent
		public static void Write(Hl7.Fhir.Model.Measure.PopulationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Criteria, writer, "criteria", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Measure.StratifierComponent
		public static void Write(Hl7.Fhir.Model.Measure.StratifierComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Criteria, writer, "criteria", cancellationToken); // 60
			Write(name.Component, writer, "component", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Measure.ComponentComponent
		public static void Write(Hl7.Fhir.Model.Measure.ComponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Criteria, writer, "criteria", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Measure.SupplementalDataComponent
		public static void Write(Hl7.Fhir.Model.Measure.SupplementalDataComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Usage, writer, "usage", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.Criteria, writer, "criteria", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MeasureReport.GroupComponent
		public static void Write(Hl7.Fhir.Model.MeasureReport.GroupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Population, writer, "population", cancellationToken); // 50
			Write(name.MeasureScore, writer, "measureScore", cancellationToken); // 60
			Write(name.Stratifier, writer, "stratifier", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MeasureReport.PopulationComponent
		public static void Write(Hl7.Fhir.Model.MeasureReport.PopulationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.CountElement, writer, "count", cancellationToken); // 50
			Write(name.SubjectResults, writer, "subjectResults", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MeasureReport.StratifierComponent
		public static void Write(Hl7.Fhir.Model.MeasureReport.StratifierComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Stratum, writer, "stratum", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MeasureReport.StratifierGroupComponent
		public static void Write(Hl7.Fhir.Model.MeasureReport.StratifierGroupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value, writer, "value", cancellationToken); // 40
			Write(name.Component, writer, "component", cancellationToken); // 50
			Write(name.Population, writer, "population", cancellationToken); // 60
			Write(name.MeasureScore, writer, "measureScore", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MeasureReport.ComponentComponent
		public static void Write(Hl7.Fhir.Model.MeasureReport.ComponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Value, writer, "value", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MeasureReport.StratifierGroupPopulationComponent
		public static void Write(Hl7.Fhir.Model.MeasureReport.StratifierGroupPopulationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.CountElement, writer, "count", cancellationToken); // 50
			Write(name.SubjectResults, writer, "subjectResults", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Medication.IngredientComponent
		public static void Write(Hl7.Fhir.Model.Medication.IngredientComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 40
			Write(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 40
			Write(name.IsActiveElement, writer, "isActive", cancellationToken); // 50
			Write(name.Strength, writer, "strength", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Medication.BatchComponent
		public static void Write(Hl7.Fhir.Model.Medication.BatchComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LotNumberElement, writer, "lotNumber", cancellationToken); // 40
			Write(name.ExpirationDateElement, writer, "expirationDate", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationAdministration.PerformerComponent
		public static void Write(Hl7.Fhir.Model.MedicationAdministration.PerformerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Function, writer, "function", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationAdministration.DosageComponent
		public static void Write(Hl7.Fhir.Model.MedicationAdministration.DosageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TextElement, writer, "text", cancellationToken); // 40
			Write(name.Site, writer, "site", cancellationToken); // 50
			Write(name.Route, writer, "route", cancellationToken); // 60
			Write(name.Method, writer, "method", cancellationToken); // 70
			Write(name.Dose, writer, "dose", cancellationToken); // 80
			Write(name.Rate as Hl7.Fhir.Model.Ratio, writer, "rateRatio", cancellationToken); // 90
			Write(name.Rate as Hl7.Fhir.Model.Quantity, writer, "rateQuantity", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationDispense.PerformerComponent
		public static void Write(Hl7.Fhir.Model.MedicationDispense.PerformerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Function, writer, "function", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent
		public static void Write(Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.WasSubstitutedElement, writer, "wasSubstituted", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Reason, writer, "reason", cancellationToken); // 60
			Write(name.ResponsibleParty, writer, "responsibleParty", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Reference, writer, "reference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.MonographComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.MonographComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Source, writer, "source", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 40
			Write(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 40
			Write(name.IsActiveElement, writer, "isActive", cancellationToken); // 50
			Write(name.Strength, writer, "strength", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.CostComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.CostComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.SourceElement, writer, "source", cancellationToken); // 50
			Write(name.Cost, writer, "cost", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.NameElement, writer, "name", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Dosage, writer, "dosage", cancellationToken); // 40
			Write(name.Indication as Hl7.Fhir.Model.CodeableConcept, writer, "indicationCodeableConcept", cancellationToken); // 50
			Write(name.Indication as Hl7.Fhir.Model.ResourceReference, writer, "indicationReference", cancellationToken); // 50
			Write(name.PatientCharacteristics, writer, "patientCharacteristics", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.DosageComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.DosageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Dosage, writer, "dosage", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.PatientCharacteristicsComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.PatientCharacteristicsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Characteristic as Hl7.Fhir.Model.CodeableConcept, writer, "characteristicCodeableConcept", cancellationToken); // 40
			Write(name.Characteristic as Hl7.Fhir.Model.SimpleQuantity, writer, "characteristicQuantity", cancellationToken); // 40
			Write(name.ValueElement, writer, "value", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Classification, writer, "classification", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Quantity, writer, "quantity", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RegulatoryAuthority, writer, "regulatoryAuthority", cancellationToken); // 40
			Write(name.Substitution, writer, "substitution", cancellationToken); // 50
			Write(name.Schedule, writer, "schedule", cancellationToken); // 60
			Write(name.MaxDispense, writer, "maxDispense", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.SubstitutionComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.SubstitutionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.AllowedElement, writer, "allowed", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.ScheduleComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.ScheduleComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Schedule, writer, "schedule", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Quantity, writer, "quantity", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent
		public static void Write(Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.AreaUnderCurve, writer, "areaUnderCurve", cancellationToken); // 40
			Write(name.LethalDose50, writer, "lethalDose50", cancellationToken); // 50
			Write(name.HalfLifePeriod, writer, "halfLifePeriod", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent
		public static void Write(Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.InitialFill, writer, "initialFill", cancellationToken); // 40
			Write(name.DispenseInterval, writer, "dispenseInterval", cancellationToken); // 50
			Write(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 60
			Write(name.NumberOfRepeatsAllowedElement, writer, "numberOfRepeatsAllowed", cancellationToken); // 70
			Write(name.Quantity, writer, "quantity", cancellationToken); // 80
			Write(name.ExpectedSupplyDuration, writer, "expectedSupplyDuration", cancellationToken); // 90
			Write(name.Performer, writer, "performer", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationRequest.InitialFillComponent
		public static void Write(Hl7.Fhir.Model.MedicationRequest.InitialFillComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Quantity, writer, "quantity", cancellationToken); // 40
			Write(name.Duration, writer, "duration", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent
		public static void Write(Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Allowed as Hl7.Fhir.Model.FhirBoolean, writer, "allowedBoolean", cancellationToken); // 40
			Write(name.Allowed as Hl7.Fhir.Model.CodeableConcept, writer, "allowedCodeableConcept", cancellationToken); // 40
			Write(name.Reason, writer, "reason", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProduct.NameComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProduct.NameComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ProductNameElement, writer, "productName", cancellationToken); // 40
			Write(name.NamePart, writer, "namePart", cancellationToken); // 50
			Write(name.CountryLanguage, writer, "countryLanguage", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProduct.NamePartComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProduct.NamePartComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PartElement, writer, "part", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProduct.CountryLanguageComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProduct.CountryLanguageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Country, writer, "country", cancellationToken); // 40
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 50
			Write(name.Language, writer, "language", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.OperationType, writer, "operationType", cancellationToken); // 40
			Write(name.AuthorisationReferenceNumber, writer, "authorisationReferenceNumber", cancellationToken); // 50
			Write(name.EffectiveDateElement, writer, "effectiveDate", cancellationToken); // 60
			Write(name.ConfidentialityIndicator, writer, "confidentialityIndicator", cancellationToken); // 70
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 80
			Write(name.Regulator, writer, "regulator", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProduct.SpecialDesignationComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProduct.SpecialDesignationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.IntendedUse, writer, "intendedUse", cancellationToken); // 60
			Write(name.Indication as Hl7.Fhir.Model.CodeableConcept, writer, "indicationCodeableConcept", cancellationToken); // 70
			Write(name.Indication as Hl7.Fhir.Model.ResourceReference, writer, "indicationReference", cancellationToken); // 70
			Write(name.Status, writer, "status", cancellationToken); // 80
			Write(name.DateElement, writer, "date", cancellationToken); // 90
			Write(name.Species, writer, "species", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductAuthorization.JurisdictionalAuthorizationComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductAuthorization.JurisdictionalAuthorizationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Country, writer, "country", cancellationToken); // 50
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 60
			Write(name.LegalStatusOfSupply, writer, "legalStatusOfSupply", cancellationToken); // 70
			Write(name.ValidityPeriod, writer, "validityPeriod", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Date as Hl7.Fhir.Model.Period, writer, "datePeriod", cancellationToken); // 60
			Write(name.Date as Hl7.Fhir.Model.FhirDateTime, writer, "dateDateTime", cancellationToken); // 60
			Write(name.Application, writer, "application", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductContraindication.OtherTherapyComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductContraindication.OtherTherapyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TherapyRelationshipType, writer, "therapyRelationshipType", cancellationToken); // 40
			Write(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 50
			Write(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TherapyRelationshipType, writer, "therapyRelationshipType", cancellationToken); // 40
			Write(name.Medication as Hl7.Fhir.Model.CodeableConcept, writer, "medicationCodeableConcept", cancellationToken); // 50
			Write(name.Medication as Hl7.Fhir.Model.ResourceReference, writer, "medicationReference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductIngredient.SpecifiedSubstanceComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductIngredient.SpecifiedSubstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Group, writer, "group", cancellationToken); // 50
			Write(name.Confidentiality, writer, "confidentiality", cancellationToken); // 60
			Write(name.Strength, writer, "strength", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductIngredient.StrengthComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductIngredient.StrengthComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Presentation, writer, "presentation", cancellationToken); // 40
			Write(name.PresentationLowLimit, writer, "presentationLowLimit", cancellationToken); // 50
			Write(name.Concentration, writer, "concentration", cancellationToken); // 60
			Write(name.ConcentrationLowLimit, writer, "concentrationLowLimit", cancellationToken); // 70
			Write(name.MeasurementPointElement, writer, "measurementPoint", cancellationToken); // 80
			Write(name.Country, writer, "country", cancellationToken); // 90
			Write(name.ReferenceStrength, writer, "referenceStrength", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductIngredient.ReferenceStrengthComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductIngredient.ReferenceStrengthComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Substance, writer, "substance", cancellationToken); // 40
			Write(name.Strength, writer, "strength", cancellationToken); // 50
			Write(name.StrengthLowLimit, writer, "strengthLowLimit", cancellationToken); // 60
			Write(name.MeasurementPointElement, writer, "measurementPoint", cancellationToken); // 70
			Write(name.Country, writer, "country", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Strength, writer, "strength", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductInteraction.InteractantComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductInteraction.InteractantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 40
			Write(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.OuterPackaging, writer, "outerPackaging", cancellationToken); // 40
			Write(name.ImmediatePackaging, writer, "immediatePackaging", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Quantity, writer, "quantity", cancellationToken); // 60
			Write(name.Material, writer, "material", cancellationToken); // 70
			Write(name.AlternateMaterial, writer, "alternateMaterial", cancellationToken); // 80
			Write(name.Device, writer, "device", cancellationToken); // 90
			Write(name.ManufacturedItem, writer, "manufacturedItem", cancellationToken); // 100
			Write(name.PackageItem, writer, "packageItem", cancellationToken); // 110
			Write(name.PhysicalCharacteristics, writer, "physicalCharacteristics", cancellationToken); // 120
			Write(name.OtherCharacteristics, writer, "otherCharacteristics", cancellationToken); // 130
			Write(name.ShelfLifeStorage, writer, "shelfLifeStorage", cancellationToken); // 140
			Write(name.Manufacturer, writer, "manufacturer", cancellationToken); // 150
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Status, writer, "status", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.FirstDose, writer, "firstDose", cancellationToken); // 50
			Write(name.MaxSingleDose, writer, "maxSingleDose", cancellationToken); // 60
			Write(name.MaxDosePerDay, writer, "maxDosePerDay", cancellationToken); // 70
			Write(name.MaxDosePerTreatmentPeriod, writer, "maxDosePerTreatmentPeriod", cancellationToken); // 80
			Write(name.MaxTreatmentPeriod, writer, "maxTreatmentPeriod", cancellationToken); // 90
			Write(name.TargetSpecies, writer, "targetSpecies", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.WithdrawalPeriod, writer, "withdrawalPeriod", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent
		public static void Write(Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Tissue, writer, "tissue", cancellationToken); // 40
			Write(name.Value, writer, "value", cancellationToken); // 50
			Write(name.SupportingInformationElement, writer, "supportingInformation", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageDefinition.FocusComponent
		public static void Write(Hl7.Fhir.Model.MessageDefinition.FocusComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.ProfileElement, writer, "profile", cancellationToken); // 50
			Write(name.MinElement, writer, "min", cancellationToken); // 60
			Write(name.MaxElement, writer, "max", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageDefinition.AllowedResponseComponent
		public static void Write(Hl7.Fhir.Model.MessageDefinition.AllowedResponseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.MessageElement, writer, "message", cancellationToken); // 40
			Write(name.Situation, writer, "situation", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent
		public static void Write(Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Target, writer, "target", cancellationToken); // 50
			Write(name.EndpointElement, writer, "endpoint", cancellationToken); // 60
			Write(name.Receiver, writer, "receiver", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageHeader.MessageSourceComponent
		public static void Write(Hl7.Fhir.Model.MessageHeader.MessageSourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.SoftwareElement, writer, "software", cancellationToken); // 50
			Write(name.VersionElement, writer, "version", cancellationToken); // 60
			Write(name.Contact, writer, "contact", cancellationToken); // 70
			Write(name.EndpointElement, writer, "endpoint", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MessageHeader.ResponseComponent
		public static void Write(Hl7.Fhir.Model.MessageHeader.ResponseComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.IdentifierElement, writer, "identifier", cancellationToken); // 40
			Write(name.CodeElement, writer, "code", cancellationToken); // 50
			Write(name.Details, writer, "details", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Chromosome, writer, "chromosome", cancellationToken); // 40
			Write(name.GenomeBuildElement, writer, "genomeBuild", cancellationToken); // 50
			Write(name.OrientationElement, writer, "orientation", cancellationToken); // 60
			Write(name.ReferenceSeqId, writer, "referenceSeqId", cancellationToken); // 70
			Write(name.ReferenceSeqPointer, writer, "referenceSeqPointer", cancellationToken); // 80
			Write(name.ReferenceSeqStringElement, writer, "referenceSeqString", cancellationToken); // 90
			Write(name.StrandElement, writer, "strand", cancellationToken); // 100
			Write(name.WindowStartElement, writer, "windowStart", cancellationToken); // 110
			Write(name.WindowEndElement, writer, "windowEnd", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.VariantComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.VariantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StartElement, writer, "start", cancellationToken); // 40
			Write(name.EndElement, writer, "end", cancellationToken); // 50
			Write(name.ObservedAlleleElement, writer, "observedAllele", cancellationToken); // 60
			Write(name.ReferenceAlleleElement, writer, "referenceAllele", cancellationToken); // 70
			Write(name.CigarElement, writer, "cigar", cancellationToken); // 80
			Write(name.VariantPointer, writer, "variantPointer", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.QualityComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.QualityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.StandardSequence, writer, "standardSequence", cancellationToken); // 50
			Write(name.StartElement, writer, "start", cancellationToken); // 60
			Write(name.EndElement, writer, "end", cancellationToken); // 70
			Write(name.Score, writer, "score", cancellationToken); // 80
			Write(name.Method, writer, "method", cancellationToken); // 90
			Write(name.TruthTPElement, writer, "truthTP", cancellationToken); // 100
			Write(name.QueryTPElement, writer, "queryTP", cancellationToken); // 110
			Write(name.TruthFNElement, writer, "truthFN", cancellationToken); // 120
			Write(name.QueryFPElement, writer, "queryFP", cancellationToken); // 130
			Write(name.GtFPElement, writer, "gtFP", cancellationToken); // 140
			Write(name.PrecisionElement, writer, "precision", cancellationToken); // 150
			Write(name.RecallElement, writer, "recall", cancellationToken); // 160
			Write(name.FScoreElement, writer, "fScore", cancellationToken); // 170
			Write(name.Roc, writer, "roc", cancellationToken); // 180
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.RocComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.RocComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ScoreElement, writer, "score", cancellationToken); // 40
			Write(name.NumTPElement, writer, "numTP", cancellationToken); // 50
			Write(name.NumFPElement, writer, "numFP", cancellationToken); // 60
			Write(name.NumFNElement, writer, "numFN", cancellationToken); // 70
			Write(name.PrecisionElement, writer, "precision", cancellationToken); // 80
			Write(name.SensitivityElement, writer, "sensitivity", cancellationToken); // 90
			Write(name.FMeasureElement, writer, "fMeasure", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.RepositoryComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.RepositoryComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.UrlElement, writer, "url", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.DatasetIdElement, writer, "datasetId", cancellationToken); // 70
			Write(name.VariantsetIdElement, writer, "variantsetId", cancellationToken); // 80
			Write(name.ReadsetIdElement, writer, "readsetId", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.StructureVariantComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.StructureVariantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.VariantType, writer, "variantType", cancellationToken); // 40
			Write(name.ExactElement, writer, "exact", cancellationToken); // 50
			Write(name.LengthElement, writer, "length", cancellationToken); // 60
			Write(name.Outer, writer, "outer", cancellationToken); // 70
			Write(name.Inner, writer, "inner", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.OuterComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.OuterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StartElement, writer, "start", cancellationToken); // 40
			Write(name.EndElement, writer, "end", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.MolecularSequence.InnerComponent
		public static void Write(Hl7.Fhir.Model.MolecularSequence.InnerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StartElement, writer, "start", cancellationToken); // 40
			Write(name.EndElement, writer, "end", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NamingSystem.UniqueIdComponent
		public static void Write(Hl7.Fhir.Model.NamingSystem.UniqueIdComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.ValueElement, writer, "value", cancellationToken); // 50
			Write(name.PreferredElement, writer, "preferred", cancellationToken); // 60
			Write(name.CommentElement, writer, "comment", cancellationToken); // 70
			Write(name.Period, writer, "period", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.OralDietComponent
		public static void Write(Hl7.Fhir.Model.NutritionOrder.OralDietComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Schedule, writer, "schedule", cancellationToken); // 50
			Write(name.Nutrient, writer, "nutrient", cancellationToken); // 60
			Write(name.Texture, writer, "texture", cancellationToken); // 70
			Write(name.FluidConsistencyType, writer, "fluidConsistencyType", cancellationToken); // 80
			Write(name.InstructionElement, writer, "instruction", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.NutrientComponent
		public static void Write(Hl7.Fhir.Model.NutritionOrder.NutrientComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Modifier, writer, "modifier", cancellationToken); // 40
			Write(name.Amount, writer, "amount", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.TextureComponent
		public static void Write(Hl7.Fhir.Model.NutritionOrder.TextureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Modifier, writer, "modifier", cancellationToken); // 40
			Write(name.FoodType, writer, "foodType", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.SupplementComponent
		public static void Write(Hl7.Fhir.Model.NutritionOrder.SupplementComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.ProductNameElement, writer, "productName", cancellationToken); // 50
			Write(name.Schedule, writer, "schedule", cancellationToken); // 60
			Write(name.Quantity, writer, "quantity", cancellationToken); // 70
			Write(name.InstructionElement, writer, "instruction", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent
		public static void Write(Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.BaseFormulaType, writer, "baseFormulaType", cancellationToken); // 40
			Write(name.BaseFormulaProductNameElement, writer, "baseFormulaProductName", cancellationToken); // 50
			Write(name.AdditiveType, writer, "additiveType", cancellationToken); // 60
			Write(name.AdditiveProductNameElement, writer, "additiveProductName", cancellationToken); // 70
			Write(name.CaloricDensity, writer, "caloricDensity", cancellationToken); // 80
			Write(name.RouteofAdministration, writer, "routeofAdministration", cancellationToken); // 90
			Write(name.Administration, writer, "administration", cancellationToken); // 100
			Write(name.MaxVolumeToDeliver, writer, "maxVolumeToDeliver", cancellationToken); // 110
			Write(name.AdministrationInstructionElement, writer, "administrationInstruction", cancellationToken); // 120
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.NutritionOrder.AdministrationComponent
		public static void Write(Hl7.Fhir.Model.NutritionOrder.AdministrationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Schedule, writer, "schedule", cancellationToken); // 40
			Write(name.Quantity, writer, "quantity", cancellationToken); // 50
			Write(name.Rate as Hl7.Fhir.Model.Quantity, writer, "rateQuantity", cancellationToken); // 60
			Write(name.Rate as Hl7.Fhir.Model.Ratio, writer, "rateRatio", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Observation.ReferenceRangeComponent
		public static void Write(Hl7.Fhir.Model.Observation.ReferenceRangeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Low, writer, "low", cancellationToken); // 40
			Write(name.High, writer, "high", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			Write(name.AppliesTo, writer, "appliesTo", cancellationToken); // 70
			Write(name.Age, writer, "age", cancellationToken); // 80
			Write(name.TextElement, writer, "text", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Observation.ComponentComponent
		public static void Write(Hl7.Fhir.Model.Observation.ComponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 50
			Write(name.DataAbsentReason, writer, "dataAbsentReason", cancellationToken); // 60
			Write(name.Interpretation, writer, "interpretation", cancellationToken); // 70
			Write(name.ReferenceRange, writer, "referenceRange", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent
		public static void Write(Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CustomaryUnit, writer, "customaryUnit", cancellationToken); // 40
			Write(name.Unit, writer, "unit", cancellationToken); // 50
			Write(name.ConversionFactorElement, writer, "conversionFactor", cancellationToken); // 60
			Write(name.DecimalPrecisionElement, writer, "decimalPrecision", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent
		public static void Write(Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CategoryElement, writer, "category", cancellationToken); // 40
			Write(name.Range, writer, "range", cancellationToken); // 50
			Write(name.Context, writer, "context", cancellationToken); // 60
			Write(name.AppliesTo, writer, "appliesTo", cancellationToken); // 70
			Write(name.GenderElement, writer, "gender", cancellationToken); // 80
			Write(name.Age, writer, "age", cancellationToken); // 90
			Write(name.GestationalAge, writer, "gestationalAge", cancellationToken); // 100
			Write(name.ConditionElement, writer, "condition", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.OperationDefinition.ParameterComponent
		public static void Write(Hl7.Fhir.Model.OperationDefinition.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.UseElement, writer, "use", cancellationToken); // 50
			Write(name.MinElement, writer, "min", cancellationToken); // 60
			Write(name.MaxElement, writer, "max", cancellationToken); // 70
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 80
			Write(name.TypeElement, writer, "type", cancellationToken); // 90
			Write(name.TargetProfileElement, writer, "targetProfile", cancellationToken); // 100
			Write(name.SearchTypeElement, writer, "searchType", cancellationToken); // 110
			Write(name.Binding, writer, "binding", cancellationToken); // 120
			Write(name.ReferencedFrom, writer, "referencedFrom", cancellationToken); // 130
			Write(name.Part, writer, "part", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.OperationDefinition.BindingComponent
		public static void Write(Hl7.Fhir.Model.OperationDefinition.BindingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.StrengthElement, writer, "strength", cancellationToken); // 40
			Write(name.ValueSetElement, writer, "valueSet", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.OperationDefinition.ReferencedFromComponent
		public static void Write(Hl7.Fhir.Model.OperationDefinition.ReferencedFromComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SourceElement, writer, "source", cancellationToken); // 40
			Write(name.SourceIdElement, writer, "sourceId", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.OperationDefinition.OverloadComponent
		public static void Write(Hl7.Fhir.Model.OperationDefinition.OverloadComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ParameterNameElement, writer, "parameterName", cancellationToken); // 40
			Write(name.CommentElement, writer, "comment", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.OperationOutcome.IssueComponent
		public static void Write(Hl7.Fhir.Model.OperationOutcome.IssueComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SeverityElement, writer, "severity", cancellationToken); // 40
			Write(name.CodeElement, writer, "code", cancellationToken); // 50
			Write(name.Details, writer, "details", cancellationToken); // 60
			Write(name.DiagnosticsElement, writer, "diagnostics", cancellationToken); // 70
			Write(name.LocationElement, writer, "location", cancellationToken); // 80
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Organization.ContactComponent
		public static void Write(Hl7.Fhir.Model.Organization.ContactComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Purpose, writer, "purpose", cancellationToken); // 40
			Write(name.Name, writer, "name", cancellationToken); // 50
			Write(name.Telecom, writer, "telecom", cancellationToken); // 60
			Write(name.Address, writer, "address", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Parameters.ParameterComponent
		public static void Write(Hl7.Fhir.Model.Parameters.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Canonical, writer, "valueCanonical", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Instant, writer, "valueInstant", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Markdown, writer, "valueMarkdown", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Oid, writer, "valueOid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.PositiveInt, writer, "valuePositiveInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UnsignedInt, writer, "valueUnsignedInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUrl, writer, "valueUrl", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Uuid, writer, "valueUuid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Address, writer, "valueAddress", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Age, writer, "valueAge", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Annotation, writer, "valueAnnotation", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactPoint, writer, "valueContactPoint", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Count, writer, "valueCount", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Distance, writer, "valueDistance", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.HumanName, writer, "valueHumanName", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Identifier, writer, "valueIdentifier", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Signature, writer, "valueSignature", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Timing, writer, "valueTiming", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactDetail, writer, "valueContactDetail", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Contributor, writer, "valueContributor", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.DataRequirement, writer, "valueDataRequirement", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Expression, writer, "valueExpression", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ParameterDefinition, writer, "valueParameterDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.RelatedArtifact, writer, "valueRelatedArtifact", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.TriggerDefinition, writer, "valueTriggerDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UsageContext, writer, "valueUsageContext", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Dosage, writer, "valueDosage", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Meta, writer, "valueMeta", cancellationToken); // 50
			WriteBase(name.Resource, writer, "resource", cancellationToken); // 60
			Write(name.Part, writer, "part", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Patient.ContactComponent
		public static void Write(Hl7.Fhir.Model.Patient.ContactComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Relationship, writer, "relationship", cancellationToken); // 40
			Write(name.Name, writer, "name", cancellationToken); // 50
			Write(name.Telecom, writer, "telecom", cancellationToken); // 60
			Write(name.Address, writer, "address", cancellationToken); // 70
			Write(name.GenderElement, writer, "gender", cancellationToken); // 80
			Write(name.Organization, writer, "organization", cancellationToken); // 90
			Write(name.Period, writer, "period", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Patient.CommunicationComponent
		public static void Write(Hl7.Fhir.Model.Patient.CommunicationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Language, writer, "language", cancellationToken); // 40
			Write(name.PreferredElement, writer, "preferred", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Patient.LinkComponent
		public static void Write(Hl7.Fhir.Model.Patient.LinkComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Other, writer, "other", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PaymentReconciliation.DetailsComponent
		public static void Write(Hl7.Fhir.Model.PaymentReconciliation.DetailsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Predecessor, writer, "predecessor", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			Write(name.Request, writer, "request", cancellationToken); // 70
			Write(name.Submitter, writer, "submitter", cancellationToken); // 80
			Write(name.Response, writer, "response", cancellationToken); // 90
			Write(name.DateElement, writer, "date", cancellationToken); // 100
			Write(name.Responsible, writer, "responsible", cancellationToken); // 110
			Write(name.Payee, writer, "payee", cancellationToken); // 120
			Write(name.Amount, writer, "amount", cancellationToken); // 130
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PaymentReconciliation.NotesComponent
		public static void Write(Hl7.Fhir.Model.PaymentReconciliation.NotesComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.TextElement, writer, "text", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Person.LinkComponent
		public static void Write(Hl7.Fhir.Model.Person.LinkComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Target, writer, "target", cancellationToken); // 40
			Write(name.AssuranceElement, writer, "assurance", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.GoalComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.GoalComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Description, writer, "description", cancellationToken); // 50
			Write(name.Priority, writer, "priority", cancellationToken); // 60
			Write(name.Start, writer, "start", cancellationToken); // 70
			Write(name.Addresses, writer, "addresses", cancellationToken); // 80
			Write(name.Documentation, writer, "documentation", cancellationToken); // 90
			Write(name.Target, writer, "target", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.TargetComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.TargetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Measure, writer, "measure", cancellationToken); // 40
			Write(name.Detail as Hl7.Fhir.Model.Quantity, writer, "detailQuantity", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.Range, writer, "detailRange", cancellationToken); // 50
			Write(name.Detail as Hl7.Fhir.Model.CodeableConcept, writer, "detailCodeableConcept", cancellationToken); // 50
			Write(name.Due, writer, "due", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.ActionComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.ActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PrefixElement, writer, "prefix", cancellationToken); // 40
			Write(name.TitleElement, writer, "title", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.TextEquivalentElement, writer, "textEquivalent", cancellationToken); // 70
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 80
			Write(name.Code, writer, "code", cancellationToken); // 90
			Write(name.Reason, writer, "reason", cancellationToken); // 100
			Write(name.Documentation, writer, "documentation", cancellationToken); // 110
			Write(name.GoalIdElement, writer, "goalId", cancellationToken); // 120
			Write(name.Subject as Hl7.Fhir.Model.CodeableConcept, writer, "subjectCodeableConcept", cancellationToken); // 130
			Write(name.Subject as Hl7.Fhir.Model.ResourceReference, writer, "subjectReference", cancellationToken); // 130
			Write(name.Trigger, writer, "trigger", cancellationToken); // 140
			Write(name.Condition, writer, "condition", cancellationToken); // 150
			Write(name.Input, writer, "input", cancellationToken); // 160
			Write(name.Output, writer, "output", cancellationToken); // 170
			Write(name.RelatedAction, writer, "relatedAction", cancellationToken); // 180
			Write(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 190
			Write(name.Timing as Hl7.Fhir.Model.Age, writer, "timingAge", cancellationToken); // 190
			Write(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 190
			Write(name.Timing as Hl7.Fhir.Model.Duration, writer, "timingDuration", cancellationToken); // 190
			Write(name.Timing as Hl7.Fhir.Model.Range, writer, "timingRange", cancellationToken); // 190
			Write(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 190
			Write(name.Participant, writer, "participant", cancellationToken); // 200
			Write(name.Type, writer, "type", cancellationToken); // 210
			Write(name.GroupingBehaviorElement, writer, "groupingBehavior", cancellationToken); // 220
			Write(name.SelectionBehaviorElement, writer, "selectionBehavior", cancellationToken); // 230
			Write(name.RequiredBehaviorElement, writer, "requiredBehavior", cancellationToken); // 240
			Write(name.PrecheckBehaviorElement, writer, "precheckBehavior", cancellationToken); // 250
			Write(name.CardinalityBehaviorElement, writer, "cardinalityBehavior", cancellationToken); // 260
			Write(name.Definition as Hl7.Fhir.Model.Canonical, writer, "definitionCanonical", cancellationToken); // 270
			Write(name.Definition as Hl7.Fhir.Model.FhirUri, writer, "definitionUri", cancellationToken); // 270
			Write(name.TransformElement, writer, "transform", cancellationToken); // 280
			Write(name.DynamicValue, writer, "dynamicValue", cancellationToken); // 290
			Write(name.Action, writer, "action", cancellationToken); // 300
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.ConditionComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.ConditionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.KindElement, writer, "kind", cancellationToken); // 40
			Write(name.Expression, writer, "expression", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ActionIdElement, writer, "actionId", cancellationToken); // 40
			Write(name.RelationshipElement, writer, "relationship", cancellationToken); // 50
			Write(name.Offset as Hl7.Fhir.Model.Duration, writer, "offsetDuration", cancellationToken); // 60
			Write(name.Offset as Hl7.Fhir.Model.Range, writer, "offsetRange", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PlanDefinition.DynamicValueComponent
		public static void Write(Hl7.Fhir.Model.PlanDefinition.DynamicValueComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PathElement, writer, "path", cancellationToken); // 40
			Write(name.Expression, writer, "expression", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Practitioner.QualificationComponent
		public static void Write(Hl7.Fhir.Model.Practitioner.QualificationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			Write(name.Period, writer, "period", cancellationToken); // 60
			Write(name.Issuer, writer, "issuer", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent
		public static void Write(Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DaysOfWeekElement, writer, "daysOfWeek", cancellationToken); // 40
			Write(name.AllDayElement, writer, "allDay", cancellationToken); // 50
			Write(name.AvailableStartTimeElement, writer, "availableStartTime", cancellationToken); // 60
			Write(name.AvailableEndTimeElement, writer, "availableEndTime", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.PractitionerRole.NotAvailableComponent
		public static void Write(Hl7.Fhir.Model.PractitionerRole.NotAvailableComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.During, writer, "during", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Procedure.PerformerComponent
		public static void Write(Hl7.Fhir.Model.Procedure.PerformerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Function, writer, "function", cancellationToken); // 40
			Write(name.Actor, writer, "actor", cancellationToken); // 50
			Write(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Procedure.FocalDeviceComponent
		public static void Write(Hl7.Fhir.Model.Procedure.FocalDeviceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Action, writer, "action", cancellationToken); // 40
			Write(name.Manipulated, writer, "manipulated", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Provenance.AgentComponent
		public static void Write(Hl7.Fhir.Model.Provenance.AgentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Role, writer, "role", cancellationToken); // 50
			Write(name.Who, writer, "who", cancellationToken); // 60
			Write(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Provenance.EntityComponent
		public static void Write(Hl7.Fhir.Model.Provenance.EntityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RoleElement, writer, "role", cancellationToken); // 40
			Write(name.What, writer, "what", cancellationToken); // 50
			Write(name.Agent, writer, "agent", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Questionnaire.ItemComponent
		public static void Write(Hl7.Fhir.Model.Questionnaire.ItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LinkIdElement, writer, "linkId", cancellationToken); // 40
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 50
			Write(name.Code, writer, "code", cancellationToken); // 60
			Write(name.PrefixElement, writer, "prefix", cancellationToken); // 70
			Write(name.TextElement, writer, "text", cancellationToken); // 80
			Write(name.TypeElement, writer, "type", cancellationToken); // 90
			Write(name.EnableWhen, writer, "enableWhen", cancellationToken); // 100
			Write(name.EnableBehaviorElement, writer, "enableBehavior", cancellationToken); // 110
			Write(name.RequiredElement, writer, "required", cancellationToken); // 120
			Write(name.RepeatsElement, writer, "repeats", cancellationToken); // 130
			Write(name.ReadOnlyElement, writer, "readOnly", cancellationToken); // 140
			Write(name.MaxLengthElement, writer, "maxLength", cancellationToken); // 150
			Write(name.AnswerValueSetElement, writer, "answerValueSet", cancellationToken); // 160
			Write(name.AnswerOption, writer, "answerOption", cancellationToken); // 170
			Write(name.Initial, writer, "initial", cancellationToken); // 180
			Write(name.Item, writer, "item", cancellationToken); // 190
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Questionnaire.EnableWhenComponent
		public static void Write(Hl7.Fhir.Model.Questionnaire.EnableWhenComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.QuestionElement, writer, "question", cancellationToken); // 40
			Write(name.OperatorElement, writer, "operator", cancellationToken); // 50
			Write(name.Answer as Hl7.Fhir.Model.FhirBoolean, writer, "answerBoolean", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.FhirDecimal, writer, "answerDecimal", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.Integer, writer, "answerInteger", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.Date, writer, "answerDate", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.FhirDateTime, writer, "answerDateTime", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.Time, writer, "answerTime", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.FhirString, writer, "answerString", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.Coding, writer, "answerCoding", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.Quantity, writer, "answerQuantity", cancellationToken); // 60
			Write(name.Answer as Hl7.Fhir.Model.ResourceReference, writer, "answerReference", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Questionnaire.AnswerOptionComponent
		public static void Write(Hl7.Fhir.Model.Questionnaire.AnswerOptionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			Write(name.InitialSelectedElement, writer, "initialSelected", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Questionnaire.InitialComponent
		public static void Write(Hl7.Fhir.Model.Questionnaire.InitialComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent
		public static void Write(Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LinkIdElement, writer, "linkId", cancellationToken); // 40
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 50
			Write(name.TextElement, writer, "text", cancellationToken); // 60
			Write(name.Answer, writer, "answer", cancellationToken); // 70
			Write(name.Item, writer, "item", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.QuestionnaireResponse.AnswerComponent
		public static void Write(Hl7.Fhir.Model.QuestionnaireResponse.AnswerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 40
			Write(name.Item, writer, "item", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RelatedPerson.CommunicationComponent
		public static void Write(Hl7.Fhir.Model.RelatedPerson.CommunicationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Language, writer, "language", cancellationToken); // 40
			Write(name.PreferredElement, writer, "preferred", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RequestGroup.ActionComponent
		public static void Write(Hl7.Fhir.Model.RequestGroup.ActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PrefixElement, writer, "prefix", cancellationToken); // 40
			Write(name.TitleElement, writer, "title", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.TextEquivalentElement, writer, "textEquivalent", cancellationToken); // 70
			Write(name.PriorityElement, writer, "priority", cancellationToken); // 80
			Write(name.Code, writer, "code", cancellationToken); // 90
			Write(name.Documentation, writer, "documentation", cancellationToken); // 100
			Write(name.Condition, writer, "condition", cancellationToken); // 110
			Write(name.RelatedAction, writer, "relatedAction", cancellationToken); // 120
			Write(name.Timing as Hl7.Fhir.Model.FhirDateTime, writer, "timingDateTime", cancellationToken); // 130
			Write(name.Timing as Hl7.Fhir.Model.Age, writer, "timingAge", cancellationToken); // 130
			Write(name.Timing as Hl7.Fhir.Model.Period, writer, "timingPeriod", cancellationToken); // 130
			Write(name.Timing as Hl7.Fhir.Model.Duration, writer, "timingDuration", cancellationToken); // 130
			Write(name.Timing as Hl7.Fhir.Model.Range, writer, "timingRange", cancellationToken); // 130
			Write(name.Timing as Hl7.Fhir.Model.Timing, writer, "timingTiming", cancellationToken); // 130
			Write(name.Participant, writer, "participant", cancellationToken); // 140
			Write(name.Type, writer, "type", cancellationToken); // 150
			Write(name.GroupingBehaviorElement, writer, "groupingBehavior", cancellationToken); // 160
			Write(name.SelectionBehaviorElement, writer, "selectionBehavior", cancellationToken); // 170
			Write(name.RequiredBehaviorElement, writer, "requiredBehavior", cancellationToken); // 180
			Write(name.PrecheckBehaviorElement, writer, "precheckBehavior", cancellationToken); // 190
			Write(name.CardinalityBehaviorElement, writer, "cardinalityBehavior", cancellationToken); // 200
			Write(name.Resource, writer, "resource", cancellationToken); // 210
			Write(name.Action, writer, "action", cancellationToken); // 220
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RequestGroup.ConditionComponent
		public static void Write(Hl7.Fhir.Model.RequestGroup.ConditionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.KindElement, writer, "kind", cancellationToken); // 40
			Write(name.Expression, writer, "expression", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RequestGroup.RelatedActionComponent
		public static void Write(Hl7.Fhir.Model.RequestGroup.RelatedActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ActionIdElement, writer, "actionId", cancellationToken); // 40
			Write(name.RelationshipElement, writer, "relationship", cancellationToken); // 50
			Write(name.Offset as Hl7.Fhir.Model.Duration, writer, "offsetDuration", cancellationToken); // 60
			Write(name.Offset as Hl7.Fhir.Model.Range, writer, "offsetRange", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ResearchElementDefinition.CharacteristicComponent
		public static void Write(Hl7.Fhir.Model.ResearchElementDefinition.CharacteristicComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Definition as Hl7.Fhir.Model.CodeableConcept, writer, "definitionCodeableConcept", cancellationToken); // 40
			Write(name.Definition as Hl7.Fhir.Model.Canonical, writer, "definitionCanonical", cancellationToken); // 40
			Write(name.Definition as Hl7.Fhir.Model.Expression, writer, "definitionExpression", cancellationToken); // 40
			Write(name.Definition as Hl7.Fhir.Model.DataRequirement, writer, "definitionDataRequirement", cancellationToken); // 40
			Write(name.UsageContext, writer, "usageContext", cancellationToken); // 50
			Write(name.ExcludeElement, writer, "exclude", cancellationToken); // 60
			Write(name.UnitOfMeasure, writer, "unitOfMeasure", cancellationToken); // 70
			Write(name.StudyEffectiveDescriptionElement, writer, "studyEffectiveDescription", cancellationToken); // 80
			Write(name.StudyEffective as Hl7.Fhir.Model.FhirDateTime, writer, "studyEffectiveDateTime", cancellationToken); // 90
			Write(name.StudyEffective as Hl7.Fhir.Model.Period, writer, "studyEffectivePeriod", cancellationToken); // 90
			Write(name.StudyEffective as Hl7.Fhir.Model.Duration, writer, "studyEffectiveDuration", cancellationToken); // 90
			Write(name.StudyEffective as Hl7.Fhir.Model.Timing, writer, "studyEffectiveTiming", cancellationToken); // 90
			Write(name.StudyEffectiveTimeFromStart, writer, "studyEffectiveTimeFromStart", cancellationToken); // 100
			Write(name.StudyEffectiveGroupMeasureElement, writer, "studyEffectiveGroupMeasure", cancellationToken); // 110
			Write(name.ParticipantEffectiveDescriptionElement, writer, "participantEffectiveDescription", cancellationToken); // 120
			Write(name.ParticipantEffective as Hl7.Fhir.Model.FhirDateTime, writer, "participantEffectiveDateTime", cancellationToken); // 130
			Write(name.ParticipantEffective as Hl7.Fhir.Model.Period, writer, "participantEffectivePeriod", cancellationToken); // 130
			Write(name.ParticipantEffective as Hl7.Fhir.Model.Duration, writer, "participantEffectiveDuration", cancellationToken); // 130
			Write(name.ParticipantEffective as Hl7.Fhir.Model.Timing, writer, "participantEffectiveTiming", cancellationToken); // 130
			Write(name.ParticipantEffectiveTimeFromStart, writer, "participantEffectiveTimeFromStart", cancellationToken); // 140
			Write(name.ParticipantEffectiveGroupMeasureElement, writer, "participantEffectiveGroupMeasure", cancellationToken); // 150
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ResearchStudy.ArmComponent
		public static void Write(Hl7.Fhir.Model.ResearchStudy.ArmComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ResearchStudy.ObjectiveComponent
		public static void Write(Hl7.Fhir.Model.ResearchStudy.ObjectiveComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Resource
		public static void WriteResource(Hl7.Fhir.Model.Resource name, XmlWriter writer, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			Write(name.IdElement, writer, "id", cancellationToken); // 10
			Write(name.Meta, writer, "meta", cancellationToken); // 20
			Write(name.ImplicitRulesElement, writer, "implicitRules", cancellationToken); // 30
			Write(name.LanguageElement, writer, "language", cancellationToken); // 40
		}

		// Hl7.Fhir.Model.RiskAssessment.PredictionComponent
		public static void Write(Hl7.Fhir.Model.RiskAssessment.PredictionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Outcome, writer, "outcome", cancellationToken); // 40
			Write(name.Probability as Hl7.Fhir.Model.FhirDecimal, writer, "probabilityDecimal", cancellationToken); // 50
			Write(name.Probability as Hl7.Fhir.Model.Range, writer, "probabilityRange", cancellationToken); // 50
			Write(name.QualitativeRisk, writer, "qualitativeRisk", cancellationToken); // 60
			Write(name.RelativeRiskElement, writer, "relativeRisk", cancellationToken); // 70
			Write(name.When as Hl7.Fhir.Model.Period, writer, "whenPeriod", cancellationToken); // 80
			Write(name.When as Hl7.Fhir.Model.Range, writer, "whenRange", cancellationToken); // 80
			Write(name.RationaleElement, writer, "rationale", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent
		public static void Write(Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.NumberOfStudiesElement, writer, "numberOfStudies", cancellationToken); // 50
			Write(name.NumberOfParticipantsElement, writer, "numberOfParticipants", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent
		public static void Write(Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			Write(name.UnitOfMeasure, writer, "unitOfMeasure", cancellationToken); // 70
			Write(name.DenominatorCountElement, writer, "denominatorCount", cancellationToken); // 80
			Write(name.NumeratorCountElement, writer, "numeratorCount", cancellationToken); // 90
			Write(name.PrecisionEstimate, writer, "precisionEstimate", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.PrecisionEstimateComponent
		public static void Write(Hl7.Fhir.Model.RiskEvidenceSynthesis.PrecisionEstimateComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.LevelElement, writer, "level", cancellationToken); // 50
			Write(name.FromElement, writer, "from", cancellationToken); // 60
			Write(name.ToElement, writer, "to", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintyComponent
		public static void Write(Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Rating, writer, "rating", cancellationToken); // 40
			Write(name.Note, writer, "note", cancellationToken); // 50
			Write(name.CertaintySubcomponent, writer, "certaintySubcomponent", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintySubcomponentComponent
		public static void Write(Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintySubcomponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Rating, writer, "rating", cancellationToken); // 50
			Write(name.Note, writer, "note", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SearchParameter.ComponentComponent
		public static void Write(Hl7.Fhir.Model.SearchParameter.ComponentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DefinitionElement, writer, "definition", cancellationToken); // 40
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Specimen.CollectionComponent
		public static void Write(Hl7.Fhir.Model.Specimen.CollectionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Collector, writer, "collector", cancellationToken); // 40
			Write(name.Collected as Hl7.Fhir.Model.FhirDateTime, writer, "collectedDateTime", cancellationToken); // 50
			Write(name.Collected as Hl7.Fhir.Model.Period, writer, "collectedPeriod", cancellationToken); // 50
			Write(name.Duration, writer, "duration", cancellationToken); // 60
			Write(name.Quantity, writer, "quantity", cancellationToken); // 70
			Write(name.Method, writer, "method", cancellationToken); // 80
			Write(name.BodySite, writer, "bodySite", cancellationToken); // 90
			Write(name.FastingStatus as Hl7.Fhir.Model.CodeableConcept, writer, "fastingStatusCodeableConcept", cancellationToken); // 100
			Write(name.FastingStatus as Hl7.Fhir.Model.Duration, writer, "fastingStatusDuration", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Specimen.ProcessingComponent
		public static void Write(Hl7.Fhir.Model.Specimen.ProcessingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.Procedure, writer, "procedure", cancellationToken); // 50
			Write(name.Additive, writer, "additive", cancellationToken); // 60
			Write(name.Time as Hl7.Fhir.Model.FhirDateTime, writer, "timeDateTime", cancellationToken); // 70
			Write(name.Time as Hl7.Fhir.Model.Period, writer, "timePeriod", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Specimen.ContainerComponent
		public static void Write(Hl7.Fhir.Model.Specimen.ContainerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Type, writer, "type", cancellationToken); // 60
			Write(name.Capacity, writer, "capacity", cancellationToken); // 70
			Write(name.SpecimenQuantity, writer, "specimenQuantity", cancellationToken); // 80
			Write(name.Additive as Hl7.Fhir.Model.CodeableConcept, writer, "additiveCodeableConcept", cancellationToken); // 90
			Write(name.Additive as Hl7.Fhir.Model.ResourceReference, writer, "additiveReference", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent
		public static void Write(Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.IsDerivedElement, writer, "isDerived", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.PreferenceElement, writer, "preference", cancellationToken); // 60
			Write(name.Container, writer, "container", cancellationToken); // 70
			Write(name.RequirementElement, writer, "requirement", cancellationToken); // 80
			Write(name.RetentionTime, writer, "retentionTime", cancellationToken); // 90
			Write(name.RejectionCriterion, writer, "rejectionCriterion", cancellationToken); // 100
			Write(name.Handling, writer, "handling", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent
		public static void Write(Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Material, writer, "material", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Cap, writer, "cap", cancellationToken); // 60
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 70
			Write(name.Capacity, writer, "capacity", cancellationToken); // 80
			Write(name.MinimumVolume as Hl7.Fhir.Model.Quantity, writer, "minimumVolumeQuantity", cancellationToken); // 90
			Write(name.MinimumVolume as Hl7.Fhir.Model.FhirString, writer, "minimumVolumeString", cancellationToken); // 90
			Write(name.Additive, writer, "additive", cancellationToken); // 100
			Write(name.PreparationElement, writer, "preparation", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent
		public static void Write(Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Additive as Hl7.Fhir.Model.CodeableConcept, writer, "additiveCodeableConcept", cancellationToken); // 40
			Write(name.Additive as Hl7.Fhir.Model.ResourceReference, writer, "additiveReference", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent
		public static void Write(Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TemperatureQualifier, writer, "temperatureQualifier", cancellationToken); // 40
			Write(name.TemperatureRange, writer, "temperatureRange", cancellationToken); // 50
			Write(name.MaxDuration, writer, "maxDuration", cancellationToken); // 60
			Write(name.InstructionElement, writer, "instruction", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureDefinition.MappingComponent
		public static void Write(Hl7.Fhir.Model.StructureDefinition.MappingComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.IdentityElement, writer, "identity", cancellationToken); // 40
			Write(name.UriElement, writer, "uri", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.CommentElement, writer, "comment", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureDefinition.ContextComponent
		public static void Write(Hl7.Fhir.Model.StructureDefinition.ContextComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureDefinition.SnapshotComponent
		public static void Write(Hl7.Fhir.Model.StructureDefinition.SnapshotComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Element, writer, "element", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureDefinition.DifferentialComponent
		public static void Write(Hl7.Fhir.Model.StructureDefinition.DifferentialComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Element, writer, "element", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.StructureComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.StructureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UrlElement, writer, "url", cancellationToken); // 40
			Write(name.ModeElement, writer, "mode", cancellationToken); // 50
			Write(name.AliasElement, writer, "alias", cancellationToken); // 60
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.GroupComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.GroupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.ExtendsElement, writer, "extends", cancellationToken); // 50
			Write(name.TypeModeElement, writer, "typeMode", cancellationToken); // 60
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 70
			Write(name.Input, writer, "input", cancellationToken); // 80
			Write(name.Rule, writer, "rule", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.InputComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.InputComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.TypeElement, writer, "type", cancellationToken); // 50
			Write(name.ModeElement, writer, "mode", cancellationToken); // 60
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.RuleComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.RuleComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Source, writer, "source", cancellationToken); // 50
			Write(name.Target, writer, "target", cancellationToken); // 60
			Write(name.Rule, writer, "rule", cancellationToken); // 70
			Write(name.Dependent, writer, "dependent", cancellationToken); // 80
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.SourceComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.SourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ContextElement, writer, "context", cancellationToken); // 40
			Write(name.MinElement, writer, "min", cancellationToken); // 50
			Write(name.MaxElement, writer, "max", cancellationToken); // 60
			Write(name.TypeElement, writer, "type", cancellationToken); // 70
			Write(name.DefaultValue as Hl7.Fhir.Model.Base64Binary, writer, "defaultValueBase64Binary", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirBoolean, writer, "defaultValueBoolean", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Canonical, writer, "defaultValueCanonical", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Code, writer, "defaultValueCode", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Date, writer, "defaultValueDate", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirDateTime, writer, "defaultValueDateTime", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirDecimal, writer, "defaultValueDecimal", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Id, writer, "defaultValueId", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Instant, writer, "defaultValueInstant", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Integer, writer, "defaultValueInteger", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Markdown, writer, "defaultValueMarkdown", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Oid, writer, "defaultValueOid", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.PositiveInt, writer, "defaultValuePositiveInt", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirString, writer, "defaultValueString", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Time, writer, "defaultValueTime", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.UnsignedInt, writer, "defaultValueUnsignedInt", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirUri, writer, "defaultValueUri", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.FhirUrl, writer, "defaultValueUrl", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Uuid, writer, "defaultValueUuid", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Address, writer, "defaultValueAddress", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Age, writer, "defaultValueAge", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Annotation, writer, "defaultValueAnnotation", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Attachment, writer, "defaultValueAttachment", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.CodeableConcept, writer, "defaultValueCodeableConcept", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Coding, writer, "defaultValueCoding", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.ContactPoint, writer, "defaultValueContactPoint", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Count, writer, "defaultValueCount", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Distance, writer, "defaultValueDistance", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Duration, writer, "defaultValueDuration", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.HumanName, writer, "defaultValueHumanName", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Identifier, writer, "defaultValueIdentifier", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Money, writer, "defaultValueMoney", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Period, writer, "defaultValuePeriod", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Quantity, writer, "defaultValueQuantity", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Range, writer, "defaultValueRange", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Ratio, writer, "defaultValueRatio", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.ResourceReference, writer, "defaultValueReference", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.SampledData, writer, "defaultValueSampledData", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Signature, writer, "defaultValueSignature", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Timing, writer, "defaultValueTiming", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.ContactDetail, writer, "defaultValueContactDetail", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Contributor, writer, "defaultValueContributor", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.DataRequirement, writer, "defaultValueDataRequirement", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Expression, writer, "defaultValueExpression", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.ParameterDefinition, writer, "defaultValueParameterDefinition", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.RelatedArtifact, writer, "defaultValueRelatedArtifact", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.TriggerDefinition, writer, "defaultValueTriggerDefinition", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.UsageContext, writer, "defaultValueUsageContext", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Dosage, writer, "defaultValueDosage", cancellationToken); // 80
			Write(name.DefaultValue as Hl7.Fhir.Model.Meta, writer, "defaultValueMeta", cancellationToken); // 80
			Write(name.ElementElement, writer, "element", cancellationToken); // 90
			Write(name.ListModeElement, writer, "listMode", cancellationToken); // 100
			Write(name.VariableElement, writer, "variable", cancellationToken); // 110
			Write(name.ConditionElement, writer, "condition", cancellationToken); // 120
			Write(name.CheckElement, writer, "check", cancellationToken); // 130
			Write(name.LogMessageElement, writer, "logMessage", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.TargetComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.TargetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ContextElement, writer, "context", cancellationToken); // 40
			Write(name.ContextTypeElement, writer, "contextType", cancellationToken); // 50
			Write(name.ElementElement, writer, "element", cancellationToken); // 60
			Write(name.VariableElement, writer, "variable", cancellationToken); // 70
			Write(name.ListModeElement, writer, "listMode", cancellationToken); // 80
			Write(name.ListRuleIdElement, writer, "listRuleId", cancellationToken); // 90
			Write(name.TransformElement, writer, "transform", cancellationToken); // 100
			Write(name.Parameter, writer, "parameter", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.ParameterComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.StructureMap.DependentComponent
		public static void Write(Hl7.Fhir.Model.StructureMap.DependentComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.VariableElement, writer, "variable", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Subscription.ChannelComponent
		public static void Write(Hl7.Fhir.Model.Subscription.ChannelComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.EndpointElement, writer, "endpoint", cancellationToken); // 50
			Write(name.PayloadElement, writer, "payload", cancellationToken); // 60
			Write(name.HeaderElement, writer, "header", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Substance.InstanceComponent
		public static void Write(Hl7.Fhir.Model.Substance.InstanceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.ExpiryElement, writer, "expiry", cancellationToken); // 50
			Write(name.Quantity, writer, "quantity", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Substance.IngredientComponent
		public static void Write(Hl7.Fhir.Model.Substance.IngredientComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Quantity, writer, "quantity", cancellationToken); // 40
			Write(name.Substance as Hl7.Fhir.Model.CodeableConcept, writer, "substanceCodeableConcept", cancellationToken); // 50
			Write(name.Substance as Hl7.Fhir.Model.ResourceReference, writer, "substanceReference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceNucleicAcid.SubunitComponent
		public static void Write(Hl7.Fhir.Model.SubstanceNucleicAcid.SubunitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SubunitElement, writer, "subunit", cancellationToken); // 40
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 50
			Write(name.LengthElement, writer, "length", cancellationToken); // 60
			Write(name.SequenceAttachment, writer, "sequenceAttachment", cancellationToken); // 70
			Write(name.FivePrime, writer, "fivePrime", cancellationToken); // 80
			Write(name.ThreePrime, writer, "threePrime", cancellationToken); // 90
			Write(name.Linkage, writer, "linkage", cancellationToken); // 100
			Write(name.Sugar, writer, "sugar", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceNucleicAcid.LinkageComponent
		public static void Write(Hl7.Fhir.Model.SubstanceNucleicAcid.LinkageComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ConnectivityElement, writer, "connectivity", cancellationToken); // 40
			Write(name.Identifier, writer, "identifier", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.ResidueSiteElement, writer, "residueSite", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceNucleicAcid.SugarComponent
		public static void Write(Hl7.Fhir.Model.SubstanceNucleicAcid.SugarComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.NameElement, writer, "name", cancellationToken); // 50
			Write(name.ResidueSiteElement, writer, "residueSite", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstancePolymer.MonomerSetComponent
		public static void Write(Hl7.Fhir.Model.SubstancePolymer.MonomerSetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RatioType, writer, "ratioType", cancellationToken); // 40
			Write(name.StartingMaterial, writer, "startingMaterial", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstancePolymer.StartingMaterialComponent
		public static void Write(Hl7.Fhir.Model.SubstancePolymer.StartingMaterialComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Material, writer, "material", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.IsDefiningElement, writer, "isDefining", cancellationToken); // 60
			Write(name.Amount, writer, "amount", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstancePolymer.RepeatComponent
		public static void Write(Hl7.Fhir.Model.SubstancePolymer.RepeatComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NumberOfUnitsElement, writer, "numberOfUnits", cancellationToken); // 40
			Write(name.AverageMolecularFormulaElement, writer, "averageMolecularFormula", cancellationToken); // 50
			Write(name.RepeatUnitAmountType, writer, "repeatUnitAmountType", cancellationToken); // 60
			Write(name.RepeatUnit, writer, "repeatUnit", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent
		public static void Write(Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.OrientationOfPolymerisation, writer, "orientationOfPolymerisation", cancellationToken); // 40
			Write(name.RepeatUnitElement, writer, "repeatUnit", cancellationToken); // 50
			Write(name.Amount, writer, "amount", cancellationToken); // 60
			Write(name.DegreeOfPolymerisation, writer, "degreeOfPolymerisation", cancellationToken); // 70
			Write(name.StructuralRepresentation, writer, "structuralRepresentation", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent
		public static void Write(Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Degree, writer, "degree", cancellationToken); // 40
			Write(name.Amount, writer, "amount", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent
		public static void Write(Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.RepresentationElement, writer, "representation", cancellationToken); // 50
			Write(name.Attachment, writer, "attachment", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceProtein.SubunitComponent
		public static void Write(Hl7.Fhir.Model.SubstanceProtein.SubunitComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SubunitElement, writer, "subunit", cancellationToken); // 40
			Write(name.SequenceElement, writer, "sequence", cancellationToken); // 50
			Write(name.LengthElement, writer, "length", cancellationToken); // 60
			Write(name.SequenceAttachment, writer, "sequenceAttachment", cancellationToken); // 70
			Write(name.NTerminalModificationId, writer, "nTerminalModificationId", cancellationToken); // 80
			Write(name.NTerminalModificationElement, writer, "nTerminalModification", cancellationToken); // 90
			Write(name.CTerminalModificationId, writer, "cTerminalModificationId", cancellationToken); // 100
			Write(name.CTerminalModificationElement, writer, "cTerminalModification", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent
		public static void Write(Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.GeneSequenceOrigin, writer, "geneSequenceOrigin", cancellationToken); // 40
			Write(name.Gene, writer, "gene", cancellationToken); // 50
			Write(name.Source, writer, "source", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent
		public static void Write(Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Element, writer, "element", cancellationToken); // 50
			Write(name.Source, writer, "source", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent
		public static void Write(Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Domain, writer, "domain", cancellationToken); // 40
			Write(name.Classification, writer, "classification", cancellationToken); // 50
			Write(name.Subtype, writer, "subtype", cancellationToken); // 60
			Write(name.Source, writer, "source", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent
		public static void Write(Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Target, writer, "target", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Interaction, writer, "interaction", cancellationToken); // 60
			Write(name.Organism, writer, "organism", cancellationToken); // 70
			Write(name.OrganismType, writer, "organismType", cancellationToken); // 80
			Write(name.Amount as Hl7.Fhir.Model.Quantity, writer, "amountQuantity", cancellationToken); // 90
			Write(name.Amount as Hl7.Fhir.Model.Range, writer, "amountRange", cancellationToken); // 90
			Write(name.Amount as Hl7.Fhir.Model.FhirString, writer, "amountString", cancellationToken); // 90
			Write(name.AmountType, writer, "amountType", cancellationToken); // 100
			Write(name.Source, writer, "source", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.FractionElement, writer, "fraction", cancellationToken); // 40
			Write(name.MaterialType, writer, "materialType", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Family, writer, "family", cancellationToken); // 40
			Write(name.Genus, writer, "genus", cancellationToken); // 50
			Write(name.Species, writer, "species", cancellationToken); // 60
			Write(name.IntraspecificType, writer, "intraspecificType", cancellationToken); // 70
			Write(name.IntraspecificDescriptionElement, writer, "intraspecificDescription", cancellationToken); // 80
			Write(name.Author, writer, "author", cancellationToken); // 90
			Write(name.Hybrid, writer, "hybrid", cancellationToken); // 100
			Write(name.OrganismGeneral, writer, "organismGeneral", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.AuthorComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSourceMaterial.AuthorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.AuthorType, writer, "authorType", cancellationToken); // 40
			Write(name.AuthorDescriptionElement, writer, "authorDescription", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.MaternalOrganismIdElement, writer, "maternalOrganismId", cancellationToken); // 40
			Write(name.MaternalOrganismNameElement, writer, "maternalOrganismName", cancellationToken); // 50
			Write(name.PaternalOrganismIdElement, writer, "paternalOrganismId", cancellationToken); // 60
			Write(name.PaternalOrganismNameElement, writer, "paternalOrganismName", cancellationToken); // 70
			Write(name.HybridType, writer, "hybridType", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Kingdom, writer, "kingdom", cancellationToken); // 40
			Write(name.Phylum, writer, "phylum", cancellationToken); // 50
			Write(name.Class, writer, "class", cancellationToken); // 60
			Write(name.Order, writer, "order", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Part, writer, "part", cancellationToken); // 40
			Write(name.PartLocation, writer, "partLocation", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.MoietyComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.MoietyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Role, writer, "role", cancellationToken); // 40
			Write(name.Identifier, writer, "identifier", cancellationToken); // 50
			Write(name.NameElement, writer, "name", cancellationToken); // 60
			Write(name.Stereochemistry, writer, "stereochemistry", cancellationToken); // 70
			Write(name.OpticalActivity, writer, "opticalActivity", cancellationToken); // 80
			Write(name.MolecularFormulaElement, writer, "molecularFormula", cancellationToken); // 90
			Write(name.Amount as Hl7.Fhir.Model.Quantity, writer, "amountQuantity", cancellationToken); // 100
			Write(name.Amount as Hl7.Fhir.Model.FhirString, writer, "amountString", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Category, writer, "category", cancellationToken); // 40
			Write(name.Code, writer, "code", cancellationToken); // 50
			Write(name.ParametersElement, writer, "parameters", cancellationToken); // 60
			Write(name.DefiningSubstance as Hl7.Fhir.Model.ResourceReference, writer, "definingSubstanceReference", cancellationToken); // 70
			Write(name.DefiningSubstance as Hl7.Fhir.Model.CodeableConcept, writer, "definingSubstanceCodeableConcept", cancellationToken); // 70
			Write(name.Amount as Hl7.Fhir.Model.Quantity, writer, "amountQuantity", cancellationToken); // 80
			Write(name.Amount as Hl7.Fhir.Model.FhirString, writer, "amountString", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.StructureComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.StructureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Stereochemistry, writer, "stereochemistry", cancellationToken); // 40
			Write(name.OpticalActivity, writer, "opticalActivity", cancellationToken); // 50
			Write(name.MolecularFormulaElement, writer, "molecularFormula", cancellationToken); // 60
			Write(name.MolecularFormulaByMoietyElement, writer, "molecularFormulaByMoiety", cancellationToken); // 70
			Write(name.Isotope, writer, "isotope", cancellationToken); // 80
			Write(name.MolecularWeight, writer, "molecularWeight", cancellationToken); // 90
			Write(name.Source, writer, "source", cancellationToken); // 100
			Write(name.Representation, writer, "representation", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Identifier, writer, "identifier", cancellationToken); // 40
			Write(name.Name, writer, "name", cancellationToken); // 50
			Write(name.Substitution, writer, "substitution", cancellationToken); // 60
			Write(name.HalfLife, writer, "halfLife", cancellationToken); // 70
			Write(name.MolecularWeight, writer, "molecularWeight", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Method, writer, "method", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Amount, writer, "amount", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.RepresentationComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.RepresentationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.RepresentationElement, writer, "representation", cancellationToken); // 50
			Write(name.Attachment, writer, "attachment", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.CodeComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.CodeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Status, writer, "status", cancellationToken); // 50
			Write(name.StatusDateElement, writer, "statusDate", cancellationToken); // 60
			Write(name.CommentElement, writer, "comment", cancellationToken); // 70
			Write(name.Source, writer, "source", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.NameComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.NameComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.Status, writer, "status", cancellationToken); // 60
			Write(name.PreferredElement, writer, "preferred", cancellationToken); // 70
			Write(name.Language, writer, "language", cancellationToken); // 80
			Write(name.Domain, writer, "domain", cancellationToken); // 90
			Write(name.Jurisdiction, writer, "jurisdiction", cancellationToken); // 100
			Write(name.Synonym, writer, "synonym", cancellationToken); // 110
			Write(name.Translation, writer, "translation", cancellationToken); // 120
			Write(name.Official, writer, "official", cancellationToken); // 130
			Write(name.Source, writer, "source", cancellationToken); // 140
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.OfficialComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.OfficialComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Authority, writer, "authority", cancellationToken); // 40
			Write(name.Status, writer, "status", cancellationToken); // 50
			Write(name.DateElement, writer, "date", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SubstanceSpecification.RelationshipComponent
		public static void Write(Hl7.Fhir.Model.SubstanceSpecification.RelationshipComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Substance as Hl7.Fhir.Model.ResourceReference, writer, "substanceReference", cancellationToken); // 40
			Write(name.Substance as Hl7.Fhir.Model.CodeableConcept, writer, "substanceCodeableConcept", cancellationToken); // 40
			Write(name.Relationship, writer, "relationship", cancellationToken); // 50
			Write(name.IsDefiningElement, writer, "isDefining", cancellationToken); // 60
			Write(name.Amount as Hl7.Fhir.Model.Quantity, writer, "amountQuantity", cancellationToken); // 70
			Write(name.Amount as Hl7.Fhir.Model.Range, writer, "amountRange", cancellationToken); // 70
			Write(name.Amount as Hl7.Fhir.Model.Ratio, writer, "amountRatio", cancellationToken); // 70
			Write(name.Amount as Hl7.Fhir.Model.FhirString, writer, "amountString", cancellationToken); // 70
			Write(name.AmountRatioLowLimit, writer, "amountRatioLowLimit", cancellationToken); // 80
			Write(name.AmountType, writer, "amountType", cancellationToken); // 90
			Write(name.Source, writer, "source", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent
		public static void Write(Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Quantity, writer, "quantity", cancellationToken); // 40
			Write(name.Item as Hl7.Fhir.Model.CodeableConcept, writer, "itemCodeableConcept", cancellationToken); // 50
			Write(name.Item as Hl7.Fhir.Model.ResourceReference, writer, "itemReference", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SupplyRequest.ParameterComponent
		public static void Write(Hl7.Fhir.Model.SupplyRequest.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Code, writer, "code", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Task.RestrictionComponent
		public static void Write(Hl7.Fhir.Model.Task.RestrictionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RepetitionsElement, writer, "repetitions", cancellationToken); // 40
			Write(name.Period, writer, "period", cancellationToken); // 50
			Write(name.Recipient, writer, "recipient", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Task.ParameterComponent
		public static void Write(Hl7.Fhir.Model.Task.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Canonical, writer, "valueCanonical", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Instant, writer, "valueInstant", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Markdown, writer, "valueMarkdown", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Oid, writer, "valueOid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.PositiveInt, writer, "valuePositiveInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UnsignedInt, writer, "valueUnsignedInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUrl, writer, "valueUrl", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Uuid, writer, "valueUuid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Address, writer, "valueAddress", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Age, writer, "valueAge", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Annotation, writer, "valueAnnotation", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactPoint, writer, "valueContactPoint", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Count, writer, "valueCount", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Distance, writer, "valueDistance", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.HumanName, writer, "valueHumanName", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Identifier, writer, "valueIdentifier", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Signature, writer, "valueSignature", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Timing, writer, "valueTiming", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactDetail, writer, "valueContactDetail", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Contributor, writer, "valueContributor", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.DataRequirement, writer, "valueDataRequirement", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Expression, writer, "valueExpression", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ParameterDefinition, writer, "valueParameterDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.RelatedArtifact, writer, "valueRelatedArtifact", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.TriggerDefinition, writer, "valueTriggerDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UsageContext, writer, "valueUsageContext", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Dosage, writer, "valueDosage", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Meta, writer, "valueMeta", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.Task.OutputComponent
		public static void Write(Hl7.Fhir.Model.Task.OutputComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.Base64Binary, writer, "valueBase64Binary", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Canonical, writer, "valueCanonical", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Date, writer, "valueDate", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Id, writer, "valueId", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Instant, writer, "valueInstant", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Markdown, writer, "valueMarkdown", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Oid, writer, "valueOid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.PositiveInt, writer, "valuePositiveInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Time, writer, "valueTime", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UnsignedInt, writer, "valueUnsignedInt", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUrl, writer, "valueUrl", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Uuid, writer, "valueUuid", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Address, writer, "valueAddress", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Age, writer, "valueAge", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Annotation, writer, "valueAnnotation", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Attachment, writer, "valueAttachment", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.CodeableConcept, writer, "valueCodeableConcept", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Coding, writer, "valueCoding", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactPoint, writer, "valueContactPoint", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Count, writer, "valueCount", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Distance, writer, "valueDistance", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Duration, writer, "valueDuration", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.HumanName, writer, "valueHumanName", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Identifier, writer, "valueIdentifier", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Money, writer, "valueMoney", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Period, writer, "valuePeriod", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Quantity, writer, "valueQuantity", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Range, writer, "valueRange", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Ratio, writer, "valueRatio", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ResourceReference, writer, "valueReference", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.SampledData, writer, "valueSampledData", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Signature, writer, "valueSignature", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Timing, writer, "valueTiming", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ContactDetail, writer, "valueContactDetail", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Contributor, writer, "valueContributor", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.DataRequirement, writer, "valueDataRequirement", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Expression, writer, "valueExpression", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.ParameterDefinition, writer, "valueParameterDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.RelatedArtifact, writer, "valueRelatedArtifact", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.TriggerDefinition, writer, "valueTriggerDefinition", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.UsageContext, writer, "valueUsageContext", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Dosage, writer, "valueDosage", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Meta, writer, "valueMeta", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.SoftwareComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.SoftwareComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.VersionElement, writer, "version", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ImplementationComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.ImplementationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 40
			Write(name.UrlElement, writer, "url", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.CodeSystemComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.CodeSystemComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UriElement, writer, "uri", cancellationToken); // 40
			Write(name.Version, writer, "version", cancellationToken); // 50
			Write(name.SubsumptionElement, writer, "subsumption", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.VersionComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.VersionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.IsDefaultElement, writer, "isDefault", cancellationToken); // 50
			Write(name.CompositionalElement, writer, "compositional", cancellationToken); // 60
			Write(name.LanguageElement, writer, "language", cancellationToken); // 70
			Write(name.Filter, writer, "filter", cancellationToken); // 80
			Write(name.PropertyElement, writer, "property", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.FilterComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.FilterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.OpElement, writer, "op", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.HierarchicalElement, writer, "hierarchical", cancellationToken); // 40
			Write(name.PagingElement, writer, "paging", cancellationToken); // 50
			Write(name.IncompleteElement, writer, "incomplete", cancellationToken); // 60
			Write(name.Parameter, writer, "parameter", cancellationToken); // 70
			Write(name.TextFilter, writer, "textFilter", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ParameterComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DocumentationElement, writer, "documentation", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ValidateCodeComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.ValidateCodeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TranslationsElement, writer, "translations", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.TranslationComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.TranslationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NeedsMapElement, writer, "needsMap", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TerminologyCapabilities.ClosureComponent
		public static void Write(Hl7.Fhir.Model.TerminologyCapabilities.ClosureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TranslationElement, writer, "translation", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.ParticipantComponent
		public static void Write(Hl7.Fhir.Model.TestReport.ParticipantComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.TypeElement, writer, "type", cancellationToken); // 40
			Write(name.UriElement, writer, "uri", cancellationToken); // 50
			Write(name.DisplayElement, writer, "display", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.SetupComponent
		public static void Write(Hl7.Fhir.Model.TestReport.SetupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.SetupActionComponent
		public static void Write(Hl7.Fhir.Model.TestReport.SetupActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Operation, writer, "operation", cancellationToken); // 40
			Write(name.Assert, writer, "assert", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.OperationComponent
		public static void Write(Hl7.Fhir.Model.TestReport.OperationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ResultElement, writer, "result", cancellationToken); // 40
			Write(name.Message, writer, "message", cancellationToken); // 50
			Write(name.DetailElement, writer, "detail", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.AssertComponent
		public static void Write(Hl7.Fhir.Model.TestReport.AssertComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.ResultElement, writer, "result", cancellationToken); // 40
			Write(name.Message, writer, "message", cancellationToken); // 50
			Write(name.DetailElement, writer, "detail", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.TestComponent
		public static void Write(Hl7.Fhir.Model.TestReport.TestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Action, writer, "action", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.TestActionComponent
		public static void Write(Hl7.Fhir.Model.TestReport.TestActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Operation, writer, "operation", cancellationToken); // 40
			Write(name.Assert, writer, "assert", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.TeardownComponent
		public static void Write(Hl7.Fhir.Model.TestReport.TeardownComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestReport.TeardownActionComponent
		public static void Write(Hl7.Fhir.Model.TestReport.TeardownActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Operation, writer, "operation", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.OriginComponent
		public static void Write(Hl7.Fhir.Model.TestScript.OriginComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.IndexElement, writer, "index", cancellationToken); // 40
			Write(name.Profile, writer, "profile", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.DestinationComponent
		public static void Write(Hl7.Fhir.Model.TestScript.DestinationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.IndexElement, writer, "index", cancellationToken); // 40
			Write(name.Profile, writer, "profile", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.MetadataComponent
		public static void Write(Hl7.Fhir.Model.TestScript.MetadataComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Link, writer, "link", cancellationToken); // 40
			Write(name.Capability, writer, "capability", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.LinkComponent
		public static void Write(Hl7.Fhir.Model.TestScript.LinkComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.UrlElement, writer, "url", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.CapabilityComponent
		public static void Write(Hl7.Fhir.Model.TestScript.CapabilityComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.RequiredElement, writer, "required", cancellationToken); // 40
			Write(name.ValidatedElement, writer, "validated", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.OriginElement, writer, "origin", cancellationToken); // 70
			Write(name.DestinationElement, writer, "destination", cancellationToken); // 80
			Write(name.LinkElement, writer, "link", cancellationToken); // 90
			Write(name.CapabilitiesElement, writer, "capabilities", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.FixtureComponent
		public static void Write(Hl7.Fhir.Model.TestScript.FixtureComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.AutocreateElement, writer, "autocreate", cancellationToken); // 40
			Write(name.AutodeleteElement, writer, "autodelete", cancellationToken); // 50
			Write(name.Resource, writer, "resource", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.VariableComponent
		public static void Write(Hl7.Fhir.Model.TestScript.VariableComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DefaultValueElement, writer, "defaultValue", cancellationToken); // 50
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 60
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 70
			Write(name.HeaderFieldElement, writer, "headerField", cancellationToken); // 80
			Write(name.HintElement, writer, "hint", cancellationToken); // 90
			Write(name.PathElement, writer, "path", cancellationToken); // 100
			Write(name.SourceIdElement, writer, "sourceId", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.SetupComponent
		public static void Write(Hl7.Fhir.Model.TestScript.SetupComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.SetupActionComponent
		public static void Write(Hl7.Fhir.Model.TestScript.SetupActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Operation, writer, "operation", cancellationToken); // 40
			Write(name.Assert, writer, "assert", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.OperationComponent
		public static void Write(Hl7.Fhir.Model.TestScript.OperationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Type, writer, "type", cancellationToken); // 40
			Write(name.ResourceElement, writer, "resource", cancellationToken); // 50
			Write(name.LabelElement, writer, "label", cancellationToken); // 60
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 70
			Write(name.AcceptElement, writer, "accept", cancellationToken); // 80
			Write(name.ContentTypeElement, writer, "contentType", cancellationToken); // 90
			Write(name.DestinationElement, writer, "destination", cancellationToken); // 100
			Write(name.EncodeRequestUrlElement, writer, "encodeRequestUrl", cancellationToken); // 110
			Write(name.MethodElement, writer, "method", cancellationToken); // 120
			Write(name.OriginElement, writer, "origin", cancellationToken); // 130
			Write(name.ParamsElement, writer, "params", cancellationToken); // 140
			Write(name.RequestHeader, writer, "requestHeader", cancellationToken); // 150
			Write(name.RequestIdElement, writer, "requestId", cancellationToken); // 160
			Write(name.ResponseIdElement, writer, "responseId", cancellationToken); // 170
			Write(name.SourceIdElement, writer, "sourceId", cancellationToken); // 180
			Write(name.TargetIdElement, writer, "targetId", cancellationToken); // 190
			Write(name.UrlElement, writer, "url", cancellationToken); // 200
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.RequestHeaderComponent
		public static void Write(Hl7.Fhir.Model.TestScript.RequestHeaderComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.FieldElement, writer, "field", cancellationToken); // 40
			Write(name.ValueElement, writer, "value", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.AssertComponent
		public static void Write(Hl7.Fhir.Model.TestScript.AssertComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LabelElement, writer, "label", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.DirectionElement, writer, "direction", cancellationToken); // 60
			Write(name.CompareToSourceIdElement, writer, "compareToSourceId", cancellationToken); // 70
			Write(name.CompareToSourceExpressionElement, writer, "compareToSourceExpression", cancellationToken); // 80
			Write(name.CompareToSourcePathElement, writer, "compareToSourcePath", cancellationToken); // 90
			Write(name.ContentTypeElement, writer, "contentType", cancellationToken); // 100
			Write(name.ExpressionElement, writer, "expression", cancellationToken); // 110
			Write(name.HeaderFieldElement, writer, "headerField", cancellationToken); // 120
			Write(name.MinimumIdElement, writer, "minimumId", cancellationToken); // 130
			Write(name.NavigationLinksElement, writer, "navigationLinks", cancellationToken); // 140
			Write(name.OperatorElement, writer, "operator", cancellationToken); // 150
			Write(name.PathElement, writer, "path", cancellationToken); // 160
			Write(name.RequestMethodElement, writer, "requestMethod", cancellationToken); // 170
			Write(name.RequestURLElement, writer, "requestURL", cancellationToken); // 180
			Write(name.ResourceElement, writer, "resource", cancellationToken); // 190
			Write(name.ResponseElement, writer, "response", cancellationToken); // 200
			Write(name.ResponseCodeElement, writer, "responseCode", cancellationToken); // 210
			Write(name.SourceIdElement, writer, "sourceId", cancellationToken); // 220
			Write(name.ValidateProfileIdElement, writer, "validateProfileId", cancellationToken); // 230
			Write(name.ValueElement, writer, "value", cancellationToken); // 240
			Write(name.WarningOnlyElement, writer, "warningOnly", cancellationToken); // 250
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.TestComponent
		public static void Write(Hl7.Fhir.Model.TestScript.TestComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.DescriptionElement, writer, "description", cancellationToken); // 50
			Write(name.Action, writer, "action", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.TestActionComponent
		public static void Write(Hl7.Fhir.Model.TestScript.TestActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Operation, writer, "operation", cancellationToken); // 40
			Write(name.Assert, writer, "assert", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.TeardownComponent
		public static void Write(Hl7.Fhir.Model.TestScript.TeardownComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Action, writer, "action", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.TestScript.TeardownActionComponent
		public static void Write(Hl7.Fhir.Model.TestScript.TeardownActionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Operation, writer, "operation", cancellationToken); // 40
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ComposeComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.ComposeComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LockedDateElement, writer, "lockedDate", cancellationToken); // 40
			Write(name.InactiveElement, writer, "inactive", cancellationToken); // 50
			Write(name.Include, writer, "include", cancellationToken); // 60
			Write(name.Exclude, writer, "exclude", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ConceptSetComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.ConceptSetComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SystemElement, writer, "system", cancellationToken); // 40
			Write(name.VersionElement, writer, "version", cancellationToken); // 50
			Write(name.Concept, writer, "concept", cancellationToken); // 60
			Write(name.Filter, writer, "filter", cancellationToken); // 70
			Write(name.ValueSetElement, writer, "valueSet", cancellationToken); // 80
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ConceptReferenceComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.ConceptReferenceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.CodeElement, writer, "code", cancellationToken); // 40
			Write(name.DisplayElement, writer, "display", cancellationToken); // 50
			Write(name.Designation, writer, "designation", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.DesignationComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.DesignationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.LanguageElement, writer, "language", cancellationToken); // 40
			Write(name.Use, writer, "use", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.FilterComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.FilterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.PropertyElement, writer, "property", cancellationToken); // 40
			Write(name.OpElement, writer, "op", cancellationToken); // 50
			Write(name.ValueElement, writer, "value", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ExpansionComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.ExpansionComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.IdentifierElement, writer, "identifier", cancellationToken); // 40
			Write(name.TimestampElement, writer, "timestamp", cancellationToken); // 50
			Write(name.TotalElement, writer, "total", cancellationToken); // 60
			Write(name.OffsetElement, writer, "offset", cancellationToken); // 70
			Write(name.Parameter, writer, "parameter", cancellationToken); // 80
			Write(name.Contains, writer, "contains", cancellationToken); // 90
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ParameterComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.ParameterComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.NameElement, writer, "name", cancellationToken); // 40
			Write(name.Value as Hl7.Fhir.Model.FhirString, writer, "valueString", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirBoolean, writer, "valueBoolean", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Integer, writer, "valueInteger", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDecimal, writer, "valueDecimal", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirUri, writer, "valueUri", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.Code, writer, "valueCode", cancellationToken); // 50
			Write(name.Value as Hl7.Fhir.Model.FhirDateTime, writer, "valueDateTime", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.ValueSet.ContainsComponent
		public static void Write(Hl7.Fhir.Model.ValueSet.ContainsComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.SystemElement, writer, "system", cancellationToken); // 40
			Write(name.AbstractElement, writer, "abstract", cancellationToken); // 50
			Write(name.InactiveElement, writer, "inactive", cancellationToken); // 60
			Write(name.VersionElement, writer, "version", cancellationToken); // 70
			Write(name.CodeElement, writer, "code", cancellationToken); // 80
			Write(name.DisplayElement, writer, "display", cancellationToken); // 90
			Write(name.Designation, writer, "designation", cancellationToken); // 100
			Write(name.Contains, writer, "contains", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent
		public static void Write(Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Who, writer, "who", cancellationToken); // 40
			Write(name.Type, writer, "type", cancellationToken); // 50
			Write(name.CommunicationMethod, writer, "communicationMethod", cancellationToken); // 60
			Write(name.ValidationStatus, writer, "validationStatus", cancellationToken); // 70
			Write(name.ValidationDateElement, writer, "validationDate", cancellationToken); // 80
			Write(name.CanPushUpdates, writer, "canPushUpdates", cancellationToken); // 90
			Write(name.PushTypeAvailable, writer, "pushTypeAvailable", cancellationToken); // 100
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.VerificationResult.AttestationComponent
		public static void Write(Hl7.Fhir.Model.VerificationResult.AttestationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Who, writer, "who", cancellationToken); // 40
			Write(name.OnBehalfOf, writer, "onBehalfOf", cancellationToken); // 50
			Write(name.CommunicationMethod, writer, "communicationMethod", cancellationToken); // 60
			Write(name.DateElement, writer, "date", cancellationToken); // 70
			Write(name.SourceIdentityCertificateElement, writer, "sourceIdentityCertificate", cancellationToken); // 80
			Write(name.ProxyIdentityCertificateElement, writer, "proxyIdentityCertificate", cancellationToken); // 90
			Write(name.ProxySignature, writer, "proxySignature", cancellationToken); // 100
			Write(name.SourceSignature, writer, "sourceSignature", cancellationToken); // 110
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.VerificationResult.ValidatorComponent
		public static void Write(Hl7.Fhir.Model.VerificationResult.ValidatorComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Organization, writer, "organization", cancellationToken); // 40
			Write(name.IdentityCertificateElement, writer, "identityCertificate", cancellationToken); // 50
			Write(name.AttestationSignature, writer, "attestationSignature", cancellationToken); // 60
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent
		public static void Write(Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.Product, writer, "product", cancellationToken); // 40
			Write(name.EyeElement, writer, "eye", cancellationToken); // 50
			Write(name.SphereElement, writer, "sphere", cancellationToken); // 60
			Write(name.CylinderElement, writer, "cylinder", cancellationToken); // 70
			Write(name.AxisElement, writer, "axis", cancellationToken); // 80
			Write(name.Prism, writer, "prism", cancellationToken); // 90
			Write(name.AddElement, writer, "add", cancellationToken); // 100
			Write(name.PowerElement, writer, "power", cancellationToken); // 110
			Write(name.BackCurveElement, writer, "backCurve", cancellationToken); // 120
			Write(name.DiameterElement, writer, "diameter", cancellationToken); // 130
			Write(name.Duration, writer, "duration", cancellationToken); // 140
			Write(name.ColorElement, writer, "color", cancellationToken); // 150
			Write(name.BrandElement, writer, "brand", cancellationToken); // 160
			Write(name.Note, writer, "note", cancellationToken); // 170
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.VisionPrescription.PrismComponent
		public static void Write(Hl7.Fhir.Model.VisionPrescription.PrismComponent name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ModifierExtension, writer, "modifierExtension", cancellationToken); // 30
			Write(name.AmountElement, writer, "amount", cancellationToken); // 40
			Write(name.BaseElement, writer, "base", cancellationToken); // 50
			writer.WriteEndElement();
		}

		// Hl7.Fhir.Model.SimpleQuantity
		public static void Write(Hl7.Fhir.Model.SimpleQuantity name, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (name == null) return;
			writer.WriteStartElement(propertyName, XmlNs.FHIR);
			Write(name.ElementId, writer, "id", cancellationToken); // 10
			Write(name.Extension, writer, "extension", cancellationToken); // 20
			Write(name.ValueElement, writer, "value", cancellationToken); // 30
			Write(name.ComparatorElement, writer, "comparator", cancellationToken); // 40
			Write(name.UnitElement, writer, "unit", cancellationToken); // 50
			Write(name.SystemElement, writer, "system", cancellationToken); // 60
			Write(name.CodeElement, writer, "code", cancellationToken); // 70
			writer.WriteEndElement();
		}

		// ---------------------------
		public static void WriteBase(Base value, XmlWriter writer, string propertyName, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;
			if (value == null) return;
			if (value is Hl7.Fhir.Model.Resource && propertyName != "root")
				writer.WriteStartElement(propertyName, XmlNs.FHIR);

			switch (value)
			{
				case Hl7.Fhir.Model.Account account:
							Write(account, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ActivityDefinition activitydefinition:
							Write(activitydefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AdverseEvent adverseevent:
							Write(adverseevent, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AllergyIntolerance allergyintolerance:
							Write(allergyintolerance, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Appointment appointment:
							Write(appointment, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AppointmentResponse appointmentresponse:
							Write(appointmentresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent auditevent:
							Write(auditevent, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Basic basic:
							Write(basic, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Binary binary:
							Write(binary, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct biologicallyderivedproduct:
							Write(biologicallyderivedproduct, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.BodyStructure bodystructure:
							Write(bodystructure, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle bundle:
							Write(bundle, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement capabilitystatement:
							Write(capabilitystatement, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CarePlan careplan:
							Write(careplan, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CareTeam careteam:
							Write(careteam, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CatalogEntry catalogentry:
							Write(catalogentry, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItem chargeitem:
							Write(chargeitem, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItemDefinition chargeitemdefinition:
							Write(chargeitemdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim claim:
							Write(claim, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse claimresponse:
							Write(claimresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClinicalImpression clinicalimpression:
							Write(clinicalimpression, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem codesystem:
							Write(codesystem, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Communication communication:
							Write(communication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CommunicationRequest communicationrequest:
							Write(communicationrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CompartmentDefinition compartmentdefinition:
							Write(compartmentdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Composition composition:
							Write(composition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap conceptmap:
							Write(conceptmap, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Condition condition:
							Write(condition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent consent:
							Write(consent, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract contract:
							Write(contract, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coverage coverage:
							Write(coverage, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityRequest coverageeligibilityrequest:
							Write(coverageeligibilityrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityResponse coverageeligibilityresponse:
							Write(coverageeligibilityresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DetectedIssue detectedissue:
							Write(detectedissue, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device device:
							Write(device, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition devicedefinition:
							Write(devicedefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceMetric devicemetric:
							Write(devicemetric, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceRequest devicerequest:
							Write(devicerequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceUseStatement deviceusestatement:
							Write(deviceusestatement, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DiagnosticReport diagnosticreport:
							Write(diagnosticreport, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentManifest documentmanifest:
							Write(documentmanifest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentReference documentreference:
							Write(documentreference, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis effectevidencesynthesis:
							Write(effectevidencesynthesis, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter encounter:
							Write(encounter, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Endpoint endpoint:
							Write(endpoint, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EnrollmentRequest enrollmentrequest:
							Write(enrollmentrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EnrollmentResponse enrollmentresponse:
							Write(enrollmentresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EpisodeOfCare episodeofcare:
							Write(episodeofcare, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EventDefinition eventdefinition:
							Write(eventdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Evidence evidence:
							Write(evidence, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.EvidenceVariable evidencevariable:
							Write(evidencevariable, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario examplescenario:
							Write(examplescenario, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit explanationofbenefit:
							Write(explanationofbenefit, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.FamilyMemberHistory familymemberhistory:
							Write(familymemberhistory, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Flag flag:
							Write(flag, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Goal goal:
							Write(goal, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.GraphDefinition graphdefinition:
							Write(graphdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Group group:
							Write(group, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.GuidanceResponse guidanceresponse:
							Write(guidanceresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.HealthcareService healthcareservice:
							Write(healthcareservice, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImagingStudy imagingstudy:
							Write(imagingstudy, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Immunization immunization:
							Write(immunization, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImmunizationEvaluation immunizationevaluation:
							Write(immunizationevaluation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImmunizationRecommendation immunizationrecommendation:
							Write(immunizationrecommendation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide implementationguide:
							Write(implementationguide, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan insuranceplan:
							Write(insuranceplan, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Invoice invoice:
							Write(invoice, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Library library:
							Write(library, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Linkage linkage:
							Write(linkage, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.List list:
							Write(list, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Location location:
							Write(location, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure measure:
							Write(measure, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport measurereport:
							Write(measurereport, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Media media:
							Write(media, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Medication medication:
							Write(medication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationAdministration medicationadministration:
							Write(medicationadministration, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationDispense medicationdispense:
							Write(medicationdispense, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge medicationknowledge:
							Write(medicationknowledge, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest medicationrequest:
							Write(medicationrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationStatement medicationstatement:
							Write(medicationstatement, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct medicinalproduct:
							Write(medicinalproduct, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductAuthorization medicinalproductauthorization:
							Write(medicinalproductauthorization, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductContraindication medicinalproductcontraindication:
							Write(medicinalproductcontraindication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIndication medicinalproductindication:
							Write(medicinalproductindication, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient medicinalproductingredient:
							Write(medicinalproductingredient, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductInteraction medicinalproductinteraction:
							Write(medicinalproductinteraction, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductManufactured medicinalproductmanufactured:
							Write(medicinalproductmanufactured, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPackaged medicinalproductpackaged:
							Write(medicinalproductpackaged, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPharmaceutical medicinalproductpharmaceutical:
							Write(medicinalproductpharmaceutical, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductUndesirableEffect medicinalproductundesirableeffect:
							Write(medicinalproductundesirableeffect, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageDefinition messagedefinition:
							Write(messagedefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader messageheader:
							Write(messageheader, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence molecularsequence:
							Write(molecularsequence, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.NamingSystem namingsystem:
							Write(namingsystem, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder nutritionorder:
							Write(nutritionorder, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Observation observation:
							Write(observation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ObservationDefinition observationdefinition:
							Write(observationdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationDefinition operationdefinition:
							Write(operationdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationOutcome operationoutcome:
							Write(operationoutcome, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Organization organization:
							Write(organization, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.OrganizationAffiliation organizationaffiliation:
							Write(organizationaffiliation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Parameters parameters:
							Write(parameters, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Patient patient:
							Write(patient, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PaymentNotice paymentnotice:
							Write(paymentnotice, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PaymentReconciliation paymentreconciliation:
							Write(paymentreconciliation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Person person:
							Write(person, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition plandefinition:
							Write(plandefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Practitioner practitioner:
							Write(practitioner, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.PractitionerRole practitionerrole:
							Write(practitionerrole, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Procedure procedure:
							Write(procedure, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Provenance provenance:
							Write(provenance, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Questionnaire questionnaire:
							Write(questionnaire, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.QuestionnaireResponse questionnaireresponse:
							Write(questionnaireresponse, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RelatedPerson relatedperson:
							Write(relatedperson, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RequestGroup requestgroup:
							Write(requestgroup, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchDefinition researchdefinition:
							Write(researchdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchElementDefinition researchelementdefinition:
							Write(researchelementdefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchStudy researchstudy:
							Write(researchstudy, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchSubject researchsubject:
							Write(researchsubject, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskAssessment riskassessment:
							Write(riskassessment, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis riskevidencesynthesis:
							Write(riskevidencesynthesis, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Schedule schedule:
							Write(schedule, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SearchParameter searchparameter:
							Write(searchparameter, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ServiceRequest servicerequest:
							Write(servicerequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Slot slot:
							Write(slot, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Specimen specimen:
							Write(specimen, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SpecimenDefinition specimendefinition:
							Write(specimendefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition structuredefinition:
							Write(structuredefinition, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap structuremap:
							Write(structuremap, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Subscription subscription:
							Write(subscription, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Substance substance:
							Write(substance, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceNucleicAcid substancenucleicacid:
							Write(substancenucleicacid, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer substancepolymer:
							Write(substancepolymer, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceProtein substanceprotein:
							Write(substanceprotein, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceReferenceInformation substancereferenceinformation:
							Write(substancereferenceinformation, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial substancesourcematerial:
							Write(substancesourcematerial, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification substancespecification:
							Write(substancespecification, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyDelivery supplydelivery:
							Write(supplydelivery, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyRequest supplyrequest:
							Write(supplyrequest, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.Task task:
							Write(task, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities terminologycapabilities:
							Write(terminologycapabilities, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport testreport:
							Write(testreport, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript testscript:
							Write(testscript, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet valueset:
							Write(valueset, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.VerificationResult verificationresult:
							Write(verificationresult, writer, cancellationToken);
							break;
				case Hl7.Fhir.Model.VisionPrescription visionprescription:
							Write(visionprescription, writer, cancellationToken);
							break;
			// ---------------------------
				case Hl7.Fhir.Model.Address address:
							Write(address, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Annotation annotation:
							Write(annotation, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Attachment attachment:
							Write(attachment, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Base64Binary base64binary:
							Write(base64binary, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirBoolean fhirboolean:
							Write(fhirboolean, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Canonical canonical:
							Write(canonical, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code code:
							Write(code, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeableConcept codeableconcept:
							Write(codeableconcept, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coding coding:
							Write(coding, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ContactDetail contactdetail:
							Write(contactdetail, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ContactPoint contactpoint:
							Write(contactpoint, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contributor contributor:
							Write(contributor, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DataRequirement datarequirement:
							Write(datarequirement, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DataRequirement.CodeFilterComponent datarequirement_codefiltercomponent:
							Write(datarequirement_codefiltercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DataRequirement.DateFilterComponent datarequirement_datefiltercomponent:
							Write(datarequirement_datefiltercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DataRequirement.SortComponent datarequirement_sortcomponent:
							Write(datarequirement_sortcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Date date:
							Write(date, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirDateTime fhirdatetime:
							Write(fhirdatetime, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirDecimal fhirdecimal:
							Write(fhirdecimal, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Dosage dosage:
							Write(dosage, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Dosage.DoseAndRateComponent dosage_doseandratecomponent:
							Write(dosage_doseandratecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition elementdefinition:
							Write(elementdefinition, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.DiscriminatorComponent elementdefinition_discriminatorcomponent:
							Write(elementdefinition_discriminatorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.TypeRefComponent elementdefinition_typerefcomponent:
							Write(elementdefinition_typerefcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.SlicingComponent elementdefinition_slicingcomponent:
							Write(elementdefinition_slicingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.BaseComponent elementdefinition_basecomponent:
							Write(elementdefinition_basecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.ExampleComponent elementdefinition_examplecomponent:
							Write(elementdefinition_examplecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.ConstraintComponent elementdefinition_constraintcomponent:
							Write(elementdefinition_constraintcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent elementdefinition_elementdefinitionbindingcomponent:
							Write(elementdefinition_elementdefinitionbindingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ElementDefinition.MappingComponent elementdefinition_mappingcomponent:
							Write(elementdefinition_mappingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Expression expression:
							Write(expression, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Extension extension:
							Write(extension, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.HumanName humanname:
							Write(humanname, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Id id:
							Write(id, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Identifier identifier:
							Write(identifier, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Instant instant:
							Write(instant, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Integer integer:
							Write(integer, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Markdown markdown:
							Write(markdown, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MarketingStatus marketingstatus:
							Write(marketingstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Meta meta:
							Write(meta, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Money money:
							Write(money, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Narrative narrative:
							Write(narrative, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Oid oid:
							Write(oid, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ParameterDefinition parameterdefinition:
							Write(parameterdefinition, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Period period:
							Write(period, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Population population:
							Write(population, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PositiveInt positiveint:
							Write(positiveint, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ProdCharacteristic prodcharacteristic:
							Write(prodcharacteristic, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ProductShelfLife productshelflife:
							Write(productshelflife, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Quantity quantity:
							Write(quantity, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Range range:
							Write(range, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Ratio ratio:
							Write(ratio, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResourceReference resourcereference:
							Write(resourcereference, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RelatedArtifact relatedartifact:
							Write(relatedartifact, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SampledData sampleddata:
							Write(sampleddata, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Signature signature:
							Write(signature, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirString fhirstring:
							Write(fhirstring, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceAmount substanceamount:
							Write(substanceamount, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent substanceamount_referencerangecomponent:
							Write(substanceamount_referencerangecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Time time:
							Write(time, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Timing timing:
							Write(timing, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Timing.RepeatComponent timing_repeatcomponent:
							Write(timing_repeatcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TriggerDefinition triggerdefinition:
							Write(triggerdefinition, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.UnsignedInt unsignedint:
							Write(unsignedint, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirUri fhiruri:
							Write(fhiruri, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FhirUrl fhirurl:
							Write(fhirurl, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.UsageContext usagecontext:
							Write(usagecontext, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Uuid uuid:
							Write(uuid, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.XHtml xhtml:
							Write(xhtml, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Account.CoverageComponent account_coveragecomponent:
							Write(account_coveragecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Account.GuarantorComponent account_guarantorcomponent:
							Write(account_guarantorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ActivityDefinition.ParticipantComponent activitydefinition_participantcomponent:
							Write(activitydefinition_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ActivityDefinition.DynamicValueComponent activitydefinition_dynamicvaluecomponent:
							Write(activitydefinition_dynamicvaluecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent adverseevent_suspectentitycomponent:
							Write(adverseevent_suspectentitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AdverseEvent.CausalityComponent adverseevent_causalitycomponent:
							Write(adverseevent_causalitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent allergyintolerance_reactioncomponent:
							Write(allergyintolerance_reactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Appointment.ParticipantComponent appointment_participantcomponent:
							Write(appointment_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent.AgentComponent auditevent_agentcomponent:
							Write(auditevent_agentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent.NetworkComponent auditevent_networkcomponent:
							Write(auditevent_networkcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent.SourceComponent auditevent_sourcecomponent:
							Write(auditevent_sourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent.EntityComponent auditevent_entitycomponent:
							Write(auditevent_entitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.AuditEvent.DetailComponent auditevent_detailcomponent:
							Write(auditevent_detailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent biologicallyderivedproduct_collectioncomponent:
							Write(biologicallyderivedproduct_collectioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent biologicallyderivedproduct_processingcomponent:
							Write(biologicallyderivedproduct_processingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent biologicallyderivedproduct_manipulationcomponent:
							Write(biologicallyderivedproduct_manipulationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent biologicallyderivedproduct_storagecomponent:
							Write(biologicallyderivedproduct_storagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle.EntryComponent bundle_entrycomponent:
							Write(bundle_entrycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle.LinkComponent bundle_linkcomponent:
							Write(bundle_linkcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle.SearchComponent bundle_searchcomponent:
							Write(bundle_searchcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle.RequestComponent bundle_requestcomponent:
							Write(bundle_requestcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Bundle.ResponseComponent bundle_responsecomponent:
							Write(bundle_responsecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.SoftwareComponent capabilitystatement_softwarecomponent:
							Write(capabilitystatement_softwarecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.ImplementationComponent capabilitystatement_implementationcomponent:
							Write(capabilitystatement_implementationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.RestComponent capabilitystatement_restcomponent:
							Write(capabilitystatement_restcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.SecurityComponent capabilitystatement_securitycomponent:
							Write(capabilitystatement_securitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.ResourceComponent capabilitystatement_resourcecomponent:
							Write(capabilitystatement_resourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.ResourceInteractionComponent capabilitystatement_resourceinteractioncomponent:
							Write(capabilitystatement_resourceinteractioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.SearchParamComponent capabilitystatement_searchparamcomponent:
							Write(capabilitystatement_searchparamcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.OperationComponent capabilitystatement_operationcomponent:
							Write(capabilitystatement_operationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.SystemInteractionComponent capabilitystatement_systeminteractioncomponent:
							Write(capabilitystatement_systeminteractioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.MessagingComponent capabilitystatement_messagingcomponent:
							Write(capabilitystatement_messagingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.EndpointComponent capabilitystatement_endpointcomponent:
							Write(capabilitystatement_endpointcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.SupportedMessageComponent capabilitystatement_supportedmessagecomponent:
							Write(capabilitystatement_supportedmessagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CapabilityStatement.DocumentComponent capabilitystatement_documentcomponent:
							Write(capabilitystatement_documentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CarePlan.ActivityComponent careplan_activitycomponent:
							Write(careplan_activitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CarePlan.DetailComponent careplan_detailcomponent:
							Write(careplan_detailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CareTeam.ParticipantComponent careteam_participantcomponent:
							Write(careteam_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CatalogEntry.RelatedEntryComponent catalogentry_relatedentrycomponent:
							Write(catalogentry_relatedentrycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItem.PerformerComponent chargeitem_performercomponent:
							Write(chargeitem_performercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent chargeitemdefinition_applicabilitycomponent:
							Write(chargeitemdefinition_applicabilitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItemDefinition.PropertyGroupComponent chargeitemdefinition_propertygroupcomponent:
							Write(chargeitemdefinition_propertygroupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ChargeItemDefinition.PriceComponentComponent chargeitemdefinition_pricecomponentcomponent:
							Write(chargeitemdefinition_pricecomponentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.RelatedClaimComponent claim_relatedclaimcomponent:
							Write(claim_relatedclaimcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.PayeeComponent claim_payeecomponent:
							Write(claim_payeecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.CareTeamComponent claim_careteamcomponent:
							Write(claim_careteamcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.SupportingInformationComponent claim_supportinginformationcomponent:
							Write(claim_supportinginformationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.DiagnosisComponent claim_diagnosiscomponent:
							Write(claim_diagnosiscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.ProcedureComponent claim_procedurecomponent:
							Write(claim_procedurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.InsuranceComponent claim_insurancecomponent:
							Write(claim_insurancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.AccidentComponent claim_accidentcomponent:
							Write(claim_accidentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.ItemComponent claim_itemcomponent:
							Write(claim_itemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.DetailComponent claim_detailcomponent:
							Write(claim_detailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Claim.SubDetailComponent claim_subdetailcomponent:
							Write(claim_subdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.ItemComponent claimresponse_itemcomponent:
							Write(claimresponse_itemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.AdjudicationComponent claimresponse_adjudicationcomponent:
							Write(claimresponse_adjudicationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.ItemDetailComponent claimresponse_itemdetailcomponent:
							Write(claimresponse_itemdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.SubDetailComponent claimresponse_subdetailcomponent:
							Write(claimresponse_subdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.AddedItemComponent claimresponse_addeditemcomponent:
							Write(claimresponse_addeditemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.AddedItemDetailComponent claimresponse_addeditemdetailcomponent:
							Write(claimresponse_addeditemdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.AddedItemSubDetailComponent claimresponse_addeditemsubdetailcomponent:
							Write(claimresponse_addeditemsubdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.TotalComponent claimresponse_totalcomponent:
							Write(claimresponse_totalcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.PaymentComponent claimresponse_paymentcomponent:
							Write(claimresponse_paymentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.NoteComponent claimresponse_notecomponent:
							Write(claimresponse_notecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.InsuranceComponent claimresponse_insurancecomponent:
							Write(claimresponse_insurancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClaimResponse.ErrorComponent claimresponse_errorcomponent:
							Write(claimresponse_errorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClinicalImpression.InvestigationComponent clinicalimpression_investigationcomponent:
							Write(clinicalimpression_investigationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ClinicalImpression.FindingComponent clinicalimpression_findingcomponent:
							Write(clinicalimpression_findingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem.FilterComponent codesystem_filtercomponent:
							Write(codesystem_filtercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem.PropertyComponent codesystem_propertycomponent:
							Write(codesystem_propertycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem.ConceptDefinitionComponent codesystem_conceptdefinitioncomponent:
							Write(codesystem_conceptdefinitioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem.DesignationComponent codesystem_designationcomponent:
							Write(codesystem_designationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CodeSystem.ConceptPropertyComponent codesystem_conceptpropertycomponent:
							Write(codesystem_conceptpropertycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Communication.PayloadComponent communication_payloadcomponent:
							Write(communication_payloadcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CommunicationRequest.PayloadComponent communicationrequest_payloadcomponent:
							Write(communicationrequest_payloadcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CompartmentDefinition.ResourceComponent compartmentdefinition_resourcecomponent:
							Write(compartmentdefinition_resourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Composition.AttesterComponent composition_attestercomponent:
							Write(composition_attestercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Composition.RelatesToComponent composition_relatestocomponent:
							Write(composition_relatestocomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Composition.EventComponent composition_eventcomponent:
							Write(composition_eventcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Composition.SectionComponent composition_sectioncomponent:
							Write(composition_sectioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap.GroupComponent conceptmap_groupcomponent:
							Write(conceptmap_groupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap.SourceElementComponent conceptmap_sourceelementcomponent:
							Write(conceptmap_sourceelementcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap.TargetElementComponent conceptmap_targetelementcomponent:
							Write(conceptmap_targetelementcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap.OtherElementComponent conceptmap_otherelementcomponent:
							Write(conceptmap_otherelementcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ConceptMap.UnmappedComponent conceptmap_unmappedcomponent:
							Write(conceptmap_unmappedcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Condition.StageComponent condition_stagecomponent:
							Write(condition_stagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Condition.EvidenceComponent condition_evidencecomponent:
							Write(condition_evidencecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent.PolicyComponent consent_policycomponent:
							Write(consent_policycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent.VerificationComponent consent_verificationcomponent:
							Write(consent_verificationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent.provisionComponent consent_provisioncomponent:
							Write(consent_provisioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent.provisionActorComponent consent_provisionactorcomponent:
							Write(consent_provisionactorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Consent.provisionDataComponent consent_provisiondatacomponent:
							Write(consent_provisiondatacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ContentDefinitionComponent contract_contentdefinitioncomponent:
							Write(contract_contentdefinitioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.TermComponent contract_termcomponent:
							Write(contract_termcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.SecurityLabelComponent contract_securitylabelcomponent:
							Write(contract_securitylabelcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ContractOfferComponent contract_contractoffercomponent:
							Write(contract_contractoffercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ContractPartyComponent contract_contractpartycomponent:
							Write(contract_contractpartycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.AnswerComponent contract_answercomponent:
							Write(contract_answercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ContractAssetComponent contract_contractassetcomponent:
							Write(contract_contractassetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.AssetContextComponent contract_assetcontextcomponent:
							Write(contract_assetcontextcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ValuedItemComponent contract_valueditemcomponent:
							Write(contract_valueditemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ActionComponent contract_actioncomponent:
							Write(contract_actioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ActionSubjectComponent contract_actionsubjectcomponent:
							Write(contract_actionsubjectcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.SignatoryComponent contract_signatorycomponent:
							Write(contract_signatorycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.FriendlyLanguageComponent contract_friendlylanguagecomponent:
							Write(contract_friendlylanguagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.LegalLanguageComponent contract_legallanguagecomponent:
							Write(contract_legallanguagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Contract.ComputableLanguageComponent contract_computablelanguagecomponent:
							Write(contract_computablelanguagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coverage.ClassComponent coverage_classcomponent:
							Write(coverage_classcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coverage.CostToBeneficiaryComponent coverage_costtobeneficiarycomponent:
							Write(coverage_costtobeneficiarycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Coverage.ExemptionComponent coverage_exemptioncomponent:
							Write(coverage_exemptioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityRequest.SupportingInformationComponent coverageeligibilityrequest_supportinginformationcomponent:
							Write(coverageeligibilityrequest_supportinginformationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityRequest.InsuranceComponent coverageeligibilityrequest_insurancecomponent:
							Write(coverageeligibilityrequest_insurancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityRequest.DetailsComponent coverageeligibilityrequest_detailscomponent:
							Write(coverageeligibilityrequest_detailscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityRequest.DiagnosisComponent coverageeligibilityrequest_diagnosiscomponent:
							Write(coverageeligibilityrequest_diagnosiscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent coverageeligibilityresponse_insurancecomponent:
							Write(coverageeligibilityresponse_insurancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent coverageeligibilityresponse_itemscomponent:
							Write(coverageeligibilityresponse_itemscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent coverageeligibilityresponse_benefitcomponent:
							Write(coverageeligibilityresponse_benefitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent coverageeligibilityresponse_errorscomponent:
							Write(coverageeligibilityresponse_errorscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DetectedIssue.EvidenceComponent detectedissue_evidencecomponent:
							Write(detectedissue_evidencecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DetectedIssue.MitigationComponent detectedissue_mitigationcomponent:
							Write(detectedissue_mitigationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device.UdiCarrierComponent device_udicarriercomponent:
							Write(device_udicarriercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device.DeviceNameComponent device_devicenamecomponent:
							Write(device_devicenamecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device.SpecializationComponent device_specializationcomponent:
							Write(device_specializationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device.VersionComponent device_versioncomponent:
							Write(device_versioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Device.PropertyComponent device_propertycomponent:
							Write(device_propertycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition.UdiDeviceIdentifierComponent devicedefinition_udideviceidentifiercomponent:
							Write(devicedefinition_udideviceidentifiercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition.DeviceNameComponent devicedefinition_devicenamecomponent:
							Write(devicedefinition_devicenamecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition.SpecializationComponent devicedefinition_specializationcomponent:
							Write(devicedefinition_specializationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition.CapabilityComponent devicedefinition_capabilitycomponent:
							Write(devicedefinition_capabilitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition.PropertyComponent devicedefinition_propertycomponent:
							Write(devicedefinition_propertycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceDefinition.MaterialComponent devicedefinition_materialcomponent:
							Write(devicedefinition_materialcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceMetric.CalibrationComponent devicemetric_calibrationcomponent:
							Write(devicemetric_calibrationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DeviceRequest.ParameterComponent devicerequest_parametercomponent:
							Write(devicerequest_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DiagnosticReport.MediaComponent diagnosticreport_mediacomponent:
							Write(diagnosticreport_mediacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentManifest.RelatedComponent documentmanifest_relatedcomponent:
							Write(documentmanifest_relatedcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentReference.RelatesToComponent documentreference_relatestocomponent:
							Write(documentreference_relatestocomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentReference.ContentComponent documentreference_contentcomponent:
							Write(documentreference_contentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.DocumentReference.ContextComponent documentreference_contextcomponent:
							Write(documentreference_contextcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.SampleSizeComponent effectevidencesynthesis_samplesizecomponent:
							Write(effectevidencesynthesis_samplesizecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.ResultsByExposureComponent effectevidencesynthesis_resultsbyexposurecomponent:
							Write(effectevidencesynthesis_resultsbyexposurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.EffectEstimateComponent effectevidencesynthesis_effectestimatecomponent:
							Write(effectevidencesynthesis_effectestimatecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.PrecisionEstimateComponent effectevidencesynthesis_precisionestimatecomponent:
							Write(effectevidencesynthesis_precisionestimatecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.CertaintyComponent effectevidencesynthesis_certaintycomponent:
							Write(effectevidencesynthesis_certaintycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EffectEvidenceSynthesis.CertaintySubcomponentComponent effectevidencesynthesis_certaintysubcomponentcomponent:
							Write(effectevidencesynthesis_certaintysubcomponentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.StatusHistoryComponent encounter_statushistorycomponent:
							Write(encounter_statushistorycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.ClassHistoryComponent encounter_classhistorycomponent:
							Write(encounter_classhistorycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.ParticipantComponent encounter_participantcomponent:
							Write(encounter_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.DiagnosisComponent encounter_diagnosiscomponent:
							Write(encounter_diagnosiscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.HospitalizationComponent encounter_hospitalizationcomponent:
							Write(encounter_hospitalizationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Encounter.LocationComponent encounter_locationcomponent:
							Write(encounter_locationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EpisodeOfCare.StatusHistoryComponent episodeofcare_statushistorycomponent:
							Write(episodeofcare_statushistorycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EpisodeOfCare.DiagnosisComponent episodeofcare_diagnosiscomponent:
							Write(episodeofcare_diagnosiscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.EvidenceVariable.CharacteristicComponent evidencevariable_characteristiccomponent:
							Write(evidencevariable_characteristiccomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.ActorComponent examplescenario_actorcomponent:
							Write(examplescenario_actorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.InstanceComponent examplescenario_instancecomponent:
							Write(examplescenario_instancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.VersionComponent examplescenario_versioncomponent:
							Write(examplescenario_versioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.ContainedInstanceComponent examplescenario_containedinstancecomponent:
							Write(examplescenario_containedinstancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.ProcessComponent examplescenario_processcomponent:
							Write(examplescenario_processcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.StepComponent examplescenario_stepcomponent:
							Write(examplescenario_stepcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.OperationComponent examplescenario_operationcomponent:
							Write(examplescenario_operationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExampleScenario.AlternativeComponent examplescenario_alternativecomponent:
							Write(examplescenario_alternativecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.RelatedClaimComponent explanationofbenefit_relatedclaimcomponent:
							Write(explanationofbenefit_relatedclaimcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.PayeeComponent explanationofbenefit_payeecomponent:
							Write(explanationofbenefit_payeecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.CareTeamComponent explanationofbenefit_careteamcomponent:
							Write(explanationofbenefit_careteamcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.SupportingInformationComponent explanationofbenefit_supportinginformationcomponent:
							Write(explanationofbenefit_supportinginformationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.DiagnosisComponent explanationofbenefit_diagnosiscomponent:
							Write(explanationofbenefit_diagnosiscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent explanationofbenefit_procedurecomponent:
							Write(explanationofbenefit_procedurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.InsuranceComponent explanationofbenefit_insurancecomponent:
							Write(explanationofbenefit_insurancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.AccidentComponent explanationofbenefit_accidentcomponent:
							Write(explanationofbenefit_accidentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.ItemComponent explanationofbenefit_itemcomponent:
							Write(explanationofbenefit_itemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.AdjudicationComponent explanationofbenefit_adjudicationcomponent:
							Write(explanationofbenefit_adjudicationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.DetailComponent explanationofbenefit_detailcomponent:
							Write(explanationofbenefit_detailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.SubDetailComponent explanationofbenefit_subdetailcomponent:
							Write(explanationofbenefit_subdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemComponent explanationofbenefit_addeditemcomponent:
							Write(explanationofbenefit_addeditemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailComponent explanationofbenefit_addeditemdetailcomponent:
							Write(explanationofbenefit_addeditemdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.AddedItemDetailSubDetailComponent explanationofbenefit_addeditemdetailsubdetailcomponent:
							Write(explanationofbenefit_addeditemdetailsubdetailcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.TotalComponent explanationofbenefit_totalcomponent:
							Write(explanationofbenefit_totalcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.PaymentComponent explanationofbenefit_paymentcomponent:
							Write(explanationofbenefit_paymentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.NoteComponent explanationofbenefit_notecomponent:
							Write(explanationofbenefit_notecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.BenefitBalanceComponent explanationofbenefit_benefitbalancecomponent:
							Write(explanationofbenefit_benefitbalancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ExplanationOfBenefit.BenefitComponent explanationofbenefit_benefitcomponent:
							Write(explanationofbenefit_benefitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.FamilyMemberHistory.ConditionComponent familymemberhistory_conditioncomponent:
							Write(familymemberhistory_conditioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Goal.TargetComponent goal_targetcomponent:
							Write(goal_targetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.GraphDefinition.LinkComponent graphdefinition_linkcomponent:
							Write(graphdefinition_linkcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.GraphDefinition.TargetComponent graphdefinition_targetcomponent:
							Write(graphdefinition_targetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.GraphDefinition.CompartmentComponent graphdefinition_compartmentcomponent:
							Write(graphdefinition_compartmentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Group.CharacteristicComponent group_characteristiccomponent:
							Write(group_characteristiccomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Group.MemberComponent group_membercomponent:
							Write(group_membercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.HealthcareService.EligibilityComponent healthcareservice_eligibilitycomponent:
							Write(healthcareservice_eligibilitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.HealthcareService.AvailableTimeComponent healthcareservice_availabletimecomponent:
							Write(healthcareservice_availabletimecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.HealthcareService.NotAvailableComponent healthcareservice_notavailablecomponent:
							Write(healthcareservice_notavailablecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImagingStudy.SeriesComponent imagingstudy_seriescomponent:
							Write(imagingstudy_seriescomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImagingStudy.PerformerComponent imagingstudy_performercomponent:
							Write(imagingstudy_performercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImagingStudy.InstanceComponent imagingstudy_instancecomponent:
							Write(imagingstudy_instancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Immunization.PerformerComponent immunization_performercomponent:
							Write(immunization_performercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Immunization.EducationComponent immunization_educationcomponent:
							Write(immunization_educationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Immunization.ReactionComponent immunization_reactioncomponent:
							Write(immunization_reactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Immunization.ProtocolAppliedComponent immunization_protocolappliedcomponent:
							Write(immunization_protocolappliedcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent immunizationrecommendation_recommendationcomponent:
							Write(immunizationrecommendation_recommendationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent immunizationrecommendation_datecriterioncomponent:
							Write(immunizationrecommendation_datecriterioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.DependsOnComponent implementationguide_dependsoncomponent:
							Write(implementationguide_dependsoncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.GlobalComponent implementationguide_globalcomponent:
							Write(implementationguide_globalcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.DefinitionComponent implementationguide_definitioncomponent:
							Write(implementationguide_definitioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.GroupingComponent implementationguide_groupingcomponent:
							Write(implementationguide_groupingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.ResourceComponent implementationguide_resourcecomponent:
							Write(implementationguide_resourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.PageComponent implementationguide_pagecomponent:
							Write(implementationguide_pagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.ParameterComponent implementationguide_parametercomponent:
							Write(implementationguide_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.TemplateComponent implementationguide_templatecomponent:
							Write(implementationguide_templatecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.ManifestComponent implementationguide_manifestcomponent:
							Write(implementationguide_manifestcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.ManifestResourceComponent implementationguide_manifestresourcecomponent:
							Write(implementationguide_manifestresourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ImplementationGuide.ManifestPageComponent implementationguide_manifestpagecomponent:
							Write(implementationguide_manifestpagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.ContactComponent insuranceplan_contactcomponent:
							Write(insuranceplan_contactcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.CoverageComponent insuranceplan_coveragecomponent:
							Write(insuranceplan_coveragecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.CoverageBenefitComponent insuranceplan_coveragebenefitcomponent:
							Write(insuranceplan_coveragebenefitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.LimitComponent insuranceplan_limitcomponent:
							Write(insuranceplan_limitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.PlanComponent insuranceplan_plancomponent:
							Write(insuranceplan_plancomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.GeneralCostComponent insuranceplan_generalcostcomponent:
							Write(insuranceplan_generalcostcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.SpecificCostComponent insuranceplan_specificcostcomponent:
							Write(insuranceplan_specificcostcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.PlanBenefitComponent insuranceplan_planbenefitcomponent:
							Write(insuranceplan_planbenefitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.InsurancePlan.CostComponent insuranceplan_costcomponent:
							Write(insuranceplan_costcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Invoice.ParticipantComponent invoice_participantcomponent:
							Write(invoice_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Invoice.LineItemComponent invoice_lineitemcomponent:
							Write(invoice_lineitemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Invoice.PriceComponentComponent invoice_pricecomponentcomponent:
							Write(invoice_pricecomponentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Linkage.ItemComponent linkage_itemcomponent:
							Write(linkage_itemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.List.EntryComponent list_entrycomponent:
							Write(list_entrycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Location.PositionComponent location_positioncomponent:
							Write(location_positioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Location.HoursOfOperationComponent location_hoursofoperationcomponent:
							Write(location_hoursofoperationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure.GroupComponent measure_groupcomponent:
							Write(measure_groupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure.PopulationComponent measure_populationcomponent:
							Write(measure_populationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure.StratifierComponent measure_stratifiercomponent:
							Write(measure_stratifiercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure.ComponentComponent measure_componentcomponent:
							Write(measure_componentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Measure.SupplementalDataComponent measure_supplementaldatacomponent:
							Write(measure_supplementaldatacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport.GroupComponent measurereport_groupcomponent:
							Write(measurereport_groupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport.PopulationComponent measurereport_populationcomponent:
							Write(measurereport_populationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport.StratifierComponent measurereport_stratifiercomponent:
							Write(measurereport_stratifiercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport.StratifierGroupComponent measurereport_stratifiergroupcomponent:
							Write(measurereport_stratifiergroupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport.ComponentComponent measurereport_componentcomponent:
							Write(measurereport_componentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MeasureReport.StratifierGroupPopulationComponent measurereport_stratifiergrouppopulationcomponent:
							Write(measurereport_stratifiergrouppopulationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Medication.IngredientComponent medication_ingredientcomponent:
							Write(medication_ingredientcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Medication.BatchComponent medication_batchcomponent:
							Write(medication_batchcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationAdministration.PerformerComponent medicationadministration_performercomponent:
							Write(medicationadministration_performercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationAdministration.DosageComponent medicationadministration_dosagecomponent:
							Write(medicationadministration_dosagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationDispense.PerformerComponent medicationdispense_performercomponent:
							Write(medicationdispense_performercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationDispense.SubstitutionComponent medicationdispense_substitutioncomponent:
							Write(medicationdispense_substitutioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.RelatedMedicationKnowledgeComponent medicationknowledge_relatedmedicationknowledgecomponent:
							Write(medicationknowledge_relatedmedicationknowledgecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.MonographComponent medicationknowledge_monographcomponent:
							Write(medicationknowledge_monographcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.IngredientComponent medicationknowledge_ingredientcomponent:
							Write(medicationknowledge_ingredientcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.CostComponent medicationknowledge_costcomponent:
							Write(medicationknowledge_costcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.MonitoringProgramComponent medicationknowledge_monitoringprogramcomponent:
							Write(medicationknowledge_monitoringprogramcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.AdministrationGuidelinesComponent medicationknowledge_administrationguidelinescomponent:
							Write(medicationknowledge_administrationguidelinescomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.DosageComponent medicationknowledge_dosagecomponent:
							Write(medicationknowledge_dosagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.PatientCharacteristicsComponent medicationknowledge_patientcharacteristicscomponent:
							Write(medicationknowledge_patientcharacteristicscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.MedicineClassificationComponent medicationknowledge_medicineclassificationcomponent:
							Write(medicationknowledge_medicineclassificationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.PackagingComponent medicationknowledge_packagingcomponent:
							Write(medicationknowledge_packagingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.DrugCharacteristicComponent medicationknowledge_drugcharacteristiccomponent:
							Write(medicationknowledge_drugcharacteristiccomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent medicationknowledge_regulatorycomponent:
							Write(medicationknowledge_regulatorycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.SubstitutionComponent medicationknowledge_substitutioncomponent:
							Write(medicationknowledge_substitutioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.ScheduleComponent medicationknowledge_schedulecomponent:
							Write(medicationknowledge_schedulecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent medicationknowledge_maxdispensecomponent:
							Write(medicationknowledge_maxdispensecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationKnowledge.KineticsComponent medicationknowledge_kineticscomponent:
							Write(medicationknowledge_kineticscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest.DispenseRequestComponent medicationrequest_dispenserequestcomponent:
							Write(medicationrequest_dispenserequestcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest.InitialFillComponent medicationrequest_initialfillcomponent:
							Write(medicationrequest_initialfillcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicationRequest.SubstitutionComponent medicationrequest_substitutioncomponent:
							Write(medicationrequest_substitutioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct.NameComponent medicinalproduct_namecomponent:
							Write(medicinalproduct_namecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct.NamePartComponent medicinalproduct_namepartcomponent:
							Write(medicinalproduct_namepartcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct.CountryLanguageComponent medicinalproduct_countrylanguagecomponent:
							Write(medicinalproduct_countrylanguagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct.ManufacturingBusinessOperationComponent medicinalproduct_manufacturingbusinessoperationcomponent:
							Write(medicinalproduct_manufacturingbusinessoperationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProduct.SpecialDesignationComponent medicinalproduct_specialdesignationcomponent:
							Write(medicinalproduct_specialdesignationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductAuthorization.JurisdictionalAuthorizationComponent medicinalproductauthorization_jurisdictionalauthorizationcomponent:
							Write(medicinalproductauthorization_jurisdictionalauthorizationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductAuthorization.ProcedureComponent medicinalproductauthorization_procedurecomponent:
							Write(medicinalproductauthorization_procedurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductContraindication.OtherTherapyComponent medicinalproductcontraindication_othertherapycomponent:
							Write(medicinalproductcontraindication_othertherapycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent medicinalproductindication_othertherapycomponent:
							Write(medicinalproductindication_othertherapycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient.SpecifiedSubstanceComponent medicinalproductingredient_specifiedsubstancecomponent:
							Write(medicinalproductingredient_specifiedsubstancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient.StrengthComponent medicinalproductingredient_strengthcomponent:
							Write(medicinalproductingredient_strengthcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient.ReferenceStrengthComponent medicinalproductingredient_referencestrengthcomponent:
							Write(medicinalproductingredient_referencestrengthcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent medicinalproductingredient_substancecomponent:
							Write(medicinalproductingredient_substancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductInteraction.InteractantComponent medicinalproductinteraction_interactantcomponent:
							Write(medicinalproductinteraction_interactantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent medicinalproductpackaged_batchidentifiercomponent:
							Write(medicinalproductpackaged_batchidentifiercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent medicinalproductpackaged_packageitemcomponent:
							Write(medicinalproductpackaged_packageitemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent medicinalproductpharmaceutical_characteristicscomponent:
							Write(medicinalproductpharmaceutical_characteristicscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent medicinalproductpharmaceutical_routeofadministrationcomponent:
							Write(medicinalproductpharmaceutical_routeofadministrationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent medicinalproductpharmaceutical_targetspeciescomponent:
							Write(medicinalproductpharmaceutical_targetspeciescomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent medicinalproductpharmaceutical_withdrawalperiodcomponent:
							Write(medicinalproductpharmaceutical_withdrawalperiodcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageDefinition.FocusComponent messagedefinition_focuscomponent:
							Write(messagedefinition_focuscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageDefinition.AllowedResponseComponent messagedefinition_allowedresponsecomponent:
							Write(messagedefinition_allowedresponsecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader.MessageDestinationComponent messageheader_messagedestinationcomponent:
							Write(messageheader_messagedestinationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader.MessageSourceComponent messageheader_messagesourcecomponent:
							Write(messageheader_messagesourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MessageHeader.ResponseComponent messageheader_responsecomponent:
							Write(messageheader_responsecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.ReferenceSeqComponent molecularsequence_referenceseqcomponent:
							Write(molecularsequence_referenceseqcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.VariantComponent molecularsequence_variantcomponent:
							Write(molecularsequence_variantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.QualityComponent molecularsequence_qualitycomponent:
							Write(molecularsequence_qualitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.RocComponent molecularsequence_roccomponent:
							Write(molecularsequence_roccomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.RepositoryComponent molecularsequence_repositorycomponent:
							Write(molecularsequence_repositorycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.StructureVariantComponent molecularsequence_structurevariantcomponent:
							Write(molecularsequence_structurevariantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.OuterComponent molecularsequence_outercomponent:
							Write(molecularsequence_outercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.MolecularSequence.InnerComponent molecularsequence_innercomponent:
							Write(molecularsequence_innercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NamingSystem.UniqueIdComponent namingsystem_uniqueidcomponent:
							Write(namingsystem_uniqueidcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.OralDietComponent nutritionorder_oraldietcomponent:
							Write(nutritionorder_oraldietcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.NutrientComponent nutritionorder_nutrientcomponent:
							Write(nutritionorder_nutrientcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.TextureComponent nutritionorder_texturecomponent:
							Write(nutritionorder_texturecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.SupplementComponent nutritionorder_supplementcomponent:
							Write(nutritionorder_supplementcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.EnteralFormulaComponent nutritionorder_enteralformulacomponent:
							Write(nutritionorder_enteralformulacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.NutritionOrder.AdministrationComponent nutritionorder_administrationcomponent:
							Write(nutritionorder_administrationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Observation.ReferenceRangeComponent observation_referencerangecomponent:
							Write(observation_referencerangecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Observation.ComponentComponent observation_componentcomponent:
							Write(observation_componentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent observationdefinition_quantitativedetailscomponent:
							Write(observationdefinition_quantitativedetailscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent observationdefinition_qualifiedintervalcomponent:
							Write(observationdefinition_qualifiedintervalcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationDefinition.ParameterComponent operationdefinition_parametercomponent:
							Write(operationdefinition_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationDefinition.BindingComponent operationdefinition_bindingcomponent:
							Write(operationdefinition_bindingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationDefinition.ReferencedFromComponent operationdefinition_referencedfromcomponent:
							Write(operationdefinition_referencedfromcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationDefinition.OverloadComponent operationdefinition_overloadcomponent:
							Write(operationdefinition_overloadcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.OperationOutcome.IssueComponent operationoutcome_issuecomponent:
							Write(operationoutcome_issuecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Organization.ContactComponent organization_contactcomponent:
							Write(organization_contactcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Parameters.ParameterComponent parameters_parametercomponent:
							Write(parameters_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Patient.ContactComponent patient_contactcomponent:
							Write(patient_contactcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Patient.CommunicationComponent patient_communicationcomponent:
							Write(patient_communicationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Patient.LinkComponent patient_linkcomponent:
							Write(patient_linkcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PaymentReconciliation.DetailsComponent paymentreconciliation_detailscomponent:
							Write(paymentreconciliation_detailscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PaymentReconciliation.NotesComponent paymentreconciliation_notescomponent:
							Write(paymentreconciliation_notescomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Person.LinkComponent person_linkcomponent:
							Write(person_linkcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.GoalComponent plandefinition_goalcomponent:
							Write(plandefinition_goalcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.TargetComponent plandefinition_targetcomponent:
							Write(plandefinition_targetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.ActionComponent plandefinition_actioncomponent:
							Write(plandefinition_actioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.ConditionComponent plandefinition_conditioncomponent:
							Write(plandefinition_conditioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent plandefinition_relatedactioncomponent:
							Write(plandefinition_relatedactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.ParticipantComponent plandefinition_participantcomponent:
							Write(plandefinition_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PlanDefinition.DynamicValueComponent plandefinition_dynamicvaluecomponent:
							Write(plandefinition_dynamicvaluecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Practitioner.QualificationComponent practitioner_qualificationcomponent:
							Write(practitioner_qualificationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent practitionerrole_availabletimecomponent:
							Write(practitionerrole_availabletimecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.PractitionerRole.NotAvailableComponent practitionerrole_notavailablecomponent:
							Write(practitionerrole_notavailablecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Procedure.PerformerComponent procedure_performercomponent:
							Write(procedure_performercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Procedure.FocalDeviceComponent procedure_focaldevicecomponent:
							Write(procedure_focaldevicecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Provenance.AgentComponent provenance_agentcomponent:
							Write(provenance_agentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Provenance.EntityComponent provenance_entitycomponent:
							Write(provenance_entitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Questionnaire.ItemComponent questionnaire_itemcomponent:
							Write(questionnaire_itemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Questionnaire.EnableWhenComponent questionnaire_enablewhencomponent:
							Write(questionnaire_enablewhencomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Questionnaire.AnswerOptionComponent questionnaire_answeroptioncomponent:
							Write(questionnaire_answeroptioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Questionnaire.InitialComponent questionnaire_initialcomponent:
							Write(questionnaire_initialcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent questionnaireresponse_itemcomponent:
							Write(questionnaireresponse_itemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.QuestionnaireResponse.AnswerComponent questionnaireresponse_answercomponent:
							Write(questionnaireresponse_answercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RelatedPerson.CommunicationComponent relatedperson_communicationcomponent:
							Write(relatedperson_communicationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RequestGroup.ActionComponent requestgroup_actioncomponent:
							Write(requestgroup_actioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RequestGroup.ConditionComponent requestgroup_conditioncomponent:
							Write(requestgroup_conditioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RequestGroup.RelatedActionComponent requestgroup_relatedactioncomponent:
							Write(requestgroup_relatedactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchElementDefinition.CharacteristicComponent researchelementdefinition_characteristiccomponent:
							Write(researchelementdefinition_characteristiccomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchStudy.ArmComponent researchstudy_armcomponent:
							Write(researchstudy_armcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ResearchStudy.ObjectiveComponent researchstudy_objectivecomponent:
							Write(researchstudy_objectivecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskAssessment.PredictionComponent riskassessment_predictioncomponent:
							Write(riskassessment_predictioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.SampleSizeComponent riskevidencesynthesis_samplesizecomponent:
							Write(riskevidencesynthesis_samplesizecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.RiskEstimateComponent riskevidencesynthesis_riskestimatecomponent:
							Write(riskevidencesynthesis_riskestimatecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.PrecisionEstimateComponent riskevidencesynthesis_precisionestimatecomponent:
							Write(riskevidencesynthesis_precisionestimatecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintyComponent riskevidencesynthesis_certaintycomponent:
							Write(riskevidencesynthesis_certaintycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.RiskEvidenceSynthesis.CertaintySubcomponentComponent riskevidencesynthesis_certaintysubcomponentcomponent:
							Write(riskevidencesynthesis_certaintysubcomponentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SearchParameter.ComponentComponent searchparameter_componentcomponent:
							Write(searchparameter_componentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Specimen.CollectionComponent specimen_collectioncomponent:
							Write(specimen_collectioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Specimen.ProcessingComponent specimen_processingcomponent:
							Write(specimen_processingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Specimen.ContainerComponent specimen_containercomponent:
							Write(specimen_containercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent specimendefinition_typetestedcomponent:
							Write(specimendefinition_typetestedcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent specimendefinition_containercomponent:
							Write(specimendefinition_containercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent specimendefinition_additivecomponent:
							Write(specimendefinition_additivecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent specimendefinition_handlingcomponent:
							Write(specimendefinition_handlingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition.MappingComponent structuredefinition_mappingcomponent:
							Write(structuredefinition_mappingcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition.ContextComponent structuredefinition_contextcomponent:
							Write(structuredefinition_contextcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition.SnapshotComponent structuredefinition_snapshotcomponent:
							Write(structuredefinition_snapshotcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureDefinition.DifferentialComponent structuredefinition_differentialcomponent:
							Write(structuredefinition_differentialcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.StructureComponent structuremap_structurecomponent:
							Write(structuremap_structurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.GroupComponent structuremap_groupcomponent:
							Write(structuremap_groupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.InputComponent structuremap_inputcomponent:
							Write(structuremap_inputcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.RuleComponent structuremap_rulecomponent:
							Write(structuremap_rulecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.SourceComponent structuremap_sourcecomponent:
							Write(structuremap_sourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.TargetComponent structuremap_targetcomponent:
							Write(structuremap_targetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.ParameterComponent structuremap_parametercomponent:
							Write(structuremap_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.StructureMap.DependentComponent structuremap_dependentcomponent:
							Write(structuremap_dependentcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Subscription.ChannelComponent subscription_channelcomponent:
							Write(subscription_channelcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Substance.InstanceComponent substance_instancecomponent:
							Write(substance_instancecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Substance.IngredientComponent substance_ingredientcomponent:
							Write(substance_ingredientcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceNucleicAcid.SubunitComponent substancenucleicacid_subunitcomponent:
							Write(substancenucleicacid_subunitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceNucleicAcid.LinkageComponent substancenucleicacid_linkagecomponent:
							Write(substancenucleicacid_linkagecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceNucleicAcid.SugarComponent substancenucleicacid_sugarcomponent:
							Write(substancenucleicacid_sugarcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer.MonomerSetComponent substancepolymer_monomersetcomponent:
							Write(substancepolymer_monomersetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer.StartingMaterialComponent substancepolymer_startingmaterialcomponent:
							Write(substancepolymer_startingmaterialcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer.RepeatComponent substancepolymer_repeatcomponent:
							Write(substancepolymer_repeatcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent substancepolymer_repeatunitcomponent:
							Write(substancepolymer_repeatunitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent substancepolymer_degreeofpolymerisationcomponent:
							Write(substancepolymer_degreeofpolymerisationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent substancepolymer_structuralrepresentationcomponent:
							Write(substancepolymer_structuralrepresentationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceProtein.SubunitComponent substanceprotein_subunitcomponent:
							Write(substanceprotein_subunitcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent substancereferenceinformation_genecomponent:
							Write(substancereferenceinformation_genecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent substancereferenceinformation_geneelementcomponent:
							Write(substancereferenceinformation_geneelementcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent substancereferenceinformation_classificationcomponent:
							Write(substancereferenceinformation_classificationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent substancereferenceinformation_targetcomponent:
							Write(substancereferenceinformation_targetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.FractionDescriptionComponent substancesourcematerial_fractiondescriptioncomponent:
							Write(substancesourcematerial_fractiondescriptioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent substancesourcematerial_organismcomponent:
							Write(substancesourcematerial_organismcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.AuthorComponent substancesourcematerial_authorcomponent:
							Write(substancesourcematerial_authorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent substancesourcematerial_hybridcomponent:
							Write(substancesourcematerial_hybridcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent substancesourcematerial_organismgeneralcomponent:
							Write(substancesourcematerial_organismgeneralcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSourceMaterial.PartDescriptionComponent substancesourcematerial_partdescriptioncomponent:
							Write(substancesourcematerial_partdescriptioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.MoietyComponent substancespecification_moietycomponent:
							Write(substancespecification_moietycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.PropertyComponent substancespecification_propertycomponent:
							Write(substancespecification_propertycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.StructureComponent substancespecification_structurecomponent:
							Write(substancespecification_structurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.IsotopeComponent substancespecification_isotopecomponent:
							Write(substancespecification_isotopecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.MolecularWeightComponent substancespecification_molecularweightcomponent:
							Write(substancespecification_molecularweightcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.RepresentationComponent substancespecification_representationcomponent:
							Write(substancespecification_representationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.CodeComponent substancespecification_codecomponent:
							Write(substancespecification_codecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.NameComponent substancespecification_namecomponent:
							Write(substancespecification_namecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.OfficialComponent substancespecification_officialcomponent:
							Write(substancespecification_officialcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SubstanceSpecification.RelationshipComponent substancespecification_relationshipcomponent:
							Write(substancespecification_relationshipcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent supplydelivery_supplieditemcomponent:
							Write(supplydelivery_supplieditemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.SupplyRequest.ParameterComponent supplyrequest_parametercomponent:
							Write(supplyrequest_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Task.RestrictionComponent task_restrictioncomponent:
							Write(task_restrictioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Task.ParameterComponent task_parametercomponent:
							Write(task_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Task.OutputComponent task_outputcomponent:
							Write(task_outputcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.SoftwareComponent terminologycapabilities_softwarecomponent:
							Write(terminologycapabilities_softwarecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ImplementationComponent terminologycapabilities_implementationcomponent:
							Write(terminologycapabilities_implementationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.CodeSystemComponent terminologycapabilities_codesystemcomponent:
							Write(terminologycapabilities_codesystemcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.VersionComponent terminologycapabilities_versioncomponent:
							Write(terminologycapabilities_versioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.FilterComponent terminologycapabilities_filtercomponent:
							Write(terminologycapabilities_filtercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent terminologycapabilities_expansioncomponent:
							Write(terminologycapabilities_expansioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ParameterComponent terminologycapabilities_parametercomponent:
							Write(terminologycapabilities_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ValidateCodeComponent terminologycapabilities_validatecodecomponent:
							Write(terminologycapabilities_validatecodecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.TranslationComponent terminologycapabilities_translationcomponent:
							Write(terminologycapabilities_translationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TerminologyCapabilities.ClosureComponent terminologycapabilities_closurecomponent:
							Write(terminologycapabilities_closurecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.ParticipantComponent testreport_participantcomponent:
							Write(testreport_participantcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.SetupComponent testreport_setupcomponent:
							Write(testreport_setupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.SetupActionComponent testreport_setupactioncomponent:
							Write(testreport_setupactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.OperationComponent testreport_operationcomponent:
							Write(testreport_operationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.AssertComponent testreport_assertcomponent:
							Write(testreport_assertcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.TestComponent testreport_testcomponent:
							Write(testreport_testcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.TestActionComponent testreport_testactioncomponent:
							Write(testreport_testactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.TeardownComponent testreport_teardowncomponent:
							Write(testreport_teardowncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestReport.TeardownActionComponent testreport_teardownactioncomponent:
							Write(testreport_teardownactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.OriginComponent testscript_origincomponent:
							Write(testscript_origincomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.DestinationComponent testscript_destinationcomponent:
							Write(testscript_destinationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.MetadataComponent testscript_metadatacomponent:
							Write(testscript_metadatacomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.LinkComponent testscript_linkcomponent:
							Write(testscript_linkcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.CapabilityComponent testscript_capabilitycomponent:
							Write(testscript_capabilitycomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.FixtureComponent testscript_fixturecomponent:
							Write(testscript_fixturecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.VariableComponent testscript_variablecomponent:
							Write(testscript_variablecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.SetupComponent testscript_setupcomponent:
							Write(testscript_setupcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.SetupActionComponent testscript_setupactioncomponent:
							Write(testscript_setupactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.OperationComponent testscript_operationcomponent:
							Write(testscript_operationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.RequestHeaderComponent testscript_requestheadercomponent:
							Write(testscript_requestheadercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.AssertComponent testscript_assertcomponent:
							Write(testscript_assertcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.TestComponent testscript_testcomponent:
							Write(testscript_testcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.TestActionComponent testscript_testactioncomponent:
							Write(testscript_testactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.TeardownComponent testscript_teardowncomponent:
							Write(testscript_teardowncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.TestScript.TeardownActionComponent testscript_teardownactioncomponent:
							Write(testscript_teardownactioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ComposeComponent valueset_composecomponent:
							Write(valueset_composecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ConceptSetComponent valueset_conceptsetcomponent:
							Write(valueset_conceptsetcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ConceptReferenceComponent valueset_conceptreferencecomponent:
							Write(valueset_conceptreferencecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.DesignationComponent valueset_designationcomponent:
							Write(valueset_designationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.FilterComponent valueset_filtercomponent:
							Write(valueset_filtercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ExpansionComponent valueset_expansioncomponent:
							Write(valueset_expansioncomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ParameterComponent valueset_parametercomponent:
							Write(valueset_parametercomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.ValueSet.ContainsComponent valueset_containscomponent:
							Write(valueset_containscomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent verificationresult_primarysourcecomponent:
							Write(verificationresult_primarysourcecomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.VerificationResult.AttestationComponent verificationresult_attestationcomponent:
							Write(verificationresult_attestationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.VerificationResult.ValidatorComponent verificationresult_validatorcomponent:
							Write(verificationresult_validatorcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent visionprescription_lensspecificationcomponent:
							Write(visionprescription_lensspecificationcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.VisionPrescription.PrismComponent visionprescription_prismcomponent:
							Write(visionprescription_prismcomponent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Account.AccountStatus> code_account_accountstatus:
							Write(code_account_accountstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus> code_publicationstatus:
							Write(code_publicationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActivityDefinition.RequestResourceType> code_activitydefinition_requestresourcetype:
							Write(code_activitydefinition_requestresourcetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent> code_requestintent:
							Write(code_requestintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority> code_requestpriority:
							Write(code_requestpriority, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality> code_adverseevent_adverseeventactuality:
							Write(code_adverseevent_adverseeventactuality, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType> code_allergyintolerance_allergyintolerancetype:
							Write(code_allergyintolerance_allergyintolerancetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality> code_allergyintolerance_allergyintolerancecriticality:
							Write(code_allergyintolerance_allergyintolerancecriticality, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Appointment.AppointmentStatus> code_appointment_appointmentstatus:
							Write(code_appointment_appointmentstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ParticipationStatus> code_participationstatus:
							Write(code_participationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction> code_auditevent_auditeventaction:
							Write(code_auditevent_auditeventaction, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome> code_auditevent_auditeventoutcome:
							Write(code_auditevent_auditeventoutcome, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> code_biologicallyderivedproduct_biologicallyderivedproductcategory:
							Write(code_biologicallyderivedproduct_biologicallyderivedproductcategory, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> code_biologicallyderivedproduct_biologicallyderivedproductstatus:
							Write(code_biologicallyderivedproduct_biologicallyderivedproductstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Bundle.BundleType> code_bundle_bundletype:
							Write(code_bundle_bundletype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CapabilityStatementKind> code_capabilitystatementkind:
							Write(code_capabilitystatementkind, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion> code_fhirversion:
							Write(code_fhirversion, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestStatus> code_requeststatus:
							Write(code_requeststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CarePlan.CarePlanIntent> code_careplan_careplanintent:
							Write(code_careplan_careplanintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CareTeam.CareTeamStatus> code_careteam_careteamstatus:
							Write(code_careteam_careteamstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ChargeItem.ChargeItemStatus> code_chargeitem_chargeitemstatus:
							Write(code_chargeitem_chargeitemstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes> code_financialresourcestatuscodes:
							Write(code_financialresourcestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Use> code_use:
							Write(code_use, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClaimProcessingCodes> code_claimprocessingcodes:
							Write(code_claimprocessingcodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus> code_clinicalimpression_clinicalimpressionstatus:
							Write(code_clinicalimpression_clinicalimpressionstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemHierarchyMeaning> code_codesystem_codesystemhierarchymeaning:
							Write(code_codesystem_codesystemhierarchymeaning, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CodeSystem.CodeSystemContentMode> code_codesystem_codesystemcontentmode:
							Write(code_codesystem_codesystemcontentmode, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus> code_eventstatus:
							Write(code_eventstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompartmentType> code_compartmenttype:
							Write(code_compartmenttype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.CompositionStatus> code_compositionstatus:
							Write(code_compositionstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification> code_composition_v3_confidentialityclassification:
							Write(code_composition_v3_confidentialityclassification, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentState> code_consent_consentstate:
							Write(code_consent_consentstate, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contract.ContractResourceStatusCodes> code_contract_contractresourcestatuscodes:
							Write(code_contract_contractresourcestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationStatus> code_observationstatus:
							Write(code_observationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DetectedIssue.DetectedIssueSeverity> code_detectedissue_detectedissueseverity:
							Write(code_detectedissue_detectedissueseverity, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Device.FHIRDeviceStatus> code_device_fhirdevicestatus:
							Write(code_device_fhirdevicestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricOperationalStatus> code_devicemetric_devicemetricoperationalstatus:
							Write(code_devicemetric_devicemetricoperationalstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricColor> code_devicemetric_devicemetriccolor:
							Write(code_devicemetric_devicemetriccolor, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceMetric.DeviceMetricCategory> code_devicemetric_devicemetriccategory:
							Write(code_devicemetric_devicemetriccategory, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus> code_deviceusestatement_deviceusestatementstatus:
							Write(code_deviceusestatement_deviceusestatementstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus> code_diagnosticreport_diagnosticreportstatus:
							Write(code_diagnosticreport_diagnosticreportstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DocumentReferenceStatus> code_documentreferencestatus:
							Write(code_documentreferencestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Encounter.EncounterStatus> code_encounter_encounterstatus:
							Write(code_encounter_encounterstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Endpoint.EndpointStatus> code_endpoint_endpointstatus:
							Write(code_endpoint_endpointstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EpisodeOfCare.EpisodeOfCareStatus> code_episodeofcare_episodeofcarestatus:
							Write(code_episodeofcare_episodeofcarestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EvidenceVariableType> code_evidencevariabletype:
							Write(code_evidencevariabletype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ExplanationOfBenefit.ExplanationOfBenefitStatus> code_explanationofbenefit_explanationofbenefitstatus:
							Write(code_explanationofbenefit_explanationofbenefitstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FamilyMemberHistory.FamilyHistoryStatus> code_familymemberhistory_familyhistorystatus:
							Write(code_familymemberhistory_familyhistorystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Flag.FlagStatus> code_flag_flagstatus:
							Write(code_flag_flagstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus> code_goal_goallifecyclestatus:
							Write(code_goal_goallifecyclestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType> code_resourcetype:
							Write(code_resourcetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Group.GroupType> code_group_grouptype:
							Write(code_group_grouptype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus> code_guidanceresponse_guidanceresponsestatus:
							Write(code_guidanceresponse_guidanceresponsestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImagingStudy.ImagingStudyStatus> code_imagingstudy_imagingstudystatus:
							Write(code_imagingstudy_imagingstudystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Immunization.ImmunizationStatusCodes> code_immunization_immunizationstatuscodes:
							Write(code_immunization_immunizationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> code_immunizationevaluation_immunizationevaluationstatuscodes:
							Write(code_immunizationevaluation_immunizationevaluationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ImplementationGuide.SPDXLicense> code_implementationguide_spdxlicense:
							Write(code_implementationguide_spdxlicense, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Invoice.InvoiceStatus> code_invoice_invoicestatus:
							Write(code_invoice_invoicestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.List.ListStatus> code_list_liststatus:
							Write(code_list_liststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ListMode> code_listmode:
							Write(code_listmode, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationStatus> code_location_locationstatus:
							Write(code_location_locationstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationMode> code_location_locationmode:
							Write(code_location_locationmode, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MeasureReport.MeasureReportStatus> code_measurereport_measurereportstatus:
							Write(code_measurereport_measurereportstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MeasureReport.MeasureReportType> code_measurereport_measurereporttype:
							Write(code_measurereport_measurereporttype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes> code_medication_medicationstatuscodes:
							Write(code_medication_medicationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusCodes> code_medicationadministration_medicationadministrationstatuscodes:
							Write(code_medicationadministration_medicationadministrationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusCodes> code_medicationdispense_medicationdispensestatuscodes:
							Write(code_medicationdispense_medicationdispensestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationKnowledge.MedicationKnowledgeStatusCodes> code_medicationknowledge_medicationknowledgestatuscodes:
							Write(code_medicationknowledge_medicationknowledgestatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationrequestStatus> code_medicationrequest_medicationrequeststatus:
							Write(code_medicationrequest_medicationrequeststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationRequest.medicationRequestIntent> code_medicationrequest_medicationrequestintent:
							Write(code_medicationrequest_medicationrequestintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes> code_medicationstatement_medicationstatuscodes:
							Write(code_medicationstatement_medicationstatuscodes, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MessageDefinition.MessageSignificanceCategory> code_messagedefinition_messagesignificancecategory:
							Write(code_messagedefinition_messagesignificancecategory, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MessageDefinition.messageheader_response_request> code_messagedefinition_messageheader_response_request:
							Write(code_messagedefinition_messageheader_response_request, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MolecularSequence.sequenceType> code_molecularsequence_sequencetype:
							Write(code_molecularsequence_sequencetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.NamingSystem.NamingSystemType> code_namingsystem_namingsystemtype:
							Write(code_namingsystem_namingsystemtype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationDefinition.OperationKind> code_operationdefinition_operationkind:
							Write(code_operationdefinition_operationkind, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender> code_administrativegender:
							Write(code_administrativegender, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.QuestionnaireResponse.QuestionnaireResponseStatus> code_questionnaireresponse_questionnaireresponsestatus:
							Write(code_questionnaireresponse_questionnaireresponsestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchElementDefinition.ResearchElementType> code_researchelementdefinition_researchelementtype:
							Write(code_researchelementdefinition_researchelementtype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus> code_researchstudy_researchstudystatus:
							Write(code_researchstudy_researchstudystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus> code_researchsubject_researchsubjectstatus:
							Write(code_researchsubject_researchsubjectstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType> code_searchparamtype:
							Write(code_searchparamtype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType> code_searchparameter_xpathusagetype:
							Write(code_searchparameter_xpathusagetype, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Slot.SlotStatus> code_slot_slotstatus:
							Write(code_slot_slotstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Specimen.SpecimenStatus> code_specimen_specimenstatus:
							Write(code_specimen_specimenstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind> code_structuredefinition_structuredefinitionkind:
							Write(code_structuredefinition_structuredefinitionkind, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule> code_structuredefinition_typederivationrule:
							Write(code_structuredefinition_typederivationrule, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus> code_subscription_subscriptionstatus:
							Write(code_subscription_subscriptionstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Substance.FHIRSubstanceStatus> code_substance_fhirsubstancestatus:
							Write(code_substance_fhirsubstancestatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus> code_supplydelivery_supplydeliverystatus:
							Write(code_supplydelivery_supplydeliverystatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus> code_supplyrequest_supplyrequeststatus:
							Write(code_supplyrequest_supplyrequeststatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskStatus> code_task_taskstatus:
							Write(code_task_taskstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Task.TaskIntent> code_task_taskintent:
							Write(code_task_taskintent, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TerminologyCapabilities.CodeSearchSupport> code_terminologycapabilities_codesearchsupport:
							Write(code_terminologycapabilities_codesearchsupport, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportStatus> code_testreport_testreportstatus:
							Write(code_testreport_testreportstatus, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.TestReport.TestReportResult> code_testreport_testreportresult:
							Write(code_testreport_testreportresult, writer, propertyName, cancellationToken);
							break;
				case Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VerificationResult.status> code_verificationresult_status:
							Write(code_verificationresult_status, writer, propertyName, cancellationToken);
							break;
				default:	System.Diagnostics.Trace.WriteLine($"No Serialization defined for {value?.TypeName}");
							break;
			}
			if (value is Hl7.Fhir.Model.Resource && propertyName != "root")
				writer.WriteEndElement();
		}
	}
}
