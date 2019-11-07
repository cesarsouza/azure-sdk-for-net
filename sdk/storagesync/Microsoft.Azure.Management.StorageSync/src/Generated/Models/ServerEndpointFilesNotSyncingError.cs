// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Files not syncing error object
    /// </summary>
    public partial class ServerEndpointFilesNotSyncingError
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ServerEndpointFilesNotSyncingError class.
        /// </summary>
        public ServerEndpointFilesNotSyncingError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ServerEndpointFilesNotSyncingError class.
        /// </summary>
        /// <param name="errorCode">Error code (HResult)</param>
        /// <param name="persistentCount">Count of persistent files not syncing
        /// with the specified error code</param>
        /// <param name="transientCount">Count of transient files not syncing
        /// with the specified error code</param>
        public ServerEndpointFilesNotSyncingError(int? errorCode = default(int?), long? persistentCount = default(long?), long? transientCount = default(long?))
        {
            ErrorCode = errorCode;
            PersistentCount = persistentCount;
            TransientCount = transientCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error code (HResult)
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// Gets count of persistent files not syncing with the specified error
        /// code
        /// </summary>
        [JsonProperty(PropertyName = "persistentCount")]
        public long? PersistentCount { get; private set; }

        /// <summary>
        /// Gets count of transient files not syncing with the specified error
        /// code
        /// </summary>
        [JsonProperty(PropertyName = "transientCount")]
        public long? TransientCount { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PersistentCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PersistentCount", 0);
            }
            if (TransientCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TransientCount", 0);
            }
        }
    }
}