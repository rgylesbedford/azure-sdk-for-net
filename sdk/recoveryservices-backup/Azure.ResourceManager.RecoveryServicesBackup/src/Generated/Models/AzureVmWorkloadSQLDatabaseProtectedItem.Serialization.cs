// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureVmWorkloadSQLDatabaseProtectedItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName");
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName");
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ParentType))
            {
                writer.WritePropertyName("parentType");
                writer.WriteStringValue(ParentType);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState");
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (Optional.IsDefined(LastBackupStatus))
            {
                writer.WritePropertyName("lastBackupStatus");
                writer.WriteStringValue(LastBackupStatus.Value.ToString());
            }
            if (Optional.IsDefined(LastBackupOn))
            {
                writer.WritePropertyName("lastBackupTime");
                writer.WriteStringValue(LastBackupOn.Value, "O");
            }
            if (Optional.IsDefined(LastBackupErrorDetail))
            {
                writer.WritePropertyName("lastBackupErrorDetail");
                writer.WriteObjectValue(LastBackupErrorDetail);
            }
            if (Optional.IsDefined(ProtectedItemDataSourceId))
            {
                writer.WritePropertyName("protectedItemDataSourceId");
                writer.WriteStringValue(ProtectedItemDataSourceId);
            }
            if (Optional.IsDefined(ProtectedItemHealthStatus))
            {
                writer.WritePropertyName("protectedItemHealthStatus");
                writer.WriteStringValue(ProtectedItemHealthStatus.Value.ToString());
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo");
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsCollectionDefined(KpisHealths))
            {
                writer.WritePropertyName("kpisHealths");
                writer.WriteStartObject();
                foreach (var item in KpisHealths)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("protectedItemType");
            writer.WriteStringValue(ProtectedItemType);
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName");
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId");
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId");
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(LastRecoveryPoint))
            {
                writer.WritePropertyName("lastRecoveryPoint");
                writer.WriteStringValue(LastRecoveryPoint.Value, "O");
            }
            if (Optional.IsDefined(BackupSetName))
            {
                writer.WritePropertyName("backupSetName");
                writer.WriteStringValue(BackupSetName);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(DeferredDeleteTimeInUTC))
            {
                writer.WritePropertyName("deferredDeleteTimeInUTC");
                writer.WriteStringValue(DeferredDeleteTimeInUTC.Value, "O");
            }
            if (Optional.IsDefined(IsScheduledForDeferredDelete))
            {
                writer.WritePropertyName("isScheduledForDeferredDelete");
                writer.WriteBooleanValue(IsScheduledForDeferredDelete.Value);
            }
            if (Optional.IsDefined(DeferredDeleteTimeRemaining))
            {
                writer.WritePropertyName("deferredDeleteTimeRemaining");
                writer.WriteStringValue(DeferredDeleteTimeRemaining);
            }
            if (Optional.IsDefined(IsDeferredDeleteScheduleUpcoming))
            {
                writer.WritePropertyName("isDeferredDeleteScheduleUpcoming");
                writer.WriteBooleanValue(IsDeferredDeleteScheduleUpcoming.Value);
            }
            if (Optional.IsDefined(IsRehydrate))
            {
                writer.WritePropertyName("isRehydrate");
                writer.WriteBooleanValue(IsRehydrate.Value);
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests");
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled");
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName");
                writer.WriteStringValue(PolicyName);
            }
            writer.WriteEndObject();
        }

        internal static AzureVmWorkloadSQLDatabaseProtectedItem DeserializeAzureVmWorkloadSQLDatabaseProtectedItem(JsonElement element)
        {
            Optional<string> friendlyName = default;
            Optional<string> serverName = default;
            Optional<string> parentName = default;
            Optional<string> parentType = default;
            Optional<string> protectionStatus = default;
            Optional<ProtectionState> protectionState = default;
            Optional<LastBackupStatus> lastBackupStatus = default;
            Optional<DateTimeOffset> lastBackupTime = default;
            Optional<ErrorDetail> lastBackupErrorDetail = default;
            Optional<string> protectedItemDataSourceId = default;
            Optional<ProtectedItemHealthStatus> protectedItemHealthStatus = default;
            Optional<AzureVmWorkloadProtectedItemExtendedInfo> extendedInfo = default;
            Optional<IDictionary<string, KPIResourceHealthDetails>> kpisHealths = default;
            string protectedItemType = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<DataSourceType> workloadType = default;
            Optional<string> containerName = default;
            Optional<string> sourceResourceId = default;
            Optional<string> policyId = default;
            Optional<DateTimeOffset> lastRecoveryPoint = default;
            Optional<string> backupSetName = default;
            Optional<CreateMode> createMode = default;
            Optional<DateTimeOffset> deferredDeleteTimeInUTC = default;
            Optional<bool> isScheduledForDeferredDelete = default;
            Optional<string> deferredDeleteTimeRemaining = default;
            Optional<bool> isDeferredDeleteScheduleUpcoming = default;
            Optional<bool> isRehydrate = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> policyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentName"))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentType"))
                {
                    parentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStatus"))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectionState = new ProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastBackupStatus = new LastBackupStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastBackupTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastBackupTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastBackupErrorDetail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastBackupErrorDetail = ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("protectedItemDataSourceId"))
                {
                    protectedItemDataSourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemHealthStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectedItemHealthStatus = new ProtectedItemHealthStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extendedInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedInfo = AzureVmWorkloadProtectedItemExtendedInfo.DeserializeAzureVmWorkloadProtectedItemExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("kpisHealths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, KPIResourceHealthDetails> dictionary = new Dictionary<string, KPIResourceHealthDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, KPIResourceHealthDetails.DeserializeKPIResourceHealthDetails(property0.Value));
                    }
                    kpisHealths = dictionary;
                    continue;
                }
                if (property.NameEquals("protectedItemType"))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workloadType = new DataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"))
                {
                    sourceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyId"))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRecoveryPoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupSetName"))
                {
                    backupSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createMode = new CreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeInUTC"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deferredDeleteTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isScheduledForDeferredDelete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isScheduledForDeferredDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeRemaining"))
                {
                    deferredDeleteTimeRemaining = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDeferredDeleteScheduleUpcoming"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDeferredDeleteScheduleUpcoming = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRehydrate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isRehydrate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyName"))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
            }
            return new AzureVmWorkloadSQLDatabaseProtectedItem(protectedItemType, Optional.ToNullable(backupManagementType), Optional.ToNullable(workloadType), containerName.Value, sourceResourceId.Value, policyId.Value, Optional.ToNullable(lastRecoveryPoint), backupSetName.Value, Optional.ToNullable(createMode), Optional.ToNullable(deferredDeleteTimeInUTC), Optional.ToNullable(isScheduledForDeferredDelete), deferredDeleteTimeRemaining.Value, Optional.ToNullable(isDeferredDeleteScheduleUpcoming), Optional.ToNullable(isRehydrate), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isArchiveEnabled), policyName.Value, friendlyName.Value, serverName.Value, parentName.Value, parentType.Value, protectionStatus.Value, Optional.ToNullable(protectionState), Optional.ToNullable(lastBackupStatus), Optional.ToNullable(lastBackupTime), lastBackupErrorDetail.Value, protectedItemDataSourceId.Value, Optional.ToNullable(protectedItemHealthStatus), extendedInfo.Value, Optional.ToDictionary(kpisHealths));
        }
    }
}
