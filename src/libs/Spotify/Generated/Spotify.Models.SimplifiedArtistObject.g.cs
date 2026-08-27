
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimplifiedArtistObject
    {
        /// <summary>
        /// Known external URLs for this artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.SimplifiedArtistObjectTypeJsonConverter))]
        public global::Spotify.SimplifiedArtistObjectType? Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedArtistObject" /> class.
        /// </summary>
        /// <param name="externalUrls">
        /// Known external URLs for this artist.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the artist.
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the artist.
        /// </param>
        /// <param name="name">
        /// The name of the artist.
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the artist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimplifiedArtistObject(
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            string? name,
            global::Spotify.SimplifiedArtistObjectType? type,
            string? uri)
        {
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedArtistObject" /> class.
        /// </summary>
        public SimplifiedArtistObject()
        {
        }

    }
}