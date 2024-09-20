
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateOrganizationMembershipResponse contains the updated membership.
    /// </summary>
    public sealed partial class UpdateOrganizationMembershipResponse
    {
        /// <summary>
        /// An organization membership defines the relationship between an organization<br/>
        /// and a user that is attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        public global::Instill.OrganizationMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}