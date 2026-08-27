
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SavedShowObject
    {
        /// <summary>
        /// The date and time the show was saved.<br/>
        /// Timestamps are returned in ISO 8601 format as Coordinated Universal Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// If the time is imprecise (for example, the date/time of an album release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// Information about the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.SimplifiedShowObjectJsonConverter))]
        public global::Spotify.SimplifiedShowObject? Show { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedShowObject" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// The date and time the show was saved.<br/>
        /// Timestamps are returned in ISO 8601 format as Coordinated Universal Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// If the time is imprecise (for example, the date/time of an album release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </param>
        /// <param name="show">
        /// Information about the show.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedShowObject(
            global::System.DateTime? addedAt,
            global::Spotify.SimplifiedShowObject? show)
        {
            this.AddedAt = addedAt;
            this.Show = show;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedShowObject" /> class.
        /// </summary>
        public SavedShowObject()
        {
        }

    }
}