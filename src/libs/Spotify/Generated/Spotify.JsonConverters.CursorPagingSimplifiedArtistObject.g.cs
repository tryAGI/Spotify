#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public class CursorPagingSimplifiedArtistObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.CursorPagingSimplifiedArtistObject>
    {
        /// <inheritdoc />
        public override global::Spotify.CursorPagingSimplifiedArtistObject Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("cursors")) __score0++;
            if (__jsonProps.Contains("href")) __score0++;
            if (__jsonProps.Contains("limit")) __score0++;
            if (__jsonProps.Contains("next")) __score0++;
            if (__jsonProps.Contains("total")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("items")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Spotify.CursorPagingObject? cursorPagingObject = default;
            global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? cursorPagingSimplifiedArtistObjectVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.CursorPagingObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.CursorPagingObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.CursorPagingObject).Name}");
                        cursorPagingObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2).Name}");
                        cursorPagingSimplifiedArtistObjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (cursorPagingObject == null && cursorPagingSimplifiedArtistObjectVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.CursorPagingObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.CursorPagingObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.CursorPagingObject).Name}");
                    cursorPagingObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (cursorPagingObject == null && cursorPagingSimplifiedArtistObjectVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2).Name}");
                    cursorPagingSimplifiedArtistObjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Spotify.CursorPagingSimplifiedArtistObject(
                cursorPagingObject,

                cursorPagingSimplifiedArtistObjectVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.CursorPagingSimplifiedArtistObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCursorPagingObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.CursorPagingObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.CursorPagingObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.CursorPagingObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CursorPagingObject!, typeInfo);
            }
            else if (value.IsCursorPagingSimplifiedArtistObjectVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.CursorPagingSimplifiedArtistObjectVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CursorPagingSimplifiedArtistObjectVariant2!, typeInfo);
            }
        }
    }
}