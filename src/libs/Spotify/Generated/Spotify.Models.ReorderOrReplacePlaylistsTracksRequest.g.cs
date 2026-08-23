
#nullable enable

namespace Spotify
{
    /// <summary>
    /// Example: {"range_start":1,"insert_before":3,"range_length":2}
    /// </summary>
    public sealed partial class ReorderOrReplacePlaylistsTracksRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        /// The position of the first item to be reordered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_start")]
        public int? RangeStart { get; set; }

        /// <summary>
        /// The position where the items should be inserted.&lt;br/&gt;To reorder the items to the end of the playlist, simply set _insert_before_ to the position after the last item.&lt;br/&gt;Examples:&lt;br/&gt;To reorder the first item to the last position in a playlist with 10 items, set _range_start_ to 0, and _insert_before_ to 10.&lt;br/&gt;To reorder the last item in a playlist with 10 items to the start of the playlist, set _range_start_ to 9, and _insert_before_ to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_before")]
        public int? InsertBefore { get; set; }

        /// <summary>
        /// The amount of items to be reordered. Defaults to 1 if not set.&lt;br/&gt;The range of items to be reordered begins from the _range_start_ position, and includes the _range_length_ subsequent items.&lt;br/&gt;Example:&lt;br/&gt;To move the items at index 9-10 to the start of the playlist, _range_start_ is set to 9, and _range_length_ is set to 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_length")]
        public int? RangeLength { get; set; }

        /// <summary>
        /// The playlist's snapshot ID against which you want to make the changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReorderOrReplacePlaylistsTracksRequest" /> class.
        /// </summary>
        /// <param name="uris"></param>
        /// <param name="rangeStart">
        /// The position of the first item to be reordered.
        /// </param>
        /// <param name="insertBefore">
        /// The position where the items should be inserted.&lt;br/&gt;To reorder the items to the end of the playlist, simply set _insert_before_ to the position after the last item.&lt;br/&gt;Examples:&lt;br/&gt;To reorder the first item to the last position in a playlist with 10 items, set _range_start_ to 0, and _insert_before_ to 10.&lt;br/&gt;To reorder the last item in a playlist with 10 items to the start of the playlist, set _range_start_ to 9, and _insert_before_ to 0.
        /// </param>
        /// <param name="rangeLength">
        /// The amount of items to be reordered. Defaults to 1 if not set.&lt;br/&gt;The range of items to be reordered begins from the _range_start_ position, and includes the _range_length_ subsequent items.&lt;br/&gt;Example:&lt;br/&gt;To move the items at index 9-10 to the start of the playlist, _range_start_ is set to 9, and _range_length_ is set to 2.
        /// </param>
        /// <param name="snapshotId">
        /// The playlist's snapshot ID against which you want to make the changes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReorderOrReplacePlaylistsTracksRequest(
            global::System.Collections.Generic.IList<string>? uris,
            int? rangeStart,
            int? insertBefore,
            int? rangeLength,
            string? snapshotId)
        {
            this.Uris = uris;
            this.RangeStart = rangeStart;
            this.InsertBefore = insertBefore;
            this.RangeLength = rangeLength;
            this.SnapshotId = snapshotId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReorderOrReplacePlaylistsTracksRequest" /> class.
        /// </summary>
        public ReorderOrReplacePlaylistsTracksRequest()
        {
        }

    }
}