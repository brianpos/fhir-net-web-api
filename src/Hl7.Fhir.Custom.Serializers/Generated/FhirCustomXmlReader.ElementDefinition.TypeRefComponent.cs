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
		public void Parse(Hl7.Fhir.Model.ElementDefinition.TypeRefComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				return;

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.CodeElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".code", cancellationToken); // 30
							break;
						case "profile":
							var newItem_profile = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_profile, reader, outcome, locationPath + ".profile["+result.ProfileElement.Count+"]", cancellationToken); // 40
							result.ProfileElement.Add(newItem_profile);
							break;
						case "targetProfile":
							var newItem_targetProfile = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_targetProfile, reader, outcome, locationPath + ".targetProfile["+result.TargetProfileElement.Count+"]", cancellationToken); // 50
							result.TargetProfileElement.Add(newItem_targetProfile);
							break;
						case "aggregation":
							var newItem_aggregation = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.AggregationMode>();
							Parse(newItem_aggregation, reader, outcome, locationPath + ".aggregation["+result.AggregationElement.Count+"]", cancellationToken); // 60
							result.AggregationElement.Add(newItem_aggregation);
							break;
						case "versioning":
							result.VersioningElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ReferenceVersionRules>();
							Parse(result.VersioningElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ReferenceVersionRules>, reader, outcome, locationPath + ".versioning", cancellationToken); // 70
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ElementDefinition.TypeRefComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
				return;

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".code", cancellationToken); // 30
							break;
						case "profile":
							var newItem_profile = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_profile, reader, outcome, locationPath + ".profile["+result.ProfileElement.Count+"]", cancellationToken); // 40
							result.ProfileElement.Add(newItem_profile);
							break;
						case "targetProfile":
							var newItem_targetProfile = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_targetProfile, reader, outcome, locationPath + ".targetProfile["+result.TargetProfileElement.Count+"]", cancellationToken); // 50
							result.TargetProfileElement.Add(newItem_targetProfile);
							break;
						case "aggregation":
							var newItem_aggregation = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.AggregationMode>();
							await ParseAsync(newItem_aggregation, reader, outcome, locationPath + ".aggregation["+result.AggregationElement.Count+"]", cancellationToken); // 60
							result.AggregationElement.Add(newItem_aggregation);
							break;
						case "versioning":
							result.VersioningElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ReferenceVersionRules>();
							await ParseAsync(result.VersioningElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.ReferenceVersionRules>, reader, outcome, locationPath + ".versioning", cancellationToken); // 70
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, locationPath + "." + reader.Name);
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
