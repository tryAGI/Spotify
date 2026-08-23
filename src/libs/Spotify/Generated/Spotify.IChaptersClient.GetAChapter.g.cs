#nullable enable

namespace Spotify
{
    public partial interface IChaptersClient
    {
        /// <summary>
        /// Get a Chapter<br/>
        /// Get Spotify catalog information for a single audiobook chapter. Chapters are only available within the US, UK, Canada, Ireland, New Zealand and Australia markets.
        /// </summary>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids)<br/>
        /// for the chapter.<br/>
        /// Example: 0D5wENdkdwbqlrHoaJ9g29
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.ChapterObject> GetAChapterAsync(
            string id,
            string? market = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Chapter<br/>
        /// Get Spotify catalog information for a single audiobook chapter. Chapters are only available within the US, UK, Canada, Ireland, New Zealand and Australia markets.
        /// </summary>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids)<br/>
        /// for the chapter.<br/>
        /// Example: 0D5wENdkdwbqlrHoaJ9g29
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.ChapterObject>> GetAChapterAsResponseAsync(
            string id,
            string? market = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}