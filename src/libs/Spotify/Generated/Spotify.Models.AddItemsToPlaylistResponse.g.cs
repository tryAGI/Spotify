
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddItemsToPlaylistResponse
    {
        /// <summary>
        /// Example: abc
        /// </summary>
        /// <example>abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemsToPlaylistResponse" /> class.
        /// </summary>
        /// <param name="snapshotId">
        /// Example: abc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddItemsToPlaylistResponse(
            string? snapshotId)
        {
            this.SnapshotId = snapshotId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemsToPlaylistResponse" /> class.
        /// </summary>
        public AddItemsToPlaylistResponse()
        {
        }

    }
}