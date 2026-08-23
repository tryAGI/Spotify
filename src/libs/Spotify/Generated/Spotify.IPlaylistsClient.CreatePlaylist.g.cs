#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Create Playlist<br/>
        /// Create a playlist for the current Spotify user. (The playlist will be empty until<br/>
        /// you [add tracks](/documentation/web-api/reference/add-tracks-to-playlist).)<br/>
        /// Each user is generally limited to a maximum of 11000 playlists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PlaylistObject> CreatePlaylistAsync(

            global::Spotify.CreatePlaylistRequest request,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Playlist<br/>
        /// Create a playlist for the current Spotify user. (The playlist will be empty until<br/>
        /// you [add tracks](/documentation/web-api/reference/add-tracks-to-playlist).)<br/>
        /// Each user is generally limited to a maximum of 11000 playlists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PlaylistObject>> CreatePlaylistAsResponseAsync(

            global::Spotify.CreatePlaylistRequest request,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Playlist<br/>
        /// Create a playlist for the current Spotify user. (The playlist will be empty until<br/>
        /// you [add tracks](/documentation/web-api/reference/add-tracks-to-playlist).)<br/>
        /// Each user is generally limited to a maximum of 11000 playlists.
        /// </summary>
        /// <param name="name">
        /// The name for the new playlist, for example `"Your Coolest Playlist"`. This name does not need to be unique; a user may have several playlists with the same name.
        /// </param>
        /// <param name="public">
        /// Defaults to `true`. The playlist's public/private status (if it should be added to the user's profile or not): `true` the playlist will be public, `false` the playlist will be private. To be able to create private playlists, the user must have granted the `playlist-modify-private` [scope](/documentation/web-api/concepts/scopes/#list-of-scopes). For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </param>
        /// <param name="collaborative">
        /// Defaults to `false`. If `true` the playlist will be collaborative. _**Note**: to create a collaborative playlist you must also set `public` to `false`. To create collaborative playlists you must have granted `playlist-modify-private` and `playlist-modify-public` [scopes](/documentation/web-api/concepts/scopes/#list-of-scopes)._
        /// </param>
        /// <param name="description">
        /// value for playlist description as displayed in Spotify Clients and in the Web API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PlaylistObject> CreatePlaylistAsync(
            string name,
            bool? @public = default,
            bool? collaborative = default,
            string? description = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}