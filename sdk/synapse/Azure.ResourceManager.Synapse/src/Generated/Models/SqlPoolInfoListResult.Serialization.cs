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
    internal partial class SqlPoolInfoListResult
    {
        internal static SqlPoolInfoListResult DeserializeSqlPoolInfoListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<SqlPoolData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlPoolData> array = new List<SqlPoolData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlPoolData.DeserializeSqlPoolData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SqlPoolInfoListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
