
#nullable enable

namespace Spotify
{
    /// <summary>
    /// Example: {"name":"Updated Playlist Name","description":"Updated playlist description","public":false}
    /// </summary>
    public sealed partial class ChangePlaylistDetailsRequest
    {
        /// <summary>
        /// The new name for the playlist, for example `"My New Playlist Title"`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The playlist's public/private status (if it should be added to the user's profile or not): `true` the playlist will be public, `false` the playlist will be private, `null` the playlist status is not relevant. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// If `true`, the playlist will become collaborative and other users will be able to modify the playlist in their Spotify client. &lt;br/&gt;<br/>
        /// _**Note**: You can only set `collaborative` to `true` on non-public playlists._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborative")]
        public bool? Collaborative { get; set; }

        /// <summary>
        /// Value for playlist description as displayed in Spotify Clients and in the Web API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePlaylistDetailsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the playlist, for example `"My New Playlist Title"`
        /// </param>
        /// <param name="public">
        /// The playlist's public/private status (if it should be added to the user's profile or not): `true` the playlist will be public, `false` the playlist will be private, `null` the playlist status is not relevant. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </param>
        /// <param name="collaborative">
        /// If `true`, the playlist will become collaborative and other users will be able to modify the playlist in their Spotify client. &lt;br/&gt;<br/>
        /// _**Note**: You can only set `collaborative` to `true` on non-public playlists._
        /// </param>
        /// <param name="description">
        /// Value for playlist description as displayed in Spotify Clients and in the Web API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChangePlaylistDetailsRequest(
            string? name,
            bool? @public,
            bool? collaborative,
            string? description)
        {
            this.Name = name;
            this.Public = @public;
            this.Collaborative = collaborative;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePlaylistDetailsRequest" /> class.
        /// </summary>
        public ChangePlaylistDetailsRequest()
        {
        }

    }
}