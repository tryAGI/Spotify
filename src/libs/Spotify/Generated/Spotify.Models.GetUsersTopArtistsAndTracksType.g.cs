
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The type of entity to return. Valid values: `artists` or `tracks`
    /// </summary>
    public enum GetUsersTopArtistsAndTracksType
    {
        /// <summary>
        /// `artists` or `tracks`
        /// </summary>
        Artists,
        /// <summary>
        /// `artists` or `tracks`
        /// </summary>
        Tracks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersTopArtistsAndTracksTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersTopArtistsAndTracksType value)
        {
            return value switch
            {
                GetUsersTopArtistsAndTracksType.Artists => "artists",
                GetUsersTopArtistsAndTracksType.Tracks => "tracks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersTopArtistsAndTracksType? ToEnum(string value)
        {
            return value switch
            {
                "artists" => GetUsersTopArtistsAndTracksType.Artists,
                "tracks" => GetUsersTopArtistsAndTracksType.Tracks,
                _ => null,
            };
        }
    }
}