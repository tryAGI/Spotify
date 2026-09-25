
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ErrorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject), TypeInfoPropertyName = "SimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedShowObject), TypeInfoPropertyName = "PagingSavedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedShowObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SavedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SavedShowObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObject), TypeInfoPropertyName = "PagingSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedEpisodeObject), TypeInfoPropertyName = "SimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision), TypeInfoPropertyName = "EpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ResumePointObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType), TypeInfoPropertyName = "EpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CopyrightObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType), TypeInfoPropertyName = "ShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowObject), TypeInfoPropertyName = "ShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowsEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowsEpisodesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowsEpisodesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedShowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedShowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedShowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveShowsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveShowsUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveShowsUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveShowsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveShowsUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveShowsUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedShowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedShowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedShowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject?), TypeInfoPropertyName = "NullableSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedShowObject?), TypeInfoPropertyName = "NullablePagingSavedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObject?), TypeInfoPropertyName = "NullablePagingSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedEpisodeObject?), TypeInfoPropertyName = "NullableSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableEpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType?), TypeInfoPropertyName = "NullableEpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType?), TypeInfoPropertyName = "NullableShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowObject?), TypeInfoPropertyName = "NullableShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SavedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    internal sealed partial class ShowsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ShowsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ShowsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ShowsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSavedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.ShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter());
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
                    typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseType)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseType?)

                    || typeToConvert == typeof(global::Spotify.ShowBaseType)

                    || typeToConvert == typeof(global::Spotify.ShowBaseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision))
                {
                    return new global::Spotify.JsonConverters.EpisodeBaseReleaseDatePrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?))
                {
                    return new global::Spotify.JsonConverters.EpisodeBaseReleaseDatePrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.EpisodeBaseType))
                {
                    return new global::Spotify.JsonConverters.EpisodeBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.EpisodeBaseType?))
                {
                    return new global::Spotify.JsonConverters.EpisodeBaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ShowBaseType))
                {
                    return new global::Spotify.JsonConverters.ShowBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ShowBaseType?))
                {
                    return new global::Spotify.JsonConverters.ShowBaseTypeNullableJsonConverter();
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
                    0 => new ShowsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}