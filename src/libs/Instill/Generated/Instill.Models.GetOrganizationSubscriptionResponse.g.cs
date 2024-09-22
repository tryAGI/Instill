
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetOrganizationSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetOrganizationSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::Instill.OrganizationSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}