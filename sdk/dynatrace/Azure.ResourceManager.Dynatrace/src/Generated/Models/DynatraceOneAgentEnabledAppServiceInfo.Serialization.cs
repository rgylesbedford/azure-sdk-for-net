// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceOneAgentEnabledAppServiceInfo
    {
        internal static DynatraceOneAgentEnabledAppServiceInfo DeserializeDynatraceOneAgentEnabledAppServiceInfo(JsonElement element)
        {
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> version = default;
            Optional<DynatraceOneAgentMonitoringType> monitoringType = default;
            Optional<DynatraceOneAgentAutoUpdateSetting> autoUpdateSetting = default;
            Optional<DynatraceOneAgentUpdateStatus> updateStatus = default;
            Optional<DynatraceOneAgentAvailabilityState> availabilityState = default;
            Optional<DynatraceLogModuleState> logModule = default;
            Optional<string> hostGroup = default;
            Optional<string> hostName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitoringType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monitoringType = new DynatraceOneAgentMonitoringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoUpdateSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoUpdateSetting = new DynatraceOneAgentAutoUpdateSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateStatus = new DynatraceOneAgentUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availabilityState = new DynatraceOneAgentAvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logModule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logModule = new DynatraceLogModuleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostGroup"))
                {
                    hostGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
            }
            return new DynatraceOneAgentEnabledAppServiceInfo(resourceId.Value, version.Value, Optional.ToNullable(monitoringType), Optional.ToNullable(autoUpdateSetting), Optional.ToNullable(updateStatus), Optional.ToNullable(availabilityState), Optional.ToNullable(logModule), hostGroup.Value, hostName.Value);
        }
    }
}
