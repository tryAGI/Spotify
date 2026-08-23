
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimplifiedAlbumObjectVariant2
    {
        /// <summary>
        /// The artists of the album. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject> Artists { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedAlbumObjectVariant2" /> class.
        /// </summary>
        /// <param name="artists">
        /// The artists of the album. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimplifiedAlbumObjectVariant2(
            global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject> artists)
        {
            this.Artists = artists ?? throw new global::System.ArgumentNullException(nameof(artists));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifiedAlbumObjectVariant2" /> class.
        /// </summary>
        public SimplifiedAlbumObjectVariant2()
        {
        }

    }
}