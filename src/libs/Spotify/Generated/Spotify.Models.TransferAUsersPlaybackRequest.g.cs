
#nullable enable

namespace Spotify
{
    /// <summary>
    /// Example: {"device_ids":["74ASZWbe4lXaubB36ztrGX"]}
    /// </summary>
    public sealed partial class TransferAUsersPlaybackRequest
    {
        /// <summary>
        /// A JSON array containing the ID of the device on which playback should be started/transferred.&lt;br/&gt;For example:`{device_ids:["74ASZWbe4lXaubB36ztrGX"]}`&lt;br/&gt;_**Note**: Although an array is accepted, only a single device_id is currently supported. Supplying more than one will return `400 Bad Request`_
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DeviceIds { get; set; }

        /// <summary>
        /// **true**: ensure playback happens on new device.&lt;br/&gt;**false** or not provided: keep the current playback state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play")]
        public bool? Play { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAUsersPlaybackRequest" /> class.
        /// </summary>
        /// <param name="deviceIds">
        /// A JSON array containing the ID of the device on which playback should be started/transferred.&lt;br/&gt;For example:`{device_ids:["74ASZWbe4lXaubB36ztrGX"]}`&lt;br/&gt;_**Note**: Although an array is accepted, only a single device_id is currently supported. Supplying more than one will return `400 Bad Request`_
        /// </param>
        /// <param name="play">
        /// **true**: ensure playback happens on new device.&lt;br/&gt;**false** or not provided: keep the current playback state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferAUsersPlaybackRequest(
            global::System.Collections.Generic.IList<string> deviceIds,
            bool? play)
        {
            this.DeviceIds = deviceIds ?? throw new global::System.ArgumentNullException(nameof(deviceIds));
            this.Play = play;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAUsersPlaybackRequest" /> class.
        /// </summary>
        public TransferAUsersPlaybackRequest()
        {
        }

    }
}