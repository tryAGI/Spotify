
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup), TypeInfoPropertyName = "ArtistDiscographyAlbumObjectVariant2AlbumGroup2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AlbumObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleAlbumsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnEpisodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnEpisodeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnEpisodeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.EpisodeObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetMultipleEpisodesResponse4))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAChapterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAChapterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAChapterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ChapterObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralChaptersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCurrentUsersProfileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCurrentUsersProfileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCurrentUsersProfileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsItemsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsItemsResponse3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAListOfCurrentUsersPlaylistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAListOfCurrentUsersPlaylistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveLibraryItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveLibraryItemsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveLibraryItemsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveLibraryItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveLibraryItemsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveLibraryItemsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckLibraryContainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckLibraryContainsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckLibraryContainsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAlbumsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedAlbumsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAlbumsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAlbumsUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveAlbumsUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAlbumsUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAlbumsUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveAlbumsUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAlbumsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedAlbumsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedEpisodesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedEpisodesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveEpisodesUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveEpisodesUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveEpisodesUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveEpisodesUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveEpisodesUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveEpisodesUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedEpisodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedEpisodesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedEpisodesResponse3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersProfileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersProfileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>), TypeInfoPropertyName = "AllOfPagingObjectGetCategoriesResponseCategories22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponseCategories2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CategoryObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetCategoriesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetNewReleasesResponse4))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AudioFeaturesObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationGenresResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TransferAUsersPlaybackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAUsersAvailableDevicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.DeviceObject>))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAvailableMarketsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason?), TypeInfoPropertyName = "NullableAlbumRestrictionObjectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType?), TypeInfoPropertyName = "NullableArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType?), TypeInfoPropertyName = "NullableSimplifiedArtistObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item?), TypeInfoPropertyName = "NullableItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject?), TypeInfoPropertyName = "NullableEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?), TypeInfoPropertyName = "NullablePlaylistTrackObjectItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlaying?), TypeInfoPropertyName = "NullableCurrentlyPlaying2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType?), TypeInfoPropertyName = "NullableQueueObjectCurrentlyPlayingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueItem?), TypeInfoPropertyName = "NullableQueueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType?), TypeInfoPropertyName = "NullableQueueObjectQueueItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item2?), TypeInfoPropertyName = "NullableItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType?), TypeInfoPropertyName = "NullableCurrentlyPlayingContextObjectItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PublicUserObjectType?), TypeInfoPropertyName = "NullablePublicUserObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioFeaturesObjectType?), TypeInfoPropertyName = "NullableAudioFeaturesObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingPlayHistoryObject?), TypeInfoPropertyName = "NullableCursorPagingPlayHistoryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CursorPagingSimplifiedArtistObject?), TypeInfoPropertyName = "NullableCursorPagingSimplifiedArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObject?), TypeInfoPropertyName = "NullablePagingPlaylistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistDiscographyAlbumObject?), TypeInfoPropertyName = "NullablePagingArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObject?), TypeInfoPropertyName = "NullableArtistDiscographyAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAlbumObject?), TypeInfoPropertyName = "NullablePagingSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject?), TypeInfoPropertyName = "NullableSimplifiedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedAlbumObject?), TypeInfoPropertyName = "NullablePagingSavedAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedTrackObject?), TypeInfoPropertyName = "NullablePagingSimplifiedTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedTrackObject?), TypeInfoPropertyName = "NullablePagingSavedTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingTrackObject?), TypeInfoPropertyName = "NullablePagingTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObject?), TypeInfoPropertyName = "NullablePagingPlaylistTrackObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedShowObject?), TypeInfoPropertyName = "NullablePagingSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject?), TypeInfoPropertyName = "NullableSimplifiedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedShowObject?), TypeInfoPropertyName = "NullablePagingSavedShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedEpisodeObject?), TypeInfoPropertyName = "NullablePagingSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedEpisodeObject?), TypeInfoPropertyName = "NullableSimplifiedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedEpisodeObject?), TypeInfoPropertyName = "NullablePagingSavedEpisodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedAudiobookObject?), TypeInfoPropertyName = "NullablePagingSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAudiobookObject?), TypeInfoPropertyName = "NullableSimplifiedAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingArtistObject?), TypeInfoPropertyName = "NullablePagingArtistObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedChapterObject?), TypeInfoPropertyName = "NullablePagingSimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedChapterObject?), TypeInfoPropertyName = "NullableSimplifiedChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumObject?), TypeInfoPropertyName = "NullableAlbumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObject?), TypeInfoPropertyName = "NullablePlaylistOwnerObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType?), TypeInfoPropertyName = "NullablePlaylistUserObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType?), TypeInfoPropertyName = "NullableTrackObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableEpisodeBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType?), TypeInfoPropertyName = "NullableEpisodeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType?), TypeInfoPropertyName = "NullableShowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowObject?), TypeInfoPropertyName = "NullableShowObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookBaseType?), TypeInfoPropertyName = "NullableAudiobookBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudiobookObject?), TypeInfoPropertyName = "NullableAudiobookObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType?), TypeInfoPropertyName = "NullableAlbumBaseAlbumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableAlbumBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType?), TypeInfoPropertyName = "NullableAlbumBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup?), TypeInfoPropertyName = "NullableArtistDiscographyAlbumObjectVariant2AlbumGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterObject?), TypeInfoPropertyName = "NullableChapterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableChapterBaseReleaseDatePrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChapterBaseType?), TypeInfoPropertyName = "NullableChapterBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchTypeItem?), TypeInfoPropertyName = "NullableSearchTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SearchIncludeExternal?), TypeInfoPropertyName = "NullableSearchIncludeExternal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksType?), TypeInfoPropertyName = "NullableGetUsersTopArtistsAndTracksType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFollowedType?), TypeInfoPropertyName = "NullableGetFollowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowArtistsUsersType?), TypeInfoPropertyName = "NullableFollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowArtistsUsersType?), TypeInfoPropertyName = "NullableUnfollowArtistsUsersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckCurrentUserFollowsType?), TypeInfoPropertyName = "NullableCheckCurrentUserFollowsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>?), TypeInfoPropertyName = "NullableAllOfPagingObjectGetUsersTopArtistsAndTracksResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItem?), TypeInfoPropertyName = "NullableGetUsersTopArtistsAndTracksResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetUsersTopArtistsAndTracksResponseItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>?), TypeInfoPropertyName = "NullableAllOfPagingObjectGetCategoriesResponseCategories22")]
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
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Spotify.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.CurrentlyPlayingJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.QueueItemJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.Item2JsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.CursorPagingPlayHistoryObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.CursorPagingSimplifiedArtistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingPlaylistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingArtistDiscographyAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSavedAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSavedTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingPlaylistTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSavedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSavedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedAudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingArtistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedChapterObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PlaylistOwnerObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.EpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedEpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.ShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.AudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAudiobookObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.ChapterObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedChapterObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.AlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.AllOfJsonConverter<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>());
            options.Converters.Add(new global::Spotify.JsonConverters.AllOfJsonConverter<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>());
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

                    || typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.QueueObjectQueueItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Spotify.PublicUserObjectType)

                    || typeToConvert == typeof(global::Spotify.PublicUserObjectType?)

                    || typeToConvert == typeof(global::Spotify.AudioFeaturesObjectType)

                    || typeToConvert == typeof(global::Spotify.AudioFeaturesObjectType?)

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

                    || typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup)

                    || typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup?)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseType)

                    || typeToConvert == typeof(global::Spotify.ChapterBaseType?)

                    || typeToConvert == typeof(global::Spotify.SearchTypeItem)

                    || typeToConvert == typeof(global::Spotify.SearchTypeItem?)

                    || typeToConvert == typeof(global::Spotify.SearchIncludeExternal)

                    || typeToConvert == typeof(global::Spotify.SearchIncludeExternal?)

                    || typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType)

                    || typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType?)

                    || typeToConvert == typeof(global::Spotify.GetFollowedType)

                    || typeToConvert == typeof(global::Spotify.GetFollowedType?)

                    || typeToConvert == typeof(global::Spotify.FollowArtistsUsersType)

                    || typeToConvert == typeof(global::Spotify.FollowArtistsUsersType?)

                    || typeToConvert == typeof(global::Spotify.UnfollowArtistsUsersType)

                    || typeToConvert == typeof(global::Spotify.UnfollowArtistsUsersType?)

                    || typeToConvert == typeof(global::Spotify.CheckCurrentUserFollowsType)

                    || typeToConvert == typeof(global::Spotify.CheckCurrentUserFollowsType?)

                    || typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType?);
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

                if (typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType))
                {
                    return new global::Spotify.JsonConverters.PlaylistTrackObjectItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?))
                {
                    return new global::Spotify.JsonConverters.PlaylistTrackObjectItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Spotify.PublicUserObjectType))
                {
                    return new global::Spotify.JsonConverters.PublicUserObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.PublicUserObjectType?))
                {
                    return new global::Spotify.JsonConverters.PublicUserObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AudioFeaturesObjectType))
                {
                    return new global::Spotify.JsonConverters.AudioFeaturesObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.AudioFeaturesObjectType?))
                {
                    return new global::Spotify.JsonConverters.AudioFeaturesObjectTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup))
                {
                    return new global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup?))
                {
                    return new global::Spotify.JsonConverters.ArtistDiscographyAlbumObjectVariant2AlbumGroupNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType))
                {
                    return new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType?))
                {
                    return new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType))
                {
                    return new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType?))
                {
                    return new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}