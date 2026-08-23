using System.Net;
using System.Net.Http.Headers;

namespace Spotify.IntegrationTests;

[TestClass]
public sealed class ContractTests
{
    [TestMethod]
    public async Task SaveLibraryItems_UsesBearerAuthAndRetriesRateLimits()
    {
        var handler = new RecordingHandler(attempt =>
        {
            if (attempt == 1)
            {
                var response = new HttpResponseMessage(HttpStatusCode.TooManyRequests);
                response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.Zero);
                return response;
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(SpotifyClient.DefaultBaseUrl),
        };
        using var client = new SpotifyClient("access-token", httpClient, disposeHttpClient: false);

        await client.Library.SaveLibraryItemsAsync("spotify:track:123");

        handler.Attempts.Should().Be(2);
        handler.LastMethod.Should().Be(HttpMethod.Put);
        handler.LastRequestUri.Should().NotBeNull();
        handler.LastRequestUri!.AbsolutePath.Should().EndWith("/me/library");
        handler.LastRequestUri.Query.Should().Contain("uris=spotify%3Atrack%3A123");
        handler.LastAuthorization.Should().Be(new AuthenticationHeaderValue("Bearer", "access-token"));
    }

    [TestMethod]
    public async Task SavedTracks_PreservesItemsFromAllOfPage()
    {
        var handler = new RecordingHandler(_ => new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(
                """
                {
                  "href": "https://api.spotify.com/v1/me/tracks?limit=50&offset=0",
                  "limit": 50,
                  "next": null,
                  "offset": 0,
                  "previous": null,
                  "total": 1,
                  "items": [
                    {
                      "added_at": "2026-08-22T20:00:00Z",
                      "track": {
                        "id": "track-1",
                        "name": "Teardrop",
                        "artists": [{ "name": "Massive Attack" }],
                        "uri": "spotify:track:track-1",
                        "duration_ms": 330000
                      }
                    }
                  ]
                }
                """),
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(SpotifyClient.DefaultBaseUrl),
        };
        using var client = new SpotifyClient("access-token", httpClient, disposeHttpClient: false);

        var page = await client.Tracks.GetUsersSavedTracksAsync(limit: 50, offset: 0);
        var items = page.GetItems();

        page.GetTotal().Should().Be(1);
        items.Should().ContainSingle();
        items[0].Track!.Id.Should().Be("track-1");
        items[0].Track!.Artists.Should().ContainSingle(artist => artist.Name == "Massive Attack");
    }

    [TestMethod]
    public async Task CurrentPlaybackOrDefault_ReturnsNullForDocumentedNoContentResponse()
    {
        var handler = new RecordingHandler(_ => new HttpResponseMessage(HttpStatusCode.NoContent));
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(SpotifyClient.DefaultBaseUrl),
        };
        using var client = new SpotifyClient("access-token", httpClient, disposeHttpClient: false);

        var playback = await client.Player.GetCurrentPlaybackOrDefaultAsync();

        playback.Should().BeNull();
        handler.Attempts.Should().Be(1);
        handler.LastRequestUri.Should().NotBeNull();
        handler.LastRequestUri!.AbsolutePath.Should().EndWith("/me/player");
        handler.LastAuthorization.Should().Be(new AuthenticationHeaderValue("Bearer", "access-token"));
    }

