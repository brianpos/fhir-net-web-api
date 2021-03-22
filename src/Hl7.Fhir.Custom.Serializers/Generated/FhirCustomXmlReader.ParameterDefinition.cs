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
		public void Parse(Hl7.Fhir.Model.ParameterDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.Code();
							Parse(result.NameElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".name", cancellationToken); // 30
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>, reader, outcome, locationPath + ".use", cancellationToken); // 40
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.Integer();
							Parse(result.MinElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".min", cancellationToken); // 50
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".max", cancellationToken); // 60
							break;
						case "documentation":
							result.DocumentationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DocumentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentation", cancellationToken); // 70
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>, reader, outcome, locationPath + ".type", cancellationToken); // 80
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ParameterDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".name", cancellationToken); // 30
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>, reader, outcome, locationPath + ".use", cancellationToken); // 40
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MinElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".min", cancellationToken); // 50
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".max", cancellationToken); // 60
							break;
						case "documentation":
							result.DocumentationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DocumentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentation", cancellationToken); // 70
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>, reader, outcome, locationPath + ".type", cancellationToken); // 80
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile", cancellationToken); // 90
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
