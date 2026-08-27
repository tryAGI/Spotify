
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecommendationsObject
    {
        /// <summary>
        /// An array of recommendation seed objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seeds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.RecommendationSeedObject> Seeds { get; set; }

        /// <summary>
        /// An array of track object (simplified) ordered according to the parameters supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.TrackObject> Tracks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendationsObject" /> class.
        /// </summary>
        /// <param name="seeds">
        /// An array of recommendation seed objects.
        /// </param>
        /// <param name="tracks">
        /// An array of track object (simplified) ordered according to the parameters supplied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendationsObject(
            global::System.Collections.Generic.IList<global::Spotify.RecommendationSeedObject> seeds,
            global::System.Collections.Generic.IList<global::Spotify.TrackObject> tracks)
        {
            this.Seeds = seeds ?? throw new global::System.ArgumentNullException(nameof(seeds));
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendationsObject" /> class.
        /// </summary>
        public RecommendationsObject()
        {
        }

    }
}