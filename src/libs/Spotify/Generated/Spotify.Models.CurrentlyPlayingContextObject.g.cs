
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CurrentlyPlayingContextObject
    {
        /// <summary>
        /// The device that is currently active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        public global::Spotify.DeviceObject? Device { get; set; }

        /// <summary>
        /// off, track, context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat_state")]
        public string? RepeatState { get; set; }

        /// <summary>
        /// If shuffle is on or off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shuffle_state")]
        public bool? ShuffleState { get; set; }

        /// <summary>
        /// A Context Object. Can be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Spotify.ContextObject? Context { get; set; }

        /// <summary>
        /// Unix Millisecond Timestamp when playback state was last changed (play, pause, skip, scrub, new song, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Progress into the currently playing track or episode. Can be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_ms")]
        public int? ProgressMs { get; set; }

        /// <summary>
        /// If something is currently playing, return `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_playing")]
        public bool? IsPlaying { get; set; }

        /// <summary>
        /// The currently playing track or episode. Can be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.Item2JsonConverter))]
        public global::Spotify.Item2? Item { get; set; }

        /// <summary>
        /// The object type of the currently playing item. Can be one of `track`, `episode`, `ad` or `unknown`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        /// <summary>
        /// Allows to update the user interface based on which playback actions are available within the current context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::Spotify.DisallowsObject? Actions { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentlyPlayingContextObject" /> class.
        /// </summary>
        /// <param name="device">
        /// The device that is currently active.
        /// </param>
        /// <param name="repeatState">
        /// off, track, context
        /// </param>
        /// <param name="shuffleState">
        /// If shuffle is on or off.
        /// </param>
        /// <param name="context">
        /// A Context Object. Can be `null`.
        /// </param>
        /// <param name="timestamp">
        /// Unix Millisecond Timestamp when playback state was last changed (play, pause, skip, scrub, new song, etc.).
        /// </param>
        /// <param name="progressMs">
        /// Progress into the currently playing track or episode. Can be `null`.
        /// </param>
        /// <param name="isPlaying">
        /// If something is currently playing, return `true`.
        /// </param>
        /// <param name="item">
        /// The currently playing track or episode. Can be `null`.
        /// </param>
        /// <param name="currentlyPlayingType">
        /// The object type of the currently playing item. Can be one of `track`, `episode`, `ad` or `unknown`.
        /// </param>
        /// <param name="actions">
        /// Allows to update the user interface based on which playback actions are available within the current context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentlyPlayingContextObject(
            global::Spotify.DeviceObject? device,
            string? repeatState,
            bool? shuffleState,
            global::Spotify.ContextObject? context,
            long? timestamp,
            int? progressMs,
            bool? isPlaying,
            global::Spotify.Item2? item,
            string? currentlyPlayingType,
            global::Spotify.DisallowsObject? actions)
        {
            this.Device = device;
            this.RepeatState = repeatState;
            this.ShuffleState = shuffleState;
            this.Context = context;
            this.Timestamp = timestamp;
            this.ProgressMs = progressMs;
            this.IsPlaying = isPlaying;
            this.Item = item;
            this.CurrentlyPlayingType = currentlyPlayingType;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentlyPlayingContextObject" /> class.
        /// </summary>
        public CurrentlyPlayingContextObject()
        {
        }

    }
}