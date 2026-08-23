#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Spotify.JsonConverters
{
    /// <inheritdoc />
    public class Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Spotify.Item2>
    {
        /// <inheritdoc />
        public override global::Spotify.Item2 Read(
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
            if (__jsonProps.Contains("album")) __score0++;
            if (__jsonProps.Contains("artists")) __score0++;
            if (__jsonProps.Contains("available_markets")) __score0++;
            if (__jsonProps.Contains("disc_number")) __score0++;
            if (__jsonProps.Contains("duration_ms")) __score0++;
            if (__jsonProps.Contains("explicit")) __score0++;
            if (__jsonProps.Contains("external_ids")) __score0++;
            if (__jsonProps.Contains("external_urls")) __score0++;
            if (__jsonProps.Contains("href")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_local")) __score0++;
            if (__jsonProps.Contains("is_playable")) __score0++;
            if (__jsonProps.Contains("linked_from")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("popularity")) __score0++;
            if (__jsonProps.Contains("preview_url")) __score0++;
            if (__jsonProps.Contains("restrictions")) __score0++;
            if (__jsonProps.Contains("track_number")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("uri")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Spotify.TrackObject? track = default;
            global::Spotify.EpisodeObject? episodeObject = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.TrackObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.TrackObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.TrackObject).Name}");
                        track = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.EpisodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.EpisodeObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.EpisodeObject).Name}");
                        episodeObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (track == null && episodeObject == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.TrackObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.TrackObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.TrackObject).Name}");
                    track = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (track == null && episodeObject == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.EpisodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.EpisodeObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.EpisodeObject).Name}");
                    episodeObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Spotify.Item2(
                track,

                episodeObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Spotify.Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTrack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.TrackObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.TrackObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.TrackObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Track!, typeInfo);
            }
            else if (value.IsEpisodeObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Spotify.EpisodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Spotify.EpisodeObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Spotify.EpisodeObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EpisodeObject!.Value, typeInfo);
            }
        }
    }
}