
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The precision with which `release_date` value is known.<br/>
    /// Example: year
    /// </summary>
    public enum AlbumBaseReleaseDatePrecision
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlbumBaseReleaseDatePrecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlbumBaseReleaseDatePrecision value)
        {
            return value switch
            {
                AlbumBaseReleaseDatePrecision.Day => "day",
                AlbumBaseReleaseDatePrecision.Month => "month",
                AlbumBaseReleaseDatePrecision.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlbumBaseReleaseDatePrecision? ToEnum(string value)
        {
            return value switch
            {
                "day" => AlbumBaseReleaseDatePrecision.Day,
                "month" => AlbumBaseReleaseDatePrecision.Month,
                "year" => AlbumBaseReleaseDatePrecision.Year,
                _ => null,
            };
        }
    }
}