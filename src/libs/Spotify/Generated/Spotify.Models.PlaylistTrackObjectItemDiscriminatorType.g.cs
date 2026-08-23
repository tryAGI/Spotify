
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaylistTrackObjectItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaylistTrackObjectItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaylistTrackObjectItemDiscriminatorType value)
        {
            return value switch
            {
                PlaylistTrackObjectItemDiscriminatorType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaylistTrackObjectItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "track" => PlaylistTrackObjectItemDiscriminatorType.Track,
                _ => null,
            };
        }
    }
}