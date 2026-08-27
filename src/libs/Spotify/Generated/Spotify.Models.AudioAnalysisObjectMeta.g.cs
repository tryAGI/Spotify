
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioAnalysisObjectMeta
    {
        /// <summary>
        /// The version of the Analyzer used to analyze this track.<br/>
        /// Example: 4.0.0
        /// </summary>
        /// <example>4.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzer_version")]
        public string? AnalyzerVersion { get; set; }

        /// <summary>
        /// The platform used to read the track's audio data.<br/>
        /// Example: Linux
        /// </summary>
        /// <example>Linux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// A detailed status code for this track. If analysis data is missing, this code may explain why.<br/>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed_status")]
        public string? DetailedStatus { get; set; }

        /// <summary>
        /// The return code of the analyzer process. 0 if successful, 1 if any errors occurred.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) at which this track was analyzed.<br/>
        /// Example: 1495193577
        /// </summary>
        /// <example>1495193577</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// The amount of time taken to analyze this track.<br/>
        /// Example: 6.93906
        /// </summary>
        /// <example>6.93906</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_time")]
        public double? AnalysisTime { get; set; }

        /// <summary>
        /// The method used to read the track's audio data.<br/>
        /// Example: libvorbisfile L+R 44100-&gt;22050
        /// </summary>
        /// <example>libvorbisfile L+R 44100-&gt;22050</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_process")]
        public string? InputProcess { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisObjectMeta" /> class.
        /// </summary>
        /// <param name="analyzerVersion">
        /// The version of the Analyzer used to analyze this track.<br/>
        /// Example: 4.0.0
        /// </param>
        /// <param name="platform">
        /// The platform used to read the track's audio data.<br/>
        /// Example: Linux
        /// </param>
        /// <param name="detailedStatus">
        /// A detailed status code for this track. If analysis data is missing, this code may explain why.<br/>
        /// Example: OK
        /// </param>
        /// <param name="statusCode">
        /// The return code of the analyzer process. 0 if successful, 1 if any errors occurred.<br/>
        /// Example: 0
        /// </param>
        /// <param name="timestamp">
        /// The Unix timestamp (in seconds) at which this track was analyzed.<br/>
        /// Example: 1495193577
        /// </param>
        /// <param name="analysisTime">
        /// The amount of time taken to analyze this track.<br/>
        /// Example: 6.93906
        /// </param>
        /// <param name="inputProcess">
        /// The method used to read the track's audio data.<br/>
        /// Example: libvorbisfile L+R 44100-&gt;22050
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAnalysisObjectMeta(
            string? analyzerVersion,
            string? platform,
            string? detailedStatus,
            int? statusCode,
            global::System.DateTimeOffset? timestamp,
            double? analysisTime,
            string? inputProcess)
        {
            this.AnalyzerVersion = analyzerVersion;
            this.Platform = platform;
            this.DetailedStatus = detailedStatus;
            this.StatusCode = statusCode;
            this.Timestamp = timestamp;
            this.AnalysisTime = analysisTime;
            this.InputProcess = inputProcess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisObjectMeta" /> class.
        /// </summary>
        public AudioAnalysisObjectMeta()
        {
        }

    }
}