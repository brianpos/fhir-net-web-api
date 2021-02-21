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
		public void Parse(Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 60
							break;
						case "material":
							var newItem_material = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_material, reader, outcome); // 70
							result.Material.Add(newItem_material);
							break;
						case "alternateMaterial":
							var newItem_alternateMaterial = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_alternateMaterial, reader, outcome); // 80
							result.AlternateMaterial.Add(newItem_alternateMaterial);
							break;
						case "device":
							var newItem_device = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_device, reader, outcome); // 90
							result.Device.Add(newItem_device);
							break;
						case "manufacturedItem":
							var newItem_manufacturedItem = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturedItem, reader, outcome); // 100
							result.ManufacturedItem.Add(newItem_manufacturedItem);
							break;
						case "packageItem":
							var newItem_packageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
							Parse(newItem_packageItem, reader, outcome); // 110
							result.PackageItem.Add(newItem_packageItem);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							Parse(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome); // 120
							break;
						case "otherCharacteristics":
							var newItem_otherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_otherCharacteristics, reader, outcome); // 130
							result.OtherCharacteristics.Add(newItem_otherCharacteristics);
							break;
						case "shelfLifeStorage":
							var newItem_shelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
							Parse(newItem_shelfLifeStorage, reader, outcome); // 140
							result.ShelfLifeStorage.Add(newItem_shelfLifeStorage);
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome); // 150
							result.Manufacturer.Add(newItem_manufacturer);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome); // 60
							break;
						case "material":
							var newItem_material = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_material, reader, outcome); // 70
							result.Material.Add(newItem_material);
							break;
						case "alternateMaterial":
							var newItem_alternateMaterial = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_alternateMaterial, reader, outcome); // 80
							result.AlternateMaterial.Add(newItem_alternateMaterial);
							break;
						case "device":
							var newItem_device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_device, reader, outcome); // 90
							result.Device.Add(newItem_device);
							break;
						case "manufacturedItem":
							var newItem_manufacturedItem = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturedItem, reader, outcome); // 100
							result.ManufacturedItem.Add(newItem_manufacturedItem);
							break;
						case "packageItem":
							var newItem_packageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
							await ParseAsync(newItem_packageItem, reader, outcome); // 110
							result.PackageItem.Add(newItem_packageItem);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							await ParseAsync(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome); // 120
							break;
						case "otherCharacteristics":
							var newItem_otherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_otherCharacteristics, reader, outcome); // 130
							result.OtherCharacteristics.Add(newItem_otherCharacteristics);
							break;
						case "shelfLifeStorage":
							var newItem_shelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
							await ParseAsync(newItem_shelfLifeStorage, reader, outcome); // 140
							result.ShelfLifeStorage.Add(newItem_shelfLifeStorage);
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome); // 150
							result.Manufacturer.Add(newItem_manufacturer);
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
