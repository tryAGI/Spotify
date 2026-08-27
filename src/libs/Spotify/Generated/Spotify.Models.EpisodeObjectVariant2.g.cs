
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EpisodeObjectVariant2
    {
        /// <summary>
        /// The show on which the episode belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.SimplifiedShowObject Show { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeObjectVariant2" /> class.
        /// </summary>
        /// <param name="show">
        /// The show on which the episode belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EpisodeObjectVariant2(
            global::Spotify.SimplifiedShowObject show)
        {
            this.Show = show;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeObjectVariant2" /> class.
        /// </summary>
        public EpisodeObjectVariant2()
        {
        }

    }
}