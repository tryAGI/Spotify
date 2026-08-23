#nullable enable

namespace Spotify
{
    public partial interface ILibraryClient
    {
        /// <summary>
        /// Remove Items from Library<br/>
        /// Remove one or more items from the current user's library. Accepts Spotify URIs for tracks, albums, episodes, shows, audiobooks, users, and playlists.
        /// </summary>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids). Maximum: 40 URIs.<br/>
        /// Supported URI types:<br/>
        /// - `spotify:track:{id}`<br/>
        /// - `spotify:album:{id}`<br/>
        /// - `spotify:episode:{id}`<br/>
        /// - `spotify:show:{id}`<br/>
        /// - `spotify:audiobook:{id}`<br/>
        /// - `spotify:user:{id}`<br/>
        /// - `spotify:playlist:{id}`<br/>
        /// Example: spotify:track:7a3LWj5xSFhFRYmztS8wgK,spotify:album:4aawyAB9vmqN3uQ7FjRGTy
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveLibraryItemsAsync(
            string uris,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Items from Library<br/>
        /// Remove one or more items from the current user's library. Accepts Spotify URIs for tracks, albums, episodes, shows, audiobooks, users, and playlists.
        /// </summary>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids). Maximum: 40 URIs.<br/>
        /// Supported URI types:<br/>
        /// - `spotify:track:{id}`<br/>
        /// - `spotify:album:{id}`<br/>
        /// - `spotify:episode:{id}`<br/>
        /// - `spotify:show:{id}`<br/>
        /// - `spotify:audiobook:{id}`<br/>
        /// - `spotify:user:{id}`<br/>
        /// - `spotify:playlist:{id}`<br/>
        /// Example: spotify:track:7a3LWj5xSFhFRYmztS8wgK,spotify:album:4aawyAB9vmqN3uQ7FjRGTy
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse> RemoveLibraryItemsAsResponseAsync(
            string uris,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}