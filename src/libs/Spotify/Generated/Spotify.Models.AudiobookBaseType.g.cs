
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum AudiobookBaseType
    {
        /// <summary>
        ///
        /// </summary>
        Audiobook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudiobookBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudiobookBaseType value)
        {
            return value switch
            {
                AudiobookBaseType.Audiobook => "audiobook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudiobookBaseType? ToEnum(string value)
        {
            return value switch
            {
                "audiobook" => AudiobookBaseType.Audiobook,
                _ => null,
            };
        }
    }
}