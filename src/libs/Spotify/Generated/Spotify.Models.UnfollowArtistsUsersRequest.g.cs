
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnfollowArtistsUsersRequest
    {
        /// <summary>
        /// A JSON array of the artist or user [Spotify IDs](/documentation/web-api/concepts/spotify-uris-ids). For example: `{ids:["74ASZWbe4lXaubB36ztrGX", "08td7MxkoHQkXnWAYD8d6Q"]}`. A maximum of 50 IDs can be sent in one request. _**Note**: if the `ids` parameter is present in the query string, any IDs listed here in the body will be ignored._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnfollowArtistsUsersRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// A JSON array of the artist or user [Spotify IDs](/documentation/web-api/concepts/spotify-uris-ids). For example: `{ids:["74ASZWbe4lXaubB36ztrGX", "08td7MxkoHQkXnWAYD8d6Q"]}`. A maximum of 50 IDs can be sent in one request. _**Note**: if the `ids` parameter is present in the query string, any IDs listed here in the body will be ignored._
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnfollowArtistsUsersRequest(
            global::System.Collections.Generic.IList<string>? ids)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnfollowArtistsUsersRequest" /> class.
        /// </summary>
        public UnfollowArtistsUsersRequest()
        {
        }

    }
}