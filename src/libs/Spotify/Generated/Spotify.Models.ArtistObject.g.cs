
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArtistObject
    {
        /// <summary>
        /// Known external URLs for this artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// Information about the followers of the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        public global::Spotify.FollowersObject? Followers { get; set; }

        /// <summary>
        /// A list of the genres the artist is associated with. If not yet classified, the array is empty.<br/>
        /// Example: [Prog rock, Grunge]
        /// </summary>
        /// <example>[Prog rock, Grunge]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

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
        /// Images of the artist in various sizes, widest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Spotify.ImageObject>? Images { get; set; }

        /// <summary>
        /// The name of the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The popularity of the artist. The value will be between 0 and 100, with 100 being the most popular. The artist's popularity is calculated from the popularity of all the artist's tracks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("popularity")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Popularity { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.ArtistObjectTypeJsonConverter))]
        public global::Spotify.ArtistObjectType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ArtistObject" /> class.
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
        /// <param name="images">
        /// Images of the artist in various sizes, widest first.
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
        public ArtistObject(
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject>? images,
            string? name,
            global::Spotify.ArtistObjectType? type,
            string? uri)
        {
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.Name = name;
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistObject" /> class.
        /// </summary>
        public ArtistObject()
        {
        }

    }
}