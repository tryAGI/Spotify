
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveTracksPlaylistRequest
    {
        /// <summary>
        /// An array of objects containing [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) of the tracks or episodes to remove.<br/>
        /// For example: `{ "tracks": [{ "uri": "spotify:track:4iV5W9uYEdYUVa79Axb7Rh" },{ "uri": "spotify:track:1301WleyT98MSxVHPZCA6M" }] }`. A maximum of 100 objects can be sent at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.RemoveTracksPlaylistRequestTrack> Tracks { get; set; }

        /// <summary>
        /// The playlist's snapshot ID against which you want to make the changes.<br/>
        /// The API will validate that the specified items exist and in the specified positions and make the changes,<br/>
        /// even if more recent changes have been made to the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTracksPlaylistRequest" /> class.
        /// </summary>
        /// <param name="tracks">
        /// An array of objects containing [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) of the tracks or episodes to remove.<br/>
        /// For example: `{ "tracks": [{ "uri": "spotify:track:4iV5W9uYEdYUVa79Axb7Rh" },{ "uri": "spotify:track:1301WleyT98MSxVHPZCA6M" }] }`. A maximum of 100 objects can be sent at once.
        /// </param>
        /// <param name="snapshotId">
        /// The playlist's snapshot ID against which you want to make the changes.<br/>
        /// The API will validate that the specified items exist and in the specified positions and make the changes,<br/>
        /// even if more recent changes have been made to the playlist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveTracksPlaylistRequest(
            global::System.Collections.Generic.IList<global::Spotify.RemoveTracksPlaylistRequestTrack> tracks,
            string? snapshotId)
        {
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
            this.SnapshotId = snapshotId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTracksPlaylistRequest" /> class.
        /// </summary>
        public RemoveTracksPlaylistRequest()
        {
        }

    }
}