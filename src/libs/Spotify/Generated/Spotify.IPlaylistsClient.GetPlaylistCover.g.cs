#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Get Playlist Cover Image<br/>
        /// Get the current image associated with a specific playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Spotify.ImageObject>> GetPlaylistCoverAsync(
            string playlistId,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Playlist Cover Image<br/>
        /// Get the current image associated with a specific playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Spotify.ImageObject>>> GetPlaylistCoverAsResponseAsync(
            string playlistId,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}