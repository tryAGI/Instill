
#nullable enable

namespace Instill
{
    /// <summary>
    /// UserSubscription details describe the plan (i.e., features) a user has access to.
    /// </summary>
    public sealed partial class UserSubscription
    {
        /// <summary>
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.UserSubscriptionPlanJsonConverter))]
        public global::Instill.UserSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::Instill.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}