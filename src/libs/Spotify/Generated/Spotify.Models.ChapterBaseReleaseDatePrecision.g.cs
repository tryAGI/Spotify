
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The precision with which `release_date` value is known.<br/>
    /// Example: day
    /// </summary>
    public enum ChapterBaseReleaseDatePrecision
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
    public static class ChapterBaseReleaseDatePrecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterBaseReleaseDatePrecision value)
        {
            return value switch
            {
                ChapterBaseReleaseDatePrecision.Day => "day",
                ChapterBaseReleaseDatePrecision.Month => "month",
                ChapterBaseReleaseDatePrecision.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterBaseReleaseDatePrecision? ToEnum(string value)
        {
            return value switch
            {
                "day" => ChapterBaseReleaseDatePrecision.Day,
                "month" => ChapterBaseReleaseDatePrecision.Month,
                "year" => ChapterBaseReleaseDatePrecision.Year,
                _ => null,
            };
        }
    }
}