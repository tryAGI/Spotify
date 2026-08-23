
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The ID type: either `artist` or `user`.<br/>
    /// Example: artist
    /// </summary>
    public enum UnfollowArtistsUsersType
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
    public static class UnfollowArtistsUsersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfollowArtistsUsersType value)
        {
            return value switch
            {
                UnfollowArtistsUsersType.Artist => "artist",
                UnfollowArtistsUsersType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfollowArtistsUsersType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => UnfollowArtistsUsersType.Artist,
                "user" => UnfollowArtistsUsersType.User,
                _ => null,
            };
        }
    }
}