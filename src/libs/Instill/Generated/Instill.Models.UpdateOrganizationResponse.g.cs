
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateOrganizationResponse contains the updated organization.
    /// </summary>
    public sealed partial class UpdateOrganizationResponse
    {
        /// <summary>
        /// The organization resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Instill.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}