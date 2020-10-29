using Hl7.Fhir.Model;

namespace Hl7.Fhir.Rest
{
    public interface IFhirHttpClient
    {
        System.Threading.Tasks.Task<TResource> UpdateAsync<TResource>(TResource resource) where TResource : Resource;
        System.Threading.Tasks.Task DeleteAsync(Resource resource);
        System.Threading.Tasks.Task DeleteAsync(string location);
        System.Threading.Tasks.Task<TResource> CreateAsync<TResource>(TResource resource) where TResource : Resource;
        System.Threading.Tasks.Task<TResource> ReadAsync<TResource>(string resourceId) where TResource : Resource;
        System.Threading.Tasks.Task<Bundle> SearchAsync<TResource>(string[] searchParameters) where TResource : Resource;
    }
}