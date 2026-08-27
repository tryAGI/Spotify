
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSeveralAudioFeaturesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.AudioFeaturesObject> AudioFeatures { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSeveralAudioFeaturesResponse" /> class.
        /// </summary>
        /// <param name="audioFeatures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSeveralAudioFeaturesResponse(
            global::System.Collections.Generic.IList<global::Spotify.AudioFeaturesObject> audioFeatures)
        {
            this.AudioFeatures = audioFeatures ?? throw new global::System.ArgumentNullException(nameof(audioFeatures));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSeveralAudioFeaturesResponse" /> class.
        /// </summary>
        public GetSeveralAudioFeaturesResponse()
        {
        }

    }
}