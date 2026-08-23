#nullable enable

namespace Spotify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get User's Top Items<br/>
        /// Get the current user's top artists or tracks based on calculated affinity.
        /// </summary>
        /// <param name="type">
        /// The type of entity to return. Valid values: `artists` or `tracks`
        /// </param>
        /// <param name="timeRange">
        /// Over what time frame the affinities are computed. Valid values: `long_term` (calculated from ~1 year of data and including all new data as it becomes available), `medium_term` (approximately last 6 months), `short_term` (approximately last 4 weeks). Default: `medium_term`<br/>
        /// Default Value: medium_term<br/>
        /// Example: medium_term
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>> GetUsersTopArtistsAndTracksAsync(
            global::Spotify.GetUsersTopArtistsAndTracksType type,
            string? timeRange = default,
            int? limit = default,
            int? offset = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User's Top Items<br/>
        /// Get the current user's top artists or tracks based on calculated affinity.
        /// </summary>
        /// <param name="type">
        /// The type of entity to return. Valid values: `artists` or `tracks`
        /// </param>
        /// <param name="timeRange">
        /// Over what time frame the affinities are computed. Valid values: `long_term` (calculated from ~1 year of data and including all new data as it becomes available), `medium_term` (approximately last 6 months), `short_term` (approximately last 4 weeks). Default: `medium_term`<br/>
        /// Default Value: medium_term<br/>
        /// Example: medium_term
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>>> GetUsersTopArtistsAndTracksAsResponseAsync(
            global::Spotify.GetUsersTopArtistsAndTracksType type,
            string? timeRange = default,
            int? limit = default,
            int? offset = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}