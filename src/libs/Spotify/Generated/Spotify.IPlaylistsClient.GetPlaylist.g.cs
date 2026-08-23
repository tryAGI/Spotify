#nullable enable

namespace Spotify
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Get Playlist<br/>
        /// Get a playlist owned by a Spotify user.
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
        /// just the playlist''s description and URI: `fields=description,uri`. A dot<br/>
        /// separator can be used to specify non-reoccurring fields, while parentheses<br/>
        /// can be used to specify reoccurring fields within objects. For example, to<br/>
        /// get just the added date and user ID of the adder: `fields=tracks.items(added_at,added_by.id)`.<br/>
        /// Use multiple parentheses to drill down into nested objects, for example: `fields=tracks.items(track(name,href,album(name,href)))`.<br/>
        /// Fields can be excluded by prefixing them with an exclamation mark, for example:<br/>
        /// `fields=tracks.items(track(name,href,album(!name,href)))`<br/>
        /// Example: items(added_by.id,track(name,href,album(name,href)))
        /// </param>
        /// <param name="additionalTypes">
        /// A comma-separated list of item types that your client supports besides the default `track` type. Valid types are: `track` and `episode`.&lt;br/&gt;<br/>
        /// _**Note**: This parameter was introduced to allow existing clients to maintain their current behaviour and might be deprecated in the future._&lt;br/&gt;<br/>
        /// In addition to providing this parameter, make sure that your client properly handles cases of new types in the future by checking against the `type` field of each object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.PlaylistObject> GetPlaylistAsync(
            string playlistId,
            string? market = default,
            string? fields = default,
            string? additionalTypes = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Playlist<br/>
        /// Get a playlist owned by a Spotify user.
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
        /// just the playlist''s description and URI: `fields=description,uri`. A dot<br/>
        /// separator can be used to specify non-reoccurring fields, while parentheses<br/>
        /// can be used to specify reoccurring fields within objects. For example, to<br/>
        /// get just the added date and user ID of the adder: `fields=tracks.items(added_at,added_by.id)`.<br/>
        /// Use multiple parentheses to drill down into nested objects, for example: `fields=tracks.items(track(name,href,album(name,href)))`.<br/>
        /// Fields can be excluded by prefixing them with an exclamation mark, for example:<br/>
        /// `fields=tracks.items(track(name,href,album(!name,href)))`<br/>
        /// Example: items(added_by.id,track(name,href,album(name,href)))
        /// </param>
        /// <param name="additionalTypes">
        /// A comma-separated list of item types that your client supports besides the default `track` type. Valid types are: `track` and `episode`.&lt;br/&gt;<br/>
        /// _**Note**: This parameter was introduced to allow existing clients to maintain their current behaviour and might be deprecated in the future._&lt;br/&gt;<br/>
        /// In addition to providing this parameter, make sure that your client properly handles cases of new types in the future by checking against the `type` field of each object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PlaylistObject>> GetPlaylistAsResponseAsync(
            string playlistId,
            string? market = default,
            string? fields = default,
            string? additionalTypes = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}