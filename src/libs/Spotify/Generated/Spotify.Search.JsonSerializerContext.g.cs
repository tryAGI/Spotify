
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason), TypeInfoPropertyName = "AlbumRestrictionObjectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowersObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType), TypeInfoPropertyName = "ArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType), TypeInfoPropertyName = "SimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ErrorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObject), TypeInfoPropertyName = "PagingPlaylistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedPlaylistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedPlaylistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAlbumObject), TypeInfoPropertyName = "PagingSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject), TypeInfoPropertyName = "SimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingTrackObject), TypeInfoPropertyName = "PagingTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingTrackObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.TrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedShowObject), TypeInfoPropertyName = "PagingSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedShowObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject), TypeInfoPropertyName = "SimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObject), TypeInfoPropertyName = "PagingSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedEpisodeObject), TypeInfoPropertyName = "SimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObject), TypeInfoPropertyName = "PagingSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedAudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAudiobookObject), TypeInfoPropertyName = "SimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistObject), TypeInfoPropertyName = "PagingArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObject), TypeInfoPropertyName = "PlaylistOwnerObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTracksRefObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType), TypeInfoPropertyName = "PlaylistUserObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalIdObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType), TypeInfoPropertyName = "TrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision), TypeInfoPropertyName = "EpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ResumePointObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType), TypeInfoPropertyName = "EpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CopyrightObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType), TypeInfoPropertyName = "ShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AuthorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AuthorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.NarratorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.NarratorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBaseType), TypeInfoPropertyName = "AudiobookBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType), TypeInfoPropertyName = "AlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision), TypeInfoPropertyName = "AlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType), TypeInfoPropertyName = "AlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SearchTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchTypeItem), TypeInfoPropertyName = "SearchTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchIncludeExternal), TypeInfoPropertyName = "SearchIncludeExternal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason?), TypeInfoPropertyName = "NullableAlbumRestrictionObjectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType?), TypeInfoPropertyName = "NullableArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType?), TypeInfoPropertyName = "NullableSimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObject?), TypeInfoPropertyName = "NullablePagingPlaylistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAlbumObject?), TypeInfoPropertyName = "NullablePagingSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject?), TypeInfoPropertyName = "NullableSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingTrackObject?), TypeInfoPropertyName = "NullablePagingTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedShowObject?), TypeInfoPropertyName = "NullablePagingSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject?), TypeInfoPropertyName = "NullableSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObject?), TypeInfoPropertyName = "NullablePagingSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedEpisodeObject?), TypeInfoPropertyName = "NullableSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObject?), TypeInfoPropertyName = "NullablePagingSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAudiobookObject?), TypeInfoPropertyName = "NullableSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistObject?), TypeInfoPropertyName = "NullablePagingArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObject?), TypeInfoPropertyName = "NullablePlaylistOwnerObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType?), TypeInfoPropertyName = "NullablePlaylistUserObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType?), TypeInfoPropertyName = "NullableTrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableEpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType?), TypeInfoPropertyName = "NullableEpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType?), TypeInfoPropertyName = "NullableShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBaseType?), TypeInfoPropertyName = "NullableAudiobookBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType?), TypeInfoPropertyName = "NullableAlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableAlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType?), TypeInfoPropertyName = "NullableAlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchTypeItem?), TypeInfoPropertyName = "NullableSearchTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchIncludeExternal?), TypeInfoPropertyName = "NullableSearchIncludeExternal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedPlaylistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.TrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedAudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AuthorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.NarratorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SearchTypeItem>))]
    internal sealed partial class SearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Spotify.JsonConverters.PagingPlaylistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedAudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingArtistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PlaylistOwnerObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAlbumObjectJsonConverter());
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
                    typeToConvert == typeof(global::Spotify.AlbumRestrictionObjectReason)

                    || typeToConvert == typeof(global::Spotify.AlbumRestrictionObjectReason?)

                    || typeToConvert == typeof(global::Spotify.ArtistObjectType)

                    || typeToConvert == typeof(global::Spotify.ArtistObjectType?)

                    || typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType)

                    || typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType?)

                    || typeToConvert == typeof(global::Spotify.PlaylistUserObjectType)

                    || typeToConvert == typeof(global::Spotify.PlaylistUserObjectType?)

                    || typeToConvert == typeof(global::Spotify.TrackObjectType)

                    || typeToConvert == typeof(global::Spotify.TrackObjectType?)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseType)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseType?)

                    || typeToConvert == typeof(global::Spotify.ShowBaseType)

                    || typeToConvert == typeof(global::Spotify.ShowBaseType?)

                    || typeToConvert == typeof(global::Spotify.AudiobookBaseType)

                    || typeToConvert == typeof(global::Spotify.AudiobookBaseType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType?)

                    || typeToConvert == typeof(global::Spotify.SearchTypeItem)

                    || typeToConvert == typeof(global::Spotify.SearchTypeItem?)

                    || typeToConvert == typeof(global::Spotify.SearchIncludeExternal)

                    || typeToConvert == typeof(global::Spotify.SearchIncludeExternal?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Spotify.AlbumRestrictionObjectReason))
                {
                    return new global::Spotify.JsonConverters.AlbumRestrictionObjectReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumRestrictionObjectReason?))
                {
                    return new global::Spotify.JsonConverters.AlbumRestrictionObjectReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ArtistObjectType))
                {
                    return new global::Spotify.JsonConverters.ArtistObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ArtistObjectType?))
                {
                    return new global::Spotify.JsonConverters.ArtistObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType))
                {
                    return new global::Spotify.JsonConverters.SimplifiedArtistObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType?))
                {
                    return new global::Spotify.JsonConverters.SimplifiedArtistObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.PlaylistUserObjectType))
                {
                    return new global::Spotify.JsonConverters.PlaylistUserObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.PlaylistUserObjectType?))
                {
                    return new global::Spotify.JsonConverters.PlaylistUserObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.TrackObjectType))
                {
                    return new global::Spotify.JsonConverters.TrackObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.TrackObjectType?))
                {
                    return new global::Spotify.JsonConverters.TrackObjectTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Spotify.AudiobookBaseType))
                {
                    return new global::Spotify.JsonConverters.AudiobookBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AudiobookBaseType?))
                {
                    return new global::Spotify.JsonConverters.AudiobookBaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType))
                {
                    return new global::Spotify.JsonConverters.AlbumBaseAlbumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType?))
                {
                    return new global::Spotify.JsonConverters.AlbumBaseAlbumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision))
                {
                    return new global::Spotify.JsonConverters.AlbumBaseReleaseDatePrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision?))
                {
                    return new global::Spotify.JsonConverters.AlbumBaseReleaseDatePrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumBaseType))
                {
                    return new global::Spotify.JsonConverters.AlbumBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AlbumBaseType?))
                {
                    return new global::Spotify.JsonConverters.AlbumBaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SearchTypeItem))
                {
                    return new global::Spotify.JsonConverters.SearchTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SearchTypeItem?))
                {
                    return new global::Spotify.JsonConverters.SearchTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SearchIncludeExternal))
                {
                    return new global::Spotify.JsonConverters.SearchIncludeExternalJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SearchIncludeExternal?))
                {
                    return new global::Spotify.JsonConverters.SearchIncludeExternalNullableJsonConverter();
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
                    0 => new SearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}