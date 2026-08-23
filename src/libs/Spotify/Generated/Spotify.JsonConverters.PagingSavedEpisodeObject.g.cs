#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public class PagingSavedEpisodeObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.PagingSavedEpisodeObject>
    {
        /// <inheritdoc />
        public override global::Spotify.PagingSavedEpisodeObject Read(
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
            if (__jsonProps.Contains("href")) __score0++;
            if (__jsonProps.Contains("limit")) __score0++;
            if (__jsonProps.Contains("next")) __score0++;
            if (__jsonProps.Contains("offset")) __score0++;
            if (__jsonProps.Contains("previous")) __score0++;
            if (__jsonProps.Contains("total")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("items")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Spotify.PagingObject? pagingObject = default;
            global::Spotify.PagingSavedEpisodeObjectVariant2? pagingSavedEpisodeObjectVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.PagingObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.PagingObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.PagingObject).Name}");
                        pagingObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.PagingSavedEpisodeObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.PagingSavedEpisodeObjectVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.PagingSavedEpisodeObjectVariant2).Name}");
                        pagingSavedEpisodeObjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pagingObject == null && pagingSavedEpisodeObjectVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.PagingObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.PagingObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.PagingObject).Name}");
                    pagingObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (pagingObject == null && pagingSavedEpisodeObjectVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.PagingSavedEpisodeObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.PagingSavedEpisodeObjectVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.PagingSavedEpisodeObjectVariant2).Name}");
                    pagingSavedEpisodeObjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Spotify.PagingSavedEpisodeObject(
                pagingObject,

                pagingSavedEpisodeObjectVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.PagingSavedEpisodeObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPagingObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.PagingObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.PagingObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.PagingObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PagingObject!, typeInfo);
            }
            else if (value.IsPagingSavedEpisodeObjectVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.PagingSavedEpisodeObjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.PagingSavedEpisodeObjectVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.PagingSavedEpisodeObjectVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PagingSavedEpisodeObjectVariant2!, typeInfo);
            }
        }
    }
}