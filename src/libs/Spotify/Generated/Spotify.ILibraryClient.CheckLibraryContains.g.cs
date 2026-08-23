#nullable enable

namespace Spotify
{
    public partial interface ILibraryClient
    {
        /// <summary>
        /// Check User's Saved Items<br/>
        /// Check if one or more items are already saved in the current user's library. Accepts Spotify URIs for tracks, albums, episodes, shows, audiobooks, artists, users, and playlists.
        /// </summary>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids). Maximum: 40 URIs.<br/>
        /// Supported URI types:<br/>
        /// - `spotify:track:{id}`<br/>
        /// - `spotify:album:{id}`<br/>
        /// - `spotify:episode:{id}`<br/>
        /// - `spotify:show:{id}`<br/>
        /// - `spotify:audiobook:{id}`<br/>
        /// - `spotify:artist:{id}`<br/>
        /// - `spotify:user:{id}`<br/>
        /// - `spotify:playlist:{id}`<br/>
        /// Example: spotify:track:7a3LWj5xSFhFRYmztS8wgK,spotify:album:4aawyAB9vmqN3uQ7FjRGTy,spotify:artist:2takcwOaAZWiXQijPHIx7B
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<bool>> CheckLibraryContainsAsync(
            string uris,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check User's Saved Items<br/>
        /// Check if one or more items are already saved in the current user's library. Accepts Spotify URIs for tracks, albums, episodes, shows, audiobooks, artists, users, and playlists.
        /// </summary>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids). Maximum: 40 URIs.<br/>
        /// Supported URI types:<br/>
        /// - `spotify:track:{id}`<br/>
        /// - `spotify:album:{id}`<br/>
        /// - `spotify:episode:{id}`<br/>
        /// - `spotify:show:{id}`<br/>
        /// - `spotify:audiobook:{id}`<br/>
        /// - `spotify:artist:{id}`<br/>
        /// - `spotify:user:{id}`<br/>
        /// - `spotify:playlist:{id}`<br/>
        /// Example: spotify:track:7a3LWj5xSFhFRYmztS8wgK,spotify:album:4aawyAB9vmqN3uQ7FjRGTy,spotify:artist:2takcwOaAZWiXQijPHIx7B
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<bool>>> CheckLibraryContainsAsResponseAsync(
            string uris,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}