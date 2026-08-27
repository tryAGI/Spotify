
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SavedEpisodeObject
    {
        /// <summary>
        /// The date and time the episode was saved.<br/>
        /// Timestamps are returned in ISO 8601 format as Coordinated Universal Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// Information about the episode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.EpisodeObjectJsonConverter))]
        public global::Spotify.EpisodeObject? Episode { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedEpisodeObject" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// The date and time the episode was saved.<br/>
        /// Timestamps are returned in ISO 8601 format as Coordinated Universal Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="episode">
        /// Information about the episode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedEpisodeObject(
            global::System.DateTime? addedAt,
            global::Spotify.EpisodeObject? episode)
        {
            this.AddedAt = addedAt;
            this.Episode = episode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedEpisodeObject" /> class.
        /// </summary>
        public SavedEpisodeObject()
        {
        }

    }
}