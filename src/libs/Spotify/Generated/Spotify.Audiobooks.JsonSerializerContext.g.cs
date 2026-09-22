
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ErrorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObject), TypeInfoPropertyName = "PagingSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedAudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAudiobookObject), TypeInfoPropertyName = "SimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedChapterObject), TypeInfoPropertyName = "PagingSimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedChapterObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedChapterObject), TypeInfoPropertyName = "SimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ResumePointObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CopyrightObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AuthorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AuthorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.NarratorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.NarratorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBaseType), TypeInfoPropertyName = "AudiobookBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookObject), TypeInfoPropertyName = "AudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseReleaseDatePrecision), TypeInfoPropertyName = "ChapterBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseType), TypeInfoPropertyName = "ChapterBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAudiobookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAudiobookResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAudiobookResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAudiobookResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAudiobookResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudiobookChaptersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudiobookChaptersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudiobookChaptersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAudiobooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAudiobooksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAudiobooksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAudiobooksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAudiobooksUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAudiobooksUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAudiobooksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAudiobooksUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAudiobooksUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAudiobooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAudiobooksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAudiobooksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObject?), TypeInfoPropertyName = "NullablePagingSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAudiobookObject?), TypeInfoPropertyName = "NullableSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedChapterObject?), TypeInfoPropertyName = "NullablePagingSimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedChapterObject?), TypeInfoPropertyName = "NullableSimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBaseType?), TypeInfoPropertyName = "NullableAudiobookBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookObject?), TypeInfoPropertyName = "NullableAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableChapterBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseType?), TypeInfoPropertyName = "NullableChapterBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedAudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AuthorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.NarratorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    internal sealed partial class AudiobooksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudiobooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudiobooksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudiobooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedAudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedChapterObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.AudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedChapterObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Spotify.AudiobookBaseType)

                    || typeToConvert == typeof(global::Spotify.AudiobookBaseType?)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseType)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Spotify.AudiobookBaseType))
                {
                    return new global::Spotify.JsonConverters.AudiobookBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AudiobookBaseType?))
                {
                    return new global::Spotify.JsonConverters.AudiobookBaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ChapterBaseReleaseDatePrecision))
                {
                    return new global::Spotify.JsonConverters.ChapterBaseReleaseDatePrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ChapterBaseReleaseDatePrecision?))
                {
                    return new global::Spotify.JsonConverters.ChapterBaseReleaseDatePrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ChapterBaseType))
                {
                    return new global::Spotify.JsonConverters.ChapterBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ChapterBaseType?))
                {
                    return new global::Spotify.JsonConverters.ChapterBaseTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AudiobooksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}