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
		public void Parse(Hl7.Fhir.Model.OperationDefinition.ParameterComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.Code();
							Parse(result.NameElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>, reader, outcome, locationPath + ".use", cancellationToken); // 50
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.Integer();
							Parse(result.MinElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".min", cancellationToken); // 60
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".max", cancellationToken); // 70
							break;
						case "documentation":
							result.DocumentationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DocumentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentation", cancellationToken); // 80
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>, reader, outcome, locationPath + ".type", cancellationToken); // 90
							break;
						case "targetProfile":
							var newItem_targetProfile = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_targetProfile, reader, outcome, locationPath + ".targetProfile["+result.TargetProfileElement.Count+"]", cancellationToken); // 100
							result.TargetProfileElement.Add(newItem_targetProfile);
							break;
						case "searchType":
							result.SearchTypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>();
							Parse(result.SearchTypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>, reader, outcome, locationPath + ".searchType", cancellationToken); // 110
							break;
						case "binding":
							result.Binding = new Hl7.Fhir.Model.OperationDefinition.BindingComponent();
							Parse(result.Binding as Hl7.Fhir.Model.OperationDefinition.BindingComponent, reader, outcome, locationPath + ".binding", cancellationToken); // 120
							break;
						case "referencedFrom":
							var newItem_referencedFrom = new Hl7.Fhir.Model.OperationDefinition.ReferencedFromComponent();
							Parse(newItem_referencedFrom, reader, outcome, locationPath + ".referencedFrom["+result.ReferencedFrom.Count+"]", cancellationToken); // 130
							result.ReferencedFrom.Add(newItem_referencedFrom);
							break;
						case "part":
							var newItem_part = new Hl7.Fhir.Model.OperationDefinition.ParameterComponent();
							Parse(newItem_part, reader, outcome, locationPath + ".part["+result.Part.Count+"]", cancellationToken); // 140
							result.Part.Add(newItem_part);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.OperationDefinition.ParameterComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".name", cancellationToken); // 40
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.OperationParameterUse>, reader, outcome, locationPath + ".use", cancellationToken); // 50
							break;
						case "min":
							result.MinElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MinElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".min", cancellationToken); // 60
							break;
						case "max":
							result.MaxElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.MaxElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".max", cancellationToken); // 70
							break;
						case "documentation":
							result.DocumentationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DocumentationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".documentation", cancellationToken); // 80
							break;
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRAllTypes>, reader, outcome, locationPath + ".type", cancellationToken); // 90
							break;
						case "targetProfile":
							var newItem_targetProfile = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_targetProfile, reader, outcome, locationPath + ".targetProfile["+result.TargetProfileElement.Count+"]", cancellationToken); // 100
							result.TargetProfileElement.Add(newItem_targetProfile);
							break;
						case "searchType":
							result.SearchTypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>();
							await ParseAsync(result.SearchTypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchParamType>, reader, outcome, locationPath + ".searchType", cancellationToken); // 110
							break;
						case "binding":
							result.Binding = new Hl7.Fhir.Model.OperationDefinition.BindingComponent();
							await ParseAsync(result.Binding as Hl7.Fhir.Model.OperationDefinition.BindingComponent, reader, outcome, locationPath + ".binding", cancellationToken); // 120
							break;
						case "referencedFrom":
							var newItem_referencedFrom = new Hl7.Fhir.Model.OperationDefinition.ReferencedFromComponent();
							await ParseAsync(newItem_referencedFrom, reader, outcome, locationPath + ".referencedFrom["+result.ReferencedFrom.Count+"]", cancellationToken); // 130
							result.ReferencedFrom.Add(newItem_referencedFrom);
							break;
						case "part":
							var newItem_part = new Hl7.Fhir.Model.OperationDefinition.ParameterComponent();
							await ParseAsync(newItem_part, reader, outcome, locationPath + ".part["+result.Part.Count+"]", cancellationToken); // 140
							result.Part.Add(newItem_part);
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
