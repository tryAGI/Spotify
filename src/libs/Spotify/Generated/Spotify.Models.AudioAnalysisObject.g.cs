
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioAnalysisObject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Spotify.AudioAnalysisObjectMeta? Meta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        public global::Spotify.AudioAnalysisObjectTrack? Track { get; set; }

        /// <summary>
        /// The time intervals of the bars throughout the track. A bar (or measure) is a segment of time defined as a given number of beats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bars")]
        public global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? Bars { get; set; }

        /// <summary>
        /// The time intervals of beats throughout the track. A beat is the basic time unit of a piece of music; for example, each tick of a metronome. Beats are typically multiples of tatums.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beats")]
        public global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? Beats { get; set; }

        /// <summary>
        /// Sections are defined by large variations in rhythm or timbre, e.g. chorus, verse, bridge, guitar solo, etc. Each section contains its own descriptions of tempo, key, mode, time_signature, and loudness.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        public global::System.Collections.Generic.IList<global::Spotify.SectionObject>? Sections { get; set; }

        /// <summary>
        /// Each segment contains a roughly conisistent sound throughout its duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Spotify.SegmentObject>? Segments { get; set; }

        /// <summary>
        /// A tatum represents the lowest regular pulse train that a listener intuitively infers from the timing of perceived musical events (segments).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tatums")]
        public global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? Tatums { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisObject" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="track"></param>
        /// <param name="bars">
        /// The time intervals of the bars throughout the track. A bar (or measure) is a segment of time defined as a given number of beats.
        /// </param>
        /// <param name="beats">
        /// The time intervals of beats throughout the track. A beat is the basic time unit of a piece of music; for example, each tick of a metronome. Beats are typically multiples of tatums.
        /// </param>
        /// <param name="sections">
        /// Sections are defined by large variations in rhythm or timbre, e.g. chorus, verse, bridge, guitar solo, etc. Each section contains its own descriptions of tempo, key, mode, time_signature, and loudness.
        /// </param>
        /// <param name="segments">
        /// Each segment contains a roughly conisistent sound throughout its duration.
        /// </param>
        /// <param name="tatums">
        /// A tatum represents the lowest regular pulse train that a listener intuitively infers from the timing of perceived musical events (segments).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAnalysisObject(
            global::Spotify.AudioAnalysisObjectMeta? meta,
            global::Spotify.AudioAnalysisObjectTrack? track,
            global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? bars,
            global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? beats,
            global::System.Collections.Generic.IList<global::Spotify.SectionObject>? sections,
            global::System.Collections.Generic.IList<global::Spotify.SegmentObject>? segments,
            global::System.Collections.Generic.IList<global::Spotify.TimeIntervalObject>? tatums)
        {
            this.Meta = meta;
            this.Track = track;
            this.Bars = bars;
            this.Beats = beats;
            this.Sections = sections;
            this.Segments = segments;
            this.Tatums = tatums;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisObject" /> class.
        /// </summary>
        public AudioAnalysisObject()
        {
        }

    }
}