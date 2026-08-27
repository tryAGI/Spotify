
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum SimplifiedArtistObjectType
    {
        /// <summary>
        ///
        /// </summary>
        Artist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimplifiedArtistObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimplifiedArtistObjectType value)
        {
            return value switch
            {
                SimplifiedArtistObjectType.Artist => "artist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimplifiedArtistObjectType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => SimplifiedArtistObjectType.Artist,
                _ => null,
            };
        }
    }
}