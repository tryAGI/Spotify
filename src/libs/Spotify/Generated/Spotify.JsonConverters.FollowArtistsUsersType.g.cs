#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class FollowArtistsUsersTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.FollowArtistsUsersType>
    {
        /// <inheritdoc />
        public override global::Spotify.FollowArtistsUsersType Read(
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
                        return global::Spotify.FollowArtistsUsersTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.FollowArtistsUsersType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.FollowArtistsUsersType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.FollowArtistsUsersType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Spotify.FollowArtistsUsersTypeExtensions.ToValueString(value));
        }
    }
}
