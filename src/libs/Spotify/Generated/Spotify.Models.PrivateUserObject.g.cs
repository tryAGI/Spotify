
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateUserObject
    {
        /// <summary>
        /// A public, immutable, pseudoanonymous identifier for the user's account. Use this field for account linking rather than the `id` field, as it is stable and will not change over the lifetime of the account.<br/>
        /// Example: aB3dE5fG7h
        /// </summary>
        /// <example>aB3dE5fG7h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The country of the user, as set in the user's account profile. An [ISO 3166-1 alpha-2 country code](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _This field is only available when the current user has granted access to the [user-read-private](/documentation/web-api/concepts/scopes/#list-of-scopes) scope._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Country { get; set; }

        /// <summary>
        /// The name displayed on the user's profile. `null` if not available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The user's email address, as entered by the user when creating their account. _**Important!** This email address is unverified; there is no proof that it actually belongs to the user._ _This field is only available when the current user has granted access to the [user-read-email](/documentation/web-api/concepts/scopes/#list-of-scopes) scope._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Email { get; set; }

        /// <summary>
        /// The user's explicit content settings. _This field is only available when the current user has granted access to the [user-read-private](/documentation/web-api/concepts/scopes/#list-of-scopes) scope._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit_content")]
        public global::Spotify.ExplicitContentSettingsObject? ExplicitContent { get; set; }

        /// <summary>
        /// Known external URLs for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_urls")]
        public global::Spotify.ExternalUrlObject? ExternalUrls { get; set; }

        /// <summary>
        /// Information about the followers of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        public global::Spotify.FollowersObject? Followers { get; set; }

        /// <summary>
        /// A link to the Web API endpoint for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The [Spotify user ID](/documentation/web-api/concepts/spotify-uris-ids) for the user. Do not use this field for account linking — use `account_id` instead, which is immutable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The user's profile image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Spotify.ImageObject>? Images { get; set; }

        /// <summary>
        /// The user's Spotify subscription level: "premium", "free", etc. (The subscription level "open" can be considered the same as "free".) _This field is only available when the current user has granted access to the [user-read-private](/documentation/web-api/concepts/scopes/#list-of-scopes) scope._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Product { get; set; }

        /// <summary>
        /// The object type: "user"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserObject" /> class.
        /// </summary>
        /// <param name="accountId">
        /// A public, immutable, pseudoanonymous identifier for the user's account. Use this field for account linking rather than the `id` field, as it is stable and will not change over the lifetime of the account.<br/>
        /// Example: aB3dE5fG7h
        /// </param>
        /// <param name="displayName">
        /// The name displayed on the user's profile. `null` if not available.
        /// </param>
        /// <param name="externalUrls">
        /// Known external URLs for this user.
        /// </param>
        /// <param name="href">
        /// A link to the Web API endpoint for this user.
        /// </param>
        /// <param name="id">
        /// The [Spotify user ID](/documentation/web-api/concepts/spotify-uris-ids) for the user. Do not use this field for account linking — use `account_id` instead, which is immutable.
        /// </param>
        /// <param name="images">
        /// The user's profile image.
        /// </param>
        /// <param name="type">
        /// The object type: "user"
        /// </param>
        /// <param name="uri">
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateUserObject(
            string? accountId,
            string? displayName,
            global::Spotify.ExternalUrlObject? externalUrls,
            string? href,
            string? id,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject>? images,
            string? type,
            string? uri)
        {
            this.AccountId = accountId;
            this.DisplayName = displayName;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserObject" /> class.
        /// </summary>
        public PrivateUserObject()
        {
        }

    }
}