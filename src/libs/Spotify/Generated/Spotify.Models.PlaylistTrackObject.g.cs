
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaylistTrackObject
    {
        /// <summary>
        /// The date and time the track or episode was added. _**Note**: some very old playlists may return `null` in this field._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// The Spotify user who added the track or episode. _**Note**: some very old playlists may return `null` in this field._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_by")]
        public global::Spotify.PlaylistUserObject? AddedBy { get; set; }

        /// <summary>
        /// Whether this track or episode is a [local file](/documentation/web-api/concepts/playlists/#local-files) or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_local")]
        public bool? IsLocal { get; set; }

        /// <summary>
        /// Information about the track or episode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.ItemJsonConverter))]
        public global::Spotify.Item? Item { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistTrackObject" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// The date and time the track or episode was added. _**Note**: some very old playlists may return `null` in this field._
        /// </param>
        /// <param name="addedBy">
        /// The Spotify user who added the track or episode. _**Note**: some very old playlists may return `null` in this field._
        /// </param>
        /// <param name="isLocal">
        /// Whether this track or episode is a [local file](/documentation/web-api/concepts/playlists/#local-files) or not.
        /// </param>
        /// <param name="item">
        /// Information about the track or episode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistTrackObject(
            global::System.DateTime? addedAt,
            global::Spotify.PlaylistUserObject? addedBy,
            bool? isLocal,
            global::Spotify.Item? item)
        {
            this.AddedAt = addedAt;
            this.AddedBy = addedBy;
            this.IsLocal = isLocal;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistTrackObject" /> class.
        /// </summary>
        public PlaylistTrackObject()
        {
        }

    }
}