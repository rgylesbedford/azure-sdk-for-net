// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class OfficeConsentList
    {
        internal static OfficeConsentList DeserializeOfficeConsentList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<OfficeConsentData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<OfficeConsentData> array = new List<OfficeConsentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OfficeConsentData.DeserializeOfficeConsentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new OfficeConsentList(nextLink.Value, value);
        }
    }
}
