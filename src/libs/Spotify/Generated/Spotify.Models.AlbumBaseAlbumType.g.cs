
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The type of the album.<br/>
    /// Example: compilation
    /// </summary>
    public enum AlbumBaseAlbumType
    {
        /// <summary>
        ///
        /// </summary>
        Album,
        /// <summary>
        ///
        /// </summary>
        Compilation,
        /// <summary>
        ///
        /// </summary>
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlbumBaseAlbumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlbumBaseAlbumType value)
        {
            return value switch
            {
                AlbumBaseAlbumType.Album => "album",
                AlbumBaseAlbumType.Compilation => "compilation",
                AlbumBaseAlbumType.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlbumBaseAlbumType? ToEnum(string value)
        {
            return value switch
            {
                "album" => AlbumBaseAlbumType.Album,
                "compilation" => AlbumBaseAlbumType.Compilation,
                "single" => AlbumBaseAlbumType.Single,
                _ => null,
            };
        }
    }
}