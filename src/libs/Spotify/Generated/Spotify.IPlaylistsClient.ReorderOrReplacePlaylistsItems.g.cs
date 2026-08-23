#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Update Playlist Items<br/>
        /// Either reorder or replace items in a playlist depending on the request's parameters.<br/>
        /// To reorder items, include `range_start`, `insert_before`, `range_length` and `snapshot_id` in the request's body.<br/>
        /// To replace items, include `uris` as either a query parameter or in the request's body.<br/>
        /// Replacing items in a playlist will overwrite its existing items. This operation can be used for replacing or clearing items in a playlist.<br/>
        /// &lt;br/&gt;<br/>
        /// **Note**: Replace and reorder are mutually exclusive operations which share the same endpoint, but have different parameters.<br/>
        /// These operations can't be applied together in a single request.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to set, can be track or episode URIs. For example: `uris=spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M,spotify:episode:512ojhOuo1ktJprKbVcKyQ`&lt;br/&gt;A maximum of 100 items can be set in one request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.ReorderOrReplacePlaylistsItemsResponse> ReorderOrReplacePlaylistsItemsAsync(
            string playlistId,

            global::Spotify.ReorderOrReplacePlaylistsItemsRequest request,
            string? uris = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Playlist Items<br/>
        /// Either reorder or replace items in a playlist depending on the request's parameters.<br/>
        /// To reorder items, include `range_start`, `insert_before`, `range_length` and `snapshot_id` in the request's body.<br/>
        /// To replace items, include `uris` as either a query parameter or in the request's body.<br/>
        /// Replacing items in a playlist will overwrite its existing items. This operation can be used for replacing or clearing items in a playlist.<br/>
        /// &lt;br/&gt;<br/>
        /// **Note**: Replace and reorder are mutually exclusive operations which share the same endpoint, but have different parameters.<br/>
        /// These operations can't be applied together in a single request.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to set, can be track or episode URIs. For example: `uris=spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M,spotify:episode:512ojhOuo1ktJprKbVcKyQ`&lt;br/&gt;A maximum of 100 items can be set in one request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.ReorderOrReplacePlaylistsItemsResponse>> ReorderOrReplacePlaylistsItemsAsResponseAsync(
            string playlistId,

            global::Spotify.ReorderOrReplacePlaylistsItemsRequest request,
            string? uris = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Playlist Items<br/>
        /// Either reorder or replace items in a playlist depending on the request's parameters.<br/>
        /// To reorder items, include `range_start`, `insert_before`, `range_length` and `snapshot_id` in the request's body.<br/>
        /// To replace items, include `uris` as either a query parameter or in the request's body.<br/>
        /// Replacing items in a playlist will overwrite its existing items. This operation can be used for replacing or clearing items in a playlist.<br/>
        /// &lt;br/&gt;<br/>
        /// **Note**: Replace and reorder are mutually exclusive operations which share the same endpoint, but have different parameters.<br/>
        /// These operations can't be applied together in a single request.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to set, can be track or episode URIs. For example: `uris=spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M,spotify:episode:512ojhOuo1ktJprKbVcKyQ`&lt;br/&gt;A maximum of 100 items can be set in one request.
        /// </param>
        /// <param name="requestUris"></param>
        /// <param name="rangeStart">
        /// The position of the first item to be reordered.
        /// </param>
        /// <param name="insertBefore">
        /// The position where the items should be inserted.&lt;br/&gt;To reorder the items to the end of the playlist, simply set _insert_before_ to the position after the last item.&lt;br/&gt;Examples:&lt;br/&gt;To reorder the first item to the last position in a playlist with 10 items, set _range_start_ to 0, and _insert_before_ to 10.&lt;br/&gt;To reorder the last item in a playlist with 10 items to the start of the playlist, set _range_start_ to 9, and _insert_before_ to 0.
        /// </param>
        /// <param name="rangeLength">
        /// The amount of items to be reordered. Defaults to 1 if not set.&lt;br/&gt;The range of items to be reordered begins from the _range_start_ position, and includes the _range_length_ subsequent items.&lt;br/&gt;Example:&lt;br/&gt;To move the items at index 9-10 to the start of the playlist, _range_start_ is set to 9, and _range_length_ is set to 2.
        /// </param>
        /// <param name="snapshotId">
        /// The playlist's snapshot ID against which you want to make the changes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.ReorderOrReplacePlaylistsItemsResponse> ReorderOrReplacePlaylistsItemsAsync(
            string playlistId,
            string? uris = default,
            global::System.Collections.Generic.IList<string>? requestUris = default,
            int? rangeStart = default,
            int? insertBefore = default,
            int? rangeLength = default,
            string? snapshotId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}