
## Introduction ##
This is a demonstration server showing how to integrate Terminology Services with a FHIR Facade/Server
The storage layer is using a slightly modified version of the Microsoft FHIR Server (SQL Server)

It is not intended to be a production solution, but can illustrate execute the 
FHIR operations that could express what the existing API is doing.

Existing features:
* Search API
  * Token based search - specifically the :below modifier
  * GET resources
  * Instance History (last n versions - default 20)
  * Type History (last n versions - default 20)
  * Custom operation `$update-closure` - adds a specified `system` + `code` to a closure table in the `name` parameter
  * Custom operation `$reset-closure` - resets the closure table in the `name` parameter

* WholeSystem API
  * System History (last n versions - default 20)

Technically the utility is:
* built on the Microsoft .NET (dotnetcore) platform
* uses the HL7 FHIR reference assemblies
  * *Core* (NuGet packages starting with `Hl7.Fhir.R3`) - contains the FhirClient and parsers

## Search ##



## Licensing and Copyright
All work in this demonstration belongs to brianpos and is available under the BSD 3-clause license, and is only intended for demonstration purposes
HL7®, FHIR® and the FHIR Mark® are trademarks owned by Health Level Seven International, 
registered with the United States Patent and Trademark Office.
