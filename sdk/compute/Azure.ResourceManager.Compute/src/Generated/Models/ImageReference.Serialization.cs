// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ImageReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Publisher != null)
            {
                writer.WritePropertyName("publisher");
                writer.WriteStringValue(Publisher);
            }
            if (Offer != null)
            {
                writer.WritePropertyName("offer");
                writer.WriteStringValue(Offer);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku);
            }
            if (Version != null)
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (ExactVersion != null)
            {
                writer.WritePropertyName("exactVersion");
                writer.WriteStringValue(ExactVersion);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static ImageReference DeserializeImageReference(JsonElement element)
        {
            string publisher = default;
            string offer = default;
            string sku = default;
            string version = default;
            string exactVersion = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisher"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exactVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exactVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ImageReference(id, publisher, offer, sku, version, exactVersion);
        }
    }
}
