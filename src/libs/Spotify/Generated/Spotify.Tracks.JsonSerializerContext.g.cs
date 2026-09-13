
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
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.LinkedTrackObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalUrlObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackRestrictionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason), TypeInfoPropertyName = "AlbumRestrictionObjectReason2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeRestrictionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowersObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType), TypeInfoPropertyName = "ArtistObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType), TypeInfoPropertyName = "SimplifiedArtistObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item), TypeInfoPropertyName = "Item2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject), TypeInfoPropertyName = "EpisodeObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminator), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType), TypeInfoPropertyName = "PlaylistTrackObjectItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ErrorObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioAnalysisObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioAnalysisObjectMeta), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioAnalysisObjectTrack), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TimeIntervalObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SectionObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SectionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SegmentObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SegmentObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioFeaturesObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioFeaturesObjectType), TypeInfoPropertyName = "AudioFeaturesObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedTrackObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject), TypeInfoPropertyName = "SimplifiedAlbumObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedTrackObject), TypeInfoPropertyName = "PagingSimplifiedTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedTrackObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedTrackObject), TypeInfoPropertyName = "PagingSavedTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedTrackObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SavedTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SavedTrackObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.TrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObject), TypeInfoPropertyName = "PagingPlaylistTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.PlaylistTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject), TypeInfoPropertyName = "SimplifiedShowObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RecommendationsObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.RecommendationSeedObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RecommendationSeedObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType), TypeInfoPropertyName = "PlaylistUserObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalIdObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType), TypeInfoPropertyName = "TrackObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBase), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision), TypeInfoPropertyName = "EpisodeBaseReleaseDatePrecision2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ResumePointObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType), TypeInfoPropertyName = "EpisodeBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBase), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CopyrightObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType), TypeInfoPropertyName = "ShowBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBase), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType), TypeInfoPropertyName = "AlbumBaseAlbumType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision), TypeInfoPropertyName = "AlbumBaseReleaseDatePrecision2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType), TypeInfoPropertyName = "AlbumBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.RemoveTracksPlaylistRequestTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistRequestTrack), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.RemoveItemsPlaylistRequestItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistRequestItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SaveTracksUserRequestTimestampedId>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserRequestTimestampedId), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksType), TypeInfoPropertyName = "GetUsersTopArtistsAndTracksType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnAlbumsTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAnArtistsTopTracksResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetTrackResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralTracksResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddTracksToPlaylistResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsTracksResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksPlaylistResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsItemsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsItemsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistsItemsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AddItemsToPlaylistResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ReorderOrReplacePlaylistsItemsResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveItemsPlaylistResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersSavedTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SaveTracksUserResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.RemoveTracksUserResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckUsersSavedTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>), TypeInfoPropertyName = "AllOfPagingObjectGetUsersTopArtistsAndTracksResponse22", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItem), TypeInfoPropertyName = "GetUsersTopArtistsAndTracksResponseItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminator), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType), TypeInfoPropertyName = "GetUsersTopArtistsAndTracksResponseItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponse5), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.AudioFeaturesObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetSeveralAudioFeaturesResponse4), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioFeaturesResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAudioAnalysisResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetRecommendationsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason?), TypeInfoPropertyName = "NullableAlbumRestrictionObjectReason2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ArtistObjectType?), TypeInfoPropertyName = "NullableArtistObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType?), TypeInfoPropertyName = "NullableSimplifiedArtistObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item?), TypeInfoPropertyName = "NullableItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject?), TypeInfoPropertyName = "NullableEpisodeObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?), TypeInfoPropertyName = "NullablePlaylistTrackObjectItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AudioFeaturesObjectType?), TypeInfoPropertyName = "NullableAudioFeaturesObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject?), TypeInfoPropertyName = "NullableSimplifiedAlbumObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSimplifiedTrackObject?), TypeInfoPropertyName = "NullablePagingSimplifiedTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingSavedTrackObject?), TypeInfoPropertyName = "NullablePagingSavedTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObject?), TypeInfoPropertyName = "NullablePagingPlaylistTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject?), TypeInfoPropertyName = "NullableSimplifiedShowObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType?), TypeInfoPropertyName = "NullablePlaylistUserObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType?), TypeInfoPropertyName = "NullableTrackObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableEpisodeBaseReleaseDatePrecision2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType?), TypeInfoPropertyName = "NullableEpisodeBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType?), TypeInfoPropertyName = "NullableShowBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType?), TypeInfoPropertyName = "NullableAlbumBaseAlbumType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableAlbumBaseReleaseDatePrecision2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType?), TypeInfoPropertyName = "NullableAlbumBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksType?), TypeInfoPropertyName = "NullableGetUsersTopArtistsAndTracksType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>?), TypeInfoPropertyName = "NullableAllOfPagingObjectGetUsersTopArtistsAndTracksResponse22", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItem?), TypeInfoPropertyName = "NullableGetUsersTopArtistsAndTracksResponseItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetUsersTopArtistsAndTracksResponseItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.TimeIntervalObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SectionObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SegmentObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SavedTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.TrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.PlaylistTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RecommendationSeedObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RemoveTracksPlaylistRequestTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RemoveItemsPlaylistRequestItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SaveTracksUserRequestTimestampedId>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.AudioFeaturesObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    internal sealed partial class TracksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TracksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TracksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Spotify.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSimplifiedTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingSavedTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingPlaylistTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.EpisodeObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.SimplifiedAlbumObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksResponseItemJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.AllOfJsonConverter<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>());
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

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseAlbumType?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseReleaseDatePrecision?)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType)

                    || typeToConvert == typeof(global::Spotify.AlbumBaseType?)

                    || typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType)

                    || typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType?)

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

                if (typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType))
                {
                    return new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.GetUsersTopArtistsAndTracksType?))
                {
                    return new global::Spotify.JsonConverters.GetUsersTopArtistsAndTracksTypeNullableJsonConverter();
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
                    0 => new TracksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}