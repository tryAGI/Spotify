
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalIdObject
    {
        /// <summary>
        /// [International Standard Recording Code](http://en.wikipedia.org/wiki/International_Standard_Recording_Code)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isrc")]
        public string? Isrc { get; set; }

        /// <summary>
        /// [International Article Number](http://en.wikipedia.org/wiki/International_Article_Number_%28EAN%29)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ean")]
        public string? Ean { get; set; }

        /// <summary>
        /// [Universal Product Code](http://en.wikipedia.org/wiki/Universal_Product_Code)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upc")]
        public string? Upc { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalIdObject" /> class.
        /// </summary>
        /// <param name="isrc">
        /// [International Standard Recording Code](http://en.wikipedia.org/wiki/International_Standard_Recording_Code)
        /// </param>
        /// <param name="ean">
        /// [International Article Number](http://en.wikipedia.org/wiki/International_Article_Number_%28EAN%29)
        /// </param>
        /// <param name="upc">
        /// [Universal Product Code](http://en.wikipedia.org/wiki/Universal_Product_Code)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalIdObject(
            string? isrc,
            string? ean,
            string? upc)
        {
            this.Isrc = isrc;
            this.Ean = ean;
            this.Upc = upc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalIdObject" /> class.
        /// </summary>
        public ExternalIdObject()
        {
        }

    }
}