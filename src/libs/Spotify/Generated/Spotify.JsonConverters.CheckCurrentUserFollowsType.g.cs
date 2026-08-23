#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class CheckCurrentUserFollowsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.CheckCurrentUserFollowsType>
    {
        /// <inheritdoc />
        public override global::Spotify.CheckCurrentUserFollowsType Read(
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
                        return global::Spotify.CheckCurrentUserFollowsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.CheckCurrentUserFollowsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.CheckCurrentUserFollowsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.CheckCurrentUserFollowsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Spotify.CheckCurrentUserFollowsTypeExtensions.ToValueString(value));
        }
    }
}
