
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFollowedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.CursorPagingSimplifiedArtistObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.CursorPagingSimplifiedArtistObject Artists { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowedResponse" /> class.
        /// </summary>
        /// <param name="artists"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFollowedResponse(
            global::Spotify.CursorPagingSimplifiedArtistObject artists)
        {
            this.Artists = artists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowedResponse" /> class.
        /// </summary>
        public GetFollowedResponse()
        {
        }

    }
}