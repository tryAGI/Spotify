
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetMultipleEpisodesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.EpisodeObject> Episodes { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleEpisodesResponse" /> class.
        /// </summary>
        /// <param name="episodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMultipleEpisodesResponse(
            global::System.Collections.Generic.IList<global::Spotify.EpisodeObject> episodes)
        {
            this.Episodes = episodes ?? throw new global::System.ArgumentNullException(nameof(episodes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleEpisodesResponse" /> class.
        /// </summary>
        public GetMultipleEpisodesResponse()
        {
        }

    }
}