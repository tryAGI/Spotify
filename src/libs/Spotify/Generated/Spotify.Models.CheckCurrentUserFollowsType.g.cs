
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The ID type: either `artist` or `user`.<br/>
    /// Example: artist
    /// </summary>
    public enum CheckCurrentUserFollowsType
    {
        /// <summary>
        /// either `artist` or `user`.
        /// </summary>
        Artist,
        /// <summary>
        /// either `artist` or `user`.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckCurrentUserFollowsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckCurrentUserFollowsType value)
        {
            return value switch
            {
                CheckCurrentUserFollowsType.Artist => "artist",
                CheckCurrentUserFollowsType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckCurrentUserFollowsType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => CheckCurrentUserFollowsType.Artist,
                "user" => CheckCurrentUserFollowsType.User,
                _ => null,
            };
        }
    }
}