
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SavedAlbumObject
    {
        /// <summary>
        /// The date and time the album was saved<br/>
        /// Timestamps are returned in ISO 8601 format as Coordinated Universal Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// If the time is imprecise (for example, the date/time of an album release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// Information about the album.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("album")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.AlbumObjectJsonConverter))]
        public global::Spotify.AlbumObject? Album { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedAlbumObject" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// The date and time the album was saved<br/>
        /// Timestamps are returned in ISO 8601 format as Coordinated Universal Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// If the time is imprecise (for example, the date/time of an album release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </param>
        /// <param name="album">
        /// Information about the album.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedAlbumObject(
            global::System.DateTime? addedAt,
            global::Spotify.AlbumObject? album)
        {
            this.AddedAt = addedAt;
            this.Album = album;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedAlbumObject" /> class.
        /// </summary>
        public SavedAlbumObject()
        {
        }

    }
}