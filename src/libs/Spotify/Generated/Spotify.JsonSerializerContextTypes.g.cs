
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Spotify.LinkedTrackObject? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ExternalUrlObject? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TrackRestrictionObject? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumRestrictionObject? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumRestrictionObjectReason? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeRestrictionObject? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterRestrictionObject? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ArtistObject? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.FollowersObject? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.ImageObject>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ImageObject? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ArtistObjectType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedArtistObject? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedArtistObjectType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlayHistoryObject? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TrackObject? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ContextObject? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistTrackObject? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistUserObject? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.Item? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeObject? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistTrackObjectItemDiscriminator? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistTrackObjectItemDiscriminatorType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.QueueObject? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CurrentlyPlaying? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.QueueObjectCurrentlyPlayingDiscriminator? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.QueueItem>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.QueueItem? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.QueueObjectQueueItemDiscriminator? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.QueueObjectQueueItemDiscriminatorType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CurrentlyPlayingContextObject? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.DeviceObject? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.Item2? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CurrentlyPlayingContextObjectItemDiscriminator? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CurrentlyPlayingContextObjectItemDiscriminatorType? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.DisallowsObject? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ErrorObject? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PrivateUserObject? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ExplicitContentSettingsObject? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PublicUserObject? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PublicUserObjectType? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudioAnalysisObject? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudioAnalysisObjectMeta? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudioAnalysisObjectTrack? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TimeIntervalObject? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SectionObject>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SectionObject? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SegmentObject>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SegmentObject? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudioFeaturesObject? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudioFeaturesObjectType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedTrackObject? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedArtistObject>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorObject? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorPagingObject? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorPagingPlayHistoryObject? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorPagingPlayHistoryObjectVariant2? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.PlayHistoryObject>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorPagingSimplifiedArtistObject? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CursorPagingSimplifiedArtistObjectVariant2? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.ArtistObject>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingObject? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingPlaylistObject? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingPlaylistObjectVariant2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedPlaylistObject>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedPlaylistObject? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingFeaturedPlaylistObject? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingArtistDiscographyAlbumObject? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingArtistDiscographyAlbumObjectVariant2? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.ArtistDiscographyAlbumObject>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ArtistDiscographyAlbumObject? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedAlbumObject? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedAlbumObjectVariant2? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedAlbumObject>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedAlbumObject? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedAlbumObject? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedAlbumObjectVariant2? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SavedAlbumObject>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SavedAlbumObject? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedTrackObject? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedTrackObjectVariant2? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedTrackObject>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedTrackObject? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedTrackObjectVariant2? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SavedTrackObject>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SavedTrackObject? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingTrackObject? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingTrackObjectVariant2? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.TrackObject>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingPlaylistTrackObject? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingPlaylistTrackObjectVariant2? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.PlaylistTrackObject>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedShowObject? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedShowObjectVariant2? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedShowObject>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedShowObject? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedShowObject? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedShowObjectVariant2? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SavedShowObject>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SavedShowObject? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedEpisodeObject? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedEpisodeObjectVariant2? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedEpisodeObject>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedEpisodeObject? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedEpisodeObject? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSavedEpisodeObjectVariant2? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SavedEpisodeObject>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SavedEpisodeObject? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedAudiobookObject? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedAudiobookObjectVariant2? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedAudiobookObject>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedAudiobookObject? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingArtistObject? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingArtistObjectVariant2? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedChapterObject? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PagingSimplifiedChapterObjectVariant2? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedChapterObject>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedChapterObject? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RecommendationsObject? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.RecommendationSeedObject>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RecommendationSeedObject? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumObject? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistObject? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistOwnerObject? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistTracksRefObject? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistUserObjectType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PlaylistOwnerObjectVariant2? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CategoryObject? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ExternalIdObject? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TrackObjectType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeBase? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeObjectVariant2? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeBaseReleaseDatePrecision? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ResumePointObject? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.EpisodeBaseType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowBase? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.CopyrightObject>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CopyrightObject? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowBaseType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowObject? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ShowObjectVariant2? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudiobookBase? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.AuthorObject>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AuthorObject? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.NarratorObject>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.NarratorObject? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudiobookBaseType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudiobookObject? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AudiobookObjectVariant2? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumBase? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumBaseAlbumType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumBaseReleaseDatePrecision? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumBaseType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SimplifiedAlbumObjectVariant2? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ArtistDiscographyAlbumObjectVariant2? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ArtistDiscographyAlbumObjectVariant2AlbumGroup? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterObject? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterBase? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterObjectVariant2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterBaseReleaseDatePrecision? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChapterBaseType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AlbumObjectVariant2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChangePlaylistDetailsRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddTracksToPlaylistRequest? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsTracksRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksPlaylistRequest? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.RemoveTracksPlaylistRequestTrack>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksPlaylistRequestTrack? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddItemsToPlaylistRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsItemsRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveItemsPlaylistRequest? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.RemoveItemsPlaylistRequestItem>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveItemsPlaylistRequestItem? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CreatePlaylistRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveAlbumsUserRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveAlbumsUserRequest? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveTracksUserRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SaveTracksUserRequestTimestampedId>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveTracksUserRequestTimestampedId? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksUserRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveEpisodesUserRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveEpisodesUserRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CreatePlaylistForUserRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.FollowPlaylistRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.FollowArtistsUsersRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.UnfollowArtistsUsersRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TransferAUsersPlaybackRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.StartAUsersPlaybackRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.SearchTypeItem>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SearchTypeItem? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SearchIncludeExternal? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetFollowedType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.FollowArtistsUsersType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.UnfollowArtistsUsersType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckCurrentUserFollowsType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnAlbumResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAlbumsResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.AlbumObject>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAlbumsResponse2? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAlbumsResponse3? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAlbumsResponse4? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnAlbumsTracksResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleArtistsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleArtistsResponse2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleArtistsResponse3? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleArtistsResponse4? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsAlbumsResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsTopTracksResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsTopTracksResponse2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsTopTracksResponse3? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsTopTracksResponse4? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsRelatedArtistsResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsRelatedArtistsResponse2? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsRelatedArtistsResponse3? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnArtistsRelatedArtistsResponse4? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAShowResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleShowsResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleShowsResponse2? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleShowsResponse3? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleShowsResponse4? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAShowsEpisodesResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnEpisodeResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleEpisodesResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.EpisodeObject>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleEpisodesResponse2? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleEpisodesResponse3? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleEpisodesResponse4? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAnAudiobookResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAudiobooksResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.AudiobookObject>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAudiobooksResponse2? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAudiobooksResponse3? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetMultipleAudiobooksResponse4? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAudiobookChaptersResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersSavedAudiobooksResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveAudiobooksUserResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveAudiobooksUserResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckUsersSavedAudiobooksResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAChapterResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralChaptersResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.ChapterObject>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralChaptersResponse2? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralChaptersResponse3? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralChaptersResponse4? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetTrackResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralTracksResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralTracksResponse2? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralTracksResponse3? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralTracksResponse4? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SearchResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SearchResponse2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SearchResponse3? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SearchResponse4? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetCurrentUsersProfileResponse? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetPlaylistResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ChangePlaylistDetailsResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetPlaylistsTracksResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddTracksToPlaylistResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddTracksToPlaylistResponse2? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddTracksToPlaylistResponse3? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddTracksToPlaylistResponse4? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsTracksResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsTracksResponse2? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsTracksResponse3? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsTracksResponse4? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksPlaylistResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksPlaylistResponse2? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksPlaylistResponse3? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksPlaylistResponse4? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetPlaylistsItemsResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddItemsToPlaylistResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddItemsToPlaylistResponse2? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddItemsToPlaylistResponse3? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddItemsToPlaylistResponse4? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsItemsResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsItemsResponse2? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsItemsResponse3? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ReorderOrReplacePlaylistsItemsResponse4? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveItemsPlaylistResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveItemsPlaylistResponse2? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveItemsPlaylistResponse3? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveItemsPlaylistResponse4? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAListOfCurrentUsersPlaylistsResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CreatePlaylistResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveLibraryItemsResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveLibraryItemsResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckLibraryContainsResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersSavedAlbumsResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveAlbumsUserResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveAlbumsUserResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckUsersSavedAlbumsResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersSavedTracksResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveTracksUserResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveTracksUserResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckUsersSavedTracksResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersSavedEpisodesResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveEpisodesUserResponse? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveEpisodesUserResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckUsersSavedEpisodesResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersSavedShowsResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SaveShowsUserResponse? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.RemoveShowsUserResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckUsersSavedShowsResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetUsersTopArtistsAndTracksResponse2>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponse2? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponseItem? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminator? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponseItemDiscriminatorType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponse3? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponse4? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersTopArtistsAndTracksResponse5? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetUsersProfileResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetListUsersPlaylistsResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CreatePlaylistForUserResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.FollowPlaylistResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.UnfollowPlaylistResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetFeaturedPlaylistsResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetCategoriesResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetCategoriesResponseCategories2? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.CategoryObject>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetCategoriesResponse2? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetCategoriesResponse3? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetCategoriesResponse4? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetACategoryResponse? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetACategoriesPlaylistsResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetPlaylistCoverResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.UploadCustomPlaylistCoverResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetNewReleasesResponse? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetNewReleasesResponse2? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetNewReleasesResponse3? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetNewReleasesResponse4? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetFollowedResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetFollowedResponse2? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetFollowedResponse3? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetFollowedResponse4? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.FollowArtistsUsersResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.UnfollowArtistsUsersResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckCurrentUserFollowsResponse? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.CheckIfUserFollowsPlaylistResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralAudioFeaturesResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.AudioFeaturesObject>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralAudioFeaturesResponse2? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralAudioFeaturesResponse3? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetSeveralAudioFeaturesResponse4? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAudioFeaturesResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAudioAnalysisResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetRecommendationsResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetRecommendationGenresResponse? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetRecommendationGenresResponse2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetRecommendationGenresResponse3? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetRecommendationGenresResponse4? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetInformationAboutTheUsersCurrentPlaybackResponse? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.TransferAUsersPlaybackResponse? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAUsersAvailableDevicesResponse? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Spotify.DeviceObject>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAUsersAvailableDevicesResponse2? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAUsersAvailableDevicesResponse3? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAUsersAvailableDevicesResponse4? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetTheUsersCurrentlyPlayingTrackResponse? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.StartAUsersPlaybackResponse? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.PauseAUsersPlaybackResponse? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SkipUsersPlaybackToNextTrackResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SkipUsersPlaybackToPreviousTrackResponse? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SeekToPositionInCurrentlyPlayingTrackResponse? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SetRepeatModeOnUsersPlaybackResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.SetVolumeForUsersPlaybackResponse? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.ToggleShuffleForUsersPlaybackResponse? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetRecentlyPlayedResponse? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetQueueResponse? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.AddToQueueResponse? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAvailableMarketsResponse? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAvailableMarketsResponse2? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAvailableMarketsResponse3? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Spotify.GetAvailableMarketsResponse4? Type392 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.ImageObject>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.QueueItem>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.TimeIntervalObject>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SectionObject>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SegmentObject>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedArtistObject>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.PlayHistoryObject>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.ArtistObject>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedPlaylistObject>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.ArtistDiscographyAlbumObject>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedAlbumObject>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SavedAlbumObject>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedTrackObject>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SavedTrackObject>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.TrackObject>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.PlaylistTrackObject>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedShowObject>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SavedShowObject>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedEpisodeObject>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SavedEpisodeObject>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedAudiobookObject>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SimplifiedChapterObject>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.RecommendationSeedObject>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.CopyrightObject>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.AuthorObject>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.NarratorObject>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.RemoveTracksPlaylistRequestTrack>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.RemoveItemsPlaylistRequestItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SaveTracksUserRequestTimestampedId>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.SearchTypeItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.AlbumObject>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.EpisodeObject>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.AudiobookObject>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.ChapterObject>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.GetUsersTopArtistsAndTracksResponseItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.CategoryObject>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.AudioFeaturesObject>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.DeviceObject>? ListType40 { get; set; }
    }
}