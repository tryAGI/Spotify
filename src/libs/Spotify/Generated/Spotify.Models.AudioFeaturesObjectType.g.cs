
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum AudioFeaturesObjectType
    {
        /// <summary>
        ///
        /// </summary>
        AudioFeatures,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFeaturesObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFeaturesObjectType value)
        {
            return value switch
            {
                AudioFeaturesObjectType.AudioFeatures => "audio_features",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFeaturesObjectType? ToEnum(string value)
        {
            return value switch
            {
                "audio_features" => AudioFeaturesObjectType.AudioFeatures,
                _ => null,
            };
        }
    }
}