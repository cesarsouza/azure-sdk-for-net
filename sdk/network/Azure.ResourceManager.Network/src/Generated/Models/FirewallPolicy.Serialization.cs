// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(BasePolicy))
            {
                writer.WritePropertyName("basePolicy");
                writer.WriteObjectValue(BasePolicy);
            }
            if (Optional.IsDefined(ThreatIntelMode))
            {
                writer.WritePropertyName("threatIntelMode");
                writer.WriteStringValue(ThreatIntelMode.Value.ToString());
            }
            if (Optional.IsDefined(ThreatIntelWhitelist))
            {
                writer.WritePropertyName("threatIntelWhitelist");
                writer.WriteObjectValue(ThreatIntelWhitelist);
            }
            if (Optional.IsDefined(IntrusionSystemMode))
            {
                writer.WritePropertyName("intrusionSystemMode");
                writer.WriteStringValue(IntrusionSystemMode.Value.ToString());
            }
            if (Optional.IsDefined(TransportSecurity))
            {
                writer.WritePropertyName("transportSecurity");
                writer.WriteObjectValue(TransportSecurity);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FirewallPolicy DeserializeFirewallPolicy(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IReadOnlyList<SubResource>> ruleGroups = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<SubResource> basePolicy = default;
            Optional<IReadOnlyList<SubResource>> firewalls = default;
            Optional<IReadOnlyList<SubResource>> childPolicies = default;
            Optional<AzureFirewallThreatIntelMode> threatIntelMode = default;
            Optional<FirewallPolicyThreatIntelWhitelist> threatIntelWhitelist = default;
            Optional<FirewallPolicyIntrusionSystemMode> intrusionSystemMode = default;
            Optional<FirewallPolicyTransportSecurity> transportSecurity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = ManagedServiceIdentity.DeserializeManagedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ruleGroups"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            ruleGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("basePolicy"))
                        {
                            basePolicy = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("firewalls"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            firewalls = array;
                            continue;
                        }
                        if (property0.NameEquals("childPolicies"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            childPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("threatIntelMode"))
                        {
                            threatIntelMode = new AzureFirewallThreatIntelMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("threatIntelWhitelist"))
                        {
                            threatIntelWhitelist = FirewallPolicyThreatIntelWhitelist.DeserializeFirewallPolicyThreatIntelWhitelist(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("intrusionSystemMode"))
                        {
                            intrusionSystemMode = new FirewallPolicyIntrusionSystemMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("transportSecurity"))
                        {
                            transportSecurity = FirewallPolicyTransportSecurity.DeserializeFirewallPolicyTransportSecurity(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FirewallPolicy(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, identity.Value, Optional.ToList(ruleGroups), Optional.ToNullable(provisioningState), basePolicy.Value, Optional.ToList(firewalls), Optional.ToList(childPolicies), Optional.ToNullable(threatIntelMode), threatIntelWhitelist.Value, Optional.ToNullable(intrusionSystemMode), transportSecurity.Value);
        }
    }
}
