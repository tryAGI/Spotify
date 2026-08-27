#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType Read(
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
                        return global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
