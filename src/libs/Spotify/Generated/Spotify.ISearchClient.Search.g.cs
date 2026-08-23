#nullable enable

namespace Spotify
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search for Item<br/>
        /// Get Spotify catalog information about albums, artists, playlists, tracks, shows, episodes or audiobooks<br/>
        /// that match a keyword string. Audiobooks are only available within the US, UK, Canada, Ireland, New Zealand and Australia markets.
        /// </summary>
        /// <param name="q">
        /// Your search query.<br/>
        /// You can narrow down your search using field filters. The available filters are `album`, `artist`, `track`, `year`, `upc`, `tag:hipster`, `tag:new`, `isrc`, and `genre`. Each field filter only applies to certain result types.<br/>
        /// The `artist` and `year` filters can be used while searching albums, artists and tracks. You can filter on a single `year` or a range (e.g. 1955-1960).&lt;br /&gt;<br/>
        /// The `album` filter can be used while searching albums and tracks.&lt;br /&gt;<br/>
        /// The `genre` filter can be used while searching artists and tracks.&lt;br /&gt;<br/>
        /// The `isrc` and `track` filters can be used while searching tracks.&lt;br /&gt;<br/>
        /// The `upc`, `tag:new` and `tag:hipster` filters can only be used while searching albums. The `tag:new` filter will return albums released in the past two weeks and `tag:hipster` can be used to return only albums with the lowest 10% popularity.&lt;br /&gt;<br/>
        /// Example: remaster%20track:Doxy%20artist:Miles%20Davis
        /// </param>
        /// <param name="type">
        /// A comma-separated list of item types to search across. Search results include hits<br/>
        /// from all the specified item types. For example: `q=abacab&amp;type=album,track` returns<br/>
        /// both albums and tracks matching "abacab".
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
        /// <param name="limit">
        /// The maximum number of results to return in each item type.<br/>
        /// Default Value: 5<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// The index of the first result to return. Use<br/>
        /// with limit to get the next page of search results.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="includeExternal">
        /// If `include_external=audio` is specified it signals that the client can play externally hosted audio content, and marks<br/>
        /// the content as playable in the response. By default externally hosted audio content is marked as unplayable in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.SearchResponse> SearchAsync(
            string q,
            global::System.Collections.Generic.IList<global::Spotify.SearchTypeItem> type,
            string? market = default,
            int? limit = default,
            int? offset = default,
            global::Spotify.SearchIncludeExternal? includeExternal = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for Item<br/>
        /// Get Spotify catalog information about albums, artists, playlists, tracks, shows, episodes or audiobooks<br/>
        /// that match a keyword string. Audiobooks are only available within the US, UK, Canada, Ireland, New Zealand and Australia markets.
        /// </summary>
        /// <param name="q">
        /// Your search query.<br/>
        /// You can narrow down your search using field filters. The available filters are `album`, `artist`, `track`, `year`, `upc`, `tag:hipster`, `tag:new`, `isrc`, and `genre`. Each field filter only applies to certain result types.<br/>
        /// The `artist` and `year` filters can be used while searching albums, artists and tracks. You can filter on a single `year` or a range (e.g. 1955-1960).&lt;br /&gt;<br/>
        /// The `album` filter can be used while searching albums and tracks.&lt;br /&gt;<br/>
        /// The `genre` filter can be used while searching artists and tracks.&lt;br /&gt;<br/>
        /// The `isrc` and `track` filters can be used while searching tracks.&lt;br /&gt;<br/>
        /// The `upc`, `tag:new` and `tag:hipster` filters can only be used while searching albums. The `tag:new` filter will return albums released in the past two weeks and `tag:hipster` can be used to return only albums with the lowest 10% popularity.&lt;br /&gt;<br/>
        /// Example: remaster%20track:Doxy%20artist:Miles%20Davis
        /// </param>
        /// <param name="type">
        /// A comma-separated list of item types to search across. Search results include hits<br/>
        /// from all the specified item types. For example: `q=abacab&amp;type=album,track` returns<br/>
        /// both albums and tracks matching "abacab".
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
        /// <param name="limit">
        /// The maximum number of results to return in each item type.<br/>
        /// Default Value: 5<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// The index of the first result to return. Use<br/>
        /// with limit to get the next page of search results.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="includeExternal">
        /// If `include_external=audio` is specified it signals that the client can play externally hosted audio content, and marks<br/>
        /// the content as playable in the response. By default externally hosted audio content is marked as unplayable in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.SearchResponse>> SearchAsResponseAsync(
            string q,
            global::System.Collections.Generic.IList<global::Spotify.SearchTypeItem> type,
            string? market = default,
            int? limit = default,
            int? offset = default,
            global::Spotify.SearchIncludeExternal? includeExternal = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}