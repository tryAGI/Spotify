#nullable enable

namespace Spotify
{
    public partial interface IPlayerClient
    {
        /// <summary>
        /// Get Available Devices<br/>
        /// Get information about a user’s available Spotify Connect devices. Some device models are not supported and will not be listed in the API response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.GetAUsersAvailableDevicesResponse> GetAUsersAvailableDevicesAsync(
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Available Devices<br/>
        /// Get information about a user’s available Spotify Connect devices. Some device models are not supported and will not be listed in the API response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.GetAUsersAvailableDevicesResponse>> GetAUsersAvailableDevicesAsResponseAsync(
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}