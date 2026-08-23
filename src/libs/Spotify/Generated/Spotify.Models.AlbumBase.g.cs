
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlbumBase
    {
        /// <summary>
        /// The type of the album.<br/>
        /// Example: compilation
        /// </summary>
        /// <example>compilation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("album_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.AlbumBaseAlbumTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.AlbumBaseAlbumType AlbumType { get; set; }

        /// <summary>
        /// The number of tracks in the album.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTracks { get; set; }

        /// <summary>
        /// The markets in which the album is available: [ISO 3166-1 alpha-2 country codes](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _**NOTE**: an album is considered available in a market when at least 1 of its tracks is available in that market._<br/>
        /// Example: [CA, BR, IT]
        /// </summary>
        /// <example>[CA, BR, IT]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_markets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableMarkets { get; set; }

        /// <summary>
        /// Known external URLs for this album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the album.<br/>
        /// Example: 2up3OPMp9Tb4dAKM2erWXQ
        /// </summary>
        /// <example>2up3OPMp9Tb4dAKM2erWXQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The cover art for the album in various sizes, widest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.ImageObject> Images { get; set; }

        /// <summary>
        /// The name of the album. In case of an album takedown, the value may be an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The date the album was first released.<br/>
        /// Example: 1981-12
        /// </summary>
        /// <example>1981-12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseDate { get; set; }

        /// <summary>
        /// The precision with which `release_date` value is known.<br/>
        /// Example: year
        /// </summary>
        /// <example>year</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date_precision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.AlbumBaseReleaseDatePrecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.AlbumBaseReleaseDatePrecision ReleaseDatePrecision { get; set; }

        /// <summary>
        /// Included in the response when a content restriction is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::Spotify.AlbumRestrictionObject? Restrictions { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.AlbumBaseTypeJsonConverter))]
        public global::Spotify.AlbumBaseType Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the album.<br/>
        /// Example: spotify:album:2up3OPMp9Tb4dAKM2erWXQ
        /// </summary>
        /// <example>spotify:album:2up3OPMp9Tb4dAKM2erWXQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumBase" /> class.
        /// </summary>
        /// <param name="albumType">
        /// The type of the album.<br/>
        /// Example: compilation
        /// </param>
        /// <param name="totalTracks">
        /// The number of tracks in the album.<br/>
        /// Example: 9
        /// </param>
        /// <param name="availableMarkets">
        /// The markets in which the album is available: [ISO 3166-1 alpha-2 country codes](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _**NOTE**: an album is considered available in a market when at least 1 of its tracks is available in that market._<br/>
        /// Example: [CA, BR, IT]
        /// </param>
        /// <param name="externalUrls">
        /// Known external URLs for this album.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the album.
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the album.<br/>
        /// Example: 2up3OPMp9Tb4dAKM2erWXQ
        /// </param>
        /// <param name="images">
        /// The cover art for the album in various sizes, widest first.
        /// </param>
        /// <param name="name">
        /// The name of the album. In case of an album takedown, the value may be an empty string.
        /// </param>
        /// <param name="releaseDate">
        /// The date the album was first released.<br/>
        /// Example: 1981-12
        /// </param>
        /// <param name="releaseDatePrecision">
        /// The precision with which `release_date` value is known.<br/>
        /// Example: year
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the album.<br/>
        /// Example: spotify:album:2up3OPMp9Tb4dAKM2erWXQ
        /// </param>
        /// <param name="restrictions">
        /// Included in the response when a content restriction is applied.
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlbumBase(
            global::Spotify.AlbumBaseAlbumType albumType,
            int totalTracks,
            global::System.Collections.Generic.IList<string> availableMarkets,
            global::Spotify.ExternalUrlObject externalUrls,
            string href,
            string id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject> images,
            string name,
            string releaseDate,
            global::Spotify.AlbumBaseReleaseDatePrecision releaseDatePrecision,
            string uri,
            global::Spotify.AlbumRestrictionObject? restrictions,
            global::Spotify.AlbumBaseType type)
        {
            this.AlbumType = albumType;
            this.TotalTracks = totalTracks;
            this.AvailableMarkets = availableMarkets ?? throw new global::System.ArgumentNullException(nameof(availableMarkets));
            this.ExternalUrls = externalUrls ?? throw new global::System.ArgumentNullException(nameof(externalUrls));
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ReleaseDate = releaseDate ?? throw new global::System.ArgumentNullException(nameof(releaseDate));
            this.ReleaseDatePrecision = releaseDatePrecision;
            this.Restrictions = restrictions;
            this.Type = type;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumBase" /> class.
        /// </summary>
        public AlbumBase()
        {
        }

    }
}