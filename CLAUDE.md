# Spotify SDK

Generated .NET client for Spotify's official Web API OpenAPI document.

## Regeneration

Run `cd src/libs/Spotify && ./generate.sh`. The script refreshes the official schema and regenerates `Generated/`; never edit that directory manually.

The SDK uses bearer OAuth tokens and excludes deprecated operations. The schema override removes only `PlaylistTrackObject.track`, Spotify's deprecated alias for `PlaylistTrackObject.item`, because the legacy inline union otherwise collides with C# type/member naming.

The Advantage integration depends on catalog search, playback, devices, queue, playlists, saved tracks/albums, unified library mutation and membership checks, personalization, artist/album/track metadata, and current-user profile endpoints.

Use `PagingSavedTrackObject.GetItems()` for saved-track pages. Spotify declares this response with `allOf`; the helper reconstructs its typed items from source-generated raw model data when the generated union selects the paging metadata half.

Use `IPlayerClient.GetCurrentPlaybackOrDefaultAsync()` for current playback. Spotify documents HTTP 204 when no playback is active; the generated non-null response method cannot deserialize that empty success body, while this helper maps it to `null`.

Bodyless-success contract coverage must include every generated operation whose official schema has a success response without content: playlist details and cover upload, unified library save/remove, all player commands, and the nullable current-playback read. Keep the test matrix synchronized when the upstream schema adds another empty `200`, `202`, or `204` response.
