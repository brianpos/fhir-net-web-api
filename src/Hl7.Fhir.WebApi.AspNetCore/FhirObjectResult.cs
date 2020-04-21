/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Mvc;

namespace Hl7.Fhir.NetCoreApi.R4
{
    public class FhirObjectResult : ObjectResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="resource">The resource that will be returned to the user (could be OperationOutcome due to prefer)</param>
        /// <param name="result">The real result of the request (such as the updated Patient resource)</param>
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
    }
}
