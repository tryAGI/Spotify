
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The ID type.<br/>
    /// Example: artist
    /// </summary>
    public enum FollowArtistsUsersType
    {
        /// <summary>
        ///
        /// </summary>
        Artist,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FollowArtistsUsersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FollowArtistsUsersType value)
        {
            return value switch
            {
                FollowArtistsUsersType.Artist => "artist",
                FollowArtistsUsersType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FollowArtistsUsersType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => FollowArtistsUsersType.Artist,
                "user" => FollowArtistsUsersType.User,
                _ => null,
            };
        }
    }
}