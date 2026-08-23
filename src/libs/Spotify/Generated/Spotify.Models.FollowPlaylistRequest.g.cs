
#nullable enable

namespace Spotify
{
    /// <summary>
    /// Example: {"public":false}
    /// </summary>
    public sealed partial class FollowPlaylistRequest
    {
        /// <summary>
        /// Defaults to `true`. If `true` the playlist will be included in user's public playlists (added to profile), if `false` it will remain private. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowPlaylistRequest" /> class.
        /// </summary>
        /// <param name="public">
        /// Defaults to `true`. If `true` the playlist will be included in user's public playlists (added to profile), if `false` it will remain private. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowPlaylistRequest(
            bool? @public)
        {
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowPlaylistRequest" /> class.
        /// </summary>
        public FollowPlaylistRequest()
        {
        }

    }
}