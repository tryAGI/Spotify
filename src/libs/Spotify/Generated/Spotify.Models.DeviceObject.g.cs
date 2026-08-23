
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeviceObject
    {
        /// <summary>
        /// The device ID. This ID is unique and persistent to some extent. However, this is not guaranteed and any cached `device_id` should periodically be cleared out and refetched as necessary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// If this device is the currently active device.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// If this device is currently in a private session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_private_session")]
        public bool? IsPrivateSession { get; set; }

        /// <summary>
        /// Whether controlling this device is restricted. At present if this is "true" then no Web API commands will be accepted by this device.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_restricted")]
        public bool? IsRestricted { get; set; }

        /// <summary>
        /// A human-readable name for the device. Some devices have a name that the user can configure (e.g. \"Loudest speaker\") and some devices have a generic name associated with the manufacturer or device model.<br/>
        /// Example: Kitchen speaker
        /// </summary>
        /// <example>Kitchen speaker</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Device type, such as "computer", "smartphone" or "speaker".<br/>
        /// Example: computer
        /// </summary>
        /// <example>computer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The current volume in percent.<br/>
        /// Example: 59
        /// </summary>
        /// <example>59</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_percent")]
        public int? VolumePercent { get; set; }

        /// <summary>
        /// If this device can be used to set the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_volume")]
        public bool? SupportsVolume { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The device ID. This ID is unique and persistent to some extent. However, this is not guaranteed and any cached `device_id` should periodically be cleared out and refetched as necessary.
        /// </param>
        /// <param name="isActive">
        /// If this device is the currently active device.
        /// </param>
        /// <param name="isPrivateSession">
        /// If this device is currently in a private session.
        /// </param>
        /// <param name="isRestricted">
        /// Whether controlling this device is restricted. At present if this is "true" then no Web API commands will be accepted by this device.
        /// </param>
        /// <param name="name">
        /// A human-readable name for the device. Some devices have a name that the user can configure (e.g. \"Loudest speaker\") and some devices have a generic name associated with the manufacturer or device model.<br/>
        /// Example: Kitchen speaker
        /// </param>
        /// <param name="type">
        /// Device type, such as "computer", "smartphone" or "speaker".<br/>
        /// Example: computer
        /// </param>
        /// <param name="volumePercent">
        /// The current volume in percent.<br/>
        /// Example: 59
        /// </param>
        /// <param name="supportsVolume">
        /// If this device can be used to set the volume.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeviceObject(
            string? id,
            bool? isActive,
            bool? isPrivateSession,
            bool? isRestricted,
            string? name,
            string? type,
            int? volumePercent,
            bool? supportsVolume)
        {
            this.Id = id;
            this.IsActive = isActive;
            this.IsPrivateSession = isPrivateSession;
            this.IsRestricted = isRestricted;
            this.Name = name;
            this.Type = type;
            this.VolumePercent = volumePercent;
            this.SupportsVolume = supportsVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceObject" /> class.
        /// </summary>
        public DeviceObject()
        {
        }

    }
}