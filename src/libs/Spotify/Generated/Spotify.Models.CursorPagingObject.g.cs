
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CursorPagingObject
    {
        /// <summary>
        /// A link to the Web API endpoint returning the full result of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The maximum number of items in the response (as set in the query or by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// URL to the next page of items. ( `null` if none)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The cursors used to find the next set of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursors")]
        public global::Spotify.CursorObject? Cursors { get; set; }

        /// <summary>
        /// The total number of items available to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPagingObject" /> class.
        /// </summary>
        /// <param name="href">
        /// A link to the Web API endpoint returning the full result of the request.
        /// </param>
        /// <param name="limit">
        /// The maximum number of items in the response (as set in the query or by default).
        /// </param>
        /// <param name="next">
        /// URL to the next page of items. ( `null` if none)
        /// </param>
        /// <param name="cursors">
        /// The cursors used to find the next set of items.
        /// </param>
        /// <param name="total">
        /// The total number of items available to return.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CursorPagingObject(
            string? href,
            int? limit,
            string? next,
            global::Spotify.CursorObject? cursors,
            int? total)
        {
            this.Href = href;
            this.Limit = limit;
            this.Next = next;
            this.Cursors = cursors;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPagingObject" /> class.
        /// </summary>
        public CursorPagingObject()
        {
        }

    }
}