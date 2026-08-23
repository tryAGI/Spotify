#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Toggle Playback Shuffle<br/>
        /// Toggle shuffle on or off for user’s playback. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="state">
        /// **true** : Shuffle user's playback.&lt;br/&gt;<br/>
        /// **false** : Do not shuffle user's playback.<br/>
        /// Example: true
        /// </param>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If<br/>
        /// not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task ToggleShuffleForUsersPlaybackAsync(
            bool state,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toggle Playback Shuffle<br/>
        /// Toggle shuffle on or off for user’s playback. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="state">
        /// **true** : Shuffle user's playback.&lt;br/&gt;<br/>
        /// **false** : Do not shuffle user's playback.<br/>
        /// Example: true
        /// </param>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If<br/>
        /// not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse> ToggleShuffleForUsersPlaybackAsResponseAsync(
            bool state,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}