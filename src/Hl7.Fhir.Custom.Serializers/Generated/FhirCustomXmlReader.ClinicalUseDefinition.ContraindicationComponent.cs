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
		public void Parse(Hl7.Fhir.Model.ClinicalUseDefinition.ContraindicationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "diseaseSymptomProcedure":
							result.DiseaseSymptomProcedure = new Hl7.Fhir.Model.CodeableReference();
							Parse(result.DiseaseSymptomProcedure as Hl7.Fhir.Model.CodeableReference, reader, outcome, locationPath + ".diseaseSymptomProcedure", cancellationToken); // 40
							break;
						case "diseaseStatus":
							result.DiseaseStatus = new Hl7.Fhir.Model.CodeableReference();
							Parse(result.DiseaseStatus as Hl7.Fhir.Model.CodeableReference, reader, outcome, locationPath + ".diseaseStatus", cancellationToken); // 50
							break;
						case "comorbidity":
							var newItem_comorbidity = new Hl7.Fhir.Model.CodeableReference();
							Parse(newItem_comorbidity, reader, outcome, locationPath + ".comorbidity["+result.Comorbidity.Count+"]", cancellationToken); // 60
							result.Comorbidity.Add(newItem_comorbidity);
							break;
						case "indication":
							var newItem_indication = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_indication, reader, outcome, locationPath + ".indication["+result.Indication.Count+"]", cancellationToken); // 70
							result.Indication.Add(newItem_indication);
							break;
						case "otherTherapy":
							var newItem_otherTherapy = new Hl7.Fhir.Model.ClinicalUseDefinition.OtherTherapyComponent();
							Parse(newItem_otherTherapy, reader, outcome, locationPath + ".otherTherapy["+result.OtherTherapy.Count+"]", cancellationToken); // 80
							result.OtherTherapy.Add(newItem_otherTherapy);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ClinicalUseDefinition.ContraindicationComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "diseaseSymptomProcedure":
							result.DiseaseSymptomProcedure = new Hl7.Fhir.Model.CodeableReference();
							await ParseAsync(result.DiseaseSymptomProcedure as Hl7.Fhir.Model.CodeableReference, reader, outcome, locationPath + ".diseaseSymptomProcedure", cancellationToken); // 40
							break;
						case "diseaseStatus":
							result.DiseaseStatus = new Hl7.Fhir.Model.CodeableReference();
							await ParseAsync(result.DiseaseStatus as Hl7.Fhir.Model.CodeableReference, reader, outcome, locationPath + ".diseaseStatus", cancellationToken); // 50
							break;
						case "comorbidity":
							var newItem_comorbidity = new Hl7.Fhir.Model.CodeableReference();
							await ParseAsync(newItem_comorbidity, reader, outcome, locationPath + ".comorbidity["+result.Comorbidity.Count+"]", cancellationToken); // 60
							result.Comorbidity.Add(newItem_comorbidity);
							break;
						case "indication":
							var newItem_indication = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_indication, reader, outcome, locationPath + ".indication["+result.Indication.Count+"]", cancellationToken); // 70
							result.Indication.Add(newItem_indication);
							break;
						case "otherTherapy":
							var newItem_otherTherapy = new Hl7.Fhir.Model.ClinicalUseDefinition.OtherTherapyComponent();
							await ParseAsync(newItem_otherTherapy, reader, outcome, locationPath + ".otherTherapy["+result.OtherTherapy.Count+"]", cancellationToken); // 80
							result.OtherTherapy.Add(newItem_otherTherapy);
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
