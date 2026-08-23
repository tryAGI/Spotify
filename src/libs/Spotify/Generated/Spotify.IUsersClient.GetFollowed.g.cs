#nullable enable

namespace Spotify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get Followed Artists<br/>
        /// Get the current user's followed artists.
        /// </summary>
        /// <param name="type">
        /// The ID type: currently only `artist` is supported.<br/>
        /// Example: artist
        /// </param>
        /// <param name="after">
        /// The last artist ID retrieved from the previous request.<br/>
        /// Example: 0I2XqVXqHScXjHhk6AYYRe
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20\. Minimum: 1\. Maximum: 50\.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.GetFollowedResponse> GetFollowedAsync(
            global::Spotify.GetFollowedType type,
            string? after = default,
            int? limit = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Followed Artists<br/>
        /// Get the current user's followed artists.
        /// </summary>
        /// <param name="type">
        /// The ID type: currently only `artist` is supported.<br/>
        /// Example: artist
        /// </param>
        /// <param name="after">
        /// The last artist ID retrieved from the previous request.<br/>
        /// Example: 0I2XqVXqHScXjHhk6AYYRe
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20\. Minimum: 1\. Maximum: 50\.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.GetFollowedResponse>> GetFollowedAsResponseAsync(
            global::Spotify.GetFollowedType type,
            string? after = default,
            int? limit = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}