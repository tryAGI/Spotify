
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType), TypeInfoPropertyName = "SimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlayHistoryObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ContextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject), TypeInfoPropertyName = "EpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlaying), TypeInfoPropertyName = "CurrentlyPlaying2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType), TypeInfoPropertyName = "QueueObjectCurrentlyPlayingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.QueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueItem), TypeInfoPropertyName = "QueueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectQueueItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType), TypeInfoPropertyName = "QueueObjectQueueItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlayingContextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.DeviceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item2), TypeInfoPropertyName = "Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType), TypeInfoPropertyName = "CurrentlyPlayingContextObjectItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.DisallowsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ErrorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingPlayHistoryObject), TypeInfoPropertyName = "CursorPagingPlayHistoryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingPlayHistoryObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.PlayHistoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject), TypeInfoPropertyName = "SimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject), TypeInfoPropertyName = "SimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalIdObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType), TypeInfoPropertyName = "TrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision), TypeInfoPropertyName = "EpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ResumePointObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType), TypeInfoPropertyName = "EpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CopyrightObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType), TypeInfoPropertyName = "ShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType), TypeInfoPropertyName = "AlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision), TypeInfoPropertyName = "AlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType), TypeInfoPropertyName = "AlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.StartAUsersPlaybackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.DeviceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTheUsersCurrentlyPlayingTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTheUsersCurrentlyPlayingTrackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTheUsersCurrentlyPlayingTrackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.StartAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.StartAUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.StartAUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PauseAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PauseAUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PauseAUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToNextTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToNextTrackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToNextTrackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToPreviousTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToPreviousTrackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToPreviousTrackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SeekToPositionInCurrentlyPlayingTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SeekToPositionInCurrentlyPlayingTrackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SeekToPositionInCurrentlyPlayingTrackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetRepeatModeOnUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetRepeatModeOnUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetRepeatModeOnUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetVolumeForUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetVolumeForUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetVolumeForUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ToggleShuffleForUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ToggleShuffleForUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ToggleShuffleForUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecentlyPlayedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecentlyPlayedResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecentlyPlayedResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetQueueResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetQueueResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddToQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddToQueueResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddToQueueResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason?), TypeInfoPropertyName = "NullableAlbumRestrictionObjectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType?), TypeInfoPropertyName = "NullableSimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject?), TypeInfoPropertyName = "NullableEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlaying?), TypeInfoPropertyName = "NullableCurrentlyPlaying2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType?), TypeInfoPropertyName = "NullableQueueObjectCurrentlyPlayingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueItem?), TypeInfoPropertyName = "NullableQueueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType?), TypeInfoPropertyName = "NullableQueueObjectQueueItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item2?), TypeInfoPropertyName = "NullableItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType?), TypeInfoPropertyName = "NullableCurrentlyPlayingContextObjectItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingPlayHistoryObject?), TypeInfoPropertyName = "NullableCursorPagingPlayHistoryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject?), TypeInfoPropertyName = "NullableSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject?), TypeInfoPropertyName = "NullableSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType?), TypeInfoPropertyName = "NullableTrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableEpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType?), TypeInfoPropertyName = "NullableEpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType?), TypeInfoPropertyName = "NullableShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType?), TypeInfoPropertyName = "NullableAlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableAlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType?), TypeInfoPropertyName = "NullableAlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.QueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.PlayHistoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.DeviceObject>))]
    internal sealed partial class PlayerSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlayerSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PlayerSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PlayerSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Spotify.JsonConverters.CurrentlyPlayingJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.QueueItemJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.Item2JsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.CursorPagingPlayHistoryObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.EpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter());
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

                    || typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType)

                    || typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType?)

                    || typeToConvert == typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.TrackObjectType)

                    || typeToConvert == typeof(global::Spotify.TrackObjectType?)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseType)

                    || typeToConvert == typeof(global::Spotify.EpisodeBaseType?)

                    || typeToConvert == typeof(global::Spotify.ShowBaseType)

                    || typeToConvert == typeof(global::Spotify.ShowBaseType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType?);
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

                if (typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType))
                {
                    return new global::Spotify.JsonConverters.SimplifiedArtistObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.SimplifiedArtistObjectType?))
                {
                    return new global::Spotify.JsonConverters.SimplifiedArtistObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType))
                {
                    return new global::Spotify.JsonConverters.QueueObjectCurrentlyPlayingDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType?))
                {
                    return new global::Spotify.JsonConverters.QueueObjectCurrentlyPlayingDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType))
                {
                    return new global::Spotify.JsonConverters.QueueObjectQueueItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType?))
                {
                    return new global::Spotify.JsonConverters.QueueObjectQueueItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType))
                {
                    return new global::Spotify.JsonConverters.CurrentlyPlayingContextObjectItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType?))
                {
                    return new global::Spotify.JsonConverters.CurrentlyPlayingContextObjectItemDiscriminatorTypeNullableJsonConverter();
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
                    0 => new PlayerSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}