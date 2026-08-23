<div class="docs-hero">
  <h1>Spotify</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Spotify generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/tryAGI.Spotify/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/tryAGI.Spotify"></a>
    <a href="https://github.com/tryAGI/Spotify/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Spotify/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Spotify/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Spotify"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://developer.spotify.com/reference/web-api/open-api-schema.yaml">Spotify's OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```shell
dotnet add package tryAGI.Spotify
```

```csharp
using Spotify;

using var client = new SpotifyClient(accessToken);
```

Pass a Spotify OAuth access token; the SDK emits the required bearer authorization header.

<!-- EXAMPLES:START -->
### Search


```csharp
using var client = new SpotifyClient(apiKey);

// Search the Spotify catalog with one or more strongly typed result categories.
var result = await client.Search.SearchAsync(
    q: "artist:Massive Attack",
    type: [SearchTypeItem.Track],
    limit: 10);
```

### Saved tracks


```csharp
using var client = new SpotifyClient(apiKey);

// Read the current user's saved tracks for preference and library synchronization workflows.
var page = await client.Tracks.GetUsersSavedTracksAsync(limit: 20, offset: 0);

// GetItems handles Spotify's composed paging schema and returns typed SavedTrackObject values.
var tracks = page.GetItems();
```
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Spotify/issues">tryAGI/Spotify</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Spotify/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
