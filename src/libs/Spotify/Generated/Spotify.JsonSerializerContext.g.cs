
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
            typeof(global::Spotify.JsonConverters.AlbumRestrictionObjectReasonJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumRestrictionObjectReasonNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.ArtistObjectTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.ArtistObjectTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedArtistObjectTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedArtistObjectTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.PlaylistTrackObjectItemDiscriminatorTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.PlaylistTrackObjectItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.QueueObjectCurrentlyPlayingDiscriminatorTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.QueueObjectCurrentlyPlayingDiscriminatorTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.QueueObjectQueueItemDiscriminatorTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.QueueObjectQueueItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.CurrentlyPlayingContextObjectItemDiscriminatorTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.CurrentlyPlayingContextObjectItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.PublicUserObjectTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.PublicUserObjectTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.AudioFeaturesObjectTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.AudioFeaturesObjectTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.PlaylistUserObjectTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.PlaylistUserObjectTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.TrackObjectTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.TrackObjectTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.EpisodeBaseReleaseDatePrecisionJsonConverter),

            typeof(global::Spotify.JsonConverters.EpisodeBaseReleaseDatePrecisionNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.EpisodeBaseTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.EpisodeBaseTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.ShowBaseTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.ShowBaseTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.AudiobookBaseTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.AudiobookBaseTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumBaseAlbumTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumBaseAlbumTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumBaseReleaseDatePrecisionJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumBaseReleaseDatePrecisionNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumBaseTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumBaseTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupJsonConverter),

            typeof(global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.ChapterBaseReleaseDatePrecisionJsonConverter),

            typeof(global::Spotify.JsonConverters.ChapterBaseReleaseDatePrecisionNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.ChapterBaseTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.ChapterBaseTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.SearchTypeItemJsonConverter),

            typeof(global::Spotify.JsonConverters.SearchTypeItemNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.SearchIncludeExternalJsonConverter),

            typeof(global::Spotify.JsonConverters.SearchIncludeExternalNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.GetFollowedTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.GetFollowedTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.FollowArtistsUsersTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.FollowArtistsUsersTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.UnfollowArtistsUsersTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.UnfollowArtistsUsersTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.CheckCurrentUserFollowsTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.CheckCurrentUserFollowsTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeJsonConverter),

            typeof(global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Spotify.JsonConverters.ItemJsonConverter),

            typeof(global::Spotify.JsonConverters.CurrentlyPlayingJsonConverter),

            typeof(global::Spotify.JsonConverters.QueueItemJsonConverter),

            typeof(global::Spotify.JsonConverters.Item2JsonConverter),

            typeof(global::Spotify.JsonConverters.CursorPagingPlayHistoryObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.CursorPagingSimplifiedArtistObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingPlaylistObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingArtistDiscographyAlbumObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSimplifiedAlbumObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSavedAlbumObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSimplifiedTrackObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSavedTrackObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingTrackObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingPlaylistTrackObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSimplifiedShowObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSavedShowObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSimplifiedEpisodeObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSavedEpisodeObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSimplifiedAudiobookObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingArtistObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PagingSimplifiedChapterObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.PlaylistOwnerObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.EpisodeObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedEpisodeObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.ShowObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.AudiobookObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedAudiobookObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedAlbumObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.ChapterObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.SimplifiedChapterObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.AlbumObjectJsonConverter),

            typeof(global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemJsonConverter),

            typeof(global::Spotify.JsonConverters.AllOfJsonConverter<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>),

            typeof(global::Spotify.JsonConverters.AllOfJsonConverter<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>),

            typeof(global::Spotify.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.JsonSerializerContextTypes))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.LinkedTrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason), TypeInfoPropertyName = "AlbumRestrictionObjectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterRestrictionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowersObject))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType), TypeInfoPropertyName = "ArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType), TypeInfoPropertyName = "SimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlayHistoryObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ContextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item), TypeInfoPropertyName = "Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject), TypeInfoPropertyName = "EpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType), TypeInfoPropertyName = "PlaylistTrackObjectItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PrivateUserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExplicitContentSettingsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PublicUserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PublicUserObjectType), TypeInfoPropertyName = "PublicUserObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioAnalysisObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioAnalysisObjectMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioAnalysisObjectTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TimeIntervalObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SectionObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SectionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SegmentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SegmentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioFeaturesObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioFeaturesObjectType), TypeInfoPropertyName = "AudioFeaturesObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedTrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingPlayHistoryObject), TypeInfoPropertyName = "CursorPagingPlayHistoryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingPlayHistoryObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.PlayHistoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingSimplifiedArtistObject), TypeInfoPropertyName = "CursorPagingSimplifiedArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingSimplifiedArtistObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObject), TypeInfoPropertyName = "PagingPlaylistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedPlaylistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedPlaylistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingFeaturedPlaylistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistDiscographyAlbumObject), TypeInfoPropertyName = "PagingArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistDiscographyAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ArtistDiscographyAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObject), TypeInfoPropertyName = "ArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAlbumObject), TypeInfoPropertyName = "PagingSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject), TypeInfoPropertyName = "SimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedAlbumObject), TypeInfoPropertyName = "PagingSavedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SavedAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SavedAlbumObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedTrackObject), TypeInfoPropertyName = "PagingSimplifiedTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedTrackObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedTrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedTrackObject), TypeInfoPropertyName = "PagingSavedTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedTrackObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SavedTrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SavedTrackObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingTrackObject), TypeInfoPropertyName = "PagingTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingTrackObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.TrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObject), TypeInfoPropertyName = "PagingPlaylistTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.PlaylistTrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedShowObject), TypeInfoPropertyName = "PagingSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedShowObjectVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedEpisodeObject), TypeInfoPropertyName = "PagingSavedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedEpisodeObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SavedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SavedEpisodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObject), TypeInfoPropertyName = "PagingSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedAudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAudiobookObject), TypeInfoPropertyName = "SimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistObject), TypeInfoPropertyName = "PagingArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedChapterObject), TypeInfoPropertyName = "PagingSimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedChapterObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedChapterObject), TypeInfoPropertyName = "SimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RecommendationsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.RecommendationSeedObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RecommendationSeedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumObject), TypeInfoPropertyName = "AlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObject), TypeInfoPropertyName = "PlaylistOwnerObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTracksRefObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType), TypeInfoPropertyName = "PlaylistUserObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CategoryObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalIdObject))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType), TypeInfoPropertyName = "TrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision), TypeInfoPropertyName = "EpisodeBaseReleaseDatePrecision2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ResumePointObject))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType), TypeInfoPropertyName = "EpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CopyrightObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType), TypeInfoPropertyName = "ShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowObject), TypeInfoPropertyName = "ShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AuthorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AuthorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.NarratorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.NarratorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBaseType), TypeInfoPropertyName = "AudiobookBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookObject), TypeInfoPropertyName = "AudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType), TypeInfoPropertyName = "AlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision), TypeInfoPropertyName = "AlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType), TypeInfoPropertyName = "AlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup), TypeInfoPropertyName = "ArtistDiscographyAlbumObjectVariant2AlbumGroup2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterObject), TypeInfoPropertyName = "ChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseReleaseDatePrecision), TypeInfoPropertyName = "ChapterBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseType), TypeInfoPropertyName = "ChapterBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.RemoveTracksPlaylistRequestTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistRequestTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.RemoveItemsPlaylistRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAlbumsUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAlbumsUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SaveTracksUserRequestTimestampedId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserRequestTimestampedId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveEpisodesUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveEpisodesUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.StartAUsersPlaybackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SearchTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchTypeItem), TypeInfoPropertyName = "SearchTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchIncludeExternal), TypeInfoPropertyName = "SearchIncludeExternal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksType), TypeInfoPropertyName = "GetUsersTopArtistsAndTracksType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedType), TypeInfoPropertyName = "GetFollowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersType), TypeInfoPropertyName = "FollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersType), TypeInfoPropertyName = "UnfollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsType), TypeInfoPropertyName = "CheckCurrentUserFollowsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleArtistsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsRelatedArtistsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleShowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAShowsEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnEpisodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.EpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAudiobookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAudiobooksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudiobookChaptersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAudiobooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAudiobooksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAudiobooksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAudiobooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAChapterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCurrentUsersProfileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAListOfCurrentUsersPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveLibraryItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveLibraryItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckLibraryContainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAlbumsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAlbumsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveEpisodesUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveEpisodesUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedShowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveShowsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveShowsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedShowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>), TypeInfoPropertyName = "AllOfPagingObjectGetUsersTopArtistsAndTracksResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItem), TypeInfoPropertyName = "GetUsersTopArtistsAndTracksResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType), TypeInfoPropertyName = "GetUsersTopArtistsAndTracksResponseItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersProfileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>), TypeInfoPropertyName = "AllOfPagingObjectGetCategoriesResponseCategories22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponseCategories2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CategoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AudioFeaturesObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.DeviceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTheUsersCurrentlyPlayingTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.StartAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PauseAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToNextTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SkipUsersPlaybackToPreviousTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SeekToPositionInCurrentlyPlayingTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetRepeatModeOnUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SetVolumeForUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ToggleShuffleForUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecentlyPlayedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddToQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.QueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.TimeIntervalObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SectionObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SegmentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.PlayHistoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ArtistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedPlaylistObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ArtistDiscographyAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SavedAlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedTrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SavedTrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.TrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.PlaylistTrackObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SavedShowObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SavedEpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedAudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RecommendationSeedObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AuthorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.NarratorObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RemoveTracksPlaylistRequestTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RemoveItemsPlaylistRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SaveTracksUserRequestTimestampedId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SearchTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.EpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AudiobookObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CategoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AudioFeaturesObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.DeviceObject>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}