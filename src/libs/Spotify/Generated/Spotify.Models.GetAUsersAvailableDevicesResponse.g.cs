
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAUsersAvailableDevicesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Spotify.DeviceObject> Devices { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAUsersAvailableDevicesResponse" /> class.
        /// </summary>
        /// <param name="devices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAUsersAvailableDevicesResponse(
            global::System.Collections.Generic.IList<global::Spotify.DeviceObject> devices)
        {
            this.Devices = devices ?? throw new global::System.ArgumentNullException(nameof(devices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAUsersAvailableDevicesResponse" /> class.
        /// </summary>
        public GetAUsersAvailableDevicesResponse()
        {
        }

    }
}