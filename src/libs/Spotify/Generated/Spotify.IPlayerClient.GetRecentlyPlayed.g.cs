#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Get Recently Played Tracks<br/>
        /// Get tracks from the current user's recently played tracks.<br/>
        /// _**Note**: Currently doesn't support podcast episodes._
        /// </summary>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="after">
        /// A Unix timestamp in milliseconds. Returns all items<br/>
        /// after (but not including) this cursor position. If `after` is specified, `before`<br/>
        /// must not be specified.<br/>
        /// Example: 1484811043508
        /// </param>
        /// <param name="before">
        /// A Unix timestamp in milliseconds. Returns all items<br/>
        /// before (but not including) this cursor position. If `before` is specified,<br/>
        /// `after` must not be specified.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.CursorPagingPlayHistoryObject> GetRecentlyPlayedAsync(
            int? limit = default,
            int? after = default,
            int? before = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Recently Played Tracks<br/>
        /// Get tracks from the current user's recently played tracks.<br/>
        /// _**Note**: Currently doesn't support podcast episodes._
        /// </summary>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="after">
        /// A Unix timestamp in milliseconds. Returns all items<br/>
        /// after (but not including) this cursor position. If `after` is specified, `before`<br/>
        /// must not be specified.<br/>
        /// Example: 1484811043508
        /// </param>
        /// <param name="before">
        /// A Unix timestamp in milliseconds. Returns all items<br/>
        /// before (but not including) this cursor position. If `before` is specified,<br/>
        /// `after` must not be specified.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.CursorPagingPlayHistoryObject>> GetRecentlyPlayedAsResponseAsync(
            int? limit = default,
            int? after = default,
            int? before = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}