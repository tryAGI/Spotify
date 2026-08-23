
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlbumObjectVariant2
    {
        /// <summary>
        /// The artists of the album. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>? Artists { get; set; }

        /// <summary>
        /// The tracks of the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedTrackObjectJsonConverter))]
        public global::Spotify.PagingSimplifiedTrackObject? Tracks { get; set; }

        /// <summary>
        /// The copyright statements of the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyrights")]
        public global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>? Copyrights { get; set; }

        /// <summary>
        /// Known external IDs for the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::Spotify.ExternalIdObject? ExternalIds { get; set; }

        /// <summary>
        /// **Deprecated** The array is always empty.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// The label associated with the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Label { get; set; }

        /// <summary>
        /// The popularity of the album. The value will be between 0 and 100, with 100 being the most popular.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("popularity")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Popularity { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumObjectVariant2" /> class.
        /// </summary>
        /// <param name="artists">
        /// The artists of the album. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </param>
        /// <param name="tracks">
        /// The tracks of the album.
        /// </param>
        /// <param name="copyrights">
        /// The copyright statements of the album.
        /// </param>
        /// <param name="externalIds">
        /// Known external IDs for the album.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlbumObjectVariant2(
            global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>? artists,
            global::Spotify.PagingSimplifiedTrackObject? tracks,
            global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>? copyrights,
            global::Spotify.ExternalIdObject? externalIds)
        {
            this.Artists = artists;
            this.Tracks = tracks;
            this.Copyrights = copyrights;
            this.ExternalIds = externalIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumObjectVariant2" /> class.
        /// </summary>
        public AlbumObjectVariant2()
        {
        }

    }
}