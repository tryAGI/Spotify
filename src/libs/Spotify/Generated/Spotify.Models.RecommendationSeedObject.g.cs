
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendationSeedObject
    {
        /// <summary>
        /// The number of tracks available after min\_\* and max\_\* filters have been applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterFilteringSize")]
        public int? AfterFilteringSize { get; set; }

        /// <summary>
        /// The number of tracks available after relinking for regional availability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterRelinkingSize")]
        public int? AfterRelinkingSize { get; set; }

        /// <summary>
        /// A link to the full track or artist data for this seed. For tracks this will be a link to a Track Object. For artists a link to an Artist Object. For genre seeds, this value will be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The id used to select this seed. This will be the same as the string used in the `seed_artists`, `seed_tracks` or `seed_genres` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The number of recommended tracks available for this seed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialPoolSize")]
        public int? InitialPoolSize { get; set; }

        /// <summary>
        /// The entity type of this seed. One of `artist`, `track` or `genre`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendationSeedObject" /> class.
        /// </summary>
        /// <param name="afterFilteringSize">
        /// The number of tracks available after min\_\* and max\_\* filters have been applied.
        /// </param>
        /// <param name="afterRelinkingSize">
        /// The number of tracks available after relinking for regional availability.
        /// </param>
        /// <param name="href">
        /// A link to the full track or artist data for this seed. For tracks this will be a link to a Track Object. For artists a link to an Artist Object. For genre seeds, this value will be `null`.
        /// </param>
        /// <param name="id">
        /// The id used to select this seed. This will be the same as the string used in the `seed_artists`, `seed_tracks` or `seed_genres` parameter.
        /// </param>
        /// <param name="initialPoolSize">
        /// The number of recommended tracks available for this seed.
        /// </param>
        /// <param name="type">
        /// The entity type of this seed. One of `artist`, `track` or `genre`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendationSeedObject(
            int? afterFilteringSize,
            int? afterRelinkingSize,
            string? href,
            string? id,
            int? initialPoolSize,
            string? type)
        {
            this.AfterFilteringSize = afterFilteringSize;
            this.AfterRelinkingSize = afterRelinkingSize;
            this.Href = href;
            this.Id = id;
            this.InitialPoolSize = initialPoolSize;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendationSeedObject" /> class.
        /// </summary>
        public RecommendationSeedObject()
        {
        }

    }
}