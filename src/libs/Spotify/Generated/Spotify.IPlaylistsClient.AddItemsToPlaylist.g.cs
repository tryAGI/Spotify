#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Add Items to Playlist<br/>
        /// Add one or more items to a user's playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="position">
        /// The position to insert the items, a zero-based index. For example, to insert the items in the first position: `position=0`; to insert the items in the third position: `position=2`. If omitted, the items will be appended to the playlist. Items are added in the order they are listed in the query string or request body.<br/>
        /// Example: 0
        /// </param>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to add, can be track or episode URIs. For example:&lt;br/&gt;`uris=spotify:track:4iV5W9uYEdYUVa79Axb7Rh, spotify:track:1301WleyT98MSxVHPZCA6M, spotify:episode:512ojhOuo1ktJprKbVcKyQ`&lt;br/&gt;A maximum of 100 items can be added in one request. &lt;br/&gt;<br/>
        /// _**Note**: it is likely that passing a large number of item URIs as a query parameter will exceed the maximum length of the request URI. When adding a large number of items, it is recommended to pass them in the request body, see below._<br/>
        /// Example: spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AddItemsToPlaylistResponse> AddItemsToPlaylistAsync(
            string playlistId,

            global::Spotify.AddItemsToPlaylistRequest request,
            int? position = default,
            string? uris = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Items to Playlist<br/>
        /// Add one or more items to a user's playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="position">
        /// The position to insert the items, a zero-based index. For example, to insert the items in the first position: `position=0`; to insert the items in the third position: `position=2`. If omitted, the items will be appended to the playlist. Items are added in the order they are listed in the query string or request body.<br/>
        /// Example: 0
        /// </param>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to add, can be track or episode URIs. For example:&lt;br/&gt;`uris=spotify:track:4iV5W9uYEdYUVa79Axb7Rh, spotify:track:1301WleyT98MSxVHPZCA6M, spotify:episode:512ojhOuo1ktJprKbVcKyQ`&lt;br/&gt;A maximum of 100 items can be added in one request. &lt;br/&gt;<br/>
        /// _**Note**: it is likely that passing a large number of item URIs as a query parameter will exceed the maximum length of the request URI. When adding a large number of items, it is recommended to pass them in the request body, see below._<br/>
        /// Example: spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.AddItemsToPlaylistResponse>> AddItemsToPlaylistAsResponseAsync(
            string playlistId,

            global::Spotify.AddItemsToPlaylistRequest request,
            int? position = default,
            string? uris = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Items to Playlist<br/>
        /// Add one or more items to a user's playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="position">
        /// The position to insert the items, a zero-based index. For example, to insert the items in the first position: `position=0`; to insert the items in the third position: `position=2`. If omitted, the items will be appended to the playlist. Items are added in the order they are listed in the query string or request body.<br/>
        /// Example: 0
        /// </param>
        /// <param name="uris">
        /// A comma-separated list of [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to add, can be track or episode URIs. For example:&lt;br/&gt;`uris=spotify:track:4iV5W9uYEdYUVa79Axb7Rh, spotify:track:1301WleyT98MSxVHPZCA6M, spotify:episode:512ojhOuo1ktJprKbVcKyQ`&lt;br/&gt;A maximum of 100 items can be added in one request. &lt;br/&gt;<br/>
        /// _**Note**: it is likely that passing a large number of item URIs as a query parameter will exceed the maximum length of the request URI. When adding a large number of items, it is recommended to pass them in the request body, see below._<br/>
        /// Example: spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M
        /// </param>
        /// <param name="requestUris">
        /// A JSON array of the [Spotify URIs](/documentation/web-api/concepts/spotify-uris-ids) to add. For example: `{"uris": ["spotify:track:4iV5W9uYEdYUVa79Axb7Rh","spotify:track:1301WleyT98MSxVHPZCA6M", "spotify:episode:512ojhOuo1ktJprKbVcKyQ"]}`&lt;br/&gt;A maximum of 100 items can be added in one request. _**Note**: if the `uris` parameter is present in the query string, any URIs listed here in the body will be ignored._
        /// </param>
        /// <param name="requestPosition">
        /// The position to insert the items, a zero-based index. For example, to insert the items in the first position: `position=0` ; to insert the items in the third position: `position=2`. If omitted, the items will be appended to the playlist. Items are added in the order they appear in the uris array. For example: `{"uris": ["spotify:track:4iV5W9uYEdYUVa79Axb7Rh","spotify:track:1301WleyT98MSxVHPZCA6M"], "position": 3}`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AddItemsToPlaylistResponse> AddItemsToPlaylistAsync(
            string playlistId,
            int? position = default,
            string? uris = default,
            global::System.Collections.Generic.IList<string>? requestUris = default,
            int? requestPosition = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}