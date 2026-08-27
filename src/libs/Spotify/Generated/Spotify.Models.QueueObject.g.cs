
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueObject
    {
        /// <summary>
        /// The currently playing track or episode. Can be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currently_playing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.CurrentlyPlayingJsonConverter))]
        public global::Spotify.CurrentlyPlaying? CurrentlyPlaying { get; set; }

        /// <summary>
        /// The tracks or episodes in the queue. Can be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        public global::System.Collections.Generic.IList<global::Spotify.QueueItem>? Queue { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueObject" /> class.
        /// </summary>
        /// <param name="currentlyPlaying">
        /// The currently playing track or episode. Can be `null`.
        /// </param>
        /// <param name="queue">
        /// The tracks or episodes in the queue. Can be empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueObject(
            global::Spotify.CurrentlyPlaying? currentlyPlaying,
            global::System.Collections.Generic.IList<global::Spotify.QueueItem>? queue)
        {
            this.CurrentlyPlaying = currentlyPlaying;
            this.Queue = queue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueObject" /> class.
        /// </summary>
        public QueueObject()
        {
        }

    }
}