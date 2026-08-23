
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterObjectVariant2
    {
        /// <summary>
        /// The audiobook for which the chapter belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audiobook")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.SimplifiedAudiobookObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.SimplifiedAudiobookObject Audiobook { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterObjectVariant2" /> class.
        /// </summary>
        /// <param name="audiobook">
        /// The audiobook for which the chapter belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterObjectVariant2(
            global::Spotify.SimplifiedAudiobookObject audiobook)
        {
            this.Audiobook = audiobook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterObjectVariant2" /> class.
        /// </summary>
        public ChapterObjectVariant2()
        {
        }

    }
}