#nullable enable

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlbumRestrictionObjectReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.AlbumRestrictionObjectReason>
    {
        /// <inheritdoc />
        public override global::Spotify.AlbumRestrictionObjectReason Read(
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
                        return global::Spotify.AlbumRestrictionObjectReasonExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Spotify.AlbumRestrictionObjectReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Spotify.AlbumRestrictionObjectReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.AlbumRestrictionObjectReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Spotify.AlbumRestrictionObjectReasonExtensions.ToValueString(value));
        }
    }
}
