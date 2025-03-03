// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SourceControlSyncJobResult
    {
        internal static SourceControlSyncJobResult DeserializeSourceControlSyncJobResult(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            Optional<string> sourceControlSyncJobId = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<SourceControlProvisioningState> provisioningState = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<SourceControlSyncType> syncType = default;
            Optional<string> exception = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceControlSyncJobId"))
                        {
                            sourceControlSyncJobId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new SourceControlProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                startTime = null;
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("syncType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            syncType = new SourceControlSyncType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exception"))
                        {
                            exception = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SourceControlSyncJobResult(id.Value, sourceControlSyncJobId.Value, Optional.ToNullable(creationTime), Optional.ToNullable(provisioningState), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(syncType), exception.Value);
        }
    }
}
