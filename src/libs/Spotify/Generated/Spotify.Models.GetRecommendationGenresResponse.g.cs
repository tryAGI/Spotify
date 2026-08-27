
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRecommendationGenresResponse
    {
        /// <summary>
        /// Example: [alternative, samba]
        /// </summary>
        /// <example>[alternative, samba]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Genres { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecommendationGenresResponse" /> class.
        /// </summary>
        /// <param name="genres">
        /// Example: [alternative, samba]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRecommendationGenresResponse(
            global::System.Collections.Generic.IList<string> genres)
        {
            this.Genres = genres ?? throw new global::System.ArgumentNullException(nameof(genres));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecommendationGenresResponse" /> class.
        /// </summary>
        public GetRecommendationGenresResponse()
        {
        }

    }
}