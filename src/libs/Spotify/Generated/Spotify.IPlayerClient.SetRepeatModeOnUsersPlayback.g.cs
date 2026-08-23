#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Set Repeat Mode<br/>
        /// Set the repeat mode for the user's playback. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="state">
        /// **track**, **context** or **off**.&lt;br/&gt;<br/>
        /// **track** will repeat the current track.&lt;br/&gt;<br/>
        /// **context** will repeat the current context.&lt;br/&gt;<br/>
        /// **off** will turn repeat off.<br/>
        /// Example: context
        /// </param>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If<br/>
        /// not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task SetRepeatModeOnUsersPlaybackAsync(
            string state,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Repeat Mode<br/>
        /// Set the repeat mode for the user's playback. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="state">
        /// **track**, **context** or **off**.&lt;br/&gt;<br/>
        /// **track** will repeat the current track.&lt;br/&gt;<br/>
        /// **context** will repeat the current context.&lt;br/&gt;<br/>
        /// **off** will turn repeat off.<br/>
        /// Example: context
        /// </param>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If<br/>
        /// not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse> SetRepeatModeOnUsersPlaybackAsResponseAsync(
            string state,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}