
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMultipleAudiobooksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audiobooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.AudiobookObject> Audiobooks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleAudiobooksResponse" /> class.
        /// </summary>
        /// <param name="audiobooks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMultipleAudiobooksResponse(
            global::System.Collections.Generic.IList<global::Spotify.AudiobookObject> audiobooks)
        {
            this.Audiobooks = audiobooks ?? throw new global::System.ArgumentNullException(nameof(audiobooks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleAudiobooksResponse" /> class.
        /// </summary>
        public GetMultipleAudiobooksResponse()
        {
        }

    }
}