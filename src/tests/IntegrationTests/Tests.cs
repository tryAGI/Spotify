namespace Spotify.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SpotifyClient GetAuthenticatedClient()
    {
        var accessToken =
            Environment.GetEnvironmentVariable("SPOTIFY_ACCESS_TOKEN") is { Length: > 0 } accessTokenValue
                ? accessTokenValue
                : throw new AssertInconclusiveException("SPOTIFY_ACCESS_TOKEN environment variable is not found.");

        var client = new SpotifyClient(accessToken);

        return client;
    }
}
