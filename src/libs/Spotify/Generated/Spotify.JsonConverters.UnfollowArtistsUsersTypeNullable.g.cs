#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnfollowArtistsUsersTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.UnfollowArtistsUsersType?>
    {
        /// <inheritdoc />
        public override global::Spotify.UnfollowArtistsUsersType? Read(
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
                        return global::Spotify.UnfollowArtistsUsersTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.UnfollowArtistsUsersType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.UnfollowArtistsUsersType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.UnfollowArtistsUsersType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Spotify.UnfollowArtistsUsersTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
