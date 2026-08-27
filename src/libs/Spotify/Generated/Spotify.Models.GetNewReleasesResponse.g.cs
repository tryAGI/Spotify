
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetNewReleasesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("albums")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedAlbumObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.PagingSimplifiedAlbumObject Albums { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNewReleasesResponse" /> class.
        /// </summary>
        /// <param name="albums"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNewReleasesResponse(
            global::Spotify.PagingSimplifiedAlbumObject albums)
        {
            this.Albums = albums;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNewReleasesResponse" /> class.
        /// </summary>
        public GetNewReleasesResponse()
        {
        }

    }
}