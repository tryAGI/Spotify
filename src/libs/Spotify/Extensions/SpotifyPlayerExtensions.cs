using System.Net;

namespace Spotify;

/// <summary>Spotify playback helpers for documented success responses without a JSON body.</summary>
public static class SpotifyPlayerExtensions
{
    /// <summary>
    /// Gets the current playback state, or <see langword="null"/> when Spotify returns HTTP 204
    /// because the user has no active playback session.
    /// </summary>
    public static async Task<CurrentlyPlayingContextObject?> GetCurrentPlaybackOrDefaultAsync(
        this IPlayerClient client,
        string? market = null,
        string? additionalTypes = null,
        AutoSDKRequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        try
        {
            return await client.GetInformationAboutTheUsersCurrentPlaybackAsync(
                market,
                additionalTypes,
                requestOptions,
                cancellationToken).ConfigureAwait(false);
        }
        catch (ApiException exception) when (exception.StatusCode == HttpStatusCode.NoContent)
        {
            return null;
        }
    }
}
