
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CursorObject
    {
        /// <summary>
        /// The cursor to use as key to find the next page of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        /// The cursor to use as key to find the previous page of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        public string? Before { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorObject" /> class.
        /// </summary>
        /// <param name="after">
        /// The cursor to use as key to find the next page of items.
        /// </param>
        /// <param name="before">
        /// The cursor to use as key to find the previous page of items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CursorObject(
            string? after,
            string? before)
        {
            this.After = after;
            this.Before = before;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorObject" /> class.
        /// </summary>
        public CursorObject()
        {
        }

    }
}