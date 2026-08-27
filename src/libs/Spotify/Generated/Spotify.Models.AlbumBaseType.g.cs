
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum AlbumBaseType
    {
        /// <summary>
        ///
        /// </summary>
        Album,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlbumBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlbumBaseType value)
        {
            return value switch
            {
                AlbumBaseType.Album => "album",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlbumBaseType? ToEnum(string value)
        {
            return value switch
            {
                "album" => AlbumBaseType.Album,
                _ => null,
            };
        }
    }
}