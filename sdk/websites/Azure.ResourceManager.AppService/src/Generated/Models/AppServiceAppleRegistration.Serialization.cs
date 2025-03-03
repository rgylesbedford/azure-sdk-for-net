// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAppleRegistration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName");
                writer.WriteStringValue(ClientSecretSettingName);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceAppleRegistration DeserializeAppServiceAppleRegistration(JsonElement element)
        {
            Optional<string> clientId = default;
            Optional<string> clientSecretSettingName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceAppleRegistration(clientId.Value, clientSecretSettingName.Value);
        }
    }
}
