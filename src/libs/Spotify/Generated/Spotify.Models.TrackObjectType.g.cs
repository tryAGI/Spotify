
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type: "track".
    /// </summary>
    public enum TrackObjectType
    {
        /// <summary>
        /// "track".
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackObjectType value)
        {
            return value switch
            {
                TrackObjectType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackObjectType? ToEnum(string value)
        {
            return value switch
            {
                "track" => TrackObjectType.Track,
                _ => null,
            };
        }
    }
}