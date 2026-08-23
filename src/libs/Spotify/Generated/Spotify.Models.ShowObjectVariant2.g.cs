
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShowObjectVariant2
    {
        /// <summary>
        /// The episodes of the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedEpisodeObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.PagingSimplifiedEpisodeObject Episodes { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowObjectVariant2" /> class.
        /// </summary>
        /// <param name="episodes">
        /// The episodes of the show.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShowObjectVariant2(
            global::Spotify.PagingSimplifiedEpisodeObject episodes)
        {
            this.Episodes = episodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowObjectVariant2" /> class.
        /// </summary>
        public ShowObjectVariant2()
        {
        }

    }
}