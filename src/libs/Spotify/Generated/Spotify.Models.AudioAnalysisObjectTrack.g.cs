
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioAnalysisObjectTrack
    {
        /// <summary>
        /// The exact number of audio samples analyzed from this track. See also `analysis_sample_rate`.<br/>
        /// Example: 4585515
        /// </summary>
        /// <example>4585515</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples")]
        public int? NumSamples { get; set; }

        /// <summary>
        /// Length of the track in seconds.<br/>
        /// Example: 207.95985
        /// </summary>
        /// <example>207.95985</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// This field will always contain the empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_md5")]
        public string? SampleMd5 { get; set; }

        /// <summary>
        /// An offset to the start of the region of the track that was analyzed. (As the entire track is analyzed, this should always be 0.)<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_seconds")]
        public int? OffsetSeconds { get; set; }

        /// <summary>
        /// The length of the region of the track was analyzed, if a subset of the track was analyzed. (As the entire track is analyzed, this should always be 0.)<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_seconds")]
        public int? WindowSeconds { get; set; }

        /// <summary>
        /// The sample rate used to decode and analyze this track. May differ from the actual sample rate of this track available on Spotify.<br/>
        /// Example: 22050
        /// </summary>
        /// <example>22050</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_sample_rate")]
        public int? AnalysisSampleRate { get; set; }

        /// <summary>
        /// The number of channels used for analysis. If 1, all channels are summed together to mono before analysis.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_channels")]
        public int? AnalysisChannels { get; set; }

        /// <summary>
        /// The time, in seconds, at which the track's fade-in period ends. If the track has no fade-in, this will be 0.0.<br/>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_fade_in")]
        public double? EndOfFadeIn { get; set; }

        /// <summary>
        /// The time, in seconds, at which the track's fade-out period starts. If the track has no fade-out, this should match the track's length.<br/>
        /// Example: 201.13705
        /// </summary>
        /// <example>201.13705</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_of_fade_out")]
        public double? StartOfFadeOut { get; set; }

        /// <summary>
        /// The overall loudness of a track in decibels (dB). Loudness values are averaged across the entire track and are useful for comparing relative loudness of tracks. Loudness is the quality of a sound that is the primary psychological correlate of physical strength (amplitude). Values typically range between -60 and 0 db.<br/>
        /// Example: -5.883
        /// </summary>
        /// <example>-5.883</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness")]
        public float? Loudness { get; set; }

        /// <summary>
        /// The overall estimated tempo of a track in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.<br/>
        /// Example: 118.211
        /// </summary>
        /// <example>118.211</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempo")]
        public float? Tempo { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the `tempo`.<br/>
        /// Example: 0.73
        /// </summary>
        /// <example>0.73</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempo_confidence")]
        public double? TempoConfidence { get; set; }

        /// <summary>
        /// An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of "3/4", to "7/4".<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_signature")]
        public int? TimeSignature { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`.<br/>
        /// Example: 0.994
        /// </summary>
        /// <example>0.994</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_signature_confidence")]
        public double? TimeSignatureConfidence { get; set; }

        /// <summary>
        /// The key the track is in. Integers map to pitches using standard [Pitch Class notation](https://en.wikipedia.org/wiki/Pitch_class). E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on. If no key was detected, the value is -1.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public int? Key { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the `key`.<br/>
        /// Example: 0.408
        /// </summary>
        /// <example>0.408</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_confidence")]
        public double? KeyConfidence { get; set; }

        /// <summary>
        /// Mode indicates the modality (major or minor) of a track, the type of scale from which its melodic content is derived. Major is represented by 1 and minor is 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the `mode`.<br/>
        /// Example: 0.485
        /// </summary>
        /// <example>0.485</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode_confidence")]
        public double? ModeConfidence { get; set; }

        /// <summary>
        /// An [Echo Nest Musical Fingerprint (ENMFP)](https://academiccommons.columbia.edu/doi/10.7916/D8Q248M4) codestring for this track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codestring")]
        public string? Codestring { get; set; }

        /// <summary>
        /// A version number for the Echo Nest Musical Fingerprint format used in the codestring field.<br/>
        /// Example: 3.15
        /// </summary>
        /// <example>3.15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_version")]
        public double? CodeVersion { get; set; }

        /// <summary>
        /// An [EchoPrint](https://github.com/spotify/echoprint-codegen) codestring for this track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echoprintstring")]
        public string? Echoprintstring { get; set; }

        /// <summary>
        /// A version number for the EchoPrint format used in the echoprintstring field.<br/>
        /// Example: 4.15
        /// </summary>
        /// <example>4.15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("echoprint_version")]
        public double? EchoprintVersion { get; set; }

        /// <summary>
        /// A [Synchstring](https://github.com/echonest/synchdata) for this track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synchstring")]
        public string? Synchstring { get; set; }

        /// <summary>
        /// A version number for the Synchstring used in the synchstring field.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("synch_version")]
        public double? SynchVersion { get; set; }

        /// <summary>
        /// A Rhythmstring for this track. The format of this string is similar to the Synchstring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhythmstring")]
        public string? Rhythmstring { get; set; }

        /// <summary>
        /// A version number for the Rhythmstring used in the rhythmstring field.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhythm_version")]
        public double? RhythmVersion { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisObjectTrack" /> class.
        /// </summary>
        /// <param name="numSamples">
        /// The exact number of audio samples analyzed from this track. See also `analysis_sample_rate`.<br/>
        /// Example: 4585515
        /// </param>
        /// <param name="duration">
        /// Length of the track in seconds.<br/>
        /// Example: 207.95985
        /// </param>
        /// <param name="sampleMd5">
        /// This field will always contain the empty string.
        /// </param>
        /// <param name="offsetSeconds">
        /// An offset to the start of the region of the track that was analyzed. (As the entire track is analyzed, this should always be 0.)<br/>
        /// Example: 0
        /// </param>
        /// <param name="windowSeconds">
        /// The length of the region of the track was analyzed, if a subset of the track was analyzed. (As the entire track is analyzed, this should always be 0.)<br/>
        /// Example: 0
        /// </param>
        /// <param name="analysisSampleRate">
        /// The sample rate used to decode and analyze this track. May differ from the actual sample rate of this track available on Spotify.<br/>
        /// Example: 22050
        /// </param>
        /// <param name="analysisChannels">
        /// The number of channels used for analysis. If 1, all channels are summed together to mono before analysis.<br/>
        /// Example: 1
        /// </param>
        /// <param name="endOfFadeIn">
        /// The time, in seconds, at which the track's fade-in period ends. If the track has no fade-in, this will be 0.0.<br/>
        /// Example: 0.0
        /// </param>
        /// <param name="startOfFadeOut">
        /// The time, in seconds, at which the track's fade-out period starts. If the track has no fade-out, this should match the track's length.<br/>
        /// Example: 201.13705
        /// </param>
        /// <param name="loudness">
        /// The overall loudness of a track in decibels (dB). Loudness values are averaged across the entire track and are useful for comparing relative loudness of tracks. Loudness is the quality of a sound that is the primary psychological correlate of physical strength (amplitude). Values typically range between -60 and 0 db.<br/>
        /// Example: -5.883
        /// </param>
        /// <param name="tempo">
        /// The overall estimated tempo of a track in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.<br/>
        /// Example: 118.211
        /// </param>
        /// <param name="tempoConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the `tempo`.<br/>
        /// Example: 0.73
        /// </param>
        /// <param name="timeSignature">
        /// An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of "3/4", to "7/4".<br/>
        /// Example: 4
        /// </param>
        /// <param name="timeSignatureConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`.<br/>
        /// Example: 0.994
        /// </param>
        /// <param name="key">
        /// The key the track is in. Integers map to pitches using standard [Pitch Class notation](https://en.wikipedia.org/wiki/Pitch_class). E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on. If no key was detected, the value is -1.<br/>
        /// Example: 9
        /// </param>
        /// <param name="keyConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the `key`.<br/>
        /// Example: 0.408
        /// </param>
        /// <param name="mode">
        /// Mode indicates the modality (major or minor) of a track, the type of scale from which its melodic content is derived. Major is represented by 1 and minor is 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="modeConfidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the `mode`.<br/>
        /// Example: 0.485
        /// </param>
        /// <param name="codestring">
        /// An [Echo Nest Musical Fingerprint (ENMFP)](https://academiccommons.columbia.edu/doi/10.7916/D8Q248M4) codestring for this track.
        /// </param>
        /// <param name="codeVersion">
        /// A version number for the Echo Nest Musical Fingerprint format used in the codestring field.<br/>
        /// Example: 3.15
        /// </param>
        /// <param name="echoprintstring">
        /// An [EchoPrint](https://github.com/spotify/echoprint-codegen) codestring for this track.
        /// </param>
        /// <param name="echoprintVersion">
        /// A version number for the EchoPrint format used in the echoprintstring field.<br/>
        /// Example: 4.15
        /// </param>
        /// <param name="synchstring">
        /// A [Synchstring](https://github.com/echonest/synchdata) for this track.
        /// </param>
        /// <param name="synchVersion">
        /// A version number for the Synchstring used in the synchstring field.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="rhythmstring">
        /// A Rhythmstring for this track. The format of this string is similar to the Synchstring.
        /// </param>
        /// <param name="rhythmVersion">
        /// A version number for the Rhythmstring used in the rhythmstring field.<br/>
        /// Example: 1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAnalysisObjectTrack(
            int? numSamples,
            double? duration,
            string? sampleMd5,
            int? offsetSeconds,
            int? windowSeconds,
            int? analysisSampleRate,
            int? analysisChannels,
            double? endOfFadeIn,
            double? startOfFadeOut,
            float? loudness,
            float? tempo,
            double? tempoConfidence,
            int? timeSignature,
            double? timeSignatureConfidence,
            int? key,
            double? keyConfidence,
            int? mode,
            double? modeConfidence,
            string? codestring,
            double? codeVersion,
            string? echoprintstring,
            double? echoprintVersion,
            string? synchstring,
            double? synchVersion,
            string? rhythmstring,
            double? rhythmVersion)
        {
            this.NumSamples = numSamples;
            this.Duration = duration;
            this.SampleMd5 = sampleMd5;
            this.OffsetSeconds = offsetSeconds;
            this.WindowSeconds = windowSeconds;
            this.AnalysisSampleRate = analysisSampleRate;
            this.AnalysisChannels = analysisChannels;
            this.EndOfFadeIn = endOfFadeIn;
            this.StartOfFadeOut = startOfFadeOut;
            this.Loudness = loudness;
            this.Tempo = tempo;
            this.TempoConfidence = tempoConfidence;
            this.TimeSignature = timeSignature;
            this.TimeSignatureConfidence = timeSignatureConfidence;
            this.Key = key;
            this.KeyConfidence = keyConfidence;
            this.Mode = mode;
            this.ModeConfidence = modeConfidence;
            this.Codestring = codestring;
            this.CodeVersion = codeVersion;
            this.Echoprintstring = echoprintstring;
            this.EchoprintVersion = echoprintVersion;
            this.Synchstring = synchstring;
            this.SynchVersion = synchVersion;
            this.Rhythmstring = rhythmstring;
            this.RhythmVersion = rhythmVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisObjectTrack" /> class.
        /// </summary>
        public AudioAnalysisObjectTrack()
        {
        }

    }
}