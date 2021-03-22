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
		public void Parse(Hl7.Fhir.Model.ElementDefinition.SlicingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "discriminator":
							var newItem_discriminator = new Hl7.Fhir.Model.ElementDefinition.DiscriminatorComponent();
							Parse(newItem_discriminator, reader, outcome, locationPath + ".discriminator["+result.Discriminator.Count+"]", cancellationToken); // 40
							result.Discriminator.Add(newItem_discriminator);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 50
							break;
						case "ordered":
							result.OrderedElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.OrderedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".ordered", cancellationToken); // 60
							break;
						case "rules":
							result.RulesElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.SlicingRules>();
							Parse(result.RulesElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.SlicingRules>, reader, outcome, locationPath + ".rules", cancellationToken); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ElementDefinition.SlicingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "discriminator":
							var newItem_discriminator = new Hl7.Fhir.Model.ElementDefinition.DiscriminatorComponent();
							await ParseAsync(newItem_discriminator, reader, outcome, locationPath + ".discriminator["+result.Discriminator.Count+"]", cancellationToken); // 40
							result.Discriminator.Add(newItem_discriminator);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 50
							break;
						case "ordered":
							result.OrderedElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.OrderedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".ordered", cancellationToken); // 60
							break;
						case "rules":
							result.RulesElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.SlicingRules>();
							await ParseAsync(result.RulesElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ElementDefinition.SlicingRules>, reader, outcome, locationPath + ".rules", cancellationToken); // 70
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
