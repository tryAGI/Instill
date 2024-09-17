
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreditConsumptionChartRecord represents a timeline of Instill Credit<br/>
    /// consumption. It contains a collection of (timestamp, amount) pairs that<br/>
    /// represent the total credit consumption in a given time bucket.
    /// </summary>
    public sealed partial class CreditConsumptionChartRecord
    {
        /// <summary>
        /// The ID of the namespace that owns the credit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NamespaceId { get; set; }

        /// <summary>
        /// Time buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeBuckets")]
        public global::System.Collections.Generic.IList<global::System.DateTime>? TimeBuckets { get; set; }

        /// <summary>
        /// Total credit consumed in each time bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public global::System.Collections.Generic.IList<float>? Amount { get; set; }

        /// <summary>
        /// Credit consumption source (e.g. "pipeline", "model").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}