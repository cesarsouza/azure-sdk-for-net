// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class Desired
    {
        internal static Desired DeserializeDesired(JsonElement element)
        {
            object value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetObject();
                    continue;
                }
            }
            return new Desired(value);
        }
    }
}