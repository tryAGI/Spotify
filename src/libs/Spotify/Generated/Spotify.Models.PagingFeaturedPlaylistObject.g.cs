
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PagingFeaturedPlaylistObject
    {
        /// <summary>
        /// The localized message of a playlist.<br/>
        /// Example: Popular Playlists
        /// </summary>
        /// <example>Popular Playlists</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlists")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingPlaylistObjectJsonConverter))]
        public global::Spotify.PagingPlaylistObject? Playlists { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingFeaturedPlaylistObject" /> class.
        /// </summary>
        /// <param name="message">
        /// The localized message of a playlist.<br/>
        /// Example: Popular Playlists
        /// </param>
        /// <param name="playlists"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagingFeaturedPlaylistObject(
            string? message,
            global::Spotify.PagingPlaylistObject? playlists)
        {
            this.Message = message;
            this.Playlists = playlists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingFeaturedPlaylistObject" /> class.
        /// </summary>
        public PagingFeaturedPlaylistObject()
        {
        }

    }
}