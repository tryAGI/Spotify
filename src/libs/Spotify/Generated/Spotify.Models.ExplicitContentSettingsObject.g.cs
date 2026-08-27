
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExplicitContentSettingsObject
    {
        /// <summary>
        /// When `true`, indicates that explicit content should not be played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_enabled")]
        public bool? FilterEnabled { get; set; }

        /// <summary>
        /// When `true`, indicates that the explicit content setting is locked and can't be changed by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_locked")]
        public bool? FilterLocked { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplicitContentSettingsObject" /> class.
        /// </summary>
        /// <param name="filterEnabled">
        /// When `true`, indicates that explicit content should not be played.
        /// </param>
        /// <param name="filterLocked">
        /// When `true`, indicates that the explicit content setting is locked and can't be changed by the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplicitContentSettingsObject(
            bool? filterEnabled,
            bool? filterLocked)
        {
            this.FilterEnabled = filterEnabled;
            this.FilterLocked = filterLocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplicitContentSettingsObject" /> class.
        /// </summary>
        public ExplicitContentSettingsObject()
        {
        }

    }
}