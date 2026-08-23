
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageObject
    {
        /// <summary>
        /// The source URL of the image.<br/>
        /// Example: https://i.scdn.co/image/ab67616d00001e02ff9ca10b55ce82ae553c8228
        /// </summary>
        /// <example>https://i.scdn.co/image/ab67616d00001e02ff9ca10b55ce82ae553c8228</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The image height in pixels.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The image width in pixels.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageObject" /> class.
        /// </summary>
        /// <param name="url">
        /// The source URL of the image.<br/>
        /// Example: https://i.scdn.co/image/ab67616d00001e02ff9ca10b55ce82ae553c8228
        /// </param>
        /// <param name="height">
        /// The image height in pixels.<br/>
        /// Example: 300
        /// </param>
        /// <param name="width">
        /// The image width in pixels.<br/>
        /// Example: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageObject(
            string url,
            int? height,
            int? width)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageObject" /> class.
        /// </summary>
        public ImageObject()
        {
        }

    }
}