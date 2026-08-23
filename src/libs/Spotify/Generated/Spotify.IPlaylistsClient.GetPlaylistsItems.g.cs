#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Get Playlist Items<br/>
        /// Get full details of the items of a playlist owned by a Spotify user.<br/>
        /// **Note**: This endpoint is only accessible for playlists owned by the current user or playlists the user is a collaborator of. A `403 Forbidden` status code will be returned if the user is neither the owner nor a collaborator of the playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="market">
        /// An [ISO 3166-1 alpha-2 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).<br/>
        ///   If a country code is specified, only content that is available in that market will be returned.&lt;br/&gt;<br/>
        ///   If a valid user access token is specified in the request header, the country associated with<br/>
        ///   the user account will take priority over this parameter.&lt;br/&gt;<br/>
        ///   _**Note**: If neither market or user country are provided, the content is considered unavailable for the client._&lt;br/&gt;<br/>
        ///   Users can view the country that is associated with their account in the [account settings](https://www.spotify.com/account/overview/).<br/>
        /// Example: ES
        /// </param>
        /// <param name="fields">
        /// Filters for the query: a comma-separated list of the<br/>
        /// fields to return. If omitted, all fields are returned. For example, to get<br/>
        /// just the total number of items and the request limit:&lt;br/&gt;`fields=total,limit`&lt;br/&gt;A<br/>
        /// dot separator can be used to specify non-reoccurring fields, while parentheses<br/>
        /// can be used to specify reoccurring fields within objects. For example, to<br/>
        /// get just the added date and user ID of the adder:&lt;br/&gt;`fields=items(added_at,added_by.id)`&lt;br/&gt;Use<br/>
        /// multiple parentheses to drill down into nested objects, for example:&lt;br/&gt;`fields=items(track(name,href,album(name,href)))`&lt;br/&gt;Fields<br/>
        /// can be excluded by prefixing them with an exclamation mark, for example:&lt;br/&gt;`fields=items.track.album(!external_urls,images)`<br/>
        /// Example: items(added_by.id,track(name,href,album(name,href)))
        /// </param>
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
        /// <param name="additionalTypes">
        /// A comma-separated list of item types that your client supports besides the default `track` type. Valid types are: `track` and `episode`.&lt;br/&gt;<br/>
        /// _**Note**: This parameter was introduced to allow existing clients to maintain their current behaviour and might be deprecated in the future._&lt;br/&gt;<br/>
        /// In addition to providing this parameter, make sure that your client properly handles cases of new types in the future by checking against the `type` field of each object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PagingPlaylistTrackObject> GetPlaylistsItemsAsync(
            string playlistId,
            string? market = default,
            string? fields = default,
            int? limit = default,
            int? offset = default,
            string? additionalTypes = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Playlist Items<br/>
        /// Get full details of the items of a playlist owned by a Spotify user.<br/>
        /// **Note**: This endpoint is only accessible for playlists owned by the current user or playlists the user is a collaborator of. A `403 Forbidden` status code will be returned if the user is neither the owner nor a collaborator of the playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="market">
        /// An [ISO 3166-1 alpha-2 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).<br/>
        ///   If a country code is specified, only content that is available in that market will be returned.&lt;br/&gt;<br/>
        ///   If a valid user access token is specified in the request header, the country associated with<br/>
        ///   the user account will take priority over this parameter.&lt;br/&gt;<br/>
        ///   _**Note**: If neither market or user country are provided, the content is considered unavailable for the client._&lt;br/&gt;<br/>
        ///   Users can view the country that is associated with their account in the [account settings](https://www.spotify.com/account/overview/).<br/>
        /// Example: ES
        /// </param>
        /// <param name="fields">
        /// Filters for the query: a comma-separated list of the<br/>
        /// fields to return. If omitted, all fields are returned. For example, to get<br/>
        /// just the total number of items and the request limit:&lt;br/&gt;`fields=total,limit`&lt;br/&gt;A<br/>
        /// dot separator can be used to specify non-reoccurring fields, while parentheses<br/>
        /// can be used to specify reoccurring fields within objects. For example, to<br/>
        /// get just the added date and user ID of the adder:&lt;br/&gt;`fields=items(added_at,added_by.id)`&lt;br/&gt;Use<br/>
        /// multiple parentheses to drill down into nested objects, for example:&lt;br/&gt;`fields=items(track(name,href,album(name,href)))`&lt;br/&gt;Fields<br/>
        /// can be excluded by prefixing them with an exclamation mark, for example:&lt;br/&gt;`fields=items.track.album(!external_urls,images)`<br/>
        /// Example: items(added_by.id,track(name,href,album(name,href)))
        /// </param>
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
        /// <param name="additionalTypes">
        /// A comma-separated list of item types that your client supports besides the default `track` type. Valid types are: `track` and `episode`.&lt;br/&gt;<br/>
        /// _**Note**: This parameter was introduced to allow existing clients to maintain their current behaviour and might be deprecated in the future._&lt;br/&gt;<br/>
        /// In addition to providing this parameter, make sure that your client properly handles cases of new types in the future by checking against the `type` field of each object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PagingPlaylistTrackObject>> GetPlaylistsItemsAsResponseAsync(
            string playlistId,
            string? market = default,
            string? fields = default,
            int? limit = default,
            int? offset = default,
            string? additionalTypes = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}