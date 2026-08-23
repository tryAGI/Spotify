#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public class GetUsersTopArtistsAndTracksResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>
    {
        /// <inheritdoc />
        public override global::Spotify.GetUsersTopArtistsAndTracksResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Spotify.ArtistObject? artist = default;
            if (discriminator?.Type == global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType.Artist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ArtistObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ArtistObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Spotify.ArtistObject)}");
                artist = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Spotify.TrackObject? track = default;
            if (discriminator?.Type == global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType.Track)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.TrackObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.TrackObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Spotify.TrackObject)}");
                track = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Spotify.GetUsersTopArtistsAndTracksResponseItem(
                discriminator?.Type,
                artist,

                track
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.GetUsersTopArtistsAndTracksResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArtist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ArtistObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ArtistObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ArtistObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Artist!, typeInfo);
            }
            else if (value.IsTrack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.TrackObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.TrackObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.TrackObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Track!, typeInfo);
            }
        }
    }
}