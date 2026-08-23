
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueObjectCurrentlyPlayingDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.QueueObjectCurrentlyPlayingDiscriminatorTypeJsonConverter))]
        public global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueObjectCurrentlyPlayingDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueObjectCurrentlyPlayingDiscriminator(
            global::Spotify.QueueObjectCurrentlyPlayingDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueObjectCurrentlyPlayingDiscriminator" /> class.
        /// </summary>
        public QueueObjectCurrentlyPlayingDiscriminator()
        {
        }

    }
}