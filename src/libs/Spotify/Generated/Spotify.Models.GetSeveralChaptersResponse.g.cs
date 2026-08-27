
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSeveralChaptersResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.ChapterObject> Chapters { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSeveralChaptersResponse" /> class.
        /// </summary>
        /// <param name="chapters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSeveralChaptersResponse(
            global::System.Collections.Generic.IList<global::Spotify.ChapterObject> chapters)
        {
            this.Chapters = chapters ?? throw new global::System.ArgumentNullException(nameof(chapters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSeveralChaptersResponse" /> class.
        /// </summary>
        public GetSeveralChaptersResponse()
        {
        }

    }
}