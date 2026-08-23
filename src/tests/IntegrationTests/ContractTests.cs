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
