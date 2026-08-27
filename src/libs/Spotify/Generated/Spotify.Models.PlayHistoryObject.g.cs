
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlayHistoryObject
    {
        /// <summary>
        /// The track the user listened to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        public global::Spotify.TrackObject? Track { get; set; }

        /// <summary>
        /// The date and time the track was played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("played_at")]
        public global::System.DateTime? PlayedAt { get; set; }

        /// <summary>
        /// The context the track was played from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Spotify.ContextObject? Context { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayHistoryObject" /> class.
        /// </summary>
        /// <param name="track">
        /// The track the user listened to.
        /// </param>
        /// <param name="playedAt">
        /// The date and time the track was played.
        /// </param>
        /// <param name="context">
        /// The context the track was played from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlayHistoryObject(
            global::Spotify.TrackObject? track,
            global::System.DateTime? playedAt,
            global::Spotify.ContextObject? context)
        {
            this.Track = track;
            this.PlayedAt = playedAt;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayHistoryObject" /> class.
        /// </summary>
        public PlayHistoryObject()
        {
        }

    }
}