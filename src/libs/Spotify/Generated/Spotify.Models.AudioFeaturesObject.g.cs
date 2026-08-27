
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioFeaturesObject
    {
        /// <summary>
        /// A confidence measure from 0.0 to 1.0 of whether the track is acoustic. 1.0 represents high confidence the track is acoustic.<br/>
        /// Example: 0.00242
        /// </summary>
        /// <example>0.00242</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acousticness")]
        public float? Acousticness { get; set; }

        /// <summary>
        /// A URL to access the full audio analysis of this track. An access token is required to access this data.<br/>
        /// Example: https://api.spotify.com/v1/audio-analysis/2takcwOaAZWiXQijPHIx7B
        /// </summary>
        /// <example>https://api.spotify.com/v1/audio-analysis/2takcwOaAZWiXQijPHIx7B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_url")]
        public string? AnalysisUrl { get; set; }

        /// <summary>
        /// Danceability describes how suitable a track is for dancing based on a combination of musical elements including tempo, rhythm stability, beat strength, and overall regularity. A value of 0.0 is least danceable and 1.0 is most danceable.<br/>
        /// Example: 0.585
        /// </summary>
        /// <example>0.585</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("danceability")]
        public float? Danceability { get; set; }

        /// <summary>
        /// The duration of the track in milliseconds.<br/>
        /// Example: 237040
        /// </summary>
        /// <example>237040</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Energy is a measure from 0.0 to 1.0 and represents a perceptual measure of intensity and activity. Typically, energetic tracks feel fast, loud, and noisy. For example, death metal has high energy, while a Bach prelude scores low on the scale. Perceptual features contributing to this attribute include dynamic range, perceived loudness, timbre, onset rate, and general entropy.<br/>
        /// Example: 0.842
        /// </summary>
        /// <example>0.842</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("energy")]
        public float? Energy { get; set; }

        /// <summary>
        /// The Spotify ID for the track.<br/>
        /// Example: 2takcwOaAZWiXQijPHIx7B
        /// </summary>
        /// <example>2takcwOaAZWiXQijPHIx7B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Predicts whether a track contains no vocals. "Ooh" and "aah" sounds are treated as instrumental in this context. Rap or spoken word tracks are clearly "vocal". The closer the instrumentalness value is to 1.0, the greater likelihood the track contains no vocal content. Values above 0.5 are intended to represent instrumental tracks, but confidence is higher as the value approaches 1.0.<br/>
        /// Example: 0.00686
        /// </summary>
        /// <example>0.00686</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumentalness")]
        public float? Instrumentalness { get; set; }

        /// <summary>
        /// The key the track is in. Integers map to pitches using standard [Pitch Class notation](https://en.wikipedia.org/wiki/Pitch_class). E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on. If no key was detected, the value is -1.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public int? Key { get; set; }

        /// <summary>
        /// Detects the presence of an audience in the recording. Higher liveness values represent an increased probability that the track was performed live. A value above 0.8 provides strong likelihood that the track is live.<br/>
        /// Example: 0.0866
        /// </summary>
        /// <example>0.0866</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("liveness")]
        public float? Liveness { get; set; }

        /// <summary>
        /// The overall loudness of a track in decibels (dB). Loudness values are averaged across the entire track and are useful for comparing relative loudness of tracks. Loudness is the quality of a sound that is the primary psychological correlate of physical strength (amplitude). Values typically range between -60 and 0 db.<br/>
        /// Example: -5.883
        /// </summary>
        /// <example>-5.883</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness")]
        public float? Loudness { get; set; }

        /// <summary>
        /// Mode indicates the modality (major or minor) of a track, the type of scale from which its melodic content is derived. Major is represented by 1 and minor is 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// Speechiness detects the presence of spoken words in a track. The more exclusively speech-like the recording (e.g. talk show, audio book, poetry), the closer to 1.0 the attribute value. Values above 0.66 describe tracks that are probably made entirely of spoken words. Values between 0.33 and 0.66 describe tracks that may contain both music and speech, either in sections or layered, including such cases as rap music. Values below 0.33 most likely represent music and other non-speech-like tracks.<br/>
        /// Example: 0.0556
        /// </summary>
        /// <example>0.0556</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speechiness")]
        public float? Speechiness { get; set; }

        /// <summary>
        /// The overall estimated tempo of a track in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.<br/>
        /// Example: 118.211
        /// </summary>
        /// <example>118.211</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempo")]
        public float? Tempo { get; set; }

        /// <summary>
        /// An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of "3/4", to "7/4".<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_signature")]
        public int? TimeSignature { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the track.<br/>
        /// Example: https://api.spotify.com/v1/tracks/2takcwOaAZWiXQijPHIx7B
        /// </summary>
        /// <example>https://api.spotify.com/v1/tracks/2takcwOaAZWiXQijPHIx7B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_href")]
        public string? TrackHref { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.AudioFeaturesObjectTypeJsonConverter))]
        public global::Spotify.AudioFeaturesObjectType? Type { get; set; }

        /// <summary>
        /// The Spotify URI for the track.<br/>
        /// Example: spotify:track:2takcwOaAZWiXQijPHIx7B
        /// </summary>
        /// <example>spotify:track:2takcwOaAZWiXQijPHIx7B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// A measure from 0.0 to 1.0 describing the musical positiveness conveyed by a track. Tracks with high valence sound more positive (e.g. happy, cheerful, euphoric), while tracks with low valence sound more negative (e.g. sad, depressed, angry).<br/>
        /// Example: 0.428
        /// </summary>
        /// <example>0.428</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valence")]
        public float? Valence { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFeaturesObject" /> class.
        /// </summary>
        /// <param name="acousticness">
        /// A confidence measure from 0.0 to 1.0 of whether the track is acoustic. 1.0 represents high confidence the track is acoustic.<br/>
        /// Example: 0.00242
        /// </param>
        /// <param name="analysisUrl">
        /// A URL to access the full audio analysis of this track. An access token is required to access this data.<br/>
        /// Example: https://api.spotify.com/v1/audio-analysis/2takcwOaAZWiXQijPHIx7B
        /// </param>
        /// <param name="danceability">
        /// Danceability describes how suitable a track is for dancing based on a combination of musical elements including tempo, rhythm stability, beat strength, and overall regularity. A value of 0.0 is least danceable and 1.0 is most danceable.<br/>
        /// Example: 0.585
        /// </param>
        /// <param name="durationMs">
        /// The duration of the track in milliseconds.<br/>
        /// Example: 237040
        /// </param>
        /// <param name="energy">
        /// Energy is a measure from 0.0 to 1.0 and represents a perceptual measure of intensity and activity. Typically, energetic tracks feel fast, loud, and noisy. For example, death metal has high energy, while a Bach prelude scores low on the scale. Perceptual features contributing to this attribute include dynamic range, perceived loudness, timbre, onset rate, and general entropy.<br/>
        /// Example: 0.842
        /// </param>
        /// <param name="id">
        /// The Spotify ID for the track.<br/>
        /// Example: 2takcwOaAZWiXQijPHIx7B
        /// </param>
        /// <param name="instrumentalness">
        /// Predicts whether a track contains no vocals. "Ooh" and "aah" sounds are treated as instrumental in this context. Rap or spoken word tracks are clearly "vocal". The closer the instrumentalness value is to 1.0, the greater likelihood the track contains no vocal content. Values above 0.5 are intended to represent instrumental tracks, but confidence is higher as the value approaches 1.0.<br/>
        /// Example: 0.00686
        /// </param>
        /// <param name="key">
        /// The key the track is in. Integers map to pitches using standard [Pitch Class notation](https://en.wikipedia.org/wiki/Pitch_class). E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on. If no key was detected, the value is -1.<br/>
        /// Example: 9
        /// </param>
        /// <param name="liveness">
        /// Detects the presence of an audience in the recording. Higher liveness values represent an increased probability that the track was performed live. A value above 0.8 provides strong likelihood that the track is live.<br/>
        /// Example: 0.0866
        /// </param>
        /// <param name="loudness">
        /// The overall loudness of a track in decibels (dB). Loudness values are averaged across the entire track and are useful for comparing relative loudness of tracks. Loudness is the quality of a sound that is the primary psychological correlate of physical strength (amplitude). Values typically range between -60 and 0 db.<br/>
        /// Example: -5.883
        /// </param>
        /// <param name="mode">
        /// Mode indicates the modality (major or minor) of a track, the type of scale from which its melodic content is derived. Major is represented by 1 and minor is 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="speechiness">
        /// Speechiness detects the presence of spoken words in a track. The more exclusively speech-like the recording (e.g. talk show, audio book, poetry), the closer to 1.0 the attribute value. Values above 0.66 describe tracks that are probably made entirely of spoken words. Values between 0.33 and 0.66 describe tracks that may contain both music and speech, either in sections or layered, including such cases as rap music. Values below 0.33 most likely represent music and other non-speech-like tracks.<br/>
        /// Example: 0.0556
        /// </param>
        /// <param name="tempo">
        /// The overall estimated tempo of a track in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.<br/>
        /// Example: 118.211
        /// </param>
        /// <param name="timeSignature">
        /// An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of "3/4", to "7/4".<br/>
        /// Example: 4
        /// </param>
        /// <param name="trackHref">
        /// A link to the Web API endpoint providing full details of the track.<br/>
        /// Example: https://api.spotify.com/v1/tracks/2takcwOaAZWiXQijPHIx7B
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
        /// <param name="uri">
        /// The Spotify URI for the track.<br/>
        /// Example: spotify:track:2takcwOaAZWiXQijPHIx7B
        /// </param>
        /// <param name="valence">
        /// A measure from 0.0 to 1.0 describing the musical positiveness conveyed by a track. Tracks with high valence sound more positive (e.g. happy, cheerful, euphoric), while tracks with low valence sound more negative (e.g. sad, depressed, angry).<br/>
        /// Example: 0.428
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioFeaturesObject(
            float? acousticness,
            string? analysisUrl,
            float? danceability,
            int? durationMs,
            float? energy,
            string? id,
            float? instrumentalness,
            int? key,
            float? liveness,
            float? loudness,
            int? mode,
            float? speechiness,
            float? tempo,
            int? timeSignature,
            string? trackHref,
            global::Spotify.AudioFeaturesObjectType? type,
            string? uri,
            float? valence)
        {
            this.Acousticness = acousticness;
            this.AnalysisUrl = analysisUrl;
            this.Danceability = danceability;
            this.DurationMs = durationMs;
            this.Energy = energy;
            this.Id = id;
            this.Instrumentalness = instrumentalness;
            this.Key = key;
            this.Liveness = liveness;
            this.Loudness = loudness;
            this.Mode = mode;
            this.Speechiness = speechiness;
            this.Tempo = tempo;
            this.TimeSignature = timeSignature;
            this.TrackHref = trackHref;
            this.Type = type;
            this.Uri = uri;
            this.Valence = valence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFeaturesObject" /> class.
        /// </summary>
        public AudioFeaturesObject()
        {
        }

    }
}