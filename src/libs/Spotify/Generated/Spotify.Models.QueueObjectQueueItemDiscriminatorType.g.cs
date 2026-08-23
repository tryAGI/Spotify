
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueueObjectQueueItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueObjectQueueItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueObjectQueueItemDiscriminatorType value)
        {
            return value switch
            {
                QueueObjectQueueItemDiscriminatorType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueObjectQueueItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "track" => QueueObjectQueueItemDiscriminatorType.Track,
                _ => null,
            };
        }
    }
}