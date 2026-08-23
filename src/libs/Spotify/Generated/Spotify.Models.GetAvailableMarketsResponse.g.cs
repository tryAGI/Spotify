
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvailableMarketsResponse
    {
        /// <summary>
        /// Example: [CA, BR, IT]
        /// </summary>
        /// <example>[CA, BR, IT]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("markets")]
        public global::System.Collections.Generic.IList<string>? Markets { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableMarketsResponse" /> class.
        /// </summary>
        /// <param name="markets">
        /// Example: [CA, BR, IT]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvailableMarketsResponse(
            global::System.Collections.Generic.IList<string>? markets)
        {
            this.Markets = markets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableMarketsResponse" /> class.
        /// </summary>
        public GetAvailableMarketsResponse()
        {
        }

    }
}