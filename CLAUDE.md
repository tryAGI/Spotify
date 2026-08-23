# Spotify SDK

Generated .NET client for Spotify's official Web API OpenAPI document.

## Regeneration

Run `cd src/libs/Spotify && ./generate.sh`. The script refreshes the official schema and regenerates `Generated/`; never edit that directory manually.

The SDK uses bearer OAuth tokens and excludes deprecated operations. The schema override removes only `PlaylistTrackObject.track`, Spotify's deprecated alias for `PlaylistTrackObject.item`, because the legacy inline union otherwise collides with C# type/member naming.

The Advantage integration depends on catalog search, playback, devices, queue, playlists, saved tracks/albums, unified library mutation and membership checks, personalization, artist/album/track metadata, and current-user profile endpoints.
