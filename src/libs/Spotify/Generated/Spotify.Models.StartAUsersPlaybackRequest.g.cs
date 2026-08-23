
#nullable enable

namespace Spotify
{
    /// <summary>
    /// Example: {"context_uri":"spotify:album:5ht7ItJgpBH7W6vJ5BqpPr","offset":{"position":5},"position_ms":0}
    /// </summary>
    public sealed partial class StartAUsersPlaybackRequest
    {
        /// <summary>
        /// Optional. Spotify URI of the context to play.<br/>
        /// Valid contexts are albums, artists &amp; playlists.<br/>
        /// `{context_uri:"spotify:album:1Je1IMUlBXcx1Fz0WE7oPT"}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_uri")]
        public string? ContextUri { get; set; }

        /// <summary>
        /// Optional. A JSON array of the Spotify track URIs to play.<br/>
        /// For example: `{"uris": ["spotify:track:4iV5W9uYEdYUVa79Axb7Rh", "spotify:track:1301WleyT98MSxVHPZCA6M"]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        /// Optional. Indicates from where in the context playback should start. Only available when context_uri corresponds to an album or playlist object<br/>
        /// "position" is zero based and can’t be negative. Example: `"offset": {"position": 5}`<br/>
        /// "uri" is a string representing the uri of the item to start at. Example: `"offset": {"uri": "spotify:track:1301WleyT98MSxVHPZCA6M"}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public object? Offset { get; set; }

        /// <summary>
        /// integer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_ms")]
        public int? PositionMs { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAUsersPlaybackRequest" /> class.
        /// </summary>
        /// <param name="contextUri">
        /// Optional. Spotify URI of the context to play.<br/>
        /// Valid contexts are albums, artists &amp; playlists.<br/>
        /// `{context_uri:"spotify:album:1Je1IMUlBXcx1Fz0WE7oPT"}`
        /// </param>
        /// <param name="uris">
        /// Optional. A JSON array of the Spotify track URIs to play.<br/>
        /// For example: `{"uris": ["spotify:track:4iV5W9uYEdYUVa79Axb7Rh", "spotify:track:1301WleyT98MSxVHPZCA6M"]}`
        /// </param>
        /// <param name="offset">
        /// Optional. Indicates from where in the context playback should start. Only available when context_uri corresponds to an album or playlist object<br/>
        /// "position" is zero based and can’t be negative. Example: `"offset": {"position": 5}`<br/>
        /// "uri" is a string representing the uri of the item to start at. Example: `"offset": {"uri": "spotify:track:1301WleyT98MSxVHPZCA6M"}`
        /// </param>
        /// <param name="positionMs">
        /// integer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartAUsersPlaybackRequest(
            string? contextUri,
            global::System.Collections.Generic.IList<string>? uris,
            object? offset,
            int? positionMs)
        {
            this.ContextUri = contextUri;
            this.Uris = uris;
            this.Offset = offset;
            this.PositionMs = positionMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAUsersPlaybackRequest" /> class.
        /// </summary>
        public StartAUsersPlaybackRequest()
        {
        }

    }
}