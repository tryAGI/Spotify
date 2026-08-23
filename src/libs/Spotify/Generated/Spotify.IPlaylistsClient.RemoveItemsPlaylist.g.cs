#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Remove Playlist Items<br/>
        /// Remove one or more items from a user's playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.RemoveItemsPlaylistResponse> RemoveItemsPlaylistAsync(
            string playlistId,

            global::Spotify.RemoveItemsPlaylistRequest request,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Playlist Items<br/>
        /// Remove one or more items from a user's playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.RemoveItemsPlaylistResponse>> RemoveItemsPlaylistAsResponseAsync(
            string playlistId,

            global::Spotify.RemoveItemsPlaylistRequest request,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Playlist Items<br/>
        /// Remove one or more items from a user's playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="items">
        /// An array of objects containing [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) of the tracks or episodes to remove.<br/>
        /// For example: `{ "items": [{ "uri": "spotify:track:4iV5W9uYEdYUVa79Axb7Rh" },{ "uri": "spotify:track:1301WleyT98MSxVHPZCA6M" }] }`. A maximum of 100 objects can be sent at once.
        /// </param>
        /// <param name="snapshotId">
        /// The playlist's snapshot ID against which you want to make the changes.<br/>
        /// The API will validate that the specified items exist and in the specified positions and make the changes,<br/>
        /// even if more recent changes have been made to the playlist.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.RemoveItemsPlaylistResponse> RemoveItemsPlaylistAsync(
            string playlistId,
            global::System.Collections.Generic.IList<global::Spotify.RemoveItemsPlaylistRequestItem> items,
            string? snapshotId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}