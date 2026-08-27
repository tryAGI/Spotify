
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SectionObject
    {
        /// <summary>
        /// The starting point (in seconds) of the section.<br/>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The duration (in seconds) of the section.<br/>
        /// Example: 6.97092
        /// </summary>
        /// <example>6.97092</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the section's "designation".<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The overall loudness of the section in decibels (dB). Loudness values are useful for comparing relative loudness of sections within tracks.<br/>
        /// Example: -14.938
        /// </summary>
        /// <example>-14.938</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness")]
        public double? Loudness { get; set; }

        /// <summary>
        /// The overall estimated tempo of the section in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.<br/>
        /// Example: 113.178
        /// </summary>
        /// <example>113.178</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempo")]
        public double? Tempo { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the tempo. Some tracks contain tempo changes or sounds which don't contain tempo (like pure speech) which would correspond to a low value in this field.<br/>
        /// Example: 0.647
        /// </summary>
        /// <example>0.647</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempo_confidence")]
        public double? TempoConfidence { get; set; }

        /// <summary>
        /// The estimated overall key of the section. The values in this field ranging from 0 to 11 mapping to pitches using standard Pitch Class notation (E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on). If no key was detected, the value is -1.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public int? Key { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the key. Songs with many key changes may correspond to low values in this field.<br/>
        /// Example: 0.297
        /// </summary>
        /// <example>0.297</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_confidence")]
        public double? KeyConfidence { get; set; }

        /// <summary>
        /// Indicates the modality (major or minor) of a section, the type of scale from which its melodic content is derived. This field will contain a 0 for "minor", a 1 for "major", or a -1 for no result. Note that the major key (e.g. C major) could more likely be confused with the minor key at 3 semitones lower (e.g. A minor) as both keys carry the same pitches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public double? Mode { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the `mode`.<br/>
        /// Example: 0.471
        /// </summary>
        /// <example>0.471</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode_confidence")]
        public double? ModeConfidence { get; set; }

        /// <summary>
        /// An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of "3/4", to "7/4".<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_signature")]
        public int? TimeSignature { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`. Sections with time signature changes may correspond to low values in this field.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_signature_confidence")]
        public double? TimeSignatureConfidence { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionObject" /> class.
        /// </summary>
        /// <param name="start">
        /// The starting point (in seconds) of the section.<br/>
        /// Example: 0.0
        /// </param>
        /// <param name="duration">
        /// The duration (in seconds) of the section.<br/>
        /// Example: 6.97092
        /// </param>
        /// <param name="confidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the section's "designation".<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="loudness">
        /// The overall loudness of the section in decibels (dB). Loudness values are useful for comparing relative loudness of sections within tracks.<br/>
        /// Example: -14.938
        /// </param>
        /// <param name="tempo">
        /// The overall estimated tempo of the section in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.<br/>
        /// Example: 113.178
        /// </param>
        /// <param name="tempoConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the tempo. Some tracks contain tempo changes or sounds which don't contain tempo (like pure speech) which would correspond to a low value in this field.<br/>
        /// Example: 0.647
        /// </param>
        /// <param name="key">
        /// The estimated overall key of the section. The values in this field ranging from 0 to 11 mapping to pitches using standard Pitch Class notation (E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on). If no key was detected, the value is -1.<br/>
        /// Example: 9
        /// </param>
        /// <param name="keyConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the key. Songs with many key changes may correspond to low values in this field.<br/>
        /// Example: 0.297
        /// </param>
        /// <param name="mode">
        /// Indicates the modality (major or minor) of a section, the type of scale from which its melodic content is derived. This field will contain a 0 for "minor", a 1 for "major", or a -1 for no result. Note that the major key (e.g. C major) could more likely be confused with the minor key at 3 semitones lower (e.g. A minor) as both keys carry the same pitches.
        /// </param>
        /// <param name="modeConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the `mode`.<br/>
        /// Example: 0.471
        /// </param>
        /// <param name="timeSignature">
        /// An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of "3/4", to "7/4".<br/>
        /// Example: 4
        /// </param>
        /// <param name="timeSignatureConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`. Sections with time signature changes may correspond to low values in this field.<br/>
        /// Example: 1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SectionObject(
            double? start,
            double? duration,
            double? confidence,
            double? loudness,
            double? tempo,
            double? tempoConfidence,
            int? key,
            double? keyConfidence,
            double? mode,
            double? modeConfidence,
            int? timeSignature,
            double? timeSignatureConfidence)
        {
            this.Start = start;
            this.Duration = duration;
            this.Confidence = confidence;
            this.Loudness = loudness;
            this.Tempo = tempo;
            this.TempoConfidence = tempoConfidence;
            this.Key = key;
            this.KeyConfidence = keyConfidence;
            this.Mode = mode;
            this.ModeConfidence = modeConfidence;
            this.TimeSignature = timeSignature;
            this.TimeSignatureConfidence = timeSignatureConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionObject" /> class.
        /// </summary>
        public SectionObject()
        {
        }

    }
}