#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public class ChapterObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.ChapterObject>
    {
        /// <inheritdoc />
        public override global::Spotify.ChapterObject Read(
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
            if (__jsonProps.Contains("audio_preview_url")) __score0++;
            if (__jsonProps.Contains("available_markets")) __score0++;
            if (__jsonProps.Contains("chapter_number")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("duration_ms")) __score0++;
            if (__jsonProps.Contains("explicit")) __score0++;
            if (__jsonProps.Contains("external_urls")) __score0++;
            if (__jsonProps.Contains("href")) __score0++;
            if (__jsonProps.Contains("html_description")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("images")) __score0++;
            if (__jsonProps.Contains("is_playable")) __score0++;
            if (__jsonProps.Contains("languages")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("release_date")) __score0++;
            if (__jsonProps.Contains("release_date_precision")) __score0++;
            if (__jsonProps.Contains("restrictions")) __score0++;
            if (__jsonProps.Contains("resume_point")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("uri")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audiobook")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Spotify.ChapterBase? @base = default;
            global::Spotify.ChapterObjectVariant2? chapterObjectVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ChapterBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ChapterBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ChapterBase).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ChapterObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ChapterObjectVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ChapterObjectVariant2).Name}");
                        chapterObjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && chapterObjectVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ChapterBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ChapterBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ChapterBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (@base == null && chapterObjectVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ChapterObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ChapterObjectVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ChapterObjectVariant2).Name}");
                    chapterObjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Spotify.ChapterObject(
                @base,

                chapterObjectVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.ChapterObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ChapterBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ChapterBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ChapterBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsChapterObjectVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.ChapterObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.ChapterObjectVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.ChapterObjectVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChapterObjectVariant2!, typeInfo);
            }
        }
    }
}