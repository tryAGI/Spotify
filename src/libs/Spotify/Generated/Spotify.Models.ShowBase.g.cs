
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ShowBase
    {
        /// <summary>
        /// A list of the countries in which the show can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_markets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableMarkets { get; set; }

        /// <summary>
        /// The copyright statements of the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyrights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.CopyrightObject> Copyrights { get; set; }

        /// <summary>
        /// A description of the show. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A description of the show. This field may contain HTML tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlDescription { get; set; }

        /// <summary>
        /// Whether or not the show has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Explicit { get; set; }

        /// <summary>
        /// External URLs for this show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The cover art for the show in various sizes, widest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.ImageObject> Images { get; set; }

        /// <summary>
        /// True if all of the shows episodes are hosted outside of Spotify's CDN. This field might be `null` in some cases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_externally_hosted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsExternallyHosted { get; set; }

        /// <summary>
        /// A list of the languages used in the show, identified by their [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>
        /// The media type of the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// The name of the episode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The publisher of the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisher")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Publisher { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.ShowBaseTypeJsonConverter))]
        public global::Spotify.ShowBaseType Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// The total number of episodes in the show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_episodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEpisodes { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowBase" /> class.
        /// </summary>
        /// <param name="availableMarkets">
        /// A list of the countries in which the show can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </param>
        /// <param name="copyrights">
        /// The copyright statements of the show.
        /// </param>
        /// <param name="description">
        /// A description of the show. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.
        /// </param>
        /// <param name="htmlDescription">
        /// A description of the show. This field may contain HTML tags.
        /// </param>
        /// <param name="explicit">
        /// Whether or not the show has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </param>
        /// <param name="externalUrls">
        /// External URLs for this show.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint providing full details of the show.
        /// </param>
        /// <param name="id">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the show.
        /// </param>
        /// <param name="images">
        /// The cover art for the show in various sizes, widest first.
        /// </param>
        /// <param name="isExternallyHosted">
        /// True if all of the shows episodes are hosted outside of Spotify's CDN. This field might be `null` in some cases.
        /// </param>
        /// <param name="languages">
        /// A list of the languages used in the show, identified by their [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code.
        /// </param>
        /// <param name="mediaType">
        /// The media type of the show.
        /// </param>
        /// <param name="name">
        /// The name of the episode.
        /// </param>
        /// <param name="publisher">
        /// The publisher of the show.
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the show.
        /// </param>
        /// <param name="totalEpisodes">
        /// The total number of episodes in the show.
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShowBase(
            global::System.Collections.Generic.IList<string> availableMarkets,
            global::System.Collections.Generic.IList<global::Spotify.CopyrightObject> copyrights,
            string description,
            string htmlDescription,
            bool @explicit,
            global::Spotify.ExternalUrlObject externalUrls,
            string href,
            string id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject> images,
            bool isExternallyHosted,
            global::System.Collections.Generic.IList<string> languages,
            string mediaType,
            string name,
            string publisher,
            string uri,
            int totalEpisodes,
            global::Spotify.ShowBaseType type)
        {
            this.AvailableMarkets = availableMarkets ?? throw new global::System.ArgumentNullException(nameof(availableMarkets));
            this.Copyrights = copyrights ?? throw new global::System.ArgumentNullException(nameof(copyrights));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HtmlDescription = htmlDescription ?? throw new global::System.ArgumentNullException(nameof(htmlDescription));
            this.Explicit = @explicit;
            this.ExternalUrls = externalUrls ?? throw new global::System.ArgumentNullException(nameof(externalUrls));
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.IsExternallyHosted = isExternallyHosted;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Publisher = publisher ?? throw new global::System.ArgumentNullException(nameof(publisher));
            this.Type = type;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.TotalEpisodes = totalEpisodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowBase" /> class.
        /// </summary>
        public ShowBase()
        {
        }

    }
}