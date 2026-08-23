# Saved tracks



This example assumes `using Spotify;` is in scope and `apiKey` contains your Spotify API key.

```csharp
using var client = new SpotifyClient(apiKey);

// Read the current user's saved tracks for preference and library synchronization workflows.
var page = await client.Tracks.GetUsersSavedTracksAsync(limit: 20, offset: 0);
```