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
using Microsoft.Azure.Management.RemoteApp.Operations;
using Microsoft.Azure.Management.RemoteApp.Responses.Collections;
using Microsoft.Azure.Management.RemoteApp.Responses.Common;

namespace Microsoft.Azure.Management.RemoteApp.Operations
{
    public static partial class RemoteAppServiceOperationsExtensions
    {
        /// <summary>
        /// Creates a collection with the given details.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='populateOnly'>
        /// Required. A flag denoting if the request is to populate the
        /// creation details of the collection or update and deploy (true for
        /// populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Required. Details for the collection to be created.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static OperationResultWithTrackingId Create(this IRemoteAppServiceOperations operations, bool populateOnly, ServiceCreationDetails collectionDetails)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRemoteAppServiceOperations)s).CreateAsync(populateOnly, collectionDetails);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a collection with the given details.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='populateOnly'>
        /// Required. A flag denoting if the request is to populate the
        /// creation details of the collection or update and deploy (true for
        /// populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Required. Details for the collection to be created.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static Task<OperationResultWithTrackingId> CreateAsync(this IRemoteAppServiceOperations operations, bool populateOnly, ServiceCreationDetails collectionDetails)
        {
            return operations.CreateAsync(populateOnly, collectionDetails, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. The collection id.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static OperationResultWithTrackingId Delete(this IRemoteAppServiceOperations operations, string collectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRemoteAppServiceOperations)s).DeleteAsync(collectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. The collection id.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static Task<OperationResultWithTrackingId> DeleteAsync(this IRemoteAppServiceOperations operations, string collectionId)
        {
            return operations.DeleteAsync(collectionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the details for a given collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. The collection id.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        public static GetServiceResult Get(this IRemoteAppServiceOperations operations, string collectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRemoteAppServiceOperations)s).GetAsync(collectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the details for a given collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. The collection id.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        public static Task<GetServiceResult> GetAsync(this IRemoteAppServiceOperations operations, string collectionId)
        {
            return operations.GetAsync(collectionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of all collection details for the subscription id
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        public static GetServiceListResult List(this IRemoteAppServiceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRemoteAppServiceOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of all collection details for the subscription id
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        public static Task<GetServiceListResult> ListAsync(this IRemoteAppServiceOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of all regions where collection can be created for the
        /// subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <returns>
        /// The list of locations.
        /// </returns>
        public static GetRegionListResult RegionList(this IRemoteAppServiceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRemoteAppServiceOperations)s).RegionListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of all regions where collection can be created for the
        /// subscription
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <returns>
        /// The list of locations.
        /// </returns>
        public static Task<GetRegionListResult> RegionListAsync(this IRemoteAppServiceOperations operations)
        {
            return operations.RegionListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Sets a new information to the collection with given id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. The collection id.
        /// </param>
        /// <param name='forceRedeploy'>
        /// Required. A flag denoting if the request is to re-deploy the
        /// collection after it is updated.
        /// </param>
        /// <param name='populateOnly'>
        /// Required. A flag denoting if the request is to populate the
        /// collection details(true for populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Required. Details for the collection to be created.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static OperationResultWithTrackingId Set(this IRemoteAppServiceOperations operations, bool collectionId, bool forceRedeploy, bool populateOnly, ServiceCreationDetails collectionDetails)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRemoteAppServiceOperations)s).SetAsync(collectionId, forceRedeploy, populateOnly, collectionDetails);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Sets a new information to the collection with given id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IRemoteAppServiceOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. The collection id.
        /// </param>
        /// <param name='forceRedeploy'>
        /// Required. A flag denoting if the request is to re-deploy the
        /// collection after it is updated.
        /// </param>
        /// <param name='populateOnly'>
        /// Required. A flag denoting if the request is to populate the
        /// collection details(true for populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Required. Details for the collection to be created.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static Task<OperationResultWithTrackingId> SetAsync(this IRemoteAppServiceOperations operations, bool collectionId, bool forceRedeploy, bool populateOnly, ServiceCreationDetails collectionDetails)
        {
            return operations.SetAsync(collectionId, forceRedeploy, populateOnly, collectionDetails, CancellationToken.None);
        }
    }
}
