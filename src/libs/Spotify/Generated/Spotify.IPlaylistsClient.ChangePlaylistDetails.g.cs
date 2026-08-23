#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Change Playlist Details<br/>
        /// Change a playlist's name and public/private state. (The user must, of<br/>
        /// course, own the playlist.)
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task ChangePlaylistDetailsAsync(
            string playlistId,

            global::Spotify.ChangePlaylistDetailsRequest request,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Playlist Details<br/>
        /// Change a playlist's name and public/private state. (The user must, of<br/>
        /// course, own the playlist.)
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse> ChangePlaylistDetailsAsResponseAsync(
            string playlistId,

            global::Spotify.ChangePlaylistDetailsRequest request,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Playlist Details<br/>
        /// Change a playlist's name and public/private state. (The user must, of<br/>
        /// course, own the playlist.)
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ChangePlaylistDetailsAsync(
            string playlistId,
            string? name = default,
            bool? @public = default,
            bool? collaborative = default,
            string? description = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}