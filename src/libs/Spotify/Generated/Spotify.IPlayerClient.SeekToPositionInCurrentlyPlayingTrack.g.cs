#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Seek To Position<br/>
        /// Seeks to the given position in the user’s currently playing track. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="positionMs">
        /// The position in milliseconds to seek to. Must be a<br/>
        /// positive number. Passing in a position that is greater than the length of<br/>
        /// the track will cause the player to start playing the next song.<br/>
        /// Example: 25000
        /// </param>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If<br/>
        /// not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task SeekToPositionInCurrentlyPlayingTrackAsync(
            int positionMs,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Seek To Position<br/>
        /// Seeks to the given position in the user’s currently playing track. This API only works for users who have Spotify Premium. The order of execution is not guaranteed when you use this API with other Player API endpoints.
        /// </summary>
        /// <param name="positionMs">
        /// The position in milliseconds to seek to. Must be a<br/>
        /// positive number. Passing in a position that is greater than the length of<br/>
        /// the track will cause the player to start playing the next song.<br/>
        /// Example: 25000
        /// </param>
        /// <param name="deviceId">
        /// The id of the device this command is targeting. If<br/>
        /// not supplied, the user's currently active device is the target.<br/>
        /// Example: 0d1841b0976bae2a3a310dd74c0f3df354899bc8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse> SeekToPositionInCurrentlyPlayingTrackAsResponseAsync(
            int positionMs,
            string? deviceId = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}