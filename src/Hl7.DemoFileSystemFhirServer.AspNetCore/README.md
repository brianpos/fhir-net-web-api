
## Introduction ##
This is a demonstration server showing how to implement a FHIR Facade with aspnetcore,
All content is configured through the use of a file folder

It is not intended to be a production solution, but can illustrate execute the 
FHIR operations that could express what the existing API is doing.

Existing features:
* Patient API
  * Create, Read and delete individual resource
  * Custom Operation `"count-em"` that returns the number of resource instances in an operation outcome
* WholeSystem API
  * Custom Operation `"count-em"` that returns the number of all resource instances in an operation outcome
  * Whole system history operation (with no ordering)

Technically the utility is:
* built on the Microsoft .NET (dotnetcore) platform
* uses the HL7 FHIR reference assemblies
  * *Core* (NuGet packages starting with `Hl7.Fhir.STU3`) - contains the FhirClient and parsers
  * *Specification* (NuGet packages starting with `Hl7.Fhir.Specification.STU3`) - contains the FHIR Validator
  * *FhirPath* (NuGet package `Hl7.FhirPath`) - the FhirPath evaluator, used by the Core and Specification assemblies
  * *Support* (NuGet package `Hl7.Fhir.Support`) - a library with interfaces, abstractions and utility methods that are used by the other packages

## Search ##
No searchThe search will return a Provenance resource for each resource returned from the search,
and an OperationOutcome giving a summary of each members contribution to the results (or error details)

## Licensing and Copyright
All work in this demonstration belongs to brianpos and is available under the BSD 3-clause license, and is only intended for demonstration purposes
HL7®, FHIR® and the FHIR Mark® are trademarks owned by Health Level Seven International, 
registered with the United States Patent and Trademark Office.
