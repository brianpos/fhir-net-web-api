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
		public void Parse(Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 60
							break;
						case "material":
							var newItem_material = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_material, reader, outcome, locationPath + ".material["+result.Material.Count+"]", cancellationToken); // 70
							result.Material.Add(newItem_material);
							break;
						case "alternateMaterial":
							var newItem_alternateMaterial = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_alternateMaterial, reader, outcome, locationPath + ".alternateMaterial["+result.AlternateMaterial.Count+"]", cancellationToken); // 80
							result.AlternateMaterial.Add(newItem_alternateMaterial);
							break;
						case "device":
							var newItem_device = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_device, reader, outcome, locationPath + ".device["+result.Device.Count+"]", cancellationToken); // 90
							result.Device.Add(newItem_device);
							break;
						case "manufacturedItem":
							var newItem_manufacturedItem = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturedItem, reader, outcome, locationPath + ".manufacturedItem["+result.ManufacturedItem.Count+"]", cancellationToken); // 100
							result.ManufacturedItem.Add(newItem_manufacturedItem);
							break;
						case "packageItem":
							var newItem_packageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
							Parse(newItem_packageItem, reader, outcome, locationPath + ".packageItem["+result.PackageItem.Count+"]", cancellationToken); // 110
							result.PackageItem.Add(newItem_packageItem);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							Parse(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome, locationPath + ".physicalCharacteristics", cancellationToken); // 120
							break;
						case "otherCharacteristics":
							var newItem_otherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_otherCharacteristics, reader, outcome, locationPath + ".otherCharacteristics["+result.OtherCharacteristics.Count+"]", cancellationToken); // 130
							result.OtherCharacteristics.Add(newItem_otherCharacteristics);
							break;
						case "shelfLifeStorage":
							var newItem_shelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
							Parse(newItem_shelfLifeStorage, reader, outcome, locationPath + ".shelfLifeStorage["+result.ShelfLifeStorage.Count+"]", cancellationToken); // 140
							result.ShelfLifeStorage.Add(newItem_shelfLifeStorage);
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 150
							result.Manufacturer.Add(newItem_manufacturer);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 40
							result.Identifier.Add(newItem_identifier);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 60
							break;
						case "material":
							var newItem_material = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_material, reader, outcome, locationPath + ".material["+result.Material.Count+"]", cancellationToken); // 70
							result.Material.Add(newItem_material);
							break;
						case "alternateMaterial":
							var newItem_alternateMaterial = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_alternateMaterial, reader, outcome, locationPath + ".alternateMaterial["+result.AlternateMaterial.Count+"]", cancellationToken); // 80
							result.AlternateMaterial.Add(newItem_alternateMaterial);
							break;
						case "device":
							var newItem_device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_device, reader, outcome, locationPath + ".device["+result.Device.Count+"]", cancellationToken); // 90
							result.Device.Add(newItem_device);
							break;
						case "manufacturedItem":
							var newItem_manufacturedItem = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturedItem, reader, outcome, locationPath + ".manufacturedItem["+result.ManufacturedItem.Count+"]", cancellationToken); // 100
							result.ManufacturedItem.Add(newItem_manufacturedItem);
							break;
						case "packageItem":
							var newItem_packageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
							await ParseAsync(newItem_packageItem, reader, outcome, locationPath + ".packageItem["+result.PackageItem.Count+"]", cancellationToken); // 110
							result.PackageItem.Add(newItem_packageItem);
							break;
						case "physicalCharacteristics":
							result.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
							await ParseAsync(result.PhysicalCharacteristics as Hl7.Fhir.Model.ProdCharacteristic, reader, outcome, locationPath + ".physicalCharacteristics", cancellationToken); // 120
							break;
						case "otherCharacteristics":
							var newItem_otherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_otherCharacteristics, reader, outcome, locationPath + ".otherCharacteristics["+result.OtherCharacteristics.Count+"]", cancellationToken); // 130
							result.OtherCharacteristics.Add(newItem_otherCharacteristics);
							break;
						case "shelfLifeStorage":
							var newItem_shelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
							await ParseAsync(newItem_shelfLifeStorage, reader, outcome, locationPath + ".shelfLifeStorage["+result.ShelfLifeStorage.Count+"]", cancellationToken); // 140
							result.ShelfLifeStorage.Add(newItem_shelfLifeStorage);
							break;
						case "manufacturer":
							var newItem_manufacturer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_manufacturer, reader, outcome, locationPath + ".manufacturer["+result.Manufacturer.Count+"]", cancellationToken); // 150
							result.Manufacturer.Add(newItem_manufacturer);
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
