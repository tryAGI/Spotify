
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ErrorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingSimplifiedArtistObject), TypeInfoPropertyName = "CursorPagingSimplifiedArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistDiscographyAlbumObject), TypeInfoPropertyName = "PagingArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistDiscographyAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ArtistDiscographyAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObject), TypeInfoPropertyName = "ArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject), TypeInfoPropertyName = "SimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.TrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalIdObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType), TypeInfoPropertyName = "TrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType), TypeInfoPropertyName = "AlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision), TypeInfoPropertyName = "AlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType), TypeInfoPropertyName = "AlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup), TypeInfoPropertyName = "ArtistDiscographyAlbumObjectVariant2AlbumGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedType), TypeInfoPropertyName = "GetFollowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersType), TypeInfoPropertyName = "FollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersType), TypeInfoPropertyName = "UnfollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsType), TypeInfoPropertyName = "CheckCurrentUserFollowsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsAlbumsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsAlbumsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason?), TypeInfoPropertyName = "NullableAlbumRestrictionObjectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType?), TypeInfoPropertyName = "NullableArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType?), TypeInfoPropertyName = "NullableSimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingSimplifiedArtistObject?), TypeInfoPropertyName = "NullableCursorPagingSimplifiedArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistDiscographyAlbumObject?), TypeInfoPropertyName = "NullablePagingArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObject?), TypeInfoPropertyName = "NullableArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject?), TypeInfoPropertyName = "NullableSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType?), TypeInfoPropertyName = "NullableTrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType?), TypeInfoPropertyName = "NullableAlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableAlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType?), TypeInfoPropertyName = "NullableAlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup?), TypeInfoPropertyName = "NullableArtistDiscographyAlbumObjectVariant2AlbumGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedType?), TypeInfoPropertyName = "NullableGetFollowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersType?), TypeInfoPropertyName = "NullableFollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersType?), TypeInfoPropertyName = "NullableUnfollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsType?), TypeInfoPropertyName = "NullableCheckCurrentUserFollowsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ArtistDiscographyAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.TrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    internal sealed partial class ArtistsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArtistsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ArtistsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ArtistsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Spotify.JsonConverters.CursorPagingSimplifiedArtistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingArtistDiscographyAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectJsonConverter());
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

                    || typeToConvert == typeof(global::Spotify.TrackObjectType)

                    || typeToConvert == typeof(global::Spotify.TrackObjectType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType?)

                    || typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup)

                    || typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup?)

                    || typeToConvert == typeof(global::Spotify.GetFollowedType)

                    || typeToConvert == typeof(global::Spotify.GetFollowedType?)

                    || typeToConvert == typeof(global::Spotify.FollowArtistsUsersType)

                    || typeToConvert == typeof(global::Spotify.FollowArtistsUsersType?)

                    || typeToConvert == typeof(global::Spotify.UnfollowArtistsUsersType)

                    || typeToConvert == typeof(global::Spotify.UnfollowArtistsUsersType?)

                    || typeToConvert == typeof(global::Spotify.CheckCurrentUserFollowsType)

                    || typeToConvert == typeof(global::Spotify.CheckCurrentUserFollowsType?);
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

                if (typeToConvert == typeof(global::Spotify.TrackObjectType))
                {
                    return new global::Spotify.JsonConverters.TrackObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.TrackObjectType?))
                {
                    return new global::Spotify.JsonConverters.TrackObjectTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup))
                {
                    return new global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup?))
                {
                    return new global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.GetFollowedType))
                {
                    return new global::Spotify.JsonConverters.GetFollowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.GetFollowedType?))
                {
                    return new global::Spotify.JsonConverters.GetFollowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.FollowArtistsUsersType))
                {
                    return new global::Spotify.JsonConverters.FollowArtistsUsersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.FollowArtistsUsersType?))
                {
                    return new global::Spotify.JsonConverters.FollowArtistsUsersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.UnfollowArtistsUsersType))
                {
                    return new global::Spotify.JsonConverters.UnfollowArtistsUsersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.UnfollowArtistsUsersType?))
                {
                    return new global::Spotify.JsonConverters.UnfollowArtistsUsersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.CheckCurrentUserFollowsType))
                {
                    return new global::Spotify.JsonConverters.CheckCurrentUserFollowsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.CheckCurrentUserFollowsType?))
                {
                    return new global::Spotify.JsonConverters.CheckCurrentUserFollowsTypeNullableJsonConverter();
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
                    0 => new ArtistsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}