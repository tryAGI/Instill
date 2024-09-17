#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class CheckNamespaceByUIDAdminResponseNamespaceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.CheckNamespaceByUIDAdminResponseNamespace?>
    {
        /// <inheritdoc />
        public override global::Instill.CheckNamespaceByUIDAdminResponseNamespace? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Instill.CheckNamespaceByUIDAdminResponseNamespaceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.CheckNamespaceByUIDAdminResponseNamespace)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.CheckNamespaceByUIDAdminResponseNamespace? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Instill.CheckNamespaceByUIDAdminResponseNamespaceExtensions.ToValueString(value.Value));
            }
        }
    }
}
