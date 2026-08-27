
#nullable enable

namespace Spotify
{
    /// <summary>
    /// This field describes the relationship between the artist and the album.<br/>
    /// Example: compilation
    /// </summary>
    public enum ArtistDiscographyAlbumObjectVariant2AlbumGroup
    {
        /// <summary>
        ///
        /// </summary>
        Album,
        /// <summary>
        ///
        /// </summary>
        AppearsOn,
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
    public static class ArtistDiscographyAlbumObjectVariant2AlbumGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtistDiscographyAlbumObjectVariant2AlbumGroup value)
        {
            return value switch
            {
                ArtistDiscographyAlbumObjectVariant2AlbumGroup.Album => "album",
                ArtistDiscographyAlbumObjectVariant2AlbumGroup.AppearsOn => "appears_on",
                ArtistDiscographyAlbumObjectVariant2AlbumGroup.Compilation => "compilation",
                ArtistDiscographyAlbumObjectVariant2AlbumGroup.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtistDiscographyAlbumObjectVariant2AlbumGroup? ToEnum(string value)
        {
            return value switch
            {
                "album" => ArtistDiscographyAlbumObjectVariant2AlbumGroup.Album,
                "appears_on" => ArtistDiscographyAlbumObjectVariant2AlbumGroup.AppearsOn,
                "compilation" => ArtistDiscographyAlbumObjectVariant2AlbumGroup.Compilation,
                "single" => ArtistDiscographyAlbumObjectVariant2AlbumGroup.Single,
                _ => null,
            };
        }
    }
}