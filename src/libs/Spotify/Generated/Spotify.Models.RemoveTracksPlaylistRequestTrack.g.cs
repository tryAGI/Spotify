
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveTracksPlaylistRequestTrack
    {
        /// <summary>
        /// Spotify URI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTracksPlaylistRequestTrack" /> class.
        /// </summary>
        /// <param name="uri">
        /// Spotify URI
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveTracksPlaylistRequestTrack(
            string? uri)
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTracksPlaylistRequestTrack" /> class.
        /// </summary>
        public RemoveTracksPlaylistRequestTrack()
        {
        }

    }
}