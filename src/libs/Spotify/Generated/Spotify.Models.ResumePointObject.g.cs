
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResumePointObject
    {
        /// <summary>
        /// Whether or not the episode has been fully played by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fully_played")]
        public bool? FullyPlayed { get; set; }

        /// <summary>
        /// The user's most recent position in the episode in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_position_ms")]
        public int? ResumePositionMs { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePointObject" /> class.
        /// </summary>
        /// <param name="fullyPlayed">
        /// Whether or not the episode has been fully played by the user.
        /// </param>
        /// <param name="resumePositionMs">
        /// The user's most recent position in the episode in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumePointObject(
            bool? fullyPlayed,
            int? resumePositionMs)
        {
            this.FullyPlayed = fullyPlayed;
            this.ResumePositionMs = resumePositionMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePointObject" /> class.
        /// </summary>
        public ResumePointObject()
        {
        }

    }
}