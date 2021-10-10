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
		public void Parse(Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "product":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".product", cancellationToken); // 40
							break;
						case "eye":
							result.EyeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>();
							Parse(result.EyeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>, reader, outcome, locationPath + ".eye", cancellationToken); // 50
							break;
						case "sphere":
							result.SphereElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.SphereElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".sphere", cancellationToken); // 60
							break;
						case "cylinder":
							result.CylinderElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.CylinderElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".cylinder", cancellationToken); // 70
							break;
						case "axis":
							result.AxisElement = new Hl7.Fhir.Model.Integer();
							Parse(result.AxisElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".axis", cancellationToken); // 80
							break;
						case "prism":
							var newItem_prism = new Hl7.Fhir.Model.VisionPrescription.PrismComponent();
							Parse(newItem_prism, reader, outcome, locationPath + ".prism["+result.Prism.Count+"]", cancellationToken); // 90
							result.Prism.Add(newItem_prism);
							break;
						case "add":
							result.AddElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.AddElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".add", cancellationToken); // 100
							break;
						case "power":
							result.PowerElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PowerElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".power", cancellationToken); // 110
							break;
						case "backCurve":
							result.BackCurveElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.BackCurveElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".backCurve", cancellationToken); // 120
							break;
						case "diameter":
							result.DiameterElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DiameterElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".diameter", cancellationToken); // 130
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.Quantity();
							Parse(result.Duration as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".duration", cancellationToken); // 140
							break;
						case "color":
							result.ColorElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ColorElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".color", cancellationToken); // 150
							break;
						case "brand":
							result.BrandElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.BrandElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".brand", cancellationToken); // 160
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 170
							result.Note.Add(newItem_note);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "product":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".product", cancellationToken); // 40
							break;
						case "eye":
							result.EyeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>();
							await ParseAsync(result.EyeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>, reader, outcome, locationPath + ".eye", cancellationToken); // 50
							break;
						case "sphere":
							result.SphereElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.SphereElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".sphere", cancellationToken); // 60
							break;
						case "cylinder":
							result.CylinderElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.CylinderElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".cylinder", cancellationToken); // 70
							break;
						case "axis":
							result.AxisElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.AxisElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".axis", cancellationToken); // 80
							break;
						case "prism":
							var newItem_prism = new Hl7.Fhir.Model.VisionPrescription.PrismComponent();
							await ParseAsync(newItem_prism, reader, outcome, locationPath + ".prism["+result.Prism.Count+"]", cancellationToken); // 90
							result.Prism.Add(newItem_prism);
							break;
						case "add":
							result.AddElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.AddElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".add", cancellationToken); // 100
							break;
						case "power":
							result.PowerElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PowerElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".power", cancellationToken); // 110
							break;
						case "backCurve":
							result.BackCurveElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.BackCurveElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".backCurve", cancellationToken); // 120
							break;
						case "diameter":
							result.DiameterElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DiameterElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".diameter", cancellationToken); // 130
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Duration as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".duration", cancellationToken); // 140
							break;
						case "color":
							result.ColorElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ColorElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".color", cancellationToken); // 150
							break;
						case "brand":
							result.BrandElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.BrandElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".brand", cancellationToken); // 160
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 170
							result.Note.Add(newItem_note);
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
