#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Get the User's Queue<br/>
        /// Get the list of objects that make up the user's queue.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.QueueObject> GetQueueAsync(
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the User's Queue<br/>
        /// Get the list of objects that make up the user's queue.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.QueueObject>> GetQueueAsResponseAsync(
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}