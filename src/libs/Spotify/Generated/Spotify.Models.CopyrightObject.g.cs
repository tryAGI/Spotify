
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopyrightObject
    {
        /// <summary>
        /// The copyright text for this content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The type of copyright: `C` = the copyright, `P` = the sound recording (performance) copyright.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyrightObject" /> class.
        /// </summary>
        /// <param name="text">
        /// The copyright text for this content.
        /// </param>
        /// <param name="type">
        /// The type of copyright: `C` = the copyright, `P` = the sound recording (performance) copyright.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopyrightObject(
            string? text,
            string? type)
        {
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyrightObject" /> class.
        /// </summary>
        public CopyrightObject()
        {
        }

    }
}