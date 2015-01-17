// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RemoteApp.Models.Collections;
using Microsoft.Azure.Management.RemoteApp.Responses.Collections;
using Microsoft.Azure.Management.RemoteApp.Responses.Common;

namespace Microsoft.Azure.Management.RemoteApp.Operations
{
    /// <summary>
    /// RemoteApp collection operations.
    /// </summary>
    public partial interface IRemoteAppServiceOperations
    {
        /// <summary>
        /// Creates a collection with the given details.
        /// </summary>
        /// <param name='populateOnly'>
        /// A flag denoting if the request is to populate the creation details
        /// of the collection or update and deploy (true for populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Details for the collection to be created.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> CreateAsync(bool populateOnly, ServiceCreationDetails collectionDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name='collectionId'>
        /// The collection id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> DeleteAsync(string collectionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the details for a given collection
        /// </summary>
        /// <param name='collectionId'>
        /// The collection id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        Task<GetServiceResult> GetAsync(string collectionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of all collection details for the subscription id
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        Task<GetServiceListResult> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a list of all regions where collection can be created for the
        /// subscription
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list of locations.
        /// </returns>
        Task<GetRegionListResult> RegionListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets a new information to the collection with given id.
        /// </summary>
        /// <param name='collectionId'>
        /// The collection id.
        /// </param>
        /// <param name='forceRedeploy'>
        /// A flag denoting if the request is to re-deploy the collection after
        /// it is updated.
        /// </param>
        /// <param name='populateOnly'>
        /// A flag denoting if the request is to populate the collection
        /// details(true for populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Details for the collection to be created.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> SetAsync(bool collectionId, bool forceRedeploy, bool populateOnly, ServiceCreationDetails collectionDetails, CancellationToken cancellationToken);
    }
}
