
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetAuthenticatedUserResponse contains the requested authenticated user.
    /// </summary>
    public sealed partial class GetAuthenticatedUserResponse
    {
        /// <summary>
        /// AuthenticatedUser contains the information of an authenticated user, i.e.,<br/>
        /// the public user information plus some fields that should only be accessed by<br/>
        /// the user themselves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Instill.AuthenticatedUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}