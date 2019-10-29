/* 
 * Copyright (c) 2017+ brianpos, Furore and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// Implementations of this interface cover the system scope of the FHIR Server
    /// </summary>
    /// <typeparam name="TSP">The Dependency Injector class - IServiceProvider for aspnetcore and IDependencyResolver for webapi</typeparam>
    public interface IFhirSystemServiceR4<TSP>
    {
        /// <summary>
        /// Retrieve the CapabilityStatement resource applicable for this server
        /// (was Conformance in DSTU2)
        /// </summary>
        /// <returns></returns>
        Task<CapabilityStatement> GetConformance(ModelBaseInputs<TSP> request, Rest.SummaryType summary);

        /// <summary>
        /// Retrieve a ResourceService processor for the provided resource type
        /// </summary>
        /// <param name="request"></param>
        /// <param name="resourceName"></param>
        /// <returns></returns>
        IFhirResourceServiceR4<TSP> GetResourceService(ModelBaseInputs<TSP> request, string resourceName);

        /// <summary>
        /// Process the bundle passed in (could be a batch or a transaction)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="bundle"></param>
        /// <returns>the matching bundle with the results of the request</returns>
        Task<Bundle> ProcessBatch(ModelBaseInputs<TSP> request, Bundle bundle);

        /// <summary>
        /// Retrieve the system history for the request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="since"></param>
        /// <param name="Till"></param>
        /// <param name="Count"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Bundle> SystemHistory(ModelBaseInputs<TSP> request, DateTimeOffset? since, DateTimeOffset? Till, int? Count, Rest.SummaryType summary);

        /// <summary>
        /// Perform the FHIR operation on the whole system (not a resource type/instance specific operation)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="operation"></param>
        /// <param name="operationParameters"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Resource> PerformOperation(ModelBaseInputs<TSP> request, string operation, Parameters operationParameters, Rest.SummaryType summary);

        /// <summary>
        /// Search the entire server (not a resource type/instance specific operation)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="parameters"></param>
        /// <param name="Count"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Bundle> Search(ModelBaseInputs<TSP> request, IEnumerable<KeyValuePair<string, string>> parameters, int? Count, Rest.SummaryType summary);
    }
}
