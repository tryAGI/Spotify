
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingTrackObjectJsonConverter))]
        public global::Spotify.PagingTrackObject? Tracks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingArtistObjectJsonConverter))]
        public global::Spotify.PagingArtistObject? Artists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("albums")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedAlbumObjectJsonConverter))]
        public global::Spotify.PagingSimplifiedAlbumObject? Albums { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlists")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingPlaylistObjectJsonConverter))]
        public global::Spotify.PagingPlaylistObject? Playlists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedShowObjectJsonConverter))]
        public global::Spotify.PagingSimplifiedShowObject? Shows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedEpisodeObjectJsonConverter))]
        public global::Spotify.PagingSimplifiedEpisodeObject? Episodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audiobooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedAudiobookObjectJsonConverter))]
        public global::Spotify.PagingSimplifiedAudiobookObject? Audiobooks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="tracks"></param>
        /// <param name="artists"></param>
        /// <param name="albums"></param>
        /// <param name="playlists"></param>
        /// <param name="shows"></param>
        /// <param name="episodes"></param>
        /// <param name="audiobooks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            global::Spotify.PagingTrackObject? tracks,
            global::Spotify.PagingArtistObject? artists,
            global::Spotify.PagingSimplifiedAlbumObject? albums,
            global::Spotify.PagingPlaylistObject? playlists,
            global::Spotify.PagingSimplifiedShowObject? shows,
            global::Spotify.PagingSimplifiedEpisodeObject? episodes,
            global::Spotify.PagingSimplifiedAudiobookObject? audiobooks)
        {
            this.Tracks = tracks;
            this.Artists = artists;
            this.Albums = albums;
            this.Playlists = playlists;
            this.Shows = shows;
            this.Episodes = episodes;
            this.Audiobooks = audiobooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }

    }
}