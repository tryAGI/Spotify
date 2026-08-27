
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PagingObject
    {
        /// <summary>
        /// A link to the Web API endpoint returning the full result of the request<br/>
        /// Example: https://api.spotify.com/v1/me/shows?offset=0&amp;limit=20
        /// </summary>
        /// <example>https://api.spotify.com/v1/me/shows?offset=0&amp;limit=20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// The maximum number of items in the response (as set in the query or by default).<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// URL to the next page of items. ( `null` if none)<br/>
        /// Example: https://api.spotify.com/v1/me/shows?offset=1&amp;limit=1
        /// </summary>
        /// <example>https://api.spotify.com/v1/me/shows?offset=1&amp;limit=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The offset of the items returned (as set in the query or by default)<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// URL to the previous page of items. ( `null` if none)<br/>
        /// Example: https://api.spotify.com/v1/me/shows?offset=1&amp;limit=1
        /// </summary>
        /// <example>https://api.spotify.com/v1/me/shows?offset=1&amp;limit=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// The total number of items available to return.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingObject" /> class.
        /// </summary>
        /// <param name="href">
        /// A link to the Web API endpoint returning the full result of the request<br/>
        /// Example: https://api.spotify.com/v1/me/shows?offset=0&amp;limit=20
        /// </param>
        /// <param name="limit">
        /// The maximum number of items in the response (as set in the query or by default).<br/>
        /// Example: 20
        /// </param>
        /// <param name="offset">
        /// The offset of the items returned (as set in the query or by default)<br/>
        /// Example: 0
        /// </param>
        /// <param name="total">
        /// The total number of items available to return.<br/>
        /// Example: 4
        /// </param>
        /// <param name="next">
        /// URL to the next page of items. ( `null` if none)<br/>
        /// Example: https://api.spotify.com/v1/me/shows?offset=1&amp;limit=1
        /// </param>
        /// <param name="previous">
        /// URL to the previous page of items. ( `null` if none)<br/>
        /// Example: https://api.spotify.com/v1/me/shows?offset=1&amp;limit=1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagingObject(
            string href,
            int limit,
            int offset,
            int total,
            string? next,
            string? previous)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Limit = limit;
            this.Next = next;
            this.Offset = offset;
            this.Previous = previous;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingObject" /> class.
        /// </summary>
        public PagingObject()
        {
        }

    }
}