    [TestMethod]
    public async Task BodylessSuccessOperations_CompleteWithoutDeserializingContent()
    {
        BodylessSuccessCase[] cases =
        [
            new("change-playlist-details", HttpStatusCode.OK, HttpMethod.Put, "/playlists/playlist-id",
                client => client.Playlists.ChangePlaylistDetailsAsync("playlist-id", name: "Renamed")),
            new("save-library-items", HttpStatusCode.OK, HttpMethod.Put, "/me/library",
                client => client.Library.SaveLibraryItemsAsync("spotify:track:track-id")),
            new("remove-library-items", HttpStatusCode.OK, HttpMethod.Delete, "/me/library",
                client => client.Library.RemoveLibraryItemsAsync("spotify:track:track-id")),
            new("upload-custom-playlist-cover", HttpStatusCode.Accepted, HttpMethod.Put, "/playlists/playlist-id/images",
                client => client.Playlists.UploadCustomPlaylistCoverAsync("playlist-id", [0x01])),
            new("transfer-a-users-playback", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player",
                client => client.Player.TransferAUsersPlaybackAsync(["device-id"])),
            new("start-a-users-playback", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player/play",
                client => client.Player.StartAUsersPlaybackAsync(deviceId: "device-id")),
            new("pause-a-users-playback", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player/pause",
                client => client.Player.PauseAUsersPlaybackAsync("device-id")),
            new("skip-users-playback-to-next-track", HttpStatusCode.NoContent, HttpMethod.Post, "/me/player/next",
                client => client.Player.SkipUsersPlaybackToNextTrackAsync("device-id")),
            new("skip-users-playback-to-previous-track", HttpStatusCode.NoContent, HttpMethod.Post, "/me/player/previous",
                client => client.Player.SkipUsersPlaybackToPreviousTrackAsync("device-id")),
            new("seek-to-position-in-currently-playing-track", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player/seek",
                client => client.Player.SeekToPositionInCurrentlyPlayingTrackAsync(1_000, "device-id")),
            new("set-repeat-mode-on-users-playback", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player/repeat",
                client => client.Player.SetRepeatModeOnUsersPlaybackAsync("off", "device-id")),
            new("set-volume-for-users-playback", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player/volume",
                client => client.Player.SetVolumeForUsersPlaybackAsync(50, "device-id")),
            new("toggle-shuffle-for-users-playback", HttpStatusCode.NoContent, HttpMethod.Put, "/me/player/shuffle",
                client => client.Player.ToggleShuffleForUsersPlaybackAsync(true, "device-id")),
            new("add-to-queue", HttpStatusCode.NoContent, HttpMethod.Post, "/me/player/queue",
                client => client.Player.AddToQueueAsync("spotify:track:track-id", "device-id")),
        ];

        var generatedVoidMethods = typeof(SpotifyClient)
            .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public)
            .Where(property => property.PropertyType.Namespace == typeof(SpotifyClient).Namespace &&
                               property.PropertyType.Name.EndsWith("Client", StringComparison.Ordinal))
            .SelectMany(property => property.PropertyType.GetMethods(
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.DeclaredOnly))
            .Where(method => method.ReturnType == typeof(Task) &&
                             method.Name.EndsWith("Async", StringComparison.Ordinal) &&
                             !method.Name.EndsWith("AsResponseAsync", StringComparison.Ordinal))
            .Select(method => method.Name)
            .Distinct(StringComparer.Ordinal)
            .ToArray();
        var coveredVoidMethods = cases
            .Select(testCase => string.Concat(
                testCase.OperationId.Split('-').Select(segment =>
                    char.ToUpperInvariant(segment[0]) + segment[1..])) + "Async")
            .ToArray();

        generatedVoidMethods.Should().BeEquivalentTo(
            coveredVoidMethods,
            "every generated bodyless-success operation needs an executable empty-response case");

        foreach (var testCase in cases)
        {
            var handler = new RecordingHandler(_ => new HttpResponseMessage(testCase.StatusCode));
            using var httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(SpotifyClient.DefaultBaseUrl),
            };
            using var client = new SpotifyClient("access-token", httpClient, disposeHttpClient: false);

            await testCase.InvokeAsync(client);

            handler.Attempts.Should().Be(1, testCase.OperationId);
            handler.LastMethod.Should().Be(testCase.Method, testCase.OperationId);
            handler.LastRequestUri.Should().NotBeNull(testCase.OperationId);
            handler.LastRequestUri!.AbsolutePath.Should().EndWith(testCase.Path, testCase.OperationId);
            handler.LastAuthorization.Should().Be(
                new AuthenticationHeaderValue("Bearer", "access-token"),
                testCase.OperationId);
        }
    }

    private sealed record BodylessSuccessCase(
        string OperationId,
        HttpStatusCode StatusCode,
        HttpMethod Method,
        string Path,
        Func<SpotifyClient, Task> InvokeAsync);

    private sealed class RecordingHandler(Func<int, HttpResponseMessage> responseFactory)
        : HttpMessageHandler
    {
        public int Attempts { get; private set; }
        public HttpMethod? LastMethod { get; private set; }
        public Uri? LastRequestUri { get; private set; }
        public AuthenticationHeaderValue? LastAuthorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Attempts++;
            LastMethod = request.Method;
            LastRequestUri = request.RequestUri;
            LastAuthorization = request.Headers.Authorization;
            return Task.FromResult(responseFactory(Attempts));
        }
    }
}
