
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateTokenResponse contains the created token.
    /// </summary>
    public sealed partial class CreateTokenResponse
    {
        /// <summary>
        /// The created API token resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AllOfJsonConverterFactory1))]
        public global::Instill.AllOf<global::Instill.ApiToken>? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}