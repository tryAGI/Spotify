
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimplifiedTrackObject
    {
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
        /// External URLs for this track.
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
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking/) is applied. If `true`, the track is playable in the given market. Otherwise `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_playable")]
        public bool? IsPlayable { get; set; }

        /// <summary>
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking/) is applied and is only part of the response if the track linking, in fact, exists. The requested track has been replaced with a different track. The track in the `linked_from` object contains information about the originally requested track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_from")]
        public global::Spotify.LinkedTrackObject? LinkedFrom { get; set; }

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
        /// A URL to a 30 second preview (MP3 format) of the track.
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
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="SimplifiedTrackObject" /> class.
        /// </summary>
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
        /// <param name="externalUrls">
        /// External URLs for this track.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the track.
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </param>
        /// <param name="isPlayable">
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking/) is applied. If `true`, the track is playable in the given market. Otherwise `false`.
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
        public SimplifiedTrackObject(
            global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>? artists,
            int? discNumber,
            int? durationMs,
            bool? @explicit,
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            bool? isPlayable,
            global::Spotify.TrackRestrictionObject? restrictions,
            string? name,
            int? trackNumber,
            string? type,
            string? uri,
            bool? isLocal)
        {
            this.Artists = artists;
            this.DiscNumber = discNumber;
            this.DurationMs = durationMs;
            this.Explicit = @explicit;
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
        /// Initializes a new instance of the <see cref="SimplifiedTrackObject" /> class.
        /// </summary>
        public SimplifiedTrackObject()
        {
        }

    }
}