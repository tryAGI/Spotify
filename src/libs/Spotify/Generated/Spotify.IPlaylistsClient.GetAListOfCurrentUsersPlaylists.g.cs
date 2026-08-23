#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Get Current User's Playlists<br/>
        /// Get a list of the playlists owned or followed by the current Spotify<br/>
        /// user.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// 'The index of the first playlist to return. Default:<br/>
        /// 0 (the first object). Maximum offset: 100.000\. Use with `limit` to get the<br/>
        /// next set of playlists.'<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PagingPlaylistObject> GetAListOfCurrentUsersPlaylistsAsync(
            int? limit = default,
            int? offset = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Current User's Playlists<br/>
        /// Get a list of the playlists owned or followed by the current Spotify<br/>
        /// user.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// 'The index of the first playlist to return. Default:<br/>
        /// 0 (the first object). Maximum offset: 100.000\. Use with `limit` to get the<br/>
        /// next set of playlists.'<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PagingPlaylistObject>> GetAListOfCurrentUsersPlaylistsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}