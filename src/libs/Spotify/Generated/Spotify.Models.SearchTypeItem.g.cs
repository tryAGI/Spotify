
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Album,
        /// <summary>
        /// 
        /// </summary>
        Artist,
        /// <summary>
        /// 
        /// </summary>
        Audiobook,
        /// <summary>
        /// 
        /// </summary>
        Episode,
        /// <summary>
        /// 
        /// </summary>
        Playlist,
        /// <summary>
        /// 
        /// </summary>
        Show,
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTypeItem value)
        {
            return value switch
            {
                SearchTypeItem.Album => "album",
                SearchTypeItem.Artist => "artist",
                SearchTypeItem.Audiobook => "audiobook",
                SearchTypeItem.Episode => "episode",
                SearchTypeItem.Playlist => "playlist",
                SearchTypeItem.Show => "show",
                SearchTypeItem.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "album" => SearchTypeItem.Album,
                "artist" => SearchTypeItem.Artist,
                "audiobook" => SearchTypeItem.Audiobook,
                "episode" => SearchTypeItem.Episode,
                "playlist" => SearchTypeItem.Playlist,
                "show" => SearchTypeItem.Show,
                "track" => SearchTypeItem.Track,
                _ => null,
            };
        }
    }
}