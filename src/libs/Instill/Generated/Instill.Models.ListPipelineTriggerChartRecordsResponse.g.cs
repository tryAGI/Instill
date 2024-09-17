
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListPipelineTriggerChartRecordsResponse contains a list of pipeline trigger<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListPipelineTriggerChartRecordsResponse
    {
        /// <summary>
        /// A list of pipeline trigger records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTriggerChartRecords")]
        public global::System.Collections.Generic.IList<global::Instill.PipelineTriggerChartRecord>? PipelineTriggerChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}