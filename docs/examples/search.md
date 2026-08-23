# Search



This example assumes `using Spotify;` is in scope and `apiKey` contains your Spotify API key.

```csharp
using var client = new SpotifyClient(apiKey);

// Search the Spotify catalog with one or more strongly typed result categories.
var result = await client.Search.SearchAsync(
    q: "artist:Massive Attack",
    type: [SearchTypeItem.Track],
    limit: 10);
```