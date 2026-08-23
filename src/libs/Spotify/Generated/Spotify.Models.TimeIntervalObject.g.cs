
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeIntervalObject
    {
        /// <summary>
        /// The starting point (in seconds) of the time interval.<br/>
        /// Example: 0.49567
        /// </summary>
        /// <example>0.49567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The duration (in seconds) of the time interval.<br/>
        /// Example: 2.18749
        /// </summary>
        /// <example>2.18749</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The confidence, from 0.0 to 1.0, of the reliability of the interval.<br/>
        /// Example: 0.925
        /// </summary>
        /// <example>0.925</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeIntervalObject" /> class.
        /// </summary>
        /// <param name="start">
        /// The starting point (in seconds) of the time interval.<br/>
        /// Example: 0.49567
        /// </param>
        /// <param name="duration">
        /// The duration (in seconds) of the time interval.<br/>
        /// Example: 2.18749
        /// </param>
        /// <param name="confidence">
        /// The confidence, from 0.0 to 1.0, of the reliability of the interval.<br/>
        /// Example: 0.925
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeIntervalObject(
            double? start,
            double? duration,
            double? confidence)
        {
            this.Start = start;
            this.Duration = duration;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeIntervalObject" /> class.
        /// </summary>
        public TimeIntervalObject()
        {
        }

    }
}