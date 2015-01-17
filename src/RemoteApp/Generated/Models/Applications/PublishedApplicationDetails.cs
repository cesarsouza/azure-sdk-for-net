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
using Microsoft.Azure.Management.RemoteApp.Models.Applications;

namespace Microsoft.Azure.Management.RemoteApp.Models.Applications
{
    /// <summary>
    /// Publishing details of remote application.
    /// </summary>
    public partial class PublishedApplicationDetails
    {
        private string _alias;
        
        /// <summary>
        /// Optional. A short unique name for the application.
        /// </summary>
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }
        
        private bool _availableToUsers;
        
        /// <summary>
        /// Optional. A flag to denote if the application will be available to
        /// the end user.
        /// </summary>
        public bool AvailableToUsers
        {
            get { return this._availableToUsers; }
            set { this._availableToUsers = value; }
        }
        
        private string _commandLineArguments;
        
        /// <summary>
        /// Optional. The command line arguments to launch the application.
        /// </summary>
        public string CommandLineArguments
        {
            get { return this._commandLineArguments; }
            set { this._commandLineArguments = value; }
        }
        
        private IconPngUrisType _iconPngUris;
        
        /// <summary>
        /// Optional. The available map of icon PNG file URIs for different
        /// resolutions (e.g. 16x16, 32x32, 64x64). The key of the map is the
        /// first dimension of the PNG resolution.
        /// </summary>
        public IconPngUrisType IconPngUris
        {
            get { return this._iconPngUris; }
            set { this._iconPngUris = value; }
        }
        
        private string _iconUri;
        
        /// <summary>
        /// Optional. The URI for the application's default icon PNG file.
        /// </summary>
        public string IconUri
        {
            get { return this._iconUri; }
            set { this._iconUri = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. The application name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _remoteAppServiceId;
        
        /// <summary>
        /// Required. The associated RemoteApp collection id.
        /// </summary>
        public string RemoteAppServiceId
        {
            get { return this._remoteAppServiceId; }
            set { this._remoteAppServiceId = value; }
        }
        
        private AppPublishingStatus _status;
        
        /// <summary>
        /// Optional. The application status.
        /// </summary>
        public AppPublishingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. The customer subscription id.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        private string _virtualPath;
        
        /// <summary>
        /// Optional. The application image path on the destination machine
        /// specified with environment variables for the drive and known
        /// system path.
        /// </summary>
        public string VirtualPath
        {
            get { return this._virtualPath; }
            set { this._virtualPath = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PublishedApplicationDetails class.
        /// </summary>
        public PublishedApplicationDetails()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PublishedApplicationDetails class
        /// with required arguments.
        /// </summary>
        public PublishedApplicationDetails(string name, string remoteAppServiceId)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (remoteAppServiceId == null)
            {
                throw new ArgumentNullException("remoteAppServiceId");
            }
            this.Name = name;
            this.RemoteAppServiceId = remoteAppServiceId;
        }
    }
}
