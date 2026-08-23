/*
order: 10
title: Search
slug: search
*/

namespace Spotify.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SearchTracks()
    {
        using var client = GetAuthenticatedClient();

        //// Search the Spotify catalog with one or more strongly typed result categories.
        var result = await client.Search.SearchAsync(
            q: "artist:Massive Attack",
            type: [SearchTypeItem.Track],
            limit: 10);

        result.Tracks.Should().NotBeNull();
    }
}
