
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FollowersObject
    {
        /// <summary>
        /// This will always be set to null, as the Web API does not support it at the moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The total number of followers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowersObject" /> class.
        /// </summary>
        /// <param name="href">
        /// This will always be set to null, as the Web API does not support it at the moment.
        /// </param>
        /// <param name="total">
        /// The total number of followers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowersObject(
            string? href,
            int? total)
        {
            this.Href = href;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowersObject" /> class.
        /// </summary>
        public FollowersObject()
        {
        }

    }
}