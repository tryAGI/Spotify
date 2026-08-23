
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoryObject
    {
        /// <summary>
        /// A link to the Web API endpoint returning full details of the category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// The category icon, in various sizes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.ImageObject> Icons { get; set; }

        /// <summary>
        /// The [Spotify category ID](/documentation/web-api/concepts/spotify-uris-ids) of the category.<br/>
        /// Example: equal
        /// </summary>
        /// <example>equal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the category.<br/>
        /// Example: EQUAL
        /// </summary>
        /// <example>EQUAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryObject" /> class.
        /// </summary>
        /// <param name="href">
        /// A link to the Web API endpoint returning full details of the category.
        /// </param>
        /// <param name="icons">
        /// The category icon, in various sizes.
        /// </param>
        /// <param name="id">
        /// The [Spotify category ID](/documentation/web-api/concepts/spotify-uris-ids) of the category.<br/>
        /// Example: equal
        /// </param>
        /// <param name="name">
        /// The name of the category.<br/>
        /// Example: EQUAL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoryObject(
            string href,
            global::System.Collections.Generic.IList<global::Spotify.ImageObject> icons,
            string id,
            string name)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Icons = icons ?? throw new global::System.ArgumentNullException(nameof(icons));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryObject" /> class.
        /// </summary>
        public CategoryObject()
        {
        }

    }
}