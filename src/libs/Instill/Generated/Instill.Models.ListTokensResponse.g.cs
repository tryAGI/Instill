
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListTokensResponse contains a list of API tokens.
    /// </summary>
    public sealed partial class ListTokensResponse
    {
        /// <summary>
        /// A list of API token resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<global::Instill.ApiToken>? Tokens { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of API token resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}