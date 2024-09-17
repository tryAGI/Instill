#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class CheckNamespaceAdminResponseNamespaceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.CheckNamespaceAdminResponseNamespace>
    {
        /// <inheritdoc />
        public override global::Instill.CheckNamespaceAdminResponseNamespace Read(
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
                        return global::Instill.CheckNamespaceAdminResponseNamespaceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.CheckNamespaceAdminResponseNamespace)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.CheckNamespaceAdminResponseNamespace value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Instill.CheckNamespaceAdminResponseNamespaceExtensions.ToValueString(value));
        }
    }
}
