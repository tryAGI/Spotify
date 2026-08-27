
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExternalUrlObject
    {
        /// <summary>
        /// The [Spotify URL](/documentation/web-api/concepts/spotify-uris-ids) for the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spotify")]
        public string? Spotify { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalUrlObject" /> class.
        /// </summary>
        /// <param name="spotify">
        /// The [Spotify URL](/documentation/web-api/concepts/spotify-uris-ids) for the object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalUrlObject(
            string? spotify)
        {
            this.Spotify = spotify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalUrlObject" /> class.
        /// </summary>
        public ExternalUrlObject()
        {
        }

    }
}