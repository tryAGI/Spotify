#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Start/Resume Playback<br/>
        /// Start a new context or resume current playback on the user's active device. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task StartAUsersPlaybackAsync(

            global::Spotify.StartAUsersPlaybackRequest request,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start/Resume Playback<br/>
        /// Start a new context or resume current playback on the user's active device. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse> StartAUsersPlaybackAsResponseAsync(

            global::Spotify.StartAUsersPlaybackRequest request,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start/Resume Playback<br/>
        /// Start a new context or resume current playback on the user's active device. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="contextUri">
        /// Optional. Spotify URI of the context to play.<br/>
        /// Valid contexts are albums, artists &amp; playlists.<br/>
        /// `{context_uri:"spotify:album:1Je1IMUlBXcx1Fz0WE7oPT"}`
        /// </param>
        /// <param name="uris">
        /// Optional. A JSON array of the Spotify track URIs to play.<br/>
        /// For example: `{"uris": ["spotify:track:4iV5W9uYEdYUVa79Axb7Rh", "spotify:track:1301WleyT98MSxVHPZCA6M"]}`
        /// </param>
        /// <param name="offset">
        /// Optional. Indicates from where in the context playback should start. Only available when context_uri corresponds to an album or playlist object<br/>
        /// "position" is zero based and can’t be negative. Example: `"offset": {"position": 5}`<br/>
        /// "uri" is a string representing the uri of the item to start at. Example: `"offset": {"uri": "spotify:track:1301WleyT98MSxVHPZCA6M"}`
        /// </param>
        /// <param name="positionMs">
        /// integer
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StartAUsersPlaybackAsync(
            string? deviceId = default,
            string? contextUri = default,
            global::System.Collections.Generic.IList<string>? uris = default,
            object? offset = default,
            int? positionMs = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}