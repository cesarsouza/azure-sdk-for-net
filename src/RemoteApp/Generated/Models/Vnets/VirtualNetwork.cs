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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.RemoteApp.Models.Vnets;

namespace Microsoft.Azure.Management.RemoteApp.Models.Vnets
{
    /// <summary>
    /// Properties of the virtual network.
    /// </summary>
    public partial class VirtualNetwork
    {
        private IList<string> _dnsServers;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }
        
        private string _gatewayIp;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string GatewayIp
        {
            get { return this._gatewayIp; }
            set { this._gatewayIp = value; }
        }
        
        private string _gatewaySubnet;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string GatewaySubnet
        {
            get { return this._gatewaySubnet; }
            set { this._gatewaySubnet = value; }
        }
        
        private GatewayType _gatewayType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public GatewayType GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }
        
        private IList<string> _localAddressSpaces;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> LocalAddressSpaces
        {
            get { return this._localAddressSpaces; }
            set { this._localAddressSpaces = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _serviceName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }
        
        private string _sharedKey;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string SharedKey
        {
            get { return this._sharedKey; }
            set { this._sharedKey = value; }
        }
        
        private VirtualNetworkState _state;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public VirtualNetworkState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _stateInfo;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string StateInfo
        {
            get { return this._stateInfo; }
            set { this._stateInfo = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        private bool _upgradeInProgress;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool UpgradeInProgress
        {
            get { return this._upgradeInProgress; }
            set { this._upgradeInProgress = value; }
        }
        
        private string _virtualNetworkId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VirtualNetworkId
        {
            get { return this._virtualNetworkId; }
            set { this._virtualNetworkId = value; }
        }
        
        private IList<string> _vnetAddressSpaces;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> VnetAddressSpaces
        {
            get { return this._vnetAddressSpaces; }
            set { this._vnetAddressSpaces = value; }
        }
        
        private string _vpnAddress;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VpnAddress
        {
            get { return this._vpnAddress; }
            set { this._vpnAddress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork()
        {
            this.DnsServers = new LazyList<string>();
            this.LocalAddressSpaces = new LazyList<string>();
            this.VnetAddressSpaces = new LazyList<string>();
        }
    }
}
