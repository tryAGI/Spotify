#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetFollowedTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.GetFollowedType?>
    {
        /// <inheritdoc />
        public override global::Spotify.GetFollowedType? Read(
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
                        return global::Spotify.GetFollowedTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.GetFollowedType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.GetFollowedType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.GetFollowedType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Spotify.GetFollowedTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
