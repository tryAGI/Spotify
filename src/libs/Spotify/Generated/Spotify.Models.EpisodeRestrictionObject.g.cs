
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EpisodeRestrictionObject
    {
        /// <summary>
        /// The reason for the restriction. Supported values:<br/>
        /// - `market` - The content item is not available in the given market.<br/>
        /// - `product` - The content item is not available for the user's subscription type.<br/>
        /// - `explicit` - The content item is explicit and the user's account is set to not play explicit content.<br/>
        /// Additional reasons may be added in the future.<br/>
        /// **Note**: If you use this field, make sure that your application safely handles unknown values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeRestrictionObject" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason for the restriction. Supported values:<br/>
        /// - `market` - The content item is not available in the given market.<br/>
        /// - `product` - The content item is not available for the user's subscription type.<br/>
        /// - `explicit` - The content item is explicit and the user's account is set to not play explicit content.<br/>
        /// Additional reasons may be added in the future.<br/>
        /// **Note**: If you use this field, make sure that your application safely handles unknown values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EpisodeRestrictionObject(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeRestrictionObject" /> class.
        /// </summary>
        public EpisodeRestrictionObject()
        {
        }

    }
}