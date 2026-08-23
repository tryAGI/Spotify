
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagingPlaylistObjectVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Spotify.SimplifiedPlaylistObject>? Items { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingPlaylistObjectVariant2" /> class.
        /// </summary>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagingPlaylistObjectVariant2(
            global::System.Collections.Generic.IList<global::Spotify.SimplifiedPlaylistObject>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingPlaylistObjectVariant2" /> class.
        /// </summary>
        public PagingPlaylistObjectVariant2()
        {
        }

    }
}