using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hl7.Fhir.NetCoreApi.STU3
{
    public class FhirObjectResult : ObjectResult
    {
        public FhirObjectResult(System.Net.HttpStatusCode status, Resource resource, Resource result)
            : base(resource)
        {
            _result = result;
            base.StatusCode = (int)status;
        }

        public FhirObjectResult(System.Net.HttpStatusCode status, Resource resource)
            : base(resource)
        {
            _result = resource;
            base.StatusCode = (int)status;
        }

        public static FhirObjectResult FhirDeletedResult(string deletedVersionId = null)
        {
            return new FhirObjectResult(System.Net.HttpStatusCode.NoContent, null) { _deletedVersionId  = deletedVersionId };
        }

        private string _deletedVersionId;
        private Resource _result;
        public Resource Result { get { return _result; } }
        public string DeletedVersionId { get { return _deletedVersionId; } }

        public override void OnFormatting(ActionContext context)
        {
            // we can control the formatter to be selected here!
            base.OnFormatting(context);
        }
    }
}
