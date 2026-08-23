/*
order: 20
title: Saved tracks
slug: saved-tracks
*/

namespace Spotify.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetSavedTracks()
    {
        using var client = GetAuthenticatedClient();

        //// Read the current user's saved tracks for preference and library synchronization workflows.
        var page = await client.Tracks.GetUsersSavedTracksAsync(limit: 20, offset: 0);

        page.Object.Should().NotBeNull();
    }
}
