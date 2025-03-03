// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WebAppBackupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebAppBackupData DeserializeWebAppBackupData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> id0 = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<string> blobName = default;
            Optional<string> name0 = default;
            Optional<WebAppBackupStatus> status = default;
            Optional<long> sizeInBytes = default;
            Optional<DateTimeOffset> created = default;
            Optional<string> log = default;
            Optional<IReadOnlyList<AppServiceDatabaseBackupSetting>> databases = default;
            Optional<bool> scheduled = default;
            Optional<DateTimeOffset> lastRestoreTimeStamp = default;
            Optional<DateTimeOffset> finishedTimeStamp = default;
            Optional<string> correlationId = default;
            Optional<long> websiteSizeInBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("id"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            id0 = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageAccountUrl = null;
                                continue;
                            }
                            storageAccountUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobName"))
                        {
                            blobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("name"))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToWebAppBackupStatus();
                            continue;
                        }
                        if (property0.NameEquals("sizeInBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("created"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("log"))
                        {
                            log = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AppServiceDatabaseBackupSetting> array = new List<AppServiceDatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceDatabaseBackupSetting.DeserializeAppServiceDatabaseBackupSetting(item));
                            }
                            databases = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scheduled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastRestoreTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastRestoreTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("finishedTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            finishedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("correlationId"))
                        {
                            correlationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("websiteSizeInBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            websiteSizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebAppBackupData(id, name, type, systemData.Value, Optional.ToNullable(id0), storageAccountUrl.Value, blobName.Value, name0.Value, Optional.ToNullable(status), Optional.ToNullable(sizeInBytes), Optional.ToNullable(created), log.Value, Optional.ToList(databases), Optional.ToNullable(scheduled), Optional.ToNullable(lastRestoreTimeStamp), Optional.ToNullable(finishedTimeStamp), correlationId.Value, Optional.ToNullable(websiteSizeInBytes), kind.Value);
        }
    }
}
