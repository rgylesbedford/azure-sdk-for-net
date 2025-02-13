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
    public partial class WebSiteInstanceStatusData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StatusUri))
            {
                writer.WritePropertyName("statusUrl");
                writer.WriteStringValue(StatusUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DetectorUri))
            {
                writer.WritePropertyName("detectorUrl");
                writer.WriteStringValue(DetectorUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ConsoleUri))
            {
                writer.WritePropertyName("consoleUrl");
                writer.WriteStringValue(ConsoleUri.AbsoluteUri);
            }
            if (Optional.IsDefined(HealthCheckUri))
            {
                writer.WritePropertyName("healthCheckUrl");
                writer.WriteStringValue(HealthCheckUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers");
                writer.WriteStartObject();
                foreach (var item in Containers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebSiteInstanceStatusData DeserializeWebSiteInstanceStatusData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SiteRuntimeState> state = default;
            Optional<Uri> statusUrl = default;
            Optional<Uri> detectorUrl = default;
            Optional<Uri> consoleUrl = default;
            Optional<Uri> healthCheckUrl = default;
            Optional<IDictionary<string, ContainerInfo>> containers = default;
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
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = property0.Value.GetString().ToSiteRuntimeState();
                            continue;
                        }
                        if (property0.NameEquals("statusUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                statusUrl = null;
                                continue;
                            }
                            statusUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detectorUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                detectorUrl = null;
                                continue;
                            }
                            detectorUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("consoleUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                consoleUrl = null;
                                continue;
                            }
                            consoleUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                healthCheckUrl = null;
                                continue;
                            }
                            healthCheckUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("containers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, ContainerInfo> dictionary = new Dictionary<string, ContainerInfo>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ContainerInfo.DeserializeContainerInfo(property1.Value));
                            }
                            containers = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebSiteInstanceStatusData(id, name, type, systemData.Value, Optional.ToNullable(state), statusUrl.Value, detectorUrl.Value, consoleUrl.Value, healthCheckUrl.Value, Optional.ToDictionary(containers), kind.Value);
        }
    }
}
