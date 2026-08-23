
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicUserObject
    {
        /// <summary>
        /// The name displayed on the user's profile. `null` if not available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Known public external URLs for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// Information about the followers of this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        public global::Spotify.FollowersObject? Followers { get; set; }

        /// <summary>
        /// A link to the Web API endpoint for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The [Spotify user ID](/documentation/web-api/concepts/spotify-uris-ids) for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The user's profile image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Spotify.ImageObject>? Images { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.PublicUserObjectTypeJsonConverter))]
        public global::Spotify.PublicUserObjectType? Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUserObject" /> class.
        /// </summary>
        /// <param name="displayName">
        /// The name displayed on the user's profile. `null` if not available.
        /// </param>
        /// <param name="externalUrls">
        /// Known public external URLs for this user.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint for this user.
        /// </param>
        /// <param name="id">
        /// The [Spotify user ID](/documentation/web-api/concepts/spotify-uris-ids) for this user.
        /// </param>
        /// <param name="images">
        /// The user's profile image.
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for this user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicUserObject(
            string? displayName,
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject>? images,
            global::Spotify.PublicUserObjectType? type,
            string? uri)
        {
            this.DisplayName = displayName;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUserObject" /> class.
        /// </summary>
        public PublicUserObject()
        {
        }

    }
}