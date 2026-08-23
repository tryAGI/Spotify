
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtistDiscographyAlbumObjectVariant2
    {
        /// <summary>
        /// This field describes the relationship between the artist and the album.<br/>
        /// Example: compilation
        /// </summary>
        /// <example>compilation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("album_group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup AlbumGroup { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistDiscographyAlbumObjectVariant2" /> class.
        /// </summary>
        /// <param name="albumGroup">
        /// This field describes the relationship between the artist and the album.<br/>
        /// Example: compilation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtistDiscographyAlbumObjectVariant2(
            global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup albumGroup)
        {
            this.AlbumGroup = albumGroup;
        }

    }
}