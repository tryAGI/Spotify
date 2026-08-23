
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterBase
    {
        /// <summary>
        /// A URL to a 30 second preview (MP3 format) of the chapter. `null` if not available.<br/>
        /// Example: https://p.scdn.co/mp3-preview/2f37da1d4221f40b9d1a98cd191f4d6f1646ad17
        /// </summary>
        /// <example>https://p.scdn.co/mp3-preview/2f37da1d4221f40b9d1a98cd191f4d6f1646ad17</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_preview_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AudioPreviewUrl { get; set; }

        /// <summary>
        /// A list of the countries in which the chapter can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_markets")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? AvailableMarkets { get; set; }

        /// <summary>
        /// The number of the chapter<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChapterNumber { get; set; }

        /// <summary>
        /// A description of the chapter. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.<br/>
        /// Example: We kept on ascending, with occasional periods of quick descent, but in the main always ascending. Suddenly, I became conscious of the fact that the driver was in the act of pulling up the horses in the courtyard of a vast ruined castle, from whose tall black windows came no ray of light, and whose broken battlements showed a jagged line against the moonlit sky.
        /// </summary>
        /// <example>We kept on ascending, with occasional periods of quick descent, but in the main always ascending. Suddenly, I became conscious of the fact that the driver was in the act of pulling up the horses in the courtyard of a vast ruined castle, from whose tall black windows came no ray of light, and whose broken battlements showed a jagged line against the moonlit sky.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A description of the chapter. This field may contain HTML tags.<br/>
        /// Example: &lt;p&gt;We kept on ascending, with occasional periods of quick descent, but in the main always ascending. Suddenly, I became conscious of the fact that the driver was in the act of pulling up the horses in the courtyard of a vast ruined castle, from whose tall black windows came no ray of light, and whose broken battlements showed a jagged line against the moonlit sky.&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;We kept on ascending, with occasional periods of quick descent, but in the main always ascending. Suddenly, I became conscious of the fact that the driver was in the act of pulling up the horses in the courtyard of a vast ruined castle, from whose tall black windows came no ray of light, and whose broken battlements showed a jagged line against the moonlit sky.&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlDescription { get; set; }

        /// <summary>
        /// The chapter length in milliseconds.<br/>
        /// Example: 1686230
        /// </summary>
        /// <example>1686230</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// Whether or not the chapter has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Explicit { get; set; }

        /// <summary>
        /// External URLs for this chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the chapter.<br/>
        /// Example: https://api.spotify.com/v1/episodes/5Xt5DXGzch68nYYamXrNxZ
        /// </summary>
        /// <example>https://api.spotify.com/v1/episodes/5Xt5DXGzch68nYYamXrNxZ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the chapter.<br/>
        /// Example: 5Xt5DXGzch68nYYamXrNxZ
        /// </summary>
        /// <example>5Xt5DXGzch68nYYamXrNxZ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The cover art for the chapter in various sizes, widest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.ImageObject> Images { get; set; }

        /// <summary>
        /// True if the chapter is playable in the given market. Otherwise false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_playable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPlayable { get; set; }

        /// <summary>
        /// A list of the languages used in the chapter, identified by their [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639) code.<br/>
        /// Example: [fr, en]
        /// </summary>
        /// <example>[fr, en]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>
        /// The name of the chapter.<br/>
        /// Example: Starting Your Own Podcast: Tips, Tricks, and Advice From Anchor Creators
        /// </summary>
        /// <example>Starting Your Own Podcast: Tips, Tricks, and Advice From Anchor Creators</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The date the chapter was first released, for example `"1981-12-15"`. Depending on the precision, it might be shown as `"1981"` or `"1981-12"`.<br/>
        /// Example: 1981-12-15
        /// </summary>
        /// <example>1981-12-15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseDate { get; set; }

        /// <summary>
        /// The precision with which `release_date` value is known.<br/>
        /// Example: day
        /// </summary>
        /// <example>day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date_precision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.ChapterBaseReleaseDatePrecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.ChapterBaseReleaseDatePrecision ReleaseDatePrecision { get; set; }

        /// <summary>
        /// The user's most recent position in the chapter. Set if the supplied access token is a user token and has the scope 'user-read-playback-position'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_point")]
        public global::Spotify.ResumePointObject? ResumePoint { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.ChapterBaseTypeJsonConverter))]
        public global::Spotify.ChapterBaseType Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the chapter.<br/>
        /// Example: spotify:episode:0zLhl3WsOCQHbe1BPTiHgr
        /// </summary>
        /// <example>spotify:episode:0zLhl3WsOCQHbe1BPTiHgr</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Included in the response when a content restriction is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::Spotify.ChapterRestrictionObject? Restrictions { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterBase" /> class.
        /// </summary>
        /// <param name="chapterNumber">
        /// The number of the chapter<br/>
        /// Example: 1
        /// </param>
        /// <param name="description">
        /// A description of the chapter. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.<br/>
        /// Example: We kept on ascending, with occasional periods of quick descent, but in the main always ascending. Suddenly, I became conscious of the fact that the driver was in the act of pulling up the horses in the courtyard of a vast ruined castle, from whose tall black windows came no ray of light, and whose broken battlements showed a jagged line against the moonlit sky.
        /// </param>
        /// <param name="htmlDescription">
        /// A description of the chapter. This field may contain HTML tags.<br/>
        /// Example: &lt;p&gt;We kept on ascending, with occasional periods of quick descent, but in the main always ascending. Suddenly, I became conscious of the fact that the driver was in the act of pulling up the horses in the courtyard of a vast ruined castle, from whose tall black windows came no ray of light, and whose broken battlements showed a jagged line against the moonlit sky.&lt;/p&gt;
        /// </param>
        /// <param name="durationMs">
        /// The chapter length in milliseconds.<br/>
        /// Example: 1686230
        /// </param>
        /// <param name="explicit">
        /// Whether or not the chapter has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </param>
        /// <param name="externalUrls">
        /// External URLs for this chapter.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the chapter.<br/>
        /// Example: https://api.spotify.com/v1/episodes/5Xt5DXGzch68nYYamXrNxZ
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the chapter.<br/>
        /// Example: 5Xt5DXGzch68nYYamXrNxZ
        /// </param>
        /// <param name="images">
        /// The cover art for the chapter in various sizes, widest first.
        /// </param>
        /// <param name="isPlayable">
        /// True if the chapter is playable in the given market. Otherwise false.
        /// </param>
        /// <param name="languages">
        /// A list of the languages used in the chapter, identified by their [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639) code.<br/>
        /// Example: [fr, en]
        /// </param>
        /// <param name="name">
        /// The name of the chapter.<br/>
        /// Example: Starting Your Own Podcast: Tips, Tricks, and Advice From Anchor Creators
        /// </param>
        /// <param name="releaseDate">
        /// The date the chapter was first released, for example `"1981-12-15"`. Depending on the precision, it might be shown as `"1981"` or `"1981-12"`.<br/>
        /// Example: 1981-12-15
        /// </param>
        /// <param name="releaseDatePrecision">
        /// The precision with which `release_date` value is known.<br/>
        /// Example: day
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the chapter.<br/>
        /// Example: spotify:episode:0zLhl3WsOCQHbe1BPTiHgr
        /// </param>
        /// <param name="resumePoint">
        /// The user's most recent position in the chapter. Set if the supplied access token is a user token and has the scope 'user-read-playback-position'.
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
        /// <param name="restrictions">
        /// Included in the response when a content restriction is applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterBase(
            int chapterNumber,
            string description,
            string htmlDescription,
            int durationMs,
            bool @explicit,
            global::Spotify.ExternalUrlObject externalUrls,
            string href,
            string id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject> images,
            bool isPlayable,
            global::System.Collections.Generic.IList<string> languages,
            string name,
            string releaseDate,
            global::Spotify.ChapterBaseReleaseDatePrecision releaseDatePrecision,
            string uri,
            global::Spotify.ResumePointObject? resumePoint,
            global::Spotify.ChapterBaseType type,
            global::Spotify.ChapterRestrictionObject? restrictions)
        {
            this.ChapterNumber = chapterNumber;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HtmlDescription = htmlDescription ?? throw new global::System.ArgumentNullException(nameof(htmlDescription));
            this.DurationMs = durationMs;
            this.Explicit = @explicit;
            this.ExternalUrls = externalUrls ?? throw new global::System.ArgumentNullException(nameof(externalUrls));
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.IsPlayable = isPlayable;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ReleaseDate = releaseDate ?? throw new global::System.ArgumentNullException(nameof(releaseDate));
            this.ReleaseDatePrecision = releaseDatePrecision;
            this.ResumePoint = resumePoint;
            this.Type = type;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterBase" /> class.
        /// </summary>
        public ChapterBase()
        {
        }

    }
}