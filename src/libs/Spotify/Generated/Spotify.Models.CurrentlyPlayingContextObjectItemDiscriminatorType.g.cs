
#nullable enable

namespace Spotify
{
    /// <summary>
    /// 
    /// </summary>
    public enum CurrentlyPlayingContextObjectItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CurrentlyPlayingContextObjectItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CurrentlyPlayingContextObjectItemDiscriminatorType value)
        {
            return value switch
            {
                CurrentlyPlayingContextObjectItemDiscriminatorType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CurrentlyPlayingContextObjectItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "track" => CurrentlyPlayingContextObjectItemDiscriminatorType.Track,
                _ => null,
            };
        }
    }
}