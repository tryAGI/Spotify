
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SegmentObject
    {
        /// <summary>
        /// The starting point (in seconds) of the segment.<br/>
        /// Example: 0.70154
        /// </summary>
        /// <example>0.70154</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The duration (in seconds) of the segment.<br/>
        /// Example: 0.19891
        /// </summary>
        /// <example>0.19891</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the segmentation. Segments of the song which are difficult to logically segment (e.g: noise) may correspond to low values in this field.<br/>
        /// Example: 0.435
        /// </summary>
        /// <example>0.435</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The onset loudness of the segment in decibels (dB). Combined with `loudness_max` and `loudness_max_time`, these components can be used to describe the "attack" of the segment.<br/>
        /// Example: -23.053
        /// </summary>
        /// <example>-23.053</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_start")]
        public double? LoudnessStart { get; set; }

        /// <summary>
        /// The peak loudness of the segment in decibels (dB). Combined with `loudness_start` and `loudness_max_time`, these components can be used to describe the "attack" of the segment.<br/>
        /// Example: -14.25
        /// </summary>
        /// <example>-14.25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_max")]
        public double? LoudnessMax { get; set; }

        /// <summary>
        /// The segment-relative offset of the segment peak loudness in seconds. Combined with `loudness_start` and `loudness_max`, these components can be used to desctibe the "attack" of the segment.<br/>
        /// Example: 0.07305
        /// </summary>
        /// <example>0.07305</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_max_time")]
        public double? LoudnessMaxTime { get; set; }

        /// <summary>
        /// The offset loudness of the segment in decibels (dB). This value should be equivalent to the loudness_start of the following segment.<br/>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_end")]
        public double? LoudnessEnd { get; set; }

        /// <summary>
        /// Pitch content is given by a “chroma” vector, corresponding to the 12 pitch classes C, C#, D to B, with values ranging from 0 to 1 that describe the relative dominance of every pitch in the chromatic scale. For example a C Major chord would likely be represented by large values of C, E and G (i.e. classes 0, 4, and 7).<br/>
        /// Vectors are normalized to 1 by their strongest dimension, therefore noisy sounds are likely represented by values that are all close to 1, while pure tones are described by one value at 1 (the pitch) and others near 0.<br/>
        /// As can be seen below, the 12 vector indices are a combination of low-power spectrum values at their respective pitch frequencies.<br/>
        /// ![pitch vector](/assets/audio/Pitch_vector.png)<br/>
        /// Example: [0.212, 0.141, 0.294]
        /// </summary>
        /// <example>[0.212, 0.141, 0.294]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitches")]
        public global::System.Collections.Generic.IList<double>? Pitches { get; set; }

        /// <summary>
        /// Timbre is the quality of a musical note or sound that distinguishes different types of musical instruments, or voices. It is a complex notion also referred to as sound color, texture, or tone quality, and is derived from the shape of a segment’s spectro-temporal surface, independently of pitch and loudness. The timbre feature is a vector that includes 12 unbounded values roughly centered around 0. Those values are high level abstractions of the spectral surface, ordered by degree of importance.<br/>
        /// For completeness however, the first dimension represents the average loudness of the segment; second emphasizes brightness; third is more closely correlated to the flatness of a sound; fourth to sounds with a stronger attack; etc. See an image below representing the 12 basis functions (i.e. template segments).<br/>
        /// ![timbre basis functions](/assets/audio/Timbre_basis_functions.png)<br/>
        /// The actual timbre of the segment is best described as a linear combination of these 12 basis functions weighted by the coefficient values: timbre = c1 x b1 + c2 x b2 + ... + c12 x b12, where c1 to c12 represent the 12 coefficients and b1 to b12 the 12 basis functions as displayed below. Timbre vectors are best used in comparison with each other.<br/>
        /// Example: [42.115, 64.373, -0.233]
        /// </summary>
        /// <example>[42.115, 64.373, -0.233]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timbre")]
        public global::System.Collections.Generic.IList<double>? Timbre { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentObject" /> class.
        /// </summary>
        /// <param name="start">
        /// The starting point (in seconds) of the segment.<br/>
        /// Example: 0.70154
        /// </param>
        /// <param name="duration">
        /// The duration (in seconds) of the segment.<br/>
        /// Example: 0.19891
        /// </param>
        /// <param name="confidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the segmentation. Segments of the song which are difficult to logically segment (e.g: noise) may correspond to low values in this field.<br/>
        /// Example: 0.435
        /// </param>
        /// <param name="loudnessStart">
        /// The onset loudness of the segment in decibels (dB). Combined with `loudness_max` and `loudness_max_time`, these components can be used to describe the "attack" of the segment.<br/>
        /// Example: -23.053
        /// </param>
        /// <param name="loudnessMax">
        /// The peak loudness of the segment in decibels (dB). Combined with `loudness_start` and `loudness_max_time`, these components can be used to describe the "attack" of the segment.<br/>
        /// Example: -14.25
        /// </param>
        /// <param name="loudnessMaxTime">
        /// The segment-relative offset of the segment peak loudness in seconds. Combined with `loudness_start` and `loudness_max`, these components can be used to desctibe the "attack" of the segment.<br/>
        /// Example: 0.07305
        /// </param>
        /// <param name="loudnessEnd">
        /// The offset loudness of the segment in decibels (dB). This value should be equivalent to the loudness_start of the following segment.<br/>
        /// Example: 0.0
        /// </param>
        /// <param name="pitches">
        /// Pitch content is given by a “chroma” vector, corresponding to the 12 pitch classes C, C#, D to B, with values ranging from 0 to 1 that describe the relative dominance of every pitch in the chromatic scale. For example a C Major chord would likely be represented by large values of C, E and G (i.e. classes 0, 4, and 7).<br/>
        /// Vectors are normalized to 1 by their strongest dimension, therefore noisy sounds are likely represented by values that are all close to 1, while pure tones are described by one value at 1 (the pitch) and others near 0.<br/>
        /// As can be seen below, the 12 vector indices are a combination of low-power spectrum values at their respective pitch frequencies.<br/>
        /// ![pitch vector](/assets/audio/Pitch_vector.png)<br/>
        /// Example: [0.212, 0.141, 0.294]
        /// </param>
        /// <param name="timbre">
        /// Timbre is the quality of a musical note or sound that distinguishes different types of musical instruments, or voices. It is a complex notion also referred to as sound color, texture, or tone quality, and is derived from the shape of a segment’s spectro-temporal surface, independently of pitch and loudness. The timbre feature is a vector that includes 12 unbounded values roughly centered around 0. Those values are high level abstractions of the spectral surface, ordered by degree of importance.<br/>
        /// For completeness however, the first dimension represents the average loudness of the segment; second emphasizes brightness; third is more closely correlated to the flatness of a sound; fourth to sounds with a stronger attack; etc. See an image below representing the 12 basis functions (i.e. template segments).<br/>
        /// ![timbre basis functions](/assets/audio/Timbre_basis_functions.png)<br/>
        /// The actual timbre of the segment is best described as a linear combination of these 12 basis functions weighted by the coefficient values: timbre = c1 x b1 + c2 x b2 + ... + c12 x b12, where c1 to c12 represent the 12 coefficients and b1 to b12 the 12 basis functions as displayed below. Timbre vectors are best used in comparison with each other.<br/>
        /// Example: [42.115, 64.373, -0.233]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentObject(
            double? start,
            double? duration,
            double? confidence,
            double? loudnessStart,
            double? loudnessMax,
            double? loudnessMaxTime,
            double? loudnessEnd,
            global::System.Collections.Generic.IList<double>? pitches,
            global::System.Collections.Generic.IList<double>? timbre)
        {
            this.Start = start;
            this.Duration = duration;
            this.Confidence = confidence;
            this.LoudnessStart = loudnessStart;
            this.LoudnessMax = loudnessMax;
            this.LoudnessMaxTime = loudnessMaxTime;
            this.LoudnessEnd = loudnessEnd;
            this.Pitches = pitches;
            this.Timbre = timbre;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentObject" /> class.
        /// </summary>
        public SegmentObject()
        {
        }

    }
}