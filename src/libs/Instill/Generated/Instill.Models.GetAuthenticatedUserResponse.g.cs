
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Instill
{
    /// <summary>
    /// GetAuthenticatedUserResponse contains the requested authenticated user.
    /// </summary>
    public sealed partial class GetAuthenticatedUserResponse
    {
        /// <summary>
        /// The authenticated user resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AllOfJsonConverterFactory1))]
        public global::Instill.AllOf<global::Instill.AuthenticatedUser>? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}