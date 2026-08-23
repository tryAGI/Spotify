
#nullable enable

namespace Spotify
{
    /// <summary>
    /// Optional. Indicates from where in the context playback should start. Only available when context_uri corresponds to an album or playlist object<br/>
    /// "position" is zero based and can’t be negative. Example: `"offset": {"position": 5}`<br/>
    /// "uri" is a string representing the uri of the item to start at. Example: `"offset": {"uri": "spotify:track:1301WleyT98MSxVHPZCA6M"}`
    /// </summary>
    public sealed partial class StartAUsersPlaybackRequestOffset
    {

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

    }
}