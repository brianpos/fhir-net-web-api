﻿/* 
 * Copyright (c) 2017+ brianpos, Firely and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hl7.Fhir.WebApi
{
    /// <summary>
    /// Implementations of this interface may cover only a specific resource type
    /// </summary>
    /// <typeparam name="TSP">The Dependency Injector class - IServiceProvider for aspnetcore and IDependencyResolver for webapi</typeparam>
    public interface IFhirResourceServiceR4<TSP>
    {
        /// <summary>
        /// Implementations of this interface process this resource name
        /// </summary>
        string ResourceName { get; }

        ModelBaseInputs<TSP> RequestDetails { get; }

        /// <summary>
        /// generate the rest resource component for this specific resource type
        /// </summary>
        /// <returns></returns>
        Task<CapabilityStatement.ResourceComponent> GetRestResourceComponent();

        /// <summary>
        /// Create/Update this resource (create when no Resource.Id is provided, update when it is)
        /// When creating a new resource, must set the resource.UserData["Created"] = true;
        /// (otherwise set it to false - for when a new version of an existing resource is created)
        /// </summary>
        /// <remarks>The controller will validate if the PUT/POST has the correct values, and is also used in the batch operations</remarks>
        /// <param name="resource"></param>
        /// <param name="ifMatch"></param>
        /// <param name="ifNoneExist"></param>
        /// <param name="ifModifiedSince"></param>
        /// <returns></returns>
        Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince);

        /// <summary>
        /// Retrieve the resource with the provided resourceId/versionId
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="VersionId">If this parameter is null/empty, then the latest version of the resource should be retrieved</param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Resource> Get(string resourceId, string VersionId, Rest.SummaryType summary);

        /// <summary>
        /// Delete the provided Resource Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ifMatch"></param>
        /// <returns>Returns the ResourceIdentity of the resource (the deletion version)</returns>
        Task<string> Delete(string id, string ifMatch);

        /// <summary>
        /// Retrieve the history items across all instances of this resource type
        /// </summary>
        /// <param name="since"></param>
        /// <param name="Till"></param>
        /// <param name="Count"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, Rest.SummaryType summary);

        /// <summary>
        /// Retrieve the history items for the specific resource Id
        /// </summary>
        /// <param name="ResourceId"></param>
        /// <param name="since"></param>
        /// <param name="Till"></param>
        /// <param name="Count"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, Hl7.Fhir.Rest.SummaryType summary);

        /// <summary>
        /// Perform a search based on the provided search parameters
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="Count"></param>
        /// <param name="summary"></param>
        /// <param name="sortby"></param>
        /// <returns></returns>
        Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, Rest.SummaryType summary, string sortby);

        /// <summary>
        /// Perform a Resource Instance based Operation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="operation"></param>
        /// <param name="operationParameters"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Resource> PerformOperation(string id, string operation, Parameters operationParameters, Rest.SummaryType summary);

        /// <summary>
        /// Perform a Resource Type based operation
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="operationParameters"></param>
        /// <param name="summary"></param>
        /// <returns></returns>
        Task<Resource> PerformOperation(string operation, Parameters operationParameters, Rest.SummaryType summary);
    }
}
