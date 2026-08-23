
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum ArtistObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Artist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtistObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtistObjectType value)
        {
            return value switch
            {
                ArtistObjectType.Artist => "artist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtistObjectType? ToEnum(string value)
        {
            return value switch
            {
                "artist" => ArtistObjectType.Artist,
                _ => null,
            };
        }
    }
}