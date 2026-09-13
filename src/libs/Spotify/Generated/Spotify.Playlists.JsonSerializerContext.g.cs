
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ExternalUrlObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackRestrictionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason), TypeInfoPropertyName = "AlbumRestrictionObjectReason2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeRestrictionObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.ImageObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ImageObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObject), TypeInfoPropertyName = "PagingPlaylistObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.SimplifiedPlaylistObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedPlaylistObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingFeaturedPlaylistObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject), TypeInfoPropertyName = "SimplifiedAlbumObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObject), TypeInfoPropertyName = "PagingPlaylistTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Spotify.PlaylistTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject), TypeInfoPropertyName = "SimplifiedShowObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObject), TypeInfoPropertyName = "PlaylistOwnerObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTracksRefObject), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType), TypeInfoPropertyName = "PlaylistUserObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObjectVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ChangePlaylistDetailsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAListOfCurrentUsersPlaylistsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAListOfCurrentUsersPlaylistsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetAListOfCurrentUsersPlaylistsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetListUsersPlaylistsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CreatePlaylistForUserResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.FollowPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UnfollowPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetFeaturedPlaylistsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetACategoriesPlaylistsResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.GetPlaylistCoverResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.UploadCustomPlaylistCoverResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.CheckIfUserFollowsPlaylistResponse3), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumRestrictionObjectReason?), TypeInfoPropertyName = "NullableAlbumRestrictionObjectReason2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedArtistObjectType?), TypeInfoPropertyName = "NullableSimplifiedArtistObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.Item?), TypeInfoPropertyName = "NullableItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeObject?), TypeInfoPropertyName = "NullableEpisodeObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?), TypeInfoPropertyName = "NullablePlaylistTrackObjectItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistObject?), TypeInfoPropertyName = "NullablePagingPlaylistObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedAlbumObject?), TypeInfoPropertyName = "NullableSimplifiedAlbumObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PagingPlaylistTrackObject?), TypeInfoPropertyName = "NullablePagingPlaylistTrackObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.SimplifiedShowObject?), TypeInfoPropertyName = "NullableSimplifiedShowObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistOwnerObject?), TypeInfoPropertyName = "NullablePlaylistOwnerObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.PlaylistUserObjectType?), TypeInfoPropertyName = "NullablePlaylistUserObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.TrackObjectType?), TypeInfoPropertyName = "NullableTrackObjectType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableEpisodeBaseReleaseDatePrecision2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.EpisodeBaseType?), TypeInfoPropertyName = "NullableEpisodeBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.ShowBaseType?), TypeInfoPropertyName = "NullableShowBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseAlbumType?), TypeInfoPropertyName = "NullableAlbumBaseAlbumType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseReleaseDatePrecision?), TypeInfoPropertyName = "NullableAlbumBaseReleaseDatePrecision2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Spotify.AlbumBaseType?), TypeInfoPropertyName = "NullableAlbumBaseType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.ImageObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.SimplifiedPlaylistObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.PlaylistTrackObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.CopyrightObject>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RemoveTracksPlaylistRequestTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Spotify.RemoveItemsPlaylistRequestItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    internal sealed partial class PlaylistsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PlaylistsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PlaylistsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Spotify.JsonConverters.PagingPlaylistObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PagingPlaylistTrackObjectJsonConverter());
            options.Converters.Add(new global::Spotify.JsonConverters.PlaylistOwnerObjectJsonConverter());
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

                    || typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType)

                    || typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?)

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

                if (typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType))
                {
                    return new global::Spotify.JsonConverters.PlaylistTrackObjectItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Spotify.PlaylistTrackObjectItemDiscriminatorType?))
                {
                    return new global::Spotify.JsonConverters.PlaylistTrackObjectItemDiscriminatorTypeNullableJsonConverter();
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
                    0 => new PlaylistsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}