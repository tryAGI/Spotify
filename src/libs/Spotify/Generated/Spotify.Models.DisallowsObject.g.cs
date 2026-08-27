
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DisallowsObject
    {
        /// <summary>
        /// Interrupting playback. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupting_playback")]
        public bool? InterruptingPlayback { get; set; }

        /// <summary>
        /// Pausing. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausing")]
        public bool? Pausing { get; set; }

        /// <summary>
        /// Resuming. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resuming")]
        public bool? Resuming { get; set; }

        /// <summary>
        /// Seeking playback location. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seeking")]
        public bool? Seeking { get; set; }

        /// <summary>
        /// Skipping to the next context. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipping_next")]
        public bool? SkippingNext { get; set; }

        /// <summary>
        /// Skipping to the previous context. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipping_prev")]
        public bool? SkippingPrev { get; set; }

        /// <summary>
        /// Toggling repeat context flag. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggling_repeat_context")]
        public bool? TogglingRepeatContext { get; set; }

        /// <summary>
        /// Toggling shuffle flag. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggling_shuffle")]
        public bool? TogglingShuffle { get; set; }

        /// <summary>
        /// Toggling repeat track flag. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggling_repeat_track")]
        public bool? TogglingRepeatTrack { get; set; }

        /// <summary>
        /// Transfering playback between devices. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferring_playback")]
        public bool? TransferringPlayback { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisallowsObject" /> class.
        /// </summary>
        /// <param name="interruptingPlayback">
        /// Interrupting playback. Optional field.
        /// </param>
        /// <param name="pausing">
        /// Pausing. Optional field.
        /// </param>
        /// <param name="resuming">
        /// Resuming. Optional field.
        /// </param>
        /// <param name="seeking">
        /// Seeking playback location. Optional field.
        /// </param>
        /// <param name="skippingNext">
        /// Skipping to the next context. Optional field.
        /// </param>
        /// <param name="skippingPrev">
        /// Skipping to the previous context. Optional field.
        /// </param>
        /// <param name="togglingRepeatContext">
        /// Toggling repeat context flag. Optional field.
        /// </param>
        /// <param name="togglingShuffle">
        /// Toggling shuffle flag. Optional field.
        /// </param>
        /// <param name="togglingRepeatTrack">
        /// Toggling repeat track flag. Optional field.
        /// </param>
        /// <param name="transferringPlayback">
        /// Transfering playback between devices. Optional field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DisallowsObject(
            bool? interruptingPlayback,
            bool? pausing,
            bool? resuming,
            bool? seeking,
            bool? skippingNext,
            bool? skippingPrev,
            bool? togglingRepeatContext,
            bool? togglingShuffle,
            bool? togglingRepeatTrack,
            bool? transferringPlayback)
        {
            this.InterruptingPlayback = interruptingPlayback;
            this.Pausing = pausing;
            this.Resuming = resuming;
            this.Seeking = seeking;
            this.SkippingNext = skippingNext;
            this.SkippingPrev = skippingPrev;
            this.TogglingRepeatContext = togglingRepeatContext;
            this.TogglingShuffle = togglingShuffle;
            this.TogglingRepeatTrack = togglingRepeatTrack;
            this.TransferringPlayback = transferringPlayback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisallowsObject" /> class.
        /// </summary>
        public DisallowsObject()
        {
        }

    }
}