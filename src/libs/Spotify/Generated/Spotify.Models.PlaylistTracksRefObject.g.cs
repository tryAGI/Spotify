
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistTracksRefObject
    {
        /// <summary>
        /// A link to the Web API endpoint where full details of the playlist's tracks can be retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Number of tracks in the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistTracksRefObject" /> class.
        /// </summary>
        /// <param name="href">
        /// A link to the Web API endpoint where full details of the playlist's tracks can be retrieved.
        /// </param>
        /// <param name="total">
        /// Number of tracks in the playlist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistTracksRefObject(
            string? href,
            int? total)
        {
            this.Href = href;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistTracksRefObject" /> class.
        /// </summary>
        public PlaylistTracksRefObject()
        {
        }

    }
}