
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackObject
    {
        /// <summary>
        /// The album on which the track appears. The album object includes a link in `href` to full information about the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("album")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.SimplifiedAlbumObjectJsonConverter))]
        public global::Spotify.SimplifiedAlbumObject? Album { get; set; }

        /// <summary>
        /// The artists who performed the track. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>? Artists { get; set; }

        /// <summary>
        /// A list of the countries in which the track can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_markets")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? AvailableMarkets { get; set; }

        /// <summary>
        /// The disc number (usually `1` unless the album consists of more than one disc).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disc_number")]
        public int? DiscNumber { get; set; }

        /// <summary>
        /// The track length in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Whether or not the track has explicit lyrics ( `true` = yes it does; `false` = no it does not OR unknown).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit")]
        public bool? Explicit { get; set; }

        /// <summary>
        /// Known external IDs for the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::Spotify.ExternalIdObject? ExternalIds { get; set; }

        /// <summary>
        /// Known external URLs for this track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking) is applied. If `true`, the track is playable in the given market. Otherwise `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_playable")]
        public bool? IsPlayable { get; set; }

        /// <summary>
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking) is applied, and the requested track has been replaced with different track. The track in the `linked_from` object contains information about the originally requested track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_from")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? LinkedFrom { get; set; }

        /// <summary>
        /// Included in the response when a content restriction is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::Spotify.TrackRestrictionObject? Restrictions { get; set; }

        /// <summary>
        /// The name of the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The popularity of the track. The value will be between 0 and 100, with 100 being the most popular.&lt;br/&gt;The popularity of a track is a value between 0 and 100, with 100 being the most popular. The popularity is calculated by algorithm and is based, in the most part, on the total number of plays the track has had and how recent those plays are.&lt;br/&gt;Generally speaking, songs that are being played a lot now will have a higher popularity than songs that were played a lot in the past. Duplicate tracks (e.g. the same track from a single and an album) are rated independently. Artist and album popularity is derived mathematically from track popularity. _**Note**: the popularity value may lag actual popularity by a few days: the value is not updated in real time._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("popularity")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Popularity { get; set; }

        /// <summary>
        /// A link to a 30 second preview (MP3 format) of the track. Can be `null`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The number of the track. If an album has several discs, the track number is the number on the specified disc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_number")]
        public int? TrackNumber { get; set; }

        /// <summary>
        /// The object type: "track".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.TrackObjectTypeJsonConverter))]
        public global::Spotify.TrackObjectType? Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Whether or not the track is from a local file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_local")]
        public bool? IsLocal { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackObject" /> class.
        /// </summary>
        /// <param name="album">
        /// The album on which the track appears. The album object includes a link in `href` to full information about the album.
        /// </param>
        /// <param name="artists">
        /// The artists who performed the track. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </param>
        /// <param name="discNumber">
        /// The disc number (usually `1` unless the album consists of more than one disc).
        /// </param>
        /// <param name="durationMs">
        /// The track length in milliseconds.
        /// </param>
        /// <param name="explicit">
        /// Whether or not the track has explicit lyrics ( `true` = yes it does; `false` = no it does not OR unknown).
        /// </param>
        /// <param name="externalIds">
        /// Known external IDs for the track.
        /// </param>
        /// <param name="externalUrls">
        /// Known external URLs for this track.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the track.
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </param>
        /// <param name="isPlayable">
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking) is applied. If `true`, the track is playable in the given market. Otherwise `false`.
        /// </param>
        /// <param name="restrictions">
        /// Included in the response when a content restriction is applied.
        /// </param>
        /// <param name="name">
        /// The name of the track.
        /// </param>
        /// <param name="trackNumber">
        /// The number of the track. If an album has several discs, the track number is the number on the specified disc.
        /// </param>
        /// <param name="type">
        /// The object type: "track".
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </param>
        /// <param name="isLocal">
        /// Whether or not the track is from a local file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackObject(
            global::Spotify.SimplifiedAlbumObject? album,
            global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>? artists,
            int? discNumber,
            int? durationMs,
            bool? @explicit,
            global::Spotify.ExternalIdObject? externalIds,
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            bool? isPlayable,
            global::Spotify.TrackRestrictionObject? restrictions,
            string? name,
            int? trackNumber,
            global::Spotify.TrackObjectType? type,
            string? uri,
            bool? isLocal)
        {
            this.Album = album;
            this.Artists = artists;
            this.DiscNumber = discNumber;
            this.DurationMs = durationMs;
            this.Explicit = @explicit;
            this.ExternalIds = externalIds;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.IsPlayable = isPlayable;
            this.Restrictions = restrictions;
            this.Name = name;
            this.TrackNumber = trackNumber;
            this.Type = type;
            this.Uri = uri;
            this.IsLocal = isLocal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackObject" /> class.
        /// </summary>
        public TrackObject()
        {
        }

    }
}