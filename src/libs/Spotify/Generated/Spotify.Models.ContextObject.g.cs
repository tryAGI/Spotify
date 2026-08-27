
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContextObject
    {
        /// <summary>
        /// The object type, e.g. "artist", "playlist", "album", "show".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// External URLs for this context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, e.g. "artist", "playlist", "album", "show".
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the track.
        /// </param>
        /// <param name="externalUrls">
        /// External URLs for this context.
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextObject(
            string? type,
            string? href,
            global::Spotify.ExternalUrlObject? externalUrls,
            string? uri)
        {
            this.Type = type;
            this.Href = href;
            this.ExternalUrls = externalUrls;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextObject" /> class.
        /// </summary>
        public ContextObject()
        {
        }

    }
}