// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SparkConfigurationListResponse
    {
        internal static SparkConfigurationListResponse DeserializeSparkConfigurationListResponse(JsonElement element)
        {
            IReadOnlyList<SparkConfigurationResourceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SparkConfigurationResourceData> array = new List<SparkConfigurationResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkConfigurationResourceData.DeserializeSparkConfigurationResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SparkConfigurationListResponse(value, nextLink.Value);
        }
    }
}
