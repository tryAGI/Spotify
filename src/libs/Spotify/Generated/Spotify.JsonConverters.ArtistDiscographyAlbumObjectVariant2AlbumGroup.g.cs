#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ArtistDiscographyAlbumObjectVariant2AlbumGroupJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup>
    {
        /// <inheritdoc />
        public override global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroupExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroupExtensions.ToValueString(value));
        }
    }
}
