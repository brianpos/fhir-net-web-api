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
		public void Parse(Hl7.Fhir.Model.ConceptMap.TargetElementComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".display", cancellationToken); // 50
							break;
						case "equivalence":
							result.EquivalenceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMapEquivalence>();
							Parse(result.EquivalenceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMapEquivalence>, reader, outcome, locationPath + ".equivalence", cancellationToken); // 60
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment", cancellationToken); // 70
							break;
						case "dependsOn":
							var newItem_dependsOn = new Hl7.Fhir.Model.ConceptMap.OtherElementComponent();
							Parse(newItem_dependsOn, reader, outcome, locationPath + ".dependsOn["+result.DependsOn.Count+"]", cancellationToken); // 80
							result.DependsOn.Add(newItem_dependsOn);
							break;
						case "product":
							var newItem_product = new Hl7.Fhir.Model.ConceptMap.OtherElementComponent();
							Parse(newItem_product, reader, outcome, locationPath + ".product["+result.Product.Count+"]", cancellationToken); // 90
							result.Product.Add(newItem_product);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ConceptMap.TargetElementComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code", cancellationToken); // 40
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".display", cancellationToken); // 50
							break;
						case "equivalence":
							result.EquivalenceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMapEquivalence>();
							await ParseAsync(result.EquivalenceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMapEquivalence>, reader, outcome, locationPath + ".equivalence", cancellationToken); // 60
							break;
						case "comment":
							result.CommentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CommentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".comment", cancellationToken); // 70
							break;
						case "dependsOn":
							var newItem_dependsOn = new Hl7.Fhir.Model.ConceptMap.OtherElementComponent();
							await ParseAsync(newItem_dependsOn, reader, outcome, locationPath + ".dependsOn["+result.DependsOn.Count+"]", cancellationToken); // 80
							result.DependsOn.Add(newItem_dependsOn);
							break;
						case "product":
							var newItem_product = new Hl7.Fhir.Model.ConceptMap.OtherElementComponent();
							await ParseAsync(newItem_product, reader, outcome, locationPath + ".product["+result.Product.Count+"]", cancellationToken); // 90
							result.Product.Add(newItem_product);
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
