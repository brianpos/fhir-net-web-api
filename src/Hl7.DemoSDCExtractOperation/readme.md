|Demo SDC $expand function app|
|---|

## Introduction ##
This project provides a quick POC on how you could create an Azure Function App and use the FirelySDK to serialize the content correctly.
Specifically it handles the XML/JSON serializing the content in/out of the function through the content-type/accept headers and then
provides the object model to the class itself.

``` c#
        [Function("$extract")] // The api route to handle
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequestData req,
            FunctionContext context,
            [InputConverter(typeof(FhirInputConverter))] // this input converter is optional if you register the converter in your `WorkerOptions` during configuration
            Parameters resource)
        {
            // the `resource` will be converted from the body of the POST request
            var qr = resource.GetResource("questionnaire-response") as QuestionnaireResponse;

            // once you've done your logic and created your FHIR object to return, use this helper method to format the HttpResponseData
            return req.FormatFhirDataOutput(HttpStatusCode.OK, qr);
        }
```



## Background reading
https://docs.microsoft.com/en-us/azure/azure-functions/dotnet-isolated-process-guide?pivots=development-environment-vscode&tabs=browser
