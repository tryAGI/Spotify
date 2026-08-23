
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimplifiedPlaylistObject
    {
        /// <summary>
        /// `true` if the owner allows other users to modify the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborative")]
        public bool? Collaborative { get; set; }

        /// <summary>
        /// The playlist description. _Only returned for modified, verified playlists, otherwise_ `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Known external URLs for this playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Images for the playlist. The array may be empty or contain up to three images. The images are returned by size in descending order. See [Working with Playlists](/documentation/web-api/concepts/playlists). _**Note**: If returned, the source URL for the image (`url`) is temporary and will expire in less than a day._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Spotify.ImageObject>? Images { get; set; }

        /// <summary>
        /// The name of the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The user who owns the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PlaylistOwnerObjectJsonConverter))]
        public global::Spotify.PlaylistOwnerObject? Owner { get; set; }

        /// <summary>
        /// The playlist's public/private status (if it is added to the user's profile): `true` the playlist is public, `false` the playlist is private, `null` the playlist status is not relevant. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// A collection containing a link ( `href` ) to the Web API endpoint where full details of the playlist's items can be retrieved, along with the `total` number of items in the playlist. Note, a track object may be `null`. This can happen if a track is no longer available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Spotify.PlaylistTracksRefObject? Items { get; set; }

        /// <summary>
        /// **Deprecated:** Use `items` instead. A collection containing a link ( `href` ) to the Web API endpoint where full details of the playlist's tracks can be retrieved, along with the `total` number of tracks in the playlist. Note, a track object may be `null`. This can happen if a track is no longer available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::Spotify.PlaylistTracksRefObject? Tracks { get; set; }

        /// <summary>
        /// The object type: "playlist"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedPlaylistObject" /> class.
        /// </summary>
        /// <param name="collaborative">
        /// `true` if the owner allows other users to modify the playlist.
        /// </param>
        /// <param name="description">
        /// The playlist description. _Only returned for modified, verified playlists, otherwise_ `null`.
        /// </param>
        /// <param name="externalUrls">
        /// Known external URLs for this playlist.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the playlist.
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the playlist.
        /// </param>
        /// <param name="images">
        /// Images for the playlist. The array may be empty or contain up to three images. The images are returned by size in descending order. See [Working with Playlists](/documentation/web-api/concepts/playlists). _**Note**: If returned, the source URL for the image (`url`) is temporary and will expire in less than a day._
        /// </param>
        /// <param name="name">
        /// The name of the playlist.
        /// </param>
        /// <param name="owner">
        /// The user who owns the playlist
        /// </param>
        /// <param name="public">
        /// The playlist's public/private status (if it is added to the user's profile): `true` the playlist is public, `false` the playlist is private, `null` the playlist status is not relevant. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </param>
        /// <param name="snapshotId">
        /// The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist version
        /// </param>
        /// <param name="items">
        /// A collection containing a link ( `href` ) to the Web API endpoint where full details of the playlist's items can be retrieved, along with the `total` number of items in the playlist. Note, a track object may be `null`. This can happen if a track is no longer available.
        /// </param>
        /// <param name="type">
        /// The object type: "playlist"
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the playlist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimplifiedPlaylistObject(
            bool? collaborative,
            string? description,
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject>? images,
            string? name,
            global::Spotify.PlaylistOwnerObject? owner,
            bool? @public,
            string? snapshotId,
            global::Spotify.PlaylistTracksRefObject? items,
            string? type,
            string? uri)
        {
            this.Collaborative = collaborative;
            this.Description = description;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.Name = name;
            this.Owner = owner;
            this.Public = @public;
            this.SnapshotId = snapshotId;
            this.Items = items;
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedPlaylistObject" /> class.
        /// </summary>
        public SimplifiedPlaylistObject()
        {
        }

    }
}