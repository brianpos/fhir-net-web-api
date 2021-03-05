using Hl7.Fhir.Model;
using System;

namespace Hl7.Fhir.Rest
{
    public interface IFhirHttpClient
    {
        System.Threading.Tasks.Task<TResource> UpdateAsync<TResource>(TResource resource) where TResource : Resource;
        System.Threading.Tasks.Task DeleteAsync(Resource resource);
        System.Threading.Tasks.Task DeleteAsync(string location);
        System.Threading.Tasks.Task<TResource> CreateAsync<TResource>(TResource resource) where TResource : Resource;
        System.Threading.Tasks.Task<TResource> ReadAsync<TResource>(string resourceId) where TResource : Resource;
        System.Threading.Tasks.Task<Bundle> SearchAsync<TResource>(string[] searchParameters = null) where TResource : Resource;
        System.Threading.Tasks.Task<Bundle> SearchAsync<TResource>(SearchParams searchParameters) where TResource : Resource;
        System.Threading.Tasks.Task<Bundle> ContinueAsync(Bundle current, PageDirection direction = PageDirection.Next);
        System.Threading.Tasks.Task<CapabilityStatement> CapabilityStatementAsync(SummaryType? summary = null);
        System.Threading.Tasks.Task<Resource> InstanceOperationAsync(Uri location, string operationName, Parameters parameters = null, bool useGet = false);
    }
}