
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The ID type: currently only `artist` is supported.<br/>
    /// Example: artist
    /// </summary>
    public enum GetFollowedType
    {
        /// <summary>
        /// currently only `artist` is supported.
        /// </summary>
        Artist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFollowedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFollowedType value)
        {
            return value switch
            {
                GetFollowedType.Artist => "artist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFollowedType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => GetFollowedType.Artist,
                _ => null,
            };
        }
    }
}