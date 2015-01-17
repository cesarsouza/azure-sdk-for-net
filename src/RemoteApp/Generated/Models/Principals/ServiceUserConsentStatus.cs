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
using Microsoft.Azure.Management.RemoteApp.Models.Principals;

namespace Microsoft.Azure.Management.RemoteApp.Models.Principals
{
    /// <summary>
    /// The collection user consent status information.
    /// </summary>
    public partial class ServiceUserConsentStatus
    {
        private SecurityPrincipal _securityPrincipal;
        
        /// <summary>
        /// Optional. The security principal information.
        /// </summary>
        public SecurityPrincipal SecurityPrincipal
        {
            get { return this._securityPrincipal; }
            set { this._securityPrincipal = value; }
        }
        
        private ConsentStatus _status;
        
        /// <summary>
        /// Optional. The user consent status.
        /// </summary>
        public ConsentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceUserConsentStatus class.
        /// </summary>
        public ServiceUserConsentStatus()
        {
        }
    }
}
