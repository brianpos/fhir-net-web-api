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
		public void Parse(Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "product":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "eye":
							result.EyeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>();
							Parse(result.EyeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>, reader, outcome); // 50
							break;
						case "sphere":
							result.SphereElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.SphereElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 60
							break;
						case "cylinder":
							result.CylinderElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.CylinderElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 70
							break;
						case "axis":
							result.AxisElement = new Hl7.Fhir.Model.Integer();
							Parse(result.AxisElement as Hl7.Fhir.Model.Integer, reader, outcome); // 80
							break;
						case "prism":
							var newItem_prism = new Hl7.Fhir.Model.VisionPrescription.PrismComponent();
							Parse(newItem_prism, reader, outcome); // 90
							result.Prism.Add(newItem_prism);
							break;
						case "add":
							result.AddElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.AddElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 100
							break;
						case "power":
							result.PowerElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PowerElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 110
							break;
						case "backCurve":
							result.BackCurveElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.BackCurveElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 120
							break;
						case "diameter":
							result.DiameterElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.DiameterElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 130
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.SimpleQuantity();
							Parse(result.Duration as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 140
							break;
						case "color":
							result.ColorElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ColorElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "brand":
							result.BrandElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.BrandElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 170
							result.Note.Add(newItem_note);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.VisionPrescription.LensSpecificationComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "product":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "eye":
							result.EyeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>();
							await ParseAsync(result.EyeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.VisionPrescription.VisionEyes>, reader, outcome); // 50
							break;
						case "sphere":
							result.SphereElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.SphereElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 60
							break;
						case "cylinder":
							result.CylinderElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.CylinderElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 70
							break;
						case "axis":
							result.AxisElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.AxisElement as Hl7.Fhir.Model.Integer, reader, outcome); // 80
							break;
						case "prism":
							var newItem_prism = new Hl7.Fhir.Model.VisionPrescription.PrismComponent();
							await ParseAsync(newItem_prism, reader, outcome); // 90
							result.Prism.Add(newItem_prism);
							break;
						case "add":
							result.AddElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.AddElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 100
							break;
						case "power":
							result.PowerElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PowerElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 110
							break;
						case "backCurve":
							result.BackCurveElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.BackCurveElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 120
							break;
						case "diameter":
							result.DiameterElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.DiameterElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome); // 130
							break;
						case "duration":
							result.Duration = new Hl7.Fhir.Model.SimpleQuantity();
							await ParseAsync(result.Duration as Hl7.Fhir.Model.SimpleQuantity, reader, outcome); // 140
							break;
						case "color":
							result.ColorElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ColorElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "brand":
							result.BrandElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.BrandElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 160
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 170
							result.Note.Add(newItem_note);
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
