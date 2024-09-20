
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSourceFileResponse
    {
        /// <summary>
        /// The SourceFile message represents a source file in the artifact system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFile")]
        public global::Instill.SourceFile? SourceFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}