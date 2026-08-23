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
