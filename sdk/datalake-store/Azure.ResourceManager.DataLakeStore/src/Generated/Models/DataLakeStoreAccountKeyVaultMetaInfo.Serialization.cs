// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountKeyVaultMetaInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultResourceId");
            writer.WriteStringValue(KeyVaultResourceId);
            writer.WritePropertyName("encryptionKeyName");
            writer.WriteStringValue(EncryptionKeyName);
            writer.WritePropertyName("encryptionKeyVersion");
            writer.WriteStringValue(EncryptionKeyVersion);
            writer.WriteEndObject();
        }

        internal static DataLakeStoreAccountKeyVaultMetaInfo DeserializeDataLakeStoreAccountKeyVaultMetaInfo(JsonElement element)
        {
            string keyVaultResourceId = default;
            string encryptionKeyName = default;
            string encryptionKeyVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultResourceId"))
                {
                    keyVaultResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKeyName"))
                {
                    encryptionKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKeyVersion"))
                {
                    encryptionKeyVersion = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeStoreAccountKeyVaultMetaInfo(keyVaultResourceId, encryptionKeyName, encryptionKeyVersion);
        }
    }
}
