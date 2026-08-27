
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsersTopArtistsAndTracksResponseItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Artist,
        /// <summary>
        ///
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersTopArtistsAndTracksResponseItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersTopArtistsAndTracksResponseItemDiscriminatorType value)
        {
            return value switch
            {
                GetUsersTopArtistsAndTracksResponseItemDiscriminatorType.Artist => "artist",
                GetUsersTopArtistsAndTracksResponseItemDiscriminatorType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersTopArtistsAndTracksResponseItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => GetUsersTopArtistsAndTracksResponseItemDiscriminatorType.Artist,
                "track" => GetUsersTopArtistsAndTracksResponseItemDiscriminatorType.Track,
                _ => null,
            };
        }
    }
}