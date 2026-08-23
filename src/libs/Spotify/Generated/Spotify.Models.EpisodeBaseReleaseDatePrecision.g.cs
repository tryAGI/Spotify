
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The precision with which `release_date` value is known.<br/>
    /// Example: day
    /// </summary>
    public enum EpisodeBaseReleaseDatePrecision
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
    public static class EpisodeBaseReleaseDatePrecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EpisodeBaseReleaseDatePrecision value)
        {
            return value switch
            {
                EpisodeBaseReleaseDatePrecision.Day => "day",
                EpisodeBaseReleaseDatePrecision.Month => "month",
                EpisodeBaseReleaseDatePrecision.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EpisodeBaseReleaseDatePrecision? ToEnum(string value)
        {
            return value switch
            {
                "day" => EpisodeBaseReleaseDatePrecision.Day,
                "month" => EpisodeBaseReleaseDatePrecision.Month,
                "year" => EpisodeBaseReleaseDatePrecision.Year,
                _ => null,
            };
        }
    }
}