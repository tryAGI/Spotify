
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetMultipleAlbumsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("albums")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.AlbumObject> Albums { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleAlbumsResponse" /> class.
        /// </summary>
        /// <param name="albums"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMultipleAlbumsResponse(
            global::System.Collections.Generic.IList<global::Spotify.AlbumObject> albums)
        {
            this.Albums = albums ?? throw new global::System.ArgumentNullException(nameof(albums));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleAlbumsResponse" /> class.
        /// </summary>
        public GetMultipleAlbumsResponse()
        {
        }

    }
}