
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueueObjectCurrentlyPlayingDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueObjectCurrentlyPlayingDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueObjectCurrentlyPlayingDiscriminatorType value)
        {
            return value switch
            {
                QueueObjectCurrentlyPlayingDiscriminatorType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueObjectCurrentlyPlayingDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "track" => QueueObjectCurrentlyPlayingDiscriminatorType.Track,
                _ => null,
            };
        }
    }
}