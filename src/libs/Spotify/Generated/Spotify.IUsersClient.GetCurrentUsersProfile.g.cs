#nullable enable

namespace Spotify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get Current User's Profile<br/>
        /// Get detailed profile information about the current user (including the<br/>
        /// current user's username).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PrivateUserObject> GetCurrentUsersProfileAsync(
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Current User's Profile<br/>
        /// Get detailed profile information about the current user (including the<br/>
        /// current user's username).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PrivateUserObject>> GetCurrentUsersProfileAsResponseAsync(
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}