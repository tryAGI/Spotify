
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SaveTracksUserRequestTimestampedId
    {
        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The timestamp when the track was added to the library. Use ISO 8601 format with UTC timezone (e.g., `2023-01-15T14:30:00Z`). You can specify past timestamps to insert tracks at specific positions in the library's chronological order. The API uses minute-level granularity for ordering, though the timestamp supports millisecond precision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AddedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTracksUserRequestTimestampedId" /> class.
        /// </summary>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </param>
        /// <param name="addedAt">
        /// The timestamp when the track was added to the library. Use ISO 8601 format with UTC timezone (e.g., `2023-01-15T14:30:00Z`). You can specify past timestamps to insert tracks at specific positions in the library's chronological order. The API uses minute-level granularity for ordering, though the timestamp supports millisecond precision.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveTracksUserRequestTimestampedId(
            string id,
            global::System.DateTime addedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AddedAt = addedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTracksUserRequestTimestampedId" /> class.
        /// </summary>
        public SaveTracksUserRequestTimestampedId()
        {
        }

    }
}