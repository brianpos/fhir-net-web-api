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
		public void Parse(Hl7.Fhir.Model.DataRequirement result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
			{
				// contextLocation.Pop();
				return;
			}

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>, reader, outcome); // 30
							break;
						case "profile":
							var newItem_profile = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_profile, reader, outcome); // 40
							result.ProfileElement.Add(newItem_profile);
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 50
							break;
						case "mustSupport":
							var newItem_mustSupport = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_mustSupport, reader, outcome); // 60
							result.MustSupportElement.Add(newItem_mustSupport);
							break;
						case "codeFilter":
							var newItem_codeFilter = new Hl7.Fhir.Model.DataRequirement.CodeFilterComponent();
							Parse(newItem_codeFilter, reader, outcome); // 70
							result.CodeFilter.Add(newItem_codeFilter);
							break;
						case "dateFilter":
							var newItem_dateFilter = new Hl7.Fhir.Model.DataRequirement.DateFilterComponent();
							Parse(newItem_dateFilter, reader, outcome); // 80
							result.DateFilter.Add(newItem_dateFilter);
							break;
						case "limit":
							result.LimitElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.LimitElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 90
							break;
						case "sort":
							var newItem_sort = new Hl7.Fhir.Model.DataRequirement.SortComponent();
							Parse(newItem_sort, reader, outcome); // 100
							result.Sort.Add(newItem_sort);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.DataRequirement result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
			{
				// contextLocation.Pop();
				return;
			}

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>, reader, outcome); // 30
							break;
						case "profile":
							var newItem_profile = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_profile, reader, outcome); // 40
							result.ProfileElement.Add(newItem_profile);
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 50
							break;
						case "mustSupport":
							var newItem_mustSupport = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_mustSupport, reader, outcome); // 60
							result.MustSupportElement.Add(newItem_mustSupport);
							break;
						case "codeFilter":
							var newItem_codeFilter = new Hl7.Fhir.Model.DataRequirement.CodeFilterComponent();
							await ParseAsync(newItem_codeFilter, reader, outcome); // 70
							result.CodeFilter.Add(newItem_codeFilter);
							break;
						case "dateFilter":
							var newItem_dateFilter = new Hl7.Fhir.Model.DataRequirement.DateFilterComponent();
							await ParseAsync(newItem_dateFilter, reader, outcome); // 80
							result.DateFilter.Add(newItem_dateFilter);
							break;
						case "limit":
							result.LimitElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.LimitElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 90
							break;
						case "sort":
							var newItem_sort = new Hl7.Fhir.Model.DataRequirement.SortComponent();
							await ParseAsync(newItem_sort, reader, outcome); // 100
							result.Sort.Add(newItem_sort);
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}
	}
}
