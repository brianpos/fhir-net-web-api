using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using Hl7.Fhir.Utility;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using System.IO;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;

namespace Hl7.DemoFileSystemFhirServer
{
    public class AzureBlobStorageResourceService : Hl7.Fhir.WebApi.IFhirResourceServiceR4<IServiceProvider>
    {
        public AzureBlobStorageResourceService()
        {
            if (_container == null)
            {
                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse("UseDevelopmentStorage=true");

                // Create the blob client.
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

                // Retrieve reference to a previously created container.
                _containerName = "raw";
                _container = blobClient.GetContainerReference(_containerName);
                _container.CreateIfNotExistsAsync();
            }
        }

        static CloudBlobContainer _container;
        static string _containerName;
        static FhirJsonSerializer serializer = new FhirJsonSerializer();

        public ModelBaseInputs<IServiceProvider> RequestDetails { get; set; }

        public string ResourceName { get; set; }

        string FileName(string Id)
        {
            return $"{ResourceName}-{Id}.json";
        }

        public async Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince)
        {
            if (String.IsNullOrEmpty(resource.Id))
                resource.Id = Guid.NewGuid().ToFhirId();
            if (resource.Meta == null)
                resource.Meta = new Meta();
            resource.Meta.LastUpdated = DateTime.Now;
            var dirRef = _container.GetDirectoryReference(_containerName);
            var blob = dirRef.GetBlockBlobReference(FileName(resource.Id));
            using (Stream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    using (JsonWriter jsonwriter = SerializationUtil.CreateJsonTextWriter(writer)) // This will use the BetterJsonWriter which handles precision correctly
                    {
                        serializer.Serialize(resource, jsonwriter);
                        stream.Seek(0, SeekOrigin.Begin);
                        await blob.UploadFromStreamAsync(stream);
                        resource.SetAnnotation<CreateOrUpate>(CreateOrUpate.Create);
                    }
                }
            }
            return resource;
        }

        public async Task<string> Delete(string id, string ifMatch)
        {
            var dirRef = _container.GetDirectoryReference(_containerName);
            var blob = dirRef.GetBlobReference(FileName(id));
            if (await blob.ExistsAsync())
                await blob.DeleteAsync();

            return null;
        }

        public async Task<Resource> Get(string resourceId, string VersionId, SummaryType summary)
        {
            var dirRef = _container.GetDirectoryReference(_containerName);
            var blob = dirRef.GetBlobReference(FileName(resourceId));
            if (!await blob.ExistsAsync())
                throw new FhirServerException(System.Net.HttpStatusCode.Gone, "It might have been deleted!");

            var stream = await blob.OpenReadAsync();
            var reader = SerializationUtil.JsonReaderFromStream(stream);
            return new Fhir.Serialization.FhirJsonParser().Parse<Resource>(reader);
        }

        public Task<CapabilityStatement.ResourceComponent> GetRestResourceComponent()
        {
            throw new NotImplementedException();
        }

        public Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Resource> PerformOperation(string operation, Parameters operationParameters, SummaryType summary)
        {
            if (operation == "count-em")
            {
                var result = new OperationOutcome();
                result.Issue.Add(new OperationOutcome.IssueComponent()
                {
                    Code = OperationOutcome.IssueType.Informational,
                    Severity = OperationOutcome.IssueSeverity.Information,
                    Details = new CodeableConcept(null, null, $"{ResourceName} resource instances: {System.IO.Directory.EnumerateFiles(AzureBlobStorageSystemService.Directory, $"{ResourceName}.*.xml").Count()}")
                });
                return System.Threading.Tasks.Task.FromResult<Resource>(result);
            }

            throw new NotImplementedException();
        }

        public Task<Resource> PerformOperation(string id, string operation, Parameters operationParameters, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
            //Bundle result = new Bundle();
            //result.Meta = new Meta();
            //result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            //result.Type = Bundle.BundleType.Searchset;
            //result.ResourceBase = RequestDetails.BaseUri;

            // Check that the Last Update value is correctly entered and that the count is at least as big as the data included
            // and update the links
            // result.ProcessLastModifiedFromEntriesAndLinks(Request.RequestUri, pagesize, pagenumber, snapshotID);
        }

        public Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            Bundle result = new Bundle();
            result.Meta = new Meta()
            {
                LastUpdated = DateTime.Now
            };
            result.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToString("n")).OriginalString;
            result.Type = Bundle.BundleType.History;

            var parser = new Fhir.Serialization.FhirXmlParser();
            var files = System.IO.Directory.EnumerateFiles(AzureBlobStorageSystemService.Directory, $"{ResourceName}.*.xml");
            foreach (var filename in files)
            {
                var resource = parser.Parse<Resource>(System.IO.File.ReadAllText(filename));
                result.AddResourceEntry(resource,
                    ResourceIdentity.Build(RequestDetails.BaseUri,
                        resource.ResourceType.ToString(),
                        resource.Id,
                        resource.Meta.VersionId).OriginalString);
            }
            result.Total = result.Entry.Count;

            // also need to set the page links

            return System.Threading.Tasks.Task.FromResult(result);
        }
    }
}
