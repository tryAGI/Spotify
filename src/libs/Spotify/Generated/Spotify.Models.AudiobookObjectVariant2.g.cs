
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudiobookObjectVariant2
    {
        /// <summary>
        /// The chapters of the audiobook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PagingSimplifiedChapterObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.PagingSimplifiedChapterObject Chapters { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiobookObjectVariant2" /> class.
        /// </summary>
        /// <param name="chapters">
        /// The chapters of the audiobook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiobookObjectVariant2(
            global::Spotify.PagingSimplifiedChapterObject chapters)
        {
            this.Chapters = chapters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiobookObjectVariant2" /> class.
        /// </summary>
        public AudiobookObjectVariant2()
        {
        }

    }
}