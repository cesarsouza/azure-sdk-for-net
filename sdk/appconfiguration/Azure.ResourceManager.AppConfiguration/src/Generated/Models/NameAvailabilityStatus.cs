// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The result of a request to check the availability of a resource name. </summary>
    public partial class NameAvailabilityStatus
    {
        /// <summary> Initializes a new instance of NameAvailabilityStatus. </summary>
        internal NameAvailabilityStatus()
        {
        }

        /// <summary> Initializes a new instance of NameAvailabilityStatus. </summary>
        /// <param name="nameAvailable"> The value indicating whether the resource name is available. </param>
        /// <param name="message"> If any, the error message that provides more detail for the reason that the name is not available. </param>
        /// <param name="reason"> If any, the reason that the name is not available. </param>
        internal NameAvailabilityStatus(bool? nameAvailable, string message, string reason)
        {
            NameAvailable = nameAvailable;
            Message = message;
            Reason = reason;
        }

        /// <summary> The value indicating whether the resource name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> If any, the error message that provides more detail for the reason that the name is not available. </summary>
        public string Message { get; }
        /// <summary> If any, the reason that the name is not available. </summary>
        public string Reason { get; }
    }
}
