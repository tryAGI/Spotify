
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMultipleShowsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.SimplifiedShowObject> Shows { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleShowsResponse" /> class.
        /// </summary>
        /// <param name="shows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMultipleShowsResponse(
            global::System.Collections.Generic.IList<global::Spotify.SimplifiedShowObject> shows)
        {
            this.Shows = shows ?? throw new global::System.ArgumentNullException(nameof(shows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleShowsResponse" /> class.
        /// </summary>
        public GetMultipleShowsResponse()
        {
        }

    }
}