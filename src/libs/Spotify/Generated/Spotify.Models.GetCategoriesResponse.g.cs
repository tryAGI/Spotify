
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCategoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Spotify.JsonConverters.AllOfJsonConverter<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2> Categories { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoriesResponse" /> class.
        /// </summary>
        /// <param name="categories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCategoriesResponse(
            global::Spotify.AllOf<global::Spotify.PagingObject, global::Spotify.GetCategoriesResponseCategories2> categories)
        {
            this.Categories = categories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoriesResponse" /> class.
        /// </summary>
        public GetCategoriesResponse()
        {
        }

    }
}