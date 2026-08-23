#nullable enable

namespace Spotify
{
    public partial interface IShowsClient
    {
        /// <summary>
        /// Get User's Saved Shows<br/>
        /// Get a list of shows saved in the current Spotify user's library. Optional parameters can be used to limit the number of shows returned.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// The index of the first item to return. Default: 0 (the first item). Use with limit to get the next set of items.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PagingSavedShowObject> GetUsersSavedShowsAsync(
            int? limit = default,
            int? offset = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User's Saved Shows<br/>
        /// Get a list of shows saved in the current Spotify user's library. Optional parameters can be used to limit the number of shows returned.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// The index of the first item to return. Default: 0 (the first item). Use with limit to get the next set of items.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PagingSavedShowObject>> GetUsersSavedShowsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